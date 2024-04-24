<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MailBox
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
        Dim MailIDLabel As System.Windows.Forms.Label
        Dim ChartNumberLabel As System.Windows.Forms.Label
        Dim RecordIDLabel As System.Windows.Forms.Label
        Dim DateIdentifierLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim PatientPhoneLabel As System.Windows.Forms.Label
        Dim TaskTypeLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MailBox))
        Dim AssignedByLabel As System.Windows.Forms.Label
        Dim AssignedToLabel As System.Windows.Forms.Label
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.MailBoxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MailBoxTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MailBoxTableAdapter
        Me.MailBoxBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MailBoxBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MailBoxDataGridView = New System.Windows.Forms.DataGridView
        Me.MailIDTextBox = New System.Windows.Forms.TextBox
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox
        Me.RecordIDTextBox = New System.Windows.Forms.TextBox
        Me.DateIdentifierTextBox = New System.Windows.Forms.TextBox
        Me.LocationTextBox = New System.Windows.Forms.TextBox
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.PatientPhoneTextBox = New System.Windows.Forms.TextBox
        Me.TaskTypeTextBox = New System.Windows.Forms.TextBox
        Me.StatusTextBox = New System.Windows.Forms.TextBox
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.CommentsTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnGetPatient = New System.Windows.Forms.Button
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AssignedByComboBox = New System.Windows.Forms.ComboBox
        Me.AssignedToComboBox = New System.Windows.Forms.ComboBox
        MailIDLabel = New System.Windows.Forms.Label
        ChartNumberLabel = New System.Windows.Forms.Label
        RecordIDLabel = New System.Windows.Forms.Label
        DateIdentifierLabel = New System.Windows.Forms.Label
        LocationLabel = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        FirstNameLabel = New System.Windows.Forms.Label
        PatientPhoneLabel = New System.Windows.Forms.Label
        TaskTypeLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        CommentsLabel = New System.Windows.Forms.Label
        AssignedByLabel = New System.Windows.Forms.Label
        AssignedToLabel = New System.Windows.Forms.Label
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MailBoxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MailBoxBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MailBoxBindingNavigator.SuspendLayout()
        CType(Me.MailBoxDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MailIDLabel
        '
        MailIDLabel.AutoSize = True
        MailIDLabel.Location = New System.Drawing.Point(73, 24)
        MailIDLabel.Name = "MailIDLabel"
        MailIDLabel.Size = New System.Drawing.Size(43, 13)
        MailIDLabel.TabIndex = 2
        MailIDLabel.Text = "Mail ID:"
        '
        'ChartNumberLabel
        '
        ChartNumberLabel.AutoSize = True
        ChartNumberLabel.Location = New System.Drawing.Point(41, 199)
        ChartNumberLabel.Name = "ChartNumberLabel"
        ChartNumberLabel.Size = New System.Drawing.Size(75, 13)
        ChartNumberLabel.TabIndex = 4
        ChartNumberLabel.Text = "Chart Number:"
        '
        'RecordIDLabel
        '
        RecordIDLabel.AutoSize = True
        RecordIDLabel.Location = New System.Drawing.Point(57, 49)
        RecordIDLabel.Name = "RecordIDLabel"
        RecordIDLabel.Size = New System.Drawing.Size(59, 13)
        RecordIDLabel.TabIndex = 6
        RecordIDLabel.Text = "Record ID:"
        '
        'DateIdentifierLabel
        '
        DateIdentifierLabel.AutoSize = True
        DateIdentifierLabel.Location = New System.Drawing.Point(40, 324)
        DateIdentifierLabel.Name = "DateIdentifierLabel"
        DateIdentifierLabel.Size = New System.Drawing.Size(76, 13)
        DateIdentifierLabel.TabIndex = 8
        DateIdentifierLabel.Text = "Date Identifier:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Location = New System.Drawing.Point(65, 299)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(51, 13)
        LocationLabel.TabIndex = 10
        LocationLabel.Text = "Location:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(55, 224)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 12
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(56, 249)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 14
        FirstNameLabel.Text = "First Name:"
        '
        'PatientPhoneLabel
        '
        PatientPhoneLabel.AutoSize = True
        PatientPhoneLabel.Location = New System.Drawing.Point(39, 274)
        PatientPhoneLabel.Name = "PatientPhoneLabel"
        PatientPhoneLabel.Size = New System.Drawing.Size(77, 13)
        PatientPhoneLabel.TabIndex = 16
        PatientPhoneLabel.Text = "Patient Phone:"
        '
        'TaskTypeLabel
        '
        TaskTypeLabel.AutoSize = True
        TaskTypeLabel.Location = New System.Drawing.Point(55, 124)
        TaskTypeLabel.Name = "TaskTypeLabel"
        TaskTypeLabel.Size = New System.Drawing.Size(61, 13)
        TaskTypeLabel.TabIndex = 22
        TaskTypeLabel.Text = "Task Type:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(76, 74)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 24
        StatusLabel.Text = "Status:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(83, 99)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 26
        DateLabel.Text = "Date:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(387, 8)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(59, 13)
        CommentsLabel.TabIndex = 28
        CommentsLabel.Text = "Comments:"
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MailBoxBindingSource
        '
        Me.MailBoxBindingSource.DataMember = "MailBox"
        Me.MailBoxBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MailBoxTableAdapter
        '
        Me.MailBoxTableAdapter.ClearBeforeFill = True
        '
        'MailBoxBindingNavigator
        '
        Me.MailBoxBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MailBoxBindingNavigator.BindingSource = Me.MailBoxBindingSource
        Me.MailBoxBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MailBoxBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MailBoxBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MailBoxBindingNavigatorSaveItem})
        Me.MailBoxBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MailBoxBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MailBoxBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MailBoxBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MailBoxBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MailBoxBindingNavigator.Name = "MailBoxBindingNavigator"
        Me.MailBoxBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MailBoxBindingNavigator.Size = New System.Drawing.Size(1186, 25)
        Me.MailBoxBindingNavigator.TabIndex = 0
        Me.MailBoxBindingNavigator.Text = "BindingNavigator1"
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
        'MailBoxBindingNavigatorSaveItem
        '
        Me.MailBoxBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MailBoxBindingNavigatorSaveItem.Image = CType(resources.GetObject("MailBoxBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MailBoxBindingNavigatorSaveItem.Name = "MailBoxBindingNavigatorSaveItem"
        Me.MailBoxBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MailBoxBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MailBoxDataGridView
        '
        Me.MailBoxDataGridView.AllowUserToAddRows = False
        Me.MailBoxDataGridView.AutoGenerateColumns = False
        Me.MailBoxDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn14})
        Me.MailBoxDataGridView.DataSource = Me.MailBoxBindingSource
        Me.MailBoxDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.MailBoxDataGridView.Name = "MailBoxDataGridView"
        Me.MailBoxDataGridView.Size = New System.Drawing.Size(1165, 499)
        Me.MailBoxDataGridView.TabIndex = 1
        '
        'MailIDTextBox
        '
        Me.MailIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "MailID", True))
        Me.MailIDTextBox.Enabled = False
        Me.MailIDTextBox.Location = New System.Drawing.Point(122, 24)
        Me.MailIDTextBox.Name = "MailIDTextBox"
        Me.MailIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MailIDTextBox.TabIndex = 3
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "ChartNumber", True))
        Me.ChartNumberTextBox.Enabled = False
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(122, 199)
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(103, 20)
        Me.ChartNumberTextBox.TabIndex = 5
        '
        'RecordIDTextBox
        '
        Me.RecordIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "RecordID", True))
        Me.RecordIDTextBox.Enabled = False
        Me.RecordIDTextBox.Location = New System.Drawing.Point(122, 49)
        Me.RecordIDTextBox.Name = "RecordIDTextBox"
        Me.RecordIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RecordIDTextBox.TabIndex = 7
        '
        'DateIdentifierTextBox
        '
        Me.DateIdentifierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "DateIdentifier", True))
        Me.DateIdentifierTextBox.Enabled = False
        Me.DateIdentifierTextBox.Location = New System.Drawing.Point(122, 324)
        Me.DateIdentifierTextBox.Name = "DateIdentifierTextBox"
        Me.DateIdentifierTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DateIdentifierTextBox.TabIndex = 9
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "Location", True))
        Me.LocationTextBox.Enabled = False
        Me.LocationTextBox.Location = New System.Drawing.Point(122, 299)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LocationTextBox.TabIndex = 11
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(122, 224)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 13
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(122, 249)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 15
        '
        'PatientPhoneTextBox
        '
        Me.PatientPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "PatientPhone", True))
        Me.PatientPhoneTextBox.Location = New System.Drawing.Point(122, 274)
        Me.PatientPhoneTextBox.Name = "PatientPhoneTextBox"
        Me.PatientPhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PatientPhoneTextBox.TabIndex = 17
        '
        'TaskTypeTextBox
        '
        Me.TaskTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "TaskType", True))
        Me.TaskTypeTextBox.Location = New System.Drawing.Point(122, 124)
        Me.TaskTypeTextBox.Name = "TaskTypeTextBox"
        Me.TaskTypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TaskTypeTextBox.TabIndex = 23
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(122, 74)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StatusTextBox.TabIndex = 25
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MailBoxBindingSource, "Date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(122, 99)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 27
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "Comments", True))
        Me.CommentsTextBox.Location = New System.Drawing.Point(390, 24)
        Me.CommentsTextBox.Multiline = True
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(778, 474)
        Me.CommentsTextBox.TabIndex = 29
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1182, 534)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MailBoxDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1174, 508)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(AssignedToLabel)
        Me.TabPage2.Controls.Add(Me.AssignedToComboBox)
        Me.TabPage2.Controls.Add(AssignedByLabel)
        Me.TabPage2.Controls.Add(Me.AssignedByComboBox)
        Me.TabPage2.Controls.Add(Me.btnGetPatient)
        Me.TabPage2.Controls.Add(Me.MailIDTextBox)
        Me.TabPage2.Controls.Add(MailIDLabel)
        Me.TabPage2.Controls.Add(Me.CommentsTextBox)
        Me.TabPage2.Controls.Add(CommentsLabel)
        Me.TabPage2.Controls.Add(ChartNumberLabel)
        Me.TabPage2.Controls.Add(Me.DateDateTimePicker)
        Me.TabPage2.Controls.Add(Me.ChartNumberTextBox)
        Me.TabPage2.Controls.Add(DateLabel)
        Me.TabPage2.Controls.Add(RecordIDLabel)
        Me.TabPage2.Controls.Add(Me.StatusTextBox)
        Me.TabPage2.Controls.Add(Me.RecordIDTextBox)
        Me.TabPage2.Controls.Add(StatusLabel)
        Me.TabPage2.Controls.Add(DateIdentifierLabel)
        Me.TabPage2.Controls.Add(Me.TaskTypeTextBox)
        Me.TabPage2.Controls.Add(Me.DateIdentifierTextBox)
        Me.TabPage2.Controls.Add(TaskTypeLabel)
        Me.TabPage2.Controls.Add(LocationLabel)
        Me.TabPage2.Controls.Add(Me.LocationTextBox)
        Me.TabPage2.Controls.Add(LastNameLabel)
        Me.TabPage2.Controls.Add(Me.LastNameTextBox)
        Me.TabPage2.Controls.Add(FirstNameLabel)
        Me.TabPage2.Controls.Add(Me.PatientPhoneTextBox)
        Me.TabPage2.Controls.Add(Me.FirstNameTextBox)
        Me.TabPage2.Controls.Add(PatientPhoneLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1174, 508)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnGetPatient
        '
        Me.btnGetPatient.Location = New System.Drawing.Point(231, 199)
        Me.btnGetPatient.Name = "btnGetPatient"
        Me.btnGetPatient.Size = New System.Drawing.Size(91, 20)
        Me.btnGetPatient.TabIndex = 40
        Me.btnGetPatient.Text = "Get Patient"
        Me.btnGetPatient.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 60
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MailID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MailID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Chart#"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DateIdentifier"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DateIdentifier"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RecordID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RecordID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PatientPhone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PatientPhone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "AssignedBy"
        Me.DataGridViewTextBoxColumn9.HeaderText = "AssignedBy"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "AssignedTo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "AssignedTo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TaskType"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TaskType"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 300
        '
        'AssignedByLabel
        '
        AssignedByLabel.AutoSize = True
        AssignedByLabel.Location = New System.Drawing.Point(48, 153)
        AssignedByLabel.Name = "AssignedByLabel"
        AssignedByLabel.Size = New System.Drawing.Size(68, 13)
        AssignedByLabel.TabIndex = 40
        AssignedByLabel.Text = "Assigned By:"
        '
        'AssignedByComboBox
        '
        Me.AssignedByComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "AssignedBy", True))
        Me.AssignedByComboBox.FormattingEnabled = True
        Me.AssignedByComboBox.Location = New System.Drawing.Point(122, 149)
        Me.AssignedByComboBox.Name = "AssignedByComboBox"
        Me.AssignedByComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AssignedByComboBox.TabIndex = 41
        '
        'AssignedToLabel
        '
        AssignedToLabel.AutoSize = True
        AssignedToLabel.Location = New System.Drawing.Point(47, 178)
        AssignedToLabel.Name = "AssignedToLabel"
        AssignedToLabel.Size = New System.Drawing.Size(69, 13)
        AssignedToLabel.TabIndex = 41
        AssignedToLabel.Text = "Assigned To:"
        '
        'AssignedToComboBox
        '
        Me.AssignedToComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MailBoxBindingSource, "AssignedTo", True))
        Me.AssignedToComboBox.FormattingEnabled = True
        Me.AssignedToComboBox.Location = New System.Drawing.Point(122, 174)
        Me.AssignedToComboBox.Name = "AssignedToComboBox"
        Me.AssignedToComboBox.Size = New System.Drawing.Size(200, 21)
        Me.AssignedToComboBox.TabIndex = 42
        '
        'MailBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MailBoxBindingNavigator)
        Me.Name = "MailBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MailBox"
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MailBoxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MailBoxBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MailBoxBindingNavigator.ResumeLayout(False)
        Me.MailBoxBindingNavigator.PerformLayout()
        CType(Me.MailBoxDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MailBoxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MailBoxTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MailBoxTableAdapter
    Friend WithEvents MailBoxBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MailBoxBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MailBoxDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MailIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RecordIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateIdentifierTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatientPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaskTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnGetPatient As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AssignedToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AssignedByComboBox As System.Windows.Forms.ComboBox
End Class
