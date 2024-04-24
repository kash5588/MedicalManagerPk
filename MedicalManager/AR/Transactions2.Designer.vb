<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions2
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
        Dim ChartNumberLabel As System.Windows.Forms.Label
        Dim CaseNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transactions2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox
        Me.MMARCASEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARDataSet = New MedicalManager.ARDataSet
        Me.CaseNumberTextBox = New System.Windows.Forms.TextBox
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MMARCASEBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.CaseSaveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.txtFind = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chkKeepPayorCheckNo = New System.Windows.Forms.CheckBox
        Me.txtPayorName = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCheckNumber = New System.Windows.Forms.TextBox
        Me.btnSaveTrans = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTotalBalance = New System.Windows.Forms.TextBox
        Me.txtTotalPayments = New System.Windows.Forms.TextBox
        Me.txtTotalAmount = New System.Windows.Forms.TextBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox
        Me.cmbWhoPaid = New System.Windows.Forms.ComboBox
        Me.btnApplyCharges = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.MMARCASEDataGridView = New System.Windows.Forms.DataGridView
        Me.DateCreated = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MiddleInitial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DOB = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Deductible = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn148 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMARTRANSACTIONSDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.MMPRocedureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AllowedAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DeductibleAndOther = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ServicesNotCovered = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuarantorAmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CopayAmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Insurance1AmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Insurance2AmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Insurance3AmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AdjustmentAmount = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AttorneyAmountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaymentReceived = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LineTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LineBalance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillingStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntryNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn10 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn11 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GuarantorPaid = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Insurance1Paid = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Insurance2Paid = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Insurance3Paid = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn16 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn17 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn18 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn19 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AttorneyPaid = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn21 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn81 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMARTRANSACTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnSavePostPymnt = New System.Windows.Forms.Button
        Me.btnSaveDeposit = New System.Windows.Forms.Button
        Me.MMARDepositDataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn12 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.MMARDepositBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMARPostPaymentDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMARPostPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.MMARTRANSACTIONSDataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn85 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn102 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.MMDXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn103 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn104 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn105 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMPRocedureDataGridView = New System.Windows.Forms.DataGridView
        Me.Code1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AmountA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProcedureDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMINSURENCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.MMINSURENCEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet = New MedicalManager.MMDataDataSet
        Me.PaymentReference = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMDataDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMComboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMComboTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMComboTableAdapter
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DepositDate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PayorType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaymentMethod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaymentAmountDeposit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Copay = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMINSURENCETableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMINSURENCETableAdapter
        Me.MMDataDataSet1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMARCASETableAdapter = New MedicalManager.ARDataSetTableAdapters.MMARCASETableAdapter
        Me.MMARTRANSACTIONSTableAdapter = New MedicalManager.ARDataSetTableAdapters.MMARTRANSACTIONSTableAdapter
        Me.MMARDepositTableAdapter = New MedicalManager.ARDataSetTableAdapters.MMARDepositTableAdapter
        Me.MMPRocedureTableAdapter = New MedicalManager.ARDataSetTableAdapters.MMPRocedureTableAdapter
        Me.MMDXTableAdapter = New MedicalManager.ARDataSetTableAdapters.MMDXTableAdapter
        Me.MMARPostPaymentTableAdapter = New MedicalManager.ARDataSetTableAdapters.MMARPostPaymentTableAdapter
        ChartNumberLabel = New System.Windows.Forms.Label
        CaseNumberLabel = New System.Windows.Forms.Label
        CType(Me.MMARCASEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARCASEBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMARCASEBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MMARCASEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARTRANSACTIONSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPRocedureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARTRANSACTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMARDepositDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARDepositBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARPostPaymentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARPostPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.MMARTRANSACTIONSDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPRocedureDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMINSURENCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMINSURENCEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMComboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartNumberLabel
        '
        ChartNumberLabel.AutoSize = True
        ChartNumberLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        ChartNumberLabel.Location = New System.Drawing.Point(735, 0)
        ChartNumberLabel.Name = "ChartNumberLabel"
        ChartNumberLabel.Size = New System.Drawing.Size(49, 13)
        ChartNumberLabel.TabIndex = 1
        ChartNumberLabel.Text = "Chart No"
        '
        'CaseNumberLabel
        '
        CaseNumberLabel.AutoSize = True
        CaseNumberLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        CaseNumberLabel.Location = New System.Drawing.Point(879, 0)
        CaseNumberLabel.Name = "CaseNumberLabel"
        CaseNumberLabel.Size = New System.Drawing.Size(48, 13)
        CaseNumberLabel.TabIndex = 3
        CaseNumberLabel.Text = "Case No"
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ChartNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMARCASEBindingSource, "ChartNumber", True))
        Me.ChartNumberTextBox.Enabled = False
        Me.ChartNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(790, 0)
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(83, 13)
        Me.ChartNumberTextBox.TabIndex = 2
        '
        'MMARCASEBindingSource
        '
        Me.MMARCASEBindingSource.DataMember = "MMARCASE"
        Me.MMARCASEBindingSource.DataSource = Me.ARDataSet
        '
        'ARDataSet
        '
        Me.ARDataSet.DataSetName = "ARDataSet"
        Me.ARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaseNumberTextBox
        '
        Me.CaseNumberTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CaseNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CaseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMARCASEBindingSource, "CaseNumber", True))
        Me.CaseNumberTextBox.Enabled = False
        Me.CaseNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaseNumberTextBox.Location = New System.Drawing.Point(933, 0)
        Me.CaseNumberTextBox.Name = "CaseNumberTextBox"
        Me.CaseNumberTextBox.Size = New System.Drawing.Size(79, 13)
        Me.CaseNumberTextBox.TabIndex = 4
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'MMARCASEBindingNavigator
        '
        Me.MMARCASEBindingNavigator.AddNewItem = Nothing
        Me.MMARCASEBindingNavigator.BindingSource = Me.MMARCASEBindingSource
        Me.MMARCASEBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMARCASEBindingNavigator.DeleteItem = Nothing
        Me.MMARCASEBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1, Me.CaseSaveToolStripButton, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.txtFind, Me.ToolStripLabel3, Me.cmbFilter})
        Me.MMARCASEBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMARCASEBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMARCASEBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMARCASEBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMARCASEBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMARCASEBindingNavigator.Name = "MMARCASEBindingNavigator"
        Me.MMARCASEBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMARCASEBindingNavigator.Size = New System.Drawing.Size(1121, 25)
        Me.MMARCASEBindingNavigator.TabIndex = 0
        Me.MMARCASEBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripLabel1.Text = "Save Case"
        '
        'CaseSaveToolStripButton
        '
        Me.CaseSaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CaseSaveToolStripButton.Image = CType(resources.GetObject("CaseSaveToolStripButton.Image"), System.Drawing.Image)
        Me.CaseSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CaseSaveToolStripButton.Name = "CaseSaveToolStripButton"
        Me.CaseSaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CaseSaveToolStripButton.Text = "&Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(104, 22)
        Me.ToolStripButton1.Text = "View Bill (Complete)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripButton2.Text = "View Bill"
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
        Me.txtFind.Size = New System.Drawing.Size(50, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel3.Text = "Criteria"
        '
        'cmbFilter
        '
        Me.cmbFilter.Items.AddRange(New Object() {"ChartNumber", "LastName", "FirstName"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(100, 25)
        Me.cmbFilter.Text = "ChartNumber"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1119, 499)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.chkKeepPayorCheckNo)
        Me.TabPage1.Controls.Add(Me.txtPayorName)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtCheckNumber)
        Me.TabPage1.Controls.Add(Me.btnSaveTrans)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtTotalBalance)
        Me.TabPage1.Controls.Add(Me.txtTotalPayments)
        Me.TabPage1.Controls.Add(Me.txtTotalAmount)
        Me.TabPage1.Controls.Add(Me.txtBalance)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtTotal)
        Me.TabPage1.Controls.Add(Me.cmbPaymentType)
        Me.TabPage1.Controls.Add(Me.cmbWhoPaid)
        Me.TabPage1.Controls.Add(Me.btnApplyCharges)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.MMARCASEDataGridView)
        Me.TabPage1.Controls.Add(Me.MMARTRANSACTIONSDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1111, 473)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transactions"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkKeepPayorCheckNo
        '
        Me.chkKeepPayorCheckNo.AutoSize = True
        Me.chkKeepPayorCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkKeepPayorCheckNo.ForeColor = System.Drawing.Color.DarkRed
        Me.chkKeepPayorCheckNo.Location = New System.Drawing.Point(133, 206)
        Me.chkKeepPayorCheckNo.Name = "chkKeepPayorCheckNo"
        Me.chkKeepPayorCheckNo.Size = New System.Drawing.Size(299, 17)
        Me.chkKeepPayorCheckNo.TabIndex = 42
        Me.chkKeepPayorCheckNo.Text = "Keep Payor and Check # For More Transactions"
        Me.chkKeepPayorCheckNo.UseVisualStyleBackColor = True
        '
        'txtPayorName
        '
        Me.txtPayorName.FormattingEnabled = True
        Me.txtPayorName.Location = New System.Drawing.Point(133, 237)
        Me.txtPayorName.MaxDropDownItems = 15
        Me.txtPayorName.MaxLength = 50
        Me.txtPayorName.Name = "txtPayorName"
        Me.txtPayorName.Size = New System.Drawing.Size(259, 21)
        Me.txtPayorName.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Payment Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(7, 237)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Payor Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(395, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Check Number"
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.Location = New System.Drawing.Point(398, 237)
        Me.txtCheckNumber.MaxLength = 20
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.Size = New System.Drawing.Size(135, 20)
        Me.txtCheckNumber.TabIndex = 2
        '
        'btnSaveTrans
        '
        Me.btnSaveTrans.Location = New System.Drawing.Point(811, 425)
        Me.btnSaveTrans.Name = "btnSaveTrans"
        Me.btnSaveTrans.Size = New System.Drawing.Size(94, 23)
        Me.btnSaveTrans.TabIndex = 34
        Me.btnSaveTrans.Text = "Save"
        Me.btnSaveTrans.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 426)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Total Balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 426)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Total Payments"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Total Amount"
        '
        'txtTotalBalance
        '
        Me.txtTotalBalance.Location = New System.Drawing.Point(239, 440)
        Me.txtTotalBalance.MaxLength = 20
        Me.txtTotalBalance.Name = "txtTotalBalance"
        Me.txtTotalBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalBalance.TabIndex = 30
        Me.txtTotalBalance.Text = "0"
        Me.txtTotalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPayments
        '
        Me.txtTotalPayments.Location = New System.Drawing.Point(123, 440)
        Me.txtTotalPayments.MaxLength = 20
        Me.txtTotalPayments.Name = "txtTotalPayments"
        Me.txtTotalPayments.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPayments.TabIndex = 29
        Me.txtTotalPayments.Text = "0"
        Me.txtTotalPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(6, 440)
        Me.txtTotalAmount.MaxLength = 20
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAmount.TabIndex = 28
        Me.txtTotalAmount.Text = "0"
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBalance
        '
        Me.txtBalance.Enabled = False
        Me.txtBalance.Location = New System.Drawing.Point(890, 237)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(99, 20)
        Me.txtBalance.TabIndex = 6
        Me.txtBalance.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(888, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Balance to Distribute"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(776, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Amnt Received Today"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(663, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Method of Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(536, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Who Paid"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(779, 237)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(103, 20)
        Me.txtTotal.TabIndex = 5
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Location = New System.Drawing.Point(666, 237)
        Me.cmbPaymentType.MaxLength = 11
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(104, 21)
        Me.cmbPaymentType.TabIndex = 4
        '
        'cmbWhoPaid
        '
        Me.cmbWhoPaid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbWhoPaid.FormattingEnabled = True
        Me.cmbWhoPaid.Location = New System.Drawing.Point(539, 237)
        Me.cmbWhoPaid.Name = "cmbWhoPaid"
        Me.cmbWhoPaid.Size = New System.Drawing.Size(121, 21)
        Me.cmbWhoPaid.TabIndex = 3
        '
        'btnApplyCharges
        '
        Me.btnApplyCharges.Location = New System.Drawing.Point(1011, 425)
        Me.btnApplyCharges.Name = "btnApplyCharges"
        Me.btnApplyCharges.Size = New System.Drawing.Size(94, 23)
        Me.btnApplyCharges.TabIndex = 7
        Me.btnApplyCharges.Text = "Apply Charges"
        Me.btnApplyCharges.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(911, 425)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 23)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add Transaction"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'MMARCASEDataGridView
        '
        Me.MMARCASEDataGridView.AllowUserToAddRows = False
        Me.MMARCASEDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMARCASEDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MMARCASEDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateCreated, Me.DataGridViewTextBoxColumn53, Me.FirstName, Me.LastName, Me.MiddleInitial, Me.DOB, Me.DataGridViewTextBoxColumn52, Me.Deductible, Me.DataGridViewTextBoxColumn82, Me.DataGridViewTextBoxColumn148})
        Me.MMARCASEDataGridView.DataSource = Me.MMARCASEBindingSource
        Me.MMARCASEDataGridView.Location = New System.Drawing.Point(3, 6)
        Me.MMARCASEDataGridView.Name = "MMARCASEDataGridView"
        Me.MMARCASEDataGridView.Size = New System.Drawing.Size(1102, 199)
        Me.MMARCASEDataGridView.TabIndex = 16
        '
        'DateCreated
        '
        Me.DateCreated.DataPropertyName = "DateCreated"
        Me.DateCreated.HeaderText = "DOS"
        Me.DateCreated.Name = "DateCreated"
        Me.DateCreated.ReadOnly = True
        Me.DateCreated.Width = 75
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Chart No"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        Me.DataGridViewTextBoxColumn53.Width = 65
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'MiddleInitial
        '
        Me.MiddleInitial.DataPropertyName = "MiddleInitial"
        Me.MiddleInitial.HeaderText = "MI"
        Me.MiddleInitial.Name = "MiddleInitial"
        Me.MiddleInitial.ReadOnly = True
        Me.MiddleInitial.Width = 25
        '
        'DOB
        '
        Me.DOB.DataPropertyName = "DOB"
        Me.DOB.HeaderText = "DOB"
        Me.DOB.Name = "DOB"
        Me.DOB.ReadOnly = True
        Me.DOB.Width = 60
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "Copay"
        Me.DataGridViewTextBoxColumn52.HeaderText = "Copay"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.Width = 50
        '
        'Deductible
        '
        Me.Deductible.DataPropertyName = "Deductible"
        Me.Deductible.HeaderText = "Deductible"
        Me.Deductible.Name = "Deductible"
        Me.Deductible.Width = 52
        '
        'DataGridViewTextBoxColumn82
        '
        Me.DataGridViewTextBoxColumn82.DataPropertyName = "CaseNumber"
        Me.DataGridViewTextBoxColumn82.HeaderText = "Case No"
        Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
        Me.DataGridViewTextBoxColumn82.ReadOnly = True
        Me.DataGridViewTextBoxColumn82.Width = 57
        '
        'DataGridViewTextBoxColumn148
        '
        Me.DataGridViewTextBoxColumn148.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn148.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn148.Name = "DataGridViewTextBoxColumn148"
        Me.DataGridViewTextBoxColumn148.Width = 475
        '
        'MMARTRANSACTIONSDataGridView
        '
        Me.MMARTRANSACTIONSDataGridView.AllowUserToAddRows = False
        Me.MMARTRANSACTIONSDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMARTRANSACTIONSDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MMARTRANSACTIONSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn10, Me.Amount, Me.AllowedAmount, Me.DeductibleAndOther, Me.ServicesNotCovered, Me.Description, Me.GuarantorAmountPaid, Me.CopayAmountPaid, Me.Insurance1AmountPaid, Me.Insurance2AmountPaid, Me.Insurance3AmountPaid, Me.AdjustmentAmount, Me.AttorneyAmountPaid, Me.PaymentReceived, Me.LineTotal, Me.LineBalance, Me.BillingStatus, Me.DataGridViewTextBoxColumn1, Me.EntryNumber, Me.Type, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewCheckBoxColumn8, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn35, Me.DataGridViewCheckBoxColumn9, Me.DataGridViewCheckBoxColumn10, Me.DataGridViewCheckBoxColumn11, Me.GuarantorPaid, Me.Insurance1Paid, Me.Insurance2Paid, Me.Insurance3Paid, Me.DataGridViewCheckBoxColumn16, Me.DataGridViewCheckBoxColumn17, Me.DataGridViewCheckBoxColumn18, Me.DataGridViewCheckBoxColumn19, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn39, Me.AttorneyPaid, Me.DataGridViewCheckBoxColumn21, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn81})
        Me.MMARTRANSACTIONSDataGridView.DataSource = Me.MMARTRANSACTIONSBindingSource
        Me.MMARTRANSACTIONSDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.MMARTRANSACTIONSDataGridView.Location = New System.Drawing.Point(0, 260)
        Me.MMARTRANSACTIONSDataGridView.Name = "MMARTRANSACTIONSDataGridView"
        Me.MMARTRANSACTIONSDataGridView.RowHeadersWidth = 20
        Me.MMARTRANSACTIONSDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.MMARTRANSACTIONSDataGridView.Size = New System.Drawing.Size(1105, 159)
        Me.MMARTRANSACTIONSDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateFrom"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 62
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ProcedureCode"
        Me.DataGridViewTextBoxColumn10.DataSource = Me.MMPRocedureBindingSource
        Me.DataGridViewTextBoxColumn10.DisplayMember = "Code1"
        Me.DataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn10.HeaderText = "Pr Code"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.Width = 60
        '
        'MMPRocedureBindingSource
        '
        Me.MMPRocedureBindingSource.DataMember = "MMPRocedure"
        Me.MMPRocedureBindingSource.DataSource = Me.ARDataSet
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        Me.Amount.FillWeight = 75.0!
        Me.Amount.HeaderText = "Amnt"
        Me.Amount.Name = "Amount"
        Me.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Amount.Width = 50
        '
        'AllowedAmount
        '
        Me.AllowedAmount.DataPropertyName = "AllowedAmount"
        Me.AllowedAmount.HeaderText = "Allowed"
        Me.AllowedAmount.Name = "AllowedAmount"
        Me.AllowedAmount.Width = 45
        '
        'DeductibleAndOther
        '
        Me.DeductibleAndOther.DataPropertyName = "DeductibleAndOther"
        Me.DeductibleAndOther.HeaderText = "DED/OTHR"
        Me.DeductibleAndOther.Name = "DeductibleAndOther"
        Me.DeductibleAndOther.Width = 62
        '
        'ServicesNotCovered
        '
        Me.ServicesNotCovered.DataPropertyName = "ServicesNotCovered"
        Me.ServicesNotCovered.HeaderText = "SNC"
        Me.ServicesNotCovered.Name = "ServicesNotCovered"
        Me.ServicesNotCovered.Width = 40
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Desc"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 50
        '
        'GuarantorAmountPaid
        '
        Me.GuarantorAmountPaid.DataPropertyName = "GuarantorAmountPaid"
        Me.GuarantorAmountPaid.HeaderText = "SelfPaid"
        Me.GuarantorAmountPaid.Name = "GuarantorAmountPaid"
        Me.GuarantorAmountPaid.ReadOnly = True
        Me.GuarantorAmountPaid.Width = 55
        '
        'CopayAmountPaid
        '
        Me.CopayAmountPaid.DataPropertyName = "CopayAmountPaid"
        Me.CopayAmountPaid.HeaderText = "Copay"
        Me.CopayAmountPaid.Name = "CopayAmountPaid"
        Me.CopayAmountPaid.ReadOnly = True
        Me.CopayAmountPaid.Width = 55
        '
        'Insurance1AmountPaid
        '
        Me.Insurance1AmountPaid.DataPropertyName = "Insurance1AmountPaid"
        Me.Insurance1AmountPaid.HeaderText = "Ins1Paid"
        Me.Insurance1AmountPaid.Name = "Insurance1AmountPaid"
        Me.Insurance1AmountPaid.ReadOnly = True
        Me.Insurance1AmountPaid.Width = 55
        '
        'Insurance2AmountPaid
        '
        Me.Insurance2AmountPaid.DataPropertyName = "Insurance2AmountPaid"
        Me.Insurance2AmountPaid.HeaderText = "Ins2Paid"
        Me.Insurance2AmountPaid.Name = "Insurance2AmountPaid"
        Me.Insurance2AmountPaid.ReadOnly = True
        Me.Insurance2AmountPaid.Width = 55
        '
        'Insurance3AmountPaid
        '
        Me.Insurance3AmountPaid.DataPropertyName = "Insurance3AmountPaid"
        Me.Insurance3AmountPaid.HeaderText = "Ins3Paid"
        Me.Insurance3AmountPaid.Name = "Insurance3AmountPaid"
        Me.Insurance3AmountPaid.ReadOnly = True
        Me.Insurance3AmountPaid.Width = 55
        '
        'AdjustmentAmount
        '
        Me.AdjustmentAmount.DataPropertyName = "AdjustmentAmount"
        Me.AdjustmentAmount.HeaderText = "WriteOff"
        Me.AdjustmentAmount.Name = "AdjustmentAmount"
        Me.AdjustmentAmount.ReadOnly = True
        Me.AdjustmentAmount.Width = 55
        '
        'AttorneyAmountPaid
        '
        Me.AttorneyAmountPaid.DataPropertyName = "AttorneyAmountPaid"
        Me.AttorneyAmountPaid.HeaderText = "AttrnPaid"
        Me.AttorneyAmountPaid.Name = "AttorneyAmountPaid"
        Me.AttorneyAmountPaid.ReadOnly = True
        Me.AttorneyAmountPaid.Width = 55
        '
        'PaymentReceived
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        Me.PaymentReceived.DefaultCellStyle = DataGridViewCellStyle3
        Me.PaymentReceived.HeaderText = "Received"
        Me.PaymentReceived.Name = "PaymentReceived"
        Me.PaymentReceived.Width = 57
        '
        'LineTotal
        '
        Me.LineTotal.DataPropertyName = "LineTotal"
        Me.LineTotal.HeaderText = "LineTotal"
        Me.LineTotal.Name = "LineTotal"
        Me.LineTotal.ReadOnly = True
        Me.LineTotal.Width = 57
        '
        'LineBalance
        '
        Me.LineBalance.DataPropertyName = "LineBalance"
        Me.LineBalance.HeaderText = "Line Bal"
        Me.LineBalance.Name = "LineBalance"
        Me.LineBalance.ReadOnly = True
        Me.LineBalance.Width = 57
        '
        'BillingStatus
        '
        Me.BillingStatus.DataPropertyName = "BillingStatus"
        Me.BillingStatus.HeaderText = "B. Status"
        Me.BillingStatus.MaxInputLength = 1
        Me.BillingStatus.Name = "BillingStatus"
        Me.BillingStatus.Width = 59
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DateCreated"
        Me.DataGridViewTextBoxColumn1.HeaderText = "B. Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 65
        '
        'EntryNumber
        '
        Me.EntryNumber.DataPropertyName = "EntryNumber"
        Me.EntryNumber.HeaderText = "EntryNo"
        Me.EntryNumber.Name = "EntryNumber"
        Me.EntryNumber.ReadOnly = True
        Me.EntryNumber.Width = 50
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.Width = 40
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DateTo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DateTo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "InsuranceCategory"
        Me.DataGridViewTextBoxColumn12.HeaderText = "InsuranceCategory"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "TypeofService"
        Me.DataGridViewTextBoxColumn18.HeaderText = "TypeofService"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ChartNumber"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ClaimNumber"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ClaimNumber"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DocumentNumber"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DocumentNumber"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "AttendingProvider"
        Me.DataGridViewTextBoxColumn11.HeaderText = "AttendingProvider"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Modifier1"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Modifier1"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TransactionType"
        Me.DataGridViewTextBoxColumn14.HeaderText = "TransactionType"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Modifier2"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Modifier2"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Modifier3"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Modifier3"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Modifier4"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Modifier4"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "PlaceofService"
        Me.DataGridViewTextBoxColumn19.HeaderText = "PlaceofService"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "VisitNumber"
        Me.DataGridViewTextBoxColumn20.HeaderText = "VisitNumber"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "VisitTotalinSeries"
        Me.DataGridViewTextBoxColumn21.HeaderText = "VisitTotalinSeries"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "VisitSeriesID"
        Me.DataGridViewTextBoxColumn22.HeaderText = "VisitSeriesID"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Units"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Units"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Minutes"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Minutes"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "PriceIndicator"
        Me.DataGridViewTextBoxColumn26.HeaderText = "PriceIndicator"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Diagnosis1"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Diagnosis1"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Diagnosis2"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Diagnosis2"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Diagnosis3"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Diagnosis3"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Diagnosis4"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Diagnosis4"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "ClaimItemRejected"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "ClaimItemRejected"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "AcceptAssignment1"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "AcceptAssignment1"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        '
        'DataGridViewCheckBoxColumn7
        '
        Me.DataGridViewCheckBoxColumn7.DataPropertyName = "AcceptAssignment2"
        Me.DataGridViewCheckBoxColumn7.HeaderText = "AcceptAssignment2"
        Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "AcceptAssignment3"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "AcceptAssignment3"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "DateCreated"
        Me.DataGridViewTextBoxColumn27.HeaderText = "DateCreated"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "DateofFirstStatement"
        Me.DataGridViewTextBoxColumn28.HeaderText = "DateofFirstStatement"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "DateofSecondStatement"
        Me.DataGridViewTextBoxColumn29.HeaderText = "DateofSecondStatement"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "DateofLastStatement"
        Me.DataGridViewTextBoxColumn35.HeaderText = "DateofLastStatement"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewCheckBoxColumn9
        '
        Me.DataGridViewCheckBoxColumn9.DataPropertyName = "BilledtoInsured1"
        Me.DataGridViewCheckBoxColumn9.HeaderText = "BilledtoInsured1"
        Me.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9"
        '
        'DataGridViewCheckBoxColumn10
        '
        Me.DataGridViewCheckBoxColumn10.DataPropertyName = "BilledtoInsured2"
        Me.DataGridViewCheckBoxColumn10.HeaderText = "BilledtoInsured2"
        Me.DataGridViewCheckBoxColumn10.Name = "DataGridViewCheckBoxColumn10"
        '
        'DataGridViewCheckBoxColumn11
        '
        Me.DataGridViewCheckBoxColumn11.DataPropertyName = "BilledtoInsured3"
        Me.DataGridViewCheckBoxColumn11.HeaderText = "BilledtoInsured3"
        Me.DataGridViewCheckBoxColumn11.Name = "DataGridViewCheckBoxColumn11"
        '
        'GuarantorPaid
        '
        Me.GuarantorPaid.DataPropertyName = "GuarantorPaid"
        Me.GuarantorPaid.HeaderText = "GuarantorPaid"
        Me.GuarantorPaid.Name = "GuarantorPaid"
        '
        'Insurance1Paid
        '
        Me.Insurance1Paid.DataPropertyName = "Insurance1Paid"
        Me.Insurance1Paid.HeaderText = "Insurance1Paid"
        Me.Insurance1Paid.Name = "Insurance1Paid"
        '
        'Insurance2Paid
        '
        Me.Insurance2Paid.DataPropertyName = "Insurance2Paid"
        Me.Insurance2Paid.HeaderText = "Insurance2Paid"
        Me.Insurance2Paid.Name = "Insurance2Paid"
        '
        'Insurance3Paid
        '
        Me.Insurance3Paid.DataPropertyName = "Insurance3Paid"
        Me.Insurance3Paid.HeaderText = "Insurance3Paid"
        Me.Insurance3Paid.Name = "Insurance3Paid"
        '
        'DataGridViewCheckBoxColumn16
        '
        Me.DataGridViewCheckBoxColumn16.DataPropertyName = "GuarantorResponsible"
        Me.DataGridViewCheckBoxColumn16.HeaderText = "GuarantorResponsible"
        Me.DataGridViewCheckBoxColumn16.Name = "DataGridViewCheckBoxColumn16"
        '
        'DataGridViewCheckBoxColumn17
        '
        Me.DataGridViewCheckBoxColumn17.DataPropertyName = "Insurance1Responsible"
        Me.DataGridViewCheckBoxColumn17.HeaderText = "Insurance1Responsible"
        Me.DataGridViewCheckBoxColumn17.Name = "DataGridViewCheckBoxColumn17"
        '
        'DataGridViewCheckBoxColumn18
        '
        Me.DataGridViewCheckBoxColumn18.DataPropertyName = "Insurance2Responsible"
        Me.DataGridViewCheckBoxColumn18.HeaderText = "Insurance2Responsible"
        Me.DataGridViewCheckBoxColumn18.Name = "DataGridViewCheckBoxColumn18"
        '
        'DataGridViewCheckBoxColumn19
        '
        Me.DataGridViewCheckBoxColumn19.DataPropertyName = "Insurance3Responsible"
        Me.DataGridViewCheckBoxColumn19.HeaderText = "Insurance3Responsible"
        Me.DataGridViewCheckBoxColumn19.Name = "DataGridViewCheckBoxColumn19"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "DocumentationType"
        Me.DataGridViewTextBoxColumn36.HeaderText = "DocumentationType"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Documentation"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Documentation"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'AttorneyPaid
        '
        Me.AttorneyPaid.DataPropertyName = "AttorneyPaid"
        Me.AttorneyPaid.HeaderText = "AttorneyPaid"
        Me.AttorneyPaid.Name = "AttorneyPaid"
        '
        'DataGridViewCheckBoxColumn21
        '
        Me.DataGridViewCheckBoxColumn21.DataPropertyName = "AttorneyResponsible"
        Me.DataGridViewCheckBoxColumn21.HeaderText = "AttorneyResponsible"
        Me.DataGridViewCheckBoxColumn21.Name = "DataGridViewCheckBoxColumn21"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "UserCode"
        Me.DataGridViewTextBoxColumn41.HeaderText = "UserCode"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "DiagnosisCode1"
        Me.DataGridViewTextBoxColumn42.HeaderText = "DiagnosisCode1"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "DiagnosisCode2"
        Me.DataGridViewTextBoxColumn43.HeaderText = "DiagnosisCode2"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "DiagnosisCode3"
        Me.DataGridViewTextBoxColumn44.HeaderText = "DiagnosisCode3"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "DiagnosisCode4"
        Me.DataGridViewTextBoxColumn45.HeaderText = "DiagnosisCode4"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "CCEntryNumber"
        Me.DataGridViewTextBoxColumn46.HeaderText = "CCEntryNumber"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "ToothNumber"
        Me.DataGridViewTextBoxColumn47.HeaderText = "ToothNumber"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "CheckNumber"
        Me.DataGridViewTextBoxColumn48.HeaderText = "CheckNumber"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "MouthQuadrant"
        Me.DataGridViewTextBoxColumn49.HeaderText = "MouthQuadrant"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "DateModified"
        Me.DataGridViewTextBoxColumn50.HeaderText = "DateModified"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn81
        '
        Me.DataGridViewTextBoxColumn81.DataPropertyName = "DepositID"
        Me.DataGridViewTextBoxColumn81.HeaderText = "DepositID"
        Me.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81"
        '
        'MMARTRANSACTIONSBindingSource
        '
        Me.MMARTRANSACTIONSBindingSource.DataMember = "MMARTRANSACTIONS"
        Me.MMARTRANSACTIONSBindingSource.DataSource = Me.ARDataSet
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.btnSavePostPymnt)
        Me.TabPage2.Controls.Add(Me.btnSaveDeposit)
        Me.TabPage2.Controls.Add(Me.MMARDepositDataGridView1)
        Me.TabPage2.Controls.Add(Me.MMARPostPaymentDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1111, 473)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Deposit/PostedPymnt"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSavePostPymnt
        '
        Me.btnSavePostPymnt.Location = New System.Drawing.Point(1016, 440)
        Me.btnSavePostPymnt.Name = "btnSavePostPymnt"
        Me.btnSavePostPymnt.Size = New System.Drawing.Size(89, 23)
        Me.btnSavePostPymnt.TabIndex = 15
        Me.btnSavePostPymnt.Text = "Save Payments"
        Me.btnSavePostPymnt.UseVisualStyleBackColor = True
        '
        'btnSaveDeposit
        '
        Me.btnSaveDeposit.Location = New System.Drawing.Point(1016, 206)
        Me.btnSaveDeposit.Name = "btnSaveDeposit"
        Me.btnSaveDeposit.Size = New System.Drawing.Size(89, 23)
        Me.btnSaveDeposit.TabIndex = 14
        Me.btnSaveDeposit.Text = "Save Deposit"
        Me.btnSaveDeposit.UseVisualStyleBackColor = True
        '
        'MMARDepositDataGridView1
        '
        Me.MMARDepositDataGridView1.AllowUserToAddRows = False
        Me.MMARDepositDataGridView1.AutoGenerateColumns = False
        Me.MMARDepositDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn70, Me.DataGridViewTextBoxColumn80, Me.DataGridViewTextBoxColumn76, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn72, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn69, Me.DataGridViewTextBoxColumn71, Me.DataGridViewTextBoxColumn74, Me.DataGridViewTextBoxColumn75, Me.DataGridViewTextBoxColumn77, Me.DataGridViewTextBoxColumn78, Me.DataGridViewTextBoxColumn79, Me.DataGridViewCheckBoxColumn12})
        Me.MMARDepositDataGridView1.DataSource = Me.MMARDepositBindingSource
        Me.MMARDepositDataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.MMARDepositDataGridView1.Name = "MMARDepositDataGridView1"
        Me.MMARDepositDataGridView1.Size = New System.Drawing.Size(1099, 197)
        Me.MMARDepositDataGridView1.TabIndex = 13
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "EntryNumber"
        Me.DataGridViewTextBoxColumn55.HeaderText = "EntryNumber"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        Me.DataGridViewTextBoxColumn55.Width = 75
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "DepositDate"
        Me.DataGridViewTextBoxColumn56.HeaderText = "DepositDate"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.Width = 75
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn70.HeaderText = "Chart No"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        Me.DataGridViewTextBoxColumn70.Width = 65
        '
        'DataGridViewTextBoxColumn80
        '
        Me.DataGridViewTextBoxColumn80.DataPropertyName = "CaseNumber"
        Me.DataGridViewTextBoxColumn80.HeaderText = "Case No"
        Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
        Me.DataGridViewTextBoxColumn80.Width = 60
        '
        'DataGridViewTextBoxColumn76
        '
        Me.DataGridViewTextBoxColumn76.DataPropertyName = "PayorName"
        Me.DataGridViewTextBoxColumn76.HeaderText = "PayorName"
        Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
        Me.DataGridViewTextBoxColumn76.Width = 175
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "PayorType"
        Me.DataGridViewTextBoxColumn65.HeaderText = "PayorType"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.Width = 80
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "CheckNumber"
        Me.DataGridViewTextBoxColumn72.HeaderText = "Check No"
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        Me.DataGridViewTextBoxColumn72.Width = 75
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.DataPropertyName = "PaymentAmount"
        Me.DataGridViewTextBoxColumn73.HeaderText = "Pay Amnt"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        Me.DataGridViewTextBoxColumn73.Width = 60
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn57.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "PaymentMethod"
        Me.DataGridViewTextBoxColumn66.HeaderText = "Pay Method"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.Width = 70
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "InsuranceCode"
        Me.DataGridViewTextBoxColumn69.HeaderText = "InsuranceCode"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "AttorneyCode"
        Me.DataGridViewTextBoxColumn71.HeaderText = "AttorneyCode"
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.DataPropertyName = "UnappliedAmount"
        Me.DataGridViewTextBoxColumn74.HeaderText = "UnappliedAmount"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.DataPropertyName = "DepositCode"
        Me.DataGridViewTextBoxColumn75.HeaderText = "DepositCode"
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        '
        'DataGridViewTextBoxColumn77
        '
        Me.DataGridViewTextBoxColumn77.DataPropertyName = "PaymentCode"
        Me.DataGridViewTextBoxColumn77.HeaderText = "PaymentCode"
        Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
        '
        'DataGridViewTextBoxColumn78
        '
        Me.DataGridViewTextBoxColumn78.DataPropertyName = "AdjustmentCode"
        Me.DataGridViewTextBoxColumn78.HeaderText = "AdjustmentCode"
        Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
        '
        'DataGridViewTextBoxColumn79
        '
        Me.DataGridViewTextBoxColumn79.DataPropertyName = "DeductibleCode"
        Me.DataGridViewTextBoxColumn79.HeaderText = "DeductibleCode"
        Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
        '
        'DataGridViewCheckBoxColumn12
        '
        Me.DataGridViewCheckBoxColumn12.DataPropertyName = "Copay"
        Me.DataGridViewCheckBoxColumn12.HeaderText = "Copay"
        Me.DataGridViewCheckBoxColumn12.Name = "DataGridViewCheckBoxColumn12"
        '
        'MMARDepositBindingSource
        '
        Me.MMARDepositBindingSource.DataMember = "MMARDeposit"
        Me.MMARDepositBindingSource.DataSource = Me.ARDataSet
        '
        'MMARPostPaymentDataGridView
        '
        Me.MMARPostPaymentDataGridView.AllowUserToAddRows = False
        Me.MMARPostPaymentDataGridView.AutoGenerateColumns = False
        Me.MMARPostPaymentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn54})
        Me.MMARPostPaymentDataGridView.DataSource = Me.MMARPostPaymentBindingSource
        Me.MMARPostPaymentDataGridView.Location = New System.Drawing.Point(6, 231)
        Me.MMARPostPaymentDataGridView.Name = "MMARPostPaymentDataGridView"
        Me.MMARPostPaymentDataGridView.Size = New System.Drawing.Size(1099, 203)
        Me.MMARPostPaymentDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "PostPaymentID"
        Me.DataGridViewTextBoxColumn30.HeaderText = "PostPaymentID"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "CaseNumber"
        Me.DataGridViewTextBoxColumn31.HeaderText = "CaseNumber"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "PaymentReference"
        Me.DataGridViewTextBoxColumn33.HeaderText = "PaymentReference"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "ChargeReference"
        Me.DataGridViewTextBoxColumn34.HeaderText = "ChargeReference"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "PaymentAmount"
        Me.DataGridViewTextBoxColumn37.HeaderText = "PaymentAmount"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "WhoPaid"
        Me.DataGridViewTextBoxColumn38.HeaderText = "WhoPaid"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "DepositID"
        Me.DataGridViewTextBoxColumn40.HeaderText = "DepositID"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "DateModified"
        Me.DataGridViewTextBoxColumn54.HeaderText = "DateModified"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'MMARPostPaymentBindingSource
        '
        Me.MMARPostPaymentBindingSource.DataMember = "MMARPostPayment"
        Me.MMARPostPaymentBindingSource.DataSource = Me.ARDataSet
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.MMARTRANSACTIONSDataGridView1)
        Me.TabPage3.Controls.Add(Me.MMPRocedureDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1111, 473)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "MISC"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Search by Description:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(125, 147)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 20)
        Me.TextBox1.TabIndex = 35
        '
        'MMARTRANSACTIONSDataGridView1
        '
        Me.MMARTRANSACTIONSDataGridView1.AllowUserToAddRows = False
        Me.MMARTRANSACTIONSDataGridView1.AutoGenerateColumns = False
        Me.MMARTRANSACTIONSDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn85, Me.DataGridViewTextBoxColumn102, Me.DataGridViewTextBoxColumn103, Me.DataGridViewTextBoxColumn104, Me.DataGridViewTextBoxColumn105, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61})
        Me.MMARTRANSACTIONSDataGridView1.DataSource = Me.MMARTRANSACTIONSBindingSource
        Me.MMARTRANSACTIONSDataGridView1.Location = New System.Drawing.Point(2, 15)
        Me.MMARTRANSACTIONSDataGridView1.Name = "MMARTRANSACTIONSDataGridView1"
        Me.MMARTRANSACTIONSDataGridView1.Size = New System.Drawing.Size(1103, 122)
        Me.MMARTRANSACTIONSDataGridView1.TabIndex = 34
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ChartNumber"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "EntryNumber"
        Me.DataGridViewTextBoxColumn24.HeaderText = "EntryNumber"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 75
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "DateFrom"
        Me.DataGridViewTextBoxColumn32.HeaderText = "DateFrom"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 75
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "ProcedureCode"
        Me.DataGridViewTextBoxColumn51.HeaderText = "ProcedureCode"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn85
        '
        Me.DataGridViewTextBoxColumn85.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn85.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn85.Name = "DataGridViewTextBoxColumn85"
        Me.DataGridViewTextBoxColumn85.Width = 80
        '
        'DataGridViewTextBoxColumn102
        '
        Me.DataGridViewTextBoxColumn102.DataPropertyName = "DiagnosisCode1"
        Me.DataGridViewTextBoxColumn102.DataSource = Me.MMDXBindingSource
        Me.DataGridViewTextBoxColumn102.DisplayMember = "Code1"
        Me.DataGridViewTextBoxColumn102.HeaderText = "Dx1"
        Me.DataGridViewTextBoxColumn102.Name = "DataGridViewTextBoxColumn102"
        Me.DataGridViewTextBoxColumn102.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn102.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn102.Width = 70
        '
        'MMDXBindingSource
        '
        Me.MMDXBindingSource.DataMember = "MMDX"
        Me.MMDXBindingSource.DataSource = Me.ARDataSet
        '
        'DataGridViewTextBoxColumn103
        '
        Me.DataGridViewTextBoxColumn103.DataPropertyName = "DiagnosisCode2"
        Me.DataGridViewTextBoxColumn103.DataSource = Me.MMDXBindingSource
        Me.DataGridViewTextBoxColumn103.DisplayMember = "Code1"
        Me.DataGridViewTextBoxColumn103.HeaderText = "Dx2"
        Me.DataGridViewTextBoxColumn103.Name = "DataGridViewTextBoxColumn103"
        Me.DataGridViewTextBoxColumn103.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn103.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn103.Width = 70
        '
        'DataGridViewTextBoxColumn104
        '
        Me.DataGridViewTextBoxColumn104.DataPropertyName = "DiagnosisCode3"
        Me.DataGridViewTextBoxColumn104.DataSource = Me.MMDXBindingSource
        Me.DataGridViewTextBoxColumn104.DisplayMember = "Code1"
        Me.DataGridViewTextBoxColumn104.HeaderText = "Dx3"
        Me.DataGridViewTextBoxColumn104.Name = "DataGridViewTextBoxColumn104"
        Me.DataGridViewTextBoxColumn104.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn104.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn104.Width = 70
        '
        'DataGridViewTextBoxColumn105
        '
        Me.DataGridViewTextBoxColumn105.DataPropertyName = "DiagnosisCode4"
        Me.DataGridViewTextBoxColumn105.DataSource = Me.MMDXBindingSource
        Me.DataGridViewTextBoxColumn105.DisplayMember = "Code1"
        Me.DataGridViewTextBoxColumn105.HeaderText = "Dx4"
        Me.DataGridViewTextBoxColumn105.Name = "DataGridViewTextBoxColumn105"
        Me.DataGridViewTextBoxColumn105.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn105.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn105.Width = 70
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Modifier1"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Mod1"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.Width = 50
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "Modifier2"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Mod2"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.Width = 50
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "Modifier3"
        Me.DataGridViewTextBoxColumn60.HeaderText = "Mod3"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.Width = 50
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "Modifier4"
        Me.DataGridViewTextBoxColumn61.HeaderText = "Mod4"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.Width = 50
        '
        'MMPRocedureDataGridView
        '
        Me.MMPRocedureDataGridView.AllowUserToAddRows = False
        Me.MMPRocedureDataGridView.AutoGenerateColumns = False
        Me.MMPRocedureDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MMPRocedureDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.MMPRocedureDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code1, Me.AmountA, Me.ProcedureDescription})
        Me.MMPRocedureDataGridView.DataSource = Me.MMPRocedureBindingSource
        Me.MMPRocedureDataGridView.Location = New System.Drawing.Point(6, 173)
        Me.MMPRocedureDataGridView.Name = "MMPRocedureDataGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMPRocedureDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MMPRocedureDataGridView.RowHeadersWidth = 25
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MMPRocedureDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.MMPRocedureDataGridView.Size = New System.Drawing.Size(319, 177)
        Me.MMPRocedureDataGridView.TabIndex = 34
        '
        'Code1
        '
        Me.Code1.DataPropertyName = "Code1"
        Me.Code1.HeaderText = "Code1"
        Me.Code1.Name = "Code1"
        Me.Code1.Width = 60
        '
        'AmountA
        '
        Me.AmountA.DataPropertyName = "AmountA"
        Me.AmountA.HeaderText = "Amount"
        Me.AmountA.Name = "AmountA"
        Me.AmountA.Width = 60
        '
        'ProcedureDescription
        '
        Me.ProcedureDescription.DataPropertyName = "Description"
        Me.ProcedureDescription.HeaderText = "Description"
        Me.ProcedureDescription.Name = "ProcedureDescription"
        Me.ProcedureDescription.Width = 155
        '
        'MMINSURENCEBindingSource
        '
        Me.MMINSURENCEBindingSource.DataMember = "MMINSURENCE"
        Me.MMINSURENCEBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMINSURENCEBindingSource1
        '
        Me.MMINSURENCEBindingSource1.DataMember = "MMINSURENCE"
        Me.MMINSURENCEBindingSource1.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet
        '
        Me.MMDataDataSet.DataSetName = "MMDataDataSet"
        Me.MMDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentReference
        '
        Me.PaymentReference.DataPropertyName = "PaymentReference"
        Me.PaymentReference.HeaderText = "PaymentReference"
        Me.PaymentReference.Name = "PaymentReference"
        '
        'MMDataDataSet1BindingSource
        '
        Me.MMDataDataSet1BindingSource.DataSource = Me.MMDataDataSet1
        Me.MMDataDataSet1BindingSource.Position = 0
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
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "EntryNumber"
        Me.DataGridViewTextBoxColumn64.HeaderText = "EntryNumber"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.ReadOnly = True
        Me.DataGridViewTextBoxColumn64.Width = 75
        '
        'DepositDate
        '
        Me.DepositDate.DataPropertyName = "DepositDate"
        Me.DepositDate.HeaderText = "DepositDate"
        Me.DepositDate.Name = "DepositDate"
        Me.DepositDate.Width = 75
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn63.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        '
        'PayorType
        '
        Me.PayorType.DataPropertyName = "PayorType"
        Me.PayorType.HeaderText = "PayorType"
        Me.PayorType.Name = "PayorType"
        '
        'PaymentMethod
        '
        Me.PaymentMethod.DataPropertyName = "PaymentMethod"
        Me.PaymentMethod.HeaderText = "PaymentMethod"
        Me.PaymentMethod.Name = "PaymentMethod"
        '
        'PaymentAmountDeposit
        '
        Me.PaymentAmountDeposit.DataPropertyName = "PaymentAmount"
        Me.PaymentAmountDeposit.HeaderText = "PaymentAmount"
        Me.PaymentAmountDeposit.Name = "PaymentAmountDeposit"
        '
        'Copay
        '
        Me.Copay.DataPropertyName = "Copay"
        Me.Copay.HeaderText = "Copay"
        Me.Copay.Name = "Copay"
        Me.Copay.Width = 50
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "InsuranceCode"
        Me.DataGridViewTextBoxColumn67.HeaderText = "InsuranceCode"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn68.HeaderText = "ChartNumber"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        '
        'MMINSURENCETableAdapter
        '
        Me.MMINSURENCETableAdapter.ClearBeforeFill = True
        '
        'MMDataDataSet1BindingSource1
        '
        Me.MMDataDataSet1BindingSource1.DataSource = Me.MMDataDataSet1
        Me.MMDataDataSet1BindingSource1.Position = 0
        '
        'MMDataDataSet1BindingSource2
        '
        Me.MMDataDataSet1BindingSource2.DataSource = Me.MMDataDataSet1
        Me.MMDataDataSet1BindingSource2.Position = 0
        '
        'MMARCASETableAdapter
        '
        Me.MMARCASETableAdapter.ClearBeforeFill = True
        '
        'MMARTRANSACTIONSTableAdapter
        '
        Me.MMARTRANSACTIONSTableAdapter.ClearBeforeFill = True
        '
        'MMARDepositTableAdapter
        '
        Me.MMARDepositTableAdapter.ClearBeforeFill = True
        '
        'MMPRocedureTableAdapter
        '
        Me.MMPRocedureTableAdapter.ClearBeforeFill = True
        '
        'MMDXTableAdapter
        '
        Me.MMDXTableAdapter.ClearBeforeFill = True
        '
        'MMARPostPaymentTableAdapter
        '
        Me.MMARPostPaymentTableAdapter.ClearBeforeFill = True
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 532)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(CaseNumberLabel)
        Me.Controls.Add(Me.CaseNumberTextBox)
        Me.Controls.Add(Me.ChartNumberTextBox)
        Me.Controls.Add(ChartNumberLabel)
        Me.Controls.Add(Me.MMARCASEBindingNavigator)
        Me.Name = "Transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transactions"
        CType(Me.MMARCASEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARCASEBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMARCASEBindingNavigator.ResumeLayout(False)
        Me.MMARCASEBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.MMARCASEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARTRANSACTIONSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPRocedureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARTRANSACTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MMARDepositDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARDepositBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARPostPaymentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARPostPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.MMARTRANSACTIONSDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPRocedureDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMINSURENCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMINSURENCEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMComboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ARDataSet As MedicalManager.ARDataSet
    Friend WithEvents MMARCASEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMARCASETableAdapter As MedicalManager.ARDataSetTableAdapters.MMARCASETableAdapter
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaseNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MMARTRANSACTIONSTableAdapter As MedicalManager.ARDataSetTableAdapters.MMARTRANSACTIONSTableAdapter
    Friend WithEvents MMARTRANSACTIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MMARCASEBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents MMARDepositBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMARDepositTableAdapter As MedicalManager.ARDataSetTableAdapters.MMARDepositTableAdapter
    Friend WithEvents MMPRocedureBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMPRocedureTableAdapter As MedicalManager.ARDataSetTableAdapters.MMPRocedureTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmbPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbWhoPaid As System.Windows.Forms.ComboBox
    Friend WithEvents btnApplyCharges As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents MMARCASEDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MMARTRANSACTIONSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MMDXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDXTableAdapter As MedicalManager.ARDataSetTableAdapters.MMDXTableAdapter
    Friend WithEvents MMARPostPaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMARPostPaymentTableAdapter As MedicalManager.ARDataSetTableAdapters.MMARPostPaymentTableAdapter
    Friend WithEvents CaseNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSaveTrans As System.Windows.Forms.Button
    Friend WithEvents MMARTRANSACTIONSDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MMPRocedureDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MMDataDataSet As MedicalManager.MMDataDataSet
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn85 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn102 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn103 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn104 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn105 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Code1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcedureDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentReference As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMARPostPaymentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMDataDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMComboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMComboTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMComboTableAdapter
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCheckNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MMARDepositDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepositDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayorType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentAmountDeposit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Copay As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSavePostPymnt As System.Windows.Forms.Button
    Friend WithEvents btnSaveDeposit As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CaseSaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtFind As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtPayorName As System.Windows.Forms.ComboBox
    Friend WithEvents MMINSURENCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMINSURENCETableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMINSURENCETableAdapter
    Friend WithEvents MMINSURENCEBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet1BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn80 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn77 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn78 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn79 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn12 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chkKeepPayorCheckNo As System.Windows.Forms.CheckBox
    Friend WithEvents DateCreated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleInitial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deductible As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn82 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn148 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AllowedAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeductibleAndOther As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicesNotCovered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuarantorAmountPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CopayAmountPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insurance1AmountPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insurance2AmountPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Insurance3AmountPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdjustmentAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttorneyAmountPaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentReceived As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillingStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntryNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn9 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn10 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn11 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GuarantorPaid As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Insurance1Paid As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Insurance2Paid As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Insurance3Paid As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn16 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn17 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn18 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn19 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttorneyPaid As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn21 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn81 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
