<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShortVisitTemplate
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
        Dim DateLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim MiLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim VisitTypeLabel As System.Windows.Forms.Label
        Dim FacilityLabel As System.Windows.Forms.Label
        Dim ReferringProviderLabel As System.Windows.Forms.Label
        Dim ReferralSourceLabel As System.Windows.Forms.Label
        Dim ChiefComplaintLabel As System.Windows.Forms.Label
        Dim TimeStampLabel As System.Windows.Forms.Label
        Dim FollowUpLabel As System.Windows.Forms.Label
        Dim RefferedToLabel As System.Windows.Forms.Label
        Dim DietLabel As System.Windows.Forms.Label
        Dim CounsellingLabel As System.Windows.Forms.Label
        Dim Dx1Label As System.Windows.Forms.Label
        Dim Dx2Label As System.Windows.Forms.Label
        Dim Dx3Label As System.Windows.Forms.Label
        Dim Dx4Label As System.Windows.Forms.Label
        Dim SignesLabel As System.Windows.Forms.Label
        Dim SignedByLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim AssignedToLabel As System.Windows.Forms.Label
        Dim HPILabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShortVisitTemplate))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MMChartVisitBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.MMChartVisitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.MMChartVisitBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox
        Me.CaseNumberTextBox = New System.Windows.Forms.TextBox
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.LastNameTextBox = New System.Windows.Forms.TextBox
        Me.MiTextBox = New System.Windows.Forms.TextBox
        Me.DOBTextBox = New System.Windows.Forms.TextBox
        Me.VisitTypeTextBox = New System.Windows.Forms.TextBox
        Me.FacilityTextBox = New System.Windows.Forms.TextBox
        Me.ReferringProviderTextBox = New System.Windows.Forms.TextBox
        Me.AssignedProviderTextBox = New System.Windows.Forms.TextBox
        Me.ReferralSourceTextBox = New System.Windows.Forms.TextBox
        Me.ChiefComplaintTextBox = New System.Windows.Forms.TextBox
        Me.HPITextBox = New System.Windows.Forms.TextBox
        Me.TimeStampDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.FollowUpTextBox = New System.Windows.Forms.TextBox
        Me.DietTextBox = New System.Windows.Forms.TextBox
        Me.CounsellingTextBox = New System.Windows.Forms.TextBox
        Me.TextBoxDx1 = New System.Windows.Forms.TextBox
        Me.TextBoxDx2 = New System.Windows.Forms.TextBox
        Me.TextBoxDx3 = New System.Windows.Forms.TextBox
        Me.TextBoxDx4 = New System.Windows.Forms.TextBox
        Me.SignesCheckBox = New System.Windows.Forms.CheckBox
        Me.SignedByComboBox = New System.Windows.Forms.ComboBox
        Me.StatusComboBox = New System.Windows.Forms.ComboBox
        Me.AssignedToComboBox = New System.Windows.Forms.ComboBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGridViewPr = New System.Windows.Forms.DataGridView
        Me.MMCHDxRxLtMtDataGridView = New System.Windows.Forms.DataGridView
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
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMCHDxRxLtMtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.radOther = New System.Windows.Forms.RadioButton
        Me.radFollowUp = New System.Windows.Forms.RadioButton
        Me.radDiet = New System.Windows.Forms.RadioButton
        Me.radCounseling = New System.Windows.Forms.RadioButton
        Me.RadioButtonTestImaging = New System.Windows.Forms.RadioButton
        Me.RadioButtonMT = New System.Windows.Forms.RadioButton
        Me.RadioButtonLT = New System.Windows.Forms.RadioButton
        Me.RadioButtonPr = New System.Windows.Forms.RadioButton
        Me.RadioButtonDx = New System.Windows.Forms.RadioButton
        Me.MMChartRxDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMChartRxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMChartTVitalSignDataGridView = New System.Windows.Forms.DataGridView
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
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.MMChartTVitalSignBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.cmdMedications = New System.Windows.Forms.Button
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.MMChartVisitTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartVisitTableAdapter
        Me.MMCHDxRxLtMtTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
        Me.MMChartRxTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartRxTableAdapter
        Me.MMChartTVitalSignTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter
        ChartNumberLabel = New System.Windows.Forms.Label
        CaseNumberLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        FirstNameLabel = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        MiLabel = New System.Windows.Forms.Label
        DOBLabel = New System.Windows.Forms.Label
        VisitTypeLabel = New System.Windows.Forms.Label
        FacilityLabel = New System.Windows.Forms.Label
        ReferringProviderLabel = New System.Windows.Forms.Label
        ReferralSourceLabel = New System.Windows.Forms.Label
        ChiefComplaintLabel = New System.Windows.Forms.Label
        TimeStampLabel = New System.Windows.Forms.Label
        FollowUpLabel = New System.Windows.Forms.Label
        RefferedToLabel = New System.Windows.Forms.Label
        DietLabel = New System.Windows.Forms.Label
        CounsellingLabel = New System.Windows.Forms.Label
        Dx1Label = New System.Windows.Forms.Label
        Dx2Label = New System.Windows.Forms.Label
        Dx3Label = New System.Windows.Forms.Label
        Dx4Label = New System.Windows.Forms.Label
        SignesLabel = New System.Windows.Forms.Label
        SignedByLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        AssignedToLabel = New System.Windows.Forms.Label
        HPILabel = New System.Windows.Forms.Label
        CType(Me.MMChartVisitBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMChartVisitBindingNavigator.SuspendLayout()
        CType(Me.MMChartVisitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewPr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHDxRxLtMtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartRxDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartTVitalSignDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChartNumberLabel
        '
        ChartNumberLabel.AutoSize = True
        ChartNumberLabel.Location = New System.Drawing.Point(22, 40)
        ChartNumberLabel.Name = "ChartNumberLabel"
        ChartNumberLabel.Size = New System.Drawing.Size(75, 13)
        ChartNumberLabel.TabIndex = 1
        ChartNumberLabel.Text = "Chart Number:"
        '
        'CaseNumberLabel
        '
        CaseNumberLabel.AutoSize = True
        CaseNumberLabel.Location = New System.Drawing.Point(22, 65)
        CaseNumberLabel.Name = "CaseNumberLabel"
        CaseNumberLabel.Size = New System.Drawing.Size(74, 13)
        CaseNumberLabel.TabIndex = 3
        CaseNumberLabel.Text = "Case Number:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(64, 91)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 5
        DateLabel.Text = "Date:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(37, 115)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 7
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(36, 140)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 9
        LastNameLabel.Text = "Last Name:"
        '
        'MiLabel
        '
        MiLabel.AutoSize = True
        MiLabel.Location = New System.Drawing.Point(76, 165)
        MiLabel.Name = "MiLabel"
        MiLabel.Size = New System.Drawing.Size(21, 13)
        MiLabel.TabIndex = 11
        MiLabel.Text = "Mi:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(64, 190)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 13
        DOBLabel.Text = "DOB:"
        '
        'VisitTypeLabel
        '
        VisitTypeLabel.AutoSize = True
        VisitTypeLabel.Location = New System.Drawing.Point(41, 215)
        VisitTypeLabel.Name = "VisitTypeLabel"
        VisitTypeLabel.Size = New System.Drawing.Size(56, 13)
        VisitTypeLabel.TabIndex = 15
        VisitTypeLabel.Text = "Visit Type:"
        '
        'FacilityLabel
        '
        FacilityLabel.AutoSize = True
        FacilityLabel.Location = New System.Drawing.Point(55, 240)
        FacilityLabel.Name = "FacilityLabel"
        FacilityLabel.Size = New System.Drawing.Size(42, 13)
        FacilityLabel.TabIndex = 17
        FacilityLabel.Text = "Facility:"
        '
        'ReferringProviderLabel
        '
        ReferringProviderLabel.AutoSize = True
        ReferringProviderLabel.Location = New System.Drawing.Point(2, 265)
        ReferringProviderLabel.Name = "ReferringProviderLabel"
        ReferringProviderLabel.Size = New System.Drawing.Size(95, 13)
        ReferringProviderLabel.TabIndex = 19
        ReferringProviderLabel.Text = "Referring Provider:"
        '
        'ReferralSourceLabel
        '
        ReferralSourceLabel.AutoSize = True
        ReferralSourceLabel.Location = New System.Drawing.Point(13, 290)
        ReferralSourceLabel.Name = "ReferralSourceLabel"
        ReferralSourceLabel.Size = New System.Drawing.Size(84, 13)
        ReferralSourceLabel.TabIndex = 23
        ReferralSourceLabel.Text = "Referral Source:"
        '
        'ChiefComplaintLabel
        '
        ChiefComplaintLabel.AutoSize = True
        ChiefComplaintLabel.Location = New System.Drawing.Point(14, 15)
        ChiefComplaintLabel.Name = "ChiefComplaintLabel"
        ChiefComplaintLabel.Size = New System.Drawing.Size(83, 13)
        ChiefComplaintLabel.TabIndex = 43
        ChiefComplaintLabel.Text = "Chief Complaint:"
        '
        'TimeStampLabel
        '
        TimeStampLabel.AutoSize = True
        TimeStampLabel.Location = New System.Drawing.Point(252, 130)
        TimeStampLabel.Name = "TimeStampLabel"
        TimeStampLabel.Size = New System.Drawing.Size(66, 13)
        TimeStampLabel.TabIndex = 67
        TimeStampLabel.Text = "Time Stamp:"
        '
        'FollowUpLabel
        '
        FollowUpLabel.AutoSize = True
        FollowUpLabel.Location = New System.Drawing.Point(261, 156)
        FollowUpLabel.Name = "FollowUpLabel"
        FollowUpLabel.Size = New System.Drawing.Size(57, 13)
        FollowUpLabel.TabIndex = 69
        FollowUpLabel.Text = "Follow Up:"
        '
        'RefferedToLabel
        '
        RefferedToLabel.AutoSize = True
        RefferedToLabel.Location = New System.Drawing.Point(251, 208)
        RefferedToLabel.Name = "RefferedToLabel"
        RefferedToLabel.Size = New System.Drawing.Size(67, 13)
        RefferedToLabel.TabIndex = 71
        RefferedToLabel.Text = "Reffered To:"
        '
        'DietLabel
        '
        DietLabel.AutoSize = True
        DietLabel.Location = New System.Drawing.Point(289, 78)
        DietLabel.Name = "DietLabel"
        DietLabel.Size = New System.Drawing.Size(29, 13)
        DietLabel.TabIndex = 73
        DietLabel.Text = "Diet:"
        '
        'CounsellingLabel
        '
        CounsellingLabel.AutoSize = True
        CounsellingLabel.Location = New System.Drawing.Point(254, 104)
        CounsellingLabel.Name = "CounsellingLabel"
        CounsellingLabel.Size = New System.Drawing.Size(64, 13)
        CounsellingLabel.TabIndex = 75
        CounsellingLabel.Text = "Counselling:"
        '
        'Dx1Label
        '
        Dx1Label.AutoSize = True
        Dx1Label.Location = New System.Drawing.Point(17, 37)
        Dx1Label.Name = "Dx1Label"
        Dx1Label.Size = New System.Drawing.Size(29, 13)
        Dx1Label.TabIndex = 77
        Dx1Label.Text = "Dx1:"
        '
        'Dx2Label
        '
        Dx2Label.AutoSize = True
        Dx2Label.Location = New System.Drawing.Point(145, 37)
        Dx2Label.Name = "Dx2Label"
        Dx2Label.Size = New System.Drawing.Size(29, 13)
        Dx2Label.TabIndex = 79
        Dx2Label.Text = "Dx2:"
        '
        'Dx3Label
        '
        Dx3Label.AutoSize = True
        Dx3Label.Location = New System.Drawing.Point(257, 37)
        Dx3Label.Name = "Dx3Label"
        Dx3Label.Size = New System.Drawing.Size(29, 13)
        Dx3Label.TabIndex = 81
        Dx3Label.Text = "Dx3:"
        '
        'Dx4Label
        '
        Dx4Label.AutoSize = True
        Dx4Label.Location = New System.Drawing.Point(368, 37)
        Dx4Label.Name = "Dx4Label"
        Dx4Label.Size = New System.Drawing.Size(29, 13)
        Dx4Label.TabIndex = 83
        Dx4Label.Text = "Dx4:"
        '
        'SignesLabel
        '
        SignesLabel.AutoSize = True
        SignesLabel.Location = New System.Drawing.Point(276, 237)
        SignesLabel.Name = "SignesLabel"
        SignesLabel.Size = New System.Drawing.Size(43, 13)
        SignesLabel.TabIndex = 85
        SignesLabel.Text = "Signed:"
        '
        'SignedByLabel
        '
        SignedByLabel.AutoSize = True
        SignedByLabel.Location = New System.Drawing.Point(260, 292)
        SignedByLabel.Name = "SignedByLabel"
        SignedByLabel.Size = New System.Drawing.Size(58, 13)
        SignedByLabel.TabIndex = 87
        SignedByLabel.Text = "Signed By:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(278, 182)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 89
        StatusLabel.Text = "Status:"
        '
        'AssignedToLabel
        '
        AssignedToLabel.AutoSize = True
        AssignedToLabel.Location = New System.Drawing.Point(249, 264)
        AssignedToLabel.Name = "AssignedToLabel"
        AssignedToLabel.Size = New System.Drawing.Size(69, 13)
        AssignedToLabel.TabIndex = 91
        AssignedToLabel.Text = "Assigned To:"
        '
        'HPILabel
        '
        HPILabel.AutoSize = True
        HPILabel.Location = New System.Drawing.Point(290, 52)
        HPILabel.Name = "HPILabel"
        HPILabel.Size = New System.Drawing.Size(28, 13)
        HPILabel.TabIndex = 45
        HPILabel.Text = "HPI:"
        '
        'MMChartVisitBindingNavigator
        '
        Me.MMChartVisitBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMChartVisitBindingNavigator.BindingSource = Me.MMChartVisitBindingSource
        Me.MMChartVisitBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMChartVisitBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMChartVisitBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MMChartVisitBindingNavigatorSaveItem, Me.ToolStripButton2})
        Me.MMChartVisitBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMChartVisitBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMChartVisitBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMChartVisitBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMChartVisitBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMChartVisitBindingNavigator.Name = "MMChartVisitBindingNavigator"
        Me.MMChartVisitBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMChartVisitBindingNavigator.Size = New System.Drawing.Size(1200, 25)
        Me.MMChartVisitBindingNavigator.TabIndex = 0
        Me.MMChartVisitBindingNavigator.Text = "BindingNavigator1"
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
        'MMChartVisitBindingSource
        '
        Me.MMChartVisitBindingSource.DataMember = "MMChartVisit"
        Me.MMChartVisitBindingSource.DataSource = Me.MMDataDataSet1
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
        'MMChartVisitBindingNavigatorSaveItem
        '
        Me.MMChartVisitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MMChartVisitBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMChartVisitBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMChartVisitBindingNavigatorSaveItem.Name = "MMChartVisitBindingNavigatorSaveItem"
        Me.MMChartVisitBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MMChartVisitBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripButton2.Text = "Report"
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "ChartNumber", True))
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(103, 37)
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(109, 20)
        Me.ChartNumberTextBox.TabIndex = 2
        '
        'CaseNumberTextBox
        '
        Me.CaseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "CaseNumber", True))
        Me.CaseNumberTextBox.Location = New System.Drawing.Point(103, 62)
        Me.CaseNumberTextBox.Name = "CaseNumberTextBox"
        Me.CaseNumberTextBox.Size = New System.Drawing.Size(109, 20)
        Me.CaseNumberTextBox.TabIndex = 4
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MMChartVisitBindingSource, "Date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(103, 87)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(109, 20)
        Me.DateDateTimePicker.TabIndex = 6
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(103, 112)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(109, 20)
        Me.FirstNameTextBox.TabIndex = 8
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(103, 137)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(109, 20)
        Me.LastNameTextBox.TabIndex = 10
        '
        'MiTextBox
        '
        Me.MiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "Mi", True))
        Me.MiTextBox.Location = New System.Drawing.Point(103, 162)
        Me.MiTextBox.Name = "MiTextBox"
        Me.MiTextBox.Size = New System.Drawing.Size(109, 20)
        Me.MiTextBox.TabIndex = 12
        '
        'DOBTextBox
        '
        Me.DOBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "DOB", True))
        Me.DOBTextBox.Location = New System.Drawing.Point(103, 187)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(109, 20)
        Me.DOBTextBox.TabIndex = 14
        '
        'VisitTypeTextBox
        '
        Me.VisitTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "VisitType", True))
        Me.VisitTypeTextBox.Location = New System.Drawing.Point(103, 212)
        Me.VisitTypeTextBox.Name = "VisitTypeTextBox"
        Me.VisitTypeTextBox.Size = New System.Drawing.Size(109, 20)
        Me.VisitTypeTextBox.TabIndex = 16
        '
        'FacilityTextBox
        '
        Me.FacilityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "Facility", True))
        Me.FacilityTextBox.Location = New System.Drawing.Point(103, 237)
        Me.FacilityTextBox.Name = "FacilityTextBox"
        Me.FacilityTextBox.Size = New System.Drawing.Size(109, 20)
        Me.FacilityTextBox.TabIndex = 18
        '
        'ReferringProviderTextBox
        '
        Me.ReferringProviderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "ReferringProvider", True))
        Me.ReferringProviderTextBox.Location = New System.Drawing.Point(103, 262)
        Me.ReferringProviderTextBox.Name = "ReferringProviderTextBox"
        Me.ReferringProviderTextBox.Size = New System.Drawing.Size(109, 20)
        Me.ReferringProviderTextBox.TabIndex = 20
        '
        'AssignedProviderTextBox
        '
        Me.AssignedProviderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "AssignedProvider", True))
        Me.AssignedProviderTextBox.Location = New System.Drawing.Point(324, 206)
        Me.AssignedProviderTextBox.Name = "AssignedProviderTextBox"
        Me.AssignedProviderTextBox.Size = New System.Drawing.Size(114, 20)
        Me.AssignedProviderTextBox.TabIndex = 22
        '
        'ReferralSourceTextBox
        '
        Me.ReferralSourceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "ReferralSource", True))
        Me.ReferralSourceTextBox.Location = New System.Drawing.Point(103, 287)
        Me.ReferralSourceTextBox.Name = "ReferralSourceTextBox"
        Me.ReferralSourceTextBox.Size = New System.Drawing.Size(109, 20)
        Me.ReferralSourceTextBox.TabIndex = 24
        '
        'ChiefComplaintTextBox
        '
        Me.ChiefComplaintTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "ChiefComplaint", True))
        Me.ChiefComplaintTextBox.Location = New System.Drawing.Point(103, 12)
        Me.ChiefComplaintTextBox.Name = "ChiefComplaintTextBox"
        Me.ChiefComplaintTextBox.Size = New System.Drawing.Size(335, 20)
        Me.ChiefComplaintTextBox.TabIndex = 44
        '
        'HPITextBox
        '
        Me.HPITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "HPI", True))
        Me.HPITextBox.Location = New System.Drawing.Point(324, 49)
        Me.HPITextBox.Name = "HPITextBox"
        Me.HPITextBox.Size = New System.Drawing.Size(114, 20)
        Me.HPITextBox.TabIndex = 46
        '
        'TimeStampDateTimePicker
        '
        Me.TimeStampDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MMChartVisitBindingSource, "TimeStamp", True))
        Me.TimeStampDateTimePicker.Location = New System.Drawing.Point(324, 127)
        Me.TimeStampDateTimePicker.Name = "TimeStampDateTimePicker"
        Me.TimeStampDateTimePicker.Size = New System.Drawing.Size(114, 20)
        Me.TimeStampDateTimePicker.TabIndex = 68
        '
        'FollowUpTextBox
        '
        Me.FollowUpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "FollowUp", True))
        Me.FollowUpTextBox.Location = New System.Drawing.Point(324, 153)
        Me.FollowUpTextBox.Name = "FollowUpTextBox"
        Me.FollowUpTextBox.Size = New System.Drawing.Size(114, 20)
        Me.FollowUpTextBox.TabIndex = 70
        '
        'DietTextBox
        '
        Me.DietTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "Diet", True))
        Me.DietTextBox.Location = New System.Drawing.Point(324, 75)
        Me.DietTextBox.Name = "DietTextBox"
        Me.DietTextBox.Size = New System.Drawing.Size(114, 20)
        Me.DietTextBox.TabIndex = 74
        '
        'CounsellingTextBox
        '
        Me.CounsellingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "Counselling", True))
        Me.CounsellingTextBox.Location = New System.Drawing.Point(324, 101)
        Me.CounsellingTextBox.Name = "CounsellingTextBox"
        Me.CounsellingTextBox.Size = New System.Drawing.Size(114, 20)
        Me.CounsellingTextBox.TabIndex = 76
        '
        'TextBoxDx1
        '
        Me.TextBoxDx1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "Dx1", True))
        Me.TextBoxDx1.Location = New System.Drawing.Point(52, 33)
        Me.TextBoxDx1.Name = "TextBoxDx1"
        Me.TextBoxDx1.Size = New System.Drawing.Size(87, 20)
        Me.TextBoxDx1.TabIndex = 78
        '
        'TextBoxDx2
        '
        Me.TextBoxDx2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "Dx2", True))
        Me.TextBoxDx2.Location = New System.Drawing.Point(182, 33)
        Me.TextBoxDx2.Name = "TextBoxDx2"
        Me.TextBoxDx2.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxDx2.TabIndex = 80
        '
        'TextBoxDx3
        '
        Me.TextBoxDx3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "Dx3", True))
        Me.TextBoxDx3.Location = New System.Drawing.Point(292, 33)
        Me.TextBoxDx3.Name = "TextBoxDx3"
        Me.TextBoxDx3.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxDx3.TabIndex = 82
        '
        'TextBoxDx4
        '
        Me.TextBoxDx4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "Dx4", True))
        Me.TextBoxDx4.Location = New System.Drawing.Point(403, 33)
        Me.TextBoxDx4.Name = "TextBoxDx4"
        Me.TextBoxDx4.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxDx4.TabIndex = 84
        '
        'SignesCheckBox
        '
        Me.SignesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MMChartVisitBindingSource, "Signes", True))
        Me.SignesCheckBox.Location = New System.Drawing.Point(324, 232)
        Me.SignesCheckBox.Name = "SignesCheckBox"
        Me.SignesCheckBox.Size = New System.Drawing.Size(40, 24)
        Me.SignesCheckBox.TabIndex = 86
        '
        'SignedByComboBox
        '
        Me.SignedByComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "SignedBy", True))
        Me.SignedByComboBox.FormattingEnabled = True
        Me.SignedByComboBox.Location = New System.Drawing.Point(324, 289)
        Me.SignedByComboBox.Name = "SignedByComboBox"
        Me.SignedByComboBox.Size = New System.Drawing.Size(114, 21)
        Me.SignedByComboBox.TabIndex = 88
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(324, 179)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(114, 21)
        Me.StatusComboBox.TabIndex = 90
        '
        'AssignedToComboBox
        '
        Me.AssignedToComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartVisitBindingSource, "AssignedTo", True))
        Me.AssignedToComboBox.FormattingEnabled = True
        Me.AssignedToComboBox.Location = New System.Drawing.Point(324, 262)
        Me.AssignedToComboBox.Name = "AssignedToComboBox"
        Me.AssignedToComboBox.Size = New System.Drawing.Size(114, 21)
        Me.AssignedToComboBox.TabIndex = 92
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(530, 655)
        Me.TabControl1.TabIndex = 103
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(ChartNumberLabel)
        Me.TabPage1.Controls.Add(Me.ChartNumberTextBox)
        Me.TabPage1.Controls.Add(CaseNumberLabel)
        Me.TabPage1.Controls.Add(TimeStampLabel)
        Me.TabPage1.Controls.Add(Me.SignesCheckBox)
        Me.TabPage1.Controls.Add(Me.TimeStampDateTimePicker)
        Me.TabPage1.Controls.Add(Me.CaseNumberTextBox)
        Me.TabPage1.Controls.Add(FollowUpLabel)
        Me.TabPage1.Controls.Add(SignesLabel)
        Me.TabPage1.Controls.Add(Me.FollowUpTextBox)
        Me.TabPage1.Controls.Add(DateLabel)
        Me.TabPage1.Controls.Add(SignedByLabel)
        Me.TabPage1.Controls.Add(Me.DateDateTimePicker)
        Me.TabPage1.Controls.Add(Me.SignedByComboBox)
        Me.TabPage1.Controls.Add(StatusLabel)
        Me.TabPage1.Controls.Add(Me.StatusComboBox)
        Me.TabPage1.Controls.Add(FirstNameLabel)
        Me.TabPage1.Controls.Add(AssignedToLabel)
        Me.TabPage1.Controls.Add(Me.AssignedToComboBox)
        Me.TabPage1.Controls.Add(Me.FirstNameTextBox)
        Me.TabPage1.Controls.Add(LastNameLabel)
        Me.TabPage1.Controls.Add(Me.LastNameTextBox)
        Me.TabPage1.Controls.Add(MiLabel)
        Me.TabPage1.Controls.Add(Me.MiTextBox)
        Me.TabPage1.Controls.Add(DOBLabel)
        Me.TabPage1.Controls.Add(Me.CounsellingTextBox)
        Me.TabPage1.Controls.Add(Me.DOBTextBox)
        Me.TabPage1.Controls.Add(CounsellingLabel)
        Me.TabPage1.Controls.Add(VisitTypeLabel)
        Me.TabPage1.Controls.Add(Me.DietTextBox)
        Me.TabPage1.Controls.Add(Me.VisitTypeTextBox)
        Me.TabPage1.Controls.Add(DietLabel)
        Me.TabPage1.Controls.Add(FacilityLabel)
        Me.TabPage1.Controls.Add(RefferedToLabel)
        Me.TabPage1.Controls.Add(Me.FacilityTextBox)
        Me.TabPage1.Controls.Add(Me.HPITextBox)
        Me.TabPage1.Controls.Add(ReferringProviderLabel)
        Me.TabPage1.Controls.Add(HPILabel)
        Me.TabPage1.Controls.Add(Me.ReferringProviderTextBox)
        Me.TabPage1.Controls.Add(Me.ChiefComplaintTextBox)
        Me.TabPage1.Controls.Add(ChiefComplaintLabel)
        Me.TabPage1.Controls.Add(Me.AssignedProviderTextBox)
        Me.TabPage1.Controls.Add(ReferralSourceLabel)
        Me.TabPage1.Controls.Add(Me.ReferralSourceTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(522, 629)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewPr)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(522, 629)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewPr
        '
        Me.DataGridViewPr.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewPr.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewPr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewPr.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewPr.MultiSelect = False
        Me.DataGridViewPr.Name = "DataGridViewPr"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPr.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewPr.Size = New System.Drawing.Size(516, 623)
        Me.DataGridViewPr.TabIndex = 142
        '
        'MMCHDxRxLtMtDataGridView
        '
        Me.MMCHDxRxLtMtDataGridView.AllowUserToAddRows = False
        Me.MMCHDxRxLtMtDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMCHDxRxLtMtDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MMCHDxRxLtMtDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn11})
        Me.MMCHDxRxLtMtDataGridView.DataSource = Me.MMCHDxRxLtMtBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MMCHDxRxLtMtDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.MMCHDxRxLtMtDataGridView.Location = New System.Drawing.Point(2, 2)
        Me.MMCHDxRxLtMtDataGridView.MultiSelect = False
        Me.MMCHDxRxLtMtDataGridView.Name = "MMCHDxRxLtMtDataGridView"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMCHDxRxLtMtDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MMCHDxRxLtMtDataGridView.Size = New System.Drawing.Size(641, 241)
        Me.MMCHDxRxLtMtDataGridView.TabIndex = 104
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ChartNumber"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UserCode"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UserCode"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TimeStamp"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TimeStamp"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PrDx"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PrDx"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "PostedToBilling"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "PostedToBilling"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'MMCHDxRxLtMtBindingSource
        '
        Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
        Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.radOther.Location = New System.Drawing.Point(519, 0)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(51, 17)
        Me.radOther.TabIndex = 157
        Me.radOther.Text = "Other"
        Me.radOther.UseVisualStyleBackColor = False
        '
        'radFollowUp
        '
        Me.radFollowUp.AutoSize = True
        Me.radFollowUp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.radFollowUp.Location = New System.Drawing.Point(576, 0)
        Me.radFollowUp.Name = "radFollowUp"
        Me.radFollowUp.Size = New System.Drawing.Size(72, 17)
        Me.radFollowUp.TabIndex = 156
        Me.radFollowUp.Text = "Follow Up"
        Me.radFollowUp.UseVisualStyleBackColor = False
        '
        'radDiet
        '
        Me.radDiet.AutoSize = True
        Me.radDiet.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.radDiet.Location = New System.Drawing.Point(654, 0)
        Me.radDiet.Name = "radDiet"
        Me.radDiet.Size = New System.Drawing.Size(44, 17)
        Me.radDiet.TabIndex = 155
        Me.radDiet.Text = "Diet"
        Me.radDiet.UseVisualStyleBackColor = False
        '
        'radCounseling
        '
        Me.radCounseling.AutoSize = True
        Me.radCounseling.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.radCounseling.Checked = True
        Me.radCounseling.Location = New System.Drawing.Point(704, 0)
        Me.radCounseling.Name = "radCounseling"
        Me.radCounseling.Size = New System.Drawing.Size(77, 17)
        Me.radCounseling.TabIndex = 154
        Me.radCounseling.TabStop = True
        Me.radCounseling.Text = "Counseling"
        Me.radCounseling.UseVisualStyleBackColor = False
        '
        'RadioButtonTestImaging
        '
        Me.RadioButtonTestImaging.AutoSize = True
        Me.RadioButtonTestImaging.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RadioButtonTestImaging.Location = New System.Drawing.Point(1040, 0)
        Me.RadioButtonTestImaging.Name = "RadioButtonTestImaging"
        Me.RadioButtonTestImaging.Size = New System.Drawing.Size(83, 17)
        Me.RadioButtonTestImaging.TabIndex = 153
        Me.RadioButtonTestImaging.Text = "TestImaging"
        Me.RadioButtonTestImaging.UseVisualStyleBackColor = False
        '
        'RadioButtonMT
        '
        Me.RadioButtonMT.AutoSize = True
        Me.RadioButtonMT.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RadioButtonMT.Location = New System.Drawing.Point(948, 0)
        Me.RadioButtonMT.Name = "RadioButtonMT"
        Me.RadioButtonMT.Size = New System.Drawing.Size(86, 17)
        Me.RadioButtonMT.TabIndex = 152
        Me.RadioButtonMT.Text = "TestMedical "
        Me.RadioButtonMT.UseVisualStyleBackColor = False
        '
        'RadioButtonLT
        '
        Me.RadioButtonLT.AutoSize = True
        Me.RadioButtonLT.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RadioButtonLT.Location = New System.Drawing.Point(872, 0)
        Me.RadioButtonLT.Name = "RadioButtonLT"
        Me.RadioButtonLT.Size = New System.Drawing.Size(67, 17)
        Me.RadioButtonLT.TabIndex = 151
        Me.RadioButtonLT.Text = "Lab Test"
        Me.RadioButtonLT.UseVisualStyleBackColor = False
        '
        'RadioButtonPr
        '
        Me.RadioButtonPr.AutoSize = True
        Me.RadioButtonPr.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RadioButtonPr.Location = New System.Drawing.Point(831, 0)
        Me.RadioButtonPr.Name = "RadioButtonPr"
        Me.RadioButtonPr.Size = New System.Drawing.Size(35, 17)
        Me.RadioButtonPr.TabIndex = 150
        Me.RadioButtonPr.Text = "Pr"
        Me.RadioButtonPr.UseVisualStyleBackColor = False
        '
        'RadioButtonDx
        '
        Me.RadioButtonDx.AutoSize = True
        Me.RadioButtonDx.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RadioButtonDx.Checked = True
        Me.RadioButtonDx.Location = New System.Drawing.Point(787, 0)
        Me.RadioButtonDx.Name = "RadioButtonDx"
        Me.RadioButtonDx.Size = New System.Drawing.Size(38, 17)
        Me.RadioButtonDx.TabIndex = 149
        Me.RadioButtonDx.TabStop = True
        Me.RadioButtonDx.Text = "Dx"
        Me.RadioButtonDx.UseVisualStyleBackColor = False
        '
        'MMChartRxDataGridView
        '
        Me.MMChartRxDataGridView.AllowUserToAddRows = False
        Me.MMChartRxDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMChartRxDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.MMChartRxDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.CaseNumber, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn23, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29})
        Me.MMChartRxDataGridView.DataSource = Me.MMChartRxBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MMChartRxDataGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.MMChartRxDataGridView.Location = New System.Drawing.Point(2, 249)
        Me.MMChartRxDataGridView.MultiSelect = False
        Me.MMChartRxDataGridView.Name = "MMChartRxDataGridView"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMChartRxDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.MMChartRxDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.MMChartRxDataGridView.Size = New System.Drawing.Size(641, 197)
        Me.MMChartRxDataGridView.TabIndex = 158
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "RX ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "RX ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 50
        '
        'CaseNumber
        '
        Me.CaseNumber.DataPropertyName = "CaseNumber"
        Me.CaseNumber.HeaderText = "CaseNo"
        Me.CaseNumber.Name = "CaseNumber"
        Me.CaseNumber.Width = 50
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ChartNo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 50
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PatientName"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PatientName"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "OrderingPhysicianID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "OrdPhyID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 60
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "PhysicianName"
        Me.DataGridViewTextBoxColumn16.HeaderText = "PhysicianName"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "LicenseNumber"
        Me.DataGridViewTextBoxColumn17.HeaderText = "LicenseNumber"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Medication"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Medication"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Dosage"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Dosage"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 50
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "NumberOfRefills"
        Me.DataGridViewTextBoxColumn20.HeaderText = "No Refills"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 50
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "StartDate"
        Me.DataGridViewTextBoxColumn21.HeaderText = "StartDate"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 60
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "EndDate"
        Me.DataGridViewTextBoxColumn22.HeaderText = "EndDate"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "SigNature"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "SigNature"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "SignerName"
        Me.DataGridViewTextBoxColumn23.HeaderText = "SignerName"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "NeedDEANo"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "NeedDEANo"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "DAENo"
        Me.DataGridViewTextBoxColumn24.HeaderText = "DAENo"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "User"
        Me.DataGridViewTextBoxColumn25.HeaderText = "User"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "TimeStamp"
        Me.DataGridViewTextBoxColumn26.HeaderText = "TimeStamp"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "SubstituteOk"
        Me.DataGridViewTextBoxColumn27.HeaderText = "SubstituteOk"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Instructions"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Instructions"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'MMChartRxBindingSource
        '
        Me.MMChartRxBindingSource.DataMember = "MMChartRx"
        Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMChartTVitalSignDataGridView
        '
        Me.MMChartTVitalSignDataGridView.AllowUserToAddRows = False
        Me.MMChartTVitalSignDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMChartTVitalSignDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.MMChartTVitalSignDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewCheckBoxColumn4})
        Me.MMChartTVitalSignDataGridView.DataSource = Me.MMChartTVitalSignBindingSource
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MMChartTVitalSignDataGridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.MMChartTVitalSignDataGridView.Location = New System.Drawing.Point(2, 452)
        Me.MMChartTVitalSignDataGridView.MultiSelect = False
        Me.MMChartTVitalSignDataGridView.Name = "MMChartTVitalSignDataGridView"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMChartTVitalSignDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.MMChartTVitalSignDataGridView.Size = New System.Drawing.Size(641, 137)
        Me.MMChartTVitalSignDataGridView.TabIndex = 159
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "VID"
        Me.DataGridViewTextBoxColumn30.HeaderText = "VID"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn31.HeaderText = "ChartNumber"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "CaseNumber"
        Me.DataGridViewTextBoxColumn32.HeaderText = "CaseNumber"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Time"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Temp"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Temp"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Pulse"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Pulse"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Resp"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Resp"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Systolic"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Systolic"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Diastolic"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Diastolic"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "HtIn"
        Me.DataGridViewTextBoxColumn40.HeaderText = "HtIn"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "WtLb"
        Me.DataGridViewTextBoxColumn41.HeaderText = "WtLb"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Oz"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Oz"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "BMI"
        Me.DataGridViewTextBoxColumn43.HeaderText = "BMI"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "PulseOx"
        Me.DataGridViewTextBoxColumn44.HeaderText = "PulseOx"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "User"
        Me.DataGridViewTextBoxColumn45.HeaderText = "User"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "TimeStamp"
        Me.DataGridViewTextBoxColumn46.HeaderText = "TimeStamp"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn47.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Signed"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Signed"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'MMChartTVitalSignBindingSource
        '
        Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
        Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdMedications)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer1.Panel2.Controls.Add(Dx1Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxDx1)
        Me.SplitContainer1.Panel2.Controls.Add(Dx2Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxDx2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxDx3)
        Me.SplitContainer1.Panel2.Controls.Add(Dx3Label)
        Me.SplitContainer1.Panel2.Controls.Add(Dx4Label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxDx4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1200, 686)
        Me.SplitContainer1.SplitterDistance = 536
        Me.SplitContainer1.TabIndex = 160
        '
        'cmdMedications
        '
        Me.cmdMedications.Location = New System.Drawing.Point(498, 31)
        Me.cmdMedications.Name = "cmdMedications"
        Me.cmdMedications.Size = New System.Drawing.Size(85, 23)
        Me.cmdMedications.TabIndex = 160
        Me.cmdMedications.Text = "Medications"
        Me.cmdMedications.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(3, 58)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(654, 618)
        Me.TabControl2.TabIndex = 161
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.MMCHDxRxLtMtDataGridView)
        Me.TabPage3.Controls.Add(Me.MMChartTVitalSignDataGridView)
        Me.TabPage3.Controls.Add(Me.MMChartRxDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(646, 592)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(603, 546)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'MMChartVisitTableAdapter
        '
        Me.MMChartVisitTableAdapter.ClearBeforeFill = True
        '
        'MMCHDxRxLtMtTableAdapter
        '
        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
        '
        'MMChartRxTableAdapter
        '
        Me.MMChartRxTableAdapter.ClearBeforeFill = True
        '
        'MMChartTVitalSignTableAdapter
        '
        Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True
        '
        'ShortVisitTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1200, 686)
        Me.Controls.Add(Me.radOther)
        Me.Controls.Add(Me.radFollowUp)
        Me.Controls.Add(Me.radDiet)
        Me.Controls.Add(Me.radCounseling)
        Me.Controls.Add(Me.RadioButtonTestImaging)
        Me.Controls.Add(Me.RadioButtonMT)
        Me.Controls.Add(Me.RadioButtonLT)
        Me.Controls.Add(Me.RadioButtonPr)
        Me.Controls.Add(Me.RadioButtonDx)
        Me.Controls.Add(Me.MMChartVisitBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ShortVisitTemplate"
        Me.Text = "ShortVisitTemplate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MMChartVisitBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMChartVisitBindingNavigator.ResumeLayout(False)
        Me.MMChartVisitBindingNavigator.PerformLayout()
        CType(Me.MMChartVisitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewPr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHDxRxLtMtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartRxDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartTVitalSignDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMChartVisitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartVisitTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartVisitTableAdapter
    Friend WithEvents MMChartVisitBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMChartVisitBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaseNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VisitTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FacilityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferringProviderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AssignedProviderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReferralSourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChiefComplaintTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HPITextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimeStampDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FollowUpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DietTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CounsellingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDx1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDx2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDx3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDx4 As System.Windows.Forms.TextBox
    Friend WithEvents SignesCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SignedByComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AssignedToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMCHDxRxLtMtBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMCHDxRxLtMtTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
    Friend WithEvents MMCHDxRxLtMtDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents radFollowUp As System.Windows.Forms.RadioButton
    Friend WithEvents radDiet As System.Windows.Forms.RadioButton
    Friend WithEvents radCounseling As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTestImaging As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMT As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonLT As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPr As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDx As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewPr As System.Windows.Forms.DataGridView
    Friend WithEvents MMChartRxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartRxTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartRxTableAdapter
    Friend WithEvents MMChartRxDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MMChartTVitalSignBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartTVitalSignTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter
    Friend WithEvents MMChartTVitalSignDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdMedications As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
End Class
