Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Public Class BodySketch

    Inherits System.Windows.Forms.Form
    Dim mousePath As New System.Drawing.Drawing2D.GraphicsPath() 'declare a new Graphic path to follow the mouse movement
    Dim myAlpha As Integer = 100
    Dim myUserColor As New Color()
    Dim myPenWidth As Single = 5
    Dim arrayRet(3) As String
    Dim arrayChartnumber As String
    Dim arrayCasenumber As String
    Dim arrayDate As String

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mousePath.StartFigure()
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Try
                mousePath.AddLine(e.X, e.Y, e.X, e.Y)
            Catch
                MsgBox("")
            End Try
        End If
        PictureBox1.Invalidate()

    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Try
            myUserColor = (System.Drawing.Color.Red)
            myAlpha = 250
            Dim CurrentPen = New Pen(Color.FromArgb(myAlpha, myUserColor), myPenWidth) '
            e.Graphics.DrawPath(CurrentPen, mousePath)
        Catch
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            Dim bmp As New Drawing.Bitmap(485, 457)
            PictureBox1.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
            CheckforBodySketchesFolder()
            bmp.Save("C:\BodySketches\" & txtChartNumber.Text & txtCaseNumber.Text & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Me.Close()
        Catch
            'Dim bmpsecond As New drawingBitmap(485, 457)
            'Bitmap(bm = New Bitmap(this.myBitmap))
            'bm.Save("Output\\out.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
        End Try
    End Sub

    Private Sub ClearAll()
        PictureBox1.CreateGraphics.Clear(Color.White)
        mousePath.Reset()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    Public Function ShowBodySketch(ByVal arrayRet() As String) As String()
        arrayChartnumber = arrayRet(0)
        arrayCasenumber = arrayRet(1)
        arrayDate = arrayRet(2)
        Me.ShowDialog()

    End Function

    Private Sub BodySketch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Visit2.RetrieveBodySketch()

    End Sub

    Private Sub BodySketch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtChartNumber.Text = arrayChartnumber
        txtCaseNumber.Text = arrayCasenumber
        txtDate.Text = arrayDate

        ClearAll()
        ' CheckForExistingBodySketch()
    End Sub

    Private Function CheckForExistingBodySketch()
        If File.Exists("C:\BodySketches\" & arrayChartnumber & arrayCasenumber & ".jpeg") Then
            PictureBox1.Image = Image.FromFile("C:\BodySketches\" & arrayChartnumber & arrayCasenumber & ".jpeg")
        End If
    End Function

    Private Function CheckforBodySketchesFolder()
        Dim path As String
        Dim di As System.IO.DirectoryInfo

        path = "C:\BodySketches"
        di = New System.IO.DirectoryInfo(path)

        If (Not di.Exists) Then
            di.Create()
        End If
    End Function


    Private Sub cboBackgroudPic_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBackgroudPic.SelectedIndexChanged
        If cboBackgroudPic.Text = "face" Then
            PictureBox1.BackgroundImage = My.Resources.face
        ElseIf cboBackgroudPic.Text = "body" Then
            PictureBox1.BackgroundImage = My.Resources.body
        End If
    End Sub
End Class





'###############
'## Copyright (C)    ##
'## EaK2k  2008     ##
'## All rights          ##
'## Reserved        ##
'#############
'Public Class Form1
'    Dim xStart, yStart, xEnd, yEnd As Integer
'    Dim Drawbitmap As Bitmap
'    Dim Drawgraphics As Graphics
'    Dim myPen As New Pen(Color.BlueViolet, 3)
'    Dim myColor As Color = Color.Blue
'    Dim myBrush As New Drawing.SolidBrush(Color.Red)
'    Dim myBrushWidth As Integer
'    Dim ContinuousFlag As Boolean

'    Private Sub drawMyline()
'        PictureBox1.Image = Drawbitmap
'        Drawgraphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
'        Drawgraphics.DrawLine(myPen, xStart, yStart, xEnd, yEnd)
'    End Sub

'    Private Sub savebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'        SaveFileDialog1.ShowDialog()
'        If SaveFileDialog1.FileName <> "" Then
'            FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
'            FileClose(1)
'        End If
'    End Sub

'    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Drawbitmap = New Bitmap(PictureBox1.Width, PictureBox1.Height)
'        Drawgraphics = Graphics.FromImage(Drawbitmap)
'        PictureBox1.Image = Drawbitmap
'        Drawgraphics.Clear(Color.White)
'        myBrushWidth = 4
'    End Sub
'    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
'        xStart = Control.MousePosition.X - (Me.Left + PictureBox1.Left + 4)
'        yStart = Control.MousePosition.Y - (Me.Top + PictureBox1.Top + 31)
'        'to do continuous drawing, enable this line 
'        'drawMyline()
'        If RadioButton1.Checked = True Then
'            ContinuousFlag = True
'        End If
'    End Sub

'    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
'        If ContinuousFlag Then
'            Drawgraphics.SmoothingMode = Drawing2D.SmoothingMode.None
'            Drawgraphics.FillEllipse(myBrush, e.X, e.Y, myBrushWidth, myBrushWidth)
'            PictureBox1.Image = Drawbitmap
'        End If
'    End Sub

'    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
'        xEnd = Control.MousePosition.X - (Me.Left + PictureBox1.Left + 4)
'        yEnd = Control.MousePosition.Y - (Me.Top + PictureBox1.Top + 31)

'        If RadioButton1.Checked Then
'            ContinuousFlag = False
'        Else
'            drawMyline()
'        End If
'    End Sub