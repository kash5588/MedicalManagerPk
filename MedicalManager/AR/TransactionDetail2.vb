Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class TransactionDetail2

    Dim aRetBilling(7) As String
    Dim myBindingSource As New BindingSource()
    Private MouseIsDown As Boolean = False
    Dim TransactionsChartnumber As String

    Private Sub TransactionDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.MMARDepositTableAdapter.Fill(Me.ARDataSet.MMARDeposit)
            Me.MMARPostPaymentTableAdapter.Fill(Me.ARDataSet.MMARPostPayment)
            Me.BillingHeaderTableAdapter.Fill(Me.ARDataSet.BillingHeader)
            Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)

            If TransactionsChartnumber <> "" Then
                Me.BillingHeaderBindingSource.Filter = "ChartNumber like" & "'" & TransactionsChartnumber & "%'"
                Me.BillingHeaderBindingSource.Sort = "ChartNumber"
                BillingHeaderDataGridView.DataSource = Me.BillingHeaderBindingSource
            End If

            LoadComboBoxes2()
            CalculateTotals()
            If Not CaseNumberTextBox.Text = "" Then
                ApplyColorScheme()
            End If
            LoadPayerNameCbo()
            txtPayorName.Focus()
            PreventColReorder()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in TransactionDetailLoad")
        End Try
    End Sub

#Region "Standard"

    Private Sub TransactionDetail2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then

                Me.BillingDetailBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            If Me.ARDataSet.BillingDetail.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.BillingDetailTableAdapter.Update(Me.ARDataSet.BillingDetail)
                    Case Windows.Forms.DialogResult.No
                        Me.ARDataSet.BillingDetail.RejectChanges()

                    Case Else
                        e.Cancel = True
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Patient form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
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
        Me.Validate()
        Me.BillingHeaderBindingSource.EndEdit()
        Me.BillingHeaderTableAdapter.Update(Me.ARDataSet.BillingHeader)
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

        Try
            If BillingDetailDataGridView.Rows(hit.RowIndex).Cells(hit.ColumnIndex).OwningColumn.Name.ToString = "Payment" Then
                ' ElseIf BillingDetailDataGridView.Rows(hit.RowIndex).Cells("BDExtended").Value.ToString.Contains("-") = False Then

                If BillingDetailDataGridView.Rows(hit.RowIndex).Cells("BDCharge").Value.ToString = "" Then
                    MessageBox.Show("Drag payment into a charge column")
                Else
                    BillingDetailDataGridView.Rows(hit.RowIndex).Cells(hit.ColumnIndex).Value = e.Data.GetData(DataFormats.Text)
                End If
            Else
                MessageBox.Show("Drag amount to payment column")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
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
                LoadPayerNameCbo()
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
                If Me.BillingDetailDataGridView.Rows(i).Cells("Payments").Value.ToString.Contains("-") Then
                    txtTotalPayments.Text += Me.BillingDetailDataGridView.Rows(i).Cells("Payments").Value
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
            lblBalance.Text = CDec(txtTotalBalance.Text).ToString("c")



        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in CalculateTotals")
        End Try
    End Function

    Private Sub btnApplyCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApplyCharges.Click
        Dim i As Integer

        Try
            If cmbWhoPaid.Text <> "" And cmbPaymentType.Text <> "" And txtTotal.Text <> "" Then
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
                            newRow("Payments") = "-" & BillingDetailDataGridView.Rows(i).Cells("Payment").Value.ToString
                            newRow("CPTCode") = BillingDetailDataGridView.Rows(i).Cells("BDCPTCode").Value.ToString
                            newRow("AssignedProvider") = BillingDetailDataGridView.Rows(i).Cells("BDAssignedProvider").Value.ToString
                            'newRow("TransactionCode") = BillingDetailDataGridView.Rows(i).Cells("").Value.ToString
                            newRow("Units") = BillingDetailDataGridView.Rows(i).Cells("BDUnits").Value.ToString
                            newRow("ServiceDate1") = BillingDetailDataGridView.Rows(i).Cells("BDServiceDate1").Value.ToString
                            ' newRow("DateCreated") = BillingDetailDataGridView.Rows(i).Cells("BDDateCreated").Value.ToString
                            newRow("DateEntered") = Format(Now, "MM/dd/yyyy")
                            newRow("PayorName") = txtPayorName.Text
                            newRow("PayorType") = cmbWhoPaid.Text
                            newRow("CheckNumber") = txtCheckNumber.Text
                            newRow("PaymentMethod") = cmbPaymentType.Text
                            newRow("PaymentDate") = DateTimePicker1.Text

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
                    Me.BillingDetailBindingSource.EndEdit()
                    Me.BillingDetailTableAdapter.Update(Me.ARDataSet.BillingDetail)

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

                    Me.BillingDetailTableAdapter.FillByCaseNumber(Me.ARDataSet.BillingDetail, CaseNumberTextBox.Text)

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

            '  Dim font As New Font(BillingDetailDataGridView.DefaultCellStyle.Font.FontFamily, BillingDetailDataGridView.DefaultCellStyle.Font.Size, FontStyle.Regular)

            For i = 0 To BillingDetailDataGridView.Rows.Count - 1

                If Me.BillingDetailDataGridView.Rows(i).Cells("BDLineBalance").Value = 0 And Me.BillingDetailDataGridView.Rows(i).Cells("Payments").Value.ToString.Contains("-") = False Then
                    BillingDetailDataGridView.Rows(i).Cells("BDLineBalance").Style.BackColor = Color.FromArgb(164, 229, 147)
                    BillingDetailDataGridView.Rows(i).Cells("ImageCol").Value = My.Resources.RedCross
                ElseIf Me.BillingDetailDataGridView.Rows(i).Cells("BDLineBalance").Value > 0 Then
                    BillingDetailDataGridView.Rows(i).Cells("BDLineBalance").Style.BackColor = Color.FromArgb(248, 160, 170)
                    BillingDetailDataGridView.Rows(i).Cells("ImageCol").Value = My.Resources.RedCross

                End If

                If Me.BillingDetailDataGridView.Rows(i).Cells("Payments").Value.ToString.Contains("-") Then
                    BillingDetailDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                    BillingDetailDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    BillingDetailDataGridView.Rows(i).Cells("ImageCol").Value = My.Resources.tealdollar

                    '  BillingDetailDataGridView.Rows(i).DefaultCellStyle.Font = font
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
        'Dim i As Integer = 0
        'Dim strTotalPayments As String = 0
        'Dim strTotalAmount As String = 0
        'Dim strTotalBalance As String = 0

        'Try
        '    For i = 0 To BillingDetailDataGridView.Rows.Count - 1
        '        If Me.BillingDetailDataGridView.Rows(i).Cells("Payments").Value.ToString.Contains("-") Then
        '            strTotalPayments += Me.BillingDetailDataGridView.Rows(i).Cells("Payments").Value
        '        Else
        '            strTotalAmount += Me.BillingDetailDataGridView.Rows(i).Cells("BDExtended").Value
        '        End If
        '    Next

        '    BillingHeaderDataGridView.SelectedRows(0).Cells("BHPayments").Value = strTotalPayments - 0
        '    BillingHeaderDataGridView.SelectedRows(0).Cells("BHCharges").Value = strTotalAmount - 0
        '    BillingHeaderDataGridView.SelectedRows(0).Cells("BHTotal").Value = (strTotalAmount - 0) + (strTotalPayments - 0)

        '    Me.Validate()
        '    Me.BillingHeaderBindingSource.EndEdit()
        '    Me.BillingHeaderTableAdapter.Update(Me.ARDataSet.BillingHeader)

        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString, "Error in UpdateHeader")
        'End Try




        Try
            BillingHeaderDataGridView.SelectedRows(0).Cells("BHPayments").Value = txtTotalPayments.Text
            BillingHeaderDataGridView.SelectedRows(0).Cells("BHCharges").Value = txtTotalAmount.Text
            BillingHeaderDataGridView.SelectedRows(0).Cells("BHTotal").Value =  txtTotalBalance.Text
            Me.Validate()
            Me.BillingHeaderBindingSource.EndEdit()
            Me.BillingHeaderTableAdapter.Update(Me.ARDataSet.BillingHeader)

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error in UpdateHeader")
        End Try
    End Function

    Private Sub btnViewBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewBill.Click
        ARNewBill.ReportShow(ChartNumberTextBox.Text, CaseNumberTextBox.Text)
    End Sub

    Private Sub txtTotal_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTotal.Leave
        RefreshtxtBalance()
    End Sub

    Private Function RefreshtxtBalance()
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

                If txtTotal.Text = "" Then
                    txtBalance.Text = 0 - sumThispayment
                Else
                    txtBalance.Text = txtTotal.Text - sumThispayment
                End If

                If txtBalance.Text < 0 Then
                    MessageBox.Show("Overapplied Charges: " & Replace(txtBalance.Text, "-", "$"), "Overapplied Charges", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If  '  If BillingDetailDataGridView.Rows.Count Then
        Catch ex As Exception
            'MessageBox.Show(ex.ToString, "Error in CellValueChanged")
        End Try
    End Function

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        Try
            If cmbFilter.Text <> "" Then
                Me.BillingHeaderBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
            End If

            Me.BillingHeaderBindingSource.Sort = "ChartNumber"
            BillingHeaderDataGridView.DataSource = Me.BillingHeaderBindingSource
        Catch
        End Try
    End Sub

    Public Function ShowTransactions(ByVal ChartNumber As String) As String()
        TransactionsChartnumber = ChartNumber
        Me.Show()
    End Function

    Private Sub cmbWhoPaid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbWhoPaid.SelectedIndexChanged
        Dim strValue As String = ""
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        Dim cmd As New SqlCommand

        If txtPayorName.Text = "" Then
            cn.Open()


            If cmbWhoPaid.Text.ToLower = "insurance1" Then
                cmd = New SqlCommand("SELECT InsCoName FROM MMPatient WHERE ChartNumber  = '" & ChartNumberTextBox.Text & "'", cn)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                While dr.Read
                    strValue = dr.Item(0).ToString
                End While
                cn.Close()
                txtPayorName.Text = strValue
            ElseIf cmbWhoPaid.Text.ToLower = "insurance2" Then
                cmd = New SqlCommand("SELECT InsCoName2 FROM MMPatient WHERE ChartNumber  = '" & ChartNumberTextBox.Text & "'", cn)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                While dr.Read
                    strValue = dr.Item(0).ToString
                End While
                cn.Close()
                txtPayorName.Text = strValue
            End If

          

        End If


    End Sub

    Private Function LoadPayerNameCbo()
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        Dim dr As SqlDataReader = Nothing
        Dim ii As Integer
        Try
            txtPayorName.Items.Clear()
            cn.Open()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("select i1.Name, i2.Name, firstname + ' ' + lastname + '- cash' as NameCash, firstname + ' ' + lastname + '- credit card' as NameCC,firstname + ' ' + lastname + '- check' as NameCheck from mmpatient bh left join MMINSURENCE i1 on bh.InsCoId = i1.Code left join MMINSURENCE i2 on bh.InsCoId2 = i2.Code where ChartNumber = '" & ChartNumberTextBox.Text & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read
                Dim i As Integer = dr.FieldCount
                For ii = 0 To dr.FieldCount - 1
                    If dr.Item(ii).ToString & "" <> "" Then
                        txtPayorName.Items.Add(dr.Item(ii).ToString)
                    End If
                Next
            End While
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cn.Close()
            dr.Close()
        End Try
    End Function

    Private Function PreventColReorder()
        Dim i As Integer
        For i = 0 To BillingDetailDataGridView.Columns.Count - 1
            BillingDetailDataGridView.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
    End Function

    Private Sub txtTotal_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTotal.KeyUp
        RefreshtxtBalance()
    End Sub

    Private Sub WriteOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteOffToolStripMenuItem.Click
        Try
            If Not IsDBNull(BillingDetailDataGridView.SelectedRows(0).Cells("BDLineBalance").Value) Then
                Dim newRow As DataRow = Me.ARDataSet.BillingDetail.NewRow
                newRow("CaseNumber") = BillingDetailDataGridView.SelectedRows(0).Cells("BDCaseNumber").Value.ToString
                newRow("ChartNumber") = BillingDetailDataGridView.SelectedRows(0).Cells("BDChartNumber").Value.ToString
                newRow("Payments") = "-" & BillingDetailDataGridView.SelectedRows(0).Cells("BDLineBalance").Value.ToString
                newRow("CPTCode") = BillingDetailDataGridView.SelectedRows(0).Cells("BDCPTCode").Value.ToString
                newRow("AssignedProvider") = BillingDetailDataGridView.SelectedRows(0).Cells("BDAssignedProvider").Value.ToString
                newRow("Units") = BillingDetailDataGridView.SelectedRows(0).Cells("BDUnits").Value.ToString
                newRow("ServiceDate1") = BillingDetailDataGridView.SelectedRows(0).Cells("BDServiceDate1").Value.ToString
                newRow("DateEntered") = Format(Now, "MM/dd/yyyy")
                newRow("PayorType") = "WRITE OFF"
                newRow("PaymentMethod") = "WRITE OFF"
                newRow("PaymentDate") = Format(Now, "MM/dd/yyyy")
                Dim a As String = Me.BillingDetailDataGridView.SelectedRows(0).Cells("BDId").Value()
                Me.BillingDetailDataGridView.SelectedRows(0).Cells("BDReceived").Value() += Me.BillingDetailDataGridView.SelectedRows(0).Cells("BDLineBalance").Value.ToString
                Me.Validate()
                Me.BillingDetailBindingSource.EndEdit()
                Me.BillingDetailTableAdapter.Update(Me.ARDataSet.BillingDetail)
                Me.ARDataSet.BillingDetail.Rows.Add(newRow)
                Me.BillingDetailTableAdapter.Update(Me.ARDataSet.BillingDetail)
                Me.BillingDetailTableAdapter.FillByCaseNumber(Me.ARDataSet.BillingDetail, CaseNumberTextBox.Text)
                CalculateTotals()
                ApplyColorScheme()
                UpdateHeader()
            End If
        Catch
            MessageBox.Show("error cancelling appointment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BillingDetailDataGridView_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles BillingDetailDataGridView.CellMouseDown
        If e.Button = MouseButtons.Right Then
            BillingDetailDataGridView.Rows(e.RowIndex).Selected = True
        End If
    End Sub

   
End Class