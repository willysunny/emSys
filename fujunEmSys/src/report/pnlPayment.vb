﻿Public Class pnlPayment
    Inherits pnlSlider
    Private init As Boolean = True
    Private printPage As Integer = 0

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        printDoc.OriginAtMargins = False
        printDoc.DocumentName = "報表"

        Try
            printDlg.Document = printDoc
            printPreviewDlg.ShowDialog()
            If printDlg.ShowDialog() = DialogResult.OK Then printDoc.Print()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub printDoc_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles printDoc.EndPrint
        printPage = 0
    End Sub

    Private Sub PrintDoc_PrintprintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDoc.PrintPage

        Const regFee As Integer = 200
        Const diagFee As Integer = 500
        Dim checkFee As Integer = 0
        Dim regRate As Integer = 1
        Dim diagRate As Integer = 1
        Dim checkRate As Integer = 1
        Dim medDiscount As Double = 1
        Dim sum As Integer = 0
        Dim sponsoredSum As Integer = 0
        Select Case discountBox.SelectedIndex
            Case 0
                If Not emSys.patientInfo.isNew Then regRate = 0
                medDiscount = 1
            Case 1
                regRate = 0
                diagRate = 0
                medDiscount = 0.8
            Case 2
                regRate = 0
                diagRate = 0
                medDiscount = 0
            Case 3
                regRate = 0
                diagRate = 0
                medDiscount = 0.9
            Case 4
                regRate = 0
                diagRate = 0
                medDiscount = 0.5
            Case 5
                regRate = 0
                diagRate = 0
                medDiscount = 0.7
            Case 7
                regRate = 0
                diagRate = 0
                medDiscount = 1
            Case Else
                If Not emSys.patientInfo.isNew Then regRate = 0
                medDiscount = 1
        End Select

        Dim medFee As Integer = 0
        Dim medDiscounted As Integer = 0
        For Each row As DataGridViewRow In leftResult.Rows
            medFee += CType(row.Cells("lmedPrice").Value, Integer) * medDiscount
            medDiscounted += CType(row.Cells("lmedPrice").Value, Integer) * (1 - medDiscount)
        Next
        For Each row As DataGridViewRow In rightResult.Rows
            medFee += CType(row.Cells("rmedPrice").Value, Integer)
        Next
        sum = regFee * regRate + diagFee * diagRate + checkFee * checkRate + medFee
        sponsoredSum = regFee * (1 - regRate) + diagFee * (1 - diagRate) + checkFee * (1 - checkRate) + medDiscounted



        Dim outlinePath As New Drawing2D.GraphicsPath
        Dim useFont As Font = New Font("標楷體", 20, FontStyle.Regular)
        Dim fontsize As Integer = 16
        Dim stringFormat As New StringFormat()

        '上半標題
        stringFormat.Alignment = StringAlignment.Center
        outlinePath.AddString("福濬中醫診所門診醫療費用收據", useFont.FontFamily, FontStyle.Regular, 28, New Point(414, 50), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()

        ' 抬頭
        stringFormat.Alignment = StringAlignment.Near
        Dim twC As System.Globalization.TaiwanCalendar = New System.Globalization.TaiwanCalendar()
        outlinePath.AddString("就診日期: " & twC.GetYear(emSys.patientHistory.visitTime) & emSys.patientHistory.visitTime.ToString("-MM-dd"), useFont.FontFamily, FontStyle.Regular, fontsize, New Point(50, 100), stringFormat)
        outlinePath.AddString("病例號碼: " & emSys.patientInfo.pID, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(232, 100), stringFormat)
        outlinePath.AddString("姓　　名: " & emSys.patientInfo.pName, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(414, 100), stringFormat)
        outlinePath.AddString("醫生姓名: " & docName.Text, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(595, 100), stringFormat)
        outlinePath.AddString("出生日期: " & emSys.patientInfo.pDOB, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(50, 120), stringFormat)
        outlinePath.AddString("性　　別: " & pSex.Text, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(232, 120), stringFormat)
        outlinePath.AddString("身分證號: " & emSys.patientInfo.pPID, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(414, 120), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()

        '健保項目
        stringFormat.Alignment = StringAlignment.Center
        outlinePath.AddString("健保申報項目", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 160), stringFormat)
        outlinePath.AddString("診察費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 190), stringFormat)
        outlinePath.AddString("藥費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 220), stringFormat)
        outlinePath.AddString("藥事服務費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 250), stringFormat)
        outlinePath.AddString("注射費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 280), stringFormat)
        outlinePath.AddString("檢驗費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 310), stringFormat)
        outlinePath.AddString("處置手術費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 340), stringFormat)
        outlinePath.AddString("材料費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 370), stringFormat)
        outlinePath.AddString("小計", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 400), stringFormat)
        outlinePath.AddString("應繳金額", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 430), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()

        stringFormat.Alignment = StringAlignment.Far
        outlinePath.AddString("點", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(394, 400), stringFormat)
        outlinePath.AddString("元", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(394, 430), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()
        stringFormat.Alignment = StringAlignment.Near
        outlinePath.AddString("健保申請", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(252, 400), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()

        '健保點數
        stringFormat.Alignment = StringAlignment.Center
        outlinePath.AddString("點數", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 160), stringFormat)
        outlinePath.AddString("0", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 190), stringFormat)
        outlinePath.AddString("0", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 220), stringFormat)
        outlinePath.AddString("0", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 250), stringFormat)
        outlinePath.AddString("0", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 280), stringFormat)
        outlinePath.AddString("0", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 310), stringFormat)
        outlinePath.AddString("0", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 340), stringFormat)
        outlinePath.AddString("0", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 370), stringFormat)
        outlinePath.AddString("0", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(348, 400), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()

        stringFormat.Alignment = StringAlignment.Far
        outlinePath.AddString(sum.ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(355, 430), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()

        '自付費項目
        stringFormat.Alignment = StringAlignment.Center
        outlinePath.AddString("自付費用項目", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(505, 160), stringFormat)
        outlinePath.AddString("掛號費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(505, 190), stringFormat)
        outlinePath.AddString("診察費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(505, 220), stringFormat)
        outlinePath.AddString("藥費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(505, 250), stringFormat)
        outlinePath.AddString("檢驗檢查", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(505, 280), stringFormat)
        outlinePath.AddString("針灸費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(505, 310), stringFormat)
        outlinePath.AddString("其他", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(505, 340), stringFormat)
        outlinePath.AddString("小計", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(505, 370), stringFormat)
        outlinePath.AddString("收款人", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(505, 400), stringFormat)
        outlinePath.AddString("收款日期", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(505, 430), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()

        '自付金額
        stringFormat.Alignment = StringAlignment.Center
        outlinePath.AddString("費用", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(686, 160), stringFormat)
        outlinePath.AddString(CInt(regFee * regRate).ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(686, 190), stringFormat)
        outlinePath.AddString(CInt(diagFee * diagRate).ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(686, 220), stringFormat)
        outlinePath.AddString(CInt(medFee * medDiscount).ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(686, 250), stringFormat)
        outlinePath.AddString(CInt(checkFee * checkRate).ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(686, 280), stringFormat)
        outlinePath.AddString("0", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(686, 310), stringFormat)
        outlinePath.AddString("0", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(686, 340), stringFormat)
        outlinePath.AddString(sum.ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(686, 370), stringFormat)
        outlinePath.AddString(twC.GetYear(Now) & Now.ToString("-MM-dd HH:mm"), useFont.FontFamily, FontStyle.Regular, fontsize, New Point(686, 430), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()

        ' 註腳
        stringFormat.Alignment = StringAlignment.Near
        outlinePath.AddString("診所名稱: 福濬中醫診所", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(50, 465), stringFormat)
        outlinePath.AddString("電話: 03-3277900", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(414, 465), stringFormat)
        outlinePath.AddString("傳真: 03-3273989", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(595, 465), stringFormat)
        outlinePath.AddString("診所地址: 桃園縣龜山區文化二路30之11號", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(50, 485), stringFormat)
        outlinePath.AddString("備註: 本收據僅供繳費證明用，遺失恕不補發，請妥善保存。", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(50, 505), stringFormat)
        e.Graphics.FillPath(Brushes.Black, outlinePath)
        e.Graphics.DrawPath(Pens.Black, outlinePath)
        outlinePath.Reset()

        '外框
        For x = 0 To 4
            outlinePath.AddLine(New Point(50 + 182 * x, 154), New Point(50 + 182 * x, 454))
            e.Graphics.DrawPath(Pens.Black, outlinePath)
            outlinePath.Reset()
        Next
        For y = 0 To 10
            outlinePath.AddLine(New Point(50, 154 + 30 * y), New Point(778, 154 + 30 * y))
            e.Graphics.DrawPath(Pens.Black, outlinePath)
            outlinePath.Reset()
        Next

        '切割線
        For x = 0 To 80 Step 2
            outlinePath.AddLine(New Point(50 + x * 9, 585), New Point(59 + x * 9, 585))
            e.Graphics.DrawPath(Pens.Black, outlinePath)
            outlinePath.Reset()
        Next

        Select Case printPage
            Case 0
                ' ==================================================================================================================================================
                ' =                                                  printPage 1 - Sponsored Fees
                ' ==================================================================================================================================================
                If Not discountBox.SelectedIndex = 0 Then

                    '下半標題
                    stringFormat.Alignment = StringAlignment.Center
                    outlinePath.AddString("財團法人福濬傳統研究基金會醫療補助費用明細", useFont.FontFamily, FontStyle.Regular, 28, New Point(414, 635), stringFormat)
                    e.Graphics.FillPath(Brushes.Black, outlinePath)
                    e.Graphics.DrawPath(Pens.Black, outlinePath)
                    outlinePath.Reset()

                    ' 抬頭
                    stringFormat.Alignment = StringAlignment.Near
                    outlinePath.AddString("日期: " & twC.GetYear(emSys.patientHistory.visitTime) & emSys.patientHistory.visitTime.ToString("-MM-dd"), useFont.FontFamily, FontStyle.Regular, fontsize, New Point(50, 695), stringFormat)
                    outlinePath.AddString("姓名: " & emSys.patientInfo.pName, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(232, 695), stringFormat)
                    outlinePath.AddString("身分證字號: " & emSys.patientInfo.pPID, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(414, 695), stringFormat)
                    e.Graphics.FillPath(Brushes.Black, outlinePath)
                    e.Graphics.DrawPath(Pens.Black, outlinePath)
                    outlinePath.Reset()

                    '補給項目
                    stringFormat.Alignment = StringAlignment.Center
                    outlinePath.AddString("項目/內容", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 740), stringFormat)
                    outlinePath.AddString("掛號費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 770), stringFormat)
                    outlinePath.AddString("診察費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 800), stringFormat)
                    outlinePath.AddString("檢驗費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 830), stringFormat)
                    outlinePath.AddString("藥費", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 860), stringFormat)
                    outlinePath.AddString("合計", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(141, 920), stringFormat)
                    outlinePath.AddString("金額", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 740), stringFormat)
                    outlinePath.AddString("備註", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(595, 740), stringFormat)
                    e.Graphics.FillPath(Brushes.Black, outlinePath)
                    e.Graphics.DrawPath(Pens.Black, outlinePath)
                    outlinePath.Reset()

                    '補給金額
                    stringFormat.Alignment = StringAlignment.Center
                    outlinePath.AddString(CInt(regFee * (1 - regRate)).ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 770), stringFormat)
                    outlinePath.AddString(CInt(diagFee * (1 - diagRate)).ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 800), stringFormat)
                    outlinePath.AddString(CInt(checkFee * (1 - checkRate)).ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 830), stringFormat)
                    outlinePath.AddString(CInt(medFee * (1 - medDiscount)).ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 860), stringFormat)
                    outlinePath.AddString(CInt(sponsoredSum).ToString, useFont.FontFamily, FontStyle.Regular, fontsize, New Point(323, 920), stringFormat)
                    outlinePath.AddString(CInt(sponsoredSum).ToString, useFont.FontFamily, FontStyle.Regular, 20, New Point(232, 1000), stringFormat)
                    e.Graphics.FillPath(Brushes.Black, outlinePath)
                    e.Graphics.DrawPath(Pens.Black, outlinePath)
                    outlinePath.Reset()


                    '外框
                    For x = 0 To 4
                        If Not x = 3 Then
                            outlinePath.AddLine(New Point(50 + 182 * x, 735), New Point(50 + 182 * x, 945))
                            e.Graphics.DrawPath(Pens.Black, outlinePath)
                            outlinePath.Reset()
                        End If
                    Next
                    For y = 0 To 7
                        outlinePath.AddLine(New Point(50, 735 + 30 * y), New Point(778, 735 + 30 * y))
                        e.Graphics.DrawPath(Pens.Black, outlinePath)
                        outlinePath.Reset()
                    Next

                    ' 簽名
                    stringFormat.Alignment = StringAlignment.Near
                    outlinePath.AddString("補助金額: ", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(50, 1000), stringFormat)
                    outlinePath.AddString("簽名:", useFont.FontFamily, FontStyle.Regular, fontsize, New Point(414, 1000), stringFormat)
                    e.Graphics.DrawPath(Pens.Black, outlinePath)
                    outlinePath.Reset()

                    outlinePath.AddLine(New Point(131, 1020), New Point(323, 1020))
                    e.Graphics.DrawPath(Pens.Black, outlinePath)
                    outlinePath.Reset()
                    outlinePath.AddLine(New Point(465, 1020), New Point(717, 1020))
                    e.Graphics.DrawPath(Pens.Black, outlinePath)
                    outlinePath.Reset()
                End If
                printPage = 1
            Case 1
                ' ==================================================================================================================================================
                ' =                                                  printPage 2 - Detailed Info
                ' ==================================================================================================================================================

                '下半標題
                stringFormat.Alignment = StringAlignment.Center
                outlinePath.AddString("藥品費用明細", useFont.FontFamily, FontStyle.Regular, 28, New Point(414, 635), stringFormat)
                e.Graphics.FillPath(Brushes.Black, outlinePath)
                e.Graphics.DrawPath(Pens.Black, outlinePath)
                outlinePath.Reset()

                ''外框
                'For x = 0 To 4
                '    outlinePath.AddLine(New Point(50 + 182 * x, 690), New Point(50 + 182 * x, 1110))
                '    e.Graphics.DrawPath(Pens.Black, outlinePath)
                '    outlinePath.Reset()
                'Next
                'For y = 0 To 14
                '    outlinePath.AddLine(New Point(50, 690 + 30 * y), New Point(778, 690 + 30 * y))
                '    e.Graphics.DrawPath(Pens.Black, outlinePath)
                '    outlinePath.Reset()
                'Next

                For i = 0 To 1

                    '底線
                    e.Graphics.DrawLine(Pens.Black, New Point((354 * i) + 101, 715), New Point((354 * i) + 181, 715))
                    e.Graphics.DrawLine(Pens.Black, New Point((354 * i) + 260, 715), New Point((354 * i) + 300, 715))
                    e.Graphics.DrawLine(Pens.Black, New Point((354 * i) + 310, 715), New Point((354 * i) + 350, 715))
                    e.Graphics.DrawLine(Pens.Black, New Point((354 * i) + 360, 715), New Point((354 * i) + 400, 715))

                    '抬頭
                    stringFormat.Alignment = StringAlignment.Center
                    outlinePath.AddString("藥品名稱", useFont.FontFamily, FontStyle.Regular, fontsize, New Point((354 * i) + 141, 695), stringFormat)
                    outlinePath.AddString("數量", useFont.FontFamily, FontStyle.Regular, fontsize, New Point((354 * i) + 280, 695), stringFormat)
                    outlinePath.AddString("天數", useFont.FontFamily, FontStyle.Regular, fontsize, New Point((354 * i) + 330, 695), stringFormat)
                    outlinePath.AddString("金額", useFont.FontFamily, FontStyle.Regular, fontsize, New Point((354 * i) + 380, 695), stringFormat)
                    e.Graphics.FillPath(Brushes.Black, outlinePath)
                    e.Graphics.DrawPath(Pens.Black, outlinePath)
                    outlinePath.Reset()
                Next

                With leftResult
                    For i = 0 To .Rows.Count - 1
                        outlinePath.AddString(.Rows(i).Cells(2).Value, useFont.FontFamily, FontStyle.Regular, 12, New Point((354 * Math.Floor(i / 19)) + 141, 725 + (i Mod 19) * 20), stringFormat)
                        outlinePath.AddString(.Rows(i).Cells(8).Value & .Rows(i).Cells(5).Value, useFont.FontFamily, FontStyle.Regular, 12, New Point((354 * Math.Floor(i / 19)) + 280, 725 + (i Mod 19) * 20), stringFormat)
                        outlinePath.AddString(.Rows(i).Cells(6).Value.ToString, useFont.FontFamily, FontStyle.Regular, 12, New Point((354 * Math.Floor(i / 19)) + 330, 725 + (i Mod 19) * 20), stringFormat)
                        outlinePath.AddString(.Rows(i).Cells(3).Value.ToString, useFont.FontFamily, FontStyle.Regular, 12, New Point((354 * Math.Floor(i / 19)) + 380, 725 + (i Mod 19) * 20), stringFormat)
                        e.Graphics.FillPath(Brushes.Black, outlinePath)
                        e.Graphics.DrawPath(Pens.Black, outlinePath)
                        outlinePath.Reset()
                    Next
                End With

                printPage = 0
        End Select

        If printPage = 1 Then
            e.HasMoreprintPages = True
        Else
            e.HasMoreprintPages = False
        End If
        Debug.WriteLine(e.HasMoreprintPages)
    End Sub
    Private Function verText(ByVal input As String) As String
        verText = ""
        For i = 0 To Len(input)
            If Not Mid(input, i + 1, 1) = " " Then
                verText += Mid(input, i + 1, 1) + vbNewLine
            End If
        Next
        Return verText
    End Function

End Class