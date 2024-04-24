Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class Transactions
    Dim aRet(7) As String
    Dim myBindingSource As New BindingSource()

    Private Sub Transactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.MMINSURENCETableAdapter.Fill(Me.MMDataDataSet1.MMINSURENCE)
            Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
            LoadComboBoxes2()
            Me.MMDXTableAdapter.Fill(Me.ARDataSet.MMDX)
            Me.MMPRocedureTableAdapter.Fill(Me.ARDataSet.MMPRocedure)
            Me.MMARCASETableAdapter.Fill(Me.ARDataSet.MMARCASE)
            If Not CaseNumberTextBox.Text = "" Then
                Me.MMARTRANSACTIONSTableAdapter.FillByCaseId(Me.ARDataSet.MMARTRANSACTIONS, CaseNumberTextBox.Text)
                Me.MMARPostPaymentTableAdapter.FillByCaseId(Me.ARDataSet.MMARPostPayment, CaseNumberTextBox.Text)
                Me.MMARDepositTableAdapter.Fill(Me.ARDataSet.MMARDeposit)
                CalculateTotals()
                ApplyColorScheme()
            End If
        Catch
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

    Private Sub ChartNumberTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ChartNumberTextBox.KeyUp
        Try
            If ChartNumberTextBox.Text <> "" Then
                Me.MMARCASEBindingSource.Filter = "ChartNumber like" & "'" & ChartNumberTextBox.Text & "%'"
            End If
            Me.MMARCASEBindingSource.Sort = "ChartNumber"
            MMARCASEDataGridView.DataSource = Me.MMARCASEBindingSource
        Catch
        End Try
    End Sub

    Private Sub MMARCASEDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMARCASEDataGridView.DoubleClick
        Try
            If MMARCASEDataGridView.SelectedRows.Count Then
                ARNotes.ShowARNotes(aRet)
            End If
        Catch
        End Try
    End Sub

    Private Sub MMARCASEDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMARCASEDataGridView.SelectionChanged
        On Error Resume Next
        If MMARCASEDataGridView.SelectedRows.Count Then
            Me.MMARTRANSACTIONSTableAdapter.FillByCaseId(Me.ARDataSet.MMARTRANSACTIONS, CaseNumberTextBox.Text)
            Me.MMARPostPaymentTableAdapter.FillByCaseId(Me.ARDataSet.MMARPostPayment, CaseNumberTextBox.Text)
            txtTotalAmount.Text = 0
            txtTotalPayments.Text = 0
            txtTotalBalance.Text = 0
            CalculateTotals()
            ApplyColorScheme()

            aRet(0) = "Y"
            aRet(1) = CaseNumberTextBox.Text
            aRet(2) = ChartNumberTextBox.Text

        End If
    End Sub

    Private Sub MMARTRANSACTIONSDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MMARTRANSACTIONSDataGridView.CellValueChanged
        Dim i As Integer = 0
        Dim sumThispayment As Double = 0

        Try
            For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
                Try
                    Dim strWhoPaid As String = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
                    If strWhoPaid <> 0 Then
                        sumThispayment += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
                    End If
                Catch
                End Try
            Next
            txtBalance.Text = txtTotal.Text - sumThispayment
            If txtBalance.Text < 0 Then
                MessageBox.Show("Overapplied Charges: " & Replace(txtBalance.Text, "-", "$"), "Overapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch
        End Try
    End Sub

    Private Sub btnApplyCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyCharges.Click

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
                    Dim i As Integer = 0
                    For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
                        If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value <> Nothing Then
                            Dim strWhoPaid As String = cmbWhoPaid.Text
                            Dim strToAppend = "AmountPaid"
                            Dim strToAppend2 = "Paid"
                            If strWhoPaid = "WRITEOFF" Then
                                Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AdjustmentAmount").Value() += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
                                'Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend2).Value = True
                                txtTotalPayments.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
                                txtTotalAmount.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value
                                txtTotalBalance.Text = txtTotalAmount.Text - txtTotalPayments.Text
                            Else
                                ' Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend2).Value = True
                                Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend).Value += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
                                Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("GuarantorAmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("CopayAmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance1AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance2AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance3AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AdjustmentAmount").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AttorneyAmountPaid").Value
                                Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value - Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
                                txtTotalPayments.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
                                txtTotalAmount.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value
                                txtTotalBalance.Text = txtTotalAmount.Text - txtTotalPayments.Text
                            End If   'If strWhoPaid = "WriteOff" Then
                        End If   'If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value <> Nothing Then
                    Next
                    Console.WriteLine(txtTotal.Text)
                    Me.Validate()
                    Me.MMARTRANSACTIONSBindingSource.EndEdit()
                    Me.MMARTRANSACTIONSTableAdapter.Update(Me.ARDataSet.MMARTRANSACTIONS)

                    For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
                        If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value <> "" Then
                            Me.ARDataSet.MMARPostPayment.PaymentReferenceColumn.DefaultValue = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("EntryNumber").Value()
                            Me.ARDataSet.MMARPostPayment.PaymentAmountColumn.DefaultValue = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value()
                            Me.ARDataSet.MMARPostPayment.DateModifiedColumn.DefaultValue = Format(DateTimePicker1.Value, "MM/dd/yyyy") 'Format(Now, "MM/dd/yyyy")
                            Me.ARDataSet.MMARPostPayment.WhoPaidColumn.DefaultValue = cmbWhoPaid.Text
                            Me.ARDataSet.MMARPostPayment.CaseNumberColumn.DefaultValue = CaseNumberTextBox.Text
                            Me.MMARPostPaymentBindingSource.AddNew()

                        End If
                    Next
                    Console.WriteLine(txtTotal.Text)


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

                    ApplyColorScheme()

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
                    For ii = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
                        Me.MMARTRANSACTIONSDataGridView.Rows(ii).Cells("PaymentReceived").Value = ""
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
            CalculateTotals()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Me.ARDataSet.MMARTRANSACTIONS.DateFromColumn.DefaultValue = Format(Now, "MM/dd/yyyy")
            Me.ARDataSet.MMARTRANSACTIONS.DateToColumn.DefaultValue = Format(Now, "MM/dd/yyyy")
            Me.ARDataSet.MMARTRANSACTIONS.ChartNumberColumn.DefaultValue = ChartNumberTextBox.Text
            Me.ARDataSet.MMARTRANSACTIONS.CaseNumberColumn.DefaultValue = CaseNumberTextBox.Text
            MMARTRANSACTIONSBindingSource.AddNew()
            SaveTransactions()
        Catch
        End Try
    End Sub

    Private Sub txtTotal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.Leave
        Dim i As Integer = 0
        Dim sumThispayment As Double = 0

        Try
            For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
                Try
                    Dim strWhoPaid As String = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
                    If strWhoPaid <> 0 Then
                        sumThispayment += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
                    End If
                Catch
                End Try
            Next
            txtBalance.Text = txtTotal.Text - sumThispayment
            If txtBalance.Text < 0 Then
                MessageBox.Show("Overapplied Charges: " & Replace(txtBalance.Text, "-", "$"), "Overapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch
        End Try
    End Sub

    Private Sub MMPRocedureDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MMPRocedureDataGridView.CellDoubleClick
        Try
            Me.ARDataSet.MMARTRANSACTIONS.DateFromColumn.DefaultValue = Format(Now, "MM/dd/yyyy")
            Me.ARDataSet.MMARTRANSACTIONS.DateToColumn.DefaultValue = Format(Now, "MM/dd/yyyy")
            Me.ARDataSet.MMARTRANSACTIONS.ChartNumberColumn.DefaultValue = ChartNumberTextBox.Text
            Me.ARDataSet.MMARTRANSACTIONS.CaseNumberColumn.DefaultValue = CaseNumberTextBox.Text

            ' Me.ARDataSet.MMARTRANSACTIONS.CaseNumberColumn.DefaultValue = MMPRocedureDataGridView.Rows(0).Cells("DataGridViewTextBoxColumnDescription").value
            Me.ARDataSet.MMARTRANSACTIONS.AmountColumn.DefaultValue = MMPRocedureDataGridView.Rows(e.RowIndex).Cells("AmountA").Value
            Me.ARDataSet.MMARTRANSACTIONS.ProcedureCodeColumn.DefaultValue = MMPRocedureDataGridView.Rows(e.RowIndex).Cells("Code1").Value
            Me.ARDataSet.MMARTRANSACTIONS.DescriptionColumn.DefaultValue = MMPRocedureDataGridView.Rows(e.RowIndex).Cells("ProcedureDescription").Value

            MMARTRANSACTIONSBindingSource.AddNew()
            SaveTransactions()
        Catch
        End Try
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        Try
            Me.MMPRocedureBindingSource.Filter = "Description" & " like" & "'" & TextBox1.Text & "%'"
            Me.MMPRocedureBindingSource.Sort = "Description"
            MMPRocedureDataGridView.DataSource = Me.MMPRocedureBindingSource
        Catch
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            ARPatientBill.ReportShow(ChartNumberTextBox.Text, CaseNumberTextBox.Text)
        Catch
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            ARPatientBillSimple.ReportShow(ChartNumberTextBox.Text, CaseNumberTextBox.Text)
        Catch
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            PrintMultipleBills.Show()
        Catch
        End Try
    End Sub

    Private Function ApplyColorScheme() As Boolean
        Dim i As Integer
        Try
            For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
                If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Value > 0 Then
                    'Color.FromArgb(255, 255, 255)
                    Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Style.BackColor = Color.FromArgb(248, 160, 170)
                ElseIf Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Value < 0 Then
                    Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Style.BackColor = Color.FromArgb(255, 201, 164)
                Else
                    Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Style.BackColor = Color.FromArgb(164, 229, 147)
                End If
            Next

            Select Case txtTotalBalance.Text
                Case Is < 0
                    txtTotalBalance.BackColor = Color.FromArgb(255, 201, 164)
                Case Is > 0
                    txtTotalBalance.BackColor = Color.FromArgb(248, 160, 170)
                Case Is = 0
                    txtTotalBalance.BackColor = Color.FromArgb(164, 229, 147)
            End Select


            'For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
            '    If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Value > 0 Then
            '        'Color.FromArgb(255, 255, 255)
            '        Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Style.BackColor = Color.OrangeRed
            '    ElseIf Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Value < 0 Then
            '        Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Style.BackColor = Color.LemonChiffon
            '    Else
            '        Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Style.BackColor = Color.PaleTurquoise
            '    End If
            'Next


            'Select Case txtTotalBalance.Text
            '    Case Is < 0
            '        txtTotalBalance.BackColor = Color.FromArgb(223, 171, 98)
            '    Case Is > 0
            '        txtTotalBalance.BackColor = Color.FromArgb(223, 118, 98)
            '    Case Is = 0
            '        txtTotalBalance.BackColor = Color.FromArgb(72, 163, 103)
            'End Select
        Catch ex As Exception
        End Try
    End Function

    Private Function CalculateTotals()
        Dim i As Integer = 0
        txtTotalPayments.Text = 0
        txtTotalAmount.Text = 0
        txtTotalBalance.Text = 0
        Dim strTotalPayments As String = 0
        Dim strTotalAmount As String = 0
        Dim strTotalBalance As String = 0
        Try
            For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
                Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("GuarantorAmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("CopayAmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance1AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance2AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance3AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AdjustmentAmount").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AttorneyAmountPaid").Value
                Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value - Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
                txtTotalPayments.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
                txtTotalAmount.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value
                txtTotalBalance.Text = (txtTotalAmount.Text - txtTotalPayments.Text).ToString("c")
            Next
            txtTotalPayments.Text = (txtTotalPayments.Text - 0).ToString("c")
            txtTotalAmount.Text = (txtTotalAmount.Text - 0).ToString("c")
            'txtTotalBalance.Text = strTotalBalance.ToString("c")
        Catch
        End Try

        'For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
        '    Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("GuarantorAmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("CopayAmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance1AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance2AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance3AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AdjustmentAmount").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AttorneyAmountPaid").Value
        '    Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value - Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
        '    txtTotalPayments.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
        '    txtTotalAmount.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value
        '    txtTotalBalance.Text = (txtTotalAmount.Text - txtTotalPayments.Text).ToString("c")
        'Next
    End Function

    Private Sub btnSaveTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTrans.Click
        Try
            SaveTransactions()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSaveDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDeposit.Click
        Try
            Me.Validate()
            Me.MMARDepositBindingSource.EndEdit()
            Me.MMARDepositTableAdapter.Update(Me.ARDataSet.MMARDeposit)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnSavePostPymnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavePostPymnt.Click
        Try
            Me.Validate()
            Me.MMARPostPaymentBindingSource.EndEdit()
            Me.MMARPostPaymentTableAdapter.Update(Me.ARDataSet.MMARPostPayment)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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
                Me.MMARTRANSACTIONSBindingSource.EndEdit()
                Me.MMARTRANSACTIONSTableAdapter.Update(Me.ARDataSet.MMARTRANSACTIONS)
            Else
                MessageBox.Show("You are not authorized to save.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Sub CaseSaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaseSaveToolStripButton.Click
        Try
            Me.Validate()
            Me.MMARCASEBindingSource.EndEdit()
            Me.MMARCASETableAdapter.Update(Me.ARDataSet.MMARCASE)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        Try
            If cmbFilter.Text <> "" Then
                Me.MMARCASEBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
            End If
            Me.MMARCASEBindingSource.Sort = "ChartNumber"
            MMARCASEDataGridView.DataSource = Me.MMARCASEBindingSource
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollection.Click
        Try
            Dim colPrint As New DataGridViewCheckBoxColumn
            colPrint.DefaultCellStyle.NullValue = True
            colPrint.Name = "Print"
            Dim connString As String = connString2


            Dim cn As New SqlConnection(connString)
            cn.Open()

            Dim cmd As New SqlCommand("select EntryNumber, ChartNumber, CaseNumber, Datefrom as DOS, ProcedureCode as Code, [Description]  , Amount, linebalance as Balance, datecreated as DateBilled  from [MMARTRANSACTIONS] where chartnumber= '" & ChartNumberTextBox.Text & "' and  linebalance > 0 and Billingstatus = 'B' and datecreated < '" & dtpCollections.Text & "'", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMDX")

            myBindingSource = New BindingSource()
            myBindingSource.DataSource = ds
            myBindingSource.DataMember = ds.Tables(0).TableName
            dgvCollections.DataSource = myBindingSource

            If dgvCollections.Columns.Contains("Print") Then
            Else
                dgvCollections.Columns.Add(colPrint)
                dgvCollections.Columns("Print").Width = 45
            End If



            ds.Dispose()
            cn.Close()
         
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub
End Class


'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
'    txtTotalAmount.Text = 0
'    txtTotalPayments.Text = 0
'    txtTotalBalance.Text = 0

'    If cmbWhoPaid.Text <> "" And cmbPaymentType.Text <> "" Then

'        If txtBalance.Text > 0 Then
'            MessageBox.Show("Underapplied Charges: " & "$" & txtBalance.Text, "Underapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        ElseIf txtBalance.Text < 0 Then
'            MessageBox.Show("Overapplied Charges: " & Replace(txtBalance.Text, "-", "$"), "Overapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        Else

'            Dim i As Integer = 0
'            Try
'                For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1

'                    Dim strWhoPaid As String = cmbWhoPaid.Text
'                    'Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("WhoPaid").Value
'                    Dim strToAppend = "AmountPaid"
'                    Dim strToAppend2 = "Paid"
'                    If strWhoPaid = "WriteOff" Then
'                        Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AdjustmentAmount").Value() += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
'                    End If
'                    Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend).Value += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
'                    Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend2).Value = True



'                    Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("ThisPayment").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("GuarantorAmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance1AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance2AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance3AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AdjustmentAmount").Value
'                    Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AllowedAmount").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value - Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("ThisPayment").Value
'                    txtTotalPayments.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("ThisPayment").Value
'                    txtTotalAmount.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value
'                    txtTotalBalance.Text = txtTotalAmount.Text - txtTotalPayments.Text

'                Next


'                Me.Validate()
'                Me.MMARTRANSACTIONSBindingSource.EndEdit()
'                Me.MMARTRANSACTIONSTableAdapter.Update(Me.ARDataSet.MMARTRANSACTIONS)

'                For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
'                    Try
'                        If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value <> Nothing Then

'                            Me.ARDataSet.MMARPostPayment.PaymentReferenceColumn.DefaultValue = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("EntryNumber").Value()
'                            Me.ARDataSet.MMARPostPayment.PaymentAmountColumn.DefaultValue = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value()
'                            Me.ARDataSet.MMARPostPayment.DateModifiedColumn.DefaultValue = Format(Now, "MM/dd/yyyy")
'                            Me.ARDataSet.MMARPostPayment.WhoPaidColumn.DefaultValue = "G"
'                            Me.ARDataSet.MMARPostPayment.CaseNumberColumn.DefaultValue = CaseNumberTextBox.Text
'                            Me.MMARPostPaymentBindingSource.AddNew()

'                        End If

'                    Catch ex As Exception
'                        MessageBox.Show("Row not added to Post Payment History", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                    End Try
'                Next

'                'Me.Validate()
'                'Me.MMARPostPaymentBindingSource.EndEdit()
'                'Me.MMARPostPaymentTableAdapter.Update(Me.ARDataSet.MMARPostPayment)

'                ApplyColorScheme()

'                '*******************Clear controls
'                Dim ii As Integer
'                cmbWhoPaid.Text = ""
'                cmbPaymentType.Text = ""
'                txtTotal.Text = ""
'                txtBalance.Text = 0

'                For ii = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
'                    Me.MMARTRANSACTIONSDataGridView.Rows(ii).Cells("PaymentReceived").Value = ""
'                Next
'                '*******************
'            Catch
'                MessageBox.Show("Transaction(s) failed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        End If
'    Else
'        MessageBox.Show("Please enter required fields.", "Missing Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
'    End If

'End Sub


'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
'    txtTotalAmount.Text = 0
'    txtTotalPayments.Text = 0
'    txtTotalBalance.Text = 0

'    If cmbWhoPaid.Text <> "" And cmbPaymentType.Text <> "" Then

'        If txtBalance.Text > 0 Then
'            MessageBox.Show("Underapplied Charges: " & "$" & txtBalance.Text, "Underapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        ElseIf txtBalance.Text < 0 Then
'            MessageBox.Show("Overapplied Charges: " & Replace(txtBalance.Text, "-", "$"), "Overapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        Else

'            Dim i As Integer = 0
'            Try
'                For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
'                    If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value <> Nothing Then
'                        Dim strWhoPaid As String = cmbWhoPaid.Text
'                        Dim strToAppend = "AmountPaid"
'                        Dim strToAppend2 = "Paid"
'                        If strWhoPaid = "WriteOff" Then
'                            Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AdjustmentAmount").Value() += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
'                            Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend2).Value = True
'                        Else
'                            Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend2).Value = True
'                            Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells(strWhoPaid & strToAppend).Value += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value
'                            Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("GuarantorAmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance1AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance2AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Insurance3AmountPaid").Value + Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("AdjustmentAmount").Value
'                            Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineBalance").Value = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value - Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
'                            txtTotalPayments.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("LineTotal").Value
'                            txtTotalAmount.Text += Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("Amount").Value
'                            txtTotalBalance.Text = txtTotalAmount.Text - txtTotalPayments.Text
'                        End If   'If strWhoPaid = "WriteOff" Then
'                    End If   'If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value <> Nothing Then
'                Next

'                Me.Validate()
'                Me.MMARTRANSACTIONSBindingSource.EndEdit()
'                Me.MMARTRANSACTIONSTableAdapter.Update(Me.ARDataSet.MMARTRANSACTIONS)

'                For i = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
'                    Try
'                        If Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value <> Nothing Then

'                            Me.ARDataSet.MMARPostPayment.PaymentReferenceColumn.DefaultValue = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("EntryNumber").Value()
'                            Me.ARDataSet.MMARPostPayment.PaymentAmountColumn.DefaultValue = Me.MMARTRANSACTIONSDataGridView.Rows(i).Cells("PaymentReceived").Value()
'                            Me.ARDataSet.MMARPostPayment.DateModifiedColumn.DefaultValue = Format(Now, "MM/dd/yyyy")

'                            Dim WhoPaid As String

'                            If cmbWhoPaid.Text = "Guarantor" Then
'                                WhoPaid = "G"
'                            ElseIf cmbWhoPaid.Text = "Insurance1" Then
'                                WhoPaid = "1"
'                            ElseIf cmbWhoPaid.Text = "Insurance2" Then
'                                WhoPaid = "2"
'                            ElseIf cmbWhoPaid.Text = "Insurance3" Then
'                                WhoPaid = "3"
'                            End If

'                            Me.ARDataSet.MMARPostPayment.WhoPaidColumn.DefaultValue = WhoPaid
'                            Me.ARDataSet.MMARPostPayment.CaseNumberColumn.DefaultValue = CaseNumberTextBox.Text
'                            Me.MMARPostPaymentBindingSource.AddNew()

'                        End If

'                    Catch ex As Exception
'                        MessageBox.Show("Row not added to Post Payment History", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                    End Try
'                Next

'                'Me.Validate()
'                'Me.MMARPostPaymentBindingSource.EndEdit()
'                'Me.MMARPostPaymentTableAdapter.Update(Me.ARDataSet.MMARPostPayment)

'                ApplyColorScheme()

'                '*******************Clear controls
'                Dim ii As Integer
'                cmbWhoPaid.Text = ""
'                cmbPaymentType.Text = ""
'                txtTotal.Text = ""
'                txtBalance.Text = 0

'                For ii = 0 To MMARTRANSACTIONSDataGridView.Rows.Count - 1
'                    Me.MMARTRANSACTIONSDataGridView.Rows(ii).Cells("PaymentReceived").Value = ""
'                Next
'                '*******************
'            Catch
'                MessageBox.Show("Transaction(s) failed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            End Try
'        End If
'    Else
'        MessageBox.Show("Please enter required fields.", "Missing Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
'    End If
'    CalculateTotals()
'End Sub




'Dim WhoPaid As String

'If cmbWhoPaid.Text = "Guarantor" Then
'    WhoPaid = "G"
'ElseIf cmbWhoPaid.Text = "Insurance1" Then
'    WhoPaid = "1"
'ElseIf cmbWhoPaid.Text = "Insurance2" Then
'    WhoPaid = "2"
'ElseIf cmbWhoPaid.Text = "Insurance3" Then
'    WhoPaid = "3"
'End If