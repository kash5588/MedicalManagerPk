Public Class RVtokenSlip
    Dim CaseNumber As String

    Private Sub RVtokenSlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMPrectice' table. You can move, or remove it, as needed.
        Me.MMPrecticeTableAdapter.Fill(Me.MMDataDataSet1.MMPrectice)
        Me.TokenSlipTableAdapter.FillCaseNo(Me.MMDataDataSet1.TokenSlip, CaseNumber)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub ShowReport(CaseNo As String) ' As String()

        CaseNumber = CaseNo
        Me.Show()
    End Sub
    Private Sub PrintReport()
        Try
            ' Assuming reportViewer1 is the name of your ReportViewer control
            Me.ReportViewer1.PrintDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred while printing: " & ex.Message)
        End Try
    End Sub

    Private Sub RVtokenSlip_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            PrintReport()
        End If
    End Sub
End Class