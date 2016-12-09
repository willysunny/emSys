Public Class frmEmsButtons

    Public Event OK As EventHandler
    Public Event CANCELLED As EventHandler
    Public buttonResult As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        rdoEnergy.Checked = True
        rdoUpLeft.Checked = True
        rdoDownRight.Checked = True

    End Sub

    Public Sub New(ByVal iCode As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        iCode2Btn(iCode)
    End Sub

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

    Private Sub okLink_Click(sender As Object, e As EventArgs) Handles okLink.Click
        buttonResult = btn2iCode()
        RaiseEvent OK(Me, New EventArgs)
        Close()
    End Sub

    Private Sub cancelLink_Click(sender As Object, e As EventArgs) Handles cancelLink.Click

    End Sub
End Class