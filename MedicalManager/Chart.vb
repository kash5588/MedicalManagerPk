Public Class Chart
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
      Dim aRet(7) As String
    Dim CChartNumber As String
    Private Sub cmdPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatient.Click
        Dim Patient As New PATIENT
        'aRet = frmCustomers.ShowPicklist
        ' Patient.ShowDialog()
        aRet = Patient.ShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab
            ChartNumberTextBox.Text = aRet(1)
            Name1.Text = aRet(2) & " " & aRet(3) & " " & aRet(4)
            DOBTextBox.Text = aRet(6)
            ' Home.Text = aRet(5)
            'Work.Text = aRet(6)
                  Address.Text = aRet(5)

        End If
        'MdiParent.Controls("ToolStripButton2").Text = Name.Text & ""

    End Sub
      Public Function ShowChartContents(ByVal bRet()) As String()

            aRet = bRet
            '  ChartNumber = bRet(1)
            CChartNumber = aRet(1)




            Me.Show()
      End Function



    Private Sub Chart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.MMCHARTContentsTableAdapter.FillByCaherNumber(Me.MMDataDataSet1.MMCHARTContents, CChartNumber)

            ChartNumberTextBox.Text = aRet(1)
            Name1.Text = aRet(2) + " " + aRet(3)
        DOBTextBox.Text = aRet(6)
        Home.Text = aRet(7)
            Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Chart.rdlc"

            'Try
            'If reportName = "Deposit.rdlc" Then

            Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
            ReportDataSource1.Name = "MMDataDataSet_MMCHARTViewChart"
            ReportDataSource1.Value = Me.MMCHARTViewChartBindingSource
            Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
            Me.ReportViewer1.LocalReport.DisplayName = "View Chart"
            Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Chart.rdlc"
            Me.MMCHARTViewChartBindingSource.DataMember = "MMCHARTViewChart"
            Me.MMCHARTViewChartBindingSource.DataSource = Me.MMDataDataSet1
            '   Me.MMCHARTViewChartTableAdapter.FillChCn(Me.MMDataDataSet1.MMCHARTViewChart, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)



            Me.ReportViewer1.RefreshReport()
            Me.ShowDialog()

            'Catch ex As Exception
            '      MessageBox.Show(ex.Message, "Report Preview", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            'End Try




            'If DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(2).Value = "Images" Then


            '    TabControl1.SelectedTab = TabControl1.TabPages(1)
            'Else
            '    TabControl1.SelectedTab = TabControl1.TabPages(0)

            'End If
    End Sub



    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    ''Private Sub MMCHARTContentsBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MMCHARTContentsBindingSource.CurrentChanged

    ''End Sub

    'Private Sub MMCHARTContentsBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    On Error Resume Next
    '    ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Chart.rdlc"

    '    ' Try
    '    'If reportName = "Deposit.rdlc" Then

    '    Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
    '    ReportDataSource1.Name = "MMDataDataSet1_MMCHARTViewChart"
    '    ReportDataSource1.Value = Me.MMCHARTViewChartBindingSource
    '    Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
    '    Me.ReportViewer1.LocalReport.DisplayName = "View Chart"
    '    Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Chart.rdlc"
    '    Me.MMCHARTViewChartBindingSource.DataMember = "MMCHARTViewChart"
    '    Me.MMCHARTViewChartBindingSource.DataSource = Me.MMDataDataSet1
    '    Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)



    '    Me.ReportViewer1.RefreshReport()
    '    Me.ShowDialog()

    '    '  Catch ex As Exception
    '    'MessageBox.Show(ex.Message, "Report Preview", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '    'End Try




    '    If DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(4).Value = "Images" Then


    '        TabControl1.SelectedTab = TabControl1.TabPages(1)
    '    Else
    '        TabControl1.SelectedTab = TabControl1.TabPages(0)

    '    End If
    'End Sub


    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

        On Error Resume Next
        ' If IsNumeric(LabDataSet.PATTEST.Rows(e.RowIndex)("Result")) Then


        'If CDbl(LabDataSet.PATTEST.Rows(e.RowIndex)("Result")) > CDbl(LabDataSet.PATTEST.Rows(e.RowIndex)("Hi")) Or CDbl(LabDataSet.PATTEST.Rows(e.RowIndex)("Result")) < CDbl(LabDataSet.PATTEST.Rows(e.RowIndex)("Low")) Then
        If e.ColumnIndex = 5 Then
            If e.Value = 0 Then
                'e.CellStyle.ForeColor = Drawing.Color.Blue
                e.CellStyle.BackColor = Drawing.Color.Pink
            Else
                e.CellStyle.BackColor = Drawing.Color.Aqua
            End If
        End If
        'End If
        'End If
    End Sub

    Private Sub MMCHARTContentsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                  Me.Validate()
                  Me.MMCHARTContentsBindingSource.EndEdit()
                  Me.MMCHARTContentsTableAdapter.Update(Me.MMDataDataSet1.MMCHARTContents)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Me.MMCHARTContentsBindingSource.Filter = "DocumentType ='ComboBox1.Text'"
        If ComboBox1.Text = "MEDICATIONS" Then

            TabControl1.SelectedTab = TabControl1.TabPages(2)
            Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, CChartNumber)
        Else
            TabControl1.SelectedTab = TabControl1.TabPages(0)

        End If
        Me.MMCHARTContentsBindingSource.Filter = "DocumentType" & " like" & "'" & ComboBox1.Text & "%'"

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Chart.rdlc"

            Try
                  'If reportName = "Deposit.rdlc" Then

                  Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                  ReportDataSource1.Name = "MMDataDataSet1_MMCHARTViewChart"
                  ReportDataSource1.Value = Me.MMCHARTViewChartBindingSource
                  Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
                  Me.ReportViewer1.LocalReport.DisplayName = "View Chart"
                  Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "MedicalManager." & "Chart.rdlc"
                  Me.MMCHARTViewChartBindingSource.DataMember = "MMCHARTViewChart"
                  Me.MMCHARTViewChartBindingSource.DataSource = Me.MMDataDataSet1
                  Me.MMCHARTViewChartTableAdapter.FillByChCn(Me.MMDataDataSet1.MMCHARTViewChart, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(0).Value, DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(1).Value)
            Me.ReportViewer1.RefreshReport()
                  Me.Show()


            If DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(3).Value = "IMAGE" Then


                TabControl1.SelectedTab = TabControl1.TabPages(1)
                'PictureBox2.Image = Image.FromFile("C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\Blue hills.jpg")
                PictureBox2.Image = Image.FromFile(DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(8).Value)

            Else
                TabControl1.SelectedTab = TabControl1.TabPages(0)

            End If
            'If DataGridView1.Rows(MMCHARTContentsBindingSource.Position).Cells(3).Value = "MEDICATIONS" Then

            '    TabControl1.SelectedTab = TabControl1.TabPages(2)
            '    Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, CChartNumber)
            'Else
            '    TabControl1.SelectedTab = TabControl1.TabPages(0)

            'End If

            'MmChartTVitalSignTableAdapter1.FillByChNo(Me.MMDataDataSet1.MMChartTVitalSign, CChartNumber)
            'Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, CChartNumber)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

   
   
    
    Private Sub VNOTES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VNOTES.Click
        ComboBox1.SelectedIndex = 3
    End Sub

    Private Sub LAB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAB.Click
        ComboBox1.SelectedIndex = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ComboBox1.SelectedIndex = 1
            Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, CChartNumber)
            TabControl1.SelectedTab = TabControl1.TabPages(2)
            MMChartRxDataGridView.DataSource = Me.MMChartRxBindingSource

            MMChartRxDataGridView.Columns(0).Visible = False
            MMChartRxDataGridView.Columns(1).Visible = False
            MMChartRxDataGridView.Columns(2).Visible = False

            MMChartRxDataGridView.Columns(3).Visible = False
            MMChartRxDataGridView.Columns(4).Visible = False
            MMChartRxDataGridView.Columns(5).Visible = False

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            ComboBox1.SelectedIndex = 2
            ComboBox1.SelectedIndex = 1
            MmChartTVitalSignTableAdapter1.FillByChNo(Me.MMDataDataSet1.MMChartTVitalSign, CChartNumber)
            TabControl1.SelectedTab = TabControl1.TabPages(2)
            MMChartRxDataGridView.DataSource = Me.MMChartTVitalSignBindingSource

            MMChartRxDataGridView.Columns(0).Visible = False

            MMChartRxDataGridView.Columns(1).Visible = False
            MMChartRxDataGridView.Columns(2).Visible = False

            MMChartRxDataGridView.Columns(4).Visible = False
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub cmdMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMessages.Click
        'Try
        '    Me.MessagingTableAdapter.FillChartNumber(Me.MMDataDataSet1.Messaging, CChartNumber)

        '    MMChartRxDataGridView.DataSource = Me.MessagingBindingSource
        '    MMChartRxDataGridView.Columns(0).Visible = False

        '    MMChartRxDataGridView.Columns(2).Visible = False
        '    MMChartRxDataGridView.Columns(3).Visible = False

        '    MMChartRxDataGridView.Columns(9).Visible = False

        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ComboBox1.SelectedIndex = 2
    End Sub

    Private Sub CORRES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CORRES.Click
        ComboBox1.SelectedIndex = 4
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ComboBox1.SelectedIndex = 5
    End Sub

    Private Sub HOSPITAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HOSPITAL.Click
        ComboBox1.SelectedIndex = 6
    End Sub

    'Private Sub FillBYChToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.MMChartRxTableAdapter.FillBYCh(Me.MMDataDataSet1.MMChartRx, Param1ToolStripTextBox.Text)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    'Private Sub FillChartNumberToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.MessagingTableAdapter.FillChartNumber(Me.MMDataDataSet1.Messaging, Param1ToolStripTextBox.Text)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    'Private Sub cmdMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMessages.Click
    '    Try
    '        Me.MessagingTableAdapter.FillChartNumber(Me.MMDataDataSet1.Messaging, Param1ToolStripTextBox.Text)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
End Class