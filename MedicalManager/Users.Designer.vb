<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim NetworkUsernameLabel As System.Windows.Forms.Label
        Dim Procedure_NameLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim PermissionsLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.MMUsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.MMUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.MMUsersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.TitleTextBox = New System.Windows.Forms.TextBox
        Me.NetworkUsernameTextBox = New System.Windows.Forms.TextBox
        Me.Procedure_NameTextBox = New System.Windows.Forms.TextBox
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.MMUsersDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.EmailComboBox = New System.Windows.Forms.ComboBox
        Me.PermissionsComboBox = New System.Windows.Forms.ComboBox
        Me.UserIdTextBox = New System.Windows.Forms.TextBox
        Me.btnRemoveAuthorization = New System.Windows.Forms.Button
        Me.MMActionsListDataGridView = New System.Windows.Forms.DataGridView
        Me.Authorized = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Actions = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMActionsListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCopyProcedure = New System.Windows.Forms.TextBox
        Me.MMUsersTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.MMUsersTableAdapter
        Me.MMActionsListTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.MMActionsListTableAdapter
        FirstNameLabel = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        TitleLabel = New System.Windows.Forms.Label
        NetworkUsernameLabel = New System.Windows.Forms.Label
        Procedure_NameLabel = New System.Windows.Forms.Label
        EmailAddressLabel = New System.Windows.Forms.Label
        PasswordLabel = New System.Windows.Forms.Label
        UserIdLabel = New System.Windows.Forms.Label
        PermissionsLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        CType(Me.MMUsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMUsersBindingNavigator.SuspendLayout()
        CType(Me.MMUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MMUsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMActionsListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMActionsListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(66, 45)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(65, 71)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(96, 97)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 7
        TitleLabel.Text = "Title:"
        '
        'NetworkUsernameLabel
        '
        NetworkUsernameLabel.AutoSize = True
        NetworkUsernameLabel.Location = New System.Drawing.Point(342, 72)
        NetworkUsernameLabel.Name = "NetworkUsernameLabel"
        NetworkUsernameLabel.Size = New System.Drawing.Size(58, 13)
        NetworkUsernameLabel.TabIndex = 9
        NetworkUsernameLabel.Text = "Username:"
        '
        'Procedure_NameLabel
        '
        Procedure_NameLabel.AutoSize = True
        Procedure_NameLabel.Location = New System.Drawing.Point(36, 151)
        Procedure_NameLabel.Name = "Procedure_NameLabel"
        Procedure_NameLabel.Size = New System.Drawing.Size(90, 13)
        Procedure_NameLabel.TabIndex = 11
        Procedure_NameLabel.Text = "Procedure Name:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(50, 121)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(76, 13)
        EmailAddressLabel.TabIndex = 17
        EmailAddressLabel.Text = "Email Address:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(344, 97)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 19
        PasswordLabel.Text = "Password:"
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(82, 18)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(44, 13)
        UserIdLabel.TabIndex = 23
        UserIdLabel.Text = "User Id:"
        '
        'PermissionsLabel
        '
        PermissionsLabel.AutoSize = True
        PermissionsLabel.Location = New System.Drawing.Point(335, 18)
        PermissionsLabel.Name = "PermissionsLabel"
        PermissionsLabel.Size = New System.Drawing.Size(65, 13)
        PermissionsLabel.TabIndex = 24
        PermissionsLabel.Text = "Permissions:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(365, 45)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 25
        EmailLabel.Text = "Email:"
        '
        'MMUsersBindingNavigator
        '
        Me.MMUsersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMUsersBindingNavigator.BindingSource = Me.MMUsersBindingSource
        Me.MMUsersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMUsersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMUsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel2, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel1, Me.MMUsersBindingNavigatorSaveItem})
        Me.MMUsersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMUsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMUsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMUsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMUsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMUsersBindingNavigator.Name = "MMUsersBindingNavigator"
        Me.MMUsersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMUsersBindingNavigator.Size = New System.Drawing.Size(867, 25)
        Me.MMUsersBindingNavigator.TabIndex = 0
        Me.MMUsersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'MMUsersBindingSource
        '
        Me.MMUsersBindingSource.DataMember = "MMUsers"
        Me.MMUsersBindingSource.DataSource = Me.MMDataDataSet2
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
        'MMUsersBindingNavigatorSaveItem
        '
        Me.MMUsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMUsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMUsersBindingNavigatorSaveItem.Name = "MMUsersBindingNavigatorSaveItem"
        Me.MMUsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.MMUsersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(132, 42)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(141, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(132, 68)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(141, 20)
        Me.LastNameTextBox.TabIndex = 2
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(132, 94)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(141, 20)
        Me.TitleTextBox.TabIndex = 3
        '
        'NetworkUsernameTextBox
        '
        Me.NetworkUsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "NetworkUsername", True))
        Me.NetworkUsernameTextBox.Location = New System.Drawing.Point(406, 69)
        Me.NetworkUsernameTextBox.Name = "NetworkUsernameTextBox"
        Me.NetworkUsernameTextBox.Size = New System.Drawing.Size(133, 20)
        Me.NetworkUsernameTextBox.TabIndex = 4
        '
        'Procedure_NameTextBox
        '
        Me.Procedure_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "Procedure_Name", True))
        Me.Procedure_NameTextBox.Location = New System.Drawing.Point(132, 148)
        Me.Procedure_NameTextBox.Multiline = True
        Me.Procedure_NameTextBox.Name = "Procedure_NameTextBox"
        Me.Procedure_NameTextBox.Size = New System.Drawing.Size(407, 229)
        Me.Procedure_NameTextBox.TabIndex = 12
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(132, 118)
        Me.EmailAddressTextBox.MaxLength = 40
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(141, 20)
        Me.EmailAddressTextBox.TabIndex = 7
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(406, 94)
        Me.PasswordTextBox.MaxLength = 10
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(133, 20)
        Me.PasswordTextBox.TabIndex = 8
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(867, 428)
        Me.TabControl1.TabIndex = 21
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MMUsersDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(859, 402)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MMUsersDataGridView
        '
        Me.MMUsersDataGridView.AllowUserToAddRows = False
        Me.MMUsersDataGridView.AutoGenerateColumns = False
        Me.MMUsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.MMUsersDataGridView.DataSource = Me.MMUsersBindingSource
        Me.MMUsersDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.MMUsersDataGridView.Name = "MMUsersDataGridView"
        Me.MMUsersDataGridView.Size = New System.Drawing.Size(857, 396)
        Me.MMUsersDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NetworkUsername"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NetworkUsername"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Procedure_Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Procedure_Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Permissions"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Permissions"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "EmailAddress"
        Me.DataGridViewTextBoxColumn9.HeaderText = "EmailAddress"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(EmailLabel)
        Me.TabPage2.Controls.Add(Me.EmailComboBox)
        Me.TabPage2.Controls.Add(PermissionsLabel)
        Me.TabPage2.Controls.Add(Me.PermissionsComboBox)
        Me.TabPage2.Controls.Add(UserIdLabel)
        Me.TabPage2.Controls.Add(Me.UserIdTextBox)
        Me.TabPage2.Controls.Add(Me.btnRemoveAuthorization)
        Me.TabPage2.Controls.Add(Me.MMActionsListDataGridView)
        Me.TabPage2.Controls.Add(Me.PasswordTextBox)
        Me.TabPage2.Controls.Add(PasswordLabel)
        Me.TabPage2.Controls.Add(FirstNameLabel)
        Me.TabPage2.Controls.Add(Me.EmailAddressTextBox)
        Me.TabPage2.Controls.Add(Me.FirstNameTextBox)
        Me.TabPage2.Controls.Add(EmailAddressLabel)
        Me.TabPage2.Controls.Add(LastNameLabel)
        Me.TabPage2.Controls.Add(Me.LastNameTextBox)
        Me.TabPage2.Controls.Add(TitleLabel)
        Me.TabPage2.Controls.Add(Me.TitleTextBox)
        Me.TabPage2.Controls.Add(NetworkUsernameLabel)
        Me.TabPage2.Controls.Add(Me.Procedure_NameTextBox)
        Me.TabPage2.Controls.Add(Me.NetworkUsernameTextBox)
        Me.TabPage2.Controls.Add(Procedure_NameLabel)
        Me.TabPage2.Controls.Add(Me.txtCopyProcedure)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(859, 402)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EmailComboBox
        '
        Me.EmailComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "Email", True))
        Me.EmailComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmailComboBox.FormattingEnabled = True
        Me.EmailComboBox.Items.AddRange(New Object() {"Y", "N"})
        Me.EmailComboBox.Location = New System.Drawing.Point(406, 42)
        Me.EmailComboBox.MaxLength = 1
        Me.EmailComboBox.Name = "EmailComboBox"
        Me.EmailComboBox.Size = New System.Drawing.Size(48, 21)
        Me.EmailComboBox.TabIndex = 6
        '
        'PermissionsComboBox
        '
        Me.PermissionsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "Permissions", True))
        Me.PermissionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PermissionsComboBox.FormattingEnabled = True
        Me.PermissionsComboBox.Items.AddRange(New Object() {"Y", "N"})
        Me.PermissionsComboBox.Location = New System.Drawing.Point(406, 15)
        Me.PermissionsComboBox.MaxLength = 1
        Me.PermissionsComboBox.Name = "PermissionsComboBox"
        Me.PermissionsComboBox.Size = New System.Drawing.Size(48, 21)
        Me.PermissionsComboBox.TabIndex = 5
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "UserId", True))
        Me.UserIdTextBox.Enabled = False
        Me.UserIdTextBox.Location = New System.Drawing.Point(132, 15)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.Size = New System.Drawing.Size(69, 20)
        Me.UserIdTextBox.TabIndex = 0
        '
        'btnRemoveAuthorization
        '
        Me.btnRemoveAuthorization.Location = New System.Drawing.Point(741, 376)
        Me.btnRemoveAuthorization.Name = "btnRemoveAuthorization"
        Me.btnRemoveAuthorization.Size = New System.Drawing.Size(115, 23)
        Me.btnRemoveAuthorization.TabIndex = 23
        Me.btnRemoveAuthorization.Text = "Update Authorization"
        Me.btnRemoveAuthorization.UseVisualStyleBackColor = True
        '
        'MMActionsListDataGridView
        '
        Me.MMActionsListDataGridView.AllowUserToAddRows = False
        Me.MMActionsListDataGridView.AutoGenerateColumns = False
        Me.MMActionsListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Authorized, Me.Actions, Me.Description, Me.ID})
        Me.MMActionsListDataGridView.DataSource = Me.MMActionsListBindingSource
        Me.MMActionsListDataGridView.Location = New System.Drawing.Point(584, 3)
        Me.MMActionsListDataGridView.Name = "MMActionsListDataGridView"
        Me.MMActionsListDataGridView.Size = New System.Drawing.Size(271, 371)
        Me.MMActionsListDataGridView.TabIndex = 20
        '
        'Authorized
        '
        Me.Authorized.DataPropertyName = "Authorized"
        Me.Authorized.HeaderText = "Authorized"
        Me.Authorized.Name = "Authorized"
        Me.Authorized.Width = 70
        '
        'Actions
        '
        Me.Actions.DataPropertyName = "Actions"
        Me.Actions.HeaderText = "Actions"
        Me.Actions.Name = "Actions"
        Me.Actions.Width = 150
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Visible = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 30
        '
        'MMActionsListBindingSource
        '
        Me.MMActionsListBindingSource.DataMember = "MMActionsList"
        Me.MMActionsListBindingSource.DataSource = Me.MMDataDataSet2
        '
        'txtCopyProcedure
        '
        Me.txtCopyProcedure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMUsersBindingSource, "Procedure_Name", True))
        Me.txtCopyProcedure.Location = New System.Drawing.Point(612, 15)
        Me.txtCopyProcedure.Multiline = True
        Me.txtCopyProcedure.Name = "txtCopyProcedure"
        Me.txtCopyProcedure.Size = New System.Drawing.Size(191, 206)
        Me.txtCopyProcedure.TabIndex = 22
        '
        'MMUsersTableAdapter
        '
        Me.MMUsersTableAdapter.ClearBeforeFill = True
        '
        'MMActionsListTableAdapter
        '
        Me.MMActionsListTableAdapter.ClearBeforeFill = True
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 457)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MMUsersBindingNavigator)
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        CType(Me.MMUsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMUsersBindingNavigator.ResumeLayout(False)
        Me.MMUsersBindingNavigator.PerformLayout()
        CType(Me.MMUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.MMUsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.MMActionsListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMActionsListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents MMUsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMUsersTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.MMUsersTableAdapter
    Friend WithEvents MMUsersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMUsersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NetworkUsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Procedure_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents MMUsersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMActionsListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMActionsListTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.MMActionsListTableAdapter
    Friend WithEvents MMActionsListDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtCopyProcedure As System.Windows.Forms.TextBox
    Friend WithEvents Authorized As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Actions As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRemoveAuthorization As System.Windows.Forms.Button
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
    Friend WithEvents UserIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PermissionsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
