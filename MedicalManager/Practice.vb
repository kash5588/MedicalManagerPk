Public Class Practice

    Private Sub MMPrecticeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMPrecticeBindingNavigatorSaveItem.Click
            Try
                  Me.Validate()
                  Me.MMPrecticeBindingSource.EndEdit()
                  Me.MMPrecticeTableAdapter.Update(Me.MMDataDataSet1.MMPrectice)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub Practice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMPrectice' table. You can move, or remove it, as needed.
        Me.MMPrecticeTableAdapter.Fill(Me.MMDataDataSet1.MMPrectice)

    End Sub

      Private Sub IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDTextBox.TextChanged

      End Sub

    Private Sub Extra2Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class