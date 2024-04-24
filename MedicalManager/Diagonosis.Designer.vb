<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diagonosis
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
        Dim Code1Label As System.Windows.Forms.Label
        Dim Code2Label As System.Windows.Forms.Label
        Dim Code3Label As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim TemplateLabel As System.Windows.Forms.Label
        Dim MyDxLabel As System.Windows.Forms.Label
        Dim ApprovedLabel As System.Windows.Forms.Label
        Dim ScreenLocationLabel As System.Windows.Forms.Label
        Dim TimeStampLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Diagonosis))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.MMDXDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMDXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Code1TextBox = New System.Windows.Forms.TextBox
        Me.Code2TextBox = New System.Windows.Forms.TextBox
        Me.Code3TextBox = New System.Windows.Forms.TextBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.TemplateTextBox = New System.Windows.Forms.TextBox
        Me.MyDxTextBox = New System.Windows.Forms.TextBox
        Me.ApprovedCheckBox = New System.Windows.Forms.CheckBox
        Me.ScreenLocationTextBox = New System.Windows.Forms.TextBox
        Me.TimeStampDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.MMDXBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MMDXBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.MMDXTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMDXTableAdapter
        Code1Label = New System.Windows.Forms.Label
        Code2Label = New System.Windows.Forms.Label
        Code3Label = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        TemplateLabel = New System.Windows.Forms.Label
        MyDxLabel = New System.Windows.Forms.Label
        ApprovedLabel = New System.Windows.Forms.Label
        ScreenLocationLabel = New System.Windows.Forms.Label
        TimeStampLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MMDXDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMDXBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMDXBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Code1Label
        '
        Code1Label.AutoSize = True
        Code1Label.Location = New System.Drawing.Point(110, 42)
        Code1Label.Name = "Code1Label"
        Code1Label.Size = New System.Drawing.Size(69, 13)
        Code1Label.TabIndex = 18
        Code1Label.Text = "Diag Code 1:"
        '
        'Code2Label
        '
        Code2Label.AutoSize = True
        Code2Label.Location = New System.Drawing.Point(110, 66)
        Code2Label.Name = "Code2Label"
        Code2Label.Size = New System.Drawing.Size(69, 13)
        Code2Label.TabIndex = 20
        Code2Label.Text = "Diag Code 2:"
        '
        'Code3Label
        '
        Code3Label.AutoSize = True
        Code3Label.Location = New System.Drawing.Point(110, 90)
        Code3Label.Name = "Code3Label"
        Code3Label.Size = New System.Drawing.Size(69, 13)
        Code3Label.TabIndex = 22
        Code3Label.Text = "Diag Code 3:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(116, 114)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 24
        DescriptionLabel.Text = "Description:"
        '
        'TemplateLabel
        '
        TemplateLabel.AutoSize = True
        TemplateLabel.Location = New System.Drawing.Point(125, 138)
        TemplateLabel.Name = "TemplateLabel"
        TemplateLabel.Size = New System.Drawing.Size(54, 13)
        TemplateLabel.TabIndex = 26
        TemplateLabel.Text = "Template:"
        '
        'MyDxLabel
        '
        MyDxLabel.AutoSize = True
        MyDxLabel.Location = New System.Drawing.Point(139, 162)
        MyDxLabel.Name = "MyDxLabel"
        MyDxLabel.Size = New System.Drawing.Size(40, 13)
        MyDxLabel.TabIndex = 28
        MyDxLabel.Text = "My Dx:"
        '
        'ApprovedLabel
        '
        ApprovedLabel.AutoSize = True
        ApprovedLabel.Location = New System.Drawing.Point(123, 188)
        ApprovedLabel.Name = "ApprovedLabel"
        ApprovedLabel.Size = New System.Drawing.Size(56, 13)
        ApprovedLabel.TabIndex = 30
        ApprovedLabel.Text = "Approved:"
        '
        'ScreenLocationLabel
        '
        ScreenLocationLabel.AutoSize = True
        ScreenLocationLabel.Location = New System.Drawing.Point(91, 214)
        ScreenLocationLabel.Name = "ScreenLocationLabel"
        ScreenLocationLabel.Size = New System.Drawing.Size(88, 13)
        ScreenLocationLabel.TabIndex = 32
        ScreenLocationLabel.Text = "Screen Location:"
        '
        'TimeStampLabel
        '
        TimeStampLabel.AutoSize = True
        TimeStampLabel.Location = New System.Drawing.Point(113, 239)
        TimeStampLabel.Name = "TimeStampLabel"
        TimeStampLabel.Size = New System.Drawing.Size(66, 13)
        TimeStampLabel.TabIndex = 34
        TimeStampLabel.Text = "Time Stamp:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(814, 351)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MMDXDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(806, 325)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MMDXDataGridView
        '
        Me.MMDXDataGridView.AutoGenerateColumns = False
        Me.MMDXDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.MMDXDataGridView.DataSource = Me.MMDXBindingSource
        Me.MMDXDataGridView.Location = New System.Drawing.Point(3, 6)
        Me.MMDXDataGridView.Name = "MMDXDataGridView"
        Me.MMDXDataGridView.Size = New System.Drawing.Size(803, 316)
        Me.MMDXDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Code1"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Diag Code 1"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Code2"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Diag Code 2"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Code3"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Diag Code 3"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Template"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Template"
        Me.DataGridViewTextBoxColumn5.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MyDx"
        Me.DataGridViewTextBoxColumn6.HeaderText = "My Diagnosis"
        Me.DataGridViewTextBoxColumn6.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Approved"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Approved"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ScreenLocation"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Screen Location"
        Me.DataGridViewTextBoxColumn7.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TimeStamp"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Time Stamp"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'MMDXBindingSource
        '
        Me.MMDXBindingSource.DataMember = "MMDX"
        Me.MMDXBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Code1Label)
        Me.TabPage2.Controls.Add(Me.Code1TextBox)
        Me.TabPage2.Controls.Add(Code2Label)
        Me.TabPage2.Controls.Add(Me.Code2TextBox)
        Me.TabPage2.Controls.Add(Code3Label)
        Me.TabPage2.Controls.Add(Me.Code3TextBox)
        Me.TabPage2.Controls.Add(DescriptionLabel)
        Me.TabPage2.Controls.Add(Me.DescriptionTextBox)
        Me.TabPage2.Controls.Add(TemplateLabel)
        Me.TabPage2.Controls.Add(Me.TemplateTextBox)
        Me.TabPage2.Controls.Add(MyDxLabel)
        Me.TabPage2.Controls.Add(Me.MyDxTextBox)
        Me.TabPage2.Controls.Add(ApprovedLabel)
        Me.TabPage2.Controls.Add(Me.ApprovedCheckBox)
        Me.TabPage2.Controls.Add(ScreenLocationLabel)
        Me.TabPage2.Controls.Add(Me.ScreenLocationTextBox)
        Me.TabPage2.Controls.Add(TimeStampLabel)
        Me.TabPage2.Controls.Add(Me.TimeStampDateTimePicker)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(806, 325)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Code1TextBox
        '
        Me.Code1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDXBindingSource, "Code1", True))
        Me.Code1TextBox.Location = New System.Drawing.Point(185, 39)
        Me.Code1TextBox.MaxLength = 10
        Me.Code1TextBox.Name = "Code1TextBox"
        Me.Code1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Code1TextBox.TabIndex = 19
        '
        'Code2TextBox
        '
        Me.Code2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDXBindingSource, "Code2", True))
        Me.Code2TextBox.Location = New System.Drawing.Point(185, 63)
        Me.Code2TextBox.MaxLength = 10
        Me.Code2TextBox.Name = "Code2TextBox"
        Me.Code2TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Code2TextBox.TabIndex = 21
        '
        'Code3TextBox
        '
        Me.Code3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDXBindingSource, "Code3", True))
        Me.Code3TextBox.Location = New System.Drawing.Point(185, 87)
        Me.Code3TextBox.MaxLength = 10
        Me.Code3TextBox.Name = "Code3TextBox"
        Me.Code3TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Code3TextBox.TabIndex = 23
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDXBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(185, 111)
        Me.DescriptionTextBox.MaxLength = 100
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(460, 20)
        Me.DescriptionTextBox.TabIndex = 25
        '
        'TemplateTextBox
        '
        Me.TemplateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDXBindingSource, "Template", True))
        Me.TemplateTextBox.Location = New System.Drawing.Point(185, 135)
        Me.TemplateTextBox.MaxLength = 10
        Me.TemplateTextBox.Name = "TemplateTextBox"
        Me.TemplateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TemplateTextBox.TabIndex = 27
        '
        'MyDxTextBox
        '
        Me.MyDxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDXBindingSource, "MyDx", True))
        Me.MyDxTextBox.Location = New System.Drawing.Point(185, 159)
        Me.MyDxTextBox.MaxLength = 10
        Me.MyDxTextBox.Name = "MyDxTextBox"
        Me.MyDxTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MyDxTextBox.TabIndex = 29
        '
        'ApprovedCheckBox
        '
        Me.ApprovedCheckBox.Checked = True
        Me.ApprovedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ApprovedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MMDXBindingSource, "Approved", True))
        Me.ApprovedCheckBox.Location = New System.Drawing.Point(185, 183)
        Me.ApprovedCheckBox.Name = "ApprovedCheckBox"
        Me.ApprovedCheckBox.Size = New System.Drawing.Size(23, 24)
        Me.ApprovedCheckBox.TabIndex = 31
        '
        'ScreenLocationTextBox
        '
        Me.ScreenLocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDXBindingSource, "ScreenLocation", True))
        Me.ScreenLocationTextBox.Location = New System.Drawing.Point(185, 211)
        Me.ScreenLocationTextBox.Name = "ScreenLocationTextBox"
        Me.ScreenLocationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ScreenLocationTextBox.TabIndex = 33
        '
        'TimeStampDateTimePicker
        '
        Me.TimeStampDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MMDXBindingSource, "TimeStamp", True))
        Me.TimeStampDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TimeStampDateTimePicker.Location = New System.Drawing.Point(185, 235)
        Me.TimeStampDateTimePicker.Name = "TimeStampDateTimePicker"
        Me.TimeStampDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.TimeStampDateTimePicker.TabIndex = 35
        '
        'MMDXBindingNavigator
        '
        Me.MMDXBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMDXBindingNavigator.BindingSource = Me.MMDXBindingSource
        Me.MMDXBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMDXBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMDXBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel1, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel4, Me.MMDXBindingNavigatorSaveItem, Me.ToolStripLabel5, Me.ToolStripLabel2, Me.txtFind, Me.ToolStripLabel3, Me.cmbFilter})
        Me.MMDXBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMDXBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMDXBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMDXBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMDXBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMDXBindingNavigator.Name = "MMDXBindingNavigator"
        Me.MMDXBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMDXBindingNavigator.Size = New System.Drawing.Size(814, 25)
        Me.MMDXBindingNavigator.TabIndex = 1
        Me.MMDXBindingNavigator.Text = "BindingNavigator1"
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
        'MMDXBindingNavigatorSaveItem
        '
        Me.MMDXBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMDXBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMDXBindingNavigatorSaveItem.Name = "MMDXBindingNavigatorSaveItem"
        Me.MMDXBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.MMDXBindingNavigatorSaveItem.Text = "Save Data"
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
        Me.cmbFilter.Items.AddRange(New Object() {"Description", "Code1"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 25)
        '
        'MMDXTableAdapter
        '
        Me.MMDXTableAdapter.ClearBeforeFill = True
        '
        'Diagonosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 380)
        Me.Controls.Add(Me.MMDXBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(205, 85)
        Me.Name = "Diagonosis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diagnosis"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.MMDXDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.MMDXBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMDXBindingNavigator.ResumeLayout(False)
        Me.MMDXBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMDXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDXTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMDXTableAdapter
    Friend WithEvents MMDXBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMDXBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MMDXDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Code1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Code2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Code3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TemplateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MyDxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApprovedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ScreenLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimeStampDateTimePicker As System.Windows.Forms.DateTimePicker
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
      Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
      Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
End Class
