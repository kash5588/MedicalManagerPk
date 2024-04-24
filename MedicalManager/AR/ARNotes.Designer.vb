<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARNotes
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
        Dim EntryNoARNotesLabel As System.Windows.Forms.Label
        Dim CaseNumberLabel As System.Windows.Forms.Label
        Dim ChartNumberLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ARNotes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MMARNotesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MMARNotesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Param1ToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.Param1ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FillDataByCaseNumberToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.EntryNoARNotesTextBox = New System.Windows.Forms.TextBox
        Me.CaseNumberTextBox = New System.Windows.Forms.TextBox
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox
        Me.NotesTextBox = New System.Windows.Forms.TextBox
        Me.MMARNotesDataGridView = New System.Windows.Forms.DataGridView
        Me.btnComments = New System.Windows.Forms.Button
        Me.MMARNotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARDataSet = New MedicalManager.ARDataSet
        Me.MMARNotesTableAdapter = New MedicalManager.ARDataSetTableAdapters.MMARNotesTableAdapter
        Me.EntryNoARNotes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateEntered = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        EntryNoARNotesLabel = New System.Windows.Forms.Label
        CaseNumberLabel = New System.Windows.Forms.Label
        ChartNumberLabel = New System.Windows.Forms.Label
        NotesLabel = New System.Windows.Forms.Label
        CType(Me.MMARNotesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMARNotesBindingNavigator.SuspendLayout()
        CType(Me.MMARNotesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMARNotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EntryNoARNotesLabel
        '
        EntryNoARNotesLabel.AutoSize = True
        EntryNoARNotesLabel.Location = New System.Drawing.Point(58, 39)
        EntryNoARNotesLabel.Name = "EntryNoARNotesLabel"
        EntryNoARNotesLabel.Size = New System.Drawing.Size(51, 13)
        EntryNoARNotesLabel.TabIndex = 2
        EntryNoARNotesLabel.Text = "Entry No:"
        '
        'CaseNumberLabel
        '
        CaseNumberLabel.AutoSize = True
        CaseNumberLabel.Enabled = False
        CaseNumberLabel.Location = New System.Drawing.Point(221, 39)
        CaseNumberLabel.Name = "CaseNumberLabel"
        CaseNumberLabel.Size = New System.Drawing.Size(74, 13)
        CaseNumberLabel.TabIndex = 4
        CaseNumberLabel.Text = "Case Number:"
        '
        'ChartNumberLabel
        '
        ChartNumberLabel.AutoSize = True
        ChartNumberLabel.Enabled = False
        ChartNumberLabel.Location = New System.Drawing.Point(407, 39)
        ChartNumberLabel.Name = "ChartNumberLabel"
        ChartNumberLabel.Size = New System.Drawing.Size(75, 13)
        ChartNumberLabel.TabIndex = 6
        ChartNumberLabel.Text = "Chart Number:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(-3, 61)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 13)
        NotesLabel.TabIndex = 8
        NotesLabel.Text = "Notes:"
        '
        'MMARNotesBindingNavigator
        '
        Me.MMARNotesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMARNotesBindingNavigator.BindingSource = Me.MMARNotesBindingSource
        Me.MMARNotesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMARNotesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMARNotesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MMARNotesBindingNavigatorSaveItem, Me.Param1ToolStripLabel, Me.Param1ToolStripTextBox, Me.FillDataByCaseNumberToolStripButton})
        Me.MMARNotesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMARNotesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMARNotesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMARNotesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMARNotesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMARNotesBindingNavigator.Name = "MMARNotesBindingNavigator"
        Me.MMARNotesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMARNotesBindingNavigator.Size = New System.Drawing.Size(785, 25)
        Me.MMARNotesBindingNavigator.TabIndex = 0
        Me.MMARNotesBindingNavigator.Text = "BindingNavigator1"
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
        'MMARNotesBindingNavigatorSaveItem
        '
        Me.MMARNotesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MMARNotesBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMARNotesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMARNotesBindingNavigatorSaveItem.Name = "MMARNotesBindingNavigatorSaveItem"
        Me.MMARNotesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MMARNotesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Param1ToolStripLabel
        '
        Me.Param1ToolStripLabel.Name = "Param1ToolStripLabel"
        Me.Param1ToolStripLabel.Size = New System.Drawing.Size(75, 22)
        Me.Param1ToolStripLabel.Text = "Case Number:"
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        Me.Param1ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillDataByCaseNumberToolStripButton
        '
        Me.FillDataByCaseNumberToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillDataByCaseNumberToolStripButton.Name = "FillDataByCaseNumberToolStripButton"
        Me.FillDataByCaseNumberToolStripButton.Size = New System.Drawing.Size(107, 22)
        Me.FillDataByCaseNumberToolStripButton.Text = "Fill Data By Case No"
        '
        'EntryNoARNotesTextBox
        '
        Me.EntryNoARNotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMARNotesBindingSource, "EntryNoARNotes", True))
        Me.EntryNoARNotesTextBox.Enabled = False
        Me.EntryNoARNotesTextBox.Location = New System.Drawing.Point(115, 35)
        Me.EntryNoARNotesTextBox.Name = "EntryNoARNotesTextBox"
        Me.EntryNoARNotesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EntryNoARNotesTextBox.TabIndex = 3
        '
        'CaseNumberTextBox
        '
        Me.CaseNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMARNotesBindingSource, "CaseNumber", True))
        Me.CaseNumberTextBox.Location = New System.Drawing.Point(301, 35)
        Me.CaseNumberTextBox.Name = "CaseNumberTextBox"
        Me.CaseNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CaseNumberTextBox.TabIndex = 5
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMARNotesBindingSource, "ChartNumber", True))
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(498, 35)
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ChartNumberTextBox.TabIndex = 7
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMARNotesBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(0, 77)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(786, 76)
        Me.NotesTextBox.TabIndex = 9
        '
        'MMARNotesDataGridView
        '
        Me.MMARNotesDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MMARNotesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MMARNotesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EntryNoARNotes, Me.DateEntered, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.MMARNotesDataGridView.DataSource = Me.MMARNotesBindingSource
        Me.MMARNotesDataGridView.Location = New System.Drawing.Point(0, 159)
        Me.MMARNotesDataGridView.Name = "MMARNotesDataGridView"
        Me.MMARNotesDataGridView.Size = New System.Drawing.Size(786, 401)
        Me.MMARNotesDataGridView.TabIndex = 10
        '
        'btnComments
        '
        Me.btnComments.Location = New System.Drawing.Point(651, 34)
        Me.btnComments.Name = "btnComments"
        Me.btnComments.Size = New System.Drawing.Size(94, 23)
        Me.btnComments.TabIndex = 11
        Me.btnComments.Text = "Pick Comments"
        Me.btnComments.UseVisualStyleBackColor = True
        '
        'MMARNotesBindingSource
        '
        Me.MMARNotesBindingSource.DataMember = "MMARNotes"
        Me.MMARNotesBindingSource.DataSource = Me.ARDataSet
        '
        'ARDataSet
        '
        Me.ARDataSet.DataSetName = "ARDataSet"
        Me.ARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMARNotesTableAdapter
        '
        Me.MMARNotesTableAdapter.ClearBeforeFill = True
        '
        'EntryNoARNotes
        '
        Me.EntryNoARNotes.DataPropertyName = "EntryNoARNotes"
        Me.EntryNoARNotes.HeaderText = "EntryNoARNotes"
        Me.EntryNoARNotes.Name = "EntryNoARNotes"
        Me.EntryNoARNotes.ReadOnly = True
        Me.EntryNoARNotes.Visible = False
        Me.EntryNoARNotes.Width = 5
        '
        'DateEntered
        '
        Me.DateEntered.DataPropertyName = "DateEntered"
        Me.DateEntered.HeaderText = "Date Entered"
        Me.DateEntered.Name = "DateEntered"
        Me.DateEntered.Width = 77
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CaseNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Case No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Chart No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 545
        '
        'ARNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 562)
        Me.Controls.Add(Me.btnComments)
        Me.Controls.Add(Me.MMARNotesDataGridView)
        Me.Controls.Add(EntryNoARNotesLabel)
        Me.Controls.Add(Me.EntryNoARNotesTextBox)
        Me.Controls.Add(CaseNumberLabel)
        Me.Controls.Add(Me.CaseNumberTextBox)
        Me.Controls.Add(ChartNumberLabel)
        Me.Controls.Add(Me.ChartNumberTextBox)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.MMARNotesBindingNavigator)
        Me.Name = "ARNotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARNotes"
        CType(Me.MMARNotesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMARNotesBindingNavigator.ResumeLayout(False)
        Me.MMARNotesBindingNavigator.PerformLayout()
        CType(Me.MMARNotesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMARNotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ARDataSet As MedicalManager.ARDataSet
    Friend WithEvents MMARNotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMARNotesTableAdapter As MedicalManager.ARDataSetTableAdapters.MMARNotesTableAdapter
    Friend WithEvents MMARNotesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMARNotesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EntryNoARNotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CaseNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MMARNotesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Param1ToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Param1ToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillDataByCaseNumberToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnComments As System.Windows.Forms.Button
    Friend WithEvents EntryNoARNotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateEntered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
