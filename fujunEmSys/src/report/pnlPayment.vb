Public Class pnlPayment
    Inherits pnlSlider

    Private init As Boolean = True
    Private patientInfo As New pInfo
    Dim discountType As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 折扣
    Dim diagDiscount As Dictionary(Of Integer, Double) = New Dictionary(Of Integer, Double) ' 診費折扣
    Dim medDiscount As Dictionary(Of Integer, Double) = New Dictionary(Of Integer, Double) ' 藥費折扣
    Dim diagFeeType As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 診費
    Dim unit As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
    Dim groupUnit As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 群組單位

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
        groupUnit.Add(1, "包")
        groupUnit.Add(2, "顆")
        groupUnit.Add(3, "匙")
        groupUnit.Add(4, "盒")

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

        If mainForm.debugMode.Checked Then
            fullListView.Visible = True
        End If

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
        If Not mainForm.debugMode.Checked Then
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
        End If

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
        getTotal()
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
        medTotal.Text = medSum + (500 + diagFee.SelectedValue) * diagDiscount.Item(discountBox.SelectedValue)
        bioTotal.Text = bioSum
        totalSum.Text = medSum + bioSum + (500 + diagFee.SelectedValue) * diagDiscount.Item(discountBox.SelectedValue)
    End Sub
#End Region


#Region "列印"
    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click
        printDoc.DocumentName = "報表"
        If mainForm.debugMode.Checked Then
            printPreviewDlg.ShowDialog()
        Else
            Try
                If printDlg.ShowDialog() = DialogResult.OK Then printDoc.Print()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If
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
        Dim diagSum As Integer = 500 * diagDiscount.Item(discountBox.SelectedValue) + diagFee.SelectedValue * diagDiscount.Item(discountBox.SelectedValue)
        Dim diagOrigSum As Integer = 500 + diagFee.SelectedValue
        Dim docName As String = ""
        Dim reader As IDataReader = runQuery("SELECT d.docName FROM patient_booking AS pb 
                                              INNER JOIN doctor AS d ON d.docID = pb.docID 
                                              WHERE bID=" & waitingList.SelectedValue)
        If reader.Read Then docName = reader.GetString(0) Else docName = ""
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
        Dim twC As System.Globalization.TaiwanCalendar = New System.Globalization.TaiwanCalendar()

        If printPage < 2 Then

#Region "頁首"
            '上半標題
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("福濬中醫診所門診醫療費用收據", titleFont, Brushes.Black, New Point(414, 50), stringFormat)

            ' 抬頭
            stringFormat.Alignment = StringAlignment.Near
            e.Graphics.DrawString("就診日期: " & twC.GetYear(checkDate.Value) & checkDate.Value.ToString("-MM-dd"), smallFont, Brushes.Black, New Point(50, 100), stringFormat)
            e.Graphics.DrawString("病歷號碼: " & patientInfo.pID, smallFont, Brushes.Black, New Point(232, 100), stringFormat)
            e.Graphics.DrawString("姓　　名: " & patientInfo.pName, smallFont, Brushes.Black, New Point(414, 100), stringFormat)
            e.Graphics.DrawString("醫生姓名: " & docName, smallFont, Brushes.Black, New Point(595, 100), stringFormat)
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
            e.Graphics.DrawString("診所地址: 桃園市龜山區文化二路30之11號", useFont, Brushes.Black, New Point(50, 485), stringFormat)
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
                e.Graphics.DrawLine(Pens.Black, New Point(50 + x * 9, 570), New Point(59 + x * 9, 570))
            Next

#End Region
            Select Case printPage
                Case 0
#Region "基金會補助"
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
                        e.Graphics.DrawLine(Pens.Black, New Point(150, 1020), New Point(323, 1020))
                        e.Graphics.DrawLine(Pens.Black, New Point(465, 1020), New Point(717, 1020))
                    End If
#End Region
                    printPage = 1
                Case 1
#Region "病人處方籤"
                    ' ==================================================================================================================================================
                    ' =                                                  printPage 2 - Med List
                    ' ==================================================================================================================================================
                    '標題
                    stringFormat.Alignment = StringAlignment.Center
                    e.Graphics.DrawString("福濬中醫診所處方籤", titleFont, Brushes.Black, New Point(414, 600), stringFormat)

                    stringFormat.Alignment = StringAlignment.Near
                    e.Graphics.DrawString("病歷號: " & patientInfo.pID, useFont, Brushes.Black, New Point(50, 640), stringFormat)
                    e.Graphics.DrawString("姓名: " & pName.Text, useFont, Brushes.Black, New Point(232, 640), stringFormat)
                    e.Graphics.DrawString("性別: " & pSex.Text, useFont, Brushes.Black, New Point(414, 640), stringFormat)
                    e.Graphics.DrawString("出生日期: " & twC.GetYear(patientInfo.pDOB) & patientInfo.pDOB.ToString("-MM-dd"), useFont, Brushes.Black, New Point(595, 640), stringFormat)
                    e.Graphics.DrawString("醫師: " & docName, useFont, Brushes.Black, New Point(50, 660), stringFormat)
                    e.Graphics.DrawString("調劑者: " & docName, useFont, Brushes.Black, New Point(232, 660), stringFormat)
                    e.Graphics.DrawString("調劑日期: " & twC.GetYear(checkDate.Value) & checkDate.Value.ToString("-MM-dd"), useFont, Brushes.Black, New Point(414, 660), stringFormat)

                    Dim resultText As String = ""
                    If mainForm.debugMode.Checked And Not patientInfo.initiated Then
                        'If mainForm.debugMode.Checked Then
                        resultText = "藥物清單: １２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０"
                        warpText(resultText, 55, 700, 750, 380, useFont, e)
                    Else
#Region "藥物清單"
                        e.Graphics.DrawLine(Pens.Black, New Point(50, 690), New Point(778, 690))

                        fullListView.DataSource = returnData(mainForm, "Select group_concat(mi.medName) as '藥品清單', group_concat(mi.medName,'(',mg.meddays*md.medAmount,'|',md.medUnit,')') as 'medList',
                                                               mg.morning as '早', mg.noon as '午', mg.night as '晚', mg.beforeSleep as '睡前', mg.notWell as '不適時', 
                                                               mg.beforeMeal as '飯前', mg.afterMeal as '飯後', 
                                                               mg.medDays as '天數', 
                                                               mg.medAmount as '份量', mg.medUnit, null as '單位',
                                                               mg.makePill as '打錠'
                                                        FROM medGroup2medDetail as mg
                                                        INNER JOIN medDetail AS md ON mg.mgID = md.mgID
                                                        INNER JOIN med_item as mi on md.medID = mi.medID
                                                        WHERE bID=" & waitingList.SelectedValue & " AND mi.bioMed = 0
                                                        GROUP BY mg.mgid")

                        Dim perscription As String = ""
                        For printIndex As Integer = 0 To fullListView.Rows.Count - 1

                            perscription += "- "

                            Dim medList As String() = fullListView.Rows(printIndex).Cells("medList").Value.ToString.Split(",")
                            For i = 0 To medList.Count - 1
                                Dim unitList As String() = medList(i).Split("|")
                                unitList(1) = unit(CInt(Mid(unitList(1), 1, Len(unitList(1)) - 1))) & ")"
                                medList(i) = String.Join("", unitList)
                            Next

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
                            If usage = "" And fullListView.Rows(printIndex).Cells("不適時").Value Then
                                usage += "有症狀時"
                            Else
                                usage += "和有症狀時"
                            End If
                            usage += "服用" & fullListView.Rows(printIndex).Cells("份量").Value & groupUnit(fullListView.Rows(printIndex).Cells("medUnit").Value)

                            perscription += String.Join(", ", medList) & ", " & fullListView.Rows(printIndex).Cells("天數").Value & "天, 每天" & usage & "。" & vbNewLine
                        Next
                        warpText(perscription, 50, 700, 750, 380, useFont, e)
                    End If
                    e.Graphics.DrawLine(Pens.Black, New Point(50, 1070), New Point(778, 1070))
#End Region


                    '頁尾
                    stringFormat.Alignment = StringAlignment.Near
                    e.Graphics.DrawString("調劑地點: 福濬中醫診所" & vbNewLine &
                                          "地址: 桃園市龜山區文化二路30-11號", useFont, Brushes.Black, New Point(50, 1080), stringFormat)
                    e.Graphics.DrawString("電話: 03-3277900" & vbNewLine &
                                          "警語: 服藥期間請勿喝咖啡", useFont, Brushes.Black, New Point(414, 1080), stringFormat)
#End Region
                    printPage = 2
            End Select
        ElseIf printPage = 2 Then
#Region "費用明細"

            '基本資料
            stringFormat.Alignment = StringAlignment.Near
            e.Graphics.DrawString("病歷號: " & patientInfo.pID, useFont, Brushes.Black, New Point(50, 50), stringFormat)
            e.Graphics.DrawString("姓名: " & pName.Text, useFont, Brushes.Black, New Point(232, 50), stringFormat)
            e.Graphics.DrawString("診費: " & diagSum, useFont, Brushes.Black, New Point(414, 50), stringFormat)
            e.Graphics.DrawString("就醫日期: " & twC.GetYear(checkDate.Value) & checkDate.Value.ToString("-MM-dd"), useFont, Brushes.Black, New Point(565, 50), stringFormat)

#Region "藥品費用明細"
            ' ==================================================================================================================================================
            ' =                                                  printPage 3 - Clinic Fee
            ' ==================================================================================================================================================

            '上半標題
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("藥品費用明細", titleFont, Brushes.Black, New Point(414, 85), stringFormat)

            '底線
            e.Graphics.DrawLine(Pens.Black, New Point(110, 150), New Point(190, 150))
            e.Graphics.DrawLine(Pens.Black, New Point(270, 150), New Point(330, 150))
            e.Graphics.DrawLine(Pens.Black, New Point(375, 150), New Point(430, 150))
            e.Graphics.DrawLine(Pens.Black, New Point(470, 150), New Point(530, 150))
            e.Graphics.DrawLine(Pens.Black, New Point(570, 150), New Point(630, 150))
            e.Graphics.DrawLine(Pens.Black, New Point(670, 150), New Point(730, 150))

            '抬頭
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("藥品名稱", useFont, Brushes.Black, New Point(150, 130), stringFormat)
            e.Graphics.DrawString("天數", useFont, Brushes.Black, New Point(300, 130), stringFormat)
            e.Graphics.DrawString("數量", useFont, Brushes.Black, New Point(400, 130), stringFormat)
            e.Graphics.DrawString("原價", useFont, Brushes.Black, New Point(500, 130), stringFormat)
            e.Graphics.DrawString("折扣", useFont, Brushes.Black, New Point(600, 130), stringFormat)
            e.Graphics.DrawString("實收", useFont, Brushes.Black, New Point(700, 130), stringFormat)

            Dim displayRow As Integer = 24

            If mainForm.debugMode.Checked And Not patientInfo.initiated Then
                'If mainForm.debugMode.Checked Then
                For i = 0 To displayRow
                    e.Graphics.DrawString("無敵霹靂長的藥名", smallFont, Brushes.Black, New Point(150, 160 + i * 20), stringFormat)
                    e.Graphics.DrawString("888", smallFont, Brushes.Black, New Point(300, 160 + i * 20), stringFormat)
                    e.Graphics.DrawString("8888.88克", smallFont, Brushes.Black, New Point(400, 160 + i * 20), stringFormat)
                    e.Graphics.DrawString("88888.88", smallFont, Brushes.Black, New Point(500, 160 + i * 20), stringFormat)
                    e.Graphics.DrawString("88888.88", smallFont, Brushes.Black, New Point(600, 160 + i * 20), stringFormat)
                    e.Graphics.DrawString("88888.88", smallFont, Brushes.Black, New Point(700, 160 + i * 20), stringFormat)
                Next
            Else
                Dim i As Integer = 0
                For Each row As DataGridViewRow In medFee.Rows
                    e.Graphics.DrawString(row.Cells("藥品名稱").Value, smallFont, Brushes.Black, New Point(150, 160 + i * 20), stringFormat)
                    e.Graphics.DrawString(row.Cells("medDays").Value, smallFont, Brushes.Black, New Point(300, 160 + i * 20), stringFormat)
                    e.Graphics.DrawString(row.Cells("總量").Value & row.Cells("單位").Value, smallFont, Brushes.Black, New Point(400, 160 + i * 20), stringFormat)
                    e.Graphics.DrawString(row.Cells("origPrice").Value, smallFont, Brushes.Black, New Point(500, 160 + i * 20), stringFormat)
                    e.Graphics.DrawString(row.Cells("origPrice").Value - row.Cells("金額").Value, smallFont, Brushes.Black, New Point(600, 160 + i * 20), stringFormat)
                    e.Graphics.DrawString(row.Cells("金額").Value, smallFont, Brushes.Black, New Point(700, 160 + i * 20), stringFormat)
                    i += 1
                Next
            End If
#End Region
#Region "建議用藥費用明細"
            ' ==================================================================================================================================================
            ' =                                                  printPage 3 - BioMed Fee
            ' ==================================================================================================================================================

            '下半標題
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("建議用藥費用明細", titleFont, Brushes.Black, New Point(414, 680), stringFormat)


            '底線
            e.Graphics.DrawLine(Pens.Black, New Point(110, 745), New Point(190, 745))
            e.Graphics.DrawLine(Pens.Black, New Point(270, 745), New Point(330, 745))
            e.Graphics.DrawLine(Pens.Black, New Point(375, 745), New Point(430, 745))
            e.Graphics.DrawLine(Pens.Black, New Point(470, 745), New Point(530, 745))
            e.Graphics.DrawLine(Pens.Black, New Point(570, 745), New Point(630, 745))
            e.Graphics.DrawLine(Pens.Black, New Point(670, 745), New Point(730, 745))

            '抬頭
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("藥品名稱", useFont, Brushes.Black, New Point(150, 725), stringFormat)
            e.Graphics.DrawString("天數", useFont, Brushes.Black, New Point(300, 725), stringFormat)
            e.Graphics.DrawString("數量", useFont, Brushes.Black, New Point(400, 725), stringFormat)
            e.Graphics.DrawString("原價", useFont, Brushes.Black, New Point(500, 725), stringFormat)
            e.Graphics.DrawString("折扣", useFont, Brushes.Black, New Point(600, 725), stringFormat)
            e.Graphics.DrawString("實收", useFont, Brushes.Black, New Point(700, 725), stringFormat)

            If mainForm.debugMode.Checked And Not patientInfo.initiated Then
                'If mainForm.debugMode.Checked Then
                For i = 0 To 10
                    e.Graphics.DrawString("無敵霹靂長的藥名", smallFont, Brushes.Black, New Point(150, 755 + i * 20), stringFormat)
                    e.Graphics.DrawString("888", smallFont, Brushes.Black, New Point(300, 755 + i * 20), stringFormat)
                    e.Graphics.DrawString("8888.88克", smallFont, Brushes.Black, New Point(400, 755 + i * 20), stringFormat)
                    e.Graphics.DrawString("88888.88", smallFont, Brushes.Black, New Point(500, 755 + i * 20), stringFormat)
                    e.Graphics.DrawString("88888.88", smallFont, Brushes.Black, New Point(600, 755 + i * 20), stringFormat)
                    e.Graphics.DrawString("88888.88", smallFont, Brushes.Black, New Point(700, 755 + i * 20), stringFormat)
                Next
            Else
                Dim i As Integer = 0
                For Each row As DataGridViewRow In bioFee.Rows
                    e.Graphics.DrawString(row.Cells("藥品名稱").Value, smallFont, Brushes.Black, New Point(150, 755 + i * 20), stringFormat)
                    e.Graphics.DrawString(row.Cells("medDays").Value, smallFont, Brushes.Black, New Point(300, 755 + i * 20), stringFormat)
                    e.Graphics.DrawString(row.Cells("總量").Value & row.Cells("單位").Value, smallFont, Brushes.Black, New Point(400, 755 + i * 20), stringFormat)
                    e.Graphics.DrawString(row.Cells("origPrice").Value, smallFont, Brushes.Black, New Point(500, 755 + i * 20), stringFormat)
                    e.Graphics.DrawString(row.Cells("origPrice").Value - row.Cells("金額").Value, smallFont, Brushes.Black, New Point(600, 755 + i * 20), stringFormat)
                    e.Graphics.DrawString(row.Cells("金額").Value, smallFont, Brushes.Black, New Point(700, 755 + i * 20), stringFormat)
                    i += 1
                Next
            End If
#End Region

            stringFormat.Alignment = StringAlignment.Near
            e.Graphics.DrawString("診所小計: " & medSum + diagSum, useFont, Brushes.Black, New Point(50, 1100), stringFormat)
            e.Graphics.DrawString("生醫小計: " & bioSum, useFont, Brushes.Black, New Point(232, 1100), stringFormat)
            e.Graphics.DrawString("總計: " & medSum + bioSum + diagSum, useFont, Brushes.Black, New Point(414, 1100), stringFormat)
            e.Graphics.DrawString("折扣總計: " & (medOrigSum + bioOrigSum + diagOrigSum) - (medSum + bioSum + diagSum), useFont, Brushes.Black, New Point(595, 1100), stringFormat)

            printPage = 3
        ElseIf printPage = 3 Then
#Region "診所處方簽"
            ' ==================================================================================================================================================
            ' =                                                  printPage 4 - Med List
            ' ==================================================================================================================================================
            '標題
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("福濬中醫診所處方籤", titleFont, Brushes.Black, New Point(414, 50), stringFormat)

            stringFormat.Alignment = StringAlignment.Near
            e.Graphics.DrawString("病歷號: " & patientInfo.pID, useFont, Brushes.Black, New Point(50, 90), stringFormat)
            e.Graphics.DrawString("姓名: " & pName.Text, useFont, Brushes.Black, New Point(232, 90), stringFormat)
            e.Graphics.DrawString("性別: " & pSex.Text, useFont, Brushes.Black, New Point(414, 90), stringFormat)
            e.Graphics.DrawString("出生日期: " & twC.GetYear(patientInfo.pDOB) & patientInfo.pDOB.ToString("-MM-dd"), useFont, Brushes.Black, New Point(595, 90), stringFormat)
            e.Graphics.DrawString("醫師: " & docName, useFont, Brushes.Black, New Point(50, 110), stringFormat)
            e.Graphics.DrawString("調劑者: " & docName, useFont, Brushes.Black, New Point(232, 110), stringFormat)
            e.Graphics.DrawString("調劑日期: " & twC.GetYear(checkDate.Value) & checkDate.Value.ToString("-MM-dd"), useFont, Brushes.Black, New Point(414, 110), stringFormat)

            Dim resultText As String = ""
            If mainForm.debugMode.Checked And Not patientInfo.initiated Then
                'If mainForm.debugMode.Checked Then
                resultText = "病人主訴: １２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０"
                warpText(resultText, 50, 130, 740, 120, useFont, e)
                e.Graphics.DrawLine(Pens.Black, New Point(50, 250), New Point(778, 250))
                resultText = "藥物清單: １２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０"
                warpText(resultText, 50, 260, 740, 380, useFont, e)
            Else
#Region "藥物清單"
                reader = runQuery("SELECT concern FROM patient_booking WHERE bID=" & waitingList.SelectedValue)
                If reader.Read Then
                    If reader.IsDBNull(0) Then resultText = "病人主訴:" Else resultText = "病人主訴: " & reader.GetString(0)
                End If
                warpText(resultText, 50, 130, 740, 120, useFont, e)

                e.Graphics.DrawLine(Pens.Black, New Point(50, 250), New Point(778, 250))

                fullListView.DataSource = returnData(mainForm, "Select group_concat(mi.medName) as '藥品清單', group_concat(mi.medName,'(',mg.meddays*md.medAmount,'|',md.medUnit,')') as 'medList',
                                                               mg.morning as '早', mg.noon as '午', mg.night as '晚', mg.beforeSleep as '睡前', mg.notWell as '不適時', 
                                                               mg.beforeMeal as '飯前', mg.afterMeal as '飯後', 
                                                               mg.medDays as '天數', 
                                                               mg.medAmount as '份量', mg.medUnit, null as '單位',
                                                               mg.makePill as '打錠'
                                                        FROM medGroup2medDetail as mg
                                                        INNER JOIN medDetail AS md ON mg.mgID = md.mgID
                                                        INNER JOIN med_item as mi on md.medID = mi.medID
                                                        WHERE bID=" & waitingList.SelectedValue & " AND mi.bioMed = 0
                                                        GROUP BY mg.mgid")

                Dim perscription As String = ""
                For printIndex As Integer = 0 To fullListView.Rows.Count - 1

                    perscription += "- "

                    Dim medList As String() = fullListView.Rows(printIndex).Cells("medList").Value.ToString.Split(",")
                    For i = 0 To medList.Count - 1
                        Dim unitList As String() = medList(i).Split("|")
                        unitList(1) = unit(CInt(Mid(unitList(1), 1, Len(unitList(1)) - 1))) & ")"
                        medList(i) = String.Join("", unitList)
                    Next

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
                    If usage = "" And fullListView.Rows(printIndex).Cells("不適時").Value Then
                        usage += "有症狀時"
                    Else
                        usage += "和有症狀時"
                    End If
                    usage += "服用" & fullListView.Rows(printIndex).Cells("份量").Value & groupUnit(fullListView.Rows(printIndex).Cells("medUnit").Value)

                    perscription += String.Join(", ", medList) & ", " & fullListView.Rows(printIndex).Cells("天數").Value & "天, 每天" & usage & "。" & vbNewLine
                Next
                warpText(perscription, 50, 260, 740, 380, useFont, e)
            End If
#End Region
#End Region
            e.Graphics.DrawLine(Pens.Black, New Point(50, 620), New Point(778, 620))
#Region "建議用藥"
            ' ==================================================================================================================================================
            ' =                                                  printPage 4 - Recommend
            ' ==================================================================================================================================================
            '標題
            stringFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString("建議用藥處方籤", titleFont, Brushes.Black, New Point(414, 640), stringFormat)

            resultText = ""
            If mainForm.debugMode.Checked And Not patientInfo.initiated Then
                'If mainForm.debugMode.Checked Then
                resultText = "藥物清單: １２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０１２３４５６７８９０"
                warpText(resultText, 55, 700, 750, 380, useFont, e)
            Else
#Region "藥物清單"
                e.Graphics.DrawLine(Pens.Black, New Point(50, 690), New Point(778, 690))

                fullListView.DataSource = returnData(mainForm, "Select group_concat(mi.medName) as '藥品清單', group_concat(mi.medName,'(',mg.meddays*md.medAmount,'|',md.medUnit,')') as 'medList',
                                                               mg.morning as '早', mg.noon as '午', mg.night as '晚', mg.beforeSleep as '睡前', mg.notWell as '不適時', 
                                                               mg.beforeMeal as '飯前', mg.afterMeal as '飯後', 
                                                               mg.medDays as '天數', 
                                                               mg.medAmount as '份量', mg.medUnit, null as '單位',
                                                               mg.makePill as '打錠'
                                                        FROM medGroup2medDetail as mg
                                                        INNER JOIN medDetail AS md ON mg.mgID = md.mgID
                                                        INNER JOIN med_item as mi on md.medID = mi.medID
                                                        WHERE bID=" & waitingList.SelectedValue & " AND mi.bioMed = 1
                                                        GROUP BY mg.mgid")

                Dim perscription As String = ""
                For printIndex As Integer = 0 To fullListView.Rows.Count - 1

                    perscription += "- "

                    Dim medList As String() = fullListView.Rows(printIndex).Cells("medList").Value.ToString.Split(",")
                    For i = 0 To medList.Count - 1
                        Dim unitList As String() = medList(i).Split("|")
                        unitList(1) = unit(CInt(Mid(unitList(1), 1, Len(unitList(1)) - 1))) & ")"
                        medList(i) = String.Join("", unitList)
                    Next

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
                    If usage = "" And fullListView.Rows(printIndex).Cells("不適時").Value Then
                        usage += "有症狀時"
                    Else
                        usage += "和有症狀時"
                    End If
                    usage += "服用" & fullListView.Rows(printIndex).Cells("份量").Value & groupUnit(fullListView.Rows(printIndex).Cells("medUnit").Value)

                    perscription += String.Join(", ", medList) & ", " & fullListView.Rows(printIndex).Cells("天數").Value & "天, 每天" & usage & "。" & vbNewLine
                Next
                warpText(perscription, 50, 700, 750, 380, useFont, e)
            End If
            e.Graphics.DrawLine(Pens.Black, New Point(50, 1070), New Point(778, 1070))
#End Region

            '頁尾
            stringFormat.Alignment = StringAlignment.Near
            e.Graphics.DrawString("調劑地點: 福濬中醫診所" & vbNewLine &
                                          "地址: 桃園市龜山區文化二路30-11號", useFont, Brushes.Black, New Point(50, 1080), stringFormat)
            e.Graphics.DrawString("電話: 03-3277900" & vbNewLine &
                                          "警語: 服藥期間請勿喝咖啡", useFont, Brushes.Black, New Point(414, 1080), stringFormat)
#End Region
            printPage = 4
        End If
#End Region

        If Not printPage = 4 Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
        'Debug.WriteLine(e.HasMorePages)
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

    Private Sub warpText(ByVal input As String, ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByRef usefont As Font, ByRef e As Printing.PrintPageEventArgs)
        'Dim aBytes() As Byte = System.Text.Encoding.UTF8.GetBytes(input)
        'Dim strmMem As New System.IO.MemoryStream(aBytes)
        'Dim streamToPrint As New IO.StreamReader(strmMem)
        'Dim line As String = streamToPrint.ReadLine()
        Dim sf As StringFormat = StringFormat.GenericTypographic
        sf.Alignment = StringAlignment.Near
        sf.LineAlignment = StringAlignment.Near
        sf.FormatFlags = StringFormatFlags.LineLimit
        sf.Trimming = StringTrimming.Word
        Dim actual = e.Graphics.MeasureString(input, usefont, New SizeF(width, height), sf)
        e.Graphics.DrawString(input, usefont, Brushes.Black, New RectangleF(x, y, width, height), sf)
    End Sub
#End Region
End Class
