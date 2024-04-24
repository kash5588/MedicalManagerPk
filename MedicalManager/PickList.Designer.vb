<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PickList))
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.MMPATIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMPATIENTTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMPATIENTTableAdapter
        Me.MMPATIENTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.MMPATIENTDataGridView = New System.Windows.Forms.DataGridView
        Me.PatientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChartNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MiddleInitialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateofBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Street1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Street2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ZipCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmploymentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HomeePhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CellPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.MMPhysionDataGridView = New System.Windows.Forms.DataGridView
        Me.PhysicianCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianLastName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianMiddleInitial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianCredentials = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianStreet1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianStreet2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianCity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianState = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianZip = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianPhone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianSSNorFedTaxID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhysicianSpecialty = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMPhysionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.LetterBodyDataGridView = New System.Windows.Forms.DataGridView
        Me.MMPhysionTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMPhysionTableAdapter
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPATIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMPATIENTBindingNavigator.SuspendLayout()
        CType(Me.MMPATIENTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMPhysionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPhysionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.LetterBodyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMPATIENTBindingSource
        '
        Me.MMPATIENTBindingSource.DataMember = "MMPATIENT"
        Me.MMPATIENTBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMPATIENTTableAdapter
        '
        Me.MMPATIENTTableAdapter.ClearBeforeFill = True
        '
        'MMPATIENTBindingNavigator
        '
        Me.MMPATIENTBindingNavigator.AddNewItem = Nothing
        Me.MMPATIENTBindingNavigator.BindingSource = Me.MMPATIENTBindingSource
        Me.MMPATIENTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMPATIENTBindingNavigator.DeleteItem = Nothing
        Me.MMPATIENTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel2, Me.txtFind, Me.ToolStripSeparator1, Me.ToolStripLabel3, Me.cmbFilter})
        Me.MMPATIENTBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMPATIENTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMPATIENTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMPATIENTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMPATIENTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMPATIENTBindingNavigator.Name = "MMPATIENTBindingNavigator"
        Me.MMPATIENTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMPATIENTBindingNavigator.Size = New System.Drawing.Size(878, 25)
        Me.MMPATIENTBindingNavigator.TabIndex = 0
        Me.MMPATIENTBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.ToolStripLabel2.Size = New System.Drawing.Size(27, 22)
        Me.ToolStripLabel2.Text = "Find"
        '
        'txtFind
        '
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel3.Text = "Criteria"
        '
        'cmbFilter
        '
        Me.cmbFilter.Items.AddRange(New Object() {"ChartNumber", "LastName", "FirstName", "DateOfBirth", "SSNo"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 25)
        '
        'MMPATIENTDataGridView
        '
        Me.MMPATIENTDataGridView.AllowUserToAddRows = False
        Me.MMPATIENTDataGridView.AllowUserToResizeRows = False
        Me.MMPATIENTDataGridView.AutoGenerateColumns = False
        Me.MMPATIENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MMPATIENTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIDDataGridViewTextBoxColumn, Me.ChartNumberDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleInitialDataGridViewTextBoxColumn, Me.DateofBirthDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.Street1DataGridViewTextBoxColumn, Me.Street2DataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipCodeDataGridViewTextBoxColumn, Me.EmploymentStatusDataGridViewTextBoxColumn, Me.HomeePhoneDataGridViewTextBoxColumn, Me.CellPhoneDataGridViewTextBoxColumn})
        Me.MMPATIENTDataGridView.DataSource = Me.MMPATIENTBindingSource
        Me.MMPATIENTDataGridView.Location = New System.Drawing.Point(3, 6)
        Me.MMPATIENTDataGridView.Name = "MMPATIENTDataGridView"
        Me.MMPATIENTDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MMPATIENTDataGridView.Size = New System.Drawing.Size(864, 490)
        Me.MMPATIENTDataGridView.TabIndex = 1
        '
        'PatientIDDataGridViewTextBoxColumn
        '
        Me.PatientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID"
        Me.PatientIDDataGridViewTextBoxColumn.HeaderText = "Pat ID"
        Me.PatientIDDataGridViewTextBoxColumn.Name = "PatientIDDataGridViewTextBoxColumn"
        Me.PatientIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientIDDataGridViewTextBoxColumn.Width = 75
        '
        'ChartNumberDataGridViewTextBoxColumn
        '
        Me.ChartNumberDataGridViewTextBoxColumn.DataPropertyName = "ChartNumber"
        Me.ChartNumberDataGridViewTextBoxColumn.HeaderText = "Chart No"
        Me.ChartNumberDataGridViewTextBoxColumn.MaxInputLength = 8
        Me.ChartNumberDataGridViewTextBoxColumn.Name = "ChartNumberDataGridViewTextBoxColumn"
        Me.ChartNumberDataGridViewTextBoxColumn.Width = 75
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.MaxInputLength = 20
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.MaxInputLength = 20
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleInitialDataGridViewTextBoxColumn
        '
        Me.MiddleInitialDataGridViewTextBoxColumn.DataPropertyName = "MiddleInitial"
        Me.MiddleInitialDataGridViewTextBoxColumn.HeaderText = "MI"
        Me.MiddleInitialDataGridViewTextBoxColumn.MaxInputLength = 1
        Me.MiddleInitialDataGridViewTextBoxColumn.Name = "MiddleInitialDataGridViewTextBoxColumn"
        Me.MiddleInitialDataGridViewTextBoxColumn.Width = 25
        '
        'DateofBirthDataGridViewTextBoxColumn
        '
        Me.DateofBirthDataGridViewTextBoxColumn.DataPropertyName = "DateofBirth"
        Me.DateofBirthDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DateofBirthDataGridViewTextBoxColumn.Name = "DateofBirthDataGridViewTextBoxColumn"
        Me.DateofBirthDataGridViewTextBoxColumn.Width = 50
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.MaxInputLength = 6
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.Width = 50
        '
        'Street1DataGridViewTextBoxColumn
        '
        Me.Street1DataGridViewTextBoxColumn.DataPropertyName = "Street1"
        Me.Street1DataGridViewTextBoxColumn.HeaderText = "Address 1"
        Me.Street1DataGridViewTextBoxColumn.MaxInputLength = 30
        Me.Street1DataGridViewTextBoxColumn.Name = "Street1DataGridViewTextBoxColumn"
        '
        'Street2DataGridViewTextBoxColumn
        '
        Me.Street2DataGridViewTextBoxColumn.DataPropertyName = "Street2"
        Me.Street2DataGridViewTextBoxColumn.HeaderText = "Address 2"
        Me.Street2DataGridViewTextBoxColumn.MaxInputLength = 30
        Me.Street2DataGridViewTextBoxColumn.Name = "Street2DataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.MaxInputLength = 20
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.Width = 75
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.MaxInputLength = 2
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.Width = 35
        '
        'ZipCodeDataGridViewTextBoxColumn
        '
        Me.ZipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn.HeaderText = "Zip"
        Me.ZipCodeDataGridViewTextBoxColumn.MaxInputLength = 10
        Me.ZipCodeDataGridViewTextBoxColumn.Name = "ZipCodeDataGridViewTextBoxColumn"
        Me.ZipCodeDataGridViewTextBoxColumn.Width = 50
        '
        'EmploymentStatusDataGridViewTextBoxColumn
        '
        Me.EmploymentStatusDataGridViewTextBoxColumn.DataPropertyName = "EmploymentStatus"
        Me.EmploymentStatusDataGridViewTextBoxColumn.HeaderText = "Employment Status"
        Me.EmploymentStatusDataGridViewTextBoxColumn.MaxInputLength = 12
        Me.EmploymentStatusDataGridViewTextBoxColumn.Name = "EmploymentStatusDataGridViewTextBoxColumn"
        '
        'HomeePhoneDataGridViewTextBoxColumn
        '
        Me.HomeePhoneDataGridViewTextBoxColumn.DataPropertyName = "HomeePhone"
        Me.HomeePhoneDataGridViewTextBoxColumn.HeaderText = "Home Phone"
        Me.HomeePhoneDataGridViewTextBoxColumn.MaxInputLength = 14
        Me.HomeePhoneDataGridViewTextBoxColumn.Name = "HomeePhoneDataGridViewTextBoxColumn"
        Me.HomeePhoneDataGridViewTextBoxColumn.Width = 75
        '
        'CellPhoneDataGridViewTextBoxColumn
        '
        Me.CellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CellPhone"
        Me.CellPhoneDataGridViewTextBoxColumn.HeaderText = "Cell Phone"
        Me.CellPhoneDataGridViewTextBoxColumn.MaxInputLength = 14
        Me.CellPhoneDataGridViewTextBoxColumn.Name = "CellPhoneDataGridViewTextBoxColumn"
        Me.CellPhoneDataGridViewTextBoxColumn.Width = 75
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(878, 525)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MMPATIENTDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(870, 499)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Patient"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.MMPhysionDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(870, 499)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Physician"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MMPhysionDataGridView
        '
        Me.MMPhysionDataGridView.AllowUserToAddRows = False
        Me.MMPhysionDataGridView.AllowUserToResizeRows = False
        Me.MMPhysionDataGridView.AutoGenerateColumns = False
        Me.MMPhysionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PhysicianCode, Me.PhysicianLastName, Me.PhysicianFirstName, Me.PhysicianMiddleInitial, Me.PhysicianCredentials, Me.PhysicianStreet1, Me.PhysicianStreet2, Me.PhysicianCity, Me.PhysicianState, Me.PhysicianZip, Me.PhysicianPhone, Me.PhysicianSSNorFedTaxID, Me.PhysicianSpecialty})
        Me.MMPhysionDataGridView.DataSource = Me.MMPhysionBindingSource
        Me.MMPhysionDataGridView.Location = New System.Drawing.Point(3, 6)
        Me.MMPhysionDataGridView.Name = "MMPhysionDataGridView"
        Me.MMPhysionDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MMPhysionDataGridView.Size = New System.Drawing.Size(864, 490)
        Me.MMPhysionDataGridView.TabIndex = 0
        '
        'PhysicianCode
        '
        Me.PhysicianCode.DataPropertyName = "Code"
        Me.PhysicianCode.HeaderText = "Code"
        Me.PhysicianCode.Name = "PhysicianCode"
        '
        'PhysicianLastName
        '
        Me.PhysicianLastName.DataPropertyName = "LastName"
        Me.PhysicianLastName.HeaderText = "LastName"
        Me.PhysicianLastName.Name = "PhysicianLastName"
        '
        'PhysicianFirstName
        '
        Me.PhysicianFirstName.DataPropertyName = "FirstName"
        Me.PhysicianFirstName.HeaderText = "FirstName"
        Me.PhysicianFirstName.Name = "PhysicianFirstName"
        '
        'PhysicianMiddleInitial
        '
        Me.PhysicianMiddleInitial.DataPropertyName = "MiddleInitial"
        Me.PhysicianMiddleInitial.HeaderText = "MiddleInitial"
        Me.PhysicianMiddleInitial.Name = "PhysicianMiddleInitial"
        '
        'PhysicianCredentials
        '
        Me.PhysicianCredentials.DataPropertyName = "Credentials"
        Me.PhysicianCredentials.HeaderText = "Credentials"
        Me.PhysicianCredentials.Name = "PhysicianCredentials"
        '
        'PhysicianStreet1
        '
        Me.PhysicianStreet1.DataPropertyName = "Street1"
        Me.PhysicianStreet1.HeaderText = "Street1"
        Me.PhysicianStreet1.Name = "PhysicianStreet1"
        '
        'PhysicianStreet2
        '
        Me.PhysicianStreet2.DataPropertyName = "Street2"
        Me.PhysicianStreet2.HeaderText = "Street2"
        Me.PhysicianStreet2.Name = "PhysicianStreet2"
        '
        'PhysicianCity
        '
        Me.PhysicianCity.DataPropertyName = "City"
        Me.PhysicianCity.HeaderText = "City"
        Me.PhysicianCity.Name = "PhysicianCity"
        '
        'PhysicianState
        '
        Me.PhysicianState.DataPropertyName = "State"
        Me.PhysicianState.HeaderText = "State"
        Me.PhysicianState.Name = "PhysicianState"
        '
        'PhysicianZip
        '
        Me.PhysicianZip.DataPropertyName = "ZipCode"
        Me.PhysicianZip.HeaderText = "ZipCode"
        Me.PhysicianZip.Name = "PhysicianZip"
        '
        'PhysicianPhone
        '
        Me.PhysicianPhone.DataPropertyName = "Phone"
        Me.PhysicianPhone.HeaderText = "Phone"
        Me.PhysicianPhone.Name = "PhysicianPhone"
        '
        'PhysicianSSNorFedTaxID
        '
        Me.PhysicianSSNorFedTaxID.DataPropertyName = "SSNorFedTaxID"
        Me.PhysicianSSNorFedTaxID.HeaderText = "SSNorFedTaxID"
        Me.PhysicianSSNorFedTaxID.Name = "PhysicianSSNorFedTaxID"
        '
        'PhysicianSpecialty
        '
        Me.PhysicianSpecialty.DataPropertyName = "Specialty"
        Me.PhysicianSpecialty.HeaderText = "Specialty"
        Me.PhysicianSpecialty.Name = "PhysicianSpecialty"
        '
        'MMPhysionBindingSource
        '
        Me.MMPhysionBindingSource.DataMember = "MMPhysion"
        Me.MMPhysionBindingSource.DataSource = Me.MMDataDataSet1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LetterBodyDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(870, 499)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Letter Body"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'LetterBodyDataGridView
        '
        Me.LetterBodyDataGridView.AllowUserToAddRows = False
        Me.LetterBodyDataGridView.AllowUserToResizeRows = False
        Me.LetterBodyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LetterBodyDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.LetterBodyDataGridView.Name = "LetterBodyDataGridView"
        Me.LetterBodyDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.LetterBodyDataGridView.Size = New System.Drawing.Size(858, 487)
        Me.LetterBodyDataGridView.TabIndex = 0
        '
        'MMPhysionTableAdapter
        '
        Me.MMPhysionTableAdapter.ClearBeforeFill = True
        '
        'PickList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 557)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MMPATIENTBindingNavigator)
        Me.Name = "PickList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Pick List"
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPATIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMPATIENTBindingNavigator.ResumeLayout(False)
        Me.MMPATIENTBindingNavigator.PerformLayout()
        CType(Me.MMPATIENTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MMPhysionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPhysionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.LetterBodyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMPATIENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMPATIENTTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMPATIENTTableAdapter
    Friend WithEvents MMPATIENTBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MMPATIENTDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PatientIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChartNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleInitialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Street1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Street2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmploymentStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HomeePhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CellPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMPhysionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMPhysionTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMPhysionTableAdapter
    Friend WithEvents MMPhysionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PhysicianCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianLastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianFirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianMiddleInitial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianCredentials As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianStreet1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianStreet2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianZip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianSSNorFedTaxID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicianSpecialty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents LetterBodyDataGridView As System.Windows.Forms.DataGridView
End Class
