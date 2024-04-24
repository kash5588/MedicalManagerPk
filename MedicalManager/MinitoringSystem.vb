Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Drawing.Imaging
Imports System.IO.File

Public Class MinitoringSystem
    Dim m_strFilePath As String







    Dim curF As Integer
    Dim finishX, finishY As Integer
    Dim startX, startY As Integer
    Dim up, down As Point
    Dim strFilePath As String
    Dim strPath As String
    Dim strFileName As String
    Dim g As Graphics
    Dim totFrame As Integer
    Dim frameCount As String
    Dim pageNo As Integer
    Dim objfile As System.IO.File
    Dim objImage As System.Drawing.Image
    Dim ifSaved As Boolean = False
    Dim isDelete As Boolean = True
    Dim isEdit As Boolean = False







    Private Sub LoadPageInfo()
        ' Display width and height
        'txtWidth.Text = MultiTiffViewer1.GetWidth
        'txtHeight.Text = MultiTiffViewer1.GetHeight

        ' Load TIFF information
        'LoadTiffInfo()

        ' Display setting
        '  MultiTiffViewer1.ZoomToFit()
        'MultiTiffViewer1.XAlign = cboAlign.SelectedIndex()
        'MultiTiffViewer1.XShowBorder = chkShowBorder.Checked
    End Sub
    Private Sub MMCentralMonitorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMCentralMonitorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMCentralMonitorBindingSource.EndEdit()
        Me.MMCentralMonitorTableAdapter.Update(Me.MMDataDataSet1.MMCentralMonitor)

    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text <> "" Then
            Me.MMCentralMonitorBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
            Me.MonitorByChartBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
        End If
        Me.MMCentralMonitorBindingSource.Sort = "ChartNumber"
        MMCentralMonitorDataGridView.DataSource = Me.MMCentralMonitorBindingSource

    End Sub

    Private Sub MinitoringSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.VisitReportPractice' table. You can move, or remove it, as needed.
        Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)
        Try
            Me.MonitorTableAdapter.Fill(Me.MMDataDataSet1.Monitor)
            Me.MMCentralMonitorTableAdapter.Fill(Me.MMDataDataSet1.MMCentralMonitor)
        Catch
        End Try
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            txtFind.Text = ""
            Me.MMCentralMonitorBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
            MonitorByChartDataGridView.Visible = False
            Me.MonitorTableAdapter.Fill(Me.MMDataDataSet1.Monitor)
            Me.MMCentralMonitorTableAdapter.Fill(Me.MMDataDataSet1.MMCentralMonitor)
        Catch
        End Try
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            '  Me.UpdateSignaturesTableAdapter.Fill(Me.MMDataDataSet1.UpdateSignatures, New System.Nullable(Of Boolean)(CType(SignedToolStripTextBox.Text, Boolean)), New System.Nullable(Of Integer)(CType(CaseNumberToolStripTextBox.Text, Integer)), New System.Nullable(Of Integer)(CType(ProcedureIndicatorToolStripTextBox.Text, Integer)), New System.Nullable(Of Integer)(CType(IDToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'Handles Button23.Click
        ' Private Sub UpdateDataSet(ByVal myDataSet As DataSet)
        ' check for changes with the HasChanges method first.
        Dim i As Integer
        Dim myDataSet As New DataSet
        Dim dt As DataTable
        dt = Me.MMDataDataSet1.Tables("MMCentralMonitor").GetChanges(DataRowState.Modified)
        myDataSet.Tables.Add(dt)
        If Not myDataSet.HasChanges(DataRowState.Modified) Then Exit Sub
        ' create temporary DataSet variable.
        Dim xDataSet As DataSet
        ' getChanges for modified rows only.
        xDataSet = myDataSet.GetChanges(DataRowState.Modified)
        ' check the DataSet for errors.
        If xDataSet.HasErrors Then
            ' insert code to resolve errors.
        End If

        ' Dim strID As Integer
        Dim row As DataRow

        For i = 0 To myDataSet.Tables(0).Rows.Count - 1

            Dim db As DBAccess = New DBAccess

            'db.Parameters.Add(New SqlParameter("@p1", 1))
            'db.Parameters.Add(New SqlParameter("@p2", myDataSet.Tables(0).Rows(i)("CaseNumber").ToString()))
            ' strID = myDataSet.Tables(0).Rows(i)("CaseNumber").ToString()
            db.Parameters.Add(New SqlParameter("@p1", 1))
            db.Parameters.Add(New SqlParameter("@p2", 742))

            Dim retval As Integer = db.ExecuteNonQuery("UpdateVisitSignature")
            'MessageBox.Show(retval)
            row = Me.MMDataDataSet1.MMCentralMonitor.Rows.Find(myDataSet.Tables(0).Rows(i)("ID").ToString())
            row("PostedChanges") = True
        Next

        Me.MMCentralMonitorBindingSource.EndEdit()
        Me.MMCentralMonitorTableAdapter.Update(Me.MMDataDataSet1.MMCentralMonitor)

        'MMCentralMonitorBindingSource.Position = MMCentralMonitorBindingSource.Find("CaseNumber", 732)
    End Sub

    Private Sub btnUpdateSignatures_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateSignatures.Click
        Try

            Dim i As Integer
            Dim myDataSet As New DataSet
            Dim dt As New DataTable
            Dim strProcedureIndicator As String = ""
            Dim xDataSet As DataSet
            Dim row As DataRow

            MMCentralMonitorDataGridView.EndEdit()
            MMCentralMonitorBindingSource.EndEdit()

            dt = Me.MMDataDataSet1.Tables("MMCentralMonitor").GetChanges(DataRowState.Modified)

            If Not dt Is Nothing Then myDataSet.Tables.Add(dt) Else Exit Sub
            xDataSet = myDataSet.GetChanges(DataRowState.Modified)
            PrintValues(xDataSet, "Subset values")

            For i = 0 To myDataSet.Tables(0).Rows.Count - 1
                Select Case myDataSet.Tables(0).Rows(i)("RecordType").ToString.ToLower.TrimEnd()
                    Case "visit"
                        strProcedureIndicator = 1
                    Case "prescription"
                        strProcedureIndicator = 2
                    Case "vital signs"
                        strProcedureIndicator = 3
                    Case "message"
                        strProcedureIndicator = 4
                    Case "letter"
                        strProcedureIndicator = 6
                    Case "consent"
                        strProcedureIndicator = 6
                    Case Else
                        strProcedureIndicator = 5
                End Select

                'Dim db As DBAccess = New DBAccess
                'db.Parameters.Add(New SqlParameter("@Signed", 1))
                'db.Parameters.Add(New SqlParameter("@CaseNumber", myDataSet.Tables(0).Rows(i)("CaseNumber").ToString()))
                'db.Parameters.Add(New SqlParameter("@ProcedureIndicator", strProcedureIndicator))
                'db.Parameters.Add(New SqlParameter("@ID", myDataSet.Tables(0).Rows(i)("ForeignID").ToString()))
                'Dim retval As Integer = db.ExecuteNonQuery("UpdateSignatures")

                
                '   Me.UpdateSignaturesTableAdapter.Fill(Me.MMDataDataSet1.UpdateSignatures, New System.Nullable(Of Boolean)(CType(1, Boolean)), New System.Nullable(Of Integer)(CType(myDataSet.Tables(0).Rows(i)("CaseNumber").ToString(), Integer)), New System.Nullable(Of Integer)(CType(strProcedureIndicator, Integer)), New System.Nullable(Of Integer)(CType(myDataSet.Tables(0).Rows(i)("ForeignID").ToString(), Integer)))
                Me.UpdateSignaturesTableAdapter.Fill(Me.MMDataDataSet1.UpdateSignatures, New System.Nullable(Of Boolean)(CType(myDataSet.Tables(0).Rows(i)("IsSigned"), Boolean)), New System.Nullable(Of Integer)(CType(myDataSet.Tables(0).Rows(i)("CaseNumber").ToString(), Integer)), New System.Nullable(Of Integer)(CType(strProcedureIndicator, Integer)), New System.Nullable(Of Integer)(CType(myDataSet.Tables(0).Rows(i)("ForeignID").ToString(), Integer)), myDataSet.Tables(0).Rows(i)("ChartNumber").ToString, New System.Nullable(Of Date)(CType(myDataSet.Tables(0).Rows(i)("Date").ToString(), Date)))

                row = Me.MMDataDataSet1.MMCentralMonitor.Rows.Find(myDataSet.Tables(0).Rows(i)("ID").ToString())
                row("PostedChanges") = True

                'If retval = 1 Then
                '    row = Me.MMDataDataSet1.MMCentralMonitor.Rows.Find(myDataSet.Tables(0).Rows(i)("ID").ToString())
                '    row("PostedChanges") = True
                'End If
            Next

            Me.MMCentralMonitorBindingSource.EndEdit()
            Me.MMCentralMonitorTableAdapter.Update(Me.MMDataDataSet1.MMCentralMonitor)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PrintValues(ByVal dataSet As DataSet, ByVal label As String)
        Console.WriteLine(label + ControlChars.Cr)
        Dim table As DataTable
        For Each table In dataSet.Tables
            Console.WriteLine("TableName: " + table.TableName)
            Dim row As DataRow
            For Each row In table.Rows
                Dim column As DataColumn
                For Each column In table.Columns
                    Console.Write(ControlChars.Tab & " " _
                       & row(column).ToString())
                Next column
                Console.WriteLine()
            Next row
        Next table
    End Sub

    Private Sub MMCentralMonitorDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMCentralMonitorDataGridView.SelectionChanged
        Dim ChartNumber, DateOfservice, CaseNumber As String
        ChartNumber = ""
        CaseNumber = ""
        Try
            If MMCentralMonitorDataGridView.SelectedRows.Count Then
                If Not IsDBNull(MMCentralMonitorDataGridView.SelectedRows(0).Cells("ChartNumber").Value) Then
                    If Not IsDBNull(MMCentralMonitorDataGridView.SelectedRows(0).Cells("CaseNumber").Value) Then

                        ChartNumber = MMCentralMonitorDataGridView.SelectedRows(0).Cells("ChartNumber").Value
                        DateOfservice = MMCentralMonitorDataGridView.SelectedRows(0).Cells("DateOfservice").Value
                        CaseNumber = MMCentralMonitorDataGridView.SelectedRows(0).Cells("CaseNumber").Value

                        Select Case MMCentralMonitorDataGridView.SelectedRows(0).Cells("RecordType").Value
                            Case "Visit"

                                ReportViewer1.Reset()
                                ReportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewer.VisitReport.rdlc"

                                If MMCentralMonitorDataGridView.SelectedRows(0).Cells("RecordType").Value = "Visit" Then
                                    If Not IsDBNull(MMCentralMonitorDataGridView.SelectedRows(0).Cells("ChartNumber").Value) And Not IsDBNull(MMCentralMonitorDataGridView.SelectedRows(0).Cells("DateOfservice").Value) Then


                                        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource

                                        ReportDataSource1.Name = "MMDataDataSet1_VisitReport"
                                        ReportDataSource1.Value = Me.VisitReportBindingSource
                                        ReportDataSource2.Name = "MMDataDataSet1_MMChartRx"
                                        ReportDataSource2.Value = Me.MMChartRxBindingSource
                                        ReportDataSource3.Name = "MMDataDataSet1_MMCHDxRxLtMt"
                                        ReportDataSource3.Value = Me.MMCHDxRxLtMtBindingSource
                                        ReportDataSource4.Name = "MMDataDataSet1_MMChartTVitalSign"
                                        ReportDataSource4.Value = Me.MMChartTVitalSignBindingSource
                                        ReportDataSource5.Name = "MMDataDataSet1_VisitReportPractice"
                                        ReportDataSource5.Value = Me.VisitReportPracticeBindingSource

                                        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                                        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
                                        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
                                        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
                                        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)

                                        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.VisitReport.rdlc"
                                        '  Me.ReportViewer1.Location = New System.Drawing.Point(23, 29)
                                        Me.ReportViewer1.Name = "ReportViewer1"
                                        '  Me.ReportViewer1.Size = New System.Drawing.Size(594, 539)
                                        Me.ReportViewer1.TabIndex = 0
                                        '
                                        'MMDataDataSet1
                                        '
                                        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
                                        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
                                        '
                                        'VisitReportBindingSource
                                        '
                                        Me.VisitReportBindingSource.DataMember = "VisitReport"
                                        Me.VisitReportBindingSource.DataSource = Me.MMDataDataSet1
                                        '
                                        'VisitreportTableAdapter
                                        '
                                        Me.VisitreportTableAdapter.ClearBeforeFill = True
                                        '
                                        'MMChartRxBindingSource
                                        '
                                        Me.MMChartRxBindingSource.DataMember = "MMChartRx"
                                        Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
                                        '
                                        'MMChartRxTableAdapter
                                        '
                                        Me.MMChartRxTableAdapter.ClearBeforeFill = True
                                        '
                                        'MMCHDxRxLtMtBindingSource
                                        '
                                        Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
                                        Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
                                        '
                                        'MMCHDxRxLtMtTableAdapter
                                        '
                                        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
                                        '
                                        'MMChartTVitalSignBindingSource
                                        '
                                        Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
                                        Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
                                        '
                                        'MMChartTVitalSignTableAdapter
                                        '
                                        Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True


                                        Me.VisitReportPracticeBindingSource.DataMember = "VisitReportPractice"
                                        Me.VisitReportPracticeBindingSource.DataSource = Me.MMDataDataSet1
                                        '
                                        'MMChartTVitalSignTableAdapter
                                        '
                                        Me.VisitReportPracticeTableAdapter.ClearBeforeFill = True

                                        Me.ReportViewer1.LocalReport.EnableExternalImages = True
                                        Me.VisitreportTableAdapter.FillByCHAndDate(Me.MMDataDataSet1.VisitReport, ChartNumber, DateOfservice)
                                        Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumber, DateOfservice)
                                        Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, ChartNumber, DateOfservice)
                                        Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, ChartNumber, DateOfservice)
                                        Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)
                                        Me.ReportViewer1.RefreshReport()
                                    End If
                                End If

                            Case "Letter"

                                ReportViewer1.Reset()
                                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                ReportDataSource1.Name = "MMDataDataSet2_Letters"
                                ReportDataSource1.Value = Me.LettersBindingSource
                                ReportDataSource2.Name = "MMDataDataSet1_VisitReportPractice"
                                ReportDataSource2.Value = Me.VisitReportPracticeBindingSource
                                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
                                Me.ReportViewer1.LocalReport.DisplayName = "Letters"
                                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Letter.rdlc"
                                Me.LettersBindingSource.DataMember = "Letters"
                                Me.LettersBindingSource.DataSource = Me.MMDataDataSet2
                                Me.VisitReportPracticeBindingSource.DataMember = "VisitReportPractice"
                                Me.VisitReportPracticeBindingSource.DataSource = Me.MMDataDataSet1
                                Me.LettersTableAdapter.FillByID(Me.MMDataDataSet2.Letters, MMCentralMonitorDataGridView.SelectedRows(0).Cells("ForeignID").Value)
                                Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)
                                Me.ReportViewer1.RefreshReport()
                                'Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, Text, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)


                            Case "Consent"

                                ReportViewer1.Reset()
                                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                ReportDataSource1.Name = "MMDataDataSet2_Letters"
                                ReportDataSource1.Value = Me.LettersBindingSource
                                ReportDataSource2.Name = "MMDataDataSet1_VisitReportPractice"
                                ReportDataSource2.Value = Me.VisitReportPracticeBindingSource
                                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
                                Me.ReportViewer1.LocalReport.DisplayName = "Letters"
                                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Letter.rdlc"
                                Me.LettersBindingSource.DataMember = "Letters"
                                Me.LettersBindingSource.DataSource = Me.MMDataDataSet2
                                Me.VisitReportPracticeBindingSource.DataMember = "VisitReportPractice"
                                Me.VisitReportPracticeBindingSource.DataSource = Me.MMDataDataSet1
                                Me.LettersTableAdapter.FillByID(Me.MMDataDataSet2.Letters, MMCentralMonitorDataGridView.SelectedRows(0).Cells("ForeignID").Value)
                                Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)
                                Me.ReportViewer1.RefreshReport()
                                'Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, Text, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)








                            Case "Message    "

                            Case Else

                                ReportViewer1.Reset()
                                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                ReportDataSource1.Name = "MMDataDataSet1_MMCHARTViewChart"
                                ReportDataSource1.Value = Me.MMCHARTViewChartBindingSource
                                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                                Me.ReportViewer1.LocalReport.DisplayName = "View Chart"
                                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Chart.rdlc"
                                Me.MMCHARTViewChartBindingSource.DataMember = "MMCHARTViewChart"
                                Me.MMCHARTViewChartBindingSource.DataSource = Me.MMDataDataSet1
                                Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, ChartNumber, CaseNumber)
                                Me.ReportViewer1.RefreshReport()
                                'Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, Text, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)


                        End Select

                        'If MMCentralMonitorDataGridView.SelectedRows(0).Cells("RecordType").Value.ToString.ToLower.TrimEnd() = "radiology" Then
                        '    If (MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value) <> "" Then 'Or MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value Is System.DBNull.Value = True Then

                        '        TabControl1.SelectedTab = TabControl1.TabPages(1)
                        '        PictureBox2.Image = Image.FromFile(MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value)
                        '    Else
                        '        TabControl1.SelectedTab = TabControl1.TabPages(0)
                        '    End If


                        If MMCentralMonitorDataGridView.SelectedRows(0).Cells("RecordSpecific").Value.ToString.ToLower.TrimEnd() = "image" Then
                            If (MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value) <> "" Then
                                TabControl1.SelectedTab = TabControl1.TabPages(1)
                                PictureBox2.Image = Image.FromFile(MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value)
                            Else
                                TabControl1.SelectedTab = TabControl1.TabPages(0)
                            End If


                        ElseIf MMCentralMonitorDataGridView.SelectedRows(0).Cells("RecordType").Value.ToString.ToLower.TrimEnd() = "prescription" Then
                            ' LoadPrescriptions(ChartNumber)
                            LoadPrescriptionsByDate(ChartNumber, MMCentralMonitorDataGridView.SelectedRows(0).Cells("DateOfservice").Value.ToString)
                        ElseIf MMCentralMonitorDataGridView.SelectedRows(0).Cells("RecordType").Value.ToString.ToLower.TrimEnd() = "vital signs" Then
                            LoadVitalSigns(ChartNumber)



                        ElseIf MMCentralMonitorDataGridView.SelectedRows(0).Cells("RecordSpecific").Value.ToString.ToLower.TrimEnd() = "tif" Then
                            If (MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value) <> "" Then

                                TabControl1.SelectedTab = TabControl1.TabPages(3)
                                strFilePath = MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value.ToString
                                openImage(strFilePath)
                                '   LoadTiff((MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value))
                            Else
                                TabControl1.SelectedTab = TabControl1.TabPages(0)
                            End If


                        Else
                            TabControl1.SelectedTab = TabControl1.TabPages(0)
                        End If
                    End If
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function LoadPrescriptions(ByVal ChartNumber As String)
        TabControl1.SelectedTab = TabControl1.TabPages(2)
        Dim connectionstring As String
        Try
            connectionstring = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim conn As New SqlClient.SqlConnection(connectionstring)
            Dim ds As New DataSet
            Dim sqlstring As String = "SELECT StartDate, Medication, Dosage, NumberOfRefills, Quantity, SubstituteOk  FROM MMChartRx where ChartNumber = '" & ChartNumber & "'"
            Dim daPrescriptions As New SqlClient.SqlDataAdapter(sqlstring, conn)
            daPrescriptions.Fill(ds, "MMChartRx")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "MMChartRx"
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)

        Catch ex As Exception
        Finally

        End Try
    End Function

    Private Function LoadPrescriptionsByDate(ByVal ChartNumber As String, ByVal strDate As String)
        TabControl1.SelectedTab = TabControl1.TabPages(2)
        Dim connectionstring As String
        Try
            connectionstring = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim conn As New SqlClient.SqlConnection(connectionstring)
            Dim ds As New DataSet
            Dim sqlstring As String = "SELECT StartDate, Medication, Dosage, NumberOfRefills as Refills, Quantity as Qty, SubstituteOk  FROM MMChartRx where ChartNumber = '" & ChartNumber & "' AND StartDate = '" & strDate & "'"
            Dim daPrescriptions As New SqlClient.SqlDataAdapter(sqlstring, conn)
            daPrescriptions.Fill(ds, "MMChartRx")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "MMChartRx"
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)

        Catch ex As Exception
        Finally

        End Try
    End Function

    Private Function LoadVitalSigns(ByVal ChartNumber As String)
        TabControl1.SelectedTab = TabControl1.TabPages(2)
        Dim connectionstring As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        Dim conn As New SqlClient.SqlConnection(connectionstring)
        Dim ds As New DataSet
        Dim sqlstring As String = "SELECT Date, Temp, Pulse, Resp, Systolic, Diastolic, HtIn, WtLb FROM MMChartTVitalSign where ChartNumber = '" & ChartNumber & "'"
        Dim da As New SqlClient.SqlDataAdapter(sqlstring, conn)
        da.Fill(ds, "MMChartTVitalSign")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "MMChartTVitalSign"
        DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
    End Function

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnFillByChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFillByChart.Click
        'Try
        '    txtFind.Text = ""
        '    Me.MonitorByChartBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
        '    MonitorByChartDataGridView.Visible = True
        '    Me.MonitorByChartTableAdapter.Fill(Me.MMDataDataSet2.MonitorByChart, txtChartNumber.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try


        Try
            txtFind.Text = ""
            Me.MonitorByChartBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
            MonitorByChartDataGridView.Visible = True
            Me.MonitorByChartTableAdapter.FillByChartNumber(Me.MMDataDataSet2.MonitorByChart, txtChartNumber.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try






    End Sub

    Private Sub MonitorByChartDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MonitorByChartDataGridView.SelectionChanged

        Dim ChartNumber, DateOfservice, CaseNumber As String
        ChartNumber = ""
        CaseNumber = ""
        Try
            If MonitorByChartDataGridView.SelectedRows.Count Then
                If Not IsDBNull(MonitorByChartDataGridView.SelectedRows(0).Cells("ChartNumber2").Value) Then
                    If Not IsDBNull(MonitorByChartDataGridView.SelectedRows(0).Cells("CaseNumber2").Value) Then

                        ChartNumber = MonitorByChartDataGridView.SelectedRows(0).Cells("ChartNumber2").Value
                        DateOfservice = MonitorByChartDataGridView.SelectedRows(0).Cells("DateOfservice2").Value
                        CaseNumber = MonitorByChartDataGridView.SelectedRows(0).Cells("CaseNumber2").Value

                        Select Case MonitorByChartDataGridView.SelectedRows(0).Cells("RecordType2").Value
                            Case "Visit"

                                ReportViewer1.Reset()
                                ReportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewer.VisitReport.rdlc"

                                If MonitorByChartDataGridView.SelectedRows(0).Cells("RecordType2").Value = "Visit" Then
                                    If Not IsDBNull(MonitorByChartDataGridView.SelectedRows(0).Cells("ChartNumber2").Value) And Not IsDBNull(MonitorByChartDataGridView.SelectedRows(0).Cells("DateOfservice2").Value) Then


                                        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource

                                        ReportDataSource1.Name = "MMDataDataSet1_VisitReport"
                                        ReportDataSource1.Value = Me.VisitReportBindingSource
                                        ReportDataSource2.Name = "MMDataDataSet1_MMChartRx"
                                        ReportDataSource2.Value = Me.MMChartRxBindingSource
                                        ReportDataSource3.Name = "MMDataDataSet1_MMCHDxRxLtMt"
                                        ReportDataSource3.Value = Me.MMCHDxRxLtMtBindingSource
                                        ReportDataSource4.Name = "MMDataDataSet1_MMChartTVitalSign"
                                        ReportDataSource4.Value = Me.MMChartTVitalSignBindingSource
                                        ReportDataSource5.Name = "MMDataDataSet1_VisitReportPractice"
                                        ReportDataSource5.Value = Me.VisitReportPracticeBindingSource

                                        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                                        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
                                        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
                                        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
                                        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)

                                        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.VisitReport.rdlc"
                                        '  Me.ReportViewer1.Location = New System.Drawing.Point(23, 29)
                                        Me.ReportViewer1.Name = "ReportViewer1"
                                        '  Me.ReportViewer1.Size = New System.Drawing.Size(594, 539)
                                        Me.ReportViewer1.TabIndex = 0
                                        '
                                        'MMDataDataSet1
                                        '
                                        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
                                        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
                                        '
                                        'VisitReportBindingSource
                                        '
                                        Me.VisitReportBindingSource.DataMember = "VisitReport"
                                        Me.VisitReportBindingSource.DataSource = Me.MMDataDataSet1
                                        '
                                        'VisitreportTableAdapter
                                        '
                                        Me.VisitreportTableAdapter.ClearBeforeFill = True
                                        '
                                        'MMChartRxBindingSource
                                        '
                                        Me.MMChartRxBindingSource.DataMember = "MMChartRx"
                                        Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
                                        '
                                        'MMChartRxTableAdapter
                                        '
                                        Me.MMChartRxTableAdapter.ClearBeforeFill = True
                                        '
                                        'MMCHDxRxLtMtBindingSource
                                        '
                                        Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
                                        Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
                                        '
                                        'MMCHDxRxLtMtTableAdapter
                                        '
                                        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
                                        '
                                        'MMChartTVitalSignBindingSource
                                        '
                                        Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
                                        Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
                                        '
                                        'MMChartTVitalSignTableAdapter
                                        '
                                        Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True


                                        Me.VisitreportTableAdapter.FillByCHAndDate(Me.MMDataDataSet1.VisitReport, ChartNumber, DateOfservice)
                                        Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumber, DateOfservice)
                                        Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, ChartNumber, DateOfservice)
                                        Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, ChartNumber, DateOfservice)
                                        Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)
                                        Me.ReportViewer1.RefreshReport()
                                    End If
                                End If

                            Case "Letter"

                                ReportViewer1.Reset()
                                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                ReportDataSource1.Name = "MMDataDataSet2_Letters"
                                ReportDataSource1.Value = Me.LettersBindingSource
                                ReportDataSource2.Name = "MMDataDataSet1_VisitReportPractice"
                                ReportDataSource2.Value = Me.VisitReportPracticeBindingSource
                                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
                                Me.ReportViewer1.LocalReport.DisplayName = "Letters"
                                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Letter.rdlc"
                                Me.LettersBindingSource.DataMember = "Letters"
                                Me.LettersBindingSource.DataSource = Me.MMDataDataSet2
                                Me.VisitReportPracticeBindingSource.DataMember = "VisitReportPractice"
                                Me.VisitReportPracticeBindingSource.DataSource = Me.MMDataDataSet1
                                Me.LettersTableAdapter.FillByID(Me.MMDataDataSet2.Letters, MonitorByChartDataGridView.SelectedRows(0).Cells("ForeignID2").Value)
                                Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)
                                Me.ReportViewer1.RefreshReport()


                            Case "Consent"

                                ReportViewer1.Reset()
                                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                ReportDataSource1.Name = "MMDataDataSet2_Letters"
                                ReportDataSource1.Value = Me.LettersBindingSource
                                ReportDataSource2.Name = "MMDataDataSet1_VisitReportPractice"
                                ReportDataSource2.Value = Me.VisitReportPracticeBindingSource
                                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
                                Me.ReportViewer1.LocalReport.DisplayName = "Letters"
                                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Letter.rdlc"
                                Me.LettersBindingSource.DataMember = "Letters"
                                Me.LettersBindingSource.DataSource = Me.MMDataDataSet2
                                Me.VisitReportPracticeBindingSource.DataMember = "VisitReportPractice"
                                Me.VisitReportPracticeBindingSource.DataSource = Me.MMDataDataSet1
                                Me.LettersTableAdapter.FillByID(Me.MMDataDataSet2.Letters, MMCentralMonitorDataGridView.SelectedRows(0).Cells("ForeignID").Value)
                                Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)
                                Me.ReportViewer1.RefreshReport()
                                'Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, Text, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)



                            Case Else

                                ReportViewer1.Reset()
                                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                ReportDataSource1.Name = "MMDataDataSet1_MMCHARTViewChart"
                                ReportDataSource1.Value = Me.MMCHARTViewChartBindingSource
                                Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                                Me.ReportViewer1.LocalReport.DisplayName = "View Chart"
                                Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Chart.rdlc"
                                Me.MMCHARTViewChartBindingSource.DataMember = "MMCHARTViewChart"
                                Me.MMCHARTViewChartBindingSource.DataSource = Me.MMDataDataSet1
                                Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, ChartNumber, CaseNumber)
                                Me.ReportViewer1.RefreshReport()
                                'Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, Text, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)


                        End Select

                        If MonitorByChartDataGridView.SelectedRows(0).Cells("RecordSpecific2").Value.ToString.ToLower.TrimEnd() = "image" Then
                            If (MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value) <> "" Then 'Or MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath").Value Is System.DBNull.Value = True Then

                                TabControl1.SelectedTab = TabControl1.TabPages(1)
                                PictureBox2.Image = Image.FromFile(MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value)
                            Else
                                TabControl1.SelectedTab = TabControl1.TabPages(0)
                            End If

                        ElseIf MonitorByChartDataGridView.SelectedRows(0).Cells("RecordType2").Value.ToString.ToLower.TrimEnd() = "prescription" Then
                            LoadPrescriptions(ChartNumber)

                        ElseIf MonitorByChartDataGridView.SelectedRows(0).Cells("RecordType2").Value.ToString.ToLower.TrimEnd() = "vital signs" Then
                            LoadVitalSigns(ChartNumber)

                        ElseIf MonitorByChartDataGridView.SelectedRows(0).Cells("RecordSpecific2").Value.ToString.ToLower.TrimEnd() = "tif" Then
                            If (MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value) <> "" Then

                                TabControl1.SelectedTab = TabControl1.TabPages(3)
                                strFilePath = MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value.ToString
                                openImage(strFilePath)
                                '   LoadTiff((MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value))
                            Else
                                TabControl1.SelectedTab = TabControl1.TabPages(0)
                            End If

                        Else
                            TabControl1.SelectedTab = TabControl1.TabPages(0)
                        End If
                    End If
                End If
            End If
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show(ex.ToString, "File not found")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub cmdGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGo.Click
        ' Display specified page
        ' MultiTiffViewer1.LoadTiffPage(Application.StartupPath + m_strFilePath, txtPageNo.Text)

        ' Display info. and setting of specified page 
        LoadPageInfo()
    End Sub

    'Private Sub cmdTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTop.Click
    '    txtPageNo.Text = 1
    '    MultiTiffViewer1.LoadTiffPage(Application.StartupPath + m_strFilePath, txtPageNo.Text)

    '    ' Display info. and setting of specified page 
    '    LoadPageInfo()
    'End Sub

    Private Sub cmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.Click
        If txtPageNo.Text > 1 Then
            txtPageNo.Text = txtPageNo.Text - 1
        Else
            txtPageNo.Text = 1
        End If
        ' MultiTiffViewer1.LoadTiffPage(Application.StartupPath + m_strFilePath, txtPageNo.Text)

        ' Display info. and setting of specified page 
        LoadPageInfo()
    End Sub

    'Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
    '    Dim iTotalPage As Integer

    '    iTotalPage = MultiTiffViewer1.GetTiffPageCount(Application.StartupPath + m_strFilePath)

    '    If txtPageNo.Text < iTotalPage Then
    '        txtPageNo.Text = txtPageNo.Text + 1
    '    Else
    '        txtPageNo.Text = iTotalPage
    '    End If
    '    MultiTiffViewer1.LoadTiffPage(Application.StartupPath + m_strFilePath, txtPageNo.Text)

    '    ' Display info. and setting of specified page 
    '    LoadPageInfo()
    'End Sub

    'Private Sub cmdBottom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBottom.Click
    '    Dim iTotalPage As Integer

    '    iTotalPage = MultiTiffViewer1.GetTiffPageCount(Application.StartupPath + m_strFilePath)

    '    txtPageNo.Text = iTotalPage
    '    MultiTiffViewer1.LoadTiffPage(Application.StartupPath + m_strFilePath, txtPageNo.Text)

    '    ' Display info. and setting of specified page 
    '    LoadPageInfo()
    'End Sub

    'Private Sub cmdRotate90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRotate90.Click
    '    MultiTiffViewer1.Rotate90()
    'End Sub

    'Private Sub cmdZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZoomOut.Click
    '    MultiTiffViewer1.XZoomValue = 0.75
    '    MultiTiffViewer1.Zoom()
    'End Sub

    'Private Sub cmdZoomByWidth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZoomByWidth.Click
    '    MultiTiffViewer1.ZoomToFitByWidth()
    'End Sub

    'Private Sub cmdZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZoomIn.Click
    '    MultiTiffViewer1.XZoomValue = 1.25
    '    MultiTiffViewer1.Zoom()
    'End Sub

    'Private Function LoadTiff(ByVal path As String)
    '    Try
    '        '    m_strFilePath = "\" & path & ".tif"
    '        '    MultiTiffViewer1.LoadTiffPage(Application.StartupPath + m_strFilePath, 1)

    '        '    ' Display total page
    '        '    lblTotalPage.Text = MultiTiffViewer1.GetTiffPageCount(Application.StartupPath + m_strFilePath)
    '        '    'lblTotalPage.Text = MultiTiffViewer1.GetTiffPageCount(m_strFilePath)
    '        '    MultiTiffViewer1.ZoomToFitByWidth()
    '        '    txtPageNo.Text = 1

    '        '    ' Display info. and setting of specified page 
    '        '    LoadPageInfo()
    '        'Catch ex As System.Exception
    '        '    System.Windows.Forms.MessageBox.Show(ex.Message)
    '        'End Try





    '        m_strFilePath = path '& ".tif"
    '        MultiTiffViewer1.LoadTiffPage(m_strFilePath, 1)

    '        ' Display total page
    '        lblTotalPage.Text = MultiTiffViewer1.GetTiffPageCount(m_strFilePath)
    '        'lblTotalPage.Text = MultiTiffViewer1.GetTiffPageCount(m_strFilePath)
    '        MultiTiffViewer1.ZoomToFitByWidth()
    '        txtPageNo.Text = 1

    '        ' Display info. and setting of specified page 
    '        LoadPageInfo()
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try









    ' End Function











    Private Sub loadImage(ByVal strFilePath As String)
        Try
            picBoxSize()
            ifSaved = False
            cboFrameNo.Items.Clear()
            '  cboFrameEdit.Items.Clear()
            'Changed the cursor to waitCursor
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'Sets the tiff file as an image object.
            objImage = objImage.FromFile(strFilePath)
            Dim objGuid As Guid = (objImage.FrameDimensionsList(0))
            Dim objDimension As System.Drawing.Imaging.FrameDimension = New System.Drawing.Imaging.FrameDimension(objGuid)

            'Gets the total number of frames in the .tiff file
            totFrame = objImage.GetFrameCount(objDimension)

            'Adds number of frames to the combo box for displaying purposes.
            Dim i As Integer
            For i = 0 To totFrame - 1
                cboFrameNo.Items.Add(i)
            Next
            cboFrameNo.Items.IndexOf(1)

            'Sets the temporary folder to "C:\temp\"
            strPath = "c:\temp\"

            'Saves every frame as a seperate file.
            Dim z As Integer
            z = 0
            curF = 0
            For z = 0 To (totFrame - 1)
                objImage.SelectActiveFrame(objDimension, curF)
                '   objImage.Save(strPath & curF & ".tif", Imaging.ImageFormat.Tiff)
                curF = curF + 1
            Next

            curF = 0

            'Displayes the frames
            DisplayFrame()
            Me.Cursor = System.Windows.Forms.Cursors.Default

        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show("File could not be found: " & strFilePath.ToString, "Unable to Locate File")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch
            MessageBox.Show("Tif could not be displayed.", "", MessageBoxButtons.OK)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sets the tooltip text's
        ' ToolTip.SetToolTip(btnOpen, "Open Image")
        '  ToolTip.SetToolTip(btnSave, "Copy to")
        ' ToolTip.SetToolTip(btnPrint, "Print to PDF")
        ' ToolTip.SetToolTip(btnDelete, "Delete Page")
        ToolTip.SetToolTip(btnPrevious, "Previous Page")
        ToolTip.SetToolTip(btnNext, "Next Page")
        ToolTip.SetToolTip(cboFrameNo, "Current Page")
        ToolTip.SetToolTip(btnUnZoom, "UnZoom by 1.25%")
        ToolTip.SetToolTip(btnZoom, "Zoom by 1.25%")
        ' ToolTip.SetToolTip(btnErase, "Eraser")
        curF = 0
    End Sub

    ''on click displays the next page
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If checkPath() = True Then
            btnPrevious.Enabled = True
            If isEdit = True Then
                isDelete = False
            Else
                isDelete = True
            End If

            nextFrame()
            DisplayFrame()
        Else
            Exit Sub
        End If

    End Sub

    ''Gets the next frame number
    Private Sub nextFrame()
        If curF = totFrame - 1 Then
            btnNext.Enabled = False
            Exit Sub
        Else
            curF = curF + 1
        End If
    End Sub

    ''on click displays the previous frame
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If checkPath() = True Then
            btnNext.Enabled = True
            If isEdit = True Then
                isDelete = False
            Else
                isDelete = True
            End If

            previousFrame()
            DisplayFrame()
        Else
            Exit Sub
        End If
    End Sub

    'gets the previous frame number
    Public Sub previousFrame()
        If curF = 0 Then
            btnPrevious.Enabled = False
            Exit Sub
        Else
            curF = curF - 1
        End If
    End Sub

    'Displays the selected frame
    Private Sub DisplayFrame()
        'if isDelete is true sets the image as the original .tiff image
        'if inDelete is false sets the imahe as seperate file from the temp folder
        Select Case isDelete
            Case True
                ' Dim objImage As System.Drawing.Image = objImage.FromFile(MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value.ToString)
            Case False
                Dim objImage As System.Drawing.Image = objImage.FromFile(strPath & curF & ".tif")
        End Select

        Dim objGuid As Guid = (objImage.FrameDimensionsList(0))
        Dim objDimension As System.Drawing.Imaging.FrameDimension = New System.Drawing.Imaging.FrameDimension(objGuid)
        objImage.SelectActiveFrame(objDimension, curF)
        picImage.Image = objImage
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        cboFrameNo.Text = curF
    End Sub

    'Gets the selected frame number for display from combo box
    Private Sub cboFrameNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFrameNo.SelectedIndexChanged
        curF = cboFrameNo.Text
        If curF = totFrame - 1 Then
            btnNext.Enabled = True
            Exit Sub
        Else
            DisplayFrame()
        End If
    End Sub

    ''on click zooms the image by 1.25 %
    Private Sub btnZoom_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoom.Click
        If checkPath() = True Then
            picImage.Width = CInt(picImage.Width * 1.25)
            picImage.Height = CInt(picImage.Height * 1.25)
        Else
            Exit Sub
        End If
    End Sub

    Private Function checkPath() As Boolean
        If strFilePath = "" Then
            MsgBox("Select an image to edit", MsgBoxStyle.Information)
            checkPath = False
            Exit Function
        Else
            checkPath = True
        End If
    End Function


    'on click unzooms the image by 1.25%
    Private Sub btnUnZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnZoom.Click
        If checkPath() = True Then
            picImage.Width = CInt(picImage.Width / 1.25)
            picImage.Height = CInt(picImage.Height / 1.25)
        Else
            Exit Sub
        End If
    End Sub

    'Gets the ctual size of the image
    Private Sub actualSize()
        picImage.Width = objImage.Width
        picImage.Height = objImage.Height
    End Sub

    Private Sub picBoxSize()
        picImage.Width = 600
        picImage.Height = 640
    End Sub

    'Gets the cross cursor
    Private Sub btnErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If checkPath() = True Then
            MsgBox("Screen will change to Edit Mode", MsgBoxStyle.Critical)
            Me.Cursor = System.Windows.Forms.Cursors.Cross
            isEdit = True
            isDelete = False
            actualSize()
            DisplayFrame()
        Else
            Exit Sub
        End If
    End Sub

    'on mouse down gets the x,y position of the mouse
    Public Sub mDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picImage.MouseDown
        'Checks to see if the cursor is cross
        If Me.Cursor Is System.Windows.Forms.Cursors.Cross Then
            'Checks if left mouse button in clicked
            If e.Button <> MouseButtons.Left Then
                Exit Sub
            Else
                'Gets starting position of the mouse
                startX = e.X
                startY = e.Y
                down = New Point(startX, startY)
            End If
        End If
    End Sub

    'on mouse up gets the x,y position of the mouse and draws user defined 
    'rectangle. Then saves the page as curF & "s" & ".tif"
    Private Sub mUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picImage.MouseUp
        'Checks to see if the cursor is cross
        If Me.Cursor Is System.Windows.Forms.Cursors.Cross Then
            Dim img As Drawing.Image
            'sets the current page as image.
            img = Image.FromFile(strPath & curF & ".tif")

            Dim objBmp As New Bitmap(img, img.Width, img.Height)
            '   Dim objNewBmp As New Bitmap(objBmp.Width, objBmp.Height, Imaging.PixelFormat.Format16bppRgb555)

            Dim g As Graphics
            '    g = Graphics.FromImage(objNewBmp)
            'Creats a duplicate image file as bitmap format 
            Dim rect As Rectangle
            With rect
                .Width = img.Width
                .Height = img.Height
                .X = 0
                .Y = 0
            End With

            g.DrawImage(img, rect)

            Dim DrawRect As Rectangle
            'Sets the position of the mouse
            finishX = e.X
            finishY = e.Y

            up = New Point(finishX, finishY)
            'Sets the value of rectangle, x, y, width, height position
            DrawRect = New Rectangle(Math.Min(up.X, down.X), Math.Min(up.Y, down.Y), Math.Abs(up.X - down.X), Math.Abs(up.Y - down.Y))

            Dim b As SolidBrush = New SolidBrush(Color.White)
            g.FillRectangle(b, DrawRect)

            'Creates an rectagnle on the picture box for visual.
            g = picImage.CreateGraphics
            g.FillRectangle(b, DrawRect)

            If MsgBox("Do you want to save the change?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '      objNewBmp.Save(strPath & curF & "s" & ".tif", Imaging.ImageFormat.Tiff)
                '  cboFrameEdit.Items.Add(curF)
                g.Dispose()
                '    objNewBmp.Dispose()
            Else
                g.Dispose()
                ' objNewBmp.Dispose()
            End If
        End If
    End Sub

    'Opens selected image
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'openImage()
    End Sub

    ''Opens an image to edit
    Private Sub openImage(ByVal strFilePath As String)
        'If strFilePath = "" Then
        '    cboFrameNo.Items.Clear()
        '    'OpenFileDialog1.ShowDialog()
        'strFilePath = MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value.ToString ' OpenFileDialog1.FileName.ToString

        '    If strFilePath = "" Then
        '        MsgBox("Please select an image")
        '        OpenFileDialog1.ShowDialog()
        '    Else
        '        MsgBox(strFilePath)
        loadImage(strFilePath)
        '    End If
        'Else
        'MsgBox("Please close the current image", MsgBoxStyle.Information)
        'End If
    End Sub

    'Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
    '    If strFilePath = "" Then
    '        End
    '    Else
    '        closeFile()
    '        disposeFrame()
    '        End
    '    End If
    'End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    '    saveImage()
    'End Sub

    ''Saves the edited image
    'Private Sub saveImage()
    '    If checkPath() = True Then

    '        SaveFileDialog1.AddExtension = True
    '        SaveFileDialog1.ShowDialog()
    '        strFileName = SaveFileDialog1.FileName()
    '        strFileName = strFileName & ".tif"

    '        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

    '        'Deletes the original edited pages. For example page 0.tif was edited
    '        'and saved as 0s.tif. Now delete the 0.tif in order rename the 
    '        '0s.tif file to 0.tif. Then we can package all the page numbers back to
    '        'one .tiff file

    '        Dim z As Integer
    '        Dim editPageCount As Integer

    '        editPageCount = cboFrameEdit.Items.Count

    '        For z = 0 To editPageCount
    '            If z = editPageCount Then
    '                Exit For
    '            End If
    '            Dim strEditedPage As String

    '            strEditedPage = cboFrameEdit.Items.Item(z)
    '            Try
    '                If objfile.Exists(strPath & strEditedPage & ".tif") Then
    '                    objfile.Delete(strPath & strEditedPage & ".tif")
    '                    objfile.Move(strPath & strEditedPage & "s" & ".tif", strPath & strEditedPage & ".tif")
    '                End If
    '            Catch ex As Exception

    '            End Try
    '        Next

    '        Dim saveTif As Bitmap = New Bitmap(strPath & curF & ".tif")

    '        Dim myImageCodecInfo As ImageCodecInfo
    '        Dim myEncoder As Encoder
    '        Dim myEncoderParameter As EncoderParameter
    '        Dim myEncoderParameters As EncoderParameters

    '        'Get an ImageCodecInfo object that represents the TIFF codec.
    '        myImageCodecInfo = GetEncoderInfo("image/tiff")

    '        'Create an Encoder object based on the GUID
    '        'for the SaveFlag parameter category.
    '        myEncoder = Encoder.SaveFlag
    '        'Create an EncoderParameters object.
    '        'An EncoderParameters object has an array of EncoderParameter
    '        'objects. In this case, there is only one
    '        'EncoderParameter object in the array.
    '        myEncoderParameters = New EncoderParameters(1)

    '        myEncoderParameter = New EncoderParameter(myEncoder, CLng(EncoderValue.MultiFrame))
    '        myEncoderParameters.Param(0) = myEncoderParameter
    '        saveTif.Save(strFileName, myImageCodecInfo, myEncoderParameters)

    '        Dim i As Integer
    '        cboFrameNo.Items.RemoveAt(0)
    '        frameCount = cboFrameNo.Items.Count
    '        'Removes the page 1 from the combo box. otherwise first page will be
    '        'saved twice.
    '        Try
    '            For i = 0 To frameCount

    '                pageNo = cboFrameNo.Items.Item(i)

    '                If objfile.Exists(strPath & pageNo & ".tif") Then
    '                    Dim saveFrame As Bitmap = New Bitmap(strPath & pageNo & ".tif")

    '                    myEncoderParameter = New EncoderParameter(myEncoder, CLng(EncoderValue.FrameDimensionPage))
    '                    myEncoderParameters.Param(0) = myEncoderParameter
    '                    saveTif.SaveAdd(saveFrame, myEncoderParameters)
    '                    saveFrame.Dispose()
    '                End If
    '            Next
    '        Catch ex As Exception
    '        End Try

    '        saveTif.Dispose()
    '        Me.Cursor = System.Windows.Forms.Cursors.Default

    '        MsgBox("File saved as" & strFileName)
    '        ifSaved = True

    '        If MsgBox("Do you want to close this image?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            closeFile()
    '        Else
    '            'Changes the file to newly saved file name and loads the saved file.
    '            strFilePath = strFileName
    '            isDelete = True
    '            loadImage(strFileName)
    '        End If
    '    Else
    '        Exit Sub
    '    End If
    'End Sub

    ''Deletes the saved individual frames
    'Private Sub disposeFrame()
    '    Try
    '        Dim i As Integer

    '        frameCount = cboFrameNo.Items.Count
    '        For i = 0 To frameCount
    '            pageNo = cboFrameNo.Items.Item(i)
    '            If objfile.Exists(strPath & pageNo & ".tif") Then
    '                objfile.Delete(strPath & pageNo & ".tif")
    '            End If
    '        Next
    '    Catch
    '    End Try
    'End Sub

    'Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    '    If checkPath() = True Then
    '        'Check to see if the cursor is in Edit mode
    '        If Me.Cursor Is System.Windows.Forms.Cursors.Cross Then
    '            MsgBox("You can not delete a page in Edit Mode. Please Change the mode to View Mode", MsgBoxStyle.Information)
    '            Exit Sub
    '        End If

    '        If MsgBox("Do you want to delete page" & " " & curF, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            isDelete = True
    '            cboFrameNo.Items.Remove(curF)
    '            objfile.Delete(strPath & curF & ".tif")
    '            nextFrame()
    '            DisplayFrame()
    '            isDelete = False
    '        Else
    '            Exit Sub
    '        End If
    '    Else
    '        Exit Sub
    '    End If
    'End Sub

    ''GetEncoderInfo
    'Private Shared Function GetEncoderInfo(ByVal mimeType As [String]) As ImageCodecInfo
    '    Dim i As Integer
    '    Dim encoders() As ImageCodecInfo
    '    encoders = ImageCodecInfo.GetImageEncoders()

    '    For i = 0 To (encoders.Length - 1)
    '        If (encoders(i).MimeType = mimeType) Then
    '            Return encoders(i)
    '        End If
    '    Next i
    'End Function

    'Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
    '    closeFile()
    'End Sub

    ''Closes the open image file
    'Private Sub closeFile()
    '    If checkPath() = True Then
    '        If ifSaved = True Then
    '            picImage.Image = Nothing
    '            isDelete = True
    '            strFilePath = ""
    '            disposeFrame()
    '            cboFrameNo.Items.Clear()
    '            cboFrameEdit.Items.Clear()
    '        Else
    '            If MsgBox("Do you want to close the image without saving?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '                picImage.Image = Nothing
    '                objImage.Dispose()

    '                isDelete = True
    '                strFilePath = ""
    '                disposeFrame()
    '                cboFrameNo.Items.Clear()
    '                cboFrameEdit.Items.Clear()
    '            Else
    '                Exit Sub
    '            End If
    '        End If
    '    Else
    '        Exit Sub
    '    End If
    'End Sub

    ''Checks if there is an image loaded for editing.
    'Private Function checkPath() As Boolean
    '    If strFilePath = "" Then
    '        MsgBox("Select an image to edit", MsgBoxStyle.Information)
    '        checkPath = False
    '        Exit Function
    '    Else
    '        checkPath = True
    '    End If
    'End Function

    'Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    '    closeFile()
    'End Sub

    'Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
    '    openImage()
    'End Sub

    'Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
    '    saveImage()
    'End Sub

    'Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

    '    If checkPath() = True Then
    '        'using Acrobat.tlb
    '        Dim acroapp As Object
    '        Dim AcroExchApp As Object
    '        AcroExchApp = CreateObject("AcroExch.App")
    '        acroapp = CreateObject("AcroExch.AVDoc")

    '        acroapp.Open(strFilePath, "")
    '        AcroExchApp.show()
    '    End If

    'End Sub

    'Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
    '    btnErase.Hide()
    '    btnDelete.Hide()
    '    cboFrameEdit.Hide()
    '    btnZoom.Hide()
    '    btnUnZoom.Hide()
    '    btnEdit.Hide()
    '    btnNormal.Hide()
    'End Sub

    'Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
    '    btnErase.Show()
    '    btnDelete.Show()
    '    cboFrameEdit.Show()
    '    btnZoom.Show()
    '    btnUnZoom.Show()
    '    btnEdit.Show()
    '    btnNormal.Show()
    'End Sub

    'Private Sub btnNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNormal.Click
    '    If checkPath() = True Then
    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '        picBoxSize()
    '    End If
    'End Sub

    'Private Sub btnActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
    '    If checkPath() = True Then
    '        actualSize()
    '    End If
    'End Sub

    'Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
    '    Dim objFrm As Form2
    '    objFrm = New Form2()
    '    objFrm.Show()
    'End Sub


    Private Sub cmdRotate90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRotate90.Click
        picImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        picImage.Refresh()
    End Sub

    Private Sub cmdRotate270_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRotate270.Click
        picImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        picImage.Refresh()
    End Sub

    
   
    Private Sub btnVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisit.Click
        Me.MMCentralMonitorBindingSource.Filter = "RecordType like" & "'" & "Visit" & "%'"
        Me.MonitorByChartBindingSource.Filter = "RecordType like" & "'" & "Visit" & "%'"
        'Me.MMCentralMonitorBindingSource.Sort = "Date"
        'MonitorByChartDataGridView.DataSource = Me.MMCentralMonitorBindingSource
    End Sub

   
    Private Sub btnRadiology_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRadiology.Click
        Me.MMCentralMonitorBindingSource.Filter = "RecordType like" & "'" & "Radiology" & "%'"
        Me.MonitorByChartBindingSource.Filter = "RecordType like" & "'" & "Radiology" & "%'"
        'Me.MMCentralMonitorBindingSource.Sort = "Date"
        'MonitorByChartDataGridView.DataSource = Me.MMCentralMonitorBindingSource
    End Sub

    Private Sub BTNLAB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNLAB.Click
        Me.MMCentralMonitorBindingSource.Filter = "RecordType like" & "'" & "Lab" & "%'"
        Me.MonitorByChartBindingSource.Filter = "RecordType like" & "'" & "Lab" & "%'"
        'Me.MMCentralMonitorBindingSource.Sort = "Date"
        'MonitorByChartDataGridView.DataSource = Me.MMCentralMonitorBindingSource
    End Sub

    Private Sub btnMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMessages.Click
        Me.MMCentralMonitorBindingSource.Filter = "RecordType like" & "'" & "Message" & "%'"
        Me.MonitorByChartBindingSource.Filter = "RecordType like" & "'" & "Message" & "%'"
        'Me.MMCentralMonitorBindingSource.Sort = "Date"
        'MonitorByChartDataGridView.DataSource = Me.MMCentralMonitorBindingSource
    End Sub

    Private Sub btnLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLetter.Click
        Me.MMCentralMonitorBindingSource.Filter = "RecordType like" & "'" & "Letter" & "%'"
        Me.MonitorByChartBindingSource.Filter = "RecordType like" & "'" & "Letter" & "%'"
        Me.MMCentralMonitorBindingSource.Sort = "Date"
        'MonitorByChartDataGridView.DataSource = Me.MMCentralMonitorBindingSource
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        Me.MMCentralMonitorBindingSource.Filter = ""
        Me.MonitorByChartBindingSource.Filter = ""
        'Me.MMCentralMonitorBindingSource.Sort = "Date"
        'MonitorByChartDataGridView.DataSource = Me.MMCentralMonitorBindingSource
    End Sub


End Class



'Dim changesDataSet As DataSet
'If myDataSet.HasChanges(DataRowState.Modified Or DataRowState.Added) Then
'    changesDataSet = myDataSet.GetChanges(DataRowState.Modified Or DataRowState.Added)
'    PrintValues(changesDataSet, "Subset values")
'End If


'Dim g As Graphics
'Dim b1 As Bitmap
'Dim b2 As Bitmap

'b1 = Image.FromFile(sFile)

'b2 = New Bitmap(b1.Width, b1.Height)
'g = Graphics.FromImage(b2)
'g.DrawImage(b1, 0, 0)

'g.Dispose()

'PictureBox1.Image = b2
