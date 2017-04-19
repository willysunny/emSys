Imports System.ComponentModel

Public Class pnlSetting
    Public Event settingClosed As EventHandler
    Public Event loginSucceed As EventHandler

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.
        For i As Integer = 3 To 13
            Dim tile As MetroFramework.Controls.MetroTile = New MetroFramework.Controls.MetroTile
            tile.Size = New Size(100, 100)
            tile.Tag = i
            tile.Style = DirectCast(i, MetroFramework.MetroColorStyle)
            AddHandler tile.Click, AddressOf tile_click
            bgcolor.Controls.Add(tile)
        Next

        dbAddress.Text = My.Settings.serverHost
        dbPort.Text = My.Settings.serverPort
        dbUser.Text = My.Settings.serverUser
        dbPass.Text = My.Settings.serverPass
        dbName.Text = My.Settings.serverDB

        autoSaveTextBox.Text = My.Settings.autoSaveTrigger
        autoStopTextBox.Text = My.Settings.autoStopTrigger
        engUpperDanger.Value = My.Settings.engUpperDanger
        engUpperWarning.Value = My.Settings.engUpperWarning
        engLowerWarning.Value = My.Settings.engLowerWarning
        engLowerDanger.Value = My.Settings.engLowerDanger
        emsUpperDanger.Value = My.Settings.emsUpperDanger
        emsUpperWarning.Value = My.Settings.emsUpperWarning
        emsLowerWarning.Value = My.Settings.emsLowerWarning
        emsLowerDanger.Value = My.Settings.emsLowerDanger


        If My.Settings.sysTheme = MetroFramework.MetroThemeStyle.Dark Then
            mrbDark.Checked = True
        Else
            mrbLight.Checked = True
        End If

        dbUser.Focus()

    End Sub

    Public Sub tile_click(ByVal sender As Object, ByVal e As EventArgs)
        DirectCast(Parent, MetroFramework.Forms.MetroForm).StyleManager.Style = DirectCast(DirectCast(sender, MetroFramework.Controls.MetroTile).Tag, MetroFramework.MetroColorStyle)
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
        My.Settings.autoStopTrigger = CInt(autoStopTextBox.Text)
        My.Settings.engUpperDanger = engUpperDanger.Value
        My.Settings.engUpperWarning = engUpperWarning.Value
        My.Settings.engLowerWarning = engLowerWarning.Value
        My.Settings.engLowerDanger = engLowerDanger.Value
        My.Settings.emsUpperDanger = emsUpperDanger.Value
        My.Settings.emsUpperWarning = emsUpperWarning.Value
        My.Settings.emsLowerWarning = emsLowerWarning.Value
        My.Settings.emsLowerDanger = emsLowerDanger.Value

        ' 樣式相關
        My.Settings.sysTheme = DirectCast(Parent, MetroFramework.Forms.MetroForm).StyleManager.Theme
        My.Settings.sysColor = DirectCast(Parent, MetroFramework.Forms.MetroForm).StyleManager.Style
        My.Settings.Save()
    End Sub

    Private Sub saveSettingsButton_Click(sender As Object, e As EventArgs) Handles saveSettingsButton.Click
        SaveSettings()
        RaiseEvent settingClosed(Me, New EventArgs)
    End Sub

    Private Sub mrbLight_CheckedChanged(sender As Object, e As EventArgs) Handles mrbLight.CheckedChanged
        If mrbLight.Checked Then
            DirectCast(Parent, MetroFramework.Forms.MetroForm).StyleManager.Theme = MetroFramework.MetroThemeStyle.Light
        End If
    End Sub

    Private Sub mrbDark_CheckedChanged(sender As Object, e As EventArgs) Handles mrbDark.CheckedChanged
        If mrbDark.Checked Then
            DirectCast(Parent, MetroFramework.Forms.MetroForm).StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark
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

    Private Sub autoSaveTextBox_Validated(sender As Object, e As EventArgs) Handles autoSaveTextBox.Validated
        Try
            autoSaveTextBox.Text = CInt(autoSaveTextBox.Text)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "請檢查後再重新輸入。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            autoSaveTextBox.Text = My.Settings.autoSaveTrigger
        End Try
    End Sub
    Private Sub autoStopTextBox_Validated(sender As Object, e As EventArgs) Handles autoStopTextBox.Validated
        Try
            autoStopTextBox.Text = CInt(autoStopTextBox.Text)
            If autoStopTextBox.Text < 1 Then
                autoStopTextBox.Text = 1
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "請檢查後再重新輸入。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            autoStopTextBox.Text = My.Settings.autoStopTrigger
        End Try
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
    Private Sub engUpperDanger_Scroll(sender As Object, e As ScrollEventArgs)
        engUpperDangerValue.Text = engUpperDanger.Value
        If engUpperDanger.Value <= engUpperWarning.Value Then
            engUpperWarning.Value = engUpperDanger.Value
            engUpperWarningValue.Text = engUpperDanger.Value
        End If
        If engUpperDanger.Value <= engLowerWarning.Value Then
            engLowerWarning.Value = engUpperDanger.Value
            engLowerWarningValue.Text = engUpperDanger.Value
        End If
        If engUpperDanger.Value <= engLowerDanger.Value Then
            engLowerDanger.Value = engUpperDanger.Value
            engLowerDangerValue.Text = engUpperDanger.Value
        End If
    End Sub
    Private Sub engUpperWarning_Scroll(sender As Object, e As ScrollEventArgs)
        engUpperWarningValue.Text = engUpperWarning.Value
        If engUpperWarning.Value <= engLowerWarning.Value Then
            engLowerWarning.Value = engUpperWarning.Value
            engLowerWarningValue.Text = engUpperWarning.Value
        End If
        If engUpperWarning.Value <= engLowerDanger.Value Then
            engLowerDanger.Value = engUpperWarning.Value
            engLowerDangerValue.Text = engUpperWarning.Value
        End If
        If engUpperWarning.Value >= engUpperDanger.Value Then
            engUpperDanger.Value = engUpperWarning.Value
            engUpperDangerValue.Text = engUpperWarning.Value
        End If
    End Sub
    Private Sub engLowerWarning_Scroll(sender As Object, e As ScrollEventArgs)
        engLowerWarningValue.Text = engLowerWarning.Value
        If engLowerWarning.Value <= engLowerDanger.Value Then
            engLowerDanger.Value = engLowerWarning.Value
            engLowerDangerValue.Text = engLowerWarning.Value
        End If
        If engLowerWarning.Value >= engUpperDanger.Value Then
            engUpperDanger.Value = engLowerWarning.Value
            engUpperDangerValue.Text = engLowerWarning.Value
        End If
        If engLowerWarning.Value >= engUpperWarning.Value Then
            engUpperWarning.Value = engLowerWarning.Value
            engUpperWarningValue.Text = engLowerWarning.Value
        End If
    End Sub
    Private Sub engLowerDanger_Scroll(sender As Object, e As ScrollEventArgs)
        engLowerDangerValue.Text = engLowerDanger.Value
        If engLowerDanger.Value >= engUpperDanger.Value Then
            engUpperDanger.Value = engLowerDanger.Value
            engUpperDangerValue.Text = engLowerDanger.Value
        End If
        If engLowerDanger.Value >= engUpperWarning.Value Then
            engUpperWarning.Value = engLowerDanger.Value
            engUpperWarningValue.Text = engLowerDanger.Value
        End If
        If engLowerDanger.Value >= engLowerWarning.Value Then
            engLowerWarning.Value = engLowerDanger.Value
            engLowerWarningValue.Text = engLowerDanger.Value
        End If
    End Sub
    Private Sub engUpperDangerValue_Validate(sender As Object, e As EventArgs)
        checkInput(engUpperDanger, engUpperDangerValue)
    End Sub
    Private Sub engUpperWarningValue_Validate(sender As Object, e As EventArgs)
        checkInput(engUpperWarning, engUpperWarningValue)
    End Sub
    Private Sub engLowerWarningValue_Validate(sender As Object, e As EventArgs)
        checkInput(engLowerWarning, engLowerWarningValue)
    End Sub
    Private Sub engLowerDangerValue_Validate(sender As Object, e As EventArgs)
        checkInput(engLowerDanger, engLowerDangerValue)
    End Sub
#End Region

#Region "一般指數"
    Private Sub emsUpperDanger_Scroll(sender As Object, e As ScrollEventArgs)
        emsUpperDangerValue.Text = emsUpperDanger.Value
        If emsUpperDanger.Value <= emsUpperWarning.Value Then emsUpperWarning.Value = emsUpperDanger.Value
    End Sub
    Private Sub emsUpperWarning_Scroll(sender As Object, e As ScrollEventArgs)
        emsUpperWarningValue.Text = emsUpperWarning.Value
        If emsUpperWarning.Value <= emsLowerWarning.Value Then emsLowerWarning.Value = emsUpperWarning.Value
        If emsUpperWarning.Value >= emsUpperDanger.Value Then emsUpperDanger.Value = emsUpperWarning.Value
    End Sub
    Private Sub emsLowerWarning_Scroll(sender As Object, e As ScrollEventArgs)
        emsLowerWarningValue.Text = emsLowerWarning.Value
        If emsLowerWarning.Value <= emsLowerDanger.Value Then emsLowerDanger.Value = emsLowerWarning.Value
        If emsLowerWarning.Value >= emsUpperWarning.Value Then emsUpperWarning.Value = emsLowerWarning.Value
    End Sub
    Private Sub emsLowerDanger_Scroll(sender As Object, e As ScrollEventArgs)
        emsLowerDangerValue.Text = emsLowerDanger.Value
        If emsLowerDanger.Value >= emsLowerWarning.Value Then emsLowerWarning.Value = emsLowerDanger.Value
    End Sub
    Private Sub emsUpperDangerValue_Validate(sender As Object, e As EventArgs)
        checkInput(emsUpperDanger, emsUpperDangerValue)
    End Sub
    Private Sub emsUpperWarningValue_Validate(sender As Object, e As EventArgs)
        checkInput(emsUpperWarning, emsUpperWarningValue)
    End Sub
    Private Sub emsLowerWarningValue_Validate(sender As Object, e As EventArgs)
        checkInput(emsLowerWarning, emsLowerWarningValue)
    End Sub
    Private Sub emsLowerDangerValue_Validate(sender As Object, e As EventArgs)
        checkInput(emsLowerDanger, emsLowerDangerValue)
    End Sub

#End Region

End Class