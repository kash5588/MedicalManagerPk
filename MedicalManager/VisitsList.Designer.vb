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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MMChartVisitDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPracticeName = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TBTokenNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.PanelVitals = New System.Windows.Forms.Panel()
        Me.PanelMadication = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
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
        Me.UserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodSugarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMChartTVitalSignBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1()
        Me.CaseNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChartNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateVisit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicianName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TokenNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMChartVisitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMChartVisitTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartVisitTableAdapter()
        Me.MMChartTVitalSignTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter()
        Me.MMChartRxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMChartRxTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartRxTableAdapter()
        Me.DgMedicine = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.MMChartVisitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelVitals.SuspendLayout()
        Me.PanelMadication.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DgVitals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartVisitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(649, 603)
        Me.Panel1.TabIndex = 0
        '
        'MMChartVisitDataGridView
        '
        Me.MMChartVisitDataGridView.AllowUserToAddRows = False
        Me.MMChartVisitDataGridView.AllowUserToDeleteRows = False
        Me.MMChartVisitDataGridView.AutoGenerateColumns = False
        Me.MMChartVisitDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MMChartVisitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MMChartVisitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CaseNumber, Me.FirstName, Me.LastName, Me.ChartNumber, Me.DateVisit, Me.VisitType, Me.PhysicianName, Me.TokenNo})
        Me.MMChartVisitDataGridView.DataSource = Me.MMChartVisitBindingSource
        Me.MMChartVisitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MMChartVisitDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MMChartVisitDataGridView.Name = "MMChartVisitDataGridView"
        Me.MMChartVisitDataGridView.ReadOnly = True
        Me.MMChartVisitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MMChartVisitDataGridView.Size = New System.Drawing.Size(649, 603)
        Me.MMChartVisitDataGridView.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.lblPracticeName)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1223, 95)
        Me.Panel2.TabIndex = 1
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
        Me.lblPracticeName.Size = New System.Drawing.Size(1223, 41)
        Me.lblPracticeName.TabIndex = 13
        Me.lblPracticeName.Text = "Visit List of Patients"
        Me.lblPracticeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TBTokenNo)
        Me.Panel3.Controls.Add(Me.Label1)
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
        Me.Panel3.Size = New System.Drawing.Size(209, 175)
        Me.Panel3.TabIndex = 1
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
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "TokenNo"
        '
        'TBPhysicianName
        '
        Me.TBPhysicianName.Location = New System.Drawing.Point(68, 129)
        Me.TBPhysicianName.Name = "TBPhysicianName"
        Me.TBPhysicianName.Size = New System.Drawing.Size(122, 21)
        Me.TBPhysicianName.TabIndex = 14
        '
        'LBPhysicianName
        '
        Me.LBPhysicianName.AutoSize = True
        Me.LBPhysicianName.Location = New System.Drawing.Point(8, 132)
        Me.LBPhysicianName.Name = "LBPhysicianName"
        Me.LBPhysicianName.Size = New System.Drawing.Size(59, 15)
        Me.LBPhysicianName.TabIndex = 13
        Me.LBPhysicianName.Text = "Physician"
        '
        'ChartNo
        '
        Me.ChartNo.BackColor = System.Drawing.Color.White
        Me.ChartNo.Enabled = False
        Me.ChartNo.Location = New System.Drawing.Point(68, 13)
        Me.ChartNo.Name = "ChartNo"
        Me.ChartNo.Size = New System.Drawing.Size(122, 21)
        Me.ChartNo.TabIndex = 0
        '
        'txtCaseNo
        '
        Me.txtCaseNo.AcceptsReturn = True
        Me.txtCaseNo.BackColor = System.Drawing.Color.White
        Me.txtCaseNo.Enabled = False
        Me.txtCaseNo.Location = New System.Drawing.Point(68, 71)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(122, 21)
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
        Me.btnVitals.Location = New System.Drawing.Point(12, 313)
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
        Me.BtnMedication.Location = New System.Drawing.Point(12, 365)
        Me.BtnMedication.Name = "BtnMedication"
        Me.BtnMedication.Size = New System.Drawing.Size(179, 37)
        Me.BtnMedication.TabIndex = 194
        Me.BtnMedication.Text = "Medications"
        Me.BtnMedication.UseVisualStyleBackColor = False
        '
        'PanelVitals
        '
        Me.PanelVitals.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVitals.Controls.Add(Me.Panel5)
        Me.PanelVitals.Controls.Add(Me.Label5)
        Me.PanelVitals.Location = New System.Drawing.Point(0, 0)
        Me.PanelVitals.Name = "PanelVitals"
        Me.PanelVitals.Size = New System.Drawing.Size(361, 122)
        Me.PanelVitals.TabIndex = 195
        Me.PanelVitals.Visible = False
        '
        'PanelMadication
        '
        Me.PanelMadication.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMadication.Controls.Add(Me.Panel6)
        Me.PanelMadication.Controls.Add(Me.Label6)
        Me.PanelMadication.Location = New System.Drawing.Point(0, 122)
        Me.PanelMadication.Name = "PanelMadication"
        Me.PanelMadication.Size = New System.Drawing.Size(361, 156)
        Me.PanelMadication.TabIndex = 195
        Me.PanelMadication.Visible = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(357, 30)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Vital Signs"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
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
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.Controls.Add(Me.PanelVitals)
        Me.Panel4.Controls.Add(Me.PanelMadication)
        Me.Panel4.Location = New System.Drawing.Point(862, 97)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(362, 603)
        Me.Panel4.TabIndex = 196
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel5.Controls.Add(Me.DgVitals)
        Me.Panel5.Location = New System.Drawing.Point(0, 30)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(359, 92)
        Me.Panel5.TabIndex = 15
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
        'DgVitals
        '
        Me.DgVitals.AllowUserToAddRows = False
        Me.DgVitals.AllowUserToDeleteRows = False
        Me.DgVitals.AutoGenerateColumns = False
        Me.DgVitals.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgVitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgVitals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeStampDataGridViewTextBoxColumn, Me.TempDataGridViewTextBoxColumn, Me.PulseDataGridViewTextBoxColumn, Me.RespDataGridViewTextBoxColumn, Me.SystolicDataGridViewTextBoxColumn, Me.DiastolicDataGridViewTextBoxColumn, Me.HtInDataGridViewTextBoxColumn, Me.WtLbDataGridViewTextBoxColumn, Me.OzDataGridViewTextBoxColumn, Me.BMIDataGridViewTextBoxColumn, Me.PulseOxDataGridViewTextBoxColumn, Me.UserDataGridViewTextBoxColumn, Me.BloodSugarDataGridViewTextBoxColumn, Me.LMPDataGridViewTextBoxColumn})
        Me.DgVitals.DataSource = Me.MMChartTVitalSignBindingSource
        Me.DgVitals.Location = New System.Drawing.Point(2, 3)
        Me.DgVitals.Name = "DgVitals"
        Me.DgVitals.ReadOnly = True
        Me.DgVitals.RowHeadersVisible = False
        Me.DgVitals.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Azure
        Me.DgVitals.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DgVitals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgVitals.Size = New System.Drawing.Size(359, 89)
        Me.DgVitals.TabIndex = 198
        '
        'TimeStampDataGridViewTextBoxColumn
        '
        Me.TimeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp"
        Me.TimeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp"
        Me.TimeStampDataGridViewTextBoxColumn.Name = "TimeStampDataGridViewTextBoxColumn"
        Me.TimeStampDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeStampDataGridViewTextBoxColumn.Width = 115
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
        'UserDataGridViewTextBoxColumn
        '
        Me.UserDataGridViewTextBoxColumn.DataPropertyName = "User"
        Me.UserDataGridViewTextBoxColumn.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn.Name = "UserDataGridViewTextBoxColumn"
        Me.UserDataGridViewTextBoxColumn.ReadOnly = True
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
        'MMChartTVitalSignBindingSource
        '
        Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
        Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CaseNumber
        '
        Me.CaseNumber.DataPropertyName = "CaseNumber"
        Me.CaseNumber.HeaderText = "CaseNumber"
        Me.CaseNumber.Name = "CaseNumber"
        Me.CaseNumber.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Width = 120
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "LastName"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Width = 120
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
        'MMChartVisitTableAdapter
        '
        Me.MMChartVisitTableAdapter.ClearBeforeFill = True
        '
        'MMChartTVitalSignTableAdapter
        '
        Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True
        '
        'MMChartRxBindingSource
        '
        Me.MMChartRxBindingSource.DataMember = "MMChartRx"
        Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMChartRxTableAdapter
        '
        Me.MMChartRxTableAdapter.ClearBeforeFill = True
        '
        'DgMedicine
        '
        Me.DgMedicine.AllowUserToAddRows = False
        Me.DgMedicine.AllowUserToDeleteRows = False
        Me.DgMedicine.AutoGenerateColumns = False
        Me.DgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgMedicine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn17})
        Me.DgMedicine.DataSource = Me.MMChartRxBindingSource
        Me.DgMedicine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgMedicine.Location = New System.Drawing.Point(0, 0)
        Me.DgMedicine.Name = "DgMedicine"
        Me.DgMedicine.ReadOnly = True
        Me.DgMedicine.RowHeadersVisible = False
        Me.DgMedicine.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Azure
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
        'VisitsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 741)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnMedication)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PanelVitals.ResumeLayout(False)
        Me.PanelMadication.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.DgVitals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartVisitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MMDataDataSet1 As MMDataDataSet1
    Friend WithEvents MMChartVisitBindingSource As BindingSource
    Friend WithEvents MMChartVisitTableAdapter As MMDataDataSet1TableAdapters.MMChartVisitTableAdapter
    Friend WithEvents MMChartVisitDataGridView As DataGridView
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
    Friend WithEvents PanelVitals As Panel
    Friend WithEvents PanelMadication As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents CaseNumber As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents ChartNumber As DataGridViewTextBoxColumn
    Friend WithEvents DateVisit As DataGridViewTextBoxColumn
    Friend WithEvents VisitType As DataGridViewTextBoxColumn
    Friend WithEvents PhysicianName As DataGridViewTextBoxColumn
    Friend WithEvents TokenNo As DataGridViewTextBoxColumn
    Friend WithEvents DgVitals As DataGridView
    Friend WithEvents MMChartTVitalSignBindingSource As BindingSource
    Friend WithEvents MMChartTVitalSignTableAdapter As MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter
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
    Friend WithEvents UserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BloodSugarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MMChartRxBindingSource As BindingSource
    Friend WithEvents MMChartRxTableAdapter As MMDataDataSet1TableAdapters.MMChartRxTableAdapter
    Friend WithEvents DgMedicine As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
End Class
