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
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.ChartNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPracticeName = New System.Windows.Forms.Label()
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.MMCHDxRxLtMtTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter()
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
        Me.RadioButtonLT = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMT = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPr = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTestImaging = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridViewPr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHDxRxLtMtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtCaseNo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.ChartNo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblPracticeName)
        Me.Panel1.Controls.Add(Me.RadioButtonTestImaging)
        Me.Panel1.Controls.Add(Me.RadioButtonPr)
        Me.Panel1.Controls.Add(Me.RadioButtonMT)
        Me.Panel1.Controls.Add(Me.RadioButtonLT)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 87)
        Me.Panel1.TabIndex = 0
        '
        'txtCaseNo
        '
        Me.txtCaseNo.AcceptsReturn = True
        Me.txtCaseNo.BackColor = System.Drawing.Color.White
        Me.txtCaseNo.Enabled = False
        Me.txtCaseNo.Location = New System.Drawing.Point(432, 55)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(109, 21)
        Me.txtCaseNo.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(377, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CaseNo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 58)
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
        Me.txtName.Location = New System.Drawing.Point(238, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(122, 21)
        Me.txtName.TabIndex = 17
        '
        'ChartNo
        '
        Me.ChartNo.BackColor = System.Drawing.Color.White
        Me.ChartNo.Enabled = False
        Me.ChartNo.Location = New System.Drawing.Point(52, 55)
        Me.ChartNo.Name = "ChartNo"
        Me.ChartNo.Size = New System.Drawing.Size(122, 21)
        Me.ChartNo.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Ch No"
        '
        'lblPracticeName
        '
        Me.lblPracticeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPracticeName.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblPracticeName.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPracticeName.ForeColor = System.Drawing.Color.Black
        Me.lblPracticeName.Location = New System.Drawing.Point(1, 0)
        Me.lblPracticeName.Name = "lblPracticeName"
        Me.lblPracticeName.Size = New System.Drawing.Size(1239, 41)
        Me.lblPracticeName.TabIndex = 14
        Me.lblPracticeName.Text = "Procedures List "
        Me.lblPracticeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(626, 87)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 590)
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
        Me.Panel5.Size = New System.Drawing.Size(615, 535)
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
        Me.DataGridViewPr.Size = New System.Drawing.Size(615, 535)
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
        Me.Panel4.Size = New System.Drawing.Size(612, 50)
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
        Me.Label6.Location = New System.Drawing.Point(60, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Find Proc:"
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
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(1, 87)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(627, 590)
        Me.Panel3.TabIndex = 10
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Controls.Add(Me.MMCHDxRxLtMtDataGridView)
        Me.Panel7.Location = New System.Drawing.Point(0, 52)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(625, 535)
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
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(1, 87)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(625, 51)
        Me.Panel6.TabIndex = 125
        '
        'MMCHDxRxLtMtTableAdapter
        '
        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
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
        Me.MMCHDxRxLtMtDataGridView.Size = New System.Drawing.Size(625, 535)
        Me.MMCHDxRxLtMtDataGridView.TabIndex = 124
        '
        'RadioButtonLT
        '
        Me.RadioButtonLT.AutoSize = True
        Me.RadioButtonLT.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonLT.Location = New System.Drawing.Point(829, 54)
        Me.RadioButtonLT.Name = "RadioButtonLT"
        Me.RadioButtonLT.Size = New System.Drawing.Size(72, 19)
        Me.RadioButtonLT.TabIndex = 6
        Me.RadioButtonLT.Text = "Lab Test"
        Me.RadioButtonLT.UseVisualStyleBackColor = False
        '
        'RadioButtonMT
        '
        Me.RadioButtonMT.AutoSize = True
        Me.RadioButtonMT.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonMT.Location = New System.Drawing.Point(906, 54)
        Me.RadioButtonMT.Name = "RadioButtonMT"
        Me.RadioButtonMT.Size = New System.Drawing.Size(95, 19)
        Me.RadioButtonMT.TabIndex = 7
        Me.RadioButtonMT.Text = "TestMedical "
        Me.RadioButtonMT.UseVisualStyleBackColor = False
        '
        'RadioButtonPr
        '
        Me.RadioButtonPr.AutoSize = True
        Me.RadioButtonPr.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonPr.Location = New System.Drawing.Point(775, 54)
        Me.RadioButtonPr.Name = "RadioButtonPr"
        Me.RadioButtonPr.Size = New System.Drawing.Size(50, 19)
        Me.RadioButtonPr.TabIndex = 5
        Me.RadioButtonPr.Text = "Proc"
        Me.RadioButtonPr.UseVisualStyleBackColor = False
        '
        'RadioButtonTestImaging
        '
        Me.RadioButtonTestImaging.AutoSize = True
        Me.RadioButtonTestImaging.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButtonTestImaging.Location = New System.Drawing.Point(1001, 54)
        Me.RadioButtonTestImaging.Name = "RadioButtonTestImaging"
        Me.RadioButtonTestImaging.Size = New System.Drawing.Size(93, 19)
        Me.RadioButtonTestImaging.TabIndex = 8
        Me.RadioButtonTestImaging.Text = "TestImaging"
        Me.RadioButtonTestImaging.UseVisualStyleBackColor = False
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 703)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
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
        CType(Me.MMCHDxRxLtMtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPracticeName As Label
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
    Friend WithEvents Panel6 As Panel
    Friend WithEvents MMCHDxRxLtMtBindingSource As BindingSource
    Friend WithEvents MMDataDataSet1 As MMDataDataSet1
    Friend WithEvents MMCHDxRxLtMtTableAdapter As MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
    Friend WithEvents ChartNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCaseNo As TextBox
    Friend WithEvents Label4 As Label
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
    Friend WithEvents RadioButtonTestImaging As RadioButton
    Friend WithEvents RadioButtonPr As RadioButton
    Friend WithEvents RadioButtonMT As RadioButton
    Friend WithEvents RadioButtonLT As RadioButton
End Class
