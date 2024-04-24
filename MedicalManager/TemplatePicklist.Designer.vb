<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplatePicklist
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
        Me.MMChiefComplaintsDataGridView = New System.Windows.Forms.DataGridView
        Me.MMChiefComplaintsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.lstChiefComplaint = New System.Windows.Forms.ListBox
        Me.MMChiefComplaintsTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.MMChiefComplaintsTableAdapter
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFind = New System.Windows.Forms.TextBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TemplateName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChiefComplaint = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.MMChiefComplaintsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChiefComplaintsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MMChiefComplaintsDataGridView
        '
        Me.MMChiefComplaintsDataGridView.AllowUserToAddRows = False
        Me.MMChiefComplaintsDataGridView.AllowUserToDeleteRows = False
        Me.MMChiefComplaintsDataGridView.AllowUserToResizeRows = False
        Me.MMChiefComplaintsDataGridView.AutoGenerateColumns = False
        Me.MMChiefComplaintsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.TemplateName, Me.ChiefComplaint})
        Me.MMChiefComplaintsDataGridView.DataSource = Me.MMChiefComplaintsBindingSource
        Me.MMChiefComplaintsDataGridView.Location = New System.Drawing.Point(2, 27)
        Me.MMChiefComplaintsDataGridView.Name = "MMChiefComplaintsDataGridView"
        Me.MMChiefComplaintsDataGridView.Size = New System.Drawing.Size(479, 432)
        Me.MMChiefComplaintsDataGridView.TabIndex = 0
        '
        'MMChiefComplaintsBindingSource
        '
        Me.MMChiefComplaintsBindingSource.DataMember = "MMChiefComplaints"
        Me.MMChiefComplaintsBindingSource.DataSource = Me.MMDataDataSet2
        '
        'MMDataDataSet2
        '
        Me.MMDataDataSet2.DataSetName = "MMDataDataSet2"
        Me.MMDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lstChiefComplaint
        '
        Me.lstChiefComplaint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.lstChiefComplaint.FormattingEnabled = True
        Me.lstChiefComplaint.Location = New System.Drawing.Point(266, 97)
        Me.lstChiefComplaint.MultiColumn = True
        Me.lstChiefComplaint.Name = "lstChiefComplaint"
        Me.lstChiefComplaint.Size = New System.Drawing.Size(10, 134)
        Me.lstChiefComplaint.TabIndex = 2
        Me.lstChiefComplaint.Visible = False
        '
        'MMChiefComplaintsTableAdapter
        '
        Me.MMChiefComplaintsTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "Find Chief Complaint:"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(109, 1)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(102, 20)
        Me.txtFind.TabIndex = 156
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'TemplateName
        '
        Me.TemplateName.DataPropertyName = "TemplateName"
        Me.TemplateName.HeaderText = "TemplateName"
        Me.TemplateName.Name = "TemplateName"
        Me.TemplateName.Width = 275
        '
        'ChiefComplaint
        '
        Me.ChiefComplaint.DataPropertyName = "ChiefComplaint"
        Me.ChiefComplaint.HeaderText = "ChiefComplaint"
        Me.ChiefComplaint.Name = "ChiefComplaint"
        '
        'TemplatePicklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 460)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.MMChiefComplaintsDataGridView)
        Me.Controls.Add(Me.lstChiefComplaint)
        Me.Name = "TemplatePicklist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Template Picklist"
        CType(Me.MMChiefComplaintsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChiefComplaintsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents MMChiefComplaintsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChiefComplaintsTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.MMChiefComplaintsTableAdapter
    Friend WithEvents MMChiefComplaintsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents lstChiefComplaint As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TemplateName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChiefComplaint As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
