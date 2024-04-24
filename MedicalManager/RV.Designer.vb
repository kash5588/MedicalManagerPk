<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RV
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
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.VisitReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMDataDataSet1 = New MedicalManager.MMDataDataSet1()
        Me.MMChartRxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMCHDxRxLtMtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MMChartTVitalSignBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitReportPracticeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ChartNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VisitreportTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.VisitreportTableAdapter()
        Me.MMChartRxTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartRxTableAdapter()
        Me.MMCHDxRxLtMtTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter()
        Me.MMChartTVitalSignTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter()
        Me.VisitReportPracticeTableAdapter = New MedicalManager.MMDataDataSet1TableAdapters.VisitReportPracticeTableAdapter()
        Me.radVisit1 = New System.Windows.Forms.RadioButton()
        Me.radVisit2 = New System.Windows.Forms.RadioButton()
        Me.radVisit3 = New System.Windows.Forms.RadioButton()
        CType(Me.VisitReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitReportPracticeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisitReportBindingSource
        '
        Me.VisitReportBindingSource.DataMember = "VisitReport"
        Me.VisitReportBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMDataDataSet1
        '
        Me.MMDataDataSet1.DataSetName = "MMDataDataSet1"
        Me.MMDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MMChartRxBindingSource
        '
        Me.MMChartRxBindingSource.DataMember = "MMChartRx"
        Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMCHDxRxLtMtBindingSource
        '
        Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
        Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMChartTVitalSignBindingSource
        '
        Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
        Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
        '
        'VisitReportPracticeBindingSource
        '
        Me.VisitReportPracticeBindingSource.DataMember = "VisitReportPractice"
        Me.VisitReportPracticeBindingSource.DataSource = Me.MMDataDataSet1
        '
        'DateMaskedTextBox
        '
        Me.DateMaskedTextBox.Location = New System.Drawing.Point(524, 85)
        Me.DateMaskedTextBox.Mask = "00/00/0000"
        Me.DateMaskedTextBox.Name = "DateMaskedTextBox"
        Me.DateMaskedTextBox.Size = New System.Drawing.Size(126, 20)
        Me.DateMaskedTextBox.TabIndex = 132
        Me.DateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'ChartNumberTextBox
        '
        Me.ChartNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChartNumberTextBox.Location = New System.Drawing.Point(379, 85)
        Me.ChartNumberTextBox.Name = "ChartNumberTextBox"
        Me.ChartNumberTextBox.Size = New System.Drawing.Size(82, 20)
        Me.ChartNumberTextBox.TabIndex = 131
        '
        'ReportViewer1
        '
        ReportDataSource6.Name = "MMDataDataSet1_VisitReport"
        ReportDataSource6.Value = Me.VisitReportBindingSource
        ReportDataSource7.Name = "MMDataDataSet1_MMChartRx"
        ReportDataSource7.Value = Me.MMChartRxBindingSource
        ReportDataSource8.Name = "MMDataDataSet1_MMCHDxRxLtMt"
        ReportDataSource8.Value = Me.MMCHDxRxLtMtBindingSource
        ReportDataSource9.Name = "MMDataDataSet1_MMChartTVitalSign"
        ReportDataSource9.Value = Me.MMChartTVitalSignBindingSource
        ReportDataSource10.Name = "MMDataDataSet1_VisitReportPractice"
        ReportDataSource10.Value = Me.VisitReportPracticeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.VisitReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(652, 664)
        Me.ReportViewer1.TabIndex = 133
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Chart Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(466, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Visit Date"
        '
        'VisitreportTableAdapter
        '
        Me.VisitreportTableAdapter.ClearBeforeFill = True
        '
        'MMChartRxTableAdapter
        '
        Me.MMChartRxTableAdapter.ClearBeforeFill = True
        '
        'MMCHDxRxLtMtTableAdapter
        '
        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
        '
        'MMChartTVitalSignTableAdapter
        '
        Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True
        '
        'VisitReportPracticeTableAdapter
        '
        Me.VisitReportPracticeTableAdapter.ClearBeforeFill = True
        '
        'radVisit1
        '
        Me.radVisit1.AutoSize = True
        Me.radVisit1.Location = New System.Drawing.Point(464, 1)
        Me.radVisit1.Name = "radVisit1"
        Me.radVisit1.Size = New System.Drawing.Size(88, 17)
        Me.radVisit1.TabIndex = 137
        Me.radVisit1.TabStop = True
        Me.radVisit1.Text = "Visit Report 1"
        Me.radVisit1.UseVisualStyleBackColor = True
        '
        'radVisit2
        '
        Me.radVisit2.AutoSize = True
        Me.radVisit2.Location = New System.Drawing.Point(560, 1)
        Me.radVisit2.Name = "radVisit2"
        Me.radVisit2.Size = New System.Drawing.Size(88, 17)
        Me.radVisit2.TabIndex = 138
        Me.radVisit2.TabStop = True
        Me.radVisit2.Text = "Visit Report 2"
        Me.radVisit2.UseVisualStyleBackColor = True
        '
        'radVisit3
        '
        Me.radVisit3.AutoSize = True
        Me.radVisit3.Location = New System.Drawing.Point(361, 1)
        Me.radVisit3.Name = "radVisit3"
        Me.radVisit3.Size = New System.Drawing.Size(88, 17)
        Me.radVisit3.TabIndex = 140
        Me.radVisit3.TabStop = True
        Me.radVisit3.Text = "Visit Report 3"
        Me.radVisit3.UseVisualStyleBackColor = True
        '
        'RV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 687)
        Me.Controls.Add(Me.radVisit3)
        Me.Controls.Add(Me.radVisit2)
        Me.Controls.Add(Me.radVisit1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateMaskedTextBox)
        Me.Controls.Add(Me.ChartNumberTextBox)
        Me.Location = New System.Drawing.Point(205, 85)
        Me.Name = "RV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Viewer"
        CType(Me.VisitReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMDataDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartRxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMCHDxRxLtMtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MMChartTVitalSignBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitReportPracticeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ChartNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VisitReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMDataDataSet1 As MedicalManager.MMDataDataSet1
    Friend WithEvents VisitreportTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.VisitreportTableAdapter
    Friend WithEvents MMChartRxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMCHDxRxLtMtBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartTVitalSignBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MMChartRxTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartRxTableAdapter
    Friend WithEvents MMCHDxRxLtMtTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMCHDxRxLtMtTableAdapter
    Friend WithEvents MMChartTVitalSignTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.MMChartTVitalSignTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VisitReportPracticeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VisitReportPracticeTableAdapter As MedicalManager.MMDataDataSet1TableAdapters.VisitReportPracticeTableAdapter
    Friend WithEvents radVisit1 As System.Windows.Forms.RadioButton
    Friend WithEvents radVisit2 As System.Windows.Forms.RadioButton
    Friend WithEvents radVisit3 As System.Windows.Forms.RadioButton
End Class
