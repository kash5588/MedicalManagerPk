Imports System.text

Public Class ExportHL7

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mydocpath As String = "C:\HL7.txt"
        Dim sb As New StringBuilder()

        sb.Append("ST*837*0001")
        sb.Append("~")
        sb.Append("BHT*0019*00*0123*")
        sb.Append(Format(Date.Now, "yyyyMMdd") & "*")
        sb.Append(Format(Date.Now, "HHmm") & "*")
        sb.Append("RP")
        sb.Append("~")
        sb.Append("REF*87*004010X098D")
        sb.Append("~")
        sb.Append("NM1*41*2*REHMAN BILLING SERVICE")

        Using outfile As New IO.StreamWriter(mydocpath)
            outfile.Write(sb.ToString())
        End Using
    End Sub

    Private Sub FillByChAndCaseToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByChAndCaseToolStripButton.Click
        Try
            Me.ExportHl7dtTableAdapter.FillByChAndCase(Me.ARDataSet.ExportHl7dt, New System.Nullable(Of Integer)(CType(Param2ToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class