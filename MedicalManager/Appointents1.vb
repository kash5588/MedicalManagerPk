Imports System.Text
Imports Microsoft.Office.Interop.Outlook

Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Imports System.Configuration
Imports System.Data.sqlclient


Public Class Appointments

    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(4) As String
    ' Private WithEvents App As Outlook.AppointmentItem
    'Private Shared mOutlookApplication As Outlook.Application
    Dim AppId, dateapp, appduration, appstarttime As String
    Dim AddMode As Boolean
    Dim AllApp As Boolean
    Dim beforeDate As Date
    Dim beforeTime As String
    Dim strChartNumber As String
    Dim myBindingSource As New BindingSource()




    Private Sub Appointments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MMChartMessagesTableAdapter.FillByType(Me.MMDataDataSet1.MMChartMessages, "Appointment")
        Me.OAPpointments1TableAdapter.Fill(Me.MMDataDataSet1.OAPpointments1)
        Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
        LoadComboBoxes2()
        AddMode = False
        Me.MMRPHTableAdapter.Fill(Me.MMDataDataSet1.MMRPH)
        Me.OAPpointmentsTableAdapter.FillbyID(Me.MMDataDataSet1.OAPpointments, AppId)

        If Not String.IsNullOrEmpty(dateapp) Then
            Me.OAPpointments1TableAdapter.FillBy(Me.MMDataDataSet1.OAPpointments1, strChartNumber, New System.Nullable(Of Date)(CType(dateapp, Date)))
        End If

        'If Not String.IsNullOrEmpty(strChartNumber) Then
        '    ' Me.OAPpointments1TableAdapter.FillBy(Me.MMDataDataSet1.OAPpointments1, strChartNumber, New System.Nullable(Of Date)(CType(dateapp, Date)))
        '    Me.OAPpointmentsTableAdapter.FillByChartNumber(Me.MMDataDataSet1.OAPpointments, strChartNumber)
        '    TabControl1.SelectedTab = TabControl1.TabPages(0)
        '    txtFind.Text = strChartNumber
        'End If
        ' Me.OAPpointments1TableAdapter.FillBy(Me.MMDataDataSet1.OAPpointments1, strChartNumber, New System.Nullable(Of Date)(CType(dateapp, Date)))

        ' Me.OAPpointmentsTableAdapter.Fil(Me.MMDataDataSet1.OAPpointments)
        cmbFilter.SelectedIndex = 0
        TabControl1.SelectedTab = TabControl1.TabPages(1)
        BindingNavigatorAddNewItem.Enabled = False
        'LoadDefaultDr()
        LoadAppointmentHx()
        'beforeDate = DateDateTimePicker.Text
        'beforeTime = StarttimeCB.Text
    End Sub

    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        Try
            Dim FrmProcedure As New Procedure
            'aRet = frmCustomers.ShowPicklist
            ' frmCustomers.ShowDialog()
            aRet = PATIENT.ShowPicklist
            If aRet(0) = "Y" Then       ' they picked a lab
                ChartNumberTextBox.Text = aRet(1).Trim
                NameTextBox.Text = aRet(2).Trim & ", " & aRet(3).Trim
                PhoneMaskedTextBox.Text = aRet(5)
                cellMaskedTextBox.Text = aRet(6)
                ' DOBTextBox.Text = aRet(6)
                'DOBTextBox.Text = aRet(6)
                ApptStatusComboBox.Focus()
                LoadAppointmentHx()
                If Not String.IsNullOrEmpty(dateapp) Then
                    Me.OAPpointments1TableAdapter.FillBy(Me.MMDataDataSet1.OAPpointments1, ChartNumberTextBox.Text, New System.Nullable(Of Date)(CType(dateapp, Date)))
                End If
            End If
        Catch
        End Try
    End Sub

    Public Function ShowAppointment(ByVal Id As String, ByVal ChartNumber As String, ByVal strDate As String) As String()
        dateapp = strDate
        strChartNumber = ChartNumber
        AppId = Id
        Me.Show()
    End Function

    Public Function ShowAppointmentByChartNo(ByVal ChartNumber As String) As String()

        strChartNumber = ChartNumber
        AllApp = True
        Me.Show()
    End Function

    Public Function ADDAppointment(ByVal appdate As String, ByVal stTime As String, ByVal Duration As String) As String()
        dateapp = appdate
        appduration = Duration
        appstarttime = stTime
        Me.Show()

        OAPpointmentsBindingSource.AddNew()

    End Function

    Private Sub OAPpointmentsBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles OAPpointmentsBindingSource.AddingNew
        Me.MMDataDataSet1.OAPpointments.DateColumn.DefaultValue = dateapp
        TextBox1.Text = dateapp
        Dim strValue As String = ""
        Try
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            Dim cmd As New SqlCommand

            cn.Open()

            cmd = New SqlCommand("SELECT Extra1 from MMPrectice", cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read
                strValue = dr.Item(0).ToString
            End While
            cn.Close()
        Catch
        End Try



        Me.MMDataDataSet1.OAPpointments.DurationColumn.DefaultValue = appduration
        Me.MMDataDataSet1.OAPpointments.StartTimeColumn.DefaultValue = appstarttime
        Me.MMDataDataSet1.OAPpointments.ChartNumberColumn.DefaultValue = ""
        Me.MMDataDataSet1.OAPpointments.IsBreakColumn.DefaultValue = False
        Me.MMDataDataSet1.OAPpointments.CheckInColumn.DefaultValue = False
        Me.MMDataDataSet1.OAPpointments.ColorColumn.DefaultValue = ""
        Me.MMDataDataSet1.OAPpointments.CreatUserColumn.DefaultValue = globalUser
        Me.MMDataDataSet1.OAPpointments.CreatdateColumn.DefaultValue = Date.Now
        Me.MMDataDataSet1.OAPpointments.ProviderColumn.DefaultValue = strValue

        AddMode = True

    End Sub

    Private Sub OAPpointmentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OAPpointmentsBindingNavigatorSaveItem.Click
        beforeDate = Nothing
        beforeTime = ""
        Try
            beforeDate = Me.MMDataDataSet1.OAPpointments.Rows(0)("Date").ToString()
            beforeTime = Me.MMDataDataSet1.OAPpointments.Rows(0)("StartTime").ToString()
        Catch
        End Try

        Try
            If DateDateTimePicker.Text = beforeDate Then
                If StarttimeCB.Text = beforeTime Then
                    Me.Validate()
                    Me.OAPpointmentsBindingSource.EndEdit()
                    Me.OAPpointmentsTableAdapter.Update(Me.MMDataDataSet1.OAPpointments)
                Else
                    If IsAppExisting() = True Then
                        MessageBox.Show("Appointment already exists for the " & DateDateTimePicker.Text & " " & StarttimeCB.Text & " timeslot.", "Already Existing Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        Me.Validate()
                        Me.OAPpointmentsBindingSource.EndEdit()
                        Me.OAPpointmentsTableAdapter.Update(Me.MMDataDataSet1.OAPpointments)
                    End If
                End If
            Else
                If IsAppExisting() = True Then
                    MessageBox.Show("Appointment already exists during the " & DateDateTimePicker.Text & " " & StarttimeCB.Text & " timeslot.", "Already Existing Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Me.Validate()
                    Me.OAPpointmentsBindingSource.EndEdit()
                    Me.OAPpointmentsTableAdapter.Update(Me.MMDataDataSet1.OAPpointments)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function IsAppExisting() As Boolean
        'Dim AppExists As Boolean = False
        'Dim db As DBAccess = New DBAccess()
        'Dim localdr As SqlClient.SqlDataReader

        'localdr = db.ExecuteReader("SELECT Date, StartTime FROM OAPpointments  WHERE Date = '" & DateDateTimePicker.Text & "' AND StartTime = '" & StarttimeCB.Text & "'")
        'If localdr.HasRows = True Then
        '    AppExists = True
        'End If
        'Return AppExists


        Dim AppExists As Boolean = False
        'Dim localdr As SqlClient.SqlDataReader
        'Dim sql As String = "SELECT Date, StartTime FROM OAPpointments  WHERE Date = '" & DateDateTimePicker.Text & "' AND StartTime = '" & StarttimeCB.Text & "'"
        'Dim connString As String = connString2
        'Dim conn As New SqlConnection(connString)
        'Dim cmd As New SqlCommand(sql, conn)

        Try
            'conn.Open()
            'localdr = cmd.ExecuteReader
            'If localdr.HasRows = True Then
            '    AppExists = True
            'End If
            Return AppExists
        Catch
        Finally
            'conn.Close()
        End Try

    End Function

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text <> "" Then
            Me.OAPpointmentsBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
        End If
        Me.OAPpointmentsBindingSource.Sort = "ChartNumber"
        DataGridView1.DataSource = Me.OAPpointmentsBindingSource
        ' GradientCaption2.Text = "Patient Information"


    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Me.OAPpointmentsTableAdapter.FillByChartNumber(Me.MMDataDataSet1.OAPpointments, txtFind.Text + "%")
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub

    Private Function LoadComboBoxes2()

        Dim dr As DataRow

        Dim dt As DataTable
        dt = Me.MMDataDataSet1.Tables("MMCombo")

        For Each dr In dt.Rows
            If dr("VisitType") <> "N/A" Then
                VisittypeComboBox.Items.Add(dr("VisitType"))
            End If
        Next

        For Each dr In dt.Rows
            If dr("ReasonForNoCheckin") <> "N/A" Then
                ReasonforNotCheckInComboBox.Items.Add(dr("ReasonForNoCheckin"))
            End If
        Next
    End Function

    Private Function GetSelectedRowCollection() As List(Of String)
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim drc As DataGridViewSelectedRowCollection = DataGridView1.SelectedRows
            Dim ids As New List(Of String)
            For i As Integer = 0 To drc.Count - 1
                Dim id As Integer = drc(i).Cells(0).Value
                ids.Add(id.ToString)
            Next
            Return ids
        Else
            Return Nothing
        End If
    End Function

    Private Sub SaveAppButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAppButton.Click


        'Dim mOutlookApplication As New Outlook.Application

        'Dim newAppItem As Microsoft.Office.Interop.Outlook.AppointmentItem
        'newAppItem = mOutlookApplication.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olAppointmentItem)
        ''PatientRow = CType(CType( _
        ''   Me.MMPATIENTBindingSource.Current, DataRowView).Row, MMDataDataSet.MMPATIENTRow)


        'newAppItem.Subject = ChartNumberTextBox.Text & "  " & NameTextBox.Text & "  " & PhoneMaskedTextBox.Text & "  " & ProviderComboBox.Text
        'newAppItem.Body = "Office Visit"
        '' newAppItem.Start = MonthCalendar1.SelectionStart.ToShortDateString & " " & DateDateTimePicker.Value & " " & StarttimeCB ' #2/4/2007 3:30:00 PM#
        'newAppItem.Start = DateDateTimePicker.Text & " " & StarttimeCB.Text ' #2/4/2007 3:30:00 PM#
        '' newAppItem.Start = StarttimeCB.Text

        '' MsgBox(DateTimePicker1.Value)

        'newAppItem.Duration = DurationComboBox.Text
        'newAppItem.Save()

        ''Try
        ''    ' myRange.InsertAfter(customerInfo.ToString())
        ''Catch ex As Exception
        ''    MessageBox.Show( _
        ''        "The information could not be added to the document.")
        ''End Try



    End Sub

    Private Sub DateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateDateTimePicker.ValueChanged
        DateDateTimePicker.Value = DateDateTimePicker.Value.Date()
    End Sub

    Private Sub cmdRefphysician_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefphysician.Click
        Dim RefPhysician As New ReferringPhysician
        'aRet = frmCustomers.ShowPicklist
        ' frmCustomers.ShowDialog()
        aRet = RefPhysician.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab
            RefIdTextBox.Text = aRet(1)

            RefPhysicianTextBox.Text = aRet(3) + " " + aRet(2)
            '  LastNameTextBox.Text = aRet(3) + " " + aRet(2)
            '  FirstNameTextBox.Text = aRet(3)
            ' DOBTextBox.Text = aRet(6)
            'DOBTextBox.Text = aRet(6)
        End If
    End Sub

    Private Sub Appointments_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.OAPpointmentsBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            ' See if any changes were made, but not saved 
            If Me.MMDataDataSet1.OAPpointments.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        If IsAppExisting() = True Then
                            MessageBox.Show("Appointment already exists", "Already Existing Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            e.Cancel = True
                        Else
                            Me.OAPpointmentsTableAdapter.Update(Me.MMDataDataSet1.OAPpointments)
                        End If
                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.OAPpointments.RejectChanges()

                    Case Else
                        e.Cancel = True
                End Select
            End If

        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "Patient form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        Finally

        End Try
    End Sub

    'Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
    '    If IsDate(DateTimePicker1.Text) Then


    '        Try

    '            Me.OAPpointmentsTableAdapter.FillByDateGreaterThan(Me.MMDataDataSet1.OAPpointments, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)))


    '        Catch ex As System.Exception
    '            System.Windows.Forms.MessageBox.Show(ex.Message)
    '        End Try
    '    Else
    '        MsgBox("EnterDate")
    '        ' DateToolStripTextBox.Select()
    '    End If
    'End Sub

    'Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    '    If IsDate(DateTimePicker1.Text) Then


    '        Try

    '            Me.OAPpointmentsTableAdapter.FillByDatelessThan(Me.MMDataDataSet1.OAPpointments, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)))


    '        Catch ex As System.Exception
    '            System.Windows.Forms.MessageBox.Show(ex.Message)
    '        End Try
    '    Else
    '        MsgBox("EnterDate")
    '        '  DateToolStripTextBox.Select()
    '    End If
    'End Sub

    Private Sub NoteLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
        If IsDate(DateTimePicker1.Text) Then

            Try
                Me.OAPpointmentsTableAdapter.FillByDate(Me.MMDataDataSet1.OAPpointments, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("EnterDate")
        End If
        TabControl1.SelectedTab = TabControl1.TabPages(0)
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick
        If IsDate(DateTimePicker1.Text) Then
            Try
                Me.OAPpointmentsTableAdapter.FillByDate(Me.MMDataDataSet1.OAPpointments, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("EnterDate")
            'DateToolStripTextBox.Select()
        End If
        TabControl1.SelectedTab = TabControl1.TabPages(0)
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        If IsDate(DateTimePicker1.Text) Then

            Try
                Me.OAPpointmentsTableAdapter.FillByDateGreaterThan(Me.MMDataDataSet1.OAPpointments, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("EnterDate")
            ' DateToolStripTextBox.Select()
        End If
        TabControl1.SelectedTab = TabControl1.TabPages(0)
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub BToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BToolStripMenuItem.Click
        If IsDate(DateTimePicker1.Text) Then

            Try
                Me.OAPpointmentsTableAdapter.FillByDatelessThan(Me.MMDataDataSet1.OAPpointments, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("EnterDate")
            '  DateToolStripTextBox.Select()
        End If
        TabControl1.SelectedTab = TabControl1.TabPages(0)
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub cmdAddAppointment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAppointment.Click
        Try
            dateapp = DateDateTimePicker.Text
            appduration = DurationComboBox.Text
            appstarttime = StarttimeCB.Text
            '  TextBox1.Text = appdate


            OAPpointmentsBindingSource.AddNew()

            DateDateTimePicker.Text = dateapp
            DurationComboBox.Text = appduration
            StarttimeCB.Text = appstarttime
            cmdPatient.Focus()
        Catch
        End Try
    End Sub

    Private Sub btnFindByChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OAPpointmentsTableAdapter.FillByChartNumber(Me.MMDataDataSet1.OAPpointments, txtFind.Text + "%")
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Text = "List" Then
            FillByDateToolStrip.Visible = True
            DateTimePicker1.Visible = True
        Else
            FillByDateToolStrip.Visible = False
            DateTimePicker1.Visible = False
        End If
    End Sub

    'Private Sub MMChartMessagesDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMChartMessagesDataGridView.DoubleClick
    '    Try
    '        If CheckNoteMaxLength() = True Then
    '            If NoteTextBox.Text <> "" Then
    '                NoteTextBox.Text = NoteTextBox.Text & ", " & MMChartMessagesDataGridView.SelectedRows(0).Cells("Message").Value & ""
    '            Else
    '                NoteTextBox.Text = MMChartMessagesDataGridView.SelectedRows(0).Cells("Message").Value & ""
    '            End If
    '        Else
    '        End If
    '    Catch
    '    End Try
    'End Sub

    Private Function CheckNoteMaxLength() As Boolean
        Try
            If NoteTextBox.Text.Length + MMChartMessagesDataGridView.SelectedRows(0).Cells("Message").Value.ToString.Length > NoteTextBox.MaxLength Then
                MessageBox.Show("Number of characters exceeds max length of note.", "Note Maxed Out", MessageBoxButtons.OK)
                Return False
            Else : Return True
            End If
        Catch
        End Try
    End Function

    Private Function CheckNoteMaxLengthPost() As Boolean

        Dim strLength As String
        Dim i As Integer
        Try

            For i = 0 To MMChartMessagesDataGridView.RowCount - 1
                If MMChartMessagesDataGridView.Rows(i).Cells("PostColumn").Value = True Then
                    strLength = strLength + MMChartMessagesDataGridView.Rows(i).Cells("Message").Value.ToString.Length
                End If
            Next
            strLength += NoteTextBox.Text.Length

            If strLength > NoteTextBox.MaxLength Then
                MessageBox.Show("Number of characters exceeds max length of note.", "Note Maxed Out", MessageBoxButtons.OK)
                Return False
            Else : Return True
            End If

        Catch
        End Try
    End Function

    Private Sub btnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPost.Click
        Try
            If CheckNoteMaxLengthPost() = True Then
                Dim i As Integer
                For i = 0 To MMChartMessagesDataGridView.RowCount - 1
                    If MMChartMessagesDataGridView.Rows(i).Cells("PostColumn").Value = True Then
                        If NoteTextBox.Text <> "" Then
                            NoteTextBox.Text = NoteTextBox.Text & ", " & MMChartMessagesDataGridView.Rows(i).Cells("Message").Value & ""
                        Else
                            NoteTextBox.Text = MMChartMessagesDataGridView.Rows(i).Cells("Message").Value & ""
                        End If
                    End If
                Next
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count Then
            Me.OAPpointments1TableAdapter.FillBy(Me.MMDataDataSet1.OAPpointments1, DataGridView1.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value, DataGridView1.SelectedRows(0).Cells("DateDataGridViewTextBoxColumn").Value)
        End If
    End Sub

    Private Sub Appointments_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            cmdPatient.Focus()
        Catch
        End Try
    End Sub

    Private Function LoadDefaultDr()
        Dim strValue As String
        strValue = GetGeneralInfo("DefaultDrCode")
        If strValue <> "" Then
            ProviderComboBox.Text = strValue

        Else
            ProviderComboBox.Text = ""
        End If
    End Function

    Private Function LoadAppointmentHx()
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)

        Try

            If ChartNumberTextBox.Text <> "" Then
                cn.Open()
                Dim cmd As New SqlCommand("select  Date, ChartNumber, [Name], starttime as Time, Note, Resource, Phone, Cellphone, ReasonForNotCheckIn from oappointments where chartnumber = '" & ChartNumberTextBox.Text & "'", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMDX")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                dgvAppointmentHx.DataSource = myBindingSource
                ds.Dispose()
                cn.Close()
            End If
            ApplyColorToGrid()
        Catch ex As System.Exception
            MessageBox.Show(ex.ToString, "Error Loading Apppointment History")
        End Try
    End Function

    Private Function ApplyColorToGrid()
        Try

            Dim i As Integer
            For i = 0 To dgvAppointmentHx.RowCount - 1

                If IsDBNull(dgvAppointmentHx.Rows(i).Cells("chartnumber").Value) <> True Then
                    dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
                    If Not IsDBNull(dgvAppointmentHx.Rows(i).Cells("reasonfornotcheckin").Value) Then
                        If dgvAppointmentHx.Rows(i).Cells("reasonfornotcheckin").Value <> "" Then
                            'MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                            Select Case dgvAppointmentHx.Rows(i).Cells("reasonfornotcheckin").Value
                                Case "NO SHOW, NO CALL"
                                    dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "NO SHOW BUT CALLED"
                                    dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "CHANGED APPOINTMENT DATE"
                                    dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "CALLED TO CANCEL"
                                    dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "MISSED"
                                    dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "RESCHEDULED"
                                    dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "CANCELLED"
                                    dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case Else
                                    dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
                            End Select
                        End If
                    ElseIf Not IsDBNull(dgvAppointmentHx.Rows(i).Cells("resource").Value) Then
                        If dgvAppointmentHx.Rows(i).Cells("resource").Value <> "" Then
                            dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.PaleVioletRed
                        End If
                    Else
                        dgvAppointmentHx.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
                    End If
                End If
            Next




            For i = 0 To OAPpointments1DataGridView.RowCount - 1

                If IsDBNull(OAPpointments1DataGridView.Rows(i).Cells("chartnumber").Value) <> True Then
                    OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
                    If Not IsDBNull(OAPpointments1DataGridView.Rows(i).Cells("reasonfornotcheckin").Value) Then
                        If OAPpointments1DataGridView.Rows(i).Cells("reasonfornotcheckin").Value <> "" Then
                            'MultiAppointmentDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                            Select Case OAPpointments1DataGridView.Rows(i).Cells("reasonfornotcheckin").Value
                                Case "NO SHOW, NO CALL"
                                    OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "NO SHOW BUT CALLED"
                                    OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "CHANGED APPOINTMENT DATE"
                                    OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "CALLED TO CANCEL"
                                    OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "MISSED"
                                    OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "RESCHEDULED"
                                    OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case "CANCELLED"
                                    OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                                Case Else
                                    OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
                            End Select
                        End If
                    ElseIf Not IsDBNull(OAPpointments1DataGridView.Rows(i).Cells("resource").Value) Then
                        If OAPpointments1DataGridView.Rows(i).Cells("resource").Value <> "" Then
                            OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.PaleVioletRed
                        End If
                    Else
                        OAPpointments1DataGridView.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
                    End If
                End If
            Next




        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "Appointment Color Code", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Function


    
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        beforeDate = Nothing
        beforeTime = ""
        Try
            beforeDate = Me.MMDataDataSet1.OAPpointments.Rows(0)("Date").ToString()
            beforeTime = Me.MMDataDataSet1.OAPpointments.Rows(0)("StartTime").ToString()
        Catch
        End Try

        Try
            If DateDateTimePicker.Text = beforeDate Then
                If StarttimeCB.Text = beforeTime Then
                    Me.Validate()
                    Me.OAPpointmentsBindingSource.EndEdit()
                    Me.OAPpointmentsTableAdapter.Update(Me.MMDataDataSet1.OAPpointments)
                Else
                    If IsAppExisting() = True Then
                        MessageBox.Show("Appointment already exists for the " & DateDateTimePicker.Text & " " & StarttimeCB.Text & " timeslot.", "Already Existing Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        Me.Validate()
                        Me.OAPpointmentsBindingSource.EndEdit()
                        Me.OAPpointmentsTableAdapter.Update(Me.MMDataDataSet1.OAPpointments)
                    End If
                End If
            Else
                If IsAppExisting() = True Then
                    MessageBox.Show("Appointment already exists during the " & DateDateTimePicker.Text & " " & StarttimeCB.Text & " timeslot.", "Already Existing Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Me.Validate()
                    Me.OAPpointmentsBindingSource.EndEdit()
                    Me.OAPpointmentsTableAdapter.Update(Me.MMDataDataSet1.OAPpointments)
                End If
            End If

            Me.Close()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MMChartMessagesDataGridView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartMessagesDataGridView.Click
        Try
            If CheckNoteMaxLength() = True Then
                If NoteTextBox.Text <> "" Then
                    NoteTextBox.Text = NoteTextBox.Text & ", " & MMChartMessagesDataGridView.SelectedRows(0).Cells("Message").Value & ""
                Else
                    NoteTextBox.Text = MMChartMessagesDataGridView.SelectedRows(0).Cells("Message").Value & ""
                End If
            Else
            End If
        Catch
        End Try
    End Sub
End Class

'    Try
'            If DateDateTimePicker.Text <> beforeDate And StarttimeCB.Text <> beforeTime Then
''If StarttimeCB.Text <> beforeTime Then


''If AddMode = True Then
'                If IsAppExisting() = True Then
'                    MessageBox.Show("Appointment already exists", "Already Existing Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

'                Else
'                    Me.Validate()
'                    Me.OAPpointmentsBindingSource.EndEdit()
'                    Me.OAPpointmentsTableAdapter.Update(Me.MMDataDataSet1.OAPpointments)
'                End If

''Else
''    Me.Validate()
''    Me.OAPpointmentsBindingSource.EndEdit()
''    Me.OAPpointmentsTableAdapter.Update(Me.MMDataDataSet1.OAPpointments)
''End If

'            Else
'                Me.Validate()
'                Me.OAPpointmentsBindingSource.EndEdit()
'                Me.OAPpointmentsTableAdapter.Update(Me.MMDataDataSet1.OAPpointments)
'            End If


'        Catch ex As System.Exception
'            System.Windows.Forms.MessageBox.Show(ex.Message)
'        End Try

'    End Sub