<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pnlSetting
    Inherits pnlSlider

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.settingMetroPanel = New MetroFramework.Controls.MetroPanel()
        Me.saveSettingsButton = New MetroFramework.Controls.MetroButton()
        Me.settingTab = New MetroFramework.Controls.MetroTabControl()
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
        Me.emsSetting = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabEnergySetting = New System.Windows.Forms.TabPage()
        Me.engSettingTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLink10 = New MetroFramework.Controls.MetroLink()
        Me.engLowerDanger = New MetroFramework.Controls.MetroTrackBar()
        Me.engUpperDanger = New MetroFramework.Controls.MetroTrackBar()
        Me.engLowerWarning = New MetroFramework.Controls.MetroTrackBar()
        Me.engUpperWarning = New MetroFramework.Controls.MetroTrackBar()
        Me.MetroLink16 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink12 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink14 = New MetroFramework.Controls.MetroLink()
        Me.engUpperDangerValue = New MetroFramework.Controls.MetroTextBox()
        Me.engUpperWarningValue = New MetroFramework.Controls.MetroTextBox()
        Me.engLowerWarningValue = New MetroFramework.Controls.MetroTextBox()
        Me.engLowerDangerValue = New MetroFramework.Controls.MetroTextBox()
        Me.tabGraphSetting = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLink11 = New MetroFramework.Controls.MetroLink()
        Me.emsLowerDanger = New MetroFramework.Controls.MetroTrackBar()
        Me.emsUpperDanger = New MetroFramework.Controls.MetroTrackBar()
        Me.emsLowerWarning = New MetroFramework.Controls.MetroTrackBar()
        Me.emsUpperWarning = New MetroFramework.Controls.MetroTrackBar()
        Me.MetroLink13 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink15 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink17 = New MetroFramework.Controls.MetroLink()
        Me.emsUpperDangerValue = New MetroFramework.Controls.MetroTextBox()
        Me.emsUpperWarningValue = New MetroFramework.Controls.MetroTextBox()
        Me.emsLowerWarningValue = New MetroFramework.Controls.MetroTextBox()
        Me.emsLowerDangerValue = New MetroFramework.Controls.MetroTextBox()
        Me.tabLiverSetting = New System.Windows.Forms.TabPage()
        Me.tabPressureSetting = New System.Windows.Forms.TabPage()
        Me.autoSaveTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLink8 = New MetroFramework.Controls.MetroLink()
        Me.themeSetting = New MetroFramework.Controls.MetroTabPage()
        Me.mrbDark = New MetroFramework.Controls.MetroRadioButton()
        Me.mrbLight = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLink3 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.bgcolor = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.settingLink = New MetroFramework.Controls.MetroLink()
        Me.MetroLink18 = New MetroFramework.Controls.MetroLink()
        Me.MetroLink19 = New MetroFramework.Controls.MetroLink()
        Me.autoStopTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.settingMetroPanel.SuspendLayout()
        Me.settingTab.SuspendLayout()
        Me.serverSetting.SuspendLayout()
        Me.emsSetting.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabEnergySetting.SuspendLayout()
        Me.engSettingTable.SuspendLayout()
        Me.tabGraphSetting.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.themeSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.ClientSize = New System.Drawing.Size(0, 0)
        Me.owner.Location = New System.Drawing.Point(-32000, -32000)
        Me.owner.WindowState = System.Windows.Forms.FormWindowState.Minimized
        '
        'settingMetroPanel
        '
        Me.settingMetroPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingMetroPanel.Controls.Add(Me.saveSettingsButton)
        Me.settingMetroPanel.Controls.Add(Me.settingTab)
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
        Me.saveSettingsButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.saveSettingsButton.Location = New System.Drawing.Point(11, 747)
        Me.saveSettingsButton.Name = "saveSettingsButton"
        Me.saveSettingsButton.Size = New System.Drawing.Size(379, 46)
        Me.saveSettingsButton.TabIndex = 6
        Me.saveSettingsButton.Text = "儲存設定"
        Me.saveSettingsButton.UseSelectable = True
        '
        'settingTab
        '
        Me.settingTab.Controls.Add(Me.serverSetting)
        Me.settingTab.Controls.Add(Me.emsSetting)
        Me.settingTab.Controls.Add(Me.themeSetting)
        Me.settingTab.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.settingTab.Location = New System.Drawing.Point(8, 65)
        Me.settingTab.Name = "settingTab"
        Me.settingTab.SelectedIndex = 1
        Me.settingTab.Size = New System.Drawing.Size(386, 680)
        Me.settingTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.settingTab.TabIndex = 5
        Me.settingTab.UseSelectable = True
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
        Me.serverSetting.Font = New System.Drawing.Font("PMingLiU", 14.0!)
        Me.serverSetting.HorizontalScrollbarBarColor = True
        Me.serverSetting.HorizontalScrollbarHighlightOnWheel = False
        Me.serverSetting.HorizontalScrollbarSize = 10
        Me.serverSetting.Location = New System.Drawing.Point(4, 44)
        Me.serverSetting.Name = "serverSetting"
        Me.serverSetting.Size = New System.Drawing.Size(378, 632)
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
        Me.dbName.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.dbName.CustomButton.Name = ""
        Me.dbName.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.dbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dbName.CustomButton.TabIndex = 1
        Me.dbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dbName.CustomButton.UseSelectable = True
        Me.dbName.CustomButton.Visible = False
        Me.dbName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.dbName.Lines = New String(-1) {}
        Me.dbName.Location = New System.Drawing.Point(37, 341)
        Me.dbName.MaxLength = 32767
        Me.dbName.Name = "dbName"
        Me.dbName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbName.PromptText = "myDatabase"
        Me.dbName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dbName.SelectedText = ""
        Me.dbName.SelectionLength = 0
        Me.dbName.SelectionStart = 0
        Me.dbName.ShortcutsEnabled = True
        Me.dbName.Size = New System.Drawing.Size(289, 35)
        Me.dbName.TabIndex = 5
        Me.dbName.UseSelectable = True
        Me.dbName.WaterMark = "myDatabase"
        Me.dbName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dbName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dbPass
        '
        '
        '
        '
        Me.dbPass.CustomButton.Image = Nothing
        Me.dbPass.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.dbPass.CustomButton.Name = ""
        Me.dbPass.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.dbPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dbPass.CustomButton.TabIndex = 1
        Me.dbPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dbPass.CustomButton.UseSelectable = True
        Me.dbPass.CustomButton.Visible = False
        Me.dbPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.dbPass.Lines = New String(-1) {}
        Me.dbPass.Location = New System.Drawing.Point(37, 271)
        Me.dbPass.MaxLength = 32767
        Me.dbPass.Name = "dbPass"
        Me.dbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.dbPass.PromptText = "登入資料庫的密碼"
        Me.dbPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dbPass.SelectedText = ""
        Me.dbPass.SelectionLength = 0
        Me.dbPass.SelectionStart = 0
        Me.dbPass.ShortcutsEnabled = True
        Me.dbPass.Size = New System.Drawing.Size(289, 35)
        Me.dbPass.TabIndex = 4
        Me.dbPass.UseSelectable = True
        Me.dbPass.WaterMark = "登入資料庫的密碼"
        Me.dbPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dbPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dbUser
        '
        '
        '
        '
        Me.dbUser.CustomButton.Image = Nothing
        Me.dbUser.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.dbUser.CustomButton.Name = ""
        Me.dbUser.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.dbUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dbUser.CustomButton.TabIndex = 1
        Me.dbUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dbUser.CustomButton.UseSelectable = True
        Me.dbUser.CustomButton.Visible = False
        Me.dbUser.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.dbUser.Lines = New String(-1) {}
        Me.dbUser.Location = New System.Drawing.Point(37, 201)
        Me.dbUser.MaxLength = 32767
        Me.dbUser.Name = "dbUser"
        Me.dbUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbUser.PromptText = "登入資料庫的使用者名稱"
        Me.dbUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dbUser.SelectedText = ""
        Me.dbUser.SelectionLength = 0
        Me.dbUser.SelectionStart = 0
        Me.dbUser.ShortcutsEnabled = True
        Me.dbUser.Size = New System.Drawing.Size(289, 35)
        Me.dbUser.TabIndex = 3
        Me.dbUser.UseSelectable = True
        Me.dbUser.WaterMark = "登入資料庫的使用者名稱"
        Me.dbUser.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dbUser.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dbPort
        '
        '
        '
        '
        Me.dbPort.CustomButton.Image = Nothing
        Me.dbPort.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.dbPort.CustomButton.Name = ""
        Me.dbPort.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.dbPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dbPort.CustomButton.TabIndex = 1
        Me.dbPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dbPort.CustomButton.UseSelectable = True
        Me.dbPort.CustomButton.Visible = False
        Me.dbPort.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.dbPort.Lines = New String(-1) {}
        Me.dbPort.Location = New System.Drawing.Point(37, 131)
        Me.dbPort.MaxLength = 32767
        Me.dbPort.Name = "dbPort"
        Me.dbPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbPort.PromptText = "預設為3306"
        Me.dbPort.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dbPort.SelectedText = ""
        Me.dbPort.SelectionLength = 0
        Me.dbPort.SelectionStart = 0
        Me.dbPort.ShortcutsEnabled = True
        Me.dbPort.Size = New System.Drawing.Size(289, 35)
        Me.dbPort.TabIndex = 2
        Me.dbPort.UseSelectable = True
        Me.dbPort.WaterMark = "預設為3306"
        Me.dbPort.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dbPort.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dbAddress
        '
        '
        '
        '
        Me.dbAddress.CustomButton.Image = Nothing
        Me.dbAddress.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.dbAddress.CustomButton.Name = ""
        Me.dbAddress.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.dbAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dbAddress.CustomButton.TabIndex = 1
        Me.dbAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dbAddress.CustomButton.UseSelectable = True
        Me.dbAddress.CustomButton.Visible = False
        Me.dbAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.dbAddress.Lines = New String(-1) {}
        Me.dbAddress.Location = New System.Drawing.Point(37, 61)
        Me.dbAddress.MaxLength = 32767
        Me.dbAddress.Name = "dbAddress"
        Me.dbAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dbAddress.PromptText = "192.168.1.100, database.yourdomain.com 或 localhost"
        Me.dbAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dbAddress.SelectedText = ""
        Me.dbAddress.SelectionLength = 0
        Me.dbAddress.SelectionStart = 0
        Me.dbAddress.ShortcutsEnabled = True
        Me.dbAddress.Size = New System.Drawing.Size(289, 35)
        Me.dbAddress.TabIndex = 1
        Me.dbAddress.UseSelectable = True
        Me.dbAddress.WaterMark = "192.168.1.100, database.yourdomain.com 或 localhost"
        Me.dbAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dbAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'testButton
        '
        Me.testButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.testButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.testButton.Location = New System.Drawing.Point(0, 411)
        Me.testButton.Name = "testButton"
        Me.testButton.Size = New System.Drawing.Size(378, 46)
        Me.testButton.TabIndex = 6
        Me.testButton.Text = "測試連線"
        Me.testButton.UseSelectable = True
        '
        'MetroLink6
        '
        Me.MetroLink6.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink6.Location = New System.Drawing.Point(37, 242)
        Me.MetroLink6.Name = "MetroLink6"
        Me.MetroLink6.Size = New System.Drawing.Size(289, 23)
        Me.MetroLink6.TabIndex = 2
        Me.MetroLink6.Text = "使用者密碼"
        Me.MetroLink6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink6.UseSelectable = True
        '
        'MetroLink5
        '
        Me.MetroLink5.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink5.Location = New System.Drawing.Point(37, 172)
        Me.MetroLink5.Name = "MetroLink5"
        Me.MetroLink5.Size = New System.Drawing.Size(289, 23)
        Me.MetroLink5.TabIndex = 2
        Me.MetroLink5.Text = "使用者名稱"
        Me.MetroLink5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink5.UseSelectable = True
        '
        'MetroLink7
        '
        Me.MetroLink7.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink7.Location = New System.Drawing.Point(37, 312)
        Me.MetroLink7.Name = "MetroLink7"
        Me.MetroLink7.Size = New System.Drawing.Size(289, 23)
        Me.MetroLink7.TabIndex = 2
        Me.MetroLink7.Text = "資料庫名稱"
        Me.MetroLink7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink7.UseSelectable = True
        '
        'MetroLink4
        '
        Me.MetroLink4.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink4.Location = New System.Drawing.Point(37, 102)
        Me.MetroLink4.Name = "MetroLink4"
        Me.MetroLink4.Size = New System.Drawing.Size(289, 23)
        Me.MetroLink4.TabIndex = 2
        Me.MetroLink4.Text = "伺服器埠號"
        Me.MetroLink4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink4.UseSelectable = True
        '
        'MetroLink1
        '
        Me.MetroLink1.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink1.Location = New System.Drawing.Point(37, 32)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(289, 23)
        Me.MetroLink1.TabIndex = 2
        Me.MetroLink1.Text = "伺服器位置"
        Me.MetroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink1.UseSelectable = True
        '
        'emsSetting
        '
        Me.emsSetting.Controls.Add(Me.MetroTabControl1)
        Me.emsSetting.Controls.Add(Me.autoStopTextBox)
        Me.emsSetting.Controls.Add(Me.autoSaveTextBox)
        Me.emsSetting.Controls.Add(Me.MetroLink19)
        Me.emsSetting.Controls.Add(Me.MetroLink18)
        Me.emsSetting.Controls.Add(Me.MetroLink8)
        Me.emsSetting.HorizontalScrollbarBarColor = True
        Me.emsSetting.HorizontalScrollbarHighlightOnWheel = False
        Me.emsSetting.HorizontalScrollbarSize = 10
        Me.emsSetting.Location = New System.Drawing.Point(4, 44)
        Me.emsSetting.Name = "emsSetting"
        Me.emsSetting.Size = New System.Drawing.Size(378, 632)
        Me.emsSetting.TabIndex = 2
        Me.emsSetting.Text = "頻譜設定"
        Me.emsSetting.VerticalScrollbarBarColor = True
        Me.emsSetting.VerticalScrollbarHighlightOnWheel = False
        Me.emsSetting.VerticalScrollbarSize = 10
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabEnergySetting)
        Me.MetroTabControl1.Controls.Add(Me.tabGraphSetting)
        Me.MetroTabControl1.Controls.Add(Me.tabLiverSetting)
        Me.MetroTabControl1.Controls.Add(Me.tabPressureSetting)
        Me.MetroTabControl1.Location = New System.Drawing.Point(37, 201)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(289, 423)
        Me.MetroTabControl1.TabIndex = 5
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabEnergySetting
        '
        Me.tabEnergySetting.Controls.Add(Me.engSettingTable)
        Me.tabEnergySetting.Location = New System.Drawing.Point(4, 38)
        Me.tabEnergySetting.Name = "tabEnergySetting"
        Me.tabEnergySetting.Size = New System.Drawing.Size(281, 381)
        Me.tabEnergySetting.TabIndex = 0
        Me.tabEnergySetting.Text = "元氣指數"
        '
        'engSettingTable
        '
        Me.engSettingTable.BackColor = System.Drawing.Color.Transparent
        Me.engSettingTable.ColumnCount = 2
        Me.engSettingTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.engSettingTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.engSettingTable.Controls.Add(Me.MetroLink10, 0, 0)
        Me.engSettingTable.Controls.Add(Me.engLowerDanger, 0, 7)
        Me.engSettingTable.Controls.Add(Me.engUpperDanger, 0, 1)
        Me.engSettingTable.Controls.Add(Me.engLowerWarning, 0, 5)
        Me.engSettingTable.Controls.Add(Me.engUpperWarning, 0, 3)
        Me.engSettingTable.Controls.Add(Me.MetroLink16, 0, 6)
        Me.engSettingTable.Controls.Add(Me.MetroLink12, 0, 2)
        Me.engSettingTable.Controls.Add(Me.MetroLink14, 0, 4)
        Me.engSettingTable.Controls.Add(Me.engUpperDangerValue, 1, 1)
        Me.engSettingTable.Controls.Add(Me.engUpperWarningValue, 1, 3)
        Me.engSettingTable.Controls.Add(Me.engLowerWarningValue, 1, 5)
        Me.engSettingTable.Controls.Add(Me.engLowerDangerValue, 1, 7)
        Me.engSettingTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.engSettingTable.Location = New System.Drawing.Point(0, 0)
        Me.engSettingTable.Name = "engSettingTable"
        Me.engSettingTable.RowCount = 9
        Me.engSettingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.engSettingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.engSettingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.engSettingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.engSettingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.engSettingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.engSettingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.engSettingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.engSettingTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.engSettingTable.Size = New System.Drawing.Size(281, 381)
        Me.engSettingTable.TabIndex = 6
        '
        'MetroLink10
        '
        Me.engSettingTable.SetColumnSpan(Me.MetroLink10, 2)
        Me.MetroLink10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink10.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink10.Location = New System.Drawing.Point(0, 0)
        Me.MetroLink10.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink10.Name = "MetroLink10"
        Me.MetroLink10.Size = New System.Drawing.Size(281, 30)
        Me.MetroLink10.TabIndex = 4
        Me.MetroLink10.Text = "上危險值"
        Me.MetroLink10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink10.UseSelectable = True
        '
        'engLowerDanger
        '
        Me.engLowerDanger.BackColor = System.Drawing.Color.Transparent
        Me.engLowerDanger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.engLowerDanger.Location = New System.Drawing.Point(0, 210)
        Me.engLowerDanger.Margin = New System.Windows.Forms.Padding(0)
        Me.engLowerDanger.Name = "engLowerDanger"
        Me.engLowerDanger.Size = New System.Drawing.Size(181, 30)
        Me.engLowerDanger.TabIndex = 2
        Me.engLowerDanger.Text = "下危險值"
        '
        'engUpperDanger
        '
        Me.engUpperDanger.BackColor = System.Drawing.Color.Transparent
        Me.engUpperDanger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.engUpperDanger.Location = New System.Drawing.Point(0, 30)
        Me.engUpperDanger.Margin = New System.Windows.Forms.Padding(0)
        Me.engUpperDanger.Name = "engUpperDanger"
        Me.engUpperDanger.Size = New System.Drawing.Size(181, 30)
        Me.engUpperDanger.TabIndex = 2
        Me.engUpperDanger.Text = "上危險值"
        Me.engUpperDanger.Value = 95
        '
        'engLowerWarning
        '
        Me.engLowerWarning.BackColor = System.Drawing.Color.Transparent
        Me.engLowerWarning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.engLowerWarning.Location = New System.Drawing.Point(0, 150)
        Me.engLowerWarning.Margin = New System.Windows.Forms.Padding(0)
        Me.engLowerWarning.Name = "engLowerWarning"
        Me.engLowerWarning.Size = New System.Drawing.Size(181, 30)
        Me.engLowerWarning.TabIndex = 2
        Me.engLowerWarning.Text = "下警戒值"
        Me.engLowerWarning.Value = 85
        '
        'engUpperWarning
        '
        Me.engUpperWarning.BackColor = System.Drawing.Color.Transparent
        Me.engUpperWarning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.engUpperWarning.Location = New System.Drawing.Point(0, 90)
        Me.engUpperWarning.Margin = New System.Windows.Forms.Padding(0)
        Me.engUpperWarning.Name = "engUpperWarning"
        Me.engUpperWarning.Size = New System.Drawing.Size(181, 30)
        Me.engUpperWarning.TabIndex = 2
        Me.engUpperWarning.Text = "上警戒值"
        Me.engUpperWarning.Value = 95
        '
        'MetroLink16
        '
        Me.engSettingTable.SetColumnSpan(Me.MetroLink16, 2)
        Me.MetroLink16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink16.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink16.Location = New System.Drawing.Point(0, 180)
        Me.MetroLink16.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink16.Name = "MetroLink16"
        Me.MetroLink16.Size = New System.Drawing.Size(281, 30)
        Me.MetroLink16.TabIndex = 4
        Me.MetroLink16.Text = "下危險值"
        Me.MetroLink16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink16.UseSelectable = True
        '
        'MetroLink12
        '
        Me.engSettingTable.SetColumnSpan(Me.MetroLink12, 2)
        Me.MetroLink12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink12.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink12.Location = New System.Drawing.Point(0, 60)
        Me.MetroLink12.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink12.Name = "MetroLink12"
        Me.MetroLink12.Size = New System.Drawing.Size(281, 30)
        Me.MetroLink12.TabIndex = 4
        Me.MetroLink12.Text = "上警戒值"
        Me.MetroLink12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink12.UseSelectable = True
        '
        'MetroLink14
        '
        Me.engSettingTable.SetColumnSpan(Me.MetroLink14, 2)
        Me.MetroLink14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink14.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink14.Location = New System.Drawing.Point(0, 120)
        Me.MetroLink14.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink14.Name = "MetroLink14"
        Me.MetroLink14.Size = New System.Drawing.Size(281, 30)
        Me.MetroLink14.TabIndex = 4
        Me.MetroLink14.Text = "下警戒值"
        Me.MetroLink14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink14.UseSelectable = True
        '
        'engUpperDangerValue
        '
        '
        '
        '
        Me.engUpperDangerValue.CustomButton.Image = Nothing
        Me.engUpperDangerValue.CustomButton.Location = New System.Drawing.Point(72, 2)
        Me.engUpperDangerValue.CustomButton.Name = ""
        Me.engUpperDangerValue.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.engUpperDangerValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.engUpperDangerValue.CustomButton.TabIndex = 1
        Me.engUpperDangerValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.engUpperDangerValue.CustomButton.UseSelectable = True
        Me.engUpperDangerValue.CustomButton.Visible = False
        Me.engUpperDangerValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.engUpperDangerValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.engUpperDangerValue.Lines = New String() {"95"}
        Me.engUpperDangerValue.Location = New System.Drawing.Point(181, 30)
        Me.engUpperDangerValue.Margin = New System.Windows.Forms.Padding(0)
        Me.engUpperDangerValue.MaxLength = 32767
        Me.engUpperDangerValue.Name = "engUpperDangerValue"
        Me.engUpperDangerValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.engUpperDangerValue.PromptText = "0~100"
        Me.engUpperDangerValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.engUpperDangerValue.SelectedText = ""
        Me.engUpperDangerValue.SelectionLength = 0
        Me.engUpperDangerValue.SelectionStart = 0
        Me.engUpperDangerValue.ShortcutsEnabled = True
        Me.engUpperDangerValue.Size = New System.Drawing.Size(100, 30)
        Me.engUpperDangerValue.TabIndex = 5
        Me.engUpperDangerValue.Text = "95"
        Me.engUpperDangerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.engUpperDangerValue.UseSelectable = True
        Me.engUpperDangerValue.WaterMark = "0~100"
        Me.engUpperDangerValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.engUpperDangerValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'engUpperWarningValue
        '
        '
        '
        '
        Me.engUpperWarningValue.CustomButton.Image = Nothing
        Me.engUpperWarningValue.CustomButton.Location = New System.Drawing.Point(72, 2)
        Me.engUpperWarningValue.CustomButton.Name = ""
        Me.engUpperWarningValue.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.engUpperWarningValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.engUpperWarningValue.CustomButton.TabIndex = 1
        Me.engUpperWarningValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.engUpperWarningValue.CustomButton.UseSelectable = True
        Me.engUpperWarningValue.CustomButton.Visible = False
        Me.engUpperWarningValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.engUpperWarningValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.engUpperWarningValue.Lines = New String() {"95"}
        Me.engUpperWarningValue.Location = New System.Drawing.Point(181, 90)
        Me.engUpperWarningValue.Margin = New System.Windows.Forms.Padding(0)
        Me.engUpperWarningValue.MaxLength = 32767
        Me.engUpperWarningValue.Name = "engUpperWarningValue"
        Me.engUpperWarningValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.engUpperWarningValue.PromptText = "0~100"
        Me.engUpperWarningValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.engUpperWarningValue.SelectedText = ""
        Me.engUpperWarningValue.SelectionLength = 0
        Me.engUpperWarningValue.SelectionStart = 0
        Me.engUpperWarningValue.ShortcutsEnabled = True
        Me.engUpperWarningValue.Size = New System.Drawing.Size(100, 30)
        Me.engUpperWarningValue.TabIndex = 5
        Me.engUpperWarningValue.Text = "95"
        Me.engUpperWarningValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.engUpperWarningValue.UseSelectable = True
        Me.engUpperWarningValue.WaterMark = "0~100"
        Me.engUpperWarningValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.engUpperWarningValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'engLowerWarningValue
        '
        '
        '
        '
        Me.engLowerWarningValue.CustomButton.Image = Nothing
        Me.engLowerWarningValue.CustomButton.Location = New System.Drawing.Point(72, 2)
        Me.engLowerWarningValue.CustomButton.Name = ""
        Me.engLowerWarningValue.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.engLowerWarningValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.engLowerWarningValue.CustomButton.TabIndex = 1
        Me.engLowerWarningValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.engLowerWarningValue.CustomButton.UseSelectable = True
        Me.engLowerWarningValue.CustomButton.Visible = False
        Me.engLowerWarningValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.engLowerWarningValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.engLowerWarningValue.Lines = New String() {"85"}
        Me.engLowerWarningValue.Location = New System.Drawing.Point(181, 150)
        Me.engLowerWarningValue.Margin = New System.Windows.Forms.Padding(0)
        Me.engLowerWarningValue.MaxLength = 32767
        Me.engLowerWarningValue.Name = "engLowerWarningValue"
        Me.engLowerWarningValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.engLowerWarningValue.PromptText = "0~100"
        Me.engLowerWarningValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.engLowerWarningValue.SelectedText = ""
        Me.engLowerWarningValue.SelectionLength = 0
        Me.engLowerWarningValue.SelectionStart = 0
        Me.engLowerWarningValue.ShortcutsEnabled = True
        Me.engLowerWarningValue.Size = New System.Drawing.Size(100, 30)
        Me.engLowerWarningValue.TabIndex = 5
        Me.engLowerWarningValue.Text = "85"
        Me.engLowerWarningValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.engLowerWarningValue.UseSelectable = True
        Me.engLowerWarningValue.WaterMark = "0~100"
        Me.engLowerWarningValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.engLowerWarningValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'engLowerDangerValue
        '
        '
        '
        '
        Me.engLowerDangerValue.CustomButton.Image = Nothing
        Me.engLowerDangerValue.CustomButton.Location = New System.Drawing.Point(72, 2)
        Me.engLowerDangerValue.CustomButton.Name = ""
        Me.engLowerDangerValue.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.engLowerDangerValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.engLowerDangerValue.CustomButton.TabIndex = 1
        Me.engLowerDangerValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.engLowerDangerValue.CustomButton.UseSelectable = True
        Me.engLowerDangerValue.CustomButton.Visible = False
        Me.engLowerDangerValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.engLowerDangerValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.engLowerDangerValue.Lines = New String() {"50"}
        Me.engLowerDangerValue.Location = New System.Drawing.Point(181, 210)
        Me.engLowerDangerValue.Margin = New System.Windows.Forms.Padding(0)
        Me.engLowerDangerValue.MaxLength = 32767
        Me.engLowerDangerValue.Name = "engLowerDangerValue"
        Me.engLowerDangerValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.engLowerDangerValue.PromptText = "0~100"
        Me.engLowerDangerValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.engLowerDangerValue.SelectedText = ""
        Me.engLowerDangerValue.SelectionLength = 0
        Me.engLowerDangerValue.SelectionStart = 0
        Me.engLowerDangerValue.ShortcutsEnabled = True
        Me.engLowerDangerValue.Size = New System.Drawing.Size(100, 30)
        Me.engLowerDangerValue.TabIndex = 5
        Me.engLowerDangerValue.Text = "50"
        Me.engLowerDangerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.engLowerDangerValue.UseSelectable = True
        Me.engLowerDangerValue.WaterMark = "0~100"
        Me.engLowerDangerValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.engLowerDangerValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tabGraphSetting
        '
        Me.tabGraphSetting.Controls.Add(Me.TableLayoutPanel1)
        Me.tabGraphSetting.Location = New System.Drawing.Point(4, 38)
        Me.tabGraphSetting.Name = "tabGraphSetting"
        Me.tabGraphSetting.Size = New System.Drawing.Size(281, 451)
        Me.tabGraphSetting.TabIndex = 1
        Me.tabGraphSetting.Text = "一般指數"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLink11, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.emsLowerDanger, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.emsUpperDanger, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.emsLowerWarning, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.emsUpperWarning, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLink13, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLink15, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLink17, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.emsUpperDangerValue, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.emsUpperWarningValue, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.emsLowerWarningValue, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.emsLowerDangerValue, 1, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(281, 451)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'MetroLink11
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.MetroLink11, 2)
        Me.MetroLink11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink11.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink11.Location = New System.Drawing.Point(0, 0)
        Me.MetroLink11.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink11.Name = "MetroLink11"
        Me.MetroLink11.Size = New System.Drawing.Size(281, 30)
        Me.MetroLink11.TabIndex = 4
        Me.MetroLink11.Text = "上危險值"
        Me.MetroLink11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink11.UseSelectable = True
        '
        'emsLowerDanger
        '
        Me.emsLowerDanger.BackColor = System.Drawing.Color.Transparent
        Me.emsLowerDanger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emsLowerDanger.Location = New System.Drawing.Point(0, 210)
        Me.emsLowerDanger.Margin = New System.Windows.Forms.Padding(0)
        Me.emsLowerDanger.Name = "emsLowerDanger"
        Me.emsLowerDanger.Size = New System.Drawing.Size(181, 30)
        Me.emsLowerDanger.TabIndex = 2
        Me.emsLowerDanger.Text = "下危險值"
        Me.emsLowerDanger.Value = 20
        '
        'emsUpperDanger
        '
        Me.emsUpperDanger.BackColor = System.Drawing.Color.Transparent
        Me.emsUpperDanger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emsUpperDanger.Location = New System.Drawing.Point(0, 30)
        Me.emsUpperDanger.Margin = New System.Windows.Forms.Padding(0)
        Me.emsUpperDanger.Name = "emsUpperDanger"
        Me.emsUpperDanger.Size = New System.Drawing.Size(181, 30)
        Me.emsUpperDanger.TabIndex = 2
        Me.emsUpperDanger.Text = "上危險值"
        Me.emsUpperDanger.Value = 55
        '
        'emsLowerWarning
        '
        Me.emsLowerWarning.BackColor = System.Drawing.Color.Transparent
        Me.emsLowerWarning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emsLowerWarning.Location = New System.Drawing.Point(0, 150)
        Me.emsLowerWarning.Margin = New System.Windows.Forms.Padding(0)
        Me.emsLowerWarning.Name = "emsLowerWarning"
        Me.emsLowerWarning.Size = New System.Drawing.Size(181, 30)
        Me.emsLowerWarning.TabIndex = 2
        Me.emsLowerWarning.Text = "下警戒值"
        Me.emsLowerWarning.Value = 45
        '
        'emsUpperWarning
        '
        Me.emsUpperWarning.BackColor = System.Drawing.Color.Transparent
        Me.emsUpperWarning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emsUpperWarning.Location = New System.Drawing.Point(0, 90)
        Me.emsUpperWarning.Margin = New System.Windows.Forms.Padding(0)
        Me.emsUpperWarning.Name = "emsUpperWarning"
        Me.emsUpperWarning.Size = New System.Drawing.Size(181, 30)
        Me.emsUpperWarning.TabIndex = 2
        Me.emsUpperWarning.Text = "上警戒值"
        Me.emsUpperWarning.Value = 55
        '
        'MetroLink13
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.MetroLink13, 2)
        Me.MetroLink13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink13.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink13.Location = New System.Drawing.Point(0, 180)
        Me.MetroLink13.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink13.Name = "MetroLink13"
        Me.MetroLink13.Size = New System.Drawing.Size(281, 30)
        Me.MetroLink13.TabIndex = 4
        Me.MetroLink13.Text = "下危險值"
        Me.MetroLink13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink13.UseSelectable = True
        '
        'MetroLink15
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.MetroLink15, 2)
        Me.MetroLink15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink15.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink15.Location = New System.Drawing.Point(0, 60)
        Me.MetroLink15.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink15.Name = "MetroLink15"
        Me.MetroLink15.Size = New System.Drawing.Size(281, 30)
        Me.MetroLink15.TabIndex = 4
        Me.MetroLink15.Text = "上警戒值"
        Me.MetroLink15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink15.UseSelectable = True
        '
        'MetroLink17
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.MetroLink17, 2)
        Me.MetroLink17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink17.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink17.Location = New System.Drawing.Point(0, 120)
        Me.MetroLink17.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroLink17.Name = "MetroLink17"
        Me.MetroLink17.Size = New System.Drawing.Size(281, 30)
        Me.MetroLink17.TabIndex = 4
        Me.MetroLink17.Text = "下警戒值"
        Me.MetroLink17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink17.UseSelectable = True
        '
        'emsUpperDangerValue
        '
        '
        '
        '
        Me.emsUpperDangerValue.CustomButton.Image = Nothing
        Me.emsUpperDangerValue.CustomButton.Location = New System.Drawing.Point(72, 2)
        Me.emsUpperDangerValue.CustomButton.Name = ""
        Me.emsUpperDangerValue.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.emsUpperDangerValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.emsUpperDangerValue.CustomButton.TabIndex = 1
        Me.emsUpperDangerValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.emsUpperDangerValue.CustomButton.UseSelectable = True
        Me.emsUpperDangerValue.CustomButton.Visible = False
        Me.emsUpperDangerValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emsUpperDangerValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.emsUpperDangerValue.Lines = New String() {"55"}
        Me.emsUpperDangerValue.Location = New System.Drawing.Point(181, 30)
        Me.emsUpperDangerValue.Margin = New System.Windows.Forms.Padding(0)
        Me.emsUpperDangerValue.MaxLength = 32767
        Me.emsUpperDangerValue.Name = "emsUpperDangerValue"
        Me.emsUpperDangerValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emsUpperDangerValue.PromptText = "0~100"
        Me.emsUpperDangerValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emsUpperDangerValue.SelectedText = ""
        Me.emsUpperDangerValue.SelectionLength = 0
        Me.emsUpperDangerValue.SelectionStart = 0
        Me.emsUpperDangerValue.ShortcutsEnabled = True
        Me.emsUpperDangerValue.Size = New System.Drawing.Size(100, 30)
        Me.emsUpperDangerValue.TabIndex = 5
        Me.emsUpperDangerValue.Text = "55"
        Me.emsUpperDangerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.emsUpperDangerValue.UseSelectable = True
        Me.emsUpperDangerValue.WaterMark = "0~100"
        Me.emsUpperDangerValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.emsUpperDangerValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'emsUpperWarningValue
        '
        '
        '
        '
        Me.emsUpperWarningValue.CustomButton.Image = Nothing
        Me.emsUpperWarningValue.CustomButton.Location = New System.Drawing.Point(72, 2)
        Me.emsUpperWarningValue.CustomButton.Name = ""
        Me.emsUpperWarningValue.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.emsUpperWarningValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.emsUpperWarningValue.CustomButton.TabIndex = 1
        Me.emsUpperWarningValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.emsUpperWarningValue.CustomButton.UseSelectable = True
        Me.emsUpperWarningValue.CustomButton.Visible = False
        Me.emsUpperWarningValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emsUpperWarningValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.emsUpperWarningValue.Lines = New String() {"55"}
        Me.emsUpperWarningValue.Location = New System.Drawing.Point(181, 90)
        Me.emsUpperWarningValue.Margin = New System.Windows.Forms.Padding(0)
        Me.emsUpperWarningValue.MaxLength = 32767
        Me.emsUpperWarningValue.Name = "emsUpperWarningValue"
        Me.emsUpperWarningValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emsUpperWarningValue.PromptText = "0~100"
        Me.emsUpperWarningValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emsUpperWarningValue.SelectedText = ""
        Me.emsUpperWarningValue.SelectionLength = 0
        Me.emsUpperWarningValue.SelectionStart = 0
        Me.emsUpperWarningValue.ShortcutsEnabled = True
        Me.emsUpperWarningValue.Size = New System.Drawing.Size(100, 30)
        Me.emsUpperWarningValue.TabIndex = 5
        Me.emsUpperWarningValue.Text = "55"
        Me.emsUpperWarningValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.emsUpperWarningValue.UseSelectable = True
        Me.emsUpperWarningValue.WaterMark = "0~100"
        Me.emsUpperWarningValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.emsUpperWarningValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'emsLowerWarningValue
        '
        '
        '
        '
        Me.emsLowerWarningValue.CustomButton.Image = Nothing
        Me.emsLowerWarningValue.CustomButton.Location = New System.Drawing.Point(72, 2)
        Me.emsLowerWarningValue.CustomButton.Name = ""
        Me.emsLowerWarningValue.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.emsLowerWarningValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.emsLowerWarningValue.CustomButton.TabIndex = 1
        Me.emsLowerWarningValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.emsLowerWarningValue.CustomButton.UseSelectable = True
        Me.emsLowerWarningValue.CustomButton.Visible = False
        Me.emsLowerWarningValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emsLowerWarningValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.emsLowerWarningValue.Lines = New String() {"45"}
        Me.emsLowerWarningValue.Location = New System.Drawing.Point(181, 150)
        Me.emsLowerWarningValue.Margin = New System.Windows.Forms.Padding(0)
        Me.emsLowerWarningValue.MaxLength = 32767
        Me.emsLowerWarningValue.Name = "emsLowerWarningValue"
        Me.emsLowerWarningValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emsLowerWarningValue.PromptText = "0~100"
        Me.emsLowerWarningValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emsLowerWarningValue.SelectedText = ""
        Me.emsLowerWarningValue.SelectionLength = 0
        Me.emsLowerWarningValue.SelectionStart = 0
        Me.emsLowerWarningValue.ShortcutsEnabled = True
        Me.emsLowerWarningValue.Size = New System.Drawing.Size(100, 30)
        Me.emsLowerWarningValue.TabIndex = 5
        Me.emsLowerWarningValue.Text = "45"
        Me.emsLowerWarningValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.emsLowerWarningValue.UseSelectable = True
        Me.emsLowerWarningValue.WaterMark = "0~100"
        Me.emsLowerWarningValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.emsLowerWarningValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'emsLowerDangerValue
        '
        '
        '
        '
        Me.emsLowerDangerValue.CustomButton.Image = Nothing
        Me.emsLowerDangerValue.CustomButton.Location = New System.Drawing.Point(72, 2)
        Me.emsLowerDangerValue.CustomButton.Name = ""
        Me.emsLowerDangerValue.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.emsLowerDangerValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.emsLowerDangerValue.CustomButton.TabIndex = 1
        Me.emsLowerDangerValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.emsLowerDangerValue.CustomButton.UseSelectable = True
        Me.emsLowerDangerValue.CustomButton.Visible = False
        Me.emsLowerDangerValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emsLowerDangerValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.emsLowerDangerValue.Lines = New String() {"20"}
        Me.emsLowerDangerValue.Location = New System.Drawing.Point(181, 210)
        Me.emsLowerDangerValue.Margin = New System.Windows.Forms.Padding(0)
        Me.emsLowerDangerValue.MaxLength = 32767
        Me.emsLowerDangerValue.Name = "emsLowerDangerValue"
        Me.emsLowerDangerValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emsLowerDangerValue.PromptText = "0~100"
        Me.emsLowerDangerValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emsLowerDangerValue.SelectedText = ""
        Me.emsLowerDangerValue.SelectionLength = 0
        Me.emsLowerDangerValue.SelectionStart = 0
        Me.emsLowerDangerValue.ShortcutsEnabled = True
        Me.emsLowerDangerValue.Size = New System.Drawing.Size(100, 30)
        Me.emsLowerDangerValue.TabIndex = 5
        Me.emsLowerDangerValue.Text = "20"
        Me.emsLowerDangerValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.emsLowerDangerValue.UseSelectable = True
        Me.emsLowerDangerValue.WaterMark = "0~100"
        Me.emsLowerDangerValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.emsLowerDangerValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tabLiverSetting
        '
        Me.tabLiverSetting.Location = New System.Drawing.Point(4, 38)
        Me.tabLiverSetting.Name = "tabLiverSetting"
        Me.tabLiverSetting.Size = New System.Drawing.Size(281, 451)
        Me.tabLiverSetting.TabIndex = 2
        Me.tabLiverSetting.Text = "肝指數"
        '
        'tabPressureSetting
        '
        Me.tabPressureSetting.Location = New System.Drawing.Point(4, 38)
        Me.tabPressureSetting.Name = "tabPressureSetting"
        Me.tabPressureSetting.Size = New System.Drawing.Size(281, 451)
        Me.tabPressureSetting.TabIndex = 3
        Me.tabPressureSetting.Text = "壓力指數"
        '
        'autoSaveTextBox
        '
        '
        '
        '
        Me.autoSaveTextBox.CustomButton.Image = Nothing
        Me.autoSaveTextBox.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.autoSaveTextBox.CustomButton.Name = ""
        Me.autoSaveTextBox.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.autoSaveTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.autoSaveTextBox.CustomButton.TabIndex = 1
        Me.autoSaveTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.autoSaveTextBox.CustomButton.UseSelectable = True
        Me.autoSaveTextBox.CustomButton.Visible = False
        Me.autoSaveTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.autoSaveTextBox.Lines = New String(-1) {}
        Me.autoSaveTextBox.Location = New System.Drawing.Point(37, 61)
        Me.autoSaveTextBox.MaxLength = 32767
        Me.autoSaveTextBox.Name = "autoSaveTextBox"
        Me.autoSaveTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.autoSaveTextBox.PromptText = "請輸入0 ~ 100之間的值"
        Me.autoSaveTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.autoSaveTextBox.SelectedText = ""
        Me.autoSaveTextBox.SelectionLength = 0
        Me.autoSaveTextBox.SelectionStart = 0
        Me.autoSaveTextBox.ShortcutsEnabled = True
        Me.autoSaveTextBox.Size = New System.Drawing.Size(289, 35)
        Me.autoSaveTextBox.TabIndex = 3
        Me.autoSaveTextBox.UseSelectable = True
        Me.autoSaveTextBox.WaterMark = "請輸入0 ~ 100之間的值"
        Me.autoSaveTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.autoSaveTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLink8
        '
        Me.MetroLink8.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink8.Location = New System.Drawing.Point(37, 32)
        Me.MetroLink8.Name = "MetroLink8"
        Me.MetroLink8.Size = New System.Drawing.Size(289, 23)
        Me.MetroLink8.TabIndex = 4
        Me.MetroLink8.Text = "自動記錄觸發值"
        Me.MetroLink8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink8.UseSelectable = True
        '
        'themeSetting
        '
        Me.themeSetting.Controls.Add(Me.mrbDark)
        Me.themeSetting.Controls.Add(Me.mrbLight)
        Me.themeSetting.Controls.Add(Me.MetroLink3)
        Me.themeSetting.Controls.Add(Me.MetroLink2)
        Me.themeSetting.Controls.Add(Me.bgcolor)
        Me.themeSetting.Font = New System.Drawing.Font("PMingLiU", 14.0!)
        Me.themeSetting.HorizontalScrollbarBarColor = True
        Me.themeSetting.HorizontalScrollbarHighlightOnWheel = False
        Me.themeSetting.HorizontalScrollbarSize = 10
        Me.themeSetting.Location = New System.Drawing.Point(4, 44)
        Me.themeSetting.Name = "themeSetting"
        Me.themeSetting.Padding = New System.Windows.Forms.Padding(20, 130, 20, 20)
        Me.themeSetting.Size = New System.Drawing.Size(378, 632)
        Me.themeSetting.TabIndex = 1
        Me.themeSetting.Text = "樣式設定"
        Me.themeSetting.VerticalScrollbarBarColor = True
        Me.themeSetting.VerticalScrollbarHighlightOnWheel = False
        Me.themeSetting.VerticalScrollbarSize = 10
        '
        'mrbDark
        '
        Me.mrbDark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mrbDark.AutoSize = True
        Me.mrbDark.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.mrbDark.Location = New System.Drawing.Point(109, 69)
        Me.mrbDark.Name = "mrbDark"
        Me.mrbDark.Size = New System.Drawing.Size(66, 25)
        Me.mrbDark.TabIndex = 9
        Me.mrbDark.Text = "深色"
        Me.mrbDark.UseSelectable = True
        '
        'mrbLight
        '
        Me.mrbLight.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mrbLight.AutoSize = True
        Me.mrbLight.Checked = True
        Me.mrbLight.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.mrbLight.Location = New System.Drawing.Point(37, 69)
        Me.mrbLight.Name = "mrbLight"
        Me.mrbLight.Size = New System.Drawing.Size(66, 25)
        Me.mrbLight.TabIndex = 8
        Me.mrbLight.TabStop = True
        Me.mrbLight.Text = "亮白"
        Me.mrbLight.UseSelectable = True
        '
        'MetroLink3
        '
        Me.MetroLink3.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink3.Location = New System.Drawing.Point(37, 32)
        Me.MetroLink3.Name = "MetroLink3"
        Me.MetroLink3.Size = New System.Drawing.Size(75, 23)
        Me.MetroLink3.TabIndex = 7
        Me.MetroLink3.Text = "樣式"
        Me.MetroLink3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink3.UseSelectable = True
        '
        'MetroLink2
        '
        Me.MetroLink2.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink2.Location = New System.Drawing.Point(37, 92)
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
        Me.bgcolor.Location = New System.Drawing.Point(20, 130)
        Me.bgcolor.Margin = New System.Windows.Forms.Padding(0)
        Me.bgcolor.Name = "bgcolor"
        Me.bgcolor.Size = New System.Drawing.Size(338, 482)
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
        Me.settingLink.Image = Global.fujunEmsys.My.Resources.Resources.backHover
        Me.settingLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settingLink.ImageSize = 32
        Me.settingLink.Location = New System.Drawing.Point(8, 3)
        Me.settingLink.Name = "settingLink"
        Me.settingLink.NoFocusImage = Global.fujunEmsys.My.Resources.Resources.backUp
        Me.settingLink.Size = New System.Drawing.Size(124, 56)
        Me.settingLink.TabIndex = 4
        Me.settingLink.Text = "設定"
        Me.settingLink.UseSelectable = True
        '
        'MetroLink18
        '
        Me.MetroLink18.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink18.Location = New System.Drawing.Point(37, 102)
        Me.MetroLink18.Name = "MetroLink18"
        Me.MetroLink18.Size = New System.Drawing.Size(289, 23)
        Me.MetroLink18.TabIndex = 4
        Me.MetroLink18.Text = "自動停止感應"
        Me.MetroLink18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink18.UseSelectable = True
        '
        'MetroLink19
        '
        Me.MetroLink19.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink19.Location = New System.Drawing.Point(37, 172)
        Me.MetroLink19.Name = "MetroLink19"
        Me.MetroLink19.Size = New System.Drawing.Size(289, 23)
        Me.MetroLink19.TabIndex = 4
        Me.MetroLink19.Text = "指數指標參數"
        Me.MetroLink19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink19.UseSelectable = True
        '
        'autoStopTextBox
        '
        '
        '
        '
        Me.autoStopTextBox.CustomButton.Image = Nothing
        Me.autoStopTextBox.CustomButton.Location = New System.Drawing.Point(255, 1)
        Me.autoStopTextBox.CustomButton.Name = ""
        Me.autoStopTextBox.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.autoStopTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.autoStopTextBox.CustomButton.TabIndex = 1
        Me.autoStopTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.autoStopTextBox.CustomButton.UseSelectable = True
        Me.autoStopTextBox.CustomButton.Visible = False
        Me.autoStopTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.autoStopTextBox.Lines = New String(-1) {}
        Me.autoStopTextBox.Location = New System.Drawing.Point(37, 131)
        Me.autoStopTextBox.MaxLength = 32767
        Me.autoStopTextBox.Name = "autoStopTextBox"
        Me.autoStopTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.autoStopTextBox.PromptText = "請輸入1以上的值"
        Me.autoStopTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.autoStopTextBox.SelectedText = ""
        Me.autoStopTextBox.SelectionLength = 0
        Me.autoStopTextBox.SelectionStart = 0
        Me.autoStopTextBox.ShortcutsEnabled = True
        Me.autoStopTextBox.Size = New System.Drawing.Size(289, 35)
        Me.autoStopTextBox.TabIndex = 3
        Me.autoStopTextBox.UseSelectable = True
        Me.autoStopTextBox.WaterMark = "請輸入1以上的值"
        Me.autoStopTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.autoStopTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pnlSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.settingMetroPanel)
        Me.Name = "pnlSetting"
        Me.Size = New System.Drawing.Size(400, 800)
        Me.settingMetroPanel.ResumeLayout(False)
        Me.settingTab.ResumeLayout(False)
        Me.serverSetting.ResumeLayout(False)
        Me.emsSetting.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabEnergySetting.ResumeLayout(False)
        Me.engSettingTable.ResumeLayout(False)
        Me.tabGraphSetting.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.themeSetting.ResumeLayout(False)
        Me.themeSetting.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents settingMetroPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents saveSettingsButton As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents settingLink As MetroFramework.Controls.MetroLink
    Friend WithEvents settingTab As MetroFramework.Controls.MetroTabControl
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
    Friend WithEvents emsSetting As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabEnergySetting As TabPage
    Friend WithEvents engSettingTable As TableLayoutPanel
    Friend WithEvents MetroLink10 As MetroFramework.Controls.MetroLink
    Friend WithEvents engLowerDanger As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents engUpperDanger As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents engLowerWarning As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents engUpperWarning As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroLink16 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink12 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink14 As MetroFramework.Controls.MetroLink
    Friend WithEvents engUpperDangerValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents engUpperWarningValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents engLowerWarningValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents engLowerDangerValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tabGraphSetting As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MetroLink11 As MetroFramework.Controls.MetroLink
    Friend WithEvents emsLowerDanger As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents emsUpperDanger As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents emsLowerWarning As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents emsUpperWarning As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroLink13 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink15 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink17 As MetroFramework.Controls.MetroLink
    Friend WithEvents emsUpperDangerValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents emsUpperWarningValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents emsLowerWarningValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents emsLowerDangerValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tabLiverSetting As TabPage
    Friend WithEvents tabPressureSetting As TabPage
    Friend WithEvents autoSaveTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLink8 As MetroFramework.Controls.MetroLink
    Friend WithEvents themeSetting As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mrbDark As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mrbLight As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLink3 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents bgcolor As FlowLayoutPanel
    Friend WithEvents autoStopTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLink19 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLink18 As MetroFramework.Controls.MetroLink
End Class
