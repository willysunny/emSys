Public Class mainForm
    Inherits MetroFramework.Forms.MetroForm

    Public patientInfo As New pInfo
    Public patientHistory As New pHistory
    Public offlineMode As Boolean = False

    Dim login As pnlLogin = Nothing
    Dim setting As pnlSetting = Nothing
    Dim ems As pnlEms = Nothing


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.StyleManager = sysStyleManager
        AddHandler Me.Shown, AddressOf mainForm_Shown
        Application.DoEvents()

        ' Add any initialization after the InitializeComponent() call.
        login = New pnlLogin(Me)
        AddHandler login.loginSucceed, AddressOf login_success
        login.swipe()

    End Sub

#Region "Event Triggers"
    Public Sub mainForm_Shown(ByVal sender As Object, ByVal e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
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

    Private Sub exitLink_Click(sender As Object, e As MouseEventArgs) Handles exitLink.MouseUp
        If e.Button = MouseButtons.Left Then
            Me.Close()
        Else
            loginMenu.Show(exitLink, 0, exitLink.Height)
        End If
    End Sub

    Private Sub emsLink_Click(sender As Object, e As EventArgs) Handles emsLink.Click
        ems = New pnlEms(Me)
        ems.swipe()
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
#End Region
End Class
