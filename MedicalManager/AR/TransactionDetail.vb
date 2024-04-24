Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class TransactionDetail

    Dim aRetBilling(7) As String
    Dim myBindingSource As New BindingSource()
    Private MouseIsDown As Boolean = False



#Region "Standard"

    Private Sub TransactionDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.MMARDepositTableAdapter.Fill(Me.ARDataSet.MMARDeposit)
            Me.MMARPostPaymentTableAdapter.Fill(Me.ARDataSet.MMARPostPayment)
            Me.BillingHeaderTableAdapter.Fill(Me.ARDataSet.BillingHeader)
            Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
            LoadComboBoxes2()
            CalculateTotals()
            If Not CaseNumberTextBox.Text = "" Then
                ApplyColorScheme()
            End If
            txtPayorName.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in TransactionDetailLoad")
        End Try
    End Sub

    Private Sub txtTotal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.LostFocus
        MouseIsDown = False
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
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in LoadComboboxes2")
        End Try
    End Function

    Private Sub BillingHeaderBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingHeaderBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.BillingHeaderBindingSource.EndEdit()
            Me.BillingHeaderTableAdapter.Update(Me.ARDataSet.BillingHeader)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in BillingHeaderSave")
        End Try
    End Sub

    Private Sub btnSaveTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTrans.Click
        SaveTransactions()
    End Sub

    Private Function SaveTransactions()
        Try
            Dim pieces() As String
            Dim IndexOf As Integer
            Dim sAction As String
            sAction = "SaveTransactions"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then
                Me.Validate()
                Me.BillingDetailBindingSource.EndEdit()
                Me.BillingDetailTableAdapter.Update(Me.ARDataSet.BillingDetail)
            Else
                MessageBox.Show("You are not authorized to save.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function


#End Region

#Region "Drag Drop"

    Private Sub txtTotal_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTotal.MouseDown
        '' Set a flag to show that the mouse is down.
        'MouseIsDown = True
        'txtTotal.Focus()
        txtTotal.DoDragDrop(txtTotal.Text, DragDropEffects.Copy)
    End Sub

    Private Sub txtTotal_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTotal.MouseMove
        '  If MouseIsDown Then
        ' ' Initiate dragging.
        ' txtTotal.DoDragDrop(txtTotal.Text, DragDropEffects.Copy)
        ' End If
        ' MouseIsDown = False
    End Sub

    Private Sub BillingDetailDataGridView_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles BillingDetailDataGridView.DragEnter
        ' Check the format of the data being dropped.
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            ' Display the copy cursor.
            e.Effect = DragDropEffects.Copy
        Else
            ' Display the no-drop cursor.
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub BillingDetailDataGridView_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles BillingDetailDataGridView.DragDrop
        Dim clientPoint As Point = BillingDetailDataGridView.PointToClient(New Point(e.X, e.Y))
        Dim hit As DataGridView.HitTestInfo = BillingDetailDataGridView.HitTest(clientPoint.X, clientPoint.Y)
        ' Paste the text.
        BillingDetailDataGridView.Rows(hit.RowIndex).Cells(hit.ColumnIndex).Value = e.Data.GetData(DataFormats.Text)
    End Sub

#End Region


    Private Sub BillingHeaderDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingHeaderDataGridView.SelectionChanged
        Try
            If BillingHeaderDataGridView.SelectedRows.Count Then
                Me.BillingDetailTableAdapter.FillByCaseNumber(Me.ARDataSet.BillingDetail, CaseNumberTextBox.Text)
                Me.MMARDepositTableAdapter.FillByCaseID(Me.ARDataSet.MMARDeposit, CaseNumberTextBox.Text)
                txtTotalAmount.Text = 0
                txtTotalPayments.Text = 0
                txtTotalBalance.Text = 0
                aRetBilling(0) = "Y"
                aRetBilling(1) = CaseNumberTextBox.Text
                aRetBilling(2) = ChartNumberTextBox.Text
                CalculateTotals()
                ApplyColorScheme()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in BillingHeaderSelectionChanged")
        End Try
    End Sub

    Private Function CalculateTotals()
        Dim i As Integer = 0
        txtTotalPayments.Text = 0
        txtTotalAmount.Text = 0
        txtTotalBalance.Text = 0
        Dim strTotalPayments As String = 0
        Dim strTotalAmount As String = 0
        Dim strTotalBalance As String = 0

        Try
            For i = 0 To BillingDetailDataGridView.Rows.Count - 1
                If Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value.ToString.Contains("-") Then
                    txtTotalPayments.Text += Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value
                Else
                    txtTotalAmount.Text += Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value
                    If Not IsDBNull(Me.BillingDetailDataGridView.Rows(i).Cells("BDReceived").Value) Then
                        Me.BillingDetailDataGridView.Rows(i).Cells("BDLineBalance").Value = Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value - Me.BillingDetailDataGridView.Rows(i).Cells("BDReceived").Value
                    Else
                        Me.BillingDetailDataGridView.Rows(i).Cells("BDLineBalance").Value = Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value
                    End If                   ' If Not IsDBNull(Me.
                    End If

            Next
            txtTotalPayments.Text *= -1
            txtTotalBalance.Text = (txtTotalAmount.Text - txtTotalPayments.Text).ToString
            txtTotalPayments.Text = (txtTotalPayments.Text - 0).ToString
            txtTotalAmount.Text = (txtTotalAmount.Text - 0).ToString
            txtTotalBalance.Text = (txtTotalBalance.Text - 0).ToString

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in CalculateTotals")
        End Try
    End Function

    Private Sub btnApplyCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyCharges.Click
        Dim i As Integer

        Try
            If cmbWhoPaid.Text <> "" And cmbPaymentType.Text <> "" And txtTotal.Text Then
                If txtBalance.Text > 0 Then
                    MessageBox.Show("Underapplied Charges: " & "$" & txtBalance.Text, "Underapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf txtBalance.Text < 0 Then
                    MessageBox.Show("Overapplied Charges: " & Replace(txtBalance.Text, "-", "$"), "Overapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else


                    For i = 0 To BillingDetailDataGridView.Rows.Count - 1
                        If Me.BillingDetailDataGridView.Rows(i).Cells("Payment").Value <> Nothing Then

                            Dim newRow As DataRow = Me.ARDataSet.BillingDetail.NewRow

                            newRow("CaseNumber") = BillingDetailDataGridView.Rows(i).Cells("BDCaseNumber").Value.ToString
                            newRow("ChartNumber") = BillingDetailDataGridView.Rows(i).Cells("BDChartNumber").Value.ToString
                            newRow("Extended") = "-" & BillingDetailDataGridView.Rows(i).Cells("Payment").Value.ToString
                            newRow("CPTCode") = BillingDetailDataGridView.Rows(i).Cells("BDCPTCode").Value.ToString
                            newRow("AssignedProvider") = BillingDetailDataGridView.Rows(i).Cells("BDAssignedProvider").Value.ToString
                            'newRow("TransactionCode") = BillingDetailDataGridView.Rows(i).Cells("").Value.ToString
                            newRow("Units") = BillingDetailDataGridView.Rows(i).Cells("BDUnits").Value.ToString
                            newRow("ServiceDate1") = Format(DateTimePicker1.Value, "MM/dd/yyyy")
                            ' newRow("DateCreated") = BillingDetailDataGridView.Rows(i).Cells("BDDateCreated").Value.ToString
                            newRow("DateEntered") = Format(Now, "MM/dd/yyyy")
                            newRow("PayorName") = txtPayorName.Text
                            newRow("PayorType") = cmbWhoPaid.Text
                            newRow("CheckNumber") = txtCheckNumber.Text
                            newRow("PaymentMethod") = cmbPaymentType.Text

                            Me.BillingDetailDataGridView.Rows(i).Cells("BDReceived").Value() += Me.BillingDetailDataGridView.Rows(i).Cells("Payment").Value

                            Me.ARDataSet.BillingDetail.Rows.Add(newRow)
                            Me.BillingDetailTableAdapter.Update(Me.ARDataSet.BillingDetail)

                        End If            'If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value <> Nothing Then
                    Next




                    Me.ARDataSet.MMARDeposit.DepositDateColumn.DefaultValue = Format(DateTimePicker1.Value, "MM/dd/yyyy") 'Format(Now, "MM/dd/yyyy")
                    Me.ARDataSet.MMARDeposit.PaymentMethodColumn.DefaultValue = cmbPaymentType.Text
                    Me.ARDataSet.MMARDeposit.PaymentAmountColumn.DefaultValue = txtTotal.Text
                    Me.ARDataSet.MMARDeposit.PayorTypeColumn.DefaultValue = cmbWhoPaid.Text
                    'Me.ARDataSet.MMARDeposit.CopayColumn.DefaultValue = False
                    Me.ARDataSet.MMARDeposit.ChartNumberColumn.DefaultValue = ChartNumberTextBox.Text
                    Me.ARDataSet.MMARDeposit.CaseNumberColumn.DefaultValue = CaseNumberTextBox.Text
                    Me.ARDataSet.MMARDeposit.CheckNumberColumn.DefaultValue = txtCheckNumber.Text
                    Me.ARDataSet.MMARDeposit.PayorNameColumn.DefaultValue = txtPayorName.Text
                    Me.MMARDepositBindingSource.AddNew()



                    For i = 0 To BillingDetailDataGridView.Rows.Count - 1
                        If Me.BillingDetailDataGridView.Rows(i).Cells("Payment").Value <> "" Then
                            Me.ARDataSet.MMARPostPayment.PaymentReferenceColumn.DefaultValue = Me.BillingDetailDataGridView.Rows(i).Cells("BDId").Value()
                            Me.ARDataSet.MMARPostPayment.PaymentAmountColumn.DefaultValue = Me.BillingDetailDataGridView.Rows(i).Cells("Payment").Value()
                            Me.ARDataSet.MMARPostPayment.DateModifiedColumn.DefaultValue = Format(DateTimePicker1.Value, "MM/dd/yyyy") 'Format(Now, "MM/dd/yyyy")
                            Me.ARDataSet.MMARPostPayment.WhoPaidColumn.DefaultValue = cmbWhoPaid.Text
                            Me.ARDataSet.MMARPostPayment.CaseNumberColumn.DefaultValue = CaseNumberTextBox.Text
                            Me.MMARPostPaymentBindingSource.AddNew()

                        End If
                    Next



                    Me.Validate()
                    Me.MMARPostPaymentBindingSource.EndEdit()
                    Me.MMARPostPaymentTableAdapter.Update(Me.ARDataSet.MMARPostPayment)

                    Me.Validate()
                    Me.MMARDepositBindingSource.EndEdit()
                    Me.MMARDepositTableAdapter.Update(Me.ARDataSet.MMARDeposit)






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
                        Me.BillingDetailDataGridView.Rows(ii).Cells("Payment").Value = ""
                    Next
                    '*******************

                End If  ' If txtBalance.Text > 0 Then
            Else
                MessageBox.Show("Please enter required fields.", "Missing Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            CalculateTotals()
            ApplyColorScheme()
            UpdateHeader()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in ApplyCharges")
        End Try
    End Sub

    Private Function ApplyColorScheme() As Boolean

        Dim i As Integer
        Try
            For i = 0 To BillingDetailDataGridView.Rows.Count - 1
                If Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value.ToString.Contains("-") Then
                    BillingDetailDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next

            Select Case txtTotalBalance.Text
                Case Is = 0
                    txtTotalBalance.BackColor = Color.FromArgb(164, 229, 147)
                Case Is < 0
                    txtTotalBalance.BackColor = Color.FromArgb(255, 201, 164)
                Case Is > 0
                    txtTotalBalance.BackColor = Color.FromArgb(248, 160, 170)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in ApplyColorScheme")
        End Try
    End Function

    Private Sub BillingDetailDataGridView_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BillingDetailDataGridView.CellValueChanged
        Dim i As Integer = 0
        Dim sumThispayment As Double = 0

        Try
            If BillingDetailDataGridView.Rows.Count Then
                For i = 0 To BillingDetailDataGridView.Rows.Count - 1
                    Try
                        Dim strWhoPaid As String = Me.BillingDetailDataGridView.Rows(i).Cells("Payment").Value
                        If strWhoPaid <> 0 Then
                            sumThispayment += Me.BillingDetailDataGridView.Rows(i).Cells("Payment").Value
                        End If
                    Catch
                    End Try
                Next
                txtBalance.Text = txtTotal.Text - sumThispayment
                If txtBalance.Text < 0 Then
                    MessageBox.Show("Overapplied Charges: " & Replace(txtBalance.Text, "-", "$"), "Overapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If  '  If BillingDetailDataGridView.Rows.Count Then
        Catch ex As Exception
            'MessageBox.Show(ex.ToString, "Error in CellValueChanged")
        End Try
    End Sub

    Private Sub BillingDetailDataGridView_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles BillingDetailDataGridView.Sorted
        ApplyColorScheme()
        CalculateTotals()
    End Sub

    Private Function UpdateHeader()
        Dim i As Integer = 0
        'txtTotalPayments.Text = 0
        'txtTotalAmount.Text = 0
        'txtTotalBalance.Text = 0
        Dim strTotalPayments As String = 0
        Dim strTotalAmount As String = 0
        Dim strTotalBalance As String = 0

        Try
            For i = 0 To BillingDetailDataGridView.Rows.Count - 1
                If Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value.ToString.Contains("-") Then
                    ' txtTotalPayments.Text += Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value
                    strTotalPayments += Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value
                Else
                    ' txtTotalAmount.Text += Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value
                    strTotalAmount += Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value
                End If

            Next
            'txtTotalPayments.Text *= -1
            'txtTotalBalance.Text = (txtTotalAmount.Text - txtTotalPayments.Text).ToString
            'txtTotalPayments.Text = (txtTotalPayments.Text - 0).ToString
            'txtTotalAmount.Text = (txtTotalAmount.Text - 0).ToString
            'txtTotalBalance.Text = (txtTotalBalance.Text - 0).ToString

            BillingHeaderDataGridView.SelectedRows(0).Cells("BHPayments").Value = strTotalPayments - 0
            BillingHeaderDataGridView.SelectedRows(0).Cells("BHCharges").Value = strTotalAmount - 0
            BillingHeaderDataGridView.SelectedRows(0).Cells("BHTotal").Value = (strTotalAmount - 0) + (strTotalPayments - 0)

            Me.Validate()
            Me.BillingHeaderBindingSource.EndEdit()
            Me.BillingHeaderTableAdapter.Update(Me.ARDataSet.BillingHeader)

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in UpdateHeader")
        End Try
    End Function

 
End Class