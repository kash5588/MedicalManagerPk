Imports System.Data

Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.VisualBasic
Imports System.Configuration
Imports System.Text

Public Class Visit2
    Public data As DataSet
    Private m_CmdMMCHROSandGenCat As String = "SELECT MMCHROSandGenCat.Category FROM MMCHROSandGenCat"
    Private m_CmdMMCHRosAndGen As String = "SELECT  MMCHRosAndGen.MarkToEnter, MMCHRosAndGen.Discription, MMCHRosAndGen.qid, MMCHRosAndGen.ScreenLocation, MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory fROM MMCHRosAndGen"

    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(10) As String
    Dim fRet(4) As String
    Dim aForwarded(7) As String
    Dim HChartNumber, HName, HDOB As String

    Dim CounterROS As Integer
    Dim CounterPE As Integer
    Dim CounterTests As Integer
    Dim myBindingSource As New BindingSource()

    Dim arrayAssignedProvider(0) As String

    Dim counterposROSCONST As Integer
    Dim counterposROSCV As Integer
    Dim counterposROSCVSPulmonary As Integer
    Dim counterposROSEndocrine As Integer
    Dim counterposROSENT As Integer
    Dim counterposROSEyes As Integer
    Dim counterposROSFemaleGenital As Integer
    Dim counterposROSFemaleReproductive As Integer
    Dim counterposROSGeneral As Integer
    Dim counterposROSGI As Integer
    Dim counterposROSGU As Integer
    Dim counterposROSHEENT As Integer
    Dim counterposROSHEENT2 As Integer
    Dim counterposROSImmunological As Integer
    Dim counterposROSLymph As Integer
    Dim counterposROSMuscSkel As Integer
    Dim counterposROSNeuro As Integer
    Dim counterposROSNeuroEyes As Integer
    Dim counterposROSNormals As Integer
    Dim counterposROSPulmonary As Integer
    Dim counterposROSResp As Integer
    Dim counterposROSSkin As Integer
    Dim counterposROSSkinMS As Integer
    Dim counterposROSUrinary As Integer
    Dim counterposROSVestibular As Integer
    Dim counterposROSChest As Integer

    Dim counterposPENormals As Integer
    Dim counterposPEAbd As Integer
    Dim counterposPEBack As Integer
    Dim counterposPECV As Integer
    Dim counterposPECVS As Integer
    Dim counterposPEENT As Integer
    Dim counterposPEExtremities As Integer
    Dim counterposPEEyes As Integer
    Dim counterposPEFemale As Integer
    Dim counterposPEGeneral As Integer
    Dim counterposPEGenitals As Integer
    Dim counterposPEHeadNeck As Integer
    Dim counterposPEHEENT As Integer
    Dim counterposPEMale As Integer
    Dim counterposPEMouthThroat As Integer
    Dim counterposPENeckChest As Integer
    Dim counterposPEPelvicExam As Integer
    Dim counterposPEPSYCH As Integer
    Dim counterposPEPulm As Integer
    Dim counterposPERectal As Integer
    Dim counterposPERespiratory As Integer
    Dim counterposPESkin As Integer
    Dim counterposPEMS As Integer
    Dim counterposPEGait As Integer
    Dim counterposPEGU As Integer
    Dim counterposPEGI As Integer
    Dim counterposPEMentalStatus As Integer
    Dim counterposPEMood As Integer
    Dim counterposPEBehavior As Integer
    Dim counterposPELymphatic As Integer
    Dim counterposPENeurological As Integer
    Dim counterposPENeck As Integer

    Dim rowIndex As String
    Dim aPickCC(2) As String

    Private Sub Visit2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

 
    '  Dim strTemplate As String

    Private Sub Visit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
            Me.CCProfilesTableAdapter.Fill(Me.DprofilesDataSet.CCProfiles)
            LoadComboBoxes2()
            Me.MMChartVisitTableAdapter.FillByCh(Me.MMDataDataSet1.MMChartVisit, HChartNumber)
            Dim D As String = Me.MMDataDataSet1.MMChartVisit.Rows(0)("Date").ToString()

            Me.MMCHROSandGenCatTableAdapter.Fill(Me.MMDataDataSet1.MMCHROSandGenCat)
            'Me.MMCHRosAndGenTableAdapter.Fill(Me.MMDataDataSet1.MMCHRosAndGen)

            ' Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(HChartNumber), D) 'DateMaskedTextBox.Text
            ' Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CType(txtCopyCaseNumber.Text, Integer))
            Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CType(Me.MMDataDataSet1.MMChartVisit.Rows(0)("CaseNumber").ToString(), Integer))


            'Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(HChartNumber), D)
            'Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CType(txtCopyCaseNumber.Text, Integer))
            Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CType(Me.MMDataDataSet1.MMChartVisit.Rows(0)("CaseNumber").ToString(), Integer))

            ' Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, HChartNumber, D)
            ' Me.MMChartTVitalSignTableAdapter.FillByChNo(Me.MMDataDataSet1.MMChartTVitalSign, txtCopyChartNumber.Text)

            '***CHANGED***
            'TabControl3.SelectedIndex = 2
            'TabControl1.SelectedIndex = 0
            ' TabControl3.SelectedTab = ROSPETab
            TabControl1.SelectedTab = CCTab


            LoadPreviousMedications()

            Me.DataGridViewPr.Columns(0).Width = 70
            Me.DataGridViewPr.Columns(1).Width = 347

            If DOBTextBox.Text <> "" Then
                txtAge.Text = GetAge(DOBTextBox.Text)
            End If

            LockControls()
            LoadHealthMonitor()

        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
            MessageBox.Show("If no previous visit exists for " & HChartNumber & ". Please add a new visit.", "Add new visit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '***CHANGED***
            'TabControl1.SelectedIndex = 0
            TabControl1.SelectedTab = CCTab
        End Try
        TextBox2.Text = ChiefComplaintTextBox.Text
        '***CHANGED***
        ' TabControl1.SelectedIndex = 0
        TabControl1.SelectedTab = CCTab
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        ' On Error Resume Next
        Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(ChartNumberTextBox.Text), txtCopyDate.Text)
        Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(ChartNumberTextBox.Text), txtCopyDate.Text)
        Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text, txtCopyDate.Text)
    End Sub

    Private Sub txtCopyDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCopyDate.TextChanged
        Try
            'cmdRefresh.PerformClick()
            RefreshProcedures()
            RetrieveBodySketch()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function RefreshProcedures()
        Try
            Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(txtCopyChartNumber.Text), txtCopyDate.Text)
            ' Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(txtCopyChartNumber.Text), txtCopyDate.Text)
            Me.MMCHDxRxLtMtTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMCHDxRxLtMt, txtCopyCaseNumber.Text)
            Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, txtCopyChartNumber.Text, txtCopyDate.Text)
            Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CType(txtCopyCaseNumber.Text, Integer))
        Catch ex As System.Exception

        End Try

    End Function

    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        Dim FrmProcedure As New Procedure
        Try
            aRet = PATIENT.ShowPicklist
            If aRet(0) = "Y" Then
                ChartNumberTextBox.Text = aRet(1)
                LastNameTextBox.Text = aRet(2)
                FirstNameTextBox.Text = aRet(3)
                DOBTextBox.Text = aRet(7)
                DateMaskedTextBox.Text = System.DateTime.Today.ToShortDateString
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Function ShowVisitHistory(ByVal bRet() As String, ByVal arrayAssignedProviderMDI() As String) As String()
        Try
            fRet = bRet
            arrayAssignedProvider = arrayAssignedProviderMDI
            HChartNumber = bRet(1)
            'HName = bRet(1)
            'HDOB = bRet(1)


            Me.ShowDialog()
            ' Return
            ' Exit Function
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Function

    Private Sub AssPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssPr.Click
        Try
            Dim Physion As New Physician

            aRet = Physion.ShowPicklist
            If aRet(0) = "Y" Then

                AssignedProviderTextBox.Text = aRet(1)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RrfPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RrfPr.Click
        Try
            Dim RefPhysician As New ReferringPhysician
            aRet = RefPhysician.ShowPicklist
            If aRet(0) = "Y" Then
                ReferringProviderTextBox.Text = aRet(1)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Private Sub DateMaskedTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateMaskedTextBox.TextChanged
    '    cmdRefresh.PerformClick()
    'End Sub
    'Private Sub MMChartVisitBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMChartVisitBindingSource.CurrentChanged
    '    Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(ChartNumberTextBox.Text), Me.MMDataDataSet1.MMChartVisit.Rows(0)("Date").ToString())
    '    Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(ChartNumberTextBox.Text), Me.MMDataDataSet1.MMChartVisit.Rows(0)("Date").ToString())

    '    Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text, Me.MMDataDataSet1.MMChartVisit.Rows(0)("Date").ToString())
    'End Sub

    'Private Sub MMChartVisitBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMChartVisitBindingSource.PositionChanged
    '    Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(ChartNumberTextBox.Text), Me.MMDataDataSet1.MMChartVisit.Rows(0)("Date").ToString())
    '    Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(ChartNumberTextBox.Text), Me.MMDataDataSet1.MMChartVisit.Rows(0)("Date").ToString())

    '    Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text, Me.MMDataDataSet1.MMChartVisit.Rows(0)("Date").ToString())
    'End Sub

    Private Sub MMChartVisitBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMChartVisitBindingSource.AddingNew

        'If ChartNumberTextBox.Text = "" Then
        Me.MMDataDataSet1.MMChartVisit.ChartNumberColumn.DefaultValue = fRet(1)
        Me.MMDataDataSet1.MMChartVisit.FirstNameColumn.DefaultValue = fRet(3)
        Me.MMDataDataSet1.MMChartVisit.LastNameColumn.DefaultValue = fRet(2)
        Me.MMDataDataSet1.MMChartVisit.DOBColumn.DefaultValue = fRet(6)
        Me.MMDataDataSet1.MMChartVisit.TimeStampColumn.DefaultValue = System.DateTime.Today
        Me.MMDataDataSet1.MMChartVisit.DateColumn.DefaultValue = System.DateTime.Today
        Me.MMDataDataSet1.MMChartVisit.AssignedProviderColumn.DefaultValue = arrayAssignedProvider(0)
        Me.MMDataDataSet1.MMChartVisit.UserNameColumn.DefaultValue = globalUser
        On Error Resume Next
        cmdRefresh.PerformClick()


    End Sub

    Private Sub DataGridViewPr_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewPr.DoubleClick

        Try

            If RadioButtonDx.Checked = True Then
                '  newRow("Type") = "DX"
                If TextBoxDx1.Text = "" Then
                    TextBoxDx1.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    Dx1DescriptionTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value & ""
                ElseIf TextBoxDx2.Text = "" Then
                    TextBoxDx2.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    Dx2DescriptionTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value & ""
                ElseIf TextBoxDx3.Text = "" Then
                    TextBoxDx3.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    Dx3DescriptionTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value & ""
                ElseIf TextBoxDx4.Text = "" Then
                    TextBoxDx4.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    Dx4DescriptionTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value & ""
                Else
                    If Dx5DescriptionTextBox.Text = "" Then
                        Dx5DescriptionTextBox.Text = Trim(DataGridViewPr.SelectedRows(0).Cells(0).Value) & ControlChars.Tab & DataGridViewPr.SelectedRows(0).Cells("Description").Value
                    Else
                        Dx5DescriptionTextBox.Text += Environment.NewLine
                        Dx5DescriptionTextBox.Text += Trim(DataGridViewPr.SelectedRows(0).Cells(0).Value) & ControlChars.Tab & DataGridViewPr.SelectedRows(0).Cells("Description").Value
                    End If
                    Dx5DescriptionTextBox.SelectionStart = Dx5DescriptionTextBox.TextLength
                    Dx5DescriptionTextBox.ScrollToCaret()
                End If

            ElseIf radOther.Checked = True Then

                Dim strOther As String
                strOther = NotesTestBox.Text
                If NotesTestBox.Text = "" Then
                    NotesTestBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    NotesTestBox.Text = strOther + Environment.NewLine + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If

            ElseIf radProcedureNotes.Checked = True Then

                Dim strOther As String
                strOther = NotesTestBox.Text
                If NotesTestBox.Text = "" Then
                    NotesTestBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    NotesTestBox.Text = strOther + Environment.NewLine + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If

            ElseIf radFollowUp.Checked = True Then
                Dim strFollowup As String
                strFollowup = TextBoxfollowUp.Text
                If TextBoxfollowUp.Text = "" Then
                    TextBoxfollowUp.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    TextBoxfollowUp.Text = strFollowup + ", " + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If

            ElseIf radDiet.Checked = True Then
                Dim strDiet As String
                strDiet = TextBoxDiet.Text
                If TextBoxDiet.Text = "" Then
                    TextBoxDiet.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    TextBoxDiet.Text = strDiet + ", " + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If


            ElseIf radCounseling.Checked = True Then
                Dim strCounseling As String
                strCounseling = TextBoxCounselingEducation.Text
                If TextBoxCounselingEducation.Text = "" Then
                    TextBoxCounselingEducation.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    TextBoxCounselingEducation.Text = strCounseling + ", " + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If

            ElseIf radPlan.Checked = True Then
                Dim strPlan As String
                strPlan = PlanTextBox.Text
                If PlanTextBox.Text = "" Then
                    PlanTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    PlanTextBox.Text = strPlan + ", " + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If

            ElseIf radImpressions.Checked = True Then
                Dim strImpressions As String
                strImpressions = ImpressionTextBox.Text
                If ImpressionTextBox.Text = "" Then
                    ImpressionTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    ImpressionTextBox.Text = strImpressions + ", " + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If

            ElseIf RadioButtonCC.Checked = True Then
                Dim strCC As String
                strCC = ChiefComplaintTextBox.Text
                If ChiefComplaintTextBox.Text = "" Then
                    ChiefComplaintTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("ChiefComplaint").Value.ToString()
                Else
                    ChiefComplaintTextBox.Text = strCC + ", " + DataGridViewPr.SelectedRows(0).Cells("ChiefComplaint").Value.ToString
                End If
                ChiefComplaintTextBox.SelectionStart = ChiefComplaintTextBox.TextLength
                ChiefComplaintTextBox.ScrollToCaret()
                'TextBox1.Focus()

            ElseIf radChronic.Checked = True Then
                Dim strChronic As String
                strChronic = ChronicConditionsTextBox.Text
                If ChronicConditionsTextBox.Text = "" Then
                    ChronicConditionsTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("ChiefComplaint").Value.ToString()
                Else
                    ChronicConditionsTextBox.Text = strChronic + ", " + DataGridViewPr.SelectedRows(0).Cells("ChiefComplaint").Value.ToString
                End If
                ChronicConditionsTextBox.SelectionStart = ChronicConditionsTextBox.TextLength
                ChronicConditionsTextBox.ScrollToCaret()

            Else 'RadioButtonDx.Checked = False Then
                CounterTests += 1
                Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
                newRow("CHARTNUMBER") = ChartNumberTextBox.Text
                newRow("Date") = DateMaskedTextBox.Text 'System.DateTime.Now.Date
                newRow("CaseNumber") = CaseNumberTextBox.Text
                newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value
                newRow("Description") = DataGridViewPr.SelectedRows(0).Cells("Description").Value
                newRow("Amount") = DataGridViewPr.SelectedRows(0).Cells(2).Value
                newRow("Type") = DataGridViewPr.SelectedRows(0).Cells("Type").Value
                newRow("UserID") = globalUser
                newRow("InHouse") = DataGridViewPr.SelectedRows(0).Cells("InHouse").Value
                newRow("InHouseBilling") = DataGridViewPr.SelectedRows(0).Cells("InHouseBilling").Value
                newRow("Timestamp") = System.DateTime.Now.Date

                'If RadioButtonPr.Checked = True Then
                '    newRow("Type") = DataGridViewPr.SelectedRows(0).Cells("Type").Value
                '    'newRow("Type") = "PR"
                'ElseIf RadioButtonMT.Checked = True Then
                '    newRow("Type") = DataGridViewPr.SelectedRows(0).Cells("Type").Value
                '    'newRow("Type") = "MEDTEST"
                'ElseIf RadioButtonTestImaging.Checked = True Then
                '    newRow("Type") = DataGridViewPr.SelectedRows(0).Cells("Type").Value
                '    'newRow("Type") = "IMAGING"
                'ElseIf RadioButtonLT.Checked = True Then
                '    newRow("Type") = DataGridViewPr.SelectedRows(0).Cells("Type").Value
                '    'newRow("Type") = "LABTEST"
                'End If

                Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)
                Me.MMCHDxRxLtMtTableAdapter.Update(Me.MMDataDataSet1.MMCHDxRxLtMt)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Patient form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
    End Sub


    Private Sub MMChartVisitBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartVisitBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MMChartVisitBindingSource.EndEdit()
            Me.MMChartVisitTableAdapter.Update(Me.MMDataDataSet1.MMChartVisit)
            txtMode.Text = "Saved"
            BindingNavigatorAddNewItem.Visible = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub FillCNToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillCNToolStripButton.Click
    '    Try
    '        Me.MMChartVisitTableAdapter.FillByCh(Me.MMDataDataSet1.MMChartVisit, Trim(ChartNumberToolStripTextBox.Text))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try
    '    Dim s As String
    '    Me.MMCHDxRxLtMtTableAdapter.FillbyCh(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(ChartNumberToolStripTextBox.Text))
    '    Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(ChartNumberToolStripTextBox.Text), DateMaskedTextBox.Text)



    '    Dim connString As String = _
    '               "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MMData.mdb"
    '    Dim cn As New OleDbConnection(connString)
    '    cn.Open()
    '    '' read the number of rows
    '    Dim cmd As New OleDbCommand("SELECT *  FROM MMCHARTCONTENTS", cn)
    '    Dim myData As OleDbDataReader = cmd.ExecuteReader()
    '    Me.MMCHDxRxLtMtTableAdapter.FillbyCh(Me.MMDataDataSet1.MMCHDxRxLtMt, ChartNumberTextBox.Text)
    '    ' New System.Nullable(Of Date)(CType(DateDateTimePicker.Text, Date)))
    'End Sub

    Private Sub Visit2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.MMChartVisitBindingSource.EndEdit()
                Me.MMCHDxRxLtMtBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            ' See if any changes were made, but not saved 
            If Me.MMDataDataSet1.MMChartVisit.GetChanges() IsNot Nothing Or Me.MMDataDataSet1.MMCHDxRxLtMt.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.MMChartVisitTableAdapter.Update(Me.MMDataDataSet1.MMChartVisit)
                        Me.MMCHDxRxLtMtTableAdapter.Update(Me.MMDataDataSet1.MMCHDxRxLtMt)
                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.MMChartVisit.RejectChanges()
                    Case Else
                        ' do nothing and cancel closing of the form
                        e.Cancel = True
                End Select
            End If
            globalTemplate = ""
            globalChiefComplaint = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Patient form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try
        ' Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.MMChartVisitTableAdapter.FillByCh(Me.MMDataDataSet1.MMChartVisit, ChartNumberToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        ' Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Normals")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub gridCustOrders_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub

    Private Sub FillToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Normals")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Normals")
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RV.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ' On Error Resume Next
        RV.ShowVisit(txtCopyChartNumber.Text, txtCopyDate.Text, txtCopyCaseNumber.Text, "visit")
        ' Form6.ShowVisit(ChartNumberTextBox.Text, DateMaskedTextBox.Text)
        'Dim previewForm As New RV
        'Dim reportName As String
        'reportName = "ChartSummary.rdlc"
        'If reportName = "" Then
        '    MessageBox.Show("Non-existant report requested", "View Report", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'End If
        ''Dim id As String = dgInventory.Rows(dgInventory.SelectedRows(0).Index).Cells(0).Value
        'If reportName <> "" Then
        '    ' previewForm.ShowVisitSummery(reportName, ChartNumberToolStripTextBox.Text, CaseNumberTextBox.Text)
        'End If
        'Form6.Show()
    End Sub

    Private Sub ReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.MMChartVisitTableAdapter.FillByChCa(Me.MMDataDataSet1.MMChartVisit, ChartNumberToolStripTextBox.Text, CaseNumberTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        '  Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim RetVal
        RetVal = Shell("C:\Windows\system32\sndrec32.exe", 1)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        '***CHANGED***

        'If TabControl1.SelectedIndex = 3 Then
        '    If TabControl3.SelectedIndex = 2 Then
        '    Else
        '        TabControl3.SelectedIndex = 1
        '    End If
        'End If

        'If TabControl1.SelectedIndex = 2 Then
        '    If TabControl3.SelectedIndex = 2 Then
        '    Else
        '        TabControl3.SelectedIndex = 0
        '        ComboBox1.Text = "ROS-Normals"
        '    End If

        'End If
        'If TabControl1.SelectedIndex = 4 Then
        '    TabControl3.SelectedIndex = 3
        '    DataGridViewPr.DataSource = Nothing
        'End If

        'If TabControl1.SelectedIndex = 5 Then
        '    TabControl3.SelectedIndex = 3
        '    TabControl1.SelectedIndex = 5
        '    DataGridViewPr.DataSource = Nothing
        'End If


        If TabControl1.SelectedTab.Text = "PE" Then
            If TabControl3.SelectedTab.Text = "ROS / PE" Then
            Else
                TabControl3.SelectedTab = PENrmTab
                'added 02/2012
                tvwDB.Visible = False
            End If
        End If

        If TabControl1.SelectedTab.Text = "ROS " Then
            If TabControl3.SelectedTab.Text = "ROS / PE" Then
            Else
                TabControl3.SelectedTab = RosNrmTab
                Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "Ros-Normals")
                'Me.MMCHRosAndGenDataGridView.Columns(0).Width = 50
                'Me.MMCHRosAndGenDataGridView.Columns(1).Width = 225
                'Me.MMCHRosAndGenDataGridView.Columns(2).Width = 138

                'added 02/2012
                tvwDB.Visible = False

                ApplyColorToNormalsGrid()
                ComboBox1.Text = "ROS-Normals"
            End If

        End If
        If TabControl1.SelectedTab.Text = "Dx/Pr/Tests" Then
            TabControl3.SelectedTab = DxPrTestsPickTab
            DataGridViewPr.DataSource = Nothing
            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                LoadMyList()
            End If
        End If

        If TabControl1.SelectedTab.Text = "Rx" Then
            TabControl3.SelectedTab = DxPrTestsPickTab
            TabControl1.SelectedTab = RxTab
            DataGridViewPr.DataSource = Nothing
        End If

        If TabControl1.SelectedTab.Text = "Other Notes" Then
            TabControl3.SelectedTab = DxPrTestsPickTab
            DataGridViewPr.DataSource = Nothing
        End If

    End Sub

    Private Sub TabControl3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl3.SelectedIndexChanged
        Try
            '***CHANGED***
            'If TabControl3.SelectedIndex = 0 Then

            '    ComboBox1.Text = "Ros-Normals"
            '    Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "Ros-Normals")


            '    TabControl1.SelectedIndex = 2
            'End If

            'If TabControl3.SelectedIndex = 1 Then

            '    ComboBox1.Text = "PE-(Normals)"
            '    Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-(Normals)")
            '    TabControl1.SelectedIndex = 3
            'End If

            ''If TabControl3.SelectedIndex = 3 Then
            ''    TabControl1.SelectedIndex = 4
            ''End If


            If TabControl3.SelectedTab.Text = "ROS-Normals" Then

                ComboBox1.Text = "Ros-Normals"
                Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "Ros-Normals")
                ApplyColorToNormalsGrid()

                TabControl1.SelectedTab = ROSTab
            End If

            If TabControl3.SelectedTab.Text = "PE-Normals" Then

                ComboBox1.Text = "PE-(Normals)"
                Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "PE-(Normals")
                'Me.DataGridView1.Columns(0).Width = 50
                'Me.DataGridView1.Columns(1).Width = 225
                'Me.DataGridView1.Columns(2).Width = 138
                ApplyColorToNormalsGrid()
                TabControl1.SelectedTab = PETab
            End If

            'If TabControl3.SelectedIndex = 3 Then
            '    TabControl1.SelectedIndex = 4
            'End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        On Error Resume Next
        Dim st, st2 As String
        st = ComboBox1.Text
        If st = "CC" Then
            st = "CC "
        End If
        Select Case st.Substring(0, 3)
            Case "PE-"
                If DataGridView1.SelectedRows.Count Then
                    PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & ControlChars.CrLf & DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells("PEDiscription").Value & ControlChars.CrLf
                    CounterPE += 1
                    PEcount.Text = CounterPE
                End If
        End Select
    End Sub

    Private Sub MMCHRosAndGenDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMCHRosAndGenDataGridView.SelectionChanged
        Try
            If MMCHRosAndGenDataGridView.SelectedRows.Count Then
                ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells("ROSDiscription").Value & ControlChars.CrLf
                CounterROS += 1
                RosCount.Text = CounterROS
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'On Error Resume Next
        'Dim st, st2 As String
        'st = ComboBox1.Text
        'If st = "CC" Then
        '    st = "CC "
        'End If
        'Select Case st.Substring(0, 3)
        '    'if vb.Left(Catlistbox.text
        '    Case "ROS", "Ros"
        '        ReviewOfSystemsTextBox = ReviewOfSystemsTextBox.Text & ControlChars.CrLf & DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(2).Value & ControlChars.CrLf

        '        'Case "PE-"

        '        '    PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & ControlChars.CrLf & DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(2).Value & ControlChars.CrLf
        'End Select
        ' PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(2).Value & ControlChars.CrLf


        'On Error Resume Next
        'Dim st, st2 As String


        'If st = "CC" Then
        '    st = "CC "
        'End If


        '' Select Case st.Substring(0, 3)
        'Select Case ComboBox1.Text.Substring(0, 3)

        '    'if vb.Left(Catlistbox.text
        '    Case "ROS"


        '        ReviewOfSystemsTextBox.Text = "    " & ReviewOfSystemsTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value & ControlChars.CrLf

        '    Case "PE-"

        '        PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(2).Value & ControlChars.CrLf


        '    Case "CC "


        '        ChiefComplaintTextBox.Text = ChiefComplaintTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value

        '    Case "Pro"

        '        'ProblemListTextBox.Text = ProblemListTextBox.Text + "  " + MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value


        '    Case "Dia"


        '        'DxTextBox.Text = DxTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value

        '    Case "Rx"

        '        'RxTextBox.Text = RxTextBox.Text + "  " + MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value

        '    Case Else
        '        'OtherNotesTextBox.Text = OtherNotesTextBox.Text & "   " & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value & ControlChars.CrLf

        '        'ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text + Me.MMDataDataSet.MMCHRosAndGen("Description").Discription
        'End Select
    End Sub

    Private Sub TabPage7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HPITab.Click

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROSTab.Click
        RosGeneral.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RosGeneral.Show()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PhysicalExamination.Show()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(e.ToString)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TempR.Checked = True Then
            TempTextBox.Text = TempTextBox.Text & ListBox1.Text
        ElseIf RespR.Checked = True Then
            RespTextBox.Text = RespTextBox.Text & ListBox1.Text
        ElseIf PulseOxR.Checked = True Then
            PulseOxTextBox.Text = PulseOxTextBox.Text & ListBox1.Text
        ElseIf PulseR.Checked = True Then
            PulseTextBox.Text = PulseTextBox.Text & ListBox1.Text
        ElseIf HTR.Checked = True Then
            HtTextBox.Text = HtTextBox.Text & ListBox1.Text
        ElseIf WTR.Checked = True Then
            WtTextBox.Text = WtTextBox.Text & ListBox1.Text
        ElseIf SystolicR.Checked = True Then
            SystolicTextBox.Text = SystolicTextBox.Text & ListBox1.Text
        ElseIf SystolicR.Checked = True Then
            SystolicTextBox.Text = SystolicTextBox.Text & ListBox1.Text
        ElseIf DistolicR.Checked = True Then
            DistolicTextBox.Text = DistolicTextBox.Text & ListBox1.Text

        End If


    End Sub

    Private Sub MMCHRosAndGenDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MMCHRosAndGenDataGridView.CellContentClick

        '    if MMCHRosAndGenDataGridView.Columns(e.ColumnIndex).GetType()= typeof(DataGridViewLinkColumn) then

        '        Process.Start(dataGridView1(e.ColumnIndex, e.RowIndex).Value.ToString
        'End If

    End Sub

    Private Sub LinkConstitunalP_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        MsgBox("A")
    End Sub

    Private Sub ConstitunalP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If ConstitutionalP.Checked = True Then
        '    ' Me.MMCHROSandGenCatBindingSource.Find("SubCategory" = "CONSTITUTIONAL")
        '    Me.MMCHROSandGenCatBindingSource.Filter = "SubCategory" = "'" & "CONSTITUTIONAL" & "'"
        '    MsgBox(Me.MMCHROSandGenCatBindingSource.Item(0).ToString)


        'End If


    End Sub

    Private Sub BindingNavigatorCountItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            RosGeneral.Show()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            RosGeneral.Show()
            'aRet = RosGeneral.ShowPicklist
            'If aRet(0) = "Y" Then

            '    ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text + " " + aRet(1)

            'End If
        Catch
        End Try
    End Sub

    'Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ' PhysicalExamination.Show()
    '    Try
    '        aRet = PhysicalExamination.ShowPicklist
    '        If aRet(0) = "Y" Then
    '            PhysicalExamTextBox.Text = PhysicalExamTextBox.Text + " " + aRet(1)
    '        End If
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub cmdmedSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.MMChartRxTableAdapter.Update(Me.MMDataDataSet1.MMChartRx)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Private Sub cmdMedications_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    aRet(1) = ChartNumberTextBox.Text
    '    aRet(2) = FirstNameTextBox.Text
    '    aRet(3) = LastNameTextBox.Text
    '    aRet(4) = ""
    '    Prescription.ShowPrescriptions(aRet)

    '    Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, aRet(1))

    'End Sub

    Private Sub HOPI_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HOPI.Enter

    End Sub

    Private Sub ChiefComplaintTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChiefComplaintTextBox.TextChanged
        'TextBox2.Text = ChiefComplaintTextBox.Text
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridViewPr_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If RadioButtonDx.Checked = True Then


                Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
                newRow("CHARTNUMBER") = ChartNumberTextBox.Text
                newRow("Date") = System.DateTime.Now.Date
                newRow("Type") = "DX"
                newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""

                Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

            ElseIf RadioButtonPr.Checked = True Then

                Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
                newRow("CHARTNUMBER") = ChartNumberTextBox.Text
                newRow("Date") = txtCopyDate.Text 'System.DateTime.Now.Date
                newRow("Type") = "Procedures"
                newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
                Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

            ElseIf RadioButtonLT.Checked = True Then

                Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
                newRow("CHARTNUMBER") = ChartNumberTextBox.Text
                newRow("Date") = System.DateTime.Now.Date
                newRow("Type") = "Lab Test"
                newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
                Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

            ElseIf RadioButtonMT.Checked = True Then

                Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
                newRow("CHARTNUMBER") = ChartNumberTextBox.Text
                newRow("Date") = System.DateTime.Now.Date
                newRow("Type") = "Medical Test"
                newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(1).Value & ""
                Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

            ElseIf RadioButtonTestImaging.Checked = True Then

                Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
                newRow("CHARTNUMBER") = ChartNumberTextBox.Text
                newRow("Date") = System.DateTime.Now.Date
                newRow("Type") = "Images"
                newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                newRow("Description") = DataGridViewPr.SelectedRows(0).Cells(2).Value & ""
                Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)


            End If

            Me.MMCHDxRxLtMtTableAdapter.Update(Me.MMDataDataSet1.MMCHDxRxLtMt)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.MMCHDxRxLtMtTableAdapter.Update(Me.MMDataDataSet1.MMCHDxRxLtMt)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim connString As String = _
        '                    "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\MMData.mdf;Integrated Security=True user instances=true"
        'Dim cn As New SqlConnection(connString)
        'cn.Open()
        '' read the number of rows
        'Dim cmd As New SqlCommand("SELECT  Code1, Description FROM MMDX order by Description", cn)
        'Dim da As New SqlDataAdapter
        'Dim tbl As New DataTable
        'Dim ds As New DataSet
        'da.SelectCommand = cmd
        'da.Fill(ds, "MMDX")
        'DataGridViewPr.DataSource = ds.Tables("MMDX")
        'ds.Dispose()
        'cn.Close()
    End Sub


    Private Sub RadioButtonDx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDx.CheckedChanged
        Try
            If RadioButtonDx.Checked = True Then
                'User Instance=True
                Dim connString As String = connString2
                'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString


                Dim cn As New SqlConnection(connString)
                cn.Open()
                ' read the number of rows
                Dim cmd As New SqlCommand("SELECT MMDX.Code1 AS Code, MMDX.Description FROM  MMDX LEFT JOIN  PhysicianProfile ON MMDX.Code1 = PhysicianProfile.Code WHERE  physiciancode = '" & AssignedProviderTextBox.Text & "' ORDER BY MMDX.Description", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMDX")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource


                ' DataGridViewPr.DataSource = ds.Tables("MMDX")

                ds.Dispose()
                cn.Close()
                If globalTemplate <> "" Then
                    radTemplateDX.Checked = True
                    LoadTemplateSpecificDxPrTests()
                Else
                    radMyDx.Checked = True
                End If
                ' radMyDx.Checked = True
                '***CHANGED***
                TabControl3.SelectedTab = DxPrTestsPickTab
                TabControl1.SelectedTab = DxPrTestsTab
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        ' Me.DataGridViewPr.Columns(0).Width = 70
        ' Me.DataGridViewPr.Columns(1).Width = 355


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
        Try
            If RadioButtonMT.Checked = True Then

                'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                ' read the number of rows
                Dim cmd As New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMCHARTTESTMEDICAL order by Description", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMChartTestMedical")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource




                '  DataGridViewPr.DataSource = ds.Tables("MMChartTestMedical")
                ds.Dispose()
                cn.Close()

                Me.DataGridViewPr.Columns(0).Width = 70
                Me.DataGridViewPr.Columns(1).Width = 350
                Me.DataGridViewPr.Columns(2).Width = 0
                If globalTemplate <> "" Then
                    radTemplateDX.Checked = True
                    LoadTemplateSpecificDxPrTests()
                Else
                    radMyDx.Checked = True
                End If
                '***CHANGED***
                'TabControl3.SelectedIndex = 3
                'TabControl1.SelectedIndex = 4
                TabControl3.SelectedTab = DxPrTestsPickTab
                TabControl1.SelectedTab = DxPrTestsTab

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RadioButtonPr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonPr.CheckedChanged
        Try
            If RadioButtonPr.Checked = True Then
                'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                ' read the number of rows
                Dim cmd As New SqlCommand("SELECT Code1 As Code, MMPRocedure.Description, AmountA, MyProcedures, ScreenLocation, MMPRocedure.Type, InHouse, InHouseBilling  FROM   MMPRocedure LEFT JOIN PhysicianProfile ON MMPRocedure.Code1 = PhysicianProfile.Code where  physiciancode = '" & AssignedProviderTextBox.Text & "' order by Description", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMProcedure")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource

                '  DataGridViewPr.DataSource = ds.Tables("MMProcedure")
                ds.Dispose()
                cn.Close()
                Me.DataGridViewPr.Columns(0).Width = 70
                Me.DataGridViewPr.Columns(1).Width = 355
                Me.DataGridViewPr.Columns(2).Width = 50

                If globalTemplate <> "" Then
                    radTemplateDX.Checked = True
                    LoadTemplateSpecificDxPrTests()
                Else
                    radMyDx.Checked = True
                End If
                '***CHANGED***
                'TabControl3.SelectedIndex = 3
                'TabControl1.SelectedIndex = 4
                TabControl3.SelectedTab = DxPrTestsPickTab
                TabControl1.SelectedTab = DxPrTestsTab

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Profile_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Profile.Checked = True Then
        '    TabControl1.SelectedIndex = 3
        '    TabControl3.SelectedIndex = 2
        'End If
    End Sub

    'Private Sub cmdPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPost.Click
    'Try
    '    Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow

    '    If RadioButtonDx.Checked = True Then
    '        newRow("Type") = "DX"
    '    ElseIf RadioButtonPr.Checked = True Then

    '        newRow("Type") = "PR"
    '    ElseIf RadioButtonMT.Checked = True Then
    '        newRow("Type") = "MEDTEST"

    '    ElseIf Profile.Checked = True Then
    '        Dim i As Integer
    '        Dim snr, snp As String
    '        Dim spr, spp As String
    '        Dim value As String
    '        Dim ss As String
    '        value = DataGridViewPr.Rows(i).Cells(0).Value
    '        ss = value.Substring(0, 3)

    '        For i = 0 To DataGridViewPr.RowCount - 1
    '            If DataGridViewPr.Rows(i).Cells(3).Value = True Then
    '                Select Case DataGridViewPr.Rows(i).Cells(0).Value.ToString.Substring(0, 3)
    '                    Case "ROS"
    '                        If snr = "" Then
    '                            snr = DataGridViewPr.Rows(i).Cells(2).Value
    '                        Else
    '                            snr = snr & ",  " & DataGridViewPr.Rows(i).Cells(2).Value
    '                        End If
    '                    Case "PE-"
    '                        If snp = "" Then
    '                            snp = DataGridViewPr.Rows(i).Cells(2).Value
    '                        Else
    '                            snp = snp & ",  " & DataGridViewPr.Rows(i).Cells(2).Value
    '                        End If

    '                End Select
    '            End If

    '            If DataGridViewPr.Rows(i).Cells(4).Value = True Then
    '                Select Case DataGridViewPr.Rows(i).Cells(0).Value.ToString.Substring(0, 3)
    '                    Case "ROS"
    '                        If spr = "" Then
    '                            spr = DataGridViewPr.Rows(i).Cells(2).Value
    '                        Else
    '                            spr = spr & ",  " & DataGridViewPr.Rows(i).Cells(2).Value
    '                        End If
    '                    Case "PE-"
    '                        If spp = "" Then
    '                            spp = DataGridViewPr.Rows(i).Cells(2).Value
    '                        Else
    '                            spp = spp & ",  " & DataGridViewPr.Rows(i).Cells(2).Value
    '                        End If
    '                End Select
    '            End If
    '        Next

    '        'ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text + "NEGATIVE for " & snr & ControlChars.CrLf & "POSITIVE for " & spr
    '        'PhysicalExamTextBox.Text = PhysicalExamTextBox.Text + "NEGATIVE for " & snp & ControlChars.CrLf & "POSITIVE for " & spp

    '        If snr <> "" Then
    '            snr = "NEGATIVE for " & snr & ControlChars.CrLf
    '        End If
    '        If spr <> "" Then
    '            spr = "POSITIVE for " & spr & ControlChars.CrLf
    '        End If
    '        If snp <> "" Then
    '            snp = "NEGATIVE for " & snp & ControlChars.CrLf
    '        End If
    '        If spp <> "" Then
    '            spp = "POSITIVE for " & spp & ControlChars.CrLf
    '        End If
    '        ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text & snr & spr
    '        PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & snp & spp
    '    End If
    'Catch ex As System.Exception
    '    System.Windows.Forms.MessageBox.Show(ex.Message)
    'End Try

    'End Sub

    Private Sub cmdRNPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRNPost.Click
        Try
            Dim i As Integer
            For i = 0 To MMCHRosAndGenDataGridView.RowCount - 1
                If MMCHRosAndGenDataGridView.Rows(i).Cells(0).Value = True Then
                    ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(i).Cells(2).Value & ControlChars.CrLf
                    CounterROS += 1
                    RosCount.Text = CounterROS
                End If
            Next
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmdPNPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPNPost.Click
        Try
            Dim i As Integer
            For i = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Rows(i).Cells(0).Value = True Then
                    PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & ControlChars.CrLf & DataGridView1.Rows(i).Cells(2).Value & ControlChars.CrLf
                    CounterPE += 1
                    PEcount.Text = CounterPE
                End If
            Next
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmdHPI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHPI.Click
        Try
            Dim FrmProcedure As New Procedure

            aRet = HPI.ShowPicklist
            If aRet(0) = "Y" Then
                txtHPI.Text = aRet(1)
                TextBox2.Text = aRet(2)
                If ChiefComplaintTextBox.Text = "" Then
                    ChiefComplaintTextBox.Text = aRet(2)
                Else
                    ChiefComplaintTextBox.Text = ChiefComplaintTextBox.Text & ", " & aRet(2)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmdHPI2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHPI2.Click
        Try
            Dim FrmProcedure As New Procedure
            'aRet = frmCustomers.ShowPicklist
            ' frmCustomers.ShowDialog()
            aRet = HPI.ShowPicklist
            If aRet(0) = "Y" Then       ' they picked a lab
                txtHP2.Text = aRet(1)
                TextBox3.Text = aRet(2)
                If ChiefComplaintTextBox.Text = "" Then
                    ChiefComplaintTextBox.Text = aRet(2)
                Else
                    ChiefComplaintTextBox.Text = ChiefComplaintTextBox.Text & ", " & aRet(2)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmdHP3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHP3.Click
        Try
            Dim FrmProcedure As New Procedure
            'aRet = frmCustomers.ShowPicklist
            ' frmCustomers.ShowDialog()
            aRet = HPI.ShowPicklist
            If aRet(0) = "Y" Then       ' they picked a lab
                txtHP3.Text = aRet(1)
                TextBox5.Text = aRet(2)
                If ChiefComplaintTextBox.Text = "" Then
                    ChiefComplaintTextBox.Text = aRet(2)
                Else
                    ChiefComplaintTextBox.Text = ChiefComplaintTextBox.Text & ", " & aRet(2)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmdHPI4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHPI4.Click
        Try
            Dim FrmProcedure As New Procedure
            'aRet = frmCustomers.ShowPicklist
            ' frmCustomers.ShowDialog()
            aRet = HPI.ShowPicklist
            If aRet(0) = "Y" Then       ' they picked a lab
                txtHP4.Text = aRet(1)
                TextBox7.Text = aRet(2)
                If ChiefComplaintTextBox.Text = "" Then
                    ChiefComplaintTextBox.Text = aRet(2)
                Else
                    ChiefComplaintTextBox.Text = ChiefComplaintTextBox.Text & ", " & aRet(2)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Private Sub TemplateNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim itemFound As Integer = Me.CCProfilesBindingSource.Find("TemplateName", TemplateNameComboBox.Text)
    '    Me.CCProfilesBindingSource.Position = itemFound

    '    Dim connString As String = connString2
    '    Dim cn As New SqlConnection(connString)
    '    cn.Open()
    '    ' read the number of rows
    '    ' Dim cmd As New SqlCommand("SELECT  qid,ScreenLocation,Category,SubCategory,Discription,Negative,Positive FROM   MMCHRosAndGen where qid In(1505,1506)", cn)

    '    Dim strCodes, strTemplateName As String

    '    strTemplateName = DprofilesDataSet.Tables(0).Rows(Me.CCProfilesBindingSource.Position)("TemplateName")
    '    strCodes = DprofilesDataSet.Tables(0).Rows(Me.CCProfilesBindingSource.Position)("Codes")
    '    ' strCodes = "799,800,801,802,803,804,805,806,807,808,809"
    '    Dim cmd As New SqlCommand("SELECT Category,SubCategory,Discription,Negative,Positive,qid,ScreenLocation FROM   MMCHRosAndGen where qid In(" + strCodes + ")", cn)


    '    Dim da As New SqlDataAdapter
    '    Dim tbl As New DataTable
    '    Dim ds As New DataSet
    '    da.SelectCommand = cmd
    '    da.Fill(ds, "MMCHRosAndGen")
    '    DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
    '    DataGridViewPr.Columns(0).Width = 90
    '    DataGridViewPr.Columns(1).Width = 0
    '    DataGridViewPr.Columns(2).Width = 225
    '    DataGridViewPr.Columns(3).Width = 40
    '    DataGridViewPr.Columns(4).Width = 40


    '    DataGridViewPr.Columns(3).DefaultCellStyle.BackColor = Color.Cyan
    '    DataGridViewPr.Columns(4).DefaultCellStyle.BackColor = Color.Orange
    '    '(BackColor=Color [A=255, R=255, G=128, B=128], ForeColor=Color [Blue], NullValue=False, Alignment=MiddleCenter)

    '    ds.Dispose()


    '    'Me.CCProfilesTableAdapter.FillBy(Me.DprofilesDataSet.CCProfiles, TemplateNameComboBox.Text)
    '    'Dim connString As String = _
    '    '                           "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\MMData.mdf;Integrated Security=True user instances=true"
    '    'Dim cn As New SqlConnection(connString)
    '    'cn.Open()
    '    '' read the number of rows
    '    'Dim cmd As New SqlCommand("SELECT  Code1, Description FROM MMDX order by Description", cn)
    '    'Dim da As New SqlDataAdapter
    '    'Dim tbl As New DataTable
    '    'Dim ds As New DataSet
    '    'da.SelectCommand = cmd
    '    'da.Fill(ds, "MMDX")
    '    'DataGridViewPr.DataSource = ds.Tables("MMDX")
    '    'ds.Dispose()
    '    'cn.Close()

    '    ''Me.CCProfilesBindingSource.Filter = TemplateName =TemplateNameComboBox.Text"


    'End Sub

    Private Function LoadComboBoxes()
        Dim db As DBAccess = New DBAccess()
        Dim localdr As SqlClient.SqlDataReader

        localdr = db.ExecuteReader("SELECT VisitType from MMCombo")
        If localdr.HasRows = True Then
            While localdr.Read
                If localdr.Item(0).ToString <> "N/A" Then
                    VisitTypeComboBox.Items.Add(localdr.Item(0))
                End If
            End While
        End If
        localdr.Close()



        localdr = db.ExecuteReader("SELECT SignedBy from MMCombo")
        If localdr.HasRows = True Then
            While localdr.Read
                If localdr.Item(0).ToString <> "N/A" Then
                    SignedByComboBox.Items.Add(localdr.Item(0))
                End If
            End While
        End If
        localdr.Close()


        localdr = db.ExecuteReader("SELECT Status from MMCombo")
        If localdr.HasRows = True Then
            While localdr.Read
                If localdr.Item(0).ToString <> "N/A" Then
                    StatusComboBox.Items.Add(localdr.Item(0))
                End If
            End While
        End If
        localdr.Close()

        localdr = db.ExecuteReader("SELECT AssignedTo from MMCombo")
        If localdr.HasRows = True Then
            While localdr.Read
                If localdr.Item(0).ToString <> "N/A" Then
                    AssignedToComboBox.Items.Add(localdr.Item(0))
                End If
            End While
        End If
        localdr.Close()

    End Function

    Private Sub btnRefTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefTo.Click
        Try
            Dim RefPhysician As New ReferringPhysician
            aRet = RefPhysician.ShowPicklist
            If aRet(0) = "Y" Then
                TextBoxReferedTo.Text = aRet(1)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnFollowUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFollowUp.Click
        Try
            '***CHANGED***
            TabControl3.SelectedTab = DxPrTestsPickTab
            radFollowUp.Checked = True
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'f/u Panel' ORDER BY ScreenLocation ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()
            cn.Dispose()
            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnDiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiet.Click
        Try
            '***CHANGED***
            TabControl3.SelectedTab = DxPrTestsPickTab
            radDiet.Checked = True
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'Diet' ORDER BY ScreenLocation ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()
            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCounseling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCounseling.Click
        Try
            '***CHANGED***
            TabControl3.SelectedTab = DxPrTestsPickTab
            radCounseling.Checked = True
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'Counseling' ORDER BY ScreenLocation  ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()
            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False

            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnOtherTxPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtherTxPanel.Click
        Try
            'TabControl3.SelectedIndex = 3
            'TabControl1.SelectedIndex = 5
            radOther.Checked = True
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'OtherTx Panel' ORDER BY ScreenLocation ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()

            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False

            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function LoadComboBoxes2()

        Dim dr As DataRow
        Dim dt As DataTable
        Dim drCCProfiles As DataRow
        Dim dtCCProfiles As DataTable

        dtCCProfiles = Me.DprofilesDataSet.Tables("CCProfiles")
        dt = Me.MMDataDataSet1.Tables("MMCombo")

        VisitTypeComboBox.Items.Clear()
        For Each dr In dt.Rows
            If dr("VisitType") <> "N/A" Then
                VisitTypeComboBox.Items.Add(dr("VisitType"))
            End If
        Next
        SignedByComboBox.Items.Clear()
        For Each dr In dt.Rows
            If dr("SignedBy") <> "N/A" Then
                SignedByComboBox.Items.Add(dr("SignedBy"))
            End If
        Next
        StatusComboBox.Items.Clear()
        For Each dr In dt.Rows
            If dr("Status") <> "N/A" Then
                StatusComboBox.Items.Add(dr("Status"))
            End If
        Next

        AssignedToComboBox.Items.Clear()
        For Each dr In dt.Rows
            If dr("AssignedTo") <> "N/A" Then
                AssignedToComboBox.Items.Add(dr("AssignedTo"))
            End If
        Next

        'TemplateNameComboBox.Items.Clear()
        'For Each drCCProfiles In dtCCProfiles.Rows
        '    If drCCProfiles("TemplateName") <> "" Then
        '        TemplateNameComboBox.Items.Add(drCCProfiles("TemplateName"))
        '    End If
        'Next

    End Function

    Private Sub TabPage11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENrmTab.Click

    End Sub

    'Private Sub TemplateNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemplateNameComboBox.SelectedIndexChanged

    '    Dim i As Integer = 0

    '    ' MMCHRosAndGenDataGridView1.DataSource = Nothing

    '    Try

    '        Dim itemFound As Integer = Me.CCProfilesBindingSource.Find("TemplateName", TemplateNameComboBox.Text)
    '        Me.CCProfilesBindingSource.Position = itemFound

    '        Dim connString As String = connString2
    '        Dim cn As New SqlConnection(connString)
    '        cn.Open()
    '        Dim strCodes, strTemplateName As String

    '        strTemplateName = DprofilesDataSet.Tables(0).Rows(Me.CCProfilesBindingSource.Position)("TemplateName")
    '        ' strCodes = DprofilesDataSet.Tables(0).Rows(Me.CCProfilesBindingSource.Position)("Codes")
    '        ' strCodes = "799,800,801,802,803,804,805,806,807,808,809"
    '        'Dim cmd As New SqlCommand("SELECT Category,SubCategory,Discription,Negative,Positive,qid,ScreenLocation FROM   MMCHRosAndGen where qid In(" + strCodes + ")", cn)

    '        'Dim cmd As New SqlCommand("SELECT MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive, MMCHRosAndGen.qid, MMCHRosAndGen.ScreenLocation, QIDs.TemplateName  From        MMCHRosAndGen INNER JOIN   QIDs ON MMCHRosAndGen.qid = QIDs.QID WHERE     MMCHRosAndGen.qid IN (" + strCodes + ")  AND QIDs.TemplateName = '" + TemplateNameComboBox.Text + "' ORDER BY MMCHRosAndGen.ScreenLocation,QIDs.SortOrder", cn)
    '        ' Dim cmd As New SqlCommand("SELECT     MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive, QIDs.TemplateName, MMCHROSandGenCat.SortOrder, QIDs.SortOrder AS QIDSortOrder FROM MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE MMCHRosAndGen.qid IN (" + strCodes + ")  AND QIDs.TemplateName = '" + TemplateNameComboBox.Text + "' ORDER BY MMCHROSandGenCat.SortOrder, QIDs.SortOrder", cn)
    '        Dim cmd As New SqlCommand("SELECT MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory, MMCHRosAndGen.Discription as Description, MMCHRosAndGen.Negative, MMCHRosAndGen.Positive,   QIDs.TemplateName, MMCHROSandGenCat.SortOrder, QIDs.SortOrder AS QIDSortOrder, QIDs.QID, QIDs.ID, detailofitem, DetailtoPost FROM  MMCHRosAndGen INNER JOIN QIDs ON MMCHRosAndGen.qid = QIDs.QID INNER JOIN MMCHROSandGenCat ON MMCHRosAndGen.Category = MMCHROSandGenCat.Category WHERE     QIDs.TemplateName = '" + TemplateNameComboBox.Text + "' ORDER BY MMCHROSandGenCat.SortOrder, QIDSortOrder", cn)


    '        Dim da As New SqlDataAdapter
    '        Dim tbl As New DataTable
    '        Dim ds As New DataSet
    '        da.SelectCommand = cmd
    '        da.Fill(ds, "MMCHRosAndGen")
    '        ' DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
    '        MMCHRosAndGenDataGridView1.DataSource = ds.Tables("MMCHRosAndGen")


    '        '----------------------------------------------------------------------------
    '        MMCHRosAndGenDataGridView1.Columns("TemplateName").Visible = False
    '        MMCHRosAndGenDataGridView1.Columns("SortOrder").Visible = False
    '        MMCHRosAndGenDataGridView1.Columns("QIDSortOrder").Visible = False
    '        MMCHRosAndGenDataGridView1.Columns("QID").Visible = False
    '        MMCHRosAndGenDataGridView1.Columns("ID").Visible = False
    '        MMCHRosAndGenDataGridView1.Columns("detailofitem").Visible = False
    '        '----------------------------------------------------------------------------

    '        'If MMCHRosAndGenDataGridView1.Columns.Contains("DetailButton") Then

    '        'Else

    '        MMCHRosAndGenDataGridView1.Columns(0).Width = 90
    '        MMCHRosAndGenDataGridView1.Columns(1).Width = 0
    '        MMCHRosAndGenDataGridView1.Columns(2).Width = 115
    '        MMCHRosAndGenDataGridView1.Columns(3).Width = 40
    '        MMCHRosAndGenDataGridView1.Columns(4).Width = 40
    '        MMCHRosAndGenDataGridView1.Columns(3).DefaultCellStyle.BackColor = Color.LightCyan
    '        MMCHRosAndGenDataGridView1.Columns(4).DefaultCellStyle.BackColor = Color.LightPink


    '        'Dim detailcolumn As New DataGridViewButtonColumn()
    '        'detailcolumn.Name = "DetailButton"
    '        'detailcolumn.HeaderText = ""
    '        'MMCHRosAndGenDataGridView1.Columns.Add(detailcolumn)
    '        'detailcolumn.Width = 25
    '        'Dim font As New Font(MMCHRosAndGenDataGridView1.DefaultCellStyle.Font.FontFamily, 8, FontStyle.Bold)
    '        'detailcolumn.DefaultCellStyle.Font = font
    '        '' detailcolumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


    '        'Dim tempcolumn As New DataGridViewTextBoxColumn()
    '        'tempcolumn.Name = "Temp"
    '        'MMCHRosAndGenDataGridView1.Columns.Add(tempcolumn)
    '        'tempcolumn.Width = 200
    '        'End If



    '        '***CHANGED***
    '        TabControl3.SelectedTab = ROSTab
    '        TabControl1.SelectedTab = ROSPETab
    '        ds.Dispose()

    '        'For i = 0 To MMCHRosAndGenDataGridView1.RowCount - 1
    '        '    If MMCHRosAndGenDataGridView1.Rows(i).Cells("DetailOfItem").Value <> "" Then
    '        '        MMCHRosAndGenDataGridView1.Rows(i).Cells("DetailButton").Value = "***"
    '        '    End If
    '        'Next




    '    Catch ex As System.Exception
    '        MessageBox.Show(ex.Message, "Load Profile", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '    End Try
    'End Sub

    Private Sub radOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.CheckedChanged, RadioButton3.CheckedChanged

    End Sub
    Private Sub radFollowUp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFollowUp.CheckedChanged, RadioButton2.CheckedChanged

    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        Try
            myBindingSource.Filter = cmbFilter.Text & " like " & "'" & txtFind.Text & "%'"
        Catch
        End Try
    End Sub

    Private Sub cmdMedications_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMedications.Click

        'aRet(1) = ChartNumberTextBox.Text
        'aRet(2) = FirstNameTextBox.Text
        'aRet(3) = LastNameTextBox.Text
        'aRet(4) = CaseNumberTextBox.Text

        'aRet(1) = txtCopyChartNumber.Text
        'aRet(2) = txtCopyFirstName.Text
        'aRet(3) = txtCopyLastName.Text
        'aRet(10) = txtCopyCaseNumber.Text

        'Prescription.ShowPrescriptions(aRet)
        'Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, txtCopyCaseNumber.Text)


        Dim medicationsArray(10) As String
        medicationsArray(1) = txtCopyChartNumber.Text
        medicationsArray(2) = txtCopyFirstName.Text
        medicationsArray(3) = txtCopyLastName.Text
        medicationsArray(10) = txtCopyCaseNumber.Text

        Prescription.ShowPrescriptions(medicationsArray)
        Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, txtCopyCaseNumber.Text)



        'aRet(1) = ChartNumberTextBox.Text
        'aRet(2) = FirstNameTextBox.Text
        'aRet(3) = LastNameTextBox.Text
        'aRet(4) = ""
        'Prescription.ShowPrescriptions(aRet)
        'Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, aRet(1))
    End Sub

    Private Sub txtCopyCaseNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCopyCaseNumber.TextChanged
        Me.Validate()
        Me.MMChartVisitBindingSource.EndEdit()
        Me.MMChartVisitTableAdapter.Update(Me.MMDataDataSet1.MMChartVisit)
        Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, txtCopyCaseNumber.Text)
        RefreshProcedures()
        LockControls()

    End Sub

    Private Sub btnRefreshRX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshRX.Click
        Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CType(txtCopyCaseNumber.Text, Integer))
    End Sub

    Private Function LoadPreviousMedications()
        Try
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("Select CaseNumber as Case#, MedicationStatus as Status, Medication, NumberOfRefills as Refills, Quantity as Qty, Instructions, Dosage, Startdate from dbo.MMChartRx where ChartNumber = " & "'" & HChartNumber & "' ORDER BY MedicationStatus, StartDate DESC", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMChartRx")

            myBindingSource = New BindingSource()
            myBindingSource.DataSource = ds
            myBindingSource.DataMember = ds.Tables(0).TableName
            dgvPreviousMedications.DataSource = myBindingSource

            ds.Dispose()
            cn.Close()
            Me.dgvPreviousMedications.Columns(0).Width = 50
            Me.dgvPreviousMedications.Columns("Status").Width = 45
            Me.dgvPreviousMedications.Columns(2).Width = 70
            Me.dgvPreviousMedications.Columns(3).Width = 35
            Me.dgvPreviousMedications.Columns(4).Width = 35
        Catch
        End Try
    End Function

    Private Function GetLatestCaseNumber() As Integer
        Dim maxID As Integer
        Dim cn As SqlConnection = Nothing
        Try
            Dim connString As String = connString2
            cn = New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand("Select max(CaseNumber) from MMChartVisit", cn)
            maxID = cmd.ExecuteScalar()
            maxID += 1
            Return maxID
        Catch
        Finally
            If Not cn Is Nothing Then cn.Close()
        End Try
    End Function

    Private Sub RadioButtonLT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonLT.CheckedChanged
        Try
            If RadioButtonLT.Checked = True Then
                'User Instance=True
                Dim connString As String = connString2
                'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString


                Dim cn As New SqlConnection(connString)
                cn.Open()
                ' read the number of rows


                Dim cmd As New SqlCommand("SELECT TestNo, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestLab  order by Description", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMChartTestLab")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource


                ' DataGridViewPr.DataSource = ds.Tables("MMDX")

                ds.Dispose()
                cn.Close()
                Me.DataGridViewPr.Columns(0).Width = 70
                Me.DataGridViewPr.Columns(1).Width = 355
                Me.DataGridViewPr.Columns(2).Width = 50
                If globalTemplate <> "" Then
                    radTemplateDX.Checked = True
                    LoadTemplateSpecificDxPrTests()
                Else
                    radMyDx.Checked = True
                End If

                '***CHANGED***
                TabControl3.SelectedTab = DxPrTestsPickTab
                TabControl1.SelectedTab = DxPrTestsTab

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub




    'Private Sub cmdPostRosAndPE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPostRosAndPE.Click
    '    Try
    '        Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow

    '        'If RadioButtonDx.Checked = True Then
    '        '    newRow("Type") = "DX"
    '        'ElseIf RadioButtonPr.Checked = True Then

    '        '    newRow("Type") = "PR"
    '        'ElseIf RadioButtonMT.Checked = True Then
    '        '    newRow("Type") = "MEDTEST"

    '        'ElseIf Profile.Checked = True Then
    '        Dim i As Integer
    '        Dim snr, snp As String
    '        Dim spr, spp As String
    '        Dim value As String
    '        Dim ss As String


    '        Dim negROSChest As String
    '        Dim negROSCONST As String
    '        Dim negROSCV As String
    '        Dim negROSCVSPulmonary As String
    '        Dim negROSEndocrine As String
    '        Dim negROSENT As String
    '        Dim negROSEyes As String
    '        Dim negROSFemaleGenital As String
    '        Dim negROSFemaleReproductive As String
    '        Dim negROSGeneral As String
    '        Dim negROSGI As String
    '        Dim negROSGU As String
    '        Dim negROSHEENT As String
    '        Dim negROSHEENT2 As String
    '        Dim negROSImmunological As String
    '        Dim negROSLymph As String
    '        Dim negROSMuscSkel As String
    '        Dim negROSNeuro As String
    '        Dim negROSNeuroEyes As String
    '        Dim negROSNormals As String
    '        Dim negROSPulmonary As String
    '        Dim negROSResp As String
    '        Dim negROSSkin As String
    '        Dim negROSSkinMS As String
    '        Dim negROSUrinary As String
    '        Dim negROSVestibular As String

    '        Dim negPENormals As String
    '        Dim negPEAbd As String
    '        Dim negPEBack As String
    '        Dim negPECV As String
    '        Dim negPECVS As String
    '        Dim negPEENT As String
    '        Dim negPEExtremities As String
    '        Dim negPEEyes As String
    '        Dim negPEFemale As String
    '        Dim negPEGeneral As String
    '        Dim negPEGenitals As String
    '        Dim negPEHeadNeck As String
    '        Dim negPEHEENT As String
    '        Dim negPEMale As String
    '        Dim negPEMouthThroat As String
    '        Dim negPENeckChest As String
    '        Dim negPEPelvicExam As String
    '        Dim negPEPSYCH As String
    '        Dim negPEPulm As String
    '        Dim negPERectal As String
    '        Dim negPERespiratory As String
    '        Dim negPESkin As String
    '        Dim negPEMS As String
    '        Dim negPEGait As String
    '        Dim negPEGU As String
    '        Dim negPEGI As String
    '        Dim negPEMentalStatus As String
    '        Dim negPEMood As String
    '        Dim negPEBehavior As String
    '        Dim negPELymphatic As String
    '        Dim negPENeck As String
    '        Dim negPENeurological As String

    '        Dim posROSCONST As String
    '        Dim posROSCV As String
    '        Dim posROSCVSPulmonary As String
    '        Dim posROSEndocrine As String
    '        Dim posROSENT As String
    '        Dim posROSEyes As String
    '        Dim posROSFemaleGenital As String
    '        Dim posROSFemaleReproductive As String
    '        Dim posROSGeneral As String
    '        Dim posROSGI As String
    '        Dim posROSGU As String
    '        Dim posROSHEENT As String
    '        Dim posROSHEENT2 As String
    '        Dim posROSImmunological As String
    '        Dim posROSLymph As String
    '        Dim posROSMuscSkel As String
    '        Dim posROSNeuro As String
    '        Dim posROSNeuroEyes As String
    '        Dim posROSNormals As String
    '        Dim posROSPulmonary As String
    '        Dim posROSResp As String
    '        Dim posROSSkin As String
    '        Dim posROSSkinMS As String
    '        Dim posROSUrinary As String
    '        Dim posROSVestibular As String
    '        Dim posROSChest As String

    '        Dim posPENormals As String
    '        Dim posPEAbd As String
    '        Dim posPEBack As String
    '        Dim posPECV As String
    '        Dim posPECVS As String
    '        Dim posPEENT As String
    '        Dim posPEExtremities As String
    '        Dim posPEEyes As String
    '        Dim posPEFemale As String
    '        Dim posPEGeneral As String
    '        Dim posPEGenitals As String
    '        Dim posPEHeadNeck As String
    '        Dim posPEHEENT As String
    '        Dim posPEMale As String
    '        Dim posPEMouthThroat As String
    '        Dim posPENeckChest As String
    '        Dim posPEPelvicExam As String
    '        Dim posPEPSYCH As String
    '        Dim posPEPulm As String
    '        Dim posPERectal As String
    '        Dim posPERespiratory As String
    '        Dim posPESkin As String
    '        Dim posPEMS As String
    '        Dim posPEGait As String
    '        Dim posPEGU As String
    '        Dim posPEGI As String
    '        Dim posPEMentalStatus As String
    '        Dim posPEMood As String
    '        Dim posPEBehavior As String
    '        Dim posPELymphatic As String
    '        Dim posPENeck As String
    '        Dim posPENeurological As String


    '        Dim negOther As String
    '        Dim posOther As String




    '        value = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value
    '        ss = value.Substring(0, 3)
    '        Dim aa As String = MMCHRosAndGenDataGridView1.Columns(0).Name
    '        Dim aaa As String = MMCHRosAndGenDataGridView1.Columns.Count

    '        For i = 0 To MMCHRosAndGenDataGridView1.RowCount - 1


    '            If MMCHRosAndGenDataGridView1.Rows(i).Cells(3).Value = True Then





    '                Select Case MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString

    '                    Case "ROS-Chest"
    '                        If negROSChest = "" Then
    '                            negROSChest = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSChest += 1
    '                        Else
    '                            negROSChest = negROSChest & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSChest += 1
    '                        End If

    '                    Case "ROS-CONST"
    '                        If negROSCONST = "" Then
    '                            negROSCONST = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCONST += 1
    '                        Else
    '                            negROSCONST = negROSCONST & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCONST += 1
    '                        End If

    '                    Case "ROS-CV"
    '                        If negROSCV = "" Then
    '                            negROSCV = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCV += 1
    '                        Else
    '                            negROSCV = negROSCV & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCV += 1
    '                        End If

    '                    Case "ROS-CVS/Pulmonary"
    '                        If negROSCVSPulmonary = "" Then
    '                            negROSCVSPulmonary = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCVSPulmonary += 1
    '                        Else
    '                            negROSCVSPulmonary = negROSCVSPulmonary & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCVSPulmonary += 1
    '                        End If

    '                    Case "ROS-Endocrine"
    '                        If negROSEndocrine = "" Then
    '                            negROSEndocrine = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSEndocrine += 1
    '                        Else
    '                            negROSEndocrine = negROSEndocrine & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSEndocrine += 1
    '                        End If

    '                    Case "ROS-ENT"
    '                        If negROSENT = "" Then
    '                            negROSENT = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSENT += 1
    '                        Else
    '                            negROSENT = negROSENT & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSENT += 1
    '                        End If
    '                    Case "ROS-Eyes"
    '                        If negROSEyes = "" Then
    '                            negROSEyes = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSEyes += 1
    '                        Else
    '                            negROSEyes = negROSEyes & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSEyes += 1
    '                        End If

    '                    Case "ROS-Female Genital"
    '                        If negROSFemaleGenital = "" Then
    '                            negROSFemaleGenital = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSFemaleGenital += 1
    '                        Else
    '                            negROSFemaleGenital = negROSFemaleGenital & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSFemaleGenital += 1
    '                        End If

    '                    Case "ROS-Female Reproductive"
    '                        If negROSFemaleReproductive = "" Then
    '                            negROSFemaleReproductive = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSFemaleReproductive += 1
    '                        Else
    '                            negROSFemaleReproductive = negROSFemaleReproductive & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSFemaleReproductive += 1
    '                        End If

    '                    Case "ROS-General"
    '                        If negROSGeneral = "" Then
    '                            negROSGeneral = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGeneral += 1
    '                        Else
    '                            negROSGeneral = negROSGeneral & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGeneral += 1
    '                        End If

    '                    Case "ROS-GI"
    '                        If negROSGI = "" Then
    '                            negROSGI = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGI += 1
    '                        Else
    '                            negROSGI = negROSGI & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGI += 1
    '                        End If

    '                    Case "ROS-GU"
    '                        If negROSGU = "" Then
    '                            negROSGU = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGU += 1
    '                        Else
    '                            negROSGU = negROSGU & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGU += 1
    '                        End If
    '                    Case "ROS-HEENT"
    '                        If negROSHEENT = "" Then
    '                            negROSHEENT = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSHEENT += 1
    '                        Else
    '                            negROSHEENT = negROSHEENT & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSHEENT += 1
    '                        End If

    '                    Case "ROS-HEENT2"
    '                        If negROSHEENT2 = "" Then
    '                            negROSHEENT2 = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSHEENT2 += 1
    '                        Else
    '                            negROSHEENT2 = negROSHEENT2 & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSHEENT2 += 1
    '                        End If

    '                    Case "ROS-Immunological"
    '                        If negROSImmunological = "" Then
    '                            negROSImmunological = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSImmunological += 1
    '                        Else
    '                            negROSImmunological = negROSImmunological & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSImmunological += 1
    '                        End If

    '                    Case "ROS-Lymph"
    '                        If negROSLymph = "" Then
    '                            negROSLymph = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSLymph += 1
    '                        Else
    '                            negROSLymph = negROSLymph & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSLymph += 1
    '                        End If

    '                    Case "ROS-Musc/Skel"
    '                        If negROSMuscSkel = "" Then
    '                            negROSMuscSkel = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSMuscSkel += 1
    '                        Else
    '                            negROSMuscSkel = negROSMuscSkel & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSMuscSkel += 1
    '                        End If

    '                    Case "ROS-Neuro"
    '                        If negROSNeuro = "" Then
    '                            negROSNeuro = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNeuro += 1
    '                        Else
    '                            negROSNeuro = negROSNeuro & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNeuro += 1
    '                        End If

    '                    Case "ROS-Neuro/Eyes"
    '                        If negROSNeuroEyes = "" Then
    '                            negROSNeuroEyes = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNeuroEyes += 1
    '                        Else
    '                            negROSNeuroEyes = negROSNeuroEyes & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNeuroEyes += 1
    '                        End If

    '                    Case "ROS-Normals"
    '                        If negROSNormals = "" Then
    '                            negROSNormals = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNormals += 1
    '                        Else
    '                            negROSNormals = negROSNormals & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNormals += 1
    '                        End If

    '                    Case "ROS-Pulmonary"
    '                        If negROSPulmonary = "" Then
    '                            negROSPulmonary = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSPulmonary += 1
    '                        Else
    '                            negROSPulmonary = negROSPulmonary & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSPulmonary += 1
    '                        End If

    '                    Case "ROS-Resp"
    '                        If negROSResp = "" Then
    '                            negROSResp = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSResp += 1
    '                        Else
    '                            negROSResp = negROSResp & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSResp += 1
    '                        End If

    '                    Case "ROS-Skin"
    '                        If negROSSkin = "" Then
    '                            negROSSkin = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSSkin += 1
    '                        Else
    '                            negROSSkin = negROSSkin & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSSkin += 1
    '                        End If

    '                    Case "ROS-Skin/MS"
    '                        If negROSSkinMS = "" Then
    '                            negROSSkinMS = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSSkinMS += 1
    '                        Else
    '                            negROSSkinMS = negROSSkinMS & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSSkinMS += 1
    '                        End If

    '                    Case "ROS-Urinary"
    '                        If negROSUrinary = "" Then
    '                            negROSUrinary = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSUrinary += 1
    '                        Else
    '                            negROSUrinary = negROSUrinary & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSUrinary += 1
    '                        End If

    '                    Case "ROS-Vestibular"
    '                        If negROSVestibular = "" Then
    '                            negROSVestibular = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSVestibular += 1
    '                        Else
    '                            negROSVestibular = negROSVestibular & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSVestibular += 1
    '                        End If



    '                    Case "PE-(Normals)"
    '                        If negPENormals = "" Then
    '                            negPENormals = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENormals += 1
    '                        Else
    '                            negPENormals = negPENormals & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENormals += 1
    '                        End If

    '                    Case "PE-Abd"
    '                        If negPEAbd = "" Then
    '                            negPEAbd = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEAbd += 1
    '                        Else
    '                            negPEAbd = negPEAbd & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEAbd += 1
    '                        End If

    '                    Case "PE-Back"
    '                        If negPEBack = "" Then
    '                            negPEBack = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEBack += 1
    '                        Else
    '                            negPEBack = negPEBack & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEBack += 1
    '                        End If

    '                    Case "PE-CV"
    '                        If negPECV = "" Then
    '                            negPECV = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPECV += 1
    '                        Else
    '                            negPECV = negPECV & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPECV += 1
    '                        End If

    '                    Case "PE-CVS"
    '                        If negPECVS = "" Then
    '                            negPECVS = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPECVS += 1
    '                        Else
    '                            negPECVS = negPECVS & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPECVS += 1
    '                        End If

    '                    Case "PE-ENT"
    '                        If negPEENT = "" Then
    '                            negPEENT = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEENT += 1
    '                        Else
    '                            negPEENT = negPEENT & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEENT += 1
    '                        End If

    '                    Case "PE-Extremities"
    '                        If negPEExtremities = "" Then
    '                            negPEExtremities = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEExtremities += 1
    '                        Else
    '                            negPEExtremities = negPEExtremities & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEExtremities += 1
    '                        End If

    '                    Case "PE-Eyes"
    '                        If negPEEyes = "" Then
    '                            negPEEyes = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEEyes += 1
    '                        Else
    '                            negPEEyes = negPEEyes & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEEyes += 1
    '                        End If

    '                    Case "PE-Female"
    '                        If negPEFemale = "" Then
    '                            negPEFemale = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEFemale += 1
    '                        Else
    '                            negPEFemale = negPEFemale & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEFemale += 1
    '                        End If

    '                    Case "PE-General"
    '                        If negPEGeneral = "" Then
    '                            negPEGeneral = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGeneral += 1
    '                        Else
    '                            negPEGeneral = negPEGeneral & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGeneral += 1
    '                        End If

    '                    Case "PE-Genitals"
    '                        If negPEGenitals = "" Then
    '                            negPEGenitals = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGenitals += 1
    '                        Else
    '                            negPEGenitals = negPEGenitals & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGenitals += 1
    '                        End If

    '                    Case "PE-Head/Neck"
    '                        If negPEHeadNeck = "" Then
    '                            negPEHeadNeck = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEHeadNeck += 1
    '                        Else
    '                            negPEHeadNeck = negPEHeadNeck & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEHeadNeck += 1
    '                        End If

    '                    Case "PE-HEENT"
    '                        If negPEHEENT = "" Then
    '                            negPEHEENT = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEHEENT += 1
    '                        Else
    '                            negPEHEENT = negPEHEENT & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEHEENT += 1
    '                        End If

    '                    Case "PE-Male"
    '                        If negPEMale = "" Then
    '                            negPEMale = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMale += 1
    '                        Else
    '                            negPEMale = negPEMale & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMale += 1
    '                        End If
    '                    Case "PE-Mouth/Throat"
    '                        If negPEMouthThroat = "" Then
    '                            negPEMouthThroat = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMouthThroat += 1
    '                        Else
    '                            negPEMouthThroat = negPEMouthThroat & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMouthThroat += 1
    '                        End If

    '                    Case "PE-Neck/Chest"
    '                        If negPENeckChest = "" Then
    '                            negPENeckChest = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeckChest += 1
    '                        Else
    '                            negPENeckChest = negPENeckChest & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeckChest += 1
    '                        End If

    '                    Case "PE-Pelvic Exam"
    '                        If negPEPelvicExam = "" Then
    '                            negPEPelvicExam = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPelvicExam += 1
    '                        Else
    '                            negPEPelvicExam = negPEPelvicExam & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPelvicExam += 1
    '                        End If

    '                    Case "PE-PSYCH"
    '                        If negPEPSYCH = "" Then
    '                            negPEPSYCH = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPSYCH += 1
    '                        Else
    '                            negPEPSYCH = negPEPSYCH & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPSYCH += 1
    '                        End If

    '                    Case "PE-Pulm"
    '                        If negPEPulm = "" Then
    '                            negPEPulm = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPulm += 1
    '                        Else
    '                            negPEPulm = negPEPulm & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPulm += 1
    '                        End If

    '                    Case "PE-Rectal"
    '                        If negPERectal = "" Then
    '                            negPERectal = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPERectal += 1
    '                        Else
    '                            negPERectal = negPERectal & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPERectal += 1
    '                        End If
    '                    Case "PE-Respiratory"
    '                        If negPERespiratory = "" Then
    '                            negPERespiratory = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPERespiratory += 1
    '                        Else
    '                            negPERespiratory = negPERespiratory & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPERespiratory += 1
    '                        End If

    '                    Case "PE-Skin"
    '                        If negPESkin = "" Then
    '                            negPESkin = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPESkin += 1
    '                        Else
    '                            negPESkin = negPESkin & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPESkin += 1
    '                        End If

    '                    Case "PE-MS"
    '                        If negPEMS = "" Then
    '                            negPEMS = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMS += 1
    '                        Else
    '                            negPEMS = negPEMS & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMS += 1
    '                        End If
    '                    Case "PE-Gait"
    '                        If negPEGait = "" Then
    '                            negPEGait = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGait += 1
    '                        Else
    '                            negPEGait = negPEGait & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGait += 1
    '                        End If
    '                    Case "PE-GU"
    '                        If negPEGU = "" Then
    '                            negPEGU = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGU += 1
    '                        Else
    '                            negPEGU = negPEGU & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGU += 1
    '                        End If
    '                    Case "PE-GI"
    '                        If negPEGI = "" Then
    '                            negPEGI = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGI += 1
    '                        Else
    '                            negPEGI = negPEGI & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGI += 1
    '                        End If
    '                    Case "PE-Mental Status"
    '                        If negPEMentalStatus = "" Then
    '                            negPEMentalStatus = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMentalStatus += 1
    '                        Else
    '                            negPEMentalStatus = negPEMentalStatus & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMentalStatus += 1
    '                        End If
    '                    Case "PE-Mood"
    '                        If negPEMood = "" Then
    '                            negPEMood = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMood += 1
    '                        Else
    '                            negPEMood = negPEMood & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMood += 1
    '                        End If
    '                    Case "PE-Behavior"
    '                        If negPEBehavior = "" Then
    '                            negPEBehavior = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEBehavior += 1
    '                        Else
    '                            negPEBehavior = negPEBehavior & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEBehavior += 1
    '                        End If
    '                    Case "PE-lymphatic"
    '                        If negPELymphatic = "" Then
    '                            negPELymphatic = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPELymphatic += 1
    '                        Else
    '                            negPELymphatic = negPELymphatic & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPELymphatic += 1
    '                        End If

    '                    Case "PE-Neurological"
    '                        If negPENeurological = "" Then
    '                            negPENeurological = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeurological += 1
    '                        Else
    '                            negPENeurological = negPENeurological & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeurological += 1
    '                        End If

    '                    Case "PE-Neck"
    '                        If negPENeck = "" Then
    '                            negPENeck = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeck += 1
    '                        Else
    '                            negPENeck = negPENeck & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeck += 1
    '                        End If

    '                    Case Else
    '                        Dim a As String = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString()
    '                        If negOther = "" Then
    '                            negOther = "OTHER: " & MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString & ": Negative for " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                        Else
    '                            negOther = negOther & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                        End If
    '                End Select
    '            End If








    '            If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                Select Case MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString

    '                    Case "ROS-Chest"
    '                        If posROSChest = "" Then
    '                            posROSChest = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSChest += 1
    '                        Else
    '                            posROSChest = posROSChest & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSChest += 1
    '                        End If

    '                    Case "ROS-CONST"
    '                        If posROSCONST = "" Then
    '                            posROSCONST = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCONST += 1
    '                        Else
    '                            posROSCONST = posROSCONST & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCONST += 1
    '                        End If

    '                    Case "ROS-CV"
    '                        If posROSCV = "" Then
    '                            posROSCV = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCV += 1
    '                        Else
    '                            posROSCV = posROSCV & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCV += 1
    '                        End If

    '                    Case "ROS-CVS/Pulmonary"
    '                        If posROSCVSPulmonary = "" Then
    '                            posROSCVSPulmonary = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCVSPulmonary += 1
    '                        Else
    '                            posROSCVSPulmonary = posROSCVSPulmonary & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSCVSPulmonary += 1
    '                        End If

    '                    Case "ROS-Endocrine"
    '                        If posROSEndocrine = "" Then
    '                            posROSEndocrine = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSEndocrine += 1
    '                        Else
    '                            posROSEndocrine = posROSEndocrine & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSEndocrine += 1
    '                        End If

    '                    Case "ROS-ENT"
    '                        If posROSENT = "" Then
    '                            posROSENT = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSENT += 1
    '                        Else
    '                            posROSENT = posROSENT & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSENT += 1
    '                        End If
    '                    Case "ROS-Eyes"
    '                        If posROSEyes = "" Then
    '                            posROSEyes = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSEyes += 1
    '                        Else
    '                            posROSEyes = posROSEyes & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSEyes += 1
    '                        End If

    '                    Case "ROS-Female Genital"
    '                        If posROSFemaleGenital = "" Then
    '                            posROSFemaleGenital = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSFemaleGenital += 1
    '                        Else
    '                            posROSFemaleGenital = posROSFemaleGenital & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSFemaleGenital += 1
    '                        End If

    '                    Case "ROS-Female Reproductive"
    '                        If posROSFemaleReproductive = "" Then
    '                            posROSFemaleReproductive = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSFemaleReproductive += 1
    '                        Else
    '                            posROSFemaleReproductive = posROSFemaleReproductive & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSFemaleReproductive += 1
    '                        End If

    '                    Case "ROS-General"
    '                        If posROSGeneral = "" Then
    '                            posROSGeneral = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGeneral += 1
    '                        Else
    '                            posROSGeneral = posROSGeneral & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGeneral += 1
    '                        End If

    '                    Case "ROS-GI"
    '                        If posROSGI = "" Then
    '                            posROSGI = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGI += 1
    '                        Else
    '                            posROSGI = posROSGI & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGI += 1
    '                        End If

    '                    Case "ROS-GU"
    '                        If posROSGU = "" Then
    '                            posROSGU = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGU += 1
    '                        Else
    '                            posROSGU = posROSGU & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSGU += 1
    '                        End If
    '                    Case "ROS-HEENT"
    '                        If posROSHEENT = "" Then
    '                            posROSHEENT = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSHEENT += 1
    '                        Else
    '                            posROSHEENT = posROSHEENT & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSHEENT += 1
    '                        End If

    '                    Case "ROS-HEENT2"
    '                        If posROSHEENT2 = "" Then
    '                            posROSHEENT2 = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSHEENT2 += 1
    '                        Else
    '                            posROSHEENT2 = posROSHEENT2 & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSHEENT2 += 1
    '                        End If

    '                    Case "ROS-Immunological"
    '                        If posROSImmunological = "" Then
    '                            posROSImmunological = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSImmunological += 1
    '                        Else
    '                            posROSImmunological = posROSImmunological & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSImmunological += 1
    '                        End If

    '                    Case "ROS-Lymph"
    '                        If posROSLymph = "" Then
    '                            posROSLymph = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSLymph += 1
    '                        Else
    '                            posROSLymph = posROSLymph & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSLymph += 1
    '                        End If

    '                    Case "ROS-Musc/Skel"
    '                        If posROSMuscSkel = "" Then
    '                            posROSMuscSkel = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSMuscSkel += 1
    '                        Else
    '                            posROSMuscSkel = posROSMuscSkel & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSMuscSkel += 1
    '                        End If

    '                    Case "ROS-Neuro"
    '                        If posROSNeuro = "" Then
    '                            posROSNeuro = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNeuro += 1
    '                        Else
    '                            posROSNeuro = posROSNeuro & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNeuro += 1
    '                        End If

    '                    Case "ROS-Neuro/Eyes"
    '                        If posROSNeuroEyes = "" Then
    '                            posROSNeuroEyes = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNeuroEyes += 1
    '                        Else
    '                            posROSNeuroEyes = posROSNeuroEyes & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNeuroEyes += 1
    '                        End If

    '                    Case "ROS-Normals"
    '                        If posROSNormals = "" Then
    '                            posROSNormals = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNormals += 1
    '                        Else
    '                            posROSNormals = posROSNormals & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSNormals += 1
    '                        End If

    '                    Case "ROS-Pulmonary"
    '                        If posROSPulmonary = "" Then
    '                            posROSPulmonary = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSPulmonary += 1
    '                        Else
    '                            posROSPulmonary = posROSPulmonary & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSPulmonary += 1
    '                        End If

    '                    Case "ROS-Resp"
    '                        If posROSResp = "" Then
    '                            posROSResp = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSResp += 1
    '                        Else
    '                            posROSResp = posROSResp & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSResp += 1
    '                        End If

    '                    Case "ROS-Skin"
    '                        If posROSSkin = "" Then
    '                            posROSSkin = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSSkin += 1
    '                        Else
    '                            posROSSkin = posROSSkin & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSSkin += 1
    '                        End If

    '                    Case "ROS-Skin/MS"
    '                        If posROSSkinMS = "" Then
    '                            posROSSkinMS = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSSkinMS += 1
    '                        Else
    '                            posROSSkinMS = posROSSkinMS & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSSkinMS += 1
    '                        End If
    '                    Case "ROS-Urinary"
    '                        If posROSUrinary = "" Then
    '                            posROSUrinary = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSUrinary += 1
    '                        Else
    '                            posROSUrinary = posROSUrinary & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSUrinary += 1
    '                        End If

    '                    Case "ROS-Vestibular"
    '                        If posROSVestibular = "" Then
    '                            posROSVestibular = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSVestibular += 1
    '                        Else
    '                            posROSVestibular = posROSVestibular & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposROSVestibular += 1
    '                        End If

    '                    Case "PE-(Normals)"
    '                        If posPENormals = "" Then
    '                            posPENormals = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENormals += 1
    '                        Else
    '                            posPENormals = posPENormals & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENormals += 1
    '                        End If

    '                    Case "PE-Abd"
    '                        If posPEAbd = "" Then
    '                            posPEAbd = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEAbd += 1
    '                        Else
    '                            posPEAbd = posPEAbd & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEAbd += 1
    '                        End If
    '                    Case "PE-Back"
    '                        If posPEBack = "" Then
    '                            posPEBack = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEBack += 1
    '                        Else
    '                            posPEBack = posPEBack & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEBack += 1
    '                        End If

    '                    Case "PE-CV"
    '                        If posPECV = "" Then
    '                            posPECV = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPECV += 1
    '                        Else
    '                            posPECV = posPECV & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPECV += 1
    '                        End If

    '                    Case "PE-CVS"
    '                        If posPECVS = "" Then
    '                            posPECVS = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPECVS += 1
    '                        Else
    '                            posPECVS = posPECVS & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPECVS += 1
    '                        End If

    '                    Case "PE-ENT"
    '                        If posPEENT = "" Then
    '                            posPEENT = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEENT += 1
    '                        Else
    '                            posPEENT = posPEENT & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEENT += 1
    '                        End If

    '                    Case "PE-Extremities"
    '                        If posPEExtremities = "" Then
    '                            posPEExtremities = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEExtremities += 1
    '                        Else
    '                            posPEExtremities = posPEExtremities & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEExtremities += 1
    '                        End If

    '                    Case "PE-Eyes"
    '                        If posPEEyes = "" Then
    '                            posPEEyes = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEEyes += 1
    '                        Else
    '                            posPEEyes = posPEEyes & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEEyes += 1
    '                        End If

    '                    Case "PE-Female"
    '                        If posPEFemale = "" Then
    '                            posPEFemale = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEFemale += 1
    '                        Else
    '                            posPEFemale = posPEFemale & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEFemale += 1
    '                        End If

    '                    Case "PE-General"
    '                        If posPEGeneral = "" Then
    '                            posPEGeneral = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGeneral += 1
    '                        Else
    '                            posPEGeneral = posPEGeneral & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGeneral += 1
    '                        End If

    '                    Case "PE-Genitals"
    '                        If posPEGenitals = "" Then
    '                            posPEGenitals = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGenitals += 1
    '                        Else
    '                            posPEGenitals = posPEGenitals & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGenitals += 1
    '                        End If

    '                    Case "PE-Head/Neck"
    '                        If posPEHeadNeck = "" Then
    '                            posPEHeadNeck = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEHeadNeck += 1
    '                        Else
    '                            posPEHeadNeck = posPEHeadNeck & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEHeadNeck += 1
    '                        End If

    '                    Case "PE-HEENT"
    '                        If posPEHEENT = "" Then
    '                            posPEHEENT = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEHEENT += 1
    '                        Else
    '                            posPEHEENT = posPEHEENT & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEHEENT += 1
    '                        End If

    '                    Case "PE-Male"
    '                        If posPEMale = "" Then
    '                            posPEMale = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMale += 1
    '                        Else
    '                            posPEMale = posPEMale & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMale += 1
    '                        End If
    '                    Case "PE-Mouth/Throat"
    '                        If posPEMouthThroat = "" Then
    '                            posPEMouthThroat = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMouthThroat += 1
    '                        Else
    '                            posPEMouthThroat = posPEMouthThroat & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMouthThroat += 1
    '                        End If

    '                    Case "PE-Neck/Chest"
    '                        If posPENeckChest = "" Then
    '                            posPENeckChest = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeckChest += 1
    '                        Else
    '                            posPENeckChest = posPENeckChest & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeckChest += 1
    '                        End If

    '                    Case "PE-Pelvic Exam"
    '                        If posPEPelvicExam = "" Then
    '                            posPEPelvicExam = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPelvicExam += 1
    '                        Else
    '                            posPEPelvicExam = posPEPelvicExam & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPelvicExam += 1
    '                        End If

    '                    Case "PE-PSYCH"
    '                        If posPEPSYCH = "" Then
    '                            posPEPSYCH = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPSYCH += 1
    '                        Else
    '                            posPEPSYCH = posPEPSYCH & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPSYCH += 1
    '                        End If

    '                    Case "PE-Pulm"
    '                        If posPEPulm = "" Then
    '                            posPEPulm = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPulm += 1
    '                        Else
    '                            posPEPulm = posPEPulm & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEPulm += 1
    '                        End If

    '                    Case "PE-Rectal"
    '                        If posPERectal = "" Then
    '                            posPERectal = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPERectal += 1
    '                        Else
    '                            posPERectal = posPERectal & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPERectal += 1
    '                        End If
    '                    Case "PE-Respiratory"
    '                        If posPERespiratory = "" Then
    '                            posPERespiratory = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPERespiratory += 1
    '                        Else
    '                            posPERespiratory = posPERespiratory & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPERespiratory += 1
    '                        End If

    '                    Case "PE-Skin"
    '                        If posPESkin = "" Then
    '                            posPESkin = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPESkin += 1
    '                        Else
    '                            posPESkin = posPESkin & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPESkin += 1
    '                        End If

    '                    Case "PE-MS"
    '                        If posPEMS = "" Then
    '                            posPEMS = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMS += 1
    '                        Else
    '                            posPEMS = posPEMS & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMS += 1
    '                        End If
    '                    Case "PE-Gait"
    '                        If posPEGait = "" Then
    '                            posPEGait = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGait += 1
    '                        Else
    '                            posPEGait = posPEGait & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGait += 1
    '                        End If
    '                    Case "PE-GU"
    '                        If posPEGU = "" Then
    '                            posPEGU = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGU += 1
    '                        Else
    '                            posPEGU = posPEGU & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGU += 1
    '                        End If
    '                    Case "PE-GI"
    '                        If posPEGI = "" Then
    '                            posPEGI = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGI += 1
    '                        Else
    '                            posPEGI = posPEGI & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEGI += 1
    '                        End If
    '                    Case "PE-Mental Status"
    '                        If posPEMentalStatus = "" Then
    '                            posPEMentalStatus = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMentalStatus += 1
    '                        Else
    '                            posPEMentalStatus = posPEMentalStatus & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMentalStatus += 1
    '                        End If
    '                    Case "PE-Mood"
    '                        If posPEMood = "" Then
    '                            posPEMood = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMood += 1
    '                        Else
    '                            posPEMood = posPEMood & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEMood += 1
    '                        End If
    '                    Case "PE-Behavior"
    '                        If posPEBehavior = "" Then
    '                            posPEBehavior = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEBehavior += 1
    '                        Else
    '                            posPEBehavior = posPEBehavior & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPEBehavior += 1
    '                        End If
    '                    Case "PE-lymphatic"
    '                        If posPELymphatic = "" Then
    '                            posPELymphatic = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPELymphatic += 1
    '                        Else
    '                            posPELymphatic = posPELymphatic & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPELymphatic += 1
    '                        End If
    '                    Case "PE-Neurological"
    '                        If posPENeurological = "" Then
    '                            posPENeurological = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeurological += 1
    '                        Else
    '                            posPENeurological = posPENeurological & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeurological += 1
    '                        End If

    '                    Case "PE-Neck"
    '                        If posPENeck = "" Then
    '                            posPENeck = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeck += 1
    '                        Else
    '                            posPENeck = posPENeck & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                            counterposPENeck += 1
    '                        End If

    '                    Case Else
    '                        Dim a As String = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString()
    '                        If posOther = "" Then
    '                            posOther = "OTHER: " & MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString & ": Positive for " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                        Else
    '                            posOther = posOther & ",  " & MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value
    '                        End If


    '                End Select
    '            End If
    '        Next


    '        '----------------------------------------------------------------

    '        '----------------------------------------------------------------




    '        Dim sCategory As String = ""
    '        Dim sSubCategory As String = ""
    '        Dim sDescription As String = ""
    '        Dim sNeg As String = ""
    '        Dim sPos As String = ""
    '        Dim sb As StringBuilder = New StringBuilder
    '        Dim sbPE As StringBuilder = New StringBuilder

    '        Dim s As String

    '        For i = 0 To MMCHRosAndGenDataGridView1.RowCount - 1

    '            If MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString.Length > 3 Then
    '                If MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString.Substring(0, 3) = "ROS" Then
    '                    If MMCHRosAndGenDataGridView1.Rows(i).Cells(3).Value = True Or MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                        If sCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value Then

    '                            sb.Append(Environment.NewLine)
    '                            sCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value
    '                            sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value & Environment.NewLine)
    '                            sb.Append("   ")

    '                            If sSubCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & "" Then
    '                                sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ": ")
    '                                sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
    '                            Else
    '                                sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ", ")
    '                            End If


    '                            If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                                sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(+)")
    '                            Else
    '                                sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(-)")
    '                            End If
    '                        Else
    '                            If sSubCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & "" Then
    '                                sb.Append(Environment.NewLine)
    '                                sb.Append("   ")
    '                                sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ": ")

    '                                If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                                    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(+)")
    '                                Else
    '                                    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(-)")
    '                                End If

    '                                sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
    '                            Else
    '                                sb.Append(",  ")
    '                                If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                                    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(+)")

    '                                Else
    '                                    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(-)")

    '                                End If
    '                            End If

    '                            'sb.Append(",  ")
    '                            'If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                            '    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(+)")
    '                            'Else
    '                            '    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(-)")
    '                            'End If
    '                        End If



    '                        'sCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value
    '                        'sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
    '                        ''  sDescription = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & ""

    '                        'sb.Append(sCategory & Environment.NewLine)
    '                        'sb.Append(sSubCategory)
    '                    End If
    '                End If
    '            End If

    '            If MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString.Length > 3 Then
    '                If MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString.Substring(0, 3) = "PE-" Then
    '                    If MMCHRosAndGenDataGridView1.Rows(i).Cells(3).Value = True Or MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                        If sCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value Then
    '                            sbPE.Append(Environment.NewLine)
    '                            sCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value
    '                            sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value & Environment.NewLine)
    '                            sbPE.Append("   ")

    '                            If sSubCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & "" Then
    '                                sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ": ")
    '                                sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
    '                            Else
    '                                sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ", ")
    '                            End If


    '                            If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                                sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(+)")
    '                            Else
    '                                sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(-)")
    '                            End If
    '                        Else
    '                            If sSubCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & "" Then
    '                                sbPE.Append(Environment.NewLine)
    '                                sbPE.Append("   ")
    '                                sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ": ")

    '                                If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                                    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(+)")
    '                                Else
    '                                    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(-)")
    '                                End If

    '                                sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
    '                            Else
    '                                sbPE.Append(",  ")
    '                                If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                                    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(+)")
    '                                Else
    '                                    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & " " & MMCHRosAndGenDataGridView1.Rows(i).Cells("detailtopost").Value & "(-)")
    '                                End If
    '                            End If

    '                            'sbPE.Append(",  ")
    '                            'If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
    '                            '    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(+)")
    '                            'Else
    '                            '    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(-)")
    '                            'End If
    '                        End If



    '                        'sCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value
    '                        'sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
    '                        ''  sDescription = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & ""

    '                        'sbPE.Append(sCategory & Environment.NewLine)
    '                        'sbPE.Append(sSubCategory)
    '                    End If
    '                End If
    '            End If


    '        Next
    '        'sb.Replace("   :", "   ")
    '        'sb.Replace("   ,", "   ")
    '        'sbPE.Replace("   :", "   ")
    '        'sbPE.Replace("   ,", "   ")

    '        'ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text & sb.ToString
    '        'PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & sbPE.ToString

    '        '----------------------------------------------------------------

    '        '----------------------------------------------------------------

    '        If negROSChest <> "" Then
    '            negROSChest = "CHEST: NEGATIVE for " & negROSChest & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSCONST <> "" Then
    '            negROSCONST = "CONST: NEGATIVE for " & negROSCONST & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSCV <> "" Then
    '            negROSCV = "CV: NEGATIVE for " & negROSCV & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSCVSPulmonary <> "" Then
    '            negROSCVSPulmonary = "CVS PULMONARY: NEGATIVE for " & negROSCVSPulmonary & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSEndocrine <> "" Then
    '            negROSEndocrine = "ENDOCRINE: NEGATIVE for " & negROSEndocrine & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSENT <> "" Then
    '            negROSENT = "ENT: NEGATIVE for " & negROSENT & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSEyes <> "" Then
    '            negROSEyes = "EYES: NEGATIVE for " & negROSEyes & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSFemaleGenital <> "" Then
    '            negROSFemaleGenital = "FEMALE GENITAL: NEGATIVE for " & negROSFemaleGenital & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSFemaleReproductive <> "" Then
    '            negROSFemaleReproductive = "FEMALE REPRODUCTIVE: NEGATIVE for " & negROSFemaleReproductive & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSGeneral <> "" Then
    '            negROSGeneral = "General: NEGATIVE for " & negROSGeneral & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSGI <> "" Then
    '            negROSGI = "GI: NEGATIVE for " & negROSGI & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSGU <> "" Then
    '            negROSGU = "GU: NEGATIVE for " & negROSGU & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSHEENT <> "" Then
    '            negROSHEENT = "HEENT: NEGATIVE for " & negROSHEENT & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSHEENT2 <> "" Then
    '            negROSHEENT2 = "HEENT2: NEGATIVE for " & negROSHEENT2 & ControlChars.CrLf & ControlChars.CrLf
    '        End If

    '        If negROSImmunological <> "" Then
    '            negROSImmunological = "IMMUNOLOGICAL: NEGATIVE for " & negROSImmunological & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSLymph <> "" Then
    '            negROSLymph = "LYMPH: NEGATIVE for " & negROSLymph & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSMuscSkel <> "" Then
    '            negROSMuscSkel = "MUSC SKELETAL: NEGATIVE for " & negROSMuscSkel & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSNeuro <> "" Then
    '            negROSNeuro = "NEURO: NEGATIVE for " & negROSNeuro & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSNeuroEyes <> "" Then
    '            negROSNeuroEyes = "NEURO EYES: NEGATIVE for " & negROSNeuroEyes & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSNormals <> "" Then
    '            negROSNormals = "NORMALS: NEGATIVE for " & negROSNormals & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSPulmonary <> "" Then
    '            negROSPulmonary = "PULMONARY: NEGATIVE for " & negROSPulmonary & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSResp <> "" Then
    '            negROSResp = "RESP: NEGATIVE for " & negROSResp & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSSkin <> "" Then
    '            negROSSkin = "SKIN: NEGATIVE for " & negROSSkin & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSSkinMS <> "" Then
    '            negROSSkinMS = "SKIN MS: NEGATIVE for " & negROSSkinMS & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSUrinary <> "" Then
    '            negROSUrinary = "URINARY: NEGATIVE for " & negROSUrinary & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negROSVestibular <> "" Then
    '            negROSVestibular = "VESTIBULAR: NEGATIVE for " & negROSVestibular & ControlChars.CrLf & ControlChars.CrLf
    '        End If

    '        If negPENormals <> "" Then
    '            negPENormals = "NORMALS: NEGATIVE for " & negPENormals & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEAbd <> "" Then
    '            negPEAbd = "ABDOMEN: NEGATIVE for " & negPEAbd & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEBack <> "" Then
    '            negPEBack = "BACK: NEGATIVE for " & negPEBack & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPECV <> "" Then
    '            negPECV = "CV PULMONARY: NEGATIVE for " & negPECV & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPECVS <> "" Then
    '            negPECVS = "CVS: NEGATIVE for " & negPECVS & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEENT <> "" Then
    '            negPEENT = "ENT: NEGATIVE for " & negPEENT & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEExtremities <> "" Then
    '            negPEExtremities = "EXTREMITIES: NEGATIVE for " & negPEExtremities & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEEyes <> "" Then
    '            negPEEyes = "EYES: NEGATIVE for " & negPEEyes & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEFemale <> "" Then
    '            negPEFemale = "FEMALE: NEGATIVE for " & negPEFemale & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEGeneral <> "" Then
    '            negPEGeneral = "GENERAL: NEGATIVE for " & negPEGeneral & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEGenitals <> "" Then
    '            negPEGenitals = "GENITALS: NEGATIVE for " & negPEGenitals & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEHeadNeck <> "" Then
    '            negPEHeadNeck = "HEAD/NECK: NEGATIVE for " & negPEHeadNeck & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEHEENT <> "" Then
    '            negPEHEENT = "HEENT: NEGATIVE for " & negPEHEENT & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEMale <> "" Then
    '            negPEMale = "MALE: NEGATIVE for " & negPEMale & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEMouthThroat <> "" Then
    '            negPEMouthThroat = "MOUTH/THROAT: NEGATIVE for " & negPEMouthThroat & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPENeckChest <> "" Then
    '            negPENeckChest = "NECK/CHEST: NEGATIVE for " & negPENeckChest & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEPelvicExam <> "" Then
    '            negPEPelvicExam = "PELVIC EXAM: NEGATIVE for " & negPEPelvicExam & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEPSYCH <> "" Then
    '            negPEPSYCH = "PSYCH: NEGATIVE for " & negPEPSYCH & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEPulm <> "" Then
    '            negPEPulm = "PULMONARY: NEGATIVE for " & negPEPulm & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPERectal <> "" Then
    '            negPERectal = "RECTAL: NEGATIVE for " & negPERectal & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPERespiratory <> "" Then
    '            negPERespiratory = "RESPIRATORY: NEGATIVE for " & negPERespiratory & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPESkin <> "" Then
    '            negPESkin = "SKIN: NEGATIVE for " & negPESkin & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEMS <> "" Then
    '            negPEMS = "MS: NEGATIVE for " & negPEMS & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEGait <> "" Then
    '            negPEGait = "GAIT: NEGATIVE for " & negPEGait & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEGU <> "" Then
    '            negPEGU = "GU: NEGATIVE for " & negPEGU & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEGI <> "" Then
    '            negPEGI = "GI: NEGATIVE for " & negPEGI & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEMentalStatus <> "" Then
    '            negPEMentalStatus = "MENTAL STATUS: NEGATIVE for " & negPEMentalStatus & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEMood <> "" Then
    '            negPEMood = "MOOD: NEGATIVE for " & negPEMood & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPEBehavior <> "" Then
    '            negPEBehavior = "BEHAVIOR: NEGATIVE for " & negPEBehavior & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPELymphatic <> "" Then
    '            negPELymphatic = "LYMPHATIC: NEGATIVE for " & negPELymphatic & ControlChars.CrLf & ControlChars.CrLf
    '        End If

    '        If negPENeck <> "" Then
    '            negPENeck = "Neck: NEGATIVE for " & negPENeck & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If negPENeurological <> "" Then
    '            negPENeurological = "Neurological: NEGATIVE for " & negPENeurological & ControlChars.CrLf & ControlChars.CrLf
    '        End If





    '        If posROSChest <> "" Then
    '            posROSChest = "CHEST: POSITIVE for " & posROSChest & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSCONST <> "" Then
    '            posROSCONST = "CONST: POSITIVE for " & posROSCONST & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSCV <> "" Then
    '            posROSCV = "CV: POSITIVE for " & posROSCV & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSCVSPulmonary <> "" Then
    '            posROSCVSPulmonary = "CVS PULMONARY: POSITIVE for " & posROSCVSPulmonary & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSEndocrine <> "" Then
    '            posROSEndocrine = "ENDOCRINE: POSITIVE for " & posROSEndocrine & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSENT <> "" Then
    '            posROSENT = "ENT: POSITIVE for " & posROSENT & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSEyes <> "" Then
    '            posROSEyes = "EYES: POSITIVE for " & posROSEyes & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSFemaleGenital <> "" Then
    '            posROSFemaleGenital = "FEMALE GENITAL: POSITIVE for " & posROSFemaleGenital & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSFemaleReproductive <> "" Then
    '            posROSFemaleReproductive = "FEMALE REPRODUCTIVE: POSITIVE for " & posROSFemaleReproductive & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSGeneral <> "" Then
    '            posROSGeneral = "General: POSITIVE for " & posROSGeneral & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSGI <> "" Then
    '            posROSGI = "GI: POSITIVE for " & posROSGI & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSGU <> "" Then
    '            posROSGU = "GU: POSITIVE for " & posROSGU & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSHEENT <> "" Then
    '            posROSHEENT = "HEENT: POSITIVE for " & posROSHEENT & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSHEENT2 <> "" Then
    '            posROSHEENT2 = "HEENT2: POSITIVE for " & posROSHEENT2 & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSImmunological <> "" Then
    '            posROSImmunological = "IMMUNOLOGICAL: POSITIVE for " & posROSImmunological & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSLymph <> "" Then
    '            posROSLymph = "LYMPH: POSITIVE for " & posROSLymph & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSMuscSkel <> "" Then
    '            posROSMuscSkel = "MUSC SKELETAL: POSITIVE for " & posROSMuscSkel & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSNeuro <> "" Then
    '            posROSNeuro = "NEURO: POSITIVE for " & posROSNeuro & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSNeuroEyes <> "" Then
    '            posROSNeuroEyes = "NEURO EYES: POSITIVE for " & posROSNeuroEyes & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSNormals <> "" Then
    '            posROSNormals = "NORMALS: POSITIVE for " & posROSNormals & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSPulmonary <> "" Then
    '            posROSPulmonary = "PULMONARY: POSITIVE for " & posROSPulmonary & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSResp <> "" Then
    '            posROSResp = "RESP: POSITIVE for " & posROSResp & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSSkin <> "" Then
    '            posROSSkin = "SKIN: POSITIVE for " & posROSSkin & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSSkinMS <> "" Then
    '            posROSSkinMS = "SKIN MS: POSITIVE for " & posROSSkinMS & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSUrinary <> "" Then
    '            posROSUrinary = "URINARY: POSITIVE for " & posROSUrinary & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posROSVestibular <> "" Then
    '            posROSVestibular = "VESTIBULAR: POSITIVE for " & posROSVestibular & ControlChars.CrLf & ControlChars.CrLf
    '        End If

    '        If posPENormals <> "" Then
    '            posPENormals = "NORMALS: POSITIVE for " & posPENormals & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEAbd <> "" Then
    '            posPEAbd = "ABDOMEN: POSITIVE for " & posPEAbd & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEBack <> "" Then
    '            posPEBack = "BACK: POSITIVE for " & posPEBack & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPECV <> "" Then
    '            posPECV = "CV PULMONARY: POSITIVE for " & posPECV & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPECVS <> "" Then
    '            posPECVS = "CVS: POSITIVE for " & posPECVS & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEENT <> "" Then
    '            posPEENT = "ENT: POSITIVE for " & posPEENT & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEExtremities <> "" Then
    '            posPEExtremities = "EXTREMITIES: POSITIVE for " & posPEExtremities & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEEyes <> "" Then
    '            posPEEyes = "EYES: POSITIVE for " & posPEEyes & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEFemale <> "" Then
    '            posPEFemale = "FEMALE: POSITIVE for " & posPEFemale & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEGeneral <> "" Then
    '            posPEGeneral = "GENERAL: POSITIVE for " & posPEGeneral & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEGenitals <> "" Then
    '            posPEGenitals = "GENITALS: POSITIVE for " & posPEGenitals & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEHeadNeck <> "" Then
    '            posPEHeadNeck = "HEAD/NECK: POSITIVE for " & posPEHeadNeck & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEHEENT <> "" Then
    '            posPEHEENT = "HEENT: POSITIVE for " & posPEHEENT & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEMale <> "" Then
    '            posPEMale = "MALE: POSITIVE for " & posPEMale & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEMouthThroat <> "" Then
    '            posPEMouthThroat = "MOUTH/THROAT: POSITIVE for " & posPEMouthThroat & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPENeckChest <> "" Then
    '            posPENeckChest = "NECK/CHEST: POSITIVE for " & posPENeckChest & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEPelvicExam <> "" Then
    '            posPEPelvicExam = "PELVIC EXAM: POSITIVE for " & posPEPelvicExam & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEPSYCH <> "" Then
    '            posPEPSYCH = "PSYCH: POSITIVE for " & posPEPSYCH & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEPulm <> "" Then
    '            posPEPulm = "PULMONARY: POSITIVE for " & posPEPulm & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPERectal <> "" Then
    '            posPERectal = "RECTAL: POSITIVE for " & posPERectal & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPERespiratory <> "" Then
    '            posPERespiratory = "RESPIRATORY: POSITIVE for " & posPERespiratory & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPESkin <> "" Then
    '            posPESkin = "SKIN: POSITIVE for " & posPESkin & ControlChars.CrLf & ControlChars.CrLf
    '        End If

    '        If posPEMS <> "" Then
    '            posPEMS = "MS: POSITIVE for " & posPEMS & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEGait <> "" Then
    '            posPEGait = "GAIT: POSITIVE for " & posPEGait & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEGU <> "" Then
    '            posPEGU = "GU: POSITIVE for " & posPEGU & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEGI <> "" Then
    '            posPEGI = "GI: POSITIVE for " & posPEGI & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEMentalStatus <> "" Then
    '            posPEMentalStatus = "MENTAL STATUS: POSITIVE for " & posPEMentalStatus & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEMood <> "" Then
    '            posPEMood = "MOOD: POSITIVE for " & posPEMood & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPEBehavior <> "" Then
    '            posPEBehavior = "BEHAVIOR: POSITIVE for " & posPEBehavior & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPELymphatic <> "" Then
    '            posPELymphatic = "LYMPHATIC: POSITIVE for " & posPELymphatic & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPENeck <> "" Then
    '            posPENeck = "Neck: POSITIVE for " & posPENeck & ControlChars.CrLf & ControlChars.CrLf
    '        End If
    '        If posPENeurological <> "" Then
    '            posPENeurological = "Neurological: POSITIVE for " & posPENeurological & ControlChars.CrLf & ControlChars.CrLf
    '        End If

    '        '***CHANGED***
    '        TabControl1.SelectedTab = ROSTab
    '        ' ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text & negROSChest & posROSChest & negROSCONST & posROSCONST & negROSCV & posROSCV & negROSCVSPulmonary & posROSCVSPulmonary & negROSEndocrine & posROSEndocrine & negROSENT & posROSENT & negROSEyes & posROSEyes & negROSFemaleGenital & posROSFemaleGenital & negROSFemaleReproductive & posROSFemaleReproductive & negROSGeneral & posROSGeneral & negROSGI & posROSGI & negROSGU & posROSGU & negROSHEENT & posROSHEENT & negROSHEENT2 & posROSHEENT2 & negROSImmunological & posROSImmunological & negROSLymph & posROSLymph & negROSMuscSkel & posROSMuscSkel & negROSNeuro & posROSNeuro & negROSNeuroEyes & posROSNeuroEyes & negROSNormals & posROSNormals & negROSPulmonary & posROSPulmonary & negROSResp & posROSResp & negROSSkin & posROSSkin & negROSSkinMS & posROSSkinMS & negROSUrinary & posROSUrinary & negROSVestibular & posROSVestibular & posOther & negOther
    '        TabControl1.SelectedTab = PETab
    '        'PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & negPENormals & posPENormals & negPEAbd & posPEAbd & negPEBack & posPEBack & negPECV & posPECV & negPECVS & posPECVS & negPEENT & posPEENT & negPEExtremities & posPEExtremities & negPEEyes & posPEEyes & negPEFemale & posPEFemale & negPEGeneral & posPEGeneral & negPEGenitals & posPEGenitals & negPEHeadNeck & posPEHeadNeck & negPEHEENT & posPEHEENT & negPEMale & posPEMale & negPEMouthThroat & posPEMouthThroat & negPENeckChest & posPENeckChest & negPEPelvicExam & posPEPelvicExam & negPEPSYCH & posPEPSYCH & negPEPulm & posPEPulm & negPERectal & posPERectal & negPERespiratory & posPERespiratory & negPESkin & posPESkin & negPEMS & posPEMS & negPEGait & posPEGait & negPEGU & posPEGU & negPEGI & posPEGI & negPEMentalStatus & posPEMentalStatus & negPEMood & posPEMood & negPEBehavior & posPEBehavior & negPELymphatic & posPELymphatic & negOther
    '        '  PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & negPENormals & posPENormals & negPEGeneral & posPEGeneral & negPEEyes & posPEEyes & negPEENT & posPEENT & negPEHEENT & posPEHEENT & negPEHeadNeck & posPEHeadNeck & negPENeck & posPENeck & negPEMouthThroat & posPEMouthThroat & negPENeckChest & posPENeckChest & negPEAbd & posPEAbd & negPEBack & posPEBack & negPECV & posPECV & negPECVS & posPECVS & negPEFemale & posPEFemale & negPEGenitals & posPEGenitals & negPEMale & posPEMale & negPEPelvicExam & posPEPelvicExam & negPEPSYCH & posPEPSYCH & negPEPulm & posPEPulm & negPERectal & posPERectal & negPERespiratory & posPERespiratory & negPESkin & posPESkin & negPEMS & posPEMS & negPEGait & posPEGait & negPEExtremities & posPEExtremities & negPEGU & posPEGU & negPEGI & posPEGI & negPENeurological & posPENeurological & negPEMentalStatus & posPEMentalStatus & negPEMood & posPEMood & negPEBehavior & posPEBehavior & negPELymphatic & posPELymphatic & posOther & negOther

    '        sb.Replace("   :", "   ")
    '        sb.Replace("   ,", "   ")
    '        sbPE.Replace("   :", "   ")
    '        sbPE.Replace("   ,", "   ")

    '        ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text & sb.ToString
    '        PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & sbPE.ToString

    '        PEBulletsCount.Text = counterposPENormals + counterposPEAbd + counterposPEBack + counterposPECV + counterposPECVS + counterposPEENT + counterposPEExtremities + counterposPEEyes + counterposPEFemale + counterposPEGeneral + counterposPEGenitals + counterposPEHeadNeck + counterposPEHEENT + counterposPEMale + counterposPEMouthThroat + counterposPENeckChest + counterposPEPelvicExam + counterposPEPSYCH + counterposPEPulm + counterposPERectal + counterposPERespiratory + counterposPESkin + counterposPEMS + counterposPEGait + counterposPEGU + counterposPEGI + counterposPEMentalStatus + counterposPEMood + counterposPEBehavior + counterposPELymphatic + counterposPENeurological + counterposPENeck
    '        ROSBulletsCount.Text = counterposROSCONST + counterposROSCV + counterposROSCVSPulmonary + counterposROSEndocrine + counterposROSENT + counterposROSEyes + counterposROSFemaleGenital + counterposROSFemaleReproductive + counterposROSGeneral + counterposROSGI + counterposROSGU + counterposROSHEENT + counterposROSHEENT2 + counterposROSImmunological + counterposROSLymph + counterposROSMuscSkel + counterposROSNeuro + counterposROSNeuroEyes + counterposROSNormals + counterposROSPulmonary + counterposROSResp + counterposROSSkin + counterposROSSkinMS + counterposROSUrinary + counterposROSVestibular + counterposROSChest

    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub btnVitalSigns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVitalSigns.Click

        'aRet(1) = ChartNumberTextBox.Text
        'aRet(3) = FirstNameTextBox.Text
        'aRet(2) = LastNameTextBox.Text
        'aRet(10) = CaseNumberTextBox.Text & ""
        'VitalSigns.ShowVitalSigns(aRet)
        'Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text, txtCopyDate.Text)

        Dim vitalArray(10) As String
        vitalArray(1) = ChartNumberTextBox.Text
        vitalArray(3) = FirstNameTextBox.Text
        vitalArray(2) = LastNameTextBox.Text
        vitalArray(10) = CaseNumberTextBox.Text & ""
        vitalArray(9) = txtCopyDate.Text
        VitalSigns.ShowVitalSigns(vitalArray)
        Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text, txtCopyDate.Text)

    End Sub

    Private Sub RadioButtonTestImaging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonTestImaging.CheckedChanged
        Try
            If RadioButtonTestImaging.Checked = True Then
                ' Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                ' read the number of rows
                Dim cmd As New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestImaging order by Description", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMChartTestImaging")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource

                ' DataGridViewPr.DataSource = ds.Tables("MMChartTestImaging")
                ds.Dispose()
                cn.Close()
                If globalTemplate <> "" Then
                    radTemplateDX.Checked = True
                    LoadTemplateSpecificDxPrTests()
                Else
                    radMyDx.Checked = True
                End If
                '***CHANGED***
                TabControl3.SelectedTab = DxPrTestsPickTab
                TabControl1.SelectedTab = DxPrTestsTab
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnRefreshVitalSigns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshVitalSigns.Click
        Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text, txtCopyDate.Text)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCopyLastName.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        If TempR.Checked = True Then
            TempTextBox.Text = TempTextBox.Text & ListBox1.Text
        ElseIf RespR.Checked = True Then
            RespTextBox.Text = RespTextBox.Text & ListBox1.Text
        ElseIf PulseOxR.Checked = True Then
            PulseOxTextBox.Text = PulseOxTextBox.Text & ListBox1.Text
        ElseIf PulseR.Checked = True Then
            PulseTextBox.Text = PulseTextBox.Text & ListBox1.Text
        ElseIf HTR.Checked = True Then
            HtTextBox.Text = HtTextBox.Text & ListBox1.Text
        ElseIf WTR.Checked = True Then
            WtTextBox.Text = WtTextBox.Text & ListBox1.Text
        ElseIf SystolicR.Checked = True Then
            SystolicTextBox.Text = SystolicTextBox.Text & ListBox1.Text
        ElseIf SystolicR.Checked = True Then
            SystolicTextBox.Text = SystolicTextBox.Text & ListBox1.Text
        ElseIf DistolicR.Checked = True Then
            DistolicTextBox.Text = DistolicTextBox.Text & ListBox1.Text

        End If


    End Sub

    Private Sub btnSketch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSketch.Click
        'BodySketch.Show()
        Dim arrayRet(3) As String
        arrayRet(0) = txtCopyChartNumber.Text
        arrayRet(1) = txtCopyCaseNumber.Text
        arrayRet(2) = txtCopyDate.Text
        BodySketch.ShowBodySketch(arrayRet)
    End Sub

    Public Function RetrieveBodySketch()
        Try
            btnSketch.Visible = False
            If Not (PictureBoxBodySketch.Image Is Nothing) Then
                PictureBoxBodySketch.Image.Dispose()
                PictureBoxBodySketch.Image = Nothing
            End If

            Dim originalimage As System.Drawing.Image
            Dim thumb As System.Drawing.Image
            Dim inp As New IntPtr()

            originalimage = Image.FromFile("C:\BodySketches\" & txtCopyChartNumber.Text & txtCopyCaseNumber.Text & ".jpeg")

            thumb = originalimage.GetThumbnailImage(539, 558, Nothing, inp)
            Me.PictureBoxBodySketch.Image = thumb


        Catch ex As System.IO.FileNotFoundException
            btnSketch.Visible = True
        Catch ex As System.Exception

        End Try

    End Function

    Private Sub CaseNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaseNumberTextBox.TextChanged
        txtCopyCaseNumber.Text = CaseNumberTextBox.Text
    End Sub

    Public Function GetAge(ByVal Birthdate As System.DateTime, _
        Optional ByVal AsOf As System.DateTime = #1/1/1700#) _
        As String

        'Don't set second parameter if you want Age as of today

        'Demo 1: get age of person born 2/11/1954
        'Dim objDate As New System.DateTime(1954, 2, 11)
        'Debug.WriteLine(GetAge(objDate))

        'Demo 1: get same person's age 10 years from now
        'Dim objDate As New System.DateTime(1954, 2, 11)
        'Dim objdate2 As System.DateTime
        'objdate2 = Now.AddYears(10)
        'Debug.WriteLine(GetAge(objDate, objdate2))

        Dim iMonths As Integer
        Dim iYears As Integer
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


    Private Sub radAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAll.CheckedChanged
        If radAll.Checked = True Then

            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand

            Try

                radTemplateDX.BackColor = Color.Transparent
                radMyDx.BackColor = Color.Transparent
                radAll.BackColor = Color.FromArgb(148, 183, 233)

                If RadioButtonDx.Checked Then
                    cmd = New SqlCommand("SELECT     MMDX.Code1 AS Code, MMDX.Description FROM MMDX ORDER BY MMDX.Description", cn)

                ElseIf RadioButtonPr.Checked Then
                    cmd = New SqlCommand("SELECT Code1 As Code, Description, AmountA, MyProcedures, ScreenLocation, Type, InHouse, InHouseBilling  from  MMProcedure order by Description", cn)

                ElseIf RadioButtonLT.Checked Then
                    cmd = New SqlCommand("SELECT TestNo, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestLab order by Description", cn)

                ElseIf RadioButtonMT.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMCHARTTESTMEDICAL order by Description", cn)

                ElseIf RadioButtonTestImaging.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestImaging order by Description", cn)

                ElseIf radPlan.Checked Then
                    cmd = New SqlCommand("SELECT SubCategory, Discription as Description from  MMCHRosAndGen where category= 'Plan' ORDER BY ScreenLocation ", cn)

                ElseIf radProcedureNotes.Checked Then
                    cmd = New SqlCommand("SELECT SubCategory, Discription as Description from  MMCHRosAndGen where category= 'Procedure Notes' ORDER BY ScreenLocation ", cn)

                ElseIf radOther.Checked Then
                    cmd = New SqlCommand("SELECT SubCategory, Discription as Description from  MMCHRosAndGen where category= 'OtherTx Panel' ORDER BY ScreenLocation ", cn)

                ElseIf radCounseling.Checked Then
                    cmd = New SqlCommand("SELECT SubCategory, Discription as Description from  MMCHRosAndGen where category= 'Counseling' ORDER BY ScreenLocation  ", cn)

                ElseIf radImpressions.Checked Then
                    cmd = New SqlCommand("SELECT SubCategory, Discription as Description from  MMCHRosAndGen where category= 'Assessment' ORDER BY ScreenLocation ", cn)
                Else
                    DataGridViewPr.DataSource = Nothing
                    Exit Sub
                End If

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
                Me.DataGridViewPr.Columns(0).Width = 70
                Me.DataGridViewPr.Columns("Description").Width = 347


            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub radMyDx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMyDx.CheckedChanged
        If radMyDx.Checked = True Then
            radTemplateDX.BackColor = Color.Transparent
            radMyDx.BackColor = Color.FromArgb(148, 183, 233)
            radAll.BackColor = Color.Transparent

            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand

            Try
                If RadioButtonDx.Checked Then

                    cmd = New SqlCommand("SELECT MMDX.Code1 AS Code, MMDX.Description FROM  MMDX LEFT JOIN  PhysicianProfile ON MMDX.Code1 = PhysicianProfile.Code WHERE  physiciancode = '" & AssignedProviderTextBox.Text & "' ORDER BY MMDX.Description", cn)

                ElseIf RadioButtonPr.Checked Then
                    cmd = New SqlCommand("SELECT Code1 As Code, MMPRocedure.Description, AmountA, MyProcedures, ScreenLocation, MMPRocedure.Type, InHouse, InHouseBilling  FROM   MMPRocedure LEFT JOIN PhysicianProfile ON MMPRocedure.Code1 = PhysicianProfile.Code where  physiciancode = '" & AssignedProviderTextBox.Text & "' order by Description", cn)

                ElseIf RadioButtonLT.Checked Then
                    cmd = New SqlCommand("SELECT TestNo, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestLab  order by Description", cn)

                ElseIf RadioButtonMT.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMCHARTTESTMEDICAL  order by Description", cn)

                ElseIf RadioButtonTestImaging.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestImaging  order by Description", cn)
                Else
                    DataGridViewPr.DataSource = Nothing
                    Exit Sub
                End If

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
                'Me.DataGridViewPr.Columns(0).Width = 70
                'Me.DataGridViewPr.Columns(1).Width = 347

            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub grpPatient_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpPatient.Enter

    End Sub

    Private Sub AssignedProviderTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignedProviderTextBox.TextChanged

    End Sub

    'Private Sub MMCHRosAndGenDataGridView1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    CheckedListBox1.Items.Clear()


    '    ' If e.ColumnIndex = MMCHRosAndGenDataGridView1.Columns("DetailButton").Index Then

    '    If MMCHRosAndGenDataGridView1.Rows(e.RowIndex).Cells("DetailOfItem").Value <> "" Then
    '        rowIndex = e.RowIndex
    '        Dim arrActions() As String
    '        Dim item As String
    '        Dim ItemsToSplit As String = MMCHRosAndGenDataGridView1.Rows(e.RowIndex).Cells("DetailOfItem").Value
    '        arrActions = ItemsToSplit.Split(",")

    '        For Each item In arrActions
    '            CheckedListBox1.Items.Add(item)
    '        Next

    '        'Dim MousePosition As Point
    '        'MousePosition = Cursor.Position
    '        '' CheckedListBox1.Location = New Point(MousePosition.X, MousePosition.Y)
    '        'CheckedListBox1.Location = New Point(e.ColumnIndex(, e.location.Y)
    '        'CheckedListBox1.BringToFront()
    '    End If

    '    ' End If



    'End Sub

    'Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged
    '    Dim i As Integer
    '    Dim ii As Integer
    '    Dim itemsSB As String
    '    Dim itemsToAdd As String
    '    For i = 0 To CheckedListBox1.Items.Count - 1
    '        itemsSB = itemsSB + CheckedListBox1.Items(i).ToString
    '    Next
    '    If MMCHRosAndGenDataGridView1.Rows(rowIndex).Cells("DetailOfItem").Value.ToString.Replace(",", "") = itemsSB Then
    '        If MMCHRosAndGenDataGridView1.Rows(rowIndex).Cells("DetailtoPost").Value <> "" Then
    '            MMCHRosAndGenDataGridView1.Rows(rowIndex).Cells("DetailtoPost").Value = MMCHRosAndGenDataGridView1.Rows(rowIndex).Cells("DetailtoPost").Value & ", " & CheckedListBox1.SelectedItem.ToString
    '        Else
    '            MMCHRosAndGenDataGridView1.Rows(rowIndex).Cells("DetailtoPost").Value = CheckedListBox1.SelectedItem.ToString
    '        End If
    '    End If
    'End Sub



    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim MousePosition As Point
    '    MousePosition = Cursor.Position
    '    CheckedListBox1.Location = New Point(MousePosition.X, MousePosition.Y)

    'End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCTab.Click

    End Sub


    Private Function LockControls()
        If SignesCheckBox.Checked <> False Then
            TabControl1.TabPages(1).Enabled = False
            TabControl1.TabPages(2).Enabled = False
            TabControl1.TabPages(0).Enabled = False
            TabControl1.TabPages(3).Enabled = False
            TabControl1.TabPages(4).Enabled = False
            TabControl1.TabPages(5).Enabled = False
            TabControl3.Enabled = False
            SignesCheckBox.Enabled = False
            txtMode.Text = "LOCKED"
        Else
            UnlockControls()
        End If

    End Function


    Private Function UnlockControls()
        TabControl1.TabPages(1).Enabled = True
        TabControl1.TabPages(2).Enabled = True
        TabControl1.TabPages(0).Enabled = True
        TabControl1.TabPages(3).Enabled = True
        TabControl1.TabPages(4).Enabled = True
        TabControl1.TabPages(5).Enabled = True
        TabControl3.Enabled = True
        SignesCheckBox.Enabled = True
        txtMode.Text = "EDIT"
    End Function

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        UnlockControls()

        BindingNavigatorAddNewItem.Visible = False
        txtMode.Text = "ADD"
        MessageBox.Show("Default date of service is entered as todays date. Please correct if it is needed.", "Note Date of Service", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub SignesCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignesCheckBox.CheckedChanged
        LockControls()
    End Sub

    Private Sub btnPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlan.Click
        Try
            'TabControl3.SelectedIndex = 3
            'TabControl1.SelectedIndex = 5
            RadioButtonDx.Checked = False
            radProcedureNotes.Checked = False
            radPlan.Checked = True


            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'Plan' ORDER BY ScreenLocation ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()
            'Me.DataGridViewPr.Columns(0).Width = 5
            'Me.DataGridViewPr.Columns(1).Width = 70
            'Me.DataGridViewPr.Columns(2).Width = 347
            'Me.DataGridViewPr.Columns(3).Width = 25

            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False

            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnProcedureNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcedureNotes.Click
        Try
            'TabControl3.SelectedIndex = 3
            'TabControl1.SelectedIndex = 5
            RadioButtonDx.Checked = False
            radPlan.Checked = False
            radProcedureNotes.Checked = True
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'Procedure Notes' ORDER BY ScreenLocation ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()
            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False

            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub cmdRosDetailed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRosDetailed.Click
        'Try

        '    aRet = RosGeneral.ShowPicklist
        '    If aRet(0) = "Y" Then

        '        ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text + " " + aRet(1)

        '    End If
        'Catch
        'End Try

        '***CHANGED***
        TabControl1.SelectedTab = ROSTab
        TabControl1.SelectedTab = PETab

        Try
            Dim ChCsDtArray(2) As String
            ChCsDtArray(0) = txtCopyChartNumber.Text
            ChCsDtArray(1) = txtCopyCaseNumber.Text
            ChCsDtArray(2) = txtCopyDate.Text
            'BodySketch.ShowBodySketch(arrayRet)

            aRet = PhysicalExamination.ShowPicklist(ChCsDtArray)
            If aRet(0) = "Y" Then
                PhysicalExamTextBox.Text = PhysicalExamTextBox.Text + " " + aRet(1)
                ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text + " " + aRet(2)
                PEBulletsCount.Text = aRet(3)
                ROSBulletsCount.Text = aRet(4)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdPeDetailed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPeDetailed.Click
        '***CHANGED***
        TabControl1.SelectedTab = ROSTab
        TabControl1.SelectedTab = PETab

        Try
            Dim ChCsDtArray(2) As String
            ChCsDtArray(0) = txtCopyChartNumber.Text
            ChCsDtArray(1) = txtCopyCaseNumber.Text
            ChCsDtArray(2) = txtCopyDate.Text
            'BodySketch.ShowBodySketch(arrayRet)

            aRet = PhysicalExamination.ShowPicklist(ChCsDtArray)
            If aRet(0) = "Y" Then
                PhysicalExamTextBox.Text = PhysicalExamTextBox.Text + " " + aRet(1)
                ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text + " " + aRet(2)
                PEBulletsCount.Text = aRet(3)
                ROSBulletsCount.Text = aRet(4)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnPickCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickCC.Click
        Try
            Dim frmTemplatePicklist As New TemplatePicklist
            aPickCC = frmTemplatePicklist.ShowPicklist
            If aPickCC(0) = "Y" Then
                globalTemplate = aPickCC(1)
                globalChiefComplaint = aPickCC(2)
                Me.Text = "Visit Template Specific" + "                                                                               " + globalTemplate + "- " + globalChiefComplaint
                'If globalTemplate <> "" Then
                '    '***CHANGED***
                '    TabControl1.SelectedTab = DxPrTestsTab
                '    TabControl1.SelectedTab = HPITab
                '    radTemplateDX.PerformClick()
                'End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub radTemplateDX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTemplateDX.CheckedChanged
        LoadTemplateSpecificDxPrTests()
    End Sub

    Private Function LoadTemplateSpecificDxPrTests()
        Dim strDXCodes As String
        Dim strPRCodes As String
        Dim strHasRows = False
        Try
            radTemplateDX.BackColor = Color.FromArgb(148, 183, 233)
            radMyDx.BackColor = Color.Transparent
            radAll.BackColor = Color.Transparent
            If globalTemplate <> "" Then
                If radTemplateDX.Checked = True Then

                    If RadioButtonDx.Checked Then

                        Dim strQID As String
                        '******************************************
                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand("SELECT subcategory FROM QIDS where TemplateName= '" & globalTemplate & "' AND category = 'DX'", cn)
                        Dim dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strQID = strQID + "'" + dr.Item(0).ToString + "'" + ","
                        End While
                        dr.Close()
                        cn.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString3 As String = connString2
                        Dim cn3 As New SqlConnection(connString)
                        cn3.Open()
                        Dim cmd3 As New SqlCommand


                        cmd3 = New SqlCommand("SELECT MMDX.Code1 AS Code, MMDX.Description FROM  MMDX  WHERE  MMDX.Code1 IN (" & strQID.TrimEnd(",") & " ) ORDER BY MMDX.Description", cn3)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd3
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn3.Close()


                        Me.DataGridViewPr.Columns(0).Width = 70
                        Me.DataGridViewPr.Columns(1).Width = 347


                        ''******************************************
                        'Dim DPconnString As String = connStringDP
                        'Dim cn2 As New SqlConnection(DPconnString)
                        'cn2.Open()
                        'Dim cmd2 As New SqlCommand("SELECT DIAGNOSIS FROM CCProfiles where TemplateName= '" & globalTemplate & "'", cn2)
                        'Dim dr As SqlDataReader = cmd2.ExecuteReader()
                        'While dr.Read
                        '    strHasRows = True
                        '    strDXCodes = dr.Item(0).ToString
                        'End While
                        'dr.Close()
                        'cn2.Close()
                        'If strHasRows = False Then
                        '    radMyDx.Checked = True
                        '    ColorCustomMylistAllButtons()
                        '    Exit Function
                        'End If
                        ''******************************************

                        'Dim connString As String = connString2
                        'Dim cn As New SqlConnection(connString)
                        'cn.Open()
                        'Dim cmd As New SqlCommand
                        'Dim splitlist As String() = strDXCodes.Split(",")
                        'Dim newDxList As String = "'" + String.Join("','", splitlist) + "'"

                        'cmd = New SqlCommand("SELECT MMDX.Code1 AS Code, MMDX.Description FROM  MMDX  WHERE  MMDX.Code1 IN (" & newDxList.ToString & " ) ORDER BY MMDX.Description", cn)

                        'Dim da As New SqlDataAdapter
                        'Dim tbl As New DataTable
                        'Dim ds As New DataSet
                        'da.SelectCommand = cmd
                        'da.Fill(ds, "MMDX")

                        'myBindingSource = New BindingSource()
                        'myBindingSource.DataSource = ds
                        'myBindingSource.DataMember = ds.Tables(0).TableName
                        'DataGridViewPr.DataSource = myBindingSource

                        'ds.Dispose()
                        'cn.Close()

                        'Me.DataGridViewPr.Columns(0).Width = 70
                        'Me.DataGridViewPr.Columns(1).Width = 347


                    ElseIf RadioButtonPr.Checked Then

                        Dim strQID As String
                        '******************************************
                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand("SELECT subcategory FROM QIDS where TemplateName= '" & globalTemplate & "' AND category = 'PR'", cn)
                        Dim dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strQID = strQID + "'" + dr.Item(0).ToString + "'" + ","
                        End While
                        dr.Close()
                        cn.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString3 As String = connString2
                        Dim cn3 As New SqlConnection(connString)
                        cn3.Open()
                        Dim cmd3 As New SqlCommand


                        cmd3 = New SqlCommand("SELECT MMPRocedure.Code1 AS Code, MMPRocedure.Description, AmountA, MyProcedures, ScreenLocation, MMPRocedure.Type , MMPRocedure.InHouse, MMPRocedure.InHouseBilling FROM  MMPRocedure WHERE  MMPRocedure.Code1 IN (" & strQID.TrimEnd(",") & " ) ORDER BY MMPRocedure.Description", cn3)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd3
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn3.Close()


                        Me.DataGridViewPr.Columns(0).Width = 70
                        Me.DataGridViewPr.Columns(1).Width = 347




                        ''******************************************
                        'Dim DPconnString As String = connStringDP
                        'Dim cn2 As New SqlConnection(DPconnString)
                        'cn2.Open()
                        'Dim cmd2 As New SqlCommand("SELECT PROCEDURES FROM CCProfiles where TemplateName= '" & globalTemplate & "'", cn2)
                        'Dim dr As SqlDataReader = cmd2.ExecuteReader()
                        'While dr.Read
                        '    strHasRows = True
                        '    strDXCodes = dr.Item(0).ToString
                        'End While
                        'dr.Close()
                        'cn2.Close()
                        'If strHasRows = False Then
                        '    radMyDx.Checked = True
                        '    ColorCustomMylistAllButtons()
                        '    Exit Function
                        'End If
                        ''******************************************

                        'Dim connString As String = connString2
                        'Dim cn As New SqlConnection(connString)
                        'cn.Open()
                        'Dim cmd As New SqlCommand
                        'Dim splitlist As String() = strDXCodes.Split(",")
                        'Dim newDxList As String = "'" + String.Join("','", splitlist) + "'"

                        'cmd = New SqlCommand("SELECT MMPRocedure.Code1 AS Code, MMPRocedure.Description, AmountA, MyProcedures, ScreenLocation, MMPRocedure.Type FROM  MMPRocedure WHERE  MMPRocedure.Code1 IN (" & newDxList.ToString & " ) ORDER BY MMPRocedure.Description", cn)

                        'Dim da As New SqlDataAdapter
                        'Dim tbl As New DataTable
                        'Dim ds As New DataSet
                        'da.SelectCommand = cmd
                        'da.Fill(ds, "MMDX")

                        'myBindingSource = New BindingSource()
                        'myBindingSource.DataSource = ds
                        'myBindingSource.DataMember = ds.Tables(0).TableName
                        'DataGridViewPr.DataSource = myBindingSource

                        'ds.Dispose()
                        'cn.Close()

                        'Me.DataGridViewPr.Columns(0).Width = 70
                        'Me.DataGridViewPr.Columns(1).Width = 347

                    ElseIf RadioButtonLT.Checked Then

                        '******************************************
                        Dim DPconnString As String = connStringDP
                        Dim cn2 As New SqlConnection(DPconnString)
                        cn2.Open()
                        Dim cmd2 As New SqlCommand("SELECT LAB_ORDERS FROM CCProfiles where TemplateName= '" & globalTemplate & "'", cn2)
                        Dim dr As SqlDataReader = cmd2.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strDXCodes = dr.Item(0).ToString
                        End While
                        dr.Close()
                        cn2.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand
                        Dim splitlist As String() = strDXCodes.Split(",")
                        Dim newDxList As String = "'" + String.Join("','", splitlist) + "'"

                        cmd = New SqlCommand("SELECT MMChartTestLab.TestNo AS Code, MMChartTestLab.Description, Amount, MyTest, Type , InHouse, InHouseBilling FROM  MMChartTestLab WHERE  MMChartTestLab.TestNo IN (" & newDxList.ToString & " ) ORDER BY MMChartTestLab.Description", cn)

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

                        Me.DataGridViewPr.Columns(0).Width = 70
                        Me.DataGridViewPr.Columns(1).Width = 347

                    ElseIf RadioButtonTestImaging.Checked Then

                        '******************************************
                        Dim DPconnString As String = connStringDP
                        Dim cn2 As New SqlConnection(DPconnString)
                        cn2.Open()
                        Dim cmd2 As New SqlCommand("SELECT ImagingTests FROM CCProfiles where TemplateName= '" & globalTemplate & "'", cn2)
                        Dim dr As SqlDataReader = cmd2.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strDXCodes = dr.Item(0).ToString
                        End While
                        dr.Close()
                        cn2.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand
                        Dim splitlist As String() = strDXCodes.Split(",")
                        Dim newDxList As String = "'" + String.Join("','", splitlist) + "'"

                        cmd = New SqlCommand("SELECT MMChartTestImaging.id AS Code, MMChartTestImaging.Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM  MMChartTestImaging WHERE  MMChartTestImaging.id IN (" & newDxList.ToString & " ) ORDER BY MMChartTestImaging.Description", cn)

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

                        Me.DataGridViewPr.Columns(0).Width = 70
                        Me.DataGridViewPr.Columns(1).Width = 347


                    ElseIf RadioButtonMT.Checked Then

                        '******************************************
                        Dim DPconnString As String = connStringDP
                        Dim cn2 As New SqlConnection(DPconnString)
                        cn2.Open()
                        Dim cmd2 As New SqlCommand("SELECT MedicalTests FROM CCProfiles where TemplateName= '" & globalTemplate & "'", cn2)
                        Dim dr As SqlDataReader = cmd2.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strDXCodes = dr.Item(0).ToString
                        End While
                        dr.Close()
                        cn2.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand
                        Dim splitlist As String() = strDXCodes.Split(",")
                        Dim newDxList As String = "'" + String.Join("','", splitlist) + "'"

                        cmd = New SqlCommand("SELECT MMChartTestMedical.id AS Code, MMChartTestMedical.Description, Amount, MyTest, Type, InHouse, InHouseBilling  FROM  MMChartTestMedical WHERE  MMChartTestMedical.id IN (" & newDxList.ToString & " ) ORDER BY MMChartTestMedical.Description", cn)

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

                        Me.DataGridViewPr.Columns(0).Width = 70
                        Me.DataGridViewPr.Columns(1).Width = 347


                    ElseIf radPlan.Checked Then

                        Dim strQID As String
                        '******************************************
                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand("SELECT QID, category, subcategory FROM QIDS where TemplateName= '" & globalTemplate & "' AND Subcategory = 'Plan'", cn)
                        Dim dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strQID = strQID + dr.Item(0).ToString & ","
                        End While
                        dr.Close()
                        cn.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString3 As String = connString2
                        Dim cn3 As New SqlConnection(connString)
                        cn3.Open()
                        Dim cmd3 As New SqlCommand


                        cmd3 = New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation from  MMCHRosAndGen where category= 'Plan' AND QID IN(" & strQID.TrimEnd(",") & ")ORDER BY ScreenLocation ", cn3)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd3
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn3.Close()

                        Me.DataGridViewPr.Columns(0).Visible = False
                        Me.DataGridViewPr.Columns(1).Visible = True
                        Me.DataGridViewPr.Columns(2).Width = 347
                        Me.DataGridViewPr.Columns(3).Visible = False




                    ElseIf radProcedureNotes.Checked Then

                        Dim strQID As String
                        '******************************************
                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand("SELECT QID, category, subcategory FROM QIDS where TemplateName= '" & globalTemplate & "' AND Subcategory = 'Procedure Notes'", cn)
                        Dim dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strQID = strQID + dr.Item(0).ToString & ","
                        End While
                        dr.Close()
                        cn.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString3 As String = connString2
                        Dim cn3 As New SqlConnection(connString)
                        cn3.Open()
                        Dim cmd3 As New SqlCommand


                        cmd3 = New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation from  MMCHRosAndGen where category= 'Procedure Notes' AND QID IN(" & strQID.TrimEnd(",") & ")ORDER BY ScreenLocation ", cn3)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd3
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn3.Close()

                        Me.DataGridViewPr.Columns(0).Visible = False
                        Me.DataGridViewPr.Columns(1).Visible = True
                        Me.DataGridViewPr.Columns(2).Width = 347
                        Me.DataGridViewPr.Columns(3).Visible = False


                    ElseIf radOther.Checked Then

                        Dim strQID As String
                        '******************************************
                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand("SELECT QID, category, subcategory FROM QIDS where TemplateName= '" & globalTemplate & "' AND Subcategory = 'OtherTx Panel'", cn)
                        Dim dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strQID = strQID + dr.Item(0).ToString & ","
                        End While
                        dr.Close()
                        cn.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString3 As String = connString2
                        Dim cn3 As New SqlConnection(connString)
                        cn3.Open()
                        Dim cmd3 As New SqlCommand


                        cmd3 = New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation from  MMCHRosAndGen where category= 'OtherTx Panel' AND QID IN(" & strQID.TrimEnd(",") & ")ORDER BY ScreenLocation ", cn3)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd3
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn3.Close()

                        Me.DataGridViewPr.Columns(0).Visible = False
                        Me.DataGridViewPr.Columns(1).Visible = True
                        Me.DataGridViewPr.Columns(2).Width = 347
                        Me.DataGridViewPr.Columns(3).Visible = False


                    ElseIf radCounseling.Checked Then

                        Dim strQID As String
                        '******************************************
                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand("SELECT QID, category, subcategory FROM QIDS where TemplateName= '" & globalTemplate & "' AND Subcategory = 'Counseling'", cn)
                        Dim dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strQID = strQID + dr.Item(0).ToString & ","
                        End While
                        dr.Close()
                        cn.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString3 As String = connString2
                        Dim cn3 As New SqlConnection(connString)
                        cn3.Open()
                        Dim cmd3 As New SqlCommand


                        cmd3 = New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation from  MMCHRosAndGen where category= 'Counseling' AND QID IN(" & strQID.TrimEnd(",") & ")ORDER BY ScreenLocation ", cn3)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd3
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn3.Close()

                        Me.DataGridViewPr.Columns(0).Visible = False
                        Me.DataGridViewPr.Columns(1).Visible = True
                        Me.DataGridViewPr.Columns(2).Width = 347
                        Me.DataGridViewPr.Columns(3).Visible = False

                    ElseIf radImpressions.Checked Then

                        Dim strQID As String
                        '******************************************
                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand("SELECT QID, category, subcategory FROM QIDS where TemplateName= '" & globalTemplate & "' AND Subcategory = 'Assessment'", cn)
                        Dim dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strQID = strQID + dr.Item(0).ToString & ","
                        End While
                        dr.Close()
                        cn.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString3 As String = connString2
                        Dim cn3 As New SqlConnection(connString)
                        cn3.Open()
                        Dim cmd3 As New SqlCommand


                        cmd3 = New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation from  MMCHRosAndGen where category= 'Assessment' AND QID IN(" & strQID.TrimEnd(",") & ")ORDER BY ScreenLocation ", cn3)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd3
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn3.Close()

                        Me.DataGridViewPr.Columns(0).Visible = False
                        Me.DataGridViewPr.Columns(1).Visible = True
                        Me.DataGridViewPr.Columns(2).Width = 347
                        Me.DataGridViewPr.Columns(3).Visible = False

                    Else
                        DataGridViewPr.DataSource = Nothing
                        Exit Function
                    End If

                End If
            Else
                DataGridViewPr.DataSource = Nothing
                Exit Function
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Function LoadMyList()
        If radMyDx.Checked = True Then
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand

            Try
                If RadioButtonDx.Checked Then
                    cmd = New SqlCommand("SELECT MMDX.Code1 AS Code, MMDX.Description FROM  MMDX LEFT JOIN  PhysicianProfile ON MMDX.Code1 = PhysicianProfile.Code WHERE  physiciancode = '" & AssignedProviderTextBox.Text & "' ORDER BY MMDX.Description", cn)
                ElseIf RadioButtonPr.Checked Then
                    cmd = New SqlCommand("SELECT Code1 As Code, MMPRocedure.Description, AmountA, MyProcedures, ScreenLocation, MMPRocedure.Type, InHouse, InHouseBilling  FROM   MMPRocedure LEFT JOIN PhysicianProfile ON MMPRocedure.Code1 = PhysicianProfile.Code where  physiciancode = '" & AssignedProviderTextBox.Text & "' order by Description", cn)
                ElseIf RadioButtonLT.Checked Then
                    cmd = New SqlCommand("SELECT TestNo, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestLab  order by Description", cn)
                ElseIf RadioButtonMT.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMCHARTTESTMEDICAL  order by Description", cn)
                ElseIf RadioButtonTestImaging.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestImaging  order by Description", cn)
                Else
                    Exit Function
                End If

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

                Me.DataGridViewPr.Columns(0).Width = 70
                Me.DataGridViewPr.Columns(1).Width = 347

            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Function

    Private Sub btnSuperBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuperBill.Click
        RVforSuperBill.ShowVisit(txtCopyChartNumber.Text, txtCopyDate.Text, txtCopyCaseNumber.Text)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim procID As Integer
        procID = Shell("C:\Program Files\Microsoft Office\Office12\OneNote.exe", AppWinStyle.NormalNoFocus)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim myConnection As SqlConnection
        'Dim myCommand As SqlCommand
        'Dim ra As Integer


        'myConnection = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=MMData;User ID=sa;Password=Abdullah^")
        ''you need to provide password for sql server
        'myConnection.Open()
        '' myCommand = New SqlCommand("drop table #TestsPreformed SELECT MMCHDxRxLtMt.Code, MAX(MMCHDxRxLtMt.Date) AS Date into #TestsPreformed FROM         MMCHDxRxLtMt INNER JOIN MMChartEvaluation ON MMCHDxRxLtMt.Code = MMChartEvaluation.Code WHERE     (MMCHDxRxLtMt.ChartNumber = N'PATTE000') GROUP BY MMCHDxRxLtMt.Code", myConnection)
        'myCommand = New SqlCommand("drop table #TestsPreformed", myConnection)

        'ra = myCommand.ExecuteNonQuery()
        'MessageBox.Show("Records affected" & ra)
        'myConnection.Close()




        'Dim connString As String = connString2
        'Dim cn As New SqlConnection(connString)
        'cn.Open()
        'Dim cmd As New SqlCommand


        'cmd = New SqlCommand("IF OBJECT_ID('#TestsPreformed','U') IS NOT NULL DROP TABLE #TestsPreformed", cn)

        'cmd.ExecuteNonQuery()

        'cn.Close()





        'Dim db As DBAccess = New DBAccess()
        'Dim localdr As SqlClient.SqlDataReader

        'lstHealthMonitor.Items.Clear()
        'localdr = db.ExecuteReader("IF OBJECT_ID('#TestsPreformed','U') IS NOT NULL drop table #TestsPreformed IF OBJECT_ID('#TestMeetCriteria','U') IS NOT NULL DROP TABLE #TestMeetCriteria  SELECT MMCHDxRxLtMt.Code, MAX(MMCHDxRxLtMt.Date) AS Date into #TestsPreformed FROM         MMCHDxRxLtMt INNER JOIN MMChartEvaluation ON MMCHDxRxLtMt.Code = MMChartEvaluation.Code WHERE     (MMCHDxRxLtMt.ChartNumber = N'" & txtCopyChartNumber.Text & "') GROUP BY MMCHDxRxLtMt.Code   SELECT     ID, Code, Description, CodeType, FrequencyInWks, AgeFrom, AgeTo, Race, Sex, PrDx, FmHx, SHx, PmHx, QWhere, Extra1, Extra2, Extra3, UserName, TimeStamp into #TestMeetCriteria FROM MMChartEvaluation WHERE (AgeFrom BETWEEN 20 AND 150)and Sex='" & fRet(7).ToString & "'   SELECT     tp.Code, tp.Date, DATEDIFF(ww, tp.Date, GETDATE()) AS WeeksSince, tc.Description, tc.FrequencyInWks, tc.Sex, tc.AgeFrom AS AgeFromEval FROM #TestsPreformed AS tp INNER JOIN #TestMeetCriteria AS tc ON tp.Code = tc.Code AND DATEDIFF(ww, tp.Date, GETDATE()) > tc.FrequencyInWks GROUP BY DATEDIFF(ww, tp.Date, GETDATE()), tc.FrequencyInWks, tp.Date, tc.Sex, tp.Code, tc.Code, tc.AgeFrom, tc.Description ")

        'If localdr.HasRows = True Then
        '    While localdr.Read
        '        Dim strWeeksOverdue As String = localdr.Item("WeeksSince").ToString - localdr.Item("FrequencyInWks").ToString
        '        lstHealthMonitor.Items.Add(localdr.Item("Code") & "   " & localdr.Item("Description") & "   " & strWeeksOverdue & " weeks overdue")
        '    End While
        'End If
        'localdr.Close()




    End Sub

    Private Function LoadHealthMonitor()
        Dim db As DBAccess = New DBAccess()
        Dim localdr As SqlClient.SqlDataReader
        Dim dt As New DataTable()

        dt.Columns.Add("Code")
        dt.Columns.Add("Description")
        dt.Columns.Add("Test Date")
        dt.Columns.Add("Wks Over")
        'Me.dgvHealthMonitor.Columns("Test Date").DefaultCellStyle.Format = "d"

        Try
            lstHealthMonitor.Items.Clear()
            'Dim a As String = "IF OBJECT_ID('#TestsPreformed','U') IS NOT NULL drop table #TestsPreformed IF OBJECT_ID('#TestMeetCriteria','U') IS NOT NULL DROP TABLE #TestMeetCriteria  SELECT MMCHDxRxLtMt.Code, MAX(MMCHDxRxLtMt.Date) AS Date into #TestsPreformed FROM         MMCHDxRxLtMt INNER JOIN MMChartEvaluation ON MMCHDxRxLtMt.Code = MMChartEvaluation.Code WHERE     (MMCHDxRxLtMt.ChartNumber = N'" & txtCopyChartNumber.Text & "') GROUP BY MMCHDxRxLtMt.Code   SELECT     ID, Code, Description, CodeType, FrequencyInWks, AgeFrom, AgeTo, Race, Sex, PrDx, FmHx, SHx, PmHx, QWhere, Extra1, Extra2, Extra3, UserName, TimeStamp into #TestMeetCriteria FROM MMChartEvaluation WHERE " & txtAge.Text & " > AgeFrom And " & txtAge.Text & " < Ageto and Sex='" & fRet(7).ToString & "'   SELECT     tp.Code, tp.Date, DATEDIFF(ww, tp.Date, GETDATE()) AS WeeksSince, tc.Description, tc.FrequencyInWks, tc.Sex, tc.AgeFrom AS AgeFromEval FROM #TestsPreformed AS tp INNER JOIN #TestMeetCriteria AS tc ON tp.Code = tc.Code AND DATEDIFF(ww, tp.Date, GETDATE()) > tc.FrequencyInWks GROUP BY DATEDIFF(ww, tp.Date, GETDATE()), tc.FrequencyInWks, tp.Date, tc.Sex, tp.Code, tc.Code, tc.AgeFrom, tc.Description "
            localdr = db.ExecuteReader("IF OBJECT_ID('#TestsPreformed','U') IS NOT NULL drop table #TestsPreformed IF OBJECT_ID('#TestMeetCriteria','U') IS NOT NULL DROP TABLE #TestMeetCriteria  SELECT MMCHDxRxLtMt.Code, MAX(MMCHDxRxLtMt.Date) AS Date into #TestsPreformed FROM         MMCHDxRxLtMt INNER JOIN MMChartEvaluation ON MMCHDxRxLtMt.Code = MMChartEvaluation.Code WHERE     (MMCHDxRxLtMt.ChartNumber = N'" & txtCopyChartNumber.Text & "') GROUP BY MMCHDxRxLtMt.Code   SELECT     ID, Code, Description, CodeType, FrequencyInWks, AgeFrom, AgeTo, Race, Sex, PrDx, FmHx, SHx, PmHx, QWhere, Extra1, Extra2, Extra3, UserName, TimeStamp into #TestMeetCriteria FROM MMChartEvaluation WHERE " & txtAge.Text & " > AgeFrom And " & txtAge.Text & " < Ageto and Sex='" & fRet(7).ToString & "'   SELECT     tp.Code, tp.Date, DATEDIFF(ww, tp.Date, GETDATE()) AS WeeksSince, tc.Description, tc.FrequencyInWks, tc.Sex, tc.AgeFrom AS AgeFromEval FROM #TestsPreformed AS tp INNER JOIN #TestMeetCriteria AS tc ON tp.Code = tc.Code AND DATEDIFF(ww, tp.Date, GETDATE()) > tc.FrequencyInWks GROUP BY DATEDIFF(ww, tp.Date, GETDATE()), tc.FrequencyInWks, tp.Date, tc.Sex, tp.Code, tc.Code, tc.AgeFrom, tc.Description ")


            'Dim dt As New DataTable
            'dt.Load(localdr)
            'dgvHealthMonitor.DataSource = dt



            If localdr.HasRows = True Then
                While localdr.Read
                    Dim strWeeksOverdue As String = localdr.Item("WeeksSince").ToString - localdr.Item("FrequencyInWks").ToString
                    Dim row As DataRow = dt.NewRow()

                    row("Code") = localdr.Item("Code")
                    row("Description") = localdr.Item("Description")
                    row("Test Date") = localdr.Item("Date")
                    row("Wks Over") = strWeeksOverdue
                    dt.Rows.Add(row)
                    dgvHealthMonitor.DataSource = dt


                    '    Dim strWeeksOverdue As String = localdr.Item("WeeksSince").ToString - localdr.Item("FrequencyInWks").ToString
                    '    lstHealthMonitor.Items.Add(localdr.Item("Code") & "   " & localdr.Item("Description") & "   " & strWeeksOverdue & " weeks overdue" & "   " & localdr.Item("Date"))
                End While
            End If
            dgvHealthMonitor.Columns("code").Width = 75
            dgvHealthMonitor.Columns("Description").Width = 150
            dgvHealthMonitor.Columns("Test Date").Width = 80
            dgvHealthMonitor.Columns("Wks Over").Width = 75




            localdr.Close()
        Catch
        End Try
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        PEcount.Visible = True
        RosCount.Visible = True
        PEBulletsCount.Visible = True
        ROSBulletsCount.Visible = True

    End Sub

    Private Sub btnImpressions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpressions.Click
        Try
            RadioButtonDx.Checked = False
            radProcedureNotes.Checked = False
            radImpressions.Checked = True

            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()

            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'Assessment' ORDER BY ScreenLocation ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()

            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False

            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ColorCustomMylistAllButtons()
        If radAll.Checked Then
            radTemplateDX.BackColor = Color.Transparent
            radMyDx.BackColor = Color.Transparent
            radAll.BackColor = Color.FromArgb(148, 183, 233)
        ElseIf radMyDx.Checked Then
            radTemplateDX.BackColor = Color.Transparent
            radMyDx.BackColor = Color.FromArgb(148, 183, 233)
            radAll.BackColor = Color.Transparent
        ElseIf radTemplateDX.Checked Then
            radTemplateDX.BackColor = Color.FromArgb(148, 183, 233)
            radMyDx.BackColor = Color.Transparent
            radAll.BackColor = Color.Transparent
        End If
    End Function

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        RV.ShowVisit(txtCopyChartNumber.Text, txtCopyDate.Text, txtCopyCaseNumber.Text, "active")
    End Sub

    
   
    Private Sub btnPickupCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickupCC.Click
        Try
           
            RadioButtonDx.Checked = False
            radProcedureNotes.Checked = False
            radPlan.Checked = False
            RadioButtonCC.Checked = True

            TabControl3.SelectedTab = DxPrTestsPickTab
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT ChiefComplaint, Category from  MMChartCC  ORDER BY CategorySortOrder, ItemSortOrder ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()
            

         
            Me.DataGridViewPr.Columns(0).Width = 250


            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

   
    
    Private Sub btnCopyToNewVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyToNewVisit.Click
        Try
            MessageBox.Show("Select items from this visit will be added to a new visit.", "", MessageBoxButtons.OK)
            Me.SpCopyVisitTableAdapter.Fill(Me.MMDataDataSet1.spCopyVisit, New System.Nullable(Of Integer)(CType(txtCopyCaseNumber.Text, Integer)), globalUser)
            'Me.MMChartVisitBindingSource.MoveLast()
            Me.MMChartVisitTableAdapter.FillByCh(Me.MMDataDataSet1.MMChartVisit, HChartNumber)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

   
    Private Sub btnDeleteVisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteVisit.Click
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Dim connString As String
        Dim cn As SqlConnection


        Try
            sAction = "DeleteVisitAuthorization"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User not authorized to delete visits.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If MessageBox.Show("Are you sure you want to delete this visit? " & Environment.NewLine & Environment.NewLine & "Case #: " & txtCopyCaseNumber.Text & Environment.NewLine & "Chart #: " & txtCopyChartNumber.Text & Environment.NewLine & "Name: " & txtCopyFirstName.Text & " " & txtCopyLastName.Text & Environment.NewLine & "Date: " & txtCopyDate.Text & Environment.NewLine & Environment.NewLine & "Deleting visits may cause undesired consequenses." & Environment.NewLine & "If Procedures, Tests, Medications and Vital Signs were added to this visit, they will need to be deleted manually.", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Sub
            End If

            connString = connString2
            cn = New SqlConnection(connString)
            cn.Open()

            Dim cmd As New SqlCommand("Delete from MMChartVisit where CaseNumber = '" & txtCopyCaseNumber.Text & "'", cn)

            cmd.ExecuteNonQuery()

            cn.Close()
            Me.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function ApplyColorToNormalsGrid()
        Dim i As Integer
        Dim ii As Integer

        For i = 0 To MMCHRosAndGenDataGridView.RowCount - 1

            If IsDBNull(MMCHRosAndGenDataGridView.Rows(i).Cells("ROSCategory").Value) <> True Then
                If MMCHRosAndGenDataGridView.Rows(i).Cells("ROSCategory").Value = "ROS-Normals" Then
                Else
                    MMCHRosAndGenDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.DarkSeaGreen
                End If
            End If
        Next

        For i = 0 To DataGridView1.RowCount - 1

            If IsDBNull(DataGridView1.Rows(i).Cells("Category").Value) <> True Then
                If DataGridView1.Rows(i).Cells("Category").Value = "PE-(Normals)" Then
                Else
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.DarkSeaGreen
                End If
            End If
        Next

    End Function

 
    Private Sub btnPickupChronic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickupChronic.Click
        Try

            RadioButtonDx.Checked = False
            radProcedureNotes.Checked = False
            radPlan.Checked = False
            RadioButtonCC.Checked = False
            radChronic.Checked = True

            TabControl3.SelectedTab = DxPrTestsPickTab
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT ChiefComplaint, Category from  MMChartCC  ORDER BY CategorySortOrder, ItemSortOrder ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()



            Me.DataGridViewPr.Columns(0).Width = 250


            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnQuickHPI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuickHPI.Click
        tvwDB.Visible = True
        TabControl3.SelectedIndex = 0
        TabControl1.SelectedIndex = 1

        Try
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            Dim connString3 As String = connString2
            Dim cn2 As New SqlConnection(connString3)

            cn.Open()
            cn2.Open()
            Dim cmd As New SqlCommand("SELECT HPI.ID, HPI.CC, HPI.Category, HPI.SubCategory, HPI.Description FROM HPI where CC=" & "'" & "GENERAL HPI" & "' order by sortorder", cn)
            Dim cmd2 As New SqlCommand("SELECT   distinct  MMCHROSandGenCat.Category,MMCHROSandGenCat.SortOrder  FROM  HPI INNER JOIN  MMCHROSandGenCat ON HPI.Category = MMCHROSandGenCat.Category where HPI.CC=" & "'" & "GENERAL HPI" & "' ORDER BY MMCHROSandGenCat.SortOrder", cn2)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim dr2 As SqlDataReader = cmd2.ExecuteReader()

            Dim mNode As TreeNode
            tvwDB.Nodes.Clear()
            Dim i As Integer

            While dr2.Read
                mNode = tvwDB.Nodes.Add(dr2.Item(0).ToString, dr2.Item(0).ToString)
            End While
            dr2.Close()
            Do While dr.Read
                If tvwDB.Nodes.ContainsKey(dr("Category")) = True Then
                Else
                    tvwDB.Nodes.Add(dr("Category"), dr("Category"))
                End If
                tvwDB.Nodes(dr("Category")).Nodes.Add(dr("Description"))
            Loop
            dr.Close()
            cn.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click
        RecurseNodes(tvwDB.Nodes)
        tvwDB.Visible = False
        txtHPI.SelectionStart = txtHPI.TextLength
        txtHPI.ScrollToCaret()
    End Sub

    Private Function RecurseNodes(ByVal col As TreeNodeCollection)
        For Each node As TreeNode In col
            If node.Checked = True Then
                Try
                    Select Case node.Parent.ToString
                        Case "TreeNode: Chief Complaint"
                            If ChiefComplaintTextBox.Text = "" Then
                                ChiefComplaintTextBox.Text = node.Text
                            Else
                                ChiefComplaintTextBox.Text = ChiefComplaintTextBox.Text + ", " + node.Text
                            End If

                        Case Else
                            If txtHPI.Text = "" Then
                                txtHPI.Text = node.Parent.Text & "- " & node.Text
                            Else
                                txtHPI.Text = txtHPI.Text + Environment.NewLine + node.Parent.Text & "- " & node.Text
                            End If
                    End Select
                Catch
                End Try
            End If
            RecurseNodes(node.Nodes)
        Next node
    End Function

   
    Private Sub MMCHDxRxLtMtDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MMCHDxRxLtMtDataGridView.CellContentClick

    End Sub
End Class
'Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Try
'        RosGeneral.Show()
'        'aRet = RosGeneral.ShowPicklist
'        'If aRet(0) = "Y" Then

'        '    ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text + " " + aRet(1)

'        'End If
'    Catch
'    End Try
'End Sub

'Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    ' PhysicalExamination.Show()
'    Try
'        aRet = PhysicalExamination.ShowPicklist
'        If aRet(0) = "Y" Then
'            PhysicalExamTextBox.Text = PhysicalExamTextBox.Text + " " + aRet(1)
'        End If
'    Catch ex As System.Exception
'        System.Windows.Forms.MessageBox.Show(ex.Message)
'    End Try

'End Sub
'OtherTx Panel
'Dim codes As String
'        codes = codesTextbox.Text
'        If codesTextbox.Text = "" Then
'            codesTextbox.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value.ToString()
'        Else
'            codesTextbox.Text = codes + "," + DataGridViewPr.SelectedRows(0).Cells(0).Value.ToString
'        End If

'    End Sub

  

'Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

'    If cmbFilter.Text <> "" Then
'        Me.MmpatientBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
'    End If
'    Me.MmpatientBindingSource.Sort = "ChartNumber"
'    dgPatient.DataSource = Me.MMPATIENTBindingSource
'    GradientCaption2.Text = "Patient Information"


'End Sub







'  Try
'            Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
'            Me.CCProfilesTableAdapter.Fill(Me.DprofilesDataSet.CCProfiles)
''LoadComboBoxes2()
'            Me.MMChartVisitTableAdapter.FillByCh(Me.MMDataDataSet1.MMChartVisit, HChartNumber)
'Dim D As String = Me.MMDataDataSet1.MMChartVisit.Rows(0)("Date").ToString()

'            Me.MMCHROSandGenCatTableAdapter.Fill(Me.MMDataDataSet1.MMCHROSandGenCat)
''Me.MMCHRosAndGenTableAdapter.Fill(Me.MMDataDataSet1.MMCHRosAndGen)

'' Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(HChartNumber), D) 'DateMaskedTextBox.Text
'' Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CType(txtCopyCaseNumber.Text, Integer))
'            Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CType(Me.MMDataDataSet1.MMChartVisit.Rows(0)("CaseNumber").ToString(), Integer))


''Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(HChartNumber), D)
''Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CType(txtCopyCaseNumber.Text, Integer))
'            Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, CType(Me.MMDataDataSet1.MMChartVisit.Rows(0)("CaseNumber").ToString(), Integer))

'' Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, HChartNumber, D)
'' Me.MMChartTVitalSignTableAdapter.FillByChNo(Me.MMDataDataSet1.MMChartTVitalSign, txtCopyChartNumber.Text)
'            TabControl3.SelectedIndex = 2
'            TabControl1.SelectedIndex = 0
'' LoadPreviousMedications()

''Me.DataGridViewPr.Columns(0).Width = 70
''Me.DataGridViewPr.Columns(1).Width = 347
'        Catch ex As System.Exception     For ii = 0 To CheckedListBox1.CheckedItems.Count - 1

'if itemstoadd <> 
'               itemsToAdd = itemsToAdd + CheckedListBox1.CheckedItems(ii).ToString()


'       Next









'         For i = 0 To MMCHRosAndGenDataGridView1.RowCount - 1
'                If MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString.Length > 3 Then
'                    If MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString.Substring(0, 3) = "ROS" Then
'                        If MMCHRosAndGenDataGridView1.Rows(i).Cells(3).Value = True Or MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
'                            If sCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value Then

'                                sb.Append(Environment.NewLine)
'                                sCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value
'                                sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value & Environment.NewLine)
'                                sb.Append("   ")

'                                If sSubCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & "" Then
'                                    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ": ")
'                                    sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
'                                Else
'                                    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ", ")
'                                End If


'                                If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
'                                    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(+)")
'                                Else
'                                    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(-)")
'                                End If
'                            Else
'                                If sSubCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & "" Then
'                                    sb.Append(Environment.NewLine)
'                                    sb.Append("   ")
'                                    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ": ")

'                                    If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
'                                        sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(+)")
'                                    Else
'                                        sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(-)")
'                                    End If

'                                    sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
'                                Else
'                                    sb.Append(",  ")
'                                    If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
'                                        sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(+)")

'                                    Else
'                                        sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(-)")

'                                    End If
'                                End If

''sb.Append(",  ")
''If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
''    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(+)")
''Else
''    sb.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(-)")
''End If
'                            End If



''sCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value
''sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
' ''  sDescription = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & ""

''sb.Append(sCategory & Environment.NewLine)
''sb.Append(sSubCategory)
'                        End If
'                    End If
'                End If

'                If MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString.Length > 3 Then
'                    If MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value.ToString.Substring(0, 3) = "PE-" Then
'                        If MMCHRosAndGenDataGridView1.Rows(i).Cells(3).Value = True Or MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
'                            If sCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value Then
'                                sbPE.Append(Environment.NewLine)
'                                sCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value
'                                sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value & Environment.NewLine)
'                                sbPE.Append("   ")

'                                If sSubCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & "" Then
'                                    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ": ")
'                                    sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
'                                Else
'                                    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ", ")
'                                End If


'                                If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
'                                    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(+)")
'                                Else
'                                    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(-)")
'                                End If
'                            Else
'                                If sSubCategory <> MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & "" Then
'                                    sbPE.Append(Environment.NewLine)
'                                    sbPE.Append("   ")
'                                    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ": ")

'                                    If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
'                                        sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(+)")
'                                    Else
'                                        sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(-)")
'                                    End If

'                                    sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
'                                Else
'                                    sbPE.Append(",  ")
'                                    If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
'                                        sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(+)")
'                                    Else
'                                        sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(-)")
'                                    End If
'                                End If

''sbPE.Append(",  ")
''If MMCHRosAndGenDataGridView1.Rows(i).Cells(4).Value = True Then
''    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(+)")
''Else
''    sbPE.Append(MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & "(-)")
''End If
'                            End If



''sCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(0).Value
''sSubCategory = MMCHRosAndGenDataGridView1.Rows(i).Cells(1).Value & ""
' ''  sDescription = MMCHRosAndGenDataGridView1.Rows(i).Cells(2).Value & ""

''sbPE.Append(sCategory & Environment.NewLine)
''sbPE.Append(sSubCategory)
'                        End If
'                    End If
'                End If


'            Next