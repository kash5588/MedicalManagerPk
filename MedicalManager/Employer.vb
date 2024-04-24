Public Class Employer

    Dim adding As Boolean
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(3) As String

    Public Function ShowPicklist() As String()

        Dim aRet(6) As String

        aRet(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()
        If mbSelected Then
            aRet(0) = "Y"

            Dim row As MMDataDataSet1.EmployerRow
            row = CType(CType(Me.EmployerBindingSource.Current, DataRowView).Row, MMDataDataSet1.EmployerRow)

            aRet(1) = row("Code") & ""
            aRet(2) = row("Name") & ""
            aRet(3) = row("Phone") & ""
        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function
    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub EmployerDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmployerDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub
    Private Sub EmployerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployerBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.EmployerBindingSource.EndEdit()
            Me.EmployerTableAdapter.Update(Me.MMDataDataSet1.Employer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Employer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.Employer' table. You can move, or remove it, as needed.
        Me.EmployerTableAdapter.Fill(Me.MMDataDataSet1.Employer)
        cmbFilter.SelectedIndex = 0


    End Sub
    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text = "Last 6 of VinNumber" Then
            Me.EmployerBindingSource.Filter = "EntryNumber" & " like" & "'" & txtFind.Text & "%'"
        Else
            Me.EmployerBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"

        End If

        'Me.StudentsBindingSource.Filter = "LastName like '" & text & "%'"
        Me.EmployerBindingSource.Sort = "Name"
        EmployerDataGridView.DataSource = Me.EmployerBindingSource

        'TabControl1.SelectedTab = TabControl1.TabPages(0)
        'txtFind.Focus()
    End Sub

    Private Sub Employer_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.EmployerBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            ' See if any changes were made, but not saved 
            If Me.MMDataDataSet1.Employer.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                msgText = msgText & ControlChars.CrLf & _
                "Save changes?"
                'msgText = msgText & ControlChars.CrLf & "Save the changes ?"

                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.EmployerTableAdapter.Update(Me.MMDataDataSet1.Employer)

                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.Employer.RejectChanges()

                    Case Else
                        ' do nothing and cancel closing of the form
                        e.Cancel = True

                End Select
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Diagnosis form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try

    End Sub
End Class