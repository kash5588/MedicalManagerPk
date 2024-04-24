<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RVforMultiplePrescriptions
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
        Me.PrescriptionWritingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.PrescriptionWritingTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.PrescriptionWritingTableAdapter
        CType(Me.PrescriptionWritingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrescriptionWritingBindingSource
        '
        Me.PrescriptionWritingBindingSource.DataMember = "PrescriptionWriting"
        Me.PrescriptionWritingBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "MMDataDataSet1_PrescriptionWriting"
        ReportDataSource1.Value = Me.PrescriptionWritingBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.MultiplePrescriptions.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(567, 511)
        Me.ReportViewer1.TabIndex = 0
        '
        'PrescriptionWritingTableAdapter
        '
        Me.PrescriptionWritingTableAdapter.ClearBeforeFill = True
        '
        'RVforMultiplePrescriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 511)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RVforMultiplePrescriptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RVforMultiplePrescriptions"
        CType(Me.PrescriptionWritingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PrescriptionWritingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents PrescriptionWritingTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.PrescriptionWritingTableAdapter
End Class
