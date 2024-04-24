Imports System.Data.SqlClient
Imports System.IO

Public Class PatientPictures
    Dim alltext As String = ""
    Private Sub PatientPicture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet2.PatientPictures' table. You can move, or remove it, as needed.
        Me.PatientPicturesTableAdapter.Fill(Me.MMDataDataSet2.PatientPictures)
    End Sub

    Private Sub PatientPicturesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PatientPicturesBindingSource.EndEdit()
        Me.PatientPicturesTableAdapter.Update(Me.MMDataDataSet2.PatientPictures)

    End Sub


    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        Dim objOpenFileDialog As New OpenFileDialog

        With objOpenFileDialog
            .Filter = "Image files (.jpg, .jpeg, .bmp, .gif)|*.jpg;*.jpeg;*.bmp;*.gif;*.png"
            .FilterIndex = 1
            .Title = "Open File Dialog"
            .InitialDirectory = "C:\"
        End With

        If objOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Dim allText As String
            Try
                allText = objOpenFileDialog.FileName
                Dim originalimage As System.Drawing.Image
                originalimage = Image.FromFile(allText)
                PictureImagePictureBox.Image = originalimage
                '  SaveToDatabase(allText)
            Catch fileException As Exception
                Throw fileException
            End Try
        End If

        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub

    Private Function SaveToDatabase(ByVal allText As String)

        Dim connString As String = connString2
        Dim con As New SqlConnection(connString)

        Dim da As New SqlDataAdapter("Select * From PatientPictures", con)
        Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
        Dim ds As New DataSet()

        da.MissingSchemaAction = MissingSchemaAction.AddWithKey

        Dim fs As New FileStream(allText, FileMode.OpenOrCreate, FileAccess.Read)
        Dim MyData(fs.Length) As Byte
        fs.Read(MyData, 0, fs.Length)
        fs.Close()
        con.Open()
        da.Fill(ds, "PatientPictures")
        Dim myRow As DataRow
        myRow = ds.Tables("PatientPictures").NewRow()

        myRow("ChartNumber") = ChartNumberTextBox.Text
        myRow("PictureImage") = MyData
        ds.Tables("PatientPictures").Rows.Add(myRow)
        da.Update(ds, "PatientPictures")

        fs = Nothing
        MyCB = Nothing
        ds = Nothing
        da = Nothing

        con.Close()
        con = Nothing
        'MsgBox("Image saved to database")
    End Function

  

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim connString As String = connString2
        Dim con As New SqlConnection(connString)

        Dim da As New SqlDataAdapter("Select * From PatientPictures", con)
        Dim MyCB As SqlCommandBuilder = New SqlCommandBuilder(da)
        Dim ds As New DataSet()

        da.MissingSchemaAction = MissingSchemaAction.AddWithKey

        Dim fs As New FileStream(alltext, FileMode.OpenOrCreate, FileAccess.Read)
        Dim MyData(fs.Length) As Byte
        fs.Read(MyData, 0, fs.Length)
        fs.Close()
        con.Open()
        da.Fill(ds, "PatientPictures")
        Dim myRow As DataRow
        myRow = ds.Tables("PatientPictures").NewRow()

        myRow("ChartNumber") = ChartNumberTextBox.Text
        myRow("PictureImage") = MyData
        ds.Tables("PatientPictures").Rows.Add(myRow)
        da.Update(ds, "PatientPictures")

        fs = Nothing
        MyCB = Nothing
        ds = Nothing
        da = Nothing

        con.Close()
        con = Nothing
        'MsgBox("Image saved to database")
    End Sub
End Class