<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionDetail
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
        Dim ChartNumberLabel As System.Windows.Forms.Label
        Dim CaseNumberLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionDetail))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.BillingDetailDataGridView = New System.Windows.Forms.DataGridView
        Me.BillingHeaderDataGridView = New System.Windows.Forms.DataGridView
        Me.btnSaveTrans = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTotalBalance = New System.Windows.Forms.TextBox
        Me.txtTotalPayments = New System.Windows.Forms.TextBox
        Me.txtTotalAmount = New System.Windows.Forms.TextBox
        Me.btnApplyCharges = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.chkKeepPayorCheckNo = New System.Windows.Forms.CheckBox
        Me.txtPayorName = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCheckNumber = New System.Windows.Forms.TextBox
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox
        Me.cmbWhoPaid = New System.Windows.Forms.ComboBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.MMARDepositDataGridView = New System.Windows.Forms.DataGridView
        Me.btnSaveDeposit = New System.Windows.Forms.Button
        Me.MMARPostPaymentDataGridView = New System.Windows.Forms.DataGridView
        Me.btnSavePostPymnt = New System.Windows.Forms.Button
        Me.BillingHeaderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BillingHeaderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox
        Me.CaseNumberTextBox = New System.Windows.Forms.TextBox
        Me.MMComboBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.MMComboTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMComboTableAdapter
        Me.CaseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDLineBalance = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Payment = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDPayorType = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDPayorName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDPaymentMethod = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDCheckNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillingHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARDataSet = New MedicalManager.ARDataSet
        Me.BillingDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDChartNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDCaseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDServiceDate1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDCharge = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDUnits = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDExtended = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDReceived = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDCPTCode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn134 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn172 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDDateEntered = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDDateCreated = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn120 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn121 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn122 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn123 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn124 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn126 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn127 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn128 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn129 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn86 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BDAssignedProvider = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn125 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn135 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn136 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn137 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn139 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn119 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn140 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn141 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn142 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn143 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn144 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn145 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn146 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn147 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn149 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn150 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn151 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn152 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn153 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn154 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn155 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn156 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn157 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn158 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn159 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn160 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn161 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn162 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn163 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn164 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn165 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn166 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn167 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn168 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn169 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn170 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn171 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn174 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn175 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn176 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn177 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn178 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn179 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn180 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn181 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn182 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BHCharges = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BHPayments = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BHTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn81 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn83 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn84 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn85 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn87 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn88 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn89 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn90 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn91 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn92 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn93 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn94 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn95 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn96 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn97 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn98 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn99 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn100 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn101 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn102 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn103 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn104 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn105 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn106 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn107 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn108 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn109 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn110 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn111 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn112 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn113 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn114 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn115 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn116 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn117 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn200 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn201 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn202 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn203 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn204 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn205 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn206 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn207 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn208 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn209 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn210 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn138 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn188 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn196 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn197 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn186 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn190 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn198 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn199 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn185 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn189 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn187 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn191 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn192 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn193 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn194 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn195 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMARDepositBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMARPostPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingHeaderTableAdapter = New MedicalManager.ARDataSetTableAdapters.BillingHeaderTableAdapter
        Me.BillingDetailTableAdapter = New MedicalManager.ARDataSetTableAdapters.BillingDetailTableAdapter
        Me.MMARPostPaymentTableAdapter = New MedicalManager.ARDataSetTableAdapters.MMARPostPaymentTableAdapter
        Me.MMARDepositTableAdapter = New MedicalManager.ARDataSetTableAdapters.MMARDepositTableAdapter
        ChartNumberLabel = New System.Windows.Forms.Label
        CaseNumberLabel = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BillingDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingHeaderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMARDepositDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARPostPaymentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BillingHeaderBindingNavigator.SuspendLayout()
        CType(Me.MMComboBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARDepositBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARPostPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartNumberLabel
        '
        ChartNumberLabel.AutoSize = True
        ChartNumberLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        ChartNumberLabel.Location = New System.Drawing.Point(655, 4)
        ChartNumberLabel.Name = "ChartNumberLabel"
        ChartNumberLabel.Size = New System.Drawing.Size(75, 13)
        ChartNumberLabel.TabIndex = 2
        ChartNumberLabel.Text = "Chart Number:"
        '
        'CaseNumberLabel
        '
        CaseNumberLabel.AutoSize = True
        CaseNumberLabel.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        CaseNumberLabel.Location = New System.Drawing.Point(821, 4)
        CaseNumberLabel.Name = "CaseNumberLabel"
        CaseNumberLabel.Size = New System.Drawing.Size(74, 13)
        CaseNumberLabel.TabIndex = 6
        CaseNumberLabel.Text = "Case Number:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 31)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1124, 660)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.BillingDetailDataGridView)
        Me.TabPage1.Controls.Add(Me.BillingHeaderDataGridView)
        Me.TabPage1.Controls.Add(Me.btnSaveTrans)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtTotalBalance)
        Me.TabPage1.Controls.Add(Me.txtTotalPayments)
        Me.TabPage1.Controls.Add(Me.txtTotalAmount)
        Me.TabPage1.Controls.Add(Me.btnApplyCharges)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.chkKeepPayorCheckNo)
        Me.TabPage1.Controls.Add(Me.txtPayorName)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtCheckNumber)
        Me.TabPage1.Controls.Add(Me.txtBalance)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtTotal)
        Me.TabPage1.Controls.Add(Me.cmbPaymentType)
        Me.TabPage1.Controls.Add(Me.cmbWhoPaid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1116, 634)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transactions"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BillingDetailDataGridView
        '
        Me.BillingDetailDataGridView.AllowDrop = True
        Me.BillingDetailDataGridView.AllowUserToAddRows = False
        Me.BillingDetailDataGridView.AllowUserToResizeRows = False
        Me.BillingDetailDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillingDetailDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BillingDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BillingDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BDId, Me.BDChartNumber, Me.BDCaseNumber, Me.BDServiceDate1, Me.BDCharge, Me.BDUnits, Me.BDExtended, Me.BDReceived, Me.BDLineBalance, Me.Payment, Me.BDCPTCode, Me.BDPayorType, Me.BDPayorName, Me.BDPaymentMethod, Me.BDCheckNumber, Me.DataGridViewTextBoxColumn134, Me.DataGridViewTextBoxColumn172, Me.BDDateEntered, Me.BDDateCreated, Me.DataGridViewTextBoxColumn120, Me.DataGridViewTextBoxColumn121, Me.DataGridViewTextBoxColumn122, Me.DataGridViewTextBoxColumn123, Me.DataGridViewTextBoxColumn124, Me.DataGridViewTextBoxColumn126, Me.DataGridViewTextBoxColumn127, Me.DataGridViewTextBoxColumn128, Me.DataGridViewTextBoxColumn129, Me.DataGridViewTextBoxColumn86, Me.BDAssignedProvider, Me.DataGridViewTextBoxColumn125, Me.DataGridViewTextBoxColumn135, Me.DataGridViewTextBoxColumn136, Me.DataGridViewTextBoxColumn137, Me.DataGridViewTextBoxColumn139, Me.DataGridViewTextBoxColumn119, Me.DataGridViewTextBoxColumn140, Me.DataGridViewTextBoxColumn141, Me.DataGridViewTextBoxColumn142, Me.DataGridViewTextBoxColumn143, Me.DataGridViewTextBoxColumn144, Me.DataGridViewTextBoxColumn145, Me.DataGridViewTextBoxColumn146, Me.DataGridViewTextBoxColumn147, Me.DataGridViewTextBoxColumn149, Me.DataGridViewTextBoxColumn150, Me.DataGridViewTextBoxColumn151, Me.DataGridViewTextBoxColumn152, Me.DataGridViewTextBoxColumn153, Me.DataGridViewTextBoxColumn154, Me.DataGridViewTextBoxColumn155, Me.DataGridViewTextBoxColumn156, Me.DataGridViewTextBoxColumn157, Me.DataGridViewTextBoxColumn158, Me.DataGridViewTextBoxColumn159, Me.DataGridViewTextBoxColumn160, Me.DataGridViewTextBoxColumn161, Me.DataGridViewTextBoxColumn162, Me.DataGridViewTextBoxColumn163, Me.DataGridViewTextBoxColumn164, Me.DataGridViewTextBoxColumn165, Me.DataGridViewTextBoxColumn166, Me.DataGridViewTextBoxColumn167, Me.DataGridViewTextBoxColumn168, Me.DataGridViewTextBoxColumn169, Me.DataGridViewTextBoxColumn170, Me.DataGridViewTextBoxColumn171, Me.DataGridViewTextBoxColumn174, Me.DataGridViewTextBoxColumn175, Me.DataGridViewTextBoxColumn176, Me.DataGridViewTextBoxColumn177, Me.DataGridViewTextBoxColumn178, Me.DataGridViewTextBoxColumn179, Me.DataGridViewTextBoxColumn180, Me.DataGridViewTextBoxColumn181, Me.DataGridViewTextBoxColumn182})
        Me.BillingDetailDataGridView.DataSource = Me.BillingDetailBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BillingDetailDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.BillingDetailDataGridView.Location = New System.Drawing.Point(3, 271)
        Me.BillingDetailDataGridView.MultiSelect = False
        Me.BillingDetailDataGridView.Name = "BillingDetailDataGridView"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillingDetailDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BillingDetailDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.BillingDetailDataGridView.Size = New System.Drawing.Size(1107, 322)
        Me.BillingDetailDataGridView.TabIndex = 66
        '
        'BillingHeaderDataGridView
        '
        Me.BillingHeaderDataGridView.AllowUserToAddRows = False
        Me.BillingHeaderDataGridView.AllowUserToResizeRows = False
        Me.BillingHeaderDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillingHeaderDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.BillingHeaderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BillingHeaderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn10, Me.CaseNumber, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.BHCharges, Me.BHPayments, Me.BHTotal, Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn71, Me.DataGridViewTextBoxColumn72, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn74, Me.DataGridViewTextBoxColumn75, Me.DataGridViewTextBoxColumn76, Me.DataGridViewTextBoxColumn77, Me.DataGridViewTextBoxColumn78, Me.DataGridViewTextBoxColumn79, Me.DataGridViewTextBoxColumn80, Me.DataGridViewTextBoxColumn81, Me.DataGridViewTextBoxColumn82, Me.DataGridViewTextBoxColumn83, Me.DataGridViewTextBoxColumn84, Me.DataGridViewTextBoxColumn85, Me.DataGridViewTextBoxColumn87, Me.DataGridViewTextBoxColumn88, Me.DataGridViewTextBoxColumn89, Me.DataGridViewTextBoxColumn90, Me.DataGridViewTextBoxColumn91, Me.DataGridViewTextBoxColumn92, Me.DataGridViewTextBoxColumn93, Me.DataGridViewTextBoxColumn94, Me.DataGridViewTextBoxColumn95, Me.DataGridViewTextBoxColumn96, Me.DataGridViewTextBoxColumn97, Me.DataGridViewTextBoxColumn98, Me.DataGridViewTextBoxColumn99, Me.DataGridViewTextBoxColumn100, Me.DataGridViewTextBoxColumn101, Me.DataGridViewTextBoxColumn102, Me.DataGridViewTextBoxColumn103, Me.DataGridViewTextBoxColumn104, Me.DataGridViewTextBoxColumn105, Me.DataGridViewTextBoxColumn106, Me.DataGridViewTextBoxColumn107, Me.DataGridViewTextBoxColumn108, Me.DataGridViewTextBoxColumn109, Me.DataGridViewTextBoxColumn110, Me.DataGridViewTextBoxColumn111, Me.DataGridViewTextBoxColumn112, Me.DataGridViewTextBoxColumn113, Me.DataGridViewTextBoxColumn114, Me.DataGridViewTextBoxColumn115, Me.DataGridViewTextBoxColumn116, Me.DataGridViewTextBoxColumn117, Me.DataGridViewTextBoxColumn200, Me.DataGridViewTextBoxColumn201, Me.DataGridViewTextBoxColumn202, Me.DataGridViewTextBoxColumn203, Me.DataGridViewTextBoxColumn204, Me.DataGridViewTextBoxColumn205, Me.DataGridViewTextBoxColumn206, Me.DataGridViewTextBoxColumn207, Me.DataGridViewTextBoxColumn208, Me.DataGridViewTextBoxColumn209, Me.DataGridViewTextBoxColumn210})
        Me.BillingHeaderDataGridView.DataSource = Me.BillingHeaderBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BillingHeaderDataGridView.DefaultCellStyle = DataGridViewCellStyle9
        Me.BillingHeaderDataGridView.Location = New System.Drawing.Point(3, 6)
        Me.BillingHeaderDataGridView.MultiSelect = False
        Me.BillingHeaderDataGridView.Name = "BillingHeaderDataGridView"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillingHeaderDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.BillingHeaderDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.BillingHeaderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BillingHeaderDataGridView.Size = New System.Drawing.Size(1107, 206)
        Me.BillingHeaderDataGridView.TabIndex = 66
        '
        'btnSaveTrans
        '
        Me.btnSaveTrans.Location = New System.Drawing.Point(816, 596)
        Me.btnSaveTrans.Name = "btnSaveTrans"
        Me.btnSaveTrans.Size = New System.Drawing.Size(94, 23)
        Me.btnSaveTrans.TabIndex = 66
        Me.btnSaveTrans.Text = "Save"
        Me.btnSaveTrans.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 596)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Total Balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 596)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Total Payments"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 596)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Total Amount"
        '
        'txtTotalBalance
        '
        Me.txtTotalBalance.Location = New System.Drawing.Point(239, 610)
        Me.txtTotalBalance.MaxLength = 20
        Me.txtTotalBalance.Name = "txtTotalBalance"
        Me.txtTotalBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalBalance.TabIndex = 62
        Me.txtTotalBalance.Text = "0"
        Me.txtTotalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPayments
        '
        Me.txtTotalPayments.Location = New System.Drawing.Point(123, 610)
        Me.txtTotalPayments.MaxLength = 20
        Me.txtTotalPayments.Name = "txtTotalPayments"
        Me.txtTotalPayments.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPayments.TabIndex = 61
        Me.txtTotalPayments.Text = "0"
        Me.txtTotalPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(6, 610)
        Me.txtTotalAmount.MaxLength = 20
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAmount.TabIndex = 60
        Me.txtTotalAmount.Text = "0"
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnApplyCharges
        '
        Me.btnApplyCharges.Location = New System.Drawing.Point(1016, 596)
        Me.btnApplyCharges.Name = "btnApplyCharges"
        Me.btnApplyCharges.Size = New System.Drawing.Size(94, 23)
        Me.btnApplyCharges.TabIndex = 6
        Me.btnApplyCharges.Text = "Apply Charges"
        Me.btnApplyCharges.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(916, 596)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 23)
        Me.btnAdd.TabIndex = 59
        Me.btnAdd.Text = "Add Transaction"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'chkKeepPayorCheckNo
        '
        Me.chkKeepPayorCheckNo.AutoSize = True
        Me.chkKeepPayorCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkKeepPayorCheckNo.ForeColor = System.Drawing.Color.DarkRed
        Me.chkKeepPayorCheckNo.Location = New System.Drawing.Point(129, 218)
        Me.chkKeepPayorCheckNo.Name = "chkKeepPayorCheckNo"
        Me.chkKeepPayorCheckNo.Size = New System.Drawing.Size(299, 17)
        Me.chkKeepPayorCheckNo.TabIndex = 57
        Me.chkKeepPayorCheckNo.Text = "Keep Payor and Check # For More Transactions"
        Me.chkKeepPayorCheckNo.UseVisualStyleBackColor = True
        '
        'txtPayorName
        '
        Me.txtPayorName.FormattingEnabled = True
        Me.txtPayorName.Location = New System.Drawing.Point(129, 249)
        Me.txtPayorName.MaxDropDownItems = 15
        Me.txtPayorName.MaxLength = 50
        Me.txtPayorName.Name = "txtPayorName"
        Me.txtPayorName.Size = New System.Drawing.Size(259, 21)
        Me.txtPayorName.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Payment Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 249)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(126, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Payor Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(391, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Check Number"
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.Location = New System.Drawing.Point(394, 249)
        Me.txtCheckNumber.MaxLength = 20
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.Size = New System.Drawing.Size(135, 20)
        Me.txtCheckNumber.TabIndex = 2
        '
        'txtBalance
        '
        Me.txtBalance.Enabled = False
        Me.txtBalance.Location = New System.Drawing.Point(886, 249)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(99, 20)
        Me.txtBalance.TabIndex = 48
        Me.txtBalance.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(884, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Balance to Distribute"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(772, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Amnt Received Today"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(659, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Method of Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(532, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Payment Type"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(775, 249)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(103, 20)
        Me.txtTotal.TabIndex = 5
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Location = New System.Drawing.Point(662, 249)
        Me.cmbPaymentType.MaxLength = 11
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(104, 21)
        Me.cmbPaymentType.TabIndex = 4
        '
        'cmbWhoPaid
        '
        Me.cmbWhoPaid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbWhoPaid.FormattingEnabled = True
        Me.cmbWhoPaid.Location = New System.Drawing.Point(535, 249)
        Me.cmbWhoPaid.Name = "cmbWhoPaid"
        Me.cmbWhoPaid.Size = New System.Drawing.Size(121, 21)
        Me.cmbWhoPaid.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.MMARDepositDataGridView)
        Me.TabPage2.Controls.Add(Me.btnSaveDeposit)
        Me.TabPage2.Controls.Add(Me.MMARPostPaymentDataGridView)
        Me.TabPage2.Controls.Add(Me.btnSavePostPymnt)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1116, 634)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Posted Payments"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MMARDepositDataGridView
        '
        Me.MMARDepositDataGridView.AllowUserToAddRows = False
        Me.MMARDepositDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMARDepositDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.MMARDepositDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn138, Me.DataGridViewTextBoxColumn188, Me.DataGridViewTextBoxColumn196, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn197, Me.DataGridViewTextBoxColumn186, Me.DataGridViewTextBoxColumn190, Me.DataGridViewTextBoxColumn198, Me.DataGridViewTextBoxColumn199, Me.DataGridViewTextBoxColumn185, Me.DataGridViewTextBoxColumn189, Me.DataGridViewTextBoxColumn187, Me.DataGridViewTextBoxColumn191, Me.DataGridViewTextBoxColumn192, Me.DataGridViewTextBoxColumn193, Me.DataGridViewTextBoxColumn194, Me.DataGridViewTextBoxColumn195})
        Me.MMARDepositDataGridView.DataSource = Me.MMARDepositBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MMARDepositDataGridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.MMARDepositDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.MMARDepositDataGridView.Name = "MMARDepositDataGridView"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMARDepositDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.MMARDepositDataGridView.Size = New System.Drawing.Size(1105, 599)
        Me.MMARDepositDataGridView.TabIndex = 17
        '
        'btnSaveDeposit
        '
        Me.btnSaveDeposit.Location = New System.Drawing.Point(1021, 608)
        Me.btnSaveDeposit.Name = "btnSaveDeposit"
        Me.btnSaveDeposit.Size = New System.Drawing.Size(89, 23)
        Me.btnSaveDeposit.TabIndex = 16
        Me.btnSaveDeposit.Text = "Save Deposit"
        Me.btnSaveDeposit.UseVisualStyleBackColor = True
        '
        'MMARPostPaymentDataGridView
        '
        Me.MMARPostPaymentDataGridView.AllowUserToAddRows = False
        Me.MMARPostPaymentDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMARPostPaymentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.MMARPostPaymentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.MMARPostPaymentDataGridView.DataSource = Me.MMARPostPaymentBindingSource
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MMARPostPaymentDataGridView.DefaultCellStyle = DataGridViewCellStyle15
        Me.MMARPostPaymentDataGridView.Location = New System.Drawing.Point(131, 364)
        Me.MMARPostPaymentDataGridView.Name = "MMARPostPaymentDataGridView"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMARPostPaymentDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.MMARPostPaymentDataGridView.Size = New System.Drawing.Size(845, 29)
        Me.MMARPostPaymentDataGridView.TabIndex = 17
        '
        'btnSavePostPymnt
        '
        Me.btnSavePostPymnt.Location = New System.Drawing.Point(887, 396)
        Me.btnSavePostPymnt.Name = "btnSavePostPymnt"
        Me.btnSavePostPymnt.Size = New System.Drawing.Size(89, 23)
        Me.btnSavePostPymnt.TabIndex = 17
        Me.btnSavePostPymnt.Text = "Save Payments"
        Me.btnSavePostPymnt.UseVisualStyleBackColor = True
        '
        'BillingHeaderBindingNavigator
        '
        Me.BillingHeaderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BillingHeaderBindingNavigator.BindingSource = Me.BillingHeaderBindingSource
        Me.BillingHeaderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BillingHeaderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BillingHeaderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BillingHeaderBindingNavigatorSaveItem})
        Me.BillingHeaderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BillingHeaderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BillingHeaderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BillingHeaderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BillingHeaderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BillingHeaderBindingNavigator.Name = "BillingHeaderBindingNavigator"
        Me.BillingHeaderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BillingHeaderBindingNavigator.Size = New System.Drawing.Size(1126, 25)
        Me.BillingHeaderBindingNavigator.TabIndex = 1
        Me.BillingHeaderBindingNavigator.Text = "BindingNavigator1"
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
        'BillingHeaderBindingNavigatorSaveItem
        '
        Me.BillingHeaderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BillingHeaderBindingNavigatorSaveItem.Image = CType(resources.GetObject("BillingHeaderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BillingHeaderBindingNavigatorSaveItem.Name = "BillingHeaderBindingNavigatorSaveItem"
        Me.BillingHeaderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BillingHeaderBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ChartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillingDetailBindingSource, "ChartNumber", True))
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(736, 0)
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(79, 20)
        Me.ChartNumberTextBox.TabIndex = 3
        '
        'CaseNumberTextBox
        '
        Me.CaseNumberTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CaseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillingHeaderBindingSource, "CaseNumber", True))
        Me.CaseNumberTextBox.Location = New System.Drawing.Point(901, 0)
        Me.CaseNumberTextBox.Name = "CaseNumberTextBox"
        Me.CaseNumberTextBox.Size = New System.Drawing.Size(79, 20)
        Me.CaseNumberTextBox.TabIndex = 7
        '
        'MMComboBindingSource
        '
        Me.MMComboBindingSource.DataMember = "MMCombo"
        Me.MMComboBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMComboTableAdapter
        '
        Me.MMComboTableAdapter.ClearBeforeFill = True
        '
        'CaseNumber
        '
        Me.CaseNumber.DataPropertyName = "CaseNumber"
        Me.CaseNumber.HeaderText = "Case#"
        Me.CaseNumber.Name = "CaseNumber"
        Me.CaseNumber.Width = 65
        '
        'BDLineBalance
        '
        Me.BDLineBalance.HeaderText = "LineBal"
        Me.BDLineBalance.Name = "BDLineBalance"
        Me.BDLineBalance.Width = 55
        '
        'Payment
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan
        Me.Payment.DefaultCellStyle = DataGridViewCellStyle2
        Me.Payment.HeaderText = "Payment"
        Me.Payment.Name = "Payment"
        Me.Payment.Width = 55
        '
        'BDPayorType
        '
        Me.BDPayorType.DataPropertyName = "PayorType"
        Me.BDPayorType.HeaderText = "PayorType"
        Me.BDPayorType.Name = "BDPayorType"
        Me.BDPayorType.Width = 80
        '
        'BDPayorName
        '
        Me.BDPayorName.DataPropertyName = "PayorName"
        Me.BDPayorName.HeaderText = "PayorName"
        Me.BDPayorName.Name = "BDPayorName"
        Me.BDPayorName.Width = 75
        '
        'BDPaymentMethod
        '
        Me.BDPaymentMethod.DataPropertyName = "PaymentMethod"
        Me.BDPaymentMethod.HeaderText = "PayMethod"
        Me.BDPaymentMethod.Name = "BDPaymentMethod"
        Me.BDPaymentMethod.Width = 75
        '
        'BDCheckNumber
        '
        Me.BDCheckNumber.DataPropertyName = "CheckNumber"
        Me.BDCheckNumber.HeaderText = "Check#"
        Me.BDCheckNumber.Name = "BDCheckNumber"
        Me.BDCheckNumber.Width = 60
        '
        'BillingHeaderBindingSource
        '
        Me.BillingHeaderBindingSource.DataMember = "BillingHeader"
        Me.BillingHeaderBindingSource.DataSource = Me.ARDataSet
        '
        'ARDataSet
        '
        Me.ARDataSet.DataSetName = "ARDataSet"
        Me.ARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillingDetailBindingSource
        '
        Me.BillingDetailBindingSource.DataMember = "BillingDetail"
        Me.BillingDetailBindingSource.DataSource = Me.ARDataSet
        '
        'BDId
        '
        Me.BDId.DataPropertyName = "ID"
        Me.BDId.HeaderText = "ID"
        Me.BDId.Name = "BDId"
        Me.BDId.ReadOnly = True
        Me.BDId.Width = 35
        '
        'BDChartNumber
        '
        Me.BDChartNumber.DataPropertyName = "ChartNumber"
        Me.BDChartNumber.HeaderText = "Chart#"
        Me.BDChartNumber.Name = "BDChartNumber"
        Me.BDChartNumber.Width = 50
        '
        'BDCaseNumber
        '
        Me.BDCaseNumber.DataPropertyName = "CaseNumber"
        Me.BDCaseNumber.HeaderText = "Case#"
        Me.BDCaseNumber.Name = "BDCaseNumber"
        Me.BDCaseNumber.Width = 50
        '
        'BDServiceDate1
        '
        Me.BDServiceDate1.DataPropertyName = "ServiceDate1"
        Me.BDServiceDate1.HeaderText = "ServiceDate1"
        Me.BDServiceDate1.Name = "BDServiceDate1"
        Me.BDServiceDate1.Width = 75
        '
        'BDCharge
        '
        Me.BDCharge.DataPropertyName = "Charge"
        Me.BDCharge.HeaderText = "Charge"
        Me.BDCharge.Name = "BDCharge"
        Me.BDCharge.Width = 50
        '
        'BDUnits
        '
        Me.BDUnits.DataPropertyName = "Units"
        Me.BDUnits.HeaderText = "Units"
        Me.BDUnits.Name = "BDUnits"
        Me.BDUnits.Width = 35
        '
        'BDExtended
        '
        Me.BDExtended.DataPropertyName = "Extended"
        Me.BDExtended.HeaderText = "Extended"
        Me.BDExtended.Name = "BDExtended"
        Me.BDExtended.ReadOnly = True
        Me.BDExtended.Width = 55
        '
        'BDReceived
        '
        Me.BDReceived.DataPropertyName = "Received"
        Me.BDReceived.HeaderText = "Received"
        Me.BDReceived.Name = "BDReceived"
        Me.BDReceived.ReadOnly = True
        Me.BDReceived.Width = 55
        '
        'BDCPTCode
        '
        Me.BDCPTCode.DataPropertyName = "CPTCode"
        Me.BDCPTCode.HeaderText = "CPTCode"
        Me.BDCPTCode.Name = "BDCPTCode"
        Me.BDCPTCode.ReadOnly = True
        Me.BDCPTCode.Width = 65
        '
        'DataGridViewTextBoxColumn134
        '
        Me.DataGridViewTextBoxColumn134.DataPropertyName = "PatientPortion"
        Me.DataGridViewTextBoxColumn134.HeaderText = "PtPortion"
        Me.DataGridViewTextBoxColumn134.Name = "DataGridViewTextBoxColumn134"
        Me.DataGridViewTextBoxColumn134.Width = 60
        '
        'DataGridViewTextBoxColumn172
        '
        Me.DataGridViewTextBoxColumn172.DataPropertyName = "Allowed"
        Me.DataGridViewTextBoxColumn172.HeaderText = "Allowed"
        Me.DataGridViewTextBoxColumn172.Name = "DataGridViewTextBoxColumn172"
        Me.DataGridViewTextBoxColumn172.Width = 60
        '
        'BDDateEntered
        '
        Me.BDDateEntered.DataPropertyName = "DateEntered"
        Me.BDDateEntered.HeaderText = "DateEntered"
        Me.BDDateEntered.Name = "BDDateEntered"
        '
        'BDDateCreated
        '
        Me.BDDateCreated.DataPropertyName = "DateCreated"
        Me.BDDateCreated.HeaderText = "DateCreated"
        Me.BDDateCreated.Name = "BDDateCreated"
        Me.BDDateCreated.Width = 75
        '
        'DataGridViewTextBoxColumn120
        '
        Me.DataGridViewTextBoxColumn120.DataPropertyName = "Dx1"
        Me.DataGridViewTextBoxColumn120.HeaderText = "Dx1"
        Me.DataGridViewTextBoxColumn120.Name = "DataGridViewTextBoxColumn120"
        Me.DataGridViewTextBoxColumn120.Width = 50
        '
        'DataGridViewTextBoxColumn121
        '
        Me.DataGridViewTextBoxColumn121.DataPropertyName = "Dx2"
        Me.DataGridViewTextBoxColumn121.HeaderText = "Dx2"
        Me.DataGridViewTextBoxColumn121.Name = "DataGridViewTextBoxColumn121"
        Me.DataGridViewTextBoxColumn121.Width = 50
        '
        'DataGridViewTextBoxColumn122
        '
        Me.DataGridViewTextBoxColumn122.DataPropertyName = "Dx3"
        Me.DataGridViewTextBoxColumn122.HeaderText = "Dx3"
        Me.DataGridViewTextBoxColumn122.Name = "DataGridViewTextBoxColumn122"
        Me.DataGridViewTextBoxColumn122.Width = 50
        '
        'DataGridViewTextBoxColumn123
        '
        Me.DataGridViewTextBoxColumn123.DataPropertyName = "Dx4"
        Me.DataGridViewTextBoxColumn123.HeaderText = "Dx4"
        Me.DataGridViewTextBoxColumn123.Name = "DataGridViewTextBoxColumn123"
        Me.DataGridViewTextBoxColumn123.Width = 50
        '
        'DataGridViewTextBoxColumn124
        '
        Me.DataGridViewTextBoxColumn124.DataPropertyName = "Dx5"
        Me.DataGridViewTextBoxColumn124.HeaderText = "Dx5"
        Me.DataGridViewTextBoxColumn124.Name = "DataGridViewTextBoxColumn124"
        Me.DataGridViewTextBoxColumn124.Width = 50
        '
        'DataGridViewTextBoxColumn126
        '
        Me.DataGridViewTextBoxColumn126.DataPropertyName = "Modifier1"
        Me.DataGridViewTextBoxColumn126.HeaderText = "M1"
        Me.DataGridViewTextBoxColumn126.Name = "DataGridViewTextBoxColumn126"
        Me.DataGridViewTextBoxColumn126.Width = 25
        '
        'DataGridViewTextBoxColumn127
        '
        Me.DataGridViewTextBoxColumn127.DataPropertyName = "Modifier2"
        Me.DataGridViewTextBoxColumn127.HeaderText = "M2"
        Me.DataGridViewTextBoxColumn127.Name = "DataGridViewTextBoxColumn127"
        Me.DataGridViewTextBoxColumn127.Width = 25
        '
        'DataGridViewTextBoxColumn128
        '
        Me.DataGridViewTextBoxColumn128.DataPropertyName = "Modifier3"
        Me.DataGridViewTextBoxColumn128.HeaderText = "M3"
        Me.DataGridViewTextBoxColumn128.Name = "DataGridViewTextBoxColumn128"
        Me.DataGridViewTextBoxColumn128.Width = 25
        '
        'DataGridViewTextBoxColumn129
        '
        Me.DataGridViewTextBoxColumn129.DataPropertyName = "Modifier4"
        Me.DataGridViewTextBoxColumn129.HeaderText = "M4"
        Me.DataGridViewTextBoxColumn129.Name = "DataGridViewTextBoxColumn129"
        Me.DataGridViewTextBoxColumn129.Width = 25
        '
        'DataGridViewTextBoxColumn86
        '
        Me.DataGridViewTextBoxColumn86.DataPropertyName = "ServiceDate2"
        Me.DataGridViewTextBoxColumn86.HeaderText = "ServiceDate2"
        Me.DataGridViewTextBoxColumn86.Name = "DataGridViewTextBoxColumn86"
        Me.DataGridViewTextBoxColumn86.Width = 75
        '
        'BDAssignedProvider
        '
        Me.BDAssignedProvider.DataPropertyName = "AssignedProvider"
        Me.BDAssignedProvider.HeaderText = "Provider"
        Me.BDAssignedProvider.Name = "BDAssignedProvider"
        Me.BDAssignedProvider.Width = 60
        '
        'DataGridViewTextBoxColumn125
        '
        Me.DataGridViewTextBoxColumn125.DataPropertyName = "TransactionID"
        Me.DataGridViewTextBoxColumn125.HeaderText = "TransactionID"
        Me.DataGridViewTextBoxColumn125.Name = "DataGridViewTextBoxColumn125"
        '
        'DataGridViewTextBoxColumn135
        '
        Me.DataGridViewTextBoxColumn135.DataPropertyName = "DaySheetFlag"
        Me.DataGridViewTextBoxColumn135.HeaderText = "DaySheetFlag"
        Me.DataGridViewTextBoxColumn135.Name = "DataGridViewTextBoxColumn135"
        '
        'DataGridViewTextBoxColumn136
        '
        Me.DataGridViewTextBoxColumn136.DataPropertyName = "Note"
        Me.DataGridViewTextBoxColumn136.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn136.Name = "DataGridViewTextBoxColumn136"
        '
        'DataGridViewTextBoxColumn137
        '
        Me.DataGridViewTextBoxColumn137.DataPropertyName = "AttendingProvider"
        Me.DataGridViewTextBoxColumn137.HeaderText = "AttendingProvider"
        Me.DataGridViewTextBoxColumn137.Name = "DataGridViewTextBoxColumn137"
        '
        'DataGridViewTextBoxColumn139
        '
        Me.DataGridViewTextBoxColumn139.DataPropertyName = "PrintNoteStatement"
        Me.DataGridViewTextBoxColumn139.HeaderText = "PrintNoteStatement"
        Me.DataGridViewTextBoxColumn139.Name = "DataGridViewTextBoxColumn139"
        '
        'DataGridViewTextBoxColumn119
        '
        Me.DataGridViewTextBoxColumn119.DataPropertyName = "LocationID"
        Me.DataGridViewTextBoxColumn119.HeaderText = "LocationID"
        Me.DataGridViewTextBoxColumn119.Name = "DataGridViewTextBoxColumn119"
        '
        'DataGridViewTextBoxColumn140
        '
        Me.DataGridViewTextBoxColumn140.DataPropertyName = "PrintNoteInsurance"
        Me.DataGridViewTextBoxColumn140.HeaderText = "PrintNoteInsurance"
        Me.DataGridViewTextBoxColumn140.Name = "DataGridViewTextBoxColumn140"
        '
        'DataGridViewTextBoxColumn141
        '
        Me.DataGridViewTextBoxColumn141.DataPropertyName = "Posted"
        Me.DataGridViewTextBoxColumn141.HeaderText = "Posted"
        Me.DataGridViewTextBoxColumn141.Name = "DataGridViewTextBoxColumn141"
        '
        'DataGridViewTextBoxColumn142
        '
        Me.DataGridViewTextBoxColumn142.DataPropertyName = "Item"
        Me.DataGridViewTextBoxColumn142.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn142.Name = "DataGridViewTextBoxColumn142"
        '
        'DataGridViewTextBoxColumn143
        '
        Me.DataGridViewTextBoxColumn143.DataPropertyName = "SubItem"
        Me.DataGridViewTextBoxColumn143.HeaderText = "SubItem"
        Me.DataGridViewTextBoxColumn143.Name = "DataGridViewTextBoxColumn143"
        '
        'DataGridViewTextBoxColumn144
        '
        Me.DataGridViewTextBoxColumn144.DataPropertyName = "PrintDetail"
        Me.DataGridViewTextBoxColumn144.HeaderText = "PrintDetail"
        Me.DataGridViewTextBoxColumn144.Name = "DataGridViewTextBoxColumn144"
        '
        'DataGridViewTextBoxColumn145
        '
        Me.DataGridViewTextBoxColumn145.DataPropertyName = "AnesthesiaMinutes"
        Me.DataGridViewTextBoxColumn145.HeaderText = "AnesthesiaMinutes"
        Me.DataGridViewTextBoxColumn145.Name = "DataGridViewTextBoxColumn145"
        '
        'DataGridViewTextBoxColumn146
        '
        Me.DataGridViewTextBoxColumn146.DataPropertyName = "NarrativeType"
        Me.DataGridViewTextBoxColumn146.HeaderText = "NarrativeType"
        Me.DataGridViewTextBoxColumn146.Name = "DataGridViewTextBoxColumn146"
        '
        'DataGridViewTextBoxColumn147
        '
        Me.DataGridViewTextBoxColumn147.DataPropertyName = "Narrative"
        Me.DataGridViewTextBoxColumn147.HeaderText = "Narrative"
        Me.DataGridViewTextBoxColumn147.Name = "DataGridViewTextBoxColumn147"
        '
        'DataGridViewTextBoxColumn149
        '
        Me.DataGridViewTextBoxColumn149.DataPropertyName = "TimeEntered"
        Me.DataGridViewTextBoxColumn149.HeaderText = "TimeEntered"
        Me.DataGridViewTextBoxColumn149.Name = "DataGridViewTextBoxColumn149"
        '
        'DataGridViewTextBoxColumn150
        '
        Me.DataGridViewTextBoxColumn150.DataPropertyName = "Taxable"
        Me.DataGridViewTextBoxColumn150.HeaderText = "Taxable"
        Me.DataGridViewTextBoxColumn150.Name = "DataGridViewTextBoxColumn150"
        '
        'DataGridViewTextBoxColumn151
        '
        Me.DataGridViewTextBoxColumn151.DataPropertyName = "ChargePatientOnly"
        Me.DataGridViewTextBoxColumn151.HeaderText = "ChargePatientOnly"
        Me.DataGridViewTextBoxColumn151.Name = "DataGridViewTextBoxColumn151"
        '
        'DataGridViewTextBoxColumn152
        '
        Me.DataGridViewTextBoxColumn152.DataPropertyName = "TransportType"
        Me.DataGridViewTextBoxColumn152.HeaderText = "TransportType"
        Me.DataGridViewTextBoxColumn152.Name = "DataGridViewTextBoxColumn152"
        '
        'DataGridViewTextBoxColumn153
        '
        Me.DataGridViewTextBoxColumn153.DataPropertyName = "TransportedTo"
        Me.DataGridViewTextBoxColumn153.HeaderText = "TransportedTo"
        Me.DataGridViewTextBoxColumn153.Name = "DataGridViewTextBoxColumn153"
        '
        'DataGridViewTextBoxColumn154
        '
        Me.DataGridViewTextBoxColumn154.DataPropertyName = "Miles"
        Me.DataGridViewTextBoxColumn154.HeaderText = "Miles"
        Me.DataGridViewTextBoxColumn154.Name = "DataGridViewTextBoxColumn154"
        '
        'DataGridViewTextBoxColumn155
        '
        Me.DataGridViewTextBoxColumn155.DataPropertyName = "Weight"
        Me.DataGridViewTextBoxColumn155.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn155.Name = "DataGridViewTextBoxColumn155"
        '
        'DataGridViewTextBoxColumn156
        '
        Me.DataGridViewTextBoxColumn156.DataPropertyName = "Admit"
        Me.DataGridViewTextBoxColumn156.HeaderText = "Admit"
        Me.DataGridViewTextBoxColumn156.Name = "DataGridViewTextBoxColumn156"
        '
        'DataGridViewTextBoxColumn157
        '
        Me.DataGridViewTextBoxColumn157.DataPropertyName = "Discharged"
        Me.DataGridViewTextBoxColumn157.HeaderText = "Discharged"
        Me.DataGridViewTextBoxColumn157.Name = "DataGridViewTextBoxColumn157"
        '
        'DataGridViewTextBoxColumn158
        '
        Me.DataGridViewTextBoxColumn158.DataPropertyName = "Unconscious"
        Me.DataGridViewTextBoxColumn158.HeaderText = "Unconscious"
        Me.DataGridViewTextBoxColumn158.Name = "DataGridViewTextBoxColumn158"
        '
        'DataGridViewTextBoxColumn159
        '
        Me.DataGridViewTextBoxColumn159.DataPropertyName = "Restraints"
        Me.DataGridViewTextBoxColumn159.HeaderText = "Restraints"
        Me.DataGridViewTextBoxColumn159.Name = "DataGridViewTextBoxColumn159"
        '
        'DataGridViewTextBoxColumn160
        '
        Me.DataGridViewTextBoxColumn160.DataPropertyName = "Hemorrhaging"
        Me.DataGridViewTextBoxColumn160.HeaderText = "Hemorrhaging"
        Me.DataGridViewTextBoxColumn160.Name = "DataGridViewTextBoxColumn160"
        '
        'DataGridViewTextBoxColumn161
        '
        Me.DataGridViewTextBoxColumn161.DataPropertyName = "MedNecessary"
        Me.DataGridViewTextBoxColumn161.HeaderText = "MedNecessary"
        Me.DataGridViewTextBoxColumn161.Name = "DataGridViewTextBoxColumn161"
        '
        'DataGridViewTextBoxColumn162
        '
        Me.DataGridViewTextBoxColumn162.DataPropertyName = "Admitted"
        Me.DataGridViewTextBoxColumn162.HeaderText = "Admitted"
        Me.DataGridViewTextBoxColumn162.Name = "DataGridViewTextBoxColumn162"
        '
        'DataGridViewTextBoxColumn163
        '
        Me.DataGridViewTextBoxColumn163.DataPropertyName = "ServicesAvail"
        Me.DataGridViewTextBoxColumn163.HeaderText = "ServicesAvail"
        Me.DataGridViewTextBoxColumn163.Name = "DataGridViewTextBoxColumn163"
        '
        'DataGridViewTextBoxColumn164
        '
        Me.DataGridViewTextBoxColumn164.DataPropertyName = "ConfinedBefore"
        Me.DataGridViewTextBoxColumn164.HeaderText = "ConfinedBefore"
        Me.DataGridViewTextBoxColumn164.Name = "DataGridViewTextBoxColumn164"
        '
        'DataGridViewTextBoxColumn165
        '
        Me.DataGridViewTextBoxColumn165.DataPropertyName = "ConfinedAfter"
        Me.DataGridViewTextBoxColumn165.HeaderText = "ConfinedAfter"
        Me.DataGridViewTextBoxColumn165.Name = "DataGridViewTextBoxColumn165"
        '
        'DataGridViewTextBoxColumn166
        '
        Me.DataGridViewTextBoxColumn166.DataPropertyName = "MovedStretcher"
        Me.DataGridViewTextBoxColumn166.HeaderText = "MovedStretcher"
        Me.DataGridViewTextBoxColumn166.Name = "DataGridViewTextBoxColumn166"
        '
        'DataGridViewTextBoxColumn167
        '
        Me.DataGridViewTextBoxColumn167.DataPropertyName = "StretcherReason"
        Me.DataGridViewTextBoxColumn167.HeaderText = "StretcherReason"
        Me.DataGridViewTextBoxColumn167.Name = "DataGridViewTextBoxColumn167"
        '
        'DataGridViewTextBoxColumn168
        '
        Me.DataGridViewTextBoxColumn168.DataPropertyName = "Destination"
        Me.DataGridViewTextBoxColumn168.HeaderText = "Destination"
        Me.DataGridViewTextBoxColumn168.Name = "DataGridViewTextBoxColumn168"
        '
        'DataGridViewTextBoxColumn169
        '
        Me.DataGridViewTextBoxColumn169.DataPropertyName = "Origin"
        Me.DataGridViewTextBoxColumn169.HeaderText = "Origin"
        Me.DataGridViewTextBoxColumn169.Name = "DataGridViewTextBoxColumn169"
        '
        'DataGridViewTextBoxColumn170
        '
        Me.DataGridViewTextBoxColumn170.DataPropertyName = "RoundTripReason"
        Me.DataGridViewTextBoxColumn170.HeaderText = "RoundTripReason"
        Me.DataGridViewTextBoxColumn170.Name = "DataGridViewTextBoxColumn170"
        '
        'DataGridViewTextBoxColumn171
        '
        Me.DataGridViewTextBoxColumn171.DataPropertyName = "RVUValue"
        Me.DataGridViewTextBoxColumn171.HeaderText = "RVUValue"
        Me.DataGridViewTextBoxColumn171.Name = "DataGridViewTextBoxColumn171"
        '
        'DataGridViewTextBoxColumn174
        '
        Me.DataGridViewTextBoxColumn174.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn174.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn174.Name = "DataGridViewTextBoxColumn174"
        '
        'DataGridViewTextBoxColumn175
        '
        Me.DataGridViewTextBoxColumn175.DataPropertyName = "TypeOfService"
        Me.DataGridViewTextBoxColumn175.HeaderText = "TypeOfService"
        Me.DataGridViewTextBoxColumn175.Name = "DataGridViewTextBoxColumn175"
        '
        'DataGridViewTextBoxColumn176
        '
        Me.DataGridViewTextBoxColumn176.DataPropertyName = "CustomField"
        Me.DataGridViewTextBoxColumn176.HeaderText = "CustomField"
        Me.DataGridViewTextBoxColumn176.Name = "DataGridViewTextBoxColumn176"
        '
        'DataGridViewTextBoxColumn177
        '
        Me.DataGridViewTextBoxColumn177.DataPropertyName = "PaymentID"
        Me.DataGridViewTextBoxColumn177.HeaderText = "PaymentID"
        Me.DataGridViewTextBoxColumn177.Name = "DataGridViewTextBoxColumn177"
        '
        'DataGridViewTextBoxColumn178
        '
        Me.DataGridViewTextBoxColumn178.DataPropertyName = "PrimaryClaimID"
        Me.DataGridViewTextBoxColumn178.HeaderText = "PrimaryClaimID"
        Me.DataGridViewTextBoxColumn178.Name = "DataGridViewTextBoxColumn178"
        '
        'DataGridViewTextBoxColumn179
        '
        Me.DataGridViewTextBoxColumn179.DataPropertyName = "SecondaryClaimID"
        Me.DataGridViewTextBoxColumn179.HeaderText = "SecondaryClaimID"
        Me.DataGridViewTextBoxColumn179.Name = "DataGridViewTextBoxColumn179"
        '
        'DataGridViewTextBoxColumn180
        '
        Me.DataGridViewTextBoxColumn180.DataPropertyName = "TertiaryClaimID"
        Me.DataGridViewTextBoxColumn180.HeaderText = "TertiaryClaimID"
        Me.DataGridViewTextBoxColumn180.Name = "DataGridViewTextBoxColumn180"
        '
        'DataGridViewTextBoxColumn181
        '
        Me.DataGridViewTextBoxColumn181.DataPropertyName = "Timestamp"
        Me.DataGridViewTextBoxColumn181.HeaderText = "Timestamp"
        Me.DataGridViewTextBoxColumn181.Name = "DataGridViewTextBoxColumn181"
        '
        'DataGridViewTextBoxColumn182
        '
        Me.DataGridViewTextBoxColumn182.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn182.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn182.Name = "DataGridViewTextBoxColumn182"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 35
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Chart#"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 65
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "InsuranceFlag"
        Me.DataGridViewTextBoxColumn11.HeaderText = "InsuranceFlag"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DateCreated"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DateCreated"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ServiceDate"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ServiceDate"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'BHCharges
        '
        Me.BHCharges.DataPropertyName = "Charges"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.BHCharges.DefaultCellStyle = DataGridViewCellStyle6
        Me.BHCharges.HeaderText = "Charges"
        Me.BHCharges.Name = "BHCharges"
        Me.BHCharges.Width = 65
        '
        'BHPayments
        '
        Me.BHPayments.DataPropertyName = "Payments"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.BHPayments.DefaultCellStyle = DataGridViewCellStyle7
        Me.BHPayments.HeaderText = "Payments"
        Me.BHPayments.Name = "BHPayments"
        Me.BHPayments.Width = 65
        '
        'BHTotal
        '
        Me.BHTotal.DataPropertyName = "Total"
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.BHTotal.DefaultCellStyle = DataGridViewCellStyle8
        Me.BHTotal.HeaderText = "Total"
        Me.BHTotal.Name = "BHTotal"
        Me.BHTotal.Width = 65
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "Copay"
        Me.DataGridViewTextBoxColumn67.HeaderText = "Copay"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "BillPatient"
        Me.DataGridViewTextBoxColumn14.HeaderText = "BillPatient"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "BillPrimary"
        Me.DataGridViewTextBoxColumn15.HeaderText = "BillPrimary"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "BillSecondary"
        Me.DataGridViewTextBoxColumn16.HeaderText = "BillSecondary"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "BillTertiary"
        Me.DataGridViewTextBoxColumn17.HeaderText = "BillTertiary"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PrimInsPay"
        Me.DataGridViewTextBoxColumn18.HeaderText = "PrimInsPay"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "SecInsPay"
        Me.DataGridViewTextBoxColumn19.HeaderText = "SecInsPay"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TertInsPay"
        Me.DataGridViewTextBoxColumn20.HeaderText = "TertInsPay"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "PartialPrimPay"
        Me.DataGridViewTextBoxColumn21.HeaderText = "PartialPrimPay"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "PartialSecPay"
        Me.DataGridViewTextBoxColumn22.HeaderText = "PartialSecPay"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "PartialTerPay"
        Me.DataGridViewTextBoxColumn23.HeaderText = "PartialTerPay"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "PrimaryCode"
        Me.DataGridViewTextBoxColumn24.HeaderText = "PrimaryCode"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "PrimaryType"
        Me.DataGridViewTextBoxColumn25.HeaderText = "PrimaryType"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "PrimaryAutoBill"
        Me.DataGridViewTextBoxColumn28.HeaderText = "PrimaryAutoBill"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "PrimAcceptAssign"
        Me.DataGridViewTextBoxColumn29.HeaderText = "PrimAcceptAssign"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "PrimaryAuth"
        Me.DataGridViewTextBoxColumn30.HeaderText = "PrimaryAuth"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "PrimaryInsIs"
        Me.DataGridViewTextBoxColumn31.HeaderText = "PrimaryInsIs"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "PrimaryInsPatient"
        Me.DataGridViewTextBoxColumn32.HeaderText = "PrimaryInsPatient"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "PrimaryInsGuarantor"
        Me.DataGridViewTextBoxColumn33.HeaderText = "PrimaryInsGuarantor"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "PrimaryInsRelation"
        Me.DataGridViewTextBoxColumn34.HeaderText = "PrimaryInsRelation"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "PrimaryPCAClaimNumber"
        Me.DataGridViewTextBoxColumn35.HeaderText = "PrimaryPCAClaimNumber"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "PrimaryInsEffectiveDateFrom"
        Me.DataGridViewTextBoxColumn36.HeaderText = "PrimaryInsEffectiveDateFrom"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "PrimaryInsEffectiveDateTo"
        Me.DataGridViewTextBoxColumn37.HeaderText = "PrimaryInsEffectiveDateTo"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "SecondaryCode"
        Me.DataGridViewTextBoxColumn38.HeaderText = "SecondaryCode"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "SecondaryType"
        Me.DataGridViewTextBoxColumn39.HeaderText = "SecondaryType"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "SecondaryAutoBill"
        Me.DataGridViewTextBoxColumn42.HeaderText = "SecondaryAutoBill"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "SecAcceptAssign"
        Me.DataGridViewTextBoxColumn43.HeaderText = "SecAcceptAssign"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "SecondaryAuth"
        Me.DataGridViewTextBoxColumn44.HeaderText = "SecondaryAuth"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "SecondaryInsIs"
        Me.DataGridViewTextBoxColumn45.HeaderText = "SecondaryInsIs"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "SecondaryInsPatient"
        Me.DataGridViewTextBoxColumn46.HeaderText = "SecondaryInsPatient"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "SecondaryInsGuarantor"
        Me.DataGridViewTextBoxColumn47.HeaderText = "SecondaryInsGuarantor"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "SecondInsRelation"
        Me.DataGridViewTextBoxColumn48.HeaderText = "SecondInsRelation"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "SecondaryPCAClaimNumber"
        Me.DataGridViewTextBoxColumn49.HeaderText = "SecondaryPCAClaimNumber"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "SecondaryInsDateEffectiveFrom"
        Me.DataGridViewTextBoxColumn50.HeaderText = "SecondaryInsDateEffectiveFrom"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "SecondaryInsDateEffectiveTo"
        Me.DataGridViewTextBoxColumn51.HeaderText = "SecondaryInsDateEffectiveTo"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "TertiaryCode"
        Me.DataGridViewTextBoxColumn52.HeaderText = "TertiaryCode"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "TertiaryType"
        Me.DataGridViewTextBoxColumn53.HeaderText = "TertiaryType"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "TertiaryID"
        Me.DataGridViewTextBoxColumn55.HeaderText = "TertiaryID"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "TertiaryAutoBill"
        Me.DataGridViewTextBoxColumn56.HeaderText = "TertiaryAutoBill"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "TertAcceptAssign"
        Me.DataGridViewTextBoxColumn57.HeaderText = "TertAcceptAssign"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "TertiaryAuth"
        Me.DataGridViewTextBoxColumn59.HeaderText = "TertiaryAuth"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "TertiaryInsIs"
        Me.DataGridViewTextBoxColumn60.HeaderText = "TertiaryInsIs"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "TertiaryInsPatient"
        Me.DataGridViewTextBoxColumn61.HeaderText = "TertiaryInsPatient"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "TertiaryInsdGuarantor"
        Me.DataGridViewTextBoxColumn62.HeaderText = "TertiaryInsdGuarantor"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "TertInsRelation"
        Me.DataGridViewTextBoxColumn63.HeaderText = "TertInsRelation"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "TertiaryPCAClaimNumber"
        Me.DataGridViewTextBoxColumn64.HeaderText = "TertiaryPCAClaimNumber"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "TertiaryInsDateEffectiveFrom"
        Me.DataGridViewTextBoxColumn65.HeaderText = "TertiaryInsDateEffectiveFrom"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "TertiaryInsDateEffectiveTo"
        Me.DataGridViewTextBoxColumn66.HeaderText = "TertiaryInsDateEffectiveTo"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "ProviderID"
        Me.DataGridViewTextBoxColumn71.HeaderText = "ProviderID"
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "SymptomType"
        Me.DataGridViewTextBoxColumn72.HeaderText = "SymptomType"
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.DataPropertyName = "SymptomDate"
        Me.DataGridViewTextBoxColumn73.HeaderText = "SymptomDate"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.DataPropertyName = "Consultation1"
        Me.DataGridViewTextBoxColumn74.HeaderText = "Consultation1"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.DataPropertyName = "Consultation2"
        Me.DataGridViewTextBoxColumn75.HeaderText = "Consultation2"
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        '
        'DataGridViewTextBoxColumn76
        '
        Me.DataGridViewTextBoxColumn76.DataPropertyName = "ReturnToWorkType"
        Me.DataGridViewTextBoxColumn76.HeaderText = "ReturnToWorkType"
        Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
        '
        'DataGridViewTextBoxColumn77
        '
        Me.DataGridViewTextBoxColumn77.DataPropertyName = "ReturnToWorkDate"
        Me.DataGridViewTextBoxColumn77.HeaderText = "ReturnToWorkDate"
        Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
        '
        'DataGridViewTextBoxColumn78
        '
        Me.DataGridViewTextBoxColumn78.DataPropertyName = "AccidentType"
        Me.DataGridViewTextBoxColumn78.HeaderText = "AccidentType"
        Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
        '
        'DataGridViewTextBoxColumn79
        '
        Me.DataGridViewTextBoxColumn79.DataPropertyName = "AccidentState"
        Me.DataGridViewTextBoxColumn79.HeaderText = "AccidentState"
        Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
        '
        'DataGridViewTextBoxColumn80
        '
        Me.DataGridViewTextBoxColumn80.DataPropertyName = "AccidentDate"
        Me.DataGridViewTextBoxColumn80.HeaderText = "AccidentDate"
        Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
        '
        'DataGridViewTextBoxColumn81
        '
        Me.DataGridViewTextBoxColumn81.DataPropertyName = "Hospitalization1"
        Me.DataGridViewTextBoxColumn81.HeaderText = "Hospitalization1"
        Me.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81"
        '
        'DataGridViewTextBoxColumn82
        '
        Me.DataGridViewTextBoxColumn82.DataPropertyName = "Hospitalization2"
        Me.DataGridViewTextBoxColumn82.HeaderText = "Hospitalization2"
        Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
        '
        'DataGridViewTextBoxColumn83
        '
        Me.DataGridViewTextBoxColumn83.DataPropertyName = "Facility"
        Me.DataGridViewTextBoxColumn83.HeaderText = "Facility"
        Me.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83"
        '
        'DataGridViewTextBoxColumn84
        '
        Me.DataGridViewTextBoxColumn84.DataPropertyName = "LabCharge"
        Me.DataGridViewTextBoxColumn84.HeaderText = "LabCharge"
        Me.DataGridViewTextBoxColumn84.Name = "DataGridViewTextBoxColumn84"
        '
        'DataGridViewTextBoxColumn85
        '
        Me.DataGridViewTextBoxColumn85.DataPropertyName = "LabChargeAmount"
        Me.DataGridViewTextBoxColumn85.HeaderText = "LabChargeAmount"
        Me.DataGridViewTextBoxColumn85.Name = "DataGridViewTextBoxColumn85"
        '
        'DataGridViewTextBoxColumn87
        '
        Me.DataGridViewTextBoxColumn87.DataPropertyName = "SimilarSymptom"
        Me.DataGridViewTextBoxColumn87.HeaderText = "SimilarSymptom"
        Me.DataGridViewTextBoxColumn87.Name = "DataGridViewTextBoxColumn87"
        '
        'DataGridViewTextBoxColumn88
        '
        Me.DataGridViewTextBoxColumn88.DataPropertyName = "SimilarSymptomDate"
        Me.DataGridViewTextBoxColumn88.HeaderText = "SimilarSymptomDate"
        Me.DataGridViewTextBoxColumn88.Name = "DataGridViewTextBoxColumn88"
        '
        'DataGridViewTextBoxColumn89
        '
        Me.DataGridViewTextBoxColumn89.DataPropertyName = "EmploymentRelated"
        Me.DataGridViewTextBoxColumn89.HeaderText = "EmploymentRelated"
        Me.DataGridViewTextBoxColumn89.Name = "DataGridViewTextBoxColumn89"
        '
        'DataGridViewTextBoxColumn90
        '
        Me.DataGridViewTextBoxColumn90.DataPropertyName = "Emergency"
        Me.DataGridViewTextBoxColumn90.HeaderText = "Emergency"
        Me.DataGridViewTextBoxColumn90.Name = "DataGridViewTextBoxColumn90"
        '
        'DataGridViewTextBoxColumn91
        '
        Me.DataGridViewTextBoxColumn91.DataPropertyName = "ManagedPlanCode"
        Me.DataGridViewTextBoxColumn91.HeaderText = "ManagedPlanCode"
        Me.DataGridViewTextBoxColumn91.Name = "DataGridViewTextBoxColumn91"
        '
        'DataGridViewTextBoxColumn92
        '
        Me.DataGridViewTextBoxColumn92.DataPropertyName = "LastXray"
        Me.DataGridViewTextBoxColumn92.HeaderText = "LastXray"
        Me.DataGridViewTextBoxColumn92.Name = "DataGridViewTextBoxColumn92"
        '
        'DataGridViewTextBoxColumn93
        '
        Me.DataGridViewTextBoxColumn93.DataPropertyName = "LastItem"
        Me.DataGridViewTextBoxColumn93.HeaderText = "LastItem"
        Me.DataGridViewTextBoxColumn93.Name = "DataGridViewTextBoxColumn93"
        '
        'DataGridViewTextBoxColumn94
        '
        Me.DataGridViewTextBoxColumn94.DataPropertyName = "LaboratoryID"
        Me.DataGridViewTextBoxColumn94.HeaderText = "LaboratoryID"
        Me.DataGridViewTextBoxColumn94.Name = "DataGridViewTextBoxColumn94"
        '
        'DataGridViewTextBoxColumn95
        '
        Me.DataGridViewTextBoxColumn95.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn95.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn95.Name = "DataGridViewTextBoxColumn95"
        '
        'DataGridViewTextBoxColumn96
        '
        Me.DataGridViewTextBoxColumn96.DataPropertyName = "ResubmissionNumber"
        Me.DataGridViewTextBoxColumn96.HeaderText = "ResubmissionNumber"
        Me.DataGridViewTextBoxColumn96.Name = "DataGridViewTextBoxColumn96"
        '
        'DataGridViewTextBoxColumn97
        '
        Me.DataGridViewTextBoxColumn97.DataPropertyName = "OriginalRefNumber"
        Me.DataGridViewTextBoxColumn97.HeaderText = "OriginalRefNumber"
        Me.DataGridViewTextBoxColumn97.Name = "DataGridViewTextBoxColumn97"
        '
        'DataGridViewTextBoxColumn98
        '
        Me.DataGridViewTextBoxColumn98.DataPropertyName = "PCPLastSeen"
        Me.DataGridViewTextBoxColumn98.HeaderText = "PCPLastSeen"
        Me.DataGridViewTextBoxColumn98.Name = "DataGridViewTextBoxColumn98"
        '
        'DataGridViewTextBoxColumn99
        '
        Me.DataGridViewTextBoxColumn99.DataPropertyName = "PCP"
        Me.DataGridViewTextBoxColumn99.HeaderText = "PCP"
        Me.DataGridViewTextBoxColumn99.Name = "DataGridViewTextBoxColumn99"
        '
        'DataGridViewTextBoxColumn100
        '
        Me.DataGridViewTextBoxColumn100.DataPropertyName = "ConditionNature"
        Me.DataGridViewTextBoxColumn100.HeaderText = "ConditionNature"
        Me.DataGridViewTextBoxColumn100.Name = "DataGridViewTextBoxColumn100"
        '
        'DataGridViewTextBoxColumn101
        '
        Me.DataGridViewTextBoxColumn101.DataPropertyName = "ComplicationIndicator"
        Me.DataGridViewTextBoxColumn101.HeaderText = "ComplicationIndicator"
        Me.DataGridViewTextBoxColumn101.Name = "DataGridViewTextBoxColumn101"
        '
        'DataGridViewTextBoxColumn102
        '
        Me.DataGridViewTextBoxColumn102.DataPropertyName = "EPSDTFindings"
        Me.DataGridViewTextBoxColumn102.HeaderText = "EPSDTFindings"
        Me.DataGridViewTextBoxColumn102.Name = "DataGridViewTextBoxColumn102"
        '
        'DataGridViewTextBoxColumn103
        '
        Me.DataGridViewTextBoxColumn103.DataPropertyName = "EPSDTReferralItems"
        Me.DataGridViewTextBoxColumn103.HeaderText = "EPSDTReferralItems"
        Me.DataGridViewTextBoxColumn103.Name = "DataGridViewTextBoxColumn103"
        '
        'DataGridViewTextBoxColumn104
        '
        Me.DataGridViewTextBoxColumn104.DataPropertyName = "ExternalAccCause"
        Me.DataGridViewTextBoxColumn104.HeaderText = "ExternalAccCause"
        Me.DataGridViewTextBoxColumn104.Name = "DataGridViewTextBoxColumn104"
        '
        'DataGridViewTextBoxColumn105
        '
        Me.DataGridViewTextBoxColumn105.DataPropertyName = "PodiatryType"
        Me.DataGridViewTextBoxColumn105.HeaderText = "PodiatryType"
        Me.DataGridViewTextBoxColumn105.Name = "DataGridViewTextBoxColumn105"
        '
        'DataGridViewTextBoxColumn106
        '
        Me.DataGridViewTextBoxColumn106.DataPropertyName = "SystemicCondition"
        Me.DataGridViewTextBoxColumn106.HeaderText = "SystemicCondition"
        Me.DataGridViewTextBoxColumn106.Name = "DataGridViewTextBoxColumn106"
        '
        'DataGridViewTextBoxColumn107
        '
        Me.DataGridViewTextBoxColumn107.DataPropertyName = "ClassFindings"
        Me.DataGridViewTextBoxColumn107.HeaderText = "ClassFindings"
        Me.DataGridViewTextBoxColumn107.Name = "DataGridViewTextBoxColumn107"
        '
        'DataGridViewTextBoxColumn108
        '
        Me.DataGridViewTextBoxColumn108.DataPropertyName = "ForcePrintPrimary"
        Me.DataGridViewTextBoxColumn108.HeaderText = "ForcePrintPrimary"
        Me.DataGridViewTextBoxColumn108.Name = "DataGridViewTextBoxColumn108"
        '
        'DataGridViewTextBoxColumn109
        '
        Me.DataGridViewTextBoxColumn109.DataPropertyName = "ForcePrintSecondary"
        Me.DataGridViewTextBoxColumn109.HeaderText = "ForcePrintSecondary"
        Me.DataGridViewTextBoxColumn109.Name = "DataGridViewTextBoxColumn109"
        '
        'DataGridViewTextBoxColumn110
        '
        Me.DataGridViewTextBoxColumn110.DataPropertyName = "ForcePrintTertiary"
        Me.DataGridViewTextBoxColumn110.HeaderText = "ForcePrintTertiary"
        Me.DataGridViewTextBoxColumn110.Name = "DataGridViewTextBoxColumn110"
        '
        'DataGridViewTextBoxColumn111
        '
        Me.DataGridViewTextBoxColumn111.DataPropertyName = "ReferralDate"
        Me.DataGridViewTextBoxColumn111.HeaderText = "ReferralDate"
        Me.DataGridViewTextBoxColumn111.Name = "DataGridViewTextBoxColumn111"
        '
        'DataGridViewTextBoxColumn112
        '
        Me.DataGridViewTextBoxColumn112.DataPropertyName = "PregnancyIndicator"
        Me.DataGridViewTextBoxColumn112.HeaderText = "PregnancyIndicator"
        Me.DataGridViewTextBoxColumn112.Name = "DataGridViewTextBoxColumn112"
        '
        'DataGridViewTextBoxColumn113
        '
        Me.DataGridViewTextBoxColumn113.DataPropertyName = "EstimatedDOB"
        Me.DataGridViewTextBoxColumn113.HeaderText = "EstimatedDOB"
        Me.DataGridViewTextBoxColumn113.Name = "DataGridViewTextBoxColumn113"
        '
        'DataGridViewTextBoxColumn114
        '
        Me.DataGridViewTextBoxColumn114.DataPropertyName = "PrescriptionDate"
        Me.DataGridViewTextBoxColumn114.HeaderText = "PrescriptionDate"
        Me.DataGridViewTextBoxColumn114.Name = "DataGridViewTextBoxColumn114"
        '
        'DataGridViewTextBoxColumn115
        '
        Me.DataGridViewTextBoxColumn115.DataPropertyName = "LastWorkedDate"
        Me.DataGridViewTextBoxColumn115.HeaderText = "LastWorkedDate"
        Me.DataGridViewTextBoxColumn115.Name = "DataGridViewTextBoxColumn115"
        '
        'DataGridViewTextBoxColumn116
        '
        Me.DataGridViewTextBoxColumn116.DataPropertyName = "DateAssumedCare"
        Me.DataGridViewTextBoxColumn116.HeaderText = "DateAssumedCare"
        Me.DataGridViewTextBoxColumn116.Name = "DataGridViewTextBoxColumn116"
        '
        'DataGridViewTextBoxColumn117
        '
        Me.DataGridViewTextBoxColumn117.DataPropertyName = "DateReleasedCare"
        Me.DataGridViewTextBoxColumn117.HeaderText = "DateReleasedCare"
        Me.DataGridViewTextBoxColumn117.Name = "DataGridViewTextBoxColumn117"
        '
        'DataGridViewTextBoxColumn200
        '
        Me.DataGridViewTextBoxColumn200.DataPropertyName = "RefIDQualifier"
        Me.DataGridViewTextBoxColumn200.HeaderText = "RefIDQualifier"
        Me.DataGridViewTextBoxColumn200.Name = "DataGridViewTextBoxColumn200"
        '
        'DataGridViewTextBoxColumn201
        '
        Me.DataGridViewTextBoxColumn201.DataPropertyName = "SrvcAuthException"
        Me.DataGridViewTextBoxColumn201.HeaderText = "SrvcAuthException"
        Me.DataGridViewTextBoxColumn201.Name = "DataGridViewTextBoxColumn201"
        '
        'DataGridViewTextBoxColumn202
        '
        Me.DataGridViewTextBoxColumn202.DataPropertyName = "HomeboundIndicator"
        Me.DataGridViewTextBoxColumn202.HeaderText = "HomeboundIndicator"
        Me.DataGridViewTextBoxColumn202.Name = "DataGridViewTextBoxColumn202"
        '
        'DataGridViewTextBoxColumn203
        '
        Me.DataGridViewTextBoxColumn203.DataPropertyName = "SupervisingPysician"
        Me.DataGridViewTextBoxColumn203.HeaderText = "SupervisingPysician"
        Me.DataGridViewTextBoxColumn203.Name = "DataGridViewTextBoxColumn203"
        '
        'DataGridViewTextBoxColumn204
        '
        Me.DataGridViewTextBoxColumn204.DataPropertyName = "IDENumber"
        Me.DataGridViewTextBoxColumn204.HeaderText = "IDENumber"
        Me.DataGridViewTextBoxColumn204.Name = "DataGridViewTextBoxColumn204"
        '
        'DataGridViewTextBoxColumn205
        '
        Me.DataGridViewTextBoxColumn205.DataPropertyName = "CustomField"
        Me.DataGridViewTextBoxColumn205.HeaderText = "CustomField"
        Me.DataGridViewTextBoxColumn205.Name = "DataGridViewTextBoxColumn205"
        '
        'DataGridViewTextBoxColumn206
        '
        Me.DataGridViewTextBoxColumn206.DataPropertyName = "Timestamp"
        Me.DataGridViewTextBoxColumn206.HeaderText = "Timestamp"
        Me.DataGridViewTextBoxColumn206.Name = "DataGridViewTextBoxColumn206"
        '
        'DataGridViewTextBoxColumn207
        '
        Me.DataGridViewTextBoxColumn207.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn207.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn207.Name = "DataGridViewTextBoxColumn207"
        '
        'DataGridViewTextBoxColumn208
        '
        Me.DataGridViewTextBoxColumn208.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn208.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn208.Name = "DataGridViewTextBoxColumn208"
        '
        'DataGridViewTextBoxColumn209
        '
        Me.DataGridViewTextBoxColumn209.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn209.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn209.Name = "DataGridViewTextBoxColumn209"
        '
        'DataGridViewTextBoxColumn210
        '
        Me.DataGridViewTextBoxColumn210.DataPropertyName = "MiddleInitial"
        Me.DataGridViewTextBoxColumn210.HeaderText = "MiddleInitial"
        Me.DataGridViewTextBoxColumn210.Name = "DataGridViewTextBoxColumn210"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "EntryNumber"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Entry#"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        Me.DataGridViewTextBoxColumn58.Width = 50
        '
        'DataGridViewTextBoxColumn138
        '
        Me.DataGridViewTextBoxColumn138.DataPropertyName = "DepositDate"
        Me.DataGridViewTextBoxColumn138.HeaderText = "DepositDate"
        Me.DataGridViewTextBoxColumn138.Name = "DataGridViewTextBoxColumn138"
        Me.DataGridViewTextBoxColumn138.Width = 80
        '
        'DataGridViewTextBoxColumn188
        '
        Me.DataGridViewTextBoxColumn188.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn188.HeaderText = "Chart#"
        Me.DataGridViewTextBoxColumn188.Name = "DataGridViewTextBoxColumn188"
        Me.DataGridViewTextBoxColumn188.Width = 65
        '
        'DataGridViewTextBoxColumn196
        '
        Me.DataGridViewTextBoxColumn196.DataPropertyName = "CaseNumber"
        Me.DataGridViewTextBoxColumn196.HeaderText = "Case#"
        Me.DataGridViewTextBoxColumn196.Name = "DataGridViewTextBoxColumn196"
        Me.DataGridViewTextBoxColumn196.Width = 50
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Copay"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Copay"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn197
        '
        Me.DataGridViewTextBoxColumn197.DataPropertyName = "PayorType"
        Me.DataGridViewTextBoxColumn197.HeaderText = "PayorType"
        Me.DataGridViewTextBoxColumn197.Name = "DataGridViewTextBoxColumn197"
        '
        'DataGridViewTextBoxColumn186
        '
        Me.DataGridViewTextBoxColumn186.DataPropertyName = "PaymentMethod"
        Me.DataGridViewTextBoxColumn186.HeaderText = "PaymentMethod"
        Me.DataGridViewTextBoxColumn186.Name = "DataGridViewTextBoxColumn186"
        '
        'DataGridViewTextBoxColumn190
        '
        Me.DataGridViewTextBoxColumn190.DataPropertyName = "PaymentAmount"
        Me.DataGridViewTextBoxColumn190.HeaderText = "PaymentAmt"
        Me.DataGridViewTextBoxColumn190.Name = "DataGridViewTextBoxColumn190"
        Me.DataGridViewTextBoxColumn190.Width = 65
        '
        'DataGridViewTextBoxColumn198
        '
        Me.DataGridViewTextBoxColumn198.DataPropertyName = "CheckNumber"
        Me.DataGridViewTextBoxColumn198.HeaderText = "Check#"
        Me.DataGridViewTextBoxColumn198.Name = "DataGridViewTextBoxColumn198"
        '
        'DataGridViewTextBoxColumn199
        '
        Me.DataGridViewTextBoxColumn199.DataPropertyName = "PayorName"
        Me.DataGridViewTextBoxColumn199.HeaderText = "PayorName"
        Me.DataGridViewTextBoxColumn199.Name = "DataGridViewTextBoxColumn199"
        '
        'DataGridViewTextBoxColumn185
        '
        Me.DataGridViewTextBoxColumn185.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn185.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn185.Name = "DataGridViewTextBoxColumn185"
        Me.DataGridViewTextBoxColumn185.Width = 150
        '
        'DataGridViewTextBoxColumn189
        '
        Me.DataGridViewTextBoxColumn189.DataPropertyName = "AttorneyCode"
        Me.DataGridViewTextBoxColumn189.HeaderText = "AttorneyCode"
        Me.DataGridViewTextBoxColumn189.Name = "DataGridViewTextBoxColumn189"
        '
        'DataGridViewTextBoxColumn187
        '
        Me.DataGridViewTextBoxColumn187.DataPropertyName = "InsuranceCode"
        Me.DataGridViewTextBoxColumn187.HeaderText = "InsuranceCode"
        Me.DataGridViewTextBoxColumn187.Name = "DataGridViewTextBoxColumn187"
        '
        'DataGridViewTextBoxColumn191
        '
        Me.DataGridViewTextBoxColumn191.DataPropertyName = "UnappliedAmount"
        Me.DataGridViewTextBoxColumn191.HeaderText = "UnappliedAmount"
        Me.DataGridViewTextBoxColumn191.Name = "DataGridViewTextBoxColumn191"
        '
        'DataGridViewTextBoxColumn192
        '
        Me.DataGridViewTextBoxColumn192.DataPropertyName = "DepositCode"
        Me.DataGridViewTextBoxColumn192.HeaderText = "DepositCode"
        Me.DataGridViewTextBoxColumn192.Name = "DataGridViewTextBoxColumn192"
        '
        'DataGridViewTextBoxColumn193
        '
        Me.DataGridViewTextBoxColumn193.DataPropertyName = "PaymentCode"
        Me.DataGridViewTextBoxColumn193.HeaderText = "PaymentCode"
        Me.DataGridViewTextBoxColumn193.Name = "DataGridViewTextBoxColumn193"
        '
        'DataGridViewTextBoxColumn194
        '
        Me.DataGridViewTextBoxColumn194.DataPropertyName = "AdjustmentCode"
        Me.DataGridViewTextBoxColumn194.HeaderText = "AdjustmentCode"
        Me.DataGridViewTextBoxColumn194.Name = "DataGridViewTextBoxColumn194"
        '
        'DataGridViewTextBoxColumn195
        '
        Me.DataGridViewTextBoxColumn195.DataPropertyName = "DeductibleCode"
        Me.DataGridViewTextBoxColumn195.HeaderText = "DeductibleCode"
        Me.DataGridViewTextBoxColumn195.Name = "DataGridViewTextBoxColumn195"
        '
        'MMARDepositBindingSource
        '
        Me.MMARDepositBindingSource.DataMember = "MMARDeposit"
        Me.MMARDepositBindingSource.DataSource = Me.ARDataSet
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PostPaymentID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PostPaymentID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CaseNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CaseNumber"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PaymentReference"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PaymentReference"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ChargeReference"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ChargeReference"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PaymentAmount"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PaymentAmount"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "WhoPaid"
        Me.DataGridViewTextBoxColumn7.HeaderText = "WhoPaid"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DepositID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DepositID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DateModified"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DateModified"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'MMARPostPaymentBindingSource
        '
        Me.MMARPostPaymentBindingSource.DataMember = "MMARPostPayment"
        Me.MMARPostPaymentBindingSource.DataSource = Me.ARDataSet
        '
        'BillingHeaderTableAdapter
        '
        Me.BillingHeaderTableAdapter.ClearBeforeFill = True
        '
        'BillingDetailTableAdapter
        '
        Me.BillingDetailTableAdapter.ClearBeforeFill = True
        '
        'MMARPostPaymentTableAdapter
        '
        Me.MMARPostPaymentTableAdapter.ClearBeforeFill = True
        '
        'MMARDepositTableAdapter
        '
        Me.MMARDepositTableAdapter.ClearBeforeFill = True
        '
        'TransactionDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 690)
        Me.Controls.Add(CaseNumberLabel)
        Me.Controls.Add(Me.CaseNumberTextBox)
        Me.Controls.Add(ChartNumberLabel)
        Me.Controls.Add(Me.ChartNumberTextBox)
        Me.Controls.Add(Me.BillingHeaderBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "TransactionDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Detail"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.BillingDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingHeaderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MMARDepositDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARPostPaymentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingHeaderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BillingHeaderBindingNavigator.ResumeLayout(False)
        Me.BillingHeaderBindingNavigator.PerformLayout()
        CType(Me.MMComboBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARDepositBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARPostPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ARDataSet As MedicalManager.ARDataSet
    Friend WithEvents BillingHeaderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillingHeaderTableAdapter As MedicalManager.ARDataSetTableAdapters.BillingHeaderTableAdapter
    Friend WithEvents BillingHeaderBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BillingHeaderBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents chkKeepPayorCheckNo As System.Windows.Forms.CheckBox
    Friend WithEvents txtPayorName As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCheckNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmbPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbWhoPaid As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveTrans As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnApplyCharges As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents BillingDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillingDetailTableAdapter As MedicalManager.ARDataSetTableAdapters.BillingDetailTableAdapter
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveDeposit As System.Windows.Forms.Button
    Friend WithEvents btnSavePostPymnt As System.Windows.Forms.Button
    Friend WithEvents MMARPostPaymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMARPostPaymentTableAdapter As MedicalManager.ARDataSetTableAdapters.MMARPostPaymentTableAdapter
    Friend WithEvents MMARPostPaymentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMARDepositBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMARDepositTableAdapter As MedicalManager.ARDataSetTableAdapters.MMARDepositTableAdapter
    Friend WithEvents MMARDepositDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MMComboBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMComboTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMComboTableAdapter
    Friend WithEvents BillingHeaderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BillingDetailDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CaseNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn138 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn188 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn196 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn197 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn186 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn190 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn198 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn199 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn185 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn189 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn187 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn191 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn192 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn193 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn194 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn195 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BHCharges As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BHPayments As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BHTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn77 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn78 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn79 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn80 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn81 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn82 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn83 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn84 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn85 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn87 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn88 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn89 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn90 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn91 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn92 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn93 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn94 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn95 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn96 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn97 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn98 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn99 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn100 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn101 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn102 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn103 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn104 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn105 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn106 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn107 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn108 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn109 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn110 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn111 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn112 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn113 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn114 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn115 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn116 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn117 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn200 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn201 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn202 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn203 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn204 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn205 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn206 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn207 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn208 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn209 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn210 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDChartNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDCaseNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDServiceDate1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDCharge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDUnits As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDExtended As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDReceived As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDLineBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Payment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDCPTCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDPayorType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDPayorName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDPaymentMethod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDCheckNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn134 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn172 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDDateEntered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDDateCreated As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn120 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn121 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn122 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn123 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn124 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn126 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn127 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn128 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn129 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn86 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDAssignedProvider As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn125 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn135 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn136 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn137 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn139 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn119 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn140 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn141 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn142 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn143 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn144 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn145 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn146 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn147 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn149 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn150 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn151 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn152 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn153 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn154 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn155 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn156 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn157 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn158 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn159 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn160 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn161 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn162 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn163 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn164 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn165 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn166 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn167 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn168 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn169 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn170 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn171 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn174 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn175 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn176 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn177 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn178 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn179 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn180 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn181 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn182 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
