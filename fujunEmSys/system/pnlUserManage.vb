Public Class pnlUserManage
    Inherits pnlSlider

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.
        refreshData()
    End Sub

    Private Sub refreshData()
        Dim dt As DataTable = returnData(mainForm, "SELECT uID as '編號', id as '使用者名稱', fullName as '使用者姓名', level as '權限等級' FROM user")
        userDataGrid.AutoGenerateColumns = True
        userDataGrid.DataSource = dt
        userDataGrid.Refresh()
        userManageTable.RowStyles.Item(1).Height = 0
        userDataGrid.Enabled = True
        addUserButton.Enabled = True
        editUserButton.Enabled = True
        delUserButton.Enabled = True
        RemoveHandler okLink.Click, AddressOf addUserLink_OkClick
        RemoveHandler okLink.Click, AddressOf editUserLink_OkClick
    End Sub

    ' 新增使用者
    Private Sub addUserButton_Click(sender As Object, e As EventArgs) Handles addUserButton.Click
        userManageTable.RowStyles.Item(1).Height = 100
        userDataGrid.Enabled = False
        AddHandler okLink.Click, AddressOf addUserLink_OkClick
        userLabel.Text = "新增使用者"
        userID.Text = ""
        userName.Text = ""
        userPass.Text = ""
        checkPass.Text = ""
        addUserButton.Enabled = False
        editUserButton.Enabled = False
        delUserButton.Enabled = False
    End Sub
    Private Sub addUserLink_OkClick(ByVal sender As Object, e As EventArgs)
        If userPass.Text.Trim = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "密碼欄位不得為空。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            userPass.Focus()
        ElseIf userPass.Text = checkPass.Text Then
            Try
                runQuery("INSERT INTO user (id, fullName, password) VALUES ('" & userID.Text.Trim.ToLower & "', '" & userName.Text & "', '" & MD5(userPass.Text) & "');")
                MetroFramework.MetroMessageBox.Show(Me, "使用者" & userID.Text & "已新增。", "成功!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RemoveHandler okLink.Click, AddressOf addUserLink_OkClick
                refreshData()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "新增失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
                userID.Focus()
            End Try
        Else
            MetroFramework.MetroMessageBox.Show(Me, "輸入的密碼不相符, 請檢查後再繼續。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            userPass.Focus()
        End If
    End Sub
    ' 修改使用者
    Private Sub editUserButton_Click(sender As Object, e As EventArgs) Handles editUserButton.Click
        If userDataGrid.SelectedRows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "請先選取要修改的使用者。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            userManageTable.RowStyles.Item(1).Height = 100
            userDataGrid.Enabled = False
            AddHandler okLink.Click, AddressOf editUserLink_OkClick
            userLabel.Text = "修改使用者ID - " & userDataGrid.Rows(userDataGrid.SelectedRows.Item(0).Index).Cells("使用者名稱").Value
            userID.Text = userDataGrid.Rows(userDataGrid.SelectedRows.Item(0).Index).Cells("使用者名稱").Value
            userName.Text = userDataGrid.Rows(userDataGrid.SelectedRows.Item(0).Index).Cells("使用者姓名").Value
            userPass.Text = ""
            checkPass.Text = ""
        End If
        addUserButton.Enabled = False
        editUserButton.Enabled = False
        delUserButton.Enabled = False
    End Sub
    Private Sub editUserLink_OkClick(ByVal sender As Object, e As EventArgs)
        If userPass.Text.Trim = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "密碼欄位不得為空。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            userPass.Focus()
        ElseIf userPass.Text = checkPass.Text Then
            Try
                runQuery("UPDATE user SET id='" & userID.Text.Trim.ToLower & "', fullName='" & userName.Text & "', password='" & MD5(userPass.Text) & "' WHERE uID='" & userDataGrid.Rows(userDataGrid.SelectedRows.Item(0).Index).Cells("編號").Value & "';")
                MetroFramework.MetroMessageBox.Show(Me, "使用者" & userID.Text & "已修改。", "成功!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RemoveHandler okLink.Click, AddressOf editUserLink_OkClick
                refreshData()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "修改失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
                userID.Focus()
            End Try
        Else
            MetroFramework.MetroMessageBox.Show(Me, "輸入的密碼不相符, 請檢查後再繼續。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            userPass.Focus()
        End If
    End Sub
    ' 刪除使用者
    Private Sub delUserButton_Click(sender As Object, e As EventArgs) Handles delUserButton.Click
        If MetroFramework.MetroMessageBox.Show(Me, "確認刪除使用者ID: " & userDataGrid.Rows(userDataGrid.SelectedRows.Item(0).Index).Cells("使用者名稱").Value & "?", "注意!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                runQuery("DELETE FROM user WHERE uID='" & userDataGrid.Rows(userDataGrid.SelectedRows.Item(0).Index).Cells("編號").Value & "' LIMIT 1;")
                MetroFramework.MetroMessageBox.Show(Me, "使用者" & userID.Text & "已刪除。", "成功!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshData()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "刪除失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
                refreshData()
            End Try
        End If
    End Sub

    Private Sub cancelLink_Click(sender As Object, e As EventArgs) Handles cancelLink.Click
        refreshData()
    End Sub
End Class
