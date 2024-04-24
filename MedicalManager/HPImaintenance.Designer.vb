<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HPImaintenance
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
        Dim CCLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim SubCategoryLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim AddFieldLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HPImaintenance))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnJump2 = New System.Windows.Forms.Button
        Me.txtJump2 = New System.Windows.Forms.TextBox
        Me.cboHPICategory = New System.Windows.Forms.ComboBox
        Me.btnReorder = New System.Windows.Forms.CheckBox
        Me.HPIDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AddField = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SortOrder = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HPIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.cmbCategory = New System.Windows.Forms.ComboBox
        Me.cmbCC = New System.Windows.Forms.ComboBox
        Me.txtList = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox
        Me.AddFieldTextBox = New System.Windows.Forms.TextBox
        Me.CCComboBox = New System.Windows.Forms.ComboBox
        Me.HPI1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.SubCategoryComboBox = New System.Windows.Forms.ComboBox
        Me.MMChartCCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HPIBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HPIBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.HPITableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.HPITableAdapter
        Me.HPI1TableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.HPI1TableAdapter
        Me.MMChartCCTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartCCTableAdapter
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        IDLabel = New System.Windows.Forms.Label
        CCLabel = New System.Windows.Forms.Label
        CategoryLabel = New System.Windows.Forms.Label
        SubCategoryLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        AddFieldLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label8 = New System.Windows.Forms.Label
        Label9 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.HPIDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HPIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.HPI1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartCCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HPIBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HPIBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(73, 34)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'CCLabel
        '
        CCLabel.AutoSize = True
        CCLabel.Location = New System.Drawing.Point(13, 66)
        CCLabel.Name = "CCLabel"
        CCLabel.Size = New System.Drawing.Size(83, 13)
        CCLabel.TabIndex = 2
        CCLabel.Text = "Template name:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(42, 90)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 4
        CategoryLabel.Text = "Category:"
        '
        'SubCategoryLabel
        '
        SubCategoryLabel.AutoSize = True
        SubCategoryLabel.Location = New System.Drawing.Point(297, 34)
        SubCategoryLabel.Name = "SubCategoryLabel"
        SubCategoryLabel.Size = New System.Drawing.Size(74, 13)
        SubCategoryLabel.TabIndex = 6
        SubCategoryLabel.Text = "Sub Category:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(31, 118)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 8
        DescriptionLabel.Text = "Description:"
        '
        'AddFieldLabel
        '
        AddFieldLabel.AutoSize = True
        AddFieldLabel.Location = New System.Drawing.Point(317, 89)
        AddFieldLabel.Name = "AddFieldLabel"
        AddFieldLabel.Size = New System.Drawing.Size(54, 13)
        AddFieldLabel.TabIndex = 10
        AddFieldLabel.Text = "Add Field:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(16, 37)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 13)
        Label1.TabIndex = 19
        Label1.Text = "Template name:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(44, 66)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 20
        Label2.Text = "Category:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(24, 93)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(74, 13)
        Label3.TabIndex = 22
        Label3.Text = "Sub Category:"
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(27, 125)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(71, 17)
        Label4.TabIndex = 23
        Label4.Text = "Descriptions:"
        '
        'Label8
        '
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(27, 140)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(71, 49)
        Label8.TabIndex = 24
        Label8.Text = "(For multiple entries, enter a new description item per line)"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(3, 8)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(52, 13)
        Label9.TabIndex = 165
        Label9.Text = "Category:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(674, 595)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnJump2)
        Me.TabPage1.Controls.Add(Me.txtJump2)
        Me.TabPage1.Controls.Add(Label9)
        Me.TabPage1.Controls.Add(Me.cboHPICategory)
        Me.TabPage1.Controls.Add(Me.btnReorder)
        Me.TabPage1.Controls.Add(Me.HPIDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(666, 569)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnJump2
        '
        Me.btnJump2.Location = New System.Drawing.Point(84, 27)
        Me.btnJump2.Name = "btnJump2"
        Me.btnJump2.Size = New System.Drawing.Size(47, 22)
        Me.btnJump2.TabIndex = 173
        Me.btnJump2.Text = "Jump"
        Me.btnJump2.UseVisualStyleBackColor = True
        Me.btnJump2.Visible = False
        '
        'txtJump2
        '
        Me.txtJump2.Location = New System.Drawing.Point(44, 28)
        Me.txtJump2.Name = "txtJump2"
        Me.txtJump2.Size = New System.Drawing.Size(40, 20)
        Me.txtJump2.TabIndex = 172
        Me.txtJump2.Visible = False
        '
        'cboHPICategory
        '
        Me.cboHPICategory.FormattingEnabled = True
        Me.cboHPICategory.Location = New System.Drawing.Point(55, 3)
        Me.cboHPICategory.MaxDropDownItems = 25
        Me.cboHPICategory.Name = "cboHPICategory"
        Me.cboHPICategory.Size = New System.Drawing.Size(189, 21)
        Me.cboHPICategory.TabIndex = 164
        '
        'btnReorder
        '
        Me.btnReorder.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnReorder.AutoSize = True
        Me.btnReorder.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 6.25!)
        Me.btnReorder.Location = New System.Drawing.Point(6, 27)
        Me.btnReorder.Name = "btnReorder"
        Me.btnReorder.Size = New System.Drawing.Size(34, 22)
        Me.btnReorder.TabIndex = 163
        Me.btnReorder.Text = "1,2,3..."
        Me.btnReorder.UseVisualStyleBackColor = True
        '
        'HPIDataGridView
        '
        Me.HPIDataGridView.AllowUserToAddRows = False
        Me.HPIDataGridView.AutoGenerateColumns = False
        Me.HPIDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.AddField, Me.SortOrder})
        Me.HPIDataGridView.DataSource = Me.HPIBindingSource
        Me.HPIDataGridView.Location = New System.Drawing.Point(3, 26)
        Me.HPIDataGridView.Name = "HPIDataGridView"
        Me.HPIDataGridView.Size = New System.Drawing.Size(658, 538)
        Me.HPIDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CC"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CC"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SubCategory"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SubCategory"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 195
        '
        'AddField
        '
        Me.AddField.DataPropertyName = "AddField"
        Me.AddField.HeaderText = "Sort"
        Me.AddField.Name = "AddField"
        Me.AddField.Visible = False
        Me.AddField.Width = 50
        '
        'SortOrder
        '
        Me.SortOrder.DataPropertyName = "SortOrder"
        Me.SortOrder.HeaderText = "SortOrder"
        Me.SortOrder.Name = "SortOrder"
        Me.SortOrder.Width = 55
        '
        'HPIBindingSource
        '
        Me.HPIBindingSource.DataMember = "HPI"
        Me.HPIBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(666, 569)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 56)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Add New HPI Items"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 54)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Edit Existing Items"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(6, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(654, 5)
        Me.Label5.TabIndex = 58
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label8)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Label3)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.cmbCategory)
        Me.GroupBox2.Controls.Add(Me.cmbCC)
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(82, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 322)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Items"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(104, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Aggravated by", "Associated symptoms", "Chief Complaint", "Context", "Location", "Miscellaneous", "Quality", "Radiation", "Relieved by", "Usually", "Where"})
        Me.cmbCategory.Location = New System.Drawing.Point(104, 62)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(181, 21)
        Me.cmbCategory.Sorted = True
        Me.cmbCategory.TabIndex = 18
        '
        'cmbCC
        '
        Me.cmbCC.FormattingEnabled = True
        Me.cmbCC.Location = New System.Drawing.Point(104, 34)
        Me.cmbCC.Name = "cmbCC"
        Me.cmbCC.Size = New System.Drawing.Size(181, 21)
        Me.cmbCC.TabIndex = 14
        '
        'txtList
        '
        Me.txtList.Location = New System.Drawing.Point(104, 122)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(456, 194)
        Me.txtList.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(453, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Post New Item(s)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CategoryComboBox)
        Me.GroupBox1.Controls.Add(Me.AddFieldTextBox)
        Me.GroupBox1.Controls.Add(AddFieldLabel)
        Me.GroupBox1.Controls.Add(Me.CCComboBox)
        Me.GroupBox1.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(DescriptionLabel)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Controls.Add(Me.SubCategoryComboBox)
        Me.GroupBox1.Controls.Add(CCLabel)
        Me.GroupBox1.Controls.Add(SubCategoryLabel)
        Me.GroupBox1.Controls.Add(CategoryLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(82, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 166)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HPIBindingSource, "Category", True))
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Items.AddRange(New Object() {"Aggravated by", "Associated symptoms", "Chief Complaint", "Context", "Location", "Miscellaneous", "Quality", "Radiation", "Relieved by", "Usually", "Where"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(100, 86)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(183, 21)
        Me.CategoryComboBox.Sorted = True
        Me.CategoryComboBox.TabIndex = 5
        '
        'AddFieldTextBox
        '
        Me.AddFieldTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HPIBindingSource, "AddField", True))
        Me.AddFieldTextBox.Location = New System.Drawing.Point(377, 85)
        Me.AddFieldTextBox.Name = "AddFieldTextBox"
        Me.AddFieldTextBox.Size = New System.Drawing.Size(183, 20)
        Me.AddFieldTextBox.TabIndex = 11
        '
        'CCComboBox
        '
        Me.CCComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HPIBindingSource, "CC", True))
        Me.CCComboBox.DataSource = Me.HPI1BindingSource
        Me.CCComboBox.DisplayMember = "CC"
        Me.CCComboBox.FormattingEnabled = True
        Me.CCComboBox.Location = New System.Drawing.Point(100, 58)
        Me.CCComboBox.Name = "CCComboBox"
        Me.CCComboBox.Size = New System.Drawing.Size(183, 21)
        Me.CCComboBox.TabIndex = 13
        Me.CCComboBox.ValueMember = "CC"
        '
        'HPI1BindingSource
        '
        Me.HPI1BindingSource.DataMember = "HPI1"
        Me.HPI1BindingSource.DataSource = Me.MMDataDataSet1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HPIBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(100, 114)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(460, 33)
        Me.DescriptionTextBox.TabIndex = 9
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HPIBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(100, 30)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(85, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'SubCategoryComboBox
        '
        Me.SubCategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HPIBindingSource, "SubCategory", True))
        Me.SubCategoryComboBox.FormattingEnabled = True
        Me.SubCategoryComboBox.Location = New System.Drawing.Point(377, 30)
        Me.SubCategoryComboBox.Name = "SubCategoryComboBox"
        Me.SubCategoryComboBox.Size = New System.Drawing.Size(183, 21)
        Me.SubCategoryComboBox.TabIndex = 7
        '
        'MMChartCCBindingSource
        '
        Me.MMChartCCBindingSource.DataMember = "MMChartCC"
        Me.MMChartCCBindingSource.DataSource = Me.MMDataDataSet1
        '
        'HPIBindingNavigator
        '
        Me.HPIBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HPIBindingNavigator.BindingSource = Me.HPIBindingSource
        Me.HPIBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HPIBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HPIBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel1, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel2, Me.HPIBindingNavigatorSaveItem})
        Me.HPIBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HPIBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HPIBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HPIBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HPIBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HPIBindingNavigator.Name = "HPIBindingNavigator"
        Me.HPIBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HPIBindingNavigator.Size = New System.Drawing.Size(677, 25)
        Me.HPIBindingNavigator.TabIndex = 1
        Me.HPIBindingNavigator.Text = "BindingNavigator1"
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
        'HPIBindingNavigatorSaveItem
        '
        Me.HPIBindingNavigatorSaveItem.Image = CType(resources.GetObject("HPIBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HPIBindingNavigatorSaveItem.Name = "HPIBindingNavigatorSaveItem"
        Me.HPIBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.HPIBindingNavigatorSaveItem.Text = "Save Data"
        '
        'HPITableAdapter
        '
        Me.HPITableAdapter.ClearBeforeFill = True
        '
        'HPI1TableAdapter
        '
        Me.HPI1TableAdapter.ClearBeforeFill = True
        '
        'MMChartCCTableAdapter
        '
        Me.MMChartCCTableAdapter.ClearBeforeFill = True
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
        'HPImaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 626)
        Me.Controls.Add(Me.HPIBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "HPImaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HPI Maintenance"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.HPIDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HPIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.HPI1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartCCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HPIBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HPIBindingNavigator.ResumeLayout(False)
        Me.HPIBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents HPIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HPITableAdapter As MedicalManager.MMDataDataSet1TableAdapters.HPITableAdapter
    Friend WithEvents HPIBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents HPIBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents HPIDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubCategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddFieldTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HPI1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HPI1TableAdapter As MedicalManager.MMDataDataSet1TableAdapters.HPI1TableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtList As System.Windows.Forms.TextBox
    Friend WithEvents MMChartCCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartCCTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartCCTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCC As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnReorder As System.Windows.Forms.CheckBox
    Friend WithEvents cboHPICategory As System.Windows.Forms.ComboBox
    Friend WithEvents btnJump2 As System.Windows.Forms.Button
    Friend WithEvents txtJump2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddField As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SortOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
End Class
