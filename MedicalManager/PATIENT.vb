Imports System.Data.SqlClient
Imports System.IO
Public Class PATIENT
    Dim adding As Boolean
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(8) As String
    Dim arrayAssignedProvider(0) As String
    Dim ChartNumber As String
    Dim FromShowPickList As Boolean = False



    Public Function ShowPicklist() As String()
        FromShowPickList = True
        Dim aRet(7) As String
        ' On Error GoTo EH
        aRet(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()
        If mbSelected Then
            aRet(0) = "Y"
            aRet(1) = dgPatient.SelectedRows(0).Cells(1).Value & ""
            aRet(2) = dgPatient.SelectedRows(0).Cells(2).Value & ""
            aRet(3) = dgPatient.SelectedRows(0).Cells(3).Value & ""
            aRet(4) = dgPatient.SelectedRows(0).Cells(4).Value & ""
            aRet(5) = dgPatient.SelectedRows(0).Cells(10).Value & ""
            aRet(6) = dgPatient.SelectedRows(0).Cells(11).Value & ""
            ' aRet(8) = dgPatient.SelectedRows(0).Cells(19).Value & ""
            Try
                aRet(7) = dgPatient.SelectedRows(0).Cells(18).Value
            Catch
                aRet(7) = "01/01/1889"
            End Try
        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub dgProcedure_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPatient.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub

    Public Function ShowPatient(ByVal ChNo As String) As String()
        ChartNumber = ChNo
        Me.Show()
    End Function
    Private Sub cmdIns1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Insurence As New Insurence
        aRet = Insurence.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked the value
            InsCoIdTextBox.Text = aRet(1)
            InsCoNameTextBox.Text = aRet(2)

        End If
    End Sub
    Private Sub cmdIns2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Insurence As New Insurence

        aRet = Insurence.ShowPicklist
        If aRet(0) = "Y" Then       ' hey picked the value
            InsCoId2TextBox.Text = aRet(1)
            InsCoName2TextBox.Text = aRet(2)

        End If
    End Sub
    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        Try
            If cmbFilter.Text <> "" Then
                Me.MMPATIENTBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
            End If

            Me.MMPATIENTBindingSource.Sort = "ChartNumber"
            dgPatient.DataSource = Me.MMPATIENTBindingSource
        Catch
        End Try
    End Sub

    Private Sub MMPATIENTBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMPATIENTBindingSource.AddingNew
        Me.MMDataDataSet1.MMPATIENT.SignatureonFileColumn.DefaultValue = True
        Me.MMDataDataSet1.MMPATIENT.PatientTypeColumn.DefaultValue = "PATIENT"
        Me.MMDataDataSet1.MMPATIENT.DateCreatedColumn.DefaultValue = System.DateTime.Now()
        Me.MMDataDataSet1.MMPATIENT.AssignedProviderColumn.DefaultValue = GetGeneralInfo("DefaultDoctorCode")
    End Sub

    Private Sub MMPATIENTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMPATIENTBindingNavigatorSaveItem.Click
        Me.Cursor = Cursors.WaitCursor
        DateChangedTextBox.Text = System.DateTime.Now()
        'If FirstNameTextBox.Text.Trim.Length = 0 Or LastNameTextBox.Text.Trim.Length = 0 Then
        '    MessageBox.Show("Enter both First and Last Nammes")
        'End If

        'If LastNameTextBox.Text.Trim.Length > 0 And FirstNameTextBox.Text.Trim.Length > 0 And ChartNumberTextBox.Text.Trim.Length = 0 Then
        '    ChartNumberTextBox.Text = LastNameTextBox.Text.Substring(0, 3) + FirstNameTextBox.Text.Substring(0, 2) + "000"
        'End If
        GenerateChartNumber()
        'If LastNameTextBox.Text.Trim.Length > 0 And FirstNameTextBox.Text.Trim.Length > 0 And ChartNumberTextBox.Text.Trim.Length > 0 Then
        '    If LastNameTextBox.Text.Substring(0, 3) + FirstNameTextBox.Text.Substring(0, 2) <> ChartNumberTextBox.Text.Trim.Substring(0, 5) Then
        '        MsgBox("Chart Number should be first 3 Characters of Last Name and First 2 Characters of first name + 3 dig seq")
        '    End If
        'End If
        'If ChartNumberTextBox.Text.Trim.Length < 8 Then
        '    ErrorProvider1.SetError(ChartNumberTextBox, "Chart Number Must be 8 Characters")
        '    MsgBox("Chart Number Must be 8 Characters")
        'End If

        'If LastNameTextBox.Text.Trim.Length = 0 Then
        '    ErrorProvider1.SetError(LastNameTextBox, "Please enter the Last Name")
        'Else
        '    ErrorProvider1.SetError(LastNameTextBox, "")
        'End If



        Try
            Me.Validate()
            Me.MMDataDataSet1.MMPATIENT.DateofBirthColumn.DefaultValue = System.DBNull.Value
            Me.MMPATIENTBindingSource.EndEdit()
            If Me.Validate Then
                Me.MMPATIENTTableAdapter.Update(Me.MMDataDataSet1.MMPATIENT)
            End If
            Me.Cursor = Cursors.Default
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message, "MMPATIENT_Save", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Private Sub PATIENT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    '    'SET forms KEYPREVIEW = TRUE

    '    If KeyCode = vbKeyReturn Then
    '        SendKeys("{TAB}")
    '    End If
    'End Sub

    'End Sub

    Private Sub MMPATIENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        'TODO: This line of code loads data into the 'MMDataDataSet2.PatientPictures' table. You can move, or remove it, as needed.
        Me.PatientPicturesTableAdapter.Fill(Me.MMDataDataSet2.PatientPictures)
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMCombo' table. You can move, or remove it, as needed.
        Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
        Dim hiddenTab As TabPage = TabControl1.TabPages(3)
        TabControl1.TabPages.Remove(hiddenTab)
        'Try
        If ChartNumber <> "" Then
            Me.MMPATIENTTableAdapter.FillByChartNumber(Me.MMDataDataSet1.MMPATIENT, ChartNumber)
            TabControl1.SelectedIndex = 1
            Me.PatientPicturesTableAdapter.FillByChartNumber(Me.MMDataDataSet2.PatientPictures, ChartNumber)
        Else
            Me.MMPATIENTTableAdapter.Fill(Me.MMDataDataSet1.MMPATIENT)
        End If
        cmbFilter.SelectedIndex = 0
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        If PatientID_2TextBox.Text <> "" Then
            PatientID_2TextBox.Enabled = False
        Else
            PatientID_2TextBox.Enabled = True
        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "MMPATIENT_Load", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'End Try

        LoadComboBoxes2()
        Me.Text = ChartNumberTextBox.Text + " " + LastNameTextBox.Text + ", " + FirstNameTextBox.Text

    End Sub

    Private Sub cmdEmployer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Employer As New Employer
        aRet = Employer.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked vale
            EmployerCodeTextBox.Text = aRet(1)
            EmployerTextBox.Text = aRet(2)
            EmployerPhoneMaskedTextBox.Text = aRet(3)

        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        TabControl1.SelectedTab = TabControl1.TabPages(1)
        FirstNameTextBox.Focus()
        Me.Text = "Patient" ' ChartNumberTextBox.Text + " " + LastNameTextBox.Text + " ," + FirstNameTextBox.Text
    End Sub


    Private Sub ChartNumberTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ChartNumberTextBox.Validating
        If ChartNumberTextBox.Text.Trim.Length = 0 Then
            ErrorProvider1.SetError(ChartNumberTextBox, "Please enter the Chart Number")
        Else
            ErrorProvider1.SetError(ChartNumberTextBox, "")
        End If
    End Sub


    Private Sub FirstNameTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles FirstNameTextBox.Validating

        If FirstNameTextBox.Text.Trim.Length < 2 Then
            ErrorProvider1.SetError(FirstNameTextBox, "Please enter the First Name")
        Else
            ErrorProvider1.SetError(FirstNameTextBox, "")
        End If
    End Sub

    Private Sub LastNameTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LastNameTextBox.Validating

        If LastNameTextBox.Text.Trim.Length < 3 Then
            ErrorProvider1.SetError(LastNameTextBox, "Please enter the Last Name")
        Else
            ErrorProvider1.SetError(LastNameTextBox, "")
        End If
    End Sub

    'Private Sub PATIENT_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating
    '    If LastNameTextBox.Text.Trim.Length > 0 And FirstNameTextBox.Text.Trim.Length > 0 And ChartNumberTextBox.Text.Trim.Length = 0 Then
    '        ChartNumberTextBox.Text = LastNameTextBox.Text.Substring(0, 3) + FirstNameTextBox.Text.Substring(0, 2) + "000"
    '    End If
    '    If LastNameTextBox.Text.Trim.Length > 0 And FirstNameTextBox.Text.Trim.Length > 0 And ChartNumberTextBox.Text.Trim.Length > 0 Then
    '        If LastNameTextBox.Text.Substring(0, 3) + FirstNameTextBox.Text.Substring(0, 2) <> ChartNumberTextBox.Text.Trim.Substring(0, 5) Then
    '            MsgBox("Chart Number should be first 3 Characters of Last Name and First 2 Characters of first name + 3 dig seq")
    '        End If
    '    End If
    '    If ChartNumberTextBox.Text.Trim.Length < 8 Then
    '        ErrorProvider1.SetError(ChartNumberTextBox, "Chart Number Must be 8 Characters")
    '        MsgBox("Chart Number Must be 8 Characters")
    '    End If

    '    If LastNameTextBox.Text.Trim.Length = 0 Then
    '        ErrorProvider1.SetError(LastNameTextBox, "Please enter the Last Name")
    '    Else
    '        ErrorProvider1.SetError(LastNameTextBox, "")
    '    End If
    'End Sub




    'Private Sub LastNameTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LastNameTextBox.Validating
    '    If LastNameTextBox.Text.Trim.Length > 0 And FirstNameTextBox.Text.Trim.Length > 0 And ChartNumberTextBox.Text.Trim.Length = 0 Then
    '        ChartNumberTextBox.Text = LastNameTextBox.Text.Substring(0, 3) + FirstNameTextBox.Text.Substring(0, 2) + "000"
    '    End If
    '    If LastNameTextBox.Text.Trim.Length > 0 And FirstNameTextBox.Text.Trim.Length > 0 And ChartNumberTextBox.Text.Trim.Length > 0 Then
    '        If LastNameTextBox.Text.Substring(0, 3) + FirstNameTextBox.Text.Substring(0, 2) <> ChartNumberTextBox.Text.Trim.Substring(0, 5) Then
    '            MsgBox("Chart Number should be first 3 Characters of Last Name and First 2 Characters of first name + 3 dig seq")
    '        End If
    '    End If
    '    If ChartNumberTextBox.Text.Trim.Length < 8 Then
    '        ErrorProvider1.SetError(ChartNumberTextBox, "Chart Number Must be 8 Characters")
    '        MsgBox("Chart Number Must be 8 Characters")
    '    End If

    '    If LastNameTextBox.Text.Trim.Length = 0 Then
    '        ErrorProvider1.SetError(LastNameTextBox, "Please enter the Last Name")
    '    Else
    '        ErrorProvider1.SetError(LastNameTextBox, "")
    '    End If
    'End Sub

    Private Sub PATIENT_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.MMPATIENTBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            ' See if any changes were made, but not saved 
            If Me.MMDataDataSet1.MMPATIENT.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                'msgText = msgText & ControlChars.CrLf & _
                '"If you have deleted students, deleting them from the database will delete all courses and grades for the student."
                'msgText = msgText & ControlChars.CrLf & "Save the changes ?"

                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.MMPATIENTTableAdapter.Update(Me.MMDataDataSet1.MMPATIENT)

                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.MMPATIENT.RejectChanges()

                    Case Else
                        ' do nothing and cancel closing of the form
                        e.Cancel = True

                End Select
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Patient form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try

    End Sub

    'Private Function LoadComboBoxes()
    '    Dim db As DBAccess = New DBAccess()
    '    Dim localdr As SqlClient.SqlDataReader
    '    Try
    '        localdr = db.ExecuteReader("SELECT MaritalStatus from MMCombo")
    '        If localdr.HasRows = True Then
    '            While localdr.Read
    '                If localdr.Item(0).ToString <> "N/A" Then
    '                    MstatusComboBox.Items.Add(localdr.Item(0))
    '                End If
    '            End While
    '        End If
    '        localdr.Close()


    '        localdr = db.ExecuteReader("SELECT PatientType from MMCombo")
    '        If localdr.HasRows = True Then
    '            While localdr.Read
    '                If localdr.Item(0).ToString <> "N/A" Then
    '                    PatientTypeComboBox.Items.Add(localdr.Item(0))
    '                End If
    '            End While
    '        End If
    '        localdr.Close()

    '        localdr = db.ExecuteReader("SELECT EmploymentStatus from MMCombo")
    '        If localdr.HasRows = True Then
    '            While localdr.Read
    '                If localdr.Item(0).ToString <> "N/A" Then
    '                    EmploymentStatusComboBox.Items.Add(localdr.Item(0))
    '                End If
    '            End While
    '        End If
    '        localdr.Close()

    '        localdr = db.ExecuteReader("SELECT Race from MMCombo")
    '        If localdr.HasRows = True Then
    '            While localdr.Read
    '                If localdr.Item(0).ToString <> "N/A" Then
    '                    RaceComboBox.Items.Add(localdr.Item(0))
    '                End If
    '            End While
    '        End If
    '        localdr.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString)
    '    End Try
    'End Function

    Private Function LoadComboBoxes2()

        Dim dr As DataRow

        Dim dt As DataTable
        dt = Me.MMDataDataSet1.Tables("MMCombo")

        For Each dr In dt.Rows
            If dr("MaritalStatus") <> "N/A" Then
                MstatusComboBox.Items.Add(dr("MaritalStatus"))
            End If
        Next

        'For Each dr In dt.Rows
        '    If dr("Race") <> "N/A" Then
        '        RaceComboBox.Items.Add(dr("Race"))
        '    End If
        'Next

        For Each dr In dt.Rows
            If dr("PatientType") <> "N/A" Then
                PatientTypeComboBox.Items.Add(dr("PatientType"))
            End If
        Next


        For Each dr In dt.Rows
            If dr("EmploymentStatus") <> "N/A" Then
                EmploymentStatusComboBox.Items.Add(dr("EmploymentStatus"))
            End If
        Next

        For Each dr In dt.Rows
            If dr("PhysicianOffice") <> "N/A" Then
                PhysicianOfficeComboBox.Items.Add(dr("PhysicianOffice"))
            End If
        Next

    End Function




    Private Sub btnPhysician_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhysician.Click
        Dim PriPhysician As New Physician
        'aRet = frmCustomers.ShowPicklist
        ' frmCustomers.ShowDialog()
        aRet = PriPhysician.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab
            'AssignedProviderTextBox.Text = aRet(1) 'Pick Code Of Physician

            AssignedProviderTextBox.Text = aRet(3) + " " + aRet(2) 'Pick Name Of Physician

            'RefPhysicianTextBox.Text = aRet(3) + " " + aRet(2)
            '  LastNameTextBox.Text = aRet(3) + " " + aRet(2)
            '  FirstNameTextBox.Text = aRet(3)
            ' DOBTextBox.Text = aRet(6)
            'DOBTextBox.Text = aRet(6)
        End If
    End Sub




    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        Dim imagePath As String

        Using objOpenFileDialog As New OpenFileDialog()
            With objOpenFileDialog
                .Filter = "Image files (.jpg, .jpeg, .bmp, .gif, .png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png"
                .FilterIndex = 1
                .Title = "Open File Dialog"
                .InitialDirectory = "C:\"
            End With

            If objOpenFileDialog.ShowDialog() = DialogResult.OK Then
                imagePath = objOpenFileDialog.FileName
                Try
                    ' Load the image and display it in the PictureBox
                    Dim originalImage As Image = Image.FromFile(imagePath)
                    Me.PictureBox1.Image = originalImage
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    ' Save the image path to the database
                    SaveToDatabase(imagePath)
                Catch fileException As Exception
                    MessageBox.Show("An error occurred while loading the image: " & fileException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using






        'Dim objOpenFileDialog As New OpenFileDialog

        'With objOpenFileDialog
        '    .Filter = "Image files (.jpg, .jpeg, .bmp, .gif)|*.jpg;*.jpeg;*.bmp;*.gif;*.png"
        '    .FilterIndex = 1
        '    .Title = "Open File Dialog"
        '    .InitialDirectory = "C:\"
        'End With

        'If objOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Dim allText As String
        '    Try
        '        'Read the contents of the file
        '        allText = objOpenFileDialog.FileName
        '        'Display the file contents in the TextBox
        '        System.Console.WriteLine(allText)
        '        Dim originalimage As System.Drawing.Image
        '        originalimage = Image.FromFile(allText)
        '        Me.PictureBox1.Image = originalimage
        '        SaveToDatabase(allText)
        '    Catch fileException As Exception
        '        Throw fileException
        '    End Try
        'End If

        'objOpenFileDialog.Dispose()
        'objOpenFileDialog = Nothing
    End Sub

    Private Function SaveToDatabase(ByVal allText As String)

        Dim connString As String = connString2
        Dim con As New SqlConnection(connString)

        Dim da As New SqlDataAdapter("Select * From PatientPictures", con)
        Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
        Dim ds As New DataSet()

        da.MissingSchemaAction = MissingSchemaAction.AddWithKey

        Dim fs As New FileStream(allText, FileMode.OpenOrCreate, FileAccess.Read)
        Dim MyData(fs.Length) As Byte
        fs.Read(MyData, 0, fs.Length)
        fs.Close()
        con.Open()
        da.Fill(ds, "PatientPictures")
        Dim myRow As DataRow
        myRow = ds.Tables("PatientPictures").NewRow()

        myRow("ChartNumber") = ChartNumberTextBox.Text
        myRow("PictureImage") = MyData
        ds.Tables("PatientPictures").Rows.Add(myRow)
        da.Update(ds, "PatientPictures")

        fs = Nothing
        MyCB = Nothing
        ds = Nothing
        da = Nothing

        con.Close()
        con = Nothing
        'MsgBox("Image saved to database")
    End Function

    Private Sub btnDeletePatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Dim connString As String
        Dim cn As SqlConnection


        Try
            sAction = "DeleteAuthorization"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User not authorized to delete patients.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If MessageBox.Show("Are you sure you want to delete " & FirstNameTextBox.Text & " " & LastNameTextBox.Text & " from your patient records?" & Environment.NewLine & "Deleting patients may cause undesired consequenses.", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Sub
            End If

            connString = connString2
            cn = New SqlConnection(connString)
            cn.Open()

            Dim cmd As New SqlCommand("Delete from MMPATIENT where PatientID = '" & PatientIDTextBox.Text & "'", cn)

            cmd.ExecuteNonQuery()

            cn.Close()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonCancel.Click
        Me.MMPATIENTBindingSource.CancelEdit()
        Me.Close()
    End Sub


    Private Sub PATIENT_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            If FromShowPickList = True Then
                txtFind.Focus()
            End If
        Catch
        End Try
    End Sub

    Private Function GenerateChartNumber() As String

        If LastNameTextBox.Text.Trim.Length > 0 And FirstNameTextBox.Text.Trim.Length > 0 And ChartNumberTextBox.Text.Trim.Length = 0 Then
            Dim i As Integer
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()

            Dim cmd As New SqlCommand
            Dim blnExists As Boolean = True
            Dim chartnumber As String = ""

            Do Until blnExists = False
                chartnumber = LastNameTextBox.Text.Substring(0, 3) + FirstNameTextBox.Text.Substring(0, 2) & i.ToString.PadLeft(3, "0")
                i += 1
                cmd = New SqlCommand("SELECT ChartNumber FROM MMPatient where chartnumber = '" & chartnumber & "'", cn)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                blnExists = False
                While dr.Read
                    blnExists = True
                End While
                dr.Close()
            Loop
            ChartNumberTextBox.Text = chartnumber
            cn.Close()
        End If

    End Function

    Private Sub ZipCodeTextBox_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try
            If ZipCodeTextBox.Text.Length = 5 Then
                Dim strCity As String
                Dim strState As String
                Dim strValue As String
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                Dim cmd As New SqlCommand
                cmd = New SqlCommand("SELECT city, state  FROM zipcode where zipcode = '" & ZipCodeTextBox.Text & "'", cn)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                dr.Read()
                strCity = dr("City").ToString
                strState = dr("State").ToString
                dr.Close()
                cn.Close()
                If CityTextBox.Text = "" Then
                    CityTextBox.Text = strCity
                End If
                If StateTextBox.Text = "" Then
                    StateTextBox.Text = strState
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub dgPatient_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPatient.CellContentClick

    End Sub

    Private Sub BtnSaveAndVisit_Click(sender As Object, e As EventArgs) Handles BtnSaveAndVisit.Click
        If FirstNameTextBox.Text <> "" Then



            Me.Cursor = Cursors.WaitCursor
            DateChangedTextBox.Text = System.DateTime.Now()


            Me.Validate()
            Me.MMDataDataSet1.MMPATIENT.DateofBirthColumn.DefaultValue = System.DBNull.Value
            Me.MMPATIENTBindingSource.EndEdit()
            If Me.Validate Then
                Me.MMPATIENTTableAdapter.Update(Me.MMDataDataSet1.MMPATIENT)
            End If
            Me.Cursor = Cursors.Default

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

                arrayAssignedProvider(0) = AssignedProviderTextBox.Text
                Me.Hide()
                HealthHistory.ShowHistory(aRet, arrayAssignedProvider)
                Me.Close() ' Close after history is shown if needed

            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub BtnSaveAndHistory_Click(sender As Object, e As EventArgs) Handles BtnSaveAndHistory.Click
        If FirstNameTextBox.Text <> "" Then



            Me.Cursor = Cursors.WaitCursor
            DateChangedTextBox.Text = System.DateTime.Now()

            Try
                GenerateChartNumber()
                Me.Validate()
                Me.MMDataDataSet1.MMPATIENT.DateofBirthColumn.DefaultValue = System.DBNull.Value
                Me.MMPATIENTBindingSource.EndEdit()
                If Me.Validate Then
                    Me.MMPATIENTTableAdapter.Update(Me.MMDataDataSet1.MMPATIENT)
                End If
                Me.Cursor = Cursors.Default
                aRet(0) = "Y"
                aRet(1) = ChartNumberTextBox.Text.Trim()  'chartnumber
                aRet(2) = LastNameTextBox.Text.Trim() 'last name
                aRet(3) = FirstNameTextBox.Text.Trim()  'first name
                'aRet(4) = dgPatient.SelectedRows(0).Cells("MiddleInitial").Value & ""    'middle initial
                If CellPhoneMaskedTextBox.Text = "    -" Then
                    aRet(5) = ""
                Else
                    aRet(5) = CellPhoneMaskedTextBox.Text.Trim()   'phone
                End If

                aRet(6) = MaskedTextBoxDob.Text.Trim()    'DOB
                aRet(7) = CBSex.Text.Trim()

                Dim pieces() As String
                Dim IndexOf As Integer
                Dim sAction As String

                sAction = "FormHealthHistory"
                pieces = Permissions.Split(",")
                IndexOf = Array.IndexOf(pieces, sAction)

                If IndexOf <> -1 Then
                Else
                    MessageBox.Show("User is not authorized for this procedure.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                arrayAssignedProvider(0) = AssignedProviderTextBox.Text

                Me.Hide()
                HealthHistory.ShowHistory(aRet, arrayAssignedProvider)
                Me.Close() ' Close after history is shown if needed

            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
End Class


