Public Class pnlSetting
    Public Event settingClosed As EventHandler
    Public Event loginSucceed As EventHandler

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        For i As Integer = 3 To 13
            Dim tile As MetroFramework.Controls.MetroTile = New MetroFramework.Controls.MetroTile
            tile.Size = New Size(100, 100)
            tile.Tag = i
            tile.Style = CType(i, MetroFramework.MetroColorStyle)
            AddHandler tile.Click, AddressOf tile_click
            bgcolor.Controls.Add(tile)
        Next

        dbAddress.Text = My.Settings.serverHost
        dbPort.Text = My.Settings.serverPort
        dbUser.Text = My.Settings.serverUser
        dbPass.Text = My.Settings.serverPass
        dbName.Text = My.Settings.serverDB

        If My.Settings.sysTheme = MetroFramework.MetroThemeStyle.Dark Then
            mrbDark.Checked = True
        Else
            mrbLight.Checked = True
        End If


        dbUser.Focus()

    End Sub

    Public Sub tile_click(ByVal sender As Object, ByVal e As EventArgs)
        CType(Me.Parent, MetroFramework.Forms.MetroForm).StyleManager.Style = CType(CType(sender, MetroFramework.Controls.MetroTile).Tag, MetroFramework.MetroColorStyle)
    End Sub

    Public Sub showSettings()
        settingMetroPanel.Visible = True
    End Sub

    Private Sub settingLink_Click(sender As Object, e As EventArgs) Handles settingLink.Click
        RaiseEvent settingClosed(Me, New EventArgs)
    End Sub
    Public Sub SaveSettings()
        My.Settings.serverHost = dbAddress.Text
        My.Settings.serverPort = dbPort.Text
        My.Settings.serverUser = dbUser.Text
        My.Settings.serverPass = dbPass.Text
        My.Settings.serverDB = dbName.Text
        My.Settings.sysTheme = CType(Me.Parent, MetroFramework.Forms.MetroForm).StyleManager.Theme
        My.Settings.sysColor = CType(Me.Parent, MetroFramework.Forms.MetroForm).StyleManager.Style
        My.Settings.Save()
    End Sub

    Private Sub saveSettingsButton_Click(sender As Object, e As EventArgs) Handles saveSettingsButton.Click
        SaveSettings()
        RaiseEvent settingClosed(Me, New EventArgs)
    End Sub


    Private Sub mrbLight_CheckedChanged(sender As Object, e As EventArgs) Handles mrbLight.CheckedChanged
        If mrbLight.Checked Then
            CType(Me.Parent, MetroFramework.Forms.MetroForm).StyleManager.Theme = MetroFramework.MetroThemeStyle.Light
        End If
    End Sub

    Private Sub mrbDark_CheckedChanged(sender As Object, e As EventArgs) Handles mrbDark.CheckedChanged
        If mrbDark.Checked Then
            CType(Me.Parent, MetroFramework.Forms.MetroForm).StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark
        End If
    End Sub

    Private Sub testButton_Click(sender As Object, e As EventArgs) Handles testButton.Click
        If testConnection(mainForm, dbAddress.Text, dbPort.Text, dbUser.Text, dbPass.Text, dbName.Text) Then
            If MetroFramework.MetroMessageBox.Show(Me, "是否要儲存設定?", "連線成功", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                SaveSettings()
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "請檢查所有設定是否都正確。", "連線失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
