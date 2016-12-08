<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlPerscription
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
        Me.pInfoPanel = New System.Windows.Forms.Panel()
        Me.patientTab = New MetroFramework.Controls.MetroTabControl()
        Me.tabPatientInfo = New System.Windows.Forms.TabPage()
        Me.pInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.sexLabel = New MetroFramework.Controls.MetroLink()
        Me.nameLabel = New MetroFramework.Controls.MetroLink()
        Me.ageLabel = New MetroFramework.Controls.MetroLink()
        Me.countLabel = New MetroFramework.Controls.MetroLink()
        Me.lastVisitLabel = New MetroFramework.Controls.MetroLink()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.pName = New MetroFramework.Controls.MetroTextBox()
        Me.pSex = New MetroFramework.Controls.MetroTextBox()
        Me.pAge = New MetroFramework.Controls.MetroTextBox()
        Me.pVisitTimes = New MetroFramework.Controls.MetroTextBox()
        Me.pPrevVisit = New MetroFramework.Controls.MetroTextBox()
        Me.tabBooking = New System.Windows.Forms.TabPage()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.waitingList = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.medList = New System.Windows.Forms.ListBox()
        Me.mainGroupList = New MetroFramework.Controls.MetroComboBox()
        Me.subGroupList = New MetroFramework.Controls.MetroComboBox()
        Me.unusedMedList = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.pInfoPanel.SuspendLayout()
        Me.patientTab.SuspendLayout()
        Me.tabPatientInfo.SuspendLayout()
        Me.pInfoTable.SuspendLayout()
        Me.tabBooking.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.Location = New System.Drawing.Point(26, 26)
        '
        'pInfoPanel
        '
        Me.pInfoPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pInfoPanel.BackColor = System.Drawing.Color.SeaGreen
        Me.pInfoPanel.Controls.Add(Me.patientTab)
        Me.pInfoPanel.Location = New System.Drawing.Point(0, 0)
        Me.pInfoPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.pInfoPanel.Name = "pInfoPanel"
        Me.pInfoPanel.Padding = New System.Windows.Forms.Padding(20)
        Me.pInfoPanel.Size = New System.Drawing.Size(280, 725)
        Me.pInfoPanel.TabIndex = 5
        '
        'patientTab
        '
        Me.patientTab.Controls.Add(Me.tabPatientInfo)
        Me.patientTab.Controls.Add(Me.tabBooking)
        Me.patientTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientTab.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.patientTab.Location = New System.Drawing.Point(20, 20)
        Me.patientTab.Name = "patientTab"
        Me.patientTab.SelectedIndex = 1
        Me.patientTab.Size = New System.Drawing.Size(240, 685)
        Me.patientTab.TabIndex = 3
        Me.patientTab.UseSelectable = True
        '
        'tabPatientInfo
        '
        Me.tabPatientInfo.Controls.Add(Me.pInfoTable)
        Me.tabPatientInfo.Location = New System.Drawing.Point(4, 44)
        Me.tabPatientInfo.Name = "tabPatientInfo"
        Me.tabPatientInfo.Size = New System.Drawing.Size(232, 637)
        Me.tabPatientInfo.TabIndex = 0
        Me.tabPatientInfo.Text = "病患資料"
        '
        'pInfoTable
        '
        Me.pInfoTable.ColumnCount = 1
        Me.pInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pInfoTable.Controls.Add(Me.MetroLink1, 0, 10)
        Me.pInfoTable.Controls.Add(Me.sexLabel, 0, 2)
        Me.pInfoTable.Controls.Add(Me.nameLabel, 0, 0)
        Me.pInfoTable.Controls.Add(Me.ageLabel, 0, 4)
        Me.pInfoTable.Controls.Add(Me.countLabel, 0, 6)
        Me.pInfoTable.Controls.Add(Me.lastVisitLabel, 0, 8)
        Me.pInfoTable.Controls.Add(Me.MetroTextBox1, 0, 11)
        Me.pInfoTable.Controls.Add(Me.pName, 0, 1)
        Me.pInfoTable.Controls.Add(Me.pSex, 0, 3)
        Me.pInfoTable.Controls.Add(Me.pAge, 0, 5)
        Me.pInfoTable.Controls.Add(Me.pVisitTimes, 0, 7)
        Me.pInfoTable.Controls.Add(Me.pPrevVisit, 0, 9)
        Me.pInfoTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pInfoTable.Location = New System.Drawing.Point(0, 0)
        Me.pInfoTable.Name = "pInfoTable"
        Me.pInfoTable.RowCount = 12
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.pInfoTable.Size = New System.Drawing.Size(232, 637)
        Me.pInfoTable.TabIndex = 2
        '
        'MetroLink1
        '
        Me.MetroLink1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink1.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink1.Location = New System.Drawing.Point(3, 403)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(226, 34)
        Me.MetroLink1.TabIndex = 2
        Me.MetroLink1.Text = "主訴項目:"
        Me.MetroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink1.UseSelectable = True
        '
        'sexLabel
        '
        Me.sexLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sexLabel.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.sexLabel.Location = New System.Drawing.Point(3, 83)
        Me.sexLabel.Name = "sexLabel"
        Me.sexLabel.Size = New System.Drawing.Size(226, 34)
        Me.sexLabel.TabIndex = 1
        Me.sexLabel.Text = "性別:"
        Me.sexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sexLabel.UseSelectable = True
        '
        'nameLabel
        '
        Me.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nameLabel.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.nameLabel.Location = New System.Drawing.Point(3, 3)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(226, 34)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "姓名:"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nameLabel.UseSelectable = True
        '
        'ageLabel
        '
        Me.ageLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ageLabel.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.ageLabel.Location = New System.Drawing.Point(3, 163)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(226, 34)
        Me.ageLabel.TabIndex = 1
        Me.ageLabel.Text = "年齡:"
        Me.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ageLabel.UseSelectable = True
        '
        'countLabel
        '
        Me.countLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.countLabel.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.countLabel.Location = New System.Drawing.Point(3, 243)
        Me.countLabel.Name = "countLabel"
        Me.countLabel.Size = New System.Drawing.Size(226, 34)
        Me.countLabel.TabIndex = 1
        Me.countLabel.Text = "診次:"
        Me.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.countLabel.UseSelectable = True
        '
        'lastVisitLabel
        '
        Me.lastVisitLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lastVisitLabel.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.lastVisitLabel.Location = New System.Drawing.Point(3, 323)
        Me.lastVisitLabel.Name = "lastVisitLabel"
        Me.lastVisitLabel.Size = New System.Drawing.Size(226, 34)
        Me.lastVisitLabel.TabIndex = 1
        Me.lastVisitLabel.Text = "前次就診日期:"
        Me.lastVisitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lastVisitLabel.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(36, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(189, 189)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(3, 443)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.PromptText = "不顯示"
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(226, 191)
        Me.MetroTextBox1.TabIndex = 3
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "不顯示"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.Silver
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        '
        'pName
        '
        '
        '
        '
        Me.pName.CustomButton.Image = Nothing
        Me.pName.CustomButton.Location = New System.Drawing.Point(194, 2)
        Me.pName.CustomButton.Name = ""
        Me.pName.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.pName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pName.CustomButton.TabIndex = 1
        Me.pName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pName.CustomButton.UseSelectable = True
        Me.pName.CustomButton.Visible = False
        Me.pName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pName.Enabled = False
        Me.pName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pName.Lines = New String(-1) {}
        Me.pName.Location = New System.Drawing.Point(3, 43)
        Me.pName.MaxLength = 32767
        Me.pName.Name = "pName"
        Me.pName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pName.PromptText = "不顯示"
        Me.pName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pName.SelectedText = ""
        Me.pName.SelectionLength = 0
        Me.pName.SelectionStart = 0
        Me.pName.ShortcutsEnabled = True
        Me.pName.Size = New System.Drawing.Size(226, 34)
        Me.pName.TabIndex = 4
        Me.pName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pName.UseSelectable = True
        Me.pName.WaterMark = "不顯示"
        Me.pName.WaterMarkColor = System.Drawing.Color.Silver
        Me.pName.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        '
        'pSex
        '
        '
        '
        '
        Me.pSex.CustomButton.Image = Nothing
        Me.pSex.CustomButton.Location = New System.Drawing.Point(194, 2)
        Me.pSex.CustomButton.Name = ""
        Me.pSex.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.pSex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pSex.CustomButton.TabIndex = 1
        Me.pSex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pSex.CustomButton.UseSelectable = True
        Me.pSex.CustomButton.Visible = False
        Me.pSex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pSex.Enabled = False
        Me.pSex.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pSex.Lines = New String(-1) {}
        Me.pSex.Location = New System.Drawing.Point(3, 123)
        Me.pSex.MaxLength = 32767
        Me.pSex.Name = "pSex"
        Me.pSex.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pSex.PromptText = "不顯示"
        Me.pSex.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pSex.SelectedText = ""
        Me.pSex.SelectionLength = 0
        Me.pSex.SelectionStart = 0
        Me.pSex.ShortcutsEnabled = True
        Me.pSex.Size = New System.Drawing.Size(226, 34)
        Me.pSex.TabIndex = 4
        Me.pSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pSex.UseSelectable = True
        Me.pSex.WaterMark = "不顯示"
        Me.pSex.WaterMarkColor = System.Drawing.Color.Silver
        Me.pSex.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        '
        'pAge
        '
        '
        '
        '
        Me.pAge.CustomButton.Image = Nothing
        Me.pAge.CustomButton.Location = New System.Drawing.Point(194, 2)
        Me.pAge.CustomButton.Name = ""
        Me.pAge.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.pAge.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pAge.CustomButton.TabIndex = 1
        Me.pAge.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pAge.CustomButton.UseSelectable = True
        Me.pAge.CustomButton.Visible = False
        Me.pAge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pAge.Enabled = False
        Me.pAge.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pAge.Lines = New String(-1) {}
        Me.pAge.Location = New System.Drawing.Point(3, 203)
        Me.pAge.MaxLength = 32767
        Me.pAge.Name = "pAge"
        Me.pAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pAge.PromptText = "不顯示"
        Me.pAge.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pAge.SelectedText = ""
        Me.pAge.SelectionLength = 0
        Me.pAge.SelectionStart = 0
        Me.pAge.ShortcutsEnabled = True
        Me.pAge.Size = New System.Drawing.Size(226, 34)
        Me.pAge.TabIndex = 4
        Me.pAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pAge.UseSelectable = True
        Me.pAge.WaterMark = "不顯示"
        Me.pAge.WaterMarkColor = System.Drawing.Color.Silver
        Me.pAge.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        '
        'pVisitTimes
        '
        '
        '
        '
        Me.pVisitTimes.CustomButton.Image = Nothing
        Me.pVisitTimes.CustomButton.Location = New System.Drawing.Point(194, 2)
        Me.pVisitTimes.CustomButton.Name = ""
        Me.pVisitTimes.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.pVisitTimes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pVisitTimes.CustomButton.TabIndex = 1
        Me.pVisitTimes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pVisitTimes.CustomButton.UseSelectable = True
        Me.pVisitTimes.CustomButton.Visible = False
        Me.pVisitTimes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pVisitTimes.Enabled = False
        Me.pVisitTimes.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pVisitTimes.Lines = New String(-1) {}
        Me.pVisitTimes.Location = New System.Drawing.Point(3, 283)
        Me.pVisitTimes.MaxLength = 32767
        Me.pVisitTimes.Name = "pVisitTimes"
        Me.pVisitTimes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pVisitTimes.PromptText = "不顯示"
        Me.pVisitTimes.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pVisitTimes.SelectedText = ""
        Me.pVisitTimes.SelectionLength = 0
        Me.pVisitTimes.SelectionStart = 0
        Me.pVisitTimes.ShortcutsEnabled = True
        Me.pVisitTimes.Size = New System.Drawing.Size(226, 34)
        Me.pVisitTimes.TabIndex = 4
        Me.pVisitTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pVisitTimes.UseSelectable = True
        Me.pVisitTimes.WaterMark = "不顯示"
        Me.pVisitTimes.WaterMarkColor = System.Drawing.Color.Silver
        Me.pVisitTimes.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        '
        'pPrevVisit
        '
        '
        '
        '
        Me.pPrevVisit.CustomButton.Image = Nothing
        Me.pPrevVisit.CustomButton.Location = New System.Drawing.Point(194, 2)
        Me.pPrevVisit.CustomButton.Name = ""
        Me.pPrevVisit.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.pPrevVisit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pPrevVisit.CustomButton.TabIndex = 1
        Me.pPrevVisit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pPrevVisit.CustomButton.UseSelectable = True
        Me.pPrevVisit.CustomButton.Visible = False
        Me.pPrevVisit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pPrevVisit.Enabled = False
        Me.pPrevVisit.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pPrevVisit.Lines = New String(-1) {}
        Me.pPrevVisit.Location = New System.Drawing.Point(3, 363)
        Me.pPrevVisit.MaxLength = 32767
        Me.pPrevVisit.Name = "pPrevVisit"
        Me.pPrevVisit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pPrevVisit.PromptText = "不顯示"
        Me.pPrevVisit.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pPrevVisit.SelectedText = ""
        Me.pPrevVisit.SelectionLength = 0
        Me.pPrevVisit.SelectionStart = 0
        Me.pPrevVisit.ShortcutsEnabled = True
        Me.pPrevVisit.Size = New System.Drawing.Size(226, 34)
        Me.pPrevVisit.TabIndex = 4
        Me.pPrevVisit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pPrevVisit.UseSelectable = True
        Me.pPrevVisit.WaterMark = "不顯示"
        Me.pPrevVisit.WaterMarkColor = System.Drawing.Color.Silver
        Me.pPrevVisit.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        '
        'tabBooking
        '
        Me.tabBooking.Controls.Add(Me.MetroDateTime1)
        Me.tabBooking.Controls.Add(Me.waitingList)
        Me.tabBooking.Location = New System.Drawing.Point(4, 44)
        Me.tabBooking.Name = "tabBooking"
        Me.tabBooking.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.tabBooking.Size = New System.Drawing.Size(232, 637)
        Me.tabBooking.TabIndex = 1
        Me.tabBooking.Text = "等候清單"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Location = New System.Drawing.Point(0, 0)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(229, 29)
        Me.MetroDateTime1.TabIndex = 1
        '
        'waitingList
        '
        Me.waitingList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.waitingList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.waitingList.FormattingEnabled = True
        Me.waitingList.ItemHeight = 20
        Me.waitingList.Location = New System.Drawing.Point(0, 30)
        Me.waitingList.Name = "waitingList"
        Me.waitingList.Size = New System.Drawing.Size(232, 607)
        Me.waitingList.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MetroTextBox2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.medList, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.mainGroupList, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.subGroupList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.unusedMedList, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroButton1, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(599, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(441, 643)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(3, 566)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.PromptText = "快速搜尋"
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(355, 34)
        Me.MetroTextBox2.TabIndex = 5
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMark = "快速搜尋"
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'medList
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.medList, 2)
        Me.medList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.medList.FormattingEnabled = True
        Me.medList.ItemHeight = 20
        Me.medList.Location = New System.Drawing.Point(3, 83)
        Me.medList.Name = "medList"
        Me.medList.Size = New System.Drawing.Size(435, 477)
        Me.medList.TabIndex = 0
        '
        'mainGroupList
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.mainGroupList, 2)
        Me.mainGroupList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainGroupList.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.mainGroupList.FormattingEnabled = True
        Me.mainGroupList.ItemHeight = 29
        Me.mainGroupList.Location = New System.Drawing.Point(3, 3)
        Me.mainGroupList.Name = "mainGroupList"
        Me.mainGroupList.Size = New System.Drawing.Size(435, 35)
        Me.mainGroupList.TabIndex = 1
        Me.mainGroupList.UseSelectable = True
        '
        'subGroupList
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.subGroupList, 2)
        Me.subGroupList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subGroupList.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.subGroupList.FormattingEnabled = True
        Me.subGroupList.ItemHeight = 29
        Me.subGroupList.Location = New System.Drawing.Point(3, 43)
        Me.subGroupList.Name = "subGroupList"
        Me.subGroupList.Size = New System.Drawing.Size(435, 35)
        Me.subGroupList.TabIndex = 2
        Me.subGroupList.UseSelectable = True
        '
        'unusedMedList
        '
        Me.unusedMedList.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.unusedMedList, 2)
        Me.unusedMedList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unusedMedList.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.unusedMedList.Location = New System.Drawing.Point(3, 606)
        Me.unusedMedList.Name = "unusedMedList"
        Me.unusedMedList.Size = New System.Drawing.Size(435, 34)
        Me.unusedMedList.TabIndex = 3
        Me.unusedMedList.Text = "顯示未分類藥品"
        Me.unusedMedList.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroButton1.Location = New System.Drawing.Point(364, 566)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(74, 34)
        Me.MetroButton1.TabIndex = 6
        Me.MetroButton1.Text = "搜尋"
        Me.MetroButton1.UseSelectable = True
        '
        'pnlPerscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pInfoPanel)
        Me.Name = "pnlPerscription"
        Me.Size = New System.Drawing.Size(1273, 725)
        Me.pInfoPanel.ResumeLayout(False)
        Me.patientTab.ResumeLayout(False)
        Me.tabPatientInfo.ResumeLayout(False)
        Me.pInfoTable.ResumeLayout(False)
        Me.tabBooking.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pInfoPanel As Panel
    Friend WithEvents patientTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabPatientInfo As TabPage
    Friend WithEvents pInfoTable As TableLayoutPanel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents sexLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents nameLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents ageLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents countLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents lastVisitLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pSex As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pAge As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pVisitTimes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pPrevVisit As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tabBooking As TabPage
    Friend WithEvents waitingList As ListBox
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents medList As ListBox
    Friend WithEvents mainGroupList As MetroFramework.Controls.MetroComboBox
    Friend WithEvents subGroupList As MetroFramework.Controls.MetroComboBox
    Friend WithEvents unusedMedList As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
