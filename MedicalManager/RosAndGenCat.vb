Public Class RosAndGenCat

    Private Sub MMCHROSandGenCatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MMCHROSandGenCatBindingSource.EndEdit()
        Me.MMCHROSandGenCatTableAdapter.Update(Me.MMDataDataSet1.MMCHROSandGenCat)

    End Sub

    Private Sub RosAndGenCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMCHROSandGenCat' table. You can move, or remove it, as needed.
        Me.MMCHROSandGenCatTableAdapter.Fill(Me.MMDataDataSet1.MMCHROSandGenCat)
        'TODO: This line of code loads data into the 'MMDataDataSet.MMCHROSandGenCat' table. You can move, or remove it, as needed.


    End Sub

    Private Sub MMCHROSandGenCatBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMCHROSandGenCatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMCHROSandGenCatBindingSource.EndEdit()
        Me.MMCHROSandGenCatTableAdapter.Update(Me.MMDataDataSet1.MMCHROSandGenCat)

    End Sub
End Class