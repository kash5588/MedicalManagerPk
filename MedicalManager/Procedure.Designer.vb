<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Procedure
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
        Dim CodeLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim ScreenLocationLabel As System.Windows.Forms.Label
        Dim TimeToDoProcedureLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim DefaultPlaceServiceLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim TimeStampLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Procedure))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgProcedure = New System.Windows.Forms.DataGridView
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ScreenLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeToDoProcedureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DefaultPlaceServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeStampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMCHProcedureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.CodeTextBox = New System.Windows.Forms.TextBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.TypeTextBox = New System.Windows.Forms.TextBox
        Me.ScreenLocationTextBox = New System.Windows.Forms.TextBox
        Me.TimeToDoProcedureTextBox = New System.Windows.Forms.TextBox
        Me.PriceTextBox = New System.Windows.Forms.TextBox
        Me.DefaultPlaceServiceTextBox = New System.Windows.Forms.TextBox
        Me.UserIDTextBox = New System.Windows.Forms.TextBox
        Me.TimeStampDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.MMDataDataSet = New MedicalManager.MMDataDataSet
        Me.MMCHProcedureBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MMCHProcedureBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.MMCHProcedureTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHProcedureTableAdapter
        CodeLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        TypeLabel = New System.Windows.Forms.Label
        ScreenLocationLabel = New System.Windows.Forms.Label
        TimeToDoProcedureLabel = New System.Windows.Forms.Label
        PriceLabel = New System.Windows.Forms.Label
        DefaultPlaceServiceLabel = New System.Windows.Forms.Label
        UserIDLabel = New System.Windows.Forms.Label
        TimeStampLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgProcedure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHProcedureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHProcedureBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMCHProcedureBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(94, 87)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(35, 13)
        CodeLabel.TabIndex = 0
        CodeLabel.Text = "Code:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(66, 113)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 2
        DescriptionLabel.Text = "Description:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(95, 139)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 4
        TypeLabel.Text = "Type:"
        '
        'ScreenLocationLabel
        '
        ScreenLocationLabel.AutoSize = True
        ScreenLocationLabel.Location = New System.Drawing.Point(41, 165)
        ScreenLocationLabel.Name = "ScreenLocationLabel"
        ScreenLocationLabel.Size = New System.Drawing.Size(88, 13)
        ScreenLocationLabel.TabIndex = 6
        ScreenLocationLabel.Text = "Screen Location:"
        '
        'TimeToDoProcedureLabel
        '
        TimeToDoProcedureLabel.AutoSize = True
        TimeToDoProcedureLabel.Location = New System.Drawing.Point(11, 191)
        TimeToDoProcedureLabel.Name = "TimeToDoProcedureLabel"
        TimeToDoProcedureLabel.Size = New System.Drawing.Size(118, 13)
        TimeToDoProcedureLabel.TabIndex = 8
        TimeToDoProcedureLabel.Text = "Time To Do Procedure:"
        AddHandler TimeToDoProcedureLabel.Click, AddressOf Me.TimeToDoProcedureLabel_Click
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(443, 87)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 10
        PriceLabel.Text = "Price:"
        '
        'DefaultPlaceServiceLabel
        '
        DefaultPlaceServiceLabel.AutoSize = True
        DefaultPlaceServiceLabel.Location = New System.Drawing.Point(364, 113)
        DefaultPlaceServiceLabel.Name = "DefaultPlaceServiceLabel"
        DefaultPlaceServiceLabel.Size = New System.Drawing.Size(113, 13)
        DefaultPlaceServiceLabel.TabIndex = 12
        DefaultPlaceServiceLabel.Text = "Default Place Service:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(431, 139)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(46, 13)
        UserIDLabel.TabIndex = 14
        UserIDLabel.Text = "User ID:"
        '
        'TimeStampLabel
        '
        TimeStampLabel.AutoSize = True
        TimeStampLabel.Location = New System.Drawing.Point(411, 166)
        TimeStampLabel.Name = "TimeStampLabel"
        TimeStampLabel.Size = New System.Drawing.Size(66, 13)
        TimeStampLabel.TabIndex = 16
        TimeStampLabel.Text = "Time Stamp:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(937, 367)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgProcedure)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(929, 341)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgProcedure
        '
        Me.dgProcedure.AutoGenerateColumns = False
        Me.dgProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProcedure.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.ScreenLocationDataGridViewTextBoxColumn, Me.TimeToDoProcedureDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.DefaultPlaceServiceDataGridViewTextBoxColumn, Me.TimeStampDataGridViewTextBoxColumn})
        Me.dgProcedure.DataSource = Me.MMCHProcedureBindingSource
        Me.dgProcedure.Location = New System.Drawing.Point(9, 6)
        Me.dgProcedure.Name = "dgProcedure"
        Me.dgProcedure.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgProcedure.Size = New System.Drawing.Size(917, 332)
        Me.dgProcedure.TabIndex = 0
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.Width = 75
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 300
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'ScreenLocationDataGridViewTextBoxColumn
        '
        Me.ScreenLocationDataGridViewTextBoxColumn.DataPropertyName = "ScreenLocation"
        Me.ScreenLocationDataGridViewTextBoxColumn.HeaderText = "Screen Location"
        Me.ScreenLocationDataGridViewTextBoxColumn.Name = "ScreenLocationDataGridViewTextBoxColumn"
        '
        'TimeToDoProcedureDataGridViewTextBoxColumn
        '
        Me.TimeToDoProcedureDataGridViewTextBoxColumn.DataPropertyName = "TimeToDoProcedure"
        Me.TimeToDoProcedureDataGridViewTextBoxColumn.HeaderText = "Time To Do Procedure"
        Me.TimeToDoProcedureDataGridViewTextBoxColumn.Name = "TimeToDoProcedureDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'DefaultPlaceServiceDataGridViewTextBoxColumn
        '
        Me.DefaultPlaceServiceDataGridViewTextBoxColumn.DataPropertyName = "DefaultPlaceService"
        Me.DefaultPlaceServiceDataGridViewTextBoxColumn.HeaderText = "Default Place Service"
        Me.DefaultPlaceServiceDataGridViewTextBoxColumn.Name = "DefaultPlaceServiceDataGridViewTextBoxColumn"
        '
        'TimeStampDataGridViewTextBoxColumn
        '
        Me.TimeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp"
        Me.TimeStampDataGridViewTextBoxColumn.HeaderText = "Time Stamp"
        Me.TimeStampDataGridViewTextBoxColumn.Name = "TimeStampDataGridViewTextBoxColumn"
        '
        'MMCHProcedureBindingSource
        '
        Me.MMCHProcedureBindingSource.DataMember = "MMCHProcedure"
        Me.MMCHProcedureBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(CodeLabel)
        Me.TabPage2.Controls.Add(Me.CodeTextBox)
        Me.TabPage2.Controls.Add(DescriptionLabel)
        Me.TabPage2.Controls.Add(Me.DescriptionTextBox)
        Me.TabPage2.Controls.Add(TypeLabel)
        Me.TabPage2.Controls.Add(Me.TypeTextBox)
        Me.TabPage2.Controls.Add(ScreenLocationLabel)
        Me.TabPage2.Controls.Add(Me.ScreenLocationTextBox)
        Me.TabPage2.Controls.Add(TimeToDoProcedureLabel)
        Me.TabPage2.Controls.Add(Me.TimeToDoProcedureTextBox)
        Me.TabPage2.Controls.Add(PriceLabel)
        Me.TabPage2.Controls.Add(Me.PriceTextBox)
        Me.TabPage2.Controls.Add(DefaultPlaceServiceLabel)
        Me.TabPage2.Controls.Add(Me.DefaultPlaceServiceTextBox)
        Me.TabPage2.Controls.Add(UserIDLabel)
        Me.TabPage2.Controls.Add(Me.UserIDTextBox)
        Me.TabPage2.Controls.Add(TimeStampLabel)
        Me.TabPage2.Controls.Add(Me.TimeStampDateTimePicker)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(914, 327)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMCHProcedureBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(135, 84)
        Me.CodeTextBox.MaxLength = 10
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(94, 20)
        Me.CodeTextBox.TabIndex = 1
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMCHProcedureBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(135, 110)
        Me.DescriptionTextBox.MaxLength = 40
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescriptionTextBox.TabIndex = 3
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMCHProcedureBindingSource, "Type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(135, 136)
        Me.TypeTextBox.MaxLength = 1
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(94, 20)
        Me.TypeTextBox.TabIndex = 5
        '
        'ScreenLocationTextBox
        '
        Me.ScreenLocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMCHProcedureBindingSource, "ScreenLocation", True))
        Me.ScreenLocationTextBox.Location = New System.Drawing.Point(135, 162)
        Me.ScreenLocationTextBox.Name = "ScreenLocationTextBox"
        Me.ScreenLocationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ScreenLocationTextBox.TabIndex = 7
        '
        'TimeToDoProcedureTextBox
        '
        Me.TimeToDoProcedureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMCHProcedureBindingSource, "TimeToDoProcedure", True))
        Me.TimeToDoProcedureTextBox.Location = New System.Drawing.Point(135, 188)
        Me.TimeToDoProcedureTextBox.Name = "TimeToDoProcedureTextBox"
        Me.TimeToDoProcedureTextBox.Size = New System.Drawing.Size(94, 20)
        Me.TimeToDoProcedureTextBox.TabIndex = 9
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMCHProcedureBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(483, 84)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(175, 20)
        Me.PriceTextBox.TabIndex = 11
        '
        'DefaultPlaceServiceTextBox
        '
        Me.DefaultPlaceServiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMCHProcedureBindingSource, "DefaultPlaceService", True))
        Me.DefaultPlaceServiceTextBox.Location = New System.Drawing.Point(483, 110)
        Me.DefaultPlaceServiceTextBox.MaxLength = 2
        Me.DefaultPlaceServiceTextBox.Name = "DefaultPlaceServiceTextBox"
        Me.DefaultPlaceServiceTextBox.Size = New System.Drawing.Size(175, 20)
        Me.DefaultPlaceServiceTextBox.TabIndex = 13
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMCHProcedureBindingSource, "MyProcedures", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(483, 136)
        Me.UserIDTextBox.MaxLength = 50
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(175, 20)
        Me.UserIDTextBox.TabIndex = 15
        '
        'TimeStampDateTimePicker
        '
        Me.TimeStampDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MMCHProcedureBindingSource, "TimeStamp", True))
        Me.TimeStampDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TimeStampDateTimePicker.Location = New System.Drawing.Point(483, 162)
        Me.TimeStampDateTimePicker.Name = "TimeStampDateTimePicker"
        Me.TimeStampDateTimePicker.Size = New System.Drawing.Size(175, 20)
        Me.TimeStampDateTimePicker.TabIndex = 17
        '
        'MMDataDataSet
        '
        Me.MMDataDataSet.DataSetName = "MMDataDataSet"
        Me.MMDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMCHProcedureBindingNavigator
        '
        Me.MMCHProcedureBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMCHProcedureBindingNavigator.BindingSource = Me.MMCHProcedureBindingSource
        Me.MMCHProcedureBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMCHProcedureBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMCHProcedureBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MMCHProcedureBindingNavigatorSaveItem, Me.ToolStripLabel2, Me.txtFind, Me.ToolStripLabel3, Me.cmbFilter})
        Me.MMCHProcedureBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMCHProcedureBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMCHProcedureBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMCHProcedureBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMCHProcedureBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMCHProcedureBindingNavigator.Name = "MMCHProcedureBindingNavigator"
        Me.MMCHProcedureBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMCHProcedureBindingNavigator.Size = New System.Drawing.Size(939, 25)
        Me.MMCHProcedureBindingNavigator.TabIndex = 1
        Me.MMCHProcedureBindingNavigator.Text = "BindingNavigator1"
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
        'MMCHProcedureBindingNavigatorSaveItem
        '
        Me.MMCHProcedureBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MMCHProcedureBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMCHProcedureBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMCHProcedureBindingNavigatorSaveItem.Name = "MMCHProcedureBindingNavigatorSaveItem"
        Me.MMCHProcedureBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MMCHProcedureBindingNavigatorSaveItem.Text = "Save Data"
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
        'MMCHProcedureTableAdapter
        '
        Me.MMCHProcedureTableAdapter.ClearBeforeFill = True
        '
        'Procedure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 393)
        Me.Controls.Add(Me.MMCHProcedureBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(205, 85)
        Me.Name = "Procedure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procedure"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgProcedure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHProcedureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.MMDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHProcedureBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMCHProcedureBindingNavigator.ResumeLayout(False)
        Me.MMCHProcedureBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMDataDataSet As MedicalManager.MMDataDataSet
    Friend WithEvents MMCHProcedureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMCHProcedureBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMCHProcedureBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgProcedure As System.Windows.Forms.DataGridView
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScreenLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimeToDoProcedureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DefaultPlaceServiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimeStampDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMCHProcedureTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMCHProcedureTableAdapter
      Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
      Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
      Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
      Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
      Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
      Friend WithEvents ScreenLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
      Friend WithEvents TimeToDoProcedureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
      Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
      Friend WithEvents DefaultPlaceServiceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
      Friend WithEvents TimeStampDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
