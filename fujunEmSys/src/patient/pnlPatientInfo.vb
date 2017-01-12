Public Class pnlPatientInfo
    Inherits pnlSlider

    Public Event patientSelected As EventHandler

    Public patientInfo As New pInfo

    Private MySqlCon As MySql.Data.MySqlClient.MySqlConnection
    Private MySqlAdapter As MySql.Data.MySqlClient.MySqlDataAdapter
    Private resultDT As DataTable


    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.
        ' 新增性別
        Dim pt As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 測量點
        pt.Add(0, "女")
        pt.Add(1, "男")
        pt.Add(2, "未知")
        Dim ptTable As DataTable = New DataTable()
        ptTable.Columns.Add("sexCode", GetType(Integer))
        ptTable.Columns.Add("性別", GetType(String))
        For Each point As KeyValuePair(Of Integer, String) In pt
            ptTable.Rows.Add(point.Key, point.Value)
        Next
        patientSex.DataSource = ptTable
        patientSex.DisplayMember = "性別"
        patientSex.ValueMember = "sexCode"
        searchTable.ColumnStyles.Item(1).Width = 0
        loadData()
    End Sub
    ' 載入資訊
    Public Sub loadData(Optional ByVal whereClause As String = "")
        Dim sql As String = "SELECT * FROM patient"
        If Not whereClause = "" Then
            sql += " WHERE " & whereClause
        End If
        sqlGrid.DataSource = returnData(mainForm, sql & " ORDER BY pID DESC Limit 100;")
    End Sub
    ' 更新按鈕
    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim sql As String = ""
        If updateButton.Text = "新增病患" Then
            sql = "INSERT INTO patient(pPID,pName,pSex,pDOB,pPhone,pMobile,pEmail,pAddress,pRemarks) VALUES('" & patientID.Text & "', '" & patientName.Text & "', " &
                patientSex.SelectedValue & ", '" & patientDOB.Value.Date & "', '" & patientPhone.Text & "', '" & patientCell.Text & "', '" & patientEmail.Text & "', '" &
                patientAddress.Text & "', '" & patientRemarks.Text & "')"
            runQuery(sql)
            loadData()
            If MetroFramework.MetroMessageBox.Show(Me, "是否繼續新增病患資訊?", "新增成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                patientID.Text = ""
                patientName.Text = ""
                patientSex.SelectedIndex = 1
                patientDOB.Value = Now()
                patientPhone.Text = ""
                patientCell.Text = ""
                patientEmail.Text = ""
                patientAddress.Text = ""
                patientRemarks.Text = ""
            Else
                updateButton.Text = "更新資料"
                searchTable.ColumnStyles.Item(1).Width = 0
                sqlGrid.Enabled = True
                searchBox.Enabled = True
                searchButton.Enabled = True
            End If
        Else
            With sqlGrid.Rows(sqlGrid.SelectedRows.Item(0).Index)
                sql = "UPDATE patient SET " & "pPID='" & patientID.Text & "', " & "pName='" & patientName.Text & "', " & "pSex='" & patientSex.SelectedValue & "', " &
                "pDOB='" & patientDOB.Value & "', " & "pPhone='" & patientPhone.Text & "', " & "pMobile='" & patientCell.Text & "', " & "pEmail='" & patientEmail.Text & "', " &
                "pAddress='" & patientAddress.Text & "', " & "pRemarks='" & patientRemarks.Text & "' WHERE pID='" & .Cells("pID").Value & "'"
                runQuery(sql)

                .Cells("pPID").Value = patientID.Text
                .Cells("pName").Value = patientName.Text
                .Cells("pSex").Value = patientSex.SelectedValue
                .Cells("pDOB").Value = patientDOB.Value
                .Cells("pPhone").Value = patientPhone.Text
                .Cells("pMobile").Value = patientCell.Text
                .Cells("pEmail").Value = patientEmail.Text
                .Cells("pAddress").Value = patientAddress.Text
                .Cells("pRemarks").Value = patientRemarks.Text
            End With
            MetroFramework.MetroMessageBox.Show(Me, "病患資料已更新。", "更新病人", MessageBoxButtons.OK, MessageBoxIcon.Information)
            searchTable.ColumnStyles.Item(1).Width = 0
            sqlGrid.Enabled = True
            searchBox.Enabled = True
            searchButton.Enabled = True
            updateButton.Text = "更新資料"

        End If
    End Sub
    ' 右鍵選項
    Private Sub sqlGrid_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles sqlGrid.CellMouseUp
        If e.Button = MouseButtons.Right Then
            If Not e.RowIndex = -1 Then sqlGrid.Rows(e.RowIndex).Selected = True
            searchContextMenu.Show(Cursor.Position)
        End If
    End Sub
    ' 雙點 - 選擇病患
    Private Sub sqlGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles sqlGrid.CellContentDoubleClick
        patientInfo.initiate(sqlGrid.Rows(e.RowIndex).Cells("pID").Value)
        RaiseEvent patientSelected(Me, New EventArgs)
        MySqlCon.Close()
    End Sub
    ' 右鍵 - 選擇病患
    Private Sub selectPatientMenu_Click(sender As Object, e As EventArgs) Handles selectPatientMenu.Click
        If sqlGrid.Rows(sqlGrid.SelectedRows.Item(0).Index).IsNewRow Then
            MetroFramework.MetroMessageBox.Show(Me, "請另外選擇別的病人。", "無法使用此欄位", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            patientInfo.initiate(sqlGrid.Rows(sqlGrid.SelectedRows.Item(0).Index).Cells("pID").Value)
            RaiseEvent patientSelected(Me, New EventArgs)
        End If
    End Sub
    ' 右鍵 - 編輯病患
    Private Sub editPatientMenu_Click(sender As Object, e As EventArgs) Handles editPatientMenu.Click
        If Not sqlGrid.SelectedRows.Count = 0 Then
            sqlGrid.Enabled = False
            searchBox.Enabled = False
            searchButton.Enabled = False
            searchTable.ColumnStyles.Item(1).Width = 50%
            With sqlGrid.Rows(sqlGrid.SelectedRows.Item(0).Index)
                If Not TypeOf (.Cells("pPID").Value) Is DBNull Then patientID.Text = .Cells("pPID").Value Else patientID.Text = ""
                If Not TypeOf (.Cells("pName").Value) Is DBNull Then patientName.Text = .Cells("pName").Value Else patientName.Text = ""
                If Not TypeOf (.Cells("pSex").Value) Is DBNull Then patientSex.SelectedIndex = .Cells("pSex").Value Else patientSex.SelectedIndex = 1
                If Not TypeOf (.Cells("pDOB").Value) Is DBNull Then patientDOB.Value = .Cells("pDOB").Value Else patientDOB.Value = Now()
                If Not TypeOf (.Cells("pPhone").Value) Is DBNull Then patientPhone.Text = .Cells("pPhone").Value Else patientPhone.Text = ""
                If Not TypeOf (.Cells("pMobile").Value) Is DBNull Then patientCell.Text = .Cells("pMobile").Value Else patientCell.Text = ""
                If Not TypeOf (.Cells("pEmail").Value) Is DBNull Then patientEmail.Text = .Cells("pEmail").Value Else patientEmail.Text = ""
                If Not TypeOf (.Cells("pAddress").Value) Is DBNull Then patientAddress.Text = .Cells("pAddress").Value Else patientAddress.Text = ""
                If Not TypeOf (.Cells("pRemarks").Value) Is DBNull Then patientRemarks.Text = .Cells("pRemarks").Value Else patientRemarks.Text = ""
            End With
        End If
    End Sub
    ' 取消
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        searchTable.ColumnStyles.Item(1).Width = 0
        sqlGrid.Enabled = True
        searchBox.Enabled = True
        searchButton.Enabled = True
        updateButton.Text = "更新資料"
    End Sub
    ' 搜尋
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim assumptions As String = ""
        assumptions += "pID LIKE '%" & searchBox.Text & "%' OR "
        assumptions += "pName LIKE '%" & searchBox.Text & "%' OR "
        assumptions += "pPID LIKE '%" & searchBox.Text & "%' OR "
        assumptions += "pMobile LIKE '%" & searchBox.Text & "%'"
        loadData(assumptions)
    End Sub

    ' 右鍵-新增病患
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        sqlGrid.Enabled = False
        searchBox.Enabled = False
        searchButton.Enabled = False
        searchTable.ColumnStyles.Item(1).Width = 50%
        patientID.Text = ""
        patientName.Text = ""
        patientSex.SelectedIndex = 1
        patientDOB.Value = Now()
        patientPhone.Text = ""
        patientCell.Text = ""
        patientEmail.Text = ""
        patientAddress.Text = ""
        patientRemarks.Text = ""
        updateButton.Text = "新增病患"
    End Sub
End Class
