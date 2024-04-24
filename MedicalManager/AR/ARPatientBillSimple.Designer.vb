<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARPatientBillSimple
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.BillingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARDataSet = New MedicalManager.ARDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.BillingTableAdapter = New MedicalManager.ARDataSetTableAdapters.BillingTableAdapter
        Me.chkUpdateBillingStatus = New System.Windows.Forms.CheckBox
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.UpdateBillingStatusByCaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdateBillingStatusByCaseTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.UpdateBillingStatusByCaseTableAdapter
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateBillingStatusByCaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BillingBindingSource
        '
        Me.BillingBindingSource.DataMember = "Billing"
        Me.BillingBindingSource.DataSource = Me.ARDataSet
        '
        'ARDataSet
        '
        Me.ARDataSet.DataSetName = "ARDataSet"
        Me.ARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ARDataSet_Billing"
        ReportDataSource1.Value = Me.BillingBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.PatientBillSimple.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 22)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(617, 570)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomPercent = 90
        '
        'BillingTableAdapter
        '
        Me.BillingTableAdapter.ClearBeforeFill = True
        '
        'chkUpdateBillingStatus
        '
        Me.chkUpdateBillingStatus.AutoSize = True
        Me.chkUpdateBillingStatus.Checked = True
        Me.chkUpdateBillingStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUpdateBillingStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUpdateBillingStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.chkUpdateBillingStatus.Location = New System.Drawing.Point(2, 3)
        Me.chkUpdateBillingStatus.Name = "chkUpdateBillingStatus"
        Me.chkUpdateBillingStatus.Size = New System.Drawing.Size(195, 17)
        Me.chkUpdateBillingStatus.TabIndex = 2
        Me.chkUpdateBillingStatus.Text = "Update Billing Status On Print"
        Me.chkUpdateBillingStatus.UseVisualStyleBackColor = True
        '
        'MMDataDataSet2
        '
        Me.MMDataDataSet2.DataSetName = "MMDataDataSet2"
        Me.MMDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UpdateBillingStatusByCaseBindingSource
        '
        Me.UpdateBillingStatusByCaseBindingSource.DataMember = "UpdateBillingStatusByCase"
        Me.UpdateBillingStatusByCaseBindingSource.DataSource = Me.MMDataDataSet2
        '
        'UpdateBillingStatusByCaseTableAdapter
        '
        Me.UpdateBillingStatusByCaseTableAdapter.ClearBeforeFill = True
        '
        'ARPatientBillSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 593)
        Me.Controls.Add(Me.chkUpdateBillingStatus)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ARPatientBillSimple"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARPatientBillSimple"
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateBillingStatusByCaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BillingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARDataSet As MedicalManager.ARDataSet
    Friend WithEvents BillingTableAdapter As MedicalManager.ARDataSetTableAdapters.BillingTableAdapter
    Friend WithEvents chkUpdateBillingStatus As System.Windows.Forms.CheckBox
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents UpdateBillingStatusByCaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UpdateBillingStatusByCaseTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.UpdateBillingStatusByCaseTableAdapter
End Class
