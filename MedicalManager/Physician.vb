Public Class Physician
    Dim adding As Boolean
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(7) As String
    Dim ChartNumber As String
    Public Function ShowPicklist() As String()

        Dim aRet(7) As String
        ' On Error GoTo EH
        aRet(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()
        If mbSelected Then
            aRet(0) = "Y"
            aRet(1) = dgPhysician.SelectedRows(0).Cells(0).Value & ""
            aRet(2) = dgPhysician.SelectedRows(0).Cells(1).Value & ""
            aRet(3) = dgPhysician.SelectedRows(0).Cells(2).Value & ""
            aRet(4) = dgPhysician.SelectedRows(0).Cells(3).Value & ""
            'aRet(5) = DataGridView1.SelectedRows(0).Cells(5).Value & ""
            'aRet(6) = DataGridView1.SelectedRows(0).Cells(18).Value & ""
            'aRet(7) = dgPatient.SelectedRows(0).Cells(18).Value


        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub


    Private Sub dgPhysician_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPhysician.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub


    Private Sub MMPhysionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MMPhysionBindingSource.EndEdit()
        Me.MMPhysionTableAdapter.Update(Me.MMDataDataSet1.MMPhysion)

    End Sub


    Private Sub MMPhysionBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMPhysionBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MMPhysionBindingSource.EndEdit()
            Me.MMPhysionTableAdapter.Update(Me.MMDataDataSet1.MMPhysion)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Physician2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMPhysion' table. You can move, or remove it, as needed.
        Me.MMPhysionTableAdapter.Fill(Me.MMDataDataSet1.MMPhysion)

    End Sub

    Private Sub MiddleInitialLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub
End Class