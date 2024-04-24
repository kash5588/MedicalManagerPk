<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pharmacy
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
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Dim ExtensionLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim Street2Label As System.Windows.Forms.Label
        Dim Street1Label As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pharmacy))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.MMPharmacyDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fax = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMPharmacyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TextStreet2 = New System.Windows.Forms.TextBox
        Me.TextEmail = New System.Windows.Forms.TextBox
        Me.TextContact = New System.Windows.Forms.TextBox
        Me.MaskedTextFax = New System.Windows.Forms.MaskedTextBox
        Me.TextExtension = New System.Windows.Forms.TextBox
        Me.MaskedTextPhone = New System.Windows.Forms.MaskedTextBox
        Me.TextZip = New System.Windows.Forms.TextBox
        Me.TextState = New System.Windows.Forms.TextBox
        Me.TextCity = New System.Windows.Forms.TextBox
        Me.TextStreet1 = New System.Windows.Forms.TextBox
        Me.TextName = New System.Windows.Forms.TextBox
        Me.TextCode = New System.Windows.Forms.TextBox
        Me.MMPharmacyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MMPharmacyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.MMPharmacyTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.MMPharmacyTableAdapter
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        EmailLabel = New System.Windows.Forms.Label
        ContactLabel = New System.Windows.Forms.Label
        FaxLabel = New System.Windows.Forms.Label
        ExtensionLabel = New System.Windows.Forms.Label
        PhoneLabel = New System.Windows.Forms.Label
        ZipCodeLabel = New System.Windows.Forms.Label
        StateLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        Street2Label = New System.Windows.Forms.Label
        Street1Label = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        CodeLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MMPharmacyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPharmacyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMPharmacyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMPharmacyBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(578, 184)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 22
        EmailLabel.Text = "Email:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Location = New System.Drawing.Point(566, 158)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(47, 13)
        ContactLabel.TabIndex = 20
        ContactLabel.Text = "Contact:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(586, 132)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(27, 13)
        FaxLabel.TabIndex = 18
        FaxLabel.Text = "Fax:"
        '
        'ExtensionLabel
        '
        ExtensionLabel.AutoSize = True
        ExtensionLabel.Location = New System.Drawing.Point(557, 106)
        ExtensionLabel.Name = "ExtensionLabel"
        ExtensionLabel.Size = New System.Drawing.Size(56, 13)
        ExtensionLabel.TabIndex = 16
        ExtensionLabel.Text = "Extension:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(572, 80)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 14
        PhoneLabel.Text = "Phone:"
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(287, 210)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(53, 13)
        ZipCodeLabel.TabIndex = 12
        ZipCodeLabel.Text = "Zip Code:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(176, 210)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 10
        StateLabel.Text = "State:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(184, 184)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 8
        CityLabel.Text = "City:"
        '
        'Street2Label
        '
        Street2Label.AutoSize = True
        Street2Label.Location = New System.Drawing.Point(167, 158)
        Street2Label.Name = "Street2Label"
        Street2Label.Size = New System.Drawing.Size(44, 13)
        Street2Label.TabIndex = 6
        Street2Label.Text = "Street2:"
        '
        'Street1Label
        '
        Street1Label.AutoSize = True
        Street1Label.Location = New System.Drawing.Point(167, 132)
        Street1Label.Name = "Street1Label"
        Street1Label.Size = New System.Drawing.Size(44, 13)
        Street1Label.TabIndex = 4
        Street1Label.Text = "Street1:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(173, 106)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Name:"
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(176, 80)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(35, 13)
        CodeLabel.TabIndex = 0
        CodeLabel.Text = "Code:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(993, 381)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MMPharmacyDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(985, 355)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MMPharmacyDataGridView
        '
        Me.MMPharmacyDataGridView.AllowUserToAddRows = False
        Me.MMPharmacyDataGridView.AutoGenerateColumns = False
        Me.MMPharmacyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Fax, Me.DataGridViewTextBoxColumn11, Me.Email})
        Me.MMPharmacyDataGridView.DataSource = Me.MMPharmacyBindingSource
        Me.MMPharmacyDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.MMPharmacyDataGridView.Name = "MMPharmacyDataGridView"
        Me.MMPharmacyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MMPharmacyDataGridView.Size = New System.Drawing.Size(976, 344)
        Me.MMPharmacyDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Street1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Street1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Street2"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Street2"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn5.HeaderText = "City"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn6.HeaderText = "State"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ZipCode"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Zip"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 45
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Extension"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ext"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 35
        '
        'Fax
        '
        Me.Fax.DataPropertyName = "Fax"
        Me.Fax.HeaderText = "Fax"
        Me.Fax.Name = "Fax"
        Me.Fax.Width = 80
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Contact"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Contact"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 90
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'MMPharmacyBindingSource
        '
        Me.MMPharmacyBindingSource.DataMember = "MMPharmacy"
        Me.MMPharmacyBindingSource.DataSource = Me.MMDataDataSet2
        '
        'MMDataDataSet2
        '
        Me.MMDataDataSet2.DataSetName = "MMDataDataSet2"
        Me.MMDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextStreet2)
        Me.TabPage2.Controls.Add(Me.TextEmail)
        Me.TabPage2.Controls.Add(Me.TextContact)
        Me.TabPage2.Controls.Add(Me.MaskedTextFax)
        Me.TabPage2.Controls.Add(Me.TextExtension)
        Me.TabPage2.Controls.Add(Me.MaskedTextPhone)
        Me.TabPage2.Controls.Add(Me.TextZip)
        Me.TabPage2.Controls.Add(Me.TextState)
        Me.TabPage2.Controls.Add(Me.TextCity)
        Me.TabPage2.Controls.Add(Me.TextStreet1)
        Me.TabPage2.Controls.Add(Me.TextName)
        Me.TabPage2.Controls.Add(Me.TextCode)
        Me.TabPage2.Controls.Add(CodeLabel)
        Me.TabPage2.Controls.Add(NameLabel)
        Me.TabPage2.Controls.Add(Street1Label)
        Me.TabPage2.Controls.Add(Street2Label)
        Me.TabPage2.Controls.Add(CityLabel)
        Me.TabPage2.Controls.Add(StateLabel)
        Me.TabPage2.Controls.Add(ZipCodeLabel)
        Me.TabPage2.Controls.Add(PhoneLabel)
        Me.TabPage2.Controls.Add(ExtensionLabel)
        Me.TabPage2.Controls.Add(FaxLabel)
        Me.TabPage2.Controls.Add(ContactLabel)
        Me.TabPage2.Controls.Add(EmailLabel)
        Me.TabPage2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "Code", True))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(985, 355)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextStreet2
        '
        Me.TextStreet2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "Street2", True))
        Me.TextStreet2.Location = New System.Drawing.Point(217, 155)
        Me.TextStreet2.Name = "TextStreet2"
        Me.TextStreet2.Size = New System.Drawing.Size(241, 20)
        Me.TextStreet2.TabIndex = 34
        '
        'TextEmail
        '
        Me.TextEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "Email", True))
        Me.TextEmail.Location = New System.Drawing.Point(619, 181)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(152, 20)
        Me.TextEmail.TabIndex = 33
        '
        'TextContact
        '
        Me.TextContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "Contact", True))
        Me.TextContact.Location = New System.Drawing.Point(619, 155)
        Me.TextContact.Name = "TextContact"
        Me.TextContact.Size = New System.Drawing.Size(152, 20)
        Me.TextContact.TabIndex = 32
        '
        'MaskedTextFax
        '
        Me.MaskedTextFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "Fax", True))
        Me.MaskedTextFax.Location = New System.Drawing.Point(619, 129)
        Me.MaskedTextFax.Mask = "(999) 000-0000"
        Me.MaskedTextFax.Name = "MaskedTextFax"
        Me.MaskedTextFax.Size = New System.Drawing.Size(152, 20)
        Me.MaskedTextFax.TabIndex = 31
        '
        'TextExtension
        '
        Me.TextExtension.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "Extension", True))
        Me.TextExtension.Location = New System.Drawing.Point(619, 103)
        Me.TextExtension.Name = "TextExtension"
        Me.TextExtension.Size = New System.Drawing.Size(152, 20)
        Me.TextExtension.TabIndex = 30
        '
        'MaskedTextPhone
        '
        Me.MaskedTextPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "Phone", True))
        Me.MaskedTextPhone.Location = New System.Drawing.Point(619, 77)
        Me.MaskedTextPhone.Mask = "(999) 000-0000"
        Me.MaskedTextPhone.Name = "MaskedTextPhone"
        Me.MaskedTextPhone.Size = New System.Drawing.Size(152, 20)
        Me.MaskedTextPhone.TabIndex = 29
        '
        'TextZip
        '
        Me.TextZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "ZipCode", True))
        Me.TextZip.Location = New System.Drawing.Point(346, 207)
        Me.TextZip.Name = "TextZip"
        Me.TextZip.Size = New System.Drawing.Size(112, 20)
        Me.TextZip.TabIndex = 28
        '
        'TextState
        '
        Me.TextState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "State", True))
        Me.TextState.Location = New System.Drawing.Point(217, 207)
        Me.TextState.Name = "TextState"
        Me.TextState.Size = New System.Drawing.Size(36, 20)
        Me.TextState.TabIndex = 27
        '
        'TextCity
        '
        Me.TextCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "City", True))
        Me.TextCity.Location = New System.Drawing.Point(217, 181)
        Me.TextCity.Name = "TextCity"
        Me.TextCity.Size = New System.Drawing.Size(241, 20)
        Me.TextCity.TabIndex = 26
        '
        'TextStreet1
        '
        Me.TextStreet1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "Street1", True))
        Me.TextStreet1.Location = New System.Drawing.Point(217, 129)
        Me.TextStreet1.Name = "TextStreet1"
        Me.TextStreet1.Size = New System.Drawing.Size(241, 20)
        Me.TextStreet1.TabIndex = 25
        '
        'TextName
        '
        Me.TextName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "Name", True))
        Me.TextName.Location = New System.Drawing.Point(217, 103)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(241, 20)
        Me.TextName.TabIndex = 24
        '
        'TextCode
        '
        Me.TextCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMPharmacyBindingSource, "Code", True))
        Me.TextCode.Location = New System.Drawing.Point(217, 77)
        Me.TextCode.Name = "TextCode"
        Me.TextCode.Size = New System.Drawing.Size(137, 20)
        Me.TextCode.TabIndex = 23
        '
        'MMPharmacyBindingNavigator
        '
        Me.MMPharmacyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMPharmacyBindingNavigator.BindingSource = Me.MMPharmacyBindingSource
        Me.MMPharmacyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMPharmacyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMPharmacyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel1, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel4, Me.MMPharmacyBindingNavigatorSaveItem, Me.ToolStripLabel5, Me.ToolStripLabel2, Me.txtFind, Me.ToolStripLabel3, Me.cmbFilter})
        Me.MMPharmacyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMPharmacyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMPharmacyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMPharmacyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMPharmacyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMPharmacyBindingNavigator.Name = "MMPharmacyBindingNavigator"
        Me.MMPharmacyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMPharmacyBindingNavigator.Size = New System.Drawing.Size(993, 25)
        Me.MMPharmacyBindingNavigator.TabIndex = 1
        Me.MMPharmacyBindingNavigator.Text = "BindingNavigator1"
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
        'MMPharmacyBindingNavigatorSaveItem
        '
        Me.MMPharmacyBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMPharmacyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMPharmacyBindingNavigatorSaveItem.Name = "MMPharmacyBindingNavigatorSaveItem"
        Me.MMPharmacyBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.MMPharmacyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(27, 22)
        Me.ToolStripLabel2.Text = "Find"
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
        'cmbFilter
        '
        Me.cmbFilter.AutoCompleteCustomSource.AddRange(New String() {"Description", "Code"})
        Me.cmbFilter.Items.AddRange(New Object() {"Description", "Code"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 25)
        '
        'MMPharmacyTableAdapter
        '
        Me.MMPharmacyTableAdapter.ClearBeforeFill = True
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
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel5.Text = "     "
        '
        'Pharmacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 410)
        Me.Controls.Add(Me.MMPharmacyBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(230, 85)
        Me.Name = "Pharmacy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmacy"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.MMPharmacyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPharmacyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.MMPharmacyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMPharmacyBindingNavigator.ResumeLayout(False)
        Me.MMPharmacyBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents MMPharmacyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMPharmacyTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.MMPharmacyTableAdapter
    Friend WithEvents MMPharmacyBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMPharmacyBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MMPharmacyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TextZip As System.Windows.Forms.TextBox
    Friend WithEvents TextState As System.Windows.Forms.TextBox
    Friend WithEvents TextCity As System.Windows.Forms.TextBox
    Friend WithEvents TextStreet1 As System.Windows.Forms.TextBox
    Friend WithEvents TextName As System.Windows.Forms.TextBox
    Friend WithEvents TextCode As System.Windows.Forms.TextBox
    Friend WithEvents TextStreet2 As System.Windows.Forms.TextBox
    Friend WithEvents TextEmail As System.Windows.Forms.TextBox
    Friend WithEvents TextContact As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextFax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextExtension As System.Windows.Forms.TextBox
    Friend WithEvents MaskedTextPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
End Class
