Imports Microsoft.Reporting.WinForms

Public Class IncomeStatement
    Private Sub IncomeStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMPrectice' table. You can move, or remove it, as needed.
        Me.MMPrecticeTableAdapter.Fill(Me.MMDataDataSet1.MMPrectice)

        'Dim DateToday As String = "01-11-2020"
        ' DateToday = DateToday.ToUpper()
        CCdateFrom.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Me.MMPrecticeTableAdapter.Fill(Me.MMDataDataSet1.MMPrectice)
            Dim Charity As String = ""


            Me.ExpensesDetailTableAdapter.FillByExpenseDate(Me.MMDataDataSet1.ExpensesDetail, CCdateFrom.Value.ToString(), CCdateTo.Value.ToString())
            Me.MMCHDxRxLtMtTableAdapter.FillByIncomeStAndDateFilter(Me.MMDataDataSet1.MMCHDxRxLtMt, CCdateFrom.Value.ToString(), CCdateTo.Value.ToString())


            Dim myDateTimeObject As DateTime = Convert.ToDateTime(CCdateFrom.Text)
            Dim DateFrom As String = myDateTimeObject.ToString("dd-MMM-yyyy")
            Dim myDateTimeObject1 As DateTime = Convert.ToDateTime(CCdateTo.Text)
            Dim DateTo As String = myDateTimeObject1.ToString("dd-MMM-yyyy")

            Dim parms As ReportParameter() = New ReportParameter(3) {}
            parms(0) = New ReportParameter("DateFrom", DateFrom)
            Me.reportViewer1.LocalReport.SetParameters(parms(0))
            parms(1) = New ReportParameter("DateTo", DateTo)
            Me.reportViewer1.LocalReport.SetParameters(parms(1))

            parms(2) = New ReportParameter(CommonFunction.GetGeneralInfo("PracticeName"))
            Me.reportViewer1.LocalReport.SetParameters(parms(2))

            Me.reportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error")
        End Try
    End Sub


End Class