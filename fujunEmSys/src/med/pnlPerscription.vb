Imports System.Drawing.Printing

Public Class pnlPerscription
    Inherits pnlSlider

    Private patientInfo As New pInfo
    Private bID As Integer = -1
    Dim unit As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 單位
    Dim printIndex As Integer = 0

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
        unit.Add(3, "包")
        unit.Add(4, "瓶")
        Dim groupUnitTable As DataTable = New DataTable()
        With groupUnitTable
            .Columns.Add("unitCode", GetType(Integer))
            .Columns.Add("unitName", GetType(String))
            For Each point As KeyValuePair(Of Integer, String) In unit
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
            If patientInfo.pSex = 0 Then pSex.Text = "女" Else pSex.Text = "男"
            pAge.Text = patientInfo.pAge
            medTab.Enabled = True
        End If
    End Sub
    Private Sub loadPatientData(ByVal bID As Integer)
        Dim reader As IDataReader = runQuery("Select pID FROM patient_booking WHERE bID=" & bID)
        If reader.Read Then
            Dim pID As Integer = reader.Item("pID")
            patientInfo = New pInfo
            patientInfo.initiate(pID)
            reader = runQuery("SELECT bookTime As 'last_visit', count(booktime) as 'visit_count' FROM patient_booking WHERE arrived=1 AND pID=" & patientInfo.pID)
            While reader.Read
                If Not IsDBNull(reader.Item(0)) Then pPrevVisit.Text = reader.GetDateTime(0) Else pPrevVisit.Text = ""
                pVisitTimes.Text = reader.Item(1)
            End While
        End If
        With historyBox
            .DataSource = returnData(mainForm, "SELECT bID, booktime FROM patient_booking WHERE arrived=1 AND pID=" & patientInfo.pID)
            .ValueMember = "bID"
            .DisplayMember = "bookTime"
        End With
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

#Region "藥物群組"
    ' 新增群組
    Private Sub addMedGroup_Click(sender As Object, e As EventArgs) Handles addMedGroup.Click
        Try
            runQuery("INSERT INTO medGroup2medDetail (bID, medDays, medAmount, medUnit, morning, noon, night, beforeSleep, beforemeal, aftermeal, notwell, makePill, f0) VALUES ('" &
                     waitingList.SelectedValue & "', '" & medGroupDays.Text & "', '" & medGroupAmount.Text & "', '" & medGroupUnit.SelectedValue & "', " &
                     morning.Checked & ", " & noon.Checked & ", " & night.Checked & ", " & beforeSleep.Checked & ", " & beforeMeal.Checked & ", " & afterMeal.Checked & ", " & notWell.Checked & ", " &
                     makePill.Checked & ", " & F0.Checked & ");")
            reloadMedGroup()
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
                    "beforeSleep=" & beforeMeal.Checked & "," &
                    "notWell=" & notWell.Checked & "," &
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
                row.Cells("單位").Value = unit(row.Cells("medUnit").Value)
            Catch ex As Exception
                row.Cells("單位").Value = unit(1)
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
            reloadMedDetail(medGroupGrid.SelectedRows(0).Cells("mgID").Value)
        End If
    End Sub
    ' 變更藥物
    Private Sub medDetailChange_Click(sender As Object, e As EventArgs) Handles medDetailChange.Click
        Try
            runQuery("UPDATE medDetail SET " &
                    "medAmount=" & medDetailAmount.Text & "," &
                    "medUnit=" & medDetailUnit.SelectedValue &
                    " WHERE mdID=" & medDetailGrid.SelectedRows(0).Cells("mdID").Value)
            MetroFramework.MetroMessageBox.Show(Me, "更新成功", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reloadMedDetail(medGroupGrid.SelectedRows(0).Cells("mgID").Value)
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
        End If
    End Sub
    ' 載入藥物群組
    Private Sub reloadMedDetail(ByVal mgID As Integer)
        medDetailGrid.DataSource = returnData(mainForm, "Select md.mdID, mi.medName as '藥物名稱', md.medAmount as '份量', md.medUnit, null as '單位'
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
        End With
    End Sub
    Private Sub medDetailLabel_Click(sender As Object, e As EventArgs) Handles medDetailLabel.Click
        reloadMedDetail(medGroupGrid.SelectedRows(0).Cells("mgID").Value)
    End Sub

#End Region

    Private Sub medTab_Click(sender As Object, e As EventArgs) Handles medTab.Click
        If medTab.SelectedTab Is tabFull Then
            If Not historyBox.SelectedIndex = -1 Then
                fullListView.DataSource = returnData(mainForm, "Select group_concat(mi.medName) as '藥品清單', 
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
                        row.Cells("單位").Value = unit(row.Cells("medUnit").Value)
                    Catch ex As Exception
                        row.Cells("單位").Value = unit(1)
                    End Try
                Next
                fullListView.Columns("medUnit").Visible = False
            End If
        End If
    End Sub

    Private Sub printMedButton_Click(sender As Object, e As EventArgs) Handles printMedButton.Click
        printIndex = 0
        printPreview.Document = printDoc
        printPreview.ShowDialog()

        'Try
        '    With printDoc
        '        .PrinterSettings.PrinterName = "Ring 412PE+"
        '        .DefaultPageSettings.Landscape = False
        '        .Print()
        '    End With
        'Catch ex As Exception
        '    MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息: 找不到標籤機, 請檢查連線後在重試!", "無法連線至標籤機", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

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
        e.Graphics.DrawString("病歷號: " & patientInfo.pID, headerFont, Brushes.Black, New Point(215, 415), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(280, 435), New Point(380, 435))

        e.Graphics.DrawString("藥物內容:", headerFont, Brushes.Black, New Point(20, 440), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(20, 460), New Point(95, 460))


        Dim aBytes() As Byte = System.Text.Encoding.UTF8.GetBytes(fullListView.Rows(printIndex).Cells("藥品清單").Value)
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
            usage += "飯前"
            trigger = True
        End If
        If fullListView.Rows(printIndex).Cells("飯後").Value And trigger Then
            usage += "或飯後"
        ElseIf fullListView.Rows(printIndex).Cells("飯後").Value Then
            usage += "飯後"
        End If
        If fullListView.Rows(printIndex).Cells("睡前").Value Then
            usage += "以及睡前"
        End If
        usage += fullListView.Rows(printIndex).Cells("份量").Value & fullListView.Rows(printIndex).Cells("單位").Value
        If fullListView.Rows(printIndex).Cells("不適時").Value Then
            usage += "不適時也吃"
        End If
        e.Graphics.DrawString("服用方法: " & usage, headerFont, Brushes.Black, New Point(20, 525), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(20, 545), New Point(95, 545))

        e.Graphics.DrawString("福濬中醫診所 (03)327-7900" & vbNewLine & "桃園市龜山區文化二路30-11號", subFont, Brushes.Black, New Point(20, 550), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(20, 580), New Point(160, 580))


        Dim twnCal As System.Globalization.TaiwanCalendar = New System.Globalization.TaiwanCalendar
        stringFormat.Alignment = StringAlignment.Far
        e.Graphics.DrawString("製造日期:" & vbNewLine & twnCal.GetYear(DateAndTime.Now) & Now.ToString("年MM月dd日"), subFont, Brushes.Black, New Point(385, 550), stringFormat)
        e.Graphics.DrawLine(Pens.Black, New Point(380, 580), New Point(300, 580))

        If printIndex < fullListView.Rows.Count - 1 Then
            printIndex += 1
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub
End Class
