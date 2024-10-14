Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Orders
    Dim ChartNumber As String
    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRet(10) As String
    Dim AssignedProvider As String
    Dim AssignedProviderCode As String
    Dim myBindingSource As New BindingSource()
    Dim CounterTests As Integer
    Dim aPickCC(2) As String
    Dim isDataChanged As Boolean = False
    Dim isLoading As Boolean = False

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TabControl1.Appearance = TabAppearance.Buttons
        'TabControl1.ItemSize = New Size(0, 1)
        'TabControl1.SizeMode = TabSizeMode.Fixed

        ChartNo.Text = aRet(1)
        txtName.Text = (aRet(3) + " " + aRet(2)).Trim()
        txtCaseNo.Text = aRet(10)
        TBPhysician.Text = AssignedProvider

        ShowProceduresGViewData(txtCaseNo.Text)
        LoadData(txtCaseNo.Text)

    End Sub

    Private Sub ShowProceduresGViewData(CaseNo As String)
        Dim connectionString As String = connString2
        Dim query As String = "SELECT ID, ChartNumber, CaseNumber, Date, Type, Code, Description, PrDx, UserCode, UserID, TimeStamp, PostedToBilling,
                                Amount, InHouse, InHouseBilling, ChartEntry, Units, Department, ChartofAccounts, VisitType 
                                FROM MMCHDxRxLtMt WHERE CaseNumber = " + CaseNo + " ORDER BY ID DESC "

        ' Create a new connection object
        Using connection As New SqlConnection(connectionString)
            ' Create a DataAdapter with the SQL query
            Dim dataAdapter As New SqlDataAdapter(query, connection)

            ' Create a DataTable to hold the data
            Dim dataTable As New DataTable()

            Try
                ' Open the connection
                connection.Open()

                ' Fill the DataTable with data from the query
                dataAdapter.Fill(dataTable)

                ' Bind the DataTable to the DataGridView
                MMCHDxRxLtMtDataGridView.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Function ShowProcedures(ByVal dRet() As String, ByVal AssignedProviderName As String) As String()
        AssignedProvider = AssignedProviderName
        AssignedProviderCode = GetPhysicianCode(AssignedProviderName)
        'RadioButtonDx.Checked = True
        aRet = dRet
        ChartNumber = dRet(1)
        Me.Show()
        Me.TabControl1.SelectedIndex = 0
    End Function

    Public Function GetPhysicianCode(Name As String) As String

        Dim code As String = String.Empty

        Dim connectionString As String = connString2

        ' Corrected SQL query using concatenation
        Dim query As String = "SELECT code FROM  MMPhysion WHERE (FirstName + ' ' + LastName) = @Name"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Add parameters to avoid SQL injection
                command.Parameters.AddWithValue("@Name", Name)

                ' Open the connection
                connection.Open()

                ' Execute the command and get the result
                Dim result As Object = command.ExecuteScalar()

                ' Check if result is not null, then assign it to code
                If result IsNot Nothing Then
                    code = result.ToString()
                End If
            End Using
        End Using

        Return code
    End Function

    Private Sub radTemplateDX_CheckedChanged(sender As Object, e As EventArgs) Handles radTemplateDX.CheckedChanged
        LoadTemplateSpecificDxPrTests()
    End Sub

    Private Sub radMyDx_CheckedChanged(sender As Object, e As EventArgs) Handles radMyDx.CheckedChanged
        If radMyDx.Checked = True Then
            radTemplateDX.BackColor = Color.Transparent
            radMyDx.BackColor = Color.FromArgb(148, 183, 233)
            radAll.BackColor = Color.Transparent

            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand

            Try
                If RadioButtonDx.Checked Then

                    cmd = New SqlCommand("SELECT MMDX.Code1 AS Code, MMDX.Description FROM  MMDX LEFT JOIN  PhysicianProfile ON MMDX.Code1 = PhysicianProfile.Code WHERE  physiciancode = '" & AssignedProviderCode & "' ORDER BY MMDX.Description", cn)

                ElseIf RadioButtonPr.Checked Then
                    cmd = New SqlCommand("SELECT Code1 As Code, MMPRocedure.Description, AmountA, MyProcedures, ScreenLocation, MMPRocedure.Type, InHouse, InHouseBilling  FROM   MMPRocedure LEFT JOIN PhysicianProfile ON MMPRocedure.Code1 = PhysicianProfile.Code where  physiciancode = '" & AssignedProviderCode & "' order by Description", cn)

                ElseIf RadioButtonLT.Checked Then
                    cmd = New SqlCommand("SELECT TestNo, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestLab  order by Description", cn)

                ElseIf RadioButtonMT.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMCHARTTESTMEDICAL  order by Description", cn)

                ElseIf RadioButtonTestImaging.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestImaging  order by Description", cn)
                Else
                    DataGridViewPr.DataSource = Nothing
                    Exit Sub
                End If

                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMDX")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource

                ds.Dispose()
                cn.Close()
                If DataGridViewPr.Rows.Count > 0 Then
                    Me.DataGridViewPr.Columns(0).Width = 70
                    Me.DataGridViewPr.Columns(1).Width = 500
                End If


            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub radAll_CheckedChanged(sender As Object, e As EventArgs) Handles radAll.CheckedChanged
        If radAll.Checked = True Then

            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand

            Try

                radTemplateDX.BackColor = Color.Transparent
                radMyDx.BackColor = Color.Transparent
                radAll.BackColor = Color.FromArgb(148, 183, 233)

                If RadioButtonDx.Checked Then
                    cmd = New SqlCommand("SELECT     MMDX.Code1 AS Code, MMDX.Description FROM MMDX ORDER BY MMDX.Description", cn)

                ElseIf RadioButtonPr.Checked Then
                    cmd = New SqlCommand("SELECT Code1 As Code, Description, AmountA, MyProcedures, ScreenLocation, Type, InHouse, InHouseBilling  from  MMProcedure order by Description", cn)

                ElseIf RadioButtonLT.Checked Then
                    cmd = New SqlCommand("SELECT TestNo, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestLab order by Description", cn)

                ElseIf RadioButtonMT.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMCHARTTESTMEDICAL order by Description", cn)

                ElseIf RadioButtonTestImaging.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestImaging order by Description", cn)

                Else
                    DataGridViewPr.DataSource = Nothing
                    Exit Sub
                End If

                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMDX")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource

                ds.Dispose()
                cn.Close()
                Me.DataGridViewPr.Columns(0).Width = 70
                Me.DataGridViewPr.Columns("Description").Width = 347


            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



    Private Sub txtFind_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFind.KeyUp
        Try
            myBindingSource.Filter = cmbFilter.Text & " like " & "'" & txtFind.Text & "%'"
        Catch
        End Try
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        txtFind.Focus()
    End Sub

    Private Sub RadioButtonPr_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPr.CheckedChanged
        Try
            If RadioButtonPr.Checked = True Then
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                ' read the number of rows
                Dim cmd As New SqlCommand("SELECT Code1 As Code, MMPRocedure.Description, AmountA, MyProcedures, ScreenLocation, MMPRocedure.Type, InHouse, InHouseBilling  FROM   MMPRocedure LEFT JOIN PhysicianProfile ON MMPRocedure.Code1 = PhysicianProfile.Code where  physiciancode = '" & AssignedProviderCode & "' order by Description", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMProcedure")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource

                '  DataGridViewPr.DataSource = ds.Tables("MMProcedure")
                ds.Dispose()
                cn.Close()
                Me.DataGridViewPr.Columns(0).Width = 70
                Me.DataGridViewPr.Columns(1).Width = 355
                Me.DataGridViewPr.Columns(2).Width = 70

                DataGridViewPr.DefaultCellStyle.BackColor = Color.AliceBlue
                If globalTemplate <> "" Then
                    radTemplateDX.Checked = True
                    LoadTemplateSpecificDxPrTests()
                Else
                    radMyDx.Checked = True
                End If
                TabControl1.SelectedTab = DxTestsTab

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Function LoadTemplateSpecificDxPrTests()
        Dim strDXCodes As String
        Dim strPRCodes As String
        Dim strHasRows = False
        Try
            radTemplateDX.BackColor = Color.FromArgb(148, 183, 233)
            radMyDx.BackColor = Color.Transparent
            radAll.BackColor = Color.Transparent
            If globalTemplate <> "" Then
                If radTemplateDX.Checked = True Then
                    If RadioButtonDx.Checked Then

                        Dim strQID As String
                        '******************************************
                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand("SELECT subcategory FROM QIDS where TemplateName= '" & globalTemplate & "' AND category = 'DX'", cn)
                        Dim dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strQID = strQID + "'" + dr.Item(0).ToString + "'" + ","
                        End While
                        dr.Close()
                        cn.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString3 As String = connString2
                        Dim cn3 As New SqlConnection(connString)
                        cn3.Open()
                        Dim cmd3 As New SqlCommand


                        cmd3 = New SqlCommand("SELECT MMDX.Code1 AS Code, MMDX.Description FROM  MMDX  WHERE  MMDX.Code1 IN (" & strQID.TrimEnd(",") & " ) ORDER BY MMDX.Description", cn3)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd3
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn3.Close()


                        Me.DataGridViewPr.Columns(0).Width = 70
                        Me.DataGridViewPr.Columns(1).Width = 347


                    ElseIf RadioButtonPr.Checked Then

                        Dim strQID As String
                        '******************************************
                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand("SELECT subcategory FROM QIDS where TemplateName= '" & globalTemplate & "' AND category = 'PR'", cn)
                        Dim dr As SqlDataReader = cmd.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strQID = strQID + "'" + dr.Item(0).ToString + "'" + ","
                        End While
                        dr.Close()
                        cn.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString3 As String = connString2
                        Dim cn3 As New SqlConnection(connString)
                        cn3.Open()
                        Dim cmd3 As New SqlCommand


                        cmd3 = New SqlCommand("SELECT MMPRocedure.Code1 AS Code, MMPRocedure.Description, AmountA, MyProcedures, ScreenLocation, MMPRocedure.Type , MMPRocedure.InHouse, MMPRocedure.InHouseBilling FROM  MMPRocedure WHERE  MMPRocedure.Code1 IN (" & strQID.TrimEnd(",") & " ) ORDER BY MMPRocedure.Description", cn3)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd3
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn3.Close()


                        Me.DataGridViewPr.Columns(0).Width = 70
                        Me.DataGridViewPr.Columns(1).Width = 347





                    ElseIf RadioButtonLT.Checked Then

                        '******************************************
                        Dim DPconnString As String = connStringDP
                        Dim cn2 As New SqlConnection(DPconnString)
                        cn2.Open()
                        Dim cmd2 As New SqlCommand("SELECT LAB_ORDERS FROM CCProfiles where TemplateName= '" & globalTemplate & "'", cn2)
                        Dim dr As SqlDataReader = cmd2.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strDXCodes = dr.Item(0).ToString
                        End While
                        dr.Close()
                        cn2.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand
                        Dim splitlist As String() = strDXCodes.Split(",")
                        Dim newDxList As String = "'" + String.Join("','", splitlist) + "'"

                        cmd = New SqlCommand("SELECT MMChartTestLab.TestNo AS Code, MMChartTestLab.Description, Amount, MyTest, Type , InHouse, InHouseBilling FROM  MMChartTestLab WHERE  MMChartTestLab.TestNo IN (" & newDxList.ToString & " ) ORDER BY MMChartTestLab.Description", cn)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn.Close()

                        Me.DataGridViewPr.Columns(0).Width = 70
                        Me.DataGridViewPr.Columns(1).Width = 347

                    ElseIf RadioButtonTestImaging.Checked Then

                        '******************************************
                        Dim DPconnString As String = connStringDP
                        Dim cn2 As New SqlConnection(DPconnString)
                        cn2.Open()
                        Dim cmd2 As New SqlCommand("SELECT ImagingTests FROM CCProfiles where TemplateName= '" & globalTemplate & "'", cn2)
                        Dim dr As SqlDataReader = cmd2.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strDXCodes = dr.Item(0).ToString
                        End While
                        dr.Close()
                        cn2.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand
                        Dim splitlist As String() = strDXCodes.Split(",")
                        Dim newDxList As String = "'" + String.Join("','", splitlist) + "'"

                        cmd = New SqlCommand("SELECT MMChartTestImaging.id AS Code, MMChartTestImaging.Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM  MMChartTestImaging WHERE  MMChartTestImaging.id IN (" & newDxList.ToString & " ) ORDER BY MMChartTestImaging.Description", cn)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn.Close()

                        Me.DataGridViewPr.Columns(0).Width = 70
                        Me.DataGridViewPr.Columns(1).Width = 347


                    ElseIf RadioButtonMT.Checked Then

                        '******************************************
                        Dim DPconnString As String = connStringDP
                        Dim cn2 As New SqlConnection(DPconnString)
                        cn2.Open()
                        Dim cmd2 As New SqlCommand("SELECT MedicalTests FROM CCProfiles where TemplateName= '" & globalTemplate & "'", cn2)
                        Dim dr As SqlDataReader = cmd2.ExecuteReader()
                        While dr.Read
                            strHasRows = True
                            strDXCodes = dr.Item(0).ToString
                        End While
                        dr.Close()
                        cn2.Close()
                        If strHasRows = False Then
                            radMyDx.Checked = True
                            Exit Function
                        End If
                        '******************************************

                        Dim connString As String = connString2
                        Dim cn As New SqlConnection(connString)
                        cn.Open()
                        Dim cmd As New SqlCommand
                        Dim splitlist As String() = strDXCodes.Split(",")
                        Dim newDxList As String = "'" + String.Join("','", splitlist) + "'"

                        cmd = New SqlCommand("SELECT MMChartTestMedical.id AS Code, MMChartTestMedical.Description, Amount, MyTest, Type, InHouse, InHouseBilling  FROM  MMChartTestMedical WHERE  MMChartTestMedical.id IN (" & newDxList.ToString & " ) ORDER BY MMChartTestMedical.Description", cn)

                        Dim da As New SqlDataAdapter
                        Dim tbl As New DataTable
                        Dim ds As New DataSet
                        da.SelectCommand = cmd
                        da.Fill(ds, "MMDX")

                        myBindingSource = New BindingSource()
                        myBindingSource.DataSource = ds
                        myBindingSource.DataMember = ds.Tables(0).TableName
                        DataGridViewPr.DataSource = myBindingSource

                        ds.Dispose()
                        cn.Close()

                        Me.DataGridViewPr.Columns(0).Width = 70
                        Me.DataGridViewPr.Columns(1).Width = 347



                    Else
                        DataGridViewPr.DataSource = Nothing
                        Exit Function
                    End If

                End If
            Else
                DataGridViewPr.DataSource = Nothing
                Exit Function
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub DataGridViewPr_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewPr.DoubleClick
        Try
            If RadioButtonDx.Checked = True Then
                '  newRow("Type") = "DX"
                If TextBoxDx1.Text = "" Then
                    TextBoxDx1.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    Dx1DescriptionTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value & ""
                ElseIf TextBoxDx2.Text = "" Then
                    TextBoxDx2.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    Dx2DescriptionTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value & ""
                    'ElseIf TextBoxDx3.Text = "" Then
                    '    TextBoxDx3.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    '    Dx3DescriptionTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value & ""
                    'ElseIf TextBoxDx4.Text = "" Then
                    '    TextBoxDx4.Text = DataGridViewPr.SelectedRows(0).Cells(0).Value & ""
                    '    Dx4DescriptionTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value & ""
                Else
                    If Dx5DescriptionTextBox.Text = "" Then
                        Dx5DescriptionTextBox.Text = Trim(DataGridViewPr.SelectedRows(0).Cells(0).Value) & ControlChars.Tab & DataGridViewPr.SelectedRows(0).Cells("Description").Value
                    Else
                        Dx5DescriptionTextBox.Text += Environment.NewLine
                        Dx5DescriptionTextBox.Text += Trim(DataGridViewPr.SelectedRows(0).Cells(0).Value) & ControlChars.Tab & DataGridViewPr.SelectedRows(0).Cells("Description").Value
                    End If
                    Dx5DescriptionTextBox.SelectionStart = Dx5DescriptionTextBox.TextLength
                    Dx5DescriptionTextBox.ScrollToCaret()
                End If

            ElseIf radOther.Checked = True Then

                Dim strOther As String
                strOther = NotesTestBox.Text
                If NotesTestBox.Text = "" Then
                    NotesTestBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    NotesTestBox.Text = strOther + Environment.NewLine + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If

            ElseIf radProcedureNotes.Checked = True Then

                Dim strOther As String
                strOther = NotesTestBox.Text
                If NotesTestBox.Text = "" Then
                    NotesTestBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    NotesTestBox.Text = strOther + Environment.NewLine + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If

            ElseIf radFollowUp.Checked = True Then
                Dim strFollowup As String
                strFollowup = TextBoxfollowUp.Text
                If TextBoxfollowUp.Text = "" Then
                    TextBoxfollowUp.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    TextBoxfollowUp.Text = strFollowup + ", " + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If

            ElseIf radDiet.Checked = True Then
                Dim strDiet As String
                strDiet = TextBoxDiet.Text
                If TextBoxDiet.Text = "" Then
                    TextBoxDiet.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    TextBoxDiet.Text = strDiet + ", " + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If


            ElseIf radCounseling.Checked = True Then
                Dim strCounseling As String
                strCounseling = TextBoxCounselingEducation.Text
                If TextBoxCounselingEducation.Text = "" Then
                    TextBoxCounselingEducation.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                Else
                    TextBoxCounselingEducation.Text = strCounseling + ", " + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                End If

                'ElseIf radPlan.Checked = True Then
                '    Dim strPlan As String
                '    strPlan = PlanTextBox.Text
                '    If PlanTextBox.Text = "" Then
                '        PlanTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                '    Else
                '        PlanTextBox.Text = strPlan + ", " + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                '    End If

                'ElseIf radImpressions.Checked = True Then
                '    Dim strImpressions As String
                '    strImpressions = ImpressionTextBox.Text
                '    If ImpressionTextBox.Text = "" Then
                '        ImpressionTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString()
                '    Else
                '        ImpressionTextBox.Text = strImpressions + ", " + DataGridViewPr.SelectedRows(0).Cells("Description").Value.ToString
                '    End If

            ElseIf RadioButtonCC.Checked = True Then
                Dim strCC As String
                strCC = ChiefComplaintTextBox.Text
                If ChiefComplaintTextBox.Text = "" Then
                    ChiefComplaintTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("ChiefComplaint").Value.ToString()
                Else
                    ChiefComplaintTextBox.Text = strCC + ", " + DataGridViewPr.SelectedRows(0).Cells("ChiefComplaint").Value.ToString
                End If
                ChiefComplaintTextBox.SelectionStart = ChiefComplaintTextBox.TextLength
                ChiefComplaintTextBox.ScrollToCaret()
                'TextBox1.Focus()

            ElseIf radChronic.Checked = True Then
                Dim strChronic As String
                strChronic = ChronicConditionsTextBox.Text
                If ChronicConditionsTextBox.Text = "" Then
                    ChronicConditionsTextBox.Text = DataGridViewPr.SelectedRows(0).Cells("ChiefComplaint").Value.ToString()
                Else
                    ChronicConditionsTextBox.Text = strChronic + ", " + DataGridViewPr.SelectedRows(0).Cells("ChiefComplaint").Value.ToString
                End If
                ChronicConditionsTextBox.SelectionStart = ChronicConditionsTextBox.TextLength
                ChronicConditionsTextBox.ScrollToCaret()

            Else 'RadioButtonDx.Checked = False Then

                CounterTests += 1
                Dim newRow As DataRow = Me.MMDataDataSet1.MMCHDxRxLtMt.NewRow
                newRow("ChartNumber") = ChartNo.Text
                'DateMaskedTB date formate changed

                newRow("Date") = System.DateTime.Now.Date()
                newRow("CaseNumber") = txtCaseNo.Text
                newRow("Code") = DataGridViewPr.SelectedRows(0).Cells(0).Value
                newRow("Description") = DataGridViewPr.SelectedRows(0).Cells("Description").Value
                newRow("Amount") = DataGridViewPr.SelectedRows(0).Cells(2).Value
                newRow("Type") = DataGridViewPr.SelectedRows(0).Cells("Type").Value
                newRow("UserID") = globalUser
                newRow("InHouse") = DataGridViewPr.SelectedRows(0).Cells("InHouse").Value
                newRow("InHouseBilling") = DataGridViewPr.SelectedRows(0).Cells("InHouseBilling").Value
                newRow("Timestamp") = System.DateTime.Now.Date

                Me.MMDataDataSet1.MMCHDxRxLtMt.Rows.Add(newRow)
                Me.MMCHDxRxLtMtTableAdapter.Update(Me.MMDataDataSet1.MMCHDxRxLtMt)
                ShowProceduresGViewData(txtCaseNo.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Patient form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End Try
    End Sub

    Private Sub RadioButtonLT_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonLT.CheckedChanged
        Try
            If RadioButtonLT.Checked = True Then
                'User Instance=True
                Dim connString As String = connString2
                'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString


                Dim cn As New SqlConnection(connString)
                cn.Open()
                ' read the number of rows


                Dim cmd As New SqlCommand("SELECT TestNo, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestLab  order by Description", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMChartTestLab")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource


                ' DataGridViewPr.DataSource = ds.Tables("MMDX")

                ds.Dispose()
                cn.Close()
                Me.DataGridViewPr.Columns(0).Width = 70
                Me.DataGridViewPr.Columns(1).Width = 355
                Me.DataGridViewPr.Columns(2).Width = 70
                DataGridViewPr.DefaultCellStyle.BackColor = Color.WhiteSmoke
                If globalTemplate <> "" Then
                    radTemplateDX.Checked = True
                    LoadTemplateSpecificDxPrTests()
                Else
                    radMyDx.Checked = True
                End If

                TabControl1.SelectedTab = DxTestsTab

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadioButtonMT_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMT.CheckedChanged
        Try
            If RadioButtonMT.Checked = True Then

                'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                ' read the number of rows
                Dim cmd As New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMCHARTTESTMEDICAL order by Description", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMChartTestMedical")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource

                '  DataGridViewPr.DataSource = ds.Tables("MMChartTestMedical")
                ds.Dispose()
                cn.Close()

                Me.DataGridViewPr.Columns(0).Width = 70
                Me.DataGridViewPr.Columns(1).Width = 350
                Me.DataGridViewPr.Columns(2).Width = 70
                DataGridViewPr.DefaultCellStyle.BackColor = Color.Snow
                If globalTemplate <> "" Then
                    radTemplateDX.Checked = True
                    LoadTemplateSpecificDxPrTests()
                Else
                    radMyDx.Checked = True
                End If

                TabControl1.SelectedTab = DxTestsTab
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RadioButtonTestImaging_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTestImaging.CheckedChanged
        Try
            If RadioButtonTestImaging.Checked = True Then
                ' Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
                Dim connString As String = connString2
                Dim cn As New SqlConnection(connString)
                cn.Open()
                ' read the number of rows
                Dim cmd As New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestImaging order by Description", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMChartTestImaging")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource
                DataGridViewPr.DefaultCellStyle.BackColor = Color.White
                ' DataGridViewPr.DataSource = ds.Tables("MMChartTestImaging")
                ds.Dispose()
                cn.Close()
                If globalTemplate <> "" Then
                    radTemplateDX.Checked = True
                    LoadTemplateSpecificDxPrTests()
                Else
                    radMyDx.Checked = True
                End If
                TabControl1.SelectedTab = DxTestsTab

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RadioButtonDx_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDx.CheckedChanged
        Try
            If RadioButtonDx.Checked = True Then
                'User Instance=True
                Dim connString As String = connString2
                'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString


                Dim cn As New SqlConnection(connString)
                cn.Open()
                ' read the number of rows
                Dim cmd As New SqlCommand("SELECT MMDX.Code1 AS Code, MMDX.Description FROM  MMDX LEFT JOIN  PhysicianProfile ON MMDX.Code1 = PhysicianProfile.Code WHERE  physiciancode = '" & AssignedProviderCode & "' ORDER BY MMDX.Description", cn)
                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMDX")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource


                ' DataGridViewPr.DataSource = ds.Tables("MMDX")

                ds.Dispose()
                cn.Close()
                If globalTemplate <> "" Then
                    radTemplateDX.Checked = True
                    LoadTemplateSpecificDxPrTests()
                Else
                    radMyDx.Checked = True
                End If
                ' radMyDx.Checked = True
                '***CHANGED***
                'TabControl3.SelectedTab = DxPrTestsPickTab
                TabControl1.SelectedTab = DxTestsTab
                If DataGridViewPr.Rows.Count > 0 Then
                    Me.DataGridViewPr.Columns(0).Width = 70
                    Me.DataGridViewPr.Columns(1).Width = 500
                End If

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFollowUp_Click(sender As Object, e As EventArgs) Handles btnFollowUp.Click
        Try
            '***CHANGED***

            radFollowUp.Checked = True
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'f/u Panel' ORDER BY ScreenLocation ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()
            cn.Dispose()
            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefTo_Click(sender As Object, e As EventArgs) Handles btnRefTo.Click
        Try
            Dim RefPhysician As New ReferringPhysician
            aRet = RefPhysician.ShowPicklist
            If aRet(0) = "Y" Then
                TextBoxReferedTo.Text = aRet(1)
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDiet_Click(sender As Object, e As EventArgs) Handles btnDiet.Click
        Try
            '***CHANGED***
            'TabControl3.SelectedTab = DxPrTestsPickTab
            radDiet.Checked = True
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'Diet' ORDER BY ScreenLocation ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()
            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCounseling_Click(sender As Object, e As EventArgs) Handles btnCounseling.Click
        Try
            '***CHANGED***
            'TabControl3.SelectedTab = DxPrTestsPickTab
            radCounseling.Checked = True
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'Counseling' ORDER BY ScreenLocation  ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()
            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False

            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPickupCC_Click(sender As Object, e As EventArgs) Handles btnPickupCC.Click
        Try

            RadioButtonDx.Checked = False
            radProcedureNotes.Checked = False
            radPlan.Checked = False
            RadioButtonCC.Checked = True

            'TabControl3.SelectedTab = DxPrTestsPickTab
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT ChiefComplaint, Category from  MMChartCC  ORDER BY CategorySortOrder, ItemSortOrder ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()



            Me.DataGridViewPr.Columns(0).Width = 250


            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPickupChronic_Click(sender As Object, e As EventArgs) Handles btnPickupChronic.Click
        Try

            RadioButtonDx.Checked = False
            radProcedureNotes.Checked = False
            radPlan.Checked = False
            RadioButtonCC.Checked = False
            radChronic.Checked = True

            'TabControl3.SelectedTab = DxPrTestsPickTab
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT ChiefComplaint, Category from  MMChartCC  ORDER BY CategorySortOrder, ItemSortOrder ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()



            Me.DataGridViewPr.Columns(0).Width = 250


            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged



        If TabControl1.SelectedTab.Text = "Dx / Pro / Notes" Then
            'TabControl3.SelectedTab = DxPrTestsPickTab
            RadioButtonPr.Checked = False
            RadioButtonLT.Checked = False
            RadioButtonMT.Checked = False
            RadioButtonTestImaging.Checked = False
            RadioButtonDx.Checked = True

            'DataGridViewPr.DataSource = Nothing
            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                LoadMyList()
            End If
        End If


        If TabControl1.SelectedTab.Text = "CC / HPI / ROS / PE" Then
            'TabControl3.SelectedTab = DxPrTestsPickTab
            DataGridViewPr.DataSource = Nothing
        End If
    End Sub
    Private Function LoadMyList()
        If radMyDx.Checked = True Then
            Dim connString As String = connString2
            Dim cn As New SqlConnection(connString)
            cn.Open()
            Dim cmd As New SqlCommand

            Try
                If RadioButtonDx.Checked Then
                    cmd = New SqlCommand("SELECT MMDX.Code1 AS Code, MMDX.Description FROM  MMDX LEFT JOIN  PhysicianProfile ON MMDX.Code1 = PhysicianProfile.Code WHERE  physiciancode = '" & AssignedProviderCode & "' ORDER BY MMDX.Description", cn)
                ElseIf RadioButtonPr.Checked Then
                    cmd = New SqlCommand("SELECT Code1 As Code, MMPRocedure.Description, AmountA, MyProcedures, ScreenLocation, MMPRocedure.Type, InHouse, InHouseBilling  FROM   MMPRocedure LEFT JOIN PhysicianProfile ON MMPRocedure.Code1 = PhysicianProfile.Code where  physiciancode = '" & AssignedProviderCode & "' order by Description", cn)
                ElseIf RadioButtonLT.Checked Then
                    cmd = New SqlCommand("SELECT TestNo, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestLab  order by Description", cn)
                ElseIf RadioButtonMT.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMCHARTTESTMEDICAL  order by Description", cn)
                ElseIf RadioButtonTestImaging.Checked Then
                    cmd = New SqlCommand("SELECT ID, Description, Amount, MyTest, Type, InHouse, InHouseBilling FROM MMChartTestImaging  order by Description", cn)
                Else
                    Exit Function
                End If

                Dim da As New SqlDataAdapter
                Dim tbl As New DataTable
                Dim ds As New DataSet
                da.SelectCommand = cmd
                da.Fill(ds, "MMDX")

                myBindingSource = New BindingSource()
                myBindingSource.DataSource = ds
                myBindingSource.DataMember = ds.Tables(0).TableName
                DataGridViewPr.DataSource = myBindingSource

                ds.Dispose()
                cn.Close()

                Me.DataGridViewPr.Columns(0).Width = 70
                Me.DataGridViewPr.Columns(1).Width = 347

            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Function

    Private Sub btnPickCC_Click(sender As Object, e As EventArgs) Handles btnPickCC.Click
        Try
            Dim frmTemplatePicklist As New TemplatePicklist
            aPickCC = frmTemplatePicklist.ShowPicklist
            If aPickCC(0) = "Y" Then
                globalTemplate = aPickCC(1)
                globalChiefComplaint = aPickCC(2)
                Me.Text = "Visit Template Specific" + "                                                                               " + globalTemplate + "- " + globalChiefComplaint
                'If globalTemplate <> "" Then
                '    '***CHANGED***
                '    TabControl1.SelectedTab = DxPrTestsTab
                '    TabControl1.SelectedTab = HPITab
                '    radTemplateDX.PerformClick()
                'End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdHPI_Click(sender As Object, e As EventArgs) Handles cmdHPI.Click
        Try
            Dim FrmProcedure As New Procedure

            aRet = HPI.ShowPicklist
            If aRet(0) = "Y" Then
                txtHPI.Text = aRet(1)
                TextBox2.Text = aRet(2)
                If ChiefComplaintTextBox.Text = "" Then
                    ChiefComplaintTextBox.Text = aRet(2)
                Else
                    ChiefComplaintTextBox.Text = ChiefComplaintTextBox.Text & ", " & aRet(2)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LoadData(caseNumber As String)
        Try

            Dim connection As New SqlConnection(connString2)
            connection.Open()
            Dim query As String = "SELECT * FROM MMChartVisit WHERE CaseNumber = @CaseNumber"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@CaseNumber", caseNumber)

            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                TextBoxDx1.Text = reader("Dx1").ToString()
                Dx1DescriptionTextBox.Text = reader("Dx1Description").ToString()
                TextBoxDx2.Text = reader("Dx2").ToString()
                Dx2DescriptionTextBox.Text = reader("Dx2Description").ToString()
                'TextBoxDx3.Text = reader("Dx3").ToString()
                'Dx3DescriptionTextBox.Text = reader("Dx3Description").ToString()
                'TextBoxDx4.Text = reader("Dx4").ToString()
                'Dx4DescriptionTextBox.Text = reader("Dx4Description").ToString()
                Dx5DescriptionTextBox.Text = reader("Dx5Description").ToString()

                NotesTestBox.Text = reader("Notes").ToString()
                TextBoxfollowUp.Text = reader("FollowUp").ToString()
                TextBoxReferedTo.Text = reader("RefferedTo").ToString()
                TextBoxDiet.Text = reader("Diet").ToString()
                TextBoxCounselingEducation.Text = reader("Counselling").ToString()
                ChiefComplaintTextBox.Text = reader("ChiefComplaint").ToString()

                ChronicConditionsTextBox.Text = reader("ChronicConditions").ToString()
                txtHPI.Text = reader("HPI").ToString()
                ReviewOfSystemsTextBox.Text = reader("ReviewOfSystems").ToString()
                PhysicalExamTextBox.Text = reader("PhysicalExam").ToString()

            End If
            reader.Close()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally

            isLoading = False ' Re-enable TextChanged event tracking after data is loaded
            isDataChanged = False ' Reset data changed flag since it's just loading data
        End Try

    End Sub

    ' Function to update data back to the database
    Private Sub UpdateData(caseNumber As String)
        Try
            Dim connection As New SqlConnection(connString2)
            connection.Open()
            Dim query As String = "UPDATE MMChartVisit 
                                   SET Dx1 = @Dx1, Dx1Description = @Dx1Description ,Dx2 = @Dx2, Dx2Description = @Dx2Description,Dx3 = @Dx3,
                                    Dx3Description = @Dx3Description,Dx4 = @Dx4, Dx4Description = @Dx4Description,Dx5Description = @Dx5Description,
                                   Notes =@Notes, FollowUp = @FollowUp, RefferedTo = @RefferedTo, Diet = @Diet, Counselling = @Counselling,
                                    ChiefComplaint = @ChiefComplaint,ChronicConditions =@ChronicConditions, HPI = @HPI, ReviewOfSystems = @ReviewOfSystems 
                                    , PhysicalExam = @PhysicalExam
                                   WHERE CaseNumber = @CaseNumber"
            Dim command As New SqlCommand(query, connection)

            ' Set the parameters for updating
            command.Parameters.AddWithValue("@Dx1", TextBoxDx1.Text)
            command.Parameters.AddWithValue("@Dx1Description", Dx1DescriptionTextBox.Text)
            command.Parameters.AddWithValue("@Dx2", TextBoxDx2.Text)
            command.Parameters.AddWithValue("@Dx2Description", Dx2DescriptionTextBox.Text)
            command.Parameters.AddWithValue("@Dx3", "")
            command.Parameters.AddWithValue("@Dx3Description", "")
            command.Parameters.AddWithValue("@Dx4", "")
            command.Parameters.AddWithValue("@Dx4Description", "")
            command.Parameters.AddWithValue("@Dx5Description", "")
            command.Parameters.AddWithValue("@Notes", NotesTestBox.Text)
            command.Parameters.AddWithValue("@FollowUp", TextBoxfollowUp.Text)

            command.Parameters.AddWithValue("@RefferedTo", TextBoxReferedTo.Text)
            command.Parameters.AddWithValue("@Diet", TextBoxDiet.Text)
            command.Parameters.AddWithValue("@Counselling", TextBoxCounselingEducation.Text)

            command.Parameters.AddWithValue("@ChiefComplaint", ChiefComplaintTextBox.Text)

            command.Parameters.AddWithValue("@ChronicConditions", ChronicConditionsTextBox.Text)
            command.Parameters.AddWithValue("@HPI", txtHPI.Text)
            command.Parameters.AddWithValue("@ReviewOfSystems", ReviewOfSystemsTextBox.Text)
            command.Parameters.AddWithValue("@PhysicalExam", PhysicalExamTextBox.Text)

            command.Parameters.AddWithValue("@CaseNumber", caseNumber)

            ' Execute the query
            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            isDataChanged = False
        End Try
    End Sub

    Private Sub btnProcedureNotes_Click(sender As Object, e As EventArgs) Handles btnProcedureNotes.Click
        Try
            'TabControl3.SelectedIndex = 3
            'TabControl1.SelectedIndex = 5
            RadioButtonDx.Checked = False
            radPlan.Checked = False
            radProcedureNotes.Checked = True
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'Procedure Notes' ORDER BY ScreenLocation ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()
            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False

            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnOtherTxPanel_Click(sender As Object, e As EventArgs) Handles btnOtherTxPanel.Click
        Try
            'TabControl3.SelectedIndex = 3
            'TabControl1.SelectedIndex = 5
            radOther.Checked = True
            'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
            Dim connString As String = connString2

            Dim cn As New SqlConnection(connString)
            cn.Open()
            ' read the number of rows
            Dim cmd As New SqlCommand("SELECT Category,SubCategory, Discription as Description,ScreenLocation  from  MMCHRosAndGen where category= 'OtherTx Panel' ORDER BY ScreenLocation ", cn)
            Dim da As New SqlDataAdapter
            Dim tbl As New DataTable
            Dim ds As New DataSet
            da.SelectCommand = cmd
            da.Fill(ds, "MMCHRosAndGen")

            DataGridViewPr.DataSource = ds.Tables("MMCHRosAndGen")
            ds.Dispose()
            cn.Close()

            Me.DataGridViewPr.Columns(0).Visible = False
            Me.DataGridViewPr.Columns(1).Visible = True
            Me.DataGridViewPr.Columns(2).Width = 347
            Me.DataGridViewPr.Columns(3).Visible = False

            If globalTemplate <> "" Then
                radTemplateDX.Checked = True
                LoadTemplateSpecificDxPrTests()
            Else
                radMyDx.Checked = True
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        UpdateData(txtCaseNo.Text)
    End Sub

    Private Sub Orders_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isDataChanged Then
            Dim result As DialogResult = MessageBox.Show("You have unsaved changes. Do you want to save before exiting?", "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                UpdateData(txtCaseNo.Text) ' Save changes
            ElseIf result = DialogResult.Cancel Then
                e.Cancel = True ' Cancel form closing
            End If
        End If
    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDx1.TextChanged, Dx1DescriptionTextBox.TextChanged,
        TextBoxDx2.TextChanged, Dx2DescriptionTextBox.TextChanged, Dx5DescriptionTextBox.TextChanged, ChiefComplaintTextBox.TextChanged,
        ChronicConditionsTextBox.TextChanged, txtHPI.TextChanged, ReviewOfSystemsTextBox.TextChanged, PhysicalExamTextBox.TextChanged

        If Not isLoading Then
            isDataChanged = True
        End If
    End Sub
End Class