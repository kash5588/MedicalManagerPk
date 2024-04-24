Public Class ChiefComplaint

    Private Sub ChiefComplaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMChartCC' table. You can move, or remove it, as needed.
        Me.MMChartCCTableAdapter.Fill(Me.MMDataDataSet1.MMChartCC)
    End Sub

    Private Sub MMChartCCBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartCCBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMChartCCBindingSource.EndEdit()
        Me.MMChartCCTableAdapter.Update(Me.MMDataDataSet1.MMChartCC)

    End Sub

    Private Sub ChiefComplaint_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.MMChartCCBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            If Me.MMDataDataSet1.MMChartCC.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.MMChartCCTableAdapter.Update(Me.MMDataDataSet1.MMChartCC)
                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.MMChartCC.RejectChanges()
                    Case Else
                        e.Cancel = True
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "CC form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try
    End Sub

End Class