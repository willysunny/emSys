<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.sysStyleManager = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.病人資料查詢QToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.醫師資料維護DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.藥品資料維護MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.loginMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.menuOfflineMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.loginButton = New MetroFramework.Controls.MetroLink()
        Me.userManageLink = New MetroFramework.Controls.MetroLink()
        Me.docManageLink = New MetroFramework.Controls.MetroLink()
        Me.paymentTile = New MetroFramework.Controls.MetroTile()
        Me.reportTile = New MetroFramework.Controls.MetroTile()
        Me.medManageTile = New MetroFramework.Controls.MetroTile()
        Me.medInfoTile = New MetroFramework.Controls.MetroTile()
        Me.perscriptionTile = New MetroFramework.Controls.MetroTile()
        Me.paitientInfoTile = New MetroFramework.Controls.MetroTile()
        Me.bookingTile = New MetroFramework.Controls.MetroTile()
        Me.emsTile = New MetroFramework.Controls.MetroTile()
        Me.exitLink = New MetroFramework.Controls.MetroLink()
        Me.settingsLink = New MetroFramework.Controls.MetroLink()
        CType(Me.sysStyleManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.loginMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'sysStyleManager
        '
        Me.sysStyleManager.Owner = Me
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.病人資料查詢QToolStripMenuItem, Me.醫師資料維護DToolStripMenuItem, Me.藥品資料維護MToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(170, 70)
        '
        '病人資料查詢QToolStripMenuItem
        '
        Me.病人資料查詢QToolStripMenuItem.Name = "病人資料查詢QToolStripMenuItem"
        Me.病人資料查詢QToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.病人資料查詢QToolStripMenuItem.Text = "病人資料維護 (&Q)"
        '
        '醫師資料維護DToolStripMenuItem
        '
        Me.醫師資料維護DToolStripMenuItem.Name = "醫師資料維護DToolStripMenuItem"
        Me.醫師資料維護DToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.醫師資料維護DToolStripMenuItem.Text = "醫師資料維護 (&D)"
        '
        '藥品資料維護MToolStripMenuItem
        '
        Me.藥品資料維護MToolStripMenuItem.Name = "藥品資料維護MToolStripMenuItem"
        Me.藥品資料維護MToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.藥品資料維護MToolStripMenuItem.Text = "藥品資料維護 (&M)"
        '
        'loginMenu
        '
        Me.loginMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuOfflineMode, Me.aboutMenu, Me.ToolStripMenuItem1, Me.exitMenu})
        Me.loginMenu.Name = "MetroContextMenu1"
        Me.loginMenu.Size = New System.Drawing.Size(144, 76)
        '
        'menuOfflineMode
        '
        Me.menuOfflineMode.CheckOnClick = True
        Me.menuOfflineMode.Name = "menuOfflineMode"
        Me.menuOfflineMode.Size = New System.Drawing.Size(143, 22)
        Me.menuOfflineMode.Text = "離線模式 (&O)"
        '
        'aboutMenu
        '
        Me.aboutMenu.Name = "aboutMenu"
        Me.aboutMenu.Size = New System.Drawing.Size(143, 22)
        Me.aboutMenu.Text = "關於 (&A)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(140, 6)
        '
        'exitMenu
        '
        Me.exitMenu.Name = "exitMenu"
        Me.exitMenu.Size = New System.Drawing.Size(143, 22)
        Me.exitMenu.Text = "離開 (&X)"
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(1086, 78)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(86, 28)
        Me.loginButton.TabIndex = 2
        Me.loginButton.Text = "登入"
        Me.loginButton.UseSelectable = True
        '
        'userManageLink
        '
        Me.userManageLink.Location = New System.Drawing.Point(1086, 112)
        Me.userManageLink.Name = "userManageLink"
        Me.userManageLink.Size = New System.Drawing.Size(86, 28)
        Me.userManageLink.TabIndex = 2
        Me.userManageLink.Text = "使用者管理"
        Me.userManageLink.UseSelectable = True
        '
        'docManageLink
        '
        Me.docManageLink.Location = New System.Drawing.Point(1086, 146)
        Me.docManageLink.Name = "docManageLink"
        Me.docManageLink.Size = New System.Drawing.Size(86, 28)
        Me.docManageLink.TabIndex = 2
        Me.docManageLink.Text = "醫師管理"
        Me.docManageLink.UseSelectable = True
        '
        'paymentTile
        '
        Me.paymentTile.ActiveControl = Nothing
        Me.paymentTile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.paymentTile.Location = New System.Drawing.Point(653, 466)
        Me.paymentTile.Name = "paymentTile"
        Me.paymentTile.Size = New System.Drawing.Size(120, 120)
        Me.paymentTile.TabIndex = 4
        Me.paymentTile.Text = "批價系統"
        Me.paymentTile.TileImage = Global.fujunEmsys.My.Resources.Resources.paymentSys
        Me.paymentTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.paymentTile.UseSelectable = True
        Me.paymentTile.UseTileImage = True
        '
        'reportTile
        '
        Me.reportTile.ActiveControl = Nothing
        Me.reportTile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.reportTile.Location = New System.Drawing.Point(653, 340)
        Me.reportTile.Name = "reportTile"
        Me.reportTile.Size = New System.Drawing.Size(120, 120)
        Me.reportTile.TabIndex = 4
        Me.reportTile.Text = "檢驗報告"
        Me.reportTile.TileImage = Global.fujunEmsys.My.Resources.Resources.reportSys
        Me.reportTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.reportTile.UseSelectable = True
        Me.reportTile.UseTileImage = True
        '
        'medManageTile
        '
        Me.medManageTile.ActiveControl = Nothing
        Me.medManageTile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.medManageTile.Location = New System.Drawing.Point(527, 466)
        Me.medManageTile.Name = "medManageTile"
        Me.medManageTile.Size = New System.Drawing.Size(120, 120)
        Me.medManageTile.TabIndex = 4
        Me.medManageTile.Text = "藥品分類管理"
        Me.medManageTile.TileImage = Global.fujunEmsys.My.Resources.Resources.medSys
        Me.medManageTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.medManageTile.UseSelectable = True
        Me.medManageTile.UseTileImage = True
        '
        'medInfoTile
        '
        Me.medInfoTile.ActiveControl = Nothing
        Me.medInfoTile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.medInfoTile.Location = New System.Drawing.Point(401, 466)
        Me.medInfoTile.Name = "medInfoTile"
        Me.medInfoTile.Size = New System.Drawing.Size(120, 120)
        Me.medInfoTile.TabIndex = 4
        Me.medInfoTile.Text = "藥品管理"
        Me.medInfoTile.TileImage = Global.fujunEmsys.My.Resources.Resources.medInfoSys
        Me.medInfoTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.medInfoTile.UseSelectable = True
        Me.medInfoTile.UseTileImage = True
        '
        'perscriptionTile
        '
        Me.perscriptionTile.ActiveControl = Nothing
        Me.perscriptionTile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.perscriptionTile.Location = New System.Drawing.Point(527, 340)
        Me.perscriptionTile.Name = "perscriptionTile"
        Me.perscriptionTile.Size = New System.Drawing.Size(120, 120)
        Me.perscriptionTile.TabIndex = 4
        Me.perscriptionTile.Text = "處方籤"
        Me.perscriptionTile.TileImage = Global.fujunEmsys.My.Resources.Resources.perscriptionSys
        Me.perscriptionTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.perscriptionTile.UseSelectable = True
        Me.perscriptionTile.UseTileImage = True
        '
        'paitientInfoTile
        '
        Me.paitientInfoTile.ActiveControl = Nothing
        Me.paitientInfoTile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.paitientInfoTile.Location = New System.Drawing.Point(527, 214)
        Me.paitientInfoTile.Name = "paitientInfoTile"
        Me.paitientInfoTile.Size = New System.Drawing.Size(120, 120)
        Me.paitientInfoTile.TabIndex = 4
        Me.paitientInfoTile.Text = "病人資料維護"
        Me.paitientInfoTile.TileImage = Global.fujunEmsys.My.Resources.Resources.patientSys
        Me.paitientInfoTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.paitientInfoTile.UseSelectable = True
        Me.paitientInfoTile.UseTileImage = True
        '
        'bookingTile
        '
        Me.bookingTile.ActiveControl = Nothing
        Me.bookingTile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bookingTile.Location = New System.Drawing.Point(401, 214)
        Me.bookingTile.Name = "bookingTile"
        Me.bookingTile.Size = New System.Drawing.Size(120, 120)
        Me.bookingTile.TabIndex = 4
        Me.bookingTile.Text = "掛號預約系統"
        Me.bookingTile.TileImage = Global.fujunEmsys.My.Resources.Resources.bookingSys
        Me.bookingTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bookingTile.UseSelectable = True
        Me.bookingTile.UseTileImage = True
        '
        'emsTile
        '
        Me.emsTile.ActiveControl = Nothing
        Me.emsTile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.emsTile.Location = New System.Drawing.Point(401, 340)
        Me.emsTile.Name = "emsTile"
        Me.emsTile.Size = New System.Drawing.Size(120, 120)
        Me.emsTile.TabIndex = 4
        Me.emsTile.Text = "能量頻譜"
        Me.emsTile.TileImage = Global.fujunEmsys.My.Resources.Resources.emSys
        Me.emsTile.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.emsTile.UseSelectable = True
        Me.emsTile.UseTileImage = True
        '
        'exitLink
        '
        Me.exitLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitLink.Image = Global.fujunEmsys.My.Resources.Resources.shutdownHover
        Me.exitLink.ImageSize = 40
        Me.exitLink.Location = New System.Drawing.Point(1102, 22)
        Me.exitLink.Name = "exitLink"
        Me.exitLink.NoFocusImage = Global.fujunEmsys.My.Resources.Resources.shutdownUp
        Me.exitLink.Size = New System.Drawing.Size(50, 50)
        Me.exitLink.TabIndex = 0
        Me.exitLink.UseSelectable = True
        '
        'settingsLink
        '
        Me.settingsLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsLink.Image = Global.fujunEmsys.My.Resources.Resources.settingHover
        Me.settingsLink.ImageSize = 40
        Me.settingsLink.Location = New System.Drawing.Point(1046, 22)
        Me.settingsLink.Name = "settingsLink"
        Me.settingsLink.NoFocusImage = Global.fujunEmsys.My.Resources.Resources.settingUp
        Me.settingsLink.Size = New System.Drawing.Size(50, 50)
        Me.settingsLink.TabIndex = 0
        Me.settingsLink.UseSelectable = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackMaxSize = 4096
        Me.ClientSize = New System.Drawing.Size(1175, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.reportTile)
        Me.Controls.Add(Me.medManageTile)
        Me.Controls.Add(Me.paymentTile)
        Me.Controls.Add(Me.medInfoTile)
        Me.Controls.Add(Me.perscriptionTile)
        Me.Controls.Add(Me.paitientInfoTile)
        Me.Controls.Add(Me.bookingTile)
        Me.Controls.Add(Me.emsTile)
        Me.Controls.Add(Me.docManageLink)
        Me.Controls.Add(Me.userManageLink)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.exitLink)
        Me.Controls.Add(Me.settingsLink)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 800)
        Me.Name = "mainForm"
        Me.Padding = New System.Windows.Forms.Padding(20, 70, 20, 20)
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "福濬生物醫學系統"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.sysStyleManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.loginMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents settingsLink As MetroFramework.Controls.MetroLink
    Friend WithEvents exitLink As MetroFramework.Controls.MetroLink
    Friend WithEvents sysStyleManager As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents 病人資料查詢QToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 醫師資料維護DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 藥品資料維護MToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents loginMenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents menuOfflineMode As ToolStripMenuItem
    Friend WithEvents aboutMenu As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents exitMenu As ToolStripMenuItem
    Friend WithEvents loginButton As MetroFramework.Controls.MetroLink
    Friend WithEvents userManageLink As MetroFramework.Controls.MetroLink
    Friend WithEvents docManageLink As MetroFramework.Controls.MetroLink
    Friend WithEvents emsTile As MetroFramework.Controls.MetroTile
    Friend WithEvents perscriptionTile As MetroFramework.Controls.MetroTile
    Friend WithEvents reportTile As MetroFramework.Controls.MetroTile
    Friend WithEvents paitientInfoTile As MetroFramework.Controls.MetroTile
    Friend WithEvents bookingTile As MetroFramework.Controls.MetroTile
    Friend WithEvents medManageTile As MetroFramework.Controls.MetroTile
    Friend WithEvents medInfoTile As MetroFramework.Controls.MetroTile
    Friend WithEvents paymentTile As MetroFramework.Controls.MetroTile
End Class
