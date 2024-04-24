Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports Microsoft.Reporting.WinForms

Public Class PrintMultipleBills
    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)

    Private Sub FillBillByChNoCaseNoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBillByChNoCaseNoToolStripButton.Click
        Try
            Me.BillingTableAdapter.FillBillByChNoCaseNo(Me.ARDataSet.Billing, Param1ToolStripTextBox.Text, CType(Param2ToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function LoadSalesData(ByVal chartnumber As String, ByVal casenumber As Integer) As DataTable
        Me.BillingTableAdapter.FillBillByChNoCaseNo(Me.ARDataSet.Billing, chartnumber, casenumber)
        Return Me.ARDataSet.Tables("Billing")
    End Function

    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, _
       ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New FileStream("..\..\" + name + "." + fileNameExtension, FileMode.Append)
        'Dim stream As Stream = New FileStream("..\..\" + name + "." + fileNameExtension, FileMode.Create)


        m_streams.Add(stream)
        Return stream
    End Function

    Private Sub Export(ByVal report As LocalReport)
        Dim deviceInfo As String = _
          "<DeviceInfo>" + _
          "  <OutputFormat>EMF</OutputFormat>" + _
          "  <PageWidth>8.5in</PageWidth>" + _
          "  <PageHeight>11in</PageHeight>" + _
          "  <MarginTop>1in</MarginTop>" + _
          "  <MarginLeft>1in</MarginLeft>" + _
          "  <MarginRight>1in</MarginRight>" + _
          "  <MarginBottom>1in</MarginBottom>" + _
          "</DeviceInfo>"
        Dim warnings() As Warning = Nothing
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)

        Dim stream As Stream
        For Each stream In m_streams
            ' stream.Position = 0
        Next
    End Sub

    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))
        ev.Graphics.DrawImage(pageImage, ev.PageBounds)
        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Private Sub Print()
        Try
            Dim printerName As String    ' =  "Brother MFC-3220C USB Printer"
            printerName = cboInstalledPrinters.Text
            If m_streams Is Nothing Or m_streams.Count = 0 Then
                Return
            End If

            Dim printDoc As New PrintDocument()
            printDoc.PrinterSettings.PrinterName = printerName
            If Not printDoc.PrinterSettings.IsValid Then
                Dim msg As String = String.Format("Can't find printer ""{0}"".", printerName)
                Console.WriteLine(msg)
                Return
            End If
            AddHandler printDoc.PrintPage, AddressOf PrintPage
            printDoc.Print()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PrintMultipleBills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ARDataSet.MMARTRANSACTIONS' table. You can move, or remove it, as needed.
        Me.MMARTRANSACTIONSTableAdapter.FillByCaseNumber(Me.ARDataSet.MMARTRANSACTIONS)

        Dim pkInstalledPrinters As String

        ' Find all printers installed
        For Each pkInstalledPrinters In PrinterSettings.InstalledPrinters
            cboInstalledPrinters.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters

        ' Set the combo to the first printer in the list
        cboInstalledPrinters.SelectedIndex = 0
        Dim i As Integer
        For i = 0 To BillingDataGridView.Rows.Count - 1
            Me.BillingDataGridView.Rows(i).Cells("chkSelect").Value = True
        Next
        '  Me.BillingTableAdapter.FillBy(Me.ARDataSet.Billing)
        'Me.BillingTableAdapter.FillBillByChNoCaseNo(Me.ARDataSet.Billing, "WATKI000", 681)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        '  Me.Run()
        Dim ChartNumber As String
        Dim CaseNumber As Integer


        Dim i As Integer
        For i = 0 To BillingDataGridView.Rows.Count - 1
            Dim report As LocalReport = New LocalReport()
            report.ReportPath = "C:\MedicalManager\MedicalManager\AR\PatientBill.rdlc"
            ChartNumber = BillingDataGridView.Rows(i).Cells("ChartNumber").Value
            CaseNumber = BillingDataGridView.Rows(i).Cells("CaseNumber").Value
            report.DataSources.Add(New ReportDataSource("ARDataSet_Billing", LoadSalesData(ChartNumber, CaseNumber)))

            Export(report)

            m_currentPageIndex = 0
            ' Print()
        Next
    End Sub
End Class



'Public Overloads Sub Dispose() Implements IDisposable.Dispose
'    If Not (m_streams Is Nothing) Then
'        Dim stream As Stream
'        For Each stream In m_streams
'            stream.Close()
'        Next
'        m_streams = Nothing
'    End If
'End Sub

'Public Shared Sub Main(ByVal args As String())
'    Using demo As Demo = New Demo()
'        demo.Run()
'    End Using
'End Sub






