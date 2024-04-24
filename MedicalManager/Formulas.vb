Public Class Formulas

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As String
        x = T6.Text
        T7.Text = T6.Text
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        T6.Text = T6.Text + ListBox1.Text
    End Sub
End Class