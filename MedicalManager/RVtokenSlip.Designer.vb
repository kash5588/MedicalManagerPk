<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RVtokenSlip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TokenSlipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1()
        Me.MMPrecticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TokenSlipTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.TokenSlipTableAdapter()
        Me.MMPrecticeTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMPrecticeTableAdapter()
        Me.TokenSlipBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TokenSlipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMPrecticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokenSlipBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TokenSlipBindingSource
        '
        Me.TokenSlipBindingSource.DataMember = "TokenSlip"
        Me.TokenSlipBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMPrecticeBindingSource
        '
        Me.MMPrecticeBindingSource.DataMember = "MMPrectice"
        Me.MMPrecticeBindingSource.DataSource = Me.MMDataDataSet1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TokenSlipBindingSource
        ReportDataSource2.Name = "PracticeName"
        ReportDataSource2.Value = Me.MMPrecticeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.TokenSlip.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(387, 515)
        Me.ReportViewer1.TabIndex = 0
        '
        'TokenSlipTableAdapter
        '
        Me.TokenSlipTableAdapter.ClearBeforeFill = True
        '
        'MMPrecticeTableAdapter
        '
        Me.MMPrecticeTableAdapter.ClearBeforeFill = True
        '
        'TokenSlipBindingSource1
        '
        Me.TokenSlipBindingSource1.DataMember = "TokenSlip"
        Me.TokenSlipBindingSource1.DataSource = Me.MMDataDataSet1
        '
        'RVtokenSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 515)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.Name = "RVtokenSlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Token Receipt"
        CType(Me.TokenSlipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMPrecticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TokenSlipBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MMDataDataSet1 As MMDataDataSet1
    Friend WithEvents TokenSlipBindingSource As BindingSource
    Friend WithEvents TokenSlipTableAdapter As MMDataDataSet1TableAdapters.TokenSlipTableAdapter
    Friend WithEvents MMPrecticeBindingSource As BindingSource
    Friend WithEvents MMPrecticeTableAdapter As MMDataDataSet1TableAdapters.MMPrecticeTableAdapter
    Friend WithEvents TokenSlipBindingSource1 As BindingSource
End Class
