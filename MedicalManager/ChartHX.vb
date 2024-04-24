Public Class ChartHX

    Private Sub MMChartHxBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartHxBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMChartHxBindingSource.EndEdit()
        Me.MMChartHxTableAdapter.Update(Me.MMDataDataSet1.MMChartHx)

    End Sub

    Private Sub ChartHX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMChartHx' table. You can move, or remove it, as needed.
        Me.MMChartHxTableAdapter.Fill(Me.MMDataDataSet1.MMChartHx)

    End Sub
End Class