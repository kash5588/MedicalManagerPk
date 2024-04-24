<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileDetailData
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
        Dim QIDLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim SortOrderLabel As System.Windows.Forms.Label
        Dim ChiefComplaintLabel As System.Windows.Forms.Label
        Dim TemplateNameLabel As System.Windows.Forms.Label
        Dim SubCategoryLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfileDetailData))
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.QIDsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QIDsTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.QIDsTableAdapter
        Me.QIDsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.QIDsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.QIDsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.QIDTextBox = New System.Windows.Forms.TextBox
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox
        Me.CategoryTextBox = New System.Windows.Forms.TextBox
        Me.SubCategoryTextBox = New System.Windows.Forms.TextBox
        Me.SortOrderTextBox = New System.Windows.Forms.TextBox
        Me.ChiefComplaintTextBox = New System.Windows.Forms.TextBox
        Me.TemplateNameTextBox = New System.Windows.Forms.TextBox
        Me.SubCategoryTextBox1 = New System.Windows.Forms.TextBox
        IDLabel = New System.Windows.Forms.Label
        QIDLabel = New System.Windows.Forms.Label
        DescriptionLabel = New System.Windows.Forms.Label
        CategoryLabel = New System.Windows.Forms.Label
        SortOrderLabel = New System.Windows.Forms.Label
        ChiefComplaintLabel = New System.Windows.Forms.Label
        TemplateNameLabel = New System.Windows.Forms.Label
        SubCategoryLabel1 = New System.Windows.Forms.Label
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QIDsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QIDsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QIDsBindingNavigator.SuspendLayout()
        CType(Me.QIDsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(99, 38)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'QIDLabel
        '
        QIDLabel.AutoSize = True
        QIDLabel.Location = New System.Drawing.Point(91, 64)
        QIDLabel.Name = "QIDLabel"
        QIDLabel.Size = New System.Drawing.Size(29, 13)
        QIDLabel.TabIndex = 4
        QIDLabel.Text = "QID:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(57, 90)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 6
        DescriptionLabel.Text = "Description:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(68, 116)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 8
        CategoryLabel.Text = "Category:"
        '
        'SortOrderLabel
        '
        SortOrderLabel.AutoSize = True
        SortOrderLabel.Location = New System.Drawing.Point(289, 64)
        SortOrderLabel.Name = "SortOrderLabel"
        SortOrderLabel.Size = New System.Drawing.Size(58, 13)
        SortOrderLabel.TabIndex = 12
        SortOrderLabel.Text = "Sort Order:"
        '
        'ChiefComplaintLabel
        '
        ChiefComplaintLabel.AutoSize = True
        ChiefComplaintLabel.Location = New System.Drawing.Point(264, 90)
        ChiefComplaintLabel.Name = "ChiefComplaintLabel"
        ChiefComplaintLabel.Size = New System.Drawing.Size(83, 13)
        ChiefComplaintLabel.TabIndex = 14
        ChiefComplaintLabel.Text = "Chief Complaint:"
        '
        'TemplateNameLabel
        '
        TemplateNameLabel.AutoSize = True
        TemplateNameLabel.Location = New System.Drawing.Point(262, 116)
        TemplateNameLabel.Name = "TemplateNameLabel"
        TemplateNameLabel.Size = New System.Drawing.Size(85, 13)
        TemplateNameLabel.TabIndex = 16
        TemplateNameLabel.Text = "Template Name:"
        '
        'SubCategoryLabel1
        '
        SubCategoryLabel1.AutoSize = True
        SubCategoryLabel1.Location = New System.Drawing.Point(46, 142)
        SubCategoryLabel1.Name = "SubCategoryLabel1"
        SubCategoryLabel1.Size = New System.Drawing.Size(74, 13)
        SubCategoryLabel1.TabIndex = 18
        SubCategoryLabel1.Text = "Sub Category:"
        '
        'MMDataDataSet2
        '
        Me.MMDataDataSet2.DataSetName = "MMDataDataSet2"
        Me.MMDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QIDsBindingSource
        '
        Me.QIDsBindingSource.DataMember = "QIDs"
        Me.QIDsBindingSource.DataSource = Me.MMDataDataSet2
        '
        'QIDsTableAdapter
        '
        Me.QIDsTableAdapter.ClearBeforeFill = True
        '
        'QIDsBindingNavigator
        '
        Me.QIDsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QIDsBindingNavigator.BindingSource = Me.QIDsBindingSource
        Me.QIDsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.QIDsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QIDsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.QIDsBindingNavigatorSaveItem})
        Me.QIDsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.QIDsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.QIDsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.QIDsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.QIDsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.QIDsBindingNavigator.Name = "QIDsBindingNavigator"
        Me.QIDsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.QIDsBindingNavigator.Size = New System.Drawing.Size(870, 25)
        Me.QIDsBindingNavigator.TabIndex = 0
        Me.QIDsBindingNavigator.Text = "BindingNavigator1"
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
        'QIDsBindingNavigatorSaveItem
        '
        Me.QIDsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QIDsBindingNavigatorSaveItem.Image = CType(resources.GetObject("QIDsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.QIDsBindingNavigatorSaveItem.Name = "QIDsBindingNavigatorSaveItem"
        Me.QIDsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.QIDsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'QIDsDataGridView
        '
        Me.QIDsDataGridView.AutoGenerateColumns = False
        Me.QIDsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.QIDsDataGridView.DataSource = Me.QIDsBindingSource
        Me.QIDsDataGridView.Location = New System.Drawing.Point(12, 182)
        Me.QIDsDataGridView.Name = "QIDsDataGridView"
        Me.QIDsDataGridView.Size = New System.Drawing.Size(846, 462)
        Me.QIDsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "QID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "QID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SubCategory"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SubCategory"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SortOrder"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SortOrder"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ChiefComplaint"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ChiefComplaint"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TemplateName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TemplateName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QIDsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(126, 35)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 3
        '
        'QIDTextBox
        '
        Me.QIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QIDsBindingSource, "QID", True))
        Me.QIDTextBox.Location = New System.Drawing.Point(126, 61)
        Me.QIDTextBox.Name = "QIDTextBox"
        Me.QIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QIDTextBox.TabIndex = 5
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QIDsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(126, 87)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescriptionTextBox.TabIndex = 7
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QIDsBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(126, 113)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoryTextBox.TabIndex = 9
        '
        'SubCategoryTextBox
        '
        Me.SubCategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QIDsBindingSource, "SubCategory", True))
        Me.SubCategoryTextBox.Location = New System.Drawing.Point(353, 35)
        Me.SubCategoryTextBox.Name = "SubCategoryTextBox"
        Me.SubCategoryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubCategoryTextBox.TabIndex = 11
        '
        'SortOrderTextBox
        '
        Me.SortOrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QIDsBindingSource, "SortOrder", True))
        Me.SortOrderTextBox.Location = New System.Drawing.Point(353, 61)
        Me.SortOrderTextBox.Name = "SortOrderTextBox"
        Me.SortOrderTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SortOrderTextBox.TabIndex = 13
        '
        'ChiefComplaintTextBox
        '
        Me.ChiefComplaintTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QIDsBindingSource, "ChiefComplaint", True))
        Me.ChiefComplaintTextBox.Location = New System.Drawing.Point(353, 87)
        Me.ChiefComplaintTextBox.Name = "ChiefComplaintTextBox"
        Me.ChiefComplaintTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ChiefComplaintTextBox.TabIndex = 15
        '
        'TemplateNameTextBox
        '
        Me.TemplateNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QIDsBindingSource, "TemplateName", True))
        Me.TemplateNameTextBox.Location = New System.Drawing.Point(353, 113)
        Me.TemplateNameTextBox.Name = "TemplateNameTextBox"
        Me.TemplateNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TemplateNameTextBox.TabIndex = 17
        '
        'SubCategoryTextBox1
        '
        Me.SubCategoryTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QIDsBindingSource, "SubCategory", True))
        Me.SubCategoryTextBox1.Location = New System.Drawing.Point(126, 139)
        Me.SubCategoryTextBox1.Name = "SubCategoryTextBox1"
        Me.SubCategoryTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.SubCategoryTextBox1.TabIndex = 19
        '
        'ProfileDetailData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 646)
        Me.Controls.Add(SubCategoryLabel1)
        Me.Controls.Add(Me.SubCategoryTextBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(QIDLabel)
        Me.Controls.Add(Me.QIDTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Me.SubCategoryTextBox)
        Me.Controls.Add(SortOrderLabel)
        Me.Controls.Add(Me.SortOrderTextBox)
        Me.Controls.Add(ChiefComplaintLabel)
        Me.Controls.Add(Me.ChiefComplaintTextBox)
        Me.Controls.Add(TemplateNameLabel)
        Me.Controls.Add(Me.TemplateNameTextBox)
        Me.Controls.Add(Me.QIDsDataGridView)
        Me.Controls.Add(Me.QIDsBindingNavigator)
        Me.Name = "ProfileDetailData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProfileDetailData"
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QIDsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QIDsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QIDsBindingNavigator.ResumeLayout(False)
        Me.QIDsBindingNavigator.PerformLayout()
        CType(Me.QIDsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents QIDsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QIDsTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.QIDsTableAdapter
    Friend WithEvents QIDsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents QIDsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QIDsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubCategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SortOrderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChiefComplaintTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TemplateNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubCategoryTextBox1 As System.Windows.Forms.TextBox
End Class
