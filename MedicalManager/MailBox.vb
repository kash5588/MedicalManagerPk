
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class MailBox

    Public mbPicklistmode As Boolean
    Private mbSelected As Boolean
    Dim aRetPatientInfo(12) As String

    Private Sub MailBoxBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MailBoxBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MailBoxBindingSource.EndEdit()
        Me.MailBoxTableAdapter.Update(Me.MMDataDataSet1.MailBox)

    End Sub

    Private Sub MailBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MailBox' table. You can move, or remove it, as needed.
        Me.MailBoxTableAdapter.Fill(Me.MMDataDataSet1.MailBox)
        LoadUsers()
    End Sub

    Private Sub btnGetPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPatient.Click
        Try
            aRetPatientInfo = PickList.PatientShowPicklist
            If aRetPatientInfo(0) = "Y" Then       ' they picked a lab
                ChartNumberTextBox.Text = aRetPatientInfo(1).Trim
                LastNameTextBox.Text = aRetPatientInfo(2).Trim
                FirstNameTextBox.Text = aRetPatientInfo(3).Trim
                PatientPhoneTextBox.Text = aRetPatientInfo(5).Trim '& " / " & aRetPatientInfo(6).Trim
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error Picking Patient")
        End Try
    End Sub

    Private Sub MailBoxBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MailBoxBindingSource.AddingNew
        Me.MMDataDataSet1.MailBox.DateColumn.DefaultValue = Format(Now, "MM/dd/yyyy")
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        TabControl1.SelectedIndex = 1
    End Sub
    Private Function LoadUsers()
        Dim connString As String = connString2
        Dim cn As New SqlConnection(connString)
        cn.Open()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("SELECT networkusername from mmusers", cn)

        Dim dr As SqlDataReader = cmd.ExecuteReader()
        While dr.Read
            AssignedByComboBox.Items.Add(dr.Item(0).ToString)
            AssignedToComboBox.Items.Add(dr.Item(0).ToString)
        End While
        dr.Close()
        cn.Close()

    End Function

    Private Sub MailBox_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim msgText As String
        Dim result As DialogResult

        Try
            If Me.Validate Then
                Me.MailBoxBindingSource.EndEdit()
            Else
                e.Cancel = True
                Return
            End If


            If Me.MMDataDataSet1.MailBox.GetChanges() IsNot Nothing Then
                msgText = "You have made changes that have not been saved to the database."
                msgText = msgText & ControlChars.CrLf & _
                    "Save changes?"

                result = MessageBox.Show(msgText, "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
                Select Case result
                    Case Windows.Forms.DialogResult.Yes
                        Me.MailBoxTableAdapter.Update(Me.MMDataDataSet1.MailBox)

                    Case Windows.Forms.DialogResult.No
                        Me.MMDataDataSet1.MailBox.RejectChanges()

                    Case Else
                        e.Cancel = True
                End Select
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Students form closing", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            e.Cancel = True
        End Try

    End Sub
End Class