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
        ' 伺服器相關
        My.Settings.serverHost = dbAddress.Text
        My.Settings.serverPort = dbPort.Text
        My.Settings.serverUser = dbUser.Text
        My.Settings.serverPass = dbPass.Text
        My.Settings.serverDB = dbName.Text

        ' 頻譜相關
        My.Settings.autoSaveTrigger = CInt(autoSaveTextBox.Text)
        My.Settings.engUpperDanger = engUpperDanger.Value
        My.Settings.engUpperWarning = engUpperWarning.Value
        My.Settings.engLowerWarning = engLowerWarning.Value
        My.Settings.engLowerDanger = engLowerDanger.Value
        My.Settings.emsUpperDanger = emsUpperDanger.Value
        My.Settings.emsUpperWarning = emsUpperWarning.Value
        My.Settings.emsLowerWarning = emsLowerWarning.Value
        My.Settings.emsLowerDanger = emsLowerDanger.Value

        ' 樣式相關
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

    '檢查輸入
    Private Sub checkInput(ByVal tracker As MetroFramework.Controls.MetroTrackBar, ByVal input As MetroFramework.Controls.MetroTextBox)
        Try
            tracker.Value = CInt(input.Text)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "請檢查後再重新輸入。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            input.Text = tracker.Value
        End Try
    End Sub

#Region "元氣指數"
    Private Sub engUpperDanger_Scroll(sender As Object, e As ScrollEventArgs) Handles engUpperDanger.Scroll, engUpperDanger.ValueChanged
        engUpperDangerValue.Text = engUpperDanger.Value
        If engUpperDanger.Value <= engUpperWarning.Value Then engUpperWarning.Value = engUpperDanger.Value
    End Sub

    Private Sub engUpperWarning_Scroll(sender As Object, e As ScrollEventArgs) Handles engUpperWarning.Scroll, engUpperWarning.ValueChanged
        engUpperWarningValue.Text = engUpperWarning.Value
        If engUpperWarning.Value <= engLowerWarning.Value Then engLowerWarning.Value = engUpperWarning.Value
        If engUpperWarning.Value >= engUpperDanger.Value Then engUpperDanger.Value = engUpperWarning.Value
    End Sub

    Private Sub engLowerWarning_Scroll(sender As Object, e As ScrollEventArgs) Handles engLowerWarning.Scroll, engLowerWarning.ValueChanged
        engLowerWarningValue.Text = engLowerWarning.Value
        If engLowerWarning.Value <= engLowerDanger.Value Then engLowerDanger.Value = engLowerWarning.Value
        If engLowerWarning.Value >= engUpperWarning.Value Then engUpperWarning.Value = engLowerWarning.Value
    End Sub

    Private Sub engLowerDanger_Scroll(sender As Object, e As ScrollEventArgs) Handles engLowerDanger.Scroll, engLowerDanger.ValueChanged
        If engLowerDanger.Value >= engLowerWarning.Value Then engLowerWarning.Value = engLowerDanger.Value
    End Sub

    Private Sub engUpperDangerValue_Validate(sender As Object, e As EventArgs) Handles engUpperDangerValue.Validated
        checkInput(engUpperDanger, engUpperDangerValue)
    End Sub
    Private Sub engUpperWarningValue_Validate(sender As Object, e As EventArgs) Handles engUpperWarningValue.Validated
        checkInput(engUpperWarning, engUpperWarningValue)
    End Sub
    Private Sub engLowerWarningValue_Validate(sender As Object, e As EventArgs) Handles engLowerWarningValue.Validated
        checkInput(engLowerWarning, engLowerWarningValue)
    End Sub
    Private Sub engLowerDangerValue_Validate(sender As Object, e As EventArgs) Handles engLowerDangerValue.Validated
        checkInput(engLowerDanger, engLowerDangerValue)
    End Sub
#End Region

#Region "一般指數"
    Private Sub emsUpperDanger_Scroll(sender As Object, e As ScrollEventArgs) Handles emsUpperDanger.Scroll, emsUpperDanger.ValueChanged
        emsUpperDangerValue.Text = emsUpperDanger.Value
        If emsUpperDanger.Value <= emsUpperWarning.Value Then emsUpperWarning.Value = emsUpperDanger.Value
    End Sub

    Private Sub emsUpperWarning_Scroll(sender As Object, e As ScrollEventArgs) Handles emsUpperWarning.Scroll, emsUpperWarning.ValueChanged
        emsUpperWarningValue.Text = emsUpperWarning.Value
        If emsUpperWarning.Value <= emsLowerWarning.Value Then emsLowerWarning.Value = emsUpperWarning.Value
        If emsUpperWarning.Value >= emsUpperDanger.Value Then emsUpperDanger.Value = emsUpperWarning.Value
    End Sub

    Private Sub emsLowerWarning_Scroll(sender As Object, e As ScrollEventArgs) Handles emsLowerWarning.Scroll, emsLowerWarning.ValueChanged
        emsLowerWarningValue.Text = emsLowerWarning.Value
        If emsLowerWarning.Value <= emsLowerDanger.Value Then emsLowerDanger.Value = emsLowerWarning.Value
        If emsLowerWarning.Value >= emsUpperWarning.Value Then emsUpperWarning.Value = emsLowerWarning.Value
    End Sub

    Private Sub emsLowerDanger_Scroll(sender As Object, e As ScrollEventArgs) Handles emsLowerDanger.Scroll, emsLowerDanger.ValueChanged
        If emsLowerDanger.Value >= emsLowerWarning.Value Then emsLowerWarning.Value = emsLowerDanger.Value
    End Sub

    Private Sub emsUpperDangerValue_Validate(sender As Object, e As EventArgs) Handles emsUpperDangerValue.Validated
        checkInput(emsUpperDanger, emsUpperDangerValue)
    End Sub
    Private Sub emsUpperWarningValue_Validate(sender As Object, e As EventArgs) Handles emsUpperWarningValue.Validated
        checkInput(emsUpperWarning, emsUpperWarningValue)
    End Sub
    Private Sub emsLowerWarningValue_Validate(sender As Object, e As EventArgs) Handles emsLowerWarningValue.Validated
        checkInput(emsLowerWarning, emsLowerWarningValue)
    End Sub
    Private Sub emsLowerDangerValue_Validate(sender As Object, e As EventArgs) Handles emsLowerDangerValue.Validated
        checkInput(emsLowerDanger, emsLowerDangerValue)
    End Sub
#End Region


End Class