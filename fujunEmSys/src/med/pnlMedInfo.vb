Public Class pnlMedInfo
    Inherits pnlSlider

    Public Event finish_edit As EventHandler

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.
        reloadMainGroup()

#Region "批發/單價單位"
        Dim unit As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 測量點
        unit.Add(1, "克")
        unit.Add(2, "顆")
        Dim unitTable As DataTable = New DataTable()
        With unitTable
            .Columns.Add("unitCode", GetType(Integer))
            .Columns.Add("unitName", GetType(String))
            For Each point As KeyValuePair(Of Integer, String) In unit
                .Rows.Add(point.Key, point.Value)
            Next
        End With
        With unitUnit
            .DataSource = unitTable
            .DisplayMember = "unitName"
            .ValueMember = "unitCode"
        End With
        With groupAmountUnit
            .DataSource = unitTable
            .DisplayMember = "unitName"
            .ValueMember = "unitCode"
        End With
#End Region
#Region "批發單位"
        Dim gUnit As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 測量點
        gUnit.Add(1, "包")
        gUnit.Add(2, "瓶")
        Dim groupUnitTable As DataTable = New DataTable()
        With groupUnitTable
            .Columns.Add("unitCode", GetType(Integer))
            .Columns.Add("unitName", GetType(String))
            For Each point As KeyValuePair(Of Integer, String) In gUnit
                .Rows.Add(point.Key, point.Value)
            Next
        End With
        With groupUnit
            .DataSource = groupUnitTable
            .DisplayMember = "unitName"
            .ValueMember = "unitCode"
        End With
#End Region

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
        RemoveHandler medList.SelectedIndexChanged, AddressOf medList_SelectedIndexChanged
        reloadList(medList, "medID", "medName", "SELECT * FROM med_item WHERE sID=", subID)
        AddHandler medList.SelectedIndexChanged, AddressOf medList_SelectedIndexChanged
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
    ' 載入藥品資訊
    Public Sub loadMedItem(ByVal medID As Integer)
        Dim reader As IDataReader = runQuery("SELECT * FROM med_item WHERE medID=" & medID)
        With reader
            While .Read
                medName.Text = .Item("medName")
                pinyin.Text = .Item("pinyin")
                zhuyin.Text = .Item("zhuyin")
                If IsDBNull(.Item("medDesc")) Then medDesc.Text = "" Else medDesc.Text = .Item("medDesc")
                If IsDBNull(.Item("unitPrice")) Then unitPrice.Text = "" Else unitPrice.Text = .Item("unitPrice")
                If IsDBNull(.Item("unitUnit")) Then unitUnit.SelectedValue = -1 Else unitUnit.SelectedValue = .Item("unitUnit")
                If IsDBNull(.Item("groupPrice")) Then groupPrice.Text = "" Else groupPrice.Text = .Item("groupPrice")
                If IsDBNull(.Item("groupUnit")) Then groupUnit.SelectedValue = -1 Else groupUnit.SelectedValue = .Item("groupUnit")
                If IsDBNull(.Item("groupAmount")) Then groupAmount.Text = "" Else groupAmount.Text = .Item("groupAmount")
                If IsDBNull(.Item("groupAmountUnit")) Then groupAmountUnit.SelectedValue = -1 Else groupAmountUnit.SelectedValue = .Item("groupAmountUnit")
                discount.Checked = CBool(.Item("isDiscountable"))
                groupExclude.Checked = CBool(.Item("groupExclude"))
            End While
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
    Private Sub medList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles medList.SelectedIndexChanged
        loadMedItem(medList.SelectedValue)
    End Sub
    Private Sub unusedMedList_CheckedChanged(sender As Object, e As EventArgs) Handles unusedMedList.CheckedChanged
        mainGroupList.Enabled = Not unusedMedList.Checked
        subGroupList.Enabled = Not unusedMedList.Checked
        If unusedMedList.Checked Then
            reloadUnusedMedItem()
        Else
            reloadMedItem(subGroupList.SelectedValue)
        End If
    End Sub
#End Region

#Region "按鈕"
    ' 清除欄位
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        medName.Text = ""
        pinyin.Text = ""
        zhuyin.Text = ""
        medDesc.Text = ""
        unitPrice.Text = ""
        unitUnit.SelectedIndex = -1
        groupPrice.Text = ""
        groupUnit.SelectedIndex = -1
        groupAmount.Text = ""
        groupAmountUnit.SelectedIndex = -1
    End Sub
    ' 新增藥品
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        If unusedMedList.Checked Then
            If MetroFramework.MetroMessageBox.Show(Me, "確定要新增藥品【" & medName.Text & "】至【未分類】?", "新增藥品", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sql As String = "INSERT INTO med_item(sID, medName, pinyin, zhuyin, medDesc, unitPrice, unitUnit, groupPrice, groupUnit, groupAmount, groupAmountUnit, groupExclude, isDiscountable) VALUES(-1, '" &
                    medName.Text & "', '" & pinyin.Text & "', '" & zhuyin.Text & "', '" & medDesc.Text & "', '" & unitPrice.Text & "', '" & unitUnit.SelectedValue & "', '" & groupPrice.Text & "', '" & groupUnit.SelectedValue & "', '" & groupAmount.Text & "', '" & groupAmountUnit.SelectedValue & "', " & groupExclude.Checked & "', " & discount.Checked & ")"
                runQuery(sql)
                MetroFramework.MetroMessageBox.Show(Me, "新增成功", "新增藥品", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reloadUnusedMedItem()
            End If
        Else
            Dim response As DialogResult = MetroFramework.MetroMessageBox.Show(Me, "確定要新增藥品【" & medName.Text & "】至【" & CType(mainGroupList.SelectedItem, DataRowView).Row.ItemArray(1) & " - " & CType(subGroupList.SelectedItem, DataRowView).Row.ItemArray(1) & "】?" & vbNewLine & "(若要新增置【未分類】請點 No)", "新增藥品", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If Not response = DialogResult.Cancel Then
                Dim sql As String = "INSERT INTO med_item(sID, medName, pinyin, zhuyin, medDesc, unitPrice, unitUnit, groupPrice, groupUnit, groupAmount, groupAmountUnit, groupExclude, isDiscountable) VALUES("
                If response = DialogResult.Yes Then sql += subGroupList.SelectedValue.ToString Else sql += "-1"
                sql += ", '" & medName.Text & "', '" & pinyin.Text & "', '" & zhuyin.Text & "', '" & medDesc.Text & "', '" & unitPrice.Text & "', '" & unitUnit.SelectedValue & "', '" _
                    & groupPrice.Text & "', '" & groupUnit.SelectedValue & "', '" & groupAmount.Text & "', '" & groupAmountUnit.SelectedValue & "', " & groupExclude.Checked & "', " & discount.Checked & ")"
                runQuery(sql)
                MetroFramework.MetroMessageBox.Show(Me, "新增成功", "新增藥品", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reloadMedItem(subGroupList.SelectedValue)
            End If
        End If

    End Sub
    ' 修改藥品
    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        runQuery("UPDATE med_item SET " &
                 "medName='" & medName.Text & "'," &
                 "pinyin='" & pinyin.Text.Trim.ToLower & "'," &
                 "zhuyin='" & zhuyin.Text.Trim.ToLower & "'," &
                 "medDesc='" & medDesc.Text & "'," &
                 "unitPrice='" & unitPrice.Text & "'," &
                 "unitUnit='" & unitUnit.SelectedValue & "'," &
                 "groupPrice='" & groupPrice.Text & "'," &
                 "groupUnit='" & groupUnit.SelectedValue & "'," &
                 "groupAmount='" & groupAmount.Text & "'," &
                 "groupAmountUnit='" & groupAmountUnit.SelectedValue & "'," &
                 "groupExclude='" & groupExclude.Checked & "'," &
                 "isDiscountable=" & discount.Checked & " WHERE medID=" & medList.SelectedValue)
        MetroFramework.MetroMessageBox.Show(Me, "更新成功", "修改藥品", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If unusedMedList.Checked Then reloadUnusedMedItem() Else reloadMedItem(subGroupList.SelectedValue)
    End Sub
    ' 刪除藥品
    Private Sub delButton_Click(sender As Object, e As EventArgs) Handles delButton.Click
        Dim question As String = ""
        If unusedMedList.Checked Then
            question = "確定要從【未分類】刪除藥品【" & medName.Text & "】?"
        Else
            question = "確定要從【" & CType(mainGroupList.SelectedItem, DataRowView).Row.ItemArray(1) & " - " & CType(subGroupList.SelectedItem, DataRowView).Row.ItemArray(1) & "】刪除藥品【" & medName.Text & "】?"
        End If
        If MetroFramework.MetroMessageBox.Show(Me, question, "刪除藥品", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            runQuery("DELETE FROM med_item WHERE medID=" & medList.SelectedValue)
            MetroFramework.MetroMessageBox.Show(Me, "刪除成功", "刪除藥品", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reloadMedItem(subGroupList.SelectedValue)
        End If
    End Sub
#End Region
End Class
