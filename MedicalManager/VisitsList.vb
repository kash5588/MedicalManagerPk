Imports Ascend.Windows.Forms
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class VisitsList
    Public aRet(10) As String



    Private Sub VisitsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMPRocedure' table. You can move, or remove it, as needed.


        LoadcmbPhysion()
        LoadComboBoxesV2()
        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text, CBStatus.Text)
        '  Me.MMChartVisitTableAdapter.Fill(Me.MMDataDataSet1.MMChartVisit)



    End Sub

    Private Sub MMChartVisitDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles MMChartVisitDataGridView.SelectionChanged
        Try
            Dim originalDate As String = ""
            If MMChartVisitDataGridView.SelectedRows.Count > 0 Then

                aRet(0) = "Y"
                aRet(1) = MMChartVisitDataGridView.SelectedRows(0).Cells("ChartNumber").Value & "" 'chartnumber
                aRet(2) = MMChartVisitDataGridView.SelectedRows(0).Cells("LastName").Value & ""  'last name
                aRet(3) = MMChartVisitDataGridView.SelectedRows(0).Cells("FirstName").Value & ""   'first name
                aRet(10) = MMChartVisitDataGridView.SelectedRows(0).Cells("CaseNumber").Value & ""   'CaseNumber
                aRet(6) = MMChartVisitDataGridView.SelectedRows(0).Cells("DOB").Value & ""   'DOB

                ChartNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("ChartNumber").Value
                txtName.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("FirstName").Value & " " & Me.MMChartVisitDataGridView.SelectedRows(0).Cells("LastName").Value
                txtCaseNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("CaseNumber").Value & ""
                TBTokenNo.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("TokenNo").Value & ""
                TBPhysicianName.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("PhysicianName").Value & ""
                TBDate.Text = Me.MMChartVisitDataGridView.SelectedRows(0).Cells("DateVisit").Value & ""

                originalDate = MMChartVisitDataGridView.SelectedRows(0).Cells("DOB").Value.ToString()

                If originalDate <> "" Then
                    Dim parsedDate As DateTime
                    If DateTime.TryParseExact(originalDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, parsedDate) Then
                        ' Format the date to dd/MM/yyyy and display it in the TextBoxDOB
                        tbDOB.Text = parsedDate.ToString("dd/MM/yyyy")
                    End If
                Else
                    tbDOB.Text = ""
                End If
                ' Try to parse the original date string using the MM/dd/yyyy format


                LoadPicture()


            End If

            If MMChartVisitDataGridView.SelectedRows.Count = 0 Then
                clearTextBox()
            End If

            loadLeftSideGrid()
        Catch
        End Try
    End Sub

    Private Sub loadLeftSideGrid()
        If MMChartVisitDataGridView.SelectedRows.Count > 0 Then
            Me.MMChartTVitalSignTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartTVitalSign, aRet(10))
            If DgVitals.Rows.Count > 0 Then
                PanelVitals.Visible = True
            Else
                PanelVitals.Visible = False
            End If
            Me.MMChartRxTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMChartRx, aRet(10))
            If DgMedicine.Rows.Count > 0 Then
                PanelMadication.Visible = True
            Else
                PanelMadication.Visible = False
            End If
            Me.MMCHDxRxLtMtTableAdapter.FillByCaseNumber(Me.MMDataDataSet1.MMCHDxRxLtMt, aRet(10))
            If DgProcedure.Rows.Count > 0 Then
                PanelProcedure.Visible = True
            Else
                PanelProcedure.Visible = False
            End If
        Else
            PanelVitals.Visible = False
            PanelMadication.Visible = False
            PanelProcedure.Visible = False

        End If

    End Sub
    Private Function LoadComboBoxesV2()
        Try

            Dim db As DBAccess = New DBAccess()
            Dim dt As New DataTable()

            dt.Load(db.ExecuteReader("SELECT * FROM MMComboV2"))

            ' Loop through each row in the DataTable

            For Each dtRow As DataRow In dt.Rows
                ' Check if the Property value is "Status"
                If dtRow("Property").ToString() = "Status" Then
                    ' Add the Text value to the ComboBox
                    CBStatus.Items.Add(dtRow("Text").ToString())
                End If
            Next

            dt.Dispose()

            ' Select the first item in the ComboBox if there are any items
            If CBStatus.Items.Count > 0 Then
                CBStatus.SelectedIndex = 0
            End If
        Catch ex As Exception
            ' Show a message box if there is an error
            MessageBox.Show(ex.ToString(), "Error loading comboboxes.")
        End Try



    End Function
    Private Sub LoadPicture()
        Try
            Dim connString As String = CommonFunction.connString2
            Using cn As New SqlConnection(connString)
                cn.Open()
                Dim strValue As String = ""
                PBoxPatient.Image = Nothing
                If ChartNo.Text <> "" Then
                    Using cmd As New SqlCommand("SELECT ChartNumber, PictureImage FROM PatientPictures WHERE ChartNumber = @ChartNumber", cn)
                        cmd.Parameters.AddWithValue("@ChartNumber", ChartNo.Text)

                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                strValue = reader("PictureImage").ToString()
                                If strValue = "System.Byte[]" Then
                                    Dim byteBLOBData() As Byte = CType(reader("PictureImage"), Byte())
                                    PBoxPatient.Image = ToImage(byteBLOBData)
                                    PBoxPatient.SizeMode = PictureBoxSizeMode.StretchImage
                                    PBoxPatient.BorderStyle = BorderStyle.FixedSingle
                                Else
                                    PBoxPatient.Image = Nothing
                                    PBoxPatient.BorderStyle = BorderStyle.None
                                End If
                            End While
                        End Using
                    End Using

                End If

                cn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error")
        End Try
    End Sub

    Private Function ToImage(byteArray As Byte()) As Image
        Using ms As New MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Sub clearTextBox()
        ChartNo.Text = ""
        txtName.Text = ""
        TBTokenNo.Text = ""
        TBPhysicianName.Text = ""
        txtCaseNo.Text = ""
        tbDOB.Text = ""
        TBDate.Text = ""
    End Sub

    Private Sub btnVitals_Click(sender As Object, e As EventArgs) Handles btnVitals.Click
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Try
            sAction = "VistListVitals"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)
            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User not authorized to Add Vitals", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            If MMChartVisitDataGridView.SelectedRows.Count > 0 Then

                VitalSigns.ShowVitalSigns(aRet)
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try





    End Sub
    Public Function GetFilteredChartVisits(ByVal physicianName As String, ByVal dateFilter As String, ByVal Status As String) As DataTable

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
                    command.Parameters.Add(New SqlParameter("@Status", SqlDbType.NVarChar, 20))
                    command.Parameters("@Status").Value = Status

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
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Try
            sAction = "VistListMedication"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)
            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User not authorized to Add Medication", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MMChartVisitDataGridView.SelectedRows.Count > 0 Then
                Prescription.ShowPrescriptions(aRet)
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub cmbFilterByDate_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBDate.SelectedValueChanged, CBStatus.SelectedValueChanged
        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text, CBStatus.Text)
    End Sub

    Private Sub CBPhysician_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBPhysician.SelectedValueChanged
        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text, CBStatus.Text)
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
                        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text, CBStatus.Text)
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
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Try
            sAction = "VistListProcedures"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)
            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User not authorized to Add Procedures", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MMChartVisitDataGridView.SelectedRows.Count > 0 Then
                Orders.ShowProcedures(aRet, TBPhysicianName.Text)
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try





    End Sub

    Private Sub BtnVisitReport_Click(sender As Object, e As EventArgs) Handles BtnVisitReport.Click
        Dim pieces() As String
        Dim IndexOf As Integer
        Dim sAction As String
        Try
            sAction = "VistListProcedures"
            pieces = Permissions.Split(",")
            IndexOf = Array.IndexOf(pieces, sAction)
            If IndexOf <> -1 Then
            Else
                MessageBox.Show("User not authorized to Add Procedures", "Authorization Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If MMChartVisitDataGridView.SelectedRows.Count > 0 Then
                RV.ShowVisit(ChartNo.Text, TBDate.Text, txtCaseNo.Text, "visit")
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MMChartVisitDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MMChartVisitDataGridView.CellFormatting
        If MMChartVisitDataGridView.Columns(e.ColumnIndex).Name = "DOB" Then
            ' Check if the cell value is not null or empty
            If e.Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(e.Value.ToString()) Then
                Dim originalDate As String = e.Value.ToString()
                ' Parse the original date string using the MM/dd/yyyy format
                Dim parsedDate As DateTime
                If DateTime.TryParseExact(originalDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, parsedDate) Then
                    ' Format the date to dd/MM/yyyy
                    e.Value = parsedDate.ToString("dd/MM/yyyy")
                    ' Set the Formatting Applied flag to true
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text, CBStatus.Text)
    End Sub

    Private Sub BtnToken_Click(sender As Object, e As EventArgs) Handles BtnToken.Click
        RVtokenSlip.ShowReport(txtCaseNo.Text)
    End Sub

    Private Sub BtnCompleted_Click(sender As Object, e As EventArgs) Handles BtnCompleted.Click

        ' Define your connection string (update with your server details)
        Dim connectionString As String = connString2

        ' SQL query to update the status
        Dim query As String = "UPDATE MMChartVisit SET Status = @Status WHERE ChartNumber = @ChartNumber AND CaseNumber = @CaseNumber"

        ' Create a new SQL connection
        Using connection As New SqlConnection(connectionString)
            ' Create a new SQL command
            Using command As New SqlCommand(query, connection)
                ' Add parameters to the command
                command.Parameters.AddWithValue("@Status", "COMPLETED")
                command.Parameters.AddWithValue("@ChartNumber", ChartNo.Text.Trim())
                command.Parameters.AddWithValue("@CaseNumber", txtCaseNo.Text.Trim())

                ' Open the connection
                connection.Open()

                ' Execute the command
                command.ExecuteNonQuery()
            End Using
        End Using
        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text, CBStatus.Text)
    End Sub

    Private Sub CBStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBStatus.SelectedIndexChanged
        GetFilteredChartVisits(CBPhysician.Text, CBDate.Text, CBStatus.Text)
    End Sub
End Class