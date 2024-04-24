Public Class Medications
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
            aRet(1) = dgMedications.SelectedRows(0).Cells(0).Value & ""
            aRet(2) = dgMedications.SelectedRows(0).Cells(1).Value & ""
        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function
    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub dgProcedure_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMedications.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub
    Private Sub MMCHRxListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMCHRxListBindingNavigatorSaveItem.Click
            Try
                  Me.Validate()
                  Me.MMCHRxListBindingSource.EndEdit()
                  Me.MMCHRxListTableAdapter.Update(Me.MMDataDataSet.MMCHRxList)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub Medications_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet.MMCHRxList' table. You can move, or remove it, as needed.
        '  Me.MMCHRxListTableAdapter.Fill(Me.MMDataDataSet.MMCHRxList)
        cmbFilter.SelectedIndex = 0
    End Sub
    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text <> "" Then

            Me.MMCHRxListBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"

        End If

        Me.MMCHRxListBindingSource.Sort = "Medication"
        dgMedications.DataSource = Me.MMCHRxListBindingSource
        ' GradientCaption2.Text = "Patient Information"

        TabControl1.SelectedTab = TabControl1.TabPages(0)
        'txtFind.Focus()
    End Sub
End Class