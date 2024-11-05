Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Reporting.WinForms


Public Class IncomeStatement
    Private Sub IncomeStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MMPrecticeTableAdapter.Fill(Me.MMDataDataSet1.MMPrectice)
        LoadPhysicain()
        'Dim DateToday As String = "01-11-2020"
        ' DateToday = DateToday.ToUpper()
        CCdateFrom.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub LoadPhysicain()

        ' Connection string to your SQL Server database
        Dim connectionString As String = connString2

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand("SELECT DISTINCT (FirstName + ' ' + LastName + '-' + Code) AS Name FROM [dbo].[MMPhysion]", connection)
            Try
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Clear existing items
                CBPhysicain.Items.Clear()

                ' Load items into ComboBox
                While reader.Read()
                    CBPhysicain.Items.Add(reader("Name").ToString())
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try


            Cursor.Current = Cursors.WaitCursor
            Me.MMPrecticeTableAdapter.Fill(Me.MMDataDataSet1.MMPrectice)
            Me.ExpensesDetailTableAdapter.FillByExpenseDate(Me.MMDataDataSet1.ExpensesDetail, CCdateFrom.Value.ToString(), CCdateTo.Value.ToString())


            If RBDoctor.Checked = True Then
                Dim fullText As String = CBPhysicain.Text
                Dim PhyCode() As String = Split(fullText, "-")
                Dim desiredText As String = PhyCode(1)

                Me.MMCHDxRxLtMtTableAdapter.FillByIncStatDateAndDoctor(Me.MMDataDataSet1.MMCHDxRxLtMt, CCdateFrom.Value.ToString(), CCdateTo.Value.ToString(), PhyCode(1))
                ExpensesDetailBindingSource.DataSource = Nothing
            ElseIf RBHospital.Checked = True Then
                Me.MMCHDxRxLtMtTableAdapter.FillByIncomeStAndDateFilter(Me.MMDataDataSet1.MMCHDxRxLtMt, CCdateFrom.Value.ToString(), CCdateTo.Value.ToString())

            End If

            ' Set report parameters
            Dim myDateTimeObject As DateTime = Convert.ToDateTime(CCdateFrom.Text)
            Dim DateFrom As String = myDateTimeObject.ToString("dd-MMM-yyyy")
            Dim myDateTimeObject1 As DateTime = Convert.ToDateTime(CCdateTo.Text)
            Dim DateTo As String = myDateTimeObject1.ToString("dd-MMM-yyyy")
            Dim parms As ReportParameter() = New ReportParameter(2) {}
            parms(0) = New ReportParameter("DateFrom", DateFrom)
            parms(1) = New ReportParameter("DateTo", DateTo)
            parms(2) = New ReportParameter("PracticeName", CommonFunction.GetGeneralInfo("PracticeName"))

            ReportViewer1.LocalReport.SetParameters(parms)

            ' Set data sources
            ReportViewer1.LocalReport.DataSources.Clear()
            Dim incomeDetailDataSource As New ReportDataSource
            Dim expensesDetailDataSource As New ReportDataSource

            incomeDetailDataSource.Name = "DataSetIncomeDetail"
            incomeDetailDataSource.Value = Me.MMCHDxRxLtMtBindingSource
            expensesDetailDataSource.Name = "DataSetExpensesDetail"
            expensesDetailDataSource.Value = Me.ExpensesDetailBindingSource


            ReportViewer1.LocalReport.DataSources.Add(incomeDetailDataSource)
            ReportViewer1.LocalReport.DataSources.Add(expensesDetailDataSource)

            ' Refresh the report
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error")
        End Try



    End Sub

    Private Sub RBHospital_CheckedChanged(sender As Object, e As EventArgs) Handles RBHospital.CheckedChanged
        CBPhysicain.Enabled = False
    End Sub

    Private Sub RBDoctor_CheckedChanged(sender As Object, e As EventArgs) Handles RBDoctor.CheckedChanged
        CBPhysicain.Enabled = True
    End Sub
End Class