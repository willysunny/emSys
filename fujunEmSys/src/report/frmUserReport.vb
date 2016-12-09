Imports Word = Microsoft.Office.Interop.Word
Imports MySql.Data.MySqlClient

Public Class frmUserReport
    Private userInfo As frmUserQuery = Nothing
    Private pt As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 測量點

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
            .DataSource = returnData(Me, "SELECT bID, bookTime FROM patient_booking WHERE pID=" & userInfo.resultInfo.pID)
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
    Private Function getMax(ByVal hid As Integer, ByVal iCode As Integer) As Integer
        Dim max As Integer
        Dim queryStr As String = "SELECT max(`ivalue`) as `max_val` FROM ems WHERE `hid`='" & hid & "' and `iCode`='" & iCode & "' ORDER BY `iPlotCount` LIMIT 50"
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
    Private Function getLow(ByVal hid As Integer, ByVal iCode As Integer) As Integer
        Dim low As Integer
        Dim queryStr As String = "SELECT `iPlotCount`, `iValue` FROM ems WHERE `hid`='" & historyBox.SelectedValue & "' and `iCode`='" & iCode & "' ORDER BY `iPlotCount` DESC Limit 1"
        Dim reader As IDataReader = runQuery(queryStr)
        Try
            If Not reader.Read Then
                reader.Close()
                Return -9999
            Else
                If reader.GetInt32(0) > 50 Then
                    reader.Close()
                    queryStr = "SELECT * FROM ems WHERE `hid`='" & historyBox.SelectedValue & "' and `iCode`='" & iCode & "' ORDER BY `iPlotCount` DESC"
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
            oDoc.Bookmarks.Item(fieldName).Range.Font.ColorIndex = Word.WdColorIndex.wdRed
        ElseIf CInt(maxValue) > upperWarning Or CInt(maxValue) < lowerWarning Then
            oDoc.Bookmarks.Item(fieldName).Range.Font.ColorIndex = Word.WdColorIndex.wdViolet
        Else
            oDoc.Bookmarks.Item(fieldName).Range.Font.ColorIndex = Word.WdColorIndex.wdGreen
        End If
        oDoc.Bookmarks.Item(fieldName).Range.Text = maxValue
    End Sub
#End Region

    Private Sub printGraph_Click(sender As Object, e As EventArgs) Handles printGraph.Click
        If Not historyBox.SelectedIndex = -1 Then

            Try
                ' 定義Word文件
                Dim oWord As New Word.Application
                oWord = CreateObject("Word.Application")

                ' 開啟表單
                Dim oDoc As Word.Document
                oDoc = oWord.Documents.Add(Application.StartupPath & "\reportForm\reportForm.docx")

                ' 基本資訊
                oDoc.Bookmarks.Item("pID").Range.Text = userInfo.resultInfo.pID
                oDoc.Bookmarks.Item("pName").Range.Text = userInfo.resultInfo.pName
                If userInfo.resultInfo.pSex = 0 Then oDoc.Bookmarks.Item("pSex").Range.Text = "女" Else oDoc.Bookmarks.Item("pSex").Range.Text = "男"
                oDoc.Bookmarks.Item("pBDay").Range.Text = userInfo.resultInfo.pcDOB
                oDoc.Bookmarks.Item("pAge").Range.Text = Year(Now) - userInfo.resultInfo.pAge
                'oDoc.Bookmarks.Item("pCreatedDate").Range.Text = userInfo.resultInfo.pCreatedDate
                'oDoc.Bookmarks.Item("pLastVisit").Range.Text = userInfo.resultInfo.pLastVisit

                Dim colorIndex As Integer = 0
                ' 本次測量點
                For Each point As KeyValuePair(Of Integer, String) In pt
                    Debug.WriteLine(point.Key & " - " & point.Value)
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
                            If Not historyBox.SelectedIndex < historyBox.Items.Count Then setResult(oDoc, parseResult(getMax(CType(historyBox.Items(historyBox.SelectedIndex + 1), DataRowView).Row.ItemArray(0), point.Key)), point, "C" & bookmark, My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                        End If

                    Else
                        Dim maxValue As String
                        maxValue = parseResult(getMax(historyBox.SelectedValue, point.Key))
                        Dim pMaxValue As String = ""
                        If Not historyBox.SelectedIndex < historyBox.Items.Count Then pMaxValue = parseResult(getMax(CType(historyBox.Items(historyBox.SelectedIndex + 1), DataRowView).Row.ItemArray(0), point.Key))
                        Select Case point.Key
                            Case 12
                                setResult(oDoc, maxValue, point, "CE1", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If Not historyBox.SelectedIndex < historyBox.Items.Count Then setResult(oDoc, pMaxValue, point, "PE1", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            Case 3
                                setResult(oDoc, maxValue, point, "CE2", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If Not historyBox.SelectedIndex < historyBox.Items.Count Then setResult(oDoc, pMaxValue, point, "PE2", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            Case 10
                                setResult(oDoc, maxValue, point, "CE3", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If Not historyBox.SelectedIndex < historyBox.Items.Count Then setResult(oDoc, pMaxValue, point, "PE3", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            Case 5
                                setResult(oDoc, maxValue, point, "CE4", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If Not historyBox.SelectedIndex < historyBox.Items.Count Then setResult(oDoc, pMaxValue, point, "PE4", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            Case 9
                                setResult(oDoc, maxValue, point, "CE5", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If Not historyBox.SelectedIndex < historyBox.Items.Count Then setResult(oDoc, pMaxValue, point, "PE5", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                            Case 6
                                setResult(oDoc, maxValue, point, "CE6", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
                                If Not historyBox.SelectedIndex < historyBox.Items.Count Then setResult(oDoc, pMaxValue, point, "PE6", My.Settings.emsUpperDanger, My.Settings.emsUpperWarning, My.Settings.emsLowerWarning, My.Settings.emsLowerDanger)
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
                                                        WHERE Bid =" & historyBox.SelectedValue)
                For Each row As DataRow In fullMedList.Rows
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
                            times += True
                        End If

                        If .Item("noon") = True And trigger Then
                            str += "/中"
                            times += True
                        ElseIf .Item("noon") = True Then
                            str = "中"
                            times += True
                            trigger = True
                        End If

                        If .Item("night") = True And trigger Then
                            str += "/晚"
                            times += True
                        ElseIf .Item("night") = True Then
                            str = "晚"
                            times += True
                            trigger = True
                        End If

                        If .Item("beforeSleep") = True And trigger Then
                            str += "/睡前"
                            times += True
                        ElseIf .Item("beforeSleep") = True Then
                            str = "睡前"
                            times += True
                            trigger = True
                        End If

                        If .Item("notWell") = True And trigger Then
                            str += "/不適時"
                            times += True
                        ElseIf .Item("notWell") = True Then
                            str = "不適時"
                            times += True
                            trigger = True
                        End If
                        oDoc.Bookmarks.Item("medTotalAmount" & medCounter).Range.Text = (CInt(amount) * times * CInt(days)).ToString & unitName
                        oDoc.Bookmarks.Item("medTime" & medCounter).Range.Text = str

                        medCounter = medCounter + 1

                        If medCounter > 15 Then Exit For
                    End With
                Next

                '' 建議用藥
                'medCounter = 1

                'queryStr = "SELECT MI.medName, EM.medAmount, EM.medUnit, EM.medDays, EM.beforeMeal, EM.afterMeal, EM.morning, EM.noon, EM.night, EM.beforeSleep, EM.notWell, MI.medDesc FROM ems_med as EM LEFT JOIN med_item as MI ON EM.medID = MI.medID WHERE hID='" & historyBox.SelectedValue & "' AND medRecommend='1'"
                'reader = runQuery(queryStr)
                'With reader
                '    While .Read()
                '        Dim amount As String = .GetString(1)
                '        Dim times As Integer = 0
                '        Dim days As String = .GetString(3)
                '        Dim unitName As String = ""
                '        Select Case .GetDecimal(2)
                '            Case 1
                '                unitName = "克"
                '            Case 0.5
                '                unitName = "顆"
                '            Case 2
                '                unitName = "匙"
                '        End Select
                '        oDoc.Bookmarks.Item("medRecommendNameSlot" & medCounter).Range.Text = .GetString(0)
                '        oDoc.Bookmarks.Item("medRecommendNameDescSlot" & medCounter).Range.Text = .GetString(0)
                '        oDoc.Bookmarks.Item("medRecommendNameDesc" & medCounter).Range.Text = .GetString(11)
                '        oDoc.Bookmarks.Item("medRecommendAmount" & medCounter).Range.Text = amount & unitName
                '        oDoc.Bookmarks.Item("medRecommendDays" & medCounter).Range.Text = days & "天"

                '        Dim trigger As Boolean = False
                '        Dim str As String = ""
                '        If .GetBoolean(4) = True Then
                '            str = "飯前"
                '            trigger = True
                '        End If
                '        If .GetBoolean(5) And trigger Then
                '            str += "/飯後"
                '        ElseIf .GetBoolean(5) = True Then
                '            str = "飯後"
                '        End If
                '        oDoc.Bookmarks.Item("medRecommendMeal" & medCounter).Range.Text = str

                '        trigger = False
                '        str = ""
                '        If .GetInt32(6) = 1 Then
                '            str = "早"
                '            trigger = True
                '            times += True
                '        End If

                '        If .GetInt32(7) = 1 And trigger Then
                '            str += "/中"
                '            times += True
                '        ElseIf .GetInt32(7) = 1 Then
                '            str = "中"
                '            times += True
                '            trigger = True
                '        End If

                '        If .GetInt32(8) = 1 And trigger Then
                '            str += "/晚"
                '            times += True
                '        ElseIf .GetInt32(8) = 1 Then
                '            str = "晚"
                '            times += True
                '            trigger = True
                '        End If

                '        If .GetInt32(9) = 1 And trigger Then
                '            str += "/睡前"
                '            times += True
                '        ElseIf .GetInt32(9) = 1 Then
                '            str = "睡前"
                '            times += True
                '            trigger = True
                '        End If

                '        If .GetBoolean(10) And trigger Then
                '            str += "/不適時"
                '            times += True
                '        ElseIf .GetBoolean(10) Then
                '            str = "不適時"
                '            times += True
                '            trigger = True
                '        End If
                '        oDoc.Bookmarks.Item("medRecommendTotalAmount" & medCounter).Range.Text = (CInt(amount) * times * CInt(days)).ToString & unitName
                '        oDoc.Bookmarks.Item("medRecommendTime" & medCounter).Range.Text = str

                '        medCounter = medCounter + 1

                '        If medCounter > 15 Then Exit While
                '    End While
                'End With

                ' 顯示報表
                oWord.Visible = True

            Catch ex As Exception
                Debug.WriteLine(ex.Message)
            End Try
        End If
    End Sub

End Class