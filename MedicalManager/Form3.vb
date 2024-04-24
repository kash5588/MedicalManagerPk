Public Class Form3
    Dim MyForm As Form, C As Control, X As Integer
    Dim MyArray() As Object
    Private Sub MMChartCCBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MMChartCCBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MMChartCCBindingSource.EndEdit()
        Me.MMChartCCTableAdapter.Update(Me.MMDataDataSet1.MMChartCC)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MMDataDataSet1.MMChartCC' table. You can move, or remove it, as needed.
        Me.MMChartCCTableAdapter.Fill(Me.MMDataDataSet1.MMChartCC)

    End Sub



  


    '    Private Sub Form_Current()
    '        ' MyForm = Me.Form
    '        ReDim MyArray(MyForm.Controls.Count - 1)

    '        X = -1
    '        For Each C In MyForm.Controls
    '            X = X + 1
    '            Select Case C.ControlType
    '                Case acTextBox, acComboBox, acListBox, acOptionGroup 'Skip Updates field.
    '                    If C.Name = "Updates" Then GoTo TryNextC
    '                    MyArray(X) = C.Value
    '            End Select
    '        Next
    '    End Sub


    'Add the following code to the Before_Update Event of the form, and then save the form:
    '    Private Sub Form_BeforeUpdate(ByVal Cancel As Integer)

    '        Dim MyForm As Form, C As Control
    '        MyForm = Screen.ActiveForm
    '      On Err GoTo TryNextC
    '        ' Set date and current user if form has been updated.
    '      MyForm!Updates = MyForm!Updates & Chr(13) & Chr(10) & _
    '      "Changes made on " & Date & " by " & CurrentUser() & ";"

    '        ' If new record, record it in audit trail and exit sub.

    '        If MyForm.NewRecord = True Then
    '            MyForm!Updates = MyForm!Updates & Chr(13) & Chr(10) & _
    '               "New Record """
    '            Exit Sub
    '        End If

    '        ' Check each data entry control for change and record
    '        ' old value of Control.
    '        'Set the Array Counter      
    '        X = -1
    '        For Each C In MyForm.Controls

    '            ' Only check data entry type controls.
    '            X = X + 1
    '            Select Case C.ControlType

    '                Case acTextBox, acComboBox, acListBox, acOptionGroup
    '                    ' Skip Updates field.
    '                    If C.Name = "Updates" Then GoTo TryNextC

    '                    ' If control was previously Null, record "previous
    '                    ' value was blank."
    '                    If IsNull(MyArray(X)) Then
    '                        MyForm!Updates = MyForm!Updates & Chr(13) & _
    '                           Chr(10) & C.Name & "--previous value was blank"
    '                        ' If control had previous value, record previous value.
    '                    ElseIf C.Value <> MyArray(X) Then
    '                        MyForm!Updates = MyForm!Updates & Chr(13) & Chr(10) & _
    '                           C.Name & "==previous value was " & MyArray(X)
    '                    End If
    '            End Select
    'TryNextC:
    '        Next C
    '    End Sub













End Class