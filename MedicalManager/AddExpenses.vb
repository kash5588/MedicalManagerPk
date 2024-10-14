Public Class AddExpenses
    Private Sub AddExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ' TODO: This line of code loads data into the 'RehmanADataSet.IncomeSchool' table. You can move, or remove it, as needed.
            Me.ExpensesDetailTableAdapter.Fill(Me.MMDataDataSet1.ExpensesDetail)
            LoadTotalIncomeAmount()
            LoadComboBoxesV2()
            TBAmount.Enabled = False
            recievedDateDateTimePicker.Enabled = False
            ExpanseTypeComboBox.Enabled = False
            labelUser.Text = CommonFunction.globalUser
            labelCompany.Text = CommonFunction.GetGeneralInfo("PracticeName")
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error")
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Try
            ExpanseTypeComboBox.Focus()
            labelUser.Text = CommonFunction.globalUser
            TBAmount.Value = 0
            TBAmount.Enabled = True
            recievedDateDateTimePicker.Enabled = True
            ExpanseTypeComboBox.Enabled = True
            LoadTotalIncomeAmount()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Income Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub LoadTotalIncomeAmount()

        Dim i As Integer
        Dim TotalAmount As Integer = 0

        Try
            If ExpensesDetailDataGridView.Rows.Count > 0 Then
                For i = 0 To ExpensesDetailDataGridView.Rows.Count - 1
                    If ExpensesDetailDataGridView.Rows(i).Cells("Amount").Value.ToString() <> "" Then
                        TotalAmount += Int32.Parse(ExpensesDetailDataGridView.Rows(i).Cells("Amount").Value.ToString())
                    End If
                Next
                LBTotalAmount.Text = TotalAmount.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Income Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
    Private Function LoadComboBoxesV2()
        Try

            Dim db As DBAccess = New DBAccess()
            Dim dt As New DataTable()

            dt.Load(db.ExecuteReader("SELECT * FROM MMComboV2"))

            ' Loop through each row in the DataTable

            For Each dtRow As DataRow In dt.Rows
                ' Check if the Property value is "Status"
                If dtRow("Property").ToString() = "ExpenseType" Then
                    ' Add the Text value to the ComboBox
                    ExpanseTypeComboBox.Items.Add(dtRow("Text").ToString())
                End If
            Next
            For Each dtRow As DataRow In dt.Rows
                ' Check if the Property value is "Status"
                If dtRow("Property").ToString() = "PaidTo" Then
                    ' Add the Text value to the ComboBox
                    PaidToComboBox.Items.Add(dtRow("Text").ToString())
                End If
            Next
            dt.Dispose()

            ' Select the first item in the ComboBox if there are any items
            If ExpanseTypeComboBox.Items.Count > 0 Then
                ExpanseTypeComboBox.SelectedIndex = 0
            End If
            If PaidToComboBox.Items.Count > 0 Then
                PaidToComboBox.SelectedIndex = 0
            End If
        Catch ex As Exception
            ' Show a message box if there is an error
            MessageBox.Show(ex.ToString(), "Error loading comboboxes.")
        End Try



    End Function
    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Try
            If ExpanseTypeComboBox.Text <> "" AndAlso TBAmount.Text <> "0" Then
                labelUser.Text = CommonFunction.globalUser

                labelCompany.Text = CommonFunction.GetGeneralInfo("PracticeName")
                Me.Validate()
                Me.ExpensesDetailBindingSource.EndEdit()
                Me.ExpensesDetailTableAdapter.Update(Me.MMDataDataSet1.ExpensesDetail)
                LoadTotalIncomeAmount()
                TBAmount.Enabled = False
                recievedDateDateTimePicker.Enabled = False

                Me.ExpensesDetailTableAdapter.Fill(Me.MMDataDataSet1.ExpensesDetail)
            Else
                MessageBox.Show("Please check missing values 'Expense Type' OR 'Amount'...! ", "Expense Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Income Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub AddExpenses_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate() Then
                Me.ExpensesDetailBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            If Me.MMDataDataSet1.ExpensesDetail.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

                Select Case result
                    Case DialogResult.Yes
                        Me.ExpensesDetailTableAdapter.Update(MMDataDataSet1.ExpensesDetail)

                    Case DialogResult.No
                        Me.MMDataDataSet1.ExpensesDetail.RejectChanges()

                    Case Else
                        e.Cancel = True
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Expense form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try
    End Sub

    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        Try
            Me.ExpensesDetailTableAdapter.FillByExpenseDate(Me.MMDataDataSet1.ExpensesDetail, dateFrom.Value.ToString(), dateTo.Value.ToString())
            LoadTotalIncomeAmount()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Expense Details", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub TBFind_KeyUp(sender As Object, e As KeyEventArgs) Handles TBFind.KeyUp
        Try
            If TBFind.Text <> "" Then
                'ExpensesDetailBindingSource.Filter = "ExpanseType LIKE '" & TBFind.Text & "%'"
                ExpensesDetailBindingSource.Filter = "ExpanseType LIKE '" & TBFind.Text & "%' OR PaidTo LIKE '" & TBFind.Text & "%'"
                ExpensesDetailBindingSource.Sort = "ExpanseType"
                ExpensesDetailDataGridView.DataSource = ExpensesDetailBindingSource
                LoadTotalIncomeAmount()
            Else
                ExpensesDetailBindingSource.Filter = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error")
        End Try
    End Sub
End Class