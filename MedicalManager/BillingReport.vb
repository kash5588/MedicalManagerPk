Public Class BillingReport
    Dim ChNo, Dt As String
    Dim aRetChart(1) As String

    Private Sub btnPostToBilling_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPostToBilling.Click

        On Error Resume Next
        Me.Billing2TableAdapter.FillBy1(Me.ARDataSet.Billing2, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnUpdateBillingStatusByCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateBillingStatusByCase.Click
        Try
            If txtCaseNumber.Text <> "" Then
                Me.UpdateBillingStatusByCaseTableAdapter.Fill(Me.MMDataDataSet2.UpdateBillingStatusByCase, New System.Nullable(Of Integer)(CType(txtCaseNumber.Text, Integer)))
            Else
                MessageBox.Show("Please specify Case # to update billing status by Case.", "Specify Case Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BillinStatusByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillinStatusByDate.Click
        Try
            Me.UpdateBillingStatusByDateTableAdapter.Fill(Me.MMDataDataSet2.UpdateBillingStatusByDate, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BillingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub btnPrOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrOnly.Click
        On Error Resume Next
        Me.Billing2TableAdapter.FillByPr(Me.ARDataSet.Billing2, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.BillingSummaryTableAdapter.FillbyCase(Me.ARDataSet.BillingSummary, txtCaseNumber.Text)
        'Me.ReportViewer2.RefreshReport()



        ReportViewer2.Reset()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource1.Name = "ARDataSet_BillingSummary"
        ReportDataSource1.Value = Me.BillingSummaryBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.DisplayName = "View Chart"
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "MedicalManager." & "BillingSummary.rdlc"
        Me.BillingSummaryBindingSource.DataMember = "BillingSummary"
        Me.BillingSummaryBindingSource.DataSource = Me.ARDataSet
        Me.BillingSummaryTableAdapter.FillbyCase(Me.ARDataSet.BillingSummary, txtCaseNumber.Text)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub btnViewReportByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReportByDate.Click
        'Me.BillingSummaryTableAdapter.FillByDate(Me.ARDataSet.BillingSummary, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)))
        'Me.ReportViewer2.RefreshReport()






        ReportViewer2.Reset()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource1.Name = "ARDataSet_BillingSummary"
        ReportDataSource1.Value = Me.BillingSummaryBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.DisplayName = "View Chart"
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "MedicalManager." & "BillingSummary.rdlc"
        Me.BillingSummaryBindingSource.DataMember = "BillingSummary"
        Me.BillingSummaryBindingSource.DataSource = Me.ARDataSet
        Me.BillingSummaryTableAdapter.FillByDate(Me.ARDataSet.BillingSummary, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)))
        Me.ReportViewer2.RefreshReport()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ReportViewer2.Reset()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource1.Name = "ARDataSet_BillingSummary"
        ReportDataSource1.Value = Me.BillingSummaryBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.DisplayName = "View Chart"
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "MedicalManager." & "BillingSummaryCondensed.rdlc"
        Me.BillingSummaryBindingSource.DataMember = "BillingSummary"
        Me.BillingSummaryBindingSource.DataSource = Me.ARDataSet
        Me.BillingSummaryTableAdapter.FillByDate(Me.ARDataSet.BillingSummary, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)))
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button.Click
        ReportViewer2.Reset()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource1.Name = "ARDataSet_BillingSummary"
        ReportDataSource1.Value = Me.BillingSummaryBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.DisplayName = "View Chart"
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "MedicalManager." & "BillingSummaryCondensed.rdlc"
        Me.BillingSummaryBindingSource.DataMember = "BillingSummary"
        Me.BillingSummaryBindingSource.DataSource = Me.ARDataSet
        Me.BillingSummaryTableAdapter.FillbyCase(Me.ARDataSet.BillingSummary, txtCaseNumber.Text)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ReportViewer2.Reset()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource1.Name = "ARDataSet_BillingSummary"
        ReportDataSource1.Value = Me.BillingSummaryBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.DisplayName = "View Chart"
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "MedicalManager." & "BillingSummary.rdlc"
        Me.BillingSummaryBindingSource.DataMember = "BillingSummary"
        Me.BillingSummaryBindingSource.DataSource = Me.ARDataSet
        Me.BillingSummaryTableAdapter.FillByChartNumber(Me.ARDataSet.BillingSummary, txtChartNumber.Text)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ReportViewer2.Reset()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource1.Name = "ARDataSet_BillingSummary"
        ReportDataSource1.Value = Me.BillingSummaryBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.DisplayName = "View Chart"
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "MedicalManager." & "BillingSummaryCondensed.rdlc"
        Me.BillingSummaryBindingSource.DataMember = "BillingSummary"
        Me.BillingSummaryBindingSource.DataSource = Me.ARDataSet
        Me.BillingSummaryTableAdapter.FillByChartNumber(Me.ARDataSet.BillingSummary, txtChartNumber.Text)
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        Dim FrmProcedure As New Procedure
        aRetChart = PATIENT.ShowPicklist
        If aRetChart(0) = "Y" Then       ' they picked a lab
            txtChartNumber.Text = aRetChart(1)
        End If
    End Sub

  
End Class

