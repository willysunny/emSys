Public Class mainForm
    Inherits MetroFramework.Forms.MetroForm

    Public patientInfo As New pInfo
    Public patientHistory As New pHistory
    Public offlineMode As Boolean = False

    Dim login As pnlLogin = Nothing
    Dim setting As pnlSetting = Nothing
    Dim ems As pnlEms = Nothing
    Dim userManage As pnlUserManage = Nothing
    Dim patientInfoPanel As pnlPatientInfo = Nothing


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        StyleManager = sysStyleManager
        AddHandler Shown, AddressOf mainForm_Shown
        Application.DoEvents()

        ' Add any initialization after the InitializeComponent() call.
        login = New pnlLogin(Me)
        AddHandler login.loginSucceed, AddressOf login_success
        login.swipe()
    End Sub

#Region "Event Triggers"
    Public Sub mainForm_Shown(ByVal sender As Object, ByVal e As EventArgs)
        WindowState = FormWindowState.Maximized
    End Sub
    Private Sub setting_Closed(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler setting.settingClosed, AddressOf setting_Closed
        settingsLink.Enabled = True
        setting.menuSwipe(False, True)
    End Sub
    Private Sub login_success(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler login.loginSucceed, AddressOf login_success
        login.swipe(False)
    End Sub
    Private Sub ems_device_error(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler ems.DEVICE_ERROR, AddressOf ems_device_error
        MetroFramework.MetroMessageBox.Show(Me, "請檢查以下狀態後再嘗試:" & vbNewLine & "1. 電源是否有接妥?" & vbNewLine & "2. 頻譜儀USB接上電腦時是否有偵測到?", "無法與頻譜儀連線", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ems.swipe(False)
    End Sub
#End Region

#Region "Button Clicks"
    Private Sub settingsLink_Click(sender As Object, e As EventArgs) Handles settingsLink.Click
        setting = New pnlSetting(Me)
        AddHandler setting.settingClosed, AddressOf setting_Closed
        settingsLink.Enabled = False
        setting.menuSwipe(True, True)
    End Sub
    Private Sub exitLink_MouseUp(sender As Object, e As MouseEventArgs) Handles exitLink.MouseUp
        If e.Button = MouseButtons.Left Then
            Close()
        Else
            loginMenu.Show(exitLink, 0, exitLink.Height)
        End If
    End Sub
    Private Sub emsLink_Click(sender As Object, e As EventArgs) Handles emsLink.Click
        Try
            ems = New pnlEms(Me)
            AddHandler ems.DEVICE_ERROR, AddressOf ems_device_error
            RemoveHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
            AddHandler exitLink.MouseUp, AddressOf emsClose_MouseUp
            ems.swipe()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "請檢查以下狀態後再嘗試:" & vbNewLine & "1. 電源是否有接妥?" & vbNewLine & "2. 頻譜儀USB接上電腦時是否有偵測到?" & vbNewLine & "3. 是否有其他頻譜系統開啟?", "無法與頻譜儀連線", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub emsClose_MouseUp(sender As Object, e As EventArgs)
        ems.swipe(False)
        RemoveHandler exitLink.MouseUp, AddressOf emsClose_MouseUp
        AddHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
    End Sub
    Private Sub menuOfflineMode_Click(sender As Object, e As EventArgs) Handles menuOfflineMode.Click
        If menuOfflineMode.Checked Then
            offlineMode = True
            RemoveHandler login.loginSucceed, AddressOf login_success
            login.swipe(False)
        Else
            offlineMode = False
            login = New pnlLogin(Me)
            AddHandler login.loginSucceed, AddressOf login_success
            login.swipe()
        End If
    End Sub
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If menuOfflineMode.Checked Then
            menuOfflineMode.Checked = False
        End If
        login = New pnlLogin(Me)
        AddHandler login.loginSucceed, AddressOf login_success
        login.swipe()
    End Sub
    Private Sub userManageLink_Click(sender As Object, e As EventArgs) Handles userManageLink.Click
        userManage = New pnlUserManage(Me)
        RemoveHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
        AddHandler exitLink.MouseUp, AddressOf userManageLink_MouseUp
        userManage.swipe()
    End Sub
    Private Sub userManageLink_MouseUp(sender As Object, e As EventArgs)
        userManage.swipe(False)
        RemoveHandler exitLink.MouseUp, AddressOf userManageLink_MouseUp
        AddHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
    End Sub
    Private Sub testButton_Click(sender As Object, e As EventArgs) Handles testButton.Click
        Debug.WriteLine(ems.loaded)
    End Sub
    Private Sub paitientInfoLink_Click(sender As Object, e As EventArgs) Handles paitientInfoLink.Click
        patientInfoPanel = New pnlPatientInfo(Me)
        RemoveHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
        AddHandler exitLink.MouseUp, AddressOf paitientInfoLink_MouseUp
        patientInfoPanel.swipe()
    End Sub
    Private Sub paitientInfoLink_MouseUp(sender As Object, e As EventArgs)
        patientInfoPanel.swipe(False)
        RemoveHandler exitLink.MouseUp, AddressOf paitientInfoLink_MouseUp
        AddHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
    End Sub
#End Region
End Class
