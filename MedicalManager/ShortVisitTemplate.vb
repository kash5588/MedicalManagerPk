Imports System.Data

Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Imports System.Configuration


Public Class ShortVisitTemplate
    Dim aRet(4) As String

    Private Sub MMChartVisitBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartVisitBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMChartVisitBindingSource.EndEdit()
        Me.MMChartVisitTableAdapter.Update(Me.MMDataDataSet1.MMChartVisit)

    End Sub

    Private Sub ShortVisitTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMChartVisit' table. You can move, or remove it, as needed.
        Me.MMChartVisitTableAdapter.Fill(Me.MMDataDataSet1.MMChartVisit)
        Me.MMCHDxRxLtMtTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMCHDxRxLtMt, CaseNumberTextBox.Text)
        'Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, ChartNumberTextBox.Text)
        Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CaseNumberTextBox.Text)
        Me.MMChartTVitalSignTableAdapter.FillByChNo(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text)
    End Sub

    Private Sub FillbyChToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, ChartNumberTextBox.Text, DateDateTimePicker.Value)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateDateTimePicker.ValueChanged
        Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, ChartNumberTextBox.Text, DateDateTimePicker.Value)
        Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CaseNumberTextBox.Text)
        'Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, ChartNumberTextBox.Text)
        Me.MMChartTVitalSignTableAdapter.FillByChNo(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text)
    End Sub

    Private Sub RadioButtonTestImaging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT     id, TestType, TestName FROM         MMChartTestImaging", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMChartTestImaging")
        DataGridViewPr.DataSource = ds.Tables("MMChartTestImaging")
        ds.Dispose()
        cn.Close()
    End Sub

    Private Sub RadioButtonDx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDx.CheckedChanged
        'User Instance=True
        Dim connString As String = connString2
        'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString


        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT  Code1, Description FROM MMDX order by Description", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMDX")
        DataGridViewPr.DataSource = ds.Tables("MMDX")

        ds.Dispose()
        cn.Close()
        On Error Resume Next
        Me.DataGridViewPr.Columns(0).Width = 70
        Me.DataGridViewPr.Columns(1).Width = 355


        'If Me.DataGridViewPr.Columns("Code1").Name = "Code1" Then
        '    '    e.Value = String.Format("{0:t}", e.Value)

        'End If
        ' Me.DataGridViewPr.Columns("Code1").Visible = False
        'Me.DataGridViewPr.Columns("Code1").Width = 200
        'Me.DataGridViewPr.Columns("Code1").HeaderText = "Di Code"
        'Me.DataGridViewPr.Columns(0).Width = 70
        'Me.DataGridViewPr.Columns(1).Width = 355
    End Sub

    Private Sub RadioButtonMT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMT.CheckedChanged

        'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT     id,  TestName,TestType FROM   MMChartTestMedical", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMChartTestMedical")
        DataGridViewPr.DataSource = ds.Tables("MMChartTestMedical")
        ds.Dispose()
        cn.Close()

        Me.DataGridViewPr.Columns(0).Width = 70
        Me.DataGridViewPr.Columns(1).Width = 350
        Me.DataGridViewPr.Columns(2).Width = 0

    End Sub

    Private Sub RadioButtonPr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonPr.CheckedChanged

        'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT Code1 As Code, Description, AmountA, MyProcedures, ScreenLocation  from  MMProcedure", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMProcedure")

        DataGridViewPr.DataSource = ds.Tables("MMProcedure")
        ds.Dispose()
        cn.Close()
        Me.DataGridViewPr.Columns(0).Width = 70
        Me.DataGridViewPr.Columns(1).Width = 355
        Me.DataGridViewPr.Columns(2).Width = 50
    End Sub

    Private Sub DataGridViewPr_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewPr.DoubleClick
        Try

            If RadioButtonDx.Checked = True Then
                '  newRow("Type") = "DX"
                If TextBoxDx1.Text = "" Then
                    TextBoxDx1.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                ElseIf TextBoxDx2.Text = "" Then
                    TextBoxDx2.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                ElseIf TextBoxDx3.Text = "" Then
                    TextBoxDx3.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""

                ElseIf TextBoxDx4.Text = "" Then
                    TextBoxDx4.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                End If

            ElseIf radOther.Checked = True Then

                '    Dim strOther As String
                '    strOther = NotesTestBox.Text
                '    If NotesTestBox.Text = "" Then
                '        NotesTestBox.Text = DataGridViewPr.SelectedRows(0).Cells(1).Value.ToString()
                '    Else
                '        NotesTestBox.Text = strOther + Environment.NewLine + DataGridViewPr.SelectedRows(0).Cells(1).Value.ToString
                '    End If
                'ElseIf radFollowUp.Checked = True Then


                '    Dim strFollowup As String
                '    strFollowup = TextBoxfollowUp.Text
                '    If TextBoxfollowUp.Text = "" Then
                '        TextBoxfollowUp.Text = DataGridViewPr.SelectedRows(0).Cells(1).Value.ToString()
                '    Else
                '        TextBoxfollowUp.Text = strFollowup + ", " + DataGridViewPr.SelectedRows(0).Cells(1).Value.ToString
                '    End If

                'ElseIf radDiet.Checked = True Then

                '    Dim strDiet As String
                '    strDiet = TextBoxDiet.Text
                '    If TextBoxDiet.Text = "" Then
                '        TextBoxDiet.Text = DataGridViewPr.SelectedRows(0).Cells(1).Value.ToString()
                '    Else
                '        TextBoxDiet.Text = strDiet + ", " + DataGridViewPr.SelectedRows(0).Cells(1).Value.ToString
                '    End If
                'ElseIf radCounseling.Checked = True Then
                '    Dim strCounseling As String
                '    strCounseling = TextBoxCounselingEducation.Text
                '    If TextBoxCounselingEducation.Text = "" Then
                '        TextBoxCounselingEducation.Text = DataGridViewPr.SelectedRows(0).Cells(1).Value.ToString()
                '    Else
                '        TextBoxCounselingEducation.Text = strCounseling + ", " + DataGridViewPr.SelectedRows(0).Cells(1).Value.ToString
                '    End If

            Else 'RadioButtonDx.Checked = False Then
                '  CounterTests += 1
                Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
                newRow("CHARTNUMBER") = ChartNumberTextBox.Text
                newRow("Date") = DateDateTimePicker.Text 'System.DateTime.Now.Date
                newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value
                newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value
                newRow("Amount") = DataGridViewPr.SelectedRows(0).Cells(2).Value

                If RadioButtonPr.Checked = True Then
                    newRow("Type") = "PR"
                ElseIf RadioButtonMT.Checked = True Then
                    newRow("Type") = "MEDTEST"
                ElseIf RadioButtonTestImaging.Checked = True Then
                    newRow("Type") = "IMAGING"
                End If
                Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)
                Me.MMCHDxRxLtMtTableAdapter.Update(Me.MMDataDataSet1.MMCHDxRxLtMt)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Patient form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ' On Error Resume Next
        'RV.ShowVisit(ChartNumberTextBox.Text, DateDateTimePicker.Text, CaseNumberTextBox.Text)
    End Sub

    Private Sub CaseNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaseNumberTextBox.TextChanged

        Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CaseNumberTextBox.Text)
        Me.MMCHDxRxLtMtTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMCHDxRxLtMt, CaseNumberTextBox.Text)
        ' Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, ChartNumberTextBox.Text)
        Me.MMChartTVitalSignTableAdapter.FillByChNo(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text)
    End Sub

    Private Sub cmdMedications_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMedications.Click
        aRet(1) = ChartNumberTextBox.Text
        aRet(2) = FirstNameTextBox.Text
        aRet(3) = LastNameTextBox.Text
        aRet(4) = CaseNumberTextBox.Text
        Prescription.ShowPrescriptions(aRet)

        Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CaseNumberTextBox.Text)
    End Sub
End Class


'        If RadioButtonDx.Checked = True Then

'Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
'            newRow("CHARTNUMBER") = ChartNumberTextBox.Text
'            newRow("Date") = System.DateTime.Now.Date
'            newRow("Type") = "DX"
'            newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
'            newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""

'            Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

'        ElseIf RadioButtonPr.Checked = True Then

'Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
'            newRow("CHARTNUMBER") = ChartNumberTextBox.Text
'            newRow("Date") = DateDateTimePicker.Value 'System.DateTime.Now.Date
'            newRow("Type") = "Procedures"
'            newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
'            newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
'            Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

'        ElseIf RadioButtonLT.Checked = True Then

'Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
'            newRow("CHARTNUMBER") = ChartNumberTextBox.Text
'            newRow("Date") = System.DateTime.Now.Date
'            newRow("Type") = "Lab Test"
'            newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
'            newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
'            Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

'        ElseIf RadioButtonMT.Checked = True Then

'Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
'            newRow("CHARTNUMBER") = ChartNumberTextBox.Text
'            newRow("Date") = System.DateTime.Now.Date
'            newRow("Type") = "Medical Test"
'            newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
'            newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
'            Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

'        ElseIf RadioButtonTestImaging.Checked = True Then

'Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
'            newRow("CHARTNUMBER") = ChartNumberTextBox.Text
'            newRow("Date") = System.DateTime.Now.Date
'            newRow("Type") = "Images"
'            newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
'            newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(2).Value & ""
'            Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)


'        End If

'        Me.MMCHDxRxLtMtTableAdapter.Update(Me.MMDataDataSet1.MMCHDxRxLtMt)
'    End Sub