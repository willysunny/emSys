Public Class pnlMedInfo
    Inherits pnlSlider

    Public Event finish_edit As EventHandler

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "載入資料"
    ' 載入主分類
    Public Sub reloadMainGroup()
        RemoveHandler mainGroupList.SelectedIndexChanged, AddressOf mainGroupList_SelectedIndexChanged
        reloadList(mainGroupList, "mID", "mName", "SELECT * FROM med_main")
        AddHandler mainGroupList.SelectedIndexChanged, AddressOf mainGroupList_SelectedIndexChanged
        reloadSubGroup(mainGroupList.SelectedValue)
    End Sub
    ' 載入子分類
    Public Sub reloadSubGroup(ByVal mainID As Integer)
        RemoveHandler subGroupList.SelectedIndexChanged, AddressOf subGroupList_SelectedIndexChanged
        reloadList(subGroupList, "sID", "sName", "SELECT * FROM med_sub WHERE mID=", mainID)
        RemoveHandler subGroupList.SelectedIndexChanged, AddressOf subGroupList_SelectedIndexChanged
        reloadMedItem(subGroupList.SelectedValue)
    End Sub
    ' 載入藥品名稱
    Public Sub reloadMedItem(ByVal subID As Integer)
        reloadList(medList, "medID", "medName", "SELECT * FROM med_item WHERE sID=", subID)
        reloadUnusedMedItem()
    End Sub
    ' 載入未使用藥品名稱
    Public Sub reloadUnusedMedItem()
        reloadList(medList, "medID", "medName", "SELECT * FROM med_item WHERE sID=", -1)
    End Sub
    ' 載入函式
    Public Sub reloadList(ByRef lb As Object, ByVal vmName As String, ByVal dmName As String, ByVal sql As String, Optional ByVal input As String = "")
        With lb
            .DataSource = returnData(mainForm, sql & input)
            .ValueMember = vmName
            .DisplayMember = dmName
            .Refresh()
        End With
    End Sub
#End Region

#Region "觸發"
    Private Sub mainGroupList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mainGroupList.SelectedIndexChanged
        reloadSubGroup(mainGroupList.SelectedValue)
    End Sub
    Private Sub subGroupList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subGroupList.SelectedIndexChanged
        reloadMedItem(subGroupList.SelectedValue)
    End Sub

    Private Sub unusedMedList_CheckedChanged(sender As Object, e As EventArgs) Handles unusedMedList.CheckedChanged
        mainGroupList.Enabled = Not unusedMedList.Checked
        subGroupList.Enabled = Not unusedMedList.Checked
        If unusedMedList.Checked Then
            reloadMedItem(subGroupList.SelectedValue)
        Else
            reloadUnusedMedItem()
        End If
    End Sub
#End Region
End Class
