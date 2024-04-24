Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Superbill
    Dim myBindingSource As New BindingSource()
    Dim aRetPatient(4) As String
    Dim strChartNumber2 As String
    Dim strTime2 As String
    Dim strName2 As String
    Dim strDate2 As String
    Private m_Rnd As New Random

    Private Sub Superbill_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ColorAlreadySelectedSuperBillItems()
    End Sub

    Private Sub Superbill_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub


    Private Sub Superbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabControl1.SelectedIndex = 0
        If strChartNumber2 <> "" And strDate2 <> "" Then
            Me.SuperbillSavedTableAdapter.FillByChartAndDate(Me.MMDataDataSet2.SuperbillSaved, strChartNumber2, strDate2)
        End If

        Me.SuperbillTableAdapter.Fill(Me.MMDataDataSet2.Superbill)
        txtChartNumber.Text = strChartNumber2
        txtPatientName.Text = strName2
        txtApptTime.Text = strTime2
        If strDate2 <> "" Then
            txtDate.Text = strDate2
        Else
            txtDate.Text = Date.Now
        End If
        LoadSavedSuperBills()
        Me.ReportViewer1.RefreshReport()

        If txtPatientName.Text <> "" Then
            lblPatientsSuperbillItems.Text = txtPatientName.Text & "'s SuperBill Items"
        End If
        ApplyColorToSuperbillDataGridView()
        'Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Public Function ShowSuperBill(ByVal strChartnumber As String, ByVal strName As String, ByVal strTime As String, ByVal strDate As String) As String()
        strChartNumber2 = strChartnumber
        strTime2 = strTime
        strName2 = strName
        strDate2 = strDate
        Me.ShowDialog()
    End Function

    Private Sub SuperbillBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperbillBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SuperbillBindingSource.EndEdit()
        Me.SuperbillTableAdapter.Update(Me.MMDataDataSet2.Superbill)
    End Sub

    Private Sub RadioButtonDx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDx.CheckedChanged
        Try
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()

            Dim cmd As New SqlCommand("SELECT  Code1 As Code, Description FROM MMDX order by Description", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMDX")

            myBindingSource = New BindingSource()
            myBindingSource.DataSource = ds
            myBindingSource.DataMember = ds.Tables(0).TableName
            DataGridViewPr.DataSource = myBindingSource

            ds.Dispose()
            cn.Close()
        Catch
        End Try

    End Sub

    Private Sub RadioButtonMT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMT.CheckedChanged
        Try
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand("SELECT ID, Description, Amount, MyTest, Type FROM MMCHARTTESTMEDICAL order by Description", cn)
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
        Catch
        End Try
    End Sub

    Private Sub RadioButtonPr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonPr.CheckedChanged
        Try
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand("SELECT Code1 As Code, Description, AmountA, MyProcedures, ScreenLocation, Type  from  MMProcedure order by Description", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMProcedure")

            myBindingSource = New BindingSource()
            myBindingSource.DataSource = ds
            myBindingSource.DataMember = ds.Tables(0).TableName
            DataGridViewPr.DataSource = myBindingSource

            ds.Dispose()
            cn.Close()
            Me.DataGridViewPr.Columns(0).Width = 70
            Me.DataGridViewPr.Columns(1).Width = 355
            Me.DataGridViewPr.Columns(2).Width = 50
        Catch
        End Try
    End Sub

    Private Sub RadioButtonLT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonLT.CheckedChanged
        Try
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()

            Dim cmd As New SqlCommand("SELECT TestNo, Description, Amount, MyTest, Type FROM MMChartTestLab order by Description", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMChartTestLab")

            myBindingSource = New BindingSource()
            myBindingSource.DataSource = ds
            myBindingSource.DataMember = ds.Tables(0).TableName
            DataGridViewPr.DataSource = myBindingSource

            ds.Dispose()
            cn.Close()
            Me.DataGridViewPr.Columns(0).Width = 70
            Me.DataGridViewPr.Columns(1).Width = 355
            Me.DataGridViewPr.Columns(2).Width = 50
        Catch
        End Try
    End Sub

    Private Sub RadioButtonTestImaging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTestImaging.CheckedChanged
        Try
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand("SELECT ID, Description, Amount, MyTest, Type FROM MMChartTestImaging order by Description", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMChartTestImaging")
            DataGridViewPr.DataSource = ds.Tables("MMChartTestImaging")

            ds.Dispose()
            cn.Close()
        Catch
        End Try
    End Sub

    Private Sub DataGridViewPr_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewPr.DoubleClick
        Dim strAmount As String

        Try

            If RadioButtonDx.Checked = True Then

                Dim newRow As DataRow = Me.MMDataDataSet2.Superbill.NewRow
                newRow("RecordType") = "DX"
                newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
                newRow("Billable") = True
                newRow("Category") = "DX"
                Me.MMDataDataSet2.Superbill.Rows.Add(newRow)

            ElseIf RadioButtonPr.Checked = True Then

                'If Not IsDBNull(DataGridViewPr.SelectedRows(0).Cells("AmountA").Value) Then
                '    If DataGridViewPr.SelectedRows(0).Cells("AmountA").Value <> "" Then
                '        strAmount = DataGridViewPr.SelectedRows(0).Cells("AmountA").Value
                '    Else
                '        strAmount = 0
                '    End If
                'Else : strAmount = 0
                'End If

                Dim newRow As DataRow = Me.MMDataDataSet2.Superbill.NewRow
                newRow("RecordType") = "Procedure"
                newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
                newRow("Billable") = True
                newRow("Amount") = DataGridViewPr.SelectedRows(0).Cells("AmountA").Value
                newRow("Category") = "Procedure"
                Me.MMDataDataSet2.Superbill.Rows.Add(newRow)

                ElseIf RadioButtonLT.Checked = True Then

                    Dim newRow As DataRow = Me.MMDataDataSet2.Superbill.NewRow
                    newRow("RecordType") = "Lab Test"
                    newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
                    newRow("Billable") = True
                    newRow("Amount") = DataGridViewPr.SelectedRows(0).Cells("Amount").Value
                    newRow("Category") = "Lab Test"
                    Me.MMDataDataSet2.Superbill.Rows.Add(newRow)


                ElseIf RadioButtonMT.Checked = True Then

                    Dim newRow As DataRow = Me.MMDataDataSet2.Superbill.NewRow
                    newRow("RecordType") = "Medical Test"
                    newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
                    newRow("Billable") = True
                    newRow("Amount") = DataGridViewPr.SelectedRows(0).Cells("Amount").Value
                    newRow("Category") = "Medical Test"
                    Me.MMDataDataSet2.Superbill.Rows.Add(newRow)


                ElseIf RadioButtonTestImaging.Checked = True Then

                    Dim newRow As DataRow = Me.MMDataDataSet2.Superbill.NewRow
                    newRow("RecordType") = "Image"
                    newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
                    newRow("Billable") = True
                    newRow("Amount") = DataGridViewPr.SelectedRows(0).Cells("Amount").Value
                    newRow("Category") = "Imaging Test"
                    Me.MMDataDataSet2.Superbill.Rows.Add(newRow)

                End If

                Me.SuperbillTableAdapter.Update(Me.MMDataDataSet2.Superbill)
        Catch
        End Try
    End Sub

    Private Sub SuperbillBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles SuperbillBindingSource.AddingNew


        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        Dim cmd As New SqlCommand
        Dim strValue As String = ""
        cn.Open()

        cmd = New SqlCommand("SELECT Extra1 from MMPrectice", cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                strValue = dr.Item(0).ToString
            End While
            cn.Close()


        Me.MMDataDataSet2.Superbill.MySuperBillColumn.DefaultValue = strValue
        Me.MMDataDataSet2.Superbill.RecordTypeSortOrderColumn.DefaultValue = 0
        Me.MMDataDataSet2.Superbill.ItemSortOrderColumn.DefaultValue = 0
        Me.MMDataDataSet2.Superbill.BillableColumn.DefaultValue = 0
        Me.MMDataDataSet2.Superbill.AmountColumn.DefaultValue = 0.0




    End Sub

    Private Sub chkToggleColumns_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkToggleColumns.CheckedChanged
        If chkToggleColumns.Checked = True Then
            SuperbillDataGridView.Columns("dgvSBTemplateAmount").Visible = True
            SuperbillDataGridView.Columns("dgvSBTemplateBillable").Visible = True
            SuperbillDataGridView.Columns("dgvSBTemplateMySuperBill").Visible = True
            SuperbillDataGridView.Columns("dgvSBTemplateRecordTypeSortOrder").Visible = True
            SuperbillDataGridView.Columns("dgvSBTemplateItemSortOrder").Visible = True
            SuperbillDataGridView.Columns("dgvSBTemplateRecordType").Visible = True
            SuperbillDataGridView.Columns("Favorite").Visible = True
        Else
            SuperbillDataGridView.Columns("dgvSBTemplateAmount").Visible = False
            SuperbillDataGridView.Columns("dgvSBTemplateBillable").Visible = False
            SuperbillDataGridView.Columns("dgvSBTemplateMySuperBill").Visible = False
            SuperbillDataGridView.Columns("dgvSBTemplateRecordTypeSortOrder").Visible = False
            SuperbillDataGridView.Columns("dgvSBTemplateItemSortOrder").Visible = False
            SuperbillDataGridView.Columns("DataGridViewTextBoxColumn1").Visible = False
            SuperbillDataGridView.Columns("dgvSBTemplateRecordType").Visible = False
            SuperbillDataGridView.Columns("Favorite").Visible = False
        End If
    End Sub

    Private Sub btnCreateSuperBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSuperBill.Click
        Dim i As Integer = 0

        Try
            If txtChartNumber.Text <> "" And txtDate.Text <> "" Then

                For i = 0 To SuperbillDataGridView.RowCount - 1
                    If SuperbillDataGridView.Rows(i).Cells("dgvChkSuperbillItem").Value = True Then
                        'If DataGridViewPr.Rows(i).Cells("MyItem").Value = False Then

                        Dim newRow As DataRow = Me.MMDataDataSet2.SuperbillSaved.NewRow
                        newRow("ChartNumber") = txtChartNumber.Text
                        newRow("Date") = txtDate.Text
                        newRow("ApptTime") = txtApptTime.Text
                        newRow("Code") = SuperbillDataGridView.Rows(i).Cells("dgvSBTemplateCode").Value.ToString
                        newRow("Description") = SuperbillDataGridView.Rows(i).Cells("dgvSBTemplateDescription").Value.ToString
                        newRow("Notes") = SuperbillDataGridView.Rows(i).Cells("dgvSBTemplateNotes").Value.ToString
                        newRow("RecordType") = SuperbillDataGridView.Rows(i).Cells("dgvSBTemplateRecordType").Value.ToString
                        newRow("MySuperBill") = SuperbillDataGridView.Rows(i).Cells("dgvSBTemplateMySuperBill").Value.ToString
                        newRow("Billable") = SuperbillDataGridView.Rows(i).Cells("dgvSBTemplateBillable").Value.ToString
                        newRow("Amount") = SuperbillDataGridView.Rows(i).Cells("dgvSBTemplateAmount").Value.ToString
                        newRow("RecordTypeSortOrder") = SuperbillDataGridView.Rows(i).Cells("dgvSBTemplateRecordTypeSortOrder").Value.ToString
                        newRow("ItemSortOrder") = SuperbillDataGridView.Rows(i).Cells("dgvSBTemplateItemSortOrder").Value.ToString
                        newRow("Category") = SuperbillDataGridView.Rows(i).Cells("Category").Value.ToString
                        newRow("UserName") = globalUser
                        newRow("DateCreated") = Date.Now
                        Me.MMDataDataSet2.SuperbillSaved.Rows.Add(newRow)
                    End If '("dgvChkSuperbillItem").Value = True
                Next

                SuperbillSavedTableAdapter.Update(Me.MMDataDataSet2.SuperbillSaved)
                ColorAlreadySelectedSuperBillItems()

            Else
                MessageBox.Show("A patient and superbill date must be selected")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Creating Superbill", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnGetPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPatient.Click
        Try

            txtChartNumber.Text = ""
            txtPatientName.Text = ""

            aRetPatient = PickList.PatientShowPicklist
            If aRetPatient(0) = "Y" Then
                txtChartNumber.Text = aRetPatient(1).Trim
                txtPatientName.Text = aRetPatient(2).Trim & ", " & aRetPatient(3).Trim & " " & aRetPatient(4).Trim
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Picking Patient")
        End Try
    End Sub

    Private Function ClearGrid()
        Dim i As Integer
        For i = 0 To SuperbillDataGridView.RowCount - 1
            SuperbillDataGridView.Rows(i).Cells("dgvChkAlreadySelectedItem").Value = False
            SuperbillDataGridView.Rows(i).Cells("dgvChkSuperbillItem").Value = False
            SuperbillDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Empty
        Next
    End Function

    Private Function ColorAlreadySelectedSuperBillItems()
        Cursor.Current = Cursors.WaitCursor
        ClearGrid()

        Dim i As Integer
        Dim ii As Integer


        If SuperbillSavedDataGridView.Rows.Count > 0 Then
            For ii = 0 To SuperbillSavedDataGridView.RowCount - 1
                If SuperbillSavedDataGridView.Rows(ii).Cells("dgvSuperBillSavedCode").Value.ToString.Trim <> "" Then
                    For i = 0 To SuperbillDataGridView.RowCount - 1
                        If SuperbillSavedDataGridView.Rows(ii).Cells("dgvSuperBillSavedCode").Value.ToString.Trim = SuperbillDataGridView.Rows(i).Cells("dgvSBTemplateCode").Value.ToString.Trim Then
                            SuperbillDataGridView.Rows(i).Cells("dgvChkAlreadySelectedItem").Value = True
                            SuperbillDataGridView.Columns("dgvChkAlreadySelectedItem").DefaultCellStyle.BackColor = Color.WhiteSmoke
                            SuperbillDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.PowderBlue
                        End If
                    Next
                End If
            Next
        End If
       
        Cursor.Current = Cursors.Default
    End Function

    Private Sub btnSaveSuperBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSuperBill.Click
        Me.Validate()
        Me.SuperbillSavedBindingSource.EndEdit()
        Me.SuperbillSavedTableAdapter.Update(Me.MMDataDataSet2.SuperbillSaved)
        ColorAlreadySelectedSuperBillItems()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        txtDate.Text = DateTimePicker1.Text
    End Sub

    Private Function LoadSavedSuperBills()
        Dim db As DBAccess = New DBAccess()
        Dim localdr As SqlClient.SqlDataReader
        Dim dt As New DataTable()
        dt.Columns.Add("ChartNumber")
        dt.Columns.Add("Date")
        dt.Columns.Add("ApptTime")
        Try
            localdr = db.ExecuteReader("select distinct chartnumber, date, ApptTime from superbillsaved order by date desc")
            If localdr.HasRows = True Then
                While localdr.Read
                    Dim row As DataRow = dt.NewRow()
                    row("ChartNumber") = localdr.Item("chartnumber")
                    row("Date") = localdr.Item("date")
                    row("ApptTime") = localdr.Item("ApptTime")
                    dt.Rows.Add(row)
                    dgvSavedSuperbills.DataSource = dt
                End While
            End If
            dgvSavedSuperbills.Columns("ChartNumber").Width = 100
            dgvSavedSuperbills.Columns("Date").Width = 100
            dgvSavedSuperbills.Columns("ApptTime").Width = 65
            localdr.Close()
        Catch
        End Try
    End Function

    Private Sub dgvSavedSuperbills_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSavedSuperbills.DoubleClick
        TabControl1.SelectedIndex = 0
        Dim savedsuperbillname As String = dgvSavedSuperbills.SelectedRows(0).Cells("Chartnumber").Value
        Dim savedsuperbilldate As String = dgvSavedSuperbills.SelectedRows(0).Cells("Date").Value
        Me.SuperbillSavedTableAdapter.FillByChartAndDate(Me.MMDataDataSet2.SuperbillSaved, savedsuperbillname, savedsuperbilldate)
        txtChartNumber.Text = dgvSavedSuperbills.SelectedRows(0).Cells("Chartnumber").Value
        txtDate.Text = dgvSavedSuperbills.SelectedRows(0).Cells("Date").Value
        txtApptTime.Text = dgvSavedSuperbills.SelectedRows(0).Cells("ApptTime").Value
        txtPatientName.Text = ""
        lblPatientsSuperbillItems.Text = txtChartNumber.Text & "'s SuperBill Items"
        ColorAlreadySelectedSuperBillItems()
    End Sub

    Private Sub btnPrintSuperbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSuperbill.Click
        PrintSuperBill()
    End Sub

    Private Function PrintSuperBill()
        TabControl1.SelectedIndex = 2
        Dim ds As New MMDataDataSet2
        Dim dt As DataTable = ds.Tables.Add("DataTable1")
        dt.Columns.Add("Column1", Type.GetType("System.String"))
        dt.Columns.Add("Column2", Type.GetType("System.String"))
        dt.Columns.Add("Column3", Type.GetType("System.String"))
        dt.Columns.Add("Column4", Type.GetType("System.String"))

        Dim r As DataRow
        Dim strValue As String
        Dim strValue2 As String = 0
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        Dim cn2 As New SqlConnection(connString)
        Dim cn3 As New SqlConnection(connString)
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        cn.Open()
        cn2.Open()
        cn3.Open()

        Dim strSelectedItem As String = ""
        Dim strNotes As String = ""

        If radShowSelectedSBItems.Checked = True Then

            cmd = New SqlCommand("select distinct category, RecordTypeSortOrder from dbo.SuperbillSaved where chartnumber = '" & txtChartNumber.Text & "' AND date = '" & txtDate.Text & "' order by RecordTypeSortOrder", cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read

                r = dt.NewRow()
                r("Column1") = dr.Item(0).ToString
                dt.Rows.Add(r)

                cmd2 = New SqlCommand("select code, description, notes  from SuperbillSaved where  chartnumber = '" & txtChartNumber.Text & "' AND date = '" & txtDate.Text & "' AND category = '" & dr.Item(0).ToString & "' order by ItemSortOrder", cn2)
                Dim dr2 As SqlDataReader = cmd2.ExecuteReader
                While dr2.Read
                    r = dt.NewRow()
                    r("Column1") = dr2.Item(0).ToString
                    r("Column2") = dr2.Item(1).ToString
                    r("Column4") = dr2.Item(2).ToString
                    dt.Rows.Add(r)
                End While
                r = dt.NewRow()
                dt.Rows.Add(r)
                dr2.Close()
            End While



        Else

            cmd = New SqlCommand("select distinct category, RecordTypeSortOrder  from SuperBill order by RecordTypeSortOrder", cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                r = dt.NewRow()
                r("Column1") = dr.Item(0).ToString
                dt.Rows.Add(r)


                cmd2 = New SqlCommand("select code, description  from superbill where   category = '" & dr.Item(0).ToString & "' order by ItemSortOrder", cn2)
                Dim dr2 As SqlDataReader = cmd2.ExecuteReader
                While dr2.Read

                    cmd3 = New SqlCommand("select code, description, notes  from SuperbillSaved where  chartnumber = '" & txtChartNumber.Text & "' AND date = '" & txtDate.Text & "' AND category = '" & dr.Item(0).ToString & "'", cn3)
                    Dim dr3 As SqlDataReader = cmd3.ExecuteReader

                    While dr3.Read
                        If dr2.Item(0).ToString = dr3.Item(0).ToString Then
                            strSelectedItem = "X"
                            strNotes = dr3.Item(2).ToString
                        End If
                    End While
                    dr3.Close()

                    r = dt.NewRow()
                    r("Column1") = dr2.Item(0).ToString
                    r("Column2") = dr2.Item(1).ToString
                    r("Column3") = strSelectedItem
                    r("Column4") = strNotes
                    dt.Rows.Add(r)
                    strSelectedItem = ""
                    strNotes = ""
                End While
                r = dt.NewRow()
                dt.Rows.Add(r)
                dr2.Close()
            End While
        End If

        cn.Close()
        cn2.Close()
        cn3.Close()
        Dim params(1) As Microsoft.Reporting.WinForms.ReportParameter
        params(0) = New Microsoft.Reporting.WinForms.ReportParameter("ApptDateParameter", txtDate.Text)
        params(1) = New Microsoft.Reporting.WinForms.ReportParameter("ApptTimeParameter", txtApptTime.Text)

        ' ReportViewer1.LocalReport.ReportPath = "C:\MedicalManager\MedicalManager\Reports\Superbill.rdlc"
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.SuperBill.rdlc"
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("MMDataDataSet2_DataTable1", dt))

        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource

        ReportDataSource1.Name = "MMDataDataSet2_DataTable1"
        ReportDataSource1.Value = dt
        ReportDataSource2.Name = "MMDataDataSet2_SuperBillReport"
        ReportDataSource2.Value = Me.SuperBillReportBindingSource
        Me.ReportViewer1.LocalReport.SetParameters(params)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)

        Me.SuperBillReportBindingSource.DataMember = "SuperBillReport"
        Me.SuperBillReportBindingSource.DataSource = Me.MMDataDataSet2

        Me.SuperBillReportTableAdapter.FillByChart(Me.MMDataDataSet2.SuperBillReport, txtChartNumber.Text)
        Me.ReportViewer1.RefreshReport()
    End Function

    Private Sub radShowAllSBItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShowAllSBItems.CheckedChanged
        ' If SuperbillSavedDataGridView.Rows.Count Then
        PrintSuperBill()
        '  End If
    End Sub

    Private Sub radShowSelectedSBItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShowSelectedSBItems.CheckedChanged
        If SuperbillSavedDataGridView.Rows.Count Then
            PrintSuperBill()
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 2 Then
            PrintSuperBill()
        End If
    End Sub

    Private Sub SuperbillDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SuperbillDataGridView.CellContentClick
        If SuperbillDataGridView.Columns(e.ColumnIndex).Name = "dgvSBTemplateNotes" Then
            SuperbillDataGridView.Rows(e.RowIndex).Cells("dgvChkSuperbillItem").Value = True
        End If
    End Sub

    Private Sub SuperbillDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SuperbillDataGridView.CellClick
        If SuperbillDataGridView.Columns(e.ColumnIndex).Name = "dgvSBTemplateNotes" Then
            SuperbillDataGridView.Rows(e.RowIndex).Cells("dgvChkSuperbillItem").Value = True
        End If
    End Sub

    Private Function ApplyColorToSuperbillDataGridView()

        Try
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            Dim strTemplateName As String
            Dim i As Integer
            Dim ii As Integer = 0
            Dim mycolor As Color

            cn.Open()

            Dim db As DBAccess = New DBAccess()
            Dim localdr As SqlClient.SqlDataReader


            localdr = db.ExecuteReader("SELECT distinct category FROM  superbill ")

            mycolor = RandomRGBColor()
            If localdr.HasRows = True Then
                While localdr.Read
                    If localdr.Item(0).ToString <> "" Then

                        For i = 0 To SuperbillDataGridView.RowCount - 1
                            If localdr.Item(0).ToString = SuperbillDataGridView.Rows(i).Cells("Category").Value Then

                                SuperbillDataGridView.Rows(i).Cells("Category").Style.BackColor = mycolor
                            End If
                        Next
                        ii += 1
                        mycolor = RandomRGBColor()
                    End If
                End While
            End If
            localdr.Close()
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "Color Code", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Function

    Public Function RandomRGBColor() As Color
        Return Color.FromArgb(255, m_Rnd.Next(50) + 205, m_Rnd.Next(50) + 205, m_Rnd.Next(50) + 205)
    End Function

    Private Sub radMyDx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMyDx.CheckedChanged
        If radMyDx.Checked = True Then
            Me.SuperbillTableAdapter.FillByFavorite(Me.MMDataDataSet2.Superbill)
            ColorAlreadySelectedSuperBillItems()
        End If
    End Sub

    Private Sub radAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAll.CheckedChanged
        If radAll.Checked = True Then
            Me.SuperbillTableAdapter.Fill(Me.MMDataDataSet2.Superbill)
            ColorAlreadySelectedSuperBillItems()
        End If
    End Sub
End Class