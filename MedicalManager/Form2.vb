Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        'Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        ' Dim config As New System.Configuration.ConfigurationManager()
        ' Dim connString As String = System.Configuration.ConfigurationManager.ConnectionStrings(2).ConnectionString
        Dim connString As String = connString2
        ' Dim connString As String = System.Configuration.ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString
        ' Dim connString As String = ConfigurationManager.ConnectionStrings("MedicalManager.My.MySettings.MMDataConnectionString1").ConnectionString


        TextBox1.Text = connString
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT Category, Discription as Description  from  MMCHRosAndGen where category= 'f/u Panel'", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        DataGridView1.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()
        cn.Close()
        cn.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
       Dim connString As String = connString2

        TextBox1.Text = connString
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT Category, Discription as Description  from  MMCHRosAndGen where category= 'f/u Panel'", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        DataGridView1.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()
        cn.Close()
        cn.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        Dim connString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=MMData;Integrated Security=True"


        TextBox1.Text = connString
        Dim cn As New SqlConnection(connString)
        cn.Open()
        ' read the number of rows
        Dim cmd As New SqlCommand("SELECT Category, Discription as Description  from  MMCHRosAndGen where category= 'f/u Panel'", cn)
        Dim da As New SqlDataAdapter
        Dim tbl As New DataTable
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "MMCHRosAndGen")

        DataGridView1.DataSource = ds.Tables("MMCHRosAndGen")
        ds.Dispose()
        cn.Close()
        cn.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        DataGridView1.DataSource = Nothing
    End Sub
End Class