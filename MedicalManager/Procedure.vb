Public Class Procedure

    Dim adding As Boolean
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(3) As String

    Public Function ShowPicklist() As String()

        Dim aRet(6) As String
        ' On Error GoTo EH
        aRet(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()
        If mbSelected Then
            aRet(0) = "Y"
            aRet(1) = dgProcedure.SelectedRows(0).Cells(0).Value & ""
            aRet(2) = dgProcedure.SelectedRows(0).Cells(1).Value
        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function
    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub dgProcedure_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProcedure.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub
    Private Sub MMCHProcedureBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMCHProcedureBindingNavigatorSaveItem.Click
            Try
                  Me.Validate()
                  Me.MMCHProcedureBindingSource.EndEdit()
                  Me.MMCHProcedureTableAdapter.Update(Me.MMDataDataSet1.MMCHProcedure)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub Procedure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MMCHProcedureTableAdapter.Fill(Me.MMDataDataSet1.MMCHProcedure)
    End Sub

   
    'Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '    If txtFind.Text <> "" Then
    '        Me.MMCHProcedureBindingSource.Filter = "Description" & " like" & "'" & txtFind.Text & "%'"
    '    End If

    '    'Me.StudentsBindingSource.Filter = "LastName like '" & text & "%'"
    '    'Me.MMPATIENTBindingSource.Sort = "ChartNumber"
    '    'dgPatient.DataSource = Me.MMPATIENTBindingSource
    '    'TabControl1.SelectedTab = TabControl1.TabPages(0)
    '    txtFind.Focus()
    'End Sub

    
    Private Sub TimeToDoProcedureLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    
    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text <> "" Then

            Me.MMCHProcedureBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"

        End If

        Me.MMCHProcedureBindingSource.Sort = "Description"
        dgProcedure.DataSource = Me.MMCHProcedureBindingSource
      
        TabControl1.SelectedTab = TabControl1.TabPages(0)

    End Sub
    

    Private Sub MMCHProcedureBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMCHProcedureBindingSource.AddingNew
        Me.MMDataDataSet1.MMCHProcedure.TypeColumn.DefaultValue = "PR"
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class