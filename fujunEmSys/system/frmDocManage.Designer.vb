<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocManage
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
        Me.docManageTable = New System.Windows.Forms.TableLayoutPanel()
        Me.docDataGrid = New System.Windows.Forms.DataGridView()
        Me.addDocButton = New MetroFramework.Controls.MetroButton()
        Me.editDocButton = New MetroFramework.Controls.MetroButton()
        Me.delDocButton = New MetroFramework.Controls.MetroButton()
        Me.controlPanel = New System.Windows.Forms.Panel()
        Me.cancelLink = New MetroFramework.Controls.MetroLink()
        Me.okLink = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.docLabel = New MetroFramework.Controls.MetroLabel()
        Me.docName = New MetroFramework.Controls.MetroTextBox()
        Me.exitLink = New MetroFramework.Controls.MetroLink()
        Me.docLicence = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.docManageTable.SuspendLayout()
        CType(Me.docDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.controlPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'docManageTable
        '
        Me.docManageTable.ColumnCount = 4
        Me.docManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.docManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.docManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.docManageTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205.0!))
        Me.docManageTable.Controls.Add(Me.docDataGrid, 0, 0)
        Me.docManageTable.Controls.Add(Me.addDocButton, 0, 1)
        Me.docManageTable.Controls.Add(Me.editDocButton, 1, 1)
        Me.docManageTable.Controls.Add(Me.delDocButton, 2, 1)
        Me.docManageTable.Controls.Add(Me.controlPanel, 3, 0)
        Me.docManageTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.docManageTable.Location = New System.Drawing.Point(20, 60)
        Me.docManageTable.Name = "docManageTable"
        Me.docManageTable.RowCount = 2
        Me.docManageTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.docManageTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.docManageTable.Size = New System.Drawing.Size(690, 380)
        Me.docManageTable.TabIndex = 3
        '
        'docDataGrid
        '
        Me.docDataGrid.AllowUserToAddRows = False
        Me.docDataGrid.AllowUserToDeleteRows = False
        Me.docDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.docDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.docDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.docManageTable.SetColumnSpan(Me.docDataGrid, 3)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.docDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.docDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.docDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.docDataGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.docDataGrid.MultiSelect = False
        Me.docDataGrid.Name = "docDataGrid"
        Me.docDataGrid.RowTemplate.Height = 24
        Me.docDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.docDataGrid.Size = New System.Drawing.Size(483, 325)
        Me.docDataGrid.TabIndex = 0
        '
        'addDocButton
        '
        Me.addDocButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addDocButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.addDocButton.Location = New System.Drawing.Point(3, 328)
        Me.addDocButton.Name = "addDocButton"
        Me.addDocButton.Size = New System.Drawing.Size(155, 49)
        Me.addDocButton.TabIndex = 1
        Me.addDocButton.Text = "新增醫師"
        Me.addDocButton.UseSelectable = True
        '
        'editDocButton
        '
        Me.editDocButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editDocButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.editDocButton.Location = New System.Drawing.Point(164, 328)
        Me.editDocButton.Name = "editDocButton"
        Me.editDocButton.Size = New System.Drawing.Size(155, 49)
        Me.editDocButton.TabIndex = 2
        Me.editDocButton.Text = "修改醫師"
        Me.editDocButton.UseSelectable = True
        '
        'delDocButton
        '
        Me.delDocButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.delDocButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.delDocButton.Location = New System.Drawing.Point(325, 328)
        Me.delDocButton.Name = "delDocButton"
        Me.delDocButton.Size = New System.Drawing.Size(155, 49)
        Me.delDocButton.TabIndex = 3
        Me.delDocButton.Text = "刪除醫師"
        Me.delDocButton.UseSelectable = True
        '
        'controlPanel
        '
        Me.controlPanel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.controlPanel.Controls.Add(Me.cancelLink)
        Me.controlPanel.Controls.Add(Me.okLink)
        Me.controlPanel.Controls.Add(Me.MetroLabel1)
        Me.controlPanel.Controls.Add(Me.MetroLabel2)
        Me.controlPanel.Controls.Add(Me.docLicence)
        Me.controlPanel.Controls.Add(Me.docLabel)
        Me.controlPanel.Controls.Add(Me.docName)
        Me.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.controlPanel.Location = New System.Drawing.Point(483, 0)
        Me.controlPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.controlPanel.Name = "controlPanel"
        Me.controlPanel.Padding = New System.Windows.Forms.Padding(20)
        Me.docManageTable.SetRowSpan(Me.controlPanel, 2)
        Me.controlPanel.Size = New System.Drawing.Size(207, 380)
        Me.controlPanel.TabIndex = 2
        '
        'cancelLink
        '
        Me.cancelLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelLink.Image = Global.fujunEmsys.My.Resources.Resources.shutdownHover
        Me.cancelLink.ImageSize = 25
        Me.cancelLink.Location = New System.Drawing.Point(112, 324)
        Me.cancelLink.Name = "cancelLink"
        Me.cancelLink.NoFocusImage = Global.fujunEmsys.My.Resources.Resources.shutdownUp
        Me.cancelLink.Size = New System.Drawing.Size(33, 33)
        Me.cancelLink.TabIndex = 7
        Me.cancelLink.UseSelectable = True
        '
        'okLink
        '
        Me.okLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okLink.Image = Global.fujunEmsys.My.Resources.Resources.okHover
        Me.okLink.ImageSize = 25
        Me.okLink.Location = New System.Drawing.Point(151, 324)
        Me.okLink.Name = "okLink"
        Me.okLink.NoFocusImage = Global.fujunEmsys.My.Resources.Resources.okUp
        Me.okLink.Size = New System.Drawing.Size(33, 33)
        Me.okLink.TabIndex = 6
        Me.okLink.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 70)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(88, 25)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "醫師姓名"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'docLabel
        '
        Me.docLabel.AutoSize = True
        Me.docLabel.BackColor = System.Drawing.Color.Transparent
        Me.docLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.docLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.docLabel.Location = New System.Drawing.Point(23, 20)
        Me.docLabel.Name = "docLabel"
        Me.docLabel.Size = New System.Drawing.Size(92, 25)
        Me.docLabel.TabIndex = 1
        Me.docLabel.Text = "新增醫師"
        '
        'docName
        '
        Me.docName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.docName.CustomButton.Image = Nothing
        Me.docName.CustomButton.Location = New System.Drawing.Point(127, 1)
        Me.docName.CustomButton.Name = ""
        Me.docName.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.docName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.docName.CustomButton.TabIndex = 1
        Me.docName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.docName.CustomButton.UseSelectable = True
        Me.docName.CustomButton.Visible = False
        Me.docName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.docName.Lines = New String(-1) {}
        Me.docName.Location = New System.Drawing.Point(23, 98)
        Me.docName.MaxLength = 32767
        Me.docName.Name = "docName"
        Me.docName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.docName.PromptText = "醫師姓名"
        Me.docName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.docName.SelectedText = ""
        Me.docName.SelectionLength = 0
        Me.docName.SelectionStart = 0
        Me.docName.ShortcutsEnabled = True
        Me.docName.Size = New System.Drawing.Size(159, 33)
        Me.docName.TabIndex = 4
        Me.docName.UseSelectable = True
        Me.docName.WaterMark = "醫師姓名"
        Me.docName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.docName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'exitLink
        '
        Me.exitLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitLink.Image = Global.fujunEmsys.My.Resources.Resources.shutdownHover
        Me.exitLink.ImageSize = 40
        Me.exitLink.Location = New System.Drawing.Point(660, 7)
        Me.exitLink.Name = "exitLink"
        Me.exitLink.NoFocusImage = Global.fujunEmsys.My.Resources.Resources.shutdownUp
        Me.exitLink.Size = New System.Drawing.Size(50, 50)
        Me.exitLink.TabIndex = 8
        Me.exitLink.UseSelectable = True
        '
        'docLicence
        '
        Me.docLicence.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.docLicence.CustomButton.Image = Nothing
        Me.docLicence.CustomButton.Location = New System.Drawing.Point(127, 1)
        Me.docLicence.CustomButton.Name = ""
        Me.docLicence.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.docLicence.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.docLicence.CustomButton.TabIndex = 1
        Me.docLicence.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.docLicence.CustomButton.UseSelectable = True
        Me.docLicence.CustomButton.Visible = False
        Me.docLicence.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.docLicence.Lines = New String(-1) {}
        Me.docLicence.Location = New System.Drawing.Point(23, 162)
        Me.docLicence.MaxLength = 32767
        Me.docLicence.Name = "docLicence"
        Me.docLicence.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.docLicence.PromptText = "醫師執照號碼"
        Me.docLicence.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.docLicence.SelectedText = ""
        Me.docLicence.SelectionLength = 0
        Me.docLicence.SelectionStart = 0
        Me.docLicence.ShortcutsEnabled = True
        Me.docLicence.Size = New System.Drawing.Size(159, 33)
        Me.docLicence.TabIndex = 5
        Me.docLicence.UseSelectable = True
        Me.docLicence.WaterMark = "醫師執照號碼"
        Me.docLicence.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.docLicence.WaterMarkFont = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 134)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(126, 25)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "醫師執照號碼"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'frmDocManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 460)
        Me.Controls.Add(Me.exitLink)
        Me.Controls.Add(Me.docManageTable)
        Me.Name = "frmDocManage"
        Me.Text = "醫師管理"
        Me.docManageTable.ResumeLayout(False)
        CType(Me.docDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.controlPanel.ResumeLayout(False)
        Me.controlPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents docManageTable As TableLayoutPanel
    Friend WithEvents docDataGrid As DataGridView
    Friend WithEvents addDocButton As MetroFramework.Controls.MetroButton
    Friend WithEvents editDocButton As MetroFramework.Controls.MetroButton
    Friend WithEvents delDocButton As MetroFramework.Controls.MetroButton
    Friend WithEvents controlPanel As Panel
    Friend WithEvents cancelLink As MetroFramework.Controls.MetroLink
    Friend WithEvents okLink As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents docLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents docName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents exitLink As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents docLicence As MetroFramework.Controls.MetroTextBox
End Class
