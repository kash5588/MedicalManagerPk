<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.Billing2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARDataSet = New MedicalManager.ARDataSet
        Me.BillingSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnPostToBilling = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblReqsExtracted = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtCaseNumber = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.btnViewReportByDate = New System.Windows.Forms.Button
        Me.cmdPatient = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtChartNumber = New System.Windows.Forms.TextBox
        Me.Button = New System.Windows.Forms.Button
        Me.btnPrOnly = New System.Windows.Forms.Button
        Me.BillinStatusByDate = New System.Windows.Forms.Button
        Me.btnUpdateBillingStatusByCase = New System.Windows.Forms.Button
        Me.MMDataDataSet2 = New MedicalManager.MMDataDataSet2
        Me.UpdateBillingStatusByDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdateBillingStatusByDateTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.UpdateBillingStatusByDateTableAdapter
        Me.UpdateBillingStatusByCaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdateBillingStatusByCaseTableAdapter = New MedicalManager.MMDataDataSet2TableAdapters.UpdateBillingStatusByCaseTableAdapter
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.BillingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingTableAdapter = New MedicalManager.ARDataSetTableAdapters.BillingTableAdapter
        Me.Billing2TableAdapter = New MedicalManager.ARDataSetTableAdapters.Billing2TableAdapter
        Me.BillingSummaryTableAdapter = New MedicalManager.ARDataSetTableAdapters.BillingSummaryTableAdapter
        CType(Me.Billing2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateBillingStatusByDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateBillingStatusByCaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Billing2BindingSource
        '
        Me.Billing2BindingSource.DataMember = "Billing2"
        Me.Billing2BindingSource.DataSource = Me.ARDataSet
        '
        'ARDataSet
        '
        Me.ARDataSet.DataSetName = "ARDataSet"
        Me.ARDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillingSummaryBindingSource
        '
        Me.BillingSummaryBindingSource.DataMember = "BillingSummary"
        Me.BillingSummaryBindingSource.DataSource = Me.ARDataSet
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ARDataSet_Billing2"
        ReportDataSource1.Value = Me.Billing2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.BillingInfo2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1021, 159)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(81, 339)
        Me.ReportViewer1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(137, 112)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(137, 92)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Date To:"
        '
        'btnPostToBilling
        '
        Me.btnPostToBilling.Location = New System.Drawing.Point(125, 559)
        Me.btnPostToBilling.Name = "btnPostToBilling"
        Me.btnPostToBilling.Size = New System.Drawing.Size(22, 20)
        Me.btnPostToBilling.TabIndex = 8
        Me.btnPostToBilling.Text = "View Billing Report"
        Me.btnPostToBilling.UseVisualStyleBackColor = True
        Me.btnPostToBilling.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Date From:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblReqsExtracted)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtCaseNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.btnViewReportByDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdPatient)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtChartNumber)
        Me.GroupBox1.Controls.Add(Me.Button)
        Me.GroupBox1.Controls.Add(Me.btnPrOnly)
        Me.GroupBox1.Controls.Add(Me.BillinStatusByDate)
        Me.GroupBox1.Controls.Add(Me.btnPostToBilling)
        Me.GroupBox1.Controls.Add(Me.btnUpdateBillingStatusByCase)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 670)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!)
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(34, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 28)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Chart Number"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!)
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(34, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(277, 28)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Case Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReqsExtracted
        '
        Me.lblReqsExtracted.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReqsExtracted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReqsExtracted.Font = New System.Drawing.Font("Mongolian Baiti", 18.0!)
        Me.lblReqsExtracted.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblReqsExtracted.Location = New System.Drawing.Point(34, 49)
        Me.lblReqsExtracted.Name = "lblReqsExtracted"
        Me.lblReqsExtracted.Size = New System.Drawing.Size(277, 28)
        Me.lblReqsExtracted.TabIndex = 40
        Me.lblReqsExtracted.Text = "Date Range"
        Me.lblReqsExtracted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Button3.Location = New System.Drawing.Point(171, 430)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 21)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "View Billing Report Condensed"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtCaseNumber
        '
        Me.txtCaseNumber.Location = New System.Drawing.Point(137, 251)
        Me.txtCaseNumber.Name = "txtCaseNumber"
        Me.txtCaseNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCaseNumber.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Button4.Location = New System.Drawing.Point(6, 430)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 21)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "View Billing Report Expanded"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnViewReportByDate
        '
        Me.btnViewReportByDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewReportByDate.Location = New System.Drawing.Point(7, 142)
        Me.btnViewReportByDate.Name = "btnViewReportByDate"
        Me.btnViewReportByDate.Size = New System.Drawing.Size(159, 21)
        Me.btnViewReportByDate.TabIndex = 20
        Me.btnViewReportByDate.Text = "View Billing Report Expanded"
        Me.btnViewReportByDate.UseVisualStyleBackColor = True
        '
        'cmdPatient
        '
        Me.cmdPatient.Location = New System.Drawing.Point(236, 395)
        Me.cmdPatient.Name = "cmdPatient"
        Me.cmdPatient.Size = New System.Drawing.Size(48, 23)
        Me.cmdPatient.TabIndex = 26
        Me.cmdPatient.Text = "Select Patient"
        Me.cmdPatient.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Case:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(171, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 21)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "View Billing Report Condensed"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Button1.Location = New System.Drawing.Point(6, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 21)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "View Billing Report Expanded"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtChartNumber
        '
        Me.txtChartNumber.Location = New System.Drawing.Point(137, 397)
        Me.txtChartNumber.Name = "txtChartNumber"
        Me.txtChartNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtChartNumber.TabIndex = 24
        '
        'Button
        '
        Me.Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Button.Location = New System.Drawing.Point(171, 282)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(159, 21)
        Me.Button.TabIndex = 21
        Me.Button.Text = "View Billing Report Condensed"
        Me.Button.UseVisualStyleBackColor = True
        '
        'btnPrOnly
        '
        Me.btnPrOnly.Location = New System.Drawing.Point(125, 578)
        Me.btnPrOnly.Name = "btnPrOnly"
        Me.btnPrOnly.Size = New System.Drawing.Size(22, 20)
        Me.btnPrOnly.TabIndex = 17
        Me.btnPrOnly.Text = "View Billing Report(Pr)"
        Me.btnPrOnly.UseVisualStyleBackColor = True
        Me.btnPrOnly.Visible = False
        '
        'BillinStatusByDate
        '
        Me.BillinStatusByDate.Location = New System.Drawing.Point(39, 559)
        Me.BillinStatusByDate.Name = "BillinStatusByDate"
        Me.BillinStatusByDate.Size = New System.Drawing.Size(59, 20)
        Me.BillinStatusByDate.TabIndex = 16
        Me.BillinStatusByDate.Text = "Update Billing Status By Date"
        Me.BillinStatusByDate.UseVisualStyleBackColor = True
        Me.BillinStatusByDate.Visible = False
        '
        'btnUpdateBillingStatusByCase
        '
        Me.btnUpdateBillingStatusByCase.Location = New System.Drawing.Point(39, 579)
        Me.btnUpdateBillingStatusByCase.Name = "btnUpdateBillingStatusByCase"
        Me.btnUpdateBillingStatusByCase.Size = New System.Drawing.Size(59, 20)
        Me.btnUpdateBillingStatusByCase.TabIndex = 15
        Me.btnUpdateBillingStatusByCase.Text = "Update Billing Status By Case #"
        Me.btnUpdateBillingStatusByCase.UseVisualStyleBackColor = True
        Me.btnUpdateBillingStatusByCase.Visible = False
        '
        'MMDataDataSet2
        '
        Me.MMDataDataSet2.DataSetName = "MMDataDataSet2"
        Me.MMDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UpdateBillingStatusByDateBindingSource
        '
        Me.UpdateBillingStatusByDateBindingSource.DataMember = "UpdateBillingStatusByDate"
        Me.UpdateBillingStatusByDateBindingSource.DataSource = Me.MMDataDataSet2
        '
        'UpdateBillingStatusByDateTableAdapter
        '
        Me.UpdateBillingStatusByDateTableAdapter.ClearBeforeFill = True
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
        'ReportViewer2
        '
        Me.ReportViewer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource2.Name = "ARDataSet_BillingSummary"
        ReportDataSource2.Value = Me.BillingSummaryBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "MedicalManager.BillingSummary.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(346, 12)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(940, 660)
        Me.ReportViewer2.TabIndex = 12
        '
        'BillingBindingSource
        '
        Me.BillingBindingSource.DataMember = "Billing"
        Me.BillingBindingSource.DataSource = Me.ARDataSet
        '
        'BillingTableAdapter
        '
        Me.BillingTableAdapter.ClearBeforeFill = True
        '
        'Billing2TableAdapter
        '
        Me.Billing2TableAdapter.ClearBeforeFill = True
        '
        'BillingSummaryTableAdapter
        '
        Me.BillingSummaryTableAdapter.ClearBeforeFill = True
        '
        'BillingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 684)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "BillingReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Billing2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MMDataDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateBillingStatusByDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateBillingStatusByCaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BillingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARDataSet As MedicalManager.ARDataSet
    Friend WithEvents BillingTableAdapter As MedicalManager.ARDataSetTableAdapters.BillingTableAdapter
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPostToBilling As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MMDataDataSet2 As MedicalManager.MMDataDataSet2
    Friend WithEvents UpdateBillingStatusByDateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UpdateBillingStatusByDateTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.UpdateBillingStatusByDateTableAdapter
    Friend WithEvents UpdateBillingStatusByCaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UpdateBillingStatusByCaseTableAdapter As MedicalManager.MMDataDataSet2TableAdapters.UpdateBillingStatusByCaseTableAdapter
    Friend WithEvents btnUpdateBillingStatusByCase As System.Windows.Forms.Button
    Friend WithEvents txtCaseNumber As System.Windows.Forms.TextBox
    Friend WithEvents BillinStatusByDate As System.Windows.Forms.Button
    Friend WithEvents Billing2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Billing2TableAdapter As MedicalManager.ARDataSetTableAdapters.Billing2TableAdapter
    Friend WithEvents btnPrOnly As System.Windows.Forms.Button
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BillingSummaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillingSummaryTableAdapter As MedicalManager.ARDataSetTableAdapters.BillingSummaryTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnViewReportByDate As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button As System.Windows.Forms.Button
    Friend WithEvents txtChartNumber As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmdPatient As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblReqsExtracted As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
