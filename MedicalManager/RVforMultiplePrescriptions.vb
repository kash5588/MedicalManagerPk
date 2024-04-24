Public Class RVforMultiplePrescriptions
    Dim ChartNumber As String
    Dim DateOfPrescription As String
    Dim strstrRxIdList As String

    'Private Sub RVforMultiplePrescriptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'TODO: This line of code loads data into the 'MMDataDataSet1.PrescriptionWriting' table. You can move, or remove it, as needed.
    '    Me.PrescriptionWritingTableAdapter.FillByChartAndDate(Me.MMDataDataSet1.PrescriptionWriting, ChartNumber, DateOfPrescription)
    '    Me.ReportViewer1.RefreshReport()
    'End Sub

    Private Sub RVforMultiplePrescriptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.PrescriptionWriting' table. You can move, or remove it, as needed.
        Me.PrescriptionWritingTableAdapter.FillByTagIDs(Me.MMDataDataSet1.PrescriptionWriting, strstrRxIdList)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    'Public Sub ShowMultiplePrescriptions(ByVal strChartNumber As String, ByVal strDate As String)
    '    ChartNumber = strChartNumber
    '    DateOfPrescription = strDate
    '    Me.Show()
    'End Sub

    Public Sub ShowMultiplePrescriptions(ByVal strRxIdList As String)
        strstrRxIdList = strRxIdList
        Me.Show()
    End Sub

  
End Class