<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prescription
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
        Dim RX_IDLabel As System.Windows.Forms.Label
        Dim ChartNumberLabel As System.Windows.Forms.Label
        Dim PatientNameLabel As System.Windows.Forms.Label
        Dim OrderingPhysicianIDLabel As System.Windows.Forms.Label
        Dim PhysicianNameLabel As System.Windows.Forms.Label
        Dim LicenseNumberLabel As System.Windows.Forms.Label
        Dim MedicationLabel As System.Windows.Forms.Label
        Dim DosageLabel As System.Windows.Forms.Label
        Dim NumberOfRefillsLabel As System.Windows.Forms.Label
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim SignerNameLabel As System.Windows.Forms.Label
        Dim NeedDEANoLabel As System.Windows.Forms.Label
        Dim DAENoLabel As System.Windows.Forms.Label
        Dim UserLabel As System.Windows.Forms.Label
        Dim TimeStampLabel As System.Windows.Forms.Label
        Dim SubstituteOkLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim InstructionsLabel As System.Windows.Forms.Label
        Dim CaseNumberLabel As System.Windows.Forms.Label
        Dim MedicationStatusLabel As System.Windows.Forms.Label
        Dim SignesLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prescription))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.RXIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PatientNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tag = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.MedicationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DosageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumberOfRefillsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubstituteOk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Instructions = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MedicationStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChartNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrderingPhysicianIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LicenseNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DAENoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NeedDEANoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.UserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SignerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SigNatureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeStampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMChartRxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.MMDRUGDataGridView = New System.Windows.Forms.DataGridView
        Me.dgvDRGNAME = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvSTRONG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvFORM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMDRUGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ListBox4 = New System.Windows.Forms.ListBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.btnFax = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.MedicationStatusComboBox = New System.Windows.Forms.ComboBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.NumberOfRefillsComboBox = New System.Windows.Forms.ComboBox
        Me.CaseNumberTextBox = New System.Windows.Forms.TextBox
        Me.SigNatureCheckBox = New System.Windows.Forms.CheckBox
        Me.EndDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.StartDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.InstructionsTextBox = New System.Windows.Forms.TextBox
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.cmdDrug = New System.Windows.Forms.Button
        Me.SubstituteOkComboBox = New System.Windows.Forms.ComboBox
        Me.cmdOrdPhy = New System.Windows.Forms.Button
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.RX_IDTextBox = New System.Windows.Forms.TextBox
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox
        Me.PatientNameTextBox = New System.Windows.Forms.TextBox
        Me.OrderingPhysicianIDTextBox = New System.Windows.Forms.TextBox
        Me.PhysicianNameTextBox = New System.Windows.Forms.TextBox
        Me.LicenseNumberTextBox = New System.Windows.Forms.TextBox
        Me.MedicationTextBox = New System.Windows.Forms.TextBox
        Me.DosageTextBox = New System.Windows.Forms.TextBox
        Me.NeedDEANoCheckBox = New System.Windows.Forms.CheckBox
        Me.DAENoTextBox = New System.Windows.Forms.TextBox
        Me.SignerNameTextBox = New System.Windows.Forms.TextBox
        Me.UserTextBox = New System.Windows.Forms.TextBox
        Me.TimeStampDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.MMChartRxBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MMChartRxBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.MMDataDataSet = New MedicalManager.MMDataDataSet
        Me.btnPrintMultiple = New System.Windows.Forms.Button
        Me.btnRefill = New System.Windows.Forms.Button
        Me.txtFaxNumber = New System.Windows.Forms.TextBox
        Me.btnFaxMultiple = New System.Windows.Forms.Button
        Me.btnSelectPharm = New System.Windows.Forms.Button
        Me.MMChartRxTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartRxTableAdapter
        Me.MMComboTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMComboTableAdapter
        Me.MMComboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrescriptionWritingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrescriptionWritingTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.PrescriptionWritingTableAdapter
        Me.MMDRUGTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMDRUGTableAdapter
        Me.MMPrecticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMPrecticeTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMPrecticeTableAdapter
        RX_IDLabel = New System.Windows.Forms.Label
        ChartNumberLabel = New System.Windows.Forms.Label
        PatientNameLabel = New System.Windows.Forms.Label
        OrderingPhysicianIDLabel = New System.Windows.Forms.Label
        PhysicianNameLabel = New System.Windows.Forms.Label
        LicenseNumberLabel = New System.Windows.Forms.Label
        MedicationLabel = New System.Windows.Forms.Label
        DosageLabel = New System.Windows.Forms.Label
        NumberOfRefillsLabel = New System.Windows.Forms.Label
        StartDateLabel = New System.Windows.Forms.Label
        EndDateLabel = New System.Windows.Forms.Label
        SignerNameLabel = New System.Windows.Forms.Label
        NeedDEANoLabel = New System.Windows.Forms.Label
        DAENoLabel = New System.Windows.Forms.Label
        UserLabel = New System.Windows.Forms.Label
        TimeStampLabel = New System.Windows.Forms.Label
        SubstituteOkLabel = New System.Windows.Forms.Label
        QuantityLabel = New System.Windows.Forms.Label
        InstructionsLabel = New System.Windows.Forms.Label
        CaseNumberLabel = New System.Windows.Forms.Label
        MedicationStatusLabel = New System.Windows.Forms.Label
        SignesLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MMDRUGDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDRUGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MMChartRxBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMChartRxBindingNavigator.SuspendLayout()
        CType(Me.MMDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMComboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrescriptionWritingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPrecticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RX_IDLabel
        '
        RX_IDLabel.AutoSize = True
        RX_IDLabel.Location = New System.Drawing.Point(86, 25)
        RX_IDLabel.Name = "RX_IDLabel"
        RX_IDLabel.Size = New System.Drawing.Size(39, 13)
        RX_IDLabel.TabIndex = 34
        RX_IDLabel.Text = "RX ID:"
        '
        'ChartNumberLabel
        '
        ChartNumberLabel.AutoSize = True
        ChartNumberLabel.Location = New System.Drawing.Point(50, 50)
        ChartNumberLabel.Name = "ChartNumberLabel"
        ChartNumberLabel.Size = New System.Drawing.Size(75, 13)
        ChartNumberLabel.TabIndex = 36
        ChartNumberLabel.Text = "Chart Number:"
        '
        'PatientNameLabel
        '
        PatientNameLabel.AutoSize = True
        PatientNameLabel.Location = New System.Drawing.Point(51, 75)
        PatientNameLabel.Name = "PatientNameLabel"
        PatientNameLabel.Size = New System.Drawing.Size(74, 13)
        PatientNameLabel.TabIndex = 38
        PatientNameLabel.Text = "Patient Name:"
        '
        'OrderingPhysicianIDLabel
        '
        OrderingPhysicianIDLabel.AutoSize = True
        OrderingPhysicianIDLabel.Location = New System.Drawing.Point(13, 100)
        OrderingPhysicianIDLabel.Name = "OrderingPhysicianIDLabel"
        OrderingPhysicianIDLabel.Size = New System.Drawing.Size(112, 13)
        OrderingPhysicianIDLabel.TabIndex = 40
        OrderingPhysicianIDLabel.Text = "Ordering Physician ID:"
        '
        'PhysicianNameLabel
        '
        PhysicianNameLabel.AutoSize = True
        PhysicianNameLabel.Location = New System.Drawing.Point(39, 127)
        PhysicianNameLabel.Name = "PhysicianNameLabel"
        PhysicianNameLabel.Size = New System.Drawing.Size(86, 13)
        PhysicianNameLabel.TabIndex = 42
        PhysicianNameLabel.Text = "Physician Name:"
        '
        'LicenseNumberLabel
        '
        LicenseNumberLabel.AutoSize = True
        LicenseNumberLabel.Location = New System.Drawing.Point(38, 152)
        LicenseNumberLabel.Name = "LicenseNumberLabel"
        LicenseNumberLabel.Size = New System.Drawing.Size(87, 13)
        LicenseNumberLabel.TabIndex = 44
        LicenseNumberLabel.Text = "License Number:"
        '
        'MedicationLabel
        '
        MedicationLabel.AutoSize = True
        MedicationLabel.Location = New System.Drawing.Point(63, 282)
        MedicationLabel.Name = "MedicationLabel"
        MedicationLabel.Size = New System.Drawing.Size(62, 13)
        MedicationLabel.TabIndex = 46
        MedicationLabel.Text = "Medication:"
        '
        'DosageLabel
        '
        DosageLabel.AutoSize = True
        DosageLabel.Location = New System.Drawing.Point(78, 308)
        DosageLabel.Name = "DosageLabel"
        DosageLabel.Size = New System.Drawing.Size(47, 13)
        DosageLabel.TabIndex = 48
        DosageLabel.Text = "Dosage:"
        '
        'NumberOfRefillsLabel
        '
        NumberOfRefillsLabel.AutoSize = True
        NumberOfRefillsLabel.Location = New System.Drawing.Point(63, 334)
        NumberOfRefillsLabel.Name = "NumberOfRefillsLabel"
        NumberOfRefillsLabel.Size = New System.Drawing.Size(62, 13)
        NumberOfRefillsLabel.TabIndex = 50
        NumberOfRefillsLabel.Text = "# Of Refills:"
        '
        'StartDateLabel
        '
        StartDateLabel.AutoSize = True
        StartDateLabel.Location = New System.Drawing.Point(67, 230)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(58, 13)
        StartDateLabel.TabIndex = 52
        StartDateLabel.Text = "Start Date:"
        '
        'EndDateLabel
        '
        EndDateLabel.AutoSize = True
        EndDateLabel.Location = New System.Drawing.Point(70, 251)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(55, 13)
        EndDateLabel.TabIndex = 54
        EndDateLabel.Text = "End Date:"
        '
        'SignerNameLabel
        '
        SignerNameLabel.AutoSize = True
        SignerNameLabel.Location = New System.Drawing.Point(696, 252)
        SignerNameLabel.Name = "SignerNameLabel"
        SignerNameLabel.Size = New System.Drawing.Size(71, 13)
        SignerNameLabel.TabIndex = 58
        SignerNameLabel.Text = "Signer Name:"
        '
        'NeedDEANoLabel
        '
        NeedDEANoLabel.AutoSize = True
        NeedDEANoLabel.Location = New System.Drawing.Point(47, 177)
        NeedDEANoLabel.Name = "NeedDEANoLabel"
        NeedDEANoLabel.Size = New System.Drawing.Size(78, 13)
        NeedDEANoLabel.TabIndex = 60
        NeedDEANoLabel.Text = "Need DEA No:"
        '
        'DAENoLabel
        '
        DAENoLabel.AutoSize = True
        DAENoLabel.Location = New System.Drawing.Point(76, 202)
        DAENoLabel.Name = "DAENoLabel"
        DAENoLabel.Size = New System.Drawing.Size(49, 13)
        DAENoLabel.TabIndex = 62
        DAENoLabel.Text = "DEA No:"
        '
        'UserLabel
        '
        UserLabel.AutoSize = True
        UserLabel.Location = New System.Drawing.Point(735, 224)
        UserLabel.Name = "UserLabel"
        UserLabel.Size = New System.Drawing.Size(32, 13)
        UserLabel.TabIndex = 64
        UserLabel.Text = "User:"
        '
        'TimeStampLabel
        '
        TimeStampLabel.AutoSize = True
        TimeStampLabel.Location = New System.Drawing.Point(701, 202)
        TimeStampLabel.Name = "TimeStampLabel"
        TimeStampLabel.Size = New System.Drawing.Size(66, 13)
        TimeStampLabel.TabIndex = 66
        TimeStampLabel.Text = "Time Stamp:"
        '
        'SubstituteOkLabel
        '
        SubstituteOkLabel.AutoSize = True
        SubstituteOkLabel.Location = New System.Drawing.Point(65, 360)
        SubstituteOkLabel.Name = "SubstituteOkLabel"
        SubstituteOkLabel.Size = New System.Drawing.Size(60, 13)
        SubstituteOkLabel.TabIndex = 128
        SubstituteOkLabel.Text = "Substitute :"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(191, 334)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 130
        QuantityLabel.Text = "Quantity:"
        '
        'InstructionsLabel
        '
        InstructionsLabel.AutoSize = True
        InstructionsLabel.Location = New System.Drawing.Point(61, 389)
        InstructionsLabel.Name = "InstructionsLabel"
        InstructionsLabel.Size = New System.Drawing.Size(64, 13)
        InstructionsLabel.TabIndex = 131
        InstructionsLabel.Text = "Instructions:"
        '
        'CaseNumberLabel
        '
        CaseNumberLabel.AutoSize = True
        CaseNumberLabel.Location = New System.Drawing.Point(227, 25)
        CaseNumberLabel.Name = "CaseNumberLabel"
        CaseNumberLabel.Size = New System.Drawing.Size(51, 13)
        CaseNumberLabel.TabIndex = 131
        CaseNumberLabel.Text = "Case No:"
        '
        'MedicationStatusLabel
        '
        MedicationStatusLabel.AutoSize = True
        MedicationStatusLabel.Location = New System.Drawing.Point(30, 472)
        MedicationStatusLabel.Name = "MedicationStatusLabel"
        MedicationStatusLabel.Size = New System.Drawing.Size(95, 13)
        MedicationStatusLabel.TabIndex = 141
        MedicationStatusLabel.Text = "Medication Status:"
        '
        'SignesLabel
        '
        SignesLabel.AutoSize = True
        SignesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SignesLabel.ForeColor = System.Drawing.Color.Red
        SignesLabel.Location = New System.Drawing.Point(69, 3)
        SignesLabel.Name = "SignesLabel"
        SignesLabel.Size = New System.Drawing.Size(56, 13)
        SignesLabel.TabIndex = 145
        SignesLabel.Text = "Rx Signed"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1009, 531)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1001, 505)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RXIDDataGridViewTextBoxColumn, Me.PatientNameDataGridViewTextBoxColumn, Me.Tag, Me.MedicationDataGridViewTextBoxColumn, Me.DosageDataGridViewTextBoxColumn, Me.Quantity, Me.NumberOfRefillsDataGridViewTextBoxColumn, Me.SubstituteOk, Me.Instructions, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn, Me.CaseNumber, Me.MedicationStatus, Me.ChartNumberDataGridViewTextBoxColumn, Me.OrderingPhysicianIDDataGridViewTextBoxColumn, Me.PhysicianNameDataGridViewTextBoxColumn, Me.LicenseNumberDataGridViewTextBoxColumn, Me.DAENoDataGridViewTextBoxColumn, Me.NeedDEANoDataGridViewCheckBoxColumn, Me.UserDataGridViewTextBoxColumn, Me.SignerNameDataGridViewTextBoxColumn, Me.SigNatureDataGridViewTextBoxColumn, Me.TimeStampDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MMChartRxBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(991, 493)
        Me.DataGridView1.TabIndex = 0
        '
        'RXIDDataGridViewTextBoxColumn
        '
        Me.RXIDDataGridViewTextBoxColumn.DataPropertyName = "RX ID"
        Me.RXIDDataGridViewTextBoxColumn.HeaderText = "RX ID"
        Me.RXIDDataGridViewTextBoxColumn.Name = "RXIDDataGridViewTextBoxColumn"
        Me.RXIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.RXIDDataGridViewTextBoxColumn.Visible = False
        '
        'PatientNameDataGridViewTextBoxColumn
        '
        Me.PatientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName"
        Me.PatientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name"
        Me.PatientNameDataGridViewTextBoxColumn.Name = "PatientNameDataGridViewTextBoxColumn"
        '
        'Tag
        '
        Me.Tag.HeaderText = "Tag"
        Me.Tag.Name = "Tag"
        Me.Tag.Width = 40
        '
        'MedicationDataGridViewTextBoxColumn
        '
        Me.MedicationDataGridViewTextBoxColumn.DataPropertyName = "Medication"
        Me.MedicationDataGridViewTextBoxColumn.HeaderText = "Medication"
        Me.MedicationDataGridViewTextBoxColumn.Name = "MedicationDataGridViewTextBoxColumn"
        Me.MedicationDataGridViewTextBoxColumn.Width = 175
        '
        'DosageDataGridViewTextBoxColumn
        '
        Me.DosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage"
        Me.DosageDataGridViewTextBoxColumn.HeaderText = "Dosage"
        Me.DosageDataGridViewTextBoxColumn.Name = "DosageDataGridViewTextBoxColumn"
        Me.DosageDataGridViewTextBoxColumn.Width = 125
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Width = 35
        '
        'NumberOfRefillsDataGridViewTextBoxColumn
        '
        Me.NumberOfRefillsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRefills"
        Me.NumberOfRefillsDataGridViewTextBoxColumn.HeaderText = "Refills"
        Me.NumberOfRefillsDataGridViewTextBoxColumn.Name = "NumberOfRefillsDataGridViewTextBoxColumn"
        Me.NumberOfRefillsDataGridViewTextBoxColumn.Width = 35
        '
        'SubstituteOk
        '
        Me.SubstituteOk.DataPropertyName = "SubstituteOk"
        Me.SubstituteOk.HeaderText = "Substitute"
        Me.SubstituteOk.Name = "SubstituteOk"
        '
        'Instructions
        '
        Me.Instructions.DataPropertyName = "Instructions"
        Me.Instructions.HeaderText = "Instructions"
        Me.Instructions.Name = "Instructions"
        Me.Instructions.Width = 75
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.StartDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "StartDate"
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        Me.StartDateDataGridViewTextBoxColumn.Width = 69
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.EndDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.EndDateDataGridViewTextBoxColumn.HeaderText = "EndDate"
        Me.EndDateDataGridViewTextBoxColumn.Name = "EndDateDataGridViewTextBoxColumn"
        Me.EndDateDataGridViewTextBoxColumn.Width = 65
        '
        'CaseNumber
        '
        Me.CaseNumber.DataPropertyName = "CaseNumber"
        Me.CaseNumber.HeaderText = "Case#"
        Me.CaseNumber.Name = "CaseNumber"
        Me.CaseNumber.Width = 45
        '
        'MedicationStatus
        '
        Me.MedicationStatus.DataPropertyName = "MedicationStatus"
        Me.MedicationStatus.HeaderText = "RXStatus"
        Me.MedicationStatus.Name = "MedicationStatus"
        Me.MedicationStatus.Width = 75
        '
        'ChartNumberDataGridViewTextBoxColumn
        '
        Me.ChartNumberDataGridViewTextBoxColumn.DataPropertyName = "ChartNumber"
        Me.ChartNumberDataGridViewTextBoxColumn.HeaderText = "Chart#"
        Me.ChartNumberDataGridViewTextBoxColumn.Name = "ChartNumberDataGridViewTextBoxColumn"
        Me.ChartNumberDataGridViewTextBoxColumn.Width = 60
        '
        'OrderingPhysicianIDDataGridViewTextBoxColumn
        '
        Me.OrderingPhysicianIDDataGridViewTextBoxColumn.DataPropertyName = "OrderingPhysicianID"
        Me.OrderingPhysicianIDDataGridViewTextBoxColumn.HeaderText = "OrderingPhyID"
        Me.OrderingPhysicianIDDataGridViewTextBoxColumn.Name = "OrderingPhysicianIDDataGridViewTextBoxColumn"
        Me.OrderingPhysicianIDDataGridViewTextBoxColumn.Width = 70
        '
        'PhysicianNameDataGridViewTextBoxColumn
        '
        Me.PhysicianNameDataGridViewTextBoxColumn.DataPropertyName = "PhysicianName"
        Me.PhysicianNameDataGridViewTextBoxColumn.HeaderText = "PhysicianName"
        Me.PhysicianNameDataGridViewTextBoxColumn.Name = "PhysicianNameDataGridViewTextBoxColumn"
        '
        'LicenseNumberDataGridViewTextBoxColumn
        '
        Me.LicenseNumberDataGridViewTextBoxColumn.DataPropertyName = "LicenseNumber"
        Me.LicenseNumberDataGridViewTextBoxColumn.HeaderText = "License #"
        Me.LicenseNumberDataGridViewTextBoxColumn.Name = "LicenseNumberDataGridViewTextBoxColumn"
        Me.LicenseNumberDataGridViewTextBoxColumn.Width = 60
        '
        'DAENoDataGridViewTextBoxColumn
        '
        Me.DAENoDataGridViewTextBoxColumn.DataPropertyName = "DAENo"
        Me.DAENoDataGridViewTextBoxColumn.HeaderText = "DAENo"
        Me.DAENoDataGridViewTextBoxColumn.Name = "DAENoDataGridViewTextBoxColumn"
        '
        'NeedDEANoDataGridViewCheckBoxColumn
        '
        Me.NeedDEANoDataGridViewCheckBoxColumn.DataPropertyName = "NeedDEANo"
        Me.NeedDEANoDataGridViewCheckBoxColumn.HeaderText = "NeedDEANo"
        Me.NeedDEANoDataGridViewCheckBoxColumn.Name = "NeedDEANoDataGridViewCheckBoxColumn"
        '
        'UserDataGridViewTextBoxColumn
        '
        Me.UserDataGridViewTextBoxColumn.DataPropertyName = "User"
        Me.UserDataGridViewTextBoxColumn.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn.Name = "UserDataGridViewTextBoxColumn"
        '
        'SignerNameDataGridViewTextBoxColumn
        '
        Me.SignerNameDataGridViewTextBoxColumn.DataPropertyName = "SignerName"
        Me.SignerNameDataGridViewTextBoxColumn.HeaderText = "SignerName"
        Me.SignerNameDataGridViewTextBoxColumn.Name = "SignerNameDataGridViewTextBoxColumn"
        Me.SignerNameDataGridViewTextBoxColumn.Width = 70
        '
        'SigNatureDataGridViewTextBoxColumn
        '
        Me.SigNatureDataGridViewTextBoxColumn.DataPropertyName = "SigNature"
        Me.SigNatureDataGridViewTextBoxColumn.HeaderText = "Signature"
        Me.SigNatureDataGridViewTextBoxColumn.Name = "SigNatureDataGridViewTextBoxColumn"
        Me.SigNatureDataGridViewTextBoxColumn.Width = 70
        '
        'TimeStampDataGridViewTextBoxColumn
        '
        Me.TimeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp"
        Me.TimeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp"
        Me.TimeStampDataGridViewTextBoxColumn.Name = "TimeStampDataGridViewTextBoxColumn"
        '
        'MMChartRxBindingSource
        '
        Me.MMChartRxBindingSource.DataMember = "MMChartRx"
        Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(SignesLabel)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(MedicationStatusLabel)
        Me.TabPage2.Controls.Add(Me.MedicationStatusComboBox)
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Controls.Add(Me.NumberOfRefillsComboBox)
        Me.TabPage2.Controls.Add(CaseNumberLabel)
        Me.TabPage2.Controls.Add(Me.CaseNumberTextBox)
        Me.TabPage2.Controls.Add(Me.SigNatureCheckBox)
        Me.TabPage2.Controls.Add(Me.EndDateMaskedTextBox)
        Me.TabPage2.Controls.Add(Me.StartDateMaskedTextBox)
        Me.TabPage2.Controls.Add(InstructionsLabel)
        Me.TabPage2.Controls.Add(Me.InstructionsTextBox)
        Me.TabPage2.Controls.Add(QuantityLabel)
        Me.TabPage2.Controls.Add(Me.QuantityTextBox)
        Me.TabPage2.Controls.Add(Me.cmdDrug)
        Me.TabPage2.Controls.Add(SubstituteOkLabel)
        Me.TabPage2.Controls.Add(Me.SubstituteOkComboBox)
        Me.TabPage2.Controls.Add(Me.cmdOrdPhy)
        Me.TabPage2.Controls.Add(Me.cmdPatient)
        Me.TabPage2.Controls.Add(RX_IDLabel)
        Me.TabPage2.Controls.Add(Me.RX_IDTextBox)
        Me.TabPage2.Controls.Add(ChartNumberLabel)
        Me.TabPage2.Controls.Add(Me.ChartNumberTextBox)
        Me.TabPage2.Controls.Add(PatientNameLabel)
        Me.TabPage2.Controls.Add(Me.PatientNameTextBox)
        Me.TabPage2.Controls.Add(OrderingPhysicianIDLabel)
        Me.TabPage2.Controls.Add(Me.OrderingPhysicianIDTextBox)
        Me.TabPage2.Controls.Add(PhysicianNameLabel)
        Me.TabPage2.Controls.Add(Me.PhysicianNameTextBox)
        Me.TabPage2.Controls.Add(LicenseNumberLabel)
        Me.TabPage2.Controls.Add(Me.LicenseNumberTextBox)
        Me.TabPage2.Controls.Add(MedicationLabel)
        Me.TabPage2.Controls.Add(Me.MedicationTextBox)
        Me.TabPage2.Controls.Add(DosageLabel)
        Me.TabPage2.Controls.Add(Me.DosageTextBox)
        Me.TabPage2.Controls.Add(NumberOfRefillsLabel)
        Me.TabPage2.Controls.Add(StartDateLabel)
        Me.TabPage2.Controls.Add(EndDateLabel)
        Me.TabPage2.Controls.Add(NeedDEANoLabel)
        Me.TabPage2.Controls.Add(Me.NeedDEANoCheckBox)
        Me.TabPage2.Controls.Add(DAENoLabel)
        Me.TabPage2.Controls.Add(Me.DAENoTextBox)
        Me.TabPage2.Controls.Add(SignerNameLabel)
        Me.TabPage2.Controls.Add(Me.SignerNameTextBox)
        Me.TabPage2.Controls.Add(UserLabel)
        Me.TabPage2.Controls.Add(Me.UserTextBox)
        Me.TabPage2.Controls.Add(TimeStampLabel)
        Me.TabPage2.Controls.Add(Me.TimeStampDateTimePicker)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1001, 505)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MMDRUGDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(398, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 492)
        Me.GroupBox2.TabIndex = 146
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quick Rx Pickup"
        '
        'MMDRUGDataGridView
        '
        Me.MMDRUGDataGridView.AllowUserToAddRows = False
        Me.MMDRUGDataGridView.AllowUserToDeleteRows = False
        Me.MMDRUGDataGridView.AllowUserToResizeRows = False
        Me.MMDRUGDataGridView.AutoGenerateColumns = False
        Me.MMDRUGDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MMDRUGDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMDRUGDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.MMDRUGDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvDRGNAME, Me.dgvSTRONG, Me.dgvFORM})
        Me.MMDRUGDataGridView.DataSource = Me.MMDRUGBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MMDRUGDataGridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.MMDRUGDataGridView.Location = New System.Drawing.Point(9, 21)
        Me.MMDRUGDataGridView.Name = "MMDRUGDataGridView"
        Me.MMDRUGDataGridView.Size = New System.Drawing.Size(265, 459)
        Me.MMDRUGDataGridView.TabIndex = 145
        '
        'dgvDRGNAME
        '
        Me.dgvDRGNAME.DataPropertyName = "DRGNAME"
        Me.dgvDRGNAME.HeaderText = "DRGNAME"
        Me.dgvDRGNAME.Name = "dgvDRGNAME"
        '
        'dgvSTRONG
        '
        Me.dgvSTRONG.DataPropertyName = "STRONG"
        Me.dgvSTRONG.HeaderText = "STRONG"
        Me.dgvSTRONG.Name = "dgvSTRONG"
        Me.dgvSTRONG.Width = 50
        '
        'dgvFORM
        '
        Me.dgvFORM.DataPropertyName = "FORM"
        Me.dgvFORM.HeaderText = "FORM"
        Me.dgvFORM.Name = "dgvFORM"
        Me.dgvFORM.Width = 50
        '
        'MMDRUGBindingSource
        '
        Me.MMDRUGBindingSource.DataMember = "MMDRUG"
        Me.MMDRUGBindingSource.DataSource = Me.MMDataDataSet1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox4)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.ListBox3)
        Me.GroupBox1.Controls.Add(Me.btnFax)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(699, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 492)
        Me.GroupBox1.TabIndex = 144
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Construct Dosage:"
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(175, 21)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(73, 459)
        Me.ListBox4.TabIndex = 141
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(21, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(73, 459)
        Me.ListBox1.TabIndex = 138
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(98, 21)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(73, 459)
        Me.ListBox3.TabIndex = 140
        '
        'btnFax
        '
        Me.btnFax.Location = New System.Drawing.Point(209, 433)
        Me.btnFax.Name = "btnFax"
        Me.btnFax.Size = New System.Drawing.Size(39, 23)
        Me.btnFax.TabIndex = 7
        Me.btnFax.Text = "Fax"
        Me.btnFax.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(203, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'MedicationStatusComboBox
        '
        Me.MedicationStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "MedicationStatus", True))
        Me.MedicationStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MedicationStatusComboBox.FormattingEnabled = True
        Me.MedicationStatusComboBox.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.MedicationStatusComboBox.Location = New System.Drawing.Point(131, 469)
        Me.MedicationStatusComboBox.Name = "MedicationStatusComboBox"
        Me.MedicationStatusComboBox.Size = New System.Drawing.Size(198, 21)
        Me.MedicationStatusComboBox.TabIndex = 6
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(982, 8)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(10, 485)
        Me.ListBox2.TabIndex = 139
        Me.ListBox2.Visible = False
        '
        'NumberOfRefillsComboBox
        '
        Me.NumberOfRefillsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "NumberOfRefills", True))
        Me.NumberOfRefillsComboBox.FormattingEnabled = True
        Me.NumberOfRefillsComboBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.NumberOfRefillsComboBox.Location = New System.Drawing.Point(131, 330)
        Me.NumberOfRefillsComboBox.Name = "NumberOfRefillsComboBox"
        Me.NumberOfRefillsComboBox.Size = New System.Drawing.Size(54, 21)
        Me.NumberOfRefillsComboBox.TabIndex = 2
        '
        'CaseNumberTextBox
        '
        Me.CaseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "CaseNumber", True))
        Me.CaseNumberTextBox.Enabled = False
        Me.CaseNumberTextBox.Location = New System.Drawing.Point(284, 21)
        Me.CaseNumberTextBox.Name = "CaseNumberTextBox"
        Me.CaseNumberTextBox.Size = New System.Drawing.Size(45, 20)
        Me.CaseNumberTextBox.TabIndex = 132
        '
        'SigNatureCheckBox
        '
        Me.SigNatureCheckBox.AutoSize = True
        Me.SigNatureCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "SigNature", True))
        Me.SigNatureCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MMChartRxBindingSource, "SigNature", True))
        Me.SigNatureCheckBox.Enabled = False
        Me.SigNatureCheckBox.Location = New System.Drawing.Point(131, 3)
        Me.SigNatureCheckBox.Name = "SigNatureCheckBox"
        Me.SigNatureCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.SigNatureCheckBox.TabIndex = 58
        Me.SigNatureCheckBox.UseVisualStyleBackColor = True
        '
        'EndDateMaskedTextBox
        '
        Me.EndDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "EndDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "MM/dd/yyyy"))
        Me.EndDateMaskedTextBox.Location = New System.Drawing.Point(131, 249)
        Me.EndDateMaskedTextBox.Mask = "00/00/0000"
        Me.EndDateMaskedTextBox.Name = "EndDateMaskedTextBox"
        Me.EndDateMaskedTextBox.Size = New System.Drawing.Size(80, 20)
        Me.EndDateMaskedTextBox.TabIndex = 57
        Me.EndDateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'StartDateMaskedTextBox
        '
        Me.StartDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "StartDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "MM/dd/yyyy"))
        Me.StartDateMaskedTextBox.Location = New System.Drawing.Point(131, 223)
        Me.StartDateMaskedTextBox.Mask = "00/00/0000"
        Me.StartDateMaskedTextBox.Name = "StartDateMaskedTextBox"
        Me.StartDateMaskedTextBox.Size = New System.Drawing.Size(80, 20)
        Me.StartDateMaskedTextBox.TabIndex = 55
        Me.StartDateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'InstructionsTextBox
        '
        Me.InstructionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "Instructions", True))
        Me.InstructionsTextBox.Location = New System.Drawing.Point(131, 383)
        Me.InstructionsTextBox.MaxLength = 150
        Me.InstructionsTextBox.Multiline = True
        Me.InstructionsTextBox.Name = "InstructionsTextBox"
        Me.InstructionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InstructionsTextBox.Size = New System.Drawing.Size(198, 80)
        Me.InstructionsTextBox.TabIndex = 5
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(246, 330)
        Me.QuantityTextBox.MaxLength = 3
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(85, 20)
        Me.QuantityTextBox.TabIndex = 3
        '
        'cmdDrug
        '
        Me.cmdDrug.Location = New System.Drawing.Point(226, 246)
        Me.cmdDrug.Name = "cmdDrug"
        Me.cmdDrug.Size = New System.Drawing.Size(105, 23)
        Me.cmdDrug.TabIndex = 130
        Me.cmdDrug.Text = "Select Drug"
        Me.cmdDrug.UseVisualStyleBackColor = True
        '
        'SubstituteOkComboBox
        '
        Me.SubstituteOkComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "SubstituteOk", True))
        Me.SubstituteOkComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubstituteOkComboBox.FormattingEnabled = True
        Me.SubstituteOkComboBox.Items.AddRange(New Object() {"", "SUBSTITUTION PERMITTED", "DISPENSE AS WRITTEN"})
        Me.SubstituteOkComboBox.Location = New System.Drawing.Point(131, 356)
        Me.SubstituteOkComboBox.MaxLength = 25
        Me.SubstituteOkComboBox.Name = "SubstituteOkComboBox"
        Me.SubstituteOkComboBox.Size = New System.Drawing.Size(200, 21)
        Me.SubstituteOkComboBox.TabIndex = 4
        '
        'cmdOrdPhy
        '
        Me.cmdOrdPhy.Location = New System.Drawing.Point(226, 96)
        Me.cmdOrdPhy.Name = "cmdOrdPhy"
        Me.cmdOrdPhy.Size = New System.Drawing.Size(105, 23)
        Me.cmdOrdPhy.TabIndex = 128
        Me.cmdOrdPhy.Text = "Ordering Physician"
        Me.cmdOrdPhy.UseVisualStyleBackColor = True
        '
        'cmdPatient
        '
        Me.cmdPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPatient.Location = New System.Drawing.Point(226, 46)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(105, 23)
        Me.cmdPatient.TabIndex = 127
        Me.cmdPatient.Text = "Select Patient"
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'RX_IDTextBox
        '
        Me.RX_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "RX ID", True))
        Me.RX_IDTextBox.Enabled = False
        Me.RX_IDTextBox.Location = New System.Drawing.Point(131, 21)
        Me.RX_IDTextBox.Name = "RX_IDTextBox"
        Me.RX_IDTextBox.Size = New System.Drawing.Size(89, 20)
        Me.RX_IDTextBox.TabIndex = 35
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "ChartNumber", True))
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(131, 46)
        Me.ChartNumberTextBox.MaxLength = 8
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(89, 20)
        Me.ChartNumberTextBox.TabIndex = 37
        '
        'PatientNameTextBox
        '
        Me.PatientNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "PatientName", True))
        Me.PatientNameTextBox.Location = New System.Drawing.Point(131, 71)
        Me.PatientNameTextBox.MaxLength = 50
        Me.PatientNameTextBox.Name = "PatientNameTextBox"
        Me.PatientNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PatientNameTextBox.TabIndex = 39
        '
        'OrderingPhysicianIDTextBox
        '
        Me.OrderingPhysicianIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "OrderingPhysicianID", True))
        Me.OrderingPhysicianIDTextBox.Location = New System.Drawing.Point(131, 96)
        Me.OrderingPhysicianIDTextBox.MaxLength = 50
        Me.OrderingPhysicianIDTextBox.Name = "OrderingPhysicianIDTextBox"
        Me.OrderingPhysicianIDTextBox.Size = New System.Drawing.Size(89, 20)
        Me.OrderingPhysicianIDTextBox.TabIndex = 41
        '
        'PhysicianNameTextBox
        '
        Me.PhysicianNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "PhysicianName", True))
        Me.PhysicianNameTextBox.Location = New System.Drawing.Point(131, 123)
        Me.PhysicianNameTextBox.MaxLength = 50
        Me.PhysicianNameTextBox.Name = "PhysicianNameTextBox"
        Me.PhysicianNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhysicianNameTextBox.TabIndex = 43
        '
        'LicenseNumberTextBox
        '
        Me.LicenseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "LicenseNumber", True))
        Me.LicenseNumberTextBox.Location = New System.Drawing.Point(131, 148)
        Me.LicenseNumberTextBox.MaxLength = 20
        Me.LicenseNumberTextBox.Name = "LicenseNumberTextBox"
        Me.LicenseNumberTextBox.Size = New System.Drawing.Size(89, 20)
        Me.LicenseNumberTextBox.TabIndex = 45
        '
        'MedicationTextBox
        '
        Me.MedicationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "Medication", True))
        Me.MedicationTextBox.Location = New System.Drawing.Point(131, 278)
        Me.MedicationTextBox.MaxLength = 50
        Me.MedicationTextBox.Name = "MedicationTextBox"
        Me.MedicationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MedicationTextBox.TabIndex = 0
        '
        'DosageTextBox
        '
        Me.DosageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "Dosage", True))
        Me.DosageTextBox.Location = New System.Drawing.Point(131, 304)
        Me.DosageTextBox.MaxLength = 30
        Me.DosageTextBox.Name = "DosageTextBox"
        Me.DosageTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DosageTextBox.TabIndex = 1
        '
        'NeedDEANoCheckBox
        '
        Me.NeedDEANoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MMChartRxBindingSource, "NeedDEANo", True))
        Me.NeedDEANoCheckBox.Location = New System.Drawing.Point(131, 173)
        Me.NeedDEANoCheckBox.Name = "NeedDEANoCheckBox"
        Me.NeedDEANoCheckBox.Size = New System.Drawing.Size(27, 24)
        Me.NeedDEANoCheckBox.TabIndex = 61
        '
        'DAENoTextBox
        '
        Me.DAENoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "DAENo", True))
        Me.DAENoTextBox.Location = New System.Drawing.Point(131, 198)
        Me.DAENoTextBox.MaxLength = 30
        Me.DAENoTextBox.Name = "DAENoTextBox"
        Me.DAENoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DAENoTextBox.TabIndex = 63
        '
        'SignerNameTextBox
        '
        Me.SignerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "SignerName", True))
        Me.SignerNameTextBox.Location = New System.Drawing.Point(773, 246)
        Me.SignerNameTextBox.MaxLength = 50
        Me.SignerNameTextBox.Name = "SignerNameTextBox"
        Me.SignerNameTextBox.Size = New System.Drawing.Size(83, 20)
        Me.SignerNameTextBox.TabIndex = 59
        '
        'UserTextBox
        '
        Me.UserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartRxBindingSource, "User", True))
        Me.UserTextBox.Location = New System.Drawing.Point(773, 224)
        Me.UserTextBox.MaxLength = 50
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(83, 20)
        Me.UserTextBox.TabIndex = 65
        '
        'TimeStampDateTimePicker
        '
        Me.TimeStampDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MMChartRxBindingSource, "TimeStamp", True))
        Me.TimeStampDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TimeStampDateTimePicker.Location = New System.Drawing.Point(773, 198)
        Me.TimeStampDateTimePicker.Name = "TimeStampDateTimePicker"
        Me.TimeStampDateTimePicker.Size = New System.Drawing.Size(83, 20)
        Me.TimeStampDateTimePicker.TabIndex = 67
        '
        'MMChartRxBindingNavigator
        '
        Me.MMChartRxBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMChartRxBindingNavigator.BindingSource = Me.MMChartRxBindingSource
        Me.MMChartRxBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMChartRxBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMChartRxBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripSeparator7, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator8, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2, Me.MMChartRxBindingNavigatorSaveItem, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.ToolStripSeparator4, Me.txtFind, Me.ToolStripSeparator5, Me.ToolStripLabel3, Me.ToolStripSeparator6, Me.cmbFilter})
        Me.MMChartRxBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMChartRxBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMChartRxBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMChartRxBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMChartRxBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMChartRxBindingNavigator.Name = "MMChartRxBindingNavigator"
        Me.MMChartRxBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMChartRxBindingNavigator.Size = New System.Drawing.Size(1012, 25)
        Me.MMChartRxBindingNavigator.TabIndex = 1
        Me.MMChartRxBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
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
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
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
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MMChartRxBindingNavigatorSaveItem
        '
        Me.MMChartRxBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MMChartRxBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMChartRxBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMChartRxBindingNavigatorSaveItem.Name = "MMChartRxBindingNavigatorSaveItem"
        Me.MMChartRxBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MMChartRxBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(27, 22)
        Me.ToolStripLabel2.Text = "Find"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'txtFind
        '
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel3.Text = "Criteria"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'cmbFilter
        '
        Me.cmbFilter.AutoCompleteCustomSource.AddRange(New String() {"ChartNumber", "PatientName"})
        Me.cmbFilter.Items.AddRange(New Object() {"Medication"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 25)
        '
        'MMDataDataSet
        '
        Me.MMDataDataSet.DataSetName = "MMDataDataSet"
        Me.MMDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnPrintMultiple
        '
        Me.btnPrintMultiple.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnPrintMultiple.Location = New System.Drawing.Point(671, 0)
        Me.btnPrintMultiple.Name = "btnPrintMultiple"
        Me.btnPrintMultiple.Size = New System.Drawing.Size(44, 23)
        Me.btnPrintMultiple.TabIndex = 3
        Me.btnPrintMultiple.Text = "Print"
        Me.btnPrintMultiple.UseVisualStyleBackColor = True
        '
        'btnRefill
        '
        Me.btnRefill.Location = New System.Drawing.Point(624, 0)
        Me.btnRefill.Name = "btnRefill"
        Me.btnRefill.Size = New System.Drawing.Size(44, 23)
        Me.btnRefill.TabIndex = 4
        Me.btnRefill.Text = "Refill"
        Me.btnRefill.UseVisualStyleBackColor = True
        '
        'txtFaxNumber
        '
        Me.txtFaxNumber.Location = New System.Drawing.Point(893, 2)
        Me.txtFaxNumber.Name = "txtFaxNumber"
        Me.txtFaxNumber.Size = New System.Drawing.Size(79, 20)
        Me.txtFaxNumber.TabIndex = 8
        '
        'btnFaxMultiple
        '
        Me.btnFaxMultiple.Location = New System.Drawing.Point(973, 1)
        Me.btnFaxMultiple.Name = "btnFaxMultiple"
        Me.btnFaxMultiple.Size = New System.Drawing.Size(38, 23)
        Me.btnFaxMultiple.TabIndex = 9
        Me.btnFaxMultiple.Text = "Fax"
        Me.btnFaxMultiple.UseVisualStyleBackColor = True
        '
        'btnSelectPharm
        '
        Me.btnSelectPharm.Location = New System.Drawing.Point(808, 0)
        Me.btnSelectPharm.Name = "btnSelectPharm"
        Me.btnSelectPharm.Size = New System.Drawing.Size(84, 23)
        Me.btnSelectPharm.TabIndex = 10
        Me.btnSelectPharm.Text = "Pharm Pickup"
        Me.btnSelectPharm.UseVisualStyleBackColor = True
        '
        'MMChartRxTableAdapter
        '
        Me.MMChartRxTableAdapter.ClearBeforeFill = True
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
        'PrescriptionWritingBindingSource
        '
        Me.PrescriptionWritingBindingSource.DataMember = "PrescriptionWriting"
        Me.PrescriptionWritingBindingSource.DataSource = Me.MMDataDataSet1
        '
        'PrescriptionWritingTableAdapter
        '
        Me.PrescriptionWritingTableAdapter.ClearBeforeFill = True
        '
        'MMDRUGTableAdapter
        '
        Me.MMDRUGTableAdapter.ClearBeforeFill = True
        '
        'MMPrecticeBindingSource
        '
        Me.MMPrecticeBindingSource.DataMember = "MMPrectice"
        Me.MMPrecticeBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMPrecticeTableAdapter
        '
        Me.MMPrecticeTableAdapter.ClearBeforeFill = True
        '
        'Prescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 559)
        Me.Controls.Add(Me.btnSelectPharm)
        Me.Controls.Add(Me.btnFaxMultiple)
        Me.Controls.Add(Me.txtFaxNumber)
        Me.Controls.Add(Me.btnRefill)
        Me.Controls.Add(Me.btnPrintMultiple)
        Me.Controls.Add(Me.MMChartRxBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(205, 85)
        Me.Name = "Prescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prescription"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.MMDRUGDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDRUGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.MMChartRxBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMChartRxBindingNavigator.ResumeLayout(False)
        Me.MMChartRxBindingNavigator.PerformLayout()
        CType(Me.MMDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMComboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrescriptionWritingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPrecticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMDataDataSet As MedicalManager.MMDataDataSet
    Friend WithEvents MMChartRxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartRxBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMChartRxBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RX_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderingPhysicianIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhysicianNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LicenseNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MedicationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DosageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SignerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NeedDEANoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DAENoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimeStampDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMChartRxTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartRxTableAdapter
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents cmdOrdPhy As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SubstituteOkComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdDrug As System.Windows.Forms.Button
    Friend WithEvents InstructionsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EndDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents SigNatureCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CaseNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumberOfRefillsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrintMultiple As System.Windows.Forms.Button
    Friend WithEvents btnRefill As System.Windows.Forms.Button
    Friend WithEvents MMComboTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMComboTableAdapter
    Friend WithEvents MMComboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents MedicationStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFaxNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnFax As System.Windows.Forms.Button
    Friend WithEvents PrescriptionWritingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrescriptionWritingTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.PrescriptionWritingTableAdapter
    Friend WithEvents btnFaxMultiple As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MMDRUGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDRUGTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMDRUGTableAdapter
    Friend WithEvents MMDRUGDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDRGNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvSTRONG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvFORM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MMPrecticeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMPrecticeTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMPrecticeTableAdapter
    Friend WithEvents btnSelectPharm As System.Windows.Forms.Button
    Friend WithEvents RXIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PatientNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tag As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MedicationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DosageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfRefillsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubstituteOk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Instructions As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicationStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChartNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderingPhysicianIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LicenseNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DAENoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NeedDEANoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SignerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SigNatureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeStampDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
