<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PostBillingData
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCasesPosted = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnPostBillingByCase = New System.Windows.Forms.Button
        Me.btnPostBillingByDate = New System.Windows.Forms.Button
        Me.txtCaseNumber = New System.Windows.Forms.TextBox
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.ExportToTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportToTransactionTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.ExportToTransactionTableAdapter
        Me.ExportToMMCaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportToMMCaseTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseTableAdapter
        Me.ExportToMMCaseCaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportToMMCaseCaseTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseCaseTableAdapter
        Me.ExportToTransactionCaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportToTransactionCaseTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.ExportToTransactionCaseTableAdapter
        Me.ExportToMMCaseAndTransactionCOMMITROLLBACKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportToMMCaseAndTransactionCOMMITROLLBACKTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseAndTransactionCOMMITROLLBACKTableAdapter
        Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKTableAdapter
        Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewTableAdapter
        Me.ExportToMMCaseAndTransactionCOMMITROLLBACKNewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExportToMMCaseAndTransactionCOMMITROLLBACKNewTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseAndTransactionCOMMITROLLBACKNewTableAdapter
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.MMCHDxRxLtMtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMCHDxRxLtMtTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
        Me.MMCHDxRxLtMtDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.radToBePosted = New System.Windows.Forms.RadioButton
        Me.radAll = New System.Windows.Forms.RadioButton
        Me.lblPosted = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Tag = New System.Windows.Forms.DataGridViewButtonColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportToTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportToMMCaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportToMMCaseCaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportToTransactionCaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportToMMCaseAndTransactionCOMMITROLLBACKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportToMMCaseAndTransactionCOMMITROLLBACKNewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHDxRxLtMtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(121, 39)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date To"
        '
        'lblCasesPosted
        '
        Me.lblCasesPosted.AutoSize = True
        Me.lblCasesPosted.Font = New System.Drawing.Font("Courier New", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCasesPosted.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblCasesPosted.Location = New System.Drawing.Point(313, 132)
        Me.lblCasesPosted.Name = "lblCasesPosted"
        Me.lblCasesPosted.Size = New System.Drawing.Size(0, 16)
        Me.lblCasesPosted.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPostBillingByCase)
        Me.GroupBox1.Controls.Add(Me.btnPostBillingByDate)
        Me.GroupBox1.Controls.Add(Me.txtCaseNumber)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(501, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 138)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnPostBillingByCase
        '
        Me.btnPostBillingByCase.Location = New System.Drawing.Point(242, 82)
        Me.btnPostBillingByCase.Name = "btnPostBillingByCase"
        Me.btnPostBillingByCase.Size = New System.Drawing.Size(142, 23)
        Me.btnPostBillingByCase.TabIndex = 9
        Me.btnPostBillingByCase.Text = "Post Billing Data By Case#"
        Me.btnPostBillingByCase.UseVisualStyleBackColor = True
        '
        'btnPostBillingByDate
        '
        Me.btnPostBillingByDate.Location = New System.Drawing.Point(242, 39)
        Me.btnPostBillingByDate.Name = "btnPostBillingByDate"
        Me.btnPostBillingByDate.Size = New System.Drawing.Size(142, 23)
        Me.btnPostBillingByDate.TabIndex = 8
        Me.btnPostBillingByDate.Text = "Post Billing Data By Date"
        Me.btnPostBillingByDate.UseVisualStyleBackColor = True
        '
        'txtCaseNumber
        '
        Me.txtCaseNumber.Location = New System.Drawing.Point(121, 82)
        Me.txtCaseNumber.Name = "txtCaseNumber"
        Me.txtCaseNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCaseNumber.TabIndex = 7
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExportToTransactionBindingSource
        '
        Me.ExportToTransactionBindingSource.DataMember = "ExportToTransaction"
        Me.ExportToTransactionBindingSource.DataSource = Me.MMDataDataSet1
        '
        'ExportToTransactionTableAdapter
        '
        Me.ExportToTransactionTableAdapter.ClearBeforeFill = True
        '
        'ExportToMMCaseBindingSource
        '
        Me.ExportToMMCaseBindingSource.DataMember = "ExportToMMCase"
        Me.ExportToMMCaseBindingSource.DataSource = Me.MMDataDataSet1
        '
        'ExportToMMCaseTableAdapter
        '
        Me.ExportToMMCaseTableAdapter.ClearBeforeFill = True
        '
        'ExportToMMCaseCaseBindingSource
        '
        Me.ExportToMMCaseCaseBindingSource.DataMember = "ExportToMMCaseCase"
        Me.ExportToMMCaseCaseBindingSource.DataSource = Me.MMDataDataSet1
        '
        'ExportToMMCaseCaseTableAdapter
        '
        Me.ExportToMMCaseCaseTableAdapter.ClearBeforeFill = True
        '
        'ExportToTransactionCaseBindingSource
        '
        Me.ExportToTransactionCaseBindingSource.DataMember = "ExportToTransactionCase"
        Me.ExportToTransactionCaseBindingSource.DataSource = Me.MMDataDataSet1
        '
        'ExportToTransactionCaseTableAdapter
        '
        Me.ExportToTransactionCaseTableAdapter.ClearBeforeFill = True
        '
        'ExportToMMCaseAndTransactionCOMMITROLLBACKBindingSource
        '
        Me.ExportToMMCaseAndTransactionCOMMITROLLBACKBindingSource.DataMember = "ExportToMMCaseAndTransactionCOMMITROLLBACK"
        Me.ExportToMMCaseAndTransactionCOMMITROLLBACKBindingSource.DataSource = Me.MMDataDataSet1
        '
        'ExportToMMCaseAndTransactionCOMMITROLLBACKTableAdapter
        '
        Me.ExportToMMCaseAndTransactionCOMMITROLLBACKTableAdapter.ClearBeforeFill = True
        '
        'ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKBindingSource
        '
        Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKBindingSource.DataMember = "ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACK"
        Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKBindingSource.DataSource = Me.MMDataDataSet1
        '
        'ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKTableAdapter
        '
        Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKTableAdapter.ClearBeforeFill = True
        '
        'ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewBindingSource
        '
        Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewBindingSource.DataMember = "ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNew"
        Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewBindingSource.DataSource = Me.MMDataDataSet1
        '
        'ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewTableAdapter
        '
        Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewTableAdapter.ClearBeforeFill = True
        '
        'ExportToMMCaseAndTransactionCOMMITROLLBACKNewBindingSource
        '
        Me.ExportToMMCaseAndTransactionCOMMITROLLBACKNewBindingSource.DataMember = "ExportToMMCaseAndTransactionCOMMITROLLBACKNew"
        Me.ExportToMMCaseAndTransactionCOMMITROLLBACKNewBindingSource.DataSource = Me.MMDataDataSet1
        '
        'ExportToMMCaseAndTransactionCOMMITROLLBACKNewTableAdapter
        '
        Me.ExportToMMCaseAndTransactionCOMMITROLLBACKNewTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tag})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(5, 26)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 18
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(486, 653)
        Me.DataGridView1.TabIndex = 8
        '
        'MMCHDxRxLtMtBindingSource
        '
        Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
        Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMCHDxRxLtMtTableAdapter
        '
        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
        '
        'MMCHDxRxLtMtDataGridView
        '
        Me.MMCHDxRxLtMtDataGridView.AllowUserToAddRows = False
        Me.MMCHDxRxLtMtDataGridView.AllowUserToDeleteRows = False
        Me.MMCHDxRxLtMtDataGridView.AllowUserToOrderColumns = True
        Me.MMCHDxRxLtMtDataGridView.AllowUserToResizeColumns = False
        Me.MMCHDxRxLtMtDataGridView.AllowUserToResizeRows = False
        Me.MMCHDxRxLtMtDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MMCHDxRxLtMtDataGridView.AutoGenerateColumns = False
        Me.MMCHDxRxLtMtDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.MMCHDxRxLtMtDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMCHDxRxLtMtDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MMCHDxRxLtMtDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn12})
        Me.MMCHDxRxLtMtDataGridView.DataSource = Me.MMCHDxRxLtMtBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MMCHDxRxLtMtDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.MMCHDxRxLtMtDataGridView.Location = New System.Drawing.Point(501, 384)
        Me.MMCHDxRxLtMtDataGridView.Name = "MMCHDxRxLtMtDataGridView"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMCHDxRxLtMtDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MMCHDxRxLtMtDataGridView.RowHeadersVisible = False
        Me.MMCHDxRxLtMtDataGridView.RowTemplate.Height = 18
        Me.MMCHDxRxLtMtDataGridView.Size = New System.Drawing.Size(628, 293)
        Me.MMCHDxRxLtMtDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Chart"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CaseNumber"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Case"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 55
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 55
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 220
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "PostedToBilling"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Posted"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Amnt"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 50
        '
        'radToBePosted
        '
        Me.radToBePosted.Appearance = System.Windows.Forms.Appearance.Button
        Me.radToBePosted.AutoSize = True
        Me.radToBePosted.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.radToBePosted.Checked = True
        Me.radToBePosted.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radToBePosted.Location = New System.Drawing.Point(6, 0)
        Me.radToBePosted.Name = "radToBePosted"
        Me.radToBePosted.Size = New System.Drawing.Size(82, 23)
        Me.radToBePosted.TabIndex = 149
        Me.radToBePosted.TabStop = True
        Me.radToBePosted.Text = "To Be Posted"
        Me.radToBePosted.UseVisualStyleBackColor = False
        '
        'radAll
        '
        Me.radAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.radAll.AutoSize = True
        Me.radAll.BackColor = System.Drawing.Color.Transparent
        Me.radAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.radAll.Location = New System.Drawing.Point(94, 0)
        Me.radAll.Name = "radAll"
        Me.radAll.Size = New System.Drawing.Size(46, 23)
        Me.radAll.TabIndex = 148
        Me.radAll.Text = "   All   "
        Me.radAll.UseVisualStyleBackColor = False
        '
        'lblPosted
        '
        Me.lblPosted.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPosted.Font = New System.Drawing.Font("Mongolian Baiti", 16.0!)
        Me.lblPosted.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblPosted.Location = New System.Drawing.Point(146, 0)
        Me.lblPosted.Name = "lblPosted"
        Me.lblPosted.Size = New System.Drawing.Size(320, 26)
        Me.lblPosted.TabIndex = 150
        Me.lblPosted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(650, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 26)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Procedures"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tag
        '
        Me.Tag.HeaderText = "Tag"
        Me.Tag.Name = "Tag"
        Me.Tag.Text = "Export"
        Me.Tag.UseColumnTextForButtonValue = True
        Me.Tag.Width = 55
        '
        'PostBillingData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 682)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPosted)
        Me.Controls.Add(Me.radToBePosted)
        Me.Controls.Add(Me.radAll)
        Me.Controls.Add(Me.MMCHDxRxLtMtDataGridView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCasesPosted)
        Me.Name = "PostBillingData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Post Billing Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportToTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportToMMCaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportToMMCaseCaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportToTransactionCaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportToMMCaseAndTransactionCOMMITROLLBACKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportToMMCaseAndTransactionCOMMITROLLBACKNewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHDxRxLtMtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCasesPosted As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents ExportToTransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportToTransactionTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.ExportToTransactionTableAdapter
    Friend WithEvents ExportToMMCaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportToMMCaseTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseTableAdapter
    Friend WithEvents txtCaseNumber As System.Windows.Forms.TextBox
    Friend WithEvents ExportToMMCaseCaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportToMMCaseCaseTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseCaseTableAdapter
    Friend WithEvents ExportToTransactionCaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportToTransactionCaseTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.ExportToTransactionCaseTableAdapter
    Friend WithEvents btnPostBillingByDate As System.Windows.Forms.Button
    Friend WithEvents ExportToMMCaseAndTransactionCOMMITROLLBACKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportToMMCaseAndTransactionCOMMITROLLBACKTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseAndTransactionCOMMITROLLBACKTableAdapter
    Friend WithEvents btnPostBillingByCase As System.Windows.Forms.Button
    Friend WithEvents ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKTableAdapter
    Friend WithEvents ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseAndTransactionByCaseNoCOMMITROLLBACKNewTableAdapter
    Friend WithEvents ExportToMMCaseAndTransactionCOMMITROLLBACKNewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ExportToMMCaseAndTransactionCOMMITROLLBACKNewTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.ExportToMMCaseAndTransactionCOMMITROLLBACKNewTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MMCHDxRxLtMtBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMCHDxRxLtMtTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
    Friend WithEvents MMCHDxRxLtMtDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents radToBePosted As System.Windows.Forms.RadioButton
    Friend WithEvents radAll As System.Windows.Forms.RadioButton
    Friend WithEvents lblPosted As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tag As System.Windows.Forms.DataGridViewButtonColumn
End Class
