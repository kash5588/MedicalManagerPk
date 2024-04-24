Imports System.Data.SqlClient
Public Class PostBillingData


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPostBillingByDate.Click
        Dim retval As Integer
        Try
            Dim pieces() As String
            Dim IndexOf As Integer
            Dim sAction As String
            sAction = "ExportBillingData"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)
            If IndexOf <> -1 Then
            Else
                MessageBox.Show("You are not authorized to export billing data.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Me.ExportToMMCaseAndTransactionCOMMITROLLBACKNewTableAdapter.Fill(Me.MMDataDataSet1.ExportToMMCaseAndTransactionCOMMITROLLBACKNew, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)))
            lblCasesPosted.Text = "Post to billing complete."
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnPostBillingByCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPostBillingByCase.Click
        PostBillingByCase(txtCaseNumber.Text)
    End Sub

    Private Sub PostBillingData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '     LoadMMChartVisit()
    End Sub

    Private Function LoadMMChartVisit()
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        Dim cmd As New SqlCommand("select ChartNumber,CaseNumber,Date, FirstName,LastName,PostedToBilling,Signes as Signed from dbo.MMChartVisit where date BETWEEN dateadd(month,-6,getdate()) AND getdate()+1 order by date desc ", cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        DataGridView1.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()
    End Function

    Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Me.MMCHDxRxLtMtTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMCHDxRxLtMt, DataGridView1.SelectedRows(0).Cells("CaseNumber").Value.ToString())

        End If
    End Sub

    Private Sub radAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAll.CheckedChanged
        LoadAll()
    End Sub

    Private Function LoadAll()
        If radAll.Checked = True Then
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            Dim cmd As New SqlCommand("select ChartNumber,CaseNumber,Date, FirstName,LastName,PostedToBilling as Posted,Signes as Signed from dbo.MMChartVisit where date BETWEEN dateadd(month,-6,getdate()) AND getdate()+1 order by date desc ", cn)
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridView1.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            lblPosted.Text = "All in the last 6 months"

        End If
    End Function

    Private Function FormatGrid()
        Try
            Me.DataGridView1.Columns("ChartNumber").Width = 65
            Me.DataGridView1.Columns("CaseNumber").Width = 50
            Me.DataGridView1.Columns("Date").Width = 65
            Me.DataGridView1.Columns("FirstName").Width = 65
            Me.DataGridView1.Columns("LastName").Width = 65
            Me.DataGridView1.Columns("Posted").Width = 50
            Me.DataGridView1.Columns("Signed").Width = 50
        Catch
        End Try
    End Function

    Private Sub radToBePosted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radToBePosted.CheckedChanged
        LoadToBePosted()
    End Sub

    Private Function LoadToBePosted()
        If radToBePosted.Checked = True Then
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            Dim cmd As New SqlCommand("select ChartNumber,CaseNumber,Date, FirstName,LastName,PostedToBilling as Posted,Signes as Signed from dbo.MMChartVisit where date BETWEEN dateadd(month,-6,getdate()) AND getdate()+1 and PostedToBilling= 0 order by date desc ", cn)
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")
            DataGridView1.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            lblPosted.Text = "Unposted in the last 6 months"

        End If
    End Function

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim dgv As DataGridView = CType(sender, DataGridView)
        If e.ColumnIndex > -1 Then



            If dgv.Columns(e.ColumnIndex).Name = "Tag" Then
                PostBillingByCase(DataGridView1.Rows(e.RowIndex).Cells("CaseNumber").Value.ToString())
                If radAll.Checked = True Then
                    LoadAll()
                Else
                    LoadToBePosted()
                End If
            End If
        End If
    End Sub

    Private Function PostBillingByCase(ByVal CaseNumber As String)
        Dim retval As Integer
        Try
            Dim pieces() As String
            Dim IndexOf As Integer
            Dim sAction As String
            sAction = "ExportBillingData"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)
            If IndexOf <> -1 Then
            Else
                MessageBox.Show("You are not authorized to export billing data.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If
            Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewTableAdapter.Fill(Me.MMDataDataSet1.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNew, New System.Nullable(Of Integer)(CType(CaseNumber, Integer)))
            lblCasesPosted.Text = "Post to billing complete."
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function



    Private Sub PostBillingData_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FormatGrid()
    End Sub
End Class