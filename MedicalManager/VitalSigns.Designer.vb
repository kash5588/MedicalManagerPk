<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VitalSigns
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
        Me.components = New System.ComponentModel.Container
        Dim TimeStampLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim VIDLabel As System.Windows.Forms.Label
        Dim ChartNumberLabel As System.Windows.Forms.Label
        Dim CaseNumberLabel As System.Windows.Forms.Label
        Dim UserLabel As System.Windows.Forms.Label
        Dim SignedLabel As System.Windows.Forms.Label
        Dim TimeLabel As System.Windows.Forms.Label
        Dim BMILabel As System.Windows.Forms.Label
        Dim UserLabel1 As System.Windows.Forms.Label
        Dim DateLabel1 As System.Windows.Forms.Label
        Dim BloodSugarLabel As System.Windows.Forms.Label
        Dim LMPLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VitalSigns))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.MMChartTVitalSignDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Signed = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.FLName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMChartTVitalSignBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.UserTextBox1 = New System.Windows.Forms.TextBox
        Me.TimeTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCalender = New System.Windows.Forms.Button
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.LMPTextBox = New System.Windows.Forms.TextBox
        Me.BloodSugarTextBox = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.DistolicR = New System.Windows.Forms.RadioButton
        Me.WTR = New System.Windows.Forms.RadioButton
        Me.HTR = New System.Windows.Forms.RadioButton
        Me.PulseOxR = New System.Windows.Forms.RadioButton
        Me.PulseR = New System.Windows.Forms.RadioButton
        Me.RespR = New System.Windows.Forms.RadioButton
        Me.TempR = New System.Windows.Forms.RadioButton
        Me.Button28 = New System.Windows.Forms.Button
        Me.TempTextBox = New System.Windows.Forms.TextBox
        Me.PulseTextBox = New System.Windows.Forms.TextBox
        Me.SystolicR = New System.Windows.Forms.RadioButton
        Me.HtTextBox = New System.Windows.Forms.TextBox
        Me.WtTextBox = New System.Windows.Forms.TextBox
        Me.RespTextBox = New System.Windows.Forms.TextBox
        Me.PulseOxTextBox = New System.Windows.Forms.TextBox
        Me.BMITextBox = New System.Windows.Forms.TextBox
        Me.SystolicTextBox = New System.Windows.Forms.TextBox
        Me.DistolicTextBox = New System.Windows.Forms.TextBox
        Me.SignedCheckBox = New System.Windows.Forms.CheckBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.VIDTextBox = New System.Windows.Forms.TextBox
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox
        Me.CaseNumberTextBox = New System.Windows.Forms.TextBox
        Me.TimeStampTextBox = New System.Windows.Forms.TextBox
        Me.UserTextBox = New System.Windows.Forms.TextBox
        Me.MMChartTVitalSignBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.MMChartTVitalSignBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MMChartTVitalSignTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter
        TimeStampLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        VIDLabel = New System.Windows.Forms.Label
        ChartNumberLabel = New System.Windows.Forms.Label
        CaseNumberLabel = New System.Windows.Forms.Label
        UserLabel = New System.Windows.Forms.Label
        SignedLabel = New System.Windows.Forms.Label
        TimeLabel = New System.Windows.Forms.Label
        BMILabel = New System.Windows.Forms.Label
        UserLabel1 = New System.Windows.Forms.Label
        DateLabel1 = New System.Windows.Forms.Label
        BloodSugarLabel = New System.Windows.Forms.Label
        LMPLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MMChartTVitalSignDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MMChartTVitalSignBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMChartTVitalSignBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimeStampLabel
        '
        TimeStampLabel.AutoSize = True
        TimeStampLabel.Location = New System.Drawing.Point(32, 249)
        TimeStampLabel.Name = "TimeStampLabel"
        TimeStampLabel.Size = New System.Drawing.Size(66, 13)
        TimeStampLabel.TabIndex = 37
        TimeStampLabel.Text = "Time Stamp:"
        TimeStampLabel.Visible = False
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(55, 84)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 36
        NameLabel.Text = "Name:"
        '
        'VIDLabel
        '
        VIDLabel.AutoSize = True
        VIDLabel.Location = New System.Drawing.Point(55, 33)
        VIDLabel.Name = "VIDLabel"
        VIDLabel.Size = New System.Drawing.Size(38, 13)
        VIDLabel.TabIndex = 0
        VIDLabel.Text = "VS ID:"
        '
        'ChartNumberLabel
        '
        ChartNumberLabel.AutoSize = True
        ChartNumberLabel.Location = New System.Drawing.Point(41, 60)
        ChartNumberLabel.Name = "ChartNumberLabel"
        ChartNumberLabel.Size = New System.Drawing.Size(52, 13)
        ChartNumberLabel.TabIndex = 2
        ChartNumberLabel.Text = "Chart No:"
        '
        'CaseNumberLabel
        '
        CaseNumberLabel.AutoSize = True
        CaseNumberLabel.Location = New System.Drawing.Point(42, 109)
        CaseNumberLabel.Name = "CaseNumberLabel"
        CaseNumberLabel.Size = New System.Drawing.Size(51, 13)
        CaseNumberLabel.TabIndex = 4
        CaseNumberLabel.Text = "Case No:"
        '
        'UserLabel
        '
        UserLabel.AutoSize = True
        UserLabel.Location = New System.Drawing.Point(84, 317)
        UserLabel.Name = "UserLabel"
        UserLabel.Size = New System.Drawing.Size(32, 13)
        UserLabel.TabIndex = 30
        UserLabel.Text = "User:"
        UserLabel.Visible = False
        '
        'SignedLabel
        '
        SignedLabel.AutoSize = True
        SignedLabel.Enabled = False
        SignedLabel.Location = New System.Drawing.Point(50, 208)
        SignedLabel.Name = "SignedLabel"
        SignedLabel.Size = New System.Drawing.Size(43, 13)
        SignedLabel.TabIndex = 39
        SignedLabel.Text = "Signed:"
        '
        'TimeLabel
        '
        TimeLabel.AutoSize = True
        TimeLabel.Location = New System.Drawing.Point(60, 159)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New System.Drawing.Size(33, 13)
        TimeLabel.TabIndex = 121
        TimeLabel.Text = "Time:"
        '
        'BMILabel
        '
        BMILabel.AutoSize = True
        BMILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BMILabel.Location = New System.Drawing.Point(88, 198)
        BMILabel.Name = "BMILabel"
        BMILabel.Size = New System.Drawing.Size(33, 13)
        BMILabel.TabIndex = 26
        BMILabel.Text = "BMI:"
        '
        'UserLabel1
        '
        UserLabel1.AutoSize = True
        UserLabel1.Location = New System.Drawing.Point(61, 183)
        UserLabel1.Name = "UserLabel1"
        UserLabel1.Size = New System.Drawing.Size(32, 13)
        UserLabel1.TabIndex = 122
        UserLabel1.Text = "User:"
        '
        'DateLabel1
        '
        DateLabel1.AutoSize = True
        DateLabel1.Location = New System.Drawing.Point(60, 134)
        DateLabel1.Name = "DateLabel1"
        DateLabel1.Size = New System.Drawing.Size(33, 13)
        DateLabel1.TabIndex = 123
        DateLabel1.Text = "Date:"
        '
        'BloodSugarLabel
        '
        BloodSugarLabel.AutoSize = True
        BloodSugarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BloodSugarLabel.Location = New System.Drawing.Point(281, 30)
        BloodSugarLabel.Name = "BloodSugarLabel"
        BloodSugarLabel.Size = New System.Drawing.Size(65, 13)
        BloodSugarLabel.TabIndex = 129
        BloodSugarLabel.Text = "Blood Sugar"
        '
        'LMPLabel
        '
        LMPLabel.AutoSize = True
        LMPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LMPLabel.Location = New System.Drawing.Point(316, 51)
        LMPLabel.Name = "LMPLabel"
        LMPLabel.Size = New System.Drawing.Size(29, 13)
        LMPLabel.TabIndex = 130
        LMPLabel.Text = "LMP"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(928, 331)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.MedicalManager.My.Resources.Resources.untitled
        Me.TabPage1.Controls.Add(Me.MMChartTVitalSignDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(920, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MMChartTVitalSignDataGridView
        '
        Me.MMChartTVitalSignDataGridView.AllowUserToAddRows = False
        Me.MMChartTVitalSignDataGridView.AllowUserToDeleteRows = False
        Me.MMChartTVitalSignDataGridView.AutoGenerateColumns = False
        Me.MMChartTVitalSignDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Signed, Me.FLName, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.MMChartTVitalSignDataGridView.DataSource = Me.MMChartTVitalSignBindingSource
        Me.MMChartTVitalSignDataGridView.Location = New System.Drawing.Point(1, 1)
        Me.MMChartTVitalSignDataGridView.Name = "MMChartTVitalSignDataGridView"
        Me.MMChartTVitalSignDataGridView.Size = New System.Drawing.Size(917, 300)
        Me.MMChartTVitalSignDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 25
        '
        'Signed
        '
        Me.Signed.DataPropertyName = "Signed"
        Me.Signed.HeaderText = "Sign"
        Me.Signed.Name = "Signed"
        Me.Signed.Width = 38
        '
        'FLName
        '
        Me.FLName.DataPropertyName = "Name"
        Me.FLName.HeaderText = "Name"
        Me.FLName.Name = "FLName"
        Me.FLName.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Chart Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CaseNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Case Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 65
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Time"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Temp"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Temp"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 47
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Pulse"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pulse"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 47
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Systolic"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Sys"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 47
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Diastolic"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Dia"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 47
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "PulseOx"
        Me.DataGridViewTextBoxColumn15.HeaderText = "PulseOx"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 49
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "WtLb"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Wt Lb"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 47
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "HtIn"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Ht In"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 47
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Resp"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Resp"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 47
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Oz"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Oz"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 47
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "BMI"
        Me.DataGridViewTextBoxColumn14.HeaderText = "BMI"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 47
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "User"
        Me.DataGridViewTextBoxColumn16.HeaderText = "User"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "TimeStamp"
        Me.DataGridViewTextBoxColumn17.HeaderText = "TimeStamp"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'MMChartTVitalSignBindingSource
        '
        Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
        Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackgroundImage = Global.MedicalManager.My.Resources.Resources.untitled
        Me.TabPage2.Controls.Add(DateLabel1)
        Me.TabPage2.Controls.Add(Me.DateDateTimePicker)
        Me.TabPage2.Controls.Add(UserLabel1)
        Me.TabPage2.Controls.Add(Me.UserTextBox1)
        Me.TabPage2.Controls.Add(TimeLabel)
        Me.TabPage2.Controls.Add(Me.TimeTextBox)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(SignedLabel)
        Me.TabPage2.Controls.Add(Me.SignedCheckBox)
        Me.TabPage2.Controls.Add(NameLabel)
        Me.TabPage2.Controls.Add(Me.NameTextBox)
        Me.TabPage2.Controls.Add(Me.cmdPatient)
        Me.TabPage2.Controls.Add(VIDLabel)
        Me.TabPage2.Controls.Add(Me.VIDTextBox)
        Me.TabPage2.Controls.Add(ChartNumberLabel)
        Me.TabPage2.Controls.Add(Me.ChartNumberTextBox)
        Me.TabPage2.Controls.Add(CaseNumberLabel)
        Me.TabPage2.Controls.Add(Me.CaseNumberTextBox)
        Me.TabPage2.Controls.Add(TimeStampLabel)
        Me.TabPage2.Controls.Add(Me.TimeStampTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(920, 305)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MMChartTVitalSignBindingSource, "Date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(99, 130)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(119, 20)
        Me.DateDateTimePicker.TabIndex = 124
        '
        'UserTextBox1
        '
        Me.UserTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "User", True))
        Me.UserTextBox1.Enabled = False
        Me.UserTextBox1.Location = New System.Drawing.Point(99, 179)
        Me.UserTextBox1.Name = "UserTextBox1"
        Me.UserTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.UserTextBox1.TabIndex = 123
        '
        'TimeTextBox
        '
        Me.TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "Time", True))
        Me.TimeTextBox.Location = New System.Drawing.Point(99, 155)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.Size = New System.Drawing.Size(119, 20)
        Me.TimeTextBox.TabIndex = 122
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.btnCalender)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Controls.Add(LMPLabel)
        Me.GroupBox1.Controls.Add(Me.LMPTextBox)
        Me.GroupBox1.Controls.Add(BloodSugarLabel)
        Me.GroupBox1.Controls.Add(Me.BloodSugarTextBox)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.DistolicR)
        Me.GroupBox1.Controls.Add(Me.WTR)
        Me.GroupBox1.Controls.Add(Me.HTR)
        Me.GroupBox1.Controls.Add(Me.PulseOxR)
        Me.GroupBox1.Controls.Add(Me.PulseR)
        Me.GroupBox1.Controls.Add(Me.RespR)
        Me.GroupBox1.Controls.Add(Me.TempR)
        Me.GroupBox1.Controls.Add(Me.Button28)
        Me.GroupBox1.Controls.Add(Me.TempTextBox)
        Me.GroupBox1.Controls.Add(Me.PulseTextBox)
        Me.GroupBox1.Controls.Add(Me.SystolicR)
        Me.GroupBox1.Controls.Add(Me.HtTextBox)
        Me.GroupBox1.Controls.Add(Me.WtTextBox)
        Me.GroupBox1.Controls.Add(Me.RespTextBox)
        Me.GroupBox1.Controls.Add(Me.PulseOxTextBox)
        Me.GroupBox1.Controls.Add(Me.BMITextBox)
        Me.GroupBox1.Controls.Add(Me.SystolicTextBox)
        Me.GroupBox1.Controls.Add(BMILabel)
        Me.GroupBox1.Controls.Add(Me.DistolicTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(319, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 285)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "VITAL SIGNS"
        '
        'btnCalender
        '
        Me.btnCalender.Location = New System.Drawing.Point(552, 48)
        Me.btnCalender.Name = "btnCalender"
        Me.btnCalender.Size = New System.Drawing.Size(19, 19)
        Me.btnCalender.TabIndex = 134
        Me.btnCalender.Text = "C"
        Me.btnCalender.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(351, 70)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 133
        Me.MonthCalendar1.Visible = False
        '
        'LMPTextBox
        '
        Me.LMPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "LMP", True))
        Me.LMPTextBox.Location = New System.Drawing.Point(351, 48)
        Me.LMPTextBox.MaxLength = 25
        Me.LMPTextBox.Name = "LMPTextBox"
        Me.LMPTextBox.Size = New System.Drawing.Size(199, 20)
        Me.LMPTextBox.TabIndex = 131
        '
        'BloodSugarTextBox
        '
        Me.BloodSugarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "BloodSugar", True))
        Me.BloodSugarTextBox.Location = New System.Drawing.Point(351, 27)
        Me.BloodSugarTextBox.MaxLength = 10
        Me.BloodSugarTextBox.Name = "BloodSugarTextBox"
        Me.BloodSugarTextBox.Size = New System.Drawing.Size(220, 20)
        Me.BloodSugarTextBox.TabIndex = 130
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"})
        Me.ListBox1.Location = New System.Drawing.Point(24, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(25, 184)
        Me.ListBox1.TabIndex = 128
        Me.ListBox1.TabStop = False
        '
        'DistolicR
        '
        Me.DistolicR.AutoSize = True
        Me.DistolicR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistolicR.Location = New System.Drawing.Point(56, 94)
        Me.DistolicR.Name = "DistolicR"
        Me.DistolicR.Size = New System.Drawing.Size(59, 17)
        Me.DistolicR.TabIndex = 7
        Me.DistolicR.Text = "Distolic"
        Me.DistolicR.UseVisualStyleBackColor = True
        '
        'WTR
        '
        Me.WTR.AutoSize = True
        Me.WTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTR.Location = New System.Drawing.Point(56, 136)
        Me.WTR.Name = "WTR"
        Me.WTR.Size = New System.Drawing.Size(58, 17)
        Me.WTR.TabIndex = 5
        Me.WTR.Text = "Wt(lbs)"
        Me.WTR.UseVisualStyleBackColor = True
        '
        'HTR
        '
        Me.HTR.AutoSize = True
        Me.HTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HTR.Location = New System.Drawing.Point(56, 157)
        Me.HTR.Name = "HTR"
        Me.HTR.Size = New System.Drawing.Size(60, 17)
        Me.HTR.TabIndex = 4
        Me.HTR.Text = "HT(inc)"
        Me.HTR.UseVisualStyleBackColor = True
        '
        'PulseOxR
        '
        Me.PulseOxR.AutoSize = True
        Me.PulseOxR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulseOxR.Location = New System.Drawing.Point(56, 115)
        Me.PulseOxR.Name = "PulseOxR"
        Me.PulseOxR.Size = New System.Drawing.Size(64, 17)
        Me.PulseOxR.TabIndex = 3
        Me.PulseOxR.Text = "PulseOx"
        Me.PulseOxR.UseVisualStyleBackColor = True
        '
        'PulseR
        '
        Me.PulseR.AutoSize = True
        Me.PulseR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulseR.Location = New System.Drawing.Point(56, 52)
        Me.PulseR.Name = "PulseR"
        Me.PulseR.Size = New System.Drawing.Size(51, 17)
        Me.PulseR.TabIndex = 2
        Me.PulseR.Text = "Pulse"
        Me.PulseR.UseVisualStyleBackColor = True
        '
        'RespR
        '
        Me.RespR.AutoSize = True
        Me.RespR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RespR.Location = New System.Drawing.Point(56, 178)
        Me.RespR.Name = "RespR"
        Me.RespR.Size = New System.Drawing.Size(50, 17)
        Me.RespR.TabIndex = 1
        Me.RespR.Text = "Resp"
        Me.RespR.UseVisualStyleBackColor = True
        '
        'TempR
        '
        Me.TempR.AutoSize = True
        Me.TempR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempR.Location = New System.Drawing.Point(56, 31)
        Me.TempR.Name = "TempR"
        Me.TempR.Size = New System.Drawing.Size(52, 17)
        Me.TempR.TabIndex = 0
        Me.TempR.Text = "Temp"
        Me.TempR.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.Location = New System.Drawing.Point(120, 222)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(150, 22)
        Me.Button28.TabIndex = 129
        Me.Button28.TabStop = False
        Me.Button28.Text = "Clear Selected"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'TempTextBox
        '
        Me.TempTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "Temp", True))
        Me.TempTextBox.Location = New System.Drawing.Point(120, 28)
        Me.TempTextBox.MaxLength = 6
        Me.TempTextBox.Name = "TempTextBox"
        Me.TempTextBox.Size = New System.Drawing.Size(150, 20)
        Me.TempTextBox.TabIndex = 0
        '
        'PulseTextBox
        '
        Me.PulseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "Pulse", True))
        Me.PulseTextBox.Location = New System.Drawing.Point(120, 49)
        Me.PulseTextBox.MaxLength = 6
        Me.PulseTextBox.Name = "PulseTextBox"
        Me.PulseTextBox.Size = New System.Drawing.Size(150, 20)
        Me.PulseTextBox.TabIndex = 1
        '
        'SystolicR
        '
        Me.SystolicR.AutoSize = True
        Me.SystolicR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SystolicR.Location = New System.Drawing.Point(56, 73)
        Me.SystolicR.Name = "SystolicR"
        Me.SystolicR.Size = New System.Drawing.Size(61, 17)
        Me.SystolicR.TabIndex = 6
        Me.SystolicR.Text = "Systolic"
        Me.SystolicR.UseVisualStyleBackColor = True
        '
        'HtTextBox
        '
        Me.HtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "HtIn", True))
        Me.HtTextBox.Location = New System.Drawing.Point(120, 154)
        Me.HtTextBox.MaxLength = 6
        Me.HtTextBox.Name = "HtTextBox"
        Me.HtTextBox.Size = New System.Drawing.Size(150, 20)
        Me.HtTextBox.TabIndex = 6
        '
        'WtTextBox
        '
        Me.WtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "WtLb", True))
        Me.WtTextBox.Location = New System.Drawing.Point(120, 133)
        Me.WtTextBox.MaxLength = 6
        Me.WtTextBox.Name = "WtTextBox"
        Me.WtTextBox.Size = New System.Drawing.Size(150, 20)
        Me.WtTextBox.TabIndex = 5
        '
        'RespTextBox
        '
        Me.RespTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "Resp", True))
        Me.RespTextBox.Location = New System.Drawing.Point(120, 175)
        Me.RespTextBox.MaxLength = 6
        Me.RespTextBox.Name = "RespTextBox"
        Me.RespTextBox.Size = New System.Drawing.Size(150, 20)
        Me.RespTextBox.TabIndex = 7
        '
        'PulseOxTextBox
        '
        Me.PulseOxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "PulseOx", True))
        Me.PulseOxTextBox.Location = New System.Drawing.Point(120, 112)
        Me.PulseOxTextBox.MaxLength = 6
        Me.PulseOxTextBox.Name = "PulseOxTextBox"
        Me.PulseOxTextBox.Size = New System.Drawing.Size(150, 20)
        Me.PulseOxTextBox.TabIndex = 4
        '
        'BMITextBox
        '
        Me.BMITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "BMI", True))
        Me.BMITextBox.Location = New System.Drawing.Point(120, 196)
        Me.BMITextBox.MaxLength = 6
        Me.BMITextBox.Name = "BMITextBox"
        Me.BMITextBox.Size = New System.Drawing.Size(150, 20)
        Me.BMITextBox.TabIndex = 8
        '
        'SystolicTextBox
        '
        Me.SystolicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "Systolic", True))
        Me.SystolicTextBox.Location = New System.Drawing.Point(120, 70)
        Me.SystolicTextBox.MaxLength = 6
        Me.SystolicTextBox.Name = "SystolicTextBox"
        Me.SystolicTextBox.Size = New System.Drawing.Size(150, 20)
        Me.SystolicTextBox.TabIndex = 2
        '
        'DistolicTextBox
        '
        Me.DistolicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "Diastolic", True))
        Me.DistolicTextBox.Location = New System.Drawing.Point(120, 91)
        Me.DistolicTextBox.MaxLength = 6
        Me.DistolicTextBox.Name = "DistolicTextBox"
        Me.DistolicTextBox.Size = New System.Drawing.Size(150, 20)
        Me.DistolicTextBox.TabIndex = 3
        '
        'SignedCheckBox
        '
        Me.SignedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MMChartTVitalSignBindingSource, "Signed", True))
        Me.SignedCheckBox.Enabled = False
        Me.SignedCheckBox.Location = New System.Drawing.Point(99, 203)
        Me.SignedCheckBox.Name = "SignedCheckBox"
        Me.SignedCheckBox.Size = New System.Drawing.Size(27, 24)
        Me.SignedCheckBox.TabIndex = 40
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(99, 80)
        Me.NameTextBox.MaxLength = 50
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(194, 20)
        Me.NameTextBox.TabIndex = 37
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(218, 55)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(75, 21)
        Me.cmdPatient.TabIndex = 34
        Me.cmdPatient.Text = "Select"
        Me.cmdPatient.UseVisualStyleBackColor = True
        Me.cmdPatient.Visible = False
        '
        'VIDTextBox
        '
        Me.VIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "VID", True))
        Me.VIDTextBox.Enabled = False
        Me.VIDTextBox.Location = New System.Drawing.Point(99, 29)
        Me.VIDTextBox.Name = "VIDTextBox"
        Me.VIDTextBox.Size = New System.Drawing.Size(119, 20)
        Me.VIDTextBox.TabIndex = 1
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "ChartNumber", True))
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(99, 56)
        Me.ChartNumberTextBox.MaxLength = 8
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(119, 20)
        Me.ChartNumberTextBox.TabIndex = 3
        '
        'CaseNumberTextBox
        '
        Me.CaseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "CaseNumber", True))
        Me.CaseNumberTextBox.Location = New System.Drawing.Point(99, 105)
        Me.CaseNumberTextBox.Name = "CaseNumberTextBox"
        Me.CaseNumberTextBox.Size = New System.Drawing.Size(119, 20)
        Me.CaseNumberTextBox.TabIndex = 5
        '
        'TimeStampTextBox
        '
        Me.TimeStampTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "TimeStamp", True))
        Me.TimeStampTextBox.Enabled = False
        Me.TimeStampTextBox.Location = New System.Drawing.Point(99, 245)
        Me.TimeStampTextBox.Name = "TimeStampTextBox"
        Me.TimeStampTextBox.Size = New System.Drawing.Size(119, 20)
        Me.TimeStampTextBox.TabIndex = 38
        Me.TimeStampTextBox.Visible = False
        '
        'UserTextBox
        '
        Me.UserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTVitalSignBindingSource, "User", True))
        Me.UserTextBox.Enabled = False
        Me.UserTextBox.Location = New System.Drawing.Point(122, 314)
        Me.UserTextBox.MaxLength = 50
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UserTextBox.TabIndex = 31
        Me.UserTextBox.Visible = False
        '
        'MMChartTVitalSignBindingNavigator
        '
        Me.MMChartTVitalSignBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMChartTVitalSignBindingNavigator.BindingSource = Me.MMChartTVitalSignBindingSource
        Me.MMChartTVitalSignBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMChartTVitalSignBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMChartTVitalSignBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel2, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel1, Me.MMChartTVitalSignBindingNavigatorSaveItem})
        Me.MMChartTVitalSignBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMChartTVitalSignBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMChartTVitalSignBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMChartTVitalSignBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMChartTVitalSignBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMChartTVitalSignBindingNavigator.Name = "MMChartTVitalSignBindingNavigator"
        Me.MMChartTVitalSignBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMChartTVitalSignBindingNavigator.Size = New System.Drawing.Size(928, 25)
        Me.MMChartTVitalSignBindingNavigator.TabIndex = 1
        Me.MMChartTVitalSignBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(58, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel2.Text = "     "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel1.Text = "     "
        '
        'MMChartTVitalSignBindingNavigatorSaveItem
        '
        Me.MMChartTVitalSignBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMChartTVitalSignBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMChartTVitalSignBindingNavigatorSaveItem.Name = "MMChartTVitalSignBindingNavigatorSaveItem"
        Me.MMChartTVitalSignBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.MMChartTVitalSignBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MMChartTVitalSignTableAdapter
        '
        Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True
        '
        'VitalSigns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 360)
        Me.Controls.Add(Me.MMChartTVitalSignBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(UserLabel)
        Me.Location = New System.Drawing.Point(205, 85)
        Me.Name = "VitalSigns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vital Signs"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.MMChartTVitalSignDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MMChartTVitalSignBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMChartTVitalSignBindingNavigator.ResumeLayout(False)
        Me.MMChartTVitalSignBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMChartTVitalSignBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartTVitalSignTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter
    Friend WithEvents MMChartTVitalSignBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MMChartTVitalSignBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MMChartTVitalSignDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaseNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TempTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PulseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RespTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SystolicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DistolicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PulseOxTextBox As System.Windows.Forms.TextBox
      Friend WithEvents UserTextBox As System.Windows.Forms.TextBox
      Friend WithEvents cmdPatient As System.Windows.Forms.Button
      Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
      Friend WithEvents TimeStampTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents DistolicR As System.Windows.Forms.RadioButton
    Friend WithEvents WTR As System.Windows.Forms.RadioButton
    Friend WithEvents HTR As System.Windows.Forms.RadioButton
    Friend WithEvents PulseOxR As System.Windows.Forms.RadioButton
    Friend WithEvents PulseR As System.Windows.Forms.RadioButton
    Friend WithEvents RespR As System.Windows.Forms.RadioButton
    Friend WithEvents TempR As System.Windows.Forms.RadioButton
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents SystolicR As System.Windows.Forms.RadioButton
    Friend WithEvents TimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BMITextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Signed As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FLName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LMPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodSugarTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnCalender As System.Windows.Forms.Button
End Class
