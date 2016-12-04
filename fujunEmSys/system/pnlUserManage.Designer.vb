<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlUserManage
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.userManageTable = New System.Windows.Forms.TableLayoutPanel()
        Me.userDataGrid = New System.Windows.Forms.DataGridView()
        Me.addUserButton = New MetroFramework.Controls.MetroButton()
        Me.editUserButton = New MetroFramework.Controls.MetroButton()
        Me.delUserButton = New MetroFramework.Controls.MetroButton()
        Me.controlPanel = New System.Windows.Forms.Panel()
        Me.cancelLink = New MetroFramework.Controls.MetroLink()
        Me.okLink = New MetroFramework.Controls.MetroLink()
        Me.userLabel = New MetroFramework.Controls.MetroLabel()
        Me.checkPass = New MetroFramework.Controls.MetroTextBox()
        Me.userPass = New MetroFramework.Controls.MetroTextBox()
        Me.userName = New MetroFramework.Controls.MetroTextBox()
        Me.userID = New MetroFramework.Controls.MetroTextBox()
        Me.userManageTable.SuspendLayout()
        CType(Me.userDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.controlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.ClientSize = New System.Drawing.Size(0, 0)
        Me.owner.Location = New System.Drawing.Point(-32000, -32000)
        Me.owner.WindowState = System.Windows.Forms.FormWindowState.Minimized
        '
        'userManageTable
        '
        Me.userManageTable.ColumnCount = 3
        Me.userManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.userManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.userManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.userManageTable.Controls.Add(Me.userDataGrid, 0, 0)
        Me.userManageTable.Controls.Add(Me.addUserButton, 0, 2)
        Me.userManageTable.Controls.Add(Me.editUserButton, 1, 2)
        Me.userManageTable.Controls.Add(Me.delUserButton, 2, 2)
        Me.userManageTable.Controls.Add(Me.controlPanel, 0, 1)
        Me.userManageTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userManageTable.Location = New System.Drawing.Point(0, 0)
        Me.userManageTable.Name = "userManageTable"
        Me.userManageTable.RowCount = 3
        Me.userManageTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.userManageTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.userManageTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.userManageTable.Size = New System.Drawing.Size(779, 598)
        Me.userManageTable.TabIndex = 1
        '
        'userDataGrid
        '
        Me.userDataGrid.AllowUserToAddRows = False
        Me.userDataGrid.AllowUserToDeleteRows = False
        Me.userDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.userDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userManageTable.SetColumnSpan(Me.userDataGrid, 3)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.userDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.userDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.userDataGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.userDataGrid.MultiSelect = False
        Me.userDataGrid.Name = "userDataGrid"
        Me.userDataGrid.RowTemplate.Height = 24
        Me.userDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.userDataGrid.Size = New System.Drawing.Size(779, 418)
        Me.userDataGrid.TabIndex = 0
        '
        'addUserButton
        '
        Me.addUserButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addUserButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.addUserButton.Location = New System.Drawing.Point(3, 521)
        Me.addUserButton.Name = "addUserButton"
        Me.addUserButton.Size = New System.Drawing.Size(253, 74)
        Me.addUserButton.TabIndex = 1
        Me.addUserButton.Text = "新增使用者"
        Me.addUserButton.UseSelectable = True
        '
        'editUserButton
        '
        Me.editUserButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editUserButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.editUserButton.Location = New System.Drawing.Point(262, 521)
        Me.editUserButton.Name = "editUserButton"
        Me.editUserButton.Size = New System.Drawing.Size(253, 74)
        Me.editUserButton.TabIndex = 1
        Me.editUserButton.Text = "修改使用者"
        Me.editUserButton.UseSelectable = True
        '
        'delUserButton
        '
        Me.delUserButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.delUserButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.delUserButton.Location = New System.Drawing.Point(521, 521)
        Me.delUserButton.Name = "delUserButton"
        Me.delUserButton.Size = New System.Drawing.Size(255, 74)
        Me.delUserButton.TabIndex = 1
        Me.delUserButton.Text = "刪除使用者"
        Me.delUserButton.UseSelectable = True
        '
        'controlPanel
        '
        Me.controlPanel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.userManageTable.SetColumnSpan(Me.controlPanel, 3)
        Me.controlPanel.Controls.Add(Me.cancelLink)
        Me.controlPanel.Controls.Add(Me.okLink)
        Me.controlPanel.Controls.Add(Me.userLabel)
        Me.controlPanel.Controls.Add(Me.checkPass)
        Me.controlPanel.Controls.Add(Me.userPass)
        Me.controlPanel.Controls.Add(Me.userName)
        Me.controlPanel.Controls.Add(Me.userID)
        Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.controlPanel.Location = New System.Drawing.Point(0, 418)
        Me.controlPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.controlPanel.Size = New System.Drawing.Size(779, 100)
        Me.controlPanel.TabIndex = 2
        '
        'cancelLink
        '
        Me.cancelLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelLink.Image = Global.emSys2016.My.Resources.Resources.shutdownHover
        Me.cancelLink.ImageSize = 25
        Me.cancelLink.Location = New System.Drawing.Point(687, 48)
        Me.cancelLink.Name = "cancelLink"
        Me.cancelLink.NoFocusImage = Global.emSys2016.My.Resources.Resources.shutdownUp
        Me.cancelLink.Size = New System.Drawing.Size(33, 33)
        Me.cancelLink.TabIndex = 3
        Me.cancelLink.UseSelectable = True
        '
        'okLink
        '
        Me.okLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okLink.Image = Global.emSys2016.My.Resources.Resources.okHover
        Me.okLink.ImageSize = 25
        Me.okLink.Location = New System.Drawing.Point(726, 48)
        Me.okLink.Name = "okLink"
        Me.okLink.NoFocusImage = Global.emSys2016.My.Resources.Resources.okUp
        Me.okLink.Size = New System.Drawing.Size(33, 33)
        Me.okLink.TabIndex = 2
        Me.okLink.UseSelectable = True
        '
        'userLabel
        '
        Me.userLabel.AutoSize = True
        Me.userLabel.BackColor = System.Drawing.Color.Transparent
        Me.userLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.userLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.userLabel.Location = New System.Drawing.Point(23, 20)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(112, 25)
        Me.userLabel.TabIndex = 1
        Me.userLabel.Text = "新增使用者"
        '
        'checkPass
        '
        '
        '
        '
        Me.checkPass.CustomButton.Image = Nothing
        Me.checkPass.CustomButton.Location = New System.Drawing.Point(113, 1)
        Me.checkPass.CustomButton.Name = ""
        Me.checkPass.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.checkPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.checkPass.CustomButton.TabIndex = 1
        Me.checkPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.checkPass.CustomButton.UseSelectable = True
        Me.checkPass.CustomButton.Visible = False
        Me.checkPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.checkPass.Lines = New String(-1) {}
        Me.checkPass.Location = New System.Drawing.Point(476, 48)
        Me.checkPass.MaxLength = 32767
        Me.checkPass.Name = "checkPass"
        Me.checkPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.checkPass.PromptText = "確認密碼"
        Me.checkPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.checkPass.SelectedText = ""
        Me.checkPass.SelectionLength = 0
        Me.checkPass.SelectionStart = 0
        Me.checkPass.ShortcutsEnabled = True
        Me.checkPass.Size = New System.Drawing.Size(145, 33)
        Me.checkPass.TabIndex = 0
        Me.checkPass.UseSelectable = True
        Me.checkPass.WaterMark = "確認密碼"
        Me.checkPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.checkPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'userPass
        '
        '
        '
        '
        Me.userPass.CustomButton.Image = Nothing
        Me.userPass.CustomButton.Location = New System.Drawing.Point(113, 1)
        Me.userPass.CustomButton.Name = ""
        Me.userPass.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.userPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.userPass.CustomButton.TabIndex = 1
        Me.userPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.userPass.CustomButton.UseSelectable = True
        Me.userPass.CustomButton.Visible = False
        Me.userPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.userPass.Lines = New String(-1) {}
        Me.userPass.Location = New System.Drawing.Point(325, 48)
        Me.userPass.MaxLength = 32767
        Me.userPass.Name = "userPass"
        Me.userPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userPass.PromptText = "密碼"
        Me.userPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.userPass.SelectedText = ""
        Me.userPass.SelectionLength = 0
        Me.userPass.SelectionStart = 0
        Me.userPass.ShortcutsEnabled = True
        Me.userPass.Size = New System.Drawing.Size(145, 33)
        Me.userPass.TabIndex = 0
        Me.userPass.UseSelectable = True
        Me.userPass.WaterMark = "密碼"
        Me.userPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.userPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'userName
        '
        '
        '
        '
        Me.userName.CustomButton.Image = Nothing
        Me.userName.CustomButton.Location = New System.Drawing.Point(113, 1)
        Me.userName.CustomButton.Name = ""
        Me.userName.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.userName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.userName.CustomButton.TabIndex = 1
        Me.userName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.userName.CustomButton.UseSelectable = True
        Me.userName.CustomButton.Visible = False
        Me.userName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.userName.Lines = New String(-1) {}
        Me.userName.Location = New System.Drawing.Point(174, 48)
        Me.userName.MaxLength = 32767
        Me.userName.Name = "userName"
        Me.userName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userName.PromptText = "使用者姓名"
        Me.userName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.userName.SelectedText = ""
        Me.userName.SelectionLength = 0
        Me.userName.SelectionStart = 0
        Me.userName.ShortcutsEnabled = True
        Me.userName.Size = New System.Drawing.Size(145, 33)
        Me.userName.TabIndex = 0
        Me.userName.UseSelectable = True
        Me.userName.WaterMark = "使用者姓名"
        Me.userName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.userName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'userID
        '
        '
        '
        '
        Me.userID.CustomButton.Image = Nothing
        Me.userID.CustomButton.Location = New System.Drawing.Point(113, 1)
        Me.userID.CustomButton.Name = ""
        Me.userID.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.userID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.userID.CustomButton.TabIndex = 1
        Me.userID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.userID.CustomButton.UseSelectable = True
        Me.userID.CustomButton.Visible = False
        Me.userID.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.userID.Lines = New String(-1) {}
        Me.userID.Location = New System.Drawing.Point(23, 48)
        Me.userID.MaxLength = 32767
        Me.userID.Name = "userID"
        Me.userID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userID.PromptText = "使用者名稱"
        Me.userID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.userID.SelectedText = ""
        Me.userID.SelectionLength = 0
        Me.userID.SelectionStart = 0
        Me.userID.ShortcutsEnabled = True
        Me.userID.Size = New System.Drawing.Size(145, 33)
        Me.userID.TabIndex = 0
        Me.userID.UseSelectable = True
        Me.userID.WaterMark = "使用者名稱"
        Me.userID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.userID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pnlUserManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.userManageTable)
        Me.Name = "pnlUserManage"
        Me.Size = New System.Drawing.Size(779, 598)
        Me.userManageTable.ResumeLayout(False)
        CType(Me.userDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.controlPanel.ResumeLayout(False)
        Me.controlPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents userManageTable As TableLayoutPanel
    Friend WithEvents userDataGrid As DataGridView
    Friend WithEvents addUserButton As MetroFramework.Controls.MetroButton
    Friend WithEvents editUserButton As MetroFramework.Controls.MetroButton
    Friend WithEvents delUserButton As MetroFramework.Controls.MetroButton
    Friend WithEvents controlPanel As Panel
    Friend WithEvents checkPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents userPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents userName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents userID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents userLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents okLink As MetroFramework.Controls.MetroLink
    Friend WithEvents cancelLink As MetroFramework.Controls.MetroLink
End Class
