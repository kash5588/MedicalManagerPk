Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.VisualBasic

Public Class Visit

    Public data As DataSet
    Private m_CmdMMCHROSandGenCat As String = "SELECT MMCHROSandGenCat.Category FROM MMCHROSandGenCat"
    Private m_CmdMMCHRosAndGen As String = "SELECT  MMCHRosAndGen.MarkToEnter, MMCHRosAndGen.Discription, MMCHRosAndGen.qid, MMCHRosAndGen.ScreenLocation, MMCHRosAndGen.Category, MMCHRosAndGen.SubCategory fROM MMCHRosAndGen"
    'Private Sub btnSelectCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(4) As String

    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        Dim FrmProcedure As New Procedure
        aRet = PATIENT.ShowPicklist
        If aRet(0) = "Y" Then
            ChartNumberTextBox.Text = aRet(1)
            LastNameTextBox.Text = aRet(2)
            FirstNameTextBox.Text = aRet(3)
            DOBTextBox.Text = aRet(6)

        End If
    End Sub
    Private Sub AssPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssPr.Click
        Dim Physion As New Physician
        
        aRet = Physion.ShowPicklist
        If aRet(0) = "Y" Then

            AssignedProviderTextBox.Text = aRet(1)

        End If
    End Sub

    Private Sub RrfPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RrfPr.Click
        Dim RefPhysician As New ReferringPhysician
        aRet = RefPhysician.ShowPicklist
        If aRet(0) = "Y" Then
            ReferringProviderTextBox.Text = aRet(1)
            
        End If
    End Sub


    Private Sub cmdHPI1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHPI1.Click

        Dim FrmProcedure As New Procedure
      
        aRet = HPI.ShowPicklist
        If aRet(0) = "Y" Then
            txtHPI.Text = aRet(1)
        End If


    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim FrmProcedure As New Procedure
        aRet = Procedure.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab

            ProceduresTextBox.Text = ProceduresTextBox.Text & ControlChars.CrLf & aRet(1) + "     " & aRet(2)

        End If
        Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
        newRow("CHARTNUMBER") = ChartNumberTextBox.Text
        newRow("Date") = System.DateTime.Now.Date
        newRow("Type") = "PR"
        newRow("Code") = aRet(1)
        newRow("Description") = aRet(2)

        Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim FrmDiagonosis As New Diagonosis
        aRet = Diagonosis.ShowPicklist
        If aRet(0) = "Y" Then
            DxTextBox.Text = DxTextBox.Text & ControlChars.CrLf & aRet(1) + "     " & aRet(2)
        End If
        Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
        newRow("CHARTNUMBER") = ChartNumberTextBox.Text
        newRow("Date") = DateMaskedTextBox.Text   'System.DateTime.Now.Date
        newRow("Type") = "DX"
        newRow("Code") = aRet(1)
        newRow("Description") = aRet(2)

        Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)
        Me.MMCHDxRxLtMtTableAdapter.Update(Me.MMDataDataSet1.MMCHDxRxLtMt)



    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
       
        Me.MMCHDxRxLtMtTableAdapter.Update(Me.MMDataDataSet1.MMCHDxRxLtMt)

    End Sub

    Private Sub MMChartVisitBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartVisitBindingNavigatorSaveItem.Click
            Try
                  Me.Validate()
                  Me.MMChartVisitBindingSource.EndEdit()
                  ' Me.MMChartVisitTableAdapter.Update(Me.MMDataDataSet1.MMChartVisit, "msg")
                  Me.MMChartVisitTableAdapter.Update(Me.MMDataDataSet1.MMChartVisit)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub

    'Private Sub FillCNToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '  
    'End Sub


    Private Sub FillCNToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillCNToolStripButton.Click
        Try
            Me.MMChartVisitTableAdapter.FillByCh(Me.MMDataDataSet1.MMChartVisit, Trim(ChartNumberToolStripTextBox.Text))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Dim s As String
        Me.MMCHDxRxLtMtTableAdapter.FillbyCh(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(ChartNumberToolStripTextBox.Text))
        Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(ChartNumberToolStripTextBox.Text), DateMaskedTextBox.Text)
       


        Dim connString As String = _
                   "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MMData.mdb"
        Dim cn As New OleDbConnection(connString)
        cn.Open()
        '' read the number of rows
        Dim cmd As New OleDbCommand("SELECT *  FROM MMCHARTCONTENTS", cn)
        Dim myData As OleDbDataReader = cmd.ExecuteReader()
        Me.MMCHDxRxLtMtTableAdapter.FillbyCh(Me.MMDataDataSet1.MMCHDxRxLtMt, ChartNumberTextBox.Text)
        ' New System.Nullable(Of Date)(CType(DateDateTimePicker.Text, Date)))
    End Sub


    Private Sub Visit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.MMChartVisitTableAdapter.Fill(Me.MMDataDataSet1.MMChartVisit)

            Me.MMCHROSandGenCatTableAdapter.Fill(Me.MMDataDataSet1.MMCHROSandGenCat)
            ' Me.MMCHROSandGenCatTableAdapter.Fill(Me.MMDataDataSet1.MMCHROSandGenCat)

            Me.MMCHRosAndGenTableAdapter.Fill(Me.MMDataDataSet1.MMCHRosAndGen)


            Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(ChartNumberTextBox.Text), DateMaskedTextBox.Text)
            Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(ChartNumberTextBox.Text), DateMaskedTextBox.Text)

            Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text, DateMaskedTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        TextBox2.Text = ChiefComplaintTextBox.Text
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.MMChartVisitTableAdapter.FillByCh(Me.MMDataDataSet1.MMChartVisit, ChartNumberToolStripTextBox.Text)

        ' Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Normals")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub gridCustOrders_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub

    Private Sub FillToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Normals")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, "ROS-Normals")
    End Sub

   

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RV.Show()

    End Sub




    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        On Error Resume Next
        ' RV.Show()
        BillingReport.Show()
        '    Dim previewForm As New RV
        '    Dim reportName As String
        '    reportName = "ChartSummary.rdlc"
        '    If reportName = "" Then
        '        MessageBox.Show("Non-existant report requested", "View Report", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    End If
        '    'Dim id As String = dgInventory.Rows(dgInventory.SelectedRows(0).Index).Cells(0).Value
        '    If reportName <> "" Then
        '        ' previewForm.ShowVisitSummery(reportName, ChartNumberToolStripTextBox.Text, CaseNumberTextBox.Text)
        '    End If
    End Sub


    Private Sub ReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.MMChartVisitTableAdapter.FillByChCa(Me.MMDataDataSet1.MMChartVisit, ChartNumberToolStripTextBox.Text, CaseNumberTextBox.Text)

        '  Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'SendKeys.Send("{ENTER}")
    End Sub






    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim FrmProcedure As New Procedure
        'aRet = frmCustomers.ShowPicklist
        ' frmCustomers.ShowDialog()
        aRet = HPI.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab
            TextBox4.Text = aRet(1)
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim FrmProcedure As New Procedure
        'aRet = frmCustomers.ShowPicklist
        ' frmCustomers.ShowDialog()
        aRet = HPI.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab
            TextBox6.Text = aRet(1)
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim FrmProcedure As New Procedure
        'aRet = frmCustomers.ShowPicklist
        ' frmCustomers.ShowDialog()
        aRet = HPI.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab
            TextBox8.Text = aRet(1)
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim FrmDiagonosis As New Diagonosis
        'aRet = frmCustomers.ShowPicklist
        ' frmCustomers.ShowDialog()
        aRet = MedicalTests.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab

            RxTextBox.Text = RxTextBox.Text & ControlChars.CrLf & aRet(1) + "     " & aRet(2)
            'DxTextBox.Text = DxTextBox.Text & ControlChars.CrLf
        End If
        Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
        newRow("CHARTNUMBER") = ChartNumberTextBox.Text
        newRow("Date") = System.DateTime.Now.Date
        newRow("Type") = "MEDTEST"
        newRow("Code") = aRet(1)
        newRow("Description") = aRet(2)

        Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)

    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim RetVal
        RetVal = Shell("C:\Windows\system32\sndrec32.exe", 1)



    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 3 Then
            ComboBox1.Text = "PE-(Normals)"
        End If
        If TabControl1.SelectedIndex = 2 Then
            ComboBox1.Text = "Ros-Normals"
        End If

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged


        Me.MMCHRosAndGenTableAdapter.FillByCatagory(Me.MMDataDataSet1.MMCHRosAndGen, ComboBox1.Text)
    End Sub
    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        On Error Resume Next
        Dim st, st2 As String
        st = ComboBox1.Text
        If st = "CC" Then
            st = "CC "
        End If
        Select Case st.Substring(0, 3)
            'if vb.Left(Catlistbox.text
            Case "ROS"
                ReviewOfSystemsTextBox = ReviewOfSystemsTextBox.Text & ControlChars.CrLf & DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(2).Value & ControlChars.CrLf

            Case "PE-"

                PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & ControlChars.CrLf & DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(2).Value & ControlChars.CrLf
        End Select
    End Sub
    Private Sub MMCHRosAndGenDataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMCHRosAndGenDataGridView.SelectionChanged


        On Error Resume Next
        Dim st, st2 As String
        st = ComboBox1.Text
        If st = "CC" Then
            st = "CC "
        End If


        Select Case st.Substring(0, 3)
            'if vb.Left(Catlistbox.text
            Case "ROS"


                ReviewOfSystemsTextBox.Text = "    " & ReviewOfSystemsTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value & ControlChars.CrLf

                'Case "PE-"
                '
                '    PhysicalExamTextBox.Text = PhysicalExamTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(2).Value & ControlChars.CrLf


            Case "CC "


                ChiefComplaintTextBox.Text = ChiefComplaintTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value

            Case "Pro"

                ProblemListTextBox.Text = ProblemListTextBox.Text + "  " + MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value


            Case "Dia"


                DxTextBox.Text = DxTextBox.Text & ControlChars.CrLf & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value

            Case "Rx"

                RxTextBox.Text = RxTextBox.Text + "  " + MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value

            Case Else
                OtherNotesTextBox.Text = OtherNotesTextBox.Text & "   " & MMCHRosAndGenDataGridView.Rows(MMCHRosAndGenDataGridView.SelectedRows(0).Index).Cells(1).Value & ControlChars.CrLf

                'ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text + Me.MMDataDataSet.MMCHRosAndGen("Description").Discription
        End Select
    End Sub







    Private Sub TabPage7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage7.Click

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click
        RosGeneral.Show()
    End Sub

  
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RosGeneral.Show()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PhysicalExamination.Show()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(e.ToString)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

   

    Private Sub MMCHRosAndGenDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MMCHRosAndGenDataGridView.CellContentClick

        '    if MMCHRosAndGenDataGridView.Columns(e.ColumnIndex).GetType()= typeof(DataGridViewLinkColumn) then

        '        Process.Start(dataGridView1(e.ColumnIndex, e.RowIndex).Value.ToString
        'End If

    End Sub


    Private Sub LinkConstitunalP_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        MsgBox("A")
    End Sub

    Private Sub ConstitunalP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If ConstitutionalP.Checked = True Then
        '    ' Me.MMCHROSandGenCatBindingSource.Find("SubCategory" = "CONSTITUTIONAL")
        '    Me.MMCHROSandGenCatBindingSource.Filter = "SubCategory" = "'" & "CONSTITUTIONAL" & "'"
        '    MsgBox(Me.MMCHROSandGenCatBindingSource.Item(0).ToString)


        'End If


    End Sub

    'Private Sub ConstitunalR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If ConstitunalR.Checked = True Then
    '        ' Me.MMCHROSandGenCatBindingSource.Find("SubCategory" = "CONSTITUTIONAL")
    '        Me.MMCHROSandGenCatBindingSource.Filter = "SubCategory = '" & "CONSTITUTIONAL" & "'"
    '        MsgBox(Me.MMDataDataSet.MMCHROSandGenCat.Rows(Me.MMCHROSandGenCatBindingSource.Position)(0).ToString())

    '    End If

    'End Sub

    Private Sub BindingNavigatorCountItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RosGeneral.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        RosGeneral.Show()
        'aRet = RosGeneral.ShowPicklist
        'If aRet(0) = "Y" Then

        '    ReviewOfSystemsTextBox.Text = ReviewOfSystemsTextBox.Text + " " + aRet(1)

        'End If

    End Sub

    'Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
    '    ' PhysicalExamination.Show()
    '    aRet = PhysicalExamination.ShowPicklist
    '    If aRet(0) = "Y" Then

    '        PhysicalExamTextBox.Text = PhysicalExamTextBox.Text + " " + aRet(1)

    '    End If

    'End Sub

  
    Private Sub cmdmedSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmedSave.Click
        Me.MMChartRxTableAdapter.Update(Me.MMDataDataSet1.MMChartRx)
    End Sub

    Private Sub cmdMedications_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMedications.Click
        aRet(1) = ChartNumberTextBox.Text
        aRet(2) = FirstNameTextBox.Text
        aRet(3) = LastNameTextBox.Text
        aRet(4) = ""
        Prescription.ShowPrescriptions(aRet)

        Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, aRet(1))

    End Sub

    Private Sub HOPI_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HOPI.Enter

    End Sub

    Private Sub ChiefComplaintTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChiefComplaintTextBox.TextChanged
        TextBox2.Text = ChiefComplaintTextBox.Text

    End Sub

      Private Sub DOBTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DOBTextBox.TextChanged

      End Sub

    Private Sub PulseTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    'Private Sub FillByChNoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.MMChartTVitalSignTableAdapter.FillByChNo(Me.MMDataDataSet1.MMChartTVitalSign, Param1ToolStripTextBox.Text)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

   

    'Private Sub MMChartVisitBindingSource_BindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles MMChartVisitBindingSource.BindingComplete

    '    Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(ChartNumberTextBox.Text), Me.MMDataDataSet1.OAPpointments.Rows(1)("Date"))
    '    Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(ChartNumberTextBox.Text), DateMaskedTextBox.Text)

    '    Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text, DateMaskedTextBox.Text)
    '    'Me.MMDataDataSet1.OAPpointments.Rows(i)("ChartNumber").ToString()

    'End Sub


    
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        On Error Resume Next
        Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, Trim(ChartNumberTextBox.Text), DateMaskedTextBox.Text)
        Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, Trim(ChartNumberTextBox.Text), DateMaskedTextBox.Text)

        Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, ChartNumberTextBox.Text, DateMaskedTextBox.Text)
    End Sub

  
End Class


