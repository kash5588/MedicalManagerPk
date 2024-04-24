<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MMDRUGMaintenance
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim DRGNDCLabel As System.Windows.Forms.Label
        Dim DRGNAMELabel As System.Windows.Forms.Label
        Dim DRGBRNAMELabel As System.Windows.Forms.Label
        Dim DRGGGENNAMELabel As System.Windows.Forms.Label
        Dim DRGMADELabel As System.Windows.Forms.Label
        Dim DRGTYPELabel As System.Windows.Forms.Label
        Dim STRONGLabel As System.Windows.Forms.Label
        Dim FORMLabel As System.Windows.Forms.Label
        Dim ROUTELabel As System.Windows.Forms.Label
        Dim MyRxLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MMDRUGMaintenance))
        Me.MMDRUGBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MMDRUGBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.Param1ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.cmbFilter = New System.Windows.Forms.ToolStripComboBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.MMDRUGDataGridView = New System.Windows.Forms.DataGridView
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DRGNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DRGGGENNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STRONGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FORMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DRGBRNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DRGNDCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DRGMADEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DRGTYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ROUTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MyRxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMDRUGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.DRGNDCTextBox = New System.Windows.Forms.TextBox
        Me.DRGNAMETextBox = New System.Windows.Forms.TextBox
        Me.DRGBRNAMETextBox = New System.Windows.Forms.TextBox
        Me.DRGGGENNAMETextBox = New System.Windows.Forms.TextBox
        Me.DRGMADETextBox = New System.Windows.Forms.TextBox
        Me.DRGTYPETextBox = New System.Windows.Forms.TextBox
        Me.STRONGTextBox = New System.Windows.Forms.TextBox
        Me.FORMTextBox = New System.Windows.Forms.TextBox
        Me.ROUTETextBox = New System.Windows.Forms.TextBox
        Me.MyRxComboBox = New System.Windows.Forms.ComboBox
        Me.MMDRUGTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMDRUGTableAdapter
        Me.MMPrecticeTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMPrecticeTableAdapter
        Me.MMPrecticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        IDLabel = New System.Windows.Forms.Label
        DRGNDCLabel = New System.Windows.Forms.Label
        DRGNAMELabel = New System.Windows.Forms.Label
        DRGBRNAMELabel = New System.Windows.Forms.Label
        DRGGGENNAMELabel = New System.Windows.Forms.Label
        DRGMADELabel = New System.Windows.Forms.Label
        DRGTYPELabel = New System.Windows.Forms.Label
        STRONGLabel = New System.Windows.Forms.Label
        FORMLabel = New System.Windows.Forms.Label
        ROUTELabel = New System.Windows.Forms.Label
        MyRxLabel = New System.Windows.Forms.Label
        CType(Me.MMDRUGBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMDRUGBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MMDRUGDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDRUGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MMPrecticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(180, 66)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'DRGNDCLabel
        '
        DRGNDCLabel.AutoSize = True
        DRGNDCLabel.Location = New System.Drawing.Point(168, 92)
        DRGNDCLabel.Name = "DRGNDCLabel"
        DRGNDCLabel.Size = New System.Drawing.Size(33, 13)
        DRGNDCLabel.TabIndex = 2
        DRGNDCLabel.Text = "NDC:"
        '
        'DRGNAMELabel
        '
        DRGNAMELabel.AutoSize = True
        DRGNAMELabel.Location = New System.Drawing.Point(160, 118)
        DRGNAMELabel.Name = "DRGNAMELabel"
        DRGNAMELabel.Size = New System.Drawing.Size(41, 13)
        DRGNAMELabel.TabIndex = 4
        DRGNAMELabel.Text = "NAME:"
        '
        'DRGBRNAMELabel
        '
        DRGBRNAMELabel.AutoSize = True
        DRGBRNAMELabel.Location = New System.Drawing.Point(119, 144)
        DRGBRNAMELabel.Name = "DRGBRNAMELabel"
        DRGBRNAMELabel.Size = New System.Drawing.Size(82, 13)
        DRGBRNAMELabel.TabIndex = 6
        DRGBRNAMELabel.Text = "BRAND NAME:"
        '
        'DRGGGENNAMELabel
        '
        DRGGGENNAMELabel.AutoSize = True
        DRGGGENNAMELabel.Location = New System.Drawing.Point(109, 170)
        DRGGGENNAMELabel.Name = "DRGGGENNAMELabel"
        DRGGGENNAMELabel.Size = New System.Drawing.Size(92, 13)
        DRGGGENNAMELabel.TabIndex = 8
        DRGGGENNAMELabel.Text = "GENERIC NAME:"
        '
        'DRGMADELabel
        '
        DRGMADELabel.AutoSize = True
        DRGMADELabel.Location = New System.Drawing.Point(523, 62)
        DRGMADELabel.Name = "DRGMADELabel"
        DRGMADELabel.Size = New System.Drawing.Size(58, 13)
        DRGMADELabel.TabIndex = 10
        DRGMADELabel.Text = "MADE BY:"
        '
        'DRGTYPELabel
        '
        DRGTYPELabel.AutoSize = True
        DRGTYPELabel.Location = New System.Drawing.Point(543, 88)
        DRGTYPELabel.Name = "DRGTYPELabel"
        DRGTYPELabel.Size = New System.Drawing.Size(38, 13)
        DRGTYPELabel.TabIndex = 12
        DRGTYPELabel.Text = "TYPE:"
        '
        'STRONGLabel
        '
        STRONGLabel.AutoSize = True
        STRONGLabel.Location = New System.Drawing.Point(511, 114)
        STRONGLabel.Name = "STRONGLabel"
        STRONGLabel.Size = New System.Drawing.Size(70, 13)
        STRONGLabel.TabIndex = 14
        STRONGLabel.Text = "STRENGTH:"
        '
        'FORMLabel
        '
        FORMLabel.AutoSize = True
        FORMLabel.Location = New System.Drawing.Point(540, 140)
        FORMLabel.Name = "FORMLabel"
        FORMLabel.Size = New System.Drawing.Size(41, 13)
        FORMLabel.TabIndex = 16
        FORMLabel.Text = "FORM:"
        '
        'ROUTELabel
        '
        ROUTELabel.AutoSize = True
        ROUTELabel.Location = New System.Drawing.Point(533, 166)
        ROUTELabel.Name = "ROUTELabel"
        ROUTELabel.Size = New System.Drawing.Size(48, 13)
        ROUTELabel.TabIndex = 18
        ROUTELabel.Text = "ROUTE:"
        '
        'MyRxLabel
        '
        MyRxLabel.AutoSize = True
        MyRxLabel.Location = New System.Drawing.Point(541, 192)
        MyRxLabel.Name = "MyRxLabel"
        MyRxLabel.Size = New System.Drawing.Size(40, 13)
        MyRxLabel.TabIndex = 20
        MyRxLabel.Text = "My Rx:"
        '
        'MMDRUGBindingNavigator
        '
        Me.MMDRUGBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMDRUGBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMDRUGBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMDRUGBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel1, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel4, Me.MMDRUGBindingNavigatorSaveItem, Me.ToolStripLabel5, Me.ToolStripLabel2, Me.Param1ToolStripTextBox, Me.ToolStripLabel3, Me.cmbFilter})
        Me.MMDRUGBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMDRUGBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMDRUGBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMDRUGBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMDRUGBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMDRUGBindingNavigator.Name = "MMDRUGBindingNavigator"
        Me.MMDRUGBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMDRUGBindingNavigator.Size = New System.Drawing.Size(860, 25)
        Me.MMDRUGBindingNavigator.TabIndex = 2
        Me.MMDRUGBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(69, 22)
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
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(58, 22)
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
        'MMDRUGBindingNavigatorSaveItem
        '
        Me.MMDRUGBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMDRUGBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMDRUGBindingNavigatorSaveItem.Name = "MMDRUGBindingNavigatorSaveItem"
        Me.MMDRUGBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.MMDRUGBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(27, 22)
        Me.ToolStripLabel2.Text = "Find"
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        Me.Param1ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel3.Text = "Criteria"
        '
        'cmbFilter
        '
        Me.cmbFilter.AutoCompleteCustomSource.AddRange(New String() {"ChartNumber", "PatientName"})
        Me.cmbFilter.Items.AddRange(New Object() {"DRGNAME", "DRGGGNAME"})
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 25)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(860, 320)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MMDRUGDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(852, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MMDRUGDataGridView
        '
        Me.MMDRUGDataGridView.AllowUserToAddRows = False
        Me.MMDRUGDataGridView.AllowUserToDeleteRows = False
        Me.MMDRUGDataGridView.AllowUserToResizeRows = False
        Me.MMDRUGDataGridView.AutoGenerateColumns = False
        Me.MMDRUGDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DRGNAMEDataGridViewTextBoxColumn, Me.DRGGGENNAMEDataGridViewTextBoxColumn, Me.STRONGDataGridViewTextBoxColumn, Me.FORMDataGridViewTextBoxColumn, Me.DRGBRNAMEDataGridViewTextBoxColumn, Me.DRGNDCDataGridViewTextBoxColumn, Me.DRGMADEDataGridViewTextBoxColumn, Me.DRGTYPEDataGridViewTextBoxColumn, Me.ROUTEDataGridViewTextBoxColumn, Me.MyRxDataGridViewTextBoxColumn})
        Me.MMDRUGDataGridView.DataSource = Me.MMDRUGBindingSource
        Me.MMDRUGDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.MMDRUGDataGridView.Name = "MMDRUGDataGridView"
        Me.MMDRUGDataGridView.Size = New System.Drawing.Size(846, 288)
        Me.MMDRUGDataGridView.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'DRGNAMEDataGridViewTextBoxColumn
        '
        Me.DRGNAMEDataGridViewTextBoxColumn.DataPropertyName = "DRGNAME"
        Me.DRGNAMEDataGridViewTextBoxColumn.HeaderText = "DRGNAME"
        Me.DRGNAMEDataGridViewTextBoxColumn.Name = "DRGNAMEDataGridViewTextBoxColumn"
        Me.DRGNAMEDataGridViewTextBoxColumn.Width = 150
        '
        'DRGGGENNAMEDataGridViewTextBoxColumn
        '
        Me.DRGGGENNAMEDataGridViewTextBoxColumn.DataPropertyName = "DRGGGENNAME"
        Me.DRGGGENNAMEDataGridViewTextBoxColumn.HeaderText = "DRGGGENNAME"
        Me.DRGGGENNAMEDataGridViewTextBoxColumn.Name = "DRGGGENNAMEDataGridViewTextBoxColumn"
        Me.DRGGGENNAMEDataGridViewTextBoxColumn.Width = 160
        '
        'STRONGDataGridViewTextBoxColumn
        '
        Me.STRONGDataGridViewTextBoxColumn.DataPropertyName = "STRONG"
        Me.STRONGDataGridViewTextBoxColumn.HeaderText = "STRONG"
        Me.STRONGDataGridViewTextBoxColumn.Name = "STRONGDataGridViewTextBoxColumn"
        Me.STRONGDataGridViewTextBoxColumn.Width = 62
        '
        'FORMDataGridViewTextBoxColumn
        '
        Me.FORMDataGridViewTextBoxColumn.DataPropertyName = "FORM"
        Me.FORMDataGridViewTextBoxColumn.HeaderText = "FORM"
        Me.FORMDataGridViewTextBoxColumn.Name = "FORMDataGridViewTextBoxColumn"
        Me.FORMDataGridViewTextBoxColumn.Width = 52
        '
        'DRGBRNAMEDataGridViewTextBoxColumn
        '
        Me.DRGBRNAMEDataGridViewTextBoxColumn.DataPropertyName = "DRGBRNAME"
        Me.DRGBRNAMEDataGridViewTextBoxColumn.HeaderText = "DRGBRNAME"
        Me.DRGBRNAMEDataGridViewTextBoxColumn.Name = "DRGBRNAMEDataGridViewTextBoxColumn"
        Me.DRGBRNAMEDataGridViewTextBoxColumn.Width = 110
        '
        'DRGNDCDataGridViewTextBoxColumn
        '
        Me.DRGNDCDataGridViewTextBoxColumn.DataPropertyName = "DRGNDC"
        Me.DRGNDCDataGridViewTextBoxColumn.HeaderText = "DRGNDC"
        Me.DRGNDCDataGridViewTextBoxColumn.Name = "DRGNDCDataGridViewTextBoxColumn"
        Me.DRGNDCDataGridViewTextBoxColumn.Width = 85
        '
        'DRGMADEDataGridViewTextBoxColumn
        '
        Me.DRGMADEDataGridViewTextBoxColumn.DataPropertyName = "DRGMADE"
        Me.DRGMADEDataGridViewTextBoxColumn.HeaderText = "DRGMADE"
        Me.DRGMADEDataGridViewTextBoxColumn.Name = "DRGMADEDataGridViewTextBoxColumn"
        Me.DRGMADEDataGridViewTextBoxColumn.Visible = False
        '
        'DRGTYPEDataGridViewTextBoxColumn
        '
        Me.DRGTYPEDataGridViewTextBoxColumn.DataPropertyName = "DRGTYPE"
        Me.DRGTYPEDataGridViewTextBoxColumn.HeaderText = "TYPE"
        Me.DRGTYPEDataGridViewTextBoxColumn.Name = "DRGTYPEDataGridViewTextBoxColumn"
        Me.DRGTYPEDataGridViewTextBoxColumn.Width = 50
        '
        'ROUTEDataGridViewTextBoxColumn
        '
        Me.ROUTEDataGridViewTextBoxColumn.DataPropertyName = "ROUTE"
        Me.ROUTEDataGridViewTextBoxColumn.HeaderText = "ROUTE"
        Me.ROUTEDataGridViewTextBoxColumn.Name = "ROUTEDataGridViewTextBoxColumn"
        Me.ROUTEDataGridViewTextBoxColumn.Width = 52
        '
        'MyRxDataGridViewTextBoxColumn
        '
        Me.MyRxDataGridViewTextBoxColumn.DataPropertyName = "MyRx"
        Me.MyRxDataGridViewTextBoxColumn.HeaderText = "MyRx"
        Me.MyRxDataGridViewTextBoxColumn.Name = "MyRxDataGridViewTextBoxColumn"
        Me.MyRxDataGridViewTextBoxColumn.Width = 60
        '
        'MMDRUGBindingSource
        '
        Me.MMDRUGBindingSource.DataMember = "MMDRUG"
        Me.MMDRUGBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(IDLabel)
        Me.TabPage2.Controls.Add(Me.IDTextBox)
        Me.TabPage2.Controls.Add(DRGNDCLabel)
        Me.TabPage2.Controls.Add(Me.DRGNDCTextBox)
        Me.TabPage2.Controls.Add(DRGNAMELabel)
        Me.TabPage2.Controls.Add(Me.DRGNAMETextBox)
        Me.TabPage2.Controls.Add(DRGBRNAMELabel)
        Me.TabPage2.Controls.Add(Me.DRGBRNAMETextBox)
        Me.TabPage2.Controls.Add(DRGGGENNAMELabel)
        Me.TabPage2.Controls.Add(Me.DRGGGENNAMETextBox)
        Me.TabPage2.Controls.Add(DRGMADELabel)
        Me.TabPage2.Controls.Add(Me.DRGMADETextBox)
        Me.TabPage2.Controls.Add(DRGTYPELabel)
        Me.TabPage2.Controls.Add(Me.DRGTYPETextBox)
        Me.TabPage2.Controls.Add(STRONGLabel)
        Me.TabPage2.Controls.Add(Me.STRONGTextBox)
        Me.TabPage2.Controls.Add(FORMLabel)
        Me.TabPage2.Controls.Add(Me.FORMTextBox)
        Me.TabPage2.Controls.Add(ROUTELabel)
        Me.TabPage2.Controls.Add(Me.ROUTETextBox)
        Me.TabPage2.Controls.Add(MyRxLabel)
        Me.TabPage2.Controls.Add(Me.MyRxComboBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(852, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add/Edit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(207, 63)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'DRGNDCTextBox
        '
        Me.DRGNDCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "DRGNDC", True))
        Me.DRGNDCTextBox.Location = New System.Drawing.Point(207, 89)
        Me.DRGNDCTextBox.Name = "DRGNDCTextBox"
        Me.DRGNDCTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DRGNDCTextBox.TabIndex = 3
        '
        'DRGNAMETextBox
        '
        Me.DRGNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "DRGNAME", True))
        Me.DRGNAMETextBox.Location = New System.Drawing.Point(207, 115)
        Me.DRGNAMETextBox.Name = "DRGNAMETextBox"
        Me.DRGNAMETextBox.Size = New System.Drawing.Size(228, 20)
        Me.DRGNAMETextBox.TabIndex = 5
        '
        'DRGBRNAMETextBox
        '
        Me.DRGBRNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "DRGBRNAME", True))
        Me.DRGBRNAMETextBox.Location = New System.Drawing.Point(207, 141)
        Me.DRGBRNAMETextBox.Name = "DRGBRNAMETextBox"
        Me.DRGBRNAMETextBox.Size = New System.Drawing.Size(228, 20)
        Me.DRGBRNAMETextBox.TabIndex = 7
        '
        'DRGGGENNAMETextBox
        '
        Me.DRGGGENNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "DRGGGENNAME", True))
        Me.DRGGGENNAMETextBox.Location = New System.Drawing.Point(207, 167)
        Me.DRGGGENNAMETextBox.Name = "DRGGGENNAMETextBox"
        Me.DRGGGENNAMETextBox.Size = New System.Drawing.Size(228, 20)
        Me.DRGGGENNAMETextBox.TabIndex = 9
        '
        'DRGMADETextBox
        '
        Me.DRGMADETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "DRGMADE", True))
        Me.DRGMADETextBox.Location = New System.Drawing.Point(587, 59)
        Me.DRGMADETextBox.Name = "DRGMADETextBox"
        Me.DRGMADETextBox.Size = New System.Drawing.Size(121, 20)
        Me.DRGMADETextBox.TabIndex = 11
        '
        'DRGTYPETextBox
        '
        Me.DRGTYPETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "DRGTYPE", True))
        Me.DRGTYPETextBox.Location = New System.Drawing.Point(587, 85)
        Me.DRGTYPETextBox.Name = "DRGTYPETextBox"
        Me.DRGTYPETextBox.Size = New System.Drawing.Size(121, 20)
        Me.DRGTYPETextBox.TabIndex = 13
        '
        'STRONGTextBox
        '
        Me.STRONGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "STRONG", True))
        Me.STRONGTextBox.Location = New System.Drawing.Point(587, 111)
        Me.STRONGTextBox.Name = "STRONGTextBox"
        Me.STRONGTextBox.Size = New System.Drawing.Size(121, 20)
        Me.STRONGTextBox.TabIndex = 15
        '
        'FORMTextBox
        '
        Me.FORMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "FORM", True))
        Me.FORMTextBox.Location = New System.Drawing.Point(587, 137)
        Me.FORMTextBox.Name = "FORMTextBox"
        Me.FORMTextBox.Size = New System.Drawing.Size(121, 20)
        Me.FORMTextBox.TabIndex = 17
        '
        'ROUTETextBox
        '
        Me.ROUTETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "ROUTE", True))
        Me.ROUTETextBox.Location = New System.Drawing.Point(587, 163)
        Me.ROUTETextBox.Name = "ROUTETextBox"
        Me.ROUTETextBox.Size = New System.Drawing.Size(121, 20)
        Me.ROUTETextBox.TabIndex = 19
        '
        'MyRxComboBox
        '
        Me.MyRxComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMDRUGBindingSource, "MyRx", True))
        Me.MyRxComboBox.FormattingEnabled = True
        Me.MyRxComboBox.Location = New System.Drawing.Point(587, 189)
        Me.MyRxComboBox.Name = "MyRxComboBox"
        Me.MyRxComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MyRxComboBox.TabIndex = 21
        '
        'MMDRUGTableAdapter
        '
        Me.MMDRUGTableAdapter.ClearBeforeFill = True
        '
        'MMPrecticeTableAdapter
        '
        Me.MMPrecticeTableAdapter.ClearBeforeFill = True
        '
        'MMPrecticeBindingSource
        '
        Me.MMPrecticeBindingSource.DataMember = "MMPrectice"
        Me.MMPrecticeBindingSource.DataSource = Me.MMDataDataSet1
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel1.Text = "     "
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel4.Text = "     "
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel5.Text = "     "
        '
        'MMDRUGMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 348)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MMDRUGBindingNavigator)
        Me.Name = "MMDRUGMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MMDRUGMaintenance"
        CType(Me.MMDRUGBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMDRUGBindingNavigator.ResumeLayout(False)
        Me.MMDRUGBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.MMDRUGDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDRUGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.MMPrecticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDRUGBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMDRUGBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Param1ToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFilter As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents MMDRUGDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MMDRUGTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMDRUGTableAdapter
    Friend WithEvents MMPrecticeTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMPrecticeTableAdapter
    Friend WithEvents MMPrecticeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMDRUGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DRGNDCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DRGNAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DRGBRNAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DRGGGENNAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DRGMADETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DRGTYPETextBox As System.Windows.Forms.TextBox
    Friend WithEvents STRONGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FORMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ROUTETextBox As System.Windows.Forms.TextBox
    Friend WithEvents MyRxComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DRGNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DRGGGENNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STRONGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FORMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DRGBRNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DRGNDCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DRGMADEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DRGTYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ROUTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MyRxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
End Class
