Public Class MedicalTests
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
            aRet(1) = DataGridView1.SelectedRows(0).Cells(0).Value & ""
            aRet(2) = DataGridView1.SelectedRows(0).Cells(2).Value & ""
        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function

    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub

    Private Sub MMChartTestMedicalBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartTestMedicalBindingNavigatorSaveItem.Click
            Try
                  Me.Validate()
                  Me.MMChartTestMedicalBindingSource.EndEdit()
            Me.MMChartTestMedicalTableAdapter1.Update(Me.MMDataDataSet1.MMChartTestMedical)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub MedicalTestsvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MMChartTestMedicalTableAdapter1.Fill(Me.MMDataDataSet1.MMChartTestMedical)
    End Sub
 
    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

            If cmbFilter.Text <> "" Then
            '      Me.MMChartTestMedicalBindingSource.Filter = "EntryNumber" & " like" & "'" & txtFind.Text & "%'"
            'Else
            Me.MMChartTestMedicalBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
        End If

        ' Me.MMChartTestMedicalBindingSource.Sort = "TestName"
        DataGridView1.DataSource = Me.MMChartTestMedicalBindingSource

    End Sub

    Private Sub MMChartTestMedicalBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMChartTestMedicalBindingSource.AddingNew
        Me.MMDataDataSet1.MMChartTestMedical.TimeStampColumn.DefaultValue = System.DateTime.Now
        Me.MMDataDataSet1.MMChartTestMedical.UserIDColumn.DefaultValue = globalUser
        Me.MMDataDataSet1.MMChartTestMedical.TypeColumn.DefaultValue = "TM"
    End Sub
End Class