Public Class Imaging

    Private Sub MMChartTestImagingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartTestImagingBindingNavigatorSaveItem.Click
            Try
                  Me.Validate()
                  Me.MMChartTestImagingBindingSource.EndEdit()
            Me.MMChartTestImagingTableAdapter1.Update(Me.MMDataDataSet1.MMChartTestImaging)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub Imaging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMChartTestImaging' table. You can move, or remove it, as needed.
        Me.MMChartTestImagingTableAdapter1.Fill(Me.MMDataDataSet1.MMChartTestImaging)
        'TODO: This line of code loads data into the 'MMDataDataSet.MMChartTestImaging' table. You can move, or remove it, as needed.
        'Me.MMChartTestImagingTableAdapter.Fill(Me.MMDataDataSet1.MMChartTestImaging)

    End Sub


    Private Sub MMChartTestImagingBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMChartTestImagingBindingSource.AddingNew
        Me.MMDataDataSet1.MMChartTestImaging.UserIDColumn.DefaultValue = globalUser
        Me.MMDataDataSet1.MMChartTestImaging.TypeColumn.DefaultValue = "TI"
        Me.MMDataDataSet1.MMChartTestImaging.TimeStampColumn.DefaultValue = System.DateTime.Now
    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        If cmbFilter.Text <> "" Then
            Me.MMChartTestImagingBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
        End If
        DataGridView1.DataSource = Me.MMChartTestImagingBindingSource
    End Sub

    
End Class