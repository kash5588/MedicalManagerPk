Public Class VisitsList
    Private Sub MMChartVisitBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MMChartVisitBindingSource.EndEdit()
        Me.MMChartVisitTableAdapter.Update(Me.MMDataDataSet1.MMChartVisit)

    End Sub

    Private Sub VisitsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMChartVisit' table. You can move, or remove it, as needed.
        Me.MMChartVisitTableAdapter.Fill(Me.MMDataDataSet1.MMChartVisit)

    End Sub

    Private Sub MMChartVisitDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles MMChartVisitDataGridView.SelectionChanged
        Try
            If MMChartVisitDataGridView.SelectedRows.Count Then



                ChartNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("ChartNumber").Value
                txtName.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("FirstName").Value & " " & Me.MMChartVisitDataGridView.SelectedRows(0).Cells("LastName").Value
                txtCaseNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("CaseNumber").Value & ""
                TBTokenNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("TokenNo").Value & ""
                TBPhysicianName.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("PhysicianName").Value & ""
                'LoadPicture()
            End If
            If MMChartVisitDataGridView.SelectedRows.Count = 0 Then
                clearTextBox()
            End If




        Catch
        End Try
    End Sub

    Private Sub clearTextBox()
        ChartNo.Text = ""
        txtName.Text = ""
        TBTokenNo.Text = ""
        TBPhysicianName.Text = ""
        txtCaseNo.Text = ""
    End Sub
End Class