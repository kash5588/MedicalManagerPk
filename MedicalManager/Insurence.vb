Public Class Insurence

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
            aRet(1) = dgInsurence.SelectedRows(0).Cells(0).Value & ""
            aRet(2) = dgInsurence.SelectedRows(0).Cells(1).Value & ""
        End If
        ShowPicklist = aRet
        Me.Close()
        Exit Function

    End Function
    Public Sub PicklistSelect()
        mbSelected = True
        Me.Hide()
    End Sub

    Private Sub dgInsurence_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgInsurence.DoubleClick
        If mbPicklistmode Then
            PicklistSelect()
        End If
    End Sub
    Private Sub MMINSURENCEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMINSURENCEBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MMINSURENCEBindingSource.EndEdit()
            Me.MMINSURENCETableAdapter.Update(Me.MMDataDataSet1.MMINSURENCE)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Insurence_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMINSURENCE' table. You can move, or remove it, as needed.
        Me.MMINSURENCETableAdapter.Fill(Me.MMDataDataSet1.MMINSURENCE)
        cmbFilter.SelectedIndex = 0

    End Sub
    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text <> "" Then

            Me.MMINSURENCEBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"

        End If

        Me.MMINSURENCEBindingSource.Sort = "Name"
        dgInsurence.DataSource = Me.MMINSURENCEBindingSource
        ' GradientCaption2.Text = "Patient Information"

        TabControl1.SelectedTab = TabControl1.TabPages(0)
        'txtFind.Focus()
    End Sub
    
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        TabControl1.SelectedTab = TabControl1.TabPages(1)
    End Sub

    Private Sub CodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeTextBox.TextChanged

    End Sub

    Private Sub CodeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Street1TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Street1TextBox.TextChanged

    End Sub

    Private Sub Street1Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Street2TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Street2TextBox.TextChanged

    End Sub

    Private Sub Street2Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityTextBox.TextChanged

    End Sub

    Private Sub CityLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StateTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StateTextBox.TextChanged

    End Sub

    Private Sub StateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ZipCodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZipCodeTextBox.TextChanged

    End Sub

    Private Sub ZipCodeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PhoneLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExtensionTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtensionTextBox.TextChanged

    End Sub

    Private Sub ExtensionLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FaxLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PracticeIDNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PracticeIDNumberTextBox.TextChanged

    End Sub

    Private Sub PracticeIDNumberLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PlanNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanNameTextBox.TextChanged

    End Sub

    Private Sub PlanNameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TypeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PhoneMaskedTextBox_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles PhoneMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub FaxMaskedTextBox_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles FaxMaskedTextBox.MaskInputRejected

    End Sub

End Class