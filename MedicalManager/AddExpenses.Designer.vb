<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddExpenses
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
        Dim label5 As System.Windows.Forms.Label
        Dim label3 As System.Windows.Forms.Label
        Dim label2 As System.Windows.Forms.Label
        Dim recievedDateLabel As System.Windows.Forms.Label
        Dim remarksLabel As System.Windows.Forms.Label
        Dim amountLabel As System.Windows.Forms.Label
        Dim ExpanseTypeLabel As System.Windows.Forms.Label
        Dim PaidToLabel As System.Windows.Forms.Label
        Dim RecieptNoLabel As System.Windows.Forms.Label
        Dim label4 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddExpenses))
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.TBFind = New System.Windows.Forms.TextBox()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.buttonSearch = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.ExpensesDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpensesDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.RecieptNoTextBox = New System.Windows.Forms.TextBox()
        Me.PaidToComboBox = New System.Windows.Forms.ComboBox()
        Me.ExpanseTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.TBAmount = New System.Windows.Forms.NumericUpDown()
        Me.recievedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.remarksTextBox = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.ExpensesDetailTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.ExpensesDetailTableAdapter()
        Me.BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.LBTotalAmount = New System.Windows.Forms.Label()
        Me.labelUser = New System.Windows.Forms.Label()
        Me.labelCompany = New System.Windows.Forms.Label()
        label5 = New System.Windows.Forms.Label()
        label3 = New System.Windows.Forms.Label()
        label2 = New System.Windows.Forms.Label()
        recievedDateLabel = New System.Windows.Forms.Label()
        remarksLabel = New System.Windows.Forms.Label()
        amountLabel = New System.Windows.Forms.Label()
        ExpanseTypeLabel = New System.Windows.Forms.Label()
        PaidToLabel = New System.Windows.Forms.Label()
        RecieptNoLabel = New System.Windows.Forms.Label()
        label4 = New System.Windows.Forms.Label()
        Me.panel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.ExpensesDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpensesDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.TBAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'label5
        '
        label5.AutoSize = True
        label5.Location = New System.Drawing.Point(639, 14)
        label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        label5.Name = "label5"
        label5.Size = New System.Drawing.Size(47, 15)
        label5.TabIndex = 15
        label5.Text = "FindBy:"
        '
        'label3
        '
        label3.AutoSize = True
        label3.Location = New System.Drawing.Point(224, 15)
        label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        label3.Name = "label3"
        label3.Size = New System.Drawing.Size(53, 15)
        label3.TabIndex = 7
        label3.Text = "Date To:"
        '
        'label2
        '
        label2.AutoSize = True
        label2.Location = New System.Drawing.Point(7, 14)
        label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        label2.Name = "label2"
        label2.Size = New System.Drawing.Size(68, 15)
        label2.TabIndex = 8
        label2.Text = "Date From:"
        '
        'recievedDateLabel
        '
        recievedDateLabel.AutoSize = True
        recievedDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        recievedDateLabel.Location = New System.Drawing.Point(64, 350)
        recievedDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        recievedDateLabel.Name = "recievedDateLabel"
        recievedDateLabel.Size = New System.Drawing.Size(36, 15)
        recievedDateLabel.TabIndex = 8
        recievedDateLabel.Text = "Date:"
        '
        'remarksLabel
        '
        remarksLabel.AutoSize = True
        remarksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        remarksLabel.Location = New System.Drawing.Point(22, 406)
        remarksLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        remarksLabel.Name = "remarksLabel"
        remarksLabel.Size = New System.Drawing.Size(72, 15)
        remarksLabel.TabIndex = 12
        remarksLabel.Text = "Description:"
        '
        'amountLabel
        '
        amountLabel.AutoSize = True
        amountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        amountLabel.Location = New System.Drawing.Point(46, 284)
        amountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        amountLabel.Name = "amountLabel"
        amountLabel.Size = New System.Drawing.Size(52, 15)
        amountLabel.TabIndex = 14
        amountLabel.Text = "Amount:"
        '
        'ExpanseTypeLabel
        '
        ExpanseTypeLabel.AutoSize = True
        ExpanseTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ExpanseTypeLabel.Location = New System.Drawing.Point(5, 106)
        ExpanseTypeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ExpanseTypeLabel.Name = "ExpanseTypeLabel"
        ExpanseTypeLabel.Size = New System.Drawing.Size(87, 15)
        ExpanseTypeLabel.TabIndex = 17
        ExpanseTypeLabel.Text = "Expanse Type:"
        '
        'PaidToLabel
        '
        PaidToLabel.AutoSize = True
        PaidToLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaidToLabel.Location = New System.Drawing.Point(46, 163)
        PaidToLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PaidToLabel.Name = "PaidToLabel"
        PaidToLabel.Size = New System.Drawing.Size(52, 15)
        PaidToLabel.TabIndex = 18
        PaidToLabel.Text = "Paid To:"
        '
        'RecieptNoLabel
        '
        RecieptNoLabel.AutoSize = True
        RecieptNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecieptNoLabel.Location = New System.Drawing.Point(23, 224)
        RecieptNoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RecieptNoLabel.Name = "RecieptNoLabel"
        RecieptNoLabel.Size = New System.Drawing.Size(71, 15)
        RecieptNoLabel.TabIndex = 19
        RecieptNoLabel.Text = "Reciept No:"
        '
        'label4
        '
        label4.AutoSize = True
        label4.BackColor = System.Drawing.SystemColors.Control
        label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        label4.ForeColor = System.Drawing.Color.Black
        label4.Location = New System.Drawing.Point(342, 703)
        label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        label4.Name = "label4"
        label4.Size = New System.Drawing.Size(92, 15)
        label4.TabIndex = 9
        label4.Text = "Total Amount: ="
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.panel3.Controls.Add(label5)
        Me.panel3.Controls.Add(Me.TBFind)
        Me.panel3.Controls.Add(Me.dateTo)
        Me.panel3.Controls.Add(Me.dateFrom)
        Me.panel3.Controls.Add(Me.buttonSearch)
        Me.panel3.Controls.Add(label3)
        Me.panel3.Controls.Add(label2)
        Me.panel3.Location = New System.Drawing.Point(303, 36)
        Me.panel3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(929, 46)
        Me.panel3.TabIndex = 6
        '
        'TBFind
        '
        Me.TBFind.Location = New System.Drawing.Point(704, 10)
        Me.TBFind.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TBFind.MaxLength = 10
        Me.TBFind.Name = "TBFind"
        Me.TBFind.Size = New System.Drawing.Size(132, 21)
        Me.TBFind.TabIndex = 14
        '
        'dateTo
        '
        Me.dateTo.CustomFormat = "dd/MM/yyyy"
        Me.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTo.Location = New System.Drawing.Point(307, 10)
        Me.dateTo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(117, 21)
        Me.dateTo.TabIndex = 13
        '
        'dateFrom
        '
        Me.dateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateFrom.Location = New System.Drawing.Point(100, 10)
        Me.dateFrom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(117, 21)
        Me.dateFrom.TabIndex = 12
        '
        'buttonSearch
        '
        Me.buttonSearch.BackColor = System.Drawing.Color.DarkCyan
        Me.buttonSearch.Font = New System.Drawing.Font("Calibri Light", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buttonSearch.Location = New System.Drawing.Point(442, 3)
        Me.buttonSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.buttonSearch.Name = "buttonSearch"
        Me.buttonSearch.Size = New System.Drawing.Size(161, 40)
        Me.buttonSearch.TabIndex = 11
        Me.buttonSearch.Text = "Search"
        Me.buttonSearch.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.ExpensesDetailDataGridView)
        Me.panel2.Location = New System.Drawing.Point(303, 84)
        Me.panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(929, 600)
        Me.panel2.TabIndex = 5
        '
        'ExpensesDetailDataGridView
        '
        Me.ExpensesDetailDataGridView.AllowUserToAddRows = False
        Me.ExpensesDetailDataGridView.AllowUserToDeleteRows = False
        Me.ExpensesDetailDataGridView.AutoGenerateColumns = False
        Me.ExpensesDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExpensesDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Amount, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ExpensesDetailDataGridView.DataSource = Me.ExpensesDetailBindingSource
        Me.ExpensesDetailDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExpensesDetailDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ExpensesDetailDataGridView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ExpensesDetailDataGridView.Name = "ExpensesDetailDataGridView"
        Me.ExpensesDetailDataGridView.ReadOnly = True
        Me.ExpensesDetailDataGridView.RowHeadersVisible = False
        Me.ExpensesDetailDataGridView.Size = New System.Drawing.Size(929, 600)
        Me.ExpensesDetailDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ExpanseType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ExpanseType"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PaidTo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PaidTo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle2
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RecieptNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "RecieptNo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ExpanseDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PracticeName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PracticeName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn9.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'ExpensesDetailBindingSource
        '
        Me.ExpensesDetailBindingSource.DataMember = "ExpensesDetail"
        Me.ExpensesDetailBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.panel1.Controls.Add(RecieptNoLabel)
        Me.panel1.Controls.Add(Me.RecieptNoTextBox)
        Me.panel1.Controls.Add(PaidToLabel)
        Me.panel1.Controls.Add(Me.PaidToComboBox)
        Me.panel1.Controls.Add(ExpanseTypeLabel)
        Me.panel1.Controls.Add(Me.ExpanseTypeComboBox)
        Me.panel1.Controls.Add(Me.buttonSave)
        Me.panel1.Controls.Add(Me.TBAmount)
        Me.panel1.Controls.Add(recievedDateLabel)
        Me.panel1.Controls.Add(Me.recievedDateDateTimePicker)
        Me.panel1.Controls.Add(remarksLabel)
        Me.panel1.Controls.Add(Me.remarksTextBox)
        Me.panel1.Controls.Add(amountLabel)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.panel4)
        Me.panel1.Location = New System.Drawing.Point(13, 33)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(296, 699)
        Me.panel1.TabIndex = 4
        '
        'RecieptNoTextBox
        '
        Me.RecieptNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesDetailBindingSource, "RecieptNo", True))
        Me.RecieptNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecieptNoTextBox.Location = New System.Drawing.Point(101, 220)
        Me.RecieptNoTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RecieptNoTextBox.Name = "RecieptNoTextBox"
        Me.RecieptNoTextBox.Size = New System.Drawing.Size(181, 21)
        Me.RecieptNoTextBox.TabIndex = 3
        '
        'PaidToComboBox
        '
        Me.PaidToComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesDetailBindingSource, "PaidTo", True))
        Me.PaidToComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaidToComboBox.FormattingEnabled = True
        Me.PaidToComboBox.Location = New System.Drawing.Point(101, 159)
        Me.PaidToComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PaidToComboBox.Name = "PaidToComboBox"
        Me.PaidToComboBox.Size = New System.Drawing.Size(181, 23)
        Me.PaidToComboBox.TabIndex = 2
        '
        'ExpanseTypeComboBox
        '
        Me.ExpanseTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesDetailBindingSource, "ExpanseType", True))
        Me.ExpanseTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpanseTypeComboBox.FormattingEnabled = True
        Me.ExpanseTypeComboBox.Location = New System.Drawing.Point(101, 103)
        Me.ExpanseTypeComboBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ExpanseTypeComboBox.Name = "ExpanseTypeComboBox"
        Me.ExpanseTypeComboBox.Size = New System.Drawing.Size(181, 23)
        Me.ExpanseTypeComboBox.TabIndex = 1
        '
        'buttonSave
        '
        Me.buttonSave.BackColor = System.Drawing.Color.Chocolate
        Me.buttonSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buttonSave.Location = New System.Drawing.Point(74, 508)
        Me.buttonSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(180, 40)
        Me.buttonSave.TabIndex = 7
        Me.buttonSave.Text = "Save"
        Me.buttonSave.UseVisualStyleBackColor = False
        '
        'TBAmount
        '
        Me.TBAmount.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ExpensesDetailBindingSource, "Amount", True))
        Me.TBAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBAmount.Location = New System.Drawing.Point(101, 280)
        Me.TBAmount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TBAmount.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TBAmount.Name = "TBAmount"
        Me.TBAmount.Size = New System.Drawing.Size(182, 22)
        Me.TBAmount.TabIndex = 4
        Me.TBAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'recievedDateDateTimePicker
        '
        Me.recievedDateDateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.recievedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesDetailBindingSource, "ExpanseDate", True))
        Me.recievedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ExpensesDetailBindingSource, "ExpanseDate", True))
        Me.recievedDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recievedDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.recievedDateDateTimePicker.Location = New System.Drawing.Point(101, 345)
        Me.recievedDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.recievedDateDateTimePicker.Name = "recievedDateDateTimePicker"
        Me.recievedDateDateTimePicker.Size = New System.Drawing.Size(181, 21)
        Me.recievedDateDateTimePicker.TabIndex = 5
        '
        'remarksTextBox
        '
        Me.remarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesDetailBindingSource, "Description", True))
        Me.remarksTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remarksTextBox.Location = New System.Drawing.Point(101, 403)
        Me.remarksTextBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.remarksTextBox.MaxLength = 100
        Me.remarksTextBox.Multiline = True
        Me.remarksTextBox.Name = "remarksTextBox"
        Me.remarksTextBox.Size = New System.Drawing.Size(181, 65)
        Me.remarksTextBox.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.label1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(47, 24)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(195, 24)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Add Expenses Here"
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.SystemColors.Desktop
        Me.panel4.Location = New System.Drawing.Point(4, 3)
        Me.panel4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(278, 63)
        Me.panel4.TabIndex = 1
        '
        'ExpensesDetailTableAdapter
        '
        Me.ExpensesDetailTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator
        '
        Me.BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator.BindingSource = Me.ExpensesDetailBindingSource
        Me.BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator.Name = "BindingNavigator"
        Me.BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator.Size = New System.Drawing.Size(1235, 25)
        Me.BindingNavigator.TabIndex = 7
        Me.BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(76, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add New"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
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
        Me.BindingNavigatorDeleteItem.Visible = False
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
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
        'LBTotalAmount
        '
        Me.LBTotalAmount.AutoSize = True
        Me.LBTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.LBTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTotalAmount.ForeColor = System.Drawing.Color.Red
        Me.LBTotalAmount.Location = New System.Drawing.Point(458, 700)
        Me.LBTotalAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBTotalAmount.Name = "LBTotalAmount"
        Me.LBTotalAmount.Size = New System.Drawing.Size(0, 15)
        Me.LBTotalAmount.TabIndex = 10
        Me.LBTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'labelUser
        '
        Me.labelUser.AutoSize = True
        Me.labelUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesDetailBindingSource, "UserName", True))
        Me.labelUser.ForeColor = System.Drawing.Color.Transparent
        Me.labelUser.Location = New System.Drawing.Point(1162, 711)
        Me.labelUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(60, 15)
        Me.labelUser.TabIndex = 11
        Me.labelUser.Text = "labelUser"
        '
        'labelCompany
        '
        Me.labelCompany.AutoSize = True
        Me.labelCompany.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesDetailBindingSource, "PracticeName", True))
        Me.labelCompany.ForeColor = System.Drawing.Color.Transparent
        Me.labelCompany.Location = New System.Drawing.Point(1087, 705)
        Me.labelCompany.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCompany.Name = "labelCompany"
        Me.labelCompany.Size = New System.Drawing.Size(60, 15)
        Me.labelCompany.TabIndex = 11
        Me.labelCompany.Text = "labelUser"
        '
        'AddExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 735)
        Me.Controls.Add(Me.labelCompany)
        Me.Controls.Add(Me.labelUser)
        Me.Controls.Add(Me.LBTotalAmount)
        Me.Controls.Add(label4)
        Me.Controls.Add(Me.BindingNavigator)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "AddExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddExpenses"
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.panel2.ResumeLayout(False)
        CType(Me.ExpensesDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpensesDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.TBAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator.ResumeLayout(False)
        Me.BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panel3 As Panel
    Private WithEvents TBFind As TextBox
    Private WithEvents dateTo As DateTimePicker
    Private WithEvents dateFrom As DateTimePicker
    Private WithEvents buttonSearch As Button
    Private WithEvents panel2 As Panel
    Private WithEvents panel1 As Panel
    Private WithEvents buttonSave As Button
    Private WithEvents TBAmount As NumericUpDown
    Private WithEvents recievedDateDateTimePicker As DateTimePicker
    Private WithEvents remarksTextBox As TextBox
    Private WithEvents label1 As Label
    Private WithEvents panel4 As Panel
    Friend WithEvents MMDataDataSet1 As MMDataDataSet1
    Friend WithEvents ExpensesDetailBindingSource As BindingSource
    Friend WithEvents ExpensesDetailTableAdapter As MMDataDataSet1TableAdapters.ExpensesDetailTableAdapter
    Friend WithEvents ExpensesDetailDataGridView As DataGridView
    Friend WithEvents BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RecieptNoTextBox As TextBox
    Friend WithEvents PaidToComboBox As ComboBox
    Friend WithEvents ExpanseTypeComboBox As ComboBox
    Private WithEvents LBTotalAmount As Label
    Friend WithEvents labelUser As Label
    Friend WithEvents labelCompany As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
