<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabReports
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
            Me.HL7ReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.MMDataDataSet = New MedicalManager.MMDataDataSet
            Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
            Me.HL7ReportsTableAdapter = New MedicalManager.MMDataDataSetTableAdapters.HL7ReportsTableAdapter
            CType(Me.HL7ReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MMDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'HL7ReportsBindingSource
            '
            Me.HL7ReportsBindingSource.DataMember = "HL7Reports"
            Me.HL7ReportsBindingSource.DataSource = Me.MMDataDataSet
            '
            'MMDataDataSet
            '
            Me.MMDataDataSet.DataSetName = "MMDataDataSet"
            Me.MMDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'ReportViewer1
            '
            ReportDataSource1.Name = "MMDataDataSet_HL7Reports"
            ReportDataSource1.Value = Me.HL7ReportsBindingSource
            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.PatientReport.rdlc"
            Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
            Me.ReportViewer1.Name = "ReportViewer1"
            Me.ReportViewer1.Size = New System.Drawing.Size(844, 738)
            Me.ReportViewer1.TabIndex = 0
            '
            'HL7ReportsTableAdapter
            '
            Me.HL7ReportsTableAdapter.ClearBeforeFill = True
            '
            'LabReports
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(862, 762)
            Me.Controls.Add(Me.ReportViewer1)
            Me.Location = New System.Drawing.Point(205, 85)
            Me.Name = "LabReports"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Lab Reports"
            CType(Me.HL7ReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MMDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

      End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents HL7ReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet As MedicalManager.MMDataDataSet
    Friend WithEvents HL7ReportsTableAdapter As MedicalManager.MMDataDataSetTableAdapters.HL7ReportsTableAdapter
End Class
