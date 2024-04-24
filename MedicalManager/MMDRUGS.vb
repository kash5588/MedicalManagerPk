Public Class DRUGs
    Dim adding As Boolean
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(3) As String
    Dim ChartNumber As String

    Private Sub DRUGs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cmbFilter.SelectedIndex = 0
            Me.MMDRUGTableAdapter.FillBy(Me.MMDataDataSet1.MMDRUG)
            Me.MMPrecticeTableAdapter.Fill(Me.MMDataDataSet1.MMPrectice)
            LoadPhysicianCode()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Function ShowPicklist() As String()

        Dim aRet(2) As String
        ' On Error GoTo EH
        aRet(0) = "N"
        mbPicklistmode = True
        mbSelected = False
        Me.ShowDialog()
        If mbSelected Then
            aRet(0) = "Y"
            aRet(1) = MMDRUGDataGridView.SelectedRows(0).Cells(2).Value + "  " & MMDRUGDataGridView.SelectedRows(0).Cells(3).Value + "  " & MMDRUGDataGridView.SelectedRows(0).Cells(4).Value
            aRet(2) = MMDRUGDataGridView.SelectedRows(0).Cells(7).Value + ""


        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub MMDRUGDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMDRUGDataGridView.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub

    Private Sub MMDRUGBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMDRUGBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMDRUGBindingSource.EndEdit()
        Me.MMDRUGTableAdapter.Update(Me.MMDataDataSet1.MMDRUG)
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.MMDRUGTableAdapter.FillByName(Me.MMDataDataSet1.MMDRUG, Param1ToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '    If cmbFilter.Text <> "" Then

    '        Me.MMDRUGBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"

    '    End If

    '    Me.MMDRUGBindingSource.Sort = "DRGNAME"
    '    MMDRUGDataGridView.DataSource = Me.MMDRUGBindingSource

    '    'TabControl1.SelectedIndex = 0
    '    ' TabControl1.SelectedTab = TabControl1.TabPages(0)
    '    'txtFind.Focus()
    'End Sub

    Private Sub Param1ToolStripTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Param1ToolStripTextBox.KeyUp
        Try
            Me.MMDRUGTableAdapter.FillByName(Me.MMDataDataSet1.MMDRUG, Param1ToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function LoadPhysicianCode()

        Dim dr As DataRow
        Dim dt As DataTable
        Dim PhyCode As String
        Try
            dt = Me.MMDataDataSet1.Tables("MMPrectice")

            For Each dr In dt.Rows
                If dr("Extra1") <> "" Then
                    MyRxComboBox.Items.Add(dr("Extra1"))
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

End Class