Imports Ascend.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class VisitsList
    Public aRet(10) As String



    Private Sub VisitsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMPRocedure' table. You can move, or remove it, as needed.


        LoadcmbPhysion()
        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text)
        '  Me.MMChartVisitTableAdapter.Fill(Me.MMDataDataSet1.MMChartVisit)



    End Sub

    Private Sub MMChartVisitDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles MMChartVisitDataGridView.SelectionChanged
        Try
            If MMChartVisitDataGridView.SelectedRows.Count Then

                aRet(0) = "Y"
                aRet(1) = MMChartVisitDataGridView.SelectedRows(0).Cells("ChartNumber").Value & "" 'chartnumber
                aRet(2) = MMChartVisitDataGridView.SelectedRows(0).Cells("LastName").Value & ""  'last name
                aRet(3) = MMChartVisitDataGridView.SelectedRows(0).Cells("FirstName").Value & ""   'first name
                aRet(10) = MMChartVisitDataGridView.SelectedRows(0).Cells("CaseNumber").Value & ""   'CaseNumber

                ChartNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("ChartNumber").Value
                txtName.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("FirstName").Value & " " & Me.MMChartVisitDataGridView.SelectedRows(0).Cells("LastName").Value
                txtCaseNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("CaseNumber").Value & ""
                TBTokenNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("TokenNo").Value & ""
                TBPhysicianName.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("PhysicianName").Value & ""
                TBDate.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("DateVisit").Value & ""
                'LoadPicture()

                Me.MMChartTVitalSignTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartTVitalSign, aRet(1), System.DateTime.Now.Date())
                If DgVitals.Rows.Count > 0 Then
                    PanelVitals.Visible = True
                Else
                    PanelVitals.Visible = False
                End If
                Me.MMChartRxTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMChartRx, aRet(1), System.DateTime.Now.Date())
                If DgMedicine.Rows.Count > 0 Then
                    PanelMadication.Visible = True
                Else
                    PanelMadication.Visible = False
                End If
                Me.MMCHDxRxLtMtTableAdapter.FillByChNoAndDate(Me.MMDataDataSet1.MMCHDxRxLtMt, aRet(1), System.DateTime.Now.Date())
                If DgProcedure.Rows.Count > 0 Then
                    PanelProcedure.Visible = True
                Else
                    PanelProcedure.Visible = False
                End If
            End If
            If MMChartVisitDataGridView.SelectedRows.Count = 0 Then
                clearTextBox()
            End If

        Catch
        End Try
    End Sub

    Private Sub clearTextBox()
        ChartNo.Text = ""
        txtName.Text = ""
        TBTokenNo.Text = ""
        TBPhysicianName.Text = ""
        txtCaseNo.Text = ""
    End Sub

    Private Sub btnVitals_Click(sender As Object, e As EventArgs) Handles btnVitals.Click


        If MMChartVisitDataGridView.SelectedRows.Count Then

            VitalSigns.ShowVitalSigns(aRet)
        End If



    End Sub
    Public Function GetFilteredChartVisits(ByVal physicianName As String, ByVal dateFilter As String) As DataTable

        ' Create a new DataTable to hold the results
        Dim resultTable As New DataTable()

        Try
            ' Create a new SQL connection using the connection string
            Using connection As New SqlConnection(connString2)
                ' Open the connection
                connection.Open()

                ' Create a new SQL command using the stored procedure
                Using command As New SqlCommand("FilterChartVisits", connection)
                    command.CommandType = CommandType.StoredProcedure

                    ' Add the parameters to the SQL command
                    command.Parameters.Add(New SqlParameter("@PhysicianName", SqlDbType.NVarChar, 50))
                    If String.IsNullOrEmpty(physicianName) Then
                        command.Parameters("@PhysicianName").Value = DBNull.Value
                    Else
                        command.Parameters("@PhysicianName").Value = physicianName
                    End If

                    command.Parameters.Add(New SqlParameter("@DateFilter", SqlDbType.NVarChar, 10))
                    command.Parameters("@DateFilter").Value = dateFilter

                    ' Create a new SqlDataAdapter to fill the DataTable
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(resultTable)
                    End Using
                End Using
            End Using

            MMChartVisitBindingSource = New BindingSource()

            MMChartVisitBindingSource.DataSource = resultTable

            MMChartVisitDataGridView.DataSource = MMChartVisitBindingSource

        Catch ex As Exception
            ' Handle exceptions
            Console.WriteLine("Error: " & ex.Message)
        End Try

        ' Return the result set
        Return resultTable
    End Function
    Private Function LoadcmbPhysion()

        Dim dr As DataRow
        Dim dt As New DataTable()
        Dim sqlQuery As String = "SELECT FirstName, LastName FROM MMPhysion"
        Dim connectionString As String = connString2

        Try
            ' Establish a connection to the database
            Using conn As New SqlConnection(connectionString)
                ' Create a SQL command
                Using cmd As New SqlCommand(sqlQuery, conn)
                    ' Create a DataAdapter to execute the query and fill the DataTable
                    Using adapter As New SqlDataAdapter(cmd)
                        conn.Open()

                        ' Check if connection is open
                        If conn.State = ConnectionState.Open Then
                            ' Fill the DataTable
                            adapter.Fill(dt)

                            ' Check if the DataTable has data
                            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                                ' Iterate through the DataTable rows and populate the combo box
                                For Each dr In dt.Rows
                                    Dim firstName As String = dr("FirstName").ToString()
                                    Dim lastName As String = dr("LastName").ToString()

                                    If firstName <> "N/A" AndAlso lastName <> "N/A" Then
                                        CBPhysician.Items.Add($"{firstName} {lastName}")
                                    ElseIf firstName <> "N/A" Then
                                        CBPhysician.Items.Add(firstName)
                                    ElseIf lastName <> "N/A" Then
                                        CBPhysician.Items.Add(lastName)
                                    End If
                                Next
                            Else
                                MessageBox.Show("No data found in the DataTable.", "Info")
                            End If
                        Else
                            MessageBox.Show("Failed to open connection to the database.", "Connection Error")
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading name of Physicians")
        End Try
    End Function
    Private Sub BtnMedication_Click(sender As Object, e As EventArgs) Handles BtnMedication.Click
        If MMChartVisitDataGridView.SelectedRows.Count Then
            Prescription.ShowPrescriptions(aRet)
        End If
    End Sub

    Private Sub cmbFilterByDate_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBDate.SelectedValueChanged
        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text)
    End Sub

    Private Sub CBPhysician_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBPhysician.SelectedValueChanged
        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text)
    End Sub

    Private Sub txtFind_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFind.KeyUp
        Try

            If cmbFilter.Text <> "" Then

                If cmbFilter.Text = "CaseNumber" Then

                    If txtFind.Text <> "" Then
                        Me.MMChartVisitBindingSource.Filter = cmbFilter.Text & " = " & txtFind.Text
                        Me.MMChartVisitBindingSource.Sort = "CaseNumber DESC"
                        MMChartVisitDataGridView.DataSource = Me.MMChartVisitBindingSource
                    Else
                        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text)
                    End If

                Else
                    ' For string columns, use Like
                    Me.MMChartVisitBindingSource.Filter = cmbFilter.Text & " LIKE '" & txtFind.Text & "%'"
                    Me.MMChartVisitBindingSource.Sort = "CaseNumber DESC"
                    MMChartVisitDataGridView.DataSource = Me.MMChartVisitBindingSource

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbFilter_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedValueChanged
        txtFind.Focus()
        txtFind.Clear()
    End Sub

    Private Sub BtnProcedures_Click(sender As Object, e As EventArgs) Handles BtnProcedures.Click
        If MMChartVisitDataGridView.SelectedRows.Count Then
            Orders.ShowProcedures(aRet, TBPhysicianName.Text)
        End If
    End Sub

    Private Sub BtnVisitReport_Click(sender As Object, e As EventArgs) Handles BtnVisitReport.Click
        RV.ShowVisit(ChartNo.Text, TBDate.Text, txtCaseNo.Text, "visit")
    End Sub
End Class