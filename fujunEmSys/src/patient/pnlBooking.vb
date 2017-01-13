Public Class pnlBooking
    Inherits pnlSlider

    Private queryForm As frmUserQuery
    Private changedPatient As Boolean = False

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)
        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.
        Dim ampm As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 測量點
        ampm.Add(0, "上午")
        ampm.Add(1, "下午")
        Dim timeTable As DataTable = New DataTable()
        With timeTable
            .Columns.Add("code", GetType(Integer))
            .Columns.Add("name", GetType(String))
            For Each point As KeyValuePair(Of Integer, String) In ampm
                .Rows.Add(point.Key, point.Value)
            Next
        End With
        With timeList
            timeList.DataSource = timeTable
            timeList.DisplayMember = "name"
            timeList.ValueMember = "code"
        End With

        Dim docTable As DataTable = returnData(mainForm, "SELECT docID, docName from doctor")
        With docList
            .DataSource = docTable
            .ValueMember = "docID"
            .DisplayMember = "docName"
        End With
        checkTime.Value = Now.Date
        setTime(Now)
    End Sub
    ' 查詢
    Public Sub queryBooking(ByVal checkDate As Date)
        Dim sql As String = "SELECT pb.bID, pb.pID, pi.pname as '病患姓名', doc.docID, doc.docName as '看診醫師', pb.bookTime as '預約時間'
                            FROM patient_booking AS pb 
                            INNER JOIN doctor AS doc ON pb.docID = doc.docID 
                            INNER JOIN patient as pi ON pb.pID = pi.pID
                            WHERE pb.bookTime >= '" & checkDate & "' AND pb.bookTime < '" & checkDate.AddDays(1) & "' 
                            ORDER BY pb.bookTime"
        sqlDataGrid.DataSource = returnData(mainForm, sql)
        If Not mainForm.debugMode.Checked Then
            sqlDataGrid.Columns("bID").Visible = False
            sqlDataGrid.Columns("docID").Visible = False
            sqlDataGrid.Columns("pID").Visible = False
        End If
        changedPatient = False
        Try
            RemoveHandler queryForm.patientSelected, AddressOf patientChange
        Catch ex As Exception
        End Try
        editButton.Text = "修改預約"
    End Sub
    ' 時間設置
    Private Sub setTime(ByVal input As DateTime)
        Dim hour As Integer = input.Hour
        Dim minute As Integer = input.Minute
        timeList.SelectedIndex = 0
        If hour > 12 Then
            timeList.SelectedIndex = 1
            hour -= 12
        End If
        hourNumber.Value = hour
        minuteNumber.Value = minute
    End Sub
    Private Function getTime() As DateTime
        getTime = New DateTime(bookDate.Value.Year, bookDate.Value.Month, bookDate.Value.Day)
        With getTime
            getTime = .AddHours(hourNumber.Value)
            getTime = .AddMinutes(minuteNumber.Value)
            If timeList.SelectedIndex = 1 Then
                getTime = .AddHours(12)
            End If
        End With
    End Function

    ' 查看日期
    Private Sub checkTime_ValueChanged(sender As Object, e As EventArgs) Handles checkTime.ValueChanged
        queryBooking(checkTime.Value)
        bookingLayout.ColumnStyles.Item(2).Width = 0
    End Sub
    ' 顯示資料
    Private Sub sqlDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles sqlDataGrid.CellClick
        bookingLayout.ColumnStyles.Item(2).Width = 300
        pName.Text = sqlDataGrid.SelectedRows(0).Cells("病患姓名").Value
        docList.SelectedValue = sqlDataGrid.SelectedRows(0).Cells("docID").Value
        Dim bookInfo As DateTime = sqlDataGrid.SelectedRows(0).Cells("預約時間").Value
        bookDate.Value = bookInfo.Date
        setTime(bookInfo)
        changedPatient = False
        Try
            RemoveHandler queryForm.patientSelected, AddressOf patientChange
        Catch ex As Exception
        End Try
        editButton.Text = "修改預約"
    End Sub
    ' 變更病人
    Private Sub changePatientButton_Click(sender As Object, e As EventArgs) Handles changePatientButton.Click
        queryForm = New frmUserQuery
        AddHandler queryForm.patientSelected, AddressOf patientChange
        queryForm.ShowDialog()
    End Sub

    Private Sub patientChange(ByVal sender As Object, ByVal e As EventArgs)
        changedPatient = True
        pName.Text = queryForm.resultInfo.pName
    End Sub
    ' 新增預約
    Private Sub addBookingButton_Click(sender As Object, e As EventArgs) Handles addBookingButton.Click
        changedPatient = False
        Try
            RemoveHandler queryForm.patientSelected, AddressOf patientSelected
        Catch ex As Exception
        End Try
        queryForm = New frmUserQuery
        AddHandler queryForm.patientSelected, AddressOf patientSelected
        queryForm.ShowDialog()
    End Sub
    Private Sub patientSelected(ByVal sender As Object, ByVal e As EventArgs)
        pName.Text = queryForm.resultInfo.pName
        bookDate.Value = Now().Date
        setTime(Now)
        editButton.Text = "確認新增"
        bookingLayout.ColumnStyles.Item(2).Width = 300
    End Sub
    ' 刪除預約
    Private Sub delBookingButton_Click(sender As Object, e As EventArgs) Handles delBookingButton.Click
        If sqlDataGrid.SelectedRows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "請先選取要刪除的預約。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MetroFramework.MetroMessageBox.Show(Me, "確認刪除以下預約?" & vbNewLine & vbNewLine &
                                                   "病患名稱: " & sqlDataGrid.SelectedRows(0).Cells("病患姓名").Value & vbNewLine &
                                                   "看診醫師: " & sqlDataGrid.SelectedRows(0).Cells("看診醫師").Value & vbNewLine &
                                                   "預約時間: " & sqlDataGrid.SelectedRows(0).Cells("預約時間").value & vbNewLine, "注意!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                runQuery("DELETE FROM patient_booking WHERE bID='" & sqlDataGrid.SelectedRows(0).Cells("bID").Value & "' LIMIT 1;")
                MetroFramework.MetroMessageBox.Show(Me, "預約已刪除。", "成功!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                queryBooking(checkTime.Value)
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "刪除失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
                queryBooking(checkTime.Value)
            End Try
        End If

    End Sub
    ' 修改預約
    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        If editButton.Text = "確認新增" Then
            If getTime() < Now.Date Then
                MetroFramework.MetroMessageBox.Show(Me, "無法預約過去!", "新增失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If MetroFramework.MetroMessageBox.Show(Me, "確認新增以下預約?" & vbNewLine & vbNewLine &
                                                   "病患名稱: " & pName.Text & vbNewLine &
                                                   "看診醫師: " & DirectCast(docList.SelectedItem, DataRowView).Row.ItemArray(1) & vbNewLine &
                                                   "預約時間: " & getTime.ToLongTimeString & vbNewLine, "注意!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        runQuery("INSERT INTO patient_booking(pID,docID,booktime) VALUES('" & queryForm.resultInfo.pID & "', '" & docList.SelectedValue & "', '" & getTime.ToString("yyyy-MM-dd HH:mm:ss") & "');")
                        MetroFramework.MetroMessageBox.Show(Me, "預約已新增。", "成功!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        queryBooking(checkTime.Value)
                        bookingLayout.ColumnStyles.Item(2).Width = 0
                    Catch ex As Exception
                        MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "新增失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        queryBooking(checkTime.Value)
                    End Try
                End If
            End If
        ElseIf editButton.Text = "修改預約" Then
            If sqlDataGrid.SelectedRows(0).Cells("預約時間").Value < Now Then
                MetroFramework.MetroMessageBox.Show(Me, "無法修改之前的紀錄!", "修改失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim question As String = "確認修改成以下預約?" & vbNewLine & vbNewLine &
                                                   "病患名稱: " & pName.Text & vbNewLine &
                                                   "看診醫師: " & DirectCast(docList.SelectedItem, DataRowView).Row.ItemArray(1) & vbNewLine &
                                                   "預約時間: " & getTime.ToLongTimeString & vbNewLine
                If MetroFramework.MetroMessageBox.Show(Me, question, "注意!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim sql As String = "UPDATE patient_booking SET pID='"
                    If changedPatient Then sql += queryForm.resultInfo.pID Else sql += sqlDataGrid.SelectedRows(0).Cells("病患姓名").Value
                    sql += "', docID='" & docList.SelectedValue & "', booktime='" & getTime.ToString("yyyy-MM-dd HH:mm:ss") & "' WHERE bID='" & sqlDataGrid.SelectedRows(0).Cells("bID").Value & "'"

                    Try
                        runQuery(sql)
                        MetroFramework.MetroMessageBox.Show(Me, "預約已新增。", "成功!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        queryBooking(checkTime.Value)
                        bookingLayout.ColumnStyles.Item(2).Width = 0
                    Catch ex As Exception
                        MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "修改失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        queryBooking(checkTime.Value)
                    End Try
                End If
            End If
        End If
    End Sub

End Class
