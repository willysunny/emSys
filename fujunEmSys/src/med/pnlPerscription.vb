Imports System.Drawing.Printing

Public Class pnlPerscription
    Inherits pnlSlider

    Private patientInfo As New pInfo
    Private bID As Integer = -1
    Dim unit As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 單位
    Dim groupUnit As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 群組單位
    Dim printIndex As Integer = 0
    Dim singlePrint As Boolean = False

#Region "初始"
    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)
        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.
        loadTree()
        refreshBooking(Now)

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
        With medDetailUnit
            .DataSource = unitTable
            .DisplayMember = "unitName"
            .ValueMember = "unitCode"
        End With

        groupUnit.Add(1, "包")
        groupUnit.Add(2, "顆")
        groupUnit.Add(3, "匙")
        groupUnit.Add(4, "盒")
        Dim groupUnitTable As DataTable = New DataTable()
        With groupUnitTable
            .Columns.Add("unitCode", GetType(Integer))
            .Columns.Add("unitName", GetType(String))
            For Each point As KeyValuePair(Of Integer, String) In groupUnit
                .Rows.Add(point.Key, point.Value)
            Next
        End With
        With medGroupUnit
            .DataSource = groupUnitTable
            .DisplayMember = "unitName"
            .ValueMember = "unitCode"
        End With
    End Sub
#End Region

#Region "載入資料"
    Private Sub refreshBooking(ByVal checkDate As Date)
        Dim sql As String = "SELECT pb.bID, pb.pID, INSERT(pi.pname, 2, 1, '○') as 'patientName'
                            FROM patient_booking AS pb 
                            INNER JOIN patient as pi ON pb.pID = pi.pID
                            WHERE pb.bookTime >= '" & checkDate & "' AND pb.bookTime < '" & checkDate.AddDays(1) & "' 
                            ORDER BY pb.bookTime"
        With waitingList
            .DataSource = returnData(mainForm, sql)
            .ValueMember = "bID"
            .DisplayMember = "patientName"
        End With
        tabBooking.Focus()
    End Sub
    Private Sub checkDate_ValueChanged(sender As Object, e As EventArgs) Handles checkDate.ValueChanged, refreshWaitingListButton.Click
        refreshBooking(checkDate.Value)
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
#Region "載入病人資料"
    Private Sub waitingList_Click(sender As Object, e As EventArgs) Handles waitingList.Click
        If Not waitingList.SelectedIndex = -1 Then
            loadPatientData(waitingList.SelectedValue)
            patientTab.SelectedTab = tabPatientInfo
            pName.Text = patientInfo.pName
            Select Case patientInfo.pSex
                Case 0
                    pSex.Text = "女"
                Case 1
                    pSex.Text = "男"
                Case 2
                    pSex.Text = "未設定"
            End Select
            pAge.Text = patientInfo.pAge
            medTabs.Enabled = True
        End If
    End Sub
    Private Sub loadPatientData(ByVal bID As Integer)
        Dim reader As IDataReader = runQuery("Select pID, concern, response FROM patient_booking WHERE bID=" & bID)
        If reader.Read Then
            Dim pID As Integer = reader.Item("pID")
            patientInfo = New pInfo
            patientInfo.initiate(pID)
            concernText.Text = reader.Item("concern")
            responseText.Text = reader.Item("response")
            reader = runQuery("SELECT bookTime As 'last_visit', count(booktime) as 'visit_count' FROM patient_booking WHERE arrived=1 AND pID=" & patientInfo.pID)
            While reader.Read
                If Not IsDBNull(reader.Item(0)) Then pPrevVisit.Text = reader.GetDateTime(0) Else pPrevVisit.Text = ""
                pVisitTimes.Text = reader.Item(1)
            End While
        End If
        RemoveHandler historyBox.SelectedIndexChanged, AddressOf historyBox_SelectedIndexChanged
        With historyBox
            .DataSource = returnData(mainForm, "SELECT bID, booktime FROM patient_booking WHERE pID=" & patientInfo.pID & " ORDER BY bookTime DESC")
            .ValueMember = "bID"
            .DisplayMember = "bookTime"
        End With
        AddHandler historyBox.SelectedIndexChanged, AddressOf historyBox_SelectedIndexChanged
        pastRecordBox.Text = patientInfo.pPastRecord
        otherExamBox.Text = patientInfo.pOtherExam
        geneSet(Me, New EventArgs)
        fluSet(Me, New EventArgs)
        reloadMedGroup()
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

    Private Sub medTree_doubleClick(sender As Object, e As EventArgs) Handles medTree.DoubleClick
        If medGroupGrid.Rows.Count = 0 Then
            addMedGroup_Click(Me, New EventArgs)
            medGroupGrid.Rows.Item(0).Selected = True
            addMedDetail_Click(Me, New EventArgs)
        ElseIf medGroupGrid.SelectedRows.Count = 1 Then
            addMedDetail_Click(Me, New EventArgs)
        End If
    End Sub

#Region "藥物群組"
    ' 新增群組
    Private Sub addMedGroup_Click(sender As Object, e As EventArgs) Handles addMedGroup.Click
        Try
            runQuery("INSERT INTO medGroup2medDetail (bID, medDays, medAmount, medUnit, morning, noon, night, beforeSleep, beforemeal, aftermeal, notwell, multiple, makePill, f0) VALUES ('" &
                     waitingList.SelectedValue & "', '" & medGroupDays.Text & "', '" & medGroupAmount.Text & "', '" & medGroupUnit.SelectedValue & "', " &
                     morning.Checked & ", " & noon.Checked & ", " & night.Checked & ", " & beforeSleep.Checked & ", " & beforeMeal.Checked & ", " & afterMeal.Checked & ", " & notWell.Checked & ", " & multiple.Checked & ", " &
                     makePill.Checked & ", " & F0.Checked & ");")
            reloadMedGroup()
            medGroupGrid.Rows.Item(medGroupGrid.Rows.Count - 1).Selected = True
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "新增失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    ' 刪除群組
    Private Sub delMedGroup_Click(sender As Object, e As EventArgs) Handles delMedGroup.Click
        If medGroupGrid.SelectedRows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "沒有任何資料可刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MetroFramework.MetroMessageBox.Show(Me, "請確定您要刪除群組【" & medGroupGrid.SelectedRows(0).Cells("藥物清單").Value & "】? 所有相關的藥品將會全部刪除!", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                runQuery("DELETE FROM medDetail WHERE mgID=" & medGroupGrid.SelectedRows(0).Cells("mgID").Value)
                runQuery("DELETE FROM medGroup2medDetail WHERE mgID=" & medGroupGrid.SelectedRows(0).Cells("mgID").Value)
                MetroFramework.MetroMessageBox.Show(Me, "刪除成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reloadMedGroup()
            End If
        End If
    End Sub
    ' 變更群組
    Private Sub medGroupChange_Click(sender As Object, e As EventArgs) Handles medGroupChange.Click
        Try
            runQuery("UPDATE medGroup2medDetail SET " &
                    "morning=" & morning.Checked & "," &
                    "noon=" & noon.Checked & "," &
                    "night=" & night.Checked & "," &
                    "beforeSleep=" & beforeSleep.Checked & "," &
                    "notWell=" & notWell.Checked & "," &
                    "multiple=" & multiple.Checked & "," &
                    "beforeMeal=" & beforeMeal.Checked & "," &
                    "afterMeal=" & afterMeal.Checked & "," &
                    "makePill=" & makePill.Checked & "," &
                    "f0=" & F0.Checked & "," &
                    "medDays=" & medGroupDays.Text & "," &
                    "medAmount=" & medGroupAmount.Text & "," &
                    "medUnit=" & medGroupUnit.SelectedValue &
                    " WHERE mgID=" & medGroupGrid.SelectedRows(0).Cells("mgID").Value)
            MetroFramework.MetroMessageBox.Show(Me, "更新成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reloadMedGroup()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "更新失敗", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' 選擇群組
    Private Sub medGroupGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles medGroupGrid.CellClick
        If Not medGroupGrid.SelectedRows.Count = 0 Then
            With medGroupGrid.SelectedRows(0)
                morning.Checked = .Cells("morning").Value
                noon.Checked = .Cells("noon").Value
                night.Checked = .Cells("night").Value
                beforeSleep.Checked = .Cells("beforesleep").Value
                notWell.Checked = .Cells("notWell").Value
                beforeMeal.Checked = .Cells("beforemeal").Value
                afterMeal.Checked = .Cells("aftermeal").Value
                makePill.Checked = .Cells("makepill").Value
                F0.Checked = .Cells("f0").Value
                medGroupDays.Text = .Cells("天數").Value
                medGroupAmount.Text = .Cells("份量").Value
                medGroupUnit.SelectedValue = .Cells("medUnit").Value
                reloadMedDetail(.Cells("mgID").Value)
            End With
            medGroupAmount.Focus()
            medGroupAmount.SelectAll()
        End If
    End Sub
    ' 載入藥物群組
    Private Sub reloadMedGroup()
        medGroupGrid.DataSource = returnData(mainForm, "Select mg.bID, mg.mgID,
                                                               mg.morning, mg.noon, mg.night, mg.beforeSleep, mg.notWell, 
                                                               mg.beforeMeal, mg.afterMeal, mg.makePill, mg.f0, 
                                                               group_concat(mi.medName) as '藥物清單', mg.medDays as '天數', 
                                                               mg.medAmount as '份量', mg.medUnit, null as '單位'
                                                        FROM medGroup2medDetail as mg
                                                        LEFT JOIN medDetail AS md ON mg.mgID = md.mgID
                                                        LEFT JOIN med_item as mi on md.medID = mi.medID
                                                        WHERE bID=" & waitingList.SelectedValue &
                                                        " GROUP BY mg.mgID")
        For Each col As DataGridViewColumn In medGroupGrid.Columns
            col.Visible = False
        Next
        For Each row As DataGridViewRow In medGroupGrid.Rows
            If IsDBNull(row.Cells("藥物清單").Value) Then row.Cells("藥物清單").Value = "新群組"
            Try
                row.Cells("單位").Value = groupUnit(row.Cells("medUnit").Value)
            Catch ex As Exception
                row.Cells("單位").Value = groupUnit(1)
            End Try
        Next
        With medGroupGrid
            .Columns("bID").Visible = False
            .Columns("藥物清單").Visible = True
            .Columns("天數").Visible = True
            .Columns("份量").Visible = True
            .Columns("單位").Visible = True
            If Not .SelectedRows.Count = 0 Then
                reloadMedDetail(.SelectedRows(0).Cells("mgID").Value)
            End If
        End With
    End Sub
    Private Sub medGroupLabel_Click(sender As Object, e As EventArgs) Handles medGroupLabel.Click
        reloadMedGroup()
    End Sub
#End Region

#Region "藥物清單"
    ' 新增藥物
    Private Sub addMedDetail_Click(sender As Object, e As EventArgs) Handles addMedDetail.Click
        If medTree.SelectedNode.GetNodeCount(True) = 0 And medTree.SelectedNode.FullPath.Split("\").Length = 3 Then
            ' 檢查特殊狀況
            If medDetailGrid.Rows.Count >= 1 Then
                For Each row As DataGridViewRow In medDetailGrid.Rows
                    If row.Cells("bioMed").Value And Not row.Cells("groupExclude").Value Then
                        MetroFramework.MetroMessageBox.Show(Me, "錯誤: 無法將藥品 (" & row.Cells("藥物名稱").Value & ") 轉變成藥粉, 請檢查!", "藥包錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
                Dim reader As IDataReader = runQuery("SELECT bioMed, groupExclude FROM med_item WHERE medID=" & medTree.SelectedNode.Name)
                reader.Read()
                If reader.Item("bioMed") And Not reader.Item("groupExclude") Then
                    MetroFramework.MetroMessageBox.Show(Me, "錯誤: 無法將藥品 (" & medTree.SelectedNode.Text & ") 轉變成藥粉, 請檢查!", "藥包錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            Try
                runQuery("INSERT INTO medDetail (mgID, medID, medAmount, medUnit) VALUES ('" &
                      medGroupGrid.SelectedRows(0).Cells("mgID").Value & "', '" &
                      medTree.SelectedNode.Name & "', '" & medDetailAmount.Text & "', '" & medDetailUnit.SelectedValue & "');")
                Dim index As Integer = medGroupGrid.SelectedRows(0).Index
                reloadMedGroup()
                medGroupGrid.Rows.Item(index).Selected = True
                reloadMedDetail(medGroupGrid.SelectedRows(0).Cells("mgID").Value)
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "新增失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            searchBox.Text = ""
        Else
            MetroFramework.MetroMessageBox.Show(Me, "請先點選藥物再搜尋", "新增失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    ' 刪除藥物
    Private Sub delMedDetail_Click(sender As Object, e As EventArgs) Handles delMedDetail.Click
        If medDetailGrid.SelectedRows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "沒有任何資料可刪除", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            runQuery("DELETE FROM medDetail WHERE mdID=" & medDetailGrid.SelectedRows(0).Cells("mdID").Value)
            reloadMedGroup()
            reloadMedDetail(medGroupGrid.SelectedRows(0).Cells("mgID").Value)
        End If
    End Sub
    ' 變更藥物
    Private Sub medDetailChange_Click(sender As Object, e As EventArgs) Handles medDetailChange.Click
        Dim index As Integer = medDetailGrid.SelectedRows(0).Index
        Try
            runQuery("UPDATE medDetail SET " &
                    "medAmount=" & medDetailAmount.Text & "," &
                    "medUnit=" & medDetailUnit.SelectedValue &
                    " WHERE mdID=" & medDetailGrid.SelectedRows(0).Cells("mdID").Value)
            MetroFramework.MetroMessageBox.Show(Me, "更新成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reloadMedDetail(medGroupGrid.SelectedRows(0).Cells("mgID").Value)
            If index + 1 < medDetailGrid.Rows.Count Then
                medDetailGrid.Rows.Item(index + 1).Selected = True
            Else
                medDetailGrid.Rows.Item(index).Selected = True
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "更新失敗", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' 選擇藥物
    Private Sub medDetailGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles medDetailGrid.CellClick
        If Not medDetailGrid.SelectedRows.Count = 0 Then
            With medDetailGrid.SelectedRows(0)
                medDetailAmount.Text = .Cells("份量").Value
                medDetailUnit.SelectedValue = .Cells("medUnit").Value
            End With
            medDetailAmount.Focus()
            medDetailAmount.SelectAll()
        End If
    End Sub
    ' 載入藥物群組
    Private Sub reloadMedDetail(ByVal mgID As Integer)
        medDetailGrid.DataSource = returnData(mainForm, "Select md.mdID, mi.medName as '藥物名稱', md.medAmount as '份量', md.medUnit, null as '單位', mi.bioMed, mi.groupExclude
                                                        FROM medDetail AS md 
                                                        LEFT JOIN med_item as mi on md.medID = mi.medID
                                                        WHERE mgID=" & mgID)
        For Each row As DataGridViewRow In medDetailGrid.Rows
            Try
                row.Cells("單位").Value = unit(row.Cells("medUnit").Value)
            Catch ex As Exception
                row.Cells("單位").Value = unit(1)
            End Try
        Next
        With medDetailGrid
            .Columns("mdID").Visible = False
            .Columns("medUnit").Visible = False
            .Columns("bioMed").Visible = False
            .Columns("groupExclude").Visible = False
        End With
    End Sub
    Private Sub medDetailLabel_Click(sender As Object, e As EventArgs) Handles medDetailLabel.Click
        reloadMedDetail(medGroupGrid.SelectedRows(0).Cells("mgID").Value)
    End Sub
#End Region
    ' 總覽
    Private Sub medTab_Click(sender As Object, e As EventArgs) Handles medTabs.Click
        If medTabs.SelectedTab Is tabFull Then
            If Not historyBox.SelectedIndex = -1 Then
                fullListView.DataSource = returnData(mainForm, "Select group_concat(mi.medName) as '藥品清單', group_concat(mi.medName,'(',mg.meddays*md.medAmount,'|',md.medUnit,')') as 'medList',
                                                               mg.morning as '早', mg.noon as '午', mg.night as '晚', mg.beforeSleep as '睡前', mg.notWell as '有症狀時', mg.multiple as '多次', 
                                                               mg.beforeMeal as '飯前', mg.afterMeal as '飯後', 
                                                               mg.medDays as '天數', 
                                                               mg.medAmount as '份量', mg.medUnit, null as '單位',
                                                               mg.makePill as '打錠'
                                                        FROM medGroup2medDetail as mg
                                                        INNER JOIN medDetail AS md ON mg.mgID = md.mgID
                                                        INNER JOIN med_item as mi on md.medID = mi.medID
                                                        WHERE bID=" & historyBox.SelectedValue & "
                                                        GROUP BY mg.mgid")
                For Each row As DataGridViewRow In fullListView.Rows
                    Try
                        row.Cells("單位").Value = groupUnit(row.Cells("medUnit").Value)
                    Catch ex As Exception
                        row.Cells("單位").Value = groupUnit(1)
                    End Try
                Next
                If Not mainForm.debugMode.Checked Then
                    fullListView.Columns("medUnit").Visible = False
                    fullListView.Columns("medList").Visible = False
                End If
            End If
        End If
    End Sub
    Private Sub historyBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles historyBox.SelectedIndexChanged
        If Not historyBox.SelectedIndex = -1 Then
            fullListView.DataSource = returnData(mainForm, "Select group_concat(mi.medName) as '藥品清單', group_concat(mi.medName,'(',mg.meddays*md.medAmount,'|',md.medUnit,')') as 'medList',
                                                               mg.morning as '早', mg.noon as '午', mg.night as '晚', mg.beforeSleep as '睡前', mg.notWell as '不適時', 
                                                               mg.beforeMeal as '飯前', mg.afterMeal as '飯後', 
                                                               mg.medDays as '天數', 
                                                               mg.medAmount as '份量', mg.medUnit, null as '單位',
                                                               mg.makePill as '打錠'
                                                        FROM medGroup2medDetail as mg
                                                        INNER JOIN medDetail AS md ON mg.mgID = md.mgID
                                                        INNER JOIN med_item as mi on md.medID = mi.medID
                                                        WHERE bID=" & historyBox.SelectedValue & "
                                                        GROUP BY mg.mgid")
            For Each row As DataGridViewRow In fullListView.Rows
                Try
                    row.Cells("單位").Value = groupUnit(row.Cells("medUnit").Value)
                Catch ex As Exception
                    row.Cells("單位").Value = groupUnit(1)
                End Try
            Next
            If Not mainForm.debugMode.Checked Then
                fullListView.Columns("medUnit").Visible = False
                fullListView.Columns("medList").Visible = False
            End If
        End If
    End Sub
    ' 列印按鈕
    Private Sub printMedButton_Click(sender As Object, e As EventArgs) Handles printMedButton.Click
        Dim keepPrinting As Boolean = True
        printIndex = 0
        Dim dt As DataTable = returnData(mainForm, "SELECT mg.mgID, group_concat(mi.medName) as '藥物清單', mg.medDays, mg.medAmount as 'gAmount',
                                                    count(md.medID) as 'totalMeds', sum(md.medAmount) AS 'totalGram', mg.medUnit as 'gUnit', md.medUnit as 'dUnit', (mg.morning + mg.noon + mg.night + mg.beforeSleep) as 'totalTimes'
                                                    FROM medGroup2medDetail as mg LEFT JOIN medDetail as md ON mg.mgID = md.mgID LEFT JOIN med_item as mi on md.medID = mi.medID 
                                                    WHERE bID=" & historyBox.SelectedValue & " GROUP BY mg.mgID")
        For Each row As DataRow In dt.Rows
            If row.Item("totalMeds") > 1 Then
                If groupUnit(row.Item("gUnit")).Contains("包") Then
                    If Not row.Item("totalGram") / 6 = row.Item("totalTimes") Then
                        If MetroFramework.MetroMessageBox.Show(Me, "警告: 藥包 (" & row.Item("藥物清單") & ") 內總重量 (" & row.Item("totalGram") & "克) 不正確!" & vbNewLine & "請問是否繼續?", "藥包錯誤", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbNo Then
                            keepPrinting = False
                        End If
                        If Not keepPrinting Then Exit Sub
                    End If
                ElseIf groupUnit(row.Item("gUnit")).Contains("顆") And unit(row.Item("dUnit")).Contains("克") Then
                    If Not row.Item("totalTimes") * row.Item("gAmount") * 0.5 = row.Item("totalGram") Then
                        If MetroFramework.MetroMessageBox.Show(Me, "警告: 藥丸 (" & row.Item("藥物清單") & ") 內總重量 (" & row.Item("totalGram") & "克) 不正確!" & vbNewLine & "請問是否繼續?", "藥包錯誤", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbNo Then
                            keepPrinting = False
                        End If
                        If Not keepPrinting Then Exit Sub
                    End If

                End If
            End If
        Next

        If keepPrinting Then
            If mainForm.debugMode.Checked Then
                printPreview.ShowDialog()
            Else
                Try
                    With printDoc
                        .PrinterSettings.PrinterName = "Ring 412PE+"
                        .DefaultPageSettings.Landscape = False
                        .Print()
                    End With
                Catch ex As Exception
                    MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息: 找不到標籤機, 請檢查連線後在重試!", "無法連線至標籤機", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    ' 單一列印
    Private Sub printSingle_Click(sender As Object, e As EventArgs) Handles printSingle.Click
        printIndex = fullListView.SelectedRows.Item(0).Index
        If mainForm.debugMode.Checked Then
            printPreview.ShowDialog()
        Else
            Try
                singlePrint = True
                With printDoc
                    .PrinterSettings.PrinterName = "Ring 412PE+"
                    .DefaultPageSettings.Landscape = False
                    .Print()
                End With
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息: 找不到標籤機, 請檢查連線後在重試!", "無法連線至標籤機", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        printIndex = 0
        singlePrint = False
    End Sub
    ' 列印標籤
    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        ' 文字設定
        Dim titleFont As Font = New Font("微軟正黑體", 18, FontStyle.Regular)
        Dim headerFont As Font = New Font("微軟正黑體", 12, FontStyle.Regular)
        Dim textFont As Font = New Font("微軟正黑體", 10, FontStyle.Regular)
        Dim subFont As Font = New Font("微軟正黑體", 8, FontStyle.Regular)
        Dim fontsize As Integer = 18
        Dim stringFormat As New StringFormat()
        stringFormat.FormatFlags = StringFormatFlags.NoClip

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        stringFormat.Alignment = StringAlignment.Center
        e.Graphics.DrawString("福濬中醫診所用藥說明", titleFont, Brushes.Black, New Point(205, 380), stringFormat)

        stringFormat.Alignment = StringAlignment.Near
        e.Graphics.DrawString("姓名: " & pName.Text, headerFont, Brushes.Black, New Point(20, 415), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(60, 435), New Point(180, 435))
        e.Graphics.DrawString("病歷號:  " & patientInfo.pID, headerFont, Brushes.Black, New Point(215, 415), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(280, 435), New Point(380, 435))

        e.Graphics.DrawString("天數:  " & fullListView.Rows(printIndex).Cells("天數").Value & " 天", headerFont, Brushes.Black, New Point(230, 440), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(280, 460), New Point(380, 460))

        If fullListView.Rows(printIndex).Cells("打錠").Value Then
            e.Graphics.DrawString("藥物內容 (打錠):", headerFont, Brushes.Black, New Point(20, 440), stringFormat)
            e.Graphics.DrawLine(Pens.Black, New Point(20, 460), New Point(120, 460))

        Else
            e.Graphics.DrawString("藥物內容:", headerFont, Brushes.Black, New Point(20, 440), stringFormat)
            e.Graphics.DrawLine(Pens.Black, New Point(20, 460), New Point(95, 460))
        End If

        Dim medList As String() = fullListView.Rows(printIndex).Cells("medList").Value.ToString.Split(",")
        For i = 0 To medList.Count - 1
            Dim unitList As String() = medList(i).Split("|")
            unitList(1) = unit(CInt(Mid(unitList(1), 1, Len(unitList(1)) - 1))) & ")"
            medList(i) = String.Join("", unitList)
        Next

        Dim aBytes() As Byte = System.Text.Encoding.UTF8.GetBytes(String.Join(", ", medList))
        'Dim aBytes() As Byte = System.Text.Encoding.UTF8.GetBytes("這是一個非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常非常長的字串")
        Dim strmMem As New System.IO.MemoryStream(aBytes)
        Dim streamToPrint As New IO.StreamReader(strmMem)
        Dim line As String = streamToPrint.ReadLine()
        Dim sf As StringFormat = StringFormat.GenericTypographic
        sf.Alignment = StringAlignment.Near
        sf.LineAlignment = StringAlignment.Near
        sf.FormatFlags = StringFormatFlags.LineLimit
        sf.Trimming = StringTrimming.Word
        Dim actual = e.Graphics.MeasureString(line, textFont, New SizeF(350, 60), sf)
        e.Graphics.DrawString(line, textFont, Brushes.Black, New RectangleF(40, 468, 350, 60), sf)

        Dim usage As String = ""
        Dim trigger As Boolean = False
        If fullListView.Rows(printIndex).Cells("早").Value Then
            usage = "早"
            trigger = True
        End If
        If fullListView.Rows(printIndex).Cells("午").Value And trigger Then
            usage += "/午"
        ElseIf fullListView.Rows(printIndex).Cells("午").Value Then
            usage = "午"
            trigger = True
        End If
        If fullListView.Rows(printIndex).Cells("晚").Value And trigger Then
            usage += "/晚"
        ElseIf fullListView.Rows(printIndex).Cells("晚").Value Then
            usage = "晚"
            trigger = True
        End If
        trigger = False
        If fullListView.Rows(printIndex).Cells("飯前").Value Then
            usage += " 飯前"
            trigger = True
        End If
        If fullListView.Rows(printIndex).Cells("飯後").Value And trigger Then
            usage += "或 飯後"
        ElseIf fullListView.Rows(printIndex).Cells("飯後").Value Then
            usage += " 飯後"
        End If
        If fullListView.Rows(printIndex).Cells("睡前").Value Then
            usage += " 以及 睡前"
        End If
        If usage = "" And fullListView.Rows(printIndex).Cells("有症狀時").Value Then
            usage += " 有症狀時"
        ElseIf fullListView.Rows(printIndex).Cells("有症狀時").Value Then
            usage += " 和 有症狀時"
        End If
        usage += " 服用 " & fullListView.Rows(printIndex).Cells("份量").Value & " " & fullListView.Rows(printIndex).Cells("單位").Value
        e.Graphics.DrawString("服用方法: " & usage, headerFont, Brushes.Black, New Point(20, 525), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(20, 545), New Point(95, 545))

        e.Graphics.DrawString("福濬中醫診所 (03)327-7900" & vbNewLine & "桃園市龜山區文化二路30-11號", subFont, Brushes.Black, New Point(20, 550), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(20, 580), New Point(180, 580))


        Dim twnCal As System.Globalization.TaiwanCalendar = New System.Globalization.TaiwanCalendar
        stringFormat.Alignment = StringAlignment.Far
        e.Graphics.DrawString("調劑日期:" & vbNewLine & twnCal.GetYear(DateAndTime.Now) & Now.ToString("年MM月dd日 HH:mm"), subFont, Brushes.Black, New Point(385, 550), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(380, 580), New Point(270, 580))

        If singlePrint Then
            singlePrint = False
            e.HasMorePages = False
        ElseIf printIndex < fullListView.Rows.Count - 1 Then
            printIndex += 1
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub
    Private Sub medDetailAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles medDetailAmount.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            medDetailChange_Click(Me, New EventArgs)
            medDetailAmount.Focus()
        End If
    End Sub
#Region "計算機"
    Private Sub dayCalc_Click(sender As Object, e As EventArgs) Handles dayCalc.Click
        Try
            If CInt(singleBox.Text) = 0 Or CInt(totalBox.Text) = 0 Then
                dayBox.Text = CInt(totalBox.Text) / CInt(singleBox.Text)
            End If
        Catch
            dayBox.Text = "-ERR-"
        End Try
    End Sub
    Private Sub singleCalc_Click(sender As Object, e As EventArgs) Handles singleCalc.Click
        Try
            If Not CInt(dayBox.Text) = 0 Or CInt(totalBox.Text) = 0 Then
                singleBox.Text = CInt(totalBox.Text) / CInt(dayBox.Text)
            End If
        Catch
            singleBox.Text = "-ERR-"
        End Try
    End Sub
    Private Sub totalCalc_Click(sender As Object, e As EventArgs) Handles totalCalc.Click
        Try
            totalBox.Text = CInt(singleBox.Text) * CInt(dayBox.Text)
        Catch
            totalBox.Text = "-ERR-"
        End Try
    End Sub
    Private Sub clearCalc_Click(sender As Object, e As EventArgs) Handles clearCalc.Click
        dayBox.Text = "14"
        singleBox.Text = "24"
        totalBox.Text = "336"
    End Sub

    Private Sub pastRecordBox_Validated(sender As Object, e As EventArgs) Handles pastRecordBox.Validated
        patientInfo.pPastRecord = pastRecordBox.Text
    End Sub

    Private Sub otherExamBox_Validated(sender As Object, e As EventArgs) Handles otherExamBox.Validated
        patientInfo.pOtherExam = otherExamBox.Text
    End Sub

    Private Sub concernText_Validated(sender As Object, e As EventArgs) Handles concernText.Validated
        runQuery("UPDATE patient_booking SET concern='" & concernText.Text & "' WHERE bID=" & waitingList.SelectedValue)
    End Sub
    Private Sub responseText_Validated(sender As Object, e As EventArgs) Handles responseText.Validated
        runQuery("UPDATE patient_booking SET response='" & responseText.Text & "' WHERE bID=" & waitingList.SelectedValue)
    End Sub

    ' 基因缺陷
    Private Sub geneButton_Click(sender As Object, e As EventArgs) Handles geneButton.Click, altGeneButton.Click
        Dim frm As New frmGene(patientInfo.pID)
        AddHandler frm.geneSet, AddressOf geneSet
        frm.ShowDialog()
    End Sub
    Private Sub geneSet(sender As Object, e As EventArgs)
        Dim reader As IDataReader = runQuery("Select group_concat(g.geneName) as 'geneNames'
                                              FROM patient_gene as pg
                                              LEFT JOIN gene AS g ON pg.geneID = g.geneID
                                              WHERE pID=" & patientInfo.pID &
                                              " GROUP BY pg.pID")
        If reader.Read Then
            geneButton.Text = "基缺: " & reader.Item("geneNames")
            altGeneButton.Text = "基缺: " & reader.Item("geneNames")
        Else
            geneButton.Text = "基因設定"
            altGeneButton.Text = "基因設定"
        End If
    End Sub
    Private Sub fluButton_Click(sender As Object, e As EventArgs) Handles fluButton.Click
        Dim frm As New frmFlu(waitingList.SelectedValue)
        AddHandler frm.fluSet, AddressOf fluSet
        frm.ShowDialog()
    End Sub
    Private Sub careButton_Click(sender As Object, e As EventArgs) Handles careButton.Click
        Dim frm As New frmCare(waitingList.SelectedValue)
        AddHandler frm.careSet, AddressOf careSet
        frm.ShowDialog()
    End Sub
    Private Sub fluSet(sender As Object, e As EventArgs)
        Dim reader As IDataReader = runQuery("Select group_concat(f.fluName) as 'fluNames'
                                              FROM booking_flu as bf
                                              LEFT JOIN commonFlu AS f ON f.fluID = bf.fluID
                                              WHERE bID=" & waitingList.SelectedValue)
        If reader.Read Then
            fluButton.Text = "時疫: " & reader.Item("fluNames")
        Else
            fluButton.Text = "時疫設定"
        End If
    End Sub

    Private Sub careSet(sender As Object, e As EventArgs)
        Dim reader As IDataReader = runQuery("Select group_concat(c.careName) as 'careNames'
                                              FROM booking_care as bc
                                              LEFT JOIN care AS c ON c.careID = bc.careID
                                              WHERE bID=" & waitingList.SelectedValue)
        If reader.Read Then
            careButton.Text = "保養: " & reader.Item("careNames")
        Else
            careButton.Text = "保養設定"
        End If
    End Sub

#End Region
End Class
