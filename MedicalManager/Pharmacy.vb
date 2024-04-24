Public Class Pharmacy

    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRetPharm(2) As String
    Dim ChartNumber As String

    Public Function ShowPicklist() As String()

        Dim aRetPharm(2) As String
        ' On Error GoTo EH
        aRetPharm(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()
        If mbSelected Then
            aRetPharm(0) = "Y"
            aRetPharm(1) = MMPharmacyDataGridView.SelectedRows(0).Cells("Fax").Value & ""
            aRetPharm(2) = MMPharmacyDataGridView.SelectedRows(0).Cells("Email").Value & ""
       
        End If
        ShowPicklist = aRetPharm
        Me.Close()
        Exit Function

    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub


    Private Sub MMPharmacyBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMPharmacyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMPharmacyBindingSource.EndEdit()
        Me.MMPharmacyTableAdapter.Update(Me.MMDataDataSet2.MMPharmacy)

    End Sub

    Private Sub Pharmacy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.MMPharmacy' table. You can move, or remove it, as needed.
        Me.MMPharmacyTableAdapter.Fill(Me.MMDataDataSet2.MMPharmacy)
    End Sub


    Private Sub txtFind_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        If cmbFilter.Text <> "" Then
            Me.MMPharmacyBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
        End If
        Me.MMPharmacyBindingSource.Sort = "Name"
        MMPharmacyDataGridView.DataSource = Me.MMPharmacyBindingSource
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub



    Private Sub MMPharmacyDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMPharmacyDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub
End Class