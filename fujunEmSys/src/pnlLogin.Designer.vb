<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pnlLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlLogin))
        Me.noConnectionLabel = New MetroFramework.Controls.MetroLink()
        Me.loginPanel = New MetroFramework.Controls.MetroPanel()
        Me.logoBox = New System.Windows.Forms.PictureBox()
        Me.loginButton = New MetroFramework.Controls.MetroButton()
        Me.usernameTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.passwordTextbox = New MetroFramework.Controls.MetroTextBox()
        Me.loginPanel.SuspendLayout()
        CType(Me.logoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.Location = New System.Drawing.Point(78, 78)
        '
        'noConnectionLabel
        '
        Me.noConnectionLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.noConnectionLabel.BackColor = System.Drawing.Color.Transparent
        Me.noConnectionLabel.Location = New System.Drawing.Point(369, 494)
        Me.noConnectionLabel.Name = "noConnectionLabel"
        Me.noConnectionLabel.Size = New System.Drawing.Size(462, 23)
        Me.noConnectionLabel.TabIndex = 1
        Me.noConnectionLabel.Text = "無法連線至伺服器，請檢查連線後點此重試"
        Me.noConnectionLabel.UseSelectable = True
        '
        'loginPanel
        '
        Me.loginPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loginPanel.Controls.Add(Me.logoBox)
        Me.loginPanel.Controls.Add(Me.loginButton)
        Me.loginPanel.Controls.Add(Me.usernameTextbox)
        Me.loginPanel.Controls.Add(Me.passwordTextbox)
        Me.loginPanel.HorizontalScrollbarBarColor = True
        Me.loginPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.loginPanel.HorizontalScrollbarSize = 10
        Me.loginPanel.Location = New System.Drawing.Point(3, 48)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Padding = New System.Windows.Forms.Padding(20)
        Me.loginPanel.Size = New System.Drawing.Size(1194, 440)
        Me.loginPanel.TabIndex = 0
        Me.loginPanel.VerticalScrollbarBarColor = True
        Me.loginPanel.VerticalScrollbarHighlightOnWheel = False
        Me.loginPanel.VerticalScrollbarSize = 10
        '
        'logoBox
        '
        Me.logoBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logoBox.BackColor = System.Drawing.Color.White
        Me.logoBox.Image = CType(resources.GetObject("logoBox.Image"), System.Drawing.Image)
        Me.logoBox.Location = New System.Drawing.Point(497, 23)
        Me.logoBox.Name = "logoBox"
        Me.logoBox.Size = New System.Drawing.Size(200, 200)
        Me.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoBox.TabIndex = 4
        Me.logoBox.TabStop = False
        '
        'loginButton
        '
        Me.loginButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loginButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.loginButton.Location = New System.Drawing.Point(93, 377)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(1009, 40)
        Me.loginButton.TabIndex = 3
        Me.loginButton.Text = "登入"
        Me.loginButton.UseSelectable = True
        '
        'usernameTextbox
        '
        Me.usernameTextbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.usernameTextbox.CustomButton.Image = Nothing
        Me.usernameTextbox.CustomButton.Location = New System.Drawing.Point(971, 2)
        Me.usernameTextbox.CustomButton.Name = ""
        Me.usernameTextbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.usernameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.usernameTextbox.CustomButton.TabIndex = 1
        Me.usernameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.usernameTextbox.CustomButton.UseSelectable = True
        Me.usernameTextbox.CustomButton.Visible = False
        Me.usernameTextbox.DisplayIcon = True
        Me.usernameTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.usernameTextbox.Icon = CType(resources.GetObject("usernameTextbox.Icon"), System.Drawing.Image)
        Me.usernameTextbox.Lines = New String(-1) {}
        Me.usernameTextbox.Location = New System.Drawing.Point(93, 261)
        Me.usernameTextbox.Margin = New System.Windows.Forms.Padding(20)
        Me.usernameTextbox.MaxLength = 32767
        Me.usernameTextbox.Name = "usernameTextbox"
        Me.usernameTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameTextbox.PromptText = "使用者名稱"
        Me.usernameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.usernameTextbox.SelectedText = ""
        Me.usernameTextbox.SelectionLength = 0
        Me.usernameTextbox.SelectionStart = 0
        Me.usernameTextbox.ShortcutsEnabled = True
        Me.usernameTextbox.ShowClearButton = True
        Me.usernameTextbox.Size = New System.Drawing.Size(1009, 40)
        Me.usernameTextbox.TabIndex = 1
        Me.usernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.usernameTextbox.UseSelectable = True
        Me.usernameTextbox.WaterMark = "使用者名稱"
        Me.usernameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.usernameTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'passwordTextbox
        '
        Me.passwordTextbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.passwordTextbox.CustomButton.Image = Nothing
        Me.passwordTextbox.CustomButton.Location = New System.Drawing.Point(971, 2)
        Me.passwordTextbox.CustomButton.Name = ""
        Me.passwordTextbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.passwordTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.passwordTextbox.CustomButton.TabIndex = 1
        Me.passwordTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.passwordTextbox.CustomButton.UseSelectable = True
        Me.passwordTextbox.CustomButton.Visible = False
        Me.passwordTextbox.DisplayIcon = True
        Me.passwordTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.passwordTextbox.Icon = Global.fujunEmsys.My.Resources.Resources.pass
        Me.passwordTextbox.Lines = New String(-1) {}
        Me.passwordTextbox.Location = New System.Drawing.Point(93, 310)
        Me.passwordTextbox.MaxLength = 32767
        Me.passwordTextbox.Name = "passwordTextbox"
        Me.passwordTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextbox.PromptText = "使用者密碼"
        Me.passwordTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.passwordTextbox.SelectedText = ""
        Me.passwordTextbox.SelectionLength = 0
        Me.passwordTextbox.SelectionStart = 0
        Me.passwordTextbox.ShortcutsEnabled = True
        Me.passwordTextbox.ShowClearButton = True
        Me.passwordTextbox.Size = New System.Drawing.Size(1009, 40)
        Me.passwordTextbox.TabIndex = 2
        Me.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.passwordTextbox.UseSelectable = True
        Me.passwordTextbox.WaterMark = "使用者密碼"
        Me.passwordTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.passwordTextbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pnlLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.noConnectionLabel)
        Me.Controls.Add(Me.loginPanel)
        Me.Name = "pnlLogin"
        Me.Size = New System.Drawing.Size(1200, 537)
        Me.loginPanel.ResumeLayout(False)
        CType(Me.logoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents loginButton As MetroFramework.Controls.MetroButton
    Friend WithEvents usernameTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents passwordTextbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents logoBox As PictureBox
    Friend WithEvents noConnectionLabel As MetroFramework.Controls.MetroLink
End Class
