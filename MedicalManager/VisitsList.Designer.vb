<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VisitsList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MMChartVisitDataGridView = New System.Windows.Forms.DataGridView()
        Me.CaseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChartNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateVisit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicianName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TokenNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMChartVisitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.C = New System.Windows.Forms.Label()
        Me.CBStatus = New System.Windows.Forms.ComboBox()
        Me.CBDate = New System.Windows.Forms.ComboBox()
        Me.CBPhysician = New System.Windows.Forms.ComboBox()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.lblPracticeName = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCompleted = New System.Windows.Forms.Button()
        Me.TBTokenNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBDate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbDOB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBPhysicianName = New System.Windows.Forms.TextBox()
        Me.LBPhysicianName = New System.Windows.Forms.Label()
        Me.ChartNo = New System.Windows.Forms.TextBox()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVitals = New System.Windows.Forms.Button()
        Me.BtnMedication = New System.Windows.Forms.Button()
        Me.MMChartTVitalSignBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelMadication = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DgMedicine = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMChartRxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelProcedure = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DgProcedure = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCHDxRxLtMtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMPRocedureDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MMChartVisitTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartVisitTableAdapter()
        Me.MMChartTVitalSignTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter()
        Me.MMChartRxTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartRxTableAdapter()
        Me.Code1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeofServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScreenLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefaultPlaceService1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefaultPlaceService2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefaultPlaceService3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeToDoProcedureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsuranceCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientOnlyResponsibleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DontPrintonInsuranceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnlyPrintonInsuranceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostofServiceProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicareAllowedAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InactiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AdjustmentAmountNegativDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DefaultModifiersDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrePaymentDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DefaultModifier1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefaultModifier2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefaultModifier3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DefaultModifier4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MyProceduresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeStampDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InHouseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InHouseBillingDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ChartEntryDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCHDxRxLtMtTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter()
        Me.BtnProcedures = New System.Windows.Forms.Button()
        Me.BtnVisitReport = New System.Windows.Forms.Button()
        Me.PanelVitals = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DgVitals = New System.Windows.Forms.DataGridView()
        Me.TimeStampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TempDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PulseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RespDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SystolicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiastolicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HtInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WtLbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BMIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PulseOxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodSugarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PBoxPatient = New System.Windows.Forms.PictureBox()
        Me.BtnToken = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.MMChartVisitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartVisitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMadication.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DgMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.PanelProcedure.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DgProcedure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPRocedureDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVitals.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DgVitals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBoxPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.MMChartVisitDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(211, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(713, 557)
        Me.Panel1.TabIndex = 0
        '
        'MMChartVisitDataGridView
        '
        Me.MMChartVisitDataGridView.AllowUserToAddRows = False
        Me.MMChartVisitDataGridView.AllowUserToDeleteRows = False
        Me.MMChartVisitDataGridView.AutoGenerateColumns = False
        Me.MMChartVisitDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MMChartVisitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MMChartVisitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CaseNumber, Me.DOB, Me.FirstName, Me.LastName, Me.ChartNumber, Me.DateVisit, Me.VisitType, Me.PhysicianName, Me.TokenNo})
        Me.MMChartVisitDataGridView.DataSource = Me.MMChartVisitBindingSource
        Me.MMChartVisitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MMChartVisitDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MMChartVisitDataGridView.Name = "MMChartVisitDataGridView"
        Me.MMChartVisitDataGridView.ReadOnly = True
        Me.MMChartVisitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MMChartVisitDataGridView.Size = New System.Drawing.Size(713, 557)
        Me.MMChartVisitDataGridView.TabIndex = 0
        '
        'CaseNumber
        '
        Me.CaseNumber.DataPropertyName = "CaseNumber"
        Me.CaseNumber.HeaderText = "CaseNo"
        Me.CaseNumber.Name = "CaseNumber"
        Me.CaseNumber.ReadOnly = True
        Me.CaseNumber.Width = 70
        '
        'DOB
        '
        Me.DOB.DataPropertyName = "DOB"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DOB.DefaultCellStyle = DataGridViewCellStyle1
        Me.DOB.HeaderText = "DOB"
        Me.DOB.Name = "DOB"
        Me.DOB.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Width = 130
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "LastName"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Width = 130
        '
        'ChartNumber
        '
        Me.ChartNumber.DataPropertyName = "ChartNumber"
        Me.ChartNumber.HeaderText = "ChartNumber"
        Me.ChartNumber.Name = "ChartNumber"
        Me.ChartNumber.ReadOnly = True
        '
        'DateVisit
        '
        Me.DateVisit.DataPropertyName = "Date"
        Me.DateVisit.HeaderText = "Date"
        Me.DateVisit.Name = "DateVisit"
        Me.DateVisit.ReadOnly = True
        '
        'VisitType
        '
        Me.VisitType.DataPropertyName = "VisitType"
        Me.VisitType.HeaderText = "VisitType"
        Me.VisitType.Name = "VisitType"
        Me.VisitType.ReadOnly = True
        '
        'PhysicianName
        '
        Me.PhysicianName.DataPropertyName = "AssignedProvider"
        Me.PhysicianName.HeaderText = "Physician"
        Me.PhysicianName.Name = "PhysicianName"
        Me.PhysicianName.ReadOnly = True
        Me.PhysicianName.Width = 150
        '
        'TokenNo
        '
        Me.TokenNo.DataPropertyName = "Extra1"
        Me.TokenNo.HeaderText = "TokenNo"
        Me.TokenNo.Name = "TokenNo"
        Me.TokenNo.ReadOnly = True
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
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.txtFind)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.C)
        Me.Panel2.Controls.Add(Me.CBStatus)
        Me.Panel2.Controls.Add(Me.CBDate)
        Me.Panel2.Controls.Add(Me.CBPhysician)
        Me.Panel2.Controls.Add(Me.BtnRefresh)
        Me.Panel2.Controls.Add(Me.cmbFilter)
        Me.Panel2.Controls.Add(Me.lblPracticeName)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1287, 95)
        Me.Panel2.TabIndex = 1
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(248, 59)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(100, 21)
        Me.txtFind.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(986, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 15)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(776, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "FilterByDate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(539, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Physician Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(214, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Find"
        '
        'C
        '
        Me.C.AutoSize = True
        Me.C.Location = New System.Drawing.Point(354, 62)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(46, 15)
        Me.C.TabIndex = 15
        Me.C.Text = "Criteria"
        '
        'CBStatus
        '
        Me.CBStatus.FormattingEnabled = True
        Me.CBStatus.Location = New System.Drawing.Point(1030, 59)
        Me.CBStatus.Name = "CBStatus"
        Me.CBStatus.Size = New System.Drawing.Size(130, 23)
        Me.CBStatus.TabIndex = 14
        '
        'CBDate
        '
        Me.CBDate.FormattingEnabled = True
        Me.CBDate.Items.AddRange(New Object() {"Today", "Yesterday", "LastWeek", "LastMonth", "All"})
        Me.CBDate.Location = New System.Drawing.Point(855, 59)
        Me.CBDate.Name = "CBDate"
        Me.CBDate.Size = New System.Drawing.Size(121, 23)
        Me.CBDate.TabIndex = 14
        Me.CBDate.Text = "Today"
        '
        'CBPhysician
        '
        Me.CBPhysician.FormattingEnabled = True
        Me.CBPhysician.Location = New System.Drawing.Point(638, 59)
        Me.CBPhysician.Name = "CBPhysician"
        Me.CBPhysician.Size = New System.Drawing.Size(121, 23)
        Me.CBPhysician.TabIndex = 14
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.Green
        Me.BtnRefresh.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRefresh.Location = New System.Drawing.Point(66, 49)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(78, 37)
        Me.BtnRefresh.TabIndex = 194
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"FirstName", "LastName", "ChartNumber", "CaseNumber"})
        Me.cmbFilter.Location = New System.Drawing.Point(402, 59)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 23)
        Me.cmbFilter.TabIndex = 14
        '
        'lblPracticeName
        '
        Me.lblPracticeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPracticeName.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblPracticeName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPracticeName.ForeColor = System.Drawing.Color.White
        Me.lblPracticeName.Location = New System.Drawing.Point(0, 0)
        Me.lblPracticeName.Name = "lblPracticeName"
        Me.lblPracticeName.Size = New System.Drawing.Size(1287, 41)
        Me.lblPracticeName.TabIndex = 13
        Me.lblPracticeName.Text = "Visit List of Patients"
        Me.lblPracticeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BtnCompleted)
        Me.Panel3.Controls.Add(Me.TBTokenNo)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TBDate)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.tbDOB)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.TBPhysicianName)
        Me.Panel3.Controls.Add(Me.LBPhysicianName)
        Me.Panel3.Controls.Add(Me.ChartNo)
        Me.Panel3.Controls.Add(Me.txtCaseNo)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(1, 97)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 257)
        Me.Panel3.TabIndex = 1
        '
        'BtnCompleted
        '
        Me.BtnCompleted.BackColor = System.Drawing.Color.Chocolate
        Me.BtnCompleted.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompleted.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCompleted.Location = New System.Drawing.Point(61, 223)
        Me.BtnCompleted.Name = "BtnCompleted"
        Me.BtnCompleted.Size = New System.Drawing.Size(84, 28)
        Me.BtnCompleted.TabIndex = 195
        Me.BtnCompleted.Text = "Complete"
        Me.BtnCompleted.UseVisualStyleBackColor = False
        '
        'TBTokenNo
        '
        Me.TBTokenNo.Location = New System.Drawing.Point(68, 100)
        Me.TBTokenNo.Name = "TBTokenNo"
        Me.TBTokenNo.Size = New System.Drawing.Size(122, 21)
        Me.TBTokenNo.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "TokenNo:"
        '
        'TBDate
        '
        Me.TBDate.Location = New System.Drawing.Point(67, 196)
        Me.TBDate.Name = "TBDate"
        Me.TBDate.Size = New System.Drawing.Size(122, 21)
        Me.TBDate.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 15)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Date:"
        '
        'tbDOB
        '
        Me.tbDOB.Location = New System.Drawing.Point(67, 133)
        Me.tbDOB.Name = "tbDOB"
        Me.tbDOB.Size = New System.Drawing.Size(122, 21)
        Me.tbDOB.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "DOB:"
        '
        'TBPhysicianName
        '
        Me.TBPhysicianName.Location = New System.Drawing.Point(68, 165)
        Me.TBPhysicianName.Name = "TBPhysicianName"
        Me.TBPhysicianName.Size = New System.Drawing.Size(122, 21)
        Me.TBPhysicianName.TabIndex = 14
        '
        'LBPhysicianName
        '
        Me.LBPhysicianName.AutoSize = True
        Me.LBPhysicianName.Location = New System.Drawing.Point(8, 168)
        Me.LBPhysicianName.Name = "LBPhysicianName"
        Me.LBPhysicianName.Size = New System.Drawing.Size(62, 15)
        Me.LBPhysicianName.TabIndex = 13
        Me.LBPhysicianName.Text = "Physician:"
        '
        'ChartNo
        '
        Me.ChartNo.BackColor = System.Drawing.Color.White
        Me.ChartNo.Enabled = False
        Me.ChartNo.Location = New System.Drawing.Point(68, 13)
        Me.ChartNo.Name = "ChartNo"
        Me.ChartNo.Size = New System.Drawing.Size(121, 21)
        Me.ChartNo.TabIndex = 0
        '
        'txtCaseNo
        '
        Me.txtCaseNo.AcceptsReturn = True
        Me.txtCaseNo.BackColor = System.Drawing.Color.White
        Me.txtCaseNo.Enabled = False
        Me.txtCaseNo.Location = New System.Drawing.Point(68, 71)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(121, 21)
        Me.txtCaseNo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(68, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(122, 21)
        Me.txtName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CaseNo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ch No"
        '
        'btnVitals
        '
        Me.btnVitals.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnVitals.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVitals.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVitals.Location = New System.Drawing.Point(12, 427)
        Me.btnVitals.Name = "btnVitals"
        Me.btnVitals.Size = New System.Drawing.Size(179, 37)
        Me.btnVitals.TabIndex = 194
        Me.btnVitals.Text = "Vital Signs"
        Me.btnVitals.UseVisualStyleBackColor = False
        '
        'BtnMedication
        '
        Me.BtnMedication.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnMedication.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedication.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMedication.Location = New System.Drawing.Point(12, 481)
        Me.BtnMedication.Name = "BtnMedication"
        Me.BtnMedication.Size = New System.Drawing.Size(179, 37)
        Me.BtnMedication.TabIndex = 194
        Me.BtnMedication.Text = "Medications"
        Me.BtnMedication.UseVisualStyleBackColor = False
        '
        'MMChartTVitalSignBindingSource
        '
        Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
        Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
        '
        'PanelMadication
        '
        Me.PanelMadication.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMadication.Controls.Add(Me.Panel6)
        Me.PanelMadication.Controls.Add(Me.Label6)
        Me.PanelMadication.Location = New System.Drawing.Point(4, -1)
        Me.PanelMadication.Name = "PanelMadication"
        Me.PanelMadication.Size = New System.Drawing.Size(361, 156)
        Me.PanelMadication.TabIndex = 195
        Me.PanelMadication.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel6.Controls.Add(Me.DgMedicine)
        Me.Panel6.Location = New System.Drawing.Point(0, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(359, 124)
        Me.Panel6.TabIndex = 15
        '
        'DgMedicine
        '
        Me.DgMedicine.AllowUserToAddRows = False
        Me.DgMedicine.AllowUserToDeleteRows = False
        Me.DgMedicine.AutoGenerateColumns = False
        Me.DgMedicine.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgMedicine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn17})
        Me.DgMedicine.DataSource = Me.MMChartRxBindingSource
        Me.DgMedicine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgMedicine.Location = New System.Drawing.Point(0, 0)
        Me.DgMedicine.Name = "DgMedicine"
        Me.DgMedicine.ReadOnly = True
        Me.DgMedicine.RowHeadersVisible = False
        Me.DgMedicine.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DgMedicine.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DgMedicine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgMedicine.Size = New System.Drawing.Size(359, 124)
        Me.DgMedicine.TabIndex = 197
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Medication"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Medication"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Dosage"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Dosage"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "StartDate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "StartDate"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "EndDate"
        Me.DataGridViewTextBoxColumn11.HeaderText = "EndDate"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'MMChartRxBindingSource
        '
        Me.MMChartRxBindingSource.DataMember = "MMChartRx"
        Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(357, 30)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Medications"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel4.Controls.Add(Me.PanelProcedure)
        Me.Panel4.Controls.Add(Me.PanelMadication)
        Me.Panel4.Location = New System.Drawing.Point(921, 172)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(367, 482)
        Me.Panel4.TabIndex = 196
        '
        'PanelProcedure
        '
        Me.PanelProcedure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelProcedure.Controls.Add(Me.Panel8)
        Me.PanelProcedure.Controls.Add(Me.Label10)
        Me.PanelProcedure.Location = New System.Drawing.Point(4, 168)
        Me.PanelProcedure.Name = "PanelProcedure"
        Me.PanelProcedure.Size = New System.Drawing.Size(361, 200)
        Me.PanelProcedure.TabIndex = 195
        Me.PanelProcedure.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel8.Controls.Add(Me.DgProcedure)
        Me.Panel8.Controls.Add(Me.MMPRocedureDataGridView)
        Me.Panel8.Controls.Add(Me.DataGridView1)
        Me.Panel8.Location = New System.Drawing.Point(0, 31)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(359, 166)
        Me.Panel8.TabIndex = 15
        '
        'DgProcedure
        '
        Me.DgProcedure.AllowUserToAddRows = False
        Me.DgProcedure.AllowUserToDeleteRows = False
        Me.DgProcedure.AutoGenerateColumns = False
        Me.DgProcedure.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgProcedure.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn16, Me.Type, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1})
        Me.DgProcedure.DataSource = Me.MMCHDxRxLtMtBindingSource
        Me.DgProcedure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgProcedure.Location = New System.Drawing.Point(0, 0)
        Me.DgProcedure.Name = "DgProcedure"
        Me.DgProcedure.ReadOnly = True
        Me.DgProcedure.RowHeadersVisible = False
        Me.DgProcedure.Size = New System.Drawing.Size(359, 166)
        Me.DgProcedure.TabIndex = 197
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 160
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "User"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'MMCHDxRxLtMtBindingSource
        '
        Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
        Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMPRocedureDataGridView
        '
        Me.MMPRocedureDataGridView.AllowUserToAddRows = False
        Me.MMPRocedureDataGridView.AllowUserToDeleteRows = False
        Me.MMPRocedureDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MMPRocedureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MMPRocedureDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MMPRocedureDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MMPRocedureDataGridView.Name = "MMPRocedureDataGridView"
        Me.MMPRocedureDataGridView.ReadOnly = True
        Me.MMPRocedureDataGridView.RowHeadersVisible = False
        Me.MMPRocedureDataGridView.Size = New System.Drawing.Size(359, 166)
        Me.MMPRocedureDataGridView.TabIndex = 196
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(359, 166)
        Me.DataGridView1.TabIndex = 197
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(1, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(357, 30)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Procedures"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MMChartVisitTableAdapter
        '
        Me.MMChartVisitTableAdapter.ClearBeforeFill = True
        '
        'MMChartTVitalSignTableAdapter
        '
        Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True
        '
        'MMChartRxTableAdapter
        '
        Me.MMChartRxTableAdapter.ClearBeforeFill = True
        '
        'Code1DataGridViewTextBoxColumn
        '
        Me.Code1DataGridViewTextBoxColumn.DataPropertyName = "Code1"
        Me.Code1DataGridViewTextBoxColumn.HeaderText = "Code1"
        Me.Code1DataGridViewTextBoxColumn.Name = "Code1DataGridViewTextBoxColumn"
        '
        'Code2DataGridViewTextBoxColumn
        '
        Me.Code2DataGridViewTextBoxColumn.DataPropertyName = "Code2"
        Me.Code2DataGridViewTextBoxColumn.HeaderText = "Code2"
        Me.Code2DataGridViewTextBoxColumn.Name = "Code2DataGridViewTextBoxColumn"
        '
        'Code3DataGridViewTextBoxColumn
        '
        Me.Code3DataGridViewTextBoxColumn.DataPropertyName = "Code3"
        Me.Code3DataGridViewTextBoxColumn.HeaderText = "Code3"
        Me.Code3DataGridViewTextBoxColumn.Name = "Code3DataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'TypeofServiceDataGridViewTextBoxColumn
        '
        Me.TypeofServiceDataGridViewTextBoxColumn.DataPropertyName = "TypeofService"
        Me.TypeofServiceDataGridViewTextBoxColumn.HeaderText = "TypeofService"
        Me.TypeofServiceDataGridViewTextBoxColumn.Name = "TypeofServiceDataGridViewTextBoxColumn"
        '
        'ScreenLocationDataGridViewTextBoxColumn
        '
        Me.ScreenLocationDataGridViewTextBoxColumn.DataPropertyName = "ScreenLocation"
        Me.ScreenLocationDataGridViewTextBoxColumn.HeaderText = "ScreenLocation"
        Me.ScreenLocationDataGridViewTextBoxColumn.Name = "ScreenLocationDataGridViewTextBoxColumn"
        '
        'DefaultPlaceService1DataGridViewTextBoxColumn
        '
        Me.DefaultPlaceService1DataGridViewTextBoxColumn.DataPropertyName = "DefaultPlaceService1"
        Me.DefaultPlaceService1DataGridViewTextBoxColumn.HeaderText = "DefaultPlaceService1"
        Me.DefaultPlaceService1DataGridViewTextBoxColumn.Name = "DefaultPlaceService1DataGridViewTextBoxColumn"
        '
        'DefaultPlaceService2DataGridViewTextBoxColumn
        '
        Me.DefaultPlaceService2DataGridViewTextBoxColumn.DataPropertyName = "DefaultPlaceService2"
        Me.DefaultPlaceService2DataGridViewTextBoxColumn.HeaderText = "DefaultPlaceService2"
        Me.DefaultPlaceService2DataGridViewTextBoxColumn.Name = "DefaultPlaceService2DataGridViewTextBoxColumn"
        '
        'DefaultPlaceService3DataGridViewTextBoxColumn
        '
        Me.DefaultPlaceService3DataGridViewTextBoxColumn.DataPropertyName = "DefaultPlaceService3"
        Me.DefaultPlaceService3DataGridViewTextBoxColumn.HeaderText = "DefaultPlaceService3"
        Me.DefaultPlaceService3DataGridViewTextBoxColumn.Name = "DefaultPlaceService3DataGridViewTextBoxColumn"
        '
        'TimeToDoProcedureDataGridViewTextBoxColumn
        '
        Me.TimeToDoProcedureDataGridViewTextBoxColumn.DataPropertyName = "TimeToDoProcedure"
        Me.TimeToDoProcedureDataGridViewTextBoxColumn.HeaderText = "TimeToDoProcedure"
        Me.TimeToDoProcedureDataGridViewTextBoxColumn.Name = "TimeToDoProcedureDataGridViewTextBoxColumn"
        '
        'InsuranceCategoryDataGridViewTextBoxColumn
        '
        Me.InsuranceCategoryDataGridViewTextBoxColumn.DataPropertyName = "InsuranceCategory"
        Me.InsuranceCategoryDataGridViewTextBoxColumn.HeaderText = "InsuranceCategory"
        Me.InsuranceCategoryDataGridViewTextBoxColumn.Name = "InsuranceCategoryDataGridViewTextBoxColumn"
        '
        'PatientOnlyResponsibleDataGridViewCheckBoxColumn
        '
        Me.PatientOnlyResponsibleDataGridViewCheckBoxColumn.DataPropertyName = "PatientOnlyResponsible"
        Me.PatientOnlyResponsibleDataGridViewCheckBoxColumn.HeaderText = "PatientOnlyResponsible"
        Me.PatientOnlyResponsibleDataGridViewCheckBoxColumn.Name = "PatientOnlyResponsibleDataGridViewCheckBoxColumn"
        '
        'DontPrintonInsuranceDataGridViewTextBoxColumn
        '
        Me.DontPrintonInsuranceDataGridViewTextBoxColumn.DataPropertyName = "DontPrintonInsurance"
        Me.DontPrintonInsuranceDataGridViewTextBoxColumn.HeaderText = "DontPrintonInsurance"
        Me.DontPrintonInsuranceDataGridViewTextBoxColumn.Name = "DontPrintonInsuranceDataGridViewTextBoxColumn"
        '
        'OnlyPrintonInsuranceDataGridViewTextBoxColumn
        '
        Me.OnlyPrintonInsuranceDataGridViewTextBoxColumn.DataPropertyName = "OnlyPrintonInsurance"
        Me.OnlyPrintonInsuranceDataGridViewTextBoxColumn.HeaderText = "OnlyPrintonInsurance"
        Me.OnlyPrintonInsuranceDataGridViewTextBoxColumn.Name = "OnlyPrintonInsuranceDataGridViewTextBoxColumn"
        '
        'CostofServiceProductDataGridViewTextBoxColumn
        '
        Me.CostofServiceProductDataGridViewTextBoxColumn.DataPropertyName = "CostofServiceProduct"
        Me.CostofServiceProductDataGridViewTextBoxColumn.HeaderText = "CostofServiceProduct"
        Me.CostofServiceProductDataGridViewTextBoxColumn.Name = "CostofServiceProductDataGridViewTextBoxColumn"
        '
        'MedicareAllowedAmountDataGridViewTextBoxColumn
        '
        Me.MedicareAllowedAmountDataGridViewTextBoxColumn.DataPropertyName = "MedicareAllowedAmount"
        Me.MedicareAllowedAmountDataGridViewTextBoxColumn.HeaderText = "MedicareAllowedAmount"
        Me.MedicareAllowedAmountDataGridViewTextBoxColumn.Name = "MedicareAllowedAmountDataGridViewTextBoxColumn"
        '
        'AmountADataGridViewTextBoxColumn
        '
        Me.AmountADataGridViewTextBoxColumn.DataPropertyName = "AmountA"
        Me.AmountADataGridViewTextBoxColumn.HeaderText = "AmountA"
        Me.AmountADataGridViewTextBoxColumn.Name = "AmountADataGridViewTextBoxColumn"
        '
        'AmountBDataGridViewTextBoxColumn
        '
        Me.AmountBDataGridViewTextBoxColumn.DataPropertyName = "AmountB"
        Me.AmountBDataGridViewTextBoxColumn.HeaderText = "AmountB"
        Me.AmountBDataGridViewTextBoxColumn.Name = "AmountBDataGridViewTextBoxColumn"
        '
        'AmountCDataGridViewTextBoxColumn
        '
        Me.AmountCDataGridViewTextBoxColumn.DataPropertyName = "AmountC"
        Me.AmountCDataGridViewTextBoxColumn.HeaderText = "AmountC"
        Me.AmountCDataGridViewTextBoxColumn.Name = "AmountCDataGridViewTextBoxColumn"
        '
        'AccountCodeDataGridViewTextBoxColumn
        '
        Me.AccountCodeDataGridViewTextBoxColumn.DataPropertyName = "AccountCode"
        Me.AccountCodeDataGridViewTextBoxColumn.HeaderText = "AccountCode"
        Me.AccountCodeDataGridViewTextBoxColumn.Name = "AccountCodeDataGridViewTextBoxColumn"
        '
        'TaxableDataGridViewCheckBoxColumn
        '
        Me.TaxableDataGridViewCheckBoxColumn.DataPropertyName = "Taxable"
        Me.TaxableDataGridViewCheckBoxColumn.HeaderText = "Taxable"
        Me.TaxableDataGridViewCheckBoxColumn.Name = "TaxableDataGridViewCheckBoxColumn"
        '
        'InactiveDataGridViewCheckBoxColumn
        '
        Me.InactiveDataGridViewCheckBoxColumn.DataPropertyName = "Inactive"
        Me.InactiveDataGridViewCheckBoxColumn.HeaderText = "Inactive"
        Me.InactiveDataGridViewCheckBoxColumn.Name = "InactiveDataGridViewCheckBoxColumn"
        '
        'AdjustmentAmountNegativDataGridViewCheckBoxColumn
        '
        Me.AdjustmentAmountNegativDataGridViewCheckBoxColumn.DataPropertyName = "AdjustmentAmountNegativ"
        Me.AdjustmentAmountNegativDataGridViewCheckBoxColumn.HeaderText = "AdjustmentAmountNegativ"
        Me.AdjustmentAmountNegativDataGridViewCheckBoxColumn.Name = "AdjustmentAmountNegativDataGridViewCheckBoxColumn"
        '
        'DefaultModifiersDataGridViewTextBoxColumn
        '
        Me.DefaultModifiersDataGridViewTextBoxColumn.DataPropertyName = "DefaultModifiers"
        Me.DefaultModifiersDataGridViewTextBoxColumn.HeaderText = "DefaultModifiers"
        Me.DefaultModifiersDataGridViewTextBoxColumn.Name = "DefaultModifiersDataGridViewTextBoxColumn"
        '
        'PrePaymentDataGridViewCheckBoxColumn
        '
        Me.PrePaymentDataGridViewCheckBoxColumn.DataPropertyName = "PrePayment"
        Me.PrePaymentDataGridViewCheckBoxColumn.HeaderText = "PrePayment"
        Me.PrePaymentDataGridViewCheckBoxColumn.Name = "PrePaymentDataGridViewCheckBoxColumn"
        '
        'DefaultModifier1DataGridViewTextBoxColumn
        '
        Me.DefaultModifier1DataGridViewTextBoxColumn.DataPropertyName = "DefaultModifier1"
        Me.DefaultModifier1DataGridViewTextBoxColumn.HeaderText = "DefaultModifier1"
        Me.DefaultModifier1DataGridViewTextBoxColumn.Name = "DefaultModifier1DataGridViewTextBoxColumn"
        '
        'DefaultModifier2DataGridViewTextBoxColumn
        '
        Me.DefaultModifier2DataGridViewTextBoxColumn.DataPropertyName = "DefaultModifier2"
        Me.DefaultModifier2DataGridViewTextBoxColumn.HeaderText = "DefaultModifier2"
        Me.DefaultModifier2DataGridViewTextBoxColumn.Name = "DefaultModifier2DataGridViewTextBoxColumn"
        '
        'DefaultModifier3DataGridViewTextBoxColumn
        '
        Me.DefaultModifier3DataGridViewTextBoxColumn.DataPropertyName = "DefaultModifier3"
        Me.DefaultModifier3DataGridViewTextBoxColumn.HeaderText = "DefaultModifier3"
        Me.DefaultModifier3DataGridViewTextBoxColumn.Name = "DefaultModifier3DataGridViewTextBoxColumn"
        '
        'DefaultModifier4DataGridViewTextBoxColumn
        '
        Me.DefaultModifier4DataGridViewTextBoxColumn.DataPropertyName = "DefaultModifier4"
        Me.DefaultModifier4DataGridViewTextBoxColumn.HeaderText = "DefaultModifier4"
        Me.DefaultModifier4DataGridViewTextBoxColumn.Name = "DefaultModifier4DataGridViewTextBoxColumn"
        '
        'MyProceduresDataGridViewTextBoxColumn
        '
        Me.MyProceduresDataGridViewTextBoxColumn.DataPropertyName = "MyProcedures"
        Me.MyProceduresDataGridViewTextBoxColumn.HeaderText = "MyProcedures"
        Me.MyProceduresDataGridViewTextBoxColumn.Name = "MyProceduresDataGridViewTextBoxColumn"
        '
        'TimeStampDataGridViewTextBoxColumn1
        '
        Me.TimeStampDataGridViewTextBoxColumn1.DataPropertyName = "TimeStamp"
        Me.TimeStampDataGridViewTextBoxColumn1.HeaderText = "TimeStamp"
        Me.TimeStampDataGridViewTextBoxColumn1.Name = "TimeStampDataGridViewTextBoxColumn1"
        '
        'InHouseDataGridViewCheckBoxColumn
        '
        Me.InHouseDataGridViewCheckBoxColumn.DataPropertyName = "InHouse"
        Me.InHouseDataGridViewCheckBoxColumn.HeaderText = "InHouse"
        Me.InHouseDataGridViewCheckBoxColumn.Name = "InHouseDataGridViewCheckBoxColumn"
        '
        'InHouseBillingDataGridViewCheckBoxColumn
        '
        Me.InHouseBillingDataGridViewCheckBoxColumn.DataPropertyName = "InHouseBilling"
        Me.InHouseBillingDataGridViewCheckBoxColumn.HeaderText = "InHouseBilling"
        Me.InHouseBillingDataGridViewCheckBoxColumn.Name = "InHouseBillingDataGridViewCheckBoxColumn"
        '
        'ChartEntryDataGridViewCheckBoxColumn
        '
        Me.ChartEntryDataGridViewCheckBoxColumn.DataPropertyName = "ChartEntry"
        Me.ChartEntryDataGridViewCheckBoxColumn.HeaderText = "ChartEntry"
        Me.ChartEntryDataGridViewCheckBoxColumn.Name = "ChartEntryDataGridViewCheckBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MMCHDxRxLtMtTableAdapter
        '
        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
        '
        'BtnProcedures
        '
        Me.BtnProcedures.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnProcedures.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProcedures.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnProcedures.Location = New System.Drawing.Point(12, 535)
        Me.BtnProcedures.Name = "BtnProcedures"
        Me.BtnProcedures.Size = New System.Drawing.Size(179, 37)
        Me.BtnProcedures.TabIndex = 194
        Me.BtnProcedures.Text = "Procedures"
        Me.BtnProcedures.UseVisualStyleBackColor = False
        '
        'BtnVisitReport
        '
        Me.BtnVisitReport.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnVisitReport.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVisitReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVisitReport.Location = New System.Drawing.Point(12, 589)
        Me.BtnVisitReport.Name = "BtnVisitReport"
        Me.BtnVisitReport.Size = New System.Drawing.Size(179, 37)
        Me.BtnVisitReport.TabIndex = 194
        Me.BtnVisitReport.Text = "Visit Report"
        Me.BtnVisitReport.UseVisualStyleBackColor = False
        '
        'PanelVitals
        '
        Me.PanelVitals.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVitals.Controls.Add(Me.Panel5)
        Me.PanelVitals.Location = New System.Drawing.Point(211, 651)
        Me.PanelVitals.Name = "PanelVitals"
        Me.PanelVitals.Size = New System.Drawing.Size(1076, 90)
        Me.PanelVitals.TabIndex = 197
        Me.PanelVitals.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel5.Controls.Add(Me.DgVitals)
        Me.Panel5.Location = New System.Drawing.Point(2, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1071, 92)
        Me.Panel5.TabIndex = 15
        '
        'DgVitals
        '
        Me.DgVitals.AllowUserToAddRows = False
        Me.DgVitals.AllowUserToDeleteRows = False
        Me.DgVitals.AutoGenerateColumns = False
        Me.DgVitals.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgVitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgVitals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeStampDataGridViewTextBoxColumn, Me.TempDataGridViewTextBoxColumn, Me.PulseDataGridViewTextBoxColumn, Me.RespDataGridViewTextBoxColumn, Me.SystolicDataGridViewTextBoxColumn, Me.DiastolicDataGridViewTextBoxColumn, Me.HtInDataGridViewTextBoxColumn, Me.WtLbDataGridViewTextBoxColumn, Me.OzDataGridViewTextBoxColumn, Me.BMIDataGridViewTextBoxColumn, Me.PulseOxDataGridViewTextBoxColumn, Me.BloodSugarDataGridViewTextBoxColumn, Me.LMPDataGridViewTextBoxColumn, Me.UserDataGridViewTextBoxColumn})
        Me.DgVitals.DataSource = Me.MMChartTVitalSignBindingSource
        Me.DgVitals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgVitals.Location = New System.Drawing.Point(0, 0)
        Me.DgVitals.Name = "DgVitals"
        Me.DgVitals.ReadOnly = True
        Me.DgVitals.RowHeadersVisible = False
        Me.DgVitals.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DgVitals.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgVitals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgVitals.Size = New System.Drawing.Size(1071, 92)
        Me.DgVitals.TabIndex = 198
        '
        'TimeStampDataGridViewTextBoxColumn
        '
        Me.TimeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp"
        Me.TimeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp"
        Me.TimeStampDataGridViewTextBoxColumn.Name = "TimeStampDataGridViewTextBoxColumn"
        Me.TimeStampDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeStampDataGridViewTextBoxColumn.Width = 125
        '
        'TempDataGridViewTextBoxColumn
        '
        Me.TempDataGridViewTextBoxColumn.DataPropertyName = "Temp"
        Me.TempDataGridViewTextBoxColumn.HeaderText = "Temp"
        Me.TempDataGridViewTextBoxColumn.Name = "TempDataGridViewTextBoxColumn"
        Me.TempDataGridViewTextBoxColumn.ReadOnly = True
        Me.TempDataGridViewTextBoxColumn.Width = 120
        '
        'PulseDataGridViewTextBoxColumn
        '
        Me.PulseDataGridViewTextBoxColumn.DataPropertyName = "Pulse"
        Me.PulseDataGridViewTextBoxColumn.HeaderText = "Pulse"
        Me.PulseDataGridViewTextBoxColumn.Name = "PulseDataGridViewTextBoxColumn"
        Me.PulseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RespDataGridViewTextBoxColumn
        '
        Me.RespDataGridViewTextBoxColumn.DataPropertyName = "Resp"
        Me.RespDataGridViewTextBoxColumn.HeaderText = "Resp"
        Me.RespDataGridViewTextBoxColumn.Name = "RespDataGridViewTextBoxColumn"
        Me.RespDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SystolicDataGridViewTextBoxColumn
        '
        Me.SystolicDataGridViewTextBoxColumn.DataPropertyName = "Systolic"
        Me.SystolicDataGridViewTextBoxColumn.HeaderText = "Systolic"
        Me.SystolicDataGridViewTextBoxColumn.Name = "SystolicDataGridViewTextBoxColumn"
        Me.SystolicDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiastolicDataGridViewTextBoxColumn
        '
        Me.DiastolicDataGridViewTextBoxColumn.DataPropertyName = "Diastolic"
        Me.DiastolicDataGridViewTextBoxColumn.HeaderText = "Diastolic"
        Me.DiastolicDataGridViewTextBoxColumn.Name = "DiastolicDataGridViewTextBoxColumn"
        Me.DiastolicDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HtInDataGridViewTextBoxColumn
        '
        Me.HtInDataGridViewTextBoxColumn.DataPropertyName = "HtIn"
        Me.HtInDataGridViewTextBoxColumn.HeaderText = "HtIn"
        Me.HtInDataGridViewTextBoxColumn.Name = "HtInDataGridViewTextBoxColumn"
        Me.HtInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WtLbDataGridViewTextBoxColumn
        '
        Me.WtLbDataGridViewTextBoxColumn.DataPropertyName = "WtLb"
        Me.WtLbDataGridViewTextBoxColumn.HeaderText = "WtLb"
        Me.WtLbDataGridViewTextBoxColumn.Name = "WtLbDataGridViewTextBoxColumn"
        Me.WtLbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OzDataGridViewTextBoxColumn
        '
        Me.OzDataGridViewTextBoxColumn.DataPropertyName = "Oz"
        Me.OzDataGridViewTextBoxColumn.HeaderText = "Oz"
        Me.OzDataGridViewTextBoxColumn.Name = "OzDataGridViewTextBoxColumn"
        Me.OzDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BMIDataGridViewTextBoxColumn
        '
        Me.BMIDataGridViewTextBoxColumn.DataPropertyName = "BMI"
        Me.BMIDataGridViewTextBoxColumn.HeaderText = "BMI"
        Me.BMIDataGridViewTextBoxColumn.Name = "BMIDataGridViewTextBoxColumn"
        Me.BMIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PulseOxDataGridViewTextBoxColumn
        '
        Me.PulseOxDataGridViewTextBoxColumn.DataPropertyName = "PulseOx"
        Me.PulseOxDataGridViewTextBoxColumn.HeaderText = "PulseOx"
        Me.PulseOxDataGridViewTextBoxColumn.Name = "PulseOxDataGridViewTextBoxColumn"
        Me.PulseOxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BloodSugarDataGridViewTextBoxColumn
        '
        Me.BloodSugarDataGridViewTextBoxColumn.DataPropertyName = "BloodSugar"
        Me.BloodSugarDataGridViewTextBoxColumn.HeaderText = "BloodSugar"
        Me.BloodSugarDataGridViewTextBoxColumn.Name = "BloodSugarDataGridViewTextBoxColumn"
        Me.BloodSugarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LMPDataGridViewTextBoxColumn
        '
        Me.LMPDataGridViewTextBoxColumn.DataPropertyName = "LMP"
        Me.LMPDataGridViewTextBoxColumn.HeaderText = "LMP"
        Me.LMPDataGridViewTextBoxColumn.Name = "LMPDataGridViewTextBoxColumn"
        Me.LMPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserDataGridViewTextBoxColumn
        '
        Me.UserDataGridViewTextBoxColumn.DataPropertyName = "User"
        Me.UserDataGridViewTextBoxColumn.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn.Name = "UserDataGridViewTextBoxColumn"
        Me.UserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1, 650)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 90)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Vital Signs"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBoxPatient
        '
        Me.PBoxPatient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBoxPatient.BackColor = System.Drawing.Color.Transparent
        Me.PBoxPatient.Location = New System.Drawing.Point(928, 97)
        Me.PBoxPatient.Name = "PBoxPatient"
        Me.PBoxPatient.Size = New System.Drawing.Size(75, 70)
        Me.PBoxPatient.TabIndex = 17
        Me.PBoxPatient.TabStop = False
        '
        'BtnToken
        '
        Me.BtnToken.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnToken.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnToken.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnToken.Location = New System.Drawing.Point(13, 373)
        Me.BtnToken.Name = "BtnToken"
        Me.BtnToken.Size = New System.Drawing.Size(179, 37)
        Me.BtnToken.TabIndex = 194
        Me.BtnToken.Text = "Print Token"
        Me.BtnToken.UseVisualStyleBackColor = False
        '
        'VisitsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1285, 741)
        Me.Controls.Add(Me.PBoxPatient)
        Me.Controls.Add(Me.PanelVitals)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnVisitReport)
        Me.Controls.Add(Me.BtnProcedures)
        Me.Controls.Add(Me.BtnMedication)
        Me.Controls.Add(Me.BtnToken)
        Me.Controls.Add(Me.btnVitals)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "VisitsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisitsList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.MMChartVisitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartVisitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMadication.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.DgMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.PanelProcedure.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.DgProcedure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPRocedureDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVitals.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DgVitals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBoxPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MMDataDataSet1 As MMDataDataSet1
    Friend WithEvents MMChartVisitBindingSource As BindingSource
    Friend WithEvents MMChartVisitTableAdapter As MMDataDataSet1TableAdapters.MMChartVisitTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TBPhysicianName As TextBox
    Friend WithEvents LBPhysicianName As Label
    Friend WithEvents ChartNo As TextBox
    Friend WithEvents txtCaseNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBTokenNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPracticeName As Label
    Private WithEvents btnVitals As Button
    Private WithEvents BtnMedication As Button
    Friend WithEvents PanelMadication As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents MMChartTVitalSignBindingSource As BindingSource
    Friend WithEvents MMChartTVitalSignTableAdapter As MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter
    Friend WithEvents MMChartRxBindingSource As BindingSource
    Friend WithEvents MMChartRxTableAdapter As MMDataDataSet1TableAdapters.MMChartRxTableAdapter
    Friend WithEvents DgMedicine As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents C As Label
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBDate As ComboBox
    Friend WithEvents CBPhysician As ComboBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelProcedure As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents MMPRocedureDataGridView As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Code1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Code2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Code3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeofServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScreenLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefaultPlaceService1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefaultPlaceService2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefaultPlaceService3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeToDoProcedureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InsuranceCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PatientOnlyResponsibleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DontPrintonInsuranceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OnlyPrintonInsuranceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostofServiceProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicareAllowedAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxableDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents InactiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AdjustmentAmountNegativDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DefaultModifiersDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrePaymentDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DefaultModifier1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefaultModifier2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefaultModifier3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DefaultModifier4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MyProceduresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeStampDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents InHouseDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents InHouseBillingDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ChartEntryDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MMCHDxRxLtMtBindingSource As BindingSource
    Friend WithEvents MMCHDxRxLtMtTableAdapter As MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
    Friend WithEvents DgProcedure As DataGridView
    Private WithEvents BtnProcedures As Button
    Private WithEvents BtnVisitReport As Button
    Friend WithEvents TBDate As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PanelVitals As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DgVitals As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TimeStampDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TempDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PulseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RespDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SystolicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiastolicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HtInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WtLbDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OzDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BMIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PulseOxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloodSugarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tbDOB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents MMChartVisitDataGridView As DataGridView
    Friend WithEvents CaseNumber As DataGridViewTextBoxColumn
    Friend WithEvents DOB As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents ChartNumber As DataGridViewTextBoxColumn
    Friend WithEvents DateVisit As DataGridViewTextBoxColumn
    Friend WithEvents VisitType As DataGridViewTextBoxColumn
    Friend WithEvents PhysicianName As DataGridViewTextBoxColumn
    Friend WithEvents TokenNo As DataGridViewTextBoxColumn
    Private WithEvents PBoxPatient As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Private WithEvents BtnRefresh As Button
    Private WithEvents BtnToken As Button
    Private WithEvents BtnCompleted As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents CBStatus As ComboBox
End Class
