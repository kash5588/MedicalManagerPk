<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HealthHistoryQuestions
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
        Dim CodeLabel As System.Windows.Forms.Label
        Dim HistoryTypeLabel As System.Windows.Forms.Label
        Dim HistoryQuestionLabel As System.Windows.Forms.Label
        Dim HistoryDiscriptiveAnswerLabel As System.Windows.Forms.Label
        Dim ScreenLocationLabel As System.Windows.Forms.Label
        Dim UserField1Label As System.Windows.Forms.Label
        Dim UserField2Label As System.Windows.Forms.Label
        Dim AnswerTypeLabel1 As System.Windows.Forms.Label
        Dim HistoryYesAnswerLabel As System.Windows.Forms.Label
        Dim HistoryNoAnswerLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HealthHistoryQuestions))
        Me.HealthHistoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.HealthHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
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
        Me.HealthHistoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.CodeTextBox = New System.Windows.Forms.TextBox
        Me.HistoryTypeTextBox = New System.Windows.Forms.TextBox
        Me.HistoryQuestionTextBox = New System.Windows.Forms.TextBox
        Me.HistoryDiscriptiveAnswerTextBox = New System.Windows.Forms.TextBox
        Me.ScreenLocationTextBox = New System.Windows.Forms.TextBox
        Me.UserField1TextBox = New System.Windows.Forms.TextBox
        Me.UserField2TextBox = New System.Windows.Forms.TextBox
        Me.HealthHistoryDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HistoryYesAnswer = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.HistoryNoAnswer = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnswerType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnswerTypeComboBox = New System.Windows.Forms.ComboBox
        Me.HistoryYesAnswerCheckBox = New System.Windows.Forms.CheckBox
        Me.HistoryNoAnswerCheckBox = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.HealthHistoryTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.HealthHistoryTableAdapter
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        IDLabel = New System.Windows.Forms.Label
        CodeLabel = New System.Windows.Forms.Label
        HistoryTypeLabel = New System.Windows.Forms.Label
        HistoryQuestionLabel = New System.Windows.Forms.Label
        HistoryDiscriptiveAnswerLabel = New System.Windows.Forms.Label
        ScreenLocationLabel = New System.Windows.Forms.Label
        UserField1Label = New System.Windows.Forms.Label
        UserField2Label = New System.Windows.Forms.Label
        AnswerTypeLabel1 = New System.Windows.Forms.Label
        HistoryYesAnswerLabel = New System.Windows.Forms.Label
        HistoryNoAnswerLabel = New System.Windows.Forms.Label
        CType(Me.HealthHistoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HealthHistoryBindingNavigator.SuspendLayout()
        CType(Me.HealthHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HealthHistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(122, 44)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(108, 70)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(35, 13)
        CodeLabel.TabIndex = 3
        CodeLabel.Text = "Code:"
        '
        'HistoryTypeLabel
        '
        HistoryTypeLabel.AutoSize = True
        HistoryTypeLabel.Location = New System.Drawing.Point(74, 96)
        HistoryTypeLabel.Name = "HistoryTypeLabel"
        HistoryTypeLabel.Size = New System.Drawing.Size(69, 13)
        HistoryTypeLabel.TabIndex = 5
        HistoryTypeLabel.Text = "History Type:"
        '
        'HistoryQuestionLabel
        '
        HistoryQuestionLabel.AutoSize = True
        HistoryQuestionLabel.Location = New System.Drawing.Point(56, 122)
        HistoryQuestionLabel.Name = "HistoryQuestionLabel"
        HistoryQuestionLabel.Size = New System.Drawing.Size(87, 13)
        HistoryQuestionLabel.TabIndex = 7
        HistoryQuestionLabel.Text = "History Question:"
        '
        'HistoryDiscriptiveAnswerLabel
        '
        HistoryDiscriptiveAnswerLabel.AutoSize = True
        HistoryDiscriptiveAnswerLabel.Location = New System.Drawing.Point(7, 192)
        HistoryDiscriptiveAnswerLabel.Name = "HistoryDiscriptiveAnswerLabel"
        HistoryDiscriptiveAnswerLabel.Size = New System.Drawing.Size(136, 13)
        HistoryDiscriptiveAnswerLabel.TabIndex = 11
        HistoryDiscriptiveAnswerLabel.Text = "History Descriptive Answer:"
        '
        'ScreenLocationLabel
        '
        ScreenLocationLabel.AutoSize = True
        ScreenLocationLabel.Location = New System.Drawing.Point(55, 218)
        ScreenLocationLabel.Name = "ScreenLocationLabel"
        ScreenLocationLabel.Size = New System.Drawing.Size(88, 13)
        ScreenLocationLabel.TabIndex = 13
        ScreenLocationLabel.Text = "Screen Location:"
        '
        'UserField1Label
        '
        UserField1Label.AutoSize = True
        UserField1Label.Location = New System.Drawing.Point(80, 270)
        UserField1Label.Name = "UserField1Label"
        UserField1Label.Size = New System.Drawing.Size(63, 13)
        UserField1Label.TabIndex = 17
        UserField1Label.Text = "User Field1:"
        '
        'UserField2Label
        '
        UserField2Label.AutoSize = True
        UserField2Label.Location = New System.Drawing.Point(80, 296)
        UserField2Label.Name = "UserField2Label"
        UserField2Label.Size = New System.Drawing.Size(63, 13)
        UserField2Label.TabIndex = 19
        UserField2Label.Text = "User Field2:"
        '
        'AnswerTypeLabel1
        '
        AnswerTypeLabel1.AutoSize = True
        AnswerTypeLabel1.Location = New System.Drawing.Point(71, 244)
        AnswerTypeLabel1.Name = "AnswerTypeLabel1"
        AnswerTypeLabel1.Size = New System.Drawing.Size(72, 13)
        AnswerTypeLabel1.TabIndex = 21
        AnswerTypeLabel1.Text = "Answer Type:"
        '
        'HistoryYesAnswerLabel
        '
        HistoryYesAnswerLabel.AutoSize = True
        HistoryYesAnswerLabel.Location = New System.Drawing.Point(42, 148)
        HistoryYesAnswerLabel.Name = "HistoryYesAnswerLabel"
        HistoryYesAnswerLabel.Size = New System.Drawing.Size(101, 13)
        HistoryYesAnswerLabel.TabIndex = 22
        HistoryYesAnswerLabel.Text = "History Yes Answer:"
        '
        'HistoryNoAnswerLabel
        '
        HistoryNoAnswerLabel.AutoSize = True
        HistoryNoAnswerLabel.Location = New System.Drawing.Point(46, 170)
        HistoryNoAnswerLabel.Name = "HistoryNoAnswerLabel"
        HistoryNoAnswerLabel.Size = New System.Drawing.Size(97, 13)
        HistoryNoAnswerLabel.TabIndex = 23
        HistoryNoAnswerLabel.Text = "History No Answer:"
        '
        'HealthHistoryBindingNavigator
        '
        Me.HealthHistoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HealthHistoryBindingNavigator.BindingSource = Me.HealthHistoryBindingSource
        Me.HealthHistoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HealthHistoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HealthHistoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel1, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel3, Me.HealthHistoryBindingNavigatorSaveItem, Me.ToolStripLabel4, Me.ToolStripLabel2, Me.txtFind, Me.cmbFilter})
        Me.HealthHistoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HealthHistoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HealthHistoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HealthHistoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HealthHistoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HealthHistoryBindingNavigator.Name = "HealthHistoryBindingNavigator"
        Me.HealthHistoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HealthHistoryBindingNavigator.Size = New System.Drawing.Size(1241, 25)
        Me.HealthHistoryBindingNavigator.TabIndex = 0
        Me.HealthHistoryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'HealthHistoryBindingSource
        '
        Me.HealthHistoryBindingSource.DataMember = "HealthHistory"
        Me.HealthHistoryBindingSource.DataSource = Me.MMDataDataSet2
        '
        'MMDataDataSet2
        '
        Me.MMDataDataSet2.DataSetName = "MMDataDataSet2"
        Me.MMDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'HealthHistoryBindingNavigatorSaveItem
        '
        Me.HealthHistoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("HealthHistoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HealthHistoryBindingNavigatorSaveItem.Name = "HealthHistoryBindingNavigatorSaveItem"
        Me.HealthHistoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.HealthHistoryBindingNavigatorSaveItem.Text = "Save Data"
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
        'cmbFilter
        '
        Me.cmbFilter.AutoCompleteCustomSource.AddRange(New String() {"HistoryQuestion", "HistoryType"})
        Me.cmbFilter.Items.AddRange(New Object() {"HistoryQuestion", "HistoryType"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 25)
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HealthHistoryBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(149, 41)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(150, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HealthHistoryBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(149, 67)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(150, 20)
        Me.CodeTextBox.TabIndex = 4
        '
        'HistoryTypeTextBox
        '
        Me.HistoryTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HealthHistoryBindingSource, "HistoryType", True))
        Me.HistoryTypeTextBox.Location = New System.Drawing.Point(149, 93)
        Me.HistoryTypeTextBox.Name = "HistoryTypeTextBox"
        Me.HistoryTypeTextBox.Size = New System.Drawing.Size(150, 20)
        Me.HistoryTypeTextBox.TabIndex = 6
        '
        'HistoryQuestionTextBox
        '
        Me.HistoryQuestionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HealthHistoryBindingSource, "HistoryQuestion", True))
        Me.HistoryQuestionTextBox.Location = New System.Drawing.Point(149, 119)
        Me.HistoryQuestionTextBox.Name = "HistoryQuestionTextBox"
        Me.HistoryQuestionTextBox.Size = New System.Drawing.Size(150, 20)
        Me.HistoryQuestionTextBox.TabIndex = 8
        '
        'HistoryDiscriptiveAnswerTextBox
        '
        Me.HistoryDiscriptiveAnswerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HealthHistoryBindingSource, "HistoryDiscriptiveAnswer", True))
        Me.HistoryDiscriptiveAnswerTextBox.Location = New System.Drawing.Point(149, 189)
        Me.HistoryDiscriptiveAnswerTextBox.Name = "HistoryDiscriptiveAnswerTextBox"
        Me.HistoryDiscriptiveAnswerTextBox.Size = New System.Drawing.Size(150, 20)
        Me.HistoryDiscriptiveAnswerTextBox.TabIndex = 12
        '
        'ScreenLocationTextBox
        '
        Me.ScreenLocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HealthHistoryBindingSource, "ScreenLocation", True))
        Me.ScreenLocationTextBox.Location = New System.Drawing.Point(149, 215)
        Me.ScreenLocationTextBox.Name = "ScreenLocationTextBox"
        Me.ScreenLocationTextBox.Size = New System.Drawing.Size(150, 20)
        Me.ScreenLocationTextBox.TabIndex = 14
        '
        'UserField1TextBox
        '
        Me.UserField1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HealthHistoryBindingSource, "UserField1", True))
        Me.UserField1TextBox.Location = New System.Drawing.Point(149, 267)
        Me.UserField1TextBox.Name = "UserField1TextBox"
        Me.UserField1TextBox.Size = New System.Drawing.Size(150, 20)
        Me.UserField1TextBox.TabIndex = 18
        '
        'UserField2TextBox
        '
        Me.UserField2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HealthHistoryBindingSource, "UserField2", True))
        Me.UserField2TextBox.Location = New System.Drawing.Point(149, 293)
        Me.UserField2TextBox.Name = "UserField2TextBox"
        Me.UserField2TextBox.Size = New System.Drawing.Size(150, 20)
        Me.UserField2TextBox.TabIndex = 20
        '
        'HealthHistoryDataGridView
        '
        Me.HealthHistoryDataGridView.AllowUserToAddRows = False
        Me.HealthHistoryDataGridView.AutoGenerateColumns = False
        Me.HealthHistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.HistoryYesAnswer, Me.HistoryNoAnswer, Me.DataGridViewTextBoxColumn5, Me.AnswerType, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
        Me.HealthHistoryDataGridView.DataSource = Me.HealthHistoryBindingSource
        Me.HealthHistoryDataGridView.Location = New System.Drawing.Point(305, 26)
        Me.HealthHistoryDataGridView.Name = "HealthHistoryDataGridView"
        Me.HealthHistoryDataGridView.Size = New System.Drawing.Size(924, 712)
        Me.HealthHistoryDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HistoryType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "HistoryType"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "HistoryQuestion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "HistoryQuestion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'HistoryYesAnswer
        '
        Me.HistoryYesAnswer.DataPropertyName = "HistoryYesAnswer"
        Me.HistoryYesAnswer.HeaderText = "HistoryYesAnswer"
        Me.HistoryYesAnswer.Name = "HistoryYesAnswer"
        '
        'HistoryNoAnswer
        '
        Me.HistoryNoAnswer.DataPropertyName = "HistoryNoAnswer"
        Me.HistoryNoAnswer.HeaderText = "HistoryNoAnswer"
        Me.HistoryNoAnswer.Name = "HistoryNoAnswer"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "HistoryDiscriptiveAnswer"
        Me.DataGridViewTextBoxColumn5.HeaderText = "HistoryDiscriptiveAnswer"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'AnswerType
        '
        Me.AnswerType.DataPropertyName = "AnswerType"
        Me.AnswerType.HeaderText = "AnswerType"
        Me.AnswerType.Name = "AnswerType"
        Me.AnswerType.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ScreenLocation"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ScreenLocation"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UserField1"
        Me.DataGridViewTextBoxColumn8.HeaderText = "UserField1"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UserField2"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UserField2"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'AnswerTypeComboBox
        '
        Me.AnswerTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HealthHistoryBindingSource, "AnswerType", True))
        Me.AnswerTypeComboBox.FormattingEnabled = True
        Me.AnswerTypeComboBox.Items.AddRange(New Object() {"Yes", "YesNo", "No", "Descriptive"})
        Me.AnswerTypeComboBox.Location = New System.Drawing.Point(149, 241)
        Me.AnswerTypeComboBox.Name = "AnswerTypeComboBox"
        Me.AnswerTypeComboBox.Size = New System.Drawing.Size(150, 21)
        Me.AnswerTypeComboBox.TabIndex = 22
        '
        'HistoryYesAnswerCheckBox
        '
        Me.HistoryYesAnswerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HealthHistoryBindingSource, "HistoryYesAnswer", True))
        Me.HistoryYesAnswerCheckBox.Location = New System.Drawing.Point(149, 143)
        Me.HistoryYesAnswerCheckBox.Name = "HistoryYesAnswerCheckBox"
        Me.HistoryYesAnswerCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.HistoryYesAnswerCheckBox.TabIndex = 23
        '
        'HistoryNoAnswerCheckBox
        '
        Me.HistoryNoAnswerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.HealthHistoryBindingSource, "HistoryNoAnswer", True))
        Me.HistoryNoAnswerCheckBox.Location = New System.Drawing.Point(149, 165)
        Me.HistoryNoAnswerCheckBox.Name = "HistoryNoAnswerCheckBox"
        Me.HistoryNoAnswerCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.HistoryNoAnswerCheckBox.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HealthHistoryTableAdapter
        '
        Me.HealthHistoryTableAdapter.ClearBeforeFill = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel1.Text = "     "
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel3.Text = "     "
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel4.Text = "     "
        '
        'HealthHistoryQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 741)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(HistoryNoAnswerLabel)
        Me.Controls.Add(Me.HistoryNoAnswerCheckBox)
        Me.Controls.Add(HistoryYesAnswerLabel)
        Me.Controls.Add(Me.HistoryYesAnswerCheckBox)
        Me.Controls.Add(AnswerTypeLabel1)
        Me.Controls.Add(Me.AnswerTypeComboBox)
        Me.Controls.Add(Me.HealthHistoryDataGridView)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(CodeLabel)
        Me.Controls.Add(Me.CodeTextBox)
        Me.Controls.Add(HistoryTypeLabel)
        Me.Controls.Add(Me.HistoryTypeTextBox)
        Me.Controls.Add(HistoryQuestionLabel)
        Me.Controls.Add(Me.HistoryQuestionTextBox)
        Me.Controls.Add(HistoryDiscriptiveAnswerLabel)
        Me.Controls.Add(Me.HistoryDiscriptiveAnswerTextBox)
        Me.Controls.Add(ScreenLocationLabel)
        Me.Controls.Add(Me.ScreenLocationTextBox)
        Me.Controls.Add(UserField1Label)
        Me.Controls.Add(Me.UserField1TextBox)
        Me.Controls.Add(UserField2Label)
        Me.Controls.Add(Me.UserField2TextBox)
        Me.Controls.Add(Me.HealthHistoryBindingNavigator)
        Me.Name = "HealthHistoryQuestions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HealthHistoryQuestions"
        CType(Me.HealthHistoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HealthHistoryBindingNavigator.ResumeLayout(False)
        Me.HealthHistoryBindingNavigator.PerformLayout()
        CType(Me.HealthHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HealthHistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents HealthHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HealthHistoryTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.HealthHistoryTableAdapter
    Friend WithEvents HealthHistoryBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents HealthHistoryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HistoryTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HistoryQuestionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HistoryDiscriptiveAnswerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ScreenLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserField1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserField2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents HealthHistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AnswerTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HistoryYesAnswerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HistoryNoAnswerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HistoryYesAnswer As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HistoryNoAnswer As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnswerType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
End Class
