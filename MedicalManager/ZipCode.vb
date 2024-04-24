Public Class ZipCode

    Private Sub ZipCodeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZipCodeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ZipCodeBindingSource.EndEdit()
        Me.ZipCodeTableAdapter.Update(Me.MMDataDataSet2.ZipCode)

    End Sub

    Private Sub ZipCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.ZipCode' table. You can move, or remove it, as needed.
        Me.ZipCodeTableAdapter.Fill(Me.MMDataDataSet2.ZipCode)

    End Sub
End Class