Imports FAXCOMLib
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms
Imports Microsoft.Office.Interop
Imports System.Net.Mail
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Prescription
    Dim ChartNumber As String
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(10) As String
    Dim bRet(4) As String
    Dim objCurrentPatient As New CurrentPat
    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)
    Dim strDEA As String
    Dim PhyCode As String
    Dim myBindingSource As New BindingSource()
    Dim RefillCounter As Integer


    Private Sub Prescription_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MMChartRxTableAdapter.FillByChartAndActive(Me.MMDataDataSet1.MMChartRx, ChartNumber)
        Me.MMComboTableAdapter.Fill(Me.MMDataDataSet1.MMCombo)
        Me.MMPrecticeTableAdapter.Fill(Me.MMDataDataSet1.MMPrectice)
        LoadPhyDea()
        LoadDrugs()
        LockControls()
        LoadComboBoxes()
        If globalTemplate <> "" Then
            Me.Text = "Prescription" + "                                                                             " + globalTemplate + "- " + globalChiefComplaint
        End If
    End Sub

    Public Function ShowPrescriptions(ByVal dRet() As String) As String()
        aRet = dRet
        ChartNumber = dRet(1)
        Me.Show()
        Me.TabControl1.SelectedIndex = 1
    End Function

    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        Dim FrmProcedure As New Procedure
        aRet = PATIENT.ShowPicklist
        If aRet(0) = "Y" Then
            ChartNumberTextBox.Text = aRet(1)
            PatientNameTextBox.Text = aRet(2) & " " & aRet(3)
        End If
    End Sub

    Private Sub MMChartRxBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartRxBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MMChartRxBindingSource.EndEdit()
            Me.MMChartRxTableAdapter.Update(Me.MMDataDataSet1.MMChartRx)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdOrdPhy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrdPhy.Click
        Dim Physician As New Physician
        bRet = Physician.ShowPicklist
        If bRet(0) = "Y" Then       ' they picked a lab
            OrderingPhysicianIDTextBox.Text = bRet(1)
            PhysicianNameTextBox.Text = bRet(4) & " " & bRet(3) & " " & bRet(2)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim pieces() As String
            Dim IndexOf As Integer
            Dim sAction As String

            sAction = "RX"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User is not authorized for this procedure.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Me.Validate()
            Me.MMChartRxBindingSource.EndEdit()
            Me.MMChartRxTableAdapter.Update(Me.MMDataDataSet1.MMChartRx)
            RVForPrescription.ShowPrescriptions(DataGridView1.SelectedRows(0).Cells("RXIDDataGridViewTextBoxColumn").Value)
        Catch
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        objCurrentPatient.ChartNumber = ChartNumberTextBox.Text
        UnlockControls()
    End Sub

    Private Sub MMChartRxBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMChartRxBindingSource.AddingNew
        Me.MMDataDataSet1.MMChartRx.ChartNumberColumn.DefaultValue = aRet(1)
        Me.MMDataDataSet1.MMChartRx.PatientNameColumn.DefaultValue = aRet(2) + ", " + aRet(3)
        If aRet(10) <> "" Then
            Me.MMDataDataSet1.MMChartRx.CaseNumberColumn.DefaultValue = aRet(10)
        Else
            Me.MMDataDataSet1.MMChartRx.CaseNumberColumn.DefaultValue = 0
        End If
        Me.MMDataDataSet1.MMChartRx.NeedDEANoColumn.DefaultValue = 0
        Me.MMDataDataSet1.MMChartRx.SigNatureColumn.DefaultValue = 0
        Me.MMDataDataSet1.MMChartRx.StartDateColumn.DefaultValue = System.DateTime.Now.Date
        Me.MMDataDataSet1.MMChartRx.MedicationStatusColumn.DefaultValue = "Active"
        Me.MMDataDataSet1.MMChartRx.DAENoColumn.DefaultValue = strDEA
        Me.MMDataDataSet1.MMChartRx.OrderingPhysicianIDColumn.DefaultValue = PhyCode
        Me.MMDataDataSet1.MMChartRx.NumberOfRefillsColumn.DefaultValue = 0
        Me.MMDataDataSet1.MMChartRx.UserColumn.DefaultValue = globalUser.ToString
        Me.MMDataDataSet1.MMChartRx.TimeStampColumn.DefaultValue = System.DateTime.Now
    End Sub

    Private Sub cmdDrug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDrug.Click
        Try
            Dim FrmDrugs As New DRUGs

            bRet = FrmDrugs.ShowPicklist
            If bRet(0) = "Y" Then

                MedicationTextBox.Text = bRet(1)
                DosageTextBox.Focus()
            End If
        Catch
        End Try
    End Sub

    Private Sub MMChartRx_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.MMChartRxBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If

            ' See if any changes were made, but not saved 
            If Me.MMDataDataSet1.MMChartRx.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                msgText = msgText & ControlChars.CrLf & _
                    "Save changes?"
                'msgText = msgText & ControlChars.CrLf & "Save the changes ?"

                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.MMChartRxTableAdapter.Update(Me.MMDataDataSet1.MMChartRx)

                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.MMChartRx.RejectChanges()

                    Case Else
                        ' do nothing and cancel closing of the form
                        e.Cancel = True

                End Select
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Students form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try

    End Sub

    Private Sub btnPrintMultiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintMultiple.Click
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Dim i As Integer
        Dim strRxIdList As String = ""
        Try
            sAction = "RX"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User is not authorized for this procedure.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Me.Validate()
            Me.MMChartRxBindingSource.EndEdit()
            Me.MMChartRxTableAdapter.Update(Me.MMDataDataSet1.MMChartRx)
            If DataGridView1.SelectedRows.Count <> 0 Then
                ' RVforMultiplePrescriptions.ShowMultiplePrescriptions(DataGridView1.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value, DataGridView1.SelectedRows(0).Cells("StartDateDataGridViewTextBoxColumn").Value)



                For i = 0 To DataGridView1.RowCount - 1
                    If DataGridView1.Rows(i).Cells("Tag").Value = True Then
                        strRxIdList = strRxIdList + DataGridView1.Rows(i).Cells("RXIDDataGridViewTextBoxColumn").Value.ToString() & ","
                    End If
                Next

                RVforMultiplePrescriptions.ShowMultiplePrescriptions(strRxIdList.TrimEnd(","))

            End If
        Catch
        End Try
    End Sub

    Private Sub btnRefill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefill.Click
        Dim i As Integer
        RefillCounter = 0
        Try
            If DataGridView1.Rows.Count Then
                For i = 0 To DataGridView1.RowCount - 1
                    If DataGridView1.Rows(i).Cells("Tag").Value = True Then
                        Dim newRow As DataRow = Me.MMDataDataSet1.MMChartRx.NewRow
                        newRow("CHARTNUMBER") = DataGridView1.Rows(i).Cells("ChartNumberDataGridViewTextBoxColumn").Value
                        newRow("CaseNumber") = DataGridView1.Rows(i).Cells("CaseNumber").Value
                        newRow("PatientName") = DataGridView1.Rows(i).Cells("PatientNameDataGridViewTextBoxColumn").Value
                        newRow("OrderingPhysicianID") = DataGridView1.Rows(i).Cells("OrderingPhysicianIDDataGridViewTextBoxColumn").Value
                        newRow("PhysicianName") = DataGridView1.Rows(i).Cells("PhysicianNameDataGridViewTextBoxColumn").Value
                        newRow("Medication") = DataGridView1.Rows(i).Cells("MedicationDataGridViewTextBoxColumn").Value
                        newRow("Dosage") = DataGridView1.Rows(i).Cells("DosageDataGridViewTextBoxColumn").Value
                        newRow("NumberofRefills") = DataGridView1.Rows(i).Cells("NumberOfRefillsDataGridViewTextBoxColumn").Value
                        newRow("StartDate") = System.DateTime.Now.Date
                        newRow("Quantity") = DataGridView1.Rows(i).Cells("Quantity").Value
                        newRow("Instructions") = DataGridView1.Rows(i).Cells("Instructions").Value
                        newRow("SubstituteOk") = DataGridView1.Rows(i).Cells("SubstituteOk").Value
                        newRow("DAENo") = DataGridView1.Rows(i).Cells("DAENoDataGridViewTextBoxColumn").Value
                        newRow("LicenseNumber") = DataGridView1.Rows(i).Cells("LicenseNumberDataGridViewTextBoxColumn").Value
                        newRow("EndDate") = DataGridView1.Rows(i).Cells("EndDateDataGridViewTextBoxColumn").Value
                        newRow("Signature") = DataGridView1.Rows(i).Cells("SigNatureDataGridViewTextBoxColumn").Value
                        newRow("NeedDEANo") = DataGridView1.Rows(i).Cells("NeedDEANoDataGridViewCheckBoxColumn").Value
                        newRow("User") = globalUser.ToString
                        newRow("TimeStamp") = System.DateTime.Now
                        newRow("MedicationStatus") = "Active"
                        Me.MMDataDataSet1.MMChartRx.Rows.Add(newRow)
                        DataGridView1.Rows(i).Cells("MedicationStatus").Value = "Refilled"
                        RefillCounter += 1
                    End If
                Next
                Me.Validate()
                Me.MMChartRxBindingSource.EndEdit()
                Me.MMChartRxTableAdapter.Update(Me.MMDataDataSet1.MMChartRx)

                For i = 0 To DataGridView1.RowCount - 1
                    DataGridView1.Rows(i).Cells("Tag").Value = False
                Next

                MessageBox.Show(RefillCounter.ToString & " prescription(s) refilled.")
            End If   'DataGridView1.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show(RefillCounter.ToString & " prescription(s) refilled.")
        End Try
    End Sub

    Private Function LoadComboBoxes()

        Dim dr As DataRow
        Dim dt As DataTable

        dt = Me.MMDataDataSet1.Tables("MMCombo")

        'ComboBox1.Items.Clear()
        'For Each dr In dt.Rows
        '    If dr("MedCombo1") <> "N/A" Then
        '        ComboBox1.Items.Add(dr("MedCombo1"))
        '    End If
        'Next

        ListBox1.Items.Clear()
        For Each dr In dt.Rows
            If dr("MedCombo1") <> "N/A" Then
                ListBox1.Items.Add(dr("MedCombo1"))
            End If
        Next


        ListBox2.Items.Clear()
        For Each dr In dt.Rows
            If dr("MedCombo2") <> "N/A" Then
                ListBox2.Items.Add(dr("MedCombo2"))
            End If
        Next

        ListBox3.Items.Clear()
        For Each dr In dt.Rows
            If dr("MedCombo3") <> "N/A" Then
                ListBox3.Items.Add(dr("MedCombo3"))
            End If
        Next


        ListBox4.Items.Clear()
        For Each dr In dt.Rows
            If dr("MedCombo4") <> "N/A" Then
                ListBox4.Items.Add(dr("MedCombo4"))
            End If
        Next

        '    SignedByComboBox.Items.Clear()
        '    For Each dr In dt.Rows
        '        If dr("SignedBy") <> "N/A" Then
        '            SignedByComboBox.Items.Add(dr("SignedBy"))
        '        End If
        '    Next
        '    StatusComboBox.Items.Clear()
        '    For Each dr In dt.Rows
        '        If dr("Status") <> "N/A" Then
        '            StatusComboBox.Items.Add(dr("Status"))
        '        End If
        '    Next

        '    AssignedToComboBox.Items.Clear()
        '    For Each dr In dt.Rows
        '        If dr("AssignedTo") <> "N/A" Then
        '            AssignedToComboBox.Items.Add(dr("AssignedTo"))
        '        End If
        '    Next

        '    TemplateNameComboBox.Items.Clear()
        '    For Each drCCProfiles In dtCCProfiles.Rows
        '        If drCCProfiles("TemplateName") <> "" Then
        '            TemplateNameComboBox.Items.Add(drCCProfiles("TemplateName"))
        '        End If
        '    Next

    End Function

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If DosageTextBox.Text <> "" Then
            DosageTextBox.Text = DosageTextBox.Text & " " & ListBox1.SelectedItem.ToString
        Else
            DosageTextBox.Text = ListBox1.SelectedItem.ToString
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        If DosageTextBox.Text <> "" Then
            DosageTextBox.Text = DosageTextBox.Text & " " & ListBox2.SelectedItem.ToString
        Else
            DosageTextBox.Text = ListBox2.SelectedItem.ToString
        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged
        DosageTextBox.Text = DosageTextBox.Text & " " & ListBox3.SelectedItem.ToString
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox4.SelectedIndexChanged
        DosageTextBox.Text = DosageTextBox.Text & " " & ListBox4.SelectedItem.ToString
    End Sub

    Private Sub btnFax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFax.Click
        Try
            Dim pieces() As String
            Dim IndexOf As Integer
            Dim sAction As String

            sAction = "RX"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)

            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User is not authorized for this procedure.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim i As Integer
            Dim report As LocalReport = New LocalReport()
            report.ReportPath = "C:\MedicalManager\MedicalManager\Reports\Prescriptions.rdlc"
            report.DataSources.Add(New ReportDataSource("MMDataDataSet1_PrescriptionWriting", LoadSalesData()))
            Export(report)
            m_currentPageIndex = 0
            EmailFax()
            ' Print()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function LoadSalesData() As DataTable
        Me.PrescriptionWritingTableAdapter.FillByRxId(Me.MMDataDataSet1.PrescriptionWriting, DataGridView1.SelectedRows(0).Cells("RXIDDataGridViewTextBoxColumn").Value)
        Return Me.MMDataDataSet1.Tables("PrescriptionWriting")
    End Function

    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Try
            Dim filename As String
            filename = DataGridView1.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value & Replace(DataGridView1.SelectedRows(0).Cells("StartDateDataGridViewTextBoxColumn").Value, "/", "")
            CheckforPrescriptionsFolder()
            Dim stream As Stream = New FileStream("C:\MedicalManager\Prescriptions\" + filename + "." + fileNameExtension, FileMode.Create)
            m_streams.Add(stream)
            Return stream
        Catch ex As Exception
            MessageBox.Show(ex.ToString & " CreateStream")
        End Try
    End Function

    Private Sub Export(ByVal report As LocalReport)
        Try
            Dim deviceInfo As String = _
              "<DeviceInfo>" + _
              "  <OutputFormat>emf</OutputFormat>" + _
              "  <PageWidth>8.5in</PageWidth>" + _
              "  <PageHeight>11in</PageHeight>" + _
              "  <MarginTop>1in</MarginTop>" + _
              "  <MarginLeft>0in</MarginLeft>" + _
              "  <MarginRight>0in</MarginRight>" + _
              "  <MarginBottom>0in</MarginBottom>" + _
              "</DeviceInfo>"
            Dim warnings() As Microsoft.Reporting.WinForms.Warning = Nothing
            m_streams = New List(Of Stream)()
            report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)

            Dim stream As Stream
            For Each stream In m_streams
                stream.Position = 0
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString & " Export")
        End Try
    End Sub

    Private Function EmailFax()
        Try
            Dim MyMailMessage As New MailMessage()
            Dim sDisplayName As String = ""

            Dim FileToCopy As String
            Dim NewCopy As String

            FileToCopy = "C:\MedicalManager\Prescriptions\" & DataGridView1.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value & Replace(DataGridView1.SelectedRows(0).Cells("StartDateDataGridViewTextBoxColumn").Value, "/", "") & ".emf"
            NewCopy = "C:\MedicalManager\Prescriptions\" & DataGridView1.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value & Replace(DataGridView1.SelectedRows(0).Cells("StartDateDataGridViewTextBoxColumn").Value, "/", "") & "COPY" & ".emf"

            If System.IO.File.Exists(FileToCopy) = True Then
                System.IO.File.Copy(FileToCopy, NewCopy, True)
            End If

            Dim sSource As String = NewCopy    '"C:\MedicalManager\MedicalManager\" & DataGridView1.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value & Replace(DataGridView1.SelectedRows(0).Cells("StartDateDataGridViewTextBoxColumn").Value, "/", "") & ".emf"
            MyMailMessage.From = New MailAddress("medicalmanagerrx@gmail.com")

            If txtFaxNumber.Text.Contains("@") Then
                MyMailMessage.To.Add(txtFaxNumber.Text)
            Else
                Dim rx As New System.Text.RegularExpressions.Regex("[\.\\\()/\- ]")
                Dim faxnumber As String = rx.Replace(txtFaxNumber.Text, "")
                MyMailMessage.To.Add(faxnumber & "@myfax.com")
            End If

            MyMailMessage.Subject = "Prescription for " & DataGridView1.SelectedRows(0).Cells("PatientNameDataGridViewTextBoxColumn").Value
            Dim oAttch As Attachment = New Attachment(sSource)
            MyMailMessage.Attachments.Add(oAttch)

            Dim SMTPServer As New SmtpClient("smtp.gmail.com")
            SMTPServer.Port = 587
            SMTPServer.Credentials = New System.Net.NetworkCredential("medicalmanagerrx@gmail.com", "abdullah")
            SMTPServer.EnableSsl = True

            Try
                SMTPServer.Send(MyMailMessage)
                MessageBox.Show("Email Sent")
            Catch ex As SmtpException
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub btnFaxMultiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFaxMultiple.Click


        Try
            Dim pieces() As String
            Dim IndexOf As Integer
            Dim sAction As String
            sAction = "RX"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)
            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User is not authorized for this procedure.", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim i As Integer
            If txtFaxNumber.Text <> "" Then
                Dim report As LocalReport = New LocalReport()
                report.ReportPath = "C:\MedicalManager\MedicalManager\Reports\MultiplePrescriptions.rdlc"
                report.DataSources.Add(New ReportDataSource("MMDataDataSet1_PrescriptionWriting", LoadSalesDataMULT()))
                Export(report)
                m_currentPageIndex = 0
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                EmailFax()
                Me.Cursor = System.Windows.Forms.Cursors.Default
            Else
                MessageBox.Show("Please enter a fax number.")
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function LoadSalesDataMULT() As DataTable
        'Me.PrescriptionWritingTableAdapter.FillByChartAndDate(Me.MMDataDataSet1.PrescriptionWriting, DataGridView1.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value, DataGridView1.SelectedRows(0).Cells("StartDateDataGridViewTextBoxColumn").Value)

        Dim i As Integer
        Dim strRxIdList As String = ""

        For i = 0 To DataGridView1.RowCount - 1
            If DataGridView1.Rows(i).Cells("Tag").Value = True Then
                strRxIdList = strRxIdList + DataGridView1.Rows(i).Cells("RXIDDataGridViewTextBoxColumn").Value.ToString() & ","
            End If
        Next


        Me.PrescriptionWritingTableAdapter.FillByTagIDs(Me.MMDataDataSet1.PrescriptionWriting, strrxidlist.TrimEnd(","))
        Return Me.MMDataDataSet1.Tables("PrescriptionWriting")
    End Function

    Private Function LockControls()
        Try
            If SigNatureCheckBox.Checked <> False Then
                TabControl1.TabPages(1).Enabled = False
                SigNatureCheckBox.Enabled = False
                BindingNavigatorDeleteItem.Visible = False
            Else
                UnlockControls()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Function UnlockControls()
        Try
            TabControl1.TabPages(1).Enabled = True
            SigNatureCheckBox.Enabled = True
            BindingNavigatorDeleteItem.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Sub SigNatureCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SigNatureCheckBox.CheckedChanged
        LockControls()
    End Sub

    Private Sub RX_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RX_IDTextBox.TextChanged
        LockControls()
    End Sub

    Private Sub MMDRUGDataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMDRUGDataGridView.DoubleClick
        Try
            MedicationTextBox.Text = MMDRUGDataGridView.SelectedRows(0).Cells("dgvDRGNAME").Value.ToString() + "  " & MMDRUGDataGridView.SelectedRows(0).Cells("dgvStrong").Value.ToString() + "  " & MMDRUGDataGridView.SelectedRows(0).Cells("dgvForm").Value.ToString()
            DosageTextBox.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function LoadDrugs()
        Dim strDXCodes As String = ""
  
        Try
            If globalTemplate <> "" Then
                '******************************************
                Dim DPconnString As String = connStringDP
                Dim cn2 As New SqlConnection(DPconnString)
                cn2.Open()
                Dim cmd2 As New SqlCommand("SELECT Medications FROM CCProfiles where TemplateName= '" & globalTemplate & "'", cn2)
                Dim dr2 As SqlDataReader = cmd2.ExecuteReader()
                While dr2.Read
                    strDXCodes = dr2.Item(0).ToString
                End While
                dr2.Close()
                cn2.Close()
                '******************************************

                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                Dim cmd As New SqlCommand
                Dim splitlist As String() = strDXCodes.Split(",")
                Dim newDxList As String = "'" + String.Join("','", splitlist) + "'"

                cmd = New SqlCommand("SELECT DRGNAME, STRONG , FORM FROM MMDRUG WHERE ID IN (" & newDxList.ToString & ") ORDER BY DRGNAME", cn)

                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMDX")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                MMDRUGDataGridView.DataSource = myBindingSource

                ds.Dispose()
                cn.Close()

            Else

                Me.MMDRUGTableAdapter.FillByMyRx(Me.MMDataDataSet1.MMDRUG, PhyCode)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Function

    Private Function CheckforPrescriptionsFolder()
        Dim path As String
        Dim di As System.IO.DirectoryInfo

        path = "C:\MedicalManager\Prescriptions"
        di = New System.IO.DirectoryInfo(path)

        If (Not di.Exists) Then
            di.Create()
        End If
    End Function

    Private Sub btnSelectPharm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPharm.Click
        Dim frmPharmacy As New Pharmacy
        Dim aRetPharm(2) As String
        aRetPharm = frmPharmacy.ShowPicklist
        If aRetPharm(0) = "Y" Then       ' they picked a lab
            txtFaxNumber.Text = aRetPharm(1)
        End If
    End Sub

    Private Function LoadPhyDea()
        Dim dr As DataRow
        Dim dt As DataTable

        dt = Me.MMDataDataSet1.Tables("MMPrectice")

        For Each dr In dt.Rows
            If dr("Extra1") <> "" Then
                PhyCode = (dr("Extra1"))
            End If

            If Not IsDBNull(dr("Extra2")) Then
                strDEA = (dr("Extra2"))
            End If
        Next
    End Function

 
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Try
            If DataGridView1.Columns(e.ColumnIndex).Name.Equals("Tag") Then
                If (e.Value) = True Then
                    DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(227, 239, 255)
                Else
                    DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Text = "List" Then
            DataGridView1.Focus()
        End If
    End Sub

    Private Sub txtFind_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFind.KeyUp
        Try
            If cmbFilter.Text <> "" Then
                Me.MMChartRxBindingSource.Filter = cmbFilter.Text & " like" & "'" & txtFind.Text & "%'"
            End If

            'Me.MmpatientBindingSource.Sort = "ChartNumber"
            'dgPatient.DataSource = Me.MmpatientBindingSource
         
        Catch
        End Try
    End Sub

End Class



    'Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    '    ' Dim objFaxServer As New FAXCOMEXLib.FaxServer    'connection to the server

    '    ' Dim objFaxDocument As New FAXCOMEXLib.FaxDocument 'fax document to send

    '    'Dim strFaxPDFtoSend As String
    '    'Dim objFaxServer As New FaxServer

    '    'Dim objFaxDocument As New FaxDoc

    '    ''  Dim objSender As f
    '    'Dim JobID As Object

    '    ''local document to send

    '    'strFaxPDFtoSend = "c:TestFax.pdf"



    '    Try

    '        'now we have all the info, we can try and send the job out

    '        'Connect to the fax server

    '        objFaxServer.Connect("fax-svr1")

    '        'Set the fax body   

    '        objFaxDocument.Body = strFaxPDFtoSend



    '        'Name the document

    '        objFaxDocument.DocumentName = "Fax from Test Application"

    '        'Set the fax priority

    '        '  objFaxDocument.Priority = FAXCOMEXLib..FAX_PRIORITY_TYPE_ENUM.fptNORMAL

    '        'Add the recipient with the fax no 

    '        objFaxDocument.Recipients.Add("01772 123456", "Luke Niland")

    '        'Set the cover page type and the path to the cover page

    '        'objFaxDocument.CoverPageType=
    '        '        FAXCOMEXLib.FAX_COVERPAGE_TYPE_ENUM.fcptSERVER()

    '        objFaxDocument.CoverPage = "generic.cov"

    '        'Provide the address for the fax receipt

    '        objFaxDocument.ReceiptAddress = "luke@beakersoft.wanadoo.co.uk"

    '        'Dont attach the original fax to the email receipt 

    '        objFaxDocument.AttachFaxToReceipt = False

    '        'Set the receipt type to email

    '        'objFaxDocument.ReceiptType = FAXCOMEXLib.FAX_RECEIPT_TYPE_ENUM.frtMAIL



    '        'Subject into the cover

    '        objFaxDocument.Subject = "Test Fax"

    '        'Set the sender properties.

    '        objFaxDocument.Sender.Name = "Luke Niland"



    '        'Submit the document to the connected fax server

    '        objFaxDocument.ConnectedSubmit(objFaxServer)



    '    Catch ex As Exception

    '        MsgBox("Failed Sending Job" & ex.Message & " " & ex.GetBaseException.ToString)

    '    End Try


    'End Sub


'Try
'    Dim oApp As Outlook._Application
'    oApp = New Outlook.Application()
'    Dim oMsg As Outlook._MailItem
'    oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
'    oMsg.Subject = "Prescription for " & DataGridView1.SelectedRows(0).Cells("PatientNameDataGridViewTextBoxColumn").Value
'    ' oMsg.Body = "Attn: Pharmacy" & vbCr & vbCr & vbCrLf & vbCrLf & "Attached is a prescription for patient " & DataGridView1.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value
'    oMsg.To = "Zubaidha@live.com"

'    Dim sSource As String = "C:\MedicalManager\MedicalManager\" & DataGridView1.SelectedRows(0).Cells("ChartNumberDataGridViewTextBoxColumn").Value & Replace(DataGridView1.SelectedRows(0).Cells("StartDateDataGridViewTextBoxColumn").Value, "/", "") & ".emf"
'    Dim sDisplayName As String = ""
'    'Dim sBodyLen As String = oMsg.Body.Length
'    Dim oAttachs As Outlook.Attachments = oMsg.Attachments
'    Dim oAttach As Outlook.Attachment
'    ' oAttach = oAttachs.Add(sSource, , sBodyLen, sDisplayName)
'    oAttach = oAttachs.Add(sSource, , , sDisplayName)
'    ' Send
'    oMsg.Send()

'    ' Clean up
'    oApp = Nothing
'    oMsg = Nothing
'    oAttach = Nothing
'    oAttachs = Nothing
'    MessageBox.Show("Fax Sent")

'Catch
'    MessageBox.Show("Unable to send fax. Check to see of Outlook is running")
'End Try




