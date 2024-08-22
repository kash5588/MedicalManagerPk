
Public Class VitalSigns
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(10) As String
    Dim ChartNumber As String
    Dim objCurrentPatient As New CurrentPat

    Public Function ShowVitalSigns(ByVal bRet() As String) As String()
        aRet = bRet
        ChartNumber = bRet(1)
        Me.Show()
    End Function

    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        Dim FrmProcedure As New Procedure
        aRet = PATIENT.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab
            ChartNumberTextBox.Text = aRet(1)
        End If
    End Sub

    Private Sub VitalSigns_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Try
        TempTextBox.Focus()
        'Catch
        'End Try
    End Sub

      Private Sub VitalSigns_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MMChartTVitalSignTableAdapter.FillByChNo(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumber)
    End Sub

      'Private Sub MMChartTVitalSignBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      '      Me.Validate()
      '      Me.MMChartTVitalSignBindingSource.EndEdit()
      '      Me.MMChartTVitalSignTableAdapter.Update(Me.MMDataDataSet1.MMChartTVitalSign)
      'End Sub

      Private Sub FillByChNoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                  Me.MMChartTVitalSignTableAdapter.FillByChNo(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumber)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

      End Sub

      Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        objCurrentPatient.ChartNumber = ChartNumberTextBox.Text
        TabControl1.SelectedTab = TabControl1.TabPages(1)
        TempTextBox.Focus()
    End Sub

      Private Sub MMChartTVitalSignBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMChartTVitalSignBindingSource.AddingNew
        Me.MMDataDataSet1.MMChartTVitalSign.ChartNumberColumn.DefaultValue = aRet(1)
        Me.MMDataDataSet1.MMChartTVitalSign.NameColumn.DefaultValue = aRet(2) + ", " + aRet(3)

        If aRet(10) <> "" Then ' when we come from visit list and Visit page
            Me.MMDataDataSet1.MMChartTVitalSign.CaseNumberColumn.DefaultValue = aRet(10)
            If aRet(9) <> "" Then  ' when u come from visit list
                Me.MMDataDataSet1.MMChartTVitalSign.DateColumn.DefaultValue = aRet(9)
                Me.MMDataDataSet1.MMChartTVitalSign.TimeColumn.DefaultValue = aRet(9)
                Me.MMDataDataSet1.MMChartTVitalSign.UserColumn.DefaultValue = globalUser
            Else
                Me.MMDataDataSet1.MMChartTVitalSign.DateColumn.DefaultValue = System.DateTime.Now.Date
                Me.MMDataDataSet1.MMChartTVitalSign.TimeColumn.DefaultValue = System.DateTime.Now.Date
                Me.MMDataDataSet1.MMChartTVitalSign.UserColumn.DefaultValue = globalUser
            End If


        Else
            Me.MMDataDataSet1.MMChartTVitalSign.CaseNumberColumn.DefaultValue = 0
            Me.MMDataDataSet1.MMChartTVitalSign.DateColumn.DefaultValue = System.DateTime.Now.Date
            Me.MMDataDataSet1.MMChartTVitalSign.TimeColumn.DefaultValue = System.DateTime.Now
            Me.MMDataDataSet1.MMChartTVitalSign.UserColumn.DefaultValue = globalUser
        End If

        Me.MMDataDataSet1.MMChartTVitalSign.TimeStampColumn.DefaultValue = System.DateTime.Now

    End Sub

      Private Sub MMChartTVitalSignBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartTVitalSignBindingNavigatorSaveItem.Click
            Try
                  Me.Validate()
                  Me.MMChartTVitalSignBindingSource.EndEdit()
                  Me.MMChartTVitalSignTableAdapter.Update(Me.MMDataDataSet1.MMChartTVitalSign)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        If TempR.Checked = True Then
            TempTextBox.Text = TempTextBox.Text & ListBox1.Text
        ElseIf RespR.Checked = True Then
            RespTextBox.Text = RespTextBox.Text & ListBox1.Text
        ElseIf PulseOxR.Checked = True Then
            PulseOxTextBox.Text = PulseOxTextBox.Text & ListBox1.Text
        ElseIf PulseR.Checked = True Then
            PulseTextBox.Text = PulseTextBox.Text & ListBox1.Text
        ElseIf HTR.Checked = True Then
            HtTextBox.Text = HtTextBox.Text & ListBox1.Text
        ElseIf WTR.Checked = True Then
            WtTextBox.Text = WtTextBox.Text & ListBox1.Text
        ElseIf SystolicR.Checked = True Then
            SystolicTextBox.Text = SystolicTextBox.Text & ListBox1.Text
        ElseIf SystolicR.Checked = True Then
            SystolicTextBox.Text = SystolicTextBox.Text & ListBox1.Text
        ElseIf DistolicR.Checked = True Then
            DistolicTextBox.Text = DistolicTextBox.Text & ListBox1.Text

        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If TempR.Checked = True Then
            TempTextBox.Text = ""
        ElseIf RespR.Checked = True Then
            RespTextBox.Text = ""
        ElseIf PulseOxR.Checked = True Then
            PulseOxTextBox.Text = ""
        ElseIf PulseR.Checked = True Then
            PulseTextBox.Text = ""
        ElseIf HTR.Checked = True Then
            HtTextBox.Text = ""
        ElseIf WTR.Checked = True Then
            WtTextBox.Text = ""
        ElseIf SystolicR.Checked = True Then
            SystolicTextBox.Text = ""
        ElseIf SystolicR.Checked = True Then
            SystolicTextBox.Text = ""
        ElseIf DistolicR.Checked = True Then
            DistolicTextBox.Text = ""

        End If
    End Sub

    Private Sub MMChartTVitalSign_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.MMChartTVitalSignBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            ' See if any changes were made, but not saved 
            If Me.MMDataDataSet1.MMChartTVitalSign.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                msgText = msgText & ControlChars.CrLf & _
                    "Save changes?"
                'msgText = msgText & ControlChars.CrLf & "Save the changes ?"

                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.MMChartTVitalSignTableAdapter.Update(Me.MMDataDataSet1.MMChartTVitalSign)

                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.MMChartTVitalSign.RejectChanges()

                    Case Else
                        ' do nothing and cancel closing of the form
                        e.Cancel = True

                End Select
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try
    End Sub

    Private Sub BMITextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BMITextBox.GotFocus
        CalculateBMI()
    End Sub

    Private Function CalculateBMI() As String
        Dim strWeight As String = WtTextBox.Text
        Dim strHeight As String = HtTextBox.Text
        Dim strBMI As Decimal

        Try
            If WtTextBox.Text <> "" And HtTextBox.Text <> "" Then
                strBMI = (WtTextBox.Text / (HtTextBox.Text * HtTextBox.Text)) * 703
                strBMI = FormatNumber(strBMI, 1, , , TriState.False)
                BMITextBox.Text = strBMI
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Calculating BMI")
        End Try

    End Function


    Private Sub HtTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles HtTextBox.Leave
        CalculateBMI()
    End Sub


    Private Sub WtTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles WtTextBox.Leave
        CalculateBMI()
    End Sub

   
    Private Sub btnCalender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalender.Click
        If MonthCalendar1.Visible = True Then
            MonthCalendar1.Visible = False
        Else
            MonthCalendar1.Visible = True
        End If
    End Sub



    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        LMPTextBox.Text = LMPTextBox.Text & " " & (CType(MonthCalendar1.SelectionRange.Start.Date, Date))
    End Sub
End Class