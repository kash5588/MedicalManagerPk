


Public Class ReferringPhysician

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
            aRet(1) = MMRPHDataGridView.SelectedRows(0).Cells(0).Value & ""
            aRet(2) = MMRPHDataGridView.SelectedRows(0).Cells(1).Value & ""
            aRet(3) = MMRPHDataGridView.SelectedRows(0).Cells(2).Value & ""
            'aRet(4) = DataGridView1.SelectedRows(0).Cells(4).Value & ""
            'aRet(5) = DataGridView1.SelectedRows(0).Cells(5).Value & ""
            '  aRet(6) = DataGridView1.SelectedRows(0).Cells(18).Value & ""

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



    Private Sub MMRPHBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMRPHBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MMRPHBindingSource.EndEdit()
            Me.MMRPHTableAdapter.Update(Me.MMDataDataSet1.MMRPH)
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub RefPhycician_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMRPH' table. You can move, or remove it, as needed.
        Me.MMRPHTableAdapter.Fill(Me.MMDataDataSet1.MMRPH)

    End Sub

    Private Sub MMRPHDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMRPHDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub
End Class