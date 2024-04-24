Public Class RV
    Dim ChNo, Dt, strCaseNumber, strstrReportType As String

    Private Sub RV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        'Me.VisitreportTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.VisitReport, strCaseNumber)
        'Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChNo, Dt)
        'If strstrReportType = "visit" Then
        '    Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, ChNo, Dt)
        'Else
        '    Me.MMChartRxTableAdapter.FillByChartAndActive(Me.MMDataDataSet1.MMChartRx, ChNo)
        'End If

        'Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, ChNo, Dt)
        'Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)

        'Me.ReportViewer1.LocalReport.EnableExternalImages = True
        'Me.ReportViewer1.RefreshReport()

        Dim strValue As String
        strValue = GetGeneralInfo("DefaultVisitReport")

        If strValue = "VisitReport1" Then
            radVisit1.Checked = True
            LoadVisitReport1()
        ElseIf strValue = "VisitReport2" Then
            radVisit2.Checked = True
            LoadVisitReport2()
        ElseIf strValue = "VisitReport3" Then
            radVisit3.Checked = True
            LoadVisitReport3()
        Else
            LoadVisitReport1()
        End If


    End Sub

    Public Sub ShowVisit(ByVal ChNumber As String, ByVal dtService As String, ByVal casenumber As String, ByVal strReportType As String) ' As String()
        ChNo = ""
        ChNo = ChNumber
        Dt = ""
        Dt = dtService
        strCaseNumber = casenumber
        strstrReportType = strReportType
        Me.Show()
    End Sub

    Private Sub radVisit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radVisit1.CheckedChanged
        LoadVisitReport1()
    End Sub

    Private Sub radVisit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radVisit2.CheckedChanged
        LoadVisitReport2()
    End Sub

    Private Function LoadVisitReport1()

        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewer.VisitReport.rdlc"


        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource

        ReportDataSource1.Name = "MMDataDataSet1_VisitReport"
        ReportDataSource1.Value = Me.VisitReportBindingSource
        ReportDataSource2.Name = "MMDataDataSet1_MMChartRx"
        ReportDataSource2.Value = Me.MMChartRxBindingSource
        ReportDataSource3.Name = "MMDataDataSet1_MMCHDxRxLtMt"
        ReportDataSource3.Value = Me.MMCHDxRxLtMtBindingSource
        ReportDataSource4.Name = "MMDataDataSet1_MMChartTVitalSign"
        ReportDataSource4.Value = Me.MMChartTVitalSignBindingSource
        ReportDataSource5.Name = "MMDataDataSet1_VisitReportPractice"
        ReportDataSource5.Value = Me.VisitReportPracticeBindingSource

        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.VisitReport.rdlc"
        Me.ReportViewer1.Name = "ReportViewer1"
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
        'MMChartRxBindingSource
        '
        Me.MMChartRxBindingSource.DataMember = "MMChartRx"
        Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMChartRxTableAdapter
        '
        Me.MMChartRxTableAdapter.ClearBeforeFill = True
        '
        'MMCHDxRxLtMtBindingSource
        '
        Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
        Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMCHDxRxLtMtTableAdapter
        '
        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
        '
        'MMChartTVitalSignBindingSource
        '
        Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
        Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMChartTVitalSignTableAdapter
        '
        Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Me.VisitreportTableAdapter.FillByCHAndDate(Me.MMDataDataSet1.VisitReport, ChNo, Dt)
        Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChNo, Dt)
        If strstrReportType = "visit" Then
            Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, ChNo, Dt)
        Else
            Me.MMChartRxTableAdapter.FillByChartAndActive(Me.MMDataDataSet1.MMChartRx, ChNo)
        End If
        Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, ChNo, Dt)
        Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)

        Me.ReportViewer1.RefreshReport()

    End Function

    Private Function LoadVisitReport2()






        If radVisit2.Checked = True Then
            ReportViewer1.Reset()
            ReportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewer.VisitReport.rdlc"

            Dim params(0) As Microsoft.Reporting.WinForms.ReportParameter
            params(0) = New Microsoft.Reporting.WinForms.ReportParameter("UserParam", globalUser.ToString)


            Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
            Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
            Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
            Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
            Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource

            ReportDataSource1.Name = "MMDataDataSet1_VisitReport"
            ReportDataSource1.Value = Me.VisitReportBindingSource
            ReportDataSource2.Name = "MMDataDataSet1_MMChartRx"
            ReportDataSource2.Value = Me.MMChartRxBindingSource
            ReportDataSource3.Name = "MMDataDataSet1_MMCHDxRxLtMt"
            ReportDataSource3.Value = Me.MMCHDxRxLtMtBindingSource
            ReportDataSource4.Name = "MMDataDataSet1_MMChartTVitalSign"
            ReportDataSource4.Value = Me.MMChartTVitalSignBindingSource
            ReportDataSource5.Name = "MMDataDataSet1_VisitReportPractice"
            ReportDataSource5.Value = Me.VisitReportPracticeBindingSource

            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)

            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.VisitReport2.rdlc"
            Me.ReportViewer1.Name = "ReportViewer1"
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
            'MMChartRxBindingSource
            '
            Me.MMChartRxBindingSource.DataMember = "MMChartRx"
            Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
            '
            'MMChartRxTableAdapter
            '
            Me.MMChartRxTableAdapter.ClearBeforeFill = True
            '
            'MMCHDxRxLtMtBindingSource
            '
            Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
            Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
            '
            'MMCHDxRxLtMtTableAdapter
            '
            Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
            '
            'MMChartTVitalSignBindingSource
            '
            Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
            Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
            '
            'MMChartTVitalSignTableAdapter
            '
            Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True

            Me.ReportViewer1.LocalReport.EnableExternalImages = True

            Me.VisitreportTableAdapter.FillByCHAndDate(Me.MMDataDataSet1.VisitReport, ChNo, Dt)
            Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChNo, Dt)
            If strstrReportType = "visit" Then
                Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, ChNo, Dt)
            Else
                Me.MMChartRxTableAdapter.FillByChartAndActive(Me.MMDataDataSet1.MMChartRx, ChNo)
            End If
            Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, ChNo, Dt)
            Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)

            ReportViewer1.LocalReport.SetParameters(params)


            Me.ReportViewer1.RefreshReport()

        End If
    End Function

    Private Sub radVisit3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radVisit3.CheckedChanged
        LoadVisitReport3()
    End Sub

    Private Function LoadVisitReport3()
        ReportViewer1.Reset()
        ReportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewer.VisitReportTemplate2.rdlc"


        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource

        ReportDataSource1.Name = "MMDataDataSet1_VisitReport"
        ReportDataSource1.Value = Me.VisitReportBindingSource
        ReportDataSource2.Name = "MMDataDataSet1_MMChartRx"
        ReportDataSource2.Value = Me.MMChartRxBindingSource
        ReportDataSource3.Name = "MMDataDataSet1_MMCHDxRxLtMt"
        ReportDataSource3.Value = Me.MMCHDxRxLtMtBindingSource
        ReportDataSource4.Name = "MMDataDataSet1_MMChartTVitalSign"
        ReportDataSource4.Value = Me.MMChartTVitalSignBindingSource
        ReportDataSource5.Name = "MMDataDataSet1_VisitReportPractice"
        ReportDataSource5.Value = Me.VisitReportPracticeBindingSource

        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)

        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager.VisitReportTemplate2.rdlc"
        Me.ReportViewer1.Name = "ReportViewer1"
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
        'MMChartRxBindingSource
        '
        Me.MMChartRxBindingSource.DataMember = "MMChartRx"
        Me.MMChartRxBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMChartRxTableAdapter
        '
        Me.MMChartRxTableAdapter.ClearBeforeFill = True
        '
        'MMCHDxRxLtMtBindingSource
        '
        Me.MMCHDxRxLtMtBindingSource.DataMember = "MMCHDxRxLtMt"
        Me.MMCHDxRxLtMtBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMCHDxRxLtMtTableAdapter
        '
        Me.MMCHDxRxLtMtTableAdapter.ClearBeforeFill = True
        '
        'MMChartTVitalSignBindingSource
        '
        Me.MMChartTVitalSignBindingSource.DataMember = "MMChartTVitalSign"
        Me.MMChartTVitalSignBindingSource.DataSource = Me.MMDataDataSet1
        '
        'MMChartTVitalSignTableAdapter
        '
        Me.MMChartTVitalSignTableAdapter.ClearBeforeFill = True

        Me.ReportViewer1.LocalReport.EnableExternalImages = True

        Me.VisitreportTableAdapter.FillByCHAndDate(Me.MMDataDataSet1.VisitReport, ChNo, Dt)
        Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChNo, Dt)
        If strstrReportType = "visit" Then
            Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, ChNo, Dt)
        Else
            Me.MMChartRxTableAdapter.FillByChartAndActive(Me.MMDataDataSet1.MMChartRx, ChNo)
        End If
        Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, ChNo, Dt)
        Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)

        Me.ReportViewer1.RefreshReport()

    End Function
End Class