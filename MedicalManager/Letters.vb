Public Class Letters


    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(4) As String

    Private Sub LettersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LettersBindingNavigatorSaveItem.Click
        'If ChartNumberTextBox.Text = "" Then
        '    MessageBox.Show("Letter cannot be saved without being assigned to someone." & Environment.NewLine & "Click the ""Regarding"" button to pick up a patient to assign the letter to.", "What Pt is this letter/consent assigned to?", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Else
        Me.Validate()
        Me.LettersBindingSource.EndEdit()
        Me.LettersTableAdapter.Update(Me.MMDataDataSet2.Letters)
        BindingNavigatorAddNewItem.Visible = True
        'End If
    End Sub

    Private Sub Letters_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        LetterToTextBox.Focus()
    End Sub

    Private Sub Letters_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.LettersBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If


            If Me.MMDataDataSet2.Letters.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

                Select Case result
                    Case Windows.Forms.DialogResult.Yes


                        'If ChartNumberTextBox.Text = "" Then
                        '    MessageBox.Show("Letter cannot be saved without being assigned to someone." & Environment.NewLine & "Click the ""Regarding"" button to pick up a patient to assign the letter to.", "What Pt is this letter/consent assigned to?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    e.Cancel = True
                        'Else
                        Me.LettersTableAdapter.Update(Me.MMDataDataSet2.Letters)
                        'End If

                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet2.Letters.RejectChanges()

                    Case Else
                        e.Cancel = True

                End Select
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Letter form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try

    End Sub


    Private Sub Letters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.Letters' table. You can move, or remove it, as needed.
        Me.LettersTableAdapter.Fill(Me.MMDataDataSet2.Letters)
        'TODO: This line of code loads data into the 'MMDataDataSet1.VisitReportPractice' table. You can move, or remove it, as needed.
        Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)
        Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
        Try
            ADDLetter()
            LoadComboBoxes2()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnGetPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPatient.Click
        Try
            aRet = PickList.PatientShowPicklist
            If aRet(0) = "Y" Then       ' they picked a lab
                ChartNumberTextBox.Text = aRet(1).Trim
                lblChartNumber.Text = aRet(1).Trim
                LetterToTextBox.Text = aRet(3).Trim & " " & aRet(4).Trim & " " & aRet(2).Trim
                If aRet(9).Trim <> "" Then
                    AddressTextBox.Text = aRet(8).Trim & Environment.NewLine & aRet(9).Trim & Environment.NewLine & aRet(10).Trim & ", " & aRet(11).Trim & " " & aRet(12).Trim
                Else
                    AddressTextBox.Text = aRet(8).Trim & Environment.NewLine & aRet(10).Trim & ", " & aRet(11).Trim & " " & aRet(12).Trim
                End If
                LetterRegardingTextBox.Text = aRet(2).Trim & ", " & aRet(3).Trim & " " & aRet(4).Trim & "  " & aRet(7).Trim
                GreetTextBox.Text = "Dear " & aRet(3).Trim & " " & aRet(2).Trim & ":"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Picking Patient")
        End Try
    End Sub

    Private Sub btnGetPhysician_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPhysician.Click
        Try
            aRet = PickList.PhysicianShowPicklist
            If aRet(0) = "Y" Then
                LetterToTextBox.Text = "Dr. " & aRet(3).Trim & " " & aRet(4).Trim & " " & aRet(2).Trim

                If aRet(6).Trim <> "" Then
                    AddressTextBox.Text = aRet(5).Trim & Environment.NewLine & aRet(6).Trim & Environment.NewLine & aRet(7).Trim & ", " & aRet(8).Trim & " " & aRet(9).Trim
                Else
                    AddressTextBox.Text = aRet(5).Trim & Environment.NewLine & aRet(7).Trim & ", " & aRet(8).Trim & " " & aRet(9).Trim
                End If
                GreetTextBox.Text = "Dear Dr. " & aRet(3).Trim & " " & aRet(2).Trim & ":"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Picking Physician")
        End Try
    End Sub

    Private Sub btnRegarding_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegarding.Click
        Try
            aRet = PickList.PatientShowPicklist
            If aRet(0) = "Y" Then       ' they picked a lab
                ChartNumberTextBox.Text = aRet(1).Trim
                lblChartNumber.Text = aRet(1).Trim
                LetterRegardingTextBox.Text = aRet(2).Trim & ", " & aRet(3).Trim & " " & aRet(4).Trim & "  " & aRet(7).Trim
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error With Regarding")
        End Try
    End Sub

    Private Sub LettersBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles LettersBindingSource.AddingNew
        Me.MMDataDataSet2.Letters.DateColumn.DefaultValue = Format(Now, "MM/dd/yyyy")
        Me.MMDataDataSet2.Letters.LetterFromColumn.DefaultValue = Me.MMDataDataSet1.VisitReportPractice.Rows(0)("PracticeName").ToString()
        Me.MMDataDataSet2.Letters.LetterCloseColumn.DefaultValue = "Sincerely,"
        Me.MMDataDataSet2.Letters.DescriptionColumn.DefaultValue = "Letter Body"
        LetterToTextBox.Focus()
    End Sub

    Private Sub btnImportText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportText.Click
        Try
            aRet = PickList.LetterBodyShowPicklist
            If aRet(0) = "Y" Then
                TextTextBox.Text = aRet(1).Trim
                TextBox1.Text = aRet(2).Trim
            End If
            If TextBox1.Text = "Consents" Then
                LetterCloseComboBox.Text = ""
                LetterFromTextBox.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Importing Text")
        End Try
    End Sub

    Private Sub btnRefreshReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshReport.Click
        Try
            'If ChartNumberTextBox.Text = "" Then
            '    MessageBox.Show("Click the ""Regarding"" button to pick up a patient to assign the letter to.", "What Pt is this letter/consent assigned to?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            Me.Validate()
            Me.LettersBindingSource.EndEdit()
            Me.LettersTableAdapter.Update(Me.MMDataDataSet2.Letters)

            ReportViewer1.Reset()
            Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
            Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource

            ReportDataSource1.Name = "MMDataDataSet2_Letters"
            ReportDataSource1.Value = Me.LettersBindingSource
            ReportDataSource2.Name = "MMDataDataSet1_VisitReportPractice"
            ReportDataSource2.Value = Me.VisitReportPracticeBindingSource

            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)

            Me.ReportViewer1.LocalReport.DisplayName = "Letters"
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Letter.rdlc"

            Me.LettersBindingSource.DataMember = "Letters"
            Me.LettersBindingSource.DataSource = Me.MMDataDataSet2

            Me.VisitReportPracticeBindingSource.DataMember = "VisitReportPractice"
            Me.VisitReportPracticeBindingSource.DataSource = Me.MMDataDataSet1

            Me.LettersTableAdapter.FillByID(Me.MMDataDataSet2.Letters, IDTextBox.Text)
            Me.VisitReportPracticeTableAdapter.Fill(Me.MMDataDataSet1.VisitReportPractice)
            Me.ReportViewer1.RefreshReport()
            BindingNavigatorAddNewItem.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Refreshing Report")
        End Try
    End Sub

    Public Function ADDLetter() As String()
        Try
            LettersBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Adding Letter")
        End Try
    End Function


    Private Function LoadComboBoxes2()
        Try
            Dim dr As DataRow

            Dim dt As DataTable
            dt = Me.MMDataDataSet1.Tables("MMCombo")

            For Each dr In dt.Rows
                If dr("LetterFrom") <> "N/A" Then
                    LetterFromTextBox.Items.Add(dr("LetterFrom"))
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Loading Comboboxes")
        End Try
    End Function



End Class





