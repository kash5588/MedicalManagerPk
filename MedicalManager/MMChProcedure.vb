Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class MMChProcedure
    Dim aRet(8) As String
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

    Private Sub btnPhysician_Click(sender As Object, e As EventArgs) Handles btnPhysician.Click
        Dim PriPhysician As New Physician
        'aRet = frmCustomers.ShowPicklist
        ' frmCustomers.ShowDialog()
        aRet = PriPhysician.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab

            MyProceduresTextBox.Text = aRet(1) 'Pick Code Of Physician

            'AssignedProviderTextBox.Text = aRet(3) + " " + aRet(2) 'Pick Name Of Physician

        End If
    End Sub
End Class