Public Class pnlPerscription
    Inherits pnlSlider

    Private patientInfo As New pInfo
    Private bID As Integer = -1

#Region "初始"
    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)
        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.
        loadTree()
        refreshBooking()
    End Sub
#End Region

#Region "載入資料"
    Private Sub refreshBooking()
        Dim sql As String = "SELECT pb.bID, pb.pID, INSERT(pi.pname, 2, 1, '○') as 'patientName'
                            FROM patient_booking AS pb 
                            INNER JOIN patient as pi ON pb.pID = pi.pID
                            WHERE pb.bookTime >= '" & Now.Date & "' AND pb.bookTime < '" & Now.Date.AddDays(1) & "' 
                            ORDER BY pb.bookTime"
        With waitingList
            .DataSource = returnData(mainForm, sql)
            .ValueMember = "bID"
            .DisplayMember = "patientName"
        End With
        tabBooking.Focus()
    End Sub
#Region "載入藥品清單"
    ' 載入樹狀圖
    Private Sub loadTree(Optional ByVal whereClause As String = "")
        medTree.Nodes.Clear()
        Dim SQL As String = " SELECT mm.mID, mm.mName, ms.sID, ms.sName, mi.medName, mi.medID
                            FROM med_main AS mm INNER JOIN med_sub AS ms ON mm.mid=ms.mid
                            INNER JOIN med_item AS mi ON ms.sid = mi.sid"
        If Not whereClause = "" Then
            SQL += " WHERE " & whereClause
        End If
        Dim fullMedTable As DataTable = returnData(mainForm, SQL)
        Dim mainNode As TreeNode
        Dim subNode As TreeNode

        For Each row As DataRow In fullMedTable.Rows
            mainNode = searchNode(row.Item("mID"))
            subNode = searchSub(row.Item("mID"), row.Item("sID"))
            If row.Item("mName") = "解表劑" Then
                Application.DoEvents()
            End If

            If mainNode Is Nothing Then
                medTree.Nodes.Add(row.Item("mID"), row.Item("mName"))
            End If
            If subNode Is Nothing Then
                medTree.Nodes.Item(row.Item("mID").ToString).Nodes.Add(row.Item("sID"), row.Item("sName"))
            End If
            medTree.Nodes.Item(row.Item("mID").ToString).Nodes.Item(row.Item("sID").ToString).Nodes.Add(row.Item("medID"), row.Item("medName"))
        Next
        If Not whereClause = "" Then
            medTree.ExpandAll()
        Else
            medTree.CollapseAll()
        End If
    End Sub
    ' 搜尋主點
    Private Function searchNode(ByVal ID As Integer) As TreeNode
        For Each node As TreeNode In medTree.Nodes
            If node.Name = ID Then
                Return node
            End If
        Next
        Return Nothing
    End Function
    ' 搜尋副點
    Private Function searchSub(ByVal mID As String, ByVal sID As String) As TreeNode
        For Each node As TreeNode In medTree.Nodes
            If node.Name = mID Then
                For Each subNode As TreeNode In node.Nodes
                    If subNode.Name = sID Then
                        Return node
                    End If
                Next
            End If
        Next
        Return Nothing
    End Function
#End Region

    ' 載入藥物群組
    Private Sub reloadMedGroup()
        If patientInfo.initiated Then
            medGroupGrid.DataSource = returnData(mainForm, "Select * FROM medGroup2medDetail WHERE bID=" & waitingList.SelectedValue)
            For Each col As DataGridViewColumn In medGroupGrid.Columns
                col.Visible = False
            Next

        End If
    End Sub

#Region "載入病人資料"
    Private Sub waitingList_Click(sender As Object, e As EventArgs) Handles waitingList.Click
        If Not waitingList.SelectedIndex = -1 Then
            loadPatientData(waitingList.SelectedValue)
            patientTab.SelectedTab = tabPatientInfo
            pName.Text = patientInfo.pName
            If patientInfo.pSex = 0 Then pSex.Text = "女" Else pSex.Text = "男"
            pAge.Text = patientInfo.pAge
        End If
    End Sub
    Private Sub loadPatientData(ByVal bID As Integer)
        Dim reader As IDataReader = runQuery("Select pID FROM patient_booking WHERE bID=" & bID)
        If reader.Read Then
            Dim pID As Integer = reader.Item("pID")
            patientInfo = New pInfo
            patientInfo.initiate(pID)
            reader = runQuery("Select bookTime As 'last_visit', count(booktime) as 'visit_count' FROM patient_booking WHERE arrived=1 AND pID=" & patientInfo.pID)
                    While reader.Read
                    If Not IsDBNull(reader.Item(0)) Then pPrevVisit.Text = reader.GetDateTime("last_visit") Else pPrevVisit.Text = ""
                    pVisitTimes.Text = reader.Item(1)
                End While
            End If
    End Sub

#End Region

#End Region

#Region "搜尋"
    ' 藥品搜尋
    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        If searchBox.Text.Trim = "" Then
            loadTree()
        Else
            Dim SQL As String = "mi.pinyin LIKE '" & searchBox.Text.ToLower & "%' OR mi.zhuyin LIKE '" & searchBox.Text.ToLower & "%'"
            loadTree(SQL)
        End If
    End Sub
#End Region

End Class
