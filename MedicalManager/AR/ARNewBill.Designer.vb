<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARNewBill
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.NewBillingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARDataSet = New MedicalManager.ARDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.chkUpdateBillingStatus = New System.Windows.Forms.CheckBox
        Me.NewBillingTableAdapter = New MedicalManager.ARDataSetTableAdapters.NewBillingTableAdapter
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.UpdateBillingStatusByCaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdateBillingStatusByCaseTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.UpdateBillingStatusByCaseTableAdapter
        CType(Me.NewBillingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateBillingStatusByCaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewBillingBindingSource
        '
        Me.NewBillingBindingSource.DataMember = "NewBilling"
        Me.NewBillingBindingSource.DataSource = Me.ARDataSet
        '
        'ARDataSet
        '
        Me.ARDataSet.DataSetName = "ARDataSet"
        Me.ARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ARDataSet_NewBilling"
        ReportDataSource1.Value = Me.NewBillingBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.PatientBillNew.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 25)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(617, 569)
        Me.ReportViewer1.TabIndex = 1
        Me.ReportViewer1.ZoomPercent = 90
        '
        'chkUpdateBillingStatus
        '
        Me.chkUpdateBillingStatus.AutoSize = True
        Me.chkUpdateBillingStatus.Checked = True
        Me.chkUpdateBillingStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUpdateBillingStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUpdateBillingStatus.ForeColor = System.Drawing.Color.DarkRed
        Me.chkUpdateBillingStatus.Location = New System.Drawing.Point(-1, 2)
        Me.chkUpdateBillingStatus.Name = "chkUpdateBillingStatus"
        Me.chkUpdateBillingStatus.Size = New System.Drawing.Size(195, 17)
        Me.chkUpdateBillingStatus.TabIndex = 3
        Me.chkUpdateBillingStatus.Text = "Update Billing Status On Print"
        Me.chkUpdateBillingStatus.UseVisualStyleBackColor = True
        '
        'NewBillingTableAdapter
        '
        Me.NewBillingTableAdapter.ClearBeforeFill = True
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
        'ARNewBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 593)
        Me.Controls.Add(Me.chkUpdateBillingStatus)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ARNewBill"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARNewBill"
        CType(Me.NewBillingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateBillingStatusByCaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents chkUpdateBillingStatus As System.Windows.Forms.CheckBox
    Friend WithEvents ARDataSet As MedicalManager.ARDataSet
    Friend WithEvents NewBillingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NewBillingTableAdapter As MedicalManager.ARDataSetTableAdapters.NewBillingTableAdapter
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents UpdateBillingStatusByCaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UpdateBillingStatusByCaseTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.UpdateBillingStatusByCaseTableAdapter
End Class
