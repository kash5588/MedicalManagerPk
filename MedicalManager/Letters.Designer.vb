<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Letters
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
        Me.components = New System.ComponentModel.Container
        Dim IDLabel As System.Windows.Forms.Label
        Dim ChartNumberLabel As System.Windows.Forms.Label
        Dim LetterRegardingLabel As System.Windows.Forms.Label
        Dim IsRegardingPatientLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim LetterToLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ReLabel As System.Windows.Forms.Label
        Dim TextLabel As System.Windows.Forms.Label
        Dim LetterFromLabel As System.Windows.Forms.Label
        Dim TimestampLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim AssignedToLabel As System.Windows.Forms.Label
        Dim IsSignedLabel As System.Windows.Forms.Label
        Dim SignedByLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim IsChartItemLabel As System.Windows.Forms.Label
        Dim LetterCloseLabel1 As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim GreetLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Letters))
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.LettersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.LettersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox
        Me.LetterRegardingTextBox = New System.Windows.Forms.TextBox
        Me.IsRegardingPatientCheckBox = New System.Windows.Forms.CheckBox
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.LetterToTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.ReTextBox = New System.Windows.Forms.TextBox
        Me.TextTextBox = New System.Windows.Forms.TextBox
        Me.TimestampDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.UserIDTextBox = New System.Windows.Forms.TextBox
        Me.AssignedToTextBox = New System.Windows.Forms.TextBox
        Me.IsSignedCheckBox = New System.Windows.Forms.CheckBox
        Me.SignedByTextBox = New System.Windows.Forms.TextBox
        Me.StatusTextBox = New System.Windows.Forms.TextBox
        Me.IsChartItemCheckBox = New System.Windows.Forms.CheckBox
        Me.btnGetPatient = New System.Windows.Forms.Button
        Me.lblChartNumber = New System.Windows.Forms.Label
        Me.btnGetPhysician = New System.Windows.Forms.Button
        Me.btnRegarding = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnImportText = New System.Windows.Forms.Button
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.btnRefreshReport = New System.Windows.Forms.Button
        Me.LetterCloseComboBox = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GreetTextBox = New System.Windows.Forms.ComboBox
        Me.LetterFromTextBox = New System.Windows.Forms.ComboBox
        Me.tsBtnMovePrevious = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.LettersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.VisitReportPracticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.VisitReportPracticeTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.VisitReportPracticeTableAdapter
        Me.LettersTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.LettersTableAdapter
        Me.MMComboTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMComboTableAdapter
        Me.MMComboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tsBtnMoveNext = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        IDLabel = New System.Windows.Forms.Label
        ChartNumberLabel = New System.Windows.Forms.Label
        LetterRegardingLabel = New System.Windows.Forms.Label
        IsRegardingPatientLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        LetterToLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        ReLabel = New System.Windows.Forms.Label
        TextLabel = New System.Windows.Forms.Label
        LetterFromLabel = New System.Windows.Forms.Label
        TimestampLabel = New System.Windows.Forms.Label
        UserIDLabel = New System.Windows.Forms.Label
        AssignedToLabel = New System.Windows.Forms.Label
        IsSignedLabel = New System.Windows.Forms.Label
        SignedByLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        IsChartItemLabel = New System.Windows.Forms.Label
        LetterCloseLabel1 = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        GreetLabel = New System.Windows.Forms.Label
        CType(Me.LettersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LettersBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LettersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitReportPracticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMComboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(68, 35)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'ChartNumberLabel
        '
        ChartNumberLabel.AutoSize = True
        ChartNumberLabel.Location = New System.Drawing.Point(374, 313)
        ChartNumberLabel.Name = "ChartNumberLabel"
        ChartNumberLabel.Size = New System.Drawing.Size(75, 13)
        ChartNumberLabel.TabIndex = 3
        ChartNumberLabel.Text = "Chart Number:"
        '
        'LetterRegardingLabel
        '
        LetterRegardingLabel.AutoSize = True
        LetterRegardingLabel.Location = New System.Drawing.Point(3, 145)
        LetterRegardingLabel.Name = "LetterRegardingLabel"
        LetterRegardingLabel.Size = New System.Drawing.Size(89, 13)
        LetterRegardingLabel.TabIndex = 5
        LetterRegardingLabel.Text = "Letter Regarding:"
        '
        'IsRegardingPatientLabel
        '
        IsRegardingPatientLabel.AutoSize = True
        IsRegardingPatientLabel.Location = New System.Drawing.Point(455, 358)
        IsRegardingPatientLabel.Name = "IsRegardingPatientLabel"
        IsRegardingPatientLabel.Size = New System.Drawing.Size(106, 13)
        IsRegardingPatientLabel.TabIndex = 7
        IsRegardingPatientLabel.Text = "Is Regarding Patient:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(59, 54)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 9
        DateLabel.Text = "Date:"
        '
        'LetterToLabel
        '
        LetterToLabel.AutoSize = True
        LetterToLabel.Location = New System.Drawing.Point(39, 76)
        LetterToLabel.Name = "LetterToLabel"
        LetterToLabel.Size = New System.Drawing.Size(53, 13)
        LetterToLabel.TabIndex = 11
        LetterToLabel.Text = "Letter To:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(44, 95)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "Address:"
        '
        'ReLabel
        '
        ReLabel.AutoSize = True
        ReLabel.Location = New System.Drawing.Point(425, 336)
        ReLabel.Name = "ReLabel"
        ReLabel.Size = New System.Drawing.Size(24, 13)
        ReLabel.TabIndex = 15
        ReLabel.Text = "Re:"
        '
        'TextLabel
        '
        TextLabel.AutoSize = True
        TextLabel.Location = New System.Drawing.Point(61, 185)
        TextLabel.Name = "TextLabel"
        TextLabel.Size = New System.Drawing.Size(31, 13)
        TextLabel.TabIndex = 19
        TextLabel.Text = "Text:"
        '
        'LetterFromLabel
        '
        LetterFromLabel.AutoSize = True
        LetterFromLabel.Location = New System.Drawing.Point(23, 482)
        LetterFromLabel.Name = "LetterFromLabel"
        LetterFromLabel.Size = New System.Drawing.Size(63, 13)
        LetterFromLabel.TabIndex = 23
        LetterFromLabel.Text = "Letter From:"
        '
        'TimestampLabel
        '
        TimestampLabel.AutoSize = True
        TimestampLabel.Location = New System.Drawing.Point(388, 226)
        TimestampLabel.Name = "TimestampLabel"
        TimestampLabel.Size = New System.Drawing.Size(61, 13)
        TimestampLabel.TabIndex = 25
        TimestampLabel.Text = "Timestamp:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(403, 244)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(46, 13)
        UserIDLabel.TabIndex = 27
        UserIDLabel.Text = "User ID:"
        '
        'AssignedToLabel
        '
        AssignedToLabel.AutoSize = True
        AssignedToLabel.Location = New System.Drawing.Point(3, 55)
        AssignedToLabel.Name = "AssignedToLabel"
        AssignedToLabel.Size = New System.Drawing.Size(69, 13)
        AssignedToLabel.TabIndex = 29
        AssignedToLabel.Text = "Assigned To:"
        '
        'IsSignedLabel
        '
        IsSignedLabel.AutoSize = True
        IsSignedLabel.Enabled = False
        IsSignedLabel.Location = New System.Drawing.Point(17, 16)
        IsSignedLabel.Name = "IsSignedLabel"
        IsSignedLabel.Size = New System.Drawing.Size(54, 13)
        IsSignedLabel.TabIndex = 31
        IsSignedLabel.Text = "Is Signed:"
        '
        'SignedByLabel
        '
        SignedByLabel.AutoSize = True
        SignedByLabel.Location = New System.Drawing.Point(14, 33)
        SignedByLabel.Name = "SignedByLabel"
        SignedByLabel.Size = New System.Drawing.Size(58, 13)
        SignedByLabel.TabIndex = 33
        SignedByLabel.Text = "Signed By:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(32, 77)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 35
        StatusLabel.Text = "Status:"
        '
        'IsChartItemLabel
        '
        IsChartItemLabel.AutoSize = True
        IsChartItemLabel.Location = New System.Drawing.Point(452, 397)
        IsChartItemLabel.Name = "IsChartItemLabel"
        IsChartItemLabel.Size = New System.Drawing.Size(66, 13)
        IsChartItemLabel.TabIndex = 37
        IsChartItemLabel.Text = "Is Chart Item"
        '
        'LetterCloseLabel1
        '
        LetterCloseLabel1.AutoSize = True
        LetterCloseLabel1.Location = New System.Drawing.Point(23, 460)
        LetterCloseLabel1.Name = "LetterCloseLabel1"
        LetterCloseLabel1.Size = New System.Drawing.Size(66, 13)
        LetterCloseLabel1.TabIndex = 47
        LetterCloseLabel1.Text = "Letter Close:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(555, 36)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 48
        DescriptionLabel.Text = "Description:"
        DescriptionLabel.Visible = False
        '
        'GreetLabel
        '
        GreetLabel.AutoSize = True
        GreetLabel.Location = New System.Drawing.Point(53, 167)
        GreetLabel.Name = "GreetLabel"
        GreetLabel.Size = New System.Drawing.Size(36, 13)
        GreetLabel.TabIndex = 49
        GreetLabel.Text = "Greet:"
        '
        'LettersBindingNavigator
        '
        Me.LettersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LettersBindingNavigator.BindingSource = Me.LettersBindingSource
        Me.LettersBindingNavigator.CountItem = Nothing
        Me.LettersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LettersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ToolStripLabel1, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel2, Me.LettersBindingNavigatorSaveItem, Me.ToolStripLabel3, Me.tsBtnMovePrevious, Me.ToolStripLabel4, Me.tsBtnMoveNext})
        Me.LettersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LettersBindingNavigator.MoveFirstItem = Nothing
        Me.LettersBindingNavigator.MoveLastItem = Nothing
        Me.LettersBindingNavigator.MoveNextItem = Me.tsBtnMoveNext
        Me.LettersBindingNavigator.MovePreviousItem = Me.tsBtnMovePrevious
        Me.LettersBindingNavigator.Name = "LettersBindingNavigator"
        Me.LettersBindingNavigator.PositionItem = Nothing
        Me.LettersBindingNavigator.Size = New System.Drawing.Size(1101, 25)
        Me.LettersBindingNavigator.TabIndex = 0
        Me.LettersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(58, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel1.Text = "     "
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel2.Text = "     "
        '
        'LettersBindingNavigatorSaveItem
        '
        Me.LettersBindingNavigatorSaveItem.Image = CType(resources.GetObject("LettersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LettersBindingNavigatorSaveItem.Name = "LettersBindingNavigatorSaveItem"
        Me.LettersBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.LettersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(95, 30)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(41, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ChartNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "ChartNumber", True))
        Me.ChartNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(209, 54)
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(85, 13)
        Me.ChartNumberTextBox.TabIndex = 4
        '
        'LetterRegardingTextBox
        '
        Me.LetterRegardingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "LetterRegarding", True))
        Me.LetterRegardingTextBox.Location = New System.Drawing.Point(95, 143)
        Me.LetterRegardingTextBox.Name = "LetterRegardingTextBox"
        Me.LetterRegardingTextBox.Size = New System.Drawing.Size(199, 20)
        Me.LetterRegardingTextBox.TabIndex = 6
        '
        'IsRegardingPatientCheckBox
        '
        Me.IsRegardingPatientCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LettersBindingSource, "IsRegardingPatient", True))
        Me.IsRegardingPatientCheckBox.Location = New System.Drawing.Point(567, 352)
        Me.IsRegardingPatientCheckBox.Name = "IsRegardingPatientCheckBox"
        Me.IsRegardingPatientCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.IsRegardingPatientCheckBox.TabIndex = 8
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LettersBindingSource, "Date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(95, 51)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.DateDateTimePicker.TabIndex = 10
        '
        'LetterToTextBox
        '
        Me.LetterToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "LetterTo", True))
        Me.LetterToTextBox.Location = New System.Drawing.Point(95, 72)
        Me.LetterToTextBox.Name = "LetterToTextBox"
        Me.LetterToTextBox.Size = New System.Drawing.Size(199, 20)
        Me.LetterToTextBox.TabIndex = 12
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(95, 93)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(199, 49)
        Me.AddressTextBox.TabIndex = 14
        '
        'ReTextBox
        '
        Me.ReTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "Re", True))
        Me.ReTextBox.Location = New System.Drawing.Point(455, 335)
        Me.ReTextBox.Name = "ReTextBox"
        Me.ReTextBox.Size = New System.Drawing.Size(101, 20)
        Me.ReTextBox.TabIndex = 16
        '
        'TextTextBox
        '
        Me.TextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "Text", True))
        Me.TextTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextTextBox.Location = New System.Drawing.Point(95, 186)
        Me.TextTextBox.Multiline = True
        Me.TextTextBox.Name = "TextTextBox"
        Me.TextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextTextBox.Size = New System.Drawing.Size(545, 270)
        Me.TextTextBox.TabIndex = 20
        '
        'TimestampDateTimePicker
        '
        Me.TimestampDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LettersBindingSource, "Timestamp", True))
        Me.TimestampDateTimePicker.Location = New System.Drawing.Point(455, 221)
        Me.TimestampDateTimePicker.Name = "TimestampDateTimePicker"
        Me.TimestampDateTimePicker.Size = New System.Drawing.Size(101, 20)
        Me.TimestampDateTimePicker.TabIndex = 26
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(455, 243)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(101, 20)
        Me.UserIDTextBox.TabIndex = 28
        '
        'AssignedToTextBox
        '
        Me.AssignedToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "AssignedTo", True))
        Me.AssignedToTextBox.Location = New System.Drawing.Point(74, 52)
        Me.AssignedToTextBox.Name = "AssignedToTextBox"
        Me.AssignedToTextBox.Size = New System.Drawing.Size(95, 20)
        Me.AssignedToTextBox.TabIndex = 30
        '
        'IsSignedCheckBox
        '
        Me.IsSignedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LettersBindingSource, "IsSigned", True))
        Me.IsSignedCheckBox.Enabled = False
        Me.IsSignedCheckBox.Location = New System.Drawing.Point(74, 8)
        Me.IsSignedCheckBox.Name = "IsSignedCheckBox"
        Me.IsSignedCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.IsSignedCheckBox.TabIndex = 32
        '
        'SignedByTextBox
        '
        Me.SignedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "SignedBy", True))
        Me.SignedByTextBox.Location = New System.Drawing.Point(74, 30)
        Me.SignedByTextBox.Name = "SignedByTextBox"
        Me.SignedByTextBox.Size = New System.Drawing.Size(95, 20)
        Me.SignedByTextBox.TabIndex = 34
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(74, 74)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(95, 20)
        Me.StatusTextBox.TabIndex = 36
        '
        'IsChartItemCheckBox
        '
        Me.IsChartItemCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.LettersBindingSource, "IsChartItem", True))
        Me.IsChartItemCheckBox.Location = New System.Drawing.Point(438, 392)
        Me.IsChartItemCheckBox.Name = "IsChartItemCheckBox"
        Me.IsChartItemCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.IsChartItemCheckBox.TabIndex = 38
        '
        'btnGetPatient
        '
        Me.btnGetPatient.Location = New System.Drawing.Point(294, 72)
        Me.btnGetPatient.Name = "btnGetPatient"
        Me.btnGetPatient.Size = New System.Drawing.Size(85, 20)
        Me.btnGetPatient.TabIndex = 39
        Me.btnGetPatient.Text = "To Patient"
        Me.btnGetPatient.UseVisualStyleBackColor = True
        '
        'lblChartNumber
        '
        Me.lblChartNumber.AutoSize = True
        Me.lblChartNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChartNumber.Location = New System.Drawing.Point(455, 313)
        Me.lblChartNumber.Name = "lblChartNumber"
        Me.lblChartNumber.Size = New System.Drawing.Size(0, 13)
        Me.lblChartNumber.TabIndex = 40
        '
        'btnGetPhysician
        '
        Me.btnGetPhysician.Location = New System.Drawing.Point(379, 72)
        Me.btnGetPhysician.Name = "btnGetPhysician"
        Me.btnGetPhysician.Size = New System.Drawing.Size(81, 20)
        Me.btnGetPhysician.TabIndex = 41
        Me.btnGetPhysician.Text = "To Physician"
        Me.btnGetPhysician.UseVisualStyleBackColor = True
        '
        'btnRegarding
        '
        Me.btnRegarding.Location = New System.Drawing.Point(294, 142)
        Me.btnRegarding.Name = "btnRegarding"
        Me.btnRegarding.Size = New System.Drawing.Size(85, 20)
        Me.btnRegarding.TabIndex = 42
        Me.btnRegarding.Text = "Regarding"
        Me.btnRegarding.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.SignedByTextBox)
        Me.GroupBox1.Controls.Add(Me.StatusTextBox)
        Me.GroupBox1.Controls.Add(StatusLabel)
        Me.GroupBox1.Controls.Add(SignedByLabel)
        Me.GroupBox1.Controls.Add(Me.IsSignedCheckBox)
        Me.GroupBox1.Controls.Add(IsSignedLabel)
        Me.GroupBox1.Controls.Add(Me.AssignedToTextBox)
        Me.GroupBox1.Controls.Add(AssignedToLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(209, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 103)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'btnImportText
        '
        Me.btnImportText.Location = New System.Drawing.Point(565, 164)
        Me.btnImportText.Name = "btnImportText"
        Me.btnImportText.Size = New System.Drawing.Size(75, 21)
        Me.btnImportText.TabIndex = 44
        Me.btnImportText.Text = "Import Text"
        Me.btnImportText.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "MMDataDataSet2_Letters"
        ReportDataSource3.Value = Me.LettersBindingSource
        ReportDataSource4.Name = "MMDataDataSet1_VisitReportPractice"
        ReportDataSource4.Value = Me.VisitReportPracticeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.Letter.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(646, 30)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowProgress = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(435, 483)
        Me.ReportViewer1.TabIndex = 45
        Me.ReportViewer1.ZoomPercent = 66
        '
        'btnRefreshReport
        '
        Me.btnRefreshReport.Location = New System.Drawing.Point(552, 490)
        Me.btnRefreshReport.Name = "btnRefreshReport"
        Me.btnRefreshReport.Size = New System.Drawing.Size(88, 23)
        Me.btnRefreshReport.TabIndex = 47
        Me.btnRefreshReport.Text = "Refresh Report"
        Me.btnRefreshReport.UseVisualStyleBackColor = True
        '
        'LetterCloseComboBox
        '
        Me.LetterCloseComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "LetterClose", True))
        Me.LetterCloseComboBox.FormattingEnabled = True
        Me.LetterCloseComboBox.Items.AddRange(New Object() {"Regards,", "Sincerely,", "Thank You,"})
        Me.LetterCloseComboBox.Location = New System.Drawing.Point(95, 457)
        Me.LetterCloseComboBox.Name = "LetterCloseComboBox"
        Me.LetterCloseComboBox.Size = New System.Drawing.Size(284, 21)
        Me.LetterCloseComboBox.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "Description", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(623, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(17, 20)
        Me.TextBox1.TabIndex = 49
        '
        'GreetTextBox
        '
        Me.GreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "Greet", True))
        Me.GreetTextBox.FormattingEnabled = True
        Me.GreetTextBox.Items.AddRange(New Object() {"To Whom It May Concern:"})
        Me.GreetTextBox.Location = New System.Drawing.Point(95, 164)
        Me.GreetTextBox.Name = "GreetTextBox"
        Me.GreetTextBox.Size = New System.Drawing.Size(199, 21)
        Me.GreetTextBox.TabIndex = 50
        '
        'LetterFromTextBox
        '
        Me.LetterFromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LettersBindingSource, "LetterFrom", True))
        Me.LetterFromTextBox.FormattingEnabled = True
        Me.LetterFromTextBox.Location = New System.Drawing.Point(95, 479)
        Me.LetterFromTextBox.Name = "LetterFromTextBox"
        Me.LetterFromTextBox.Size = New System.Drawing.Size(284, 21)
        Me.LetterFromTextBox.TabIndex = 51
        '
        'tsBtnMovePrevious
        '
        Me.tsBtnMovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsBtnMovePrevious.Image = CType(resources.GetObject("tsBtnMovePrevious.Image"), System.Drawing.Image)
        Me.tsBtnMovePrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnMovePrevious.Name = "tsBtnMovePrevious"
        Me.tsBtnMovePrevious.Size = New System.Drawing.Size(126, 22)
        Me.tsBtnMovePrevious.Text = "Move to Previous Letter"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel3.Text = "     "
        '
        'LettersBindingSource
        '
        Me.LettersBindingSource.DataMember = "Letters"
        Me.LettersBindingSource.DataSource = Me.MMDataDataSet2
        '
        'MMDataDataSet2
        '
        Me.MMDataDataSet2.DataSetName = "MMDataDataSet2"
        Me.MMDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisitReportPracticeBindingSource
        '
        Me.VisitReportPracticeBindingSource.DataMember = "VisitReportPractice"
        Me.VisitReportPracticeBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisitReportPracticeTableAdapter
        '
        Me.VisitReportPracticeTableAdapter.ClearBeforeFill = True
        '
        'LettersTableAdapter
        '
        Me.LettersTableAdapter.ClearBeforeFill = True
        '
        'MMComboTableAdapter
        '
        Me.MMComboTableAdapter.ClearBeforeFill = True
        '
        'MMComboBindingSource
        '
        Me.MMComboBindingSource.DataMember = "MMCombo"
        Me.MMComboBindingSource.DataSource = Me.MMDataDataSet1
        '
        'tsBtnMoveNext
        '
        Me.tsBtnMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsBtnMoveNext.Image = CType(resources.GetObject("tsBtnMoveNext.Image"), System.Drawing.Image)
        Me.tsBtnMoveNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnMoveNext.Name = "tsBtnMoveNext"
        Me.tsBtnMoveNext.Size = New System.Drawing.Size(108, 22)
        Me.tsBtnMoveNext.Text = "Move to Next Letter"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel4.Text = "     "
        '
        'Letters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1101, 533)
        Me.Controls.Add(Me.LetterFromTextBox)
        Me.Controls.Add(GreetLabel)
        Me.Controls.Add(Me.GreetTextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(LetterCloseLabel1)
        Me.Controls.Add(Me.LetterCloseComboBox)
        Me.Controls.Add(Me.btnRefreshReport)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnImportText)
        Me.Controls.Add(Me.btnRegarding)
        Me.Controls.Add(Me.btnGetPhysician)
        Me.Controls.Add(Me.btnGetPatient)
        Me.Controls.Add(Me.ChartNumberTextBox)
        Me.Controls.Add(LetterRegardingLabel)
        Me.Controls.Add(Me.LetterRegardingTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(LetterToLabel)
        Me.Controls.Add(Me.LetterToTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(TextLabel)
        Me.Controls.Add(Me.TextTextBox)
        Me.Controls.Add(LetterFromLabel)
        Me.Controls.Add(Me.LettersBindingNavigator)
        Me.Controls.Add(Me.lblChartNumber)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(ChartNumberLabel)
        Me.Controls.Add(IsRegardingPatientLabel)
        Me.Controls.Add(Me.IsRegardingPatientCheckBox)
        Me.Controls.Add(ReLabel)
        Me.Controls.Add(Me.ReTextBox)
        Me.Controls.Add(TimestampLabel)
        Me.Controls.Add(Me.TimestampDateTimePicker)
        Me.Controls.Add(UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(IsChartItemLabel)
        Me.Controls.Add(Me.IsChartItemCheckBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Letters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Letters"
        CType(Me.LettersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LettersBindingNavigator.ResumeLayout(False)
        Me.LettersBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LettersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitReportPracticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMComboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents LettersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LettersTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.LettersTableAdapter
    Friend WithEvents LettersBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LettersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LetterRegardingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsRegardingPatientCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LetterToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimestampDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AssignedToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsSignedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SignedByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IsChartItemCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents btnGetPatient As System.Windows.Forms.Button
    Friend WithEvents lblChartNumber As System.Windows.Forms.Label
    Friend WithEvents btnGetPhysician As System.Windows.Forms.Button
    Friend WithEvents btnRegarding As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImportText As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnRefreshReport As System.Windows.Forms.Button
    Friend WithEvents LetterCloseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents VisitReportPracticeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VisitReportPracticeTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.VisitReportPracticeTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GreetTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents MMComboTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMComboTableAdapter
    Friend WithEvents MMComboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LetterFromTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsBtnMovePrevious As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsBtnMoveNext As System.Windows.Forms.ToolStripButton
End Class
