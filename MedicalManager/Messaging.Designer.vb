<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Messaging
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim ChartNumberLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim MessageFromLabel As System.Windows.Forms.Label
        Dim MessageToLabel As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim SignatureLabel As System.Windows.Forms.Label
        Dim SignedByLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Messaging))
        Me.MessagingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.MessagingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
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
        Me.MessagingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.FillByDate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.GreaterThanDate = New System.Windows.Forms.ToolStripButton
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.MessageFromComboBox = New System.Windows.Forms.ComboBox
        Me.MessageToComboBox = New System.Windows.Forms.ComboBox
        Me.SubjectTextBox = New System.Windows.Forms.TextBox
        Me.StatusComboBox = New System.Windows.Forms.ComboBox
        Me.MessagingDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgcStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgcSubject = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.cmdComments = New System.Windows.Forms.Button
        Me.SignatureCheckBox = New System.Windows.Forms.CheckBox
        Me.SignedByTextBox = New System.Windows.Forms.TextBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.MessagingTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MessagingTableAdapter
        Me.MMComboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMComboTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMComboTableAdapter
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.GeneralInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralInfoTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.GeneralInfoTableAdapter
        IdLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        ChartNumberLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        MessageFromLabel = New System.Windows.Forms.Label
        MessageToLabel = New System.Windows.Forms.Label
        SubjectLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        SignatureLabel = New System.Windows.Forms.Label
        SignedByLabel = New System.Windows.Forms.Label
        CType(Me.MessagingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MessagingBindingNavigator.SuspendLayout()
        CType(Me.MessagingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessagingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MMComboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(64, 16)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(50, 42)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'ChartNumberLabel
        '
        ChartNumberLabel.AutoSize = True
        ChartNumberLabel.Location = New System.Drawing.Point(8, 68)
        ChartNumberLabel.Name = "ChartNumberLabel"
        ChartNumberLabel.Size = New System.Drawing.Size(75, 13)
        ChartNumberLabel.TabIndex = 5
        ChartNumberLabel.Text = "Chart Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(45, 94)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 7
        NameLabel.Text = "Name:"
        '
        'MessageFromLabel
        '
        MessageFromLabel.AutoSize = True
        MessageFromLabel.Location = New System.Drawing.Point(338, 16)
        MessageFromLabel.Name = "MessageFromLabel"
        MessageFromLabel.Size = New System.Drawing.Size(33, 13)
        MessageFromLabel.TabIndex = 9
        MessageFromLabel.Text = "From:"
        '
        'MessageToLabel
        '
        MessageToLabel.AutoSize = True
        MessageToLabel.Location = New System.Drawing.Point(348, 41)
        MessageToLabel.Name = "MessageToLabel"
        MessageToLabel.Size = New System.Drawing.Size(23, 13)
        MessageToLabel.TabIndex = 11
        MessageToLabel.Text = "To:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Location = New System.Drawing.Point(325, 63)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(46, 13)
        SubjectLabel.TabIndex = 13
        SubjectLabel.Text = "Subject:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(853, 24)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 15
        StatusLabel.Text = "Status:"
        '
        'SignatureLabel
        '
        SignatureLabel.AutoSize = True
        SignatureLabel.Location = New System.Drawing.Point(838, 44)
        SignatureLabel.Name = "SignatureLabel"
        SignatureLabel.Size = New System.Drawing.Size(55, 13)
        SignatureLabel.TabIndex = 25
        SignatureLabel.Text = "Signature:"
        SignatureLabel.Visible = False
        '
        'SignedByLabel
        '
        SignedByLabel.AutoSize = True
        SignedByLabel.Location = New System.Drawing.Point(835, 64)
        SignedByLabel.Name = "SignedByLabel"
        SignedByLabel.Size = New System.Drawing.Size(58, 13)
        SignedByLabel.TabIndex = 26
        SignedByLabel.Text = "Signed By:"
        SignedByLabel.Visible = False
        '
        'MessagingBindingNavigator
        '
        Me.MessagingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MessagingBindingNavigator.BindingSource = Me.MessagingBindingSource
        Me.MessagingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MessagingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MessagingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel1, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel4, Me.MessagingBindingNavigatorSaveItem, Me.ToolStripLabel5, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.txtFind, Me.ToolStripLabel3, Me.cmbFilter, Me.ToolStripSeparator3, Me.FillByDate, Me.ToolStripSeparator1, Me.GreaterThanDate})
        Me.MessagingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MessagingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MessagingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MessagingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MessagingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MessagingBindingNavigator.Name = "MessagingBindingNavigator"
        Me.MessagingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MessagingBindingNavigator.Size = New System.Drawing.Size(1067, 25)
        Me.MessagingBindingNavigator.TabIndex = 0
        Me.MessagingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'MessagingBindingSource
        '
        Me.MessagingBindingSource.DataMember = "Messaging"
        Me.MessagingBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MessagingBindingNavigatorSaveItem
        '
        Me.MessagingBindingNavigatorSaveItem.Image = CType(resources.GetObject("MessagingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MessagingBindingNavigatorSaveItem.Name = "MessagingBindingNavigatorSaveItem"
        Me.MessagingBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.MessagingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel5.Text = "     "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.cmbFilter.AutoCompleteCustomSource.AddRange(New String() {"Name"})
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.Items.AddRange(New Object() {"MessageTo", "MessageFrom", "ChartNumber", "Date", "Status", "Name"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'FillByDate
        '
        Me.FillByDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByDate.Image = CType(resources.GetObject("FillByDate.Image"), System.Drawing.Image)
        Me.FillByDate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FillByDate.Name = "FillByDate"
        Me.FillByDate.Size = New System.Drawing.Size(64, 22)
        Me.FillByDate.Text = "Fill By Date"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'GreaterThanDate
        '
        Me.GreaterThanDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GreaterThanDate.Image = CType(resources.GetObject("GreaterThanDate.Image"), System.Drawing.Image)
        Me.GreaterThanDate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GreaterThanDate.Name = "GreaterThanDate"
        Me.GreaterThanDate.Size = New System.Drawing.Size(101, 22)
        Me.GreaterThanDate.Text = "Greater Than Date"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MessagingBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(89, 13)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(95, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MessagingBindingSource, "ChartNumber", True))
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(89, 65)
        Me.ChartNumberTextBox.MaxLength = 8
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(95, 20)
        Me.ChartNumberTextBox.TabIndex = 6
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MessagingBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(89, 91)
        Me.NameTextBox.MaxLength = 50
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 8
        '
        'MessageFromComboBox
        '
        Me.MessageFromComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MessagingBindingSource, "MessageFrom", True))
        Me.MessageFromComboBox.FormattingEnabled = True
        Me.MessageFromComboBox.Location = New System.Drawing.Point(377, 13)
        Me.MessageFromComboBox.MaxLength = 40
        Me.MessageFromComboBox.Name = "MessageFromComboBox"
        Me.MessageFromComboBox.Size = New System.Drawing.Size(200, 21)
        Me.MessageFromComboBox.TabIndex = 10
        '
        'MessageToComboBox
        '
        Me.MessageToComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MessagingBindingSource, "MessageTo", True))
        Me.MessageToComboBox.FormattingEnabled = True
        Me.MessageToComboBox.Location = New System.Drawing.Point(377, 37)
        Me.MessageToComboBox.MaxLength = 40
        Me.MessageToComboBox.Name = "MessageToComboBox"
        Me.MessageToComboBox.Size = New System.Drawing.Size(200, 21)
        Me.MessageToComboBox.TabIndex = 12
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MessagingBindingSource, "Subject", True))
        Me.SubjectTextBox.Location = New System.Drawing.Point(377, 63)
        Me.SubjectTextBox.MaxLength = 500
        Me.SubjectTextBox.Multiline = True
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SubjectTextBox.Size = New System.Drawing.Size(419, 63)
        Me.SubjectTextBox.TabIndex = 14
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MessagingBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(899, 19)
        Me.StatusComboBox.MaxLength = 25
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(124, 21)
        Me.StatusComboBox.TabIndex = 16
        '
        'MessagingDataGridView
        '
        Me.MessagingDataGridView.AllowUserToAddRows = False
        Me.MessagingDataGridView.AutoGenerateColumns = False
        Me.MessagingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.dgcStatus, Me.dgcSubject})
        Me.MessagingDataGridView.DataSource = Me.MessagingBindingSource
        Me.MessagingDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagingDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MessagingDataGridView.Name = "MessagingDataGridView"
        Me.MessagingDataGridView.Size = New System.Drawing.Size(1067, 440)
        Me.MessagingDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Chart Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 135
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MessageFrom"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Message From"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 85
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MessageTo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Message To"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 85
        '
        'dgcStatus
        '
        Me.dgcStatus.DataPropertyName = "Status"
        Me.dgcStatus.HeaderText = "Status"
        Me.dgcStatus.Name = "dgcStatus"
        Me.dgcStatus.Width = 150
        '
        'dgcSubject
        '
        Me.dgcSubject.DataPropertyName = "Subject"
        Me.dgcSubject.HeaderText = "Subject"
        Me.dgcSubject.Name = "dgcSubject"
        Me.dgcSubject.Width = 657
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MessagingBindingSource, "Date", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "MM/dd/yyyy"))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(89, 39)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(95, 20)
        Me.MaskedTextBox1.TabIndex = 18
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(205, 63)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(84, 23)
        Me.cmdPatient.TabIndex = 24
        Me.cmdPatient.Text = "Select Patient"
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'cmdComments
        '
        Me.cmdComments.Location = New System.Drawing.Point(596, 36)
        Me.cmdComments.Name = "cmdComments"
        Me.cmdComments.Size = New System.Drawing.Size(200, 23)
        Me.cmdComments.TabIndex = 25
        Me.cmdComments.Text = "List of Comments / Messages"
        Me.cmdComments.UseVisualStyleBackColor = True
        '
        'SignatureCheckBox
        '
        Me.SignatureCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MessagingBindingSource, "Signature", True))
        Me.SignatureCheckBox.Enabled = False
        Me.SignatureCheckBox.Location = New System.Drawing.Point(899, 40)
        Me.SignatureCheckBox.Name = "SignatureCheckBox"
        Me.SignatureCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SignatureCheckBox.TabIndex = 26
        Me.SignatureCheckBox.Visible = False
        '
        'SignedByTextBox
        '
        Me.SignedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MessagingBindingSource, "SignedBy", True))
        Me.SignedByTextBox.Location = New System.Drawing.Point(899, 64)
        Me.SignedByTextBox.MaxLength = 50
        Me.SignedByTextBox.Name = "SignedByTextBox"
        Me.SignedByTextBox.Size = New System.Drawing.Size(124, 20)
        Me.SignedByTextBox.TabIndex = 27
        Me.SignedByTextBox.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MessagingDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1067, 583)
        Me.SplitContainer1.SplitterDistance = 440
        Me.SplitContainer1.TabIndex = 28
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.IdTextBox)
        Me.GroupBox2.Controls.Add(Me.ChartNumberTextBox)
        Me.GroupBox2.Controls.Add(IdLabel)
        Me.GroupBox2.Controls.Add(StatusLabel)
        Me.GroupBox2.Controls.Add(ChartNumberLabel)
        Me.GroupBox2.Controls.Add(SignatureLabel)
        Me.GroupBox2.Controls.Add(Me.cmdComments)
        Me.GroupBox2.Controls.Add(MessageFromLabel)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox2.Controls.Add(Me.MessageFromComboBox)
        Me.GroupBox2.Controls.Add(Me.MessageToComboBox)
        Me.GroupBox2.Controls.Add(Me.SignedByTextBox)
        Me.GroupBox2.Controls.Add(NameLabel)
        Me.GroupBox2.Controls.Add(Me.SubjectTextBox)
        Me.GroupBox2.Controls.Add(SubjectLabel)
        Me.GroupBox2.Controls.Add(Me.NameTextBox)
        Me.GroupBox2.Controls.Add(SignedByLabel)
        Me.GroupBox2.Controls.Add(MessageToLabel)
        Me.GroupBox2.Controls.Add(Me.cmdPatient)
        Me.GroupBox2.Controls.Add(Me.StatusComboBox)
        Me.GroupBox2.Controls.Add(DateLabel)
        Me.GroupBox2.Controls.Add(Me.SignatureCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1047, 134)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(956, 2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker2.TabIndex = 30
        '
        'MessagingTableAdapter
        '
        Me.MessagingTableAdapter.ClearBeforeFill = True
        '
        'MMComboBindingSource
        '
        Me.MMComboBindingSource.DataMember = "MMCombo"
        Me.MMComboBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMComboTableAdapter
        '
        Me.MMComboTableAdapter.ClearBeforeFill = True
        '
        'MMDataDataSet2
        '
        Me.MMDataDataSet2.DataSetName = "MMDataDataSet2"
        Me.MMDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralInfoBindingSource
        '
        Me.GeneralInfoBindingSource.DataMember = "GeneralInfo"
        Me.GeneralInfoBindingSource.DataSource = Me.MMDataDataSet2
        '
        'GeneralInfoTableAdapter
        '
        Me.GeneralInfoTableAdapter.ClearBeforeFill = True
        '
        'Messaging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 608)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MessagingBindingNavigator)
        Me.Location = New System.Drawing.Point(205, 85)
        Me.Name = "Messaging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Messaging"
        CType(Me.MessagingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MessagingBindingNavigator.ResumeLayout(False)
        Me.MessagingBindingNavigator.PerformLayout()
        CType(Me.MessagingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessagingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MMComboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MessagingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MessagingTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MessagingTableAdapter
    Friend WithEvents MessagingBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MessagingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MessageFromComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MessageToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MessagingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents cmdComments As System.Windows.Forms.Button
    Friend WithEvents SignatureCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SignedByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MMComboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMComboTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMComboTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FillByDate As System.Windows.Forms.ToolStripButton
    Friend WithEvents GreaterThanDate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents GeneralInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralInfoTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.GeneralInfoTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgcSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
End Class
