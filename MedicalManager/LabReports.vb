Public Class LabReports

    Private Sub LabReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Try

                  'TODO: This line of code loads data into the 'MMDataDataSet.MMCHARTContents' table. You can move, or remove it, as needed.
                  ' Me.MMCHARTContentsTableAdapter.Fill(Me.MMDataDataSet.MMCHARTContents)
                  'TODO: This line of code loads data into the 'MMDataDataSet.HL7Reports' table. You can move, or remove it, as needed.
                  Me.HL7ReportsTableAdapter.FillExID(Me.MMDataDataSet.HL7Reports)

                  Me.ReportViewer1.RefreshReport()
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
      End Sub
End Class