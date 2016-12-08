<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManage
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.userLabel = New MetroFramework.Controls.MetroLabel()
        Me.checkPass = New MetroFramework.Controls.MetroTextBox()
        Me.userPass = New MetroFramework.Controls.MetroTextBox()
        Me.userName = New MetroFramework.Controls.MetroTextBox()
        Me.userID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.exitLink = New MetroFramework.Controls.MetroLink()
        Me.cancelLink = New MetroFramework.Controls.MetroLink()
        Me.okLink = New MetroFramework.Controls.MetroLink()
        Me.userManageTable.SuspendLayout()
        CType(Me.userDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.controlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'userManageTable
        '
        Me.userManageTable.ColumnCount = 4
        Me.userManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.userManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.userManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.userManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202.0!))
        Me.userManageTable.Controls.Add(Me.userDataGrid, 0, 0)
        Me.userManageTable.Controls.Add(Me.addUserButton, 0, 1)
        Me.userManageTable.Controls.Add(Me.editUserButton, 1, 1)
        Me.userManageTable.Controls.Add(Me.delUserButton, 2, 1)
        Me.userManageTable.Controls.Add(Me.controlPanel, 3, 0)
        Me.userManageTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userManageTable.Location = New System.Drawing.Point(20, 60)
        Me.userManageTable.Name = "userManageTable"
        Me.userManageTable.RowCount = 2
        Me.userManageTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.userManageTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.userManageTable.Size = New System.Drawing.Size(690, 380)
        Me.userManageTable.TabIndex = 2
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
        Me.userDataGrid.Size = New System.Drawing.Size(486, 325)
        Me.userDataGrid.TabIndex = 0
        '
        'addUserButton
        '
        Me.addUserButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addUserButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.addUserButton.Location = New System.Drawing.Point(3, 328)
        Me.addUserButton.Name = "addUserButton"
        Me.addUserButton.Size = New System.Drawing.Size(156, 49)
        Me.addUserButton.TabIndex = 1
        Me.addUserButton.Text = "新增使用者"
        Me.addUserButton.UseSelectable = True
        '
        'editUserButton
        '
        Me.editUserButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editUserButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.editUserButton.Location = New System.Drawing.Point(165, 328)
        Me.editUserButton.Name = "editUserButton"
        Me.editUserButton.Size = New System.Drawing.Size(156, 49)
        Me.editUserButton.TabIndex = 2
        Me.editUserButton.Text = "修改使用者"
        Me.editUserButton.UseSelectable = True
        '
        'delUserButton
        '
        Me.delUserButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.delUserButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.delUserButton.Location = New System.Drawing.Point(327, 328)
        Me.delUserButton.Name = "delUserButton"
        Me.delUserButton.Size = New System.Drawing.Size(156, 49)
        Me.delUserButton.TabIndex = 3
        Me.delUserButton.Text = "刪除使用者"
        Me.delUserButton.UseSelectable = True
        '
        'controlPanel
        '
        Me.controlPanel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.controlPanel.Controls.Add(Me.cancelLink)
        Me.controlPanel.Controls.Add(Me.okLink)
        Me.controlPanel.Controls.Add(Me.MetroLabel3)
        Me.controlPanel.Controls.Add(Me.MetroLabel1)
        Me.controlPanel.Controls.Add(Me.MetroLabel2)
        Me.controlPanel.Controls.Add(Me.userLabel)
        Me.controlPanel.Controls.Add(Me.checkPass)
        Me.controlPanel.Controls.Add(Me.userPass)
        Me.controlPanel.Controls.Add(Me.userName)
        Me.controlPanel.Controls.Add(Me.userID)
        Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.controlPanel.Location = New System.Drawing.Point(486, 0)
        Me.controlPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Padding = New System.Windows.Forms.Padding(20)
        Me.userManageTable.SetRowSpan(Me.controlPanel, 2)
        Me.controlPanel.Size = New System.Drawing.Size(204, 380)
        Me.controlPanel.TabIndex = 2
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
        Me.checkPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.checkPass.CustomButton.Image = Nothing
        Me.checkPass.CustomButton.Location = New System.Drawing.Point(124, 1)
        Me.checkPass.CustomButton.Name = ""
        Me.checkPass.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.checkPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.checkPass.CustomButton.TabIndex = 1
        Me.checkPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.checkPass.CustomButton.UseSelectable = True
        Me.checkPass.CustomButton.Visible = False
        Me.checkPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.checkPass.Lines = New String(-1) {}
        Me.checkPass.Location = New System.Drawing.Point(23, 265)
        Me.checkPass.MaxLength = 32767
        Me.checkPass.Name = "checkPass"
        Me.checkPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.checkPass.PromptText = "確認密碼"
        Me.checkPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.checkPass.SelectedText = ""
        Me.checkPass.SelectionLength = 0
        Me.checkPass.SelectionStart = 0
        Me.checkPass.ShortcutsEnabled = True
        Me.checkPass.Size = New System.Drawing.Size(156, 33)
        Me.checkPass.TabIndex = 7
        Me.checkPass.UseSelectable = True
        Me.checkPass.WaterMark = "確認密碼"
        Me.checkPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.checkPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'userPass
        '
        Me.userPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.userPass.CustomButton.Image = Nothing
        Me.userPass.CustomButton.Location = New System.Drawing.Point(124, 1)
        Me.userPass.CustomButton.Name = ""
        Me.userPass.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.userPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.userPass.CustomButton.TabIndex = 1
        Me.userPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.userPass.CustomButton.UseSelectable = True
        Me.userPass.CustomButton.Visible = False
        Me.userPass.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.userPass.Lines = New String(-1) {}
        Me.userPass.Location = New System.Drawing.Point(23, 226)
        Me.userPass.MaxLength = 32767
        Me.userPass.Name = "userPass"
        Me.userPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userPass.PromptText = "密碼"
        Me.userPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.userPass.SelectedText = ""
        Me.userPass.SelectionLength = 0
        Me.userPass.SelectionStart = 0
        Me.userPass.ShortcutsEnabled = True
        Me.userPass.Size = New System.Drawing.Size(156, 33)
        Me.userPass.TabIndex = 6
        Me.userPass.UseSelectable = True
        Me.userPass.WaterMark = "密碼"
        Me.userPass.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.userPass.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'userName
        '
        Me.userName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.userName.CustomButton.Image = Nothing
        Me.userName.CustomButton.Location = New System.Drawing.Point(124, 1)
        Me.userName.CustomButton.Name = ""
        Me.userName.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.userName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.userName.CustomButton.TabIndex = 1
        Me.userName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.userName.CustomButton.UseSelectable = True
        Me.userName.CustomButton.Visible = False
        Me.userName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.userName.Lines = New String(-1) {}
        Me.userName.Location = New System.Drawing.Point(23, 162)
        Me.userName.MaxLength = 32767
        Me.userName.Name = "userName"
        Me.userName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userName.PromptText = "使用者姓名"
        Me.userName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.userName.SelectedText = ""
        Me.userName.SelectionLength = 0
        Me.userName.SelectionStart = 0
        Me.userName.ShortcutsEnabled = True
        Me.userName.Size = New System.Drawing.Size(156, 33)
        Me.userName.TabIndex = 5
        Me.userName.UseSelectable = True
        Me.userName.WaterMark = "使用者姓名"
        Me.userName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.userName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'userID
        '
        Me.userID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.userID.CustomButton.Image = Nothing
        Me.userID.CustomButton.Location = New System.Drawing.Point(124, 1)
        Me.userID.CustomButton.Name = ""
        Me.userID.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.userID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.userID.CustomButton.TabIndex = 1
        Me.userID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.userID.CustomButton.UseSelectable = True
        Me.userID.CustomButton.Visible = False
        Me.userID.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.userID.Lines = New String(-1) {}
        Me.userID.Location = New System.Drawing.Point(23, 98)
        Me.userID.MaxLength = 32767
        Me.userID.Name = "userID"
        Me.userID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userID.PromptText = "使用者名稱"
        Me.userID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.userID.SelectedText = ""
        Me.userID.SelectionLength = 0
        Me.userID.SelectionStart = 0
        Me.userID.ShortcutsEnabled = True
        Me.userID.Size = New System.Drawing.Size(156, 33)
        Me.userID.TabIndex = 4
        Me.userID.UseSelectable = True
        Me.userID.WaterMark = "使用者名稱"
        Me.userID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.userID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 70)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(107, 25)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "使用者名稱"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 134)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(107, 25)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "使用者姓名"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 198)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(107, 25)
        Me.MetroLabel3.TabIndex = 1
        Me.MetroLabel3.Text = "使用者密碼"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'exitLink
        '
        Me.exitLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitLink.Image = Global.fujunEmsys.My.Resources.Resources.shutdownHover
        Me.exitLink.ImageSize = 40
        Me.exitLink.Location = New System.Drawing.Point(657, 7)
        Me.exitLink.Name = "exitLink"
        Me.exitLink.NoFocusImage = Global.fujunEmsys.My.Resources.Resources.shutdownUp
        Me.exitLink.Size = New System.Drawing.Size(50, 50)
        Me.exitLink.TabIndex = 10
        Me.exitLink.UseSelectable = True
        '
        'cancelLink
        '
        Me.cancelLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelLink.Image = Global.fujunEmsys.My.Resources.Resources.shutdownHover
        Me.cancelLink.ImageSize = 25
        Me.cancelLink.Location = New System.Drawing.Point(109, 324)
        Me.cancelLink.Name = "cancelLink"
        Me.cancelLink.NoFocusImage = Global.fujunEmsys.My.Resources.Resources.shutdownUp
        Me.cancelLink.Size = New System.Drawing.Size(33, 33)
        Me.cancelLink.TabIndex = 9
        Me.cancelLink.UseSelectable = True
        '
        'okLink
        '
        Me.okLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okLink.Image = Global.fujunEmsys.My.Resources.Resources.okHover
        Me.okLink.ImageSize = 25
        Me.okLink.Location = New System.Drawing.Point(148, 324)
        Me.okLink.Name = "okLink"
        Me.okLink.NoFocusImage = Global.fujunEmsys.My.Resources.Resources.okUp
        Me.okLink.Size = New System.Drawing.Size(33, 33)
        Me.okLink.TabIndex = 8
        Me.okLink.UseSelectable = True
        '
        'frmUserManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.exitLink)
        Me.Controls.Add(Me.userManageTable)
        Me.Name = "frmUserManage"
        Me.Text = "使用者管理"
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
    Friend WithEvents cancelLink As MetroFramework.Controls.MetroLink
    Friend WithEvents okLink As MetroFramework.Controls.MetroLink
    Friend WithEvents userLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents checkPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents userPass As MetroFramework.Controls.MetroTextBox
    Friend WithEvents userName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents userID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents exitLink As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class
