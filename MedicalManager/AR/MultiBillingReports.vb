Public Class MultiBillingReports


    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text <> "" Then

            Select Case cmbFilter.Text
                Case "DiagnosisCode"
                    Me.MultiPurposeBillingReportNewBindingSource.Filter = ("Dx1" & " like " & "'" & txtFind.Text & "%' or Dx2" & " like " & "'" & txtFind.Text & "%' or Dx3" & " like " & "'" & txtFind.Text & "%' or Dx4" & " like " & "'" & txtFind.Text & "%'")

                Case Else
                    Me.MultiPurposeBillingReportNewBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"

            End Select

        End If
        Me.MultiPurposeBillingReportNewBindingSource.Sort = "ChartNumber"
        MultiPurposeBillingReportNewDataGridView.DataSource = Me.MultiPurposeBillingReportNewBindingSource
    End Sub
 
    Private Sub btnFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFill.Click
        Try
            Me.MultiPurposeBillingReportNewTableAdapter.FillByDateBetween(Me.ARDataSet.MultiPurposeBillingReportNew, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class