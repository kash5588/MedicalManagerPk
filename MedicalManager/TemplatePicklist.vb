Public Class TemplatePicklist
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aPickCC(2) As String

    Private Sub TemplatePicklist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MMChiefComplaintsTableAdapter.Fill(Me.MMDataDataSet2.MMChiefComplaints)
        LoadListbox()
    End Sub

    Private Sub MMChiefComplaintsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MMChiefComplaintsBindingSource.EndEdit()
        Me.MMChiefComplaintsTableAdapter.Update(Me.MMDataDataSet2.MMChiefComplaints)

    End Sub

    Private Function LoadListbox()
        Dim db As DBAccess = New DBAccess()
        Dim localdr As SqlClient.SqlDataReader

        localdr = db.ExecuteReader("SELECT distinct ChiefComplaint from MMChiefComplaints order by ChiefComplaint")
        If localdr.HasRows = True Then
            While localdr.Read
                If localdr.Item(0).ToString <> "" Then
                    lstChiefComplaint.Items.Add(localdr.Item(0))
                End If
            End While
        End If
        localdr.Close()
    End Function

    Private Sub lstChiefComplaint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstChiefComplaint.SelectedIndexChanged
        Me.MMChiefComplaintsTableAdapter.FillByCC(Me.MMDataDataSet2.MMChiefComplaints, lstChiefComplaint.Text)
    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        Try
            Me.MMChiefComplaintsBindingSource.Filter = "ChiefComplaint like" & "'" & txtFind.Text & "%'"
            Me.MMChiefComplaintsBindingSource.Sort = "ChiefComplaint"
            MMChiefComplaintsDataGridView.DataSource = Me.MMChiefComplaintsBindingSource
        Catch
        End Try
    End Sub
    Public Function ShowPicklist() As String()
        aPickCC(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()
        If mbSelected Then
            aPickCC(0) = "Y"
            aPickCC(1) = MMChiefComplaintsDataGridView.SelectedRows(0).Cells("TemplateName").Value & ""
            aPickCC(2) = MMChiefComplaintsDataGridView.SelectedRows(0).Cells("ChiefComplaint").Value & ""
        End If
        ShowPicklist = aPickCC
        Me.Close()
        Exit Function
    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub MMChiefComplaintsDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMChiefComplaintsDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub
End Class