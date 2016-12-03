Public Class pnlLogin
    Inherits pnlSlider

    Public Event loginSucceed As EventHandler

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        usernameTextbox.Focus()

        If Not testConnection(owner, My.Settings.serverHost, My.Settings.serverPort, My.Settings.serverUser, My.Settings.serverPass, My.Settings.serverDB) Then
            noConnectionLabel.Visible = True
            loginButton.Enabled = False
        Else
            noConnectionLabel.Visible = False
            loginButton.Enabled = True
        End If

    End Sub

    Private Sub loginButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loginButton.Click
        Dim result As DataTable = returnData(mainForm, "SELECT * FROM `user` where `id`='" & usernameTextbox.Text & "' and `password`='" & MD5(passwordTextbox.Text.Trim) & "' limit 1")
        If Not result Is Nothing Then
            If result.Rows.Count = 0 Then
                MetroFramework.MetroMessageBox.Show(mainForm, "請檢查您的使用者名稱以及密碼無誤。", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                RaiseEvent loginSucceed(Me, New EventArgs)

            End If
        End If
    End Sub

    Private Sub exitMenu_Click(sender As Object, e As EventArgs)
        Me.ParentForm.Close()
    End Sub

    Private Sub noConnectionLabel_Click(sender As Object, e As EventArgs) Handles noConnectionLabel.Click
        If Not testConnection(owner, My.Settings.serverHost, My.Settings.serverPort, My.Settings.serverUser, My.Settings.serverPass, My.Settings.serverDB) Then
            noConnectionLabel.Visible = True
            loginButton.Enabled = False
        Else
            noConnectionLabel.Visible = False
            loginButton.Enabled = True
        End If

    End Sub

End Class
