Public Class RosGeneral


    Private Sub MMCHRosAndGenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MMCHRosAndGenBindingSource.EndEdit()
        Me.MMCHRosAndGenTableAdapter.Update(Me.MMDataDataSet.MMCHRosAndGen)

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.MMCHRosAndGenTableAdapter.Fill(Me.MMDataDataSet.MMCHRosAndGen, CategoryToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GradientNavigationButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton4.Click
        Me.MMCHRosAndGenTableAdapter.Fill(Me.MMDataDataSet.MMCHRosAndGen, "ROS-HEENT")
    End Sub
End Class