<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorInbox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSEX = New System.Windows.Forms.TextBox
        Me.txtDOB = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.ChartNo = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GradientNavigationButton3 = New Ascend.Windows.Forms.GradientNavigationButton
        Me.cmdtestorders = New Ascend.Windows.Forms.GradientNavigationButton
        Me.cmdNotes = New Ascend.Windows.Forms.GradientNavigationButton
        Me.CmdMessages = New Ascend.Windows.Forms.GradientNavigationButton
        Me.cmdVitalSigns = New Ascend.Windows.Forms.GradientNavigationButton
        Me.cmdMedications = New Ascend.Windows.Forms.GradientNavigationButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.InboxDataGridView = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GradientAnimation1 = New Ascend.Windows.Forms.GradientAnimation
        Me.GradientCaption2 = New Ascend.Windows.Forms.GradientCaption
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.InboxDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientAnimation1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GradientNavigationButton3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdtestorders)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdNotes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CmdMessages)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdVitalSigns)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmdMedications)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GradientAnimation1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1237, 557)
        Me.SplitContainer1.SplitterDistance = 219
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSEX)
        Me.GroupBox1.Controls.Add(Me.txtDOB)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.ChartNo)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 153)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ph No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ch No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "DOB"
        '
        'txtSEX
        '
        Me.txtSEX.Location = New System.Drawing.Point(48, 115)
        Me.txtSEX.Name = "txtSEX"
        Me.txtSEX.Size = New System.Drawing.Size(74, 20)
        Me.txtSEX.TabIndex = 4
        '
        'txtDOB
        '
        Me.txtDOB.AcceptsReturn = True
        Me.txtDOB.Location = New System.Drawing.Point(48, 90)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(74, 20)
        Me.txtDOB.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.AcceptsReturn = True
        Me.txtPhone.Location = New System.Drawing.Point(48, 65)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(135, 20)
        Me.txtPhone.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.Location = New System.Drawing.Point(48, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(135, 20)
        Me.txtName.TabIndex = 1
        '
        'ChartNo
        '
        Me.ChartNo.Location = New System.Drawing.Point(48, 15)
        Me.ChartNo.Name = "ChartNo"
        Me.ChartNo.Size = New System.Drawing.Size(135, 20)
        Me.ChartNo.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(188, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'GradientNavigationButton3
        '
        Me.GradientNavigationButton3.Location = New System.Drawing.Point(12, 399)
        Me.GradientNavigationButton3.Name = "GradientNavigationButton3"
        Me.GradientNavigationButton3.Size = New System.Drawing.Size(123, 26)
        Me.GradientNavigationButton3.TabIndex = 5
        Me.GradientNavigationButton3.Text = "GradientNavigationButton3"
        '
        'cmdtestorders
        '
        Me.cmdtestorders.Location = New System.Drawing.Point(13, 283)
        Me.cmdtestorders.Name = "cmdtestorders"
        Me.cmdtestorders.Size = New System.Drawing.Size(123, 26)
        Me.cmdtestorders.TabIndex = 4
        Me.cmdtestorders.Text = "Orders"
        '
        'cmdNotes
        '
        Me.cmdNotes.Location = New System.Drawing.Point(12, 251)
        Me.cmdNotes.Name = "cmdNotes"
        Me.cmdNotes.Size = New System.Drawing.Size(123, 26)
        Me.cmdNotes.TabIndex = 3
        Me.cmdNotes.Text = "Notes"
        '
        'CmdMessages
        '
        Me.CmdMessages.Location = New System.Drawing.Point(12, 219)
        Me.CmdMessages.Name = "CmdMessages"
        Me.CmdMessages.Size = New System.Drawing.Size(123, 26)
        Me.CmdMessages.TabIndex = 2
        Me.CmdMessages.Text = "Messages"
        '
        'cmdVitalSigns
        '
        Me.cmdVitalSigns.Location = New System.Drawing.Point(14, 357)
        Me.cmdVitalSigns.Name = "cmdVitalSigns"
        Me.cmdVitalSigns.Size = New System.Drawing.Size(124, 26)
        Me.cmdVitalSigns.TabIndex = 1
        Me.cmdVitalSigns.Text = "Vital Signs"
        '
        'cmdMedications
        '
        Me.cmdMedications.Location = New System.Drawing.Point(15, 325)
        Me.cmdMedications.Name = "cmdMedications"
        Me.cmdMedications.Size = New System.Drawing.Size(123, 26)
        Me.cmdMedications.TabIndex = 0
        Me.cmdMedications.Text = "Medications"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1014, 483)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.InboxDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1006, 457)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'InboxDataGridView
        '
        Me.InboxDataGridView.AllowUserToAddRows = False
        Me.InboxDataGridView.AllowUserToDeleteRows = False
        Me.InboxDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.InboxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InboxDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.InboxDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.InboxDataGridView.Name = "InboxDataGridView"
        Me.InboxDataGridView.Size = New System.Drawing.Size(1000, 446)
        Me.InboxDataGridView.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1006, 457)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GradientAnimation1
        '
        Me.GradientAnimation1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GradientAnimation1.Controls.Add(Me.GradientCaption2)
        Me.GradientAnimation1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradientAnimation1.Location = New System.Drawing.Point(0, 0)
        Me.GradientAnimation1.Name = "GradientAnimation1"
        Me.GradientAnimation1.Size = New System.Drawing.Size(1014, 74)
        Me.GradientAnimation1.TabIndex = 1
        Me.GradientAnimation1.TabStop = False
        '
        'GradientCaption2
        '
        Me.GradientCaption2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradientCaption2.Location = New System.Drawing.Point(347, 24)
        Me.GradientCaption2.Name = "GradientCaption2"
        Me.GradientCaption2.Size = New System.Drawing.Size(208, 33)
        Me.GradientCaption2.TabIndex = 0
        Me.GradientCaption2.Text = "Patient Information"
        Me.GradientCaption2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DoctorInbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 557)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "DoctorInbox"
        Me.Text = "Doctor Inbox"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.InboxDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientAnimation1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GradientAnimation1 As Ascend.Windows.Forms.GradientAnimation
    Friend WithEvents GradientCaption2 As Ascend.Windows.Forms.GradientCaption
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents InboxDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CmdMessages As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents cmdVitalSigns As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents cmdMedications As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents GradientNavigationButton3 As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents cmdtestorders As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents cmdNotes As Ascend.Windows.Forms.GradientNavigationButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSEX As System.Windows.Forms.TextBox
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents ChartNo As System.Windows.Forms.TextBox
End Class
