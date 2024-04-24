Public Class ProfileDetailData

    Private Sub QIDsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QIDsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.QIDsBindingSource.EndEdit()
        Me.QIDsTableAdapter.Update(Me.MMDataDataSet2.QIDs)

    End Sub

    Private Sub ProfileDetailData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.QIDs' table. You can move, or remove it, as needed.
        Me.QIDsTableAdapter.Fill(Me.MMDataDataSet2.QIDs)

    End Sub
End Class