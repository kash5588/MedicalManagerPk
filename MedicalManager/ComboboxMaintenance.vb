Public Class ComboboxMaintenance

    Private Sub MMComboBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMComboBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMComboBindingSource.EndEdit()
        Me.MMComboTableAdapter.Update(Me.MMDataDataSet1.MMCombo)

    End Sub

    Private Sub ComboboxMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMCombo' table. You can move, or remove it, as needed.
        Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)

    End Sub

    Private Sub MMComboBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMComboBindingSource.AddingNew
        'Dim i As Integer
        'Dim ii As Integer

        'ii = MMComboDataGridView.NewRowIndex

        'For i = 0 To MMComboDataGridView.ColumnCount - 1
        '    MMComboDataGridView.Rows(ii).Cells(i).Value = "N/A"
        'Next

        Me.MMDataDataSet1.MMCombo.MaritalStatusColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.RaceColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.EmploymentStatusColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.ReasonForNoCheckinColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.VisitTypeColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.WhoPaidColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.PaymentTypeColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.SignedByColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.AssignedToColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.StatusColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.MessageFromColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.MessageToColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.PatientTypeColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.FacilityColumn.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.MedCombo1Column.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.MedCombo2Column.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.MedCombo3Column.DefaultValue = "N/A"
        Me.MMDataDataSet1.MMCombo.MedCombo4Column.DefaultValue = "N/A"


    End Sub
End Class