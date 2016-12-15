Imports Automation.BDaq
Imports MySql.Data.MySqlClient

Public Class pnlEms
    Inherits pnlSlider

    ' Events
    Public Event DEVICE_ERROR As EventHandler
    Public initiated As Boolean = False


#Region "變數"

    Dim tempTrigger As Boolean = True

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
    Private patientInfo As pInfo

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
            Throw New Exception("Initialization Failed")
        Else
            ConfigObjs()
            init()

            If mainForm.offlineMode Then
                diagTab.TabPages.Remove(tabMed)
                patientTab.TabPages.Remove(tabBooking)
            Else
                Dim sql As String = "SELECT pb.bID, INSERT(pi.pname, 2, 1, '○') as 'patientName'
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
            End If

            initiated = True
        End If

    End Sub
    Private Sub ConfigObjs()

        '固定偏離點值
        iFixDevPoint = txtFixDevPoint.Text

        'picturebox
        myPen = New Pen(Color.Red, 2) 'creates a red pen with a thickness of 2
        paDrawBuffer = New Point(XMAX) {}
        xPixDiv = (txtDevValue.Size.Width / XMAX)
        yPixDiv = (txtDevValue.Size.Height / YMAX)
        pName.Text = mainForm.patientInfo.pName

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

        graphTab.SelectTab(tabEms)

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
#Region "載入病患資料"
    ' 
    Private Sub waitingList_Click(sender As Object, e As EventArgs) Handles waitingList.Click
        If Not waitingList.SelectedIndex = -1 Then
            loadPatientData(waitingList.SelectedValue)
            patientTab.SelectedTab = tabPatientInfo
            pName.Text = patientInfo.pName
            If patientInfo.pSex = 0 Then pSex.Text = "女" Else pSex.Text = "男"
            pAge.Text = patientInfo.pAge
        End If
    End Sub
    Private Sub loadPatientData(ByVal bID As Integer)
        patientInfo = New pInfo
        patientInfo.initiate(bID2pID(bID))
        pPrevVisit.Text = patientInfo.pLastVisit
        pVisitTimes.Text = patientInfo.pVisitCount
    End Sub
    Private Function bID2pID(ByVal bID As Integer) As Integer
        Dim reader As IDataReader = runQuery("SELECT pID FROM patient_booking where bID=" & bID & " LIMIT 1")
        reader.Read()
        Return reader.GetInt32(0)
    End Function
#End Region
#Region "繪圖"
    ' 切換分頁
    Private Sub graphTab_TabIndexChanged(sender As Object, e As EventArgs) Handles graphTab.TabIndexChanged
        txtDevValue.Refresh()
    End Sub
    Private Sub graphTab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles graphTab.SelectedIndexChanged
        txtDevValue.Refresh()
    End Sub
    Private Sub tabEms_GotFocus(sender As Object, e As EventArgs) Handles tabEms.GotFocus
        txtDevValue.Refresh()
    End Sub
    ' 主畫面
    Private Sub pb_Paint(sender As Object, e As PaintEventArgs) Handles pb.Paint
        Dim bmp As Bitmap = New Bitmap(CType(sender, PictureBox).Size.Width, CType(sender, PictureBox).Size.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.Clear(Color.White)
        If graphTab.SelectedTab.Name = "tabEms" Then
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
        ElseIf graphTab.SelectedTab.Name = "tabEnergy" Then
            'For i = 1 To size
            '    g.DrawLine(System.Drawing.Pens.DarkGreen, New Point(i * pb.Size.Width / size, 0), New Point(i * pb.Size.Width / size, pb.Size.Height))
            '    g.DrawLine(System.Drawing.Pens.DarkGreen, New Point(0, i * pb.Size.Height / size), New Point(pb.Size.Width, i * pb.Size.Height / size))
            'Next
            ' 筆刷
            Dim barPen As New Pen(Brushes.Green, CSng(txtDevValue.Width / 20))
            barPen.Alignment = Drawing2D.PenAlignment.Center

            If Not mainForm.offlineMode Then
                ' 四邊
                top_pos.Text = parseResult(getMax(waitingList.SelectedValue, 12), True)
                bot_pos.Text = parseResult(getMax(waitingList.SelectedValue, 3), True)
                left_pos.Text = parseResult(getMax(waitingList.SelectedValue, 10), True)
                right_pos.Text = parseResult(getMax(waitingList.SelectedValue, 5), True)
                diagLeft.Text = parseResult(getMax(waitingList.SelectedValue, 9), True)
                diagRight.Text = parseResult(getMax(waitingList.SelectedValue, 6), True)
            End If

            If top_pos.Text = "" Or bot_pos.Text = "" Or left_pos.Text = "" Or right_pos.Text = "" Or diagLeft.Text = "" Or diagRight.Text = "" Then
            ElseIf top_pos.Text = "0" Or bot_pos.Text = "0" Or left_pos.Text = "0" Or right_pos.Text = "0" Or diagLeft.Text = "0" Or diagRight.Text = "0" Then
            Else

                Dim center As New Point(txtDevValue.Width / 2, txtDevValue.Height / 2)
                'drawLineColor(-9999, New Point(pb.Width / 2 - pb.Width / 2 * 0.8, pb.Height / 20), New Point(pb.Width / 2 + pb.Width / 2 * 0.8, pb.Height / 20), g, pb.Width / 20)
                'drawLineColor(-9999, New Point(pb.Width / 2 - pb.Width / 2 * 0.8, pb.Height / 20 * 19), New Point(pb.Width / 2 + pb.Width / 2 * 0.8, pb.Height / 20 * 19), g, pb.Width / 20)
                'drawLineColor(-9999, New Point(pb.Width / 20, pb.Height / 2 - pb.Height / 2 * 0.8), New Point(pb.Width / 20, pb.Height / 2 + pb.Height / 2 * 0.8), g, pb.Height / 20)
                'drawLineColor(-9999, New Point(pb.Width / 20 * 19, pb.Height / 2 - pb.Height / 2 * 0.8), New Point(pb.Width / 20 * 19, pb.Height / 2 + pb.Height / 2 * 0.8), g, pb.Height / 20)

                Dim upLeft As Double = txtDevValue.Width / 2 - txtDevValue.Width * 0.004 * top_pos.Text
                Dim upRight As Double = txtDevValue.Width / 2 + txtDevValue.Width * 0.004 * top_pos.Text
                Dim downLeft As Double = txtDevValue.Width / 2 - txtDevValue.Width * 0.004 * bot_pos.Text
                Dim downRight As Double = txtDevValue.Width / 2 + txtDevValue.Width * 0.004 * bot_pos.Text

                Dim leftUp As Double = txtDevValue.Height / 2 - txtDevValue.Height * 0.004 * left_pos.Text
                Dim leftDown As Double = txtDevValue.Height / 2 + txtDevValue.Height * 0.004 * left_pos.Text
                Dim rightUp As Double = txtDevValue.Height / 2 - txtDevValue.Height * 0.004 * right_pos.Text
                Dim rightDown As Double = txtDevValue.Height / 2 + txtDevValue.Height * 0.004 * right_pos.Text


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

                    Debug.WriteLine("Center = (" & center.X & ", " & center.Y & ") | Intercept = (" & shiftX & ", " & shiftY & ")")
                    'shiftX = 0
                    'shiftY = 0
                    shiftX = (shiftX - center.X)
                    shiftY = (shiftY - center.Y)
                    Debug.WriteLine("New Intercept = (" & shiftX & ", " & shiftY & ")")

                    drawLineColor(top_pos.Text, New Point(upLeft - shiftX, txtDevValue.Height / 20),
                                            New Point(upRight - shiftX, txtDevValue.Height / 20), g, txtDevValue.Width / 20)

                    drawLineColor(bot_pos.Text, New Point(downLeft - shiftX, txtDevValue.Height / 20 * 19),
                                            New Point(downRight - shiftX, txtDevValue.Height / 20 * 19), g, txtDevValue.Width / 20)

                    drawLineColor(left_pos.Text, New Point(txtDevValue.Width / 20, leftUp - shiftY),
                                             New Point(txtDevValue.Width / 20, leftDown - shiftY), g, txtDevValue.Height / 20)

                    drawLineColor(right_pos.Text, New Point(txtDevValue.Width / 20 * 19, rightUp - shiftY),
                                              New Point(txtDevValue.Width / 20 * 19, rightDown - shiftY), g, txtDevValue.Height / 20)

                    ' 四角
                    Dim topLeft As New Point(upLeft - shiftX, leftUp - shiftY)
                    Dim topRight As New Point(upRight - shiftX, rightUp - shiftY)
                    Dim botLeft As New Point(downLeft - shiftX, leftDown - shiftY)
                    Dim botRight As New Point(downRight - shiftX, rightDown - shiftY)

                    drawLineColor(CInt(getSide(topLeft, center) / getSide(topLeft, botRight) * diagLeft.Text) * 2, topLeft, center, g, 5, True)
                    drawLineColor(CInt(getSide(topRight, center) / getSide(topRight, botLeft) * diagRight.Text) * 2, topRight, center, g, 5, True)
                    drawLineColor(CInt(getSide(botRight, center) / getSide(topLeft, botRight) * diagLeft.Text) * 2, center, botRight, g, 5, True)
                    drawLineColor(CInt(getSide(botLeft, center) / getSide(topRight, botLeft) * diagRight.Text) * 2, center, botLeft, g, 5, True)

                    ' 繪製文字
                    g.DrawString(CInt(getSide(topLeft, center) / getSide(topLeft, botRight) * diagLeft.Text).ToString, New Font("標楷體", 10, FontStyle.Regular), Brushes.Black, 1, 1)
                    g.DrawString(CInt(getSide(botRight, center) / getSide(topLeft, botRight) * diagLeft.Text).ToString, New Font("標楷體", 10, FontStyle.Regular), Brushes.Black, txtDevValue.Width - 16, txtDevValue.Height - 16)

                    g.DrawString(CInt(getSide(topRight, center) / getSide(topRight, botLeft) * diagRight.Text).ToString, New Font("標楷體", 10, FontStyle.Regular), Brushes.Black, txtDevValue.Width - 16, 1)
                    g.DrawString(CInt(getSide(botLeft, center) / getSide(topRight, botLeft) * diagRight.Text).ToString, New Font("標楷體", 10, FontStyle.Regular), Brushes.Black, 1, txtDevValue.Height - 16)

                    'If Not (top_pos.Text = "" Or left_pos.Text = "") Then
                    '    drawLineColor(getSide(New Point(-top_pos.Text / 2, left_pos.Text / 2), New Point(0, 0)), topLeft, center, g, pb.Width / 20, True)
                    'End If

                    'If Not (top_pos.Text = "" Or right_pos.Text = "") Then
                    '    drawLineColor(getSide(New Point(top_pos.Text / 2, right_pos.Text / 2), New Point(0, 0)), topRight, center, g, pb.Width / 20, True)
                    'End If

                    'If Not (bot_pos.Text = "" Or left_pos.Text = "") Then
                    '    drawLineColor(getSide(New Point(-bot_pos.Text / 2, left_pos.Text / 2), New Point(0, 0)), botLeft, center, g, pb.Width / 20, True)
                    'End If

                    'If Not (bot_pos.Text = "" Or right_pos.Text = "") Then
                    '    drawLineColor(getSide(New Point(bot_pos.Text / 2, right_pos.Text / 2), New Point(0, 0)), botRight, center, g, pb.Width / 20, True)
                    'End If


                    ' 總面積
                    Dim top As New Point(txtDevValue.Width / 2, txtDevValue.Height / 20)
                    Dim bot As New Point(txtDevValue.Width / 2, txtDevValue.Height / 20 * 19)
                    Dim left As New Point(txtDevValue.Width / 20, txtDevValue.Height / 2)
                    Dim right As New Point(txtDevValue.Width / 20 * 19, txtDevValue.Height / 2)

                    Dim maxWidth As Double = txtDevValue.Width * 0.004 * 45
                    Dim maxHeight As Double = txtDevValue.Height * 0.004 * 45
                    Dim maxArea As Double = getArea(getSide(New Point(txtDevValue.Width / 2 - maxWidth, txtDevValue.Height / 20),
                                                        New Point(txtDevValue.Width / 2 + maxWidth, txtDevValue.Height / 20)),
                                                getSide(New Point(txtDevValue.Width / 2 - maxWidth, txtDevValue.Height / 20), center),
                                                getSide(New Point(txtDevValue.Width / 2 + maxWidth, txtDevValue.Height / 20), center)) * 8


                    Dim totalArea As Double = getArea(getSide(topLeft, topRight), getSide(topLeft, center), getSide(topRight, center)) +
                                          getArea(getSide(topLeft, botLeft), getSide(topLeft, center), getSide(botLeft, center)) +
                                          getArea(getSide(botLeft, botRight), getSide(botLeft, center), getSide(botRight, center)) +
                                          getArea(getSide(topRight, botRight), getSide(topRight, center), getSide(botRight, center))

                    topArea.Text = FormatNumber(Math.Round(getArea(getSide(topLeft, topRight), getSide(topLeft, center), getSide(topRight, center)) / totalArea * 100, 1), 1)
                    botArea.Text = FormatNumber(Math.Round(getArea(getSide(botLeft, botRight), getSide(botLeft, center), getSide(botRight, center)) / totalArea * 100, 1), 1)
                    leftArea.Text = FormatNumber(Math.Round(getArea(getSide(topLeft, botLeft), getSide(topLeft, center), getSide(botLeft, center)) / totalArea * 100, 1), 1)
                    rightArea.Text = FormatNumber(Math.Round(getArea(getSide(topRight, botRight), getSide(topRight, center), getSide(botRight, center)) / totalArea * 100, 1), 1)
                    totalPercentage.Text = FormatNumber(Math.Round(totalArea / maxArea * 100, 1), 1)


                    'drawTriangle(topLeft, topRight, center, e)
                    'drawTriangle(botLeft, botRight, center, e)
                    'drawTriangle(topLeft, botLeft, center, e)
                    'drawTriangle(topRight, botRight, center, e)

                End If

            End If

            e.Graphics.DrawImage(bmp, New Point(0, 0))

            ' 格線
            bmp = New Bitmap(txtDevValue.Size.Width, txtDevValue.Size.Height)
            g = Graphics.FromImage(bmp)
            g.DrawLine(System.Drawing.Pens.DarkGreen, New Point(txtDevValue.Size.Width / 2, 0), New Point(txtDevValue.Size.Width / 2, txtDevValue.Size.Height))
            g.DrawLine(System.Drawing.Pens.DarkGreen, New Point(0, txtDevValue.Size.Height / 2), New Point(txtDevValue.Width, txtDevValue.Size.Height / 2))
            e.Graphics.DrawImage(bmp, New Point(0, 0))

        End If

    End Sub
    ' 轉算時間
    Private Function getTime(ByVal tick As Integer) As String
        Dim result As Double = CDbl(tick) / (41 / 3)
        Return FormatNumber(Math.Round(result, 1), 1)
    End Function
    ' 繪製彩線
    Private Sub drawLineColor(ByVal value As Double, ByVal pt1 As Point, ByVal pt2 As Point, ByRef g As Graphics,
                              ByVal lineSize As Double, Optional ByVal useAlt As Boolean = False)

        ' 筆刷
        Dim greenPen As New Pen(Brushes.Green, CSng(lineSize))
        greenPen.Alignment = Drawing2D.PenAlignment.Center

        Dim blackPen As New Pen(Brushes.Black, CSng(lineSize))
        blackPen.Alignment = Drawing2D.PenAlignment.Center

        Dim orangePen As New Pen(Brushes.Orange, CSng(lineSize))
        orangePen.Alignment = Drawing2D.PenAlignment.Center

        Dim redPen As New Pen(Brushes.Red, CSng(lineSize))
        redPen.Alignment = Drawing2D.PenAlignment.Center

        Dim upperDanger As Double = My.Settings.emsUpperDanger
        Dim upperWarning As Double = My.Settings.emsUpperWarning
        Dim lowerWarning As Double = My.Settings.emsLowerWarning
        Dim lowerDanger As Double = My.Settings.emsLowerDanger

        If useAlt Then
            upperDanger = My.Settings.engUpperDanger
            upperWarning = My.Settings.engUpperWarning
            lowerWarning = My.Settings.engLowerWarning
            lowerDanger = My.Settings.engLowerDanger
        End If

        If value = -9999 Then
            g.DrawLine(blackPen, pt1, pt2)
        ElseIf value >= upperDanger Or value < lowerDanger Then
            g.DrawLine(redPen, pt1, pt2)
        ElseIf value >= upperWarning Or value < lowerWarning Then
            g.DrawLine(orangePen, pt1, pt2)
        Else
            g.DrawLine(greenPen, pt1, pt2)
        End If

        greenPen.Dispose()
        blackPen.Dispose()
        orangePen.Dispose()
        redPen.Dispose()
    End Sub
#End Region
#Region "元氣計算"
    ' 距離計算
    Private Function getSide(ByVal pt1 As Point, ByVal pt2 As Point) As Double
        Return Math.Sqrt(Math.Abs(pt2.X - pt1.X) ^ 2 + Math.Abs(pt2.Y - pt1.Y) ^ 2)
    End Function
    ' 面積計算
    Private Function getArea(ByVal sideA As Double, ByVal sideB As Double, ByVal sideC As Double) As Double
        Dim p As Double = (sideA + sideB + sideC) / 2
        Return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC))
    End Function
    ' 取最大值
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
    ' 取最低值
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
    ' 解析結果
    Private Function parseResult(ByVal value As Integer, Optional outputNum As Boolean = False) As String
        If outputNum Then
            If value = -9999 Then Return "0" Else Return value.ToString
        Else
            If value = -9999 Then Return "-" Else Return value.ToString
        End If
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
                        txtDevValue.Refresh()
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
            RaiseEvent DEVICE_ERROR(Me, New EventArgs)
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
        sqlStr = sqlStr & "(' " & waitingList.SelectedValue & "','" & iCode & "','" & ptCounter & "','" & dValue & "'),"
        txtDevValue.Invalidate()
        Refresh()
        If iPlotCount > XMAX Then
            iPlotCount = iPlotCount Mod (XMAX + 1)
            iState = 2
        End If
    End Sub
    ' 儲存至SQL
    Private Sub SaveRecord()
        If waitingList.SelectedIndex = -1 Then
            MetroFramework.MetroMessageBox.Show(Me, "錯誤: 尚未選擇病患!", "儲存失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' 檢查重複資訊
            Try
                Dim reader As IDataReader = runQuery("SELECT count(`icode`) FROM ems WHERE `bID`=" & waitingList.SelectedValue & " AND `iCode`='" & iCode & "'")
                reader.Read()
                If Not reader.GetInt64(0) = 0 Then
                    reader.Close()
                    runQuery("DELETE FROM `ems` WHERE `bID`=" & waitingList.SelectedValue & " and `iCode`='" & iCode & "'")
                    runQuery("INSERT INTO ems(bID, iCode, iPlotCount, iValue) VALUES " & Mid(lastSqlStr, 1, Len(lastSqlStr) - 1))
                Else
                    reader.Close()
                    runQuery("INSERT INTO ems(bID, iCode, iPlotCount, iValue) VALUES " & Mid(lastSqlStr, 1, Len(lastSqlStr) - 1))
                End If
                runQuery("UPDATE patient_booking SET arrived=1 WHERE bID=" & waitingList.SelectedValue)
            Catch ex As Exception
                Console.WriteLine("Error: " & ex.ToString())
            End Try
            Refresh()
        End If
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
                measurePoint.Text = "量度點 [" & sMsg & "]"
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
            measurePoint.Text = "量度點 [" & sMsg & "]"
        End If
    End Sub
    ' 測量點選單
    Private Sub ptBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptBox.SelectedIndexChanged
        If Not (TypeOf ptBox.SelectedValue Is DataRowView) Then
            iCode2Btn(ptBox.SelectedValue)
        End If
    End Sub
#Region "鍵盤除錯檢查"
    Private Sub energy_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUpLeft.CheckedChanged, rdoUpRight.CheckedChanged, rdoDownLeft.CheckedChanged, rdoDownRight.CheckedChanged
        Static energyCbxStack As New List(Of CheckBox)
        ' 檢查確保元氣方向不會同時超過兩個以上點選之狀況
        Dim ckBox As New CheckBox
        If TypeOf sender Is CheckBox Then
            ckBox = CType(sender, CheckBox)
        End If
        RemoveHandler ckBox.CheckedChanged, AddressOf energy_CheckedChanged
        With ckBox
            If energyCbxStack.Contains(ckBox) Then
                .Checked = True
                '.BackColor = Color.Green
                AddHandler ckBox.CheckedChanged, AddressOf energy_CheckedChanged
                Exit Sub
            End If
            If .Checked = True Then
                energyCbxStack.Add(ckBox)
                If energyCbxStack.Count > 2 Then
                    RemoveHandler energyCbxStack.Item(0).CheckedChanged, AddressOf energy_CheckedChanged
                    energyCbxStack.Item(0).Checked = False
                    'energyCbxStack.Item(0).BackColor = BackColor
                    AddHandler energyCbxStack.Item(0).CheckedChanged, AddressOf energy_CheckedChanged
                    energyCbxStack.RemoveAt(0)
                End If
                AddHandler ckBox.CheckedChanged, AddressOf energy_CheckedChanged
            End If
        End With
        'If sender.checked Then
        '    sender.backcolor = Color.Green
        'Else
        '    sender.backcolor = BackColor
        'End If
        getMeasurePoint()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        tickCounter = 0
        'If tempTrigger Then
        '    tickCounter = 0
        '    emsTimer.Interval = 10
        '    emsTimer.Start()
        'Else
        '    emsTimer.Stop()
        'End If
        'tempTrigger = Not tempTrigger
    End Sub

    Private Sub point_CheckedChanged(sender As Object, e As EventArgs) Handles rdoC1.CheckedChanged, rdoC2.CheckedChanged, rdoC3.CheckedChanged, rdoC4.CheckedChanged, rdoC5.CheckedChanged, rdoC6.CheckedChanged
        Static ptCbxStack As New List(Of CheckBox)

        ' 檢查確保量測點不會同時超過一個以上點選之狀況
        Dim ckBox As New CheckBox
        If TypeOf sender Is CheckBox Then
            ckBox = CType(sender, CheckBox)
        End If
        RemoveHandler ckBox.CheckedChanged, AddressOf point_CheckedChanged
        With ckBox
            If ptCbxStack.Contains(ckBox) Then
                .Checked = True
                '.BackColor = Color.Green
                AddHandler ckBox.CheckedChanged, AddressOf point_CheckedChanged
                Exit Sub
            End If
            If .Checked = True Then
                ptCbxStack.Add(ckBox)
                If ptCbxStack.Count > 1 Then
                    RemoveHandler ptCbxStack.Item(0).CheckedChanged, AddressOf point_CheckedChanged
                    ptCbxStack.Item(0).Checked = False
                    'ptCbxStack.Item(0).BackColor = BackColor
                    AddHandler ptCbxStack.Item(0).CheckedChanged, AddressOf point_CheckedChanged
                    ptCbxStack.RemoveAt(0)
                End If
                AddHandler ckBox.CheckedChanged, AddressOf point_CheckedChanged
            End If
        End With
        getMeasurePoint()
    End Sub
    Private Sub finger_CheckedChanged(sender As Object, e As EventArgs) Handles rdoF1.CheckedChanged, rdoF2.CheckedChanged, rdoF3.CheckedChanged, rdoF4.CheckedChanged,
                                                                                 rdoF5.CheckedChanged
        Static fingerCbxStack As New List(Of CheckBox)

        ' 檢查確保手指不會同時超過一個以上點選之狀況
        Dim ckBox As New CheckBox
        If TypeOf sender Is CheckBox Then
            ckBox = CType(sender, CheckBox)
        End If
        RemoveHandler ckBox.CheckedChanged, AddressOf finger_CheckedChanged
        With ckBox
            If fingerCbxStack.Contains(ckBox) Then
                .Checked = True
                '.BackColor = Color.Green
                AddHandler ckBox.CheckedChanged, AddressOf finger_CheckedChanged
                Exit Sub
            End If
            If .Checked = True Then
                fingerCbxStack.Add(ckBox)
                If fingerCbxStack.Count > 1 Then
                    RemoveHandler fingerCbxStack.Item(0).CheckedChanged, AddressOf finger_CheckedChanged
                    fingerCbxStack.Item(0).Checked = False
                    'fingerCbxStack.Item(0).BackColor = BackColor
                    AddHandler fingerCbxStack.Item(0).CheckedChanged, AddressOf finger_CheckedChanged
                    fingerCbxStack.RemoveAt(0)
                End If
                AddHandler ckBox.CheckedChanged, AddressOf finger_CheckedChanged
            End If
        End With
        'If sender.checked Then
        '    sender.backcolor = Color.Green
        'Else
        '    sender.backcolor = BackColor
        'End If
        getMeasurePoint()
    End Sub
    Private Sub reverse_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLeft.CheckedChanged, rdoRight.CheckedChanged, rdoHand.CheckedChanged, rdoFoot.CheckedChanged,
                                                                                 rdoEnergy.CheckedChanged, rdoGraph.CheckedChanged, rdoS1.CheckedChanged, rdoS2.CheckedChanged
        Static firstTime As Boolean = True

        ' 反轉兩者互相牽制的按鈕
        If firstTime Then
            firstTime = False
            Select Case sender.name
                Case "rdoLeft"
                    rdoRight.Checked = Not rdoLeft.Checked
                Case "rdoRight"
                    rdoLeft.Checked = Not rdoRight.Checked
                Case "rdoHand"
                    rdoFoot.Checked = Not rdoHand.Checked
                Case "rdoFoot"
                    rdoHand.Checked = Not rdoFoot.Checked
                Case "rdoS1"
                    rdoS2.Checked = Not rdoS1.Checked
                Case "rdoS2"
                    rdoS1.Checked = Not rdoS2.Checked
                Case "rdoEnergy"
                    rdoGraph.Checked = Not rdoEnergy.Checked
                    If rdoEnergy.Checked Then
                        rdoUpLeft.Checked = True
                        rdoUpRight.Checked = True
                    End If
                Case "rdoGraph"
                    rdoEnergy.Checked = Not rdoGraph.Checked
                    If rdoGraph.Checked Then
                        rdoLeft.Checked = True
                        rdoHand.Checked = True
                        rdoF1.Checked = True
                        rdoC5.Checked = True
                        rdoS1.Checked = True
                    End If
            End Select

            ' 顯示/隱藏不相關按鈕
            rdoUpLeft.Visible = rdoEnergy.Checked
            rdoUpRight.Visible = rdoEnergy.Checked
            rdoDownLeft.Visible = rdoEnergy.Checked
            rdoDownRight.Visible = rdoEnergy.Checked
            rdoF1.Visible = rdoGraph.Checked
            rdoF2.Visible = rdoGraph.Checked
            rdoF3.Visible = rdoGraph.Checked
            rdoF4.Visible = rdoGraph.Checked
            rdoF5.Visible = rdoGraph.Checked
            rdoS1.Visible = rdoGraph.Checked
            rdoS2.Visible = rdoGraph.Checked
            rdoC6.Visible = rdoGraph.Checked
            rdoC5.Visible = rdoGraph.Checked
            rdoC4.Visible = rdoGraph.Checked
            rdoC3.Visible = rdoGraph.Checked
            rdoC2.Visible = rdoGraph.Checked
            rdoC1.Visible = rdoGraph.Checked
            rdoLeft.Visible = rdoGraph.Checked
            rdoRight.Visible = rdoGraph.Checked
            rdoHand.Visible = rdoGraph.Checked
            rdoFoot.Visible = rdoGraph.Checked
            rdoStone.Visible = rdoGraph.Checked

            firstTime = True
        End If
        'If sender.checked Then
        '    sender.backcolor = Color.Green
        'Else
        '    sender.backcolor = BackColor
        'End If
        getMeasurePoint()
    End Sub
#End Region
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
    Private Sub okLink_Click(sender As Object, e As EventArgs)
        buttonPanel.Visible = False
    End Sub
    ' 開啟小鍵盤
    Private Sub openPanelLink_Click(sender As Object, e As EventArgs) Handles openPanelLink.Click
        buttonPanel.Visible = True
    End Sub

#End Region
End Class
