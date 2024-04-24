Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class EnterChartItems
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(3) As String

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
    Dim strKeepChartnumber As String
    Dim strKeepDocType As String

    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        Dim FrmProcedure As New Procedure
        aRet = PATIENT.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab
            ChartNumberTextBox.Text = aRet(1)
        End If


    End Sub

    Private Sub MMCHARTContentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MMCHARTContentsBindingSource.EndEdit()
        Me.MMCHARTContentsTableAdapter.Update(Me.MMDataDataSet1.MMCHARTContents)

    End Sub

    Private Sub MMCHARTContentsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMCHARTContentsBindingNavigatorSaveItem.Click
        Try
            If ComboBox2.Text = "" Then
                MessageBox.Show("You must specify ""Saved As"" field.", "Saved As..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.Validate()
                Me.MMCHARTContentsBindingSource.EndEdit()
                Me.MMCHARTContentsTableAdapter.Update(Me.MMDataDataSet1.MMCHARTContents)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EnterChartItems_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim msgText As String
        Dim result As DialogResult

        Try
            If ComboBox2.Text = "" Then
                MessageBox.Show("You must specify ""Saved As"" field.", "Saved As..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            Else
                If Me.Validate Then
                    Me.MMCHARTContentsBindingSource.EndEdit()
                Else
                    e.Cancel = True
                    Return
                End If

                If Me.MMDataDataSet1.MMCHARTContents.GetChanges() IsNot Nothing Then
                    msgText = "You have made changes that have not been saved to the database."
                    result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                    Select Case result
                        Case Windows.Forms.DialogResult.Yes
                            Me.MMCHARTContentsTableAdapter.Update(Me.MMDataDataSet1.MMCHARTContents)

                        Case Windows.Forms.DialogResult.No
                            Me.MMDataDataSet1.MMCHARTContents.RejectChanges()
                        Case Else
                            e.Cancel = True
                    End Select
                End If
            End If
            'picImage.Image.Dispose()
            GC.Collect()
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Chart Contents form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try
    End Sub

    Private Sub EnterChartItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MMCHARTContentsTableAdapter.Fill(Me.MMDataDataSet1.MMCHARTContents)
        LoadFileList()
        DeleteAssignedFiles()

    End Sub

    Private Function LoadComboBoxes()
        Dim db As DBAccess = New DBAccess()
        Dim localdr As SqlClient.SqlDataReader

        localdr = db.ExecuteReader("SELECT Status from MMCombo")
        If localdr.HasRows = True Then
            While localdr.Read
                If localdr.Item(0).ToString <> "N/A" Then
                    CompleatComboBox.Items.Add(localdr.Item(0))
                End If
            End While
        End If
        localdr.Close()
    End Function

    Private Sub MMCHARTContentsBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMCHARTContentsBindingSource.AddingNew
        Me.MMDataDataSet1.MMCHARTContents.SignedColumn.DefaultValue = False
        Me.MMDataDataSet1.MMCHARTContents.DateCreatedColumn.DefaultValue = System.DateTime.Now.Date
        Me.MMDataDataSet1.MMCHARTContents.UserColumn.DefaultValue = globalUser
        Me.MMDataDataSet1.MMCHARTContents.FolderColumn.DefaultValue = "TIF"

        If chkKeepChNoandDocType.Checked Then
            Me.MMDataDataSet1.MMCHARTContents.ChartNumberColumn.DefaultValue = strKeepChartnumber.ToString
            Me.MMDataDataSet1.MMCHARTContents.DocumentTypeColumn.DefaultValue = strKeepDocType.ToString
        Else
            Me.MMDataDataSet1.MMCHARTContents.ChartNumberColumn.DefaultValue = ""
            Me.MMDataDataSet1.MMCHARTContents.DocumentTypeColumn.DefaultValue = ""

        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim objOpenFileDialog As New OpenFileDialog

        With objOpenFileDialog
            ' .Filter = "Image files (.jpg, .jpeg, .bmp, .gif)|*.jpg;*.jpeg;*.bmp;*.gif;*.png"
            .FilterIndex = 1
            .Title = "Open File Dialog"
            .InitialDirectory = "C:\"
        End With

        If objOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim strPath As String
            Try
                strPath = objOpenFileDialog.FileName
                DocumentPathTextBox.Text = strPath
            Catch fileException As Exception
                Throw fileException
            End Try
        End If
        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub

    Private Function LoadFileList()
        Try
            dgvFileList.Rows.Clear()
            Dim strFileSize As String = ""
            Dim strScansFolder As String

            Dim strValue As String
            strValue = GetGeneralInfo("ScansFolder")
            If strValue <> "" Then
                strScansFolder = strValue

            End If

            ' Dim di As New IO.DirectoryInfo("C:\Scans")
            Dim di As New IO.DirectoryInfo(strScansFolder)
            Dim aryFi As IO.FileInfo() = di.GetFiles()
            Dim fi As IO.FileInfo
            Dim FileDetails(3) As String

            For Each fi In aryFi
                If fi.Name <> "Thumbs.db" Then
                    strFileSize = (Math.Round(fi.Length / 1024)).ToString()
                    FileDetails(0) = fi.Name
                    FileDetails(1) = fi.FullName
                    FileDetails(2) = fi.Extension
                    FileDetails(3) = strFileSize & " KB"
                    dgvFileList.Rows.Add(FileDetails)
                End If
            Next
        Catch
        End Try
    End Function

    Private Sub dgvFileList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvFileList.DoubleClick
        Dim strFilePathUnassigned As String
        Dim strFilePathCopyUnassigned As String
        Dim strFileAssigned As String
        Dim fi As IO.FileInfo
        Try
            If ChartNumberTextBox.Text = "" Then
                MessageBox.Show("Select a patient")
            Else
                CheckForFolder()
                strFilePathUnassigned = dgvFileList.SelectedRows(0).Cells("FilePath").Value.ToString()
                strFilePathCopyUnassigned = IO.Path.GetDirectoryName(strFilePathUnassigned) & "\" & ChartNumberTextBox.Text & "~" & IO.Path.GetFileName(strFilePathUnassigned)
                strFileAssigned = IO.Path.GetDirectoryName(strFilePathUnassigned) & "Assigned\" & ChartNumberTextBox.Text & "~" & IO.Path.GetFileName(strFilePathUnassigned)

                fi = New IO.FileInfo(strFilePathUnassigned)
                fi.CopyTo(strFilePathCopyUnassigned)
                System.IO.File.Move(strFilePathCopyUnassigned, strFileAssigned)
                DocumentPathTextBox.Text = strFileAssigned
                dgvFileList.SelectedRows(0).DefaultCellStyle.BackColor = Color.DimGray
                'picImage.Dispose()
                'picImage = Nothing
                GC.Collect()
                Me.Validate()
                Me.MMCHARTContentsBindingSource.EndEdit()
                Me.MMCHARTContentsTableAdapter.Update(Me.MMDataDataSet1.MMCHARTContents)

                'System.IO.File.Delete(strFilePathUnassigned)
                'LoadFileList()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvFileList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvFileList.SelectionChanged
        Try
            If dgvFileList.SelectedRows.Count Then
                If dgvFileList.SelectedRows(0).Cells("FileExt").Value.ToString.ToLower.TrimEnd() = ".tif" Then
                    If (dgvFileList.SelectedRows(0).Cells("FilePath").Value) <> "" Then
                        strFilePath = dgvFileList.SelectedRows(0).Cells("FilePath").Value.ToString
                        openImage(strFilePath)
                    End If

                ElseIf dgvFileList.SelectedRows(0).Cells("FileExt").Value.ToString.ToLower.TrimEnd() = ".tiff" Then
                    If (dgvFileList.SelectedRows(0).Cells("FilePath").Value) <> "" Then
                        strFilePath = dgvFileList.SelectedRows(0).Cells("FilePath").Value.ToString
                        openImage(strFilePath)
                    End If


                ElseIf dgvFileList.SelectedRows(0).Cells("FileExt").Value.ToString.ToLower.TrimEnd() = ".jpg" Then
                    If (dgvFileList.SelectedRows(0).Cells("FilePath").Value) <> "" Then
                        strFilePath = dgvFileList.SelectedRows(0).Cells("FilePath").Value.ToString
                        picImage.Image = Image.FromFile(dgvFileList.SelectedRows(0).Cells("FilePath").Value)
                    End If

                ElseIf dgvFileList.SelectedRows(0).Cells("FileExt").Value.ToString.ToLower.TrimEnd() = ".gif" Then
                    If (dgvFileList.SelectedRows(0).Cells("FilePath").Value) <> "" Then
                        strFilePath = dgvFileList.SelectedRows(0).Cells("FilePath").Value.ToString
                        picImage.Image = Image.FromFile(dgvFileList.SelectedRows(0).Cells("FilePath").Value)
                    End If

                Else
                    picImage.Image = Nothing
                    MessageBox.Show(dgvFileList.SelectedRows(0).Cells("FileExt").Value.ToString.ToLower.TrimEnd() & " is not a supported file type.", "", MessageBoxButtons.OK)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "error dgvFileList_SelectionChanged")
        End Try

    End Sub

    Private Sub openImage(ByVal strFilePath As String)
        'If strFilePath = "" Then
        '    cboFrameNo.Items.Clear()
        '    'OpenFileDialog1.ShowDialog()
        ' strFilePath = dgvFileList.SelectedRows(0).Cells("FilePath").Value.ToString

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
            lblTotal.Text = "/ " & totFrame.ToString
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

    Private Sub picBoxSize()
        picImage.Width = 637
        picImage.Height = 658
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

    Private Function checkPath() As Boolean
        If strFilePath = "" Then
            MsgBox("Select an image to edit", MsgBoxStyle.Information)
            checkPath = False
            Exit Function
        Else
            checkPath = True
        End If
    End Function

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

    Private Sub btnUnZoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnZoom.Click
        If checkPath() = True Then
            picImage.Width = CInt(picImage.Width / 1.25)
            picImage.Height = CInt(picImage.Height / 1.25)
        Else
            Exit Sub
        End If
    End Sub

    Private Function CheckForFolder()
        'Dim path As String
        'Dim di As System.IO.DirectoryInfo

        'path = "C:\ScansAssigned"
        'di = New System.IO.DirectoryInfo(path)

        'If (Not di.Exists) Then
        '    di.Create()
        'End If


        Dim path As String
        Dim di As System.IO.DirectoryInfo


        Dim strValue As String
        strValue = GetGeneralInfo("ScansAssigned")
        If strValue <> "" Then
            path = strValue
        Else
            path = "C:\ScansAssigned"
        End If


        '  path = "C:\ScansAssigned"
        di = New System.IO.DirectoryInfo(path)

        If (Not di.Exists) Then
            di.Create()
        End If
    End Function

    Private Function DeleteAssignedFiles()

        Try

            Dim strFileSize As String = ""
            Dim strAssignedFileSize As String = ""
            Dim strScansFolder As String
            Dim strScansAssignedFolder As String

            Dim strValue As String
            strValue = GetGeneralInfo("ScansFolder")

            If strValue <> "" Then
                strScansFolder = strValue
            Else
                MessageBox.Show("No folder for scans is present")
                Exit Function
            End If

            Dim strValue2 As String
            strValue2 = GetGeneralInfo("ScansAssigned")

            If strValue2 <> "" Then
                strScansAssignedFolder = strValue2
            Else
                MessageBox.Show("No folder for assigned scans is present")
                Exit Function
            End If




            ' Dim di As New IO.DirectoryInfo("C:\Scans")
            Dim di As New IO.DirectoryInfo(strScansFolder)
            Dim aryFi As IO.FileInfo() = di.GetFiles()
            Dim fi As IO.FileInfo
            Dim FileDetails(3) As String

            Dim diAssigned As New IO.DirectoryInfo(strScansAssignedFolder)
            Dim aryFiAssigned As IO.FileInfo() = diAssigned.GetFiles()
            Dim fiAssigned As IO.FileInfo
            Dim FileDetailsAssigned(3) As String

            For Each fi In aryFi
                If fi.Name <> "Thumbs.db" Then
                    strFileSize = (Math.Round(fi.Length / 1024)).ToString()


                    For Each fiAssigned In aryFiAssigned
                        Dim strAssignedFileName As String
                        Dim strInitialFileName As String
                        strAssignedFileSize = (Math.Round(fi.Length / 1024)).ToString()
                        strAssignedFileName = fiAssigned.Name
                        strInitialFileName = fi.Name
                        If strInitialFileName.Contains("~") Then
                            Dim index2 As Integer
                            index2 = strInitialFileName.LastIndexOf("~")
                            strInitialFileName = strInitialFileName.Substring(index2 + 1)
                        End If
                    
                        Dim index As Integer
                        index = strAssignedFileName.LastIndexOf("~")

                        If index <> -1 Then
                            strAssignedFileName = strAssignedFileName.Substring(index + 1)
                            'If fi.Name = strAssignedFileName Then
                            If strInitialFileName = strAssignedFileName Then

                                If strFileSize = strAssignedFileSize Then
                                    System.IO.File.Delete(fi.FullName)
                                End If
                            End If
                        End If
                    Next

                End If
            Next
            LoadFileList()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Unable to delete file(s)")
        End Try
    End Function

    Private Sub tsbtnDeleteAssignedFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnDeleteAssignedFiles.Click
        DeleteAssignedFiles()
    End Sub

    Private Sub chkKeepChNoandDocType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKeepChNoandDocType.CheckedChanged
       
    End Sub

 
    Private Sub MMCHARTContentsDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMCHARTContentsDataGridView.SelectionChanged
        Try
            If MMCHARTContentsDataGridView.SelectedRows.Count Then
                If MMCHARTContentsDataGridView.SelectedRows(0).Cells("Folder").Value.ToString.ToLower.TrimEnd() = "tif" Then
                    If (MMCHARTContentsDataGridView.SelectedRows(0).Cells("DocumentPath").Value) <> "" Then
                        strFilePath = MMCHARTContentsDataGridView.SelectedRows(0).Cells("DocumentPath").Value.ToString
                        openImage(strFilePath)
                    End If

                ElseIf MMCHARTContentsDataGridView.SelectedRows(0).Cells("Folder").Value.ToString.ToLower.TrimEnd() = "tiff" Then
                    If (MMCHARTContentsDataGridView.SelectedRows(0).Cells("DocumentPath").Value) <> "" Then
                        strFilePath = MMCHARTContentsDataGridView.SelectedRows(0).Cells("DocumentPath").Value.ToString
                        openImage(strFilePath)
                    End If


                ElseIf MMCHARTContentsDataGridView.SelectedRows(0).Cells("Folder").Value.ToString.ToLower.TrimEnd() = "image" Then
                    If (MMCHARTContentsDataGridView.SelectedRows(0).Cells("DocumentPath").Value) <> "" Then
                        strFilePath = MMCHARTContentsDataGridView.SelectedRows(0).Cells("DocumentPath").Value.ToString
                        picImage.Image = Image.FromFile(MMCHARTContentsDataGridView.SelectedRows(0).Cells("DocumentPath").Value)
                    End If



                Else
                    picImage.Image = Nothing
                    MessageBox.Show(MMCHARTContentsDataGridView.SelectedRows(0).Cells("Folder").Value.ToString.ToLower.TrimEnd() & " is not a supported file type.", "", MessageBoxButtons.OK)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "error dgvFileList_SelectionChanged")
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        If chkKeepChNoandDocType.Checked = True Then
            If ChartNumberTextBox.Text <> "" Then
                strKeepChartnumber = ChartNumberTextBox.Text
                strKeepDocType = ComboBox1.Text
            Else
                MessageBox.Show("First select a patient to store.")
                chkKeepChNoandDocType.Checked = False
            End If
        End If
    End Sub

 
End Class