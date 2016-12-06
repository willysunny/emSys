Public Class pnlMedManage
    Inherits pnlSlider
#Region "初始"
    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        reloadMainGroup()
    End Sub
#End Region
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
        reloadUnusedSubGroup()
        reloadMedItem(subGroupList.SelectedValue)
    End Sub
    ' 載入未使用子分類
    Public Sub reloadUnusedSubGroup()
        reloadList(unusedSubGroupList, "sID", "sName", "SELECT * FROM med_sub WHERE mID=", -1)
    End Sub
    ' 載入藥品名稱
    Public Sub reloadMedItem(ByVal subID As Integer)
        reloadList(medList, "medID", "medName", "SELECT * FROM med_item WHERE sID=", subID)
        reloadUnusedMedItem()
    End Sub
    ' 載入未使用藥品名稱
    Public Sub reloadUnusedMedItem()
        reloadList(unusedmedList, "medID", "medName", "SELECT * FROM med_item WHERE sID=", -1)
    End Sub
    ' 載入函式
    Public Sub reloadList(ByRef lb As ListBox, ByVal vmName As String, ByVal dmName As String, ByVal sql As String, Optional ByVal input As String = "")
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
        subTable.Enabled = True
        reloadSubGroup(mainGroupList.SelectedValue)
    End Sub
    Private Sub subGroupList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subGroupList.SelectedIndexChanged
        medTable.Enabled = True
        reloadMedItem(subGroupList.SelectedValue)
    End Sub
#End Region
#Region "藥品移動"
    ' 刪除單一
    Private Sub delMed_Click(sender As Object, e As EventArgs) Handles delMed.Click, medList.DoubleClick
        If Not medList.SelectedIndex = -1 Then
            runQuery("UPDATE med_item SET sID=-1 WHERE medID=" & medList.SelectedValue)
            reloadMedItem(subGroupList.SelectedValue)
        End If
    End Sub
    ' 刪除全部
    Private Sub delMedAll_Click(sender As Object, e As EventArgs) Handles delMedAll.Click
        For i = 0 To medList.Items.Count - 1
            runQuery("UPDATE med_item SET sID=-1 WHERE medID=" & CType(medList.Items(i), DataRowView).Row.ItemArray(0))
        Next
        reloadMedItem(subGroupList.SelectedValue)
    End Sub
    ' 新增單一
    Private Sub addMed_Click(sender As Object, e As EventArgs) Handles addMed.Click, unusedMedList.DoubleClick
        If Not unusedMedList.SelectedIndex = -1 Then
            runQuery("UPDATE med_item SET sID=" & subGroupList.SelectedValue & " WHERE medID=" & unusedMedList.SelectedValue)
            reloadMedItem(subGroupList.SelectedValue)
        End If
    End Sub
    ' 新增全部
    Private Sub addMedAll_Click(sender As Object, e As EventArgs) Handles addMedAll.Click
        For i = 0 To unusedMedList.Items.Count - 1
            runQuery("UPDATE med_item SET sID=" & subGroupList.SelectedValue & " WHERE medID=" & CType(unusedMedList.Items(i), DataRowView).Row.ItemArray(0))
        Next
        reloadMedItem(subGroupList.SelectedValue)
    End Sub
#End Region
#Region "子分類移動"
    ' 新增單一
    Private Sub addSubGroup_Click(sender As Object, e As EventArgs) Handles addSubGroup.Click, unusedSubGroupList.DoubleClick
        If Not unusedSubGroupList.SelectedIndex = -1 Then
            runQuery("UPDATE med_sub SET mID=" & mainGroupList.SelectedValue & " WHERE sID=" & unusedSubGroupList.SelectedValue)
            reloadSubGroup(mainGroupList.SelectedValue)
        End If
    End Sub
    ' 新增全部
    Private Sub addSubGroupAll_Click(sender As Object, e As EventArgs) Handles addSubGroupAll.Click
        For i = 0 To unusedSubGroupList.Items.Count - 1
            runQuery("UPDATE med_sub SET mID=" & mainGroupList.SelectedValue & " WHERE sID=" & CType(unusedSubGroupList.Items(i), DataRowView).Row.ItemArray(0))
        Next
        reloadSubGroup(mainGroupList.SelectedValue)
    End Sub
    ' 刪除單一
    Private Sub delSubGroup_Click(sender As Object, e As EventArgs) Handles delSubGroup.Click, subGroupList.DoubleClick
        If Not subGroupList.SelectedIndex = -1 Then
            runQuery("UPDATE med_sub SET mID=-1 WHERE sID=" & subGroupList.SelectedValue)
            reloadSubGroup(mainGroupList.SelectedValue)
        End If
    End Sub
    ' 刪除全部
    Private Sub delSubGroupAll_Click(sender As Object, e As EventArgs) Handles delSubGroupAll.Click
        For i = 0 To subGroupList.Items.Count - 1
            runQuery("UPDATE med_sub SET mID=-1 WHERE sID=" & CType(subGroupList.Items(i), DataRowView).Row.ItemArray(0))
        Next
        reloadSubGroup(mainGroupList.SelectedValue)
    End Sub
#End Region
#Region "群組設定"
    ' 新增主分類
    Private Sub mainGroupAdd_Click(sender As Object, e As EventArgs) Handles mainGroupAdd.Click
        Dim inputName As String = InputBox("請輸入主分類名稱:", "新增主分類")
        If MetroFramework.MetroMessageBox.Show(Me, "確認新增主分類【" & inputName & "】?", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            runQuery("INSERT INTO med_main (mName) VALUE ('" & inputName & "')")
            MetroFramework.MetroMessageBox.Show(Me, "新增成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reloadMainGroup()
        End If
    End Sub
    ' 刪除主分類
    Private Sub mainGroupDel_Click(sender As Object, e As EventArgs) Handles mainGroupDel.Click
        If mainGroupList.SelectedIndex = -1 Then
            MetroFramework.MetroMessageBox.Show(Me, "沒有任何資料可刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MetroFramework.MetroMessageBox.Show(Me, "請確定您要刪除主分類【" & CType(mainGroupList.SelectedItem, DataRowView).Row.ItemArray(1) & "】? 所有相關的子分類將會被歸類至未使用分類!", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                runQuery("UPDATE med_sub SET mID=-1 WHERE mID=" & mainGroupList.SelectedValue)
                runQuery("DELETE FROM med_main WHERE mID=" & mainGroupList.SelectedValue)
                MetroFramework.MetroMessageBox.Show(Me, "刪除成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reloadMainGroup()
            End If
        End If
    End Sub
    ' 新增子分類
    Private Sub subGroupAdd_Click(sender As Object, e As EventArgs) Handles subGroupAdd.Click, unusedSubGroupAdd.Click
        Dim inputName As String = InputBox("請輸入子分類名稱:", "新增子分類")
        If MetroFramework.MetroMessageBox.Show(Me, "確認新增子分類【" & inputName & "】?", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If sender.name = "subGroupAdd" Then
                runQuery("INSERT INTO med_sub (sName,mID) VALUE ('" & inputName & "', " & mainGroupList.SelectedValue & ")")
            ElseIf sender.name = "unusedSubGroupAdd" Then
                runQuery("INSERT INTO med_sub (sName,mID) VALUE ('" & inputName & "', -1)")
            End If
            MetroFramework.MetroMessageBox.Show(Me, "新增成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reloadMainGroup()
        End If
    End Sub
    ' 刪除主分類
    Private Sub subGroupDel_Click(sender As Object, e As EventArgs) Handles subGroupDel.Click, unusedSubGroupDel.Click
        Dim lb As ListBox = Nothing
        If sender.name = "subGroupDel" Then
            lb = subGroupList
        ElseIf sender.name = "unusedSubGroupDel" Then
            lb = unusedSubGroupList
        End If
        If lb Is Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "這不應該發生的", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf lb.SelectedIndex = -1 Then
            MetroFramework.MetroMessageBox.Show(Me, "沒有任何資料可刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MetroFramework.MetroMessageBox.Show(Me, "請確定您要刪除子分類【" & CType(lb.selecteditem, DataRowView).Row.ItemArray(1) & "】? 所有相關的藥品資訊將會被歸類至未使用分類!", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                runQuery("UPDATE med_item SET sID=-1 WHERE sID=" & lb.SelectedValue)
                runQuery("DELETE FROM med_sub WHERE sID=" & lb.SelectedValue)
                MetroFramework.MetroMessageBox.Show(Me, "刪除成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reloadSubGroup(mainGroupList.SelectedValue)
            End If
        End If
    End Sub
#End Region

End Class
