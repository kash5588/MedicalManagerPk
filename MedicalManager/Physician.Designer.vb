<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Physician
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
        Me.components = New System.ComponentModel.Container()
        Dim CodeLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleInitialLabel As System.Windows.Forms.Label
        Dim CredentialsLabel As System.Windows.Forms.Label
        Dim Street1Label As System.Windows.Forms.Label
        Dim Street2Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Physician))
        Dim BlueCross_ShieldPINLabel As System.Windows.Forms.Label
        Dim CommercialPINLabel As System.Windows.Forms.Label
        Dim GroupPINLabel As System.Windows.Forms.Label
        Dim HMOPINLabel As System.Windows.Forms.Label
        Dim PPOPINLabel As System.Windows.Forms.Label
        Dim MedicareGroupIDLabel As System.Windows.Forms.Label
        Dim MedicaidGroupIDLabel As System.Windows.Forms.Label
        Dim BC_BSGroupIDLabel As System.Windows.Forms.Label
        Dim OtherGroupIDLabel As System.Windows.Forms.Label
        Dim EMCIDLabel As System.Windows.Forms.Label
        Dim MedicareParticpProviderLabel As System.Windows.Forms.Label
        Dim UPINLabel As System.Windows.Forms.Label
        Dim Extra1Label As System.Windows.Forms.Label
        Dim Extra2Label As System.Windows.Forms.Label
        Dim SpecialtyLabel As System.Windows.Forms.Label
        Dim SecurityLevelLabel As System.Windows.Forms.Label
        Dim SBNumberLabel As System.Windows.Forms.Label
        Dim SSNorFedTaxIDLabel As System.Windows.Forms.Label
        Dim FTIDLabel As System.Windows.Forms.Label
        Dim LicenseNumberLabel As System.Windows.Forms.Label
        Dim SignatureonFileLabel As System.Windows.Forms.Label
        Dim MedicarePINLabel As System.Windows.Forms.Label
        Dim MedicaidPINLabel As System.Windows.Forms.Label
        Dim ChampusPINLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgPhysician = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMPhysionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleInitialTextBox = New System.Windows.Forms.TextBox()
        Me.CredentialsTextBox = New System.Windows.Forms.TextBox()
        Me.Street1TextBox = New System.Windows.Forms.TextBox()
        Me.Street2TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.MMPhysionTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMPhysionTableAdapter()
        Me.MMPhysionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.MMPhysionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BlueCross_ShieldPINTextBox = New System.Windows.Forms.TextBox()
        Me.CommercialPINTextBox = New System.Windows.Forms.TextBox()
        Me.GroupPINTextBox = New System.Windows.Forms.TextBox()
        Me.HMOPINTextBox = New System.Windows.Forms.TextBox()
        Me.PPOPINTextBox = New System.Windows.Forms.TextBox()
        Me.MedicareGroupIDTextBox = New System.Windows.Forms.TextBox()
        Me.MedicaidGroupIDTextBox = New System.Windows.Forms.TextBox()
        Me.BC_BSGroupIDTextBox = New System.Windows.Forms.TextBox()
        Me.OtherGroupIDTextBox = New System.Windows.Forms.TextBox()
        Me.EMCIDTextBox = New System.Windows.Forms.TextBox()
        Me.MedicareParticpProviderCheckBox = New System.Windows.Forms.CheckBox()
        Me.UPINTextBox = New System.Windows.Forms.TextBox()
        Me.Extra1TextBox = New System.Windows.Forms.TextBox()
        Me.Extra2TextBox = New System.Windows.Forms.TextBox()
        Me.SpecialtyTextBox = New System.Windows.Forms.TextBox()
        Me.SecurityLevelTextBox = New System.Windows.Forms.TextBox()
        Me.SBNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SSNorFedTaxIDTextBox = New System.Windows.Forms.TextBox()
        Me.FTIDCheckBox = New System.Windows.Forms.CheckBox()
        Me.LicenseNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SignatureonFileCheckBox = New System.Windows.Forms.CheckBox()
        Me.MedicarePINTextBox = New System.Windows.Forms.TextBox()
        Me.MedicaidPINTextBox = New System.Windows.Forms.TextBox()
        Me.ChampusPINTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.TBPhone = New System.Windows.Forms.TextBox()
        CodeLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MiddleInitialLabel = New System.Windows.Forms.Label()
        CredentialsLabel = New System.Windows.Forms.Label()
        Street1Label = New System.Windows.Forms.Label()
        Street2Label = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        BlueCross_ShieldPINLabel = New System.Windows.Forms.Label()
        CommercialPINLabel = New System.Windows.Forms.Label()
        GroupPINLabel = New System.Windows.Forms.Label()
        HMOPINLabel = New System.Windows.Forms.Label()
        PPOPINLabel = New System.Windows.Forms.Label()
        MedicareGroupIDLabel = New System.Windows.Forms.Label()
        MedicaidGroupIDLabel = New System.Windows.Forms.Label()
        BC_BSGroupIDLabel = New System.Windows.Forms.Label()
        OtherGroupIDLabel = New System.Windows.Forms.Label()
        EMCIDLabel = New System.Windows.Forms.Label()
        MedicareParticpProviderLabel = New System.Windows.Forms.Label()
        UPINLabel = New System.Windows.Forms.Label()
        Extra1Label = New System.Windows.Forms.Label()
        Extra2Label = New System.Windows.Forms.Label()
        SpecialtyLabel = New System.Windows.Forms.Label()
        SecurityLevelLabel = New System.Windows.Forms.Label()
        SBNumberLabel = New System.Windows.Forms.Label()
        SSNorFedTaxIDLabel = New System.Windows.Forms.Label()
        FTIDLabel = New System.Windows.Forms.Label()
        LicenseNumberLabel = New System.Windows.Forms.Label()
        SignatureonFileLabel = New System.Windows.Forms.Label()
        MedicarePINLabel = New System.Windows.Forms.Label()
        MedicaidPINLabel = New System.Windows.Forms.Label()
        ChampusPINLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipCodeLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgPhysician, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPhysionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMPhysionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMPhysionBindingNavigator.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodeLabel.Location = New System.Drawing.Point(269, 55)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(39, 15)
        CodeLabel.TabIndex = 73
        CodeLabel.Text = "Code:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(238, 137)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(70, 15)
        LastNameLabel.TabIndex = 75
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(238, 98)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(70, 15)
        FirstNameLabel.TabIndex = 77
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleInitialLabel
        '
        MiddleInitialLabel.AutoSize = True
        MiddleInitialLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MiddleInitialLabel.Location = New System.Drawing.Point(441, 136)
        MiddleInitialLabel.Name = "MiddleInitialLabel"
        MiddleInitialLabel.Size = New System.Drawing.Size(24, 15)
        MiddleInitialLabel.TabIndex = 79
        MiddleInitialLabel.Text = "MI:"
        AddHandler MiddleInitialLabel.Click, AddressOf Me.MiddleInitialLabel_Click
        '
        'CredentialsLabel
        '
        CredentialsLabel.AutoSize = True
        CredentialsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CredentialsLabel.Location = New System.Drawing.Point(236, 184)
        CredentialsLabel.Name = "CredentialsLabel"
        CredentialsLabel.Size = New System.Drawing.Size(72, 15)
        CredentialsLabel.TabIndex = 81
        CredentialsLabel.Text = "Credentials:"
        '
        'Street1Label
        '
        Street1Label.AutoSize = True
        Street1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Street1Label.Location = New System.Drawing.Point(244, 222)
        Street1Label.Name = "Street1Label"
        Street1Label.Size = New System.Drawing.Size(64, 15)
        Street1Label.TabIndex = 83
        Street1Label.Text = "Address 1:"
        '
        'Street2Label
        '
        Street2Label.AutoSize = True
        Street2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Street2Label.Location = New System.Drawing.Point(244, 265)
        Street2Label.Name = "Street2Label"
        Street2Label.Size = New System.Drawing.Size(64, 15)
        Street2Label.TabIndex = 85
        Street2Label.Text = "Address 2:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(279, 306)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(29, 15)
        CityLabel.TabIndex = 87
        CityLabel.Text = "City:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(262, 354)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(46, 15)
        PhoneLabel.TabIndex = 93
        PhoneLabel.Text = "Phone:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FaxLabel.Location = New System.Drawing.Point(278, 396)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(30, 15)
        FaxLabel.TabIndex = 95
        FaxLabel.Text = "Fax:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(763, 570)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgPhysician)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(755, 544)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgPhysician
        '
        Me.dgPhysician.AllowUserToAddRows = False
        Me.dgPhysician.AllowUserToDeleteRows = False
        Me.dgPhysician.AllowUserToResizeRows = False
        Me.dgPhysician.AutoGenerateColumns = False
        Me.dgPhysician.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn14, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34})
        Me.dgPhysician.DataSource = Me.MMPhysionBindingSource
        Me.dgPhysician.Location = New System.Drawing.Point(5, 7)
        Me.dgPhysician.Name = "dgPhysician"
        Me.dgPhysician.Size = New System.Drawing.Size(746, 529)
        Me.dgPhysician.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MiddleInitial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "M I"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 30
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Credentials"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Credentials"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Street1"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address 1"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Street2"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Address 2"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn8.HeaderText = "City"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn9.HeaderText = "State"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ZipCode"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Zip"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Fax"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fax"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SSNorFedTaxID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "SSN or Fed Tax ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "FTID"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "FT ID"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "LicenseNumber"
        Me.DataGridViewTextBoxColumn14.HeaderText = "License Number"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "SignatureonFile"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Signature on File"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "MedicarePIN"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Medicare PIN"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "MedicaidPIN"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Medicaid PIN"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ChampusPIN"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Champus PIN"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "BlueCross/ShieldPIN"
        Me.DataGridViewTextBoxColumn18.HeaderText = "BlueCross/Shield PIN"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CommercialPIN"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Commercial PIN"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "GroupPIN"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Group PIN"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "HMOPIN"
        Me.DataGridViewTextBoxColumn21.HeaderText = "HMO PIN"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PPOPIN"
        Me.DataGridViewTextBoxColumn22.HeaderText = "PPO PIN"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "MedicareGroupID"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Medicare Group ID"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "MedicaidGroupID"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Medicaid Group ID"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "BC/BSGroupID"
        Me.DataGridViewTextBoxColumn25.HeaderText = "BC/BS Group ID"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "OtherGroupID"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Other Group ID"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "EMCID"
        Me.DataGridViewTextBoxColumn27.HeaderText = "EMC ID"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "MedicareParticpProvider"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Medicare Particp Provider"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "UPIN"
        Me.DataGridViewTextBoxColumn28.HeaderText = "UPIN"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Extra1"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Extra 1"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Extra2"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Extra 2"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Specialty"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Specialty"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "SecurityLevel"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Security Level"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "SBNumber"
        Me.DataGridViewTextBoxColumn33.HeaderText = "SB Number"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "SOFDate"
        Me.DataGridViewTextBoxColumn34.HeaderText = "SOF Date"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'MMPhysionBindingSource
        '
        Me.MMPhysionBindingSource.DataMember = "MMPhysion"
        Me.MMPhysionBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MaskedTextBox2)
        Me.TabPage2.Controls.Add(CodeLabel)
        Me.TabPage2.Controls.Add(Me.CodeTextBox)
        Me.TabPage2.Controls.Add(LastNameLabel)
        Me.TabPage2.Controls.Add(Me.LastNameTextBox)
        Me.TabPage2.Controls.Add(FirstNameLabel)
        Me.TabPage2.Controls.Add(Me.FirstNameTextBox)
        Me.TabPage2.Controls.Add(MiddleInitialLabel)
        Me.TabPage2.Controls.Add(Me.MiddleInitialTextBox)
        Me.TabPage2.Controls.Add(CredentialsLabel)
        Me.TabPage2.Controls.Add(Me.CredentialsTextBox)
        Me.TabPage2.Controls.Add(Street1Label)
        Me.TabPage2.Controls.Add(Me.Street1TextBox)
        Me.TabPage2.Controls.Add(Street2Label)
        Me.TabPage2.Controls.Add(Me.Street2TextBox)
        Me.TabPage2.Controls.Add(CityLabel)
        Me.TabPage2.Controls.Add(Me.TBPhone)
        Me.TabPage2.Controls.Add(Me.CityTextBox)
        Me.TabPage2.Controls.Add(PhoneLabel)
        Me.TabPage2.Controls.Add(FaxLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(755, 544)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "Fax", True))
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(312, 392)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(114, 21)
        Me.MaskedTextBox2.TabIndex = 146
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "Code", True))
        Me.CodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeTextBox.Location = New System.Drawing.Point(312, 53)
        Me.CodeTextBox.MaxLength = 7
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(97, 21)
        Me.CodeTextBox.TabIndex = 74
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(312, 133)
        Me.LastNameTextBox.MaxLength = 20
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(97, 21)
        Me.LastNameTextBox.TabIndex = 76
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(312, 93)
        Me.FirstNameTextBox.MaxLength = 20
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(199, 21)
        Me.FirstNameTextBox.TabIndex = 75
        '
        'MiddleInitialTextBox
        '
        Me.MiddleInitialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "MiddleInitial", True))
        Me.MiddleInitialTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleInitialTextBox.Location = New System.Drawing.Point(469, 133)
        Me.MiddleInitialTextBox.MaxLength = 1
        Me.MiddleInitialTextBox.Name = "MiddleInitialTextBox"
        Me.MiddleInitialTextBox.Size = New System.Drawing.Size(42, 21)
        Me.MiddleInitialTextBox.TabIndex = 80
        '
        'CredentialsTextBox
        '
        Me.CredentialsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "Credentials", True))
        Me.CredentialsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CredentialsTextBox.Location = New System.Drawing.Point(312, 180)
        Me.CredentialsTextBox.MaxLength = 10
        Me.CredentialsTextBox.Name = "CredentialsTextBox"
        Me.CredentialsTextBox.Size = New System.Drawing.Size(199, 21)
        Me.CredentialsTextBox.TabIndex = 82
        '
        'Street1TextBox
        '
        Me.Street1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "Street1", True))
        Me.Street1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Street1TextBox.Location = New System.Drawing.Point(312, 219)
        Me.Street1TextBox.MaxLength = 30
        Me.Street1TextBox.Name = "Street1TextBox"
        Me.Street1TextBox.Size = New System.Drawing.Size(199, 21)
        Me.Street1TextBox.TabIndex = 84
        '
        'Street2TextBox
        '
        Me.Street2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "Street2", True))
        Me.Street2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Street2TextBox.Location = New System.Drawing.Point(312, 262)
        Me.Street2TextBox.MaxLength = 30
        Me.Street2TextBox.Name = "Street2TextBox"
        Me.Street2TextBox.Size = New System.Drawing.Size(199, 21)
        Me.Street2TextBox.TabIndex = 86
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.Location = New System.Drawing.Point(312, 303)
        Me.CityTextBox.MaxLength = 20
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(199, 21)
        Me.CityTextBox.TabIndex = 87
        '
        'MMPhysionTableAdapter
        '
        Me.MMPhysionTableAdapter.ClearBeforeFill = True
        '
        'MMPhysionBindingNavigator
        '
        Me.MMPhysionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMPhysionBindingNavigator.BindingSource = Me.MMPhysionBindingSource
        Me.MMPhysionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMPhysionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMPhysionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel2, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel1, Me.MMPhysionBindingNavigatorSaveItem})
        Me.MMPhysionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMPhysionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMPhysionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMPhysionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMPhysionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMPhysionBindingNavigator.Name = "MMPhysionBindingNavigator"
        Me.MMPhysionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMPhysionBindingNavigator.Size = New System.Drawing.Size(763, 25)
        Me.MMPhysionBindingNavigator.TabIndex = 1
        Me.MMPhysionBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(74, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'MMPhysionBindingNavigatorSaveItem
        '
        Me.MMPhysionBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMPhysionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMPhysionBindingNavigatorSaveItem.Name = "MMPhysionBindingNavigatorSaveItem"
        Me.MMPhysionBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.MMPhysionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(StateLabel)
        Me.TabPage3.Controls.Add(Me.StateTextBox)
        Me.TabPage3.Controls.Add(ZipCodeLabel)
        Me.TabPage3.Controls.Add(Me.ZipCodeTextBox)
        Me.TabPage3.Controls.Add(SSNorFedTaxIDLabel)
        Me.TabPage3.Controls.Add(Me.SSNorFedTaxIDTextBox)
        Me.TabPage3.Controls.Add(FTIDLabel)
        Me.TabPage3.Controls.Add(Me.FTIDCheckBox)
        Me.TabPage3.Controls.Add(LicenseNumberLabel)
        Me.TabPage3.Controls.Add(Me.LicenseNumberTextBox)
        Me.TabPage3.Controls.Add(SignatureonFileLabel)
        Me.TabPage3.Controls.Add(Me.SignatureonFileCheckBox)
        Me.TabPage3.Controls.Add(MedicarePINLabel)
        Me.TabPage3.Controls.Add(Me.MedicarePINTextBox)
        Me.TabPage3.Controls.Add(MedicaidPINLabel)
        Me.TabPage3.Controls.Add(Me.MedicaidPINTextBox)
        Me.TabPage3.Controls.Add(ChampusPINLabel)
        Me.TabPage3.Controls.Add(Me.ChampusPINTextBox)
        Me.TabPage3.Controls.Add(BlueCross_ShieldPINLabel)
        Me.TabPage3.Controls.Add(Me.BlueCross_ShieldPINTextBox)
        Me.TabPage3.Controls.Add(CommercialPINLabel)
        Me.TabPage3.Controls.Add(Me.CommercialPINTextBox)
        Me.TabPage3.Controls.Add(GroupPINLabel)
        Me.TabPage3.Controls.Add(Me.GroupPINTextBox)
        Me.TabPage3.Controls.Add(HMOPINLabel)
        Me.TabPage3.Controls.Add(Me.HMOPINTextBox)
        Me.TabPage3.Controls.Add(PPOPINLabel)
        Me.TabPage3.Controls.Add(Me.PPOPINTextBox)
        Me.TabPage3.Controls.Add(MedicareGroupIDLabel)
        Me.TabPage3.Controls.Add(Me.MedicareGroupIDTextBox)
        Me.TabPage3.Controls.Add(MedicaidGroupIDLabel)
        Me.TabPage3.Controls.Add(Me.MedicaidGroupIDTextBox)
        Me.TabPage3.Controls.Add(BC_BSGroupIDLabel)
        Me.TabPage3.Controls.Add(Me.BC_BSGroupIDTextBox)
        Me.TabPage3.Controls.Add(OtherGroupIDLabel)
        Me.TabPage3.Controls.Add(Me.OtherGroupIDTextBox)
        Me.TabPage3.Controls.Add(EMCIDLabel)
        Me.TabPage3.Controls.Add(Me.EMCIDTextBox)
        Me.TabPage3.Controls.Add(MedicareParticpProviderLabel)
        Me.TabPage3.Controls.Add(Me.MedicareParticpProviderCheckBox)
        Me.TabPage3.Controls.Add(UPINLabel)
        Me.TabPage3.Controls.Add(Me.UPINTextBox)
        Me.TabPage3.Controls.Add(Extra1Label)
        Me.TabPage3.Controls.Add(Me.Extra1TextBox)
        Me.TabPage3.Controls.Add(Extra2Label)
        Me.TabPage3.Controls.Add(Me.Extra2TextBox)
        Me.TabPage3.Controls.Add(SpecialtyLabel)
        Me.TabPage3.Controls.Add(Me.SpecialtyTextBox)
        Me.TabPage3.Controls.Add(SecurityLevelLabel)
        Me.TabPage3.Controls.Add(Me.SecurityLevelTextBox)
        Me.TabPage3.Controls.Add(SBNumberLabel)
        Me.TabPage3.Controls.Add(Me.SBNumberTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(755, 544)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Other"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BlueCross_ShieldPINLabel
        '
        BlueCross_ShieldPINLabel.AutoSize = True
        BlueCross_ShieldPINLabel.Location = New System.Drawing.Point(345, 36)
        BlueCross_ShieldPINLabel.Name = "BlueCross_ShieldPINLabel"
        BlueCross_ShieldPINLabel.Size = New System.Drawing.Size(115, 13)
        BlueCross_ShieldPINLabel.TabIndex = 145
        BlueCross_ShieldPINLabel.Text = "Blue Cross/Shield PIN:"
        '
        'BlueCross_ShieldPINTextBox
        '
        Me.BlueCross_ShieldPINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "BlueCross/ShieldPIN", True))
        Me.BlueCross_ShieldPINTextBox.Location = New System.Drawing.Point(468, 33)
        Me.BlueCross_ShieldPINTextBox.MaxLength = 20
        Me.BlueCross_ShieldPINTextBox.Name = "BlueCross_ShieldPINTextBox"
        Me.BlueCross_ShieldPINTextBox.Size = New System.Drawing.Size(199, 20)
        Me.BlueCross_ShieldPINTextBox.TabIndex = 146
        '
        'CommercialPINLabel
        '
        CommercialPINLabel.AutoSize = True
        CommercialPINLabel.Location = New System.Drawing.Point(375, 62)
        CommercialPINLabel.Name = "CommercialPINLabel"
        CommercialPINLabel.Size = New System.Drawing.Size(85, 13)
        CommercialPINLabel.TabIndex = 147
        CommercialPINLabel.Text = "Commercial PIN:"
        '
        'CommercialPINTextBox
        '
        Me.CommercialPINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "CommercialPIN", True))
        Me.CommercialPINTextBox.Location = New System.Drawing.Point(467, 59)
        Me.CommercialPINTextBox.MaxLength = 20
        Me.CommercialPINTextBox.Name = "CommercialPINTextBox"
        Me.CommercialPINTextBox.Size = New System.Drawing.Size(199, 20)
        Me.CommercialPINTextBox.TabIndex = 148
        '
        'GroupPINLabel
        '
        GroupPINLabel.AutoSize = True
        GroupPINLabel.Location = New System.Drawing.Point(400, 88)
        GroupPINLabel.Name = "GroupPINLabel"
        GroupPINLabel.Size = New System.Drawing.Size(60, 13)
        GroupPINLabel.TabIndex = 149
        GroupPINLabel.Text = "Group PIN:"
        '
        'GroupPINTextBox
        '
        Me.GroupPINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "GroupPIN", True))
        Me.GroupPINTextBox.Location = New System.Drawing.Point(467, 85)
        Me.GroupPINTextBox.MaxLength = 20
        Me.GroupPINTextBox.Name = "GroupPINTextBox"
        Me.GroupPINTextBox.Size = New System.Drawing.Size(199, 20)
        Me.GroupPINTextBox.TabIndex = 150
        '
        'HMOPINLabel
        '
        HMOPINLabel.AutoSize = True
        HMOPINLabel.Location = New System.Drawing.Point(404, 114)
        HMOPINLabel.Name = "HMOPINLabel"
        HMOPINLabel.Size = New System.Drawing.Size(56, 13)
        HMOPINLabel.TabIndex = 151
        HMOPINLabel.Text = "HMO PIN:"
        '
        'HMOPINTextBox
        '
        Me.HMOPINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "HMOPIN", True))
        Me.HMOPINTextBox.Location = New System.Drawing.Point(467, 111)
        Me.HMOPINTextBox.MaxLength = 20
        Me.HMOPINTextBox.Name = "HMOPINTextBox"
        Me.HMOPINTextBox.Size = New System.Drawing.Size(199, 20)
        Me.HMOPINTextBox.TabIndex = 152
        '
        'PPOPINLabel
        '
        PPOPINLabel.AutoSize = True
        PPOPINLabel.Location = New System.Drawing.Point(407, 140)
        PPOPINLabel.Name = "PPOPINLabel"
        PPOPINLabel.Size = New System.Drawing.Size(53, 13)
        PPOPINLabel.TabIndex = 153
        PPOPINLabel.Text = "PPO PIN:"
        '
        'PPOPINTextBox
        '
        Me.PPOPINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "PPOPIN", True))
        Me.PPOPINTextBox.Location = New System.Drawing.Point(467, 137)
        Me.PPOPINTextBox.MaxLength = 20
        Me.PPOPINTextBox.Name = "PPOPINTextBox"
        Me.PPOPINTextBox.Size = New System.Drawing.Size(199, 20)
        Me.PPOPINTextBox.TabIndex = 154
        '
        'MedicareGroupIDLabel
        '
        MedicareGroupIDLabel.AutoSize = True
        MedicareGroupIDLabel.Location = New System.Drawing.Point(360, 166)
        MedicareGroupIDLabel.Name = "MedicareGroupIDLabel"
        MedicareGroupIDLabel.Size = New System.Drawing.Size(100, 13)
        MedicareGroupIDLabel.TabIndex = 155
        MedicareGroupIDLabel.Text = "Medicare Group ID:"
        '
        'MedicareGroupIDTextBox
        '
        Me.MedicareGroupIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "MedicareGroupID", True))
        Me.MedicareGroupIDTextBox.Location = New System.Drawing.Point(467, 163)
        Me.MedicareGroupIDTextBox.MaxLength = 20
        Me.MedicareGroupIDTextBox.Name = "MedicareGroupIDTextBox"
        Me.MedicareGroupIDTextBox.Size = New System.Drawing.Size(199, 20)
        Me.MedicareGroupIDTextBox.TabIndex = 156
        '
        'MedicaidGroupIDLabel
        '
        MedicaidGroupIDLabel.AutoSize = True
        MedicaidGroupIDLabel.Location = New System.Drawing.Point(361, 192)
        MedicaidGroupIDLabel.Name = "MedicaidGroupIDLabel"
        MedicaidGroupIDLabel.Size = New System.Drawing.Size(99, 13)
        MedicaidGroupIDLabel.TabIndex = 157
        MedicaidGroupIDLabel.Text = "Medicaid Group ID:"
        '
        'MedicaidGroupIDTextBox
        '
        Me.MedicaidGroupIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "MedicaidGroupID", True))
        Me.MedicaidGroupIDTextBox.Location = New System.Drawing.Point(467, 189)
        Me.MedicaidGroupIDTextBox.MaxLength = 20
        Me.MedicaidGroupIDTextBox.Name = "MedicaidGroupIDTextBox"
        Me.MedicaidGroupIDTextBox.Size = New System.Drawing.Size(199, 20)
        Me.MedicaidGroupIDTextBox.TabIndex = 158
        '
        'BC_BSGroupIDLabel
        '
        BC_BSGroupIDLabel.AutoSize = True
        BC_BSGroupIDLabel.Location = New System.Drawing.Point(371, 218)
        BC_BSGroupIDLabel.Name = "BC_BSGroupIDLabel"
        BC_BSGroupIDLabel.Size = New System.Drawing.Size(89, 13)
        BC_BSGroupIDLabel.TabIndex = 159
        BC_BSGroupIDLabel.Text = "BC/BS Group ID:"
        '
        'BC_BSGroupIDTextBox
        '
        Me.BC_BSGroupIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "BC/BSGroupID", True))
        Me.BC_BSGroupIDTextBox.Location = New System.Drawing.Point(467, 215)
        Me.BC_BSGroupIDTextBox.MaxLength = 20
        Me.BC_BSGroupIDTextBox.Name = "BC_BSGroupIDTextBox"
        Me.BC_BSGroupIDTextBox.Size = New System.Drawing.Size(199, 20)
        Me.BC_BSGroupIDTextBox.TabIndex = 160
        '
        'OtherGroupIDLabel
        '
        OtherGroupIDLabel.AutoSize = True
        OtherGroupIDLabel.Location = New System.Drawing.Point(378, 244)
        OtherGroupIDLabel.Name = "OtherGroupIDLabel"
        OtherGroupIDLabel.Size = New System.Drawing.Size(82, 13)
        OtherGroupIDLabel.TabIndex = 161
        OtherGroupIDLabel.Text = "Other Group ID:"
        '
        'OtherGroupIDTextBox
        '
        Me.OtherGroupIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "OtherGroupID", True))
        Me.OtherGroupIDTextBox.Location = New System.Drawing.Point(467, 241)
        Me.OtherGroupIDTextBox.MaxLength = 20
        Me.OtherGroupIDTextBox.Name = "OtherGroupIDTextBox"
        Me.OtherGroupIDTextBox.Size = New System.Drawing.Size(199, 20)
        Me.OtherGroupIDTextBox.TabIndex = 162
        '
        'EMCIDLabel
        '
        EMCIDLabel.AutoSize = True
        EMCIDLabel.Location = New System.Drawing.Point(413, 270)
        EMCIDLabel.Name = "EMCIDLabel"
        EMCIDLabel.Size = New System.Drawing.Size(47, 13)
        EMCIDLabel.TabIndex = 163
        EMCIDLabel.Text = "EMC ID:"
        '
        'EMCIDTextBox
        '
        Me.EMCIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "EMCID", True))
        Me.EMCIDTextBox.Location = New System.Drawing.Point(467, 267)
        Me.EMCIDTextBox.Name = "EMCIDTextBox"
        Me.EMCIDTextBox.Size = New System.Drawing.Size(199, 20)
        Me.EMCIDTextBox.TabIndex = 164
        '
        'MedicareParticpProviderLabel
        '
        MedicareParticpProviderLabel.AutoSize = True
        MedicareParticpProviderLabel.Location = New System.Drawing.Point(487, 298)
        MedicareParticpProviderLabel.Name = "MedicareParticpProviderLabel"
        MedicareParticpProviderLabel.Size = New System.Drawing.Size(132, 13)
        MedicareParticpProviderLabel.TabIndex = 165
        MedicareParticpProviderLabel.Text = "Medicare Particp Provider:"
        '
        'MedicareParticpProviderCheckBox
        '
        Me.MedicareParticpProviderCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "MedicareParticpProvider", True))
        Me.MedicareParticpProviderCheckBox.Location = New System.Drawing.Point(467, 293)
        Me.MedicareParticpProviderCheckBox.Name = "MedicareParticpProviderCheckBox"
        Me.MedicareParticpProviderCheckBox.Size = New System.Drawing.Size(20, 24)
        Me.MedicareParticpProviderCheckBox.TabIndex = 166
        '
        'UPINLabel
        '
        UPINLabel.AutoSize = True
        UPINLabel.Location = New System.Drawing.Point(424, 326)
        UPINLabel.Name = "UPINLabel"
        UPINLabel.Size = New System.Drawing.Size(36, 13)
        UPINLabel.TabIndex = 167
        UPINLabel.Text = "UPIN:"
        '
        'UPINTextBox
        '
        Me.UPINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "UPIN", True))
        Me.UPINTextBox.Location = New System.Drawing.Point(467, 323)
        Me.UPINTextBox.MaxLength = 20
        Me.UPINTextBox.Name = "UPINTextBox"
        Me.UPINTextBox.Size = New System.Drawing.Size(199, 20)
        Me.UPINTextBox.TabIndex = 168
        '
        'Extra1Label
        '
        Extra1Label.AutoSize = True
        Extra1Label.Location = New System.Drawing.Point(420, 352)
        Extra1Label.Name = "Extra1Label"
        Extra1Label.Size = New System.Drawing.Size(40, 13)
        Extra1Label.TabIndex = 169
        Extra1Label.Text = "Extra1:"
        '
        'Extra1TextBox
        '
        Me.Extra1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "Extra1", True))
        Me.Extra1TextBox.Location = New System.Drawing.Point(467, 349)
        Me.Extra1TextBox.MaxLength = 10
        Me.Extra1TextBox.Name = "Extra1TextBox"
        Me.Extra1TextBox.Size = New System.Drawing.Size(199, 20)
        Me.Extra1TextBox.TabIndex = 170
        '
        'Extra2Label
        '
        Extra2Label.AutoSize = True
        Extra2Label.Location = New System.Drawing.Point(420, 378)
        Extra2Label.Name = "Extra2Label"
        Extra2Label.Size = New System.Drawing.Size(40, 13)
        Extra2Label.TabIndex = 171
        Extra2Label.Text = "Extra2:"
        '
        'Extra2TextBox
        '
        Me.Extra2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "Extra2", True))
        Me.Extra2TextBox.Location = New System.Drawing.Point(467, 375)
        Me.Extra2TextBox.MaxLength = 10
        Me.Extra2TextBox.Name = "Extra2TextBox"
        Me.Extra2TextBox.Size = New System.Drawing.Size(199, 20)
        Me.Extra2TextBox.TabIndex = 172
        '
        'SpecialtyLabel
        '
        SpecialtyLabel.AutoSize = True
        SpecialtyLabel.Location = New System.Drawing.Point(407, 404)
        SpecialtyLabel.Name = "SpecialtyLabel"
        SpecialtyLabel.Size = New System.Drawing.Size(53, 13)
        SpecialtyLabel.TabIndex = 173
        SpecialtyLabel.Text = "Specialty:"
        '
        'SpecialtyTextBox
        '
        Me.SpecialtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "Specialty", True))
        Me.SpecialtyTextBox.Location = New System.Drawing.Point(467, 401)
        Me.SpecialtyTextBox.MaxLength = 3
        Me.SpecialtyTextBox.Name = "SpecialtyTextBox"
        Me.SpecialtyTextBox.Size = New System.Drawing.Size(199, 20)
        Me.SpecialtyTextBox.TabIndex = 174
        '
        'SecurityLevelLabel
        '
        SecurityLevelLabel.AutoSize = True
        SecurityLevelLabel.Location = New System.Drawing.Point(383, 430)
        SecurityLevelLabel.Name = "SecurityLevelLabel"
        SecurityLevelLabel.Size = New System.Drawing.Size(77, 13)
        SecurityLevelLabel.TabIndex = 175
        SecurityLevelLabel.Text = "Security Level:"
        '
        'SecurityLevelTextBox
        '
        Me.SecurityLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "SecurityLevel", True))
        Me.SecurityLevelTextBox.Location = New System.Drawing.Point(467, 427)
        Me.SecurityLevelTextBox.Name = "SecurityLevelTextBox"
        Me.SecurityLevelTextBox.Size = New System.Drawing.Size(199, 20)
        Me.SecurityLevelTextBox.TabIndex = 176
        '
        'SBNumberLabel
        '
        SBNumberLabel.AutoSize = True
        SBNumberLabel.Location = New System.Drawing.Point(396, 456)
        SBNumberLabel.Name = "SBNumberLabel"
        SBNumberLabel.Size = New System.Drawing.Size(64, 13)
        SBNumberLabel.TabIndex = 177
        SBNumberLabel.Text = "SB Number:"
        '
        'SBNumberTextBox
        '
        Me.SBNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "SBNumber", True))
        Me.SBNumberTextBox.Location = New System.Drawing.Point(467, 453)
        Me.SBNumberTextBox.MaxLength = 2
        Me.SBNumberTextBox.Name = "SBNumberTextBox"
        Me.SBNumberTextBox.Size = New System.Drawing.Size(199, 20)
        Me.SBNumberTextBox.TabIndex = 178
        '
        'SSNorFedTaxIDLabel
        '
        SSNorFedTaxIDLabel.AutoSize = True
        SSNorFedTaxIDLabel.Location = New System.Drawing.Point(16, 36)
        SSNorFedTaxIDLabel.Name = "SSNorFedTaxIDLabel"
        SSNorFedTaxIDLabel.Size = New System.Drawing.Size(97, 13)
        SSNorFedTaxIDLabel.TabIndex = 179
        SSNorFedTaxIDLabel.Text = "SSNor Fed Tax ID:"
        '
        'SSNorFedTaxIDTextBox
        '
        Me.SSNorFedTaxIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "SSNorFedTaxID", True))
        Me.SSNorFedTaxIDTextBox.Location = New System.Drawing.Point(119, 33)
        Me.SSNorFedTaxIDTextBox.MaxLength = 11
        Me.SSNorFedTaxIDTextBox.Name = "SSNorFedTaxIDTextBox"
        Me.SSNorFedTaxIDTextBox.Size = New System.Drawing.Size(199, 20)
        Me.SSNorFedTaxIDTextBox.TabIndex = 180
        '
        'FTIDLabel
        '
        FTIDLabel.AutoSize = True
        FTIDLabel.Location = New System.Drawing.Point(79, 73)
        FTIDLabel.Name = "FTIDLabel"
        FTIDLabel.Size = New System.Drawing.Size(34, 13)
        FTIDLabel.TabIndex = 181
        FTIDLabel.Text = "FTID:"
        '
        'FTIDCheckBox
        '
        Me.FTIDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "FTID", True))
        Me.FTIDCheckBox.Location = New System.Drawing.Point(119, 68)
        Me.FTIDCheckBox.Name = "FTIDCheckBox"
        Me.FTIDCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.FTIDCheckBox.TabIndex = 182
        '
        'LicenseNumberLabel
        '
        LicenseNumberLabel.AutoSize = True
        LicenseNumberLabel.Location = New System.Drawing.Point(26, 101)
        LicenseNumberLabel.Name = "LicenseNumberLabel"
        LicenseNumberLabel.Size = New System.Drawing.Size(87, 13)
        LicenseNumberLabel.TabIndex = 183
        LicenseNumberLabel.Text = "License Number:"
        '
        'LicenseNumberTextBox
        '
        Me.LicenseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "LicenseNumber", True))
        Me.LicenseNumberTextBox.Location = New System.Drawing.Point(119, 98)
        Me.LicenseNumberTextBox.MaxLength = 15
        Me.LicenseNumberTextBox.Name = "LicenseNumberTextBox"
        Me.LicenseNumberTextBox.Size = New System.Drawing.Size(199, 20)
        Me.LicenseNumberTextBox.TabIndex = 184
        '
        'SignatureonFileLabel
        '
        SignatureonFileLabel.AutoSize = True
        SignatureonFileLabel.Location = New System.Drawing.Point(24, 129)
        SignatureonFileLabel.Name = "SignatureonFileLabel"
        SignatureonFileLabel.Size = New System.Drawing.Size(89, 13)
        SignatureonFileLabel.TabIndex = 185
        SignatureonFileLabel.Text = "Signature on File:"
        '
        'SignatureonFileCheckBox
        '
        Me.SignatureonFileCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "SignatureonFile", True))
        Me.SignatureonFileCheckBox.Location = New System.Drawing.Point(119, 124)
        Me.SignatureonFileCheckBox.Name = "SignatureonFileCheckBox"
        Me.SignatureonFileCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.SignatureonFileCheckBox.TabIndex = 186
        '
        'MedicarePINLabel
        '
        MedicarePINLabel.AutoSize = True
        MedicarePINLabel.Location = New System.Drawing.Point(38, 153)
        MedicarePINLabel.Name = "MedicarePINLabel"
        MedicarePINLabel.Size = New System.Drawing.Size(75, 13)
        MedicarePINLabel.TabIndex = 187
        MedicarePINLabel.Text = "Medicare PIN:"
        '
        'MedicarePINTextBox
        '
        Me.MedicarePINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "MedicarePIN", True))
        Me.MedicarePINTextBox.Location = New System.Drawing.Point(119, 149)
        Me.MedicarePINTextBox.MaxLength = 20
        Me.MedicarePINTextBox.Name = "MedicarePINTextBox"
        Me.MedicarePINTextBox.Size = New System.Drawing.Size(199, 20)
        Me.MedicarePINTextBox.TabIndex = 188
        '
        'MedicaidPINLabel
        '
        MedicaidPINLabel.AutoSize = True
        MedicaidPINLabel.Location = New System.Drawing.Point(39, 179)
        MedicaidPINLabel.Name = "MedicaidPINLabel"
        MedicaidPINLabel.Size = New System.Drawing.Size(74, 13)
        MedicaidPINLabel.TabIndex = 189
        MedicaidPINLabel.Text = "Medicaid PIN:"
        '
        'MedicaidPINTextBox
        '
        Me.MedicaidPINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "MedicaidPIN", True))
        Me.MedicaidPINTextBox.Location = New System.Drawing.Point(119, 176)
        Me.MedicaidPINTextBox.MaxLength = 20
        Me.MedicaidPINTextBox.Name = "MedicaidPINTextBox"
        Me.MedicaidPINTextBox.Size = New System.Drawing.Size(199, 20)
        Me.MedicaidPINTextBox.TabIndex = 190
        '
        'ChampusPINLabel
        '
        ChampusPINLabel.AutoSize = True
        ChampusPINLabel.Location = New System.Drawing.Point(38, 205)
        ChampusPINLabel.Name = "ChampusPINLabel"
        ChampusPINLabel.Size = New System.Drawing.Size(75, 13)
        ChampusPINLabel.TabIndex = 191
        ChampusPINLabel.Text = "Champus PIN:"
        '
        'ChampusPINTextBox
        '
        Me.ChampusPINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "ChampusPIN", True))
        Me.ChampusPINTextBox.Location = New System.Drawing.Point(119, 202)
        Me.ChampusPINTextBox.MaxLength = 20
        Me.ChampusPINTextBox.Name = "ChampusPINTextBox"
        Me.ChampusPINTextBox.Size = New System.Drawing.Size(199, 20)
        Me.ChampusPINTextBox.TabIndex = 192
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(77, 245)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 193
        StateLabel.Text = "State:"
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(118, 243)
        Me.StateTextBox.MaxLength = 2
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(42, 20)
        Me.StateTextBox.TabIndex = 194
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(166, 247)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(53, 13)
        ZipCodeLabel.TabIndex = 195
        ZipCodeLabel.Text = "Zip Code:"
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(225, 244)
        Me.ZipCodeTextBox.MaxLength = 10
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(93, 20)
        Me.ZipCodeTextBox.TabIndex = 196
        '
        'TBPhone
        '
        Me.TBPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPhysionBindingSource, "Phone", True))
        Me.TBPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPhone.Location = New System.Drawing.Point(312, 349)
        Me.TBPhone.MaxLength = 14
        Me.TBPhone.Name = "TBPhone"
        Me.TBPhone.Size = New System.Drawing.Size(114, 21)
        Me.TBPhone.TabIndex = 88
        '
        'Physician
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 598)
        Me.Controls.Add(Me.MMPhysionBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(205, 85)
        Me.Name = "Physician"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Physician"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgPhysician, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPhysionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.MMPhysionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMPhysionBindingNavigator.ResumeLayout(False)
        Me.MMPhysionBindingNavigator.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleInitialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CredentialsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Street1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Street2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMPhysionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMPhysionTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMPhysionTableAdapter
    Friend WithEvents MMPhysionBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMPhysionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgPhysician As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents BlueCross_ShieldPINTextBox As TextBox
    Friend WithEvents CommercialPINTextBox As TextBox
    Friend WithEvents GroupPINTextBox As TextBox
    Friend WithEvents HMOPINTextBox As TextBox
    Friend WithEvents PPOPINTextBox As TextBox
    Friend WithEvents MedicareGroupIDTextBox As TextBox
    Friend WithEvents MedicaidGroupIDTextBox As TextBox
    Friend WithEvents BC_BSGroupIDTextBox As TextBox
    Friend WithEvents OtherGroupIDTextBox As TextBox
    Friend WithEvents EMCIDTextBox As TextBox
    Friend WithEvents MedicareParticpProviderCheckBox As CheckBox
    Friend WithEvents UPINTextBox As TextBox
    Friend WithEvents Extra1TextBox As TextBox
    Friend WithEvents Extra2TextBox As TextBox
    Friend WithEvents SpecialtyTextBox As TextBox
    Friend WithEvents SecurityLevelTextBox As TextBox
    Friend WithEvents SBNumberTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents SSNorFedTaxIDTextBox As TextBox
    Friend WithEvents FTIDCheckBox As CheckBox
    Friend WithEvents LicenseNumberTextBox As TextBox
    Friend WithEvents SignatureonFileCheckBox As CheckBox
    Friend WithEvents MedicarePINTextBox As TextBox
    Friend WithEvents MedicaidPINTextBox As TextBox
    Friend WithEvents ChampusPINTextBox As TextBox
    Friend WithEvents TBPhone As TextBox
End Class
