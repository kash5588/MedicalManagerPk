<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARComments
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
        Dim CodeLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ARComments))
        Me.ARDataSet = New MedicalManager.ARDataSet
        Me.MMARCommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMARCommentsTableAdapter = New MedicalManager.ARDataSetTableAdapters.MMARCommentsTableAdapter
        Me.MMARCommentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MMARCommentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MMARCommentsDataGridView = New System.Windows.Forms.DataGridView
        Me.CodeTextBox = New System.Windows.Forms.TextBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        CodeLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARCommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARCommentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMARCommentsBindingNavigator.SuspendLayout()
        CType(Me.MMARCommentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(8, 271)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(35, 13)
        CodeLabel.TabIndex = 2
        CodeLabel.Text = "Code:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(8, 297)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 4
        DescriptionLabel.Text = "Description:"
        '
        'ARDataSet
        '
        Me.ARDataSet.DataSetName = "ARDataSet"
        Me.ARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMARCommentsBindingSource
        '
        Me.MMARCommentsBindingSource.DataMember = "MMARComments"
        Me.MMARCommentsBindingSource.DataSource = Me.ARDataSet
        '
        'MMARCommentsTableAdapter
        '
        Me.MMARCommentsTableAdapter.ClearBeforeFill = True
        '
        'MMARCommentsBindingNavigator
        '
        Me.MMARCommentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMARCommentsBindingNavigator.BindingSource = Me.MMARCommentsBindingSource
        Me.MMARCommentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMARCommentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMARCommentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MMARCommentsBindingNavigatorSaveItem})
        Me.MMARCommentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMARCommentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMARCommentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMARCommentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMARCommentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMARCommentsBindingNavigator.Name = "MMARCommentsBindingNavigator"
        Me.MMARCommentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMARCommentsBindingNavigator.Size = New System.Drawing.Size(619, 25)
        Me.MMARCommentsBindingNavigator.TabIndex = 0
        Me.MMARCommentsBindingNavigator.Text = "BindingNavigator1"
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
        'MMARCommentsBindingNavigatorSaveItem
        '
        Me.MMARCommentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MMARCommentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMARCommentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMARCommentsBindingNavigatorSaveItem.Name = "MMARCommentsBindingNavigatorSaveItem"
        Me.MMARCommentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MMARCommentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MMARCommentsDataGridView
        '
        Me.MMARCommentsDataGridView.AutoGenerateColumns = False
        Me.MMARCommentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.Description})
        Me.MMARCommentsDataGridView.DataSource = Me.MMARCommentsBindingSource
        Me.MMARCommentsDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.MMARCommentsDataGridView.Name = "MMARCommentsDataGridView"
        Me.MMARCommentsDataGridView.Size = New System.Drawing.Size(616, 220)
        Me.MMARCommentsDataGridView.TabIndex = 1
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMARCommentsBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(77, 268)
        Me.CodeTextBox.MaxLength = 10
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(157, 20)
        Me.CodeTextBox.TabIndex = 3
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMARCommentsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(77, 294)
        Me.DescriptionTextBox.MaxLength = 200
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(537, 20)
        Me.DescriptionTextBox.TabIndex = 5
        '
        'Code
        '
        Me.Code.DataPropertyName = "Code"
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        Me.Code.Width = 75
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 495
        '
        'ARComments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 339)
        Me.Controls.Add(CodeLabel)
        Me.Controls.Add(Me.CodeTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.MMARCommentsDataGridView)
        Me.Controls.Add(Me.MMARCommentsBindingNavigator)
        Me.Name = "ARComments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARComments"
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARCommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARCommentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMARCommentsBindingNavigator.ResumeLayout(False)
        Me.MMARCommentsBindingNavigator.PerformLayout()
        CType(Me.MMARCommentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ARDataSet As MedicalManager.ARDataSet
    Friend WithEvents MMARCommentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMARCommentsTableAdapter As MedicalManager.ARDataSetTableAdapters.MMARCommentsTableAdapter
    Friend WithEvents MMARCommentsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMARCommentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MMARCommentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
