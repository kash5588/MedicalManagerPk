Public Class LabCorpInterFace

    Private Sub HL711BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HL711BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HL711BindingSource.EndEdit()
        Me.HL711TableAdapter.Update(Me.MMDataDataSet.HL711)

    End Sub

    Private Sub LabCorpInterFace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                  'TODO: This line of code loads data into the 'MMDataDataSet.HL7Reports' table. You can move, or remove it, as needed.
                  Me.HL7ReportsTableAdapter.FillExID(Me.MMDataDataSet.HL7Reports)
                  'TODO: This line of code loads data into the 'MMDataDataSet.HL711' table. You can move, or remove it, as needed.
                  Me.HL711TableAdapter.Fill(Me.MMDataDataSet.HL711)
            Catch ex As System.Exception
                  System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim msgText As String
        Dim result As DialogResult

        'Try

        msgText = "Import All Cars."
        msgText = msgText & ControlChars.CrLf & "Save In Inventory ?"

        result = MessageBox.Show(msgText, "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' If Windows.Forms.DialogResult.Yes = N Then

        If result = Windows.Forms.DialogResult.Yes Then



            Dim i As Integer
            Dim myNumberofRows As Integer = 0
            Dim myDataTable1 As DataTable
            Dim myDataTable2 As DataTable
            Dim strAryWords
            Dim strValue

            myDataTable1 = Me.MMDataDataSet.HL711
            myDataTable2 = Me.MMDataDataSet.HL7Reports
            ' Dim newRow1 As DataRow = myDataTable1.NewRow()
            ' Dim newRow2 As DataRow = myDataTable2.NewRow()





            For i = 0 To Me.MMDataDataSet.HL711.Rows.Count - 1

                Dim newRow1 As DataRow = myDataTable1.NewRow()
                Dim newRow2 As DataRow = myDataTable2.NewRow()

                Dim ID, MSH, PID, OBR, OBX As String
                Dim MSH4, PID1SetID, PID2PatientIDExt, PID3PatientIDInt, PID4AltPatientID, PID5S1LastName, PID5S2FirstName, PID5S3MiddleInitial, PID5S4Suffix, PID5S5Prefix, PID7DateOfBirth, PID8Sex, PID11S1Address1, PID11S2Address2, PID11S3City, PID11S4State, PID11S5Zip, PID11S6County, PID13PhoneNumHome, PID19SSNNumber As String
                Dim OBR1SetID, OBR3FillerOrderNum, OBR4S1TestCode, OBR4S2TestName, OBR6RequestedDateTime, OBR7ObservDateTime, OBR14SpecimanRecieveDateTime, OBR15S1SpecimanSource, OBR16S1OPID, OBR16S2OPLastName, OBR16S3OPFirstName, OBR16S4OPMI, OBR16S5OPSuffix, OBR16S6OPPrefix, OBR16S7OPDegree As String
                Dim MSH4SendingFacility, MSH7DateTime As String


                ID = Me.MMDataDataSet.HL711.Rows(i)("Field1")



                If ID.Substring(0, 3) = "MSH" Then

                    MSH4SendingFacility = Me.MMDataDataSet.HL711.Rows(i)("Field5")
                    MSH7DateTime = Me.MMDataDataSet.HL711.Rows(i)("Field8") & ""

                ElseIf ID.Substring(0, 3) = "PID" Then

                    PID1SetID = Me.MMDataDataSet.HL711.Rows(i)("Field2") & ""
                    PID2PatientIDExt = Me.MMDataDataSet.HL711.Rows(i)("Field3") & ""
                    PID3PatientIDInt = Me.MMDataDataSet.HL711.Rows(i)("Field4") & ""
                    PID4AltPatientID = Me.MMDataDataSet.HL711.Rows(i)("Field5") & ""

                    Dim PIDName As String
                    PIDName = Me.MMDataDataSet.HL711.Rows(i)("Field6") & ""

                    strValue = PIDName
                    strAryWords = Split(strValue, "^")

                    PID5S1LastName = strAryWords(0)
                    PID5S2FirstName = strAryWords(1)
                    PID5S3MiddleInitial = strAryWords(2)
                    '           PID5S4Suffix = strAryWords(3)
                    '               PID5S5Prefix = strAryWords(4)



                    PID7DateOfBirth = Me.MMDataDataSet.HL711.Rows(i)("Field8") & ""
                    PID8Sex = Me.MMDataDataSet.HL711.Rows(i)("Field9") & ""

                    Dim PIDAdd As String

                    PIDAdd = Me.MMDataDataSet.HL711.Rows(i)("Field12") & ""
                    strValue = PIDAdd

                    strAryWords = Split(strValue, "^")
                    If strValue <> "" Then
                        PID11S1Address1 = strAryWords(0)
                        PID11S2Address2 = strAryWords(1)
                        PID11S3City = strAryWords(2)
                        PID11S4State = strAryWords(3)
                        PID11S5Zip = strAryWords(4)
                        PID11S6County = strAryWords(5)
                    End If
                    PID13PhoneNumHome = Me.MMDataDataSet.HL711.Rows(i)("Field5") & ""
                    PID19SSNNumber = Me.MMDataDataSet.HL711.Rows(i)("Field6") & ""

                ElseIf ID.Substring(0, 3) = "OBR" Then
                    ' Dim OBR1SetID, OBR3FillerOrderNum, OBR4S1TestCode, OBR4S2TestName, OBR6RequestedDateTime, OBR7ObservDateTime, OBR14SpecimanRecieveDate, OBR15S1SpecimanSource, OBR16S1OPID, OBR16S2OPLastName, OBR16S3OPFirstName, OBR16S4OPMI, OBR16S5OPSuffix, OBR16S6OPPrefix, OBR16S7OPDegree As String

                    ' OBR4 = Me.MMDataDataSet.HL711.Rows(i)("Field5") & ""
                    OBR1SetID = Me.MMDataDataSet.HL711.Rows(i)("Field2") & ""
                    OBR3FillerOrderNum = Me.MMDataDataSet.HL711.Rows(i)("Field4") & ""

                    Dim OBR4 As String
                    OBR4 = Me.MMDataDataSet.HL711.Rows(i)("Field5")
                    strValue = OBR4
                    strAryWords = Split(strValue, "^")

                    OBR4S1TestCode = strAryWords(0)
                    OBR4S2TestName = strAryWords(1)

                    OBR6RequestedDateTime = Me.MMDataDataSet.HL711.Rows(i)("Field7") & ""
                    OBR7ObservDateTime = Me.MMDataDataSet.HL711.Rows(i)("Field8") & ""
                    OBR14SpecimanRecieveDateTime = Me.MMDataDataSet.HL711.Rows(i)("Field15") & ""
                    OBR15S1SpecimanSource = Me.MMDataDataSet.HL711.Rows(i)("Field6") & ""

                    Dim OBR16 As String
                    OBR16 = Me.MMDataDataSet.HL711.Rows(i)("Field17") & ""

                    strValue = OBR16
                    strAryWords = Split(strValue, "^")


                    OBR16S1OPID = strAryWords(0)
                    '        OBR16S2OPLastName = strAryWords(1)
                    '       OBR16S3OPFirstName = strAryWords(2)
                    '       OBR16S4OPMI = strAryWords(3)
                    '       OBR16S5OPSuffix = strAryWords(4)
                    '       OBR16S6OPPrefix = strAryWords(5)
                    '       OBR16S7OPDegree = strAryWords(6)


                ElseIf ID.Substring(0, 3) = "OBX" Or ID.Substring(0, 3) = "NTE" Then

                    'MSH
                    newRow2("MSH4SendingFacility") = MSH4SendingFacility
                    newRow2("MSH7DateTime") = MSH7DateTime
                    'PID

                    newRow2("PID1SetID") = PID1SetID
                    newRow2("PID2PatientIDExt") = PID2PatientIDExt
                    newRow2("PID3PatientIDInt") = PID3PatientIDInt
                    newRow2("PID4AltPatientID") = PID4AltPatientID

                    newRow2("PID5S1LastName") = PID5S1LastName
                    newRow2("PID5S2FirstName") = PID5S2FirstName
                    newRow2("PID5S3MiddleInitial") = PID5S3MiddleInitial
                    newRow2("PID5S4Suffix") = PID5S4Suffix
                    newRow2("PID5S5Prefix") = PID5S5Prefix


                    newRow2("PID7DateOfBirth") = PID7DateOfBirth
                    newRow2("PID8Sex") = PID8Sex
                    newRow2("PID11S1Address1") = PID11S1Address1
                    newRow2("PID11S2Address2") = PID11S2Address2
                    newRow2("PID11S3City") = PID11S3City
                    newRow2("PID11S4State") = PID11S4State
                    newRow2("PID11S5Zip") = PID11S5Zip
                    newRow2("PID11S6County") = PID11S6County
                    newRow2("PID13PhoneNumHome") = PID13PhoneNumHome
                    newRow2("PID19SSNNumber") = PID19SSNNumber

                    'OBR

                    newRow2("OBR1SetID") = OBR1SetID
                    newRow2("OBR3FillerOrderNum") = OBR3FillerOrderNum
                    newRow2("OBR4S1TestCode") = OBR4S1TestCode
                    newRow2("OBR4S2TestName") = OBR4S2TestName
                    newRow2("OBR7ObservDateTime") = OBR7ObservDateTime
                    newRow2("OBR14SpecimanRecieveDateTime") = OBR14SpecimanRecieveDateTime
                    newRow2("OBR15S1SpecimanSource") = OBR15S1SpecimanSource

                    newRow2("OBR16S1OPID") = OBR16S1OPID
                    newRow2("OBR16S2OPLastName") = OBR16S2OPLastName
                    newRow2("OBR16S3OPFirstName") = OBR16S3OPFirstName
                    newRow2("OBR16S4OPMI") = OBR16S4OPMI
                    newRow2("OBR16S5OPSuffix") = OBR16S5OPSuffix
                    newRow2("OBR16S6OPPrefix") = OBR16S6OPPrefix
                    newRow2("OBR16S7OPDegree") = OBR16S7OPDegree









                    ''OBX

                    newRow2("OBX1SetID") = Me.MMDataDataSet.HL711.Rows(i)("Field2")
                    newRow2("OBX2ValueType") = Me.MMDataDataSet.HL711.Rows(i)("Field3")
                    newRow2("OBX3S1ObservIdentifier") = Me.MMDataDataSet.HL711.Rows(i)("Field4")


                    newRow2("OBX4ObservSub") = Me.MMDataDataSet.HL711.Rows(i)("Field5")


                    Dim OBX5 As String
                    OBX5 = Me.MMDataDataSet.HL711.Rows(i)("Field6") & ""

                    strValue = OBX5
                    strAryWords = Split(strValue, "^")


                    newRow2("OBX5S1SubSeq") = strAryWords(0)
                    newRow2("OBX5S2DataType") = strAryWords(1)
                    newRow2("OBX5S3TestNo") = strAryWords(2)
                    newRow2("OBX5S4TestName") = strAryWords(3)
                    newRow2("OBX5S7Result") = strAryWords(3) 'Me.MMDataDataSet.HL711.Rows(i)("Field6") & ""
                    newRow2("OBX6Units") = Me.MMDataDataSet.HL711.Rows(i)("Field7")
                    newRow2("OBX7ReferenceRange") = Me.MMDataDataSet.HL711.Rows(i)("Field8")
                    newRow2("OBX8Flag") = Me.MMDataDataSet.HL711.Rows(i)("Field9")

                    newRow2("OBX11ObservResultsStatus") = Me.MMDataDataSet.HL711.Rows(i)("Field12")
                    newRow2("OBX14DateTimeObserv") = Me.MMDataDataSet.HL711.Rows(i)("Field13")


                    'ElseIf ID.Substring(0, 3) = "NTE" Then



                    '    newRow2("OBX1SetID") = Me.MMDataDataSet.HL711.Rows(i)("Field2")
                    '    newRow2("OBX3S1ObservIdentifier") = Me.MMDataDataSet.HL711.Rows(i)("Field4")


                    Me.MMDataDataSet.Tables("HL7Reports").Rows.Add(newRow2)

                End If




            Next


            HL7ReportsTableAdapter.Update(Me.MMDataDataSet.HL7Reports)

        End If


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error Happened", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'End Try

    End Sub

End Class