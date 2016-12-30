Public Class mainForm
    Inherits MetroFramework.Forms.MetroForm

    Public patientInfo As New pInfo
    Public offlineMode As Boolean = False

    Dim login As pnlLogin = Nothing
    Dim setting As pnlSetting = Nothing
    Dim ems As pnlEms = Nothing
    Dim patientInfoPanel As pnlPatientInfo = Nothing
    Dim medInfo As pnlMedInfo = Nothing
    Dim medManage As pnlMedManage = Nothing
    Dim pBooking As pnlBooking = Nothing
    Dim perscription As pnlPerscription = Nothing
    Dim payment As pnlPayment = Nothing

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
    Private Sub patientSelected(ByVal sender As Object, ByVal e As EventArgs)
        patientInfoPanel.swipe(False)
        RemoveHandler patientInfoPanel.patientSelected, AddressOf patientSelected
        RemoveHandler exitLink.MouseUp, AddressOf paitientInfoLink_MouseUp
        AddHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
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
    Private Sub emsLink_Click(sender As Object, e As EventArgs) Handles emsTile.Click
        Try
            ems = New pnlEms(Me)
            AddHandler ems.DEVICE_ERROR, AddressOf ems_device_error
            RemoveHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
            AddHandler exitLink.MouseUp, AddressOf emsClose_exit
            ems.swipe()

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "請檢查以下狀態後再嘗試:" & vbNewLine & "1. 電源是否有接妥?" & vbNewLine & "2. 頻譜儀USB接上電腦時是否有偵測到?" & vbNewLine & "3. 是否有其他頻譜系統開啟?", "無法與頻譜儀連線", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub emsClose_exit(sender As Object, e As EventArgs)
        ems.swipe(False)
        RemoveHandler exitLink.MouseUp, AddressOf emsClose_exit
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
    Private Sub loginButton_Click(sender As Object, e As EventArgs)
        If menuOfflineMode.Checked Then
            menuOfflineMode.Checked = False
        End If
        login = New pnlLogin(Me)
        AddHandler login.loginSucceed, AddressOf login_success
        login.swipe()
    End Sub
    Private Sub userManageLink_Click(sender As Object, e As EventArgs) Handles userTile.Click
        Dim frm As New frmUserManage
        frm.ShowDialog()
    End Sub
    Private Sub docManageLink_Click(sender As Object, e As EventArgs) Handles docTile.Click
        Dim frm As New frmDocManage
        frm.ShowDialog()
    End Sub
    Private Sub paitientInfoLink_Click(sender As Object, e As EventArgs) Handles paitientInfoTile.Click
        patientInfoPanel = New pnlPatientInfo(Me)
        RemoveHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
        AddHandler exitLink.MouseUp, AddressOf paitientInfoLink_MouseUp
        AddHandler patientInfoPanel.patientSelected, AddressOf patientSelected
        patientInfoPanel.swipe()
    End Sub
    Private Sub paitientInfoLink_MouseUp(sender As Object, e As EventArgs)
        patientInfoPanel.swipe(False)
        RemoveHandler exitLink.MouseUp, AddressOf paitientInfoLink_MouseUp
        AddHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
    End Sub
    Private Sub medManageLink_Click(sender As Object, e As EventArgs) Handles medManageTile.Click
        medManage = New pnlMedManage(Me)
        RemoveHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
        AddHandler exitLink.MouseUp, AddressOf medManage_exit
        medManage.swipe()
    End Sub
    Private Sub medManage_exit(sender As Object, e As EventArgs)
        medManage.swipe(False)
        RemoveHandler exitLink.MouseUp, AddressOf medManage_exit
        AddHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
    End Sub
    Private Sub medInfoLink_Click(sender As Object, e As EventArgs) Handles medInfoTile.Click
        medInfo = New pnlMedInfo(Me)
        RemoveHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
        AddHandler exitLink.MouseUp, AddressOf medInfo.stopSearch
        AddHandler medInfo.searchAborted, AddressOf medInfo_exit
        medInfo.swipe()
    End Sub
    Private Sub medInfo_exit(sender As Object, e As EventArgs)
        medInfo.swipe(False)
        RemoveHandler exitLink.MouseUp, AddressOf medInfo.stopSearch
        RemoveHandler medInfo.searchAborted, AddressOf medInfo_exit
        AddHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
    End Sub
    Private Sub patientBookingLink_Click(sender As Object, e As EventArgs) Handles bookingTile.Click
        pBooking = New pnlBooking(Me)
        RemoveHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
        AddHandler exitLink.MouseUp, AddressOf patientBooking_exit
        pBooking.swipe()
    End Sub
    Private Sub patientBooking_exit(sender As Object, e As EventArgs)
        pBooking.swipe(False)
        RemoveHandler exitLink.MouseUp, AddressOf patientBooking_exit
        AddHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
    End Sub
    Private Sub perscriptionLink_Click(sender As Object, e As EventArgs) Handles perscriptionTile.Click
        If Not offlineMode Then
            perscription = New pnlPerscription(Me)
            RemoveHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
            AddHandler exitLink.MouseUp, AddressOf perscription_exit
            perscription.swipe()
        End If
    End Sub
    Private Sub perscription_exit(sender As Object, e As EventArgs)
        perscription.swipe(False)
        RemoveHandler exitLink.MouseUp, AddressOf perscription_exit
        AddHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
    End Sub
    Private Sub paymentLink_Click(sender As Object, e As EventArgs) Handles paymentTile.Click
        If Not offlineMode Then
            payment = New pnlpayment(Me)
            RemoveHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
            AddHandler exitLink.MouseUp, AddressOf payment_exit
            payment.swipe()
        End If
    End Sub
    Private Sub payment_exit(sender As Object, e As EventArgs)
        payment.swipe(False)
        RemoveHandler exitLink.MouseUp, AddressOf payment_exit
        AddHandler exitLink.MouseUp, AddressOf exitLink_MouseUp
    End Sub
    Private Sub reportLink_Click(sender As Object, e As EventArgs) Handles reportTile.Click
        If Not offlineMode Then
            Dim frm As New frmUserReport
            frm.ShowDialog()
        End If
    End Sub

    Private Sub geneSetupTile_Click(sender As Object, e As EventArgs) Handles geneSetupTile.Click
        If Not offlineMode Then
            Dim frm As New frmSetupFields("基因缺陷", "gene", "geneID", "geneName", "geneDesc")
            frm.ShowDialog()
        End If
    End Sub

    Private Sub commonFluTile_Click(sender As Object, e As EventArgs) Handles commonFluTile.Click
        If Not offlineMode Then
            Dim frm As New frmSetupFields("時疫", "commonFlu", "fluID", "fluName", "fluDesc")
            frm.ShowDialog()
        End If
    End Sub
#End Region
End Class
