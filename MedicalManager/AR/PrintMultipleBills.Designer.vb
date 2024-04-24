<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintMultipleBills
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintMultipleBills))
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Param1ToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.Param1ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.Param2ToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.Param2ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FillBillByChNoCaseNoToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.cboInstalledPrinters = New System.Windows.Forms.ComboBox
        Me.BillingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BillingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARDataSet = New MedicalManager.ARDataSet
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
        Me.BillingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.BillingDataGridView = New System.Windows.Forms.DataGridView
        Me.MMARTRANSACTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingTableAdapter = New MedicalManager.ARDataSetTableAdapters.BillingTableAdapter
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.MMDataDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMARTRANSACTIONSTableAdapter = New MedicalManager.ARDataSetTableAdapters.MMARTRANSACTIONSTableAdapter
        Me.chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EntryNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChartNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClaimNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AttendingProviderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProcedureCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TransactionTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InsuranceCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TypeofServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VisitNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VisitTotalinSeriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VisitSeriesIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MinutesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PriceIndicatorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diagnosis1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Diagnosis2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Diagnosis3DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Diagnosis4DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ClaimItemRejectedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.AcceptAssignment1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.AcceptAssignment2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.AcceptAssignment3DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DateCreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateofFirstStatementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateofSecondStatementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateofLastStatementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BilledtoInsured1DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.BilledtoInsured2DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.BilledtoInsured3DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GuarantorPaidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Insurance1PaidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Insurance2PaidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Insurance3PaidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GuarantorAmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Insurance1AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Insurance2AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Insurance3AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuarantorResponsibleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Insurance1ResponsibleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Insurance2ResponsibleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Insurance3ResponsibleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.WhoPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocumentationTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocumentationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AttorneyPaidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.AttorneyAmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AttorneyResponsibleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.AdjustmentAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllowedAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiagnosisCode1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiagnosisCode2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiagnosisCode3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiagnosisCode4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MouthQuadrantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CCEntryNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToothNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CheckNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateModifiedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DepositIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ThisPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LineTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LineBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.BillingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BillingBindingNavigator.SuspendLayout()
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARTRANSACTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(1122, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Param1ToolStripLabel
        '
        Me.Param1ToolStripLabel.Name = "Param1ToolStripLabel"
        Me.Param1ToolStripLabel.Size = New System.Drawing.Size(47, 22)
        Me.Param1ToolStripLabel.Text = "Param1:"
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        Me.Param1ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Param2ToolStripLabel
        '
        Me.Param2ToolStripLabel.Name = "Param2ToolStripLabel"
        Me.Param2ToolStripLabel.Size = New System.Drawing.Size(47, 22)
        Me.Param2ToolStripLabel.Text = "Param2:"
        '
        'Param2ToolStripTextBox
        '
        Me.Param2ToolStripTextBox.Name = "Param2ToolStripTextBox"
        Me.Param2ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillBillByChNoCaseNoToolStripButton
        '
        Me.FillBillByChNoCaseNoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBillByChNoCaseNoToolStripButton.Name = "FillBillByChNoCaseNoToolStripButton"
        Me.FillBillByChNoCaseNoToolStripButton.Size = New System.Drawing.Size(110, 22)
        Me.FillBillByChNoCaseNoToolStripButton.Text = "FillBillByChNoCaseNo"
        '
        'cboInstalledPrinters
        '
        Me.cboInstalledPrinters.FormattingEnabled = True
        Me.cboInstalledPrinters.Location = New System.Drawing.Point(933, 4)
        Me.cboInstalledPrinters.Name = "cboInstalledPrinters"
        Me.cboInstalledPrinters.Size = New System.Drawing.Size(183, 21)
        Me.cboInstalledPrinters.TabIndex = 4
        '
        'BillingBindingNavigator
        '
        Me.BillingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BillingBindingNavigator.BindingSource = Me.BillingBindingSource
        Me.BillingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BillingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BillingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BillingBindingNavigatorSaveItem})
        Me.BillingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BillingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BillingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BillingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BillingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BillingBindingNavigator.Name = "BillingBindingNavigator"
        Me.BillingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BillingBindingNavigator.Size = New System.Drawing.Size(1205, 25)
        Me.BillingBindingNavigator.TabIndex = 5
        Me.BillingBindingNavigator.Text = "BindingNavigator1"
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
        'BillingBindingSource
        '
        Me.BillingBindingSource.DataMember = "Billing"
        Me.BillingBindingSource.DataSource = Me.ARDataSet
        '
        'ARDataSet
        '
        Me.ARDataSet.DataSetName = "ARDataSet"
        Me.ARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'BillingBindingNavigatorSaveItem
        '
        Me.BillingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BillingBindingNavigatorSaveItem.Enabled = False
        Me.BillingBindingNavigatorSaveItem.Image = CType(resources.GetObject("BillingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BillingBindingNavigatorSaveItem.Name = "BillingBindingNavigatorSaveItem"
        Me.BillingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BillingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BillingDataGridView
        '
        Me.BillingDataGridView.AllowUserToAddRows = False
        Me.BillingDataGridView.AutoGenerateColumns = False
        Me.BillingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelect, Me.EntryNumberDataGridViewTextBoxColumn, Me.ChartNumber, Me.CaseNumber, Me.ClaimNumberDataGridViewTextBoxColumn, Me.DateFromDataGridViewTextBoxColumn, Me.DateToDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.AttendingProviderDataGridViewTextBoxColumn, Me.ProcedureCodeDataGridViewTextBoxColumn, Me.TransactionTypeDataGridViewTextBoxColumn, Me.InsuranceCategoryDataGridViewTextBoxColumn, Me.TypeofServiceDataGridViewTextBoxColumn, Me.VisitNumberDataGridViewTextBoxColumn, Me.VisitTotalinSeriesDataGridViewTextBoxColumn, Me.VisitSeriesIDDataGridViewTextBoxColumn, Me.UnitsDataGridViewTextBoxColumn, Me.MinutesDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.PriceIndicatorDataGridViewTextBoxColumn, Me.Diagnosis1DataGridViewCheckBoxColumn, Me.Diagnosis2DataGridViewCheckBoxColumn, Me.Diagnosis3DataGridViewCheckBoxColumn, Me.Diagnosis4DataGridViewCheckBoxColumn, Me.ClaimItemRejectedDataGridViewCheckBoxColumn, Me.AcceptAssignment1DataGridViewCheckBoxColumn, Me.AcceptAssignment2DataGridViewCheckBoxColumn, Me.AcceptAssignment3DataGridViewCheckBoxColumn, Me.DateCreatedDataGridViewTextBoxColumn, Me.DateofFirstStatementDataGridViewTextBoxColumn, Me.DateofSecondStatementDataGridViewTextBoxColumn, Me.DateofLastStatementDataGridViewTextBoxColumn, Me.BilledtoInsured1DataGridViewCheckBoxColumn, Me.BilledtoInsured2DataGridViewCheckBoxColumn, Me.BilledtoInsured3DataGridViewCheckBoxColumn, Me.GuarantorPaidDataGridViewCheckBoxColumn, Me.Insurance1PaidDataGridViewCheckBoxColumn, Me.Insurance2PaidDataGridViewCheckBoxColumn, Me.Insurance3PaidDataGridViewCheckBoxColumn, Me.GuarantorAmountPaidDataGridViewTextBoxColumn, Me.Insurance1AmountPaidDataGridViewTextBoxColumn, Me.Insurance2AmountPaidDataGridViewTextBoxColumn, Me.Insurance3AmountPaidDataGridViewTextBoxColumn, Me.GuarantorResponsibleDataGridViewCheckBoxColumn, Me.Insurance1ResponsibleDataGridViewCheckBoxColumn, Me.Insurance2ResponsibleDataGridViewCheckBoxColumn, Me.Insurance3ResponsibleDataGridViewCheckBoxColumn, Me.WhoPaidDataGridViewTextBoxColumn, Me.DocumentationTypeDataGridViewTextBoxColumn, Me.DocumentationDataGridViewTextBoxColumn, Me.AttorneyPaidDataGridViewCheckBoxColumn, Me.AttorneyAmountPaidDataGridViewTextBoxColumn, Me.AttorneyResponsibleDataGridViewCheckBoxColumn, Me.AdjustmentAmountDataGridViewTextBoxColumn, Me.UserCodeDataGridViewTextBoxColumn, Me.AllowedAmountDataGridViewTextBoxColumn, Me.DiagnosisCode1DataGridViewTextBoxColumn, Me.DiagnosisCode2DataGridViewTextBoxColumn, Me.DiagnosisCode3DataGridViewTextBoxColumn, Me.DiagnosisCode4DataGridViewTextBoxColumn, Me.MouthQuadrantDataGridViewTextBoxColumn, Me.CCEntryNumberDataGridViewTextBoxColumn, Me.ToothNumberDataGridViewTextBoxColumn, Me.CheckNumberDataGridViewTextBoxColumn, Me.DateModifiedDataGridViewTextBoxColumn, Me.DepositIDDataGridViewTextBoxColumn, Me.ThisPaymentDataGridViewTextBoxColumn, Me.LineTotalDataGridViewTextBoxColumn, Me.LineBalanceDataGridViewTextBoxColumn})
        Me.BillingDataGridView.DataSource = Me.MMARTRANSACTIONSBindingSource
        Me.BillingDataGridView.Location = New System.Drawing.Point(5, 33)
        Me.BillingDataGridView.Name = "BillingDataGridView"
        Me.BillingDataGridView.RowHeadersWidth = 25
        Me.BillingDataGridView.Size = New System.Drawing.Size(1192, 509)
        Me.BillingDataGridView.TabIndex = 6
        '
        'MMARTRANSACTIONSBindingSource
        '
        Me.MMARTRANSACTIONSBindingSource.DataMember = "MMARTRANSACTIONS"
        Me.MMARTRANSACTIONSBindingSource.DataSource = Me.ARDataSet
        '
        'BillingTableAdapter
        '
        Me.BillingTableAdapter.ClearBeforeFill = True
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMDataDataSet1BindingSource
        '
        Me.MMDataDataSet1BindingSource.DataSource = Me.MMDataDataSet1
        Me.MMDataDataSet1BindingSource.Position = 0
        '
        'MMARTRANSACTIONSTableAdapter
        '
        Me.MMARTRANSACTIONSTableAdapter.ClearBeforeFill = True
        '
        'chkSelect
        '
        Me.chkSelect.HeaderText = "Select"
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.Width = 50
        '
        'EntryNumberDataGridViewTextBoxColumn
        '
        Me.EntryNumberDataGridViewTextBoxColumn.DataPropertyName = "EntryNumber"
        Me.EntryNumberDataGridViewTextBoxColumn.HeaderText = "EntryNumber"
        Me.EntryNumberDataGridViewTextBoxColumn.Name = "EntryNumberDataGridViewTextBoxColumn"
        Me.EntryNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChartNumber
        '
        Me.ChartNumber.DataPropertyName = "ChartNumber"
        Me.ChartNumber.HeaderText = "ChartNumber"
        Me.ChartNumber.Name = "ChartNumber"
        '
        'CaseNumber
        '
        Me.CaseNumber.DataPropertyName = "CaseNumber"
        Me.CaseNumber.HeaderText = "CaseNumber"
        Me.CaseNumber.Name = "CaseNumber"
        '
        'ClaimNumberDataGridViewTextBoxColumn
        '
        Me.ClaimNumberDataGridViewTextBoxColumn.DataPropertyName = "ClaimNumber"
        Me.ClaimNumberDataGridViewTextBoxColumn.HeaderText = "ClaimNumber"
        Me.ClaimNumberDataGridViewTextBoxColumn.Name = "ClaimNumberDataGridViewTextBoxColumn"
        '
        'DateFromDataGridViewTextBoxColumn
        '
        Me.DateFromDataGridViewTextBoxColumn.DataPropertyName = "DateFrom"
        Me.DateFromDataGridViewTextBoxColumn.HeaderText = "DateFrom"
        Me.DateFromDataGridViewTextBoxColumn.Name = "DateFromDataGridViewTextBoxColumn"
        '
        'DateToDataGridViewTextBoxColumn
        '
        Me.DateToDataGridViewTextBoxColumn.DataPropertyName = "DateTo"
        Me.DateToDataGridViewTextBoxColumn.HeaderText = "DateTo"
        Me.DateToDataGridViewTextBoxColumn.Name = "DateToDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'AttendingProviderDataGridViewTextBoxColumn
        '
        Me.AttendingProviderDataGridViewTextBoxColumn.DataPropertyName = "AttendingProvider"
        Me.AttendingProviderDataGridViewTextBoxColumn.HeaderText = "AttendingProvider"
        Me.AttendingProviderDataGridViewTextBoxColumn.Name = "AttendingProviderDataGridViewTextBoxColumn"
        '
        'ProcedureCodeDataGridViewTextBoxColumn
        '
        Me.ProcedureCodeDataGridViewTextBoxColumn.DataPropertyName = "ProcedureCode"
        Me.ProcedureCodeDataGridViewTextBoxColumn.HeaderText = "ProcedureCode"
        Me.ProcedureCodeDataGridViewTextBoxColumn.Name = "ProcedureCodeDataGridViewTextBoxColumn"
        '
        'TransactionTypeDataGridViewTextBoxColumn
        '
        Me.TransactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType"
        Me.TransactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType"
        Me.TransactionTypeDataGridViewTextBoxColumn.Name = "TransactionTypeDataGridViewTextBoxColumn"
        '
        'InsuranceCategoryDataGridViewTextBoxColumn
        '
        Me.InsuranceCategoryDataGridViewTextBoxColumn.DataPropertyName = "InsuranceCategory"
        Me.InsuranceCategoryDataGridViewTextBoxColumn.HeaderText = "InsuranceCategory"
        Me.InsuranceCategoryDataGridViewTextBoxColumn.Name = "InsuranceCategoryDataGridViewTextBoxColumn"
        '
        'TypeofServiceDataGridViewTextBoxColumn
        '
        Me.TypeofServiceDataGridViewTextBoxColumn.DataPropertyName = "TypeofService"
        Me.TypeofServiceDataGridViewTextBoxColumn.HeaderText = "TypeofService"
        Me.TypeofServiceDataGridViewTextBoxColumn.Name = "TypeofServiceDataGridViewTextBoxColumn"
        '
        'VisitNumberDataGridViewTextBoxColumn
        '
        Me.VisitNumberDataGridViewTextBoxColumn.DataPropertyName = "VisitNumber"
        Me.VisitNumberDataGridViewTextBoxColumn.HeaderText = "VisitNumber"
        Me.VisitNumberDataGridViewTextBoxColumn.Name = "VisitNumberDataGridViewTextBoxColumn"
        '
        'VisitTotalinSeriesDataGridViewTextBoxColumn
        '
        Me.VisitTotalinSeriesDataGridViewTextBoxColumn.DataPropertyName = "VisitTotalinSeries"
        Me.VisitTotalinSeriesDataGridViewTextBoxColumn.HeaderText = "VisitTotalinSeries"
        Me.VisitTotalinSeriesDataGridViewTextBoxColumn.Name = "VisitTotalinSeriesDataGridViewTextBoxColumn"
        '
        'VisitSeriesIDDataGridViewTextBoxColumn
        '
        Me.VisitSeriesIDDataGridViewTextBoxColumn.DataPropertyName = "VisitSeriesID"
        Me.VisitSeriesIDDataGridViewTextBoxColumn.HeaderText = "VisitSeriesID"
        Me.VisitSeriesIDDataGridViewTextBoxColumn.Name = "VisitSeriesIDDataGridViewTextBoxColumn"
        '
        'UnitsDataGridViewTextBoxColumn
        '
        Me.UnitsDataGridViewTextBoxColumn.DataPropertyName = "Units"
        Me.UnitsDataGridViewTextBoxColumn.HeaderText = "Units"
        Me.UnitsDataGridViewTextBoxColumn.Name = "UnitsDataGridViewTextBoxColumn"
        '
        'MinutesDataGridViewTextBoxColumn
        '
        Me.MinutesDataGridViewTextBoxColumn.DataPropertyName = "Minutes"
        Me.MinutesDataGridViewTextBoxColumn.HeaderText = "Minutes"
        Me.MinutesDataGridViewTextBoxColumn.Name = "MinutesDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'PriceIndicatorDataGridViewTextBoxColumn
        '
        Me.PriceIndicatorDataGridViewTextBoxColumn.DataPropertyName = "PriceIndicator"
        Me.PriceIndicatorDataGridViewTextBoxColumn.HeaderText = "PriceIndicator"
        Me.PriceIndicatorDataGridViewTextBoxColumn.Name = "PriceIndicatorDataGridViewTextBoxColumn"
        '
        'Diagnosis1DataGridViewCheckBoxColumn
        '
        Me.Diagnosis1DataGridViewCheckBoxColumn.DataPropertyName = "Diagnosis1"
        Me.Diagnosis1DataGridViewCheckBoxColumn.HeaderText = "Diagnosis1"
        Me.Diagnosis1DataGridViewCheckBoxColumn.Name = "Diagnosis1DataGridViewCheckBoxColumn"
        '
        'Diagnosis2DataGridViewCheckBoxColumn
        '
        Me.Diagnosis2DataGridViewCheckBoxColumn.DataPropertyName = "Diagnosis2"
        Me.Diagnosis2DataGridViewCheckBoxColumn.HeaderText = "Diagnosis2"
        Me.Diagnosis2DataGridViewCheckBoxColumn.Name = "Diagnosis2DataGridViewCheckBoxColumn"
        '
        'Diagnosis3DataGridViewCheckBoxColumn
        '
        Me.Diagnosis3DataGridViewCheckBoxColumn.DataPropertyName = "Diagnosis3"
        Me.Diagnosis3DataGridViewCheckBoxColumn.HeaderText = "Diagnosis3"
        Me.Diagnosis3DataGridViewCheckBoxColumn.Name = "Diagnosis3DataGridViewCheckBoxColumn"
        '
        'Diagnosis4DataGridViewCheckBoxColumn
        '
        Me.Diagnosis4DataGridViewCheckBoxColumn.DataPropertyName = "Diagnosis4"
        Me.Diagnosis4DataGridViewCheckBoxColumn.HeaderText = "Diagnosis4"
        Me.Diagnosis4DataGridViewCheckBoxColumn.Name = "Diagnosis4DataGridViewCheckBoxColumn"
        '
        'ClaimItemRejectedDataGridViewCheckBoxColumn
        '
        Me.ClaimItemRejectedDataGridViewCheckBoxColumn.DataPropertyName = "ClaimItemRejected"
        Me.ClaimItemRejectedDataGridViewCheckBoxColumn.HeaderText = "ClaimItemRejected"
        Me.ClaimItemRejectedDataGridViewCheckBoxColumn.Name = "ClaimItemRejectedDataGridViewCheckBoxColumn"
        '
        'AcceptAssignment1DataGridViewCheckBoxColumn
        '
        Me.AcceptAssignment1DataGridViewCheckBoxColumn.DataPropertyName = "AcceptAssignment1"
        Me.AcceptAssignment1DataGridViewCheckBoxColumn.HeaderText = "AcceptAssignment1"
        Me.AcceptAssignment1DataGridViewCheckBoxColumn.Name = "AcceptAssignment1DataGridViewCheckBoxColumn"
        '
        'AcceptAssignment2DataGridViewCheckBoxColumn
        '
        Me.AcceptAssignment2DataGridViewCheckBoxColumn.DataPropertyName = "AcceptAssignment2"
        Me.AcceptAssignment2DataGridViewCheckBoxColumn.HeaderText = "AcceptAssignment2"
        Me.AcceptAssignment2DataGridViewCheckBoxColumn.Name = "AcceptAssignment2DataGridViewCheckBoxColumn"
        '
        'AcceptAssignment3DataGridViewCheckBoxColumn
        '
        Me.AcceptAssignment3DataGridViewCheckBoxColumn.DataPropertyName = "AcceptAssignment3"
        Me.AcceptAssignment3DataGridViewCheckBoxColumn.HeaderText = "AcceptAssignment3"
        Me.AcceptAssignment3DataGridViewCheckBoxColumn.Name = "AcceptAssignment3DataGridViewCheckBoxColumn"
        '
        'DateCreatedDataGridViewTextBoxColumn
        '
        Me.DateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated"
        Me.DateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated"
        Me.DateCreatedDataGridViewTextBoxColumn.Name = "DateCreatedDataGridViewTextBoxColumn"
        '
        'DateofFirstStatementDataGridViewTextBoxColumn
        '
        Me.DateofFirstStatementDataGridViewTextBoxColumn.DataPropertyName = "DateofFirstStatement"
        Me.DateofFirstStatementDataGridViewTextBoxColumn.HeaderText = "DateofFirstStatement"
        Me.DateofFirstStatementDataGridViewTextBoxColumn.Name = "DateofFirstStatementDataGridViewTextBoxColumn"
        '
        'DateofSecondStatementDataGridViewTextBoxColumn
        '
        Me.DateofSecondStatementDataGridViewTextBoxColumn.DataPropertyName = "DateofSecondStatement"
        Me.DateofSecondStatementDataGridViewTextBoxColumn.HeaderText = "DateofSecondStatement"
        Me.DateofSecondStatementDataGridViewTextBoxColumn.Name = "DateofSecondStatementDataGridViewTextBoxColumn"
        '
        'DateofLastStatementDataGridViewTextBoxColumn
        '
        Me.DateofLastStatementDataGridViewTextBoxColumn.DataPropertyName = "DateofLastStatement"
        Me.DateofLastStatementDataGridViewTextBoxColumn.HeaderText = "DateofLastStatement"
        Me.DateofLastStatementDataGridViewTextBoxColumn.Name = "DateofLastStatementDataGridViewTextBoxColumn"
        '
        'BilledtoInsured1DataGridViewCheckBoxColumn
        '
        Me.BilledtoInsured1DataGridViewCheckBoxColumn.DataPropertyName = "BilledtoInsured1"
        Me.BilledtoInsured1DataGridViewCheckBoxColumn.HeaderText = "BilledtoInsured1"
        Me.BilledtoInsured1DataGridViewCheckBoxColumn.Name = "BilledtoInsured1DataGridViewCheckBoxColumn"
        '
        'BilledtoInsured2DataGridViewCheckBoxColumn
        '
        Me.BilledtoInsured2DataGridViewCheckBoxColumn.DataPropertyName = "BilledtoInsured2"
        Me.BilledtoInsured2DataGridViewCheckBoxColumn.HeaderText = "BilledtoInsured2"
        Me.BilledtoInsured2DataGridViewCheckBoxColumn.Name = "BilledtoInsured2DataGridViewCheckBoxColumn"
        '
        'BilledtoInsured3DataGridViewCheckBoxColumn
        '
        Me.BilledtoInsured3DataGridViewCheckBoxColumn.DataPropertyName = "BilledtoInsured3"
        Me.BilledtoInsured3DataGridViewCheckBoxColumn.HeaderText = "BilledtoInsured3"
        Me.BilledtoInsured3DataGridViewCheckBoxColumn.Name = "BilledtoInsured3DataGridViewCheckBoxColumn"
        '
        'GuarantorPaidDataGridViewCheckBoxColumn
        '
        Me.GuarantorPaidDataGridViewCheckBoxColumn.DataPropertyName = "GuarantorPaid"
        Me.GuarantorPaidDataGridViewCheckBoxColumn.HeaderText = "GuarantorPaid"
        Me.GuarantorPaidDataGridViewCheckBoxColumn.Name = "GuarantorPaidDataGridViewCheckBoxColumn"
        '
        'Insurance1PaidDataGridViewCheckBoxColumn
        '
        Me.Insurance1PaidDataGridViewCheckBoxColumn.DataPropertyName = "Insurance1Paid"
        Me.Insurance1PaidDataGridViewCheckBoxColumn.HeaderText = "Insurance1Paid"
        Me.Insurance1PaidDataGridViewCheckBoxColumn.Name = "Insurance1PaidDataGridViewCheckBoxColumn"
        '
        'Insurance2PaidDataGridViewCheckBoxColumn
        '
        Me.Insurance2PaidDataGridViewCheckBoxColumn.DataPropertyName = "Insurance2Paid"
        Me.Insurance2PaidDataGridViewCheckBoxColumn.HeaderText = "Insurance2Paid"
        Me.Insurance2PaidDataGridViewCheckBoxColumn.Name = "Insurance2PaidDataGridViewCheckBoxColumn"
        '
        'Insurance3PaidDataGridViewCheckBoxColumn
        '
        Me.Insurance3PaidDataGridViewCheckBoxColumn.DataPropertyName = "Insurance3Paid"
        Me.Insurance3PaidDataGridViewCheckBoxColumn.HeaderText = "Insurance3Paid"
        Me.Insurance3PaidDataGridViewCheckBoxColumn.Name = "Insurance3PaidDataGridViewCheckBoxColumn"
        '
        'GuarantorAmountPaidDataGridViewTextBoxColumn
        '
        Me.GuarantorAmountPaidDataGridViewTextBoxColumn.DataPropertyName = "GuarantorAmountPaid"
        Me.GuarantorAmountPaidDataGridViewTextBoxColumn.HeaderText = "GuarantorAmountPaid"
        Me.GuarantorAmountPaidDataGridViewTextBoxColumn.Name = "GuarantorAmountPaidDataGridViewTextBoxColumn"
        '
        'Insurance1AmountPaidDataGridViewTextBoxColumn
        '
        Me.Insurance1AmountPaidDataGridViewTextBoxColumn.DataPropertyName = "Insurance1AmountPaid"
        Me.Insurance1AmountPaidDataGridViewTextBoxColumn.HeaderText = "Insurance1AmountPaid"
        Me.Insurance1AmountPaidDataGridViewTextBoxColumn.Name = "Insurance1AmountPaidDataGridViewTextBoxColumn"
        '
        'Insurance2AmountPaidDataGridViewTextBoxColumn
        '
        Me.Insurance2AmountPaidDataGridViewTextBoxColumn.DataPropertyName = "Insurance2AmountPaid"
        Me.Insurance2AmountPaidDataGridViewTextBoxColumn.HeaderText = "Insurance2AmountPaid"
        Me.Insurance2AmountPaidDataGridViewTextBoxColumn.Name = "Insurance2AmountPaidDataGridViewTextBoxColumn"
        '
        'Insurance3AmountPaidDataGridViewTextBoxColumn
        '
        Me.Insurance3AmountPaidDataGridViewTextBoxColumn.DataPropertyName = "Insurance3AmountPaid"
        Me.Insurance3AmountPaidDataGridViewTextBoxColumn.HeaderText = "Insurance3AmountPaid"
        Me.Insurance3AmountPaidDataGridViewTextBoxColumn.Name = "Insurance3AmountPaidDataGridViewTextBoxColumn"
        '
        'GuarantorResponsibleDataGridViewCheckBoxColumn
        '
        Me.GuarantorResponsibleDataGridViewCheckBoxColumn.DataPropertyName = "GuarantorResponsible"
        Me.GuarantorResponsibleDataGridViewCheckBoxColumn.HeaderText = "GuarantorResponsible"
        Me.GuarantorResponsibleDataGridViewCheckBoxColumn.Name = "GuarantorResponsibleDataGridViewCheckBoxColumn"
        '
        'Insurance1ResponsibleDataGridViewCheckBoxColumn
        '
        Me.Insurance1ResponsibleDataGridViewCheckBoxColumn.DataPropertyName = "Insurance1Responsible"
        Me.Insurance1ResponsibleDataGridViewCheckBoxColumn.HeaderText = "Insurance1Responsible"
        Me.Insurance1ResponsibleDataGridViewCheckBoxColumn.Name = "Insurance1ResponsibleDataGridViewCheckBoxColumn"
        '
        'Insurance2ResponsibleDataGridViewCheckBoxColumn
        '
        Me.Insurance2ResponsibleDataGridViewCheckBoxColumn.DataPropertyName = "Insurance2Responsible"
        Me.Insurance2ResponsibleDataGridViewCheckBoxColumn.HeaderText = "Insurance2Responsible"
        Me.Insurance2ResponsibleDataGridViewCheckBoxColumn.Name = "Insurance2ResponsibleDataGridViewCheckBoxColumn"
        '
        'Insurance3ResponsibleDataGridViewCheckBoxColumn
        '
        Me.Insurance3ResponsibleDataGridViewCheckBoxColumn.DataPropertyName = "Insurance3Responsible"
        Me.Insurance3ResponsibleDataGridViewCheckBoxColumn.HeaderText = "Insurance3Responsible"
        Me.Insurance3ResponsibleDataGridViewCheckBoxColumn.Name = "Insurance3ResponsibleDataGridViewCheckBoxColumn"
        '
        'WhoPaidDataGridViewTextBoxColumn
        '
        Me.WhoPaidDataGridViewTextBoxColumn.DataPropertyName = "WhoPaid"
        Me.WhoPaidDataGridViewTextBoxColumn.HeaderText = "WhoPaid"
        Me.WhoPaidDataGridViewTextBoxColumn.Name = "WhoPaidDataGridViewTextBoxColumn"
        '
        'DocumentationTypeDataGridViewTextBoxColumn
        '
        Me.DocumentationTypeDataGridViewTextBoxColumn.DataPropertyName = "DocumentationType"
        Me.DocumentationTypeDataGridViewTextBoxColumn.HeaderText = "DocumentationType"
        Me.DocumentationTypeDataGridViewTextBoxColumn.Name = "DocumentationTypeDataGridViewTextBoxColumn"
        '
        'DocumentationDataGridViewTextBoxColumn
        '
        Me.DocumentationDataGridViewTextBoxColumn.DataPropertyName = "Documentation"
        Me.DocumentationDataGridViewTextBoxColumn.HeaderText = "Documentation"
        Me.DocumentationDataGridViewTextBoxColumn.Name = "DocumentationDataGridViewTextBoxColumn"
        '
        'AttorneyPaidDataGridViewCheckBoxColumn
        '
        Me.AttorneyPaidDataGridViewCheckBoxColumn.DataPropertyName = "AttorneyPaid"
        Me.AttorneyPaidDataGridViewCheckBoxColumn.HeaderText = "AttorneyPaid"
        Me.AttorneyPaidDataGridViewCheckBoxColumn.Name = "AttorneyPaidDataGridViewCheckBoxColumn"
        '
        'AttorneyAmountPaidDataGridViewTextBoxColumn
        '
        Me.AttorneyAmountPaidDataGridViewTextBoxColumn.DataPropertyName = "AttorneyAmountPaid"
        Me.AttorneyAmountPaidDataGridViewTextBoxColumn.HeaderText = "AttorneyAmountPaid"
        Me.AttorneyAmountPaidDataGridViewTextBoxColumn.Name = "AttorneyAmountPaidDataGridViewTextBoxColumn"
        '
        'AttorneyResponsibleDataGridViewCheckBoxColumn
        '
        Me.AttorneyResponsibleDataGridViewCheckBoxColumn.DataPropertyName = "AttorneyResponsible"
        Me.AttorneyResponsibleDataGridViewCheckBoxColumn.HeaderText = "AttorneyResponsible"
        Me.AttorneyResponsibleDataGridViewCheckBoxColumn.Name = "AttorneyResponsibleDataGridViewCheckBoxColumn"
        '
        'AdjustmentAmountDataGridViewTextBoxColumn
        '
        Me.AdjustmentAmountDataGridViewTextBoxColumn.DataPropertyName = "AdjustmentAmount"
        Me.AdjustmentAmountDataGridViewTextBoxColumn.HeaderText = "AdjustmentAmount"
        Me.AdjustmentAmountDataGridViewTextBoxColumn.Name = "AdjustmentAmountDataGridViewTextBoxColumn"
        '
        'UserCodeDataGridViewTextBoxColumn
        '
        Me.UserCodeDataGridViewTextBoxColumn.DataPropertyName = "UserCode"
        Me.UserCodeDataGridViewTextBoxColumn.HeaderText = "UserCode"
        Me.UserCodeDataGridViewTextBoxColumn.Name = "UserCodeDataGridViewTextBoxColumn"
        '
        'AllowedAmountDataGridViewTextBoxColumn
        '
        Me.AllowedAmountDataGridViewTextBoxColumn.DataPropertyName = "AllowedAmount"
        Me.AllowedAmountDataGridViewTextBoxColumn.HeaderText = "AllowedAmount"
        Me.AllowedAmountDataGridViewTextBoxColumn.Name = "AllowedAmountDataGridViewTextBoxColumn"
        '
        'DiagnosisCode1DataGridViewTextBoxColumn
        '
        Me.DiagnosisCode1DataGridViewTextBoxColumn.DataPropertyName = "DiagnosisCode1"
        Me.DiagnosisCode1DataGridViewTextBoxColumn.HeaderText = "DiagnosisCode1"
        Me.DiagnosisCode1DataGridViewTextBoxColumn.Name = "DiagnosisCode1DataGridViewTextBoxColumn"
        '
        'DiagnosisCode2DataGridViewTextBoxColumn
        '
        Me.DiagnosisCode2DataGridViewTextBoxColumn.DataPropertyName = "DiagnosisCode2"
        Me.DiagnosisCode2DataGridViewTextBoxColumn.HeaderText = "DiagnosisCode2"
        Me.DiagnosisCode2DataGridViewTextBoxColumn.Name = "DiagnosisCode2DataGridViewTextBoxColumn"
        '
        'DiagnosisCode3DataGridViewTextBoxColumn
        '
        Me.DiagnosisCode3DataGridViewTextBoxColumn.DataPropertyName = "DiagnosisCode3"
        Me.DiagnosisCode3DataGridViewTextBoxColumn.HeaderText = "DiagnosisCode3"
        Me.DiagnosisCode3DataGridViewTextBoxColumn.Name = "DiagnosisCode3DataGridViewTextBoxColumn"
        '
        'DiagnosisCode4DataGridViewTextBoxColumn
        '
        Me.DiagnosisCode4DataGridViewTextBoxColumn.DataPropertyName = "DiagnosisCode4"
        Me.DiagnosisCode4DataGridViewTextBoxColumn.HeaderText = "DiagnosisCode4"
        Me.DiagnosisCode4DataGridViewTextBoxColumn.Name = "DiagnosisCode4DataGridViewTextBoxColumn"
        '
        'MouthQuadrantDataGridViewTextBoxColumn
        '
        Me.MouthQuadrantDataGridViewTextBoxColumn.DataPropertyName = "MouthQuadrant"
        Me.MouthQuadrantDataGridViewTextBoxColumn.HeaderText = "MouthQuadrant"
        Me.MouthQuadrantDataGridViewTextBoxColumn.Name = "MouthQuadrantDataGridViewTextBoxColumn"
        '
        'CCEntryNumberDataGridViewTextBoxColumn
        '
        Me.CCEntryNumberDataGridViewTextBoxColumn.DataPropertyName = "CCEntryNumber"
        Me.CCEntryNumberDataGridViewTextBoxColumn.HeaderText = "CCEntryNumber"
        Me.CCEntryNumberDataGridViewTextBoxColumn.Name = "CCEntryNumberDataGridViewTextBoxColumn"
        '
        'ToothNumberDataGridViewTextBoxColumn
        '
        Me.ToothNumberDataGridViewTextBoxColumn.DataPropertyName = "ToothNumber"
        Me.ToothNumberDataGridViewTextBoxColumn.HeaderText = "ToothNumber"
        Me.ToothNumberDataGridViewTextBoxColumn.Name = "ToothNumberDataGridViewTextBoxColumn"
        '
        'CheckNumberDataGridViewTextBoxColumn
        '
        Me.CheckNumberDataGridViewTextBoxColumn.DataPropertyName = "CheckNumber"
        Me.CheckNumberDataGridViewTextBoxColumn.HeaderText = "CheckNumber"
        Me.CheckNumberDataGridViewTextBoxColumn.Name = "CheckNumberDataGridViewTextBoxColumn"
        '
        'DateModifiedDataGridViewTextBoxColumn
        '
        Me.DateModifiedDataGridViewTextBoxColumn.DataPropertyName = "DateModified"
        Me.DateModifiedDataGridViewTextBoxColumn.HeaderText = "DateModified"
        Me.DateModifiedDataGridViewTextBoxColumn.Name = "DateModifiedDataGridViewTextBoxColumn"
        '
        'DepositIDDataGridViewTextBoxColumn
        '
        Me.DepositIDDataGridViewTextBoxColumn.DataPropertyName = "DepositID"
        Me.DepositIDDataGridViewTextBoxColumn.HeaderText = "DepositID"
        Me.DepositIDDataGridViewTextBoxColumn.Name = "DepositIDDataGridViewTextBoxColumn"
        '
        'ThisPaymentDataGridViewTextBoxColumn
        '
        Me.ThisPaymentDataGridViewTextBoxColumn.DataPropertyName = "ThisPayment"
        Me.ThisPaymentDataGridViewTextBoxColumn.HeaderText = "ThisPayment"
        Me.ThisPaymentDataGridViewTextBoxColumn.Name = "ThisPaymentDataGridViewTextBoxColumn"
        '
        'LineTotalDataGridViewTextBoxColumn
        '
        Me.LineTotalDataGridViewTextBoxColumn.DataPropertyName = "LineTotal"
        Me.LineTotalDataGridViewTextBoxColumn.HeaderText = "LineTotal"
        Me.LineTotalDataGridViewTextBoxColumn.Name = "LineTotalDataGridViewTextBoxColumn"
        '
        'LineBalanceDataGridViewTextBoxColumn
        '
        Me.LineBalanceDataGridViewTextBoxColumn.DataPropertyName = "LineBalance"
        Me.LineBalanceDataGridViewTextBoxColumn.HeaderText = "LineBalance"
        Me.LineBalanceDataGridViewTextBoxColumn.Name = "LineBalanceDataGridViewTextBoxColumn"
        '
        'PrintMultipleBills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 554)
        Me.Controls.Add(Me.BillingDataGridView)
        Me.Controls.Add(Me.cboInstalledPrinters)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.BillingBindingNavigator)
        Me.Name = "PrintMultipleBills"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintMultipleBills"
        CType(Me.BillingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BillingBindingNavigator.ResumeLayout(False)
        Me.BillingBindingNavigator.PerformLayout()
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARTRANSACTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Param1ToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Param1ToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Param2ToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Param2ToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBillByChNoCaseNoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboInstalledPrinters As System.Windows.Forms.ComboBox
    Friend WithEvents ARDataSet As MedicalManager.ARDataSet
    Friend WithEvents BillingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillingTableAdapter As MedicalManager.ARDataSetTableAdapters.BillingTableAdapter
    Friend WithEvents BillingBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BillingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BillingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MMDataDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMARTRANSACTIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMARTRANSACTIONSTableAdapter As MedicalManager.ARDataSetTableAdapters.MMARTRANSACTIONSTableAdapter
    Friend WithEvents chkSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EntryNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChartNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaimNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateToDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttendingProviderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcedureCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsuranceCategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeofServiceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitTotalinSeriesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitSeriesIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MinutesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceIndicatorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diagnosis1DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Diagnosis2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Diagnosis3DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Diagnosis4DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClaimItemRejectedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AcceptAssignment1DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AcceptAssignment2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AcceptAssignment3DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DateCreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofFirstStatementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofSecondStatementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofLastStatementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BilledtoInsured1DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BilledtoInsured2DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BilledtoInsured3DataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GuarantorPaidDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Insurance1PaidDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Insurance2PaidDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Insurance3PaidDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GuarantorAmountPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insurance1AmountPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insurance2AmountPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insurance3AmountPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuarantorResponsibleDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Insurance1ResponsibleDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Insurance2ResponsibleDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Insurance3ResponsibleDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhoPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentationTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttorneyPaidDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AttorneyAmountPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttorneyResponsibleDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AdjustmentAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllowedAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiagnosisCode1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiagnosisCode2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiagnosisCode3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiagnosisCode4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MouthQuadrantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCEntryNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToothNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateModifiedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepositIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ThisPaymentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineBalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
