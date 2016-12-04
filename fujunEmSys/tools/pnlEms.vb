﻿Imports Automation.BDaq

Public Class pnlEms
    Inherits pnlSlider

    ' Events
    Public Event DEVICE_ERROR As EventHandler
    Public initiated As Boolean = False


#Region "變數"

    ' Database
    Const AryLength As Integer = 20
    Const Threshold As Integer = 3
    '
    'Dim baMeasures(299) As Byte    'Max 300 Samples/per MeasurePoint
    'Dim idxByteArray As Integer
    Dim sMeasures As String
    '
    Dim daDev(AryLength - 1) As Double '前 20 個10msec 偏離歷史記錄 array
    Dim idx As Integer '存取偏離歷史記錄陣列指標 index
    Dim iCount As Integer   '計時器
    Dim iStopCount As Integer   '停止時間計時器
    Dim iDivident As Integer    '被除數
    Dim iState As Integer   '事件進行狀態
    Dim dTotal As Double    '累加值
    Dim dFull As Double '滿刻度較正值
    Dim dOffset As Double   '偏離較正值
    Dim iFull As Integer
    Dim iOffset As Integer
    Dim bNewMeasure As Boolean
    Dim bAutoProgress As Boolean '自動選取量測點
    Dim pt As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 測量點

    '
    Dim iDoOut As Integer 'D/A 數位輸出數值
    Dim err As ErrorCode
    '
    Dim k As Double '正規化 k 值
    'Dim dMax As Double '最大值
    'Dim dDev As Double  '偏離值
    'Dim dDev1 As Double '前次偏離值
    Dim iMax As Integer '最大值
    Dim iMaxOrg As Integer  '最大值原點坐標
    Dim iDev As Integer '偏離值
    Dim iDev1 As Integer '前次偏離值
    Dim iValue1 As Integer '前次量度值
    Dim dDevRate As Double '偏離率
    Dim iDevRate As Integer ' 偏離率 (dDevRate * 1000) 取整數
    Dim iFixDevPoint As Integer '固定偏離點距
    '
    Dim bFullState As Boolean   '量滿刻度旗標
    Dim bOffsetState As Boolean '量 Offset 旗標
    Dim bDelayState As Boolean  ' Delay 旗標
    Dim bPaint As Boolean '繪圖旗標

#Region "PictureBox 繪圖變數"
    Const XMAX As Integer = 300  'X 軸最大刻度為 300 （每一刻度為 30 msec)
    Const YMAX As Integer = 100  'Y 軸最大度為 100
    Dim xPixDiv As Double ' 
    Dim yPixDiv As Double
    Dim paDrawBuffer As Point()
    Dim iPlotCount As Integer
    Dim idx1 As Integer ' paDrawBuffer insert Queue 端點指標
    Dim bmp As Bitmap
    Dim g As Graphics
    Dim myPen As Pen
#End Region

#Region "測量點"
    Dim sMainPoint As String '主量測點
    Dim sSubPoint As String '次量測點
    Dim bLR As Boolean
    Dim bHandFoot As Boolean
    Dim sFinger As String
    Dim sSub As String
    Dim iMain, iSub, iCode As Integer '主量測點值、次量測點值、代碼值
    Dim LR, HF, Finger, TB, P, S As Integer
#End Region

#Region "藥檢相關"
    Dim mainIDList As List(Of Integer)
    Dim subIDList As List(Of Integer)
    Dim medIDList As List(Of Integer)
    Dim medUnitList As List(Of String)
    Dim medMax As Integer
    Dim medCali As Boolean = True
    Dim caliberated As Boolean = False
#End Region

#Region "Conter相關"
    Dim firstChoice As String = ""
    Dim lastChoice As String = ""
    Dim lastFinger As String = ""
    Dim lastCode As String = ""
    Dim curMax As Integer
    Dim lastPt(301) As Integer
    Dim curPt(301) As Integer
    Dim dynNum As Integer = 1
    Dim dynList(6) As Integer
    Dim tickCounter As Integer = 0
    Dim printPage As Integer = 0
#End Region

#Region "SQL 相關"
    Dim sqlStr As String = "" 'sql指令串
    Dim lastSqlStr As String = "" 'sql指令串
    Dim ptCounter As Integer = 0 '
    Dim bar2iCode(60) As Integer ' Bar圖中對應點
#End Region

#End Region
#Region "繪圖"
    Private Sub pb_Paint(sender As Object, e As PaintEventArgs) Handles pb.Paint
        Dim bmp As Bitmap = New Bitmap(CType(sender, PictureBox).Size.Width, CType(sender, PictureBox).Size.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)

        g.Clear(Color.White)
        Dim i As Integer
        For i = 1 To 9
            'g.DrawLine(System.Drawing.Pens.DarkGreen, New Point(CInt(1.0 * i * ctype(sender,picturebox).Size.Width / 10), 0), New Point(CInt(1.0 * i * ctype(sender,picturebox).Size.Width / 10), ctype(sender,picturebox).Size.Height))
            g.DrawLine(System.Drawing.Pens.DarkGreen, New Point(0, CInt(1.0 * i * CType(sender, PictureBox).Size.Height / 10)), New Point(CType(sender, PictureBox).Size.Width, CInt(1.0 * i * CType(sender, PictureBox).Size.Height / 10)))
        Next
        'Change i=8 color to orange
        g.DrawLine(System.Drawing.Pens.Orange, New Point(0, CInt(1.0 * 8 * CType(sender, PictureBox).Size.Height / 10)), New Point(CType(sender, PictureBox).Size.Width, CInt(1.0 * 8 * CType(sender, PictureBox).Size.Height / 10)))
        For i = 9 To 11
            g.DrawLine(System.Drawing.Pens.Orange, New Point(0, CInt(1.0 * i * CType(sender, PictureBox).Size.Height / 20)), New Point(CType(sender, PictureBox).Size.Width, CInt(1.0 * i * CType(sender, PictureBox).Size.Height / 20)))
        Next
        If (iPlotCount > 0) Then
            Dim drawData(iPlotCount - 1) As Point

            For i = 0 To iPlotCount - 1
                drawData(i) = paDrawBuffer(i)
            Next

            If iPlotCount > 1 Then
                g.DrawLines(myPen, drawData)
            Else
                g.DrawLine(myPen, drawData(0), drawData(0))
            End If
        End If
        g.DrawLine(System.Drawing.Pens.White, New Point(0, 0), New Point(0, CType(sender, PictureBox).Size.Height))
        e.Graphics.DrawImage(bmp, New Point(0, 0))

        ' 畫文字
        Dim outlinePath As New Drawing2D.GraphicsPath
        Dim useFont As Font = New Font("微軟正黑體", 20, FontStyle.Regular)
        Dim fontsize As Integer
        Dim stringFormat As New StringFormat()
        stringFormat.FormatFlags = StringFormatFlags.NoClip
        stringFormat.Alignment = StringAlignment.Far

        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        fontsize = 30

        outlinePath.AddString(getTime(tickCounter), useFont.FontFamily, FontStyle.Regular, fontsize, New Point(CType(sender, PictureBox).Width, 0), stringFormat)
        useFont.Dispose()

        e.Graphics.FillPath(Brushes.LightGray, outlinePath)
        e.Graphics.TranslateTransform(-1, -1)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        e.Graphics.TranslateTransform(1, 1)
        outlinePath.Dispose()
    End Sub
    ' 轉算時間
    Private Function getTime(ByVal tick As Integer) As String
        Dim result As Double = CDbl(tick) / 1000 * 15
        Return FormatNumber(Math.Round(result, 1), 1)
    End Function
#End Region
#Region "頻譜測量"
    Private Sub emsTimer_Tick(sender As Object, e As EventArgs) Handles emsTimer.Tick
        Dim dValue As Double
        Dim iValue As Integer
        Dim iDoOut As Integer
        Dim dRadians As Double
        Dim dAngle As Double

        Select Case iState
            Case 0
                If (bFullState = False) Then
                    iDoOut = 1
                    err = InstantDoCtrl1.Write(0, CByte(iDoOut))
                    bFullState = True
                End If
                If (bDelayState = True) Then
                    iCount = iCount - 1
                    If (iCount > 0) Then
                        Return
                    Else
                        bDelayState = False
                    End If
                    iCount = 20 'for cal full valus
                    iDivident = iCount
                End If
                err = InstantAiCtrl1.Read(0, dValue)
                If err <> ErrorCode.Success Then
                    HandleError(err)
                Else
                    dTotal = dTotal + dValue
                    iCount = iCount - 1
                    If iCount = 0 Then
                        dValue = dTotal / iDivident
                        dFull = dValue
                        txtFullValue.Text = dFull

                        iCount = 20 'for delay 1 sec
                        dTotal = 0
                        iState = 1 '進入 offset state
                        bFullState = False
                        bDelayState = True
                    End If
                End If

            Case 1
                If (bOffsetState = False) Then
                    iDoOut = 2
                    err = InstantDoCtrl1.Write(0, CByte(iDoOut))
                    bFullState = True
                End If
                If (bDelayState = True) Then
                    iCount = iCount - 1
                    If (iCount > 0) Then
                        Return
                    Else
                        bDelayState = False
                    End If
                    iCount = 20  'for cal offset
                    iDivident = iCount

                End If
                err = InstantAiCtrl1.Read(0, dValue)
                If err <> ErrorCode.Success Then
                    HandleError(err)
                Else
                    dTotal = dTotal + dValue - dOffset
                    iCount = iCount - 1
                    If iCount = 0 Then
                        dValue = dTotal / iDivident
                        dOffset = dValue
                        txtOffsetValue.Text = dOffset
                        iCount = 3  'for  normal measurement
                        iDivident = iCount
                        dTotal = 0
                        iDoOut = 0
                        err = InstantDoCtrl1.Write(0, CByte(iDoOut))
                        iState = 2 '進入量測 state
                        k = (dFull - dOffset) / 100 '計算 k 值
                        If (k = 0) Then
                            txtFullValue.Text = 999
                            txtOffsetValue.Text = 0
                            k = 99999
                        Else
                            iFull = CInt(dFull / k)
                            iOffset = CInt(dOffset / k)
                            txtFullValue.Text = iFull
                            txtOffsetValue.Text = iOffset
                        End If
                        lblCali.Text = "量度"
                        lblCali.ForeColor = Color.Green
                        btnRevise.ForeColor = Color.Green
                    End If
                End If

            Case 2
                err = InstantAiCtrl1.Read(0, dValue)
                If err <> ErrorCode.Success Then
                    HandleError(err)
                Else

                    dTotal = dTotal + dValue - dOffset
                    iCount = iCount - 1
                    tickCounter = tickCounter + 1
                    If iCount = 0 Then
                        '正規化後轉整數
                        dValue = dTotal / (iDivident * k)
                        iValue = CInt(dValue)

                        If (dValue <= Threshold) Then
                            iStopCount = 0
                            iState = 3
                            bPaint = False '停止繪圖及量度顯示
                            Return
                        Else
                            bPaint = True
                            If bNewMeasure Then
                                sMeasures = ""
                                bNewMeasure = False
                            End If
                        End If
                        ' cal 最大值
                        If (iValue > 100) Then iValue = 100
                        If (iMax < iValue) Then
                            iMax = iValue
                            iMaxOrg = idx1
                        End If

                        ' cal 遍差值
                        iDev = iMax - iValue
                        If (iDev >= 15) Then '更換為前一次偏差值及量度值
                            iDev = GetDevValue()
                            iValue = iMax - iDev
                        Else
                            iDev1 = iDev
                        End If
                        'PutByteArray(iValue)
                        PutMeasures(iValue)
                        PutDevArray()

                        If ((idx1 - iMaxOrg) = iFixDevPoint) Then
                            '計算偏墜角
                            dDevRate = (iMax - iValue) / (idx1 - iMaxOrg)
                            dRadians = Math.Atan(dDevRate)
                            dAngle = dRadians * (180 / Math.PI)

                        End If
                        iValue1 = iValue
                        '
                        ' Display 量度值最大值遍差值
                        '
                        txtEvaValue.Text = iValue
                        '| txtLargeEvaValue.Text = iValue
                        '| txtMedLargeEvaValue.Text = iValue
                        If iValue > medMax Then
                            '| txtMedLargeEvaValue.ForeColor = Color.Red
                        Else
                            '| txtMedLargeEvaValue.ForeColor = Color.Green
                        End If
                        If medCali Then
                            If iMax > 50 Then
                                '| cigMax.Text = 50
                            Else
                                '| cigMax.Text = iMax
                            End If
                            caliberated = True
                        End If
                        txtMaxValue.Text = iMax
                        '| txtLargeMaxValue.Text = iMax
                        txtDevValue.Text = iDev
                        '| txtLargeDevValue.Text = iDev

                        If (iMax > 100) Then iMax = 100
                        If iMax < 0 Then iMax = 0
                        '
                        If (iDev > 15) Then iDev = 15
                        If iDev < 0 Then iDev = 0
                        '
                        If bPaint Then DoChart(iValue)
                        '
                        iCount = 3
                        dTotal = 0
                    End If
                End If
            Case 3
                err = InstantAiCtrl1.Read(0, dValue)
                If err <> ErrorCode.Success Then
                    HandleError(err)
                Else
                    If (dValue >= Threshold) Then
                        iStopCount = 0
                        iCount = 3
                        dTotal = 0
                        iState = 2
                        Return
                    End If
                    iStopCount += 1
                    iValue = CInt(dValue)
                    If (iValue > 100) Then iValue = 100
                    If iValue < 0 Then iValue = 0

                    If (iStopCount > 10) Then
                        iMax = 0
                        iDev = 0
                        iDev1 = 0
                        dTotal = 0
                        iCount = 3
                        iStopCount = 0
                        idx1 = 0
                        tickCounter = 0
                        'txtFixDevRate.Text = 0 'prepare 重新量度時固定量度偏離值顯示歸零
                        If sMeasures.Length > 3 Then
                            '|
                            'If emsTabs.SelectedTab.Name = "tabMed" Then
                            '    If medCali And caliberated Then
                            '        emsTimer.Enabled = False
                            '        If curMax > 50 Then
                            '            medMax = 50
                            '        Else
                            '            medMax = curMax
                            '        End If
                            '        cigMax.Text = medMax.ToString
                            '        medCali = False
                            '        emsTimer.Enabled = True
                            '    ElseIf OperateControl.SelectedTab.Name = "medCheck" Then
                            '        If medCheckGrid.Rows.Count > 0 Then
                            '            medCheckGrid.Rows(medCheckGrid.Rows.Count - 1).Cells("medTestValue").Value = txtMedLargeEvaValue.Text
                            '        End If
                            '    End If
                            'Else
                            If graphTab.SelectedTab.Name = "tabEnergy" And curMax < 15 Then
                                ' Do Nothing
                            ElseIf curMax >= My.Settings.autoSaveTrigger Then
                                emsTimer.Enabled = False
                                If Not lastSqlStr = "" And Not mainForm.offlineMode Then
                                    SaveRecord()
                                End If
                                If graphTab.SelectedTab.Name = "tabEms" Then
                                    ClickNextMeasurePoint()
                                End If
                                emsTimer.Enabled = True
                            Else
                                Array.Copy(curPt, lastPt, curPt.Length)
                                lastSqlStr = sqlStr
                                sqlStr = ""
                                sMeasures = ""
                                bNewMeasure = True
                            End If
                            'End If
                        End If

                        curMax = 0
                        iPlotCount = 0
                        ptCounter = 0
                        iState = 2
                    End If
                End If
        End Select
    End Sub
    ' 偵錯
    Private Sub HandleError(ByVal err As ErrorCode)
        If err <> ErrorCode.Success Then
            'iErr = iErr + 1
            emsTimer.Stop()
            MessageBox.Show("Sorry ! 請檢查輸入設備後再試, the error code is: " & err.ToString(), "InstantAI")
            emsTimer.Start()
        End If

    End Sub
    ' 取得偏差值
    Private Function GetDevValue() As Double
        Dim i As Integer
        i = txtPrevsDev.Text
        i = idx - i
        If i < 0 Then
            i = i + AryLength
        End If
        Return daDev(i)
    End Function

    ' 紀錄量測值
    Private Sub PutMeasures(iValue As Integer)
        sMeasures = sMeasures & iValue & ","
        'baMeasures(idxByteArray) = iValue
        'idxByteArray = idxByteArray + 1
        'If idxByteArray = 300 Then
        '    idxByteArray = 0
        'End If
    End Sub
    ' 偏差值
    Private Sub PutDevArray()
        daDev(idx) = iDev
        idx = idx + 1
        If idx = AryLength Then
            idx = 0
        End If
    End Sub
    ' 繪圖
    Private Sub DoChart(ByVal dValue As Double)
        Dim iValue As Integer
        iValue = CInt(dValue)
        paDrawBuffer(idx1).Y = (YMAX - iValue) * yPixDiv
        paDrawBuffer(idx1).X = idx1 * xPixDiv
        If iValue > curMax Then curMax = iValue
        curPt(ptCounter) = iValue
        iPlotCount = iPlotCount + 1
        'ptCounter = ptCounter + 1
        ptCounter = iPlotCount
        idx1 = (idx1 + 1) Mod (XMAX + 1)
        sqlStr = sqlStr & "(' " & mainForm.patientHistory.hID & "','" & iCode & "','" & ptCounter & "','" & dValue & "'),"
        pb.Invalidate()
        Me.Refresh()
        If iPlotCount > XMAX Then
            iPlotCount = iPlotCount Mod (XMAX + 1)
            iState = 2
        End If
    End Sub
    ' 儲存至SQL
    Private Sub SaveRecord()


        ' 檢查重複資訊
        Try
            Dim reader As IDataReader = runQuery("SELECT count(`icode`) FROM ems WHERE `hid`='" & mainForm.patientHistory.hID & "' AND `iCode`='" & iCode & "'")
            reader.Read()
            If Not reader.GetInt64(0) = 0 Then
                reader.Close()
                runQuery("DELETE FROM `ems` WHERE `hid`='" & mainForm.patientHistory.hID & "' and `iCode`='" & iCode & "'")
                runQuery("INSERT INTO ems(hID, iCode, iPlotCount, iValue) VALUES " & Mid(lastSqlStr, 1, Len(lastSqlStr) - 1))
            Else
                reader.Close()
                runQuery("INSERT INTO ems(hID, iCode, iPlotCount, iValue) VALUES " & Mid(lastSqlStr, 1, Len(lastSqlStr) - 1))
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.ToString())
        End Try
        Me.Refresh()
    End Sub
#End Region
#Region "測量點鍵盤"
    Private Sub iCode2Btn(ByVal iCode As Integer)
        If iCode < 1000 Then
            ' 元氣
            rdoEnergy.Checked = True
            Select Case iCode
                Case 12
                    rdoUpLeft.Checked = True
                    rdoUpRight.Checked = True
                Case 3
                    rdoDownLeft.Checked = True
                    rdoDownRight.Checked = True
                Case 10
                    rdoUpLeft.Checked = True
                    rdoDownLeft.Checked = True
                Case 5
                    rdoUpRight.Checked = True
                    rdoDownRight.Checked = True
                Case 9
                    rdoUpLeft.Checked = True
                    rdoDownRight.Checked = True
                Case 6
                    rdoUpRight.Checked = True
                    rdoDownLeft.Checked = True
            End Select
        Else
            '頻譜
            rdoGraph.Checked = True

            ' 左右
            If Mid(iCode.ToString, 1, 1) = "1" Then rdoLeft.Checked = True Else rdoRight.Checked = True

            ' 手腳
            If Mid(iCode.ToString, 2, 1) = "1" Then rdoHand.Checked = True Else rdoFoot.Checked = True

            ' 手指
            Select Case Mid(iCode.ToString, 3, 1)
                Case "1"
                    rdoF1.Checked = True
                Case "2"
                    rdoF2.Checked = True
                Case "3"
                    rdoF3.Checked = True
                Case "4"
                    rdoF4.Checked = True
                Case "5"
                    rdoF5.Checked = True
            End Select

            ' 內外側
            If Mid(iCode.ToString, 4, 1) = "1" Then rdoS1.Checked = True Else rdoS2.Checked = True

            ' 量測點
            Select Case Mid(iCode.ToString, 5, 1)
                Case "1"
                    rdoC1.Checked = True
                Case "2"
                    rdoC2.Checked = True
                Case "3"
                    rdoC3.Checked = True
                Case "4"
                    rdoC4.Checked = True
                Case "5"
                    rdoC5.Checked = True
                Case "6"
                    rdoC6.Checked = True
            End Select

            ' 結石
            Select Case Mid(iCode.ToString, 6, 1)
                Case "0"
                    rdoStone.Checked = False
                Case "1"
                    rdoStone.Checked = True
            End Select
        End If
    End Sub
    Public Function btn2iCode() As Integer
        Dim iCode As Integer = ""

        ' 判定哪個選項被選取
        If rdoGraph.Checked Then
            ' 定義變數
            Dim LR As String = ""
            Dim HF As String = ""
            Dim Finger As String = ""
            Dim TB As String = ""
            Dim P As String = ""
            Dim S As String = ""

            If rdoLeft.Checked Then
                LR = 1
            ElseIf rdoRight.Checked Then
                LR = 2
            End If

            If rdoHand.Checked Then
                HF = 1
            ElseIf rdoFoot.Checked Then
                HF = 2
            End If

            If rdoF1.Checked Then
                Finger = 1
            ElseIf rdoF2.Checked Then
                Finger = 1
            ElseIf rdoF3.Checked Then
                Finger = 2
            ElseIf rdoF4.Checked Then
                Finger = 2
            ElseIf rdoF5.Checked Then
                Finger = 5
            End If

            If rdoS1.Checked Then
                TB = 1
            ElseIf rdoS2.Checked Then
                TB = 2
            End If

            If rdoC1.Checked Then
                P = 1
            ElseIf rdoC2.Checked Then
                P = 2
            ElseIf rdoC3.Checked Then
                P = 3
            ElseIf rdoC4.Checked Then
                P = 4
            ElseIf rdoC5.Checked Then
                P = 5
            ElseIf rdoC6.Checked Then
                P = 6
            End If

            If rdoStone.Checked Then
                S = 1
            Else
                S = 0
            End If
            iCode = LR & HF & Finger & TB & P & S
        ElseIf rdoEnergy.Checked Then
            ' 元氣值得量測方式
            Dim a, b, c, d As String
            If rdoUpLeft.Checked Then a = "1" Else a = "0"
            If rdoUpRight.Checked Then b = "1" Else b = "0"
            If rdoDownLeft.Checked Then c = "1" Else c = "0"
            If rdoDownRight.Checked Then d = "1" Else d = "0"

            ' 將四個點用Bit方式然後轉換成Int
            iCode = Convert.ToInt32(a & b & c & d, 2)
        End If
        Return iCode
    End Function
    ' 點選下一個
    Private Sub ClickNextMeasurePoint()
        If LR = 1 And HF = 2 And Finger = 5 And TB = 2 And rdoC5.Checked Then
            iCode2Btn(125240)
        ElseIf LR = 2 And HF = 2 And Finger = 1 And TB = 1 And rdoC5.Checked Then
            iCode2Btn(221130)
        ElseIf LR = 2 And HF = 2 And Finger = 5 And TB = 2 And rdoC5.Checked Then
            iCode2Btn(225240)
        Else
            If TB = 2 Then
                If Finger = 5 Then
                    If LR = 2 Then
                        If HF = 2 Then
                            LR = 1
                            HF = 1
                            Finger = 1
                            TB = 1
                        Else
                            LR = 1
                            HF = 2
                        End If
                    Else
                        LR = 2
                    End If
                    Finger = 1
                Else
                    Finger += 1
                End If
                TB = 1
            Else
                TB = 2
            End If
            iCode2Btn(CInt(CStr(LR) & CStr(HF) & CStr(Finger) & CStr(TB) & "50"))
        End If
    End Sub
    Private Sub getMeasurePoint()
        Dim sMsg As String = ""

        If rdoGraph.Checked Then
            ' 判定哪個選項被選取
            If rdoLeft.Checked Then
                LR = 1
            ElseIf rdoRight.Checked Then
                LR = 2
            End If

            If rdoHand.Checked Then
                HF = 1
            ElseIf rdoFoot.Checked Then
                HF = 2
            End If

            If rdoF1.Checked Then
                Finger = 1
            ElseIf rdoF2.Checked Then
                Finger = 2
            ElseIf rdoF3.Checked Then
                Finger = 3
            ElseIf rdoF4.Checked Then
                Finger = 4
            ElseIf rdoF5.Checked Then
                Finger = 5

            End If

            If rdoS1.Checked Then
                TB = 1
            ElseIf rdoS2.Checked Then
                TB = 2
            End If

            If rdoC1.Checked Then
                P = 1
            ElseIf rdoC2.Checked Then
                P = 2
            ElseIf rdoC3.Checked Then
                P = 3
            ElseIf rdoC4.Checked Then
                P = 4
            ElseIf rdoC5.Checked Then
                P = 5
            ElseIf rdoC6.Checked Then
                P = 6
            End If

            If rdoStone.Checked Then
                S = 1
            Else
                S = 0
            End If

            ' 轉換成代碼並檢查是否有在初始定義的清單內
            ' 若無 (KeyNotFoundException), 則依照實際點選的點來告知
            Try
                iCode = CInt(CStr(LR) + CStr(HF) + CStr(Finger) + CStr(TB) + CStr(P) + CStr(S))
                sMsg = pt.Item(iCode)
                Dim fullPoint As String = ""
                Select Case LR
                    Case 1
                        fullPoint = "左"
                    Case 2
                        fullPoint = "右"
                    Case Else
                        fullPoint = "未知方向"
                End Select
                Select Case HF
                    Case 1
                        fullPoint += "手"
                    Case 2
                        fullPoint += "腳"
                    Case Else
                        fullPoint += "-未知部位"
                End Select
                Select Case Finger
                    Case 1
                        fullPoint += "拇指"
                    Case 2
                        fullPoint += "食指"
                    Case 3
                        fullPoint += "中指"
                    Case 4
                        fullPoint += "無名指"
                    Case 5
                        fullPoint += "小指"
                    Case Else
                        fullPoint += "-未知指頭"
                End Select
                Select Case TB
                    Case 1
                        fullPoint += "外側"
                    Case 2
                        fullPoint += "內側"
                    Case Else
                        fullPoint += "-未知邊"
                End Select
                Select Case P
                    Case 1
                        fullPoint += "頭"
                    Case 2
                        fullPoint += "頂"
                    Case 3
                        fullPoint += "上焦"
                    Case 4
                        fullPoint += "中焦"
                    Case 5
                        fullPoint += "總量度點"
                    Case 6
                        fullPoint += "下焦"
                    Case Else
                        fullPoint += "-未知量度點"
                End Select
                measurePoint.Text = "量度點 [" & fullPoint & "]"
            Catch ex As KeyNotFoundException
                Dim fullPoint As String = ""
                Select Case LR
                    Case 1
                        fullPoint = "左"
                    Case 2
                        fullPoint = "右"
                    Case Else
                        fullPoint = "未知方向"
                End Select
                Select Case HF
                    Case 1
                        fullPoint += "手"
                    Case 2
                        fullPoint += "腳"
                    Case Else
                        fullPoint += "-未知部位"
                End Select
                Select Case Finger
                    Case 1
                        fullPoint += "拇指"
                    Case 2
                        fullPoint += "食指"
                    Case 3
                        fullPoint += "中指"
                    Case 4
                        fullPoint += "無名指"
                    Case 5
                        fullPoint += "小指"
                    Case Else
                        fullPoint += "-未知指頭"
                End Select
                Select Case TB
                    Case 1
                        fullPoint += "外側"
                    Case 2
                        fullPoint += "內側"
                    Case Else
                        fullPoint += "-未知邊"
                End Select
                Select Case P
                    Case 1
                        fullPoint += "頭"
                    Case 2
                        fullPoint += "頂"
                    Case 3
                        fullPoint += "上焦"
                    Case 4
                        fullPoint += "中焦"
                    Case 5
                        fullPoint += "總量度點"
                    Case 6
                        fullPoint += "下焦"
                    Case Else
                        fullPoint += "-未知量度點"
                End Select
                If rdoStone.Checked Then fullPoint = "[結石]" & fullPoint
                sMsg = fullPoint
                measurePoint.Text = "量度點 [" & fullPoint & "]"
            End Try
        Else
            ' 元氣值得量測方式
            Dim a, b, c, d As String
            If rdoUpLeft.Checked Then a = "1" Else a = "0"
            If rdoUpRight.Checked Then b = "1" Else b = "0"
            If rdoDownLeft.Checked Then c = "1" Else c = "0"
            If rdoDownRight.Checked Then d = "1" Else d = "0"

            ' 將四個點用Bit方式然後轉換成Int
            iCode = Convert.ToInt32(a & b & c & d, 2)
            Try
                sMsg = pt.Item(iCode)
            Catch ex As KeyNotFoundException
                sMsg = "未知位置"
            End Try

        End If
    End Sub
#End Region
#Region "測試"
    ' 校正
    Private Sub btnRevise_Click(sender As Object, e As EventArgs)
        btnRevise.ForeColor = Color.Orange
        lblCali.ForeColor = Color.Orange
        txtFullValue.Text = 0
        txtOffsetValue.Text = 0
        txtEvaValue.Text = 0
        txtMaxValue.Text = 0
        txtDevValue.Text = 0
        init()
    End Sub
    ' 測試
    Private Sub btnTrigger_Click(sender As Object, e As EventArgs) Handles btnTrigger.Click
        If (iDoOut = 0) Then
            iDoOut = 4
            err = InstantDoCtrl1.Write(0, CByte(iDoOut))
            btnTrigger.ForeColor = Color.Orange
            MsgBox("啟動激發：輸出 00000100 至 DO port 成功!")
        Else
            iDoOut = 0
            err = InstantDoCtrl1.Write(0, CByte(iDoOut))
            btnTrigger.ForeColor = Color.Green
            MsgBox("清除激發：輸出 00000000 至 DO port 成功!")
        End If
    End Sub
    ' 關閉小鍵盤
    Private Sub okLink_Click(sender As Object, e As EventArgs) Handles okLink.Click
        buttonPanel.Visible = False
    End Sub
    ' 開啟小鍵盤
    Private Sub openPanelLink_Click(sender As Object, e As EventArgs) Handles openPanelLink.Click
        buttonPanel.Visible = True
    End Sub

#End Region
#Region "初始"
    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()


        ' Add any initialization after the InitializeComponent() call.
        If Not InstantAiCtrl1.Initialized Then
            RaiseEvent DEVICE_ERROR(Me, New EventArgs)
        Else
            ConfigObjs()
            init()
            initiated = True
        End If

    End Sub
    Private Sub ConfigObjs()

        If Not mainForm.offlineMode Then
            pName.Text = mainForm.patientInfo.pName
            If mainForm.patientInfo.pSex = 0 Then
                pSex.Text = "女"
            Else

                pSex.Text = "男"
            End If
            'Label36.Text = Year(Now) - Year(mainForm.patientInfo.pDOB)
        Else
            diagTab.TabPages.Remove(tabMed)
            'emsTabs.TabPages.Remove(tabEnergy)
            'emsTabs.TabPages.Remove(tabDetail)
            'emsTabs.TabPages.Remove(tabPreview)
        End If

        '固定偏離點值
        iFixDevPoint = txtFixDevPoint.Text

        'picturebox
        myPen = New Pen(Color.Red, 2) 'creates a red pen with a thickness of 2
        paDrawBuffer = New Point(XMAX) {}
        xPixDiv = (pb.Size.Width / XMAX)
        yPixDiv = (pb.Size.Height / YMAX)
        pName.Text = mainForm.patientInfo.pName

        '' 對應設定值
        'emsNorm.Text = My.Settings.emsNormalValue
        'emsRange.Text = My.Settings.emsNormalRange
        'emsCritical.Text = My.Settings.emsCriticalValue
        'energyNorm.Text = My.Settings.energyNormalValue
        'energyRange.Text = My.Settings.energyNormalRange
        'energyCritical.Text = My.Settings.energyCriticalValue

        ' 各個點的代碼以及名稱
        ' 元氣部分是以四個bit分別代表 - 左上, 右上, 左下, 右下, 然後取其Int值
        ' 其他部位則是以五位數字來分別代表以下意思
        ' 第一位數字  - 左邊(1)或右邊(2)
        ' 第二位數字  - 手(1)或腳(2)
        ' 第三位數字  - 拇指(1), 食指(2), 中指(3), 無名指(4), 小指(5)
        ' 第四位數字  - 外側(1)或內側(2)
        ' 第五位數字  - 頂(1), 頭(2), 上焦(3), 中焦(4), 總量度點(5), 下焦(6)

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

        ' 舊的點設定
        bar2iCode(1) = 111150
        bar2iCode(2) = 111250
        bar2iCode(3) = 112150
        bar2iCode(4) = 112250
        bar2iCode(5) = 113150
        bar2iCode(6) = 113250
        bar2iCode(7) = 114150
        bar2iCode(8) = 114250
        bar2iCode(9) = 115150
        bar2iCode(10) = 115250
        bar2iCode(11) = 211150
        bar2iCode(12) = 211250
        bar2iCode(13) = 212150
        bar2iCode(14) = 212250
        bar2iCode(15) = 213150
        bar2iCode(16) = 213250
        bar2iCode(17) = 214150
        bar2iCode(18) = 214250
        bar2iCode(19) = 215150
        bar2iCode(20) = 215250
        bar2iCode(21) = 121150
        bar2iCode(22) = 121250
        bar2iCode(23) = 122150
        bar2iCode(24) = 122250
        bar2iCode(25) = 123150
        bar2iCode(26) = 123250
        bar2iCode(27) = 124150
        bar2iCode(28) = 124250
        bar2iCode(29) = 125150
        bar2iCode(30) = 125250
        bar2iCode(31) = 221150
        bar2iCode(32) = 221250
        bar2iCode(33) = 222150
        bar2iCode(34) = 222250
        bar2iCode(35) = 223150
        bar2iCode(36) = 223250
        bar2iCode(37) = 224150
        bar2iCode(38) = 224250
        bar2iCode(39) = 225150
        bar2iCode(40) = 225250

        bar2iCode(41) = 12
        bar2iCode(42) = 3
        bar2iCode(43) = 10
        bar2iCode(44) = 5
        bar2iCode(45) = 9
        bar2iCode(46) = 6
        bar2iCode(47) = 115130
        bar2iCode(48) = 225240
        bar2iCode(49) = 125240

        graphTab.SelectTab(tabEnergy)

        ' 將量度點新增至下拉選單
        Dim ptTable As DataTable = New DataTable()
        ptTable.Columns.Add("iCode", GetType(Integer))
        ptTable.Columns.Add("測量點", GetType(String))
        For Each point As KeyValuePair(Of Integer, String) In pt
            If point.Key > 1000 Then
                If Mid(point.Key, 1, 1) = "1" Then ptTable.Rows.Add(point.Key, "[左] " & point.Value) Else ptTable.Rows.Add(point.Key, "[右] " & point.Value)
            Else
                ptTable.Rows.Add(point.Key, point.Value)
            End If
        Next
        ptBox.DataSource = ptTable
        ptBox.DisplayMember = "測量點"
        ptBox.ValueMember = "iCode"

    End Sub
    Private Sub init()
        '
        sMeasures = ""
        bNewMeasure = True
        bAutoProgress = False
        '
        iDoOut = 0
        idx = 0
        iCount = 100   ' for delay 1 sec
        iStopCount = 0
        dTotal = 0
        dFull = 100
        dOffset = 0
        iValue1 = 0
        dDevRate = 0
        iMax = 0
        iMaxOrg = 0 '最大值原點坐標
        iDev = 0
        iDev1 = 0
        iState = 0
        bFullState = False
        bOffsetState = False
        bDelayState = True
        lblCali.Text = "校正"
        '
        bPaint = False
        idx1 = 0
        iPlotCount = 0
        ptCounter = 0
        sqlStr = ""
        '
        bHandFoot = True
        bLR = True
        sFinger = "rdoF1"
        sSub = "rdoC2"
        getMeasurePoint()
        emsTimer.Enabled = True
    End Sub

#End Region
End Class
