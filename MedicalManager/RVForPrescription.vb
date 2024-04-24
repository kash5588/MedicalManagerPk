Public Class RVForPrescription
    Dim ID As Integer
    Private Sub RVForPrescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PrescriptionWritingTableAdapter.FillByRxId(Me.MMDataDataSet1.PrescriptionWriting, ID)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub ShowPrescriptions(ByVal ID1 As Integer) ' As String()
        ID = ID1
        Me.Show()
    End Sub
End Class