Public Class MMChProcedure

    Private Sub MMChProcedure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMPRocedure' table. You can move, or remove it, as needed.
        Me.MMPRocedureTableAdapter.Fill(Me.MMDataDataSet1.MMPRocedure)

    End Sub

    Private Sub MMPRocedureBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMPRocedureBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MMPRocedureBindingSource.EndEdit()
            Me.MMPRocedureTableAdapter.Update(Me.MMDataDataSet1.MMPRocedure)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text <> "" Then

            Me.MMPRocedureBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"

        End If

        Me.MMPRocedureBindingSource.Sort = "Description"
        MMPRocedureDataGridView.DataSource = Me.MMPRocedureBindingSource
        ' GradientCaption2.Text = "Patient Information"


        'txtFind.Focus()
    End Sub
    Private Sub Code1TextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Code1TextBox.Leave

        Try
            If Code1TextBox.Text <> "" Then
                If Code2TextBox.Text = "" Then
                    Code2TextBox.Text = Code1TextBox.Text
                End If
                If Code3TextBox.Text = "" Then
                    Code3TextBox.Text = Code1TextBox.Text
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "eeor in code1textbox_leave")
        End Try

    End Sub
   
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub MMPRocedureBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMPRocedureBindingSource.AddingNew
        Me.MMDataDataSet1.MMPRocedure.TypeColumn.DefaultValue = "PR"
    End Sub
End Class