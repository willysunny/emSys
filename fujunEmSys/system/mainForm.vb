Public Class mainForm
    Inherits MetroFramework.Forms.MetroForm

    Public patientInfo As New pInfo
    Public patientHistory As New pHistory
    Dim login As pnlLogin = Nothing
    Dim setting As pnlSetting = Nothing

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

    Public Sub mainForm_Shown(ByVal sender As Object, ByVal e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub settingsLink_Click(sender As Object, e As EventArgs) Handles settingsLink.Click
        setting = New pnlSetting(Me)
        AddHandler setting.settingClosed, AddressOf setting_Closed
        settingsLink.Visible = False
        setting.menuSwipe(True, True)
    End Sub

    Private Sub exitLink_Click(sender As Object, e As EventArgs) Handles exitLink.Click
        Me.Close()
    End Sub

    Private Sub setting_Closed(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler setting.settingClosed, AddressOf setting_Closed
        settingsLink.Visible = True
        setting.menuSwipe(False, True)
    End Sub

    Private Sub login_success(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler login.loginSucceed, AddressOf login_success
        login.swipe(False)
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
