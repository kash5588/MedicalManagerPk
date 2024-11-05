Imports System.Data.SqlClient

Public Class ProcedureEdit


    Private Sub ProcedureEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Function ShowProcedureEdit(procedureID As String) As String

        LoadData(procedureID)

        Me.ShowDialog()
    End Function

    Private Sub LoadData(procedureID As String)

        Dim connectionString As String = connString2

        ' SQL query to select data where ID matches a specific value (replace with actual ID)
        Dim query As String = "SELECT ID, CaseNumber, Date, Code, Description, Amount, VisitType, Type FROM MMCHDxRxLtMt WHERE ID = @ID"

        ' Open SQL connection and retrieve data
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Replace @ID with the specific ID value
                command.Parameters.AddWithValue("@ID", procedureID) ' Replace 1 with the actual ID you want to search for

                ' Open the connection
                connection.Open()

                ' Execute the query
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Display the data in text boxes
                        TBAmount.Text = reader("Amount").ToString()
                        TBDesc.Text = reader("Description").ToString()
                        TBId.Text = reader("ID").ToString()
                        TBCode.Text = reader("Code").ToString()

                    Else
                        MessageBox.Show("No data found with the specified procedure ID.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateDate()

    End Sub

    Public Event DataUpdated()

    Private Sub UpdateDate()
        Dim connectionString As String = connString2

        ' SQL query to update the Amount field based on ID
        Dim query As String = "UPDATE MMCHDxRxLtMt SET Amount = @Amount WHERE ID = @ID"

        ' Open SQL connection and update data
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Set parameters with the updated amount and ID
                command.Parameters.AddWithValue("@Amount", TBAmount.Text)
                command.Parameters.AddWithValue("@ID", TBId.Text) ' Assumes TextBox1 contains the ID

                ' Open the connection
                connection.Open()

                ' Execute the update command
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' Confirm update success
                If rowsAffected > 0 Then
                    RaiseEvent DataUpdated()
                    Me.Close()
                Else
                    MessageBox.Show("No record found with the specified ID.")
                End If
            End Using
        End Using
    End Sub
End Class