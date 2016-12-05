Public Class pnlPatientInfo
    Inherits pnlSlider

    Public Event patientSelected As EventHandler

    Private MySqlCon As MySql.Data.MySqlClient.MySqlConnection
    Private MySqlAdapter As MySql.Data.MySqlClient.MySqlDataAdapter
    Private MySqlCmdBuilder As MySql.Data.MySqlClient.MySqlCommandBuilder
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

        Try
            MySqlCon = New MySql.Data.MySqlClient.MySqlConnection(getConnectionString())
            MySqlCon.Open()
            MySqlAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM patient ORDER BY pID DESC Limit 100;", MySqlCon)
            resultDT = New DataTable
            MySqlAdapter.Fill(resultDT)
            sqlGrid.DataSource = resultDT
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "請確保網路連線是否正常?" & vbNewLine & "(" & ex.Message & ")", "資料庫連線失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    ' 更新按鈕
    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Try
            searchTable.ColumnStyles.Item(1).Width = 0
            With sqlGrid.Rows(sqlGrid.SelectedRows.Item(0).Index)
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
            MySqlCmdBuilder = New MySql.Data.MySqlClient.MySqlCommandBuilder(MySqlAdapter)
            MySqlAdapter.Update(resultDT)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "請確保網路連線是否正常?" & vbNewLine & "(" & ex.Message & ")", "更新資料庫失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        sqlGrid.Enabled = True
    End Sub
    ' 右鍵選項
    Private Sub sqlGrid_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles sqlGrid.CellMouseUp
        If e.Button = MouseButtons.Right Then
            sqlGrid.Rows(e.RowIndex).Selected = True
            searchContextMenu.Show(Cursor.Position)
        End If
    End Sub
    ' 雙點 - 選擇病患
    Private Sub sqlGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles sqlGrid.CellContentDoubleClick
        mainForm.patientInfo.initiate(sqlGrid.Rows(e.RowIndex).Cells("pID").Value)
        MySqlCon.Close()
        RaiseEvent patientSelected(Me, New EventArgs)
    End Sub
    ' 右鍵 - 選擇病患
    Private Sub selectPatientMenu_Click(sender As Object, e As EventArgs) Handles selectPatientMenu.Click
        If sqlGrid.Rows(sqlGrid.SelectedRows.Item(0).Index).IsNewRow Then
            MetroFramework.MetroMessageBox.Show(Me, "請另外選擇別的病人。", "無法使用此欄位", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            mainForm.patientInfo.initiate(sqlGrid.Rows(sqlGrid.SelectedRows.Item(0).Index).Cells("pID").Value)
            MySqlCon.Close()
            RaiseEvent patientSelected(Me, New EventArgs)
        End If
    End Sub
    ' 右鍵 - 編輯病患
    Private Sub editPatientMenu_Click(sender As Object, e As EventArgs) Handles editPatientMenu.Click
        sqlGrid.Enabled = False
        searchTable.ColumnStyles.Item(1).Width = 50%
        With sqlGrid.Rows(sqlGrid.SelectedRows.Item(0).Index)
            If Not TypeOf (.Cells("pID").Value) Is DBNull Then pIDLabel.Text = .Cells("pID").Value
            If Not TypeOf (.Cells("pPID").Value) Is DBNull Then patientID.Text = .Cells("pPID").Value
            If Not TypeOf (.Cells("pName").Value) Is DBNull Then patientName.Text = .Cells("pName").Value
            If Not TypeOf (.Cells("pSex").Value) Is DBNull Then patientSex.SelectedIndex = .Cells("pSex").Value
            If Not TypeOf (.Cells("pDOB").Value) Is DBNull Then patientDOB.Value = .Cells("pDOB").Value
            If Not TypeOf (.Cells("pPhone").Value) Is DBNull Then patientPhone.Text = .Cells("pPhone").Value
            If Not TypeOf (.Cells("pMobile").Value) Is DBNull Then patientCell.Text = .Cells("pMobile").Value
            If Not TypeOf (.Cells("pEmail").Value) Is DBNull Then patientEmail.Text = .Cells("pEmail").Value
            If Not TypeOf (.Cells("pAddress").Value) Is DBNull Then patientAddress.Text = .Cells("pAddress").Value
            If Not TypeOf (.Cells("pRemarks").Value) Is DBNull Then patientRemarks.Text = .Cells("pRemarks").Value
        End With
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        searchTable.ColumnStyles.Item(1).Width = 0
        sqlGrid.Enabled = True
    End Sub

End Class
