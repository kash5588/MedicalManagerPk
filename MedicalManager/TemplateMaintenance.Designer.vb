<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemplateMaintenance
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim TemplateNameLabel As System.Windows.Forms.Label
        Dim ChiefComplaintLabel As System.Windows.Forms.Label
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim TemplateNameLabel1 As System.Windows.Forms.Label
        Me.MMChiefComplaintsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMChiefComplaintsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.TemplateNameTextBox = New System.Windows.Forms.TextBox
        Me.ChiefComplaintTextBox = New System.Windows.Forms.TextBox
        Me.DprofilesDataSet = New MedicalManager.DprofilesDataSet
        Me.CCProfilesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CCProfilesTableAdapter = New MedicalManager.DprofilesDataSetTableAdapters.CCProfilesTableAdapter
        Me.IDTextBox1 = New System.Windows.Forms.TextBox
        Me.TemplateNameTextBox1 = New System.Windows.Forms.TextBox
        Me.CCProfilesDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvCCTemplateName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MMChiefComplaintsTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.MMChiefComplaintsTableAdapter
        Me.btnAddTemplate = New System.Windows.Forms.Button
        Me.btnAddChiefComplaint = New System.Windows.Forms.Button
        Me.btnTemplateSave = New System.Windows.Forms.Button
        Me.btnSaveCC = New System.Windows.Forms.Button
        IDLabel = New System.Windows.Forms.Label
        TemplateNameLabel = New System.Windows.Forms.Label
        ChiefComplaintLabel = New System.Windows.Forms.Label
        IDLabel1 = New System.Windows.Forms.Label
        TemplateNameLabel1 = New System.Windows.Forms.Label
        CType(Me.MMChiefComplaintsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChiefComplaintsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DprofilesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCProfilesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCProfilesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(427, 295)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'TemplateNameLabel
        '
        TemplateNameLabel.AutoSize = True
        TemplateNameLabel.Location = New System.Drawing.Point(427, 321)
        TemplateNameLabel.Name = "TemplateNameLabel"
        TemplateNameLabel.Size = New System.Drawing.Size(85, 13)
        TemplateNameLabel.TabIndex = 4
        TemplateNameLabel.Text = "Template Name:"
        '
        'ChiefComplaintLabel
        '
        ChiefComplaintLabel.AutoSize = True
        ChiefComplaintLabel.Location = New System.Drawing.Point(427, 347)
        ChiefComplaintLabel.Name = "ChiefComplaintLabel"
        ChiefComplaintLabel.Size = New System.Drawing.Size(83, 13)
        ChiefComplaintLabel.TabIndex = 6
        ChiefComplaintLabel.Text = "Chief Complaint:"
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Location = New System.Drawing.Point(438, 72)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.Size = New System.Drawing.Size(21, 13)
        IDLabel1.TabIndex = 8
        IDLabel1.Text = "ID:"
        '
        'TemplateNameLabel1
        '
        TemplateNameLabel1.AutoSize = True
        TemplateNameLabel1.Location = New System.Drawing.Point(438, 98)
        TemplateNameLabel1.Name = "TemplateNameLabel1"
        TemplateNameLabel1.Size = New System.Drawing.Size(85, 13)
        TemplateNameLabel1.TabIndex = 10
        TemplateNameLabel1.Text = "Template Name:"
        '
        'MMChiefComplaintsDataGridView
        '
        Me.MMChiefComplaintsDataGridView.AllowUserToAddRows = False
        Me.MMChiefComplaintsDataGridView.AutoGenerateColumns = False
        Me.MMChiefComplaintsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.MMChiefComplaintsDataGridView.DataSource = Me.MMChiefComplaintsBindingSource
        Me.MMChiefComplaintsDataGridView.Location = New System.Drawing.Point(12, 238)
        Me.MMChiefComplaintsDataGridView.Name = "MMChiefComplaintsDataGridView"
        Me.MMChiefComplaintsDataGridView.Size = New System.Drawing.Size(393, 215)
        Me.MMChiefComplaintsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TemplateName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TemplateName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ChiefComplaint"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ChiefComplaint"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChiefComplaintsBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(518, 292)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(277, 20)
        Me.IDTextBox.TabIndex = 3
        '
        'TemplateNameTextBox
        '
        Me.TemplateNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChiefComplaintsBindingSource, "TemplateName", True))
        Me.TemplateNameTextBox.Location = New System.Drawing.Point(518, 318)
        Me.TemplateNameTextBox.Name = "TemplateNameTextBox"
        Me.TemplateNameTextBox.Size = New System.Drawing.Size(277, 20)
        Me.TemplateNameTextBox.TabIndex = 5
        '
        'ChiefComplaintTextBox
        '
        Me.ChiefComplaintTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MMChiefComplaintsBindingSource, "ChiefComplaint", True))
        Me.ChiefComplaintTextBox.Location = New System.Drawing.Point(518, 344)
        Me.ChiefComplaintTextBox.Name = "ChiefComplaintTextBox"
        Me.ChiefComplaintTextBox.Size = New System.Drawing.Size(277, 20)
        Me.ChiefComplaintTextBox.TabIndex = 7
        '
        'DprofilesDataSet
        '
        Me.DprofilesDataSet.DataSetName = "DprofilesDataSet"
        Me.DprofilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CCProfilesBindingSource
        '
        Me.CCProfilesBindingSource.DataMember = "CCProfiles"
        Me.CCProfilesBindingSource.DataSource = Me.DprofilesDataSet
        '
        'CCProfilesTableAdapter
        '
        Me.CCProfilesTableAdapter.ClearBeforeFill = True
        '
        'IDTextBox1
        '
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CCProfilesBindingSource, "ID", True))
        Me.IDTextBox1.Enabled = False
        Me.IDTextBox1.Location = New System.Drawing.Point(529, 69)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(266, 20)
        Me.IDTextBox1.TabIndex = 9
        '
        'TemplateNameTextBox1
        '
        Me.TemplateNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CCProfilesBindingSource, "TemplateName", True))
        Me.TemplateNameTextBox1.Location = New System.Drawing.Point(529, 95)
        Me.TemplateNameTextBox1.Name = "TemplateNameTextBox1"
        Me.TemplateNameTextBox1.Size = New System.Drawing.Size(266, 20)
        Me.TemplateNameTextBox1.TabIndex = 11
        '
        'CCProfilesDataGridView
        '
        Me.CCProfilesDataGridView.AllowUserToAddRows = False
        Me.CCProfilesDataGridView.AutoGenerateColumns = False
        Me.CCProfilesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.dgvCCTemplateName, Me.DataGridViewTextBoxColumn5})
        Me.CCProfilesDataGridView.DataSource = Me.CCProfilesBindingSource
        Me.CCProfilesDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.CCProfilesDataGridView.Name = "CCProfilesDataGridView"
        Me.CCProfilesDataGridView.Size = New System.Drawing.Size(393, 213)
        Me.CCProfilesDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 30
        '
        'dgvCCTemplateName
        '
        Me.dgvCCTemplateName.DataPropertyName = "TemplateName"
        Me.dgvCCTemplateName.HeaderText = "TemplateName"
        Me.dgvCCTemplateName.Name = "dgvCCTemplateName"
        Me.dgvCCTemplateName.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CHIEF_COMPLAINT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CHIEF_COMPLAINT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'MMChiefComplaintsTableAdapter
        '
        Me.MMChiefComplaintsTableAdapter.ClearBeforeFill = True
        '
        'btnAddTemplate
        '
        Me.btnAddTemplate.Location = New System.Drawing.Point(529, 43)
        Me.btnAddTemplate.Name = "btnAddTemplate"
        Me.btnAddTemplate.Size = New System.Drawing.Size(147, 20)
        Me.btnAddTemplate.TabIndex = 13
        Me.btnAddTemplate.Text = "Add New Template Name"
        Me.btnAddTemplate.UseVisualStyleBackColor = True
        '
        'btnAddChiefComplaint
        '
        Me.btnAddChiefComplaint.Location = New System.Drawing.Point(518, 266)
        Me.btnAddChiefComplaint.Name = "btnAddChiefComplaint"
        Me.btnAddChiefComplaint.Size = New System.Drawing.Size(158, 20)
        Me.btnAddChiefComplaint.TabIndex = 14
        Me.btnAddChiefComplaint.Text = "Add New Chief Complaint"
        Me.btnAddChiefComplaint.UseVisualStyleBackColor = True
        '
        'btnTemplateSave
        '
        Me.btnTemplateSave.Location = New System.Drawing.Point(682, 43)
        Me.btnTemplateSave.Name = "btnTemplateSave"
        Me.btnTemplateSave.Size = New System.Drawing.Size(63, 21)
        Me.btnTemplateSave.TabIndex = 15
        Me.btnTemplateSave.Text = "Save"
        Me.btnTemplateSave.UseVisualStyleBackColor = True
        '
        'btnSaveCC
        '
        Me.btnSaveCC.Location = New System.Drawing.Point(682, 266)
        Me.btnSaveCC.Name = "btnSaveCC"
        Me.btnSaveCC.Size = New System.Drawing.Size(63, 21)
        Me.btnSaveCC.TabIndex = 16
        Me.btnSaveCC.Text = "Save"
        Me.btnSaveCC.UseVisualStyleBackColor = True
        '
        'TemplateMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 473)
        Me.Controls.Add(Me.btnSaveCC)
        Me.Controls.Add(Me.btnTemplateSave)
        Me.Controls.Add(Me.btnAddChiefComplaint)
        Me.Controls.Add(Me.btnAddTemplate)
        Me.Controls.Add(Me.CCProfilesDataGridView)
        Me.Controls.Add(TemplateNameLabel1)
        Me.Controls.Add(Me.TemplateNameTextBox1)
        Me.Controls.Add(IDLabel1)
        Me.Controls.Add(Me.IDTextBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(TemplateNameLabel)
        Me.Controls.Add(Me.TemplateNameTextBox)
        Me.Controls.Add(ChiefComplaintLabel)
        Me.Controls.Add(Me.ChiefComplaintTextBox)
        Me.Controls.Add(Me.MMChiefComplaintsDataGridView)
        Me.Name = "TemplateMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Template Maintenance"
        CType(Me.MMChiefComplaintsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChiefComplaintsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DprofilesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCProfilesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCProfilesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents MMChiefComplaintsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChiefComplaintsTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.MMChiefComplaintsTableAdapter
    Friend WithEvents MMChiefComplaintsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TemplateNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChiefComplaintTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DprofilesDataSet As MedicalManager.DprofilesDataSet
    Friend WithEvents CCProfilesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CCProfilesTableAdapter As MedicalManager.DprofilesDataSetTableAdapters.CCProfilesTableAdapter
    Friend WithEvents IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TemplateNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CCProfilesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCCTemplateName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddTemplate As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAddChiefComplaint As System.Windows.Forms.Button
    Friend WithEvents btnTemplateSave As System.Windows.Forms.Button
    Friend WithEvents btnSaveCC As System.Windows.Forms.Button
End Class
