Public Class ImmunizationMaintenance

    Private Sub MMImmunizationBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMImmunizationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMImmunizationBindingSource.EndEdit()
        Me.MMImmunizationTableAdapter.Update(Me.MMDataDataSet2.MMImmunization)

    End Sub

    Private Sub ImmunizationMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.MMImmunization' table. You can move, or remove it, as needed.
        Me.MMImmunizationTableAdapter.Fill(Me.MMDataDataSet2.MMImmunization)

    End Sub
End Class