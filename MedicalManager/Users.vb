Public Class Users

    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MMActionsListTableAdapter.Fill(Me.MMDataDataSet2.MMActionsList)
        Me.MMUsersTableAdapter.Fill(Me.MMDataDataSet2.MMUsers)
    End Sub

    Private Sub MMUsersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMUsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMUsersBindingSource.EndEdit()
        Me.MMUsersTableAdapter.Update(Me.MMDataDataSet2.MMUsers)
    End Sub

    Private Sub MMActionsListDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMActionsListDataGridView.DoubleClick
        MMActionsListDataGridView.SelectedRows(0).Cells("Authorized").Value = True
        MMActionsListDataGridView.Refresh()
        Dim ProcedureList As String = Procedure_NameTextBox.Text
        If ProcedureList = "" Then
            ProcedureList = MMActionsListDataGridView.SelectedRows(0).Cells("Actions").Value
        Else
            ProcedureList = ProcedureList & "," & MMActionsListDataGridView.SelectedRows(0).Cells("Actions").Value
        End If
        Procedure_NameTextBox.Text = ProcedureList
        CheckAuthorized()
        Me.Validate()
        Me.MMUsersBindingSource.EndEdit()
        Me.MMUsersTableAdapter.Update(Me.MMDataDataSet2.MMUsers)
    End Sub

    Private Function CheckAuthorized()
        Dim arrActions() As String
        Dim item As String
        Dim i As Integer
        Dim ii As Integer
        arrActions = txtCopyProcedure.Text.Split(",")

        For ii = 0 To MMActionsListDataGridView.RowCount - 1
            MMActionsListDataGridView.Rows(ii).Cells("Authorized").Value = False
        Next

        For Each item In arrActions
            For i = 0 To MMActionsListDataGridView.RowCount - 1
                If item = MMActionsListDataGridView.Rows(i).Cells("Actions").Value Then
                    MMActionsListDataGridView.Rows(i).Cells("Authorized").Value = True
                End If
            Next
        Next
    End Function

    Private Sub MMUsersDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMUsersDataGridView.SelectionChanged
        CheckAuthorized()
    End Sub

    Private Sub txtCopyProcedure_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCopyProcedure.TextChanged
        CheckAuthorized()
    End Sub

    Private Sub btnRemoveAuthorization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAuthorization.Click
        Dim i As Integer = 0
        Procedure_NameTextBox.Text = ""
        Dim ProcedureList As String = Procedure_NameTextBox.Text
        For i = 0 To MMActionsListDataGridView.RowCount - 1
            If MMActionsListDataGridView.Rows(i).Cells("Authorized").Value = True Then
                If ProcedureList = "" Then
                    ProcedureList = MMActionsListDataGridView.Rows(i).Cells("Actions").Value
                Else
                    ProcedureList = ProcedureList & "," & MMActionsListDataGridView.Rows(i).Cells("Actions").Value
                End If
            End If
            Procedure_NameTextBox.Text = ProcedureList
        Next
    End Sub

   
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        FirstNameTextBox.Focus()
    End Sub
End Class