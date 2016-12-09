Public Class pnlPerscription
    Inherits pnlSlider

    Private patientInfo As New pInfo
    Private bID As Integer = -1

#Region "初始"
    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)
        ' This call is required by the designer.
        InitializeComponent()

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

    Private Sub loadTree(Optional ByVal whereClause As String = "")
        medTree.Nodes.Clear()
        Dim fullMedTable As DataTable = returnData(mainForm, " SELECT mm.mID, mm.mName, ms.sID, ms.sName, mi.medName, mi.medID
                                                                FROM med_main AS mm INNER JOIN med_sub AS ms ON mm.mid=ms.mid
                                                                INNER JOIN med_item AS mi ON ms.sid = mi.sid")
        Dim mainNode As TreeNode
        Dim subNode As TreeNode
        Dim medNode As TreeNode

        For Each row As DataRow In fullMedTable.Rows


        Next
    End Sub

    Private Sub reloadMedGroup()
        If patientInfo.initiated Then
            medGroupGrid.DataSource = returnData(mainForm, "SELECT * FROM medGroup2medDetail WHERE bID=" & waitingList.SelectedValue)
            For Each col As DataGridViewColumn In medGroupGrid.Columns
                col.Visible = False
            Next

        End If
    End Sub

#End Region

#Region "事件"
    Private Sub waitingList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles waitingList.SelectedIndexChanged
        If Not waitingList.SelectedIndex = -1 Then

        End If
    End Sub
#End Region

End Class
