<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RVforSuperBill
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.VisitReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitreportTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.VisitreportTableAdapter
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.SuperBill.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 32)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowToolBar = False
        Me.ReportViewer1.Size = New System.Drawing.Size(672, 426)
        Me.ReportViewer1.TabIndex = 0
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisitReportBindingSource
        '
        Me.VisitReportBindingSource.DataMember = "VisitReport"
        Me.VisitReportBindingSource.DataSource = Me.MMDataDataSet1
        '
        'VisitreportTableAdapter
        '
        Me.VisitreportTableAdapter.ClearBeforeFill = True
        '
        'RVforSuperBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 459)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RVforSuperBill"
        Me.Text = "RVforSuperBill"
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents VisitReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VisitreportTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.VisitreportTableAdapter
End Class
