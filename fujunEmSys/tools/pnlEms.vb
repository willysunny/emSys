Public Class pnlEms
    Inherits pnlSlider

    ' Events
    Public Event DEVICE_UNPLUGGED As EventHandler

    ' Database
    'Dim cmdSql As SqlCommand
    'Dim sConn As String = My.Settings.Setting
    '
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
    'Dim err As ErrorCode
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

    '
    ' PictureBox 繪圖變數
    '
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
    '
    Dim sMainPoint As String '主量測點
    Dim sSubPoint As String '次量測點
    Dim bLR As Boolean
    Dim bHandFoot As Boolean
    Dim sFinger As String
    Dim sSub As String
    Dim iMain, iSub, iCode As Integer '主量測點值、次量測點值、代碼值
    Dim LR, HF, Finger, TB, P, S As Integer

    '
    ' 藥檢相關
    '
    Dim mainIDList As List(Of Integer)
    Dim subIDList As List(Of Integer)
    Dim medIDList As List(Of Integer)
    Dim medUnitList As List(Of String)
    Dim medMax As Integer
    Dim medCali As Boolean = True
    Dim caliberated As Boolean = False

    '
    ' Conter相關
    '
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

    '
    ' SQL 相關
    '
    Dim sqlStr As String = "" 'sql指令串
    Dim lastSqlStr As String = "" 'sql指令串
    Dim ptCounter As Integer = 0 '
    Dim bar2iCode(60) As Integer ' Bar圖中對應點

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If 

        End If


    End Sub


End Class
