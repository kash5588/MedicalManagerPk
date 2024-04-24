Public Class ARPatientBillSimple

    Dim CaseNumberParameter As Integer
    Public Sub ReportShow(ByVal ChartNumber As String, ByVal CaseNumber As Integer)
        On Error Resume Next
        CaseNumberParameter = CaseNumber
        Me.BillingTableAdapter.FillBillByChNoCaseNo(Me.ARDataSet.Billing, ChartNumber, CaseNumber)
        Me.ReportViewer1.RefreshReport()
        Me.Show()
    End Sub

    Private Sub ReportViewer1_Print(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportViewer1.Print
        If chkUpdateBillingStatus.Checked = True Then
            Try
                Me.UpdateBillingStatusByCaseTableAdapter.Fill(Me.MMDataDataSet2.UpdateBillingStatusByCase, New System.Nullable(Of Integer)(CType(CaseNumberParameter, Integer)))
            Catch ex As System.Exception
                MessageBox.Show("Failed to update billing status for Case Number: " & CaseNumberParameter, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class