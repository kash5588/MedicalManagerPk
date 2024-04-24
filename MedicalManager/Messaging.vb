Public Class Messaging
    Dim ChartNumber As String
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(3) As String
    Dim objCurrentPatient As New CurrentPat
    Dim arrayMdiInfo(3) As String
    Dim arrayComments(1) As String

    Public Function ShowMessages(ByVal aMdiInfo() As String) As String()
        arrayMdiInfo = aMdiInfo
        ChartNumber = arrayMdiInfo(1)
        Me.Show()
    End Function

    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        Dim FrmProcedure As New Procedure
        aRet = PATIENT.ShowPicklist
        If aRet(0) = "Y" Then
            ChartNumberTextBox.Text = aRet(1)
            NameTextBox.Text = aRet(2) & " " & aRet(4) & " " & aRet(3)
        End If
    End Sub

    Private Sub cmdComments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComments.Click
        Dim FrmProcedure As New MessageList
        arrayComments = MessageList.ShowPicklist
        If arrayComments(0) = "Y" Then
            If SubjectTextBox.Text = "" Then
                SubjectTextBox.Text = arrayComments(1)
            Else
                SubjectTextBox.Text = SubjectTextBox.Text & Environment.NewLine & arrayComments(1)
            End If
            'Trim(SubjectTextBox.Text) & "         " & 
        End If
    End Sub

    Private Sub MessagingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessagingBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MessagingBindingSource.EndEdit()
            Me.MessagingTableAdapter.Update(Me.MMDataDataSet1.Messaging)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Messaging_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        ChartNumber = ""
    End Sub

    Private Sub Messaging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
        LoadComboBoxes2()
        If ChartNumber <> "" Then
            Me.MessagingTableAdapter.FillChartNumber(Me.MMDataDataSet1.Messaging, ChartNumber)
        Else
            Me.MessagingTableAdapter.FillByDesc(Me.MMDataDataSet1.Messaging)
        End If
        cmbFilter.SelectedIndex = 0
    End Sub

    Private Sub FillByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByDate.Click
        Me.MessagingTableAdapter.FillByDate(Me.MMDataDataSet1.Messaging, System.DateTime.Today)
    End Sub

    Private Sub GreaterThanDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreaterThanDate.Click
        Me.MessagingTableAdapter.FillByGreaterThanDate(Me.MMDataDataSet1.Messaging, DateTimePicker2.Value)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        objCurrentPatient.ChartNumber = ChartNumberTextBox.Text
    End Sub

    Private Sub MessagingBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MessagingBindingSource.AddingNew
        Dim strValue As String
        Me.MMDataDataSet1.Messaging.DateColumn.DefaultValue = Format(Now, "MM/dd/yyyy")
        Me.MMDataDataSet1.Messaging.ChartNumberColumn.DefaultValue = arrayMdiInfo(1)
        Me.MMDataDataSet1.Messaging.NameColumn.DefaultValue = arrayMdiInfo(2) + " " + arrayMdiInfo(3)
        Me.MMDataDataSet1.Messaging.SignatureColumn.DefaultValue = False
        strValue = GetGeneralInfo("MessagingStatus")
        Me.MMDataDataSet1.Messaging.StatusColumn.DefaultValue = strValue
    End Sub

    Private Function LoadComboBoxes2()
        Try
            Dim dr As DataRow

            Dim dt As DataTable
            dt = Me.MMDataDataSet1.Tables("MMCombo")

            For Each dr In dt.Rows
                If dr("MessageFrom") <> "N/A" Then
                    MessageFromComboBox.Items.Add(dr("MessageFrom"))
                End If
            Next

            For Each dr In dt.Rows
                If dr("MessageTo") <> "N/A" Then
                    MessageToComboBox.Items.Add(dr("MessageTo"))
                End If
            Next

            For Each dr In dt.Rows
                If dr("Status") <> "N/A" Then
                    StatusComboBox.Items.Add(dr("Status"))
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Loading Comboboxes")
        End Try

    End Function

    Private Sub MessagingDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MessagingDataGridView.CellFormatting
        Try
            If MessagingDataGridView.Columns(e.ColumnIndex).Name.Equals("dgcStatus") Then
                'If e.ColumnIndex = 7 Then
                If Not IsDBNull(e.Value) Then
                    If Trim(e.Value) <> "COMPLETED" Then
                        MessagingDataGridView.Rows(e.RowIndex).Cells("dgcSubject").Style.BackColor = Drawing.Color.Cyan()
                        'e.CellStyle.BackColor = Drawing.Color.Cyan
                    End If
                Else
                    MessagingDataGridView.Rows(e.RowIndex).Cells("dgcSubject").Style.BackColor = Drawing.Color.Cyan()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.MessagingBindingSource.AddNew()
    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp

        If cmbFilter.Text = "Date" Then
            'Me.MessagingBindingSource.Filter = "EntryNumber" & " like" & "'" & txtFind.Text & "%'"
        Else
            Me.MessagingBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
        End If
        Me.MessagingBindingSource.Sort = "ChartNumber"
        MessagingDataGridView.DataSource = Me.MessagingBindingSource
      
    End Sub

    Private Sub SubjectTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SubjectTextBox.Validating
        SubjectTextBox.Text = SubjectTextBox.Text.Trim
    End Sub

    Private Sub Messaging_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim msgText As String
        Dim result As DialogResult
        Try
            If Me.Validate Then
                Me.MessagingBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            If Me.MMDataDataSet1.Messaging.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.MessagingTableAdapter.Update(Me.MMDataDataSet1.Messaging)
                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.Messaging.RejectChanges()
                    Case Else
                        e.Cancel = True
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Messages form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try
    End Sub

    Private Function GetGeneralInfo(ByVal strMessagingStatus As String) As String

        Dim dtGeneralInfo As New DataTable
        Dim row As DataRow
        Dim strValue As String
        Me.GeneralInfoTableAdapter.Fill(Me.MMDataDataSet2.GeneralInfo)
        dtGeneralInfo = Me.MMDataDataSet2.Tables("GeneralInfo")

        For Each row In dtGeneralInfo.Rows
            Select Case row("GeneralInfoKey").ToString()
                Case strMessagingStatus
                    strValue = row("GeneralInfoValue").ToString()
            End Select
        Next
        Return strValue
    End Function

End Class