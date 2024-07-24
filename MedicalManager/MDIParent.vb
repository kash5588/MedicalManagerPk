
Imports System
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Management


Public Class MDIParent
      Dim objCurrentPat As New CurrentPat
    Public aRet(10) As String
    Dim arrayAssignedProvider(0) As String
    Dim myBindingSource As New BindingSource()


    Private Sub MDIParent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Try
        On Error Resume Next
        LoginForm.ShowDialog()
        Me.ACalendardayTableAdapter.Fill(Me.MMDataDataSet1.ACalendarday)
        Dim x As Object
        x = "12/30/2024"
        If CDate(x) < Today() Then
            End
        End If


        'If "001125EC75C8" Or "00238BF42E58" Or "E06995DA930C" <> GetMACAddress() Then  ' shareens server
        '    '    If "000874392655" <> GetMACAddress() Then   ' shareens personal computer
        '    ' "001125EC75C8" 
        '    ' "000FB06F0251" 
        '    '"0026B96766C2"
        '    '0026B96766C2  DR KHOLI
        '    End
        'End If

        'Me.MmpatientTableAdapter.Fill(Me.MMDataDataSet1.MMPATIENT)
        LoadDgpatientgrid()
        ApplyColorToPatientGrid()
        ' GradientNavigationButton4.Enabled = True
        cmbFilter.SelectedIndex = 0
        TabControl1.SelectedIndex = 0
        TabControl1.SelectedIndex = 3
        TabControl1.SelectedIndex = 0
        Me.ReportViewer1.RefreshReport()
        MultiAppointmentTableAdapter.Fill(Me.MMDataDataSet1.MultiAppointment, New System.Nullable(Of Date)(CType(MonthCalendar1.SelectionRange.Start.Date, Date)))
        ApplyColorToGrid()
        LoadUser()
        Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
        LoadComboBoxes2()

        '  Timer1.Interval = 5000
        '    Timer1.Start()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Dim newThread As Threading.Thread
        'newThread = New Threading.Thread(AddressOf DoWork)
        'newThread.Start()

        '  Dim i As Integer = dgPatient.CurrentCell.RowIndex
        Dim ii As Integer = MultiAppointmentDataGridView.CurrentCell.RowIndex

        LoadAppointments()
        ' LoadDgpatientgrid()





        'If cmbFilter.Text <> "" Then
        '    If cmbFilter.Text = "SocialSecurityNumber" Then
        '        If cmbFilter.Text.Length > 2 Then
        '            Me.myBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
        '        End If
        '    Else
        '        Me.myBindingSource.Filter = "[" & cmbFilter.Text & "]" & " like " & "'" & txtFind.Text & "%'"
        '    End If
        'End If
        'Me.myBindingSource.Sort = "ChartNumber"
        'dgPatient.DataSource = Me.myBindingSource

        'dgPatient.CurrentCell = dgPatient.Rows(i).Cells(0)
        MultiAppointmentDataGridView.CurrentCell = MultiAppointmentDataGridView.Rows(ii).Cells(0)

    End Sub

    Private Function LoadDgpatientgrid()
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        Dim cmd As New SqlCommand

        Try
            cn.Open()
            cmd = New SqlCommand("SELECT [PatientID],[ChartNumber],[LastName],[FirstName],[HomeePhone],[CellPhone],[CNICNO] as CNIC,[Sex],[DateofBirth],[RelToSub],[PhysicianOffice],[AssignedProvider] FROM [MMPATIENT]", cn)

            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMDX")

            myBindingSource = New BindingSource()
            myBindingSource.DataSource = ds
            myBindingSource.DataMember = ds.Tables(0).TableName
            dgPatient.DataSource = myBindingSource
            dgPatient.Sort(dgPatient.Columns("PatientID"), System.ComponentModel.ListSortDirection.Descending)

            ds.Dispose()
            cn.Close()
            'dgPatient.Columns("PatientID").Width = 60
            'dgPatient.Columns("ChartNumber").Width = 75
            'dgPatient.Columns("LastName").Width = 120
            'dgPatient.Columns("FirstName").Width = 120

            'dgPatient.Columns("DateOfBirth").Width = 68
            'dgPatient.Columns("HomeePhone").Width = 85
            'dgPatient.Columns("SEX").Width = 65
            'dgPatient.Columns("CellPhone").Width = 85
            'dgPatient.Columns("CNIC").Width = 120
            'dgPatient.Columns("AssignedProvider").Width = 65
            '' dgPatient.Columns("InsCoID").Width = 60
            ''dgPatient.Columns("InsCoID2").Width = 60
            '' dgPatient.Columns("DateCreated").Width = 65
            '' dgPatient.Columns("EmploymentStatus").Width = 50
            'dgPatient.Columns("RelToSub").Width = 55

            ''  dgPatient.Columns("PhysicianOffice").Width = 60

            ''dgPatient.Columns("EmploymentStatus").Width = 60
            'dgPatient.Columns("PhysicianOffice").Width = 80
            'dgPatient.Columns("AssignedProvider").Width = 80
            'dgPatient.Columns("LastName").DefaultCellStyle.BackColor = Color.FromArgb(230, 234, 252)
            'dgPatient.Columns("FirstName").DefaultCellStyle.BackColor = Color.FromArgb(230, 234, 252)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function




    Private Sub GradientNavigationRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationRefresh.Click
        ' Me.MmpatientTableAdapter.Fill(Me.MMDataDataSet1.MMPATIENT)
        LoadDgpatientgrid()
        ApplyColorToPatientGrid()
    End Sub

    Private Sub GradientCaption2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientCaption2.Click
        Try

            Me.MmpatientTableAdapter.Fill(Me.MMDataDataSet1.MMPATIENT)
            cmbFilter.SelectedIndex = 0
            TabControl1.SelectedIndex = 0
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer2.RefreshReport()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        ' Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub PatientToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientToolStripMenuItem1.Click
        
        PATIENT.Show()
      
    End Sub

    'Private Sub ChartToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartToolStripMenuItem1.Click
    '    Chart.Show()
    'End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PATIENT.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Chart.Show()
    End Sub

    Private Sub AppointmentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentsToolStripMenuItem.Click

        'Dim procID As Integer
        '' Run calculator.
        'procID = Shell("C:\Program Files\Microsoft Office\Office\outlook.exe", AppWinStyle.MinimizedNoFocus)
        '' The preceding path is for Windows XP.
        '' The Windows 2000 path is C:\WINNT\system32\calc.exe.
    End Sub

    Private Sub txtFind_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFind.GotFocus
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        Try
            If cmbFilter.Text <> "" Then
                If cmbFilter.Text = "SocialSecurityNumber" Then
                    If cmbFilter.Text.Length > 2 Then
                        Me.myBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
                    End If
                Else
                    Me.myBindingSource.Filter = "[" & cmbFilter.Text & "]" & " like " & "'" & txtFind.Text & "%'"
                End If
            End If
            Me.myBindingSource.Sort = "ChartNumber"
            dgPatient.DataSource = Me.myBindingSource
            GradientCaption2.Text = "Patient Information"
            ApplyColorToPatientGrid()
        Catch
        End Try

    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Dim procID As Integer
        ' Run calculator.
        procID = Shell("C:\Windows\system32\calc.exe", AppWinStyle.NormalNoFocus)
        ' The preceding path is for Windows XP.
        ' The Windows 2000 path is C:\WINNT\system32\calc.exe.
    End Sub


    Private Sub GradientAnimation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientAnimation1.Click
        Dim procID As Integer
    End Sub

    Private Sub VisitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PrescriptionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrescriptionToolStripMenuItem.Click
        Prescription.Show()
    End Sub

    Private Sub ROSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Ros.Show()
    End Sub

    Private Sub LinkLabel13_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        'Ros.Show()
    End Sub

    Private Sub HL7ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HL7ToolStripMenuItem1.Click
        HL7.Show()
    End Sub

    Private Sub LabCorpInterFaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabCorpInterFaceToolStripMenuItem.Click
        LabCorpInterFace.Show()
    End Sub

    Private Sub LabReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabReportToolStripMenuItem.Click
        LabReports.Show()
    End Sub

    Private Sub ProceduresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Procedure.Show()
    End Sub

    Private Sub PhysionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhysionsToolStripMenuItem.Click
        Physician.Show()
    End Sub

    Private Sub RefringPhysionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefringPhysionsToolStripMenuItem.Click
        ReferringPhysician.Show()
    End Sub

    Private Sub PracticeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PracticeToolStripMenuItem.Click
        Practice.Show()
    End Sub

    Private Sub ImagingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagingToolStripMenuItem.Click
        Imaging.Show()
    End Sub

    Private Sub MedicalTestsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedicalTestsToolStripMenuItem.Click
        MedicalTests.Show()
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub AddEditAppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEditAppointmentToolStripMenuItem.Click
        AppointmentsTab.Show()
    End Sub

    Private Sub AppointmentInOutlookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentInOutlookToolStripMenuItem.Click
        Dim procID As Integer
        procID = Shell("C:\Program Files\Microsoft Office\Office12\outlook.exe", AppWinStyle.MinimizedNoFocus)
    End Sub

    Private Sub GradientNavigationButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton2.Click

        Try
            Appointments.Show()

            'MultiAppointmentTableAdapter.Fill(Me.MMDataDataSet1.MultiAppointment, New System.Nullable(Of Date)(CType(MonthCalendar1.SelectionRange.Start.Date, Date)))
            'Me.OAPpointmentsTableAdapter.FillByDate(Me.MMDataDataSet1.OAPpointments, New System.Nullable(Of Date)(CType(MonthCalendar1.SelectionRange.Start.Date, Date))) '_DateToolStripTextBox.Text
            'Me.ACalendardayTableAdapter.Fill(Me.MMDataDataSet1.ACalendarday)

            'Dim i As Integer
            'For i = 0 To Me.MMDataDataSet1.OAPpointments.Rows.Count - 1
            '    Dim row As DataRow = Me.MMDataDataSet1.Tables("ACalendarday").Rows.Find(Me.MMDataDataSet1.OAPpointments.Rows(i)(2).ToString)
            '    If row Is Nothing Then
            '        MsgBox("row not found")
            '    Else
            '        row("ChartNumber") = Me.MMDataDataSet1.OAPpointments.Rows(i)("ChartNumber").ToString
            '        row("Phone") = Me.MMDataDataSet1.OAPpointments.Rows(i)("Phone").ToString
            '        row("Name") = Me.MMDataDataSet1.OAPpointments.Rows(i)("Name").ToString
            '        row("Note") = Me.MMDataDataSet1.OAPpointments.Rows(i)("Note").ToString
            '        row("Provider") = Me.MMDataDataSet1.OAPpointments.Rows(i)("Provider").ToString
            '        'row("Resource") = Me.MMDataDataSet1.OAPpointments.Rows(i)("Resource").ToString
            '        row("AppId") = Me.MMDataDataSet1.OAPpointments.Rows(i)("Id").ToString
            '        row("Duration") = Me.MMDataDataSet1.OAPpointments.Rows(i)("Duration").ToString
            '        row("Date") = Me.MMDataDataSet1.OAPpointments.Rows(i)("Date").ToString
            '        row("CellPhone") = Me.MMDataDataSet1.OAPpointments.Rows(i)("CellPhone").ToString
            '        row("refphysician") = Me.MMDataDataSet1.OAPpointments.Rows(i)("refphysician").ToString
            '    End If
            'Next
            'TabControl1.SelectedIndex = 3
            'Me.ReportViewer1.RefreshReport()
            'Me.ReportViewer2.RefreshReport()
            'ApplyColorToGrid()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GradientNavigationButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GradientCaption2.Text = "Patient Information" Then

            If dgPatient.SelectedRows.Count Then

                Chart.ShowChartContents(aRet)
            End If

        Else
            If dgPatient.SelectedRows.Count Then

                Chart.ShowChartContents(Me.dgPatient.SelectedRows(0).Cells("ChartNumber").Value)
            End If

        End If
    End Sub

    Private Sub GradientNavigationButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton13.Click

        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Try
            sAction = "PatientEdting"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)
            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User not authorized to edit patients.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If GradientCaption2.Text = "Patient Information" Then
                If dgPatient.SelectedRows.Count Then
                    PATIENT.ShowPatient(Me.dgPatient.SelectedRows(0).Cells("ChartNumber").Value)
                End If
            Else
                If dgPatient.SelectedRows.Count Then
                    PATIENT.ShowPatient(Me.dgPatient.SelectedRows(0).Cells("ChartNumber").Value)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GradientNavigationButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton6.Click
        If GradientCaption2.Text = "Patient Information" Then
            If dgPatient.SelectedRows.Count Then
                Prescription.ShowPrescriptions(aRet)
            End If
        Else
            MsgBox("Select patient")
            Exit Sub
        End If
    End Sub

    Private Sub GradientNavigationButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton1.Click
        If GradientCaption2.Text = "Patient Information" Then
            If dgPatient.SelectedRows.Count Then
                Messaging.ShowMessages(aRet)
            End If
        End If
    End Sub

    Public ReadOnly Property AssessIDColumn() As String
        Get
            Return objCurrentPat.ChartNumber
        End Get
    End Property

    Private Sub dgPatient_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPatient.SelectionChanged

        Try
            If dgPatient.SelectedRows.Count Then
                ' aRet = CurrentPatient()
                ' MsgBox(aRet(1))
                'Dim row As MMDataDataSet1.MMPATIENTRow
                'row = CType(CType(Me.MmpatientBindingSource.Current, DataRowView).Row, MMDataDataSet1.MMPATIENTRow)

                'Dim objCurrentPat As New CurrentPat
                'objCurrentPat.ChartNumber = row.ChartNumber
                aRet(0) = "Y"
                aRet(1) = dgPatient.SelectedRows(0).Cells("ChartNumber").Value & "" 'chartnumber
                aRet(2) = dgPatient.SelectedRows(0).Cells("LastName").Value & ""  'last name
                aRet(3) = dgPatient.SelectedRows(0).Cells("FirstName").Value & ""   'first name
                aRet(4) = dgPatient.SelectedRows(0).Cells("MiddleInitial").Value & ""    'middle initial
                aRet(5) = dgPatient.SelectedRows(0).Cells("HomeePhone").Value & ""    'phone
                aRet(6) = dgPatient.SelectedRows(0).Cells("DateofBirth").Value & ""     'DOB
                aRet(7) = dgPatient.SelectedRows(0).Cells("Sex").Value & ""     'Sex
                arrayAssignedProvider(0) = dgPatient.SelectedRows(0).Cells("AssignedProvider").Value & ""
                GetLastVisitDate()

                ChartNo.Text = Me.dgPatient.SelectedRows(0).Cells("ChartNumber").Value
                txtName.Text = Me.dgPatient.SelectedRows(0).Cells("LastName").Value & " " & Me.dgPatient.SelectedRows(0).Cells("FirstName").Value & " " & Me.dgPatient.SelectedRows(0).Cells("MiddleInitial").Value
                txtPhone.Text = Me.dgPatient.SelectedRows(0).Cells("HomeePhone").Value & ""
                txtDOB.Text = Me.dgPatient.SelectedRows(0).Cells("DateofBirth").Value & ""
                txtSEX.Text = Me.dgPatient.SelectedRows(0).Cells("Sex").Value & ""
            End If
        Catch
        End Try
    End Sub

    Public Function CurrentPatient() As String()
        CurrentPatient = aRet
        Exit Function
    End Function

    Private Sub EnterNewChartItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterNewChartItemToolStripMenuItem.Click
        EnterChartItems.Show()
    End Sub

    Private Sub EAndMCodingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EAndMCodingToolStripMenuItem.Click
        EvalMngCoding.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MMChProcedure.Show()
    End Sub

    Private Sub GradientNavigationButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton14.Click

        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Try
            sAction = "FormHealthHistory"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User is not authorized for this procedure.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If GradientCaption2.Text = "Patient Information" Then
                If dgPatient.SelectedRows.Count Then
                    HealthHistory.ShowHistory(aRet, arrayAssignedProvider)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GradientNavigationButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton5.Click
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Try
            sAction = "FormMonitor"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User is not authorized for this procedure.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Sub
            End If

            MinitoringSystem.Show()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Form3.Show()
    End Sub

    Private Sub DiagonosisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagonosisToolStripMenuItem.Click
        Diagonosis.Show()
    End Sub

    Private Sub AppcalandarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' AppCalander.Show()
    End Sub

    Private Sub txtFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub InsurenceCoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsurenceCoToolStripMenuItem.Click
        Insurence.Show()
    End Sub

    Private Sub PatientToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PATIENT.Show()
    End Sub

    Private Sub EmployerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployerToolStripMenuItem.Click
        Employer.Show()
    End Sub

    Private Sub GradientNavigationButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton8.Click

        If GradientCaption2.Text = "Patient Information" Then

            If dgPatient.SelectedRows.Count Then

                VitalSigns.ShowVitalSigns(aRet)
            End If
        Else
            If dgPatient.SelectedRows.Count Then
                'VitalSigns.ShowVitalSigns(Me.dgPatient.SelectedRows(0).Cells(0).Value)

            End If

        End If
    End Sub

    Private Sub dgpatient_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgPatient.CellFormatting
        If GradientCaption2.Text = "Appointment" Then

            If e.ColumnIndex = 1 Then
                'If Not IsNothing(e.Value) Then
                '  testVar = System.DBNull.Value
                If IsDBNull(e.Value) = False Then

                    e.CellStyle.BackColor = Drawing.Color.Cyan
                    ' e.CellStyle.BackColor = Drawing.Color.Beige
                End If
            End If
        End If
    End Sub

    'Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
    '    'If GradientCaption2.Text = "Appointment" Then

    '    If e.ColumnIndex = 0 Then
    '        e.CellStyle.ForeColor = Drawing.Color.BlueViolet

    '    End If


    '    If e.ColumnIndex <> 0 Then

    '        ' If dgApp.Columns("TimeDataGridViewTextBoxColumn").ToString <> "" Then

    '        If IsDBNull(e.Value) <> True Then

    '            ' e.CellStyle.BackColor = Color.FromArgb(255, 186, 105)
    '            e.CellStyle.BackColor = Color.FromArgb(227, 239, 255)
    '            ' e.CellStyle.BackColor = Drawing.Color.Beige
    '        End If
    '    End If


    '    If dgApp.Rows(e.RowIndex).Cells("ColorDataGridViewTextBoxColumn").Value <> "" Then
    '        dgApp.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Orange
    '    End If

    'End Sub

    Private Sub GradientNavigationButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton10.Click
        ''If GradientCaption2.Text = "Appointment" Then



        'If dgApp.SelectedRows.Count Then
        '    'If IsNothing(Me.dgPatient.SelectedRows(0).Cells(14).Value) = False Then
        '    If IsDBNull(Me.dgApp.SelectedRows(0).Cells(15).Value) = False Then


        '        'Appointments.ShowAppointment(Me.dgApp.SelectedRows(0).Cells(15).Value)
        '        Appointments.ShowAppointment(Me.dgApp.SelectedRows(0).Cells(15).Value, Me.dgApp.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value, Me.dgApp.SelectedRows(0).Cells("DateDataGridViewTextBoxColumn").Value)

        '    Else

        '        Dim appdate, StTime, Duration, id As String
        '        appdate = MonthCalendar1.SelectionRange.Start.Date
        '        StTime = Me.dgApp.SelectedRows(0).Cells(0).Value
        '        Duration = "15"

        '        Appointments.ADDAppointment(appdate, StTime, Duration)
        '    End If
        'End If


    End Sub

    Private Sub dgApp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'If dgApp.SelectedRows.Count Then
        '    'If IsNothing(Me.dgPatient.SelectedRows(0).Cells(14).Value) = False Then
        '    If IsDBNull(Me.dgApp.SelectedRows(0).Cells(15).Value) = False Then


        '        Appointments.ShowAppointment(Me.dgApp.SelectedRows(0).Cells(15).Value, Me.dgApp.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value, Me.dgApp.SelectedRows(0).Cells("DateDataGridViewTextBoxColumn").Value)
        '    Else

        '        Dim appdate, StTime, Duration, id As String
        '        appdate = MonthCalendar1.SelectionRange.Start.Date
        '        StTime = Me.dgApp.SelectedRows(0).Cells(0).Value
        '        Duration = "15"

        '        Appointments.ADDAppointment(appdate, StTime, Duration)
        '    End If
        'End If

    End Sub

    Private Sub CalacderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Calander.Show()
    End Sub

    Private Sub MessageListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessageListToolStripMenuItem.Click
        MessageList.Show()
    End Sub

    Private Sub MessagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessagesToolStripMenuItem.Click
        Messaging.Show()
    End Sub

    Private Sub GradientNavigationButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton12.Click

        Dim pieces() As String
        Dim IndexOf As Integer
        'Users Users = new Users();
        Dim sAction As String
        ' sAction = "ShowFormHealthHistory"
        Try
            sAction = "PatientAdding"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then

            Else
                MessageBox.Show("User not authorized to add new patients.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            PATIENT.Show()
            PATIENT.BindingNavigatorAddNewItem.PerformClick()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub F4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Physician.Show()
    End Sub

    Private Sub SplitContainer1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub InboxToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InboxToolStripMenuItem.Click
        MailBox.Show()
    End Sub

    'Private Sub PastMedicalHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PastMedicalHistoryToolStripMenuItem.Click
    '    ChartHX.Show()
    'End Sub

    'Private Sub HPIMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HPIMaintenanceToolStripMenuItem.Click
    '    HPImaintenance.Show()
    'End Sub

    Private Sub Form1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BillingReport.Show()
    End Sub

    Private Sub DisieseProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DesieseProfiles.Show()
    End Sub

    'Private Sub RosAndGenCatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RosAndGenCatToolStripMenuItem.Click
    '    RosAndGenCat.Show()
    'End Sub

    Private Sub Form1ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Form1.Show()
    End Sub

    Private Sub TransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionsToolStripMenuItem.Click
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        sAction = "FormTransactions"
        pieces = Permissions.Split(",")
        IndexOf = Array.IndexOf(pieces, sAction)

        If IndexOf <> -1 Then
        Else
            Exit Sub
        End If

        Transactions.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myVacation1 As Date = New DateTime(2009, 1, 13)
        Dim myVacation2 As Date = New DateTime(2009, 1, 16)
        MonthCalendar1.AddBoldedDate(myVacation1)
        MonthCalendar1.AddBoldedDate(myVacation2)
        Dim VacationDates As DateTime() = {myVacation1, myVacation2}
        MonthCalendar1.BoldedDates = VacationDates
        'MonthCalendar1.SelectionStart.Date, Date
    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        sAction = "FormPostBillingData"
        pieces = Permissions.Split(",")
        IndexOf = Array.IndexOf(pieces, sAction)

        If IndexOf <> -1 Then
        Else
            MessageBox.Show("You are not authorized to view Post Billing Data form.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        PostBillingData.Show()
    End Sub

    'Private Sub ChartEvaluationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartEvaluationToolStripMenuItem.Click
    '    ChartEvaluation.Show()
    'End Sub


    Private Sub DocumentImagingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim procID As Integer
        ' Run calculator.
        procID = Shell("C:\Program Files\Common Files\Microsoft Shared\MODI\12.0\MSPVIEW.exe", AppWinStyle.NormalNoFocus)
    End Sub

    Private Sub LabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabToolStripMenuItem.Click
        Dim procID As Integer
        ' Run calculator.
        procID = Shell("C:\DotNetLab\DotNetLab\DotNetLab.exe", AppWinStyle.NormalNoFocus)
    End Sub

    Private Sub LettersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Letters.Show()
    End Sub

    Public Function LoadAppointments()
        Try
            FillSpreadSheet()
            MultiAppointmentTableAdapter.Fill(Me.MMDataDataSet1.MultiAppointment, New System.Nullable(Of Date)(CType(MonthCalendar1.SelectionRange.Start.Date, Date)))
            'TabControl1.SelectedTab = AppointmentsTab
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer2.RefreshReport()
            ApplyColorToGrid()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        TabControl1.SelectedTab = AppointmentsTab
        LoadAppointments()
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
    End Sub

    Private Sub BillingReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingReportToolStripMenuItem1.Click
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        sAction = "ReportBillingReport"
        pieces = Permissions.Split(",")
        IndexOf = Array.IndexOf(pieces, sAction)

        If IndexOf <> -1 Then
        Else
            Exit Sub
        End If
        BillingReport.Show()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Users.Show()
    End Sub

    Private Sub ShortVisitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShortVisitToolStripMenuItem.Click
        ShortVisitTemplate.Show()
    End Sub

    Private Sub LettersToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LettersToolStripMenuItem2.Click
        Letters.Show()
    End Sub

    Private Sub GradientNavigationButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OAPpointmentsTableAdapter.FillByDate(Me.MMDataDataSet1.OAPpointments, New System.Nullable(Of Date)(CType(MonthCalendar1.SelectionRange.Start.Date, Date))) '_DateToolStripTextBox.Text
        ' Dim Row As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.
        Me.ACalendardayTableAdapter.Fill(Me.MMDataDataSet1.ACalendarday)

    End Sub

    Private Sub UsersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem1.Click
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Try
            sAction = "UserEditing"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User is not authorized for this procedure.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Users.Show()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DocumentImagingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentImagingToolStripMenuItem1.Click
        Dim procID As Integer
        ' Run calculator.
        procID = Shell("C:\Program Files\Common Files\Microsoft Shared\MODI\12.0\MSPVIEW.exe", AppWinStyle.NormalNoFocus)
    End Sub

    Private Sub DiseaseProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiseaseProfileToolStripMenuItem.Click
        DesieseProfiles.Show()
    End Sub

    Private Sub ARCommentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARCommentsToolStripMenuItem.Click
        ARComments.Show()
    End Sub

    Private Sub MultiBillingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiBillingReportToolStripMenuItem.Click
        MultiBillingReports.Show()
    End Sub

    Private Sub SuperBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperBillToolStripMenuItem.Click
        Superbill.Show()
    End Sub

    Private Sub HealthHistoryQuestionireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HealthHistoryQuestionireToolStripMenuItem.Click
        HealthHistoryQuestions.Show()
    End Sub

    Private Function FillSpreadSheet()
        Dim params(0) As Microsoft.Reporting.WinForms.ReportParameter
        params(0) = New Microsoft.Reporting.WinForms.ReportParameter("DateParameter", CType(MonthCalendar1.SelectionRange.Start.Date, String))

        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource1.Name = "MMDataDataSet1_OAPpointments"
        ReportDataSource1.Value = Me.OAPpointmentsBindingSource
        ReportViewer1.LocalReport.SetParameters(params)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DisplayName = "View Chart"
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "AppointMents.rdlc"
        Me.OAPpointmentsBindingSource.DataMember = "OAPpointments"
        Me.OAPpointmentsBindingSource.DataSource = Me.MMDataDataSet1
        Me.OAPpointmentsTableAdapter.FillByDate(Me.MMDataDataSet1.OAPpointments, New System.Nullable(Of Date)(CType(MonthCalendar1.SelectionRange.Start.Date, Date)))

        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource2.Name = "MMDataDataSet1_OAPpointments"
        ReportDataSource2.Value = Me.OAPpointmentsBindingSource
        ReportViewer2.LocalReport.SetParameters(params)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.DisplayName = "View Chart"
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "MedicalManager." & "MultiAppointments.rdlc"
        Me.MultiAppointmentBindingSource.DataMember = "MultiAppointment"
        Me.MultiAppointmentBindingSource.DataSource = Me.MMDataDataSet1
        Me.MultiAppointmentTableAdapter.Fill(Me.MMDataDataSet1.MultiAppointment, New System.Nullable(Of Date)(CType(MonthCalendar1.SelectionRange.Start.Date, Date)))

    End Function

    Private Sub ImmunizationMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImmunizationMaintenanceToolStripMenuItem.Click
        ImmunizationMaintenance.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        LoginForm.ShowDialog()
        LoadUser()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub PatientPicturesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientPicturesToolStripMenuItem.Click
        PatientPictures.Show()
    End Sub

    Private Sub PharmacyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PharmacyToolStripMenuItem.Click
        Pharmacy.Show()
    End Sub

    Private Sub GradientNavigationButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton3.Click
        Letters.Show()
    End Sub

    Private Sub DrugMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrugMaintenanceToolStripMenuItem.Click
        ' MMDRUGMaintenance.Show()
        DRUGs.Show()
    End Sub

    Private Sub MyDxMyPrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyDxMyPrToolStripMenuItem.Click
        Dim procID As Integer
        ' Run calculator.
        procID = Shell("C:\EMRMaintenance\EMRMaintenance.exe", AppWinStyle.NormalNoFocus)
    End Sub

    Private Sub CheifComplaintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheifComplaintToolStripMenuItem.Click
        ChiefComplaint.Show()
    End Sub

    Private Sub CategoriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriesToolStripMenuItem.Click
        RosAndGenCat.Show()
    End Sub

    Private Sub CategoryContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryContentsToolStripMenuItem.Click
        MMCHRosAndGen.Show()
    End Sub

    Private Sub ProfileDetailToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileDetailToolStripMenuItem1.Click
        ProfileDetailData.Show()
    End Sub

    Private Sub HPIMaintenanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HPIMaintenanceToolStripMenuItem1.Click
        HPImaintenance.Show()
    End Sub

    Private Sub ChartEvaluationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChartEvaluationToolStripMenuItem1.Click
        ChartEvaluation.Show()
    End Sub

    Private Sub TestSysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestSysToolStripMenuItem.Click
        RosGeneral.Show()
    End Sub

    Private Sub TestPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestPEToolStripMenuItem.Click
        PhysicalExamination.Show()
    End Sub

    Private Sub Form1ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form1ToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub TemplateAndRelatedCCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemplateAndRelatedCCToolStripMenuItem.Click
        DesieseProfiles.Show()
    End Sub

    Private Sub GradientNavigationButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton4.Click
        EnterChartItems.Show()
    End Sub

    Private Sub MultiAppointmentDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MultiAppointmentDataGridView.DoubleClick
        If MultiAppointmentDataGridView.SelectedRows.Count Then
            'If IsNothing(Me.dgPatient.SelectedRows(0).Cells(14).Value) = False Then
            If IsDBNull(Me.MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value) = False Then
                Appointments.ShowAppointment(Me.MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value, Me.MultiAppointmentDataGridView.SelectedRows(0).Cells("ChartNumber2").Value, Me.MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value)
            Else
                Dim appdate, StTime, Duration, id As String
                appdate = MonthCalendar1.SelectionRange.Start.Date
                StTime = Me.MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn1").Value

                Dim strValue As String
                strValue = GetGeneralInfo("AppointmentDuration")
                If strValue <> "" Then
                    Duration = strValue
                Else
                    Duration = "10"
                End If
                '  in future need to get this value from generalinfo table
                Appointments.ADDAppointment(appdate, StTime, Duration)
            End If
        End If
    End Sub
    'Private Sub MultiAppointmentDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MultiAppointmentDataGridView.CellFormatting
    '    'If GradientCaption2.Text = "Appointment" Then
    '    Dim hasrecord As Boolean
    '    hasrecord = False
    '    If e.ColumnIndex = 0 Then
    '        e.CellStyle.ForeColor = Drawing.Color.BlueViolet
    '    End If

    '    If e.ColumnIndex = 1 Then
    '        If IsDBNull(e.Value) <> True Then
    '            hasrecord = True
    '            MultiAppointmentDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
    '            If Not IsDBNull(MultiAppointmentDataGridView("ReasonforNotCheckIn2", e.RowIndex).Value) Then
    '                If MultiAppointmentDataGridView("ReasonforNotCheckIn2", e.RowIndex).Value <> "" Then
    '                    MultiAppointmentDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Orange
    '                End If
    '            Else
    '                MultiAppointmentDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
    '            End If

    '        End If
    '    End If


    'If e.ColumnIndex = 1 Then
    '    If IsDBNull(e.Value) <> True Then
    '        hasrecord = True
    '        MultiAppointmentDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
    '        If Not IsDBNull(MultiAppointmentDataGridView(15, e.RowIndex).Value) Then
    '            MultiAppointmentDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Orange

    '        End If
    '    End If
    'End If









    'If e.ColumnIndex <> 0 Then


    '    ' If IsDBNull(e.Value) <> True Then
    '    If hasrecord = True Then
    '        e.CellStyle.BackColor = Color.FromArgb(227, 239, 255)

    '    End If
    'End If
    'MultiAppointmentDataGridView.r()

    'If MultiAppointmentDataGridView.Rows(e.RowIndex).Cells("ReasonforNotCheckIn2").Value <> "" Then
    '    MultiAppointmentDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Orange
    'End If
    ' End Sub

    Private Function ApplyColorToGrid()
        Try
            'Dim i As Integer
            'For i = 0 To MultiAppointmentDataGridView.RowCount - 1

            '    If IsDBNull(MultiAppointmentDataGridView.Rows(i).Cells("ChartNumber2").Value) <> True Then
            '        MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
            '        If Not IsDBNull(MultiAppointmentDataGridView.Rows(i).Cells("ReasonforNotCheckIn2").Value) Then
            '            If MultiAppointmentDataGridView.Rows(i).Cells("ReasonforNotCheckIn2").Value <> "" Then
            '                MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
            '            End If
            '        Else
            '            MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
            '        End If
            '    End If
            'Next

            Dim i As Integer
            For i = 0 To MultiAppointmentDataGridView.RowCount - 1

                If IsDBNull(MultiAppointmentDataGridView.Rows(i).Cells("ChartNumber2").Value) <> True Then
                    MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
                    If Not IsDBNull(MultiAppointmentDataGridView.Rows(i).Cells("ReasonforNotCheckIn2").Value) Then
                        If MultiAppointmentDataGridView.Rows(i).Cells("ReasonforNotCheckIn2").Value <> "" Then
                            'MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                            Select Case MultiAppointmentDataGridView.Rows(i).Cells("ReasonforNotCheckIn2").Value
                                Case "NO SHOW, NO CALL"
                                    MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "NO SHOW BUT CALLED"
                                    MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "CHANGED APPOINTMENT DATE"
                                    MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "CALLED TO CANCEL"
                                    MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "MISSED"
                                    MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "RESCHEDULED"
                                    MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "CANCELLED"
                                    MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case Else
                                    MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
                            End Select
                        End If
                    ElseIf Not IsDBNull(MultiAppointmentDataGridView.Rows(i).Cells("Resource2").Value) Then
                        If MultiAppointmentDataGridView.Rows(i).Cells("Resource2").Value <> "" Then
                            MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.PaleVioletRed
                        End If
                    Else
                        MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
                    End If
                End If

                If Not IsDBNull(MultiAppointmentDataGridView.Rows(i).Cells("CheckIn").Value) Then
                    If MultiAppointmentDataGridView.Rows(i).Cells("Checkin").Value = True Then
                        MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.DarkSeaGreen
                    End If
                End If

                If Not IsDBNull(MultiAppointmentDataGridView.Rows(i).Cells("ApptStatus").Value) Then
                    If MultiAppointmentDataGridView.Rows(i).Cells("ApptStatus").Value = "COMPLETED" Then
                        MultiAppointmentDataGridView.Rows(i).Cells("ApptStatus").Style.BackColor = Color.Plum
                    End If
                End If

            Next
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "Appointment Color Code", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Function

    Private Function ApplyColorToPatientGrid()

        'Dim i As Integer
        'Try
        '    For i = 0 To dgPatient.RowCount - 1
        '        If IsDBNull(dgPatient.Rows(i).Cells(42).Value) <> True Then
        '            If dgPatient.Rows(i).Cells(42).Value = "OFFICE1" Then
        '                dgPatient.Rows(i).DefaultCellStyle.ForeColor = Color.Red
        '            ElseIf dgPatient.Rows(i).Cells(42).Value = "OFFICE2" Then
        '                dgPatient.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
        '            ElseIf dgPatient.Rows(i).Cells(42).Value = "OFFICE3" Then
        '                dgPatient.Rows(i).DefaultCellStyle.ForeColor = Color.Green
        '            ElseIf dgPatient.Rows(i).Cells(42).Value = "OFFICE4" Then
        '                dgPatient.Rows(i).DefaultCellStyle.ForeColor = Color.Orange
        '            Else
        '            End If
        '        End If
        '    Next





        Dim strValue As String
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        Dim icolor As Integer = 0
        cn.Open()
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("select distinct physicianoffice from mmpatient", cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read

            icolor += 1

            If Not String.IsNullOrEmpty(dr.Item(0).ToString) Then


                Dim i As Integer

                For i = 0 To dgPatient.RowCount - 1
                    Try
                        If dgPatient.Rows(i).Cells("physicianoffice").Value = dr.Item(0).ToString Then
                            If icolor = 1 Then
                                dgPatient.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                            ElseIf icolor = 2 Then
                                dgPatient.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
                            ElseIf icolor = 3 Then
                                dgPatient.Rows(i).DefaultCellStyle.ForeColor = Color.Green
                            ElseIf icolor = 4 Then
                                dgPatient.Rows(i).DefaultCellStyle.ForeColor = Color.Orange
                            ElseIf icolor = 5 Then
                                dgPatient.Rows(i).DefaultCellStyle.ForeColor = Color.Plum
                            Else
                            End If
                        End If
                    Catch
                    End Try
                Next



            End If

        End While
        cn.Close()
        Return strValue



        'Catch ex As System.Exception
        '    MessageBox.Show(ex.Message, "Patient Color Code", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'End Try
    End Function

    Private Sub MessageNoteMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessageNoteMaintenanceToolStripMenuItem.Click
        MessageList.Show()
    End Sub

    Private Sub FormulasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormulasToolStripMenuItem.Click
        Dim procID As Integer
        ' Run calculator.
        procID = Shell("C:\Program Files\Microsoft Office\Office12\OneNote.exe", AppWinStyle.NormalNoFocus)
    End Sub

    Private Sub ShortVisitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShortVisitToolStripMenuItem1.Click
        ShortVisitTemplate.Show()
    End Sub

    Private Sub ComboboxMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboboxMaintenanceToolStripMenuItem.Click
        ComboboxMaintenance.Show()
    End Sub

    Private Function GetGeneralInfo(ByVal strKey As String) As String
        Dim strValue As String
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("SELECT GeneralInfoValue FROM GeneralInfo WHERE GeneralInfoKey = '" & strKey.ToString & "'", cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            strValue = dr.Item(0).ToString
        End While
        cn.Close()
        Return strValue
    End Function

    'Private Function LoadApptContextmenu()

    '    Dim tmp As New ToolStripMenuItem("NEW")
    '    ContextMenuStrip1.Items.Add(tmp)
    '    tmp.DropDownItems.Add("now show", , AddressOf mnuHandler)


    'End Function

    'Private Sub mnuHandler(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim selected As String
    '    selected = CType(sender, MenuItem).Text
    '    'this displays the correct selected menuitem's text
    '    MsgBox(selected + " inside")

    'End Sub

    Private Sub BackupDatabasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDatabasesToolStripMenuItem.Click
        'BackupDatabases.Show()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        MMUpdate.Show()
    End Sub

    Private Sub TemplateMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemplateMaintenanceToolStripMenuItem.Click
        TemplateMaintenance.Show()
    End Sub

    Public Function LoadUser()
        Try
            lblUsername.BackColor = Color.DarkSeaGreen
            If globalUser <> "" Then
                lblUsername.Text = "User: " & globalUser
            End If
        Catch
        End Try
    End Function

    Private Function GetMACAddress() As String

        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim MACAddress As String = String.Empty
        For Each mo As ManagementObject In moc

            If (MACAddress.Equals(String.Empty)) Then
                If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()

                mo.Dispose()
            End If
            MACAddress = MACAddress.Replace(":", String.Empty)

        Next
        Return MACAddress
    End Function

    Private Function LoadComboBoxes2()

        Dim dr As DataRow
        Dim dt As DataTable
        Try
            dt = Me.MMDataDataSet1.Tables("MMCombo")

            For Each dr In dt.Rows
                If dr("PhysicianOffice") <> "N/A" Then
                    cmbPhysicianOffices.Items.Add(dr("PhysicianOffice"))
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Loading Comboboxes")
        End Try
    End Function

    Private Sub cmbPhysicianOffices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPhysicianOffices.SelectedIndexChanged
        If cmbPhysicianOffices.SelectedItem.ToString = "" Then
            Me.MmpatientTableAdapter.Fill(Me.MMDataDataSet1.MMPATIENT)
        Else
            Me.MmpatientTableAdapter.FillByPhysicianOffice(Me.MMDataDataSet1.MMPATIENT, cmbPhysicianOffices.Text)
        End If
        dgPatient.DataSource = MmpatientBindingSource
        dgPatient.Refresh()
    End Sub

    Private Function GetLastVisitDate()

        'SELECT  max(date) as max_date FROM  dbo.MMChartVisit where chartnumber = 'REHZU000'




        Dim db As DBAccess = New DBAccess()
        Dim localdr As SqlClient.SqlDataReader
        Dim dt As New DataTable()

   

        Try

            localdr = db.ExecuteReader("SELECT  max(date) as max_date FROM  dbo.MMChartVisit where chartnumber = '" & dgPatient.SelectedRows(0).Cells("ChartNumber").Value & "" & "'")



            If localdr.HasRows = True Then
                While localdr.Read

                    txtLastVisitDate.Text = Replace(localdr.Item(0).ToString, "12:00:00 AM", "")



                End While
            End If


        Catch ex As System.Exception
            txtLastVisitDate.Text = ""
            ' MessageBox.Show(ex.ToString, "Unable To Load Last Visit")
        End Try





    End Function

    Private Sub TransactionsDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionsDetailToolStripMenuItem.Click
        TransactionDetail2.Show()
    End Sub

    Private Sub GradientNavigationButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton7.Click
        If GradientCaption2.Text = "Patient Information" Then
            If dgPatient.SelectedRows.Count Then
                TransactionDetail2.ShowTransactions(aRet(1))
            End If
        End If
    End Sub

#Region "RightClickAppointment"

    'Private Sub MultiAppointmentDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MultiAppointmentDataGridView.CellMouseDown

    '    Dim ocontextmenustrip As New ContextMenu
    '    Try
    '        If e.Button = Windows.Forms.MouseButtons.Right Then
    '            If e.ColumnIndex <> -1 Then
    '                MultiAppointmentDataGridView.Rows(e.RowIndex).Selected = True
    '                Me.MultiAppointmentDataGridView.CurrentCell = Me.MultiAppointmentDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
    '                ocontextmenustrip.Show(Me.MultiAppointmentDataGridView, New Point(e.RowIndex, e.ColumnIndex))

    '                RescheduleOneWeekToolStripMenuItem.DropDownItems.Clear()
    '                RescheduleOneMonthToolStripMenuItem.DropDownItems.Clear()
    '                RescheduleTwoWeeksToolStripMenuItem.DropDownItems.Clear()
    '                RescheduleThreeWeeksToolStripMenuItem.DropDownItems.Clear()

    '                If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value) Then
    '                    LoadContextMenuItems()
    '                    LoadContextMenuItemsMonth()
    '                    LoadContextMenuItemsTwoWeeks()
    '                    LoadContextMenuItemsThreeWeeks()
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub

    Private Sub CancelAppointmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelAppointmentToolStripMenuItem.Click
        Try
            If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value) Then
                ' If MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value <> "" Then
                Dim strID As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value
                Dim strTime As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn1").Value
                Dim strname As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn3").Value
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                Dim cmd As New SqlCommand("update dbo.OAPpointments set ReasonforNotCheckIn = 'CANCELLED' where ID ='" & strID & "'", cn)
                cmd.ExecuteNonQuery()
                TabControl1.SelectedTab = AppointmentsTab
                LoadAppointments()
                cn.Close()
                ' End If
            End If
        Catch
            MessageBox.Show("error cancelling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckInToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckInToolStripMenuItem.Click
        Try
            If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value) Then

                Dim strID As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value
                Dim strTime As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn1").Value
                Dim strname As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn3").Value
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                Dim cmd As New SqlCommand("update dbo.OAPpointments set CheckIn = 1 where ID ='" & strID & "'", cn)
                cmd.ExecuteNonQuery()
                TabControl1.SelectedTab = AppointmentsTab
                LoadAppointments()
                cn.Close()
                ' End If
            End If
        Catch
            MessageBox.Show("error cancelling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Function LoadContextMenuItems()
    '    RescheduleOneWeekToolStripMenuItem.DropDownItems.Clear()
    '    Dim strValue As String
    '    Dim strValue2 As String = 0
    '    Dim connString As String = connString2
    '    Dim cn As New SqlConnection(connString)
    '    Dim cn2 As New SqlConnection(connString)
    '    cn.Open()
    '    cn2.Open()
    '    Dim cmd As New SqlCommand
    '    Dim cmd2 As New SqlCommand

    '    cmd = New SqlCommand("SELECT time from Acalendarday", cn)
    '    Dim dr As SqlDataReader = cmd.ExecuteReader()
    '    While dr.Read
    '        strValue = dr.Item(0).ToString

    '        Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
    '        Dim dtDateAfterOneWeek As Date = dtDate.AddDays(7)
    '        cmd2 = New SqlCommand("select COUNT(*)  from oappointments where date = '" & dtDateAfterOneWeek & "' and starttime = '" & strValue & "'", cn2)
    '        Dim dr2 As SqlDataReader = cmd2.ExecuteReader
    '        While dr2.Read
    '            strValue2 = dr2.Item(0).ToString
    '        End While
    '        dr2.Close()

    '        strValue = strValue & "                     "
    '        Dim substringTime As String = strValue.Substring(0, 16)
    '        Dim strExistingAppointments As String

    '        If strValue2 = 0 Then
    '            strExistingAppointments = ""
    '        Else
    '            strExistingAppointments = strValue2 & " existing appts"
    '        End If
    '        RescheduleOneWeekToolStripMenuItem.DropDownItems.Add(substringTime & strExistingAppointments, Nothing, New System.EventHandler(AddressOf SelectedChildMenuWEEK_OnClick))
    '        'RescheduleOneMonthToolStripMenuItem.DropDownItems.Add(strValue, Nothing, New System.EventHandler(AddressOf SelectedChildMenuMONTH_OnClick))
    '    End While
    '    cn.Close()
    '    cn2.Close()
    'End Function

    'Private Function LoadContextMenuItemsMonth()
    '    RescheduleOneMonthToolStripMenuItem.DropDownItems.Clear()
    '    Dim strValue As String
    '    Dim strValue2 As String = 0
    '    Dim connString As String = connString2
    '    Dim cn As New SqlConnection(connString)
    '    Dim cn2 As New SqlConnection(connString)
    '    cn.Open()
    '    cn2.Open()
    '    Dim cmd As New SqlCommand
    '    Dim cmd2 As New SqlCommand

    '    cmd = New SqlCommand("SELECT time from Acalendarday", cn)
    '    Dim dr As SqlDataReader = cmd.ExecuteReader()
    '    While dr.Read
    '        strValue = dr.Item(0).ToString

    '        Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
    '        Dim dtDateAfterOneMonth As Date = dtDate.AddDays(28)
    '        cmd2 = New SqlCommand("select COUNT(*)  from oappointments where date = '" & dtDateAfterOneMonth & "' and starttime = '" & strValue & "'", cn2)
    '        Dim dr2 As SqlDataReader = cmd2.ExecuteReader
    '        While dr2.Read
    '            strValue2 = dr2.Item(0).ToString
    '        End While
    '        dr2.Close()

    '        strValue = strValue & "               "
    '        Dim substringTime As String = strValue.Substring(0, 16)
    '        Dim strExistingAppointments As String

    '        If strValue2 = 0 Then
    '            strExistingAppointments = ""
    '        Else
    '            strExistingAppointments = strValue2 & " existing appts"
    '        End If
    '        RescheduleOneMonthToolStripMenuItem.DropDownItems.Add(substringTime & strExistingAppointments, Nothing, New System.EventHandler(AddressOf SelectedChildMenuMONTH_OnClick))
    '        'RescheduleOneMonthToolStripMenuItem.DropDownItems.Add(strValue, Nothing, New System.EventHandler(AddressOf SelectedChildMenuMONTH_OnClick))
    '    End While
    '    cn.Close()
    '    cn2.Close()
    'End Function

    'Private Function LoadContextMenuItemsTwoWeeks()
    '    RescheduleTwoWeeksToolStripMenuItem.DropDownItems.Clear()
    '    Dim strValue As String
    '    Dim strValue2 As String = 0
    '    Dim connString As String = connString2
    '    Dim cn As New SqlConnection(connString)
    '    Dim cn2 As New SqlConnection(connString)
    '    cn.Open()
    '    cn2.Open()
    '    Dim cmd As New SqlCommand
    '    Dim cmd2 As New SqlCommand

    '    cmd = New SqlCommand("SELECT time from Acalendarday", cn)
    '    Dim dr As SqlDataReader = cmd.ExecuteReader()
    '    While dr.Read
    '        strValue = dr.Item(0).ToString

    '        Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
    '        Dim dtDateAfterTwoWeeks As Date = dtDate.AddDays(14)
    '        cmd2 = New SqlCommand("select COUNT(*)  from oappointments where date = '" & dtDateAfterTwoWeeks & "' and starttime = '" & strValue & "'", cn2)
    '        Dim dr2 As SqlDataReader = cmd2.ExecuteReader
    '        While dr2.Read
    '            strValue2 = dr2.Item(0).ToString
    '        End While
    '        dr2.Close()

    '        strValue = strValue & "               "
    '        Dim substringTime As String = strValue.Substring(0, 16)
    '        Dim strExistingAppointments As String

    '        If strValue2 = 0 Then
    '            strExistingAppointments = ""
    '        Else
    '            strExistingAppointments = strValue2 & " existing appts"
    '        End If
    '        RescheduleTwoWeeksToolStripMenuItem.DropDownItems.Add(substringTime & strExistingAppointments, Nothing, New System.EventHandler(AddressOf SelectedChildMenuTwoWEEK_OnClick))
    '        'RescheduleOneMonthToolStripMenuItem.DropDownItems.Add(strValue, Nothing, New System.EventHandler(AddressOf SelectedChildMenuMONTH_OnClick))
    '    End While
    '    cn.Close()
    '    cn2.Close()
    'End Function

    'Private Function LoadContextMenuItemsThreeWeeks()
    '    RescheduleThreeWeeksToolStripMenuItem.DropDownItems.Clear()
    '    Dim strValue As String
    '    Dim strValue2 As String = 0
    '    Dim connString As String = connString2
    '    Dim cn As New SqlConnection(connString)
    '    Dim cn2 As New SqlConnection(connString)
    '    cn.Open()
    '    cn2.Open()
    '    Dim cmd As New SqlCommand
    '    Dim cmd2 As New SqlCommand

    '    cmd = New SqlCommand("SELECT time from Acalendarday", cn)
    '    Dim dr As SqlDataReader = cmd.ExecuteReader()
    '    While dr.Read
    '        strValue = dr.Item(0).ToString

    '        Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
    '        Dim dtDateAfterThreeWeeks As Date = dtDate.AddDays(21)
    '        cmd2 = New SqlCommand("select COUNT(*)  from oappointments where date = '" & dtDateAfterThreeWeeks & "' and starttime = '" & strValue & "'", cn2)
    '        Dim dr2 As SqlDataReader = cmd2.ExecuteReader
    '        While dr2.Read
    '            strValue2 = dr2.Item(0).ToString
    '        End While
    '        dr2.Close()

    '        strValue = strValue & "               "
    '        Dim substringTime As String = strValue.Substring(0, 16)
    '        Dim strExistingAppointments As String

    '        If strValue2 = 0 Then
    '            strExistingAppointments = ""
    '        Else
    '            strExistingAppointments = strValue2 & " existing appts"
    '        End If
    '        RescheduleThreeWeeksToolStripMenuItem.DropDownItems.Add(substringTime & strExistingAppointments, Nothing, New System.EventHandler(AddressOf SelectedChildMenuThreeWEEK_OnClick))
    '        'RescheduleOneMonthToolStripMenuItem.DropDownItems.Add(strValue, Nothing, New System.EventHandler(AddressOf SelectedChildMenuMONTH_OnClick))
    '    End While
    '    cn.Close()
    '    cn2.Close()
    'End Function


    'Private Sub SelectedChildMenuWEEK_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value) Then
    '            Dim strname As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn3").Value & ""
    '            Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
    '            Dim dtDateAfterOneWeek As Date = dtDate.AddDays(7)
    '            Dim strDuration As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn7").Value & ""
    '            Dim strProvider As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn9").Value & ""
    '            Dim strChartNumber As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("ChartNumber2").Value & ""
    '            Dim strPhone As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn4").Value & ""
    '            Dim strCell As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn5").Value & ""
    '            Dim strNotes As String = "RESCHEDULED: " & MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn6").Value & ""
    '            Dim strVisitType As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn14").Value & ""
    '            Dim strResource As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("Resource2").Value & ""
    '            Dim strProcedureCode As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn11").Value & ""
    '            ' Dim strApptStatus As String = "Rescheduled"
    '            Dim strColor As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("Color2").Value & ""

    '            Dim connString As String = connString2
    '            Dim cn As New SqlConnection(connString)
    '            cn.Open()
    '            Dim cmd As New SqlCommand("insert into oappointments (date, starttime, duration, provider, chartnumber, name, phone, note, resource, procedurecode, color, visittype, cellphone, creatuser, creatdate)" & _
    '                           "VALUES ('" & dtDateAfterOneWeek & "', '" & sender.text.ToString.Substring(0, 12).Trim & "', '" & strDuration & "', '" & strProvider & "', '" & strChartNumber & "', '" & strname & "', '" & strPhone & "', '" & strNotes & "', '" & strResource & "', '" & strProcedureCode & "', '" & strColor & "',  '" & strVisitType & "', '" & strCell & "', '" & globalUser & "', '" & Date.Now & "')", cn)
    '            cmd.ExecuteNonQuery()
    '            LoadAppointments()
    '            MessageBox.Show(strname & "'s " & " appointment has been rescheduled for " & dtDateAfterOneWeek & " at " & sender.text.ToString.Substring(0, 12).Trim, "Rescheduled", MessageBoxButtons.OK)
    '            cn.Close()
    '            ContextMenuStrip1.Close()
    '        End If
    '    Catch
    '        MessageBox.Show("error rescheduling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub SelectedChildMenuTwoWEEK_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value) Then
    '            Dim strname As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn3").Value & ""
    '            Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
    '            Dim dtDateAftertwoWeek As Date = dtDate.AddDays(14)
    '            Dim strDuration As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn7").Value & ""
    '            Dim strProvider As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn9").Value & ""
    '            Dim strChartNumber As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("ChartNumber2").Value & ""
    '            Dim strPhone As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn4").Value & ""
    '            Dim strCell As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn5").Value & ""
    '            Dim strNotes As String = "RESCHEDULED: " & MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn6").Value & ""
    '            Dim strVisitType As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn14").Value & ""
    '            Dim strResource As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("Resource2").Value & ""
    '            Dim strProcedureCode As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn11").Value & ""
    '            ' Dim strApptStatus As String = "Rescheduled"
    '            Dim strColor As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("Color2").Value & ""

    '            Dim connString As String = connString2
    '            Dim cn As New SqlConnection(connString)
    '            cn.Open()
    '            Dim cmd As New SqlCommand("insert into oappointments (date, starttime, duration, provider, chartnumber, name, phone, note, resource, procedurecode, color, visittype, cellphone, creatuser, creatdate)" & _
    '                           "VALUES ('" & dtDateAftertwoWeek & "', '" & sender.text.ToString.Substring(0, 12).Trim & "', '" & strDuration & "', '" & strProvider & "', '" & strChartNumber & "', '" & strname & "', '" & strPhone & "', '" & strNotes & "', '" & strResource & "', '" & strProcedureCode & "', '" & strColor & "',  '" & strVisitType & "', '" & strCell & "', '" & globalUser & "', '" & Date.Now & "')", cn)
    '            cmd.ExecuteNonQuery()
    '            LoadAppointments()
    '            MessageBox.Show(strname & "'s " & " appointment has been rescheduled for " & dtDateAftertwoWeek & " at " & sender.text.ToString.Substring(0, 12).Trim, "Rescheduled", MessageBoxButtons.OK)
    '            cn.Close()
    '            ContextMenuStrip1.Close()
    '        End If
    '    Catch
    '        MessageBox.Show("error rescheduling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub SelectedChildMenuMONTH_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value) Then
    '            Dim strname As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn3").Value & ""
    '            Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
    '            Dim dtDateAfterOneMonth As Date = dtDate.AddDays(28)
    '            Dim strDuration As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn7").Value & ""
    '            Dim strProvider As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn9").Value & ""
    '            Dim strChartNumber As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("ChartNumber2").Value & ""
    '            Dim strPhone As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn4").Value & ""
    '            Dim strCell As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn5").Value & ""
    '            Dim strNotes As String = "RESCHEDULED: " & MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn6").Value & ""
    '            Dim strVisitType As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn14").Value & ""
    '            Dim strResource As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("Resource2").Value & ""
    '            Dim strProcedureCode As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn11").Value & ""
    '            ' Dim strApptStatus As String = "Rescheduled"
    '            Dim strColor As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("Color2").Value & ""

    '            Dim connString As String = connString2
    '            Dim cn As New SqlConnection(connString)
    '            cn.Open()
    '            Dim cmd As New SqlCommand("insert into oappointments (date, starttime, duration, provider, chartnumber, name, phone, note, resource, procedurecode, color, visittype, cellphone, creatuser, creatdate)" & _
    '                           "VALUES ('" & dtDateAfterOneMonth & "', '" & sender.text.ToString.Substring(0, 12).Trim & "', '" & strDuration & "', '" & strProvider & "', '" & strChartNumber & "', '" & strname & "', '" & strPhone & "', '" & strNotes & "', '" & strResource & "', '" & strProcedureCode & "', '" & strColor & "',  '" & strVisitType & "', '" & strCell & "', '" & globalUser & "', '" & Date.Now & "')", cn)
    '            cmd.ExecuteNonQuery()
    '            LoadAppointments()
    '            MessageBox.Show(strname & "'s " & " appointment has been rescheduled for " & dtDateAfterOneMonth & " at " & sender.text.ToString.Substring(0, 12).Trim, "Rescheduled", MessageBoxButtons.OK)
    '            cn.Close()
    '            ContextMenuStrip1.Close()
    '        End If
    '    Catch
    '        MessageBox.Show("error rescheduling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub SelectedChildMenuThreeWEEK_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value) Then
    '            Dim strname As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn3").Value & ""
    '            Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
    '            Dim dtDateAfterThreeWeek As Date = dtDate.AddDays(21)
    '            Dim strDuration As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn7").Value & ""
    '            Dim strProvider As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn9").Value & ""
    '            Dim strChartNumber As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("ChartNumber2").Value & ""
    '            Dim strPhone As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn4").Value & ""
    '            Dim strCell As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn5").Value & ""
    '            Dim strNotes As String = "RESCHEDULED: " & MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn6").Value & ""
    '            Dim strVisitType As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn14").Value & ""
    '            Dim strResource As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("Resource2").Value & ""
    '            Dim strProcedureCode As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn11").Value & ""
    '            ' Dim strApptStatus As String = "Rescheduled"
    '            Dim strColor As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("Color2").Value & ""

    '            Dim connString As String = connString2
    '            Dim cn As New SqlConnection(connString)
    '            cn.Open()
    '            Dim cmd As New SqlCommand("insert into oappointments (date, starttime, duration, provider, chartnumber, name, phone, note, resource, procedurecode, color, visittype, cellphone, creatuser, creatdate)" & _
    '                           "VALUES ('" & dtDateAfterThreeWeek & "', '" & sender.text.ToString.Substring(0, 12).Trim & "', '" & strDuration & "', '" & strProvider & "', '" & strChartNumber & "', '" & strname & "', '" & strPhone & "', '" & strNotes & "', '" & strResource & "', '" & strProcedureCode & "', '" & strColor & "',  '" & strVisitType & "', '" & strCell & "', '" & globalUser & "', '" & Date.Now & "')", cn)
    '            cmd.ExecuteNonQuery()
    '            LoadAppointments()
    '            MessageBox.Show(strname & "'s " & " appointment has been rescheduled for " & dtDateAfterThreeWeek & " at " & sender.text.ToString.Substring(0, 12).Trim, "Rescheduled", MessageBoxButtons.OK)
    '            cn.Close()
    '            ContextMenuStrip1.Close()
    '        End If
    '    Catch
    '        MessageBox.Show("error rescheduling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub SuperBillToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SuperBillToolStripMenuItem1.Click
        Try
            If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("ChartNumber2").Value) Then

                Dim strChartNumber As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("ChartNumber2").Value
                Dim strTime As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn1").Value
                Dim strName As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn3").Value
                Dim strDate As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
                Superbill.ShowSuperBill(strChartNumber, strName, strTime, strDate)
            End If
        Catch
            MessageBox.Show("error showing superbill", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PENDINGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENDINGToolStripMenuItem.Click
        Try
            If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value) Then
                Dim strID As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                Dim cmd As New SqlCommand("update dbo.OAPpointments set ApptStatus = 'PENDING' where ID ='" & strID & "'", cn)
                cmd.ExecuteNonQuery()
                TabControl1.SelectedTab = AppointmentsTab
                LoadAppointments()
                cn.Close()
            End If
        Catch
        End Try
    End Sub

    Private Sub COMPLETEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPLETEDToolStripMenuItem.Click
        Try
            If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value) Then
                Dim strID As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                Dim cmd As New SqlCommand("update dbo.OAPpointments set ApptStatus = 'COMPLETED' where ID ='" & strID & "'", cn)
                cmd.ExecuteNonQuery()
                TabControl1.SelectedTab = AppointmentsTab
                LoadAppointments()
                cn.Close()
            End If
        Catch
        End Try
    End Sub

#End Region



    Private Sub btnDayAfter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDayAfter.Click

        Dim d As Date = DateTimePicker1.Value
        d = d.AddDays(+1)
        DateTimePicker1.Value = d
        LoadReshedulingGrid()
    End Sub

    Private Sub btnDayBefore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDayBefore.Click
        Dim d As Date = DateTimePicker1.Value
        d = d.AddDays(-1)
        DateTimePicker1.Value = d
        LoadReshedulingGrid()
    End Sub

    Private Function LoadReshedulingGrid()

        GroupBox2.Visible = True
        Dim dt As New DataTable("ReschedulingTable")
        dt.Columns.Add("Time")
        dt.Columns.Add("ExistingAppointments")
        Dim strValue As String
        Dim strValue2 As String = 0
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        Dim cn2 As New SqlConnection(connString)
        cn.Open()
        cn2.Open()
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand


        cmd = New SqlCommand("SELECT time from Acalendarday", cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            strValue = dr.Item(0).ToString

            Dim dtDate As Date = Format(DateTimePicker1.Value, "MM/dd/yyyy")
            '          Dim dtDateAfterOneWeek As Date = dtDate.AddDays(7)
            cmd2 = New SqlCommand("select COUNT(*)  from oappointments where date = '" & dtDate & "' and starttime = '" & strValue & "'", cn2)
            Dim dr2 As SqlDataReader = cmd2.ExecuteReader
            While dr2.Read
                strValue2 = dr2.Item(0).ToString
            End While
            dr2.Close()

            strValue = strValue & "                     "
            Dim substringTime As String = strValue.Substring(0, 16)
            Dim strExistingAppointments As String

            If strValue2 = 0 Then
                strExistingAppointments = ""
            Else
                strExistingAppointments = strValue2 & " existing appts"
            End If
            dt.Rows.Add(New Object() {strValue.TrimEnd, strExistingAppointments})

        End While
        ReschedulingTable.DataSource = dt
        ReschedulingTable.Columns(0).Width = 55
        ReschedulingTable.Columns(1).Width = 90

        cn.Close()
        cn2.Close()
    End Function

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LoadReshedulingGrid()
        lblDate.Text = Format(DateTimePicker1.Value, "dddd")

    End Sub

    Private Sub RescheduleOneWeekToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RescheduleOneWeekToolStripMenuItem.Click
        Try
            Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
            Dim dtDateAfterOneWeek As Date = dtDate.AddDays(7)
            DateTimePicker1.Value = dtDateAfterOneWeek
            LoadReshedulingGrid()

        Catch
            MessageBox.Show("error rescheduling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RescheduleTwoWeeksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RescheduleTwoWeeksToolStripMenuItem.Click
        Try
            Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
            Dim dtDateAftertwoWeek As Date = dtDate.AddDays(14)
            DateTimePicker1.Value = dtDateAftertwoWeek
            LoadReshedulingGrid()
        Catch
            MessageBox.Show("error rescheduling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RescheduleThreeWeeksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RescheduleThreeWeeksToolStripMenuItem.Click
        Try
            Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
            Dim dtDateAfterThreeWeek As Date = dtDate.AddDays(21)
            DateTimePicker1.Value = dtDateAfterThreeWeek
            LoadReshedulingGrid()
        Catch
            MessageBox.Show("error rescheduling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RescheduleOneMonthToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RescheduleOneMonthToolStripMenuItem.Click
        Try
            Dim dtDate As Date = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value
            Dim dtDateAfterOneMonth As Date = dtDate.AddDays(28)
            DateTimePicker1.Value = dtDateAfterOneMonth
            LoadReshedulingGrid()
        Catch
            MessageBox.Show("error rescheduling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MultiAppointmentDataGridView_CellMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MultiAppointmentDataGridView.CellMouseDown
        Try
            MultiAppointmentDataGridView.Rows(e.RowIndex).Selected = True
            MultiAppointmentDataGridView.CurrentCell = MultiAppointmentDataGridView.Rows(e.RowIndex).Cells(0)
        Catch
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            GroupBox2.Visible = False
            GroupBox3.Visible = False
        ElseIf TabControl1.SelectedIndex = 1 Then
            GroupBox3.Visible = True
        End If
    End Sub

    Private Sub ReschedulingTable_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReschedulingTable.DoubleClick
        If Not IsDBNull(MultiAppointmentDataGridView.SelectedRows(0).Cells("ID").Value) Then
            Dim strname As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn3").Value & ""

            Dim dtReschedule As Date = Format(DateTimePicker1.Value, "MM/dd/yyyy")
            Dim strDuration As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn7").Value & ""
            Dim strProvider As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn9").Value & ""
            Dim strChartNumber As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("ChartNumber2").Value & ""
            Dim strPhone As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn4").Value & ""
            Dim strCell As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn5").Value & ""
            Dim strNotes As String = "(rescheduled from " & MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn10").Value & ") " & MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn6").Value & ""
            Dim strVisitType As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("VisitType").Value & ""
            Dim strResource As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("Resource2").Value & ""
            Dim strProcedureCode As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("DataGridViewTextBoxColumn11").Value & ""
            Dim strColor As String = MultiAppointmentDataGridView.SelectedRows(0).Cells("Color2").Value & ""
            Dim strTime As String = ReschedulingTable.SelectedRows(0).Cells(0).Value
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand("insert into oappointments (date, starttime, duration, provider, chartnumber, name, phone, note, resource, procedurecode, color, visittype, cellphone, creatuser, creatdate)" & _
                           "VALUES ('" & dtReschedule & "', '" & strTime.Trim & "', '" & strDuration & "', '" & strProvider & "', '" & strChartNumber & "', '" & strname & "', '" & strPhone & "', '" & strNotes & "', '" & strResource & "', '" & strProcedureCode & "', '" & strColor & "',  '" & strVisitType & "', '" & strCell & "', '" & globalUser & "', '" & Date.Now & "')", cn)
            cmd.ExecuteNonQuery()
            TabControl1.SelectedTab = AppointmentsTab
            LoadAppointments()
            MessageBox.Show(strname & "'s " & " appointment has been rescheduled for " & dtReschedule & " at " & strTime.Trim, "Rescheduled", MessageBoxButtons.OK)
            cn.Close()
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub MultiAppointmentDataGridView_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiAppointmentDataGridView.Sorted
        ApplyColorToGrid()
    End Sub

    Private Sub ExportToHL7ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToHL7ToolStripMenuItem.Click
        ExportHL7.Show()
    End Sub

    Private Sub ZipCodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZipCodesToolStripMenuItem.Click
        ZipCode.Show()
    End Sub


End Class
