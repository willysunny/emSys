<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlSetting
    Inherits pnlSlider

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.settingMetroPanel = New MetroFramework.Controls.MetroPanel()
        Me.saveSettingsButton = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.serverSetting = New MetroFramework.Controls.MetroTabPage()
        Me.dbName = New MetroFramework.Controls.MetroTextBox()
        Me.dbPass = New MetroFramework.Controls.MetroTextBox()
        Me.dbUser = New MetroFramework.Controls.MetroTextBox()
        Me.dbPort = New MetroFramework.Controls.MetroTextBox()
        Me.dbAddress = New MetroFramework.Controls.MetroTextBox()
        Me.testButton = New MetroFramework.Controls.MetroButton()
        Me.MetroLink6 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink5 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink7 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink4 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.themeSetting = New MetroFramework.Controls.MetroTabPage()
        Me.mrbDark = New MetroFramework.Controls.MetroRadioButton()
        Me.mrbLight = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLink3 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.bgcolor = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.settingLink = New MetroFramework.Controls.MetroLink()
        Me.settingMetroPanel.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.serverSetting.SuspendLayout()
        Me.themeSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'settingMetroPanel
        '
        Me.settingMetroPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingMetroPanel.Controls.Add(Me.saveSettingsButton)
        Me.settingMetroPanel.Controls.Add(Me.MetroTabControl1)
        Me.settingMetroPanel.Controls.Add(Me.Panel1)
        Me.settingMetroPanel.Controls.Add(Me.settingLink)
        Me.settingMetroPanel.HorizontalScrollbarBarColor = True
        Me.settingMetroPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.settingMetroPanel.HorizontalScrollbarSize = 10
        Me.settingMetroPanel.Location = New System.Drawing.Point(0, 0)
        Me.settingMetroPanel.Name = "settingMetroPanel"
        Me.settingMetroPanel.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.settingMetroPanel.Size = New System.Drawing.Size(400, 800)
        Me.settingMetroPanel.TabIndex = 2
        Me.settingMetroPanel.VerticalScrollbarBarColor = True
        Me.settingMetroPanel.VerticalScrollbarHighlightOnWheel = False
        Me.settingMetroPanel.VerticalScrollbarSize = 10
        '
        'saveSettingsButton
        '
        Me.saveSettingsButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveSettingsButton.Location = New System.Drawing.Point(11, 747)
        Me.saveSettingsButton.Name = "saveSettingsButton"
        Me.saveSettingsButton.Size = New System.Drawing.Size(386, 46)
        Me.saveSettingsButton.TabIndex = 6
        Me.saveSettingsButton.Text = "儲存設定"
        Me.saveSettingsButton.UseSelectable = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.serverSetting)
        Me.MetroTabControl1.Controls.Add(Me.themeSetting)
        Me.MetroTabControl1.Location = New System.Drawing.Point(8, 65)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(386, 680)
        Me.MetroTabControl1.TabIndex = 5
        Me.MetroTabControl1.UseSelectable = True
        '
        'serverSetting
        '
        Me.serverSetting.Controls.Add(Me.dbName)
        Me.serverSetting.Controls.Add(Me.dbPass)
        Me.serverSetting.Controls.Add(Me.dbUser)
        Me.serverSetting.Controls.Add(Me.dbPort)
        Me.serverSetting.Controls.Add(Me.dbAddress)
        Me.serverSetting.Controls.Add(Me.testButton)
        Me.serverSetting.Controls.Add(Me.MetroLink6)
        Me.serverSetting.Controls.Add(Me.MetroLink5)
        Me.serverSetting.Controls.Add(Me.MetroLink7)
        Me.serverSetting.Controls.Add(Me.MetroLink4)
        Me.serverSetting.Controls.Add(Me.MetroLink1)
        Me.serverSetting.HorizontalScrollbarBarColor = True
        Me.serverSetting.HorizontalScrollbarHighlightOnWheel = False
        Me.serverSetting.HorizontalScrollbarSize = 10
        Me.serverSetting.Location = New System.Drawing.Point(4, 38)
        Me.serverSetting.Name = "serverSetting"
        Me.serverSetting.Size = New System.Drawing.Size(378, 638)
        Me.serverSetting.TabIndex = 0
        Me.serverSetting.Text = "資料庫設定"
        Me.serverSetting.VerticalScrollbarBarColor = True
        Me.serverSetting.VerticalScrollbarHighlightOnWheel = False
        Me.serverSetting.VerticalScrollbarSize = 10
        '
        'dbName
        '
        '
        '
        '
        Me.dbName.CustomButton.Image = Nothing
        Me.dbName.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.dbName.CustomButton.Name = ""
        Me.dbName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.dbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dbName.CustomButton.TabIndex = 1
        Me.dbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dbName.CustomButton.UseSelectable = True
        Me.dbName.CustomButton.Visible = False
        Me.dbName.Lines = New String(-1) {}
        Me.dbName.Location = New System.Drawing.Point(0, 289)
        Me.dbName.MaxLength = 32767
        Me.dbName.Name = "dbName"
        Me.dbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbName.PromptText = "myDatabase"
        Me.dbName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dbName.SelectedText = ""
        Me.dbName.SelectionLength = 0
        Me.dbName.SelectionStart = 0
        Me.dbName.ShortcutsEnabled = True
        Me.dbName.Size = New System.Drawing.Size(372, 23)
        Me.dbName.TabIndex = 5
        Me.dbName.UseSelectable = True
        Me.dbName.WaterMark = "myDatabase"
        Me.dbName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dbName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dbPass
        '
        '
        '
        '
        Me.dbPass.CustomButton.Image = Nothing
        Me.dbPass.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.dbPass.CustomButton.Name = ""
        Me.dbPass.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.dbPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dbPass.CustomButton.TabIndex = 1
        Me.dbPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dbPass.CustomButton.UseSelectable = True
        Me.dbPass.CustomButton.Visible = False
        Me.dbPass.Lines = New String(-1) {}
        Me.dbPass.Location = New System.Drawing.Point(0, 231)
        Me.dbPass.MaxLength = 32767
        Me.dbPass.Name = "dbPass"
        Me.dbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.dbPass.PromptText = "登入資料庫的密碼"
        Me.dbPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dbPass.SelectedText = ""
        Me.dbPass.SelectionLength = 0
        Me.dbPass.SelectionStart = 0
        Me.dbPass.ShortcutsEnabled = True
        Me.dbPass.Size = New System.Drawing.Size(372, 23)
        Me.dbPass.TabIndex = 4
        Me.dbPass.UseSelectable = True
        Me.dbPass.WaterMark = "登入資料庫的密碼"
        Me.dbPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dbPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dbUser
        '
        '
        '
        '
        Me.dbUser.CustomButton.Image = Nothing
        Me.dbUser.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.dbUser.CustomButton.Name = ""
        Me.dbUser.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.dbUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dbUser.CustomButton.TabIndex = 1
        Me.dbUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dbUser.CustomButton.UseSelectable = True
        Me.dbUser.CustomButton.Visible = False
        Me.dbUser.Lines = New String(-1) {}
        Me.dbUser.Location = New System.Drawing.Point(0, 174)
        Me.dbUser.MaxLength = 32767
        Me.dbUser.Name = "dbUser"
        Me.dbUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbUser.PromptText = "登入資料庫的使用者名稱"
        Me.dbUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dbUser.SelectedText = ""
        Me.dbUser.SelectionLength = 0
        Me.dbUser.SelectionStart = 0
        Me.dbUser.ShortcutsEnabled = True
        Me.dbUser.Size = New System.Drawing.Size(372, 23)
        Me.dbUser.TabIndex = 3
        Me.dbUser.UseSelectable = True
        Me.dbUser.WaterMark = "登入資料庫的使用者名稱"
        Me.dbUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dbUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dbPort
        '
        '
        '
        '
        Me.dbPort.CustomButton.Image = Nothing
        Me.dbPort.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.dbPort.CustomButton.Name = ""
        Me.dbPort.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.dbPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dbPort.CustomButton.TabIndex = 1
        Me.dbPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dbPort.CustomButton.UseSelectable = True
        Me.dbPort.CustomButton.Visible = False
        Me.dbPort.Lines = New String(-1) {}
        Me.dbPort.Location = New System.Drawing.Point(3, 117)
        Me.dbPort.MaxLength = 32767
        Me.dbPort.Name = "dbPort"
        Me.dbPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbPort.PromptText = "預設為3306"
        Me.dbPort.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dbPort.SelectedText = ""
        Me.dbPort.SelectionLength = 0
        Me.dbPort.SelectionStart = 0
        Me.dbPort.ShortcutsEnabled = True
        Me.dbPort.Size = New System.Drawing.Size(372, 23)
        Me.dbPort.TabIndex = 2
        Me.dbPort.UseSelectable = True
        Me.dbPort.WaterMark = "預設為3306"
        Me.dbPort.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dbPort.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dbAddress
        '
        '
        '
        '
        Me.dbAddress.CustomButton.Image = Nothing
        Me.dbAddress.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.dbAddress.CustomButton.Name = ""
        Me.dbAddress.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.dbAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dbAddress.CustomButton.TabIndex = 1
        Me.dbAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dbAddress.CustomButton.UseSelectable = True
        Me.dbAddress.CustomButton.Visible = False
        Me.dbAddress.Lines = New String(-1) {}
        Me.dbAddress.Location = New System.Drawing.Point(3, 61)
        Me.dbAddress.MaxLength = 32767
        Me.dbAddress.Name = "dbAddress"
        Me.dbAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbAddress.PromptText = "192.168.1.100, database.yourdomain.com 或 localhost"
        Me.dbAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dbAddress.SelectedText = ""
        Me.dbAddress.SelectionLength = 0
        Me.dbAddress.SelectionStart = 0
        Me.dbAddress.ShortcutsEnabled = True
        Me.dbAddress.Size = New System.Drawing.Size(372, 23)
        Me.dbAddress.TabIndex = 1
        Me.dbAddress.UseSelectable = True
        Me.dbAddress.WaterMark = "192.168.1.100, database.yourdomain.com 或 localhost"
        Me.dbAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dbAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'testButton
        '
        Me.testButton.Location = New System.Drawing.Point(0, 346)
        Me.testButton.Name = "testButton"
        Me.testButton.Size = New System.Drawing.Size(378, 46)
        Me.testButton.TabIndex = 6
        Me.testButton.Text = "測試連線"
        Me.testButton.UseSelectable = True
        '
        'MetroLink6
        '
        Me.MetroLink6.Location = New System.Drawing.Point(0, 203)
        Me.MetroLink6.Name = "MetroLink6"
        Me.MetroLink6.Size = New System.Drawing.Size(378, 23)
        Me.MetroLink6.TabIndex = 2
        Me.MetroLink6.Text = "使用者密碼"
        Me.MetroLink6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink6.UseSelectable = True
        '
        'MetroLink5
        '
        Me.MetroLink5.Location = New System.Drawing.Point(0, 146)
        Me.MetroLink5.Name = "MetroLink5"
        Me.MetroLink5.Size = New System.Drawing.Size(378, 23)
        Me.MetroLink5.TabIndex = 2
        Me.MetroLink5.Text = "使用者名稱"
        Me.MetroLink5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink5.UseSelectable = True
        '
        'MetroLink7
        '
        Me.MetroLink7.Location = New System.Drawing.Point(0, 260)
        Me.MetroLink7.Name = "MetroLink7"
        Me.MetroLink7.Size = New System.Drawing.Size(378, 23)
        Me.MetroLink7.TabIndex = 2
        Me.MetroLink7.Text = "資料庫名稱"
        Me.MetroLink7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink7.UseSelectable = True
        '
        'MetroLink4
        '
        Me.MetroLink4.Location = New System.Drawing.Point(0, 89)
        Me.MetroLink4.Name = "MetroLink4"
        Me.MetroLink4.Size = New System.Drawing.Size(378, 23)
        Me.MetroLink4.TabIndex = 2
        Me.MetroLink4.Text = "伺服器埠號"
        Me.MetroLink4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink4.UseSelectable = True
        '
        'MetroLink1
        '
        Me.MetroLink1.Location = New System.Drawing.Point(0, 32)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(378, 23)
        Me.MetroLink1.TabIndex = 2
        Me.MetroLink1.Text = "伺服器位置"
        Me.MetroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink1.UseSelectable = True
        '
        'themeSetting
        '
        Me.themeSetting.Controls.Add(Me.mrbDark)
        Me.themeSetting.Controls.Add(Me.mrbLight)
        Me.themeSetting.Controls.Add(Me.MetroLink3)
        Me.themeSetting.Controls.Add(Me.MetroLink2)
        Me.themeSetting.Controls.Add(Me.bgcolor)
        Me.themeSetting.HorizontalScrollbarBarColor = True
        Me.themeSetting.HorizontalScrollbarHighlightOnWheel = False
        Me.themeSetting.HorizontalScrollbarSize = 10
        Me.themeSetting.Location = New System.Drawing.Point(4, 38)
        Me.themeSetting.Name = "themeSetting"
        Me.themeSetting.Padding = New System.Windows.Forms.Padding(0, 80, 0, 0)
        Me.themeSetting.Size = New System.Drawing.Size(378, 638)
        Me.themeSetting.TabIndex = 1
        Me.themeSetting.Text = "樣式設定"
        Me.themeSetting.VerticalScrollbarBarColor = True
        Me.themeSetting.VerticalScrollbarHighlightOnWheel = False
        Me.themeSetting.VerticalScrollbarSize = 10
        '
        'mrbDark
        '
        Me.mrbDark.AutoSize = True
        Me.mrbDark.Location = New System.Drawing.Point(59, 30)
        Me.mrbDark.Name = "mrbDark"
        Me.mrbDark.Size = New System.Drawing.Size(49, 15)
        Me.mrbDark.TabIndex = 9
        Me.mrbDark.Text = "深色"
        Me.mrbDark.UseSelectable = True
        '
        'mrbLight
        '
        Me.mrbLight.AutoSize = True
        Me.mrbLight.Checked = True
        Me.mrbLight.Location = New System.Drawing.Point(4, 30)
        Me.mrbLight.Name = "mrbLight"
        Me.mrbLight.Size = New System.Drawing.Size(49, 15)
        Me.mrbLight.TabIndex = 8
        Me.mrbLight.TabStop = True
        Me.mrbLight.Text = "亮白"
        Me.mrbLight.UseSelectable = True
        '
        'MetroLink3
        '
        Me.MetroLink3.Location = New System.Drawing.Point(4, 3)
        Me.MetroLink3.Name = "MetroLink3"
        Me.MetroLink3.Size = New System.Drawing.Size(75, 23)
        Me.MetroLink3.TabIndex = 7
        Me.MetroLink3.Text = "樣式"
        Me.MetroLink3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink3.UseSelectable = True
        '
        'MetroLink2
        '
        Me.MetroLink2.Location = New System.Drawing.Point(4, 51)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(75, 23)
        Me.MetroLink2.TabIndex = 7
        Me.MetroLink2.Text = "顏色"
        Me.MetroLink2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink2.UseSelectable = True
        '
        'bgcolor
        '
        Me.bgcolor.BackColor = System.Drawing.Color.Transparent
        Me.bgcolor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgcolor.Location = New System.Drawing.Point(0, 80)
        Me.bgcolor.Name = "bgcolor"
        Me.bgcolor.Size = New System.Drawing.Size(378, 558)
        Me.bgcolor.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 800)
        Me.Panel1.TabIndex = 3
        '
        'settingLink
        '
        Me.settingLink.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.settingLink.FontWeight = MetroFramework.MetroLinkWeight.Light
        Me.settingLink.Image = Global.emSys2016.My.Resources.Resources.backHover
        Me.settingLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settingLink.ImageSize = 32
        Me.settingLink.Location = New System.Drawing.Point(8, 3)
        Me.settingLink.Name = "settingLink"
        Me.settingLink.NoFocusImage = Global.emSys2016.My.Resources.Resources.backUp
        Me.settingLink.Size = New System.Drawing.Size(124, 56)
        Me.settingLink.TabIndex = 4
        Me.settingLink.Text = "設定"
        Me.settingLink.UseSelectable = True
        '
        'pnlSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.settingMetroPanel)
        Me.Name = "pnlSetting"
        Me.Size = New System.Drawing.Size(400, 800)
        Me.settingMetroPanel.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.serverSetting.ResumeLayout(False)
        Me.themeSetting.ResumeLayout(False)
        Me.themeSetting.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents settingMetroPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents saveSettingsButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents serverSetting As MetroFramework.Controls.MetroTabPage
    Friend WithEvents dbName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dbPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dbUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dbPort As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dbAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents testButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLink6 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink5 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink7 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink4 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents themeSetting As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mrbDark As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mrbLight As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLink3 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents bgcolor As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents settingLink As MetroFramework.Controls.MetroLink
End Class
