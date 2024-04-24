Public Class Diagonosis
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
            aRet(1) = MMDXDataGridView.SelectedRows(0).Cells(0).Value & ""
            aRet(2) = MMDXDataGridView.SelectedRows(0).Cells(3).Value & ""
        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub MMDXDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMDXDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub

    Private Sub MMDXBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMDXBindingNavigatorSaveItem.Click
            Try


                  Me.Validate()
                  Me.MMDXBindingSource.EndEdit()
                  Me.MMDXTableAdapter.Update(Me.MMDataDataSet1.MMDX)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub Diagonosis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMDX' table. You can move, or remove it, as needed.
        Me.MMDXTableAdapter.Fill(Me.MMDataDataSet1.MMDX)
        cmbFilter.SelectedIndex = 0
        txtFind.Focus()
    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text = "Last 6 of VinNumber" Then
            Me.MMDXBindingSource.Filter = "EntryNumber" & " like" & "'" & txtFind.Text & "%'"
        Else
            Me.MMDXBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"

        End If

        'Me.StudentsBindingSource.Filter = "LastName like '" & text & "%'"
        Me.MMDXBindingSource.Sort = "Description"
        MMDXDataGridView.DataSource = Me.MMDXBindingSource
       
        'TabControl1.SelectedTab = TabControl1.TabPages(0)
        'txtFind.Focus()
    End Sub

    Private Sub DescriptionTextBox_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DescriptionTextBox.MouseClick
        DescriptionTextBox.SelectAll()
    End Sub

    Private Sub MMDX_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.MMDXBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            ' See if any changes were made, but not saved 
            If Me.MMDataDataSet1.MMDX.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                'msgText = msgText & ControlChars.CrLf & _
                '"Save changes?"
                'msgText = msgText & ControlChars.CrLf & "Save the changes ?"

                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.MMDXTableAdapter.Update(Me.MMDataDataSet1.MMDX)

                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.MMDX.RejectChanges()

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

    Private Sub MMDXBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMDXBindingSource.AddingNew
        Me.MMDataDataSet1.MMDX.ApprovedColumn.DefaultValue = True
    End Sub
End Class