Public Class HealthHistory
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(7) As String
    Dim arrayAssignedProvider(0) As String
    Dim HChartNumber, HName, HDOB As String
    Dim myBindingSource As New BindingSource()





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











    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        Dim FrmProcedure As New Procedure
        'aRet = frmCustomers.ShowPicklist
        ' frmCustomers.ShowDialog()
        aRet = PATIENT.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab
            ChartNumberTextBox.Text = aRet(1)
            LastNameTextBox.Text = aRet(2)
            FirstNameTextBox.Text = aRet(3)
            DOBTextBox.Text = aRet(6)
            'DOBTextBox.Text = aRet(6)
        End If
    End Sub
    Private Sub MMCHHealthHistoryShortBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMCHHealthHistoryShortBindingNavigatorSaveItem.Click
            Try
                  Me.Validate()
                  Me.MMCHHealthHistoryShortBindingSource.EndEdit()
                  Me.MMCHHealthHistoryShortTableAdapter.Update(Me.MMDataDataSet1.MMCHHealthHistoryShort)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub HealthHistory_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub HealthHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.PatientPictures' table. You can move, or remove it, as needed.
        Me.PatientPicturesTableAdapter.FillByChartNumber(Me.MMDataDataSet2.PatientPictures, HChartNumber)

        Me.ReportViewer1.Clear()
        Me.MMCHDxRxLtMtTableAdapter.FillbyCh(Me.MMDataDataSet1.MMCHDxRxLtMt, HChartNumber)
        Me.MMChartRxTableAdapter.FillByChOrderbyStatus(Me.MMDataDataSet1.MMChartRx, HChartNumber)
        If HChartNumber <> "" Then
            Me.MMCHHealthHistoryShortTableAdapter.FillbyCh(Me.MMDataDataSet1.MMCHHealthHistoryShort, HChartNumber)
        End If


        If Me.MMCHHealthHistoryShortBindingSource.Count > 0 Then
            BindingNavigatorAddNewItem.Enabled = False
        End If

        TextBox1.Text = ChartNumberTextBox.Text
        Me.MMChartVisitTableAdapter.FillByCh(Me.MMDataDataSet1.MMChartVisit, HChartNumber)
        Me.MonitorByChartLimitedTableAdapter.Fill(Me.MMDataDataSet2.MonitorByChartLimited, HChartNumber)
        Me.DxByCHartTableAdapter.FillByChart(Me.MMDataDataSet2.DxByCHart, HChartNumber)
        TabControl1.SelectedIndex = 0
        Me.Text = "Health History"
        Me.Text = Me.Text + "   " + HChartNumber

        If DOBTextBox.Text <> "" Then
            txtAge.Text = GetAge(DOBTextBox.Text)
        End If
       
    End Sub
      'Public Sub ShowHistory(ByVal PChn As String, ByVal PName As String, ByVal PDOB As String)
    Public Function ShowHistory(ByVal bRet() As String, ByVal arrayAssignedProviderMDI() As String) As String()

        aRet = bRet
        arrayAssignedProvider = arrayAssignedProviderMDI
        HChartNumber = bRet(1)
        'HName = bRet(1)
        'HDOB = bRet(1)


        Me.ShowDialog()
        ' Return
        ' Exit Function

    End Function


      Private Sub MMCHHealthHistoryShortBindingSource_AddingNew1(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMCHHealthHistoryShortBindingSource.AddingNew

        If ChartNumberTextBox.Text = "" Then
            Me.MMDataDataSet1.MMCHHealthHistoryShort.ChartNoColumn.DefaultValue = aRet(1)
            Me.MMDataDataSet1.MMCHHealthHistoryShort.FirstNameColumn.DefaultValue = aRet(3)
            Me.MMDataDataSet1.MMCHHealthHistoryShort.LastNameColumn.DefaultValue = aRet(2)
            Me.MMDataDataSet1.MMCHHealthHistoryShort.DateofBirthColumn.DefaultValue = aRet(6)
            Me.MMDataDataSet1.MMCHHealthHistoryShort.SEXColumn.DefaultValue = aRet(7)
            Me.MMDataDataSet1.MMCHHealthHistoryShort.TimeStampColumn.DefaultValue = System.DateTime.Today
            Me.MMDataDataSet1.MMCHHealthHistoryShort.UserIDColumn.DefaultValue = globalUser
        End If
      End Sub

   

    Private Sub HealthHistory_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.MMCHHealthHistoryShortBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            ' See if any changes were made, but not saved 
            If Me.MMDataDataSet1.MMCHHealthHistoryShort.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                'msgText = msgText & ControlChars.CrLf & _
                '"If you have deleted students, deleting them from the database will delete all courses and grades for the student."
                'msgText = msgText & ControlChars.CrLf & "Save the changes ?"

                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.MMCHHealthHistoryShortTableAdapter.Update(Me.MMDataDataSet1.MMCHHealthHistoryShort)

                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.MMCHHealthHistoryShort.RejectChanges()

                    Case Else
                        ' do nothing and cancel closing of the form
                        e.Cancel = True

                End Select
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Students form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim Dt As String = "07/25/2007"
        ' TextBox1.Text = ChartNumberTextBox.Text

        Me.VisitreportTableAdapter.FillByCHAndDate(Me.MMDataDataSet1.VisitReport, ChartNumberTextBox.Text, DateMaskedTextBox.Text)
        Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text, DateMaskedTextBox.Text)
        Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, ChartNumberTextBox.Text, DateMaskedTextBox.Text)
        Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, ChartNumberTextBox.Text, DateMaskedTextBox.Text)
        Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)



        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub MMChartVisitDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMChartVisitDataGridView.SelectionChanged
        If MMChartVisitDataGridView.SelectedRows.Count Then

            TextBox1.Text = MMChartVisitDataGridView.SelectedRows(0).Cells("ChartNumber").Value
            DateMaskedTextBox.Text = MMChartVisitDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumnDate").Value


            'On Error Resume Next
            Me.VisitreportTableAdapter.FillByCHAndDate(Me.MMDataDataSet1.VisitReport, TextBox1.Text, DateMaskedTextBox.Text)
            Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, TextBox1.Text, DateMaskedTextBox.Text)
            Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, TextBox1.Text, DateMaskedTextBox.Text)
            Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, TextBox1.Text, DateMaskedTextBox.Text)
            Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)

            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click


        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Try
            sAction = "VisitTemplate"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then
            Else
                Exit Sub
            End If


            If ChartNumberTextBox.Text.Trim = "" Then
                MessageBox.Show("You may not add a Visit without a Chart.")
            Else
                Visit2.ShowVisitHistory(aRet, arrayAssignedProvider)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try


    End Sub

    
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.MMCHDxRxLtMtTableAdapter.FillbyCh(Me.MMDataDataSet1.MMCHDxRxLtMt, HChartNumber)
        Me.MMChartRxTableAdapter.FillByChOrderbyStatus(Me.MMDataDataSet1.MMChartRx, HChartNumber)

        Me.MMCHHealthHistoryShortTableAdapter.FillbyCh(Me.MMDataDataSet1.MMCHHealthHistoryShort, HChartNumber)

        If Me.MMCHHealthHistoryShortBindingSource.Count > 0 Then
            BindingNavigatorAddNewItem.Enabled = False
        End If

        TextBox1.Text = ChartNumberTextBox.Text
        Me.MMChartVisitTableAdapter.FillByCh(Me.MMDataDataSet1.MMChartVisit, HChartNumber)
    End Sub


    Private Sub MMCHRosAndGenDataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMCHRosAndGenDataGridView1.DoubleClick

        If MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("CategoryDataGridViewTextBoxColumn").Value.ToString.ToLower = "past hx" Then
            If PMHXTextBox.Text = "" Then
                PMHXTextBox.Text = MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("DiscriptionDataGridViewTextBoxColumn").Value & ""
            Else
                PMHXTextBox.Text = PMHXTextBox.Text & ",  " & MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("DiscriptionDataGridViewTextBoxColumn").Value & ""
            End If

        ElseIf MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("CategoryDataGridViewTextBoxColumn").Value.ToString.ToLower = "family hx" Then
            If FMHXTextBox.Text = "" Then
                FMHXTextBox.Text = MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("DiscriptionDataGridViewTextBoxColumn").Value & ""
            Else
                FMHXTextBox.Text = FMHXTextBox.Text & ",  " & MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("DiscriptionDataGridViewTextBoxColumn").Value & ""
            End If

        ElseIf MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("CategoryDataGridViewTextBoxColumn").Value.ToString.ToLower = "social hx" Then
            If SHXTextBox.Text = "" Then
                SHXTextBox.Text = MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("DiscriptionDataGridViewTextBoxColumn").Value & ""
            Else
                SHXTextBox.Text = SHXTextBox.Text & ",  " & MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("DiscriptionDataGridViewTextBoxColumn").Value & ""
            End If

        ElseIf MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("CategoryDataGridViewTextBoxColumn").Value.ToString.ToLower = "surgical hx" Then
            If SRHXTextBox.Text = "" Then
                SRHXTextBox.Text = MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("DiscriptionDataGridViewTextBoxColumn").Value & ""
            Else
                SRHXTextBox.Text = SRHXTextBox.Text & ",  " & MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("DiscriptionDataGridViewTextBoxColumn").Value & ""
            End If
        ElseIf MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("CategoryDataGridViewTextBoxColumn").Value.ToString.ToLower = "allergies" Then
            If AllergiesTextBox.Text = "" Then
                AllergiesTextBox.Text = MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("DiscriptionDataGridViewTextBoxColumn").Value & ""
            Else
                AllergiesTextBox.Text = AllergiesTextBox.Text & ",  " & MMCHRosAndGenDataGridView1.SelectedRows(0).Cells("DiscriptionDataGridViewTextBoxColumn").Value & ""
            End If

        End If

        'ElseIf radOther.Checked = True Then

        '    Dim strOther As String
        '    strOther = NotesTestBox.Text
        '    If NotesTestBox.Text = "" Then
        '        NotesTestBox.Text = DataGridViewPr.SelectedRows(0).Cells(1).Value.ToString()
        '    Else
        '        NotesTestBox.Text = strOther + Environment.NewLine + DataGridViewPr.SelectedRows(0).Cells(1).Value.ToString
        '    End If
        'ElseIf radFollowUp.Checked = True Then

    End Sub


    Private Sub radFHX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFHX.CheckedChanged
        Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        dv.RowFilter = " Category = 'Family Hx'"
        dv.Sort = "ScreenLocation1"
        MMCHRosAndGenDataGridView1.DataSource = dv


    End Sub

    Private Sub radSHx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSHx.CheckedChanged
        Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        dv.RowFilter = " Category = 'Social Hx'"
        dv.Sort = "ScreenLocation1"
        MMCHRosAndGenDataGridView1.DataSource = dv
    End Sub

    Private Sub radPHX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPHX.CheckedChanged
        Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        dv.RowFilter = " Category = 'Past Hx'"
        dv.Sort = "ScreenLocation1"
        MMCHRosAndGenDataGridView1.DataSource = dv
    End Sub

    Private Sub SRHx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SRHx.CheckedChanged
        Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        dv.RowFilter = " Category = 'Surgical Hx'"
        dv.Sort = "ScreenLocation1"
        MMCHRosAndGenDataGridView1.DataSource = dv
    End Sub

    Private Sub radAllergies_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAllergies.CheckedChanged
        Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        dv.RowFilter = " Category = 'Allergies'"
        dv.Sort = "ScreenLocation1"
        MMCHRosAndGenDataGridView1.DataSource = dv
    End Sub


    Private Sub radAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAll.CheckedChanged
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMCHRosAndGen' table. You can move, or remove it, as needed.
        Me.MMCHRosAndGenTableAdapter.FillByCategoryDescriptionAll(Me.MMDataDataSet1.MMCHRosAndGen)
        Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        dv.RowFilter = ""
        MMCHRosAndGenDataGridView1.DataSource = dv
        dv.Sort = "Category"
        radAllergies.Checked = False
        radFHX.Checked = False
        radSHx.Checked = False
        radPHX.Checked = False
        SRHx.Checked = False
    End Sub
    Private Sub radMyDx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMyDx.CheckedChanged
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMCHRosAndGen' table. You can move, or remove it, as needed.
        Me.MMCHRosAndGenTableAdapter.FillByCategoryDescription(Me.MMDataDataSet1.MMCHRosAndGen, arrayAssignedProvider(0))
        Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
        dv.RowFilter = ""
        MMCHRosAndGenDataGridView1.DataSource = dv
        dv.Sort = "Category"
        radAllergies.Checked = False
        radFHX.Checked = False
        radSHx.Checked = False
        radPHX.Checked = False
        SRHx.Checked = False
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        aRet(1) = ChartNumberTextBox.Text
        Immunization.ShowImmunizations(aRet)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        ' BindingNavigatorAddNewItem.Visible = False


    End Sub


    'Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
    '    ' If cmbFilter.Text <> "" Then

    '    Me.MMCHRosAndGenDataGridView1.DataSource = "Discription" & " like" & "'" & txtFind.Text & "%'"
    '    'End If
    '    Me.MMCHRosAndGenBindingSource.Sort = "Discription"
    '    MMCHRosAndGenDataGridView1.DataSource = Me.MMCHRosAndGenBindingSource

    'End Sub

    


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


                                Panel2.Visible = False
                                Panel1.Visible = True
                                TabControl3.SelectedIndex = 0

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


                                Panel2.Visible = False
                                Panel1.Visible = True
                                TabControl3.SelectedIndex = 0

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
                                'Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, Text, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)

                            Case "Consent"


                                Panel2.Visible = False
                                Panel1.Visible = True
                                TabControl3.SelectedIndex = 0

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
                                'Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, Text, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)



                            Case Else

                                'ReportViewer1.Reset()
                                'Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                                'ReportDataSource1.Name = "MMDataDataSet1_MMCHARTViewChart"
                                'ReportDataSource1.Value = Me.MMCHARTViewChartBindingSource
                                'Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                                'Me.ReportViewer1.LocalReport.DisplayName = "View Chart"
                                'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Chart.rdlc"
                                'Me.MMCHARTViewChartBindingSource.DataMember = "MMCHARTViewChart"
                                'Me.MMCHARTViewChartBindingSource.DataSource = Me.MMDataDataSet1
                                'Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, ChartNumber, CaseNumber)
                                'Me.ReportViewer1.RefreshReport()
                                ''Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, Text, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)


                        End Select

                        If MonitorByChartDataGridView.SelectedRows(0).Cells("RecordSpecific").Value.ToString.ToLower.TrimEnd() = "image" Then

                            Panel1.Visible = False
                            Panel2.Visible = True
                            TabControl3.SelectedIndex = 1

                            If (MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value) <> "" Then
                                ' TabControl1.SelectedTab = TabControl1.TabPages(1)
                                picImage.Image = Image.FromFile(MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value)
                                picBoxSize()
                                picImage.SizeMode = PictureBoxSizeMode.StretchImage
                                strFilePath = MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value.ToString
                            Else
                                ' TabControl1.SelectedTab = TabControl1.TabPages(0)
                            End If

                        ElseIf MonitorByChartDataGridView.SelectedRows(0).Cells("RecordType2").Value.ToString.ToLower.TrimEnd() = "prescription" Then
                            'LoadPrescriptions(ChartNumber)

                        ElseIf MonitorByChartDataGridView.SelectedRows(0).Cells("RecordType2").Value.ToString.ToLower.TrimEnd() = "vital signs" Then
                            'LoadVitalSigns(ChartNumber)

                        ElseIf MonitorByChartDataGridView.SelectedRows(0).Cells("RecordSpecific").Value.ToString.ToLower.TrimEnd() = "tif" Then

                            Panel1.Visible = False
                            Panel2.Visible = True
                            TabControl3.SelectedIndex = 1

                            If (MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value) <> "" Then

                                '  TabControl1.SelectedTab = TabControl1.TabPages(3)
                                strFilePath = MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value.ToString
                                openImage(strFilePath)
                                '   LoadTiff((MMCentralMonitorDataGridView.SelectedRows(0).Cells("DocumentPath").Value))
                            Else
                                TabControl1.SelectedTab = TabControl1.TabPages(0)
                            End If


                        ElseIf MonitorByChartDataGridView.SelectedRows(0).Cells("RecordSpecific").Value.ToString.ToLower.TrimEnd() = "image" Then

                            Panel1.Visible = False
                            Panel2.Visible = True
                            TabControl3.SelectedIndex = 1

                            If (MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value) <> "" Then
                                ' TabControl1.SelectedTab = TabControl1.TabPages(1)
                                picImage.Image = Image.FromFile(MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value)
                                strFilePath = MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value.ToString
                            Else
                                ' TabControl1.SelectedTab = TabControl1.TabPages(0)
                            End If



                        Else
                            'TabControl1.SelectedTab = TabControl1.TabPages(0)
                        End If
                    End If
                End If
            End If
        Catch ex As System.IO.FileNotFoundException
            picImage.Image = Nothing
            MessageBox.Show("File could not be found: " & MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value, "Unable to Locate File")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            picImage.Image = Nothing
            MessageBox.Show(ex.ToString, "Image Could Not Be Displayed", MessageBoxButtons.OK)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub


    Private Sub openImage(ByVal strFilePath As String)
        'If strFilePath = "" Then
        '    cboFrameNo.Items.Clear()
        '    'OpenFileDialog1.ShowDialog()
        strFilePath = MonitorByChartDataGridView.SelectedRows(0).Cells("DocumentPath2").Value.ToString ' OpenFileDialog1.FileName.ToString

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
            lblTotal.Text = " / " & totFrame.ToString
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
            picImage.Image = Nothing
            MessageBox.Show("File could not be found: " & strFilePath.ToString, "Unable to Locate File")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch
            picImage.Image = Nothing
            MessageBox.Show("Tif could not be displayed.", "", MessageBoxButtons.OK)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub picBoxSize()
        picImage.Width = 600
        picImage.Height = 640
    End Sub

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

    Private Sub cmdRotate90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRotate90.Click
        picImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        picImage.Refresh()
    End Sub

    Private Sub cmdRotate270_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRotate270.Click
        picImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        picImage.Refresh()
    End Sub
  
    Private Sub btnZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoom.Click
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

    Private Sub btnUnZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnZoom.Click
        If checkPath() = True Then
            picImage.Width = CInt(picImage.Width / 1.25)
            picImage.Height = CInt(picImage.Height / 1.25)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cboFrameNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFrameNo.SelectedIndexChanged
        curF = cboFrameNo.Text
        If curF = totFrame - 1 Then
            btnNext.Enabled = True
            Exit Sub
        Else
            DisplayFrame()
        End If
    End Sub


    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        Try
            If radAllergies.Checked = True Then
                Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
                dv.RowFilter = " Category = 'Allergies' AND Discription LIKE '" & txtFind.Text & "%'"
                dv.Sort = "Discription"
                MMCHRosAndGenDataGridView1.DataSource = dv

            ElseIf radPHX.Checked = True Then
                Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
                dv.RowFilter = " Category = 'Past Hx' AND Discription LIKE '" & txtFind.Text & "%'"
                dv.Sort = "Discription"
                MMCHRosAndGenDataGridView1.DataSource = dv

            ElseIf radFHX.Checked = True Then
                Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
                dv.RowFilter = " Category = 'Family Hx' AND Discription LIKE '" & txtFind.Text & "%'"
                dv.Sort = "Discription"
                MMCHRosAndGenDataGridView1.DataSource = dv

            ElseIf radSHx.Checked = True Then
                Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
                dv.RowFilter = " Category = 'Social Hx' AND Discription LIKE '" & txtFind.Text & "%'"
                dv.Sort = "Discription"
                MMCHRosAndGenDataGridView1.DataSource = dv

            ElseIf SRHx.Checked = True Then
                Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
                dv.RowFilter = " Category = 'Surgical Hx' AND Discription LIKE '" & txtFind.Text & "%'"
                dv.Sort = "Discription"
                MMCHRosAndGenDataGridView1.DataSource = dv

            ElseIf radMyDx.Checked = True Then
                Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
                dv.RowFilter = "Discription LIKE '" & txtFind.Text & "%'"
                MMCHRosAndGenDataGridView1.DataSource = dv
                dv.Sort = "Category"

            ElseIf radAll.Checked = True Then
                Dim dv As DataView = Me.MMDataDataSet1.MMCHRosAndGen.DefaultView
                dv.RowFilter = "Discription LIKE '" & txtFind.Text & "%'"
                MMCHRosAndGenDataGridView1.DataSource = dv
                dv.Sort = "Category"
            End If

        Catch
        End Try
    End Sub

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        MonitorByChartLimitedBindingSource.Sort = "Recordtype ASC, Date Desc"
    End Sub

    Public Function GetAge(ByVal Birthdate As System.DateTime, Optional ByVal AsOf As System.DateTime = #1/1/1700#) As String

        Dim iMonths As Integer = 0
        Dim iYears As Integer = 0
        Dim dYears As Decimal
        Dim lDayOfBirth As Long
        Dim lAsOf As Long
        Dim iBirthMonth As Integer
        Dim iAsOFMonth As Integer
        Try
            If AsOf = "#1/1/1700#" Then
                AsOf = DateTime.Now
            End If
            lDayOfBirth = DatePart(DateInterval.Day, Birthdate)
            lAsOf = DatePart(DateInterval.Day, AsOf)

            iBirthMonth = DatePart(DateInterval.Month, Birthdate)
            iAsOFMonth = DatePart(DateInterval.Month, AsOf)

            iMonths = DateDiff(DateInterval.Month, Birthdate, AsOf)

            dYears = iMonths / 12

            iYears = Math.Floor(dYears)

            If iBirthMonth = iAsOFMonth Then
                If lAsOf < lDayOfBirth Then
                    iYears = iYears - 1
                End If
            End If

            Return iYears
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Function

    Private Sub btnVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisit.Click
        Me.MonitorByChartLimitedBindingSource.Filter = "RecordType like" & "'" & "Visit" & "%'"
        MonitorByChartDataGridView.DataSource = Me.MonitorByChartLimitedBindingSource
    End Sub

    Private Sub btnRadiology_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRadiology.Click
        Me.MonitorByChartLimitedBindingSource.Filter = "RecordType like 'Radiology%'"
        MonitorByChartDataGridView.DataSource = Me.MonitorByChartLimitedBindingSource
    End Sub

    Private Sub BTNLAB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNLAB.Click
        Me.MonitorByChartLimitedBindingSource.Filter = "RecordType like" & "'" & "Lab" & "%'"
        MonitorByChartDataGridView.DataSource = Me.MonitorByChartLimitedBindingSource
    End Sub

    Private Sub btnMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMessages.Click
        Me.MonitorByChartLimitedBindingSource.Filter = "RecordType like" & "'" & "Message" & "%'"
        MonitorByChartDataGridView.DataSource = Me.MonitorByChartLimitedBindingSource
    End Sub

    Private Sub btnLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLetter.Click
        Me.MonitorByChartLimitedBindingSource.Filter = "RecordType like" & "'" & "Letter" & "%'"
        MonitorByChartDataGridView.DataSource = Me.MonitorByChartLimitedBindingSource
    End Sub

    Private Sub btnAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAll.Click
        Me.MonitorByChartLimitedBindingSource.Filter = ""
        MonitorByChartDataGridView.DataSource = Me.MonitorByChartLimitedBindingSource
    End Sub

  
    Private Sub tsbVisitTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbVisitTemplate.Click
        If ChartNumberTextBox.Text.Trim = "" Then
            MessageBox.Show("You may not add a Visit without a Chart.")
        Else
            VisitTemplate.ShowVisitHistory(aRet, arrayAssignedProvider)
        End If
    End Sub

   
    Private Sub btnOfficeTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOfficeTest.Click
        Me.MonitorByChartLimitedBindingSource.Filter = "RecordType like" & "'" & "Office Test" & "%'"
        MonitorByChartDataGridView.DataSource = Me.MonitorByChartLimitedBindingSource
    End Sub

    Private Sub btnOutsideTests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOutsideTests.Click
        Me.MonitorByChartLimitedBindingSource.Filter = "RecordType like" & "'" & "Outside Test" & "%'"
        MonitorByChartDataGridView.DataSource = Me.MonitorByChartLimitedBindingSource
    End Sub

    Private Sub btnDemographics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDemographics.Click
        Me.MonitorByChartLimitedBindingSource.Filter = "RecordType like" & "'" & "Demographics" & "%'"
        MonitorByChartDataGridView.DataSource = Me.MonitorByChartLimitedBindingSource
    End Sub
End Class