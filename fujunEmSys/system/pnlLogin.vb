Public Class pnlLogin
    Inherits pnlSlider

    Public Event loginSucceed As EventHandler

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        usernameTextbox.Focus()

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

End Class
