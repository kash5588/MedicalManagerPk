Imports System.Drawing.Imaging
Imports System.IO.File



Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUnZoom As System.Windows.Forms.Button
    Friend WithEvents btnZoom As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnErase As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents cboFrameNo As System.Windows.Forms.ComboBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cboFrameEdit As System.Windows.Forms.ComboBox
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents btnNormal As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picImage = New System.Windows.Forms.PictureBox
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.cboFrameEdit = New System.Windows.Forms.ComboBox
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnNormal = New System.Windows.Forms.Button
        Me.GroupBox = New System.Windows.Forms.GroupBox
        Me.cboFrameNo = New System.Windows.Forms.ComboBox
        Me.btnErase = New System.Windows.Forms.Button
        Me.btnOpen = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnUnZoom = New System.Windows.Forms.Button
        Me.btnZoom = New System.Windows.Forms.Button
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'picImage
        '
        Me.picImage.BackColor = System.Drawing.Color.Gainsboro
        Me.picImage.Location = New System.Drawing.Point(7, 32)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(1017, 640)
        Me.picImage.TabIndex = 21
        Me.picImage.TabStop = False
        '
        'ToolTip
        '
        Me.ToolTip.ShowAlways = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(27, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(26, 24)
        Me.btnSave.TabIndex = 20
        Me.ToolTip.SetToolTip(Me.btnSave, "Save File")
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(53, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 24)
        Me.btnClose.TabIndex = 35
        Me.ToolTip.SetToolTip(Me.btnClose, "Close Image")
        '
        'cboFrameEdit
        '
        Me.cboFrameEdit.Location = New System.Drawing.Point(467, 8)
        Me.cboFrameEdit.Name = "cboFrameEdit"
        Me.cboFrameEdit.Size = New System.Drawing.Size(40, 21)
        Me.cboFrameEdit.TabIndex = 36
        Me.ToolTip.SetToolTip(Me.cboFrameEdit, "Page Edited")
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(360, 8)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(27, 24)
        Me.btnEdit.TabIndex = 37
        Me.ToolTip.SetToolTip(Me.btnEdit, "Edit Mode")
        '
        'btnNormal
        '
        Me.btnNormal.Image = CType(resources.GetObject("btnNormal.Image"), System.Drawing.Image)
        Me.btnNormal.Location = New System.Drawing.Point(333, 8)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(27, 24)
        Me.btnNormal.TabIndex = 38
        Me.ToolTip.SetToolTip(Me.btnNormal, "View Mode")
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.btnNormal)
        Me.GroupBox.Controls.Add(Me.btnEdit)
        Me.GroupBox.Controls.Add(Me.cboFrameEdit)
        Me.GroupBox.Controls.Add(Me.btnClose)
        Me.GroupBox.Controls.Add(Me.cboFrameNo)
        Me.GroupBox.Controls.Add(Me.btnErase)
        Me.GroupBox.Controls.Add(Me.btnOpen)
        Me.GroupBox.Controls.Add(Me.btnPrint)
        Me.GroupBox.Controls.Add(Me.btnDelete)
        Me.GroupBox.Controls.Add(Me.btnUnZoom)
        Me.GroupBox.Controls.Add(Me.btnZoom)
        Me.GroupBox.Controls.Add(Me.btnPrevious)
        Me.GroupBox.Controls.Add(Me.btnNext)
        Me.GroupBox.Controls.Add(Me.btnSave)
        Me.GroupBox.Location = New System.Drawing.Point(0, -8)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(507, 32)
        Me.GroupBox.TabIndex = 23
        Me.GroupBox.TabStop = False
        '
        'cboFrameNo
        '
        Me.cboFrameNo.Location = New System.Drawing.Point(160, 8)
        Me.cboFrameNo.Name = "cboFrameNo"
        Me.cboFrameNo.Size = New System.Drawing.Size(40, 21)
        Me.cboFrameNo.TabIndex = 34
        '
        'btnErase
        '
        Me.btnErase.Image = CType(resources.GetObject("btnErase.Image"), System.Drawing.Image)
        Me.btnErase.Location = New System.Drawing.Point(440, 8)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(27, 24)
        Me.btnErase.TabIndex = 29
        '
        'btnOpen
        '
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.Location = New System.Drawing.Point(0, 8)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(27, 24)
        Me.btnOpen.TabIndex = 27
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(80, 8)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(27, 24)
        Me.btnPrint.TabIndex = 26
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(400, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(27, 24)
        Me.btnDelete.TabIndex = 25
        '
        'btnUnZoom
        '
        Me.btnUnZoom.Image = CType(resources.GetObject("btnUnZoom.Image"), System.Drawing.Image)
        Me.btnUnZoom.Location = New System.Drawing.Point(253, 8)
        Me.btnUnZoom.Name = "btnUnZoom"
        Me.btnUnZoom.Size = New System.Drawing.Size(27, 24)
        Me.btnUnZoom.TabIndex = 24
        '
        'btnZoom
        '
        Me.btnZoom.Image = CType(resources.GetObject("btnZoom.Image"), System.Drawing.Image)
        Me.btnZoom.Location = New System.Drawing.Point(280, 8)
        Me.btnZoom.Name = "btnZoom"
        Me.btnZoom.Size = New System.Drawing.Size(27, 24)
        Me.btnZoom.TabIndex = 23
        '
        'btnPrevious
        '
        Me.btnPrevious.Image = CType(resources.GetObject("btnPrevious.Image"), System.Drawing.Image)
        Me.btnPrevious.Location = New System.Drawing.Point(133, 8)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(27, 24)
        Me.btnPrevious.TabIndex = 22
        '
        'btnNext
        '
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(200, 8)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(27, 24)
        Me.btnNext.TabIndex = 21
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem7, Me.MenuItem10})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem6})
        Me.MenuItem1.Text = "File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.MenuItem2.Text = "Open"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MenuItem3.Text = "Save"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.MenuItem4.Text = "Close"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 3
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MenuItem6.Text = "Exit"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem8})
        Me.MenuItem7.Text = "Toolbar"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "Show"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Text = "Hide"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 2
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12})
        Me.MenuItem10.Text = "Help"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "About"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "doc1"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1047, 679)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.picImage)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fax Editor 1.0"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

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

    'Loads the .Tiff file and saves every frame as a seperate .tiff file
    Private Sub loadImage(ByVal strFilePath As String)
        picBoxSize()
        ifSaved = False
        cboFrameNo.Items.Clear()
        cboFrameEdit.Items.Clear()
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
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sets the tooltip text's
        ToolTip.SetToolTip(btnOpen, "Open Image")
        ToolTip.SetToolTip(btnSave, "Copy to")
        ToolTip.SetToolTip(btnPrint, "Print to PDF")
        ToolTip.SetToolTip(btnDelete, "Delete Page")
        ToolTip.SetToolTip(btnPrevious, "Previous Page")
        ToolTip.SetToolTip(btnNext, "Next Page")
        ToolTip.SetToolTip(cboFrameNo, "Current Page")
        ToolTip.SetToolTip(btnUnZoom, "UnZoom by 1.25%")
        ToolTip.SetToolTip(btnZoom, "Zoom by 1.25%")
        ToolTip.SetToolTip(btnErase, "Eraser")
        curF = 0
    End Sub

    'on click displays the next page
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

    'Gets the next frame number
    Private Sub nextFrame()
        If curF = totFrame - 1 Then
            btnNext.Enabled = False
            Exit Sub
        Else
            curF = curF + 1
        End If
    End Sub

    'on click displays the previous frame
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
                Dim objImage As System.Drawing.Image = objImage.FromFile(strFilePath)
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

    'on click zooms the image by 1.25 %
    Private Sub btnZoom_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoom.Click
        If checkPath() = True Then
            picImage.Width = CInt(picImage.Width * 1.25)
            picImage.Height = CInt(picImage.Height * 1.25)
        Else
            Exit Sub
        End If
    End Sub

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
    Private Sub btnErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErase.Click
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
    'Private Sub mUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picImage.MouseUp
    '    'Checks to see if the cursor is cross
    '    If Me.Cursor Is System.Windows.Forms.Cursors.Cross Then
    '        Dim img As Drawing.Image
    '        'sets the current page as image.
    '        img = Image.FromFile(strPath & curF & ".tif")

    '        Dim objBmp As New Bitmap(img, img.Width, img.Height)
    '        '   Dim objNewBmp As New Bitmap(objBmp.Width, objBmp.Height, Imaging.PixelFormat.Format16bppRgb555)

    '        Dim g As Graphics
    '        g = Graphics.FromImage(objNewBmp)
    '        'Creats a duplicate image file as bitmap format 
    '        Dim rect As Rectangle
    '        With rect
    '            .Width = img.Width
    '            .Height = img.Height
    '            .X = 0
    '            .Y = 0
    '        End With

    '        g.DrawImage(img, rect)

    '        Dim DrawRect As Rectangle
    '        'Sets the position of the mouse
    '        finishX = e.X
    '        finishY = e.Y

    '        up = New Point(finishX, finishY)
    '        'Sets the value of rectangle, x, y, width, height position
    '        DrawRect = New Rectangle(Math.Min(up.X, down.X), Math.Min(up.Y, down.Y), Math.Abs(up.X - down.X), Math.Abs(up.Y - down.Y))

    '        Dim b As SolidBrush = New SolidBrush(Color.White)
    '        g.FillRectangle(b, DrawRect)

    '        'Creates an rectagnle on the picture box for visual.
    '        g = picImage.CreateGraphics
    '        g.FillRectangle(b, DrawRect)

    '        If MsgBox("Do you want to save the change?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            '      objNewBmp.Save(strPath & curF & "s" & ".tif", Imaging.ImageFormat.Tiff)
    '            cboFrameEdit.Items.Add(curF)
    '            g.Dispose()
    '            objNewBmp.Dispose()
    '        Else
    '            g.Dispose()
    '            objNewBmp.Dispose()
    '        End If
    '    End If
    'End Sub

    'Opens selected image
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        openImage()
    End Sub

    'Opens an image to edit
    Private Sub openImage()
        If strFilePath = "" Then
            cboFrameNo.Items.Clear()
            OpenFileDialog1.ShowDialog()
            strFilePath = OpenFileDialog1.FileName.ToString

            If strFilePath = "" Then
                MsgBox("Please select an image")
                OpenFileDialog1.ShowDialog()
            Else
                MsgBox(strFilePath)
                loadImage(strFilePath)
            End If
        Else
            MsgBox("Please close the current image", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If strFilePath = "" Then
            End
        Else
            closeFile()
            disposeFrame()
            End
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveImage()
    End Sub

    'Saves the edited image
    Private Sub saveImage()
        If checkPath() = True Then

            SaveFileDialog1.AddExtension = True
            SaveFileDialog1.ShowDialog()
            strFileName = SaveFileDialog1.FileName()
            strFileName = strFileName & ".tif"

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            'Deletes the original edited pages. For example page 0.tif was edited
            'and saved as 0s.tif. Now delete the 0.tif in order rename the 
            '0s.tif file to 0.tif. Then we can package all the page numbers back to
            'one .tiff file

            Dim z As Integer
            Dim editPageCount As Integer

            editPageCount = cboFrameEdit.Items.Count

            For z = 0 To editPageCount
                If z = editPageCount Then
                    Exit For
                End If
                Dim strEditedPage As String

                strEditedPage = cboFrameEdit.Items.Item(z)
                Try
                    If objfile.Exists(strPath & strEditedPage & ".tif") Then
                        objfile.Delete(strPath & strEditedPage & ".tif")
                        objfile.Move(strPath & strEditedPage & "s" & ".tif", strPath & strEditedPage & ".tif")
                    End If
                Catch ex As Exception

                End Try
            Next

            Dim saveTif As Bitmap = New Bitmap(strPath & curF & ".tif")

            Dim myImageCodecInfo As ImageCodecInfo
            Dim myEncoder As Encoder
            Dim myEncoderParameter As EncoderParameter
            Dim myEncoderParameters As EncoderParameters

            'Get an ImageCodecInfo object that represents the TIFF codec.
            myImageCodecInfo = GetEncoderInfo("image/tiff")

            'Create an Encoder object based on the GUID
            'for the SaveFlag parameter category.
            myEncoder = Encoder.SaveFlag
            'Create an EncoderParameters object.
            'An EncoderParameters object has an array of EncoderParameter
            'objects. In this case, there is only one
            'EncoderParameter object in the array.
            myEncoderParameters = New EncoderParameters(1)

            myEncoderParameter = New EncoderParameter(myEncoder, CLng(EncoderValue.MultiFrame))
            myEncoderParameters.Param(0) = myEncoderParameter
            saveTif.Save(strFileName, myImageCodecInfo, myEncoderParameters)

            Dim i As Integer
            cboFrameNo.Items.RemoveAt(0)
            frameCount = cboFrameNo.Items.Count
            'Removes the page 1 from the combo box. otherwise first page will be
            'saved twice.
            Try
                For i = 0 To frameCount

                    pageNo = cboFrameNo.Items.Item(i)

                    If objfile.Exists(strPath & pageNo & ".tif") Then
                        Dim saveFrame As Bitmap = New Bitmap(strPath & pageNo & ".tif")

                        myEncoderParameter = New EncoderParameter(myEncoder, CLng(EncoderValue.FrameDimensionPage))
                        myEncoderParameters.Param(0) = myEncoderParameter
                        saveTif.SaveAdd(saveFrame, myEncoderParameters)
                        saveFrame.Dispose()
                    End If
                Next
            Catch ex As Exception
            End Try

            saveTif.Dispose()
            Me.Cursor = System.Windows.Forms.Cursors.Default

            MsgBox("File saved as" & strFileName)
            ifSaved = True

            If MsgBox("Do you want to close this image?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                closeFile()
            Else
                'Changes the file to newly saved file name and loads the saved file.
                strFilePath = strFileName
                isDelete = True
                loadImage(strFileName)
            End If
        Else
            Exit Sub
        End If
    End Sub

    'Deletes the saved individual frames
    Private Sub disposeFrame()
        Try
            Dim i As Integer

            frameCount = cboFrameNo.Items.Count
            For i = 0 To frameCount
                pageNo = cboFrameNo.Items.Item(i)
                If objfile.Exists(strPath & pageNo & ".tif") Then
                    objfile.Delete(strPath & pageNo & ".tif")
                End If
            Next
        Catch
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If checkPath() = True Then
            'Check to see if the cursor is in Edit mode
            If Me.Cursor Is System.Windows.Forms.Cursors.Cross Then
                MsgBox("You can not delete a page in Edit Mode. Please Change the mode to View Mode", MsgBoxStyle.Information)
                Exit Sub
            End If

            If MsgBox("Do you want to delete page" & " " & curF, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                isDelete = True
                cboFrameNo.Items.Remove(curF)
                objfile.Delete(strPath & curF & ".tif")
                nextFrame()
                DisplayFrame()
                isDelete = False
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub

    'GetEncoderInfo
    Private Shared Function GetEncoderInfo(ByVal mimeType As [String]) As ImageCodecInfo
        Dim i As Integer
        Dim encoders() As ImageCodecInfo
        encoders = ImageCodecInfo.GetImageEncoders()

        For i = 0 To (encoders.Length - 1)
            If (encoders(i).MimeType = mimeType) Then
                Return encoders(i)
            End If
        Next i
    End Function

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        closeFile()
    End Sub

    'Closes the open image file
    Private Sub closeFile()
        If checkPath() = True Then
            If ifSaved = True Then
                picImage.Image = Nothing
                isDelete = True
                strFilePath = ""
                disposeFrame()
                cboFrameNo.Items.Clear()
                cboFrameEdit.Items.Clear()
            Else
                If MsgBox("Do you want to close the image without saving?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    picImage.Image = Nothing
                    objImage.Dispose()

                    isDelete = True
                    strFilePath = ""
                    disposeFrame()
                    cboFrameNo.Items.Clear()
                    cboFrameEdit.Items.Clear()
                Else
                    Exit Sub
                End If
            End If
        Else
            Exit Sub
        End If
    End Sub

    'Checks if there is an image loaded for editing.
    Private Function checkPath() As Boolean
        If strFilePath = "" Then
            MsgBox("Select an image to edit", MsgBoxStyle.Information)
            checkPath = False
            Exit Function
        Else
            checkPath = True
        End If
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        closeFile()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        openImage()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        saveImage()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If checkPath() = True Then
            'using Acrobat.tlb
            Dim acroapp As Object
            Dim AcroExchApp As Object
            AcroExchApp = CreateObject("AcroExch.App")
            acroapp = CreateObject("AcroExch.AVDoc")

            acroapp.Open(strFilePath, "")
            AcroExchApp.show()
        End If

    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        btnErase.Hide()
        btnDelete.Hide()
        cboFrameEdit.Hide()
        btnZoom.Hide()
        btnUnZoom.Hide()
        btnEdit.Hide()
        btnNormal.Hide()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        btnErase.Show()
        btnDelete.Show()
        cboFrameEdit.Show()
        btnZoom.Show()
        btnUnZoom.Show()
        btnEdit.Show()
        btnNormal.Show()
    End Sub

    Private Sub btnNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNormal.Click
        If checkPath() = True Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            picBoxSize()
        End If
    End Sub

    Private Sub btnActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If checkPath() = True Then
            actualSize()
        End If
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim objFrm As Form2
        objFrm = New Form2()
        objFrm.Show()
    End Sub

End Class

