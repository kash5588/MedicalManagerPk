<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChiefComplaint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChiefComplaint))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.MMChartCCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMChartCCTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartCCTableAdapter
        Me.MMChartCCBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.MMChartCCBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MMChartCCDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CategorySortOrder = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ItemSortOrder = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartCCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartCCBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMChartCCBindingNavigator.SuspendLayout()
        CType(Me.MMChartCCDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMChartCCBindingSource
        '
        Me.MMChartCCBindingSource.DataMember = "MMChartCC"
        Me.MMChartCCBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMChartCCTableAdapter
        '
        Me.MMChartCCTableAdapter.ClearBeforeFill = True
        '
        'MMChartCCBindingNavigator
        '
        Me.MMChartCCBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMChartCCBindingNavigator.BindingSource = Me.MMChartCCBindingSource
        Me.MMChartCCBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMChartCCBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMChartCCBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel2, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel1, Me.MMChartCCBindingNavigatorSaveItem})
        Me.MMChartCCBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMChartCCBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMChartCCBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMChartCCBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMChartCCBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMChartCCBindingNavigator.Name = "MMChartCCBindingNavigator"
        Me.MMChartCCBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMChartCCBindingNavigator.Size = New System.Drawing.Size(606, 25)
        Me.MMChartCCBindingNavigator.TabIndex = 0
        Me.MMChartCCBindingNavigator.Text = "BindingNavigator1"
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel2.Text = "     "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel1.Text = "     "
        '
        'MMChartCCBindingNavigatorSaveItem
        '
        Me.MMChartCCBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MMChartCCBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMChartCCBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMChartCCBindingNavigatorSaveItem.Name = "MMChartCCBindingNavigatorSaveItem"
        Me.MMChartCCBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MMChartCCBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MMChartCCDataGridView
        '
        Me.MMChartCCDataGridView.AllowUserToAddRows = False
        Me.MMChartCCDataGridView.AutoGenerateColumns = False
        Me.MMChartCCDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Category, Me.CategorySortOrder, Me.ItemSortOrder})
        Me.MMChartCCDataGridView.DataSource = Me.MMChartCCBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MMChartCCDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.MMChartCCDataGridView.Location = New System.Drawing.Point(0, 36)
        Me.MMChartCCDataGridView.Name = "MMChartCCDataGridView"
        Me.MMChartCCDataGridView.Size = New System.Drawing.Size(606, 627)
        Me.MMChartCCDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ChiefComplaint"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ChiefComplaint"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'Category
        '
        Me.Category.DataPropertyName = "Category"
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.Width = 150
        '
        'CategorySortOrder
        '
        Me.CategorySortOrder.DataPropertyName = "CategorySortOrder"
        Me.CategorySortOrder.HeaderText = "CategorySortOrder"
        Me.CategorySortOrder.Name = "CategorySortOrder"
        '
        'ItemSortOrder
        '
        Me.ItemSortOrder.DataPropertyName = "ItemSortOrder"
        Me.ItemSortOrder.HeaderText = "ItemSortOrder"
        Me.ItemSortOrder.Name = "ItemSortOrder"
        '
        'ChiefComplaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 664)
        Me.Controls.Add(Me.MMChartCCDataGridView)
        Me.Controls.Add(Me.MMChartCCBindingNavigator)
        Me.Name = "ChiefComplaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChiefComplaint"
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartCCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartCCBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMChartCCBindingNavigator.ResumeLayout(False)
        Me.MMChartCCBindingNavigator.PerformLayout()
        CType(Me.MMChartCCDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents MMChartCCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartCCTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartCCTableAdapter
    Friend WithEvents MMChartCCBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMChartCCBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MMChartCCDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategorySortOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemSortOrder As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
