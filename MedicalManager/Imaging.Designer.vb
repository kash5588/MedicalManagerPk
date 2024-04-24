<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imaging
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
        Dim CPTCodeLabel As System.Windows.Forms.Label
        Dim InHouseLabel As System.Windows.Forms.Label
        Dim InHouseBillingLabel As System.Windows.Forms.Label
        Dim ChartEntryLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim MyTestLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Imaging))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CPTCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InHouseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.InHouseBillingDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ChartEntryDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.MMChartTestImagingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CPTCodeTextBox = New System.Windows.Forms.TextBox
        Me.InHouseCheckBox = New System.Windows.Forms.CheckBox
        Me.InHouseBillingCheckBox = New System.Windows.Forms.CheckBox
        Me.ChartEntryCheckBox = New System.Windows.Forms.CheckBox
        Me.UserIDTextBox = New System.Windows.Forms.TextBox
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.TypeTextBox = New System.Windows.Forms.TextBox
        Me.AmountTextBox = New System.Windows.Forms.TextBox
        Me.MyTestTextBox = New System.Windows.Forms.TextBox
        Me.MMChartTestImagingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.MMChartTestImagingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.MMChartTestImagingTableAdapter1 = New MedicalManager.MMDataDataSet1TableAdapters.MMChartTestImagingTableAdapter
        CPTCodeLabel = New System.Windows.Forms.Label
        InHouseLabel = New System.Windows.Forms.Label
        InHouseBillingLabel = New System.Windows.Forms.Label
        ChartEntryLabel = New System.Windows.Forms.Label
        UserIDLabel = New System.Windows.Forms.Label
        IdLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        TypeLabel = New System.Windows.Forms.Label
        AmountLabel = New System.Windows.Forms.Label
        MyTestLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartTestImagingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMChartTestImagingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMChartTestImagingBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CPTCodeLabel
        '
        CPTCodeLabel.AutoSize = True
        CPTCodeLabel.Location = New System.Drawing.Point(103, 20)
        CPTCodeLabel.Name = "CPTCodeLabel"
        CPTCodeLabel.Size = New System.Drawing.Size(56, 13)
        CPTCodeLabel.TabIndex = 0
        CPTCodeLabel.Text = "CPTCode:"
        '
        'InHouseLabel
        '
        InHouseLabel.AutoSize = True
        InHouseLabel.Location = New System.Drawing.Point(430, 21)
        InHouseLabel.Name = "InHouseLabel"
        InHouseLabel.Size = New System.Drawing.Size(53, 13)
        InHouseLabel.TabIndex = 2
        InHouseLabel.Text = "In House:"
        '
        'InHouseBillingLabel
        '
        InHouseBillingLabel.AutoSize = True
        InHouseBillingLabel.Location = New System.Drawing.Point(400, 51)
        InHouseBillingLabel.Name = "InHouseBillingLabel"
        InHouseBillingLabel.Size = New System.Drawing.Size(83, 13)
        InHouseBillingLabel.TabIndex = 4
        InHouseBillingLabel.Text = "In House Billing:"
        '
        'ChartEntryLabel
        '
        ChartEntryLabel.AutoSize = True
        ChartEntryLabel.Location = New System.Drawing.Point(421, 81)
        ChartEntryLabel.Name = "ChartEntryLabel"
        ChartEntryLabel.Size = New System.Drawing.Size(62, 13)
        ChartEntryLabel.TabIndex = 6
        ChartEntryLabel.Text = "Chart Entry:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(437, 109)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(46, 13)
        UserIDLabel.TabIndex = 8
        UserIDLabel.Text = "User ID:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(138, 49)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(21, 13)
        IdLabel.TabIndex = 10
        IdLabel.Text = "ID:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(96, 79)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 12
        DescriptionLabel.Text = "Description:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(125, 109)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 14
        TypeLabel.Text = "Type:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(113, 139)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 16
        AmountLabel.Text = "Amount:"
        '
        'MyTestLabel
        '
        MyTestLabel.AutoSize = True
        MyTestLabel.Location = New System.Drawing.Point(111, 167)
        MyTestLabel.Name = "MyTestLabel"
        MyTestLabel.Size = New System.Drawing.Size(48, 13)
        MyTestLabel.TabIndex = 18
        MyTestLabel.Text = "My Test:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(766, 304)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(758, 278)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.CPTCodeDataGridViewTextBoxColumn, Me.Description, Me.Type, Me.Amount, Me.InHouseDataGridViewCheckBoxColumn, Me.InHouseBillingDataGridViewCheckBoxColumn, Me.ChartEntryDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.MMChartTestImagingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(756, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 50
        '
        'CPTCodeDataGridViewTextBoxColumn
        '
        Me.CPTCodeDataGridViewTextBoxColumn.DataPropertyName = "CPTCode"
        Me.CPTCodeDataGridViewTextBoxColumn.HeaderText = "CPT"
        Me.CPTCodeDataGridViewTextBoxColumn.Name = "CPTCodeDataGridViewTextBoxColumn"
        Me.CPTCodeDataGridViewTextBoxColumn.Width = 75
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 225
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.Width = 70
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 65
        '
        'InHouseDataGridViewCheckBoxColumn
        '
        Me.InHouseDataGridViewCheckBoxColumn.DataPropertyName = "InHouse"
        Me.InHouseDataGridViewCheckBoxColumn.HeaderText = "In House"
        Me.InHouseDataGridViewCheckBoxColumn.Name = "InHouseDataGridViewCheckBoxColumn"
        Me.InHouseDataGridViewCheckBoxColumn.Width = 60
        '
        'InHouseBillingDataGridViewCheckBoxColumn
        '
        Me.InHouseBillingDataGridViewCheckBoxColumn.DataPropertyName = "InHouseBilling"
        Me.InHouseBillingDataGridViewCheckBoxColumn.HeaderText = "In House Bill"
        Me.InHouseBillingDataGridViewCheckBoxColumn.Name = "InHouseBillingDataGridViewCheckBoxColumn"
        Me.InHouseBillingDataGridViewCheckBoxColumn.Width = 75
        '
        'ChartEntryDataGridViewCheckBoxColumn
        '
        Me.ChartEntryDataGridViewCheckBoxColumn.DataPropertyName = "ChartEntry"
        Me.ChartEntryDataGridViewCheckBoxColumn.HeaderText = "Chart Entry"
        Me.ChartEntryDataGridViewCheckBoxColumn.Name = "ChartEntryDataGridViewCheckBoxColumn"
        Me.ChartEntryDataGridViewCheckBoxColumn.Width = 75
        '
        'MMChartTestImagingBindingSource
        '
        Me.MMChartTestImagingBindingSource.DataMember = "MMChartTestImaging"
        Me.MMChartTestImagingBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(CPTCodeLabel)
        Me.TabPage2.Controls.Add(Me.CPTCodeTextBox)
        Me.TabPage2.Controls.Add(InHouseLabel)
        Me.TabPage2.Controls.Add(Me.InHouseCheckBox)
        Me.TabPage2.Controls.Add(InHouseBillingLabel)
        Me.TabPage2.Controls.Add(Me.InHouseBillingCheckBox)
        Me.TabPage2.Controls.Add(ChartEntryLabel)
        Me.TabPage2.Controls.Add(Me.ChartEntryCheckBox)
        Me.TabPage2.Controls.Add(UserIDLabel)
        Me.TabPage2.Controls.Add(Me.UserIDTextBox)
        Me.TabPage2.Controls.Add(IdLabel)
        Me.TabPage2.Controls.Add(Me.IdTextBox)
        Me.TabPage2.Controls.Add(DescriptionLabel)
        Me.TabPage2.Controls.Add(Me.DescriptionTextBox)
        Me.TabPage2.Controls.Add(TypeLabel)
        Me.TabPage2.Controls.Add(Me.TypeTextBox)
        Me.TabPage2.Controls.Add(AmountLabel)
        Me.TabPage2.Controls.Add(Me.AmountTextBox)
        Me.TabPage2.Controls.Add(MyTestLabel)
        Me.TabPage2.Controls.Add(Me.MyTestTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(758, 278)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CPTCodeTextBox
        '
        Me.CPTCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTestImagingBindingSource, "CPTCode", True))
        Me.CPTCodeTextBox.Location = New System.Drawing.Point(163, 17)
        Me.CPTCodeTextBox.Name = "CPTCodeTextBox"
        Me.CPTCodeTextBox.Size = New System.Drawing.Size(189, 20)
        Me.CPTCodeTextBox.TabIndex = 1
        '
        'InHouseCheckBox
        '
        Me.InHouseCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MMChartTestImagingBindingSource, "InHouse", True))
        Me.InHouseCheckBox.Location = New System.Drawing.Point(489, 16)
        Me.InHouseCheckBox.Name = "InHouseCheckBox"
        Me.InHouseCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.InHouseCheckBox.TabIndex = 3
        '
        'InHouseBillingCheckBox
        '
        Me.InHouseBillingCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MMChartTestImagingBindingSource, "InHouseBilling", True))
        Me.InHouseBillingCheckBox.Location = New System.Drawing.Point(489, 46)
        Me.InHouseBillingCheckBox.Name = "InHouseBillingCheckBox"
        Me.InHouseBillingCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.InHouseBillingCheckBox.TabIndex = 5
        '
        'ChartEntryCheckBox
        '
        Me.ChartEntryCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MMChartTestImagingBindingSource, "ChartEntry", True))
        Me.ChartEntryCheckBox.Location = New System.Drawing.Point(489, 76)
        Me.ChartEntryCheckBox.Name = "ChartEntryCheckBox"
        Me.ChartEntryCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ChartEntryCheckBox.TabIndex = 7
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTestImagingBindingSource, "UserID", True))
        Me.UserIDTextBox.Enabled = False
        Me.UserIDTextBox.Location = New System.Drawing.Point(489, 106)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UserIDTextBox.TabIndex = 9
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTestImagingBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(163, 46)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(189, 20)
        Me.IdTextBox.TabIndex = 11
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTestImagingBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(163, 76)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(189, 20)
        Me.DescriptionTextBox.TabIndex = 13
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTestImagingBindingSource, "Type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(163, 106)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(189, 20)
        Me.TypeTextBox.TabIndex = 15
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTestImagingBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(163, 136)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(189, 20)
        Me.AmountTextBox.TabIndex = 17
        '
        'MyTestTextBox
        '
        Me.MyTestTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartTestImagingBindingSource, "MyTest", True))
        Me.MyTestTextBox.Location = New System.Drawing.Point(163, 164)
        Me.MyTestTextBox.Name = "MyTestTextBox"
        Me.MyTestTextBox.Size = New System.Drawing.Size(189, 20)
        Me.MyTestTextBox.TabIndex = 19
        '
        'MMChartTestImagingBindingNavigator
        '
        Me.MMChartTestImagingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMChartTestImagingBindingNavigator.BindingSource = Me.MMChartTestImagingBindingSource
        Me.MMChartTestImagingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMChartTestImagingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMChartTestImagingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel1, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel4, Me.MMChartTestImagingBindingNavigatorSaveItem, Me.ToolStripLabel5, Me.ToolStripLabel2, Me.txtFind, Me.ToolStripLabel3, Me.cmbFilter})
        Me.MMChartTestImagingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMChartTestImagingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMChartTestImagingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMChartTestImagingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMChartTestImagingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMChartTestImagingBindingNavigator.Name = "MMChartTestImagingBindingNavigator"
        Me.MMChartTestImagingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMChartTestImagingBindingNavigator.Size = New System.Drawing.Size(765, 25)
        Me.MMChartTestImagingBindingNavigator.TabIndex = 1
        Me.MMChartTestImagingBindingNavigator.Text = "BindingNavigator1"
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
        'MMChartTestImagingBindingNavigatorSaveItem
        '
        Me.MMChartTestImagingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MMChartTestImagingBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMChartTestImagingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMChartTestImagingBindingNavigatorSaveItem.Name = "MMChartTestImagingBindingNavigatorSaveItem"
        Me.MMChartTestImagingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MMChartTestImagingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel5.Text = "     "
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
        Me.cmbFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbFilter.Items.AddRange(New Object() {"Description", "CPTCode", "ID"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 25)
        '
        'MMChartTestImagingTableAdapter1
        '
        Me.MMChartTestImagingTableAdapter1.ClearBeforeFill = True
        '
        'Imaging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 333)
        Me.Controls.Add(Me.MMChartTestImagingBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(205, 85)
        Me.Name = "Imaging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imaging"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartTestImagingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.MMChartTestImagingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMChartTestImagingBindingNavigator.ResumeLayout(False)
        Me.MMChartTestImagingBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMChartTestImagingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartTestImagingBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMChartTestImagingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMChartTestImagingTableAdapter1 As MedicalManager.MMDataDataSet1TableAdapters.MMChartTestImagingTableAdapter
    Friend WithEvents CPTCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InHouseCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents InHouseBillingCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ChartEntryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MyTestTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPTCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InHouseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents InHouseBillingDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ChartEntryDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
