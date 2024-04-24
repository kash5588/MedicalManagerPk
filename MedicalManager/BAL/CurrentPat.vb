Public Class CurrentPat



      Private intPatientID As System.Int32
      Private strChartNumber As System.String
      Private strLastName As System.String
      Private strFirstName As System.String
      Private strMiddleInitial As System.String
      Private strStreet1 As System.String
      Private strStreet2 As System.String
      Private strCity As System.String
      Private strState As System.String
      Private strZipCode As System.String
      Private strHomeePhone As System.String
      Private strCellPhone As System.String
      Private strSocialSecurityNumber As System.String
      Private strSex As System.String
      Private strDateofBirth As System.DateTime
      Private strRace As System.String
      Private strMstatus As System.String
      Private strAssignedProvider As System.String

      Public Property PatientID() As System.Int32
            Get
                  Return intPatientID
            End Get
            Set(ByVal value As Int32)
                  intPatientID = value
            End Set
      End Property
      Public Property ChartNumber() As System.String
            Get
                  Return strChartNumber
            End Get
            Set(ByVal value As String)
                  strChartNumber = value
            End Set
      End Property
      Public Property LastName() As System.String
            Get
                  Return strLastName
            End Get
            Set(ByVal value As String)
                  strLastName = value
            End Set
      End Property
      Public Property FirstName() As System.String
            Get
                  Return strFirstName
            End Get
            Set(ByVal value As String)
                  strFirstName = value
            End Set
      End Property
      Public Property MiddleInitial() As System.String
            Get
                  Return strMiddleInitial
            End Get
            Set(ByVal value As String)
                  strMiddleInitial = value
            End Set

      End Property
      Public Property Street1() As System.String
            Get
                  Return strStreet1
            End Get
            Set(ByVal value As String)
                  strStreet1 = value
            End Set
      End Property
      Public Property Street2() As System.String
            Get
                  Return strStreet2
            End Get
            Set(ByVal value As String)
                  strStreet2 = value
            End Set
      End Property
      Public Property City() As System.String
            Get
                  Return strCity
            End Get
            Set(ByVal value As String)
                  strCity = value
            End Set
      End Property
      Public Property State() As System.String
            Get
                  Return strState
            End Get
            Set(ByVal value As String)
                  strState = value
            End Set
      End Property
      Public Property ZipCode() As System.String
            Get
                  Return strZipCode
            End Get
            Set(ByVal value As String)
                  strZipCode = value
            End Set
      End Property
      Public Property HomeePhone() As System.String
            Get
                  Return strHomeePhone
            End Get
            Set(ByVal value As String)
                  strHomeePhone = value
            End Set
      End Property
      Public Property CellPhone() As System.String
            Get
                  Return strCellPhone
            End Get
            Set(ByVal value As String)
                  strCellPhone = value
            End Set
      End Property

      Public Property SocialSecurityNumber() As System.String
            Get
                  Return strSocialSecurityNumber
            End Get
            Set(ByVal value As String)
                  strSocialSecurityNumber = value
            End Set
      End Property

      Public Property Sex() As System.String
            Get
                  Return strSex
            End Get
            Set(ByVal value As String)
                  strSex = value
            End Set
      End Property
      Public Property DateofBirth() As System.DateTime
            Get
                  Return strDateofBirth
            End Get
            Set(ByVal value As DateTime)
                  strDateofBirth = value
            End Set
      End Property
      Public Property Race() As System.String
            Get
                  Return strRace
            End Get
            Set(ByVal value As String)
                  strRace = value
            End Set
      End Property
      Public Property Mstatus() As System.String
            Get
                  Return strMstatus
            End Get
            Set(ByVal value As String)
                  strMstatus = value
            End Set
      End Property


      Public Property AssignedProvider() As System.String
            Get
                  Return strAssignedProvider
            End Get
            Set(ByVal value As String)
                  strAssignedProvider = value
            End Set
      End Property



End Class

