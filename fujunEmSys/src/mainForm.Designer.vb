﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.emsLink = New MetroFramework.Controls.MetroLink()
        Me.loginButton = New MetroFramework.Controls.MetroLink()
        Me.userManageLink = New MetroFramework.Controls.MetroLink()
        Me.testButton = New MetroFramework.Controls.MetroButton()
        Me.paitientInfoLink = New MetroFramework.Controls.MetroLink()
        Me.medManageLink = New MetroFramework.Controls.MetroLink()
        Me.medInfoLink = New MetroFramework.Controls.MetroLink()
        Me.exitLink = New MetroFramework.Controls.MetroLink()
        Me.settingsLink = New MetroFramework.Controls.MetroLink()
        Me.patientBookingLink = New MetroFramework.Controls.MetroLink()
        Me.docManageLink = New MetroFramework.Controls.MetroLink()
        Me.perscriptionLink = New MetroFramework.Controls.MetroLink()
        Me.reportLink = New MetroFramework.Controls.MetroLink()
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
        'emsLink
        '
        Me.emsLink.Location = New System.Drawing.Point(3, 78)
        Me.emsLink.Name = "emsLink"
        Me.emsLink.Size = New System.Drawing.Size(86, 28)
        Me.emsLink.TabIndex = 2
        Me.emsLink.Text = "頻譜系統"
        Me.emsLink.UseSelectable = True
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
        'testButton
        '
        Me.testButton.Location = New System.Drawing.Point(3, 674)
        Me.testButton.Name = "testButton"
        Me.testButton.Size = New System.Drawing.Size(75, 23)
        Me.testButton.TabIndex = 3
        Me.testButton.Text = "Test Button"
        Me.testButton.UseSelectable = True
        '
        'paitientInfoLink
        '
        Me.paitientInfoLink.Location = New System.Drawing.Point(1086, 180)
        Me.paitientInfoLink.Name = "paitientInfoLink"
        Me.paitientInfoLink.Size = New System.Drawing.Size(86, 28)
        Me.paitientInfoLink.TabIndex = 2
        Me.paitientInfoLink.Text = "病人管理"
        Me.paitientInfoLink.UseSelectable = True
        '
        'medManageLink
        '
        Me.medManageLink.Location = New System.Drawing.Point(1086, 214)
        Me.medManageLink.Name = "medManageLink"
        Me.medManageLink.Size = New System.Drawing.Size(86, 28)
        Me.medManageLink.TabIndex = 2
        Me.medManageLink.Text = "藥品分類管理"
        Me.medManageLink.UseSelectable = True
        '
        'medInfoLink
        '
        Me.medInfoLink.Location = New System.Drawing.Point(1086, 248)
        Me.medInfoLink.Name = "medInfoLink"
        Me.medInfoLink.Size = New System.Drawing.Size(86, 28)
        Me.medInfoLink.TabIndex = 2
        Me.medInfoLink.Text = "藥品管理"
        Me.medInfoLink.UseSelectable = True
        '
        'exitLink
        '
        Me.exitLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitLink.Image = Global.fujunEmsys.My.Resources.Resources.shutdownHover
        Me.exitLink.ImageSize = 40
        Me.exitLink.Location = New System.Drawing.Point(1122, 22)
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
        Me.settingsLink.Location = New System.Drawing.Point(1066, 22)
        Me.settingsLink.Name = "settingsLink"
        Me.settingsLink.NoFocusImage = Global.fujunEmsys.My.Resources.Resources.settingUp
        Me.settingsLink.Size = New System.Drawing.Size(50, 50)
        Me.settingsLink.TabIndex = 0
        Me.settingsLink.UseSelectable = True
        '
        'patientBookingLink
        '
        Me.patientBookingLink.Location = New System.Drawing.Point(1086, 282)
        Me.patientBookingLink.Name = "patientBookingLink"
        Me.patientBookingLink.Size = New System.Drawing.Size(86, 28)
        Me.patientBookingLink.TabIndex = 2
        Me.patientBookingLink.Text = "掛號系統"
        Me.patientBookingLink.UseSelectable = True
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
        'perscriptionLink
        '
        Me.perscriptionLink.Location = New System.Drawing.Point(3, 112)
        Me.perscriptionLink.Name = "perscriptionLink"
        Me.perscriptionLink.Size = New System.Drawing.Size(86, 28)
        Me.perscriptionLink.TabIndex = 2
        Me.perscriptionLink.Text = "開藥系統"
        Me.perscriptionLink.UseSelectable = True
        '
        'reportLink
        '
        Me.reportLink.Location = New System.Drawing.Point(3, 146)
        Me.reportLink.Name = "reportLink"
        Me.reportLink.Size = New System.Drawing.Size(86, 28)
        Me.reportLink.TabIndex = 2
        Me.reportLink.Text = "報表系統"
        Me.reportLink.UseSelectable = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackMaxSize = 4096
        Me.ClientSize = New System.Drawing.Size(1175, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.testButton)
        Me.Controls.Add(Me.patientBookingLink)
        Me.Controls.Add(Me.medInfoLink)
        Me.Controls.Add(Me.medManageLink)
        Me.Controls.Add(Me.paitientInfoLink)
        Me.Controls.Add(Me.docManageLink)
        Me.Controls.Add(Me.userManageLink)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.reportLink)
        Me.Controls.Add(Me.perscriptionLink)
        Me.Controls.Add(Me.emsLink)
        Me.Controls.Add(Me.exitLink)
        Me.Controls.Add(Me.settingsLink)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.Padding = New System.Windows.Forms.Padding(0, 70, 0, 0)
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
    Friend WithEvents emsLink As MetroFramework.Controls.MetroLink
    Friend WithEvents loginButton As MetroFramework.Controls.MetroLink
    Friend WithEvents userManageLink As MetroFramework.Controls.MetroLink
    Friend WithEvents testButton As MetroFramework.Controls.MetroButton
    Friend WithEvents paitientInfoLink As MetroFramework.Controls.MetroLink
    Friend WithEvents medInfoLink As MetroFramework.Controls.MetroLink
    Friend WithEvents medManageLink As MetroFramework.Controls.MetroLink
    Friend WithEvents patientBookingLink As MetroFramework.Controls.MetroLink
    Friend WithEvents docManageLink As MetroFramework.Controls.MetroLink
    Friend WithEvents perscriptionLink As MetroFramework.Controls.MetroLink
    Friend WithEvents reportLink As MetroFramework.Controls.MetroLink
End Class