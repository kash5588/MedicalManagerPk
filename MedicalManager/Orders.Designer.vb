<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.MMCHDxRxLtMtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1()
        Me.MMCHDxRxLtMtTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ProcedureTab = New System.Windows.Forms.TabPage()
        Me.DxTestsTab = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InHouseBilling = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.InHouse = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TimeStamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChartNumberPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MMCHDxRxLtMtDataGridView = New System.Windows.Forms.DataGridView()
        Me.LblDX = New System.Windows.Forms.Label()
        Me.Dx5DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Dx4DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Dx3DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Dx2DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Dx1DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.TextBoxDx4 = New System.Windows.Forms.TextBox()
        Me.TextBoxDx3 = New System.Windows.Forms.TextBox()
        Me.TextBoxDx2 = New System.Windows.Forms.TextBox()
        Me.TextBoxDx1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NotesTestBox = New System.Windows.Forms.TextBox()
        Me.btnCounseling = New System.Windows.Forms.Button()
        Me.btnRefTo = New System.Windows.Forms.Button()
        Me.btnFollowUp = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCounselingEducation = New System.Windows.Forms.TextBox()
        Me.TextBoxfollowUp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxDiet = New System.Windows.Forms.TextBox()
        Me.TextBoxReferedTo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RadioButtonDx = New System.Windows.Forms.RadioButton()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radFollowUp = New System.Windows.Forms.RadioButton()
        Me.radDiet = New System.Windows.Forms.RadioButton()
        Me.radCounseling = New System.Windows.Forms.RadioButton()
        Me.btnDiet = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridViewPr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.ProcedureTab.SuspendLayout()
        Me.DxTestsTab.SuspendLayout()
        CType(Me.MMCHDxRxLtMtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'TBPhysician
        '
        Me.TBPhysician.AcceptsReturn = True
        Me.TBPhysician.BackColor = System.Drawing.Color.White
        Me.TBPhysician.Enabled = False
        Me.TBPhysician.Location = New System.Drawing.Point(534, 18)
        Me.TBPhysician.Name = "TBPhysician"
        Me.TBPhysician.Size = New System.Drawing.Size(109, 21)
        Me.TBPhysician.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(470, 21)
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
        Me.txtCaseNo.Location = New System.Drawing.Point(382, 18)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(84, 21)
        Me.txtCaseNo.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(327, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CaseNo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 21)
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
        Me.txtName.Location = New System.Drawing.Point(201, 18)
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
        Me.ChartNo.Size = New System.Drawing.Size(103, 21)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(593, 619)
        Me.Panel3.TabIndex = 10
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Controls.Add(Me.MMCHDxRxLtMtDataGridView)
        Me.Panel7.Location = New System.Drawing.Point(0, 52)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(625, 564)
        Me.Panel7.TabIndex = 125
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
        'MMCHDxRxLtMtTableAdapter
        '
        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.ProcedureTab)
        Me.TabControl1.Controls.Add(Me.DxTestsTab)
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(2, 45)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(627, 633)
        Me.TabControl1.TabIndex = 0
        '
        'ProcedureTab
        '
        Me.ProcedureTab.Controls.Add(Me.Panel3)
        Me.ProcedureTab.Location = New System.Drawing.Point(24, 4)
        Me.ProcedureTab.Name = "ProcedureTab"
        Me.ProcedureTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProcedureTab.Size = New System.Drawing.Size(599, 625)
        Me.ProcedureTab.TabIndex = 0
        Me.ProcedureTab.Text = "Pro"
        Me.ProcedureTab.UseVisualStyleBackColor = True
        '
        'DxTestsTab
        '
        Me.DxTestsTab.Controls.Add(Me.BtnSave)
        Me.DxTestsTab.Controls.Add(Me.btnDiet)
        Me.DxTestsTab.Controls.Add(Me.Label8)
        Me.DxTestsTab.Controls.Add(Me.NotesTestBox)
        Me.DxTestsTab.Controls.Add(Me.btnCounseling)
        Me.DxTestsTab.Controls.Add(Me.btnRefTo)
        Me.DxTestsTab.Controls.Add(Me.btnFollowUp)
        Me.DxTestsTab.Controls.Add(Me.Label7)
        Me.DxTestsTab.Controls.Add(Me.TextBoxCounselingEducation)
        Me.DxTestsTab.Controls.Add(Me.TextBoxfollowUp)
        Me.DxTestsTab.Controls.Add(Me.Label9)
        Me.DxTestsTab.Controls.Add(Me.Label10)
        Me.DxTestsTab.Controls.Add(Me.TextBoxDiet)
        Me.DxTestsTab.Controls.Add(Me.TextBoxReferedTo)
        Me.DxTestsTab.Controls.Add(Me.Label11)
        Me.DxTestsTab.Controls.Add(Me.Label15)
        Me.DxTestsTab.Controls.Add(Me.LblDX)
        Me.DxTestsTab.Controls.Add(Me.Dx5DescriptionTextBox)
        Me.DxTestsTab.Controls.Add(Me.Dx4DescriptionTextBox)
        Me.DxTestsTab.Controls.Add(Me.Dx3DescriptionTextBox)
        Me.DxTestsTab.Controls.Add(Me.Dx2DescriptionTextBox)
        Me.DxTestsTab.Controls.Add(Me.Dx1DescriptionTextBox)
        Me.DxTestsTab.Controls.Add(Me.TextBoxDx4)
        Me.DxTestsTab.Controls.Add(Me.TextBoxDx3)
        Me.DxTestsTab.Controls.Add(Me.TextBoxDx2)
        Me.DxTestsTab.Controls.Add(Me.TextBoxDx1)
        Me.DxTestsTab.Location = New System.Drawing.Point(24, 4)
        Me.DxTestsTab.Name = "DxTestsTab"
        Me.DxTestsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.DxTestsTab.Size = New System.Drawing.Size(599, 625)
        Me.DxTestsTab.TabIndex = 1
        Me.DxTestsTab.Text = "Dx"
        Me.DxTestsTab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(603, 46)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Procedures"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InHouseBilling
        '
        Me.InHouseBilling.DataPropertyName = "InHouseBilling"
        Me.InHouseBilling.HeaderText = "InHouseBilling"
        Me.InHouseBilling.Name = "InHouseBilling"
        Me.InHouseBilling.ReadOnly = True
        '
        'InHouse
        '
        Me.InHouse.DataPropertyName = "InHouse"
        Me.InHouse.HeaderText = "InHouse"
        Me.InHouse.Name = "InHouse"
        Me.InHouse.ReadOnly = True
        '
        'TimeStamp
        '
        Me.TimeStamp.DataPropertyName = "TimeStamp"
        Me.TimeStamp.HeaderText = "TimeStamp"
        Me.TimeStamp.Name = "TimeStamp"
        Me.TimeStamp.ReadOnly = True
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "UserID"
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChartNumberPro
        '
        Me.ChartNumberPro.DataPropertyName = "ChartNumber"
        Me.ChartNumberPro.HeaderText = "ChartNumber"
        Me.ChartNumberPro.Name = "ChartNumberPro"
        Me.ChartNumberPro.ReadOnly = True
        '
        'DatePro
        '
        Me.DatePro.DataPropertyName = "Date"
        Me.DatePro.HeaderText = "Date"
        Me.DatePro.Name = "DatePro"
        Me.DatePro.ReadOnly = True
        '
        'CaseNo
        '
        Me.CaseNo.DataPropertyName = "CaseNumber"
        Me.CaseNo.HeaderText = "CaseNumber"
        Me.CaseNo.Name = "CaseNo"
        Me.CaseNo.ReadOnly = True
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.Width = 60
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 180
        '
        'Code
        '
        Me.Code.DataPropertyName = "Code"
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
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
        Me.MMCHDxRxLtMtDataGridView.Size = New System.Drawing.Size(625, 564)
        Me.MMCHDxRxLtMtDataGridView.TabIndex = 124
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
        Me.Dx5DescriptionTextBox.Size = New System.Drawing.Size(266, 130)
        Me.Dx5DescriptionTextBox.TabIndex = 132
        Me.Dx5DescriptionTextBox.WordWrap = False
        '
        'Dx4DescriptionTextBox
        '
        Me.Dx4DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dx4DescriptionTextBox.Location = New System.Drawing.Point(65, 127)
        Me.Dx4DescriptionTextBox.Multiline = True
        Me.Dx4DescriptionTextBox.Name = "Dx4DescriptionTextBox"
        Me.Dx4DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dx4DescriptionTextBox.Size = New System.Drawing.Size(259, 28)
        Me.Dx4DescriptionTextBox.TabIndex = 140
        '
        'Dx3DescriptionTextBox
        '
        Me.Dx3DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dx3DescriptionTextBox.Location = New System.Drawing.Point(65, 93)
        Me.Dx3DescriptionTextBox.Multiline = True
        Me.Dx3DescriptionTextBox.Name = "Dx3DescriptionTextBox"
        Me.Dx3DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dx3DescriptionTextBox.Size = New System.Drawing.Size(259, 28)
        Me.Dx3DescriptionTextBox.TabIndex = 139
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
        'TextBoxDx4
        '
        Me.TextBoxDx4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDx4.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBoxDx4.Location = New System.Drawing.Point(5, 127)
        Me.TextBoxDx4.MaxLength = 10
        Me.TextBoxDx4.Multiline = True
        Me.TextBoxDx4.Name = "TextBoxDx4"
        Me.TextBoxDx4.Size = New System.Drawing.Size(54, 28)
        Me.TextBoxDx4.TabIndex = 136
        '
        'TextBoxDx3
        '
        Me.TextBoxDx3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDx3.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBoxDx3.Location = New System.Drawing.Point(5, 93)
        Me.TextBoxDx3.MaxLength = 10
        Me.TextBoxDx3.Multiline = True
        Me.TextBoxDx3.Name = "TextBoxDx3"
        Me.TextBoxDx3.Size = New System.Drawing.Size(54, 28)
        Me.TextBoxDx3.TabIndex = 135
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
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label8.Location = New System.Drawing.Point(3, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 15)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "Other Notes:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NotesTestBox
        '
        Me.NotesTestBox.Location = New System.Drawing.Point(7, 181)
        Me.NotesTestBox.Multiline = True
        Me.NotesTestBox.Name = "NotesTestBox"
        Me.NotesTestBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.NotesTestBox.Size = New System.Drawing.Size(584, 173)
        Me.NotesTestBox.TabIndex = 143
        '
        'btnCounseling
        '
        Me.btnCounseling.Location = New System.Drawing.Point(482, 553)
        Me.btnCounseling.Name = "btnCounseling"
        Me.btnCounseling.Size = New System.Drawing.Size(109, 23)
        Me.btnCounseling.TabIndex = 146
        Me.btnCounseling.Text = "Pick Counseling"
        Me.btnCounseling.UseVisualStyleBackColor = True
        '
        'btnRefTo
        '
        Me.btnRefTo.Location = New System.Drawing.Point(482, 507)
        Me.btnRefTo.Name = "btnRefTo"
        Me.btnRefTo.Size = New System.Drawing.Size(109, 23)
        Me.btnRefTo.TabIndex = 154
        Me.btnRefTo.Text = "Pick Ref To"
        Me.btnRefTo.UseVisualStyleBackColor = True
        '
        'btnFollowUp
        '
        Me.btnFollowUp.Location = New System.Drawing.Point(482, 484)
        Me.btnFollowUp.Name = "btnFollowUp"
        Me.btnFollowUp.Size = New System.Drawing.Size(109, 23)
        Me.btnFollowUp.TabIndex = 153
        Me.btnFollowUp.Text = "Pick F/U"
        Me.btnFollowUp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label7.Location = New System.Drawing.Point(4, 553)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Counseling:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxCounselingEducation
        '
        Me.TextBoxCounselingEducation.Location = New System.Drawing.Point(93, 553)
        Me.TextBoxCounselingEducation.MaxLength = 300
        Me.TextBoxCounselingEducation.Multiline = True
        Me.TextBoxCounselingEducation.Name = "TextBoxCounselingEducation"
        Me.TextBoxCounselingEducation.Size = New System.Drawing.Size(383, 60)
        Me.TextBoxCounselingEducation.TabIndex = 152
        '
        'TextBoxfollowUp
        '
        Me.TextBoxfollowUp.Location = New System.Drawing.Point(93, 484)
        Me.TextBoxfollowUp.MaxLength = 50
        Me.TextBoxfollowUp.Name = "TextBoxfollowUp"
        Me.TextBoxfollowUp.Size = New System.Drawing.Size(383, 21)
        Me.TextBoxfollowUp.TabIndex = 148
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label9.Location = New System.Drawing.Point(4, 484)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 144
        Me.Label9.Text = "Follow Up:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label10.Location = New System.Drawing.Point(4, 530)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 15)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Diet Instruct:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxDiet
        '
        Me.TextBoxDiet.Location = New System.Drawing.Point(93, 530)
        Me.TextBoxDiet.MaxLength = 300
        Me.TextBoxDiet.Multiline = True
        Me.TextBoxDiet.Name = "TextBoxDiet"
        Me.TextBoxDiet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDiet.Size = New System.Drawing.Size(383, 20)
        Me.TextBoxDiet.TabIndex = 150
        '
        'TextBoxReferedTo
        '
        Me.TextBoxReferedTo.Location = New System.Drawing.Point(93, 507)
        Me.TextBoxReferedTo.MaxLength = 50
        Me.TextBoxReferedTo.Name = "TextBoxReferedTo"
        Me.TextBoxReferedTo.Size = New System.Drawing.Size(383, 21)
        Me.TextBoxReferedTo.TabIndex = 149
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label11.Location = New System.Drawing.Point(4, 507)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 15)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Referred To:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'btnDiet
        '
        Me.btnDiet.Location = New System.Drawing.Point(482, 530)
        Me.btnDiet.Name = "btnDiet"
        Me.btnDiet.Size = New System.Drawing.Size(109, 23)
        Me.btnDiet.TabIndex = 156
        Me.btnDiet.Text = "Pick Diet"
        Me.btnDiet.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSave.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSave.Location = New System.Drawing.Point(482, 579)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(109, 34)
        Me.BtnSave.TabIndex = 195
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ProcedureTab.ResumeLayout(False)
        Me.DxTestsTab.ResumeLayout(False)
        Me.DxTestsTab.PerformLayout()
        CType(Me.MMCHDxRxLtMtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents radTemplateDX As RadioButton
    Friend WithEvents radMyDx As RadioButton
    Friend WithEvents radAll As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents txtFind As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridViewPr As DataGridView
    Friend WithEvents Panel7 As Panel
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
    Friend WithEvents Label1 As Label
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ProcedureTab As TabPage
    Friend WithEvents DxTestsTab As TabPage
    Friend WithEvents LblDX As Label
    Friend WithEvents Dx5DescriptionTextBox As TextBox
    Friend WithEvents Dx4DescriptionTextBox As TextBox
    Friend WithEvents Dx3DescriptionTextBox As TextBox
    Friend WithEvents Dx2DescriptionTextBox As TextBox
    Friend WithEvents Dx1DescriptionTextBox As TextBox
    Friend WithEvents TextBoxDx4 As TextBox
    Friend WithEvents TextBoxDx3 As TextBox
    Friend WithEvents TextBoxDx2 As TextBox
    Friend WithEvents TextBoxDx1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NotesTestBox As TextBox
    Friend WithEvents btnCounseling As Button
    Friend WithEvents btnRefTo As Button
    Friend WithEvents btnFollowUp As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCounselingEducation As TextBox
    Friend WithEvents TextBoxfollowUp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxDiet As TextBox
    Friend WithEvents TextBoxReferedTo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents RadioButtonDx As RadioButton
    Friend WithEvents radOther As RadioButton
    Friend WithEvents radFollowUp As RadioButton
    Friend WithEvents radDiet As RadioButton
    Friend WithEvents radCounseling As RadioButton
    Friend WithEvents btnDiet As Button
    Private WithEvents BtnSave As Button
End Class
