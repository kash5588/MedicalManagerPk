<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BodySketch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BodySketch))
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtChartNumber = New System.Windows.Forms.TextBox
        Me.txtCaseNumber = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.radRed = New System.Windows.Forms.RadioButton
        Me.radBlue = New System.Windows.Forms.RadioButton
        Me.radGreen = New System.Windows.Forms.RadioButton
        Me.radOrange = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cboBackgroudPic = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.Location = New System.Drawing.Point(341, 470)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Location = New System.Drawing.Point(422, 470)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtChartNumber
        '
        Me.txtChartNumber.Enabled = False
        Me.txtChartNumber.Location = New System.Drawing.Point(503, 33)
        Me.txtChartNumber.Name = "txtChartNumber"
        Me.txtChartNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtChartNumber.TabIndex = 7
        '
        'txtCaseNumber
        '
        Me.txtCaseNumber.Enabled = False
        Me.txtCaseNumber.Location = New System.Drawing.Point(503, 80)
        Me.txtCaseNumber.Name = "txtCaseNumber"
        Me.txtCaseNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCaseNumber.TabIndex = 8
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(503, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Chart Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(503, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Case Number"
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(503, 128)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(503, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Date"
        '
        'radRed
        '
        Me.radRed.Appearance = System.Windows.Forms.Appearance.Button
        Me.radRed.AutoSize = True
        Me.radRed.BackColor = System.Drawing.Color.Red
        Me.radRed.Checked = True
        Me.radRed.Location = New System.Drawing.Point(526, 400)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(71, 23)
        Me.radRed.TabIndex = 13
        Me.radRed.TabStop = True
        Me.radRed.Text = "                  "
        Me.radRed.UseVisualStyleBackColor = False
        Me.radRed.Visible = False
        '
        'radBlue
        '
        Me.radBlue.Appearance = System.Windows.Forms.Appearance.Button
        Me.radBlue.AutoSize = True
        Me.radBlue.BackColor = System.Drawing.Color.Blue
        Me.radBlue.Location = New System.Drawing.Point(526, 421)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(71, 23)
        Me.radBlue.TabIndex = 14
        Me.radBlue.Text = "                  "
        Me.radBlue.UseVisualStyleBackColor = False
        Me.radBlue.Visible = False
        '
        'radGreen
        '
        Me.radGreen.Appearance = System.Windows.Forms.Appearance.Button
        Me.radGreen.AutoSize = True
        Me.radGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.radGreen.Location = New System.Drawing.Point(526, 442)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(71, 23)
        Me.radGreen.TabIndex = 15
        Me.radGreen.Text = "                  "
        Me.radGreen.UseVisualStyleBackColor = False
        Me.radGreen.Visible = False
        '
        'radOrange
        '
        Me.radOrange.Appearance = System.Windows.Forms.Appearance.Button
        Me.radOrange.AutoSize = True
        Me.radOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.radOrange.Location = New System.Drawing.Point(526, 464)
        Me.radOrange.Name = "radOrange"
        Me.radOrange.Size = New System.Drawing.Size(71, 23)
        Me.radOrange.TabIndex = 16
        Me.radOrange.TabStop = True
        Me.radOrange.Text = "                  "
        Me.radOrange.UseVisualStyleBackColor = False
        Me.radOrange.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Ivory
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(485, 457)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'cboBackgroudPic
        '
        Me.cboBackgroudPic.FormattingEnabled = True
        Me.cboBackgroudPic.Items.AddRange(New Object() {"body", "face"})
        Me.cboBackgroudPic.Location = New System.Drawing.Point(503, 175)
        Me.cboBackgroudPic.Name = "cboBackgroudPic"
        Me.cboBackgroudPic.Size = New System.Drawing.Size(100, 21)
        Me.cboBackgroudPic.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(503, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Image"
        '
        'BodySketch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 508)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboBackgroudPic)
        Me.Controls.Add(Me.radOrange)
        Me.Controls.Add(Me.radGreen)
        Me.Controls.Add(Me.radBlue)
        Me.Controls.Add(Me.radRed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtCaseNumber)
        Me.Controls.Add(Me.txtChartNumber)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BodySketch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Body Sketch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtChartNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCaseNumber As System.Windows.Forms.TextBox
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radRed As System.Windows.Forms.RadioButton
    Friend WithEvents radBlue As System.Windows.Forms.RadioButton
    Friend WithEvents radGreen As System.Windows.Forms.RadioButton
    Friend WithEvents radOrange As System.Windows.Forms.RadioButton
    Friend WithEvents cboBackgroudPic As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
