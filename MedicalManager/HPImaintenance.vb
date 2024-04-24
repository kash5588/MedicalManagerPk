Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class HPImaintenance
    Dim iReorderCount As Integer = 0

    Private Sub HPIBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HPIBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.HPIBindingSource.EndEdit()
            Me.HPITableAdapter.Update(Me.MMDataDataSet1.HPI)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub HPI_maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.QIDs' table. You can move, or remove it, as needed.
        ' Me.QIDsTableAdapter.FillByDistinctTemplate(Me.MMDataDataSet2.QIDs)
        ' Me.MMChartCCTableAdapter.Fill(Me.MMDataDataSet2.QIDs)
        Me.HPI1TableAdapter.Fill(Me.MMDataDataSet1.HPI1)
        Me.HPITableAdapter.Fill(Me.MMDataDataSet1.HPI)
        LoadComboCC()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MyArr
        Dim i As Long
        MyArr = Split(txtList.Text, vbCrLf)
        For i = 0 To UBound(MyArr)
            Dim row As DataRow
            row = Me.MMDataDataSet1.Tables("HPI").NewRow()
            row("CC") = cmbCC.Text
            row("Category") = cmbCategory.Text
            row("SubCategory") = ""
            row("Description") = MyArr(i)
            row("AddField") = ""
            Me.MMDataDataSet1.Tables("HPI").Rows.Add(row)
        Next
        Me.Validate()
        Me.HPIBindingSource.EndEdit()
        Me.HPITableAdapter.Update(Me.MMDataDataSet1.HPI)

    End Sub

    'Private Function LoadComboCC()
    '    Dim dr As DataRow
    '    Dim dt As DataTable
    '    dt = Me.MMDataDataSet2.Tables("QIDs")
    '    cmbCC.Items.Clear()
    '    For Each dr In dt.Rows
    '        If dr("Templatename") <> "" Then
    '            cmbCC.Items.Add(dr("Templatename"))
    '        End If
    '    Next
    'End Function

    '    Private Function LoadComboCC()
    '        Dim drQids As DataRow
    '        Dim dtTemplate As  Me.MMDataDataSet1.Tables("Qids")


    '        ComboBox1.Items.Clear()

    '        For Each drQids In dtTemplate.Rows


    '        Next
    '    End Function

    Private Function LoadComboCC()
        '    Dim dr As DataRow
        '    Dim dt As DataTable
        '    dt = Me.MMDataDataSet1.Tables("HPI")
        '    cmbCC.Items.Clear()
        '    For Each dr In dt.Rows
        '        If dr("CC") <> "" Then
        '            cmbCC.Items.Add(dr("CC"))
        '        End If
        '    Next


        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT distinct CC from HPI ORDER BY CC ", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "CC")
        ' cmbCC.DataSource = ds.Tables("CC")

        With cmbCC
            .DataSource = ds.Tables(0)
            .DisplayMember = "CC"
            .ValueMember = "CC"
            '.SelectedIndex = 0
        End With

        With cboHPICategory
            .DataSource = ds.Tables(0)
            .DisplayMember = "CC"
            .ValueMember = "CC"
            '.SelectedIndex = 0
        End With


    End Function

    Private Sub btnReorder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReorder.CheckedChanged
        If btnReorder.Checked = True Then
            btnJump2.Visible = True
            txtJump2.Visible = True
            iReorderCount = 0
        Else
            btnJump2.Visible = False
            txtJump2.Visible = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

   

    Private Sub HPIDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HPIDataGridView.CellClick
        If btnReorder.Checked = True Then
            If Me.HPIDataGridView.Columns(e.ColumnIndex).Name = "SortOrder" Then
                If Me.HPIDataGridView.SelectedCells.Count = 1 Then
                    iReorderCount += 5
                    Me.HPIDataGridView.Rows(e.RowIndex).Cells("SortOrder").Value = iReorderCount
                End If
            End If
        End If
    End Sub


    Private Sub HPIDataGridView_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles HPIDataGridView.CellMouseMove
        If btnReorder.Checked = True Then
            Me.Cursor = Cursors.Cross
        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub

 
    Private Sub cboHPICategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHPICategory.SelectedIndexChanged
        Try
            If cboHPICategory.Text <> "" Then
                Me.HPITableAdapter.FillByCC(Me.MMDataDataSet1.HPI, cboHPICategory.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnJump2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJump2.Click
        iReorderCount = txtJump2.Text - 5
    End Sub
End Class
