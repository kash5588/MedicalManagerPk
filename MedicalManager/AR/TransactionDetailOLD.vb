Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class TransactionDetailOLD




    Dim aRetBilling(7) As String
    Dim myBindingSource As New BindingSource()


    Private Sub BillingHeaderBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingHeaderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BillingHeaderBindingSource.EndEdit()
        Me.BillingHeaderTableAdapter.Update(Me.ARDataSet.BillingHeader)

    End Sub

    Private Sub TransactionDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ARDataSet.MMARDeposit' table. You can move, or remove it, as needed.
        Me.MMARDepositTableAdapter.Fill(Me.ARDataSet.MMARDeposit)
        'TODO: This line of code loads data into the 'ARDataSet.MMARPostPayment' table. You can move, or remove it, as needed.
        Me.MMARPostPaymentTableAdapter.Fill(Me.ARDataSet.MMARPostPayment)
        ' Me.BillingDetailTableAdapter.Fill(Me.ARDataSet.BillingDetail)
        Me.BillingHeaderTableAdapter.Fill(Me.ARDataSet.BillingHeader)
        Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
        LoadComboBoxes2()

    End Sub

    Private Sub BillingHeaderDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingHeaderDataGridView.SelectionChanged
        If BillingHeaderDataGridView.SelectedRows.Count Then
            '''''''''''' Me.BillingDetailTableAdapter.FillByBillingId(Me.ARDataSet.BillingDetail, IdTextBox.Text)
            ' Me.MMARPostPaymentTableAdapter.FillByCaseId(Me.ARDataSet.MMARPostPayment, CaseNumberTextBox.Text)
            txtTotalAmount.Text = 0
            txtTotalPayments.Text = 0
            txtTotalBalance.Text = 0
            'CalculateTotals()
            'ApplyColorScheme()

            aRetBilling(0) = "Y"
            aRetBilling(1) = IdTextBox.Text
            aRetBilling(2) = ChartNumberTextBox.Text

        End If
    End Sub

    Private Sub btnApplyCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyCharges.Click
        Dim i As Integer
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        sAction = "SaveTransactions"
        pieces = Permissions.Split(",")
        IndexOf = Array.IndexOf(pieces, sAction)

        If IndexOf <> -1 Then
        Else
            MessageBox.Show("You are not authorized to apply transactions.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        txtTotalAmount.Text = 0
        txtTotalPayments.Text = 0
        txtTotalBalance.Text = 0

        Try

            If cmbWhoPaid.Text <> "" And cmbPaymentType.Text <> "" Then
                If txtBalance.Text > 0 Then
                    MessageBox.Show("Underapplied Charges: " & "$" & txtBalance.Text, "Underapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf txtBalance.Text < 0 Then
                    MessageBox.Show("Overapplied Charges: " & Replace(txtBalance.Text, "-", "$"), "Overapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' '' ''Dim i As Integer = 0
                    ' '' ''For i = 0 To BillingDetailDataGridView.Rows.Count - 1
                    ' '' ''    If Me.BillingDetailDataGridView.Rows(i).Cells("Received").Value <> Nothing Then
                    ' '' ''        Dim strWhoPaid As String = cmbWhoPaid.Text
                    ' '' ''        Dim strToAppend = "AmountPaid"
                    ' '' ''        Dim strToAppend2 = "Paid"
                    ' '' ''        If strWhoPaid = "WRITEOFF" Then
                    ' '' ''            Me.BillingDetailDataGridView.Rows(i).Cells("AdjustmentAmount").Value() += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
                    ' '' ''            'Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend2).Value = True
                    ' '' ''            txtTotalPayments.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
                    ' '' ''            txtTotalAmount.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value
                    ' '' ''            txtTotalBalance.Text = txtTotalAmount.Text - txtTotalPayments.Text
                    ' '' ''        Else
                    ' '' ''            ' Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend2).Value = True
                    ' '' ''            Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend).Value += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
                    ' '' ''            Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("GuarantorAmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("CopayAmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance1AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance2AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance3AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AdjustmentAmount").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AttorneyAmountPaid").Value
                    ' '' ''            Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value - Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
                    ' '' ''            txtTotalPayments.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
                    ' '' ''            txtTotalAmount.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value
                    ' '' ''            txtTotalBalance.Text = txtTotalAmount.Text - txtTotalPayments.Text
                    ' '' ''        End If   'If strWhoPaid = "WriteOff" Then
                    ' '' ''    End If   'If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value <> Nothing Then
                    ' '' ''Next
                    ' '' ''Console.WriteLine(txtTotal.Text)
                    ' '' ''Me.Validate()
                    ' '' ''Me.MMARTRANSACTIONSBindingSource.EndEdit()
                    ' '' ''Me.MMARTRANSACTIONSTableAdapter.Update(Me.ARDataSet.MMARTRANSACTIONS)

                    For i = 0 To BillingDetailDataGridView.Rows.Count - 1
                        If Me.BillingDetailDataGridView.Rows(i).Cells("Received").Value <> 0 Then
                            Me.ARDataSet.MMARPostPayment.PaymentReferenceColumn.DefaultValue = Me.BillingDetailDataGridView.Rows(i).Cells("ID").Value()
                            Me.ARDataSet.MMARPostPayment.PaymentAmountColumn.DefaultValue = Me.BillingDetailDataGridView.Rows(i).Cells("Received").Value()
                            Me.ARDataSet.MMARPostPayment.DateModifiedColumn.DefaultValue = Format(DateTimePicker1.Value, "MM/dd/yyyy") 'Format(Now, "MM/dd/yyyy")
                            Me.ARDataSet.MMARPostPayment.WhoPaidColumn.DefaultValue = cmbWhoPaid.Text
                            Me.ARDataSet.MMARPostPayment.CaseNumberColumn.DefaultValue = IdTextBox.Text
                            Me.MMARPostPaymentBindingSource.AddNew()

                        End If
                    Next
                    'Console.WriteLine(txtTotal.Text)


                    Me.ARDataSet.MMARDeposit.DepositDateColumn.DefaultValue = Format(DateTimePicker1.Value, "MM/dd/yyyy") 'Format(Now, "MM/dd/yyyy")
                    Me.ARDataSet.MMARDeposit.PaymentMethodColumn.DefaultValue = cmbPaymentType.Text
                    Me.ARDataSet.MMARDeposit.PaymentAmountColumn.DefaultValue = txtTotal.Text
                    Me.ARDataSet.MMARDeposit.PayorTypeColumn.DefaultValue = cmbWhoPaid.Text
                    'Me.ARDataSet.MMARDeposit.CopayColumn.DefaultValue = False
                    Me.ARDataSet.MMARDeposit.ChartNumberColumn.DefaultValue = ChartNumberTextBox.Text
                    Me.ARDataSet.MMARDeposit.CaseNumberColumn.DefaultValue = IdTextBox.Text
                    Me.ARDataSet.MMARDeposit.CheckNumberColumn.DefaultValue = txtCheckNumber.Text
                    Me.ARDataSet.MMARDeposit.PayorNameColumn.DefaultValue = txtPayorName.Text
                    Me.MMARDepositBindingSource.AddNew()

                    ''''ApplyColorScheme()

                    '*******************Clear controls
                    Dim ii As Integer
                    cmbWhoPaid.Text = ""
                    cmbPaymentType.Text = ""
                    txtTotal.Text = ""
                    txtBalance.Text = 0
                    If chkKeepPayorCheckNo.Checked = False Then
                        txtPayorName.Text = ""
                        txtCheckNumber.Text = ""
                    End If
                    For ii = 0 To BillingDetailDataGridView.Rows.Count - 1
                        Me.BillingDetailDataGridView.Rows(ii).Cells("Received").Value = 0
                    Next
                    '*******************
                End If
                Me.Validate()
                Me.MMARPostPaymentBindingSource.EndEdit()
                Me.MMARPostPaymentTableAdapter.Update(Me.ARDataSet.MMARPostPayment)

                Me.Validate()
                Me.MMARDepositBindingSource.EndEdit()
                Me.MMARDepositTableAdapter.Update(Me.ARDataSet.MMARDeposit)
            Else
                MessageBox.Show("Please enter required fields.", "Missing Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'CalculateTotals()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function LoadComboBoxes2()
        Try
            Dim dr As DataRow
            Dim dr2 As DataRow

            Dim dt As DataTable
            Dim dt2 As DataTable

            dt = Me.MMDataDataSet1.Tables("MMCombo")
            dt2 = Me.MMDataDataSet1.Tables("MMINSURENCE")

            For Each dr In dt.Rows
                If dr("WhoPaid") <> "N/A" Then
                    cmbWhoPaid.Items.Add(dr("WhoPaid"))
                End If
            Next

            For Each dr In dt.Rows
                If dr("PaymentType") <> "N/A" Then
                    cmbPaymentType.Items.Add(dr("PaymentType"))
                End If
            Next

            For Each dr2 In dt2.Rows
                If dr2("Name") <> "" Then
                    txtPayorName.Items.Add(dr2("Name"))
                End If
            Next
        Catch
        End Try
    End Function


End Class