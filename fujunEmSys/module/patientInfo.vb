Public Module patientInfo

    Private p_pID As String = ""
    Private p_pPID As String = ""
    Private p_pDOB As Date = Now
    Private p_pcDOB As String = ""
    Private p_pName As String = ""
    Private p_pSex As String = ""
    Private p_pPhone As String = ""
    Private p_pMobile As String = ""
    Private p_pAddress As String = ""
    Private p_pEmail As String = ""
    Private p_pCreatedDate As String = ""
    Private p_pRemarks As String = ""
    Private p_initiated As Boolean = False
    Private p_isNull As Boolean = True
    Private p_hID As String = ""
    Private p_phID As String = ""
    Private p_doc As String = ""

    Public Structure pInfo
        Public Sub initiate()
            p_pID = ""
            p_pPID = ""
            p_pcDOB = ""
            p_pDOB = Now
            p_pName = ""
            p_pSex = ""
            p_pPhone = ""
            p_pMobile = ""
            p_pAddress = ""
            p_pEmail = ""
            p_pCreatedDate = ""
            p_initiated = False
        End Sub
        Public Sub initiate(ByVal pID As Integer)
            Dim reader As IDataReader = runQuery("SELECT pID, pPID, pName, pSex, jul2chi(pdob) as pcdob, pdob, pPhone, pMobile, pAddress, pEmail, jul2chi(pCreatedDate) as pCreatedDate FROM patient WHERE pID='" & pID & "'")
            With reader
                If .Read Then
                    p_pID = .GetInt32(0)
                    If Not reader.IsDBNull(1) Then p_pPID = .GetString(1) Else p_pPID = ""
                    If Not reader.IsDBNull(2) Then p_pName = .GetString(2) Else p_pName = ""
                    If Not reader.IsDBNull(3) Then p_pSex = .GetValue(3) Else p_pSex = 0
                    If Not reader.IsDBNull(4) Then p_pcDOB = .GetString(4) Else p_pcDOB = ""
                    If Not reader.IsDBNull(5) Then p_pDOB = .GetDateTime(5) Else p_pDOB = ""
                    If Not reader.IsDBNull(6) Then p_pPhone = .GetString(6) Else p_pPhone = ""
                    If Not reader.IsDBNull(7) Then p_pMobile = .GetString(7) Else p_pMobile = ""
                    If Not reader.IsDBNull(8) Then p_pAddress = .GetString(8) Else p_pAddress = ""
                    If Not reader.IsDBNull(9) Then p_pEmail = .GetString(9) Else p_pEmail = ""
                    If Not reader.IsDBNull(10) Then p_pCreatedDate = .GetString(10) Else p_pCreatedDate = Now
                    p_initiated = True
                Else
                    p_pID = ""
                    p_pPID = ""
                    p_pcDOB = ""
                    p_pDOB = Now
                    p_pName = ""
                    p_pSex = ""
                    p_pPhone = ""
                    p_pMobile = ""
                    p_pAddress = ""
                    p_pEmail = ""
                    p_pCreatedDate = ""
                    p_initiated = False
                End If
            End With
        End Sub
        Property initiated As Boolean
            Get
                Return p_initiated
            End Get
            Set(value As Boolean)
                p_initiated = value
            End Set
        End Property
        ReadOnly Property isNew As Boolean
            Get
                If p_initiated Then
                    Dim reader As IDataReader = runQuery("select p.pID as 'ID', count(mh.hID) as 'times' from patient as p LEFT join medhistory as mh on p.pid = mh.pid where p.pid = '" & p_pID & "';")
                    reader.Read()
                    If reader.GetInt64(1) = 0 Then Return True Else Return False
                Else
                    Return True
                End If
            End Get
        End Property
        Property pID As String
            Get
                Return p_pID
            End Get
            Set(value As String)
                p_pID = value
            End Set
        End Property
        Property pPID As String
            Get
                Return p_pPID
            End Get
            Set(value As String)
                p_pPID = value
            End Set
        End Property
        Property pName As String
            Get
                Return p_pName
            End Get
            Set(value As String)
                p_pName = value
            End Set
        End Property
        Property pSex As String
            Get
                Return p_pSex
            End Get
            Set(value As String)

                p_pSex = value
            End Set
        End Property
        Property pPhone As String
            Get
                Return p_pPhone
            End Get
            Set(value As String)
                p_pPhone = value
            End Set
        End Property
        Property pMobile As String
            Get
                Return p_pMobile
            End Get
            Set(value As String)
                p_pMobile = value
            End Set
        End Property
        Property pAddress As String
            Get
                Return p_pAddress
            End Get
            Set(value As String)
                p_pAddress = value
            End Set
        End Property
        Property pEmail As String
            Get
                Return p_pEmail
            End Get
            Set(value As String)
                p_pEmail = value
            End Set
        End Property
        Property pCreatedDate As String
            Get
                Return p_pCreatedDate
            End Get
            Set(value As String)
                p_pCreatedDate = value
            End Set
        End Property
        Property pcDOB As String
            Get
                Return p_pcDOB
            End Get
            Set(value As String)
                p_pcDOB = value
            End Set
        End Property
        Property pDOB As Date
            Get
                Return p_pDOB
            End Get
            Set(value As Date)
                p_pDOB = value
            End Set
        End Property
        ReadOnly Property getInsertSQL As String
            Get
                Return "INSERT INTO `patient` (pPID, pName, pSex, pDOB, pPhone, pMobile, pAddress, pEmail, pRemarks) " &
                    "VALUES ('" & p_pPID & "', '" & p_pName & "', '" & p_pSex & "', '" & p_pDOB.ToString("yyyy-MM-dd") & "', '" & p_pPhone & "', '" & p_pMobile & "', '" & p_pAddress & "', '" & p_pEmail & "', '" & p_pRemarks & "')"
            End Get
        End Property
        ReadOnly Property pAge As Integer
            Get
                Return Now.Date.Year - pDOB.Year
            End Get
        End Property
        ReadOnly Property pLastVisit As Date
            Get
                Dim reader As IDataReader = runQuery("SELECT bookTime as 'last_visit' FROM patient_booking WHERE arrived=1 AND pID=" & p_pID & " ORDER BY bookTime DESC Limit 1")
                If reader.Read Then
                    Return reader.GetDateTime(0)
                End If
                Return Nothing
            End Get
        End Property

        ReadOnly Property pVisitCount As Integer
            Get
                Dim reader As IDataReader = runQuery("SELECT count(booktime) as 'visit_count' FROM patient_booking WHERE arrived=1 AND pID=" & p_pID)
                reader.Read()
                Return reader.GetInt64(0)
            End Get
        End Property
    End Structure

    Public Structure pHistory
        Private pIsSet As Boolean

        ReadOnly Property initiated As Boolean
            Get
                If p_hID = "" Then Return False Else Return True
            End Get
        End Property
        ReadOnly Property isSet As Boolean
            Get
                Return pIsSet
            End Get
        End Property

        Public Sub initiate()
            p_phID = ""
            p_hID = ""
            pIsSet = False
        End Sub

        Public Sub initiate(ByVal recTime As DateTime, ByVal docName As String)
            Dim reader As IDataReader = runQuery("SELECT * FROM medHistory WHERE visitTime<='" & recTime.ToString("yyyy-MM-dd HH:mm:ss") & "' AND pID='" & mainForm.patientInfo.pID & "' ORDER BY visitTime DESC")
            If reader.Read Then
                If reader.GetDateTime(2) = recTime Then
                    p_hID = reader.GetInt32(0)
                    If reader.Read Then
                        p_phID = reader.GetInt32(0)
                    Else
                        p_phID = ""
                    End If
                Else
                    runQuery("INSERT INTO medHistory(pID,visitTime,docName) VALUES('" & mainForm.patientInfo.pID & "', '" & recTime.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & docName & "')")
                    Dim result As IDataReader = runQuery("SELECT * FROM medHistory WHERE visitTime<='" & recTime.ToString("yyyy-MM-dd HH:mm:ss") & "' AND pID='" & mainForm.patientInfo.pID & "' ORDER BY visitTime DESC")
                    result.Read()
                    p_hID = result.GetInt32(0)
                    p_doc = result.GetString(3)
                    p_phID = reader.GetInt32(0)
                End If
            Else
                runQuery("INSERT INTO medHistory(pID,visitTime,docName) VALUES('" & mainForm.patientInfo.pID & "', '" & recTime.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & docName & "')")
                Dim result As IDataReader = runQuery("SELECT * FROM medHistory WHERE visitTime<='" & recTime.ToString("yyyy-MM-dd HH:mm:ss") & "' AND pID='" & mainForm.patientInfo.pID & "' ORDER BY visitTime DESC")
                result.Read()
                p_hID = result.GetInt32(0)
                p_doc = result.GetString(3)
                p_phID = ""
            End If
            pIsSet = True
        End Sub

        ReadOnly Property prevIsNull As Boolean
            Get
                If p_phID = "" Then Return True Else Return False
            End Get
        End Property
        Property hID As String
            Get
                Return p_hID
            End Get
            Set(value As String)
                p_hID = value
            End Set
        End Property
        Property phID As String
            Get
                Return p_phID
            End Get
            Set(value As String)
                p_phID = value
            End Set
        End Property
        ReadOnly Property docName As String
            Get
                If pIsSet Then
                    Dim reader As IDataReader = runQuery("SELECT * FROM medHistory WHERE hID='" & p_hID & "'")
                    reader.Read()
                    Return reader.GetString(3)
                Else
                    Return "-未設定紀錄-"
                End If
            End Get
        End Property
        ReadOnly Property visitTime As Date
            Get
                If pIsSet Then
                    Dim reader As IDataReader = runQuery("SELECT * FROM medHistory WHERE hID='" & p_hID & "'")
                    reader.Read()
                    Return reader.GetDateTime(2)
                Else
                    Return Nothing
                End If
            End Get
        End Property

    End Structure
End Module
