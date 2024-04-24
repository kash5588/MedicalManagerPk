Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Configuration


Public Class DoctorInbox
    Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString


    Dim cn As New SqlConnection(connString)


    Private Sub GradientNavigationButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMedications.Click
        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString


        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT     [RX ID], ChartNumber, PatientName, OrderingPhysicianID, PhysicianName, LicenseNumber, Medication, Dosage, NumberOfRefills, StartDate, EndDate FROM MMChartRx  WHERE    ( SigNature = 0)", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMChartRx")

        InboxDataGridView.DataSource = ds.Tables("MMChartRx")
        ds.Dispose()
        cn.Close()
    End Sub

    Private Sub cmdVitalSigns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVitalSigns.Click
        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString

        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT     VID, ChartNumber, Date, Name, Temp, Pulse, Resp, Systolic, Diastolic, HtIn, WtLb, BMI  FROM MMChartTVitalSign  ", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet

        da.SelectCommand = cmd


        da.Fill(ds, "MMChartTVitalSign")

        cn.Close()
        InboxDataGridView.DataSource = ds.Tables("MMChartTVitalSign")

    End Sub

    Private Sub CmdMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMessages.Click
        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString


        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("select id, Date, ChartNumber, Name, MessageFrom, MessageTo, Subject, Status, Signature, SignedBy FROM Messaging WHERE  (Signature = 0)", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet

        da.SelectCommand = cmd


        da.Fill(ds, "Messaging")

        cn.Close()
        InboxDataGridView.DataSource = ds.Tables("Messaging")
        ' TextBox1.Text = Me.InboxDataGridView.SelectedRows(0).Cells(6).Value
    End Sub

    Private Sub cmdNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNotes.Click
        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString


        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT     ChartNumber, CaseNumber, DateCreated, Folder, DocumentType, Description, [Document], Image, [User], TimeStamp  FROM MMCHARTContents ", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet

        da.SelectCommand = cmd


        da.Fill(ds, "MMCHARTContents")

        cn.Close()
        InboxDataGridView.DataSource = ds.Tables("MMCHARTContents")
    End Sub

    Private Sub cmdtestorders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdtestorders.Click

        Dim connString As String = connString2 'ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString

        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT     ID, ChartNumber, Date, Type, Code, Description, UserCode, UserID, TimeStamp    FROM MMCHDxRxLtMt", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet

        da.SelectCommand = cmd
        da.Fill(ds, "MMCHDxRxLtMt")
        cn.Close()

        InboxDataGridView.DataSource = ds.Tables("MMCHDxRxLtMt")
    End Sub

    Private Sub GradientNavigationButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientNavigationButton3.Click

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
End Class
