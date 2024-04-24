<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Immunization
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
        Dim ChartNumberLabel As System.Windows.Forms.Label
        Dim ImmunizationLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Immunization))
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChartNumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.MMChartImmunizationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMChartImmunizationsTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.MMChartImmunizationsTableAdapter
        Me.MMChartImmunizationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MMChartImmunizationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.MMChartImmunizationsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ImmunizationComboBox = New System.Windows.Forms.ComboBox
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        IDLabel = New System.Windows.Forms.Label
        ChartNumberLabel = New System.Windows.Forms.Label
        ImmunizationLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartImmunizationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartImmunizationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MMChartImmunizationsBindingNavigator.SuspendLayout()
        CType(Me.MMChartImmunizationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(565, 106)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 3
        IDLabel.Text = "ID:"
        '
        'ChartNumberLabel
        '
        ChartNumberLabel.AutoSize = True
        ChartNumberLabel.Location = New System.Drawing.Point(511, 132)
        ChartNumberLabel.Name = "ChartNumberLabel"
        ChartNumberLabel.Size = New System.Drawing.Size(75, 13)
        ChartNumberLabel.TabIndex = 5
        ChartNumberLabel.Text = "Chart Number:"
        '
        'ImmunizationLabel
        '
        ImmunizationLabel.AutoSize = True
        ImmunizationLabel.Location = New System.Drawing.Point(515, 158)
        ImmunizationLabel.Name = "ImmunizationLabel"
        ImmunizationLabel.Size = New System.Drawing.Size(71, 13)
        ImmunizationLabel.TabIndex = 7
        ImmunizationLabel.Text = "Immunization:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(553, 81)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 9
        DateLabel.Text = "Date:"
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'ChartNumber
        '
        Me.ChartNumber.DataPropertyName = "ChartNumber"
        Me.ChartNumber.HeaderText = "ChartNumber"
        Me.ChartNumber.Name = "ChartNumber"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Immunization"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Immunization"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ChartNumber"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Immunization"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Immunization"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'MMDataDataSet2
        '
        Me.MMDataDataSet2.DataSetName = "MMDataDataSet2"
        Me.MMDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMChartImmunizationsBindingSource
        '
        Me.MMChartImmunizationsBindingSource.DataMember = "MMChartImmunizations"
        Me.MMChartImmunizationsBindingSource.DataSource = Me.MMDataDataSet2
        '
        'MMChartImmunizationsTableAdapter
        '
        Me.MMChartImmunizationsTableAdapter.ClearBeforeFill = True
        '
        'MMChartImmunizationsBindingNavigator
        '
        Me.MMChartImmunizationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MMChartImmunizationsBindingNavigator.BindingSource = Me.MMChartImmunizationsBindingSource
        Me.MMChartImmunizationsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MMChartImmunizationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MMChartImmunizationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripLabel2, Me.BindingNavigatorDeleteItem, Me.ToolStripLabel1, Me.MMChartImmunizationsBindingNavigatorSaveItem})
        Me.MMChartImmunizationsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MMChartImmunizationsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MMChartImmunizationsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MMChartImmunizationsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MMChartImmunizationsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MMChartImmunizationsBindingNavigator.Name = "MMChartImmunizationsBindingNavigator"
        Me.MMChartImmunizationsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MMChartImmunizationsBindingNavigator.Size = New System.Drawing.Size(764, 25)
        Me.MMChartImmunizationsBindingNavigator.TabIndex = 0
        Me.MMChartImmunizationsBindingNavigator.Text = "BindingNavigator1"
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
        'MMChartImmunizationsBindingNavigatorSaveItem
        '
        Me.MMChartImmunizationsBindingNavigatorSaveItem.Image = CType(resources.GetObject("MMChartImmunizationsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MMChartImmunizationsBindingNavigatorSaveItem.Name = "MMChartImmunizationsBindingNavigatorSaveItem"
        Me.MMChartImmunizationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.MMChartImmunizationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MMChartImmunizationsDataGridView
        '
        Me.MMChartImmunizationsDataGridView.AllowUserToAddRows = False
        Me.MMChartImmunizationsDataGridView.AllowUserToResizeRows = False
        Me.MMChartImmunizationsDataGridView.AutoGenerateColumns = False
        Me.MMChartImmunizationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.MMChartImmunizationsDataGridView.DataSource = Me.MMChartImmunizationsBindingSource
        Me.MMChartImmunizationsDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.MMChartImmunizationsDataGridView.Name = "MMChartImmunizationsDataGridView"
        Me.MMChartImmunizationsDataGridView.Size = New System.Drawing.Size(493, 422)
        Me.MMChartImmunizationsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ChartNumber"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Chart Number"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Immunization"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Immunization"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 250
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartImmunizationsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(592, 103)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(91, 20)
        Me.IDTextBox.TabIndex = 4
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartImmunizationsBindingSource, "ChartNumber", True))
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(592, 129)
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(91, 20)
        Me.ChartNumberTextBox.TabIndex = 6
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MMChartImmunizationsBindingSource, "Date", True))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(592, 77)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(91, 20)
        Me.DateDateTimePicker.TabIndex = 10
        '
        'ImmunizationComboBox
        '
        Me.ImmunizationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChartImmunizationsBindingSource, "Immunization", True))
        Me.ImmunizationComboBox.FormattingEnabled = True
        Me.ImmunizationComboBox.ItemHeight = 13
        Me.ImmunizationComboBox.Location = New System.Drawing.Point(592, 155)
        Me.ImmunizationComboBox.MaxDropDownItems = 25
        Me.ImmunizationComboBox.Name = "ImmunizationComboBox"
        Me.ImmunizationComboBox.Size = New System.Drawing.Size(155, 21)
        Me.ImmunizationComboBox.TabIndex = 11
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
        'Immunization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 448)
        Me.Controls.Add(Me.ImmunizationComboBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(ChartNumberLabel)
        Me.Controls.Add(Me.ChartNumberTextBox)
        Me.Controls.Add(ImmunizationLabel)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.MMChartImmunizationsDataGridView)
        Me.Controls.Add(Me.MMChartImmunizationsBindingNavigator)
        Me.Name = "Immunization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Immunization"
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartImmunizationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartImmunizationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MMChartImmunizationsBindingNavigator.ResumeLayout(False)
        Me.MMChartImmunizationsBindingNavigator.PerformLayout()
        CType(Me.MMChartImmunizationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChartNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents MMChartImmunizationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartImmunizationsTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.MMChartImmunizationsTableAdapter
    Friend WithEvents MMChartImmunizationsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MMChartImmunizationsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MMChartImmunizationsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImmunizationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
