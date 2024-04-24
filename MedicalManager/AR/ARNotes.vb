Public Class ARNotes
    Dim CNumber, HChartNumber As String
    Dim aRet(2) As String

    Private Sub MMARNotesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMARNotesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMARNotesBindingSource.EndEdit()
        Me.MMARNotesTableAdapter.Update(Me.ARDataSet.MMARNotes)

    End Sub

    Private Sub FillDataByCaseNumberToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.MMARNotesTableAdapter.FillDataByCaseNumber(Me.ARDataSet.MMARNotes, CType(CNumber, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub ShowARNotes(ByVal bRet() As String)
        CNumber = bRet(1)
        HChartNumber = bRet(2)
        Me.ShowDialog()
    End Sub


    Private Sub MMARNotesBindingSource_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles MMARNotesBindingSource.AddingNew
        Me.ARDataSet.MMARNotes.CaseNumberColumn.DefaultValue = CNumber
        Me.ARDataSet.MMARNotes.ChartNumberColumn.DefaultValue = HChartNumber
        Me.ARDataSet.MMARNotes.DateEnteredColumn.DefaultValue = System.DateTime.Today
    End Sub

    Private Sub ARNotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.MMARNotesTableAdapter.FillDataByCaseNumber(Me.ARDataSet.MMARNotes, CType(CNumber, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnComments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComments.Click
        Dim frmComments As New ARComments
        'aRet = frmCustomers.ShowPicklist
        ' frmCustomers.ShowDialog()
        aRet = frmComments.CommentsShowPicklist
        If aRet(0) = "Y" Then       ' they picked a lab
            NotesTextBox.Text = aRet(2)
        End If
    End Sub
End Class