Public Class RVforSuperBill
    Dim ChNo, Dt, strCaseNumber As String

    Private Sub RVforSuperBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.VisitreportTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.VisitReport, strCaseNumber)
        Me.ReportViewer1.RefreshReport()
     
    End Sub

    Public Sub ShowVisit(ByVal ChNumber As String, ByVal dtService As String, ByVal casenumber As String) ' As String()
        ChNo = ""
        ChNo = ChNumber
        Dt = ""
        Dt = dtService
        strCaseNumber = casenumber
        Me.Show()
    End Sub
End Class