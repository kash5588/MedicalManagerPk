Public Class HealthHistoryQuestions

    Private Sub HealthHistoryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HealthHistoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HealthHistoryBindingSource.EndEdit()
        Me.HealthHistoryTableAdapter.Update(Me.MMDataDataSet2.HealthHistory)

    End Sub

    Private Sub HealthHistoryQuestions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.HealthHistory' table. You can move, or remove it, as needed.
        Me.HealthHistoryTableAdapter.Fill(Me.MMDataDataSet2.HealthHistory)




    End Sub

  


    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text <> "" Then
            Me.HealthHistoryBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
        End If
        ' Me.HealthHistoryBindingSource.Sort = "ChartNumber"
        HealthHistoryDataGridView.DataSource = Me.HealthHistoryBindingSource
        ' GradientCaption2.Text = "Patient Information"


    End Sub


    Private Sub txtFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.Click

    End Sub

  


    Private Sub HealthHistoryDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles HealthHistoryDataGridView.CellFormatting
        ' On Error Resume Next

       
        If Not IsDBNull(MMDataDataSet2.HealthHistory.Rows(e.RowIndex)("AnswerType")) Then
            If MMDataDataSet2.HealthHistory.Rows(e.RowIndex)("AnswerType") = "Yes" Then
                If e.ColumnIndex = 3 Then
                    e.CellStyle.BackColor = Drawing.Color.Black
                End If
            End If
        End If

    End Sub
End Class