Public Class ARComments


    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(2) As String

    Public Function CommentsShowPicklist() As String()

        Dim aRet(15) As String
        ' On Error GoTo EH
        aRet(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()
        If mbSelected Then
            aRet(0) = "Y"
            aRet(1) = MMARCommentsDataGridView.SelectedRows(0).Cells("Code").Value & ""
            aRet(2) = MMARCommentsDataGridView.SelectedRows(0).Cells("Description").Value & ""

        End If
        CommentsShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub MMARCommentsDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMARCommentsDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub



    Private Sub MMARCommentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMARCommentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMARCommentsBindingSource.EndEdit()
        Me.MMARCommentsTableAdapter.Update(Me.ARDataSet.MMARComments)

    End Sub

    Private Sub ARComments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ARDataSet.MMARComments' table. You can move, or remove it, as needed.
        Me.MMARCommentsTableAdapter.Fill(Me.ARDataSet.MMARComments)
    End Sub


End Class