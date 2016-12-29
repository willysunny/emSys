Imports Word = Microsoft.Office.Interop.Word
Imports MySql.Data.MySqlClient

Public Class frmUserReport
    Private userInfo As frmUserQuery = Nothing
    Private pt As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 測量點
    Private printPage As Integer = 0

    Private dangerColor As Color = Color.FromArgb(255, 255, 255)
    Private dangerBGColor As Color = Color.FromArgb(230, 0, 18)
    Private warningColor As Color = Color.FromArgb(235, 97, 0)
    Private normalColor As Color = Color.FromArgb(0, 153, 68)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        pt.Add(12, "元氣 - 上")
        pt.Add(3, "元氣 - 下")
        pt.Add(10, "元氣 - 左")
        pt.Add(5, "元氣 - 右")
        pt.Add(9, "元氣 - 左上右下")
        pt.Add(6, "元氣 - 右上左下")
        pt.Add(111150, "免疫系統")
        pt.Add(111250, "肺")
        pt.Add(111230, "鼻咽")
        pt.Add(112150, "大腸")
        pt.Add(112250, "神經傳導")
        pt.Add(113150, "大血管")
        pt.Add(113250, "微血管")
        pt.Add(114150, "器官退化-總")
        pt.Add(114110, "器官退化-頂")
        pt.Add(114120, "器官退化-頭")
        pt.Add(114130, "器官退化-上焦")
        pt.Add(114140, "器官退化-中焦")
        pt.Add(114160, "器官退化-下焦")
        pt.Add(114250, "內分泌")
        pt.Add(114210, "腦下垂體")
        pt.Add(114220, "甲狀腺")
        pt.Add(114240, "乳房")
        pt.Add(114260, "卵巢")
        pt.Add(115150, "心臟")
        pt.Add(115130, "壓力指數")
        pt.Add(115250, "小腸")
        pt.Add(211150, "免疫系統")
        pt.Add(211250, "肺")
        pt.Add(211230, "鼻咽")
        pt.Add(212150, "大腸")
        pt.Add(212250, "神經傳導")
        pt.Add(213150, "大血管")
        pt.Add(213250, "微血管")
        pt.Add(214150, "器官退化-總")
        pt.Add(214110, "器官退化-頂")
        pt.Add(214120, "器官退化-頭")
        pt.Add(214130, "器官退化-上焦")
        pt.Add(214140, "器官退化-中焦")
        pt.Add(214160, "器官退化-下焦")
        pt.Add(214250, "內分泌")
        pt.Add(214210, "腦下垂體")
        pt.Add(214220, "甲狀腺")
        pt.Add(214240, "乳房")
        pt.Add(214260, "卵巢")
        pt.Add(215150, "心臟")
        pt.Add(215250, "小腸")
        pt.Add(121150, "脾臟")
        pt.Add(121250, "肝臟")
        pt.Add(121260, "肝功能/大腸")
        pt.Add(122110, "頭骨")
        pt.Add(122120, "頸椎骨")
        pt.Add(122130, "腰骨")
        pt.Add(122150, "臀骨")
        pt.Add(122140, "大腿骨")
        pt.Add(122160, "小腿骨")
        pt.Add(122250, "胃")
        pt.Add(123150, "纖維化-總")
        pt.Add(123120, "纖維化-頭")
        pt.Add(123130, "纖維化-上焦")
        pt.Add(123140, "纖維化-中焦")
        pt.Add(123160, "纖維化-下焦")
        pt.Add(123250, "皮膚")
        pt.Add(124150, "脂肪代謝")
        pt.Add(124250, "膽囊總膽管")
        pt.Add(125150, "腎臟")
        pt.Add(125230, "膀胱")
        pt.Add(125250, "膀胱經")
        pt.Add(125240, "子宮/前列腺")
        pt.Add(221150, "胰臟")
        pt.Add(221130, "血糖")
        pt.Add(221250, "肝臟")
        pt.Add(221260, "肝功能/大腸")
        pt.Add(222110, "頭骨")
        pt.Add(222120, "頸椎骨")
        pt.Add(222130, "腰骨")
        pt.Add(222150, "臀骨")
        pt.Add(222140, "大腿骨")
        pt.Add(222160, "小腿骨")
        pt.Add(222250, "胃")
        pt.Add(223150, "纖維化-總")
        pt.Add(223120, "纖維化-頭")
        pt.Add(223130, "纖維化-上焦")
        pt.Add(223140, "纖維化-中焦")
        pt.Add(223160, "纖維化-下焦")
        pt.Add(223250, "皮膚")
        pt.Add(224150, "脂肪代謝")
        pt.Add(224250, "肝內膽管")
        pt.Add(225150, "腎臟")
        pt.Add(225230, "膀胱")
        pt.Add(225240, "子宮/前列腺")
        pt.Add(225250, "膀胱經")
        pt.Add(125260, "膀胱器官退化")
        pt.Add(225260, "膀胱器官退化")
        pt.Add(125251, "膀胱結石")
        pt.Add(225251, "膀胱結石")
        pt.Add(124251, "膽囊結石")
        pt.Add(224251, "膽管結石")
        pt.Add(125151, "腎結石")
        pt.Add(225151, "腎結石")


        userInfo = New frmUserQuery
        AddHandler userInfo.patientSelected, AddressOf userInfo_patientSelected
        AddHandler userInfo.cancelled, AddressOf userInfo_cancelled
        userInfo.ShowDialog()

    End Sub
    Public Sub userInfo_cancelled(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler userInfo.patientSelected, AddressOf userInfo_patientSelected
        RemoveHandler userInfo.cancelled, AddressOf userInfo_cancelled
        Me.Close()
    End Sub


    Public Sub userInfo_patientSelected(ByVal sender As Object, ByVal e As EventArgs)
        Try
            RemoveHandler userInfo.patientSelected, AddressOf userInfo_patientSelected
            RemoveHandler userInfo.cancelled, AddressOf userInfo_cancelled
        Catch ex As Exception
        End Try
        pName.Text = userInfo.resultInfo.pName
        loadHistory()
    End Sub

    Private Sub changePatient_Click(sender As Object, e As EventArgs) Handles changePatient.Click
        userInfo = New frmUserQuery
        AddHandler userInfo.patientSelected, AddressOf userInfo_patientSelected
        userInfo.ShowDialog()
    End Sub

    Private Sub loadHistory()
        With historyBox
            .DataSource = returnData(Me, "SELECT bID, bookTime FROM patient_booking WHERE pID=" & userInfo.resultInfo.pID & " ORDER BY bookTime DESC")
            .ValueMember = "bID"
            .DisplayMember = "bookTime"
        End With
    End Sub

#Region "資料處裡"
    ' 分析結果
    Private Function parseResult(ByVal value As Integer, Optional outputNum As Boolean = False) As String
        If outputNum Then
            If value = -9999 Then Return "0" Else Return value.ToString
        Else
            If value = -9999 Then Return "-" Else Return value.ToString
        End If
    End Function
    ' 取高
    Private Function getMax(ByVal bID As Integer, ByVal iCode As Integer) As Integer
        Dim max As Integer
        Dim queryStr As String = "SELECT max(`ivalue`) as `max_val` FROM ems WHERE `bID`='" & bID & "' and `iCode`='" & iCode & "' ORDER BY `iPlotCount` LIMIT 50"
        Dim reader As IDataReader = runQuery(queryStr)
        Try

            reader.Read()
            If reader.IsDBNull(0) Then
                reader.Close()
                Return -9999
            Else
                max = CInt(reader.GetInt32(0))
                reader.Close()
            End If
        Catch ex As MySqlException
            reader.Close()
            Console.WriteLine("Error: " & ex.ToString())
        End Try
        Return max
    End Function
    ' 取低
    Private Function getLow(ByVal bID As Integer, ByVal iCode As Integer) As Integer
        Dim low As Integer
        Dim queryStr As String = "SELECT `iPlotCount`, `iValue` FROM ems WHERE `bID`='" & bID & "' and `iCode`='" & iCode & "' ORDER BY `iPlotCount` DESC Limit 1"
        Dim reader As IDataReader = runQuery(queryStr)
        Try
            If Not reader.Read Then
                reader.Close()
                Return -9999
            Else
                If reader.GetInt32(0) > 50 Then
                    reader.Close()
                    queryStr = "SELECT * FROM ems WHERE `bID`='" & bID & "' and `iCode`='" & iCode & "' ORDER BY `iPlotCount` DESC"
                    reader = runQuery(queryStr)
                    While reader.Read()
                        If reader.GetInt32(0) = 50 Then
                            low = reader.GetInt32(1)
                            reader.Close()
                            Exit While
                        End If
                    End While
                    reader.Close()
                Else
                    low = reader.GetInt32(1)
                    reader.Close()
                End If
            End If

        Catch ex As MySqlException
            reader.Close()
            Console.WriteLine("Error: " & ex.ToString())
        End Try
        Return low
    End Function
    ' 設定文字及顏色
    Private Sub setResult(ByRef oDoc As Word.Document, ByVal maxValue As String, ByVal point As KeyValuePair(Of Integer, String), ByVal fieldName As String,
                          ByVal upperDanger As Integer, ByVal upperWarning As Integer, ByVal lowerWarning As Integer, ByVal lowerDanger As Integer)

        If maxValue = "-" Then
        ElseIf CInt(maxValue) > upperDanger Or CInt(maxValue) < lowerDanger Then
            oDoc.Bookmarks.Item(fieldName).Range.Font.Color = DirectCast(dangerColor.R + &H100 * dangerColor.G + &H10000 * dangerColor.B, Word.WdColor)
            oDoc.Bookmarks.Item(fieldName).Range.Cells.Shading.BackgroundPatternColor = DirectCast(dangerBGColor.R + &H100 * dangerBGColor.G + &H10000 * dangerBGColor.B, Word.WdColor)
        ElseIf CInt(maxValue) > upperWarning Or CInt(maxValue) < lowerWarning Then
            oDoc.Bookmarks.Item(fieldName).Range.Font.Color = DirectCast(warningColor.R + &H100 * warningColor.G + &H10000 * warningColor.B, Word.WdColor)
        Else
            oDoc.Bookmarks.Item(fieldName).Range.Font.Color = DirectCast(normalColor.R + &H100 * normalColor.G + &H10000 * normalColor.B, Word.WdColor)
        End If
        oDoc.Bookmarks.Item(fieldName).Range.Text = maxValue
    End Sub
#End Region

#Region "頻譜列印"
    Private Sub printGraph_Click(sender As Object, e As EventArgs) Handles printGraphButton.Click
        If Not historyBox.SelectedIndex = -1 Then
            loadingBar.Value = 0
            loadingBar.Maximum = 150
            statusLabel.Text = "準備中"
            printGraphButton.Enabled = False
            printEnergyButton.Enabled = False
            Try
                ' 定義Word文件
                Dim oWord As New Word.Application
                oWord = CreateObject("Word.Application")

                ' 開啟表單
                Dim oDoc As Word.Document
                oDoc = oWord.Documents.Add(Application.StartupPath & "\reportForm\reportForm.docx")
                loadingBar.PerformStep()
                Application.DoEvents()

                ' 顏色數值設定
                oDoc.Bookmarks.Item("danger").Range.Font.Color = DirectCast(dangerColor.R + &H100 * dangerColor.G + &H10000 * dangerColor.B, Word.WdColor)
                oDoc.Bookmarks.Item("danger").Range.Cells.Shading.BackgroundPatternColor = DirectCast(dangerBGColor.R + &H100 * dangerBGColor.G + &H10000 * dangerBGColor.B, Word.WdColor)
                oDoc.Bookmarks.Item("danger").Range.Text = "紅色"
                oDoc.Bookmarks.Item("warning").Range.Font.Color = DirectCast(warningColor.R + &H100 * warningColor.G + &H10000 * warningColor.B, Word.WdColor)
                oDoc.Bookmarks.Item("warning").Range.Text = "橙色"
                oDoc.Bookmarks.Item("normal").Range.Font.Color = DirectCast(normalColor.R + &H100 * normalColor.G + &H10000 * normalColor.B, Word.WdColor)
                oDoc.Bookmarks.Item("normal").Range.Text = "綠色"
                oDoc.Bookmarks.Item("energyNormLowerBound").Range.Text = My.Settings.engLowerWarning + 1
                oDoc.Bookmarks.Item("energyNormUpperBound").Range.Text = My.Settings.engUpperWarning - 1
                oDoc.Bookmarks.Item("emsNormLowerBound").Range.Text = My.Settings.emsLowerWarning + 1
                oDoc.Bookmarks.Item("emsNormUpperBound").Range.Text = My.Settings.emsUpperWarning - 1

                ' 基本資訊
                oDoc.Bookmarks.Item("pID").Range.Text = userInfo.resultInfo.pID
                oDoc.Bookmarks.Item("pName").Range.Text = userInfo.resultInfo.pName
                If userInfo.resultInfo.pSex = 0 Then oDoc.Bookmarks.Item("pSex").Range.Text = "女" Else oDoc.Bookmarks.Item("pSex").Range.Text = "男"
                oDoc.Bookmarks.Item("pBDay").Range.Text = userInfo.resultInfo.pcDOB
                oDoc.Bookmarks.Item("pAge").Range.Text = userInfo.resultInfo.pAge
                oDoc.Bookmarks.Item("pCreatedDate").Range.Text = userInfo.resultInfo.pCreatedDate
                oDoc.Bookmarks.Item("pLastVisit").Range.Text = userInfo.resultInfo.pLastVisit
                oDoc.Bookmarks.Item("pTimes").Range.Text = userInfo.resultInfo.pVisitCount
                Dim reader As IDataReader = runQuery("SELECT doctor.docName FROM patient_booking INNER JOIN doctor ON patient_booking.docID = doctor.docID WHERE bID=" & historyBox.SelectedValue)
                If reader.Read() Then
                    oDoc.Bookmarks.Item("pDocName").Range.Text = reader.GetString(0)
                End If
                loadingBar.PerformStep()
                Application.DoEvents()

                Dim colorIndex As Integer = 0
                ' 本次測量點
                For Each point As KeyValuePair(Of Integer, String) In pt
                    Debug.WriteLine(point.Key & " - " & point.Value)
                    loadingBar.PerformStep()
                    Application.DoEvents()
                    If point.Key > 1000 Then
                        Dim bookmark As String = ""
                        Select Case Mid(point.Key, 1, 2)
                            Case "11"
                                bookmark = "LH" & Mid(point.Key, 3, 3)
                            Case "12"
                                bookmark = "LF" & Mid(point.Key, 3, 3)
                            Case "21"
                                bookmark = "RH" & Mid(point.Key, 3, 3)
                            Case "22"
                                bookmark = "RF" & Mid(point.Key, 3, 3)
                        End Select
                        If Mid(point.Key, 6, 1) = "1" Then
                            bookmark = bookmark + "P"
                        End If
                        If point.Key = 125260 Then
                        ElseIf point.Key = 225260 Then
                        Else
                            setResult(oDoc, parseResult(getMax(historyBox.SelectedValue, point.Key)), point, "C" & bookmark, My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            If historyBox.SelectedIndex < historyBox.Items.Count - 1 Then setResult(oDoc, parseResult(getMax(CType(historyBox.Items(historyBox.SelectedIndex + 1), DataRowView).Row.ItemArray(0), point.Key)), point, "P" & bookmark, My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                        End If

                    Else
                        Dim maxValue As String
                        maxValue = parseResult(getMax(historyBox.SelectedValue, point.Key))
                        Dim pMaxValue As String = ""
                        If historyBox.SelectedIndex < historyBox.Items.Count - 1 Then pMaxValue = parseResult(getMax(CType(historyBox.Items(historyBox.SelectedIndex + 1), DataRowView).Row.ItemArray(0), point.Key))
                        Select Case point.Key
                            Case 12
                                setResult(oDoc, maxValue, point, "CE1", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If historyBox.SelectedIndex < historyBox.Items.Count - 1 Then setResult(oDoc, pMaxValue, point, "PE1", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            Case 3
                                setResult(oDoc, maxValue, point, "CE2", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If historyBox.SelectedIndex < historyBox.Items.Count - 1 Then setResult(oDoc, pMaxValue, point, "PE2", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            Case 10
                                setResult(oDoc, maxValue, point, "CE3", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If historyBox.SelectedIndex < historyBox.Items.Count - 1 Then setResult(oDoc, pMaxValue, point, "PE3", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            Case 5
                                setResult(oDoc, maxValue, point, "CE4", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If historyBox.SelectedIndex < historyBox.Items.Count - 1 Then setResult(oDoc, pMaxValue, point, "PE4", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            Case 9
                                setResult(oDoc, maxValue, point, "CE5", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If historyBox.SelectedIndex < historyBox.Items.Count - 1 Then setResult(oDoc, pMaxValue, point, "PE5", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            Case 6
                                setResult(oDoc, maxValue, point, "CE6", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If historyBox.SelectedIndex < historyBox.Items.Count - 1 Then setResult(oDoc, pMaxValue, point, "PE6", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                        End Select
                    End If
                Next

                ' 藥檢紀錄
                Dim medCounter As Integer = 1

                Dim fullMedList As DataTable = returnData(Me, "Select mg.mgid, mi.medName, 
                                                               mg.morning, mg.noon , mg.night, mg.beforeSleep, mg.notWell, 
                                                               mg.beforeMeal, mg.afterMeal,  mg.medDays, mg.medAmount , mg.medUnit, mi.medDesc
                                                        From medGroup2medDetail As mg
                                                        INNER Join medDetail AS md ON mg.mgID = md.mgID
                                                        INNER Join med_item as mi on md.medID = mi.medID
                                                        WHERE mi.bioMed=0 AND bId =" & historyBox.SelectedValue)
                For Each row As DataRow In fullMedList.Rows
                    loadingBar.PerformStep()
                    Application.DoEvents()

                    With row
                        Dim amount As String = .Item("medAmount")
                        Dim times As Integer = 0
                        Dim days As String = .Item("medDays")
                        oDoc.Bookmarks.Item("medNameSlot" & medCounter).Range.Text = .Item("medName")
                        oDoc.Bookmarks.Item("medNameDescSlot" & medCounter).Range.Text = .Item("medName")
                        oDoc.Bookmarks.Item("medNameDesc" & medCounter).Range.Text = .Item("medDesc")

                        Dim unitName As String = ""
                        Select Case .Item("medUnit")
                            Case 1
                                unitName = "克"
                            Case 2
                                unitName = "顆"
                            Case 3
                                unitName = "包"
                            Case 4
                                unitName = "瓶"
                        End Select
                        oDoc.Bookmarks.Item("medAmount" & medCounter).Range.Text = amount & unitName
                        oDoc.Bookmarks.Item("medDays" & medCounter).Range.Text = days & "天"

                        Dim trigger As Boolean = False
                        Dim str As String = ""
                        If .Item("beforeMeal") = True Then
                            str = "飯前"
                            trigger = True
                        End If
                        If .Item("afterMeal") And trigger Then
                            str += "/飯後"
                        ElseIf .Item("AfterMeal") = True Then
                            str = "飯後"
                        End If
                        oDoc.Bookmarks.Item("medMeal" & medCounter).Range.Text = str

                        trigger = False
                        str = ""
                        If .Item("morning") = True Then
                            str = "早"
                            trigger = True
                            times += 1
                        End If

                        If .Item("noon") = True And trigger Then
                            str += "/中"
                            times += 1
                        ElseIf .Item("noon") = True Then
                            str = "中"
                            times += 1
                            trigger = True
                        End If

                        If .Item("night") = True And trigger Then
                            str += "/晚"
                            times += 1
                        ElseIf .Item("night") = True Then
                            str = "晚"
                            times += 1
                            trigger = True
                        End If

                        If .Item("beforeSleep") = True And trigger Then
                            str += "/睡前"
                            times += 1
                        ElseIf .Item("beforeSleep") = True Then
                            str = "睡前"
                            times += 1
                            trigger = True
                        End If

                        If .Item("notWell") = True And trigger Then
                            str += "/不適時"
                            times += 1
                        ElseIf .Item("notWell") = True Then
                            str = "不適時"
                            times += 1
                            trigger = True
                        End If
                        oDoc.Bookmarks.Item("medTotalAmount" & medCounter).Range.Text = (CInt(amount) * times * CInt(days)).ToString & unitName
                        oDoc.Bookmarks.Item("medTime" & medCounter).Range.Text = str

                        medCounter = medCounter + 1

                        If medCounter > 15 Then Exit For
                    End With
                Next

                ' 建議用藥
                medCounter = 1

                fullMedList = returnData(Me, "Select mg.mgid, mi.medName, 
                                                     mg.morning, mg.noon , mg.night, mg.beforeSleep, mg.notWell, 
                                                     mg.beforeMeal, mg.afterMeal,  mg.medDays, mg.medAmount , mg.medUnit, mi.medDesc
                                              From medGroup2medDetail As mg
                                              INNER Join medDetail AS md ON mg.mgID = md.mgID
                                              INNER Join med_item as mi on md.medID = mi.medID
                                              WHERE mi.bioMed=1 AND bID =" & historyBox.SelectedValue)
                For Each row As DataRow In fullMedList.Rows
                    loadingBar.PerformStep()
                    Application.DoEvents()

                    With row
                        Dim amount As String = .Item("medAmount")
                        Dim times As Integer = 0
                        Dim days As String = .Item("medDays")
                        oDoc.Bookmarks.Item("medRecommendNameSlot" & medCounter).Range.Text = .Item("medName")
                        oDoc.Bookmarks.Item("medRecommendNameDescSlot" & medCounter).Range.Text = .Item("medName")
                        oDoc.Bookmarks.Item("medRecommendNameDesc" & medCounter).Range.Text = .Item("medDesc")

                        Dim unitName As String = ""
                        Select Case .Item("medUnit")
                            Case 1
                                unitName = "克"
                            Case 2
                                unitName = "顆"
                            Case 3
                                unitName = "包"
                            Case 4
                                unitName = "瓶"
                        End Select
                        oDoc.Bookmarks.Item("medRecommendAmount" & medCounter).Range.Text = amount & unitName
                        oDoc.Bookmarks.Item("medRecommendDays" & medCounter).Range.Text = days & "天"

                        Dim trigger As Boolean = False
                        Dim str As String = ""
                        If .Item("beforeMeal") = True Then
                            str = "飯前"
                            trigger = True
                        End If
                        If .Item("afterMeal") And trigger Then
                            str += "/飯後"
                        ElseIf .Item("AfterMeal") = True Then
                            str = "飯後"
                        End If
                        oDoc.Bookmarks.Item("medRecommendMeal" & medCounter).Range.Text = str

                        trigger = False
                        str = ""
                        If .Item("morning") = True Then
                            str = "早"
                            trigger = True
                            times += 1
                        End If

                        If .Item("noon") = True And trigger Then
                            str += "/中"
                            times += 1
                        ElseIf .Item("noon") = True Then
                            str = "中"
                            times += 1
                            trigger = True
                        End If

                        If .Item("night") = True And trigger Then
                            str += "/晚"
                            times += 1
                        ElseIf .Item("night") = True Then
                            str = "晚"
                            times += 1
                            trigger = True
                        End If

                        If .Item("beforeSleep") = True And trigger Then
                            str += "/睡前"
                            times += 1
                        ElseIf .Item("beforeSleep") = True Then
                            str = "睡前"
                            times += 1
                            trigger = True
                        End If

                        If .Item("notWell") = True And trigger Then
                            str += "/不適時"
                            times += 1
                        ElseIf .Item("notWell") = True Then
                            str = "不適時"
                            times += 1
                            trigger = True
                        End If
                        oDoc.Bookmarks.Item("medRecommendTotalAmount" & medCounter).Range.Text = (CInt(amount) * times * CInt(days)).ToString & unitName
                        oDoc.Bookmarks.Item("medRecommendTime" & medCounter).Range.Text = str

                        medCounter = medCounter + 1

                        If medCounter > 15 Then Exit For
                    End With
                Next


                ' 顯示報表
                oWord.Visible = True

                loadingBar.Value = 0
                statusLabel.Text = "完成"
                printGraphButton.Enabled = True
                printEnergyButton.Enabled = True

            Catch ex As Exception
                Debug.WriteLine(ex.Message)
                loadingBar.Value = 0
                statusLabel.Text = "完成"
                printGraphButton.Enabled = True
                printEnergyButton.Enabled = True
            End Try
        End If
    End Sub
#End Region

#Region "元氣列印"
    Private Sub printEnergy_Click(sender As Object, e As EventArgs) Handles printEnergyButton.Click
        printDoc.OriginAtMargins = False
        printDoc.DocumentName = "報表"
        loadingBar.Value = 0
        loadingBar.Maximum = 4
        statusLabel.Text = "準備中"
        printGraphButton.Enabled = False
        printEnergyButton.Enabled = False

        If mainForm.debugMode.Checked Then
            printPreviewDlg.ShowDialog()
        Else
            Try
                If printDlg.ShowDialog() = DialogResult.OK Then printDoc.Print()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                loadingBar.Value = 0
                statusLabel.Text = "就緒"
                printGraphButton.Enabled = True
                printEnergyButton.Enabled = True
            End Try
        End If
    End Sub
    '結束列印重製頁數
    Private Sub PrintDoc_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles printDoc.EndPrint
        printPage = 0
        loadingBar.Value = 0
        statusLabel.Text = "完成"
        printGraphButton.Enabled = True
        printEnergyButton.Enabled = True
    End Sub
    ' 列印報表
    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDoc.PrintPage
        loadingBar.PerformStep()
        Application.DoEvents()

        If printPage = 3 Then printPage = 0

        ' 文字設定
        Dim outlinePath As New Drawing2D.GraphicsPath
        Dim useFont As Font = New Font("標楷體", 20, FontStyle.Regular)
        Dim fontsize As Integer
        Dim stringFormat As New StringFormat()
        stringFormat.FormatFlags = StringFormatFlags.NoClip

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        ' 取得Bar Chart數值
        Const size As Integer = 16
        Static hand(size) As Integer
        Static handName(size) As String
        Static foot(size) As Integer
        Static footName(size) As String
        Dim hCounter As Integer = 1
        Dim fCounter As Integer = 1

        Select Case printPage
            Case 0 ' 第一頁
                ' 與伺服器連線
                '標題設定
                fontsize = 18
                stringFormat.Alignment = StringAlignment.Far

                Dim resultData As DataTable = returnData(Me, "SELECT icode FROM ems WHERE bID='" & historyBox.SelectedValue & "' group by icode")
                For Each row As DataRow In resultData.Rows
                    If row.Item("icode") > 1000 Then
                        Dim LR As Boolean = CBool(CInt(Mid(row.Item("icode").ToString(), 1, 1)) = 1)
                        Dim HF As Integer = CInt(Mid(row.Item("icode").ToString(), 2, 1))
                        If HF = 1 Then
                            ' 手
                            If Not hand.Contains(CInt(Mid(row.Item("icode").ToString(), 3))) And hCounter <= size Then
                                hand(hCounter) = CInt(Mid(row.Item("icode").ToString(), 3))
                                handName(hCounter) = pt(row.Item("icode"))
                                '' 繪製文字
                                'outlinePath.AddString(pt(row.item("icode")), useFont.FontFamily, FontStyle.Regular, fontsize, New Point(170, 335 + (hCounter - 1) * 55), stringFormat)
                                'e.Graphics.FillPath(Brushes.Black, outlinePath)
                                'e.Graphics.DrawPath(Pens.Black, outlinePath)
                                'outlinePath.Reset()
                                hCounter += 1
                            End If
                            'For i = 1 To size
                            '    If hand(i) = CInt(Mid(row.item("icode").tostring(), 3)) Then
                            '        printBar(e, outlinePath, 170, i, row.item("icode"), LR)
                            '        Exit For
                            '    End If
                            'Next i
                        ElseIf HF = 2 Then
                            ' 腳
                            If Not foot.Contains(CInt(Mid(row.Item("icode").ToString(), 3))) And fCounter <= size Then
                                foot(fCounter) = CInt(Mid(row.Item("icode").ToString(), 3))
                                footName(fCounter) = pt(row.Item("icode"))
                                fCounter += 1
                            End If
                        End If
                    End If
                Next

                For i = 1 To size
                    If Not hand(i) = 0 Then
                        printBar(e, outlinePath, 50, i - 1, CInt("11" & hand(i)), True)
                        printBar(e, outlinePath, 50, i - 1, CInt("21" & hand(i)), False)
                    End If
                Next i

                drawOutline(e, outlinePath, "頻譜檢驗數據圖 - 手部")

            Case 1 ' 第二頁
                For i = 1 To size
                    If Not foot(i) = 0 Then
                        printBar(e, outlinePath, 50, i - 1, CInt("12" & foot(i)), True)
                        printBar(e, outlinePath, 50, i - 1, CInt("22" & foot(i)), False)
                    End If
                Next i

                drawOutline(e, outlinePath, "頻譜檢驗數據圖 - 足部")

            Case 2 ' 第三頁
                ' 繪製元氣值
                printBar(e, outlinePath, 50, size / 2 + 1, 12, True)
                printBar(e, outlinePath, 50, size / 2 + 2, 3, True)
                printBar(e, outlinePath, 50, size / 2 + 3, 10, True)
                printBar(e, outlinePath, 50, size / 2 + 4, 5, True)
                printBar(e, outlinePath, 50, size / 2 + 5, 9, True)
                printBar(e, outlinePath, 50, size / 2 + 6, 6, True)
                printBar(e, outlinePath, 50, size / 2 + 1, 12, False)
                printBar(e, outlinePath, 50, size / 2 + 2, 3, False)
                printBar(e, outlinePath, 50, size / 2 + 3, 10, False)
                printBar(e, outlinePath, 50, size / 2 + 4, 5, False)
                printBar(e, outlinePath, 50, size / 2 + 5, 9, False)
                printBar(e, outlinePath, 50, size / 2 + 6, 6, False)

                printEnergy(e, outlinePath)

                drawOutline(e, outlinePath, "元氣檢驗數據圖", True)

        End Select

        '' 基本框線
        'outlinePath.AddRectangle(New Rectangle(170, 90, 238, 160))
        'outlinePath.AddRectangle(New Rectangle(540, 90, 238, 160))
        'outlinePath.AddRectangle(New Rectangle(170, 310, 238, 780))
        'outlinePath.AddRectangle(New Rectangle(540, 310, 238, 780))

        '' 繪製基本框線
        'e.Graphics.DrawPath(Pens.Black, outlinePath)
        'outlinePath.Reset()

        useFont.Dispose()

        'e.Graphics.FillPath(Brushes.LightGray, outlinePath)
        'e.Graphics.TranslateTransform(-1, -1)
        'e.Graphics.TranslateTransform(1, 1)
        outlinePath.Dispose()
        printPage += 1
        If printPage < 3 Then e.HasMorePages = True Else e.HasMorePages = False
    End Sub
    ' 列印外框
    Private Sub drawOutline(ByRef e As Printing.PrintPageEventArgs, ByRef outlinePath As Drawing2D.GraphicsPath, ByVal title As String, Optional alt As Boolean = False)
        Dim useFont As Font = New Font("標楷體", 20, FontStyle.Regular)
        Dim stringFormat As New StringFormat()
        stringFormat.FormatFlags = StringFormatFlags.NoClip
        stringFormat.Alignment = StringAlignment.Near
        stringFormat.LineAlignment = StringAlignment.Near

        '標題
        Dim fontsize As Integer = 24
        stringFormat.Alignment = StringAlignment.Near
        outlinePath.AddString(title, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(50, 50), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()

        Dim height As Integer = (printDoc.DefaultPageSettings.Bounds.Height - 150) / 2  ' 完整高度
        Dim textHeight As Integer = height / 4                                          ' 文字高度
        Dim barHeight As Integer = height - textHeight                                  ' 圖表高度

        Dim upperDanger, upperWarning, lowerWarning, lowerDanger As Integer

        With My.Settings
            upperDanger = .emsUpperDanger
            upperWarning = .emsUpperWarning
            lowerWarning = .emsLowerWarning
            lowerDanger = .emsLowerDanger
            If alt Then
                upperDanger = .engUpperDanger
                upperWarning = .engUpperWarning
                lowerWarning = .engLowerWarning
                lowerDanger = .engLowerDanger
            End If
        End With

        For i = 0 To 1
            If alt And i = 0 Then
                ' 基本框線
                outlinePath.AddRectangle(New Rectangle(50, 100, printDoc.DefaultPageSettings.Bounds.Width - 100, height - 20))
                e.Graphics.DrawPath(Pens.Black, outlinePath)
                outlinePath.Reset()
            Else
                stringFormat.Alignment = StringAlignment.Far
                stringFormat.LineAlignment = StringAlignment.Center

                fontsize = 12

                Dim normalvalue As Integer = (upperWarning + lowerWarning) / 2
                ' 繪製標準線
                outlinePath.AddLine(50, 100 + i * height + CInt(barHeight - barHeight * normalvalue / 100), printDoc.DefaultPageSettings.Bounds.Width - 50, 100 + i * height + CInt(barHeight - barHeight * normalvalue / 100))
                outlinePath.AddString(normalvalue.ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(45, 100 + i * height + CInt(barHeight - barHeight * normalvalue / 100)), stringFormat)
                e.Graphics.DrawPath(Pens.Green, outlinePath)
                outlinePath.Reset()

                ' 繪製注意線
                outlinePath.AddLine(50, 100 + i * height + CInt(barHeight - barHeight * upperWarning / 100), printDoc.DefaultPageSettings.Bounds.Width - 50, 100 + i * height + CInt(barHeight - barHeight * upperWarning / 100))
                outlinePath.AddString(upperWarning.ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(45, 100 + i * height + CInt(barHeight - barHeight * upperWarning / 100)), stringFormat)
                e.Graphics.DrawPath(Pens.Orange, outlinePath)
                outlinePath.Reset()
                outlinePath.AddLine(50, 100 + i * height + CInt(barHeight - barHeight * lowerWarning / 100), printDoc.DefaultPageSettings.Bounds.Width - 50, 100 + i * height + CInt(barHeight - barHeight * lowerWarning / 100))
                outlinePath.AddString(lowerWarning.ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(45, 100 + i * height + CInt(barHeight - barHeight * lowerWarning / 100)), stringFormat)
                e.Graphics.DrawPath(Pens.Orange, outlinePath)
                outlinePath.Reset()

                ' 繪製警戒線
                outlinePath.AddLine(50, 100 + i * height + CInt(barHeight - barHeight * upperDanger / 100), printDoc.DefaultPageSettings.Bounds.Width - 50, 100 + i * height + CInt(barHeight - barHeight * upperDanger / 100))
                outlinePath.AddString(upperDanger.ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(45, 100 + i * height + CInt(barHeight - barHeight * upperDanger / 100)), stringFormat)
                e.Graphics.DrawPath(Pens.Red, outlinePath)
                outlinePath.Reset()
                outlinePath.AddLine(50, 100 + i * height + CInt(barHeight - barHeight * lowerDanger / 100), printDoc.DefaultPageSettings.Bounds.Width - 50, 100 + i * height + CInt(barHeight - barHeight * lowerDanger / 100))
                outlinePath.AddString(lowerDanger.ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(45, 100 + i * height + CInt(barHeight - barHeight * lowerDanger / 100)), stringFormat)
                e.Graphics.DrawPath(Pens.Red, outlinePath)
                outlinePath.Reset()

                ' 基本框線
                outlinePath.AddRectangle(New Rectangle(50, 100 + i * height, printDoc.DefaultPageSettings.Bounds.Width - 100, barHeight))
                e.Graphics.DrawPath(Pens.Black, outlinePath)
                outlinePath.Reset()
            End If
        Next
    End Sub
    ' 列印長條圖
    Private Sub printBar(ByRef e As Printing.PrintPageEventArgs, ByRef outlinePath As Drawing2D.GraphicsPath,
                         ByVal xPos As Integer, ByVal index As Integer, ByVal iCode As Integer,
                         Optional ByVal Left As Boolean = True)

        ' Bar Chart處理

        ' 基本變數
        Dim barCount As Integer = 8                                                     ' 一排多少個
        Dim width As Integer = printDoc.DefaultPageSettings.Bounds.Width - 100          ' 完整寬度
        Dim height As Integer = (printDoc.DefaultPageSettings.Bounds.Height - 150) / 2  ' 完整高度
        Dim textHeight As Integer = height / 4                                          ' 文字高度
        Dim barHeight As Integer = height - textHeight                                  ' 圖表高度
        Dim barWidth As Integer = width / barCount                                      ' 圖表寬度
        Dim LR As Integer = 0

        Dim useFont As Font = New Font("標楷體", 20, FontStyle.Regular)
        Dim fontsize As Integer
        Dim stringFormat As New StringFormat()
        stringFormat.FormatFlags = StringFormatFlags.NoClip

        Dim shift As Integer = 0

        Dim upperDanger, upperWarning, lowerWarning, lowerDanger As Integer

        With My.Settings
            upperDanger = .emsUpperDanger
            upperWarning = .emsUpperWarning
            lowerWarning = .emsLowerWarning
            lowerDanger = .emsLowerDanger
            If iCode < 1000 Then
                upperDanger = .engUpperDanger
                upperWarning = .engUpperWarning
                lowerWarning = .engLowerWarning
                lowerDanger = .engLowerDanger
            Else
                LR = CInt(Mid(iCode.ToString, 1, 1)) - 1
            End If
        End With

        ' 取得高低值
        Dim max As Integer = getMax(historyBox.SelectedValue, iCode)
        Dim low As Integer = getLow(historyBox.SelectedValue, iCode)

        If Not max = -9999 Then
            'outlinePath.AddRectangle(New Rectangle(xPos, shift + yPos + (index - 1) * 55, width * max / 100, 20))
            Dim x As Integer = xPos + (index Mod barCount) * barWidth + barWidth / 6 + LR * barWidth / 3
            Dim y As Integer = 100 + height * Math.Floor(index / barCount) + barHeight - max * barHeight / 100
            outlinePath.AddRectangle(New Rectangle(x, y, barWidth / 3, max * barHeight / 100))
            ' Drop
            If max - low > 10 Then
                e.Graphics.FillPath(Brushes.Red, outlinePath)
            ElseIf max - low > 4 Then
                e.Graphics.FillPath(Brushes.Orange, outlinePath)
            Else
                e.Graphics.FillPath(Brushes.Green, outlinePath)
            End If
            outlinePath.Reset()

            'outlinePath.AddRectangle(New Rectangle(xPos, shift + yPos + (index - 1) * 55, width * low / 100, 20))
            y = 100 + height * Math.Floor(index / barCount) + barHeight - low * barHeight / 100
            outlinePath.AddRectangle(New Rectangle(x, y, barWidth / 3, low * barHeight / 100))
            ' Result
            If max > upperDanger Or max < lowerDanger Then
                e.Graphics.FillPath(Brushes.DarkRed, outlinePath)
            ElseIf max > upperWarning Or max < lowerWarning Then
                e.Graphics.FillPath(Brushes.DarkOrange, outlinePath)
            Else
                e.Graphics.FillPath(Brushes.DarkGreen, outlinePath)
            End If
            outlinePath.Reset()

            ' 繪製文字
            Dim vertical As New Drawing2D.Matrix()
            fontsize = 18
            stringFormat.Alignment = StringAlignment.Near
            'outlinePath.AddString(max & "/" & max - low, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(xPos + 238, shift + yPos + (index - 1) * 55), stringFormat)
            outlinePath.AddString(max & "/" & max - low, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(x + barWidth / 3, 100 + height * Math.Floor(index / barCount)), stringFormat)
            vertical.RotateAt(90, New Point(x + barWidth / 3, 100 + height * Math.Floor(index / barCount)))
            outlinePath.Transform(vertical)
            e.Graphics.FillPath(Brushes.Black, outlinePath)
            e.Graphics.DrawPath(Pens.Black, outlinePath)
            outlinePath.Reset()
            outlinePath.AddString(verText(pt(iCode)), useFont.FontFamily, FontStyle.Regular, fontsize, New Point(xPos + (index Mod barCount) * barWidth + barWidth / 3, 100 + height * Math.Floor(index / barCount) + barHeight), stringFormat)
            e.Graphics.FillPath(Brushes.Black, outlinePath)
            e.Graphics.DrawPath(Pens.Black, outlinePath)
            outlinePath.Reset()
        End If
        outlinePath.Reset()
    End Sub
    '垂直文字
    Private Function verText(ByVal input As String) As String
        verText = ""
        For i = 0 To Len(input)
            If Not Mid(input, i + 1, 1) = " " Then
                verText += Mid(input, i + 1, 1) + vbNewLine
            End If
        Next
        Return verText
    End Function
    ' 列印元氣
    Private Sub printEnergy(ByRef e As Printing.PrintPageEventArgs, ByRef outlinePath As Drawing2D.GraphicsPath)


        Dim rectWidth As Integer = printDoc.DefaultPageSettings.Bounds.Width - 100
        Dim rectHeight As Integer = (printDoc.DefaultPageSettings.Bounds.Height - 150) / 2 - 20
        Dim xPos As Integer = 50
        Dim yPos As Integer = 100

        'For i = 1 To size
        '    g.DrawLine(System.Drawing.Pens.DarkGreen, New Point(i * rectSize.Width / size, 0), New Point(i * rectSize.Width / size, rectSize.Height))
        '    g.DrawLine(System.Drawing.Pens.DarkGreen, New Point(0, i * rectSize.Height / size), New Point(rectSize.Width, i * rectSize.Height / size))
        'Next

        ' 筆刷
        Dim barPen As New Pen(Brushes.Green, CSng(rectWidth / 20))
        barPen.Alignment = Drawing2D.PenAlignment.Center

        ' 四邊
        Dim top_pos As String = parseResult(getMax(historyBox.SelectedValue, 12), True)
        Dim bot_pos As String = parseResult(getMax(historyBox.SelectedValue, 3), True)
        Dim left_pos As String = parseResult(getMax(historyBox.SelectedValue, 10), True)
        Dim right_pos As String = parseResult(getMax(historyBox.SelectedValue, 5), True)
        Dim diagLeft As String = parseResult(getMax(historyBox.SelectedValue, 9), True)
        Dim diagRight As String = parseResult(getMax(historyBox.SelectedValue, 6), True)

        ' 繪製文字
        Dim useFont As Font = New Font("微軟正黑體", 20, FontStyle.Regular)
        Dim fontsize As Integer = 20
        Dim stringFormat As New StringFormat()
        stringFormat.FormatFlags = StringFormatFlags.NoClip


        If top_pos = "0" Or bot_pos = "0" Or left_pos = "0" Or right_pos = "0" Or diagLeft = "0" Or diagRight = "0" Then
            stringFormat.Alignment = StringAlignment.Center
            stringFormat.LineAlignment = StringAlignment.Center
            outlinePath.AddString("- 元氣點資料不足 -", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(xPos + rectWidth / 2, yPos + rectHeight / 2), stringFormat)

            e.Graphics.FillPath(Brushes.Black, outlinePath)
            e.Graphics.DrawPath(Pens.Black, outlinePath)
            outlinePath.Reset()
        Else
            Dim center As New Point(rectWidth / 2, rectHeight / 2)

            Dim upLeft As Double = rectWidth / 2 - rectWidth * 0.004 * top_pos
            Dim upRight As Double = rectWidth / 2 + rectWidth * 0.004 * top_pos
            Dim downLeft As Double = rectWidth / 2 - rectWidth * 0.004 * bot_pos
            Dim downRight As Double = rectWidth / 2 + rectWidth * 0.004 * bot_pos

            Dim leftUp As Double = rectHeight / 2 - rectHeight * 0.004 * left_pos
            Dim leftDown As Double = rectHeight / 2 + rectHeight * 0.004 * left_pos
            Dim rightUp As Double = rectHeight / 2 - rectHeight * 0.004 * right_pos
            Dim rightDown As Double = rectHeight / 2 + rectHeight * 0.004 * right_pos


            If (upLeft - downRight) = 0 Or (upRight - downLeft) = 0 Then
            Else
                ' m1 = (Ytl - Ybr) / (Xtl - Xbr)
                ' b1 = y - m1*x
                Dim m1 As Double = (leftUp - rightDown) / (upLeft - downRight)
                Dim b1 As Double = leftUp - m1 * upLeft
                'If Not b1 = CDbl(-rightDown - m1 * downRight) Then MsgBox("錯誤發生!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

                ' m2 = (Ytr - Ybl) / (Xtr - Xbl)
                ' b2 = y - m2*x
                Dim m2 As Double = (rightUp - leftDown) / (upRight - downLeft)
                Dim b2 As Double = rightUp - m2 * upRight
                'If Not b2 = -leftDown - m2 * -downLeft Then MsgBox("錯誤發生!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

                Dim shiftX As Double = (b2 - b1) / (m1 - m2)
                Dim shiftY As Double = m1 * shiftX + b1
                'If Not shiftY = m2 * shiftX + b2 Then MsgBox("錯誤發生!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)

                'Debug.WriteLine("Center = (" & center.X & ", " & center.Y & ") | Intercept = (" & shiftX & ", " & shiftY & ")")
                shiftX = (shiftX - center.X)
                shiftY = (shiftY - center.Y)
                'Debug.WriteLine("New Intercept = (" & shiftX & ", " & shiftY & ")")

                printLineColor(top_pos, New Point(xPos + upLeft - shiftX, yPos + rectHeight / 20),
                                       New Point(xPos + upRight - shiftX, yPos + rectHeight / 20), e, outlinePath, rectHeight / 20, True)

                printLineColor(bot_pos, New Point(xPos + downLeft - shiftX, yPos + rectHeight / 20 * 19),
                                       New Point(xPos + downRight - shiftX, yPos + rectHeight / 20 * 19), e, outlinePath, rectHeight / 20, True)

                printLineColor(left_pos, New Point(xPos + rectWidth / 20, yPos + leftUp - shiftY),
                                        New Point(xPos + rectWidth / 20, yPos + leftDown - shiftY), e, outlinePath, rectWidth / 20, True)

                printLineColor(right_pos, New Point(xPos + rectWidth / 20 * 19, yPos + rightUp - shiftY),
                                         New Point(xPos + rectWidth / 20 * 19, yPos + rightDown - shiftY), e, outlinePath, rectWidth / 20, True)

                ' 四角
                Dim topLeft As New Point(xPos + upLeft - shiftX, yPos + leftUp - shiftY)
                Dim topRight As New Point(xPos + upRight - shiftX, yPos + rightUp - shiftY)
                Dim botLeft As New Point(xPos + downLeft - shiftX, yPos + leftDown - shiftY)
                Dim botRight As New Point(xPos + downRight - shiftX, yPos + rightDown - shiftY)
                center = New Point(center.X + xPos, center.Y + yPos)

                printLineColor(CInt(getSide(topLeft, center) / getSide(topLeft, botRight) * diagLeft) * 2, topLeft, center, e, outlinePath, 5, True)    ' 左上
                printLineColor(CInt(getSide(botLeft, center) / getSide(topRight, botLeft) * diagRight) * 2, center, botLeft, e, outlinePath, 5, True)   ' 左下
                printLineColor(CInt(getSide(topRight, center) / getSide(topRight, botLeft) * diagRight) * 2, topRight, center, e, outlinePath, 5, True) ' 右上
                printLineColor(CInt(getSide(botRight, center) / getSide(topLeft, botRight) * diagLeft) * 2, center, botRight, e, outlinePath, 5, True)  ' 右下


                stringFormat.Alignment = StringAlignment.Center
                stringFormat.LineAlignment = StringAlignment.Center

                ' 左上
                outlinePath.AddString(CInt(getSide(topLeft, center) / getSide(topLeft, botRight) * diagLeft).ToString & "/" & diagLeft & vbNewLine &
                                      CInt(getSide(topLeft, center) / getSide(topLeft, botRight) * 100) & "%",
                                      useFont.FontFamily, FontStyle.Regular, fontsize, New Point(xPos + rectWidth / 4, yPos + rectHeight / 4), stringFormat)

                ' 右上
                outlinePath.AddString(CInt(getSide(topRight, center) / getSide(topRight, botLeft) * diagRight).ToString & "/" & diagRight & vbNewLine &
                                      CInt(getSide(topRight, center) / getSide(topRight, botLeft) * 100) & "%",
                                      useFont.FontFamily, FontStyle.Regular, fontsize, New Point(xPos + rectWidth - rectWidth / 4, yPos + rectHeight / 4), stringFormat)

                ' 左下
                outlinePath.AddString(CInt(getSide(botLeft, center) / getSide(topRight, botLeft) * diagRight).ToString & "/" & diagLeft & vbNewLine &
                                      CInt(getSide(botLeft, center) / getSide(topRight, botLeft) * 100) & "%",
                                      useFont.FontFamily, FontStyle.Regular, fontsize, New Point(xPos + rectWidth / 4, yPos + rectHeight - rectHeight / 4), stringFormat)

                ' 右下
                outlinePath.AddString(CInt(getSide(botRight, center) / getSide(topLeft, botRight) * diagLeft).ToString & "/" & diagRight & vbNewLine &
                                      CInt(getSide(botRight, center) / getSide(topLeft, botRight) * 100) & "%",
                                      useFont.FontFamily, FontStyle.Regular, fontsize, New Point(xPos + rectWidth - rectWidth / 4, yPos + rectHeight - rectHeight / 4), stringFormat)

                e.Graphics.FillPath(Brushes.Black, outlinePath)
                e.Graphics.DrawPath(Pens.Black, outlinePath)
                outlinePath.Reset()

            End If
        End If

        ' 格線
        outlinePath.AddLine(New Point(xPos, yPos + rectHeight / 2), New Point(xPos + rectWidth, yPos + rectHeight / 2))
        e.Graphics.DrawPath(Pens.DarkGreen, outlinePath)
        outlinePath.Reset()
        outlinePath.AddLine(New Point(xPos + rectWidth / 2, yPos), New Point(xPos + rectWidth / 2, yPos + rectHeight))
        e.Graphics.DrawPath(Pens.DarkGreen, outlinePath)
        outlinePath.Reset()
    End Sub
    ' 列印線條顏色
    Private Sub printLineColor(ByVal value As Double, ByVal pt1 As Point, ByVal pt2 As Point, ByRef e As Printing.PrintPageEventArgs,
                              ByRef outlinePath As Drawing2D.GraphicsPath, ByVal lineSize As Double, Optional ByVal useAlt As Boolean = False)

        ' 筆刷
        Dim greenPen As New Pen(Brushes.Green, CSng(lineSize))
        greenPen.Alignment = Drawing2D.PenAlignment.Center

        Dim blackPen As New Pen(Brushes.Black, CSng(lineSize))
        blackPen.Alignment = Drawing2D.PenAlignment.Center

        Dim orangePen As New Pen(Brushes.Orange, CSng(lineSize))
        orangePen.Alignment = Drawing2D.PenAlignment.Center

        Dim redPen As New Pen(Brushes.Red, CSng(lineSize))
        redPen.Alignment = Drawing2D.PenAlignment.Center

        Dim upperDanger, upperWarning, lowerWarning, lowerDanger As Integer

        With My.Settings
            upperDanger = .emsUpperDanger
            upperWarning = .emsUpperWarning
            lowerWarning = .emsLowerWarning
            lowerDanger = .emsLowerDanger
            If useAlt Then
                upperDanger = .engUpperDanger
                upperWarning = .engUpperWarning
                lowerWarning = .engLowerWarning
                lowerDanger = .engLowerDanger
            End If
        End With

        outlinePath.AddLine(pt1, pt2)

        If value = -9999 Then
            e.Graphics.DrawPath(blackPen, outlinePath)
        ElseIf value > upperDanger Or value < lowerDanger Then
            e.Graphics.DrawPath(redPen, outlinePath)
        ElseIf value > upperWarning Or value < lowerWarning Then
            e.Graphics.DrawPath(orangePen, outlinePath)
        Else
            e.Graphics.DrawPath(greenPen, outlinePath)
        End If
        outlinePath.Reset()

        greenPen.Dispose()
        blackPen.Dispose()
        orangePen.Dispose()
        redPen.Dispose()
    End Sub
    '計算邊長
    Private Function getSide(ByVal pt1 As Point, ByVal pt2 As Point) As Double
        Return Math.Sqrt(Math.Abs(pt2.X - pt1.X) ^ 2 + Math.Abs(pt2.Y - pt1.Y) ^ 2)
    End Function

#End Region

End Class