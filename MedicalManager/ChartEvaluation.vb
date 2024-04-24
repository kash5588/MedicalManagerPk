Imports System.text
Public Class ChartEvaluation

    Private Sub MMChartEvaluationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartEvaluationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMChartEvaluationBindingSource.EndEdit()
        Me.MMChartEvaluationTableAdapter.Update(Me.MMDataDataSet2.MMChartEvaluation)

    End Sub

    Private Sub ChartEvaluation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.MMChartEvaluation' table. You can move, or remove it, as needed.
        Me.MMChartEvaluationTableAdapter.Fill(Me.MMDataDataSet2.MMChartEvaluation)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim sb As New StringBuilder()
        Dim i As Integer
        Dim db As DBAccess = New DBAccess
        Dim ds As New DataSet


        For i = 0 To MMChartEvaluationDataGridView.Rows.Count - 1
            sb.Append(txtSelect.Text + " " + Me.MMChartEvaluationDataGridView.Rows(i).Cells("QWhere").Value)
            If i <> MMChartEvaluationDataGridView.Rows.Count - 1 Then
                sb.Append(vbCrLf)
                sb.Append(" Union ")
                sb.Append(vbCrLf)
            End If
        Next
        MessageBox.Show(sb.ToString)
        TextBox1.Text = sb.ToString

        ds = db.ExecuteDataSet2(sb.ToString)

        DataGridView1.DataSource = ds.Tables(0)

        DataGridView1.Refresh()
    End Sub
End Class