Public Class pnlMedInfo
    Inherits pnlSlider

    Public Event finish_edit As EventHandler
    Public Event searchAborted As EventHandler
    Public isSearching As Boolean = False
    Public abortSearch As Boolean = False
    Dim unit As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 測量點
    Dim gUnit As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 測量點

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.
        reloadMainGroup()

#Region "批發/單價單位"
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
        AddHandler subGroupList.SelectedIndexChanged, AddressOf subGroupList_SelectedIndexChanged
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
                bioMed.Checked = CBool(.Item("bioMed"))
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
                Dim sql As String = "INSERT INTO med_item(sID, medName, pinyin, zhuyin, medDesc, unitPrice, unitUnit, groupPrice, groupUnit, groupAmount, groupAmountUnit, groupExclude, bioMed) VALUES(-1, '" &
                    medName.Text & "', '" & pinyin.Text & "', '" & zhuyin.Text & "', '" & medDesc.Text & "', '" & unitPrice.Text & "', '" & unitUnit.SelectedValue & "', '" & groupPrice.Text & "', '" & groupUnit.SelectedValue & "', '" & groupAmount.Text & "', '" & groupAmountUnit.SelectedValue & "', " & groupExclude.Checked & ", " & bioMed.Checked & ")"
                runQuery(sql)
                MetroFramework.MetroMessageBox.Show(Me, "新增成功", "新增藥品", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reloadUnusedMedItem()
            End If
        Else
            Dim response As DialogResult = MetroFramework.MetroMessageBox.Show(Me, "確定要新增藥品【" & medName.Text & "】至【" & directcast(mainGroupList.SelectedItem, DataRowView).Row.ItemArray(1) & " - " & directcast(subGroupList.SelectedItem, DataRowView).Row.ItemArray(1) & "】?" & vbNewLine & "(若要新增置【未分類】請點 No)", "新增藥品", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If Not response = DialogResult.Cancel Then
                Dim sql As String = "INSERT INTO med_item(sID, medName, pinyin, zhuyin, medDesc, unitPrice, unitUnit, groupPrice, groupUnit, groupAmount, groupAmountUnit, groupExclude, bioMed) VALUES("
                If response = DialogResult.Yes Then sql += subGroupList.SelectedValue.ToString Else sql += "-1"
                sql += ", '" & medName.Text & "', '" & pinyin.Text & "', '" & zhuyin.Text & "', '" & medDesc.Text & "', '" & unitPrice.Text & "', '" & unitUnit.SelectedValue & "', '" _
                    & groupPrice.Text & "', '" & groupUnit.SelectedValue & "', '" & groupAmount.Text & "', '" & groupAmountUnit.SelectedValue & "', " & groupExclude.Checked & ", " & bioMed.Checked & ")"
                runQuery(sql)
                MetroFramework.MetroMessageBox.Show(Me, "新增成功", "新增藥品", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reloadMedItem(subGroupList.SelectedValue)
            End If
        End If

    End Sub
    ' 修改藥品
    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim index As Integer = medList.SelectedIndex
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
                 "groupExclude=" & groupExclude.Checked & "," &
                 "bioMed=" & bioMed.Checked & " WHERE medID=" & medList.SelectedValue)
        MetroFramework.MetroMessageBox.Show(Me, "更新成功", "修改藥品", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If unusedMedList.Checked Then reloadUnusedMedItem() Else reloadMedItem(subGroupList.SelectedValue)
        medList.SelectedIndex = index
    End Sub
    ' 刪除藥品
    Private Sub delButton_Click(sender As Object, e As EventArgs) Handles delButton.Click
        Dim question As String = ""
        If unusedMedList.Checked Then
            question = "確定要從【未分類】刪除藥品【" & medName.Text & "】?"
        Else
            question = "確定要從【" & directcast(mainGroupList.SelectedItem, DataRowView).Row.ItemArray(1) & " - " & directcast(subGroupList.SelectedItem, DataRowView).Row.ItemArray(1) & "】刪除藥品【" & medName.Text & "】?"
        End If
        If MetroFramework.MetroMessageBox.Show(Me, question, "刪除藥品", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            runQuery("DELETE FROM med_item WHERE medID=" & medList.SelectedValue)
            MetroFramework.MetroMessageBox.Show(Me, "刪除成功", "刪除藥品", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reloadMedItem(subGroupList.SelectedValue)
        End If
    End Sub

    Private Sub reloadFullList_Click(sender As Object, e As EventArgs) Handles reloadFullList.Click
        loadFullList()
    End Sub

    Private Sub medTab_Click(sender As Object, e As EventArgs) Handles medTab.Click
        If medTab.SelectedTab Is tabFull Then
            ' Only need to do once
            RemoveHandler medTab.Click, AddressOf medTab_Click
            loadFullList()
        End If
    End Sub

    Public Sub stopSearch(sender As Object, e As EventArgs)
        If Not isSearching Then
            RaiseEvent searchAborted(Me, New EventArgs)
        Else
            abortSearch = True
        End If
    End Sub

    Private Sub loadFullList()
        isSearching = True
        reloadFullList.Enabled = False
        fullListView.Visible = False
        loadingPanel.Visible = True
        fullListView.DataSource = returnData(mainForm, "Select mi.bioMed as '生醫', mm.mName AS '主分類', ms.sName AS '子分類', mi.medName AS '藥物名稱', mi.pinyin AS '拼音簡寫', mi.zhuyin AS '注音簡寫', 
                                                            mi.unitPrice AS '單價', mi.unitUnit, null AS '單價單位', mi.groupPrice AS '批發價', mi.groupUnit, null AS '批發單位', groupAmount AS '批發量', groupAmountUnit, null AS '批量單位'
                                                            FROM med_item AS mi INNER JOIN med_sub AS ms ON mi.sID = ms.sID
                                                            INNER JOIN med_main as mm ON ms.mID = mm.mID")
        loadProgress.Maximum = fullListView.Rows.Count
        loadProgress.Value = 0
        For Each row As DataGridViewRow In fullListView.Rows
            If abortSearch Then
                dataLoadLabel.Text = "已取消"
                isSearching = False
                Exit Sub
            End If
            dataLoadLabel.Text = "(" & loadProgress.Value & "/" & loadProgress.Maximum & ") 載入" & row.Cells("藥物名稱").Value
            Try
                row.Cells("單價單位").Value = unit(row.Cells("unitUnit").Value)
            Catch ex As Exception
                row.Cells("單價單位").Value = ""
            End Try
            Try
                row.Cells("批量單位").Value = unit(row.Cells("groupAmountUnit").Value)
            Catch ex As Exception
                row.Cells("批量單位").Value = ""
            End Try
            Try
                row.Cells("批發單位").Value = gUnit(row.Cells("groupUnit").Value)
            Catch ex As Exception
                row.Cells("批發單位").Value = ""
            End Try
            loadProgress.PerformStep()
            Application.DoEvents()
        Next
        If abortSearch Then
            dataLoadLabel.Text = "已取消"
            isSearching = false
            Exit Sub
        End If
        fullListView.Columns("unitUnit").Visible = False
        fullListView.Columns("groupAmountUnit").Visible = False
        fullListView.Columns("groupUnit").Visible = False
        fullListView.Visible = True
        loadingPanel.Visible = False
        reloadFullList.Enabled = True
        isSearching = False
    End Sub
#End Region
End Class
