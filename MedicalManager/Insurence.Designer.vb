<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insurence
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
        Dim CodeLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Street1Label As System.Windows.Forms.Label
        Dim Street2Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim ExtensionLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim PracticeIDNumberLabel As System.Windows.Forms.Label
        Dim PlanNameLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Insurence))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgInsurence = New System.Windows.Forms.DataGridView
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Street1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Street2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ZipCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExtensionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PracticeIDNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlanNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMINSURENCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.FaxMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.PlanNameTextBox = New System.Windows.Forms.TextBox
        Me.PracticeIDNumberTextBox = New System.Windows.Forms.TextBox
        Me.ExtensionTextBox = New System.Windows.Forms.TextBox
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox
        Me.StateTextBox = New System.Windows.Forms.TextBox
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.Street2TextBox = New System.Windows.Forms.TextBox
        Me.Street1TextBox = New System.Windows.Forms.TextBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.CodeTextBox = New System.Windows.Forms.TextBox
        Me.MMINSURENCEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MMINSURENCEBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.MMINSURENCETableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMINSURENCETableAdapter
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        CodeLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        Street1Label = New System.Windows.Forms.Label
        Street2Label = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        StateLabel = New System.Windows.Forms.Label
        ZipCodeLabel = New System.Windows.Forms.Label
        PhoneLabel = New System.Windows.Forms.Label
        ExtensionLabel = New System.Windows.Forms.Label
        FaxLabel = New System.Windows.Forms.Label
        PracticeIDNumberLabel = New System.Windows.Forms.Label
        PlanNameLabel = New System.Windows.Forms.Label
        TypeLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgInsurence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMINSURENCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMINSURENCEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMINSURENCEBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(87, 92)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(35, 13)
        CodeLabel.TabIndex = 0
        CodeLabel.Text = "Code:"
        AddHandler CodeLabel.Click, AddressOf Me.CodeLabel_Click
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(84, 118)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Name:"
        AddHandler NameLabel.Click, AddressOf Me.NameLabel_Click
        '
        'Street1Label
        '
        Street1Label.AutoSize = True
        Street1Label.Location = New System.Drawing.Point(65, 144)
        Street1Label.Name = "Street1Label"
        Street1Label.Size = New System.Drawing.Size(57, 13)
        Street1Label.TabIndex = 4
        Street1Label.Text = "Address 1:"
        AddHandler Street1Label.Click, AddressOf Me.Street1Label_Click
        '
        'Street2Label
        '
        Street2Label.AutoSize = True
        Street2Label.Location = New System.Drawing.Point(65, 170)
        Street2Label.Name = "Street2Label"
        Street2Label.Size = New System.Drawing.Size(57, 13)
        Street2Label.TabIndex = 6
        Street2Label.Text = "Address 2:"
        AddHandler Street2Label.Click, AddressOf Me.Street2Label_Click
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(95, 196)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 8
        CityLabel.Text = "City:"
        AddHandler CityLabel.Click, AddressOf Me.CityLabel_Click
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(87, 222)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 10
        StateLabel.Text = "State:"
        AddHandler StateLabel.Click, AddressOf Me.StateLabel_Click
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(225, 222)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(25, 13)
        ZipCodeLabel.TabIndex = 12
        ZipCodeLabel.Text = "Zip:"
        AddHandler ZipCodeLabel.Click, AddressOf Me.ZipCodeLabel_Click
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(447, 91)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 14
        PhoneLabel.Text = "Phone:"
        AddHandler PhoneLabel.Click, AddressOf Me.PhoneLabel_Click
        '
        'ExtensionLabel
        '
        ExtensionLabel.AutoSize = True
        ExtensionLabel.Location = New System.Drawing.Point(463, 117)
        ExtensionLabel.Name = "ExtensionLabel"
        ExtensionLabel.Size = New System.Drawing.Size(25, 13)
        ExtensionLabel.TabIndex = 16
        ExtensionLabel.Text = "Ext:"
        AddHandler ExtensionLabel.Click, AddressOf Me.ExtensionLabel_Click
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(461, 143)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 18
        FaxLabel.Text = "Fax:"
        AddHandler FaxLabel.Click, AddressOf Me.FaxLabel_Click
        '
        'PracticeIDNumberLabel
        '
        PracticeIDNumberLabel.AutoSize = True
        PracticeIDNumberLabel.Location = New System.Drawing.Point(408, 169)
        PracticeIDNumberLabel.Name = "PracticeIDNumberLabel"
        PracticeIDNumberLabel.Size = New System.Drawing.Size(80, 13)
        PracticeIDNumberLabel.TabIndex = 20
        PracticeIDNumberLabel.Text = "Practice ID No:"
        AddHandler PracticeIDNumberLabel.Click, AddressOf Me.PracticeIDNumberLabel_Click
        '
        'PlanNameLabel
        '
        PlanNameLabel.AutoSize = True
        PlanNameLabel.Location = New System.Drawing.Point(426, 195)
        PlanNameLabel.Name = "PlanNameLabel"
        PlanNameLabel.Size = New System.Drawing.Size(62, 13)
        PlanNameLabel.TabIndex = 22
        PlanNameLabel.Text = "Plan Name:"
        AddHandler PlanNameLabel.Click, AddressOf Me.PlanNameLabel_Click
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(454, 221)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 24
        TypeLabel.Text = "Type:"
        AddHandler TypeLabel.Click, AddressOf Me.TypeLabel_Click
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(783, 403)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgInsurence)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(775, 377)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgInsurence
        '
        Me.dgInsurence.AllowUserToAddRows = False
        Me.dgInsurence.AllowUserToDeleteRows = False
        Me.dgInsurence.AllowUserToResizeRows = False
        Me.dgInsurence.AutoGenerateColumns = False
        Me.dgInsurence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInsurence.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.Street1DataGridViewTextBoxColumn, Me.Street2DataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipCodeDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.ExtensionDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.PracticeIDNumberDataGridViewTextBoxColumn, Me.PlanNameDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn})
        Me.dgInsurence.DataSource = Me.MMINSURENCEBindingSource
        Me.dgInsurence.Location = New System.Drawing.Point(6, 6)
        Me.dgInsurence.Name = "dgInsurence"
        Me.dgInsurence.Size = New System.Drawing.Size(766, 368)
        Me.dgInsurence.TabIndex = 0
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MaxInputLength = 50
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'Street1DataGridViewTextBoxColumn
        '
        Me.Street1DataGridViewTextBoxColumn.DataPropertyName = "Street1"
        Me.Street1DataGridViewTextBoxColumn.HeaderText = "Address 1"
        Me.Street1DataGridViewTextBoxColumn.Name = "Street1DataGridViewTextBoxColumn"
        '
        'Street2DataGridViewTextBoxColumn
        '
        Me.Street2DataGridViewTextBoxColumn.DataPropertyName = "Street2"
        Me.Street2DataGridViewTextBoxColumn.HeaderText = "Address 2"
        Me.Street2DataGridViewTextBoxColumn.Name = "Street2DataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'ZipCodeDataGridViewTextBoxColumn
        '
        Me.ZipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn.HeaderText = "Zip Code"
        Me.ZipCodeDataGridViewTextBoxColumn.Name = "ZipCodeDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'ExtensionDataGridViewTextBoxColumn
        '
        Me.ExtensionDataGridViewTextBoxColumn.DataPropertyName = "Extension"
        Me.ExtensionDataGridViewTextBoxColumn.HeaderText = "Ext"
        Me.ExtensionDataGridViewTextBoxColumn.Name = "ExtensionDataGridViewTextBoxColumn"
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        '
        'PracticeIDNumberDataGridViewTextBoxColumn
        '
        Me.PracticeIDNumberDataGridViewTextBoxColumn.DataPropertyName = "PracticeIDNumber"
        Me.PracticeIDNumberDataGridViewTextBoxColumn.HeaderText = "Practice ID Number"
        Me.PracticeIDNumberDataGridViewTextBoxColumn.Name = "PracticeIDNumberDataGridViewTextBoxColumn"
        '
        'PlanNameDataGridViewTextBoxColumn
        '
        Me.PlanNameDataGridViewTextBoxColumn.DataPropertyName = "PlanName"
        Me.PlanNameDataGridViewTextBoxColumn.HeaderText = "Plan Name"
        Me.PlanNameDataGridViewTextBoxColumn.Name = "PlanNameDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'MMINSURENCEBindingSource
        '
        Me.MMINSURENCEBindingSource.DataMember = "MMINSURENCE"
        Me.MMINSURENCEBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.FaxMaskedTextBox)
        Me.TabPage2.Controls.Add(Me.PhoneMaskedTextBox)
        Me.TabPage2.Controls.Add(TypeLabel)
        Me.TabPage2.Controls.Add(PlanNameLabel)
        Me.TabPage2.Controls.Add(Me.PlanNameTextBox)
        Me.TabPage2.Controls.Add(PracticeIDNumberLabel)
        Me.TabPage2.Controls.Add(Me.PracticeIDNumberTextBox)
        Me.TabPage2.Controls.Add(FaxLabel)
        Me.TabPage2.Controls.Add(ExtensionLabel)
        Me.TabPage2.Controls.Add(Me.ExtensionTextBox)
        Me.TabPage2.Controls.Add(PhoneLabel)
        Me.TabPage2.Controls.Add(ZipCodeLabel)
        Me.TabPage2.Controls.Add(Me.ZipCodeTextBox)
        Me.TabPage2.Controls.Add(StateLabel)
        Me.TabPage2.Controls.Add(Me.StateTextBox)
        Me.TabPage2.Controls.Add(CityLabel)
        Me.TabPage2.Controls.Add(Me.CityTextBox)
        Me.TabPage2.Controls.Add(Street2Label)
        Me.TabPage2.Controls.Add(Me.Street2TextBox)
        Me.TabPage2.Controls.Add(Street1Label)
        Me.TabPage2.Controls.Add(Me.Street1TextBox)
        Me.TabPage2.Controls.Add(NameLabel)
        Me.TabPage2.Controls.Add(Me.NameTextBox)
        Me.TabPage2.Controls.Add(CodeLabel)
        Me.TabPage2.Controls.Add(Me.CodeTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(757, 361)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "Type", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"MEDICARE", "MEDICAID MO", "MEDICAID IL", "OTHER"})
        Me.ComboBox1.Location = New System.Drawing.Point(494, 218)
        Me.ComboBox1.MaxLength = 17
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(203, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'FaxMaskedTextBox
        '
        Me.FaxMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "Fax", True))
        Me.FaxMaskedTextBox.Location = New System.Drawing.Point(494, 140)
        Me.FaxMaskedTextBox.Mask = "(999) 000-0000"
        Me.FaxMaskedTextBox.Name = "FaxMaskedTextBox"
        Me.FaxMaskedTextBox.Size = New System.Drawing.Size(106, 20)
        Me.FaxMaskedTextBox.TabIndex = 27
        '
        'PhoneMaskedTextBox
        '
        Me.PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "Phone", True))
        Me.PhoneMaskedTextBox.Location = New System.Drawing.Point(494, 88)
        Me.PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox"
        Me.PhoneMaskedTextBox.Size = New System.Drawing.Size(106, 20)
        Me.PhoneMaskedTextBox.TabIndex = 26
        '
        'PlanNameTextBox
        '
        Me.PlanNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "PlanName", True))
        Me.PlanNameTextBox.Location = New System.Drawing.Point(494, 192)
        Me.PlanNameTextBox.MaxLength = 30
        Me.PlanNameTextBox.Name = "PlanNameTextBox"
        Me.PlanNameTextBox.Size = New System.Drawing.Size(204, 20)
        Me.PlanNameTextBox.TabIndex = 23
        '
        'PracticeIDNumberTextBox
        '
        Me.PracticeIDNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "PracticeIDNumber", True))
        Me.PracticeIDNumberTextBox.Location = New System.Drawing.Point(494, 166)
        Me.PracticeIDNumberTextBox.MaxLength = 15
        Me.PracticeIDNumberTextBox.Name = "PracticeIDNumberTextBox"
        Me.PracticeIDNumberTextBox.Size = New System.Drawing.Size(107, 20)
        Me.PracticeIDNumberTextBox.TabIndex = 21
        '
        'ExtensionTextBox
        '
        Me.ExtensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "Extension", True))
        Me.ExtensionTextBox.Location = New System.Drawing.Point(494, 114)
        Me.ExtensionTextBox.MaxLength = 6
        Me.ExtensionTextBox.Name = "ExtensionTextBox"
        Me.ExtensionTextBox.Size = New System.Drawing.Size(106, 20)
        Me.ExtensionTextBox.TabIndex = 17
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(256, 219)
        Me.ZipCodeTextBox.MaxLength = 10
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipCodeTextBox.TabIndex = 13
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(128, 219)
        Me.StateTextBox.MaxLength = 2
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(50, 20)
        Me.StateTextBox.TabIndex = 11
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(128, 193)
        Me.CityTextBox.MaxLength = 20
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(228, 20)
        Me.CityTextBox.TabIndex = 9
        '
        'Street2TextBox
        '
        Me.Street2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "Street2", True))
        Me.Street2TextBox.Location = New System.Drawing.Point(128, 167)
        Me.Street2TextBox.MaxLength = 30
        Me.Street2TextBox.Name = "Street2TextBox"
        Me.Street2TextBox.Size = New System.Drawing.Size(228, 20)
        Me.Street2TextBox.TabIndex = 7
        '
        'Street1TextBox
        '
        Me.Street1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "Street1", True))
        Me.Street1TextBox.Location = New System.Drawing.Point(128, 141)
        Me.Street1TextBox.MaxLength = 30
        Me.Street1TextBox.Name = "Street1TextBox"
        Me.Street1TextBox.Size = New System.Drawing.Size(228, 20)
        Me.Street1TextBox.TabIndex = 5
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(128, 115)
        Me.NameTextBox.MaxLength = 50
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(228, 20)
        Me.NameTextBox.TabIndex = 3
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMINSURENCEBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(128, 89)
        Me.CodeTextBox.MaxLength = 10
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CodeTextBox.TabIndex = 1
        '
        'MMINSURENCEBindingNavigator
        '
        Me.MMINSURENCEBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMINSURENCEBindingNavigator.BindingSource = Me.MMINSURENCEBindingSource
        Me.MMINSURENCEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMINSURENCEBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMINSURENCEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel1, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel4, Me.MMINSURENCEBindingNavigatorSaveItem, Me.ToolStripLabel2, Me.ToolStripSeparator1, Me.txtFind, Me.ToolStripLabel3, Me.ToolStripSeparator3, Me.cmbFilter})
        Me.MMINSURENCEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMINSURENCEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMINSURENCEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMINSURENCEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMINSURENCEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMINSURENCEBindingNavigator.Name = "MMINSURENCEBindingNavigator"
        Me.MMINSURENCEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMINSURENCEBindingNavigator.Size = New System.Drawing.Size(785, 25)
        Me.MMINSURENCEBindingNavigator.TabIndex = 1
        Me.MMINSURENCEBindingNavigator.Text = "BindingNavigator1"
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
        'MMINSURENCEBindingNavigatorSaveItem
        '
        Me.MMINSURENCEBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMINSURENCEBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMINSURENCEBindingNavigatorSaveItem.Name = "MMINSURENCEBindingNavigatorSaveItem"
        Me.MMINSURENCEBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.MMINSURENCEBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(27, 22)
        Me.ToolStripLabel2.Text = "Find"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'txtFind
        '
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel3.Text = "Criteria"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'cmbFilter
        '
        Me.cmbFilter.AutoCompleteCustomSource.AddRange(New String() {"Name", "Code"})
        Me.cmbFilter.Items.AddRange(New Object() {"Code", "Name"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 25)
        '
        'MMINSURENCETableAdapter
        '
        Me.MMINSURENCETableAdapter.ClearBeforeFill = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel1.Text = "     "
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel4.Text = "     "
        '
        'Insurence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 431)
        Me.Controls.Add(Me.MMINSURENCEBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(205, 85)
        Me.Name = "Insurence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insurance"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgInsurence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMINSURENCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.MMINSURENCEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMINSURENCEBindingNavigator.ResumeLayout(False)
        Me.MMINSURENCEBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMINSURENCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMINSURENCEBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMINSURENCEBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgInsurence As System.Windows.Forms.DataGridView
    Friend WithEvents PlanNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PracticeIDNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExtensionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Street2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Street1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMINSURENCETableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMINSURENCETableAdapter
    Friend WithEvents PhoneMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents FaxMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Street1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Street2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExtensionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PracticeIDNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlanNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
End Class
