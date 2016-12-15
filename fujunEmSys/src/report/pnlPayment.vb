Public Class pnlPayment
    Inherits pnlSlider

    Private init As Boolean = True
    Private patientInfo As New pInfo
    Dim discountType As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 折扣
    Dim diagDiscount As Dictionary(Of Integer, Double) = New Dictionary(Of Integer, Double) ' 診費折扣
    Dim medDiscount As Dictionary(Of Integer, Double) = New Dictionary(Of Integer, Double) ' 藥費折扣
    Dim diagFeeType As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 診費
    Dim unit As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
    Dim printPage As Integer = 0

#Region "初始"
    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)
        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.
        RemoveHandler diagFee.SelectedIndexChanged, AddressOf diagFee_SelectedIndexChanged
        RemoveHandler discountBox.SelectedIndexChanged, AddressOf discountBox_SelectedIndexChanged
        RemoveHandler medFee.CellValidated, AddressOf medFee_bioFee_CellValidated
        RemoveHandler bioFee.CellValidated, AddressOf medFee_bioFee_CellValidated

        unit.Add(1, "克")
        unit.Add(2, "顆")

        refreshBooking(Now)
        Dim discountTable As DataTable = returnData(mainForm, "SELECT * FROM discount_type")
        For Each row As DataRow In discountTable.Rows
            discountType.Add(row.Item("discountType"), row.Item("discountName"))
            diagDiscount.Add(row.Item("discountType"), row.Item("diagFee"))
            medDiscount.Add(row.Item("discountType"), row.Item("medFee"))
        Next
        With discountBox
            .DataSource = discountTable
            .ValueMember = "discountType"
            .DisplayMember = "discountName"
        End With
        With diagFeeType
            .Add(0, "複診")
            .Add(200, "初診")
        End With
        Dim diagFeeTable As New DataTable
        With diagFeeTable
            .Columns.Add("fee", GetType(Integer))
            .Columns.Add("name", GetType(String))
            For Each point As KeyValuePair(Of Integer, String) In diagFeeType
                .Rows.Add(point.Key, point.Value)
            Next
        End With
        With diagFee
            .DataSource = diagFeeTable
            .ValueMember = "fee"
            .DisplayMember = "name"
        End With
        AddHandler diagFee.SelectedIndexChanged, AddressOf diagFee_SelectedIndexChanged
        AddHandler discountBox.SelectedIndexChanged, AddressOf discountBox_SelectedIndexChanged
        AddHandler medFee.CellValidated, AddressOf medFee_bioFee_CellValidated
        AddHandler bioFee.CellValidated, AddressOf medFee_bioFee_CellValidated

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
#Region "載入病人資料"
    Private Sub waitingList_Click(sender As Object, e As EventArgs) Handles waitingList.Click
        If Not waitingList.SelectedIndex = -1 Then
            loadPatientData(waitingList.SelectedValue)
            patientTab.SelectedTab = tabPatientInfo
            pName.Text = patientInfo.pName
            If patientInfo.pSex = 0 Then pSex.Text = "女" Else pSex.Text = "男"
            pAge.Text = patientInfo.pAge
            loadPaymentData(waitingList.SelectedValue)
        End If
    End Sub
    Private Sub loadPatientData(ByVal bID As Integer)
        Dim reader As IDataReader = runQuery("Select pID FROM patient_booking WHERE bID=" & bID)
        If reader.Read Then
            Dim pID As Integer = reader.Item("pID")
            patientInfo = New pInfo
            patientInfo.initiate(pID)
        End If
    End Sub
    Private Sub loadPaymentData(ByVal bID As Integer, Optional force As Boolean = False)
        If Not force Then
            Dim reader As IDataReader = runQuery("SELECT recordID FROM feeRecord WHERE bID=" & bID)
            If reader.Read Then
                loadFromRecordID(reader.Item("recordID"))
                Exit Sub
            End If
        End If

        setupTables(medFee, bID, False)
        setupTables(bioFee, bID, True)
        getTotal()

    End Sub
    Private Sub loadFromRecordID(ByVal recordID As Integer)

    End Sub
    Private Sub setupTables(ByRef grid As DataGridView, ByVal bID As Integer, ByVal bioMed As Boolean)
        RemoveHandler grid.CellValidated, AddressOf medFee_bioFee_CellValidated
        grid.DataSource = returnData(mainForm, "Select mi.bioMed, mi.medName as '藥品名稱', mg.medDays, (mg.morning + mg.noon + mg.night + mg.beforeSleep) AS 'medTimes',
                                                  (mg.medDays * md.medAmount) AS '總量', md.medUnit, null as '單位', mi.unitPrice, mi.groupPrice, mi.groupAmount,
                                                  (SELECT count(mgID) FROM medDetail WHERE mgID=mg.mgID) as 'groupCount', null AS 'origPrice', null AS '金額',mg.makePill, null as '打錠費', mi.groupExclude
                                                  FROM medGroup2medDetail as mg
                                                  INNER JOIN medDetail AS md ON mg.mgID = md.mgID
                                                  INNER JOIN med_item as mi on md.medID = mi.medID
                                                  WHERE bID=" & bID & " AND bioMed=" & bioMed &
                                                  " ORDER BY mg.mgid")
        For Each col As DataGridViewColumn In grid.Columns
            col.Visible = False
            col.ReadOnly = True
        Next
        grid.Columns.Item("藥品名稱").Visible = True
        grid.Columns.Item("總量").Visible = True
        grid.Columns.Item("單位").Visible = True
        grid.Columns.Item("打錠費").Visible = True
        grid.Columns.Item("打錠費").ReadOnly = False
        grid.Columns.Item("金額").Visible = True
        grid.Columns.Item("金額").ReadOnly = False

        For Each row As DataGridViewRow In grid.Rows
            If row.Cells("groupCount").Value = 1 Then
                If (row.Cells("總量").Value Mod row.Cells("groupAmount").Value) * row.Cells("unitPrice").Value >= row.Cells("groupPrice").Value And
                    (row.Cells("總量").Value Mod row.Cells("groupAmount").Value) <= row.Cells("groupAmount").Value Then
                    row.Cells("origPrice").Value = row.Cells("groupPrice").Value * Math.Ceiling(row.Cells("總量").Value / row.Cells("groupAmount").Value)
                Else
                    row.Cells("origPrice").Value = row.Cells("groupPrice").Value * Math.Floor(row.Cells("總量").Value / row.Cells("groupAmount").Value) +
                        row.Cells("unitPrice").Value * (row.Cells("總量").Value Mod row.Cells("groupAmount").Value)
                End If
                row.Cells("金額").Value = row.Cells("origPrice").Value
            ElseIf row.Cells("groupCount").Value > 1 Then
                Dim pricePerGram As Double = 7.5
                If row.Cells("medTimes").Value = 3 Then pricePerGram = 10
                If row.Cells("groupExclude").Value Then
                    row.Cells("origPrice").Value = row.Cells("總量").Value * (row.Cells("groupCount").Value - pricePerGram)
                Else
                    row.Cells("origPrice").Value = row.Cells("總量").Value * pricePerGram
                End If
                row.Cells("金額").Value = row.Cells("origPrice").Value
            End If
            If row.Cells("makePill").Value Then
                row.Cells("打錠費").Value = 100 * Math.Round(Math.Ceiling(row.Cells("medDays").Value / 7) / row.Cells("groupCount").Value)
            Else
                row.Cells("打錠費").Value = 0
            End If
            row.Cells("單位").Value = unit.Item(row.Cells("medUnit").Value)
        Next
        AddHandler grid.CellValidated, AddressOf medFee_bioFee_CellValidated
    End Sub
#End Region
#End Region

#Region "金額計算"

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        For Each row As DataGridViewRow In medFee.Rows
            row.Cells("金額").Value = row.Cells("origPrice").Value
            If row.Cells("makePill").Value Then
                row.Cells("打錠費").Value = 100 * Math.Round(Math.Ceiling(row.Cells("medDays").Value / 7) / row.Cells("groupCount").Value)
            Else
                row.Cells("打錠費").Value = 0
            End If
        Next
        For Each row As DataGridViewRow In bioFee.Rows
            row.Cells("金額").Value = row.Cells("origPrice").Value
            If row.Cells("makePill").Value Then
                row.Cells("打錠費").Value = 100 * Math.Round(Math.Ceiling(row.Cells("medDays").Value / 7) / row.Cells("groupCount").Value)
            Else
                row.Cells("打錠費").Value = 0
            End If
        Next
    End Sub
    Private Sub discountBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles discountBox.SelectedIndexChanged
        For Each row As DataGridViewRow In medFee.Rows
            row.Cells("金額").Value = row.Cells("origPrice").Value * medDiscount.Item(discountBox.SelectedValue)
        Next
        For Each row As DataGridViewRow In bioFee.Rows
            row.Cells("金額").Value = row.Cells("origPrice").Value * medDiscount.Item(discountBox.SelectedValue)
        Next
        getTotal()
    End Sub
    Private Sub medFee_bioFee_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles medFee.CellValidated, bioFee.CellValidated
        getTotal()
    End Sub
    Private Sub diagFee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles diagFee.SelectedIndexChanged
        getTotal()
    End Sub
    Private Sub getTotal()
        Dim medSum As Integer = 0
        Dim bioSum As Integer = 0
        For Each row As DataGridViewRow In medFee.Rows
            medSum += CInt(row.Cells("金額").Value) + CInt(row.Cells("打錠費").Value)
        Next
        For Each row As DataGridViewRow In bioFee.Rows
            bioSum += CInt(row.Cells("金額").Value) + CInt(row.Cells("打錠費").Value)
        Next
        medTotal.Text = medSum
        bioTotal.Text = bioSum
        totalSum.Text = medSum + bioSum + (500 + diagFee.SelectedValue) * diagDiscount.Item(discountBox.SelectedValue)
    End Sub
#End Region


#Region "列印"
    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        printDoc.DocumentName = "報表"
        Try
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

        Dim sum As Integer = 0
        Dim sponsoredSum As Integer = 0
        Dim medSum As Integer = 0
        Dim bioSum As Integer = 0
        Dim medOrigSum As Integer = 0
        Dim bioOrigSum As Integer = 0

        For Each row As DataGridViewRow In medFee.Rows
            medOrigSum += CInt(row.Cells("origPrice").Value)
            If row.Cells("makePill").Value Then
                medOrigSum += 100 * Math.Round(Math.Ceiling(row.Cells("medDays").Value / 7) / row.Cells("groupCount").Value)
            End If
            medSum += CInt(row.Cells("金額").Value) + CInt(row.Cells("打錠費").Value)
        Next
        For Each row As DataGridViewRow In bioFee.Rows
            bioOrigSum += CInt(row.Cells("origPrice").Value)
            If row.Cells("makePill").Value Then
                bioOrigSum += 100 * Math.Round(Math.Ceiling(row.Cells("medDays").Value / 7) / row.Cells("groupCount").Value)
            End If
            bioSum += CInt(row.Cells("金額").Value) + CInt(row.Cells("打錠費").Value)
        Next
        sum = medSum + CInt(500 + diagFee.SelectedValue) * diagDiscount.Item(discountBox.SelectedValue)
        sponsoredSum = (medOrigSum + CInt(500 + diagFee.SelectedValue)) - sum

        Dim titleFont As Font = New Font("標楷體", 24, FontStyle.Regular)
        Dim useFont As Font = New Font("標楷體", 14, FontStyle.Regular)
        Dim smallFont As Font = New Font("標楷體", 12, FontStyle.Regular)
        Dim stringFormat As New StringFormat()

        If Not printPage = 2 Then

#Region "頁首"
            '上半標題
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("福濬中醫診所門診醫療費用收據", titleFont, Brushes.Black, New Point(414, 50), stringFormat)

            ' 抬頭
            stringFormat.Alignment = StringAlignment.Near
            Dim twC As System.Globalization.TaiwanCalendar = New System.Globalization.TaiwanCalendar()
            e.Graphics.DrawString("就診日期: " & twC.GetYear(checkDate.Value) & checkDate.Value.ToString("-MM-dd"), smallFont, Brushes.Black, New Point(50, 100), stringFormat)
            e.Graphics.DrawString("病例號碼: " & patientInfo.pID, smallFont, Brushes.Black, New Point(232, 100), stringFormat)
            e.Graphics.DrawString("姓　　名: " & patientInfo.pName, smallFont, Brushes.Black, New Point(414, 100), stringFormat)
            e.Graphics.DrawString("醫生姓名: ", smallFont, Brushes.Black, New Point(595, 100), stringFormat)
            e.Graphics.DrawString("出生日期: " & twC.GetYear(patientInfo.pDOB) & patientInfo.pDOB.ToString("-MM-dd"), smallFont, Brushes.Black, New Point(50, 120), stringFormat)
            e.Graphics.DrawString("性　　別: " & pSex.Text, smallFont, Brushes.Black, New Point(232, 120), stringFormat)
            e.Graphics.DrawString("身分證號: " & patientInfo.pPID, smallFont, Brushes.Black, New Point(414, 120), stringFormat)

            '健保項目
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("健保申報項目", useFont, Brushes.Black, New Point(141, 160), stringFormat)
            e.Graphics.DrawString("診察費", useFont, Brushes.Black, New Point(141, 190), stringFormat)
            e.Graphics.DrawString("藥費", useFont, Brushes.Black, New Point(141, 220), stringFormat)
            e.Graphics.DrawString("藥事服務費", useFont, Brushes.Black, New Point(141, 250), stringFormat)
            e.Graphics.DrawString("注射費", useFont, Brushes.Black, New Point(141, 280), stringFormat)
            e.Graphics.DrawString("檢驗費", useFont, Brushes.Black, New Point(141, 310), stringFormat)
            e.Graphics.DrawString("處置手術費", useFont, Brushes.Black, New Point(141, 340), stringFormat)
            e.Graphics.DrawString("材料費", useFont, Brushes.Black, New Point(141, 370), stringFormat)
            e.Graphics.DrawString("小計", useFont, Brushes.Black, New Point(141, 400), stringFormat)
            e.Graphics.DrawString("應繳金額", useFont, Brushes.Black, New Point(141, 430), stringFormat)

            stringFormat.Alignment = StringAlignment.Far
            e.Graphics.DrawString("點", useFont, Brushes.Black, New Point(394, 400), stringFormat)
            e.Graphics.DrawString("元", useFont, Brushes.Black, New Point(394, 430), stringFormat)
            stringFormat.Alignment = StringAlignment.Near
            e.Graphics.DrawString("健保申請", useFont, Brushes.Black, New Point(252, 400), stringFormat)

            '健保點數
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("點數", useFont, Brushes.Black, New Point(323, 160), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(323, 190), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(323, 220), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(323, 250), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(323, 280), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(323, 310), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(323, 340), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(323, 370), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(348, 400), stringFormat)

            stringFormat.Alignment = StringAlignment.Far
            e.Graphics.DrawString(sum.ToString, useFont, Brushes.Black, New Point(355, 430), stringFormat)

            '自付費項目
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("自付費用項目", useFont, Brushes.Black, New Point(505, 160), stringFormat)
            e.Graphics.DrawString("掛號費", useFont, Brushes.Black, New Point(505, 190), stringFormat)
            e.Graphics.DrawString("診察費", useFont, Brushes.Black, New Point(505, 220), stringFormat)
            e.Graphics.DrawString("藥費", useFont, Brushes.Black, New Point(505, 250), stringFormat)
            e.Graphics.DrawString("檢驗檢查", useFont, Brushes.Black, New Point(505, 280), stringFormat)
            e.Graphics.DrawString("針灸費", useFont, Brushes.Black, New Point(505, 310), stringFormat)
            e.Graphics.DrawString("其他", useFont, Brushes.Black, New Point(505, 340), stringFormat)
            e.Graphics.DrawString("小計", useFont, Brushes.Black, New Point(505, 370), stringFormat)
            e.Graphics.DrawString("收款人", useFont, Brushes.Black, New Point(505, 400), stringFormat)
            e.Graphics.DrawString("收款日期", useFont, Brushes.Black, New Point(505, 430), stringFormat)

            '自付金額
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("金額", useFont, Brushes.Black, New Point(686, 160), stringFormat)
            e.Graphics.DrawString(diagFee.SelectedValue * diagDiscount.Item(discountBox.SelectedValue), smallFont, Brushes.Black, New Point(686, 190), stringFormat)
            e.Graphics.DrawString(500 * diagDiscount.Item(discountBox.SelectedValue), smallFont, Brushes.Black, New Point(686, 220), stringFormat)
            e.Graphics.DrawString(CInt(medSum).ToString, smallFont, Brushes.Black, New Point(686, 250), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(686, 280), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(686, 310), stringFormat)
            e.Graphics.DrawString("0", smallFont, Brushes.Black, New Point(686, 340), stringFormat)
            e.Graphics.DrawString(sum.ToString, smallFont, Brushes.Black, New Point(686, 370), stringFormat)
            e.Graphics.DrawString(twC.GetYear(Now) & Now.ToString("-MM-dd HH:mm"), smallFont, Brushes.Black, New Point(686, 430), stringFormat)

            ' 註腳
            stringFormat.Alignment = StringAlignment.Near
            e.Graphics.DrawString("診所名稱: 福濬中醫診所", useFont, Brushes.Black, New Point(50, 465), stringFormat)
            e.Graphics.DrawString("電話: 03-3277900", useFont, Brushes.Black, New Point(414, 465), stringFormat)
            e.Graphics.DrawString("傳真: 03-3273989", useFont, Brushes.Black, New Point(595, 465), stringFormat)
            e.Graphics.DrawString("診所地址: 桃園縣龜山區文化二路30之11號", useFont, Brushes.Black, New Point(50, 485), stringFormat)
            e.Graphics.DrawString("備註: 本收據僅供繳費證明用，遺失恕不補發，請妥善保存。", useFont, Brushes.Black, New Point(50, 505), stringFormat)

            '外框
            For x = 0 To 4
                e.Graphics.DrawLine(Pens.Black, New Point(50 + 182 * x, 154), New Point(50 + 182 * x, 454))
            Next
            For y = 0 To 10
                e.Graphics.DrawLine(Pens.Black, New Point(50, 154 + 30 * y), New Point(778, 154 + 30 * y))
            Next

            '切割線
            For x = 0 To 80 Step 2
                e.Graphics.DrawLine(Pens.Black, New Point(50 + x * 9, 585), New Point(59 + x * 9, 585))
            Next

#End Region

#Region "基金會補助"

            Select Case printPage
                Case 0
                    ' ==================================================================================================================================================
                    ' =                                                  printPage 1 - Sponsored Fees
                    ' ==================================================================================================================================================
                    If Not discountBox.SelectedIndex = 0 Or Not sponsoredSum = 0 Then

                        '下半標題
                        stringFormat.Alignment = StringAlignment.Center
                        e.Graphics.DrawString("財團法人福濬傳統研究基金會醫療補助費用明細", titleFont, Brushes.Black, New Point(414, 635), stringFormat)

                        ' 抬頭
                        stringFormat.Alignment = StringAlignment.Near
                        e.Graphics.DrawString("日期: " & twC.GetYear(checkDate.Value) & checkDate.Value.ToString("-MM-dd"), useFont, Brushes.Black, New Point(50, 695), stringFormat)
                        e.Graphics.DrawString("姓名: " & patientInfo.pName, useFont, Brushes.Black, New Point(232, 695), stringFormat)
                        e.Graphics.DrawString("身分證字號: " & patientInfo.pPID, useFont, Brushes.Black, New Point(414, 695), stringFormat)

                        '補給項目
                        stringFormat.Alignment = StringAlignment.Center
                        e.Graphics.DrawString("項目/內容", useFont, Brushes.Black, New Point(141, 740), stringFormat)
                        e.Graphics.DrawString("掛號費", useFont, Brushes.Black, New Point(141, 770), stringFormat)
                        e.Graphics.DrawString("診察費", useFont, Brushes.Black, New Point(141, 800), stringFormat)
                        e.Graphics.DrawString("檢驗費", useFont, Brushes.Black, New Point(141, 830), stringFormat)
                        e.Graphics.DrawString("藥費", useFont, Brushes.Black, New Point(141, 860), stringFormat)
                        e.Graphics.DrawString("合計", useFont, Brushes.Black, New Point(141, 920), stringFormat)
                        e.Graphics.DrawString("金額", useFont, Brushes.Black, New Point(323, 740), stringFormat)
                        e.Graphics.DrawString("備註", useFont, Brushes.Black, New Point(595, 740), stringFormat)

                        '補給金額
                        stringFormat.Alignment = StringAlignment.Center
                        e.Graphics.DrawString(CInt(diagFee.SelectedValue * (1 - diagDiscount.Item(discountBox.SelectedValue))).ToString, useFont, Brushes.Black, New Point(323, 770), stringFormat)
                        e.Graphics.DrawString(CInt(500 * (1 - diagDiscount.Item(discountBox.SelectedValue))).ToString, useFont, Brushes.Black, New Point(323, 800), stringFormat)
                        e.Graphics.DrawString(CInt(0).ToString, useFont, Brushes.Black, New Point(323, 830), stringFormat)
                        e.Graphics.DrawString(CInt(medOrigSum - medSum).ToString, useFont, Brushes.Black, New Point(323, 860), stringFormat)
                        e.Graphics.DrawString(CInt(sponsoredSum).ToString, useFont, Brushes.Black, New Point(323, 920), stringFormat)
                        e.Graphics.DrawString(CInt(sponsoredSum).ToString, useFont, Brushes.Black, New Point(232, 1000), stringFormat)


                        '外框
                        For x = 0 To 4
                            If Not x = 3 Then
                                e.Graphics.DrawLine(Pens.Black, New Point(50 + 182 * x, 735), New Point(50 + 182 * x, 945))
                            End If
                        Next
                        For y = 0 To 7
                            e.Graphics.DrawLine(Pens.Black, New Point(50, 735 + 30 * y), New Point(778, 735 + 30 * y))
                        Next

                        ' 簽名
                        stringFormat.Alignment = StringAlignment.Near
                        e.Graphics.DrawString("補助金額: ", useFont, Brushes.Black, New Point(50, 1000), stringFormat)
                        e.Graphics.DrawString("簽名:", useFont, Brushes.Black, New Point(414, 1000), stringFormat)
                        e.Graphics.DrawLine(Pens.Black, New Point(131, 1020), New Point(323, 1020))
                        e.Graphics.DrawLine(Pens.Black, New Point(465, 1020), New Point(717, 1020))
                    End If
                    printPage = 1
#End Region

#Region "詳細資訊"
                Case 1
                    ' ==================================================================================================================================================
                    ' =                                                  printPage 2 - Detailed Info
                    ' ==================================================================================================================================================

                    '下半標題
                    stringFormat.Alignment = StringAlignment.Center
                    e.Graphics.DrawString("藥品費用明細", titleFont, Brushes.Black, New Point(414, 635), stringFormat)

                    ''外框
                    'For x = 0 To 4
                    '    e.graphics.drawline(Pens.Black,New Point(50 + 182 * x, 690), New Point(50 + 182 * x, 1110))
                    '    e.Graphics.DrawPath(Pens.Black, outlinePath)
                    '    outlinePath.Reset()
                    'Next
                    'For y = 0 To 14
                    '    e.graphics.drawline(Pens.Black,New Point(50, 690 + 30 * y), New Point(778, 690 + 30 * y))
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
                        e.Graphics.DrawString("藥品名稱", useFont, Brushes.Black, New Point((354 * i) + 141, 695), stringFormat)
                        e.Graphics.DrawString("天數", useFont, Brushes.Black, New Point((354 * i) + 280, 695), stringFormat)
                        e.Graphics.DrawString("數量", useFont, Brushes.Black, New Point((354 * i) + 330, 695), stringFormat)
                        e.Graphics.DrawString("金額", useFont, Brushes.Black, New Point((354 * i) + 380, 695), stringFormat)
                    Next

                    For i = 0 To medFee.Rows.Count - 1
                        e.Graphics.DrawString(medFee.Rows(i).Cells("藥品名稱").Value, useFont, Brushes.Black, New Point((354 * Math.Floor(i / 19)) + 141, 725 + (i Mod 19) * 20), stringFormat)
                        e.Graphics.DrawString(medFee.Rows(i).Cells("medDays").Value, useFont, Brushes.Black, New Point((354 * Math.Floor(i / 19)) + 280, 725 + (i Mod 19) * 20), stringFormat)
                        e.Graphics.DrawString(medFee.Rows(i).Cells("總量").Value & medFee.Rows(i).Cells("單位").Value, useFont, Brushes.Black, New Point((354 * Math.Floor(i / 19)) + 330, 725 + (i Mod 19) * 20), stringFormat)
                        e.Graphics.DrawString(medFee.Rows(i).Cells("金額").Value, useFont, Brushes.Black, New Point((354 * Math.Floor(i / 19)) + 380, 725 + (i Mod 19) * 20), stringFormat)
                    Next

                    stringFormat.Alignment = StringAlignment.Near
                    e.Graphics.DrawString("警語: 服藥期間請勿喝咖啡。", useFont, Brushes.Black, New Point(50, 1115), stringFormat)

                    printPage = 2
            End Select
#End Region
        Else

            ' ==================================================================================================================================================
            ' =                                                  printPage 3 - bioMed Info
            ' ==================================================================================================================================================

            '上半標題
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("建議用藥費用明細", titleFont, Brushes.Black, New Point(414, 50), stringFormat)

            '底線
            e.Graphics.DrawLine(Pens.Black, New Point(101, 120), New Point(181, 120))
            e.Graphics.DrawLine(Pens.Black, New Point(260, 120), New Point(300, 120))
            e.Graphics.DrawLine(Pens.Black, New Point(330, 120), New Point(370, 120))
            e.Graphics.DrawLine(Pens.Black, New Point(400, 120), New Point(440, 120))
            e.Graphics.DrawLine(Pens.Black, New Point(460, 120), New Point(540, 120))

            '抬頭
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("藥品名稱", useFont, Brushes.Black, New Point(141, 100), stringFormat)
            e.Graphics.DrawString("天數", useFont, Brushes.Black, New Point(280, 100), stringFormat)
            e.Graphics.DrawString("總量", useFont, Brushes.Black, New Point(350, 100), stringFormat)
            e.Graphics.DrawString("金額", useFont, Brushes.Black, New Point(420, 100), stringFormat)
            e.Graphics.DrawString("補助金額", useFont, Brushes.Black, New Point(500, 100), stringFormat)

            Dim i As Integer = 1
            For Each row As DataGridViewRow In bioFee.Rows
                e.Graphics.DrawString(row.Cells("藥品名稱").Value, useFont, Brushes.Black, New Point(141, 110 + i * 20), stringFormat)
                e.Graphics.DrawString(row.Cells("medDays").Value, useFont, Brushes.Black, New Point(280, 110 + i * 20), stringFormat)
                e.Graphics.DrawString(row.Cells("總量").Value, useFont, Brushes.Black, New Point(350, 110 + i * 20), stringFormat)
                e.Graphics.DrawString(row.Cells("金額").Value, useFont, Brushes.Black, New Point(420, 110 + i * 20), stringFormat)
                e.Graphics.DrawString(row.Cells("origPrice").Value - row.Cells("金額").Value, useFont, Brushes.Black, New Point(500, 110 + i * 20), stringFormat)
                i += 1
            Next

            stringFormat.Alignment = StringAlignment.Near
            e.Graphics.DrawString("總計: " & bioSum, titleFont, Brushes.Black, New Point(50, 1040), stringFormat)
            e.Graphics.DrawString("備註: 本收據僅供診所收費證明用，請勿給病患。", useFont, Brushes.Black, New Point(50, 1105), stringFormat)

            printPage = 3
        End If

        If Not printPage = 3 Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
        Debug.WriteLine(e.HasMorePages)
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
#End Region
End Class
