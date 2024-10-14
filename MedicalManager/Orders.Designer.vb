<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Orders
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
        Dim ChiefComplaintLabel As System.Windows.Forms.Label
        Dim ChronicConditionsLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButtonCC = New System.Windows.Forms.RadioButton()
        Me.radChronic = New System.Windows.Forms.RadioButton()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.radImpressions = New System.Windows.Forms.RadioButton()
        Me.radProcedureNotes = New System.Windows.Forms.RadioButton()
        Me.radPlan = New System.Windows.Forms.RadioButton()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radFollowUp = New System.Windows.Forms.RadioButton()
        Me.radDiet = New System.Windows.Forms.RadioButton()
        Me.radCounseling = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDx = New System.Windows.Forms.RadioButton()
        Me.TBPhysician = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ChartNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButtonTestImaging = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPr = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMT = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLT = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridViewPr = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.radTemplateDX = New System.Windows.Forms.RadioButton()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.radMyDx = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.radAll = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CCTab = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PhysicalExamTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReviewOfSystemsTextBox = New System.Windows.Forms.TextBox()
        Me.HOPI = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnPickCC = New System.Windows.Forms.Button()
        Me.ROSBulletsCount = New System.Windows.Forms.TextBox()
        Me.PEBulletsCount = New System.Windows.Forms.TextBox()
        Me.RosCount = New System.Windows.Forms.TextBox()
        Me.PEcount = New System.Windows.Forms.TextBox()
        Me.cmdHPI = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtHPI = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChronicConditionsTextBox = New System.Windows.Forms.TextBox()
        Me.btnPickupChronic = New System.Windows.Forms.Button()
        Me.ChiefComplaintTextBox = New System.Windows.Forms.TextBox()
        Me.btnPickupCC = New System.Windows.Forms.Button()
        Me.DxTestsTab = New System.Windows.Forms.TabPage()
        Me.btnProcedureNotes = New System.Windows.Forms.Button()
        Me.btnOtherTxPanel = New System.Windows.Forms.Button()
        Me.btnDiet = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NotesTestBox = New System.Windows.Forms.TextBox()
        Me.btnCounseling = New System.Windows.Forms.Button()
        Me.btnRefTo = New System.Windows.Forms.Button()
        Me.btnFollowUp = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxCounselingEducation = New System.Windows.Forms.TextBox()
        Me.TextBoxfollowUp = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxDiet = New System.Windows.Forms.TextBox()
        Me.TextBoxReferedTo = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.MMCHDxRxLtMtDataGridView = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChartNumberPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeStamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InHouse = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InHouseBilling = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MMCHDxRxLtMtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblDX = New System.Windows.Forms.Label()
        Me.Dx5DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Dx2DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Dx1DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.TextBoxDx2 = New System.Windows.Forms.TextBox()
        Me.TextBoxDx1 = New System.Windows.Forms.TextBox()
        Me.MMCHDxRxLtMtTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter()
        ChiefComplaintLabel = New System.Windows.Forms.Label()
        ChronicConditionsLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridViewPr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.CCTab.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.HOPI.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.DxTestsTab.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.MMCHDxRxLtMtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChiefComplaintLabel
        '
        ChiefComplaintLabel.AutoSize = True
        ChiefComplaintLabel.Location = New System.Drawing.Point(16, 20)
        ChiefComplaintLabel.Name = "ChiefComplaintLabel"
        ChiefComplaintLabel.Size = New System.Drawing.Size(99, 13)
        ChiefComplaintLabel.TabIndex = 103
        ChiefComplaintLabel.Text = "Chief Complaint:"
        '
        'ChronicConditionsLabel
        '
        ChronicConditionsLabel.AutoSize = True
        ChronicConditionsLabel.Location = New System.Drawing.Point(355, 22)
        ChronicConditionsLabel.Name = "ChronicConditionsLabel"
        ChronicConditionsLabel.Size = New System.Drawing.Size(117, 13)
        ChronicConditionsLabel.TabIndex = 105
        ChronicConditionsLabel.Text = "Chronic Conditions:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.RadioButtonCC)
        Me.Panel1.Controls.Add(Me.radChronic)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.radImpressions)
        Me.Panel1.Controls.Add(Me.radProcedureNotes)
        Me.Panel1.Controls.Add(Me.radPlan)
        Me.Panel1.Controls.Add(Me.radOther)
        Me.Panel1.Controls.Add(Me.radFollowUp)
        Me.Panel1.Controls.Add(Me.radDiet)
        Me.Panel1.Controls.Add(Me.radCounseling)
        Me.Panel1.Controls.Add(Me.RadioButtonDx)
        Me.Panel1.Controls.Add(Me.TBPhysician)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCaseNo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.ChartNo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.RadioButtonTestImaging)
        Me.Panel1.Controls.Add(Me.RadioButtonPr)
        Me.Panel1.Controls.Add(Me.RadioButtonMT)
        Me.Panel1.Controls.Add(Me.RadioButtonLT)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 55)
        Me.Panel1.TabIndex = 0
        '
        'RadioButtonCC
        '
        Me.RadioButtonCC.AutoSize = True
        Me.RadioButtonCC.Checked = True
        Me.RadioButtonCC.Location = New System.Drawing.Point(783, 36)
        Me.RadioButtonCC.Name = "RadioButtonCC"
        Me.RadioButtonCC.Size = New System.Drawing.Size(41, 19)
        Me.RadioButtonCC.TabIndex = 169
        Me.RadioButtonCC.TabStop = True
        Me.RadioButtonCC.Text = "CC"
        Me.RadioButtonCC.UseVisualStyleBackColor = True
        Me.RadioButtonCC.Visible = False
        '
        'radChronic
        '
        Me.radChronic.AutoSize = True
        Me.radChronic.Location = New System.Drawing.Point(1011, 36)
        Me.radChronic.Name = "radChronic"
        Me.radChronic.Size = New System.Drawing.Size(67, 19)
        Me.radChronic.TabIndex = 168
        Me.radChronic.Text = "Chronic"
        Me.radChronic.UseVisualStyleBackColor = True
        Me.radChronic.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSave.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave.Location = New System.Drawing.Point(626, 17)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(73, 27)
        Me.BtnSave.TabIndex = 195
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'radImpressions
        '
        Me.radImpressions.AutoSize = True
        Me.radImpressions.Location = New System.Drawing.Point(946, 36)
        Me.radImpressions.Name = "radImpressions"
        Me.radImpressions.Size = New System.Drawing.Size(92, 19)
        Me.radImpressions.TabIndex = 167
        Me.radImpressions.Text = "Impressions"
        Me.radImpressions.UseVisualStyleBackColor = True
        Me.radImpressions.Visible = False
        '
        'radProcedureNotes
        '
        Me.radProcedureNotes.AutoSize = True
        Me.radProcedureNotes.Checked = True
        Me.radProcedureNotes.Location = New System.Drawing.Point(879, 36)
        Me.radProcedureNotes.Name = "radProcedureNotes"
        Me.radProcedureNotes.Size = New System.Drawing.Size(69, 19)
        Me.radProcedureNotes.TabIndex = 166
        Me.radProcedureNotes.TabStop = True
        Me.radProcedureNotes.Text = "PrNotes"
        Me.radProcedureNotes.UseVisualStyleBackColor = True
        Me.radProcedureNotes.Visible = False
        '
        'radPlan
        '
        Me.radPlan.AutoSize = True
        Me.radPlan.Checked = True
        Me.radPlan.Location = New System.Drawing.Point(830, 36)
        Me.radPlan.Name = "radPlan"
        Me.radPlan.Size = New System.Drawing.Size(50, 19)
        Me.radPlan.TabIndex = 165
        Me.radPlan.TabStop = True
        Me.radPlan.Text = "Plan"
        Me.radPlan.UseVisualStyleBackColor = True
        Me.radPlan.Visible = False
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.radOther.Location = New System.Drawing.Point(1173, 33)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(55, 19)
        Me.radOther.TabIndex = 152
        Me.radOther.Text = "Other"
        Me.radOther.UseVisualStyleBackColor = False
        Me.radOther.Visible = False
        '
        'radFollowUp
        '
        Me.radFollowUp.AutoSize = True
        Me.radFollowUp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.radFollowUp.Location = New System.Drawing.Point(1143, 33)
        Me.radFollowUp.Name = "radFollowUp"
        Me.radFollowUp.Size = New System.Drawing.Size(80, 19)
        Me.radFollowUp.TabIndex = 151
        Me.radFollowUp.Text = "Follow Up"
        Me.radFollowUp.UseVisualStyleBackColor = False
        Me.radFollowUp.Visible = False
        '
        'radDiet
        '
        Me.radDiet.AutoSize = True
        Me.radDiet.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.radDiet.Location = New System.Drawing.Point(1110, 33)
        Me.radDiet.Name = "radDiet"
        Me.radDiet.Size = New System.Drawing.Size(47, 19)
        Me.radDiet.TabIndex = 150
        Me.radDiet.Text = "Diet"
        Me.radDiet.UseVisualStyleBackColor = False
        Me.radDiet.Visible = False
        '
        'radCounseling
        '
        Me.radCounseling.AutoSize = True
        Me.radCounseling.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.radCounseling.Location = New System.Drawing.Point(1084, 33)
        Me.radCounseling.Name = "radCounseling"
        Me.radCounseling.Size = New System.Drawing.Size(87, 19)
        Me.radCounseling.TabIndex = 149
        Me.radCounseling.Text = "Counseling"
        Me.radCounseling.UseVisualStyleBackColor = False
        Me.radCounseling.Visible = False
        '
        'RadioButtonDx
        '
        Me.RadioButtonDx.AutoSize = True
        Me.RadioButtonDx.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonDx.Location = New System.Drawing.Point(732, 17)
        Me.RadioButtonDx.Name = "RadioButtonDx"
        Me.RadioButtonDx.Size = New System.Drawing.Size(40, 19)
        Me.RadioButtonDx.TabIndex = 21
        Me.RadioButtonDx.Text = "Dx"
        Me.RadioButtonDx.UseVisualStyleBackColor = False
        '
        'TBPhysician
        '
        Me.TBPhysician.AcceptsReturn = True
        Me.TBPhysician.BackColor = System.Drawing.Color.White
        Me.TBPhysician.Enabled = False
        Me.TBPhysician.Location = New System.Drawing.Point(502, 18)
        Me.TBPhysician.Name = "TBPhysician"
        Me.TBPhysician.Size = New System.Drawing.Size(109, 21)
        Me.TBPhysician.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Physician:"
        '
        'txtCaseNo
        '
        Me.txtCaseNo.AcceptsReturn = True
        Me.txtCaseNo.BackColor = System.Drawing.Color.White
        Me.txtCaseNo.Enabled = False
        Me.txtCaseNo.Location = New System.Drawing.Point(368, 18)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(67, 21)
        Me.txtCaseNo.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CaseNo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(187, 18)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(122, 21)
        Me.txtName.TabIndex = 17
        '
        'ChartNo
        '
        Me.ChartNo.BackColor = System.Drawing.Color.White
        Me.ChartNo.Enabled = False
        Me.ChartNo.Location = New System.Drawing.Point(52, 18)
        Me.ChartNo.Name = "ChartNo"
        Me.ChartNo.Size = New System.Drawing.Size(90, 21)
        Me.ChartNo.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Ch No"
        '
        'RadioButtonTestImaging
        '
        Me.RadioButtonTestImaging.AutoSize = True
        Me.RadioButtonTestImaging.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonTestImaging.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonTestImaging.Location = New System.Drawing.Point(1025, 17)
        Me.RadioButtonTestImaging.Name = "RadioButtonTestImaging"
        Me.RadioButtonTestImaging.Size = New System.Drawing.Size(103, 20)
        Me.RadioButtonTestImaging.TabIndex = 8
        Me.RadioButtonTestImaging.Text = "Test Imaging"
        Me.RadioButtonTestImaging.UseVisualStyleBackColor = False
        '
        'RadioButtonPr
        '
        Me.RadioButtonPr.AutoSize = True
        Me.RadioButtonPr.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonPr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonPr.Location = New System.Drawing.Point(778, 17)
        Me.RadioButtonPr.Name = "RadioButtonPr"
        Me.RadioButtonPr.Size = New System.Drawing.Size(53, 20)
        Me.RadioButtonPr.TabIndex = 5
        Me.RadioButtonPr.Text = "Proc"
        Me.RadioButtonPr.UseVisualStyleBackColor = False
        '
        'RadioButtonMT
        '
        Me.RadioButtonMT.AutoSize = True
        Me.RadioButtonMT.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonMT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMT.Location = New System.Drawing.Point(922, 17)
        Me.RadioButtonMT.Name = "RadioButtonMT"
        Me.RadioButtonMT.Size = New System.Drawing.Size(106, 20)
        Me.RadioButtonMT.TabIndex = 7
        Me.RadioButtonMT.Text = "Test Medical "
        Me.RadioButtonMT.UseVisualStyleBackColor = False
        '
        'RadioButtonLT
        '
        Me.RadioButtonLT.AutoSize = True
        Me.RadioButtonLT.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonLT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonLT.Location = New System.Drawing.Point(837, 17)
        Me.RadioButtonLT.Name = "RadioButtonLT"
        Me.RadioButtonLT.Size = New System.Drawing.Size(78, 20)
        Me.RadioButtonLT.TabIndex = 6
        Me.RadioButtonLT.Text = "Lab Test"
        Me.RadioButtonLT.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(626, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 616)
        Me.Panel2.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.DataGridViewPr)
        Me.Panel5.Location = New System.Drawing.Point(0, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(613, 559)
        Me.Panel5.TabIndex = 163
        '
        'DataGridViewPr
        '
        Me.DataGridViewPr.AllowUserToAddRows = False
        Me.DataGridViewPr.AllowUserToDeleteRows = False
        Me.DataGridViewPr.AllowUserToOrderColumns = True
        Me.DataGridViewPr.AllowUserToResizeColumns = False
        Me.DataGridViewPr.AllowUserToResizeRows = False
        Me.DataGridViewPr.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewPr.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewPr.Name = "DataGridViewPr"
        Me.DataGridViewPr.ReadOnly = True
        Me.DataGridViewPr.RowHeadersVisible = False
        Me.DataGridViewPr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewPr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPr.Size = New System.Drawing.Size(613, 559)
        Me.DataGridViewPr.TabIndex = 142
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.cmbFilter)
        Me.Panel4.Controls.Add(Me.radTemplateDX)
        Me.Panel4.Controls.Add(Me.txtFind)
        Me.Panel4.Controls.Add(Me.radMyDx)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.radAll)
        Me.Panel4.Location = New System.Drawing.Point(3, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(610, 52)
        Me.Panel4.TabIndex = 162
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"Code", "Description"})
        Me.cmbFilter.Location = New System.Drawing.Point(253, 14)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(81, 23)
        Me.cmbFilter.TabIndex = 160
        Me.cmbFilter.Text = "Code"
        '
        'radTemplateDX
        '
        Me.radTemplateDX.Appearance = System.Windows.Forms.Appearance.Button
        Me.radTemplateDX.AutoSize = True
        Me.radTemplateDX.BackColor = System.Drawing.Color.Transparent
        Me.radTemplateDX.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radTemplateDX.Location = New System.Drawing.Point(336, 13)
        Me.radTemplateDX.Name = "radTemplateDX"
        Me.radTemplateDX.Size = New System.Drawing.Size(59, 25)
        Me.radTemplateDX.TabIndex = 158
        Me.radTemplateDX.Text = "Custom"
        Me.radTemplateDX.UseVisualStyleBackColor = False
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(128, 15)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(123, 21)
        Me.txtFind.TabIndex = 159
        '
        'radMyDx
        '
        Me.radMyDx.Appearance = System.Windows.Forms.Appearance.Button
        Me.radMyDx.AutoSize = True
        Me.radMyDx.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.radMyDx.Checked = True
        Me.radMyDx.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radMyDx.Location = New System.Drawing.Point(397, 13)
        Me.radMyDx.Name = "radMyDx"
        Me.radMyDx.Size = New System.Drawing.Size(55, 25)
        Me.radMyDx.TabIndex = 157
        Me.radMyDx.TabStop = True
        Me.radMyDx.Text = "My List"
        Me.radMyDx.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Find:"
        '
        'radAll
        '
        Me.radAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.radAll.AutoSize = True
        Me.radAll.BackColor = System.Drawing.Color.Transparent
        Me.radAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radAll.Location = New System.Drawing.Point(454, 13)
        Me.radAll.Name = "radAll"
        Me.radAll.Size = New System.Drawing.Size(48, 25)
        Me.radAll.TabIndex = 156
        Me.radAll.Text = "   All   "
        Me.radAll.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.CCTab)
        Me.TabControl1.Controls.Add(Me.DxTestsTab)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(2, 45)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(627, 633)
        Me.TabControl1.TabIndex = 0
        '
        'CCTab
        '
        Me.CCTab.Controls.Add(Me.GroupBox6)
        Me.CCTab.Controls.Add(Me.GroupBox1)
        Me.CCTab.Controls.Add(Me.HOPI)
        Me.CCTab.Controls.Add(Me.GroupBox2)
        Me.CCTab.Location = New System.Drawing.Point(4, 24)
        Me.CCTab.Name = "CCTab"
        Me.CCTab.Padding = New System.Windows.Forms.Padding(3)
        Me.CCTab.Size = New System.Drawing.Size(619, 605)
        Me.CCTab.TabIndex = 2
        Me.CCTab.Text = "CC / HPI / ROS / PE"
        Me.CCTab.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.PhysicalExamTextBox)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(3, 408)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(613, 193)
        Me.GroupBox6.TabIndex = 126
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "PHYSICAL EXAMINATION"
        '
        'PhysicalExamTextBox
        '
        Me.PhysicalExamTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.PhysicalExamTextBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhysicalExamTextBox.Location = New System.Drawing.Point(7, 19)
        Me.PhysicalExamTextBox.Multiline = True
        Me.PhysicalExamTextBox.Name = "PhysicalExamTextBox"
        Me.PhysicalExamTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.PhysicalExamTextBox.Size = New System.Drawing.Size(607, 171)
        Me.PhysicalExamTextBox.TabIndex = 127
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.ReviewOfSystemsTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(615, 162)
        Me.GroupBox1.TabIndex = 125
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REVIEW OF SYSTEMS"
        '
        'ReviewOfSystemsTextBox
        '
        Me.ReviewOfSystemsTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.ReviewOfSystemsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ReviewOfSystemsTextBox.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.ReviewOfSystemsTextBox.ForeColor = System.Drawing.Color.Black
        Me.ReviewOfSystemsTextBox.Location = New System.Drawing.Point(6, 19)
        Me.ReviewOfSystemsTextBox.Multiline = True
        Me.ReviewOfSystemsTextBox.Name = "ReviewOfSystemsTextBox"
        Me.ReviewOfSystemsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ReviewOfSystemsTextBox.Size = New System.Drawing.Size(607, 137)
        Me.ReviewOfSystemsTextBox.TabIndex = 124
        '
        'HOPI
        '
        Me.HOPI.BackColor = System.Drawing.SystemColors.Control
        Me.HOPI.Controls.Add(Me.Button3)
        Me.HOPI.Controls.Add(Me.Label14)
        Me.HOPI.Controls.Add(Me.Label13)
        Me.HOPI.Controls.Add(Me.Label12)
        Me.HOPI.Controls.Add(Me.Label16)
        Me.HOPI.Controls.Add(Me.btnPickCC)
        Me.HOPI.Controls.Add(Me.ROSBulletsCount)
        Me.HOPI.Controls.Add(Me.PEBulletsCount)
        Me.HOPI.Controls.Add(Me.RosCount)
        Me.HOPI.Controls.Add(Me.PEcount)
        Me.HOPI.Controls.Add(Me.cmdHPI)
        Me.HOPI.Controls.Add(Me.TextBox2)
        Me.HOPI.Controls.Add(Me.txtHPI)
        Me.HOPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOPI.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.HOPI.Location = New System.Drawing.Point(-4, 118)
        Me.HOPI.Name = "HOPI"
        Me.HOPI.Size = New System.Drawing.Size(623, 125)
        Me.HOPI.TabIndex = 123
        Me.HOPI.TabStop = False
        Me.HOPI.Text = "HISTORY OF PRESENT ILLNESS "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(581, 566)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(19, 21)
        Me.Button3.TabIndex = 167
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(172, 576)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 166
        Me.Label14.Text = "ROS Bullet"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(182, 555)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 165
        Me.Label13.Text = "PE Bullet"
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(54, 576)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 164
        Me.Label12.Text = "ROS System"
        Me.Label12.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(64, 555)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 163
        Me.Label16.Text = "PE System"
        Me.Label16.Visible = False
        '
        'btnPickCC
        '
        Me.btnPickCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnPickCC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPickCC.Location = New System.Drawing.Point(339, 17)
        Me.btnPickCC.Name = "btnPickCC"
        Me.btnPickCC.Size = New System.Drawing.Size(58, 22)
        Me.btnPickCC.TabIndex = 162
        Me.btnPickCC.Text = "Pick CC"
        Me.btnPickCC.UseVisualStyleBackColor = True
        '
        'ROSBulletsCount
        '
        Me.ROSBulletsCount.Location = New System.Drawing.Point(242, 572)
        Me.ROSBulletsCount.Name = "ROSBulletsCount"
        Me.ROSBulletsCount.Size = New System.Drawing.Size(33, 20)
        Me.ROSBulletsCount.TabIndex = 161
        Me.ROSBulletsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ROSBulletsCount.Visible = False
        '
        'PEBulletsCount
        '
        Me.PEBulletsCount.Location = New System.Drawing.Point(242, 551)
        Me.PEBulletsCount.Name = "PEBulletsCount"
        Me.PEBulletsCount.Size = New System.Drawing.Size(33, 20)
        Me.PEBulletsCount.TabIndex = 160
        Me.PEBulletsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PEBulletsCount.Visible = False
        '
        'RosCount
        '
        Me.RosCount.Location = New System.Drawing.Point(134, 572)
        Me.RosCount.Name = "RosCount"
        Me.RosCount.Size = New System.Drawing.Size(33, 20)
        Me.RosCount.TabIndex = 159
        Me.RosCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RosCount.Visible = False
        '
        'PEcount
        '
        Me.PEcount.Location = New System.Drawing.Point(134, 551)
        Me.PEcount.Name = "PEcount"
        Me.PEcount.Size = New System.Drawing.Size(33, 20)
        Me.PEcount.TabIndex = 158
        Me.PEcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PEcount.Visible = False
        '
        'cmdHPI
        '
        Me.cmdHPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHPI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdHPI.Location = New System.Drawing.Point(252, 17)
        Me.cmdHPI.Name = "cmdHPI"
        Me.cmdHPI.Size = New System.Drawing.Size(81, 22)
        Me.cmdHPI.TabIndex = 11
        Me.cmdHPI.Text = "HPI Template"
        Me.cmdHPI.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox2.Location = New System.Drawing.Point(6, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(245, 20)
        Me.TextBox2.TabIndex = 10
        '
        'txtHPI
        '
        Me.txtHPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHPI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtHPI.Location = New System.Drawing.Point(6, 39)
        Me.txtHPI.Multiline = True
        Me.txtHPI.Name = "txtHPI"
        Me.txtHPI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHPI.Size = New System.Drawing.Size(611, 79)
        Me.txtHPI.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.ChronicConditionsTextBox)
        Me.GroupBox2.Controls.Add(Me.btnPickupChronic)
        Me.GroupBox2.Controls.Add(Me.ChiefComplaintTextBox)
        Me.GroupBox2.Controls.Add(ChiefComplaintLabel)
        Me.GroupBox2.Controls.Add(ChronicConditionsLabel)
        Me.GroupBox2.Controls.Add(Me.btnPickupCC)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 113)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Health Monitor"
        '
        'ChronicConditionsTextBox
        '
        Me.ChronicConditionsTextBox.Location = New System.Drawing.Point(351, 38)
        Me.ChronicConditionsTextBox.MaxLength = 100
        Me.ChronicConditionsTextBox.Multiline = True
        Me.ChronicConditionsTextBox.Name = "ChronicConditionsTextBox"
        Me.ChronicConditionsTextBox.Size = New System.Drawing.Size(212, 58)
        Me.ChronicConditionsTextBox.TabIndex = 106
        '
        'btnPickupChronic
        '
        Me.btnPickupChronic.BackColor = System.Drawing.Color.LightBlue
        Me.btnPickupChronic.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickupChronic.Location = New System.Drawing.Point(567, 39)
        Me.btnPickupChronic.Name = "btnPickupChronic"
        Me.btnPickupChronic.Size = New System.Drawing.Size(12, 57)
        Me.btnPickupChronic.TabIndex = 107
        Me.btnPickupChronic.Text = "PICK"
        Me.btnPickupChronic.UseVisualStyleBackColor = False
        '
        'ChiefComplaintTextBox
        '
        Me.ChiefComplaintTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.ChiefComplaintTextBox.Location = New System.Drawing.Point(16, 36)
        Me.ChiefComplaintTextBox.MaxLength = 500
        Me.ChiefComplaintTextBox.Multiline = True
        Me.ChiefComplaintTextBox.Name = "ChiefComplaintTextBox"
        Me.ChiefComplaintTextBox.Size = New System.Drawing.Size(279, 58)
        Me.ChiefComplaintTextBox.TabIndex = 102
        '
        'btnPickupCC
        '
        Me.btnPickupCC.BackColor = System.Drawing.Color.LightBlue
        Me.btnPickupCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickupCC.Location = New System.Drawing.Point(298, 37)
        Me.btnPickupCC.Name = "btnPickupCC"
        Me.btnPickupCC.Size = New System.Drawing.Size(12, 57)
        Me.btnPickupCC.TabIndex = 104
        Me.btnPickupCC.Text = "PICK"
        Me.btnPickupCC.UseVisualStyleBackColor = False
        '
        'DxTestsTab
        '
        Me.DxTestsTab.Controls.Add(Me.btnProcedureNotes)
        Me.DxTestsTab.Controls.Add(Me.btnOtherTxPanel)
        Me.DxTestsTab.Controls.Add(Me.btnDiet)
        Me.DxTestsTab.Controls.Add(Me.Label17)
        Me.DxTestsTab.Controls.Add(Me.NotesTestBox)
        Me.DxTestsTab.Controls.Add(Me.btnCounseling)
        Me.DxTestsTab.Controls.Add(Me.btnRefTo)
        Me.DxTestsTab.Controls.Add(Me.btnFollowUp)
        Me.DxTestsTab.Controls.Add(Me.Label18)
        Me.DxTestsTab.Controls.Add(Me.TextBoxCounselingEducation)
        Me.DxTestsTab.Controls.Add(Me.TextBoxfollowUp)
        Me.DxTestsTab.Controls.Add(Me.Label19)
        Me.DxTestsTab.Controls.Add(Me.Label20)
        Me.DxTestsTab.Controls.Add(Me.TextBoxDiet)
        Me.DxTestsTab.Controls.Add(Me.TextBoxReferedTo)
        Me.DxTestsTab.Controls.Add(Me.Label21)
        Me.DxTestsTab.Controls.Add(Me.Label1)
        Me.DxTestsTab.Controls.Add(Me.Panel7)
        Me.DxTestsTab.Controls.Add(Me.Label15)
        Me.DxTestsTab.Controls.Add(Me.LblDX)
        Me.DxTestsTab.Controls.Add(Me.Dx5DescriptionTextBox)
        Me.DxTestsTab.Controls.Add(Me.Dx2DescriptionTextBox)
        Me.DxTestsTab.Controls.Add(Me.Dx1DescriptionTextBox)
        Me.DxTestsTab.Controls.Add(Me.TextBoxDx2)
        Me.DxTestsTab.Controls.Add(Me.TextBoxDx1)
        Me.DxTestsTab.Location = New System.Drawing.Point(4, 24)
        Me.DxTestsTab.Name = "DxTestsTab"
        Me.DxTestsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DxTestsTab.Size = New System.Drawing.Size(619, 605)
        Me.DxTestsTab.TabIndex = 1
        Me.DxTestsTab.Text = "Dx / Pro / Notes"
        Me.DxTestsTab.UseVisualStyleBackColor = True
        '
        'btnProcedureNotes
        '
        Me.btnProcedureNotes.Location = New System.Drawing.Point(422, 433)
        Me.btnProcedureNotes.Name = "btnProcedureNotes"
        Me.btnProcedureNotes.Size = New System.Drawing.Size(95, 25)
        Me.btnProcedureNotes.TabIndex = 228
        Me.btnProcedureNotes.Text = "Procedure Notes"
        Me.btnProcedureNotes.UseVisualStyleBackColor = True
        '
        'btnOtherTxPanel
        '
        Me.btnOtherTxPanel.Location = New System.Drawing.Point(519, 433)
        Me.btnOtherTxPanel.Name = "btnOtherTxPanel"
        Me.btnOtherTxPanel.Size = New System.Drawing.Size(77, 25)
        Me.btnOtherTxPanel.TabIndex = 229
        Me.btnOtherTxPanel.Text = "Other Notes"
        Me.btnOtherTxPanel.UseVisualStyleBackColor = True
        '
        'btnDiet
        '
        Me.btnDiet.Location = New System.Drawing.Point(487, 541)
        Me.btnDiet.Name = "btnDiet"
        Me.btnDiet.Size = New System.Drawing.Size(109, 23)
        Me.btnDiet.TabIndex = 227
        Me.btnDiet.Text = "Pick Diet"
        Me.btnDiet.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label17.Location = New System.Drawing.Point(9, 369)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 15)
        Me.Label17.TabIndex = 226
        Me.Label17.Text = "Other Notes:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NotesTestBox
        '
        Me.NotesTestBox.Location = New System.Drawing.Point(12, 388)
        Me.NotesTestBox.Multiline = True
        Me.NotesTestBox.Name = "NotesTestBox"
        Me.NotesTestBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.NotesTestBox.Size = New System.Drawing.Size(584, 43)
        Me.NotesTestBox.TabIndex = 214
        '
        'btnCounseling
        '
        Me.btnCounseling.Location = New System.Drawing.Point(487, 564)
        Me.btnCounseling.Name = "btnCounseling"
        Me.btnCounseling.Size = New System.Drawing.Size(109, 23)
        Me.btnCounseling.TabIndex = 217
        Me.btnCounseling.Text = "Pick Counseling"
        Me.btnCounseling.UseVisualStyleBackColor = True
        '
        'btnRefTo
        '
        Me.btnRefTo.Location = New System.Drawing.Point(487, 518)
        Me.btnRefTo.Name = "btnRefTo"
        Me.btnRefTo.Size = New System.Drawing.Size(109, 23)
        Me.btnRefTo.TabIndex = 225
        Me.btnRefTo.Text = "Pick Ref To"
        Me.btnRefTo.UseVisualStyleBackColor = True
        '
        'btnFollowUp
        '
        Me.btnFollowUp.Location = New System.Drawing.Point(487, 495)
        Me.btnFollowUp.Name = "btnFollowUp"
        Me.btnFollowUp.Size = New System.Drawing.Size(109, 23)
        Me.btnFollowUp.TabIndex = 224
        Me.btnFollowUp.Text = "Pick F/U"
        Me.btnFollowUp.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label18.Location = New System.Drawing.Point(9, 564)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 222
        Me.Label18.Text = "Counseling:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxCounselingEducation
        '
        Me.TextBoxCounselingEducation.Location = New System.Drawing.Point(98, 564)
        Me.TextBoxCounselingEducation.MaxLength = 300
        Me.TextBoxCounselingEducation.Multiline = True
        Me.TextBoxCounselingEducation.Name = "TextBoxCounselingEducation"
        Me.TextBoxCounselingEducation.Size = New System.Drawing.Size(383, 23)
        Me.TextBoxCounselingEducation.TabIndex = 223
        '
        'TextBoxfollowUp
        '
        Me.TextBoxfollowUp.Location = New System.Drawing.Point(98, 495)
        Me.TextBoxfollowUp.MaxLength = 50
        Me.TextBoxfollowUp.Name = "TextBoxfollowUp"
        Me.TextBoxfollowUp.Size = New System.Drawing.Size(383, 21)
        Me.TextBoxfollowUp.TabIndex = 219
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label19.Location = New System.Drawing.Point(9, 495)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 15)
        Me.Label19.TabIndex = 215
        Me.Label19.Text = "Follow Up:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label20.Location = New System.Drawing.Point(9, 541)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 15)
        Me.Label20.TabIndex = 216
        Me.Label20.Text = "Diet Instruct:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxDiet
        '
        Me.TextBoxDiet.Location = New System.Drawing.Point(98, 541)
        Me.TextBoxDiet.MaxLength = 300
        Me.TextBoxDiet.Multiline = True
        Me.TextBoxDiet.Name = "TextBoxDiet"
        Me.TextBoxDiet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDiet.Size = New System.Drawing.Size(383, 20)
        Me.TextBoxDiet.TabIndex = 221
        '
        'TextBoxReferedTo
        '
        Me.TextBoxReferedTo.Location = New System.Drawing.Point(98, 518)
        Me.TextBoxReferedTo.MaxLength = 50
        Me.TextBoxReferedTo.Name = "TextBoxReferedTo"
        Me.TextBoxReferedTo.Size = New System.Drawing.Size(383, 21)
        Me.TextBoxReferedTo.TabIndex = 220
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label21.Location = New System.Drawing.Point(9, 518)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(87, 15)
        Me.Label21.TabIndex = 218
        Me.Label21.Text = "Referred To:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(2, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(614, 34)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Procedures"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Controls.Add(Me.MMCHDxRxLtMtDataGridView)
        Me.Panel7.Location = New System.Drawing.Point(-3, 124)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(625, 230)
        Me.Panel7.TabIndex = 143
        '
        'MMCHDxRxLtMtDataGridView
        '
        Me.MMCHDxRxLtMtDataGridView.AllowUserToAddRows = False
        Me.MMCHDxRxLtMtDataGridView.AllowUserToDeleteRows = False
        Me.MMCHDxRxLtMtDataGridView.AutoGenerateColumns = False
        Me.MMCHDxRxLtMtDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.MMCHDxRxLtMtDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.Description, Me.Amount, Me.Type, Me.CaseNo, Me.DatePro, Me.ChartNumberPro, Me.IDDataGridViewTextBoxColumn, Me.UserID, Me.TimeStamp, Me.InHouse, Me.InHouseBilling})
        Me.MMCHDxRxLtMtDataGridView.DataSource = Me.MMCHDxRxLtMtBindingSource
        Me.MMCHDxRxLtMtDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MMCHDxRxLtMtDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MMCHDxRxLtMtDataGridView.Name = "MMCHDxRxLtMtDataGridView"
        Me.MMCHDxRxLtMtDataGridView.ReadOnly = True
        Me.MMCHDxRxLtMtDataGridView.Size = New System.Drawing.Size(625, 230)
        Me.MMCHDxRxLtMtDataGridView.TabIndex = 124
        '
        'Code
        '
        Me.Code.DataPropertyName = "Code"
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 180
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 60
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'CaseNo
        '
        Me.CaseNo.DataPropertyName = "CaseNumber"
        Me.CaseNo.HeaderText = "CaseNumber"
        Me.CaseNo.Name = "CaseNo"
        Me.CaseNo.ReadOnly = True
        '
        'DatePro
        '
        Me.DatePro.DataPropertyName = "Date"
        Me.DatePro.HeaderText = "Date"
        Me.DatePro.Name = "DatePro"
        Me.DatePro.ReadOnly = True
        '
        'ChartNumberPro
        '
        Me.ChartNumberPro.DataPropertyName = "ChartNumber"
        Me.ChartNumberPro.HeaderText = "ChartNumber"
        Me.ChartNumberPro.Name = "ChartNumberPro"
        Me.ChartNumberPro.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "UserID"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        '
        'TimeStamp
        '
        Me.TimeStamp.DataPropertyName = "TimeStamp"
        Me.TimeStamp.HeaderText = "TimeStamp"
        Me.TimeStamp.Name = "TimeStamp"
        Me.TimeStamp.ReadOnly = True
        '
        'InHouse
        '
        Me.InHouse.DataPropertyName = "InHouse"
        Me.InHouse.HeaderText = "InHouse"
        Me.InHouse.Name = "InHouse"
        Me.InHouse.ReadOnly = True
        '
        'InHouseBilling
        '
        Me.InHouseBilling.DataPropertyName = "InHouseBilling"
        Me.InHouseBilling.HeaderText = "InHouseBilling"
        Me.InHouseBilling.Name = "InHouseBilling"
        Me.InHouseBilling.ReadOnly = True
        '
        'MMCHDxRxLtMtBindingSource
        '
        Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
        Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Indigo
        Me.Label15.Location = New System.Drawing.Point(332, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 16)
        Me.Label15.TabIndex = 142
        Me.Label15.Text = "Free Text Diagnosis"
        '
        'LblDX
        '
        Me.LblDX.AutoSize = True
        Me.LblDX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDX.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LblDX.Location = New System.Drawing.Point(3, 6)
        Me.LblDX.Name = "LblDX"
        Me.LblDX.Size = New System.Drawing.Size(77, 16)
        Me.LblDX.TabIndex = 141
        Me.LblDX.Text = "Diagnosis"
        '
        'Dx5DescriptionTextBox
        '
        Me.Dx5DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Dx5DescriptionTextBox.Location = New System.Drawing.Point(330, 25)
        Me.Dx5DescriptionTextBox.Multiline = True
        Me.Dx5DescriptionTextBox.Name = "Dx5DescriptionTextBox"
        Me.Dx5DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dx5DescriptionTextBox.Size = New System.Drawing.Size(266, 62)
        Me.Dx5DescriptionTextBox.TabIndex = 132
        Me.Dx5DescriptionTextBox.WordWrap = False
        '
        'Dx2DescriptionTextBox
        '
        Me.Dx2DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dx2DescriptionTextBox.Location = New System.Drawing.Point(65, 59)
        Me.Dx2DescriptionTextBox.Multiline = True
        Me.Dx2DescriptionTextBox.Name = "Dx2DescriptionTextBox"
        Me.Dx2DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dx2DescriptionTextBox.Size = New System.Drawing.Size(259, 28)
        Me.Dx2DescriptionTextBox.TabIndex = 138
        '
        'Dx1DescriptionTextBox
        '
        Me.Dx1DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dx1DescriptionTextBox.Location = New System.Drawing.Point(65, 25)
        Me.Dx1DescriptionTextBox.Multiline = True
        Me.Dx1DescriptionTextBox.Name = "Dx1DescriptionTextBox"
        Me.Dx1DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dx1DescriptionTextBox.Size = New System.Drawing.Size(259, 28)
        Me.Dx1DescriptionTextBox.TabIndex = 137
        '
        'TextBoxDx2
        '
        Me.TextBoxDx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDx2.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBoxDx2.Location = New System.Drawing.Point(5, 59)
        Me.TextBoxDx2.MaxLength = 10
        Me.TextBoxDx2.Multiline = True
        Me.TextBoxDx2.Name = "TextBoxDx2"
        Me.TextBoxDx2.Size = New System.Drawing.Size(54, 28)
        Me.TextBoxDx2.TabIndex = 134
        '
        'TextBoxDx1
        '
        Me.TextBoxDx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDx1.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBoxDx1.Location = New System.Drawing.Point(5, 25)
        Me.TextBoxDx1.MaxLength = 10
        Me.TextBoxDx1.Multiline = True
        Me.TextBoxDx1.Name = "TextBoxDx1"
        Me.TextBoxDx1.Size = New System.Drawing.Size(54, 28)
        Me.TextBoxDx1.TabIndex = 133
        '
        'MMCHDxRxLtMtTableAdapter
        '
        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 703)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridViewPr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.CCTab.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.HOPI.ResumeLayout(False)
        Me.HOPI.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.DxTestsTab.ResumeLayout(False)
        Me.DxTestsTab.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.MMCHDxRxLtMtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents radTemplateDX As RadioButton
    Friend WithEvents radMyDx As RadioButton
    Friend WithEvents radAll As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridViewPr As DataGridView
    Friend WithEvents MMCHDxRxLtMtBindingSource As BindingSource
    Friend WithEvents MMDataDataSet1 As MMDataDataSet1
    Friend WithEvents MMCHDxRxLtMtTableAdapter As MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
    Friend WithEvents ChartNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCaseNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButtonTestImaging As RadioButton
    Friend WithEvents RadioButtonPr As RadioButton
    Friend WithEvents RadioButtonMT As RadioButton
    Friend WithEvents RadioButtonLT As RadioButton
    Friend WithEvents TBPhysician As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DxTestsTab As TabPage
    Friend WithEvents LblDX As Label
    Friend WithEvents Dx5DescriptionTextBox As TextBox
    Friend WithEvents Dx2DescriptionTextBox As TextBox
    Friend WithEvents Dx1DescriptionTextBox As TextBox
    Friend WithEvents TextBoxDx2 As TextBox
    Friend WithEvents TextBoxDx1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents RadioButtonDx As RadioButton
    Friend WithEvents radOther As RadioButton
    Friend WithEvents radFollowUp As RadioButton
    Friend WithEvents radDiet As RadioButton
    Friend WithEvents radCounseling As RadioButton
    Friend WithEvents CCTab As TabPage
    Friend WithEvents btnPickupCC As Button
    Friend WithEvents ChiefComplaintTextBox As TextBox
    Friend WithEvents btnPickupChronic As Button
    Friend WithEvents ChronicConditionsTextBox As TextBox
    Friend WithEvents radChronic As RadioButton
    Friend WithEvents radImpressions As RadioButton
    Friend WithEvents radProcedureNotes As RadioButton
    Friend WithEvents radPlan As RadioButton
    Friend WithEvents RadioButtonCC As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents HOPI As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnPickCC As Button
    Friend WithEvents ROSBulletsCount As TextBox
    Friend WithEvents PEBulletsCount As TextBox
    Friend WithEvents RosCount As TextBox
    Friend WithEvents PEcount As TextBox
    Friend WithEvents cmdHPI As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtHPI As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ReviewOfSystemsTextBox As TextBox
    Private WithEvents BtnSave As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents MMCHDxRxLtMtDataGridView As DataGridView
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents CaseNo As DataGridViewTextBoxColumn
    Friend WithEvents DatePro As DataGridViewTextBoxColumn
    Friend WithEvents ChartNumberPro As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents TimeStamp As DataGridViewTextBoxColumn
    Friend WithEvents InHouse As DataGridViewCheckBoxColumn
    Friend WithEvents InHouseBilling As DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnProcedureNotes As Button
    Friend WithEvents btnOtherTxPanel As Button
    Friend WithEvents btnDiet As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents NotesTestBox As TextBox
    Friend WithEvents btnCounseling As Button
    Friend WithEvents btnRefTo As Button
    Friend WithEvents btnFollowUp As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBoxCounselingEducation As TextBox
    Friend WithEvents TextBoxfollowUp As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxDiet As TextBox
    Friend WithEvents TextBoxReferedTo As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents PhysicalExamTextBox As TextBox
End Class
