Public Class MessageList
    Dim adding As Boolean
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(2) As String
    Dim ChartNumber As String


    Private Sub MessageList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If mbPicklistmode = True Then
                Me.MMChartMessagesTableAdapter.FillByType(Me.MMDataDataSet1.MMChartMessages, "Message")
            Else
                Me.MMChartMessagesTableAdapter.Fill(Me.MMDataDataSet1.MMChartMessages)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function ShowPicklist() As String()
        Try
            Dim aRet(2) As String
            ' On Error GoTo EH
            aRet(0) = "N"
            mbPicklistmode = True
            mbSelected = False
            Me.ShowDialog()
            If mbSelected Then
                aRet(0) = "Y"
                aRet(1) = MMChartMessagesDataGridView.SelectedRows(0).Cells(3).Value & ""


            End If
            ShowPicklist = aRet
            Me.Close()
            Exit Function
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "MessageList.ShowPicklist")
        End Try
    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub MMChartMessagesDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMChartMessagesDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub

    Private Sub MMChartMessagesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartMessagesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MMChartMessagesBindingSource.EndEdit()
            Me.MMChartMessagesTableAdapter.Update(Me.MMDataDataSet1.MMChartMessages)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        TabControl1.SelectedIndex = 1
    End Sub
End Class