Public Class MMDRUGMaintenance

    Private Sub MMDRUGMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbFilter.SelectedIndex = 0
            Me.MMDRUGTableAdapter.FillBy(Me.MMDataDataSet1.MMDRUG)
            Me.MMPrecticeTableAdapter.Fill(Me.MMDataDataSet1.MMPrectice)
            LoadPhysicianCode()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Param1ToolStripTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Param1ToolStripTextBox.KeyUp
        Try
            Me.MMDRUGTableAdapter.FillByName(Me.MMDataDataSet1.MMDRUG, Param1ToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function LoadPhysicianCode()

        Dim dr As DataRow
        Dim dt As DataTable
        Dim PhyCode As String
        Try
            dt = Me.MMDataDataSet1.Tables("MMPrectice")

            For Each dr In dt.Rows
                If dr("Extra1") <> "" Then
                    MyRxComboBox.Items.Add(dr("Extra1"))
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Sub MMDRUGBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMDRUGBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMDRUGBindingSource.EndEdit()
        Me.MMDRUGTableAdapter.Update(Me.MMDataDataSet1.MMDRUG)
    End Sub
End Class