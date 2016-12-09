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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.searchTable = New System.Windows.Forms.TableLayoutPanel()
        Me.searchBox = New MetroFramework.Controls.MetroTextBox()
        Me.unusedMedList = New MetroFramework.Controls.MetroCheckBox()
        Me.medTree = New System.Windows.Forms.TreeView()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabMedSetup = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.delMedGroup = New MetroFramework.Controls.MetroButton()
        Me.addMedGroup = New MetroFramework.Controls.MetroButton()
        Me.medGroupGrid = New System.Windows.Forms.DataGridView()
        Me.medGroupLabel = New MetroFramework.Controls.MetroLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.medGroupAmount = New MetroFramework.Controls.MetroTextBox()
        Me.F0 = New System.Windows.Forms.CheckBox()
        Me.afterMeal = New System.Windows.Forms.CheckBox()
        Me.morning = New System.Windows.Forms.CheckBox()
        Me.noon = New System.Windows.Forms.CheckBox()
        Me.night = New System.Windows.Forms.CheckBox()
        Me.beforeSleep = New System.Windows.Forms.CheckBox()
        Me.beforeMeal = New System.Windows.Forms.CheckBox()
        Me.makePill = New System.Windows.Forms.CheckBox()
        Me.notWell = New System.Windows.Forms.CheckBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.medGroupDays = New MetroFramework.Controls.MetroTextBox()
        Me.medGroupChange = New MetroFramework.Controls.MetroButton()
        Me.medGroupUnit = New MetroFramework.Controls.MetroComboBox()
        Me.medDetailPanel = New MetroFramework.Controls.MetroPanel()
        Me.delMedDetail = New MetroFramework.Controls.MetroButton()
        Me.addMedDetail = New MetroFramework.Controls.MetroButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.medDetailAmount = New MetroFramework.Controls.MetroTextBox()
        Me.medDetailChange = New MetroFramework.Controls.MetroButton()
        Me.medDetailUnit = New MetroFramework.Controls.MetroComboBox()
        Me.medDetailLabel = New MetroFramework.Controls.MetroLabel()
        Me.medDetailGrid = New System.Windows.Forms.DataGridView()
        Me.pInfoPanel.SuspendLayout()
        Me.patientTab.SuspendLayout()
        Me.tabPatientInfo.SuspendLayout()
        Me.pInfoTable.SuspendLayout()
        Me.tabBooking.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.searchTable.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabMedSetup.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.medGroupGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.medDetailPanel.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.medDetailGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.ClientSize = New System.Drawing.Size(0, 0)
        Me.owner.Location = New System.Drawing.Point(-32000, -32000)
        Me.owner.WindowState = System.Windows.Forms.FormWindowState.Minimized
        '
        'pInfoPanel
        '
        Me.pInfoPanel.BackColor = System.Drawing.Color.SeaGreen
        Me.pInfoPanel.Controls.Add(Me.patientTab)
        Me.pInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pInfoPanel.Location = New System.Drawing.Point(0, 0)
        Me.pInfoPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.pInfoPanel.Name = "pInfoPanel"
        Me.pInfoPanel.Padding = New System.Windows.Forms.Padding(20)
        Me.pInfoPanel.Size = New System.Drawing.Size(300, 725)
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
        Me.patientTab.Size = New System.Drawing.Size(260, 685)
        Me.patientTab.TabIndex = 3
        Me.patientTab.UseSelectable = True
        '
        'tabPatientInfo
        '
        Me.tabPatientInfo.Controls.Add(Me.pInfoTable)
        Me.tabPatientInfo.Location = New System.Drawing.Point(4, 44)
        Me.tabPatientInfo.Name = "tabPatientInfo"
        Me.tabPatientInfo.Size = New System.Drawing.Size(252, 637)
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
        Me.pInfoTable.Size = New System.Drawing.Size(252, 637)
        Me.pInfoTable.TabIndex = 2
        '
        'MetroLink1
        '
        Me.MetroLink1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink1.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink1.Location = New System.Drawing.Point(3, 403)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(246, 34)
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
        Me.sexLabel.Size = New System.Drawing.Size(246, 34)
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
        Me.nameLabel.Size = New System.Drawing.Size(246, 34)
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
        Me.ageLabel.Size = New System.Drawing.Size(246, 34)
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
        Me.countLabel.Size = New System.Drawing.Size(246, 34)
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
        Me.lastVisitLabel.Size = New System.Drawing.Size(246, 34)
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
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(56, 1)
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
        Me.MetroTextBox1.Size = New System.Drawing.Size(246, 191)
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
        Me.pName.CustomButton.Location = New System.Drawing.Point(214, 2)
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
        Me.pName.Size = New System.Drawing.Size(246, 34)
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
        Me.pSex.CustomButton.Location = New System.Drawing.Point(214, 2)
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
        Me.pSex.Size = New System.Drawing.Size(246, 34)
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
        Me.pAge.CustomButton.Location = New System.Drawing.Point(214, 2)
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
        Me.pAge.Size = New System.Drawing.Size(246, 34)
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
        Me.pVisitTimes.CustomButton.Location = New System.Drawing.Point(214, 2)
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
        Me.pVisitTimes.Size = New System.Drawing.Size(246, 34)
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
        Me.pPrevVisit.CustomButton.Location = New System.Drawing.Point(214, 2)
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
        Me.pPrevVisit.Size = New System.Drawing.Size(246, 34)
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
        Me.tabBooking.Size = New System.Drawing.Size(252, 637)
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
        Me.waitingList.Size = New System.Drawing.Size(252, 607)
        Me.waitingList.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pInfoPanel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroPanel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroTabControl1, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1273, 725)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.SaddleBrown
        Me.MetroPanel2.Controls.Add(Me.searchTable)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.ForeColor = System.Drawing.Color.White
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(303, 3)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(10, 50, 10, 10)
        Me.MetroPanel2.Size = New System.Drawing.Size(294, 719)
        Me.MetroPanel2.TabIndex = 8
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'searchTable
        '
        Me.searchTable.ColumnCount = 1
        Me.searchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.searchTable.Controls.Add(Me.searchBox, 0, 1)
        Me.searchTable.Controls.Add(Me.unusedMedList, 0, 2)
        Me.searchTable.Controls.Add(Me.medTree, 0, 0)
        Me.searchTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchTable.Location = New System.Drawing.Point(10, 50)
        Me.searchTable.Name = "searchTable"
        Me.searchTable.RowCount = 3
        Me.searchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.searchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.searchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.searchTable.Size = New System.Drawing.Size(274, 659)
        Me.searchTable.TabIndex = 7
        '
        'searchBox
        '
        '
        '
        '
        Me.searchBox.CustomButton.Image = Nothing
        Me.searchBox.CustomButton.Location = New System.Drawing.Point(236, 2)
        Me.searchBox.CustomButton.Name = ""
        Me.searchBox.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.searchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchBox.CustomButton.TabIndex = 1
        Me.searchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchBox.CustomButton.UseSelectable = True
        Me.searchBox.CustomButton.Visible = False
        Me.searchBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.searchBox.Lines = New String(-1) {}
        Me.searchBox.Location = New System.Drawing.Point(3, 582)
        Me.searchBox.MaxLength = 32767
        Me.searchBox.Name = "searchBox"
        Me.searchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchBox.PromptText = "快速搜尋"
        Me.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchBox.SelectedText = ""
        Me.searchBox.SelectionLength = 0
        Me.searchBox.SelectionStart = 0
        Me.searchBox.ShortcutsEnabled = True
        Me.searchBox.Size = New System.Drawing.Size(268, 34)
        Me.searchBox.TabIndex = 5
        Me.searchBox.UseSelectable = True
        Me.searchBox.WaterMark = "快速搜尋"
        Me.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchBox.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'unusedMedList
        '
        Me.unusedMedList.AutoSize = True
        Me.unusedMedList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unusedMedList.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.unusedMedList.Location = New System.Drawing.Point(3, 622)
        Me.unusedMedList.Name = "unusedMedList"
        Me.unusedMedList.Size = New System.Drawing.Size(268, 34)
        Me.unusedMedList.TabIndex = 3
        Me.unusedMedList.Text = "顯示未分類藥品"
        Me.unusedMedList.UseCustomBackColor = True
        Me.unusedMedList.UseCustomForeColor = True
        Me.unusedMedList.UseSelectable = True
        '
        'medTree
        '
        Me.medTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medTree.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.medTree.Location = New System.Drawing.Point(3, 3)
        Me.medTree.Name = "medTree"
        Me.medTree.Size = New System.Drawing.Size(268, 573)
        Me.medTree.TabIndex = 12
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.ForeColor = System.Drawing.Color.White
        Me.MetroLabel6.Location = New System.Drawing.Point(10, 22)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(92, 25)
        Me.MetroLabel6.TabIndex = 13
        Me.MetroLabel6.Text = "藥物搜尋"
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabMedSetup)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(603, 3)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(667, 719)
        Me.MetroTabControl1.TabIndex = 13
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabMedSetup
        '
        Me.tabMedSetup.Controls.Add(Me.TableLayoutPanel3)
        Me.tabMedSetup.Location = New System.Drawing.Point(4, 38)
        Me.tabMedSetup.Name = "tabMedSetup"
        Me.tabMedSetup.Size = New System.Drawing.Size(659, 677)
        Me.tabMedSetup.TabIndex = 0
        Me.tabMedSetup.Text = "藥包設定"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.MetroPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.medDetailPanel, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(659, 677)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.DarkCyan
        Me.MetroPanel1.Controls.Add(Me.delMedGroup)
        Me.MetroPanel1.Controls.Add(Me.addMedGroup)
        Me.MetroPanel1.Controls.Add(Me.medGroupGrid)
        Me.MetroPanel1.Controls.Add(Me.medGroupLabel)
        Me.MetroPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Padding = New System.Windows.Forms.Padding(10, 50, 10, 180)
        Me.MetroPanel1.Size = New System.Drawing.Size(323, 671)
        Me.MetroPanel1.TabIndex = 12
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'delMedGroup
        '
        Me.delMedGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delMedGroup.Location = New System.Drawing.Point(292, 20)
        Me.delMedGroup.Name = "delMedGroup"
        Me.delMedGroup.Size = New System.Drawing.Size(21, 24)
        Me.delMedGroup.TabIndex = 15
        Me.delMedGroup.Text = "-"
        Me.delMedGroup.UseSelectable = True
        '
        'addMedGroup
        '
        Me.addMedGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addMedGroup.Location = New System.Drawing.Point(265, 20)
        Me.addMedGroup.Name = "addMedGroup"
        Me.addMedGroup.Size = New System.Drawing.Size(21, 24)
        Me.addMedGroup.TabIndex = 15
        Me.addMedGroup.Text = "+"
        Me.addMedGroup.UseSelectable = True
        '
        'medGroupGrid
        '
        Me.medGroupGrid.AllowUserToAddRows = False
        Me.medGroupGrid.AllowUserToDeleteRows = False
        Me.medGroupGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.medGroupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.medGroupGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medGroupGrid.Location = New System.Drawing.Point(10, 50)
        Me.medGroupGrid.MultiSelect = False
        Me.medGroupGrid.Name = "medGroupGrid"
        Me.medGroupGrid.ReadOnly = True
        Me.medGroupGrid.RowTemplate.Height = 24
        Me.medGroupGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.medGroupGrid.Size = New System.Drawing.Size(303, 441)
        Me.medGroupGrid.TabIndex = 14
        '
        'medGroupLabel
        '
        Me.medGroupLabel.AutoSize = True
        Me.medGroupLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.medGroupLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.medGroupLabel.ForeColor = System.Drawing.Color.White
        Me.medGroupLabel.Location = New System.Drawing.Point(10, 22)
        Me.medGroupLabel.Name = "medGroupLabel"
        Me.medGroupLabel.Size = New System.Drawing.Size(92, 25)
        Me.medGroupLabel.TabIndex = 13
        Me.medGroupLabel.Text = "藥物群組"
        Me.medGroupLabel.UseCustomBackColor = True
        Me.medGroupLabel.UseCustomForeColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.medGroupAmount, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.F0, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.afterMeal, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.morning, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.noon, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.night, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.beforeSleep, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.beforeMeal, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.makePill, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.notWell, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.medGroupDays, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.medGroupChange, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.medGroupUnit, 3, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 497)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(303, 164)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.ForeColor = System.Drawing.Color.White
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 84)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(54, 40)
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "份量"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'medGroupAmount
        '
        Me.medGroupAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.medGroupAmount, 2)
        '
        '
        '
        Me.medGroupAmount.CustomButton.Image = Nothing
        Me.medGroupAmount.CustomButton.Location = New System.Drawing.Point(86, 2)
        Me.medGroupAmount.CustomButton.Name = ""
        Me.medGroupAmount.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.medGroupAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.medGroupAmount.CustomButton.TabIndex = 1
        Me.medGroupAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.medGroupAmount.CustomButton.UseSelectable = True
        Me.medGroupAmount.CustomButton.Visible = False
        Me.medGroupAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.medGroupAmount.Lines = New String() {"14"}
        Me.medGroupAmount.Location = New System.Drawing.Point(63, 89)
        Me.medGroupAmount.MaxLength = 32767
        Me.medGroupAmount.Name = "medGroupAmount"
        Me.medGroupAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medGroupAmount.PromptText = "天數"
        Me.medGroupAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.medGroupAmount.SelectedText = ""
        Me.medGroupAmount.SelectionLength = 0
        Me.medGroupAmount.SelectionStart = 0
        Me.medGroupAmount.ShortcutsEnabled = True
        Me.medGroupAmount.Size = New System.Drawing.Size(114, 30)
        Me.medGroupAmount.TabIndex = 8
        Me.medGroupAmount.Text = "14"
        Me.medGroupAmount.UseSelectable = True
        Me.medGroupAmount.WaterMark = "天數"
        Me.medGroupAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.medGroupAmount.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'F0
        '
        Me.F0.Appearance = System.Windows.Forms.Appearance.Button
        Me.F0.AutoSize = True
        Me.F0.BackColor = System.Drawing.SystemColors.HotTrack
        Me.F0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.F0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.F0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.F0.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.F0.ForeColor = System.Drawing.Color.White
        Me.F0.Location = New System.Drawing.Point(243, 45)
        Me.F0.Name = "F0"
        Me.F0.Size = New System.Drawing.Size(57, 36)
        Me.F0.TabIndex = 3
        Me.F0.Text = "F0"
        Me.F0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.F0.UseVisualStyleBackColor = False
        '
        'afterMeal
        '
        Me.afterMeal.Appearance = System.Windows.Forms.Appearance.Button
        Me.afterMeal.AutoSize = True
        Me.afterMeal.BackColor = System.Drawing.SystemColors.HotTrack
        Me.afterMeal.Checked = True
        Me.afterMeal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.afterMeal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.afterMeal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.afterMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.afterMeal.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.afterMeal.ForeColor = System.Drawing.Color.White
        Me.afterMeal.Location = New System.Drawing.Point(63, 45)
        Me.afterMeal.Name = "afterMeal"
        Me.afterMeal.Size = New System.Drawing.Size(54, 36)
        Me.afterMeal.TabIndex = 2
        Me.afterMeal.Text = "飯後"
        Me.afterMeal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.afterMeal.UseVisualStyleBackColor = False
        '
        'morning
        '
        Me.morning.Appearance = System.Windows.Forms.Appearance.Button
        Me.morning.AutoSize = True
        Me.morning.BackColor = System.Drawing.Color.SteelBlue
        Me.morning.Checked = True
        Me.morning.CheckState = System.Windows.Forms.CheckState.Checked
        Me.morning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.morning.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.morning.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.morning.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.morning.ForeColor = System.Drawing.Color.White
        Me.morning.Location = New System.Drawing.Point(3, 3)
        Me.morning.Name = "morning"
        Me.morning.Size = New System.Drawing.Size(54, 36)
        Me.morning.TabIndex = 0
        Me.morning.Text = "早"
        Me.morning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.morning.UseVisualStyleBackColor = False
        '
        'noon
        '
        Me.noon.Appearance = System.Windows.Forms.Appearance.Button
        Me.noon.AutoSize = True
        Me.noon.BackColor = System.Drawing.Color.SteelBlue
        Me.noon.Checked = True
        Me.noon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.noon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.noon.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.noon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.noon.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.noon.ForeColor = System.Drawing.Color.White
        Me.noon.Location = New System.Drawing.Point(63, 3)
        Me.noon.Name = "noon"
        Me.noon.Size = New System.Drawing.Size(54, 36)
        Me.noon.TabIndex = 1
        Me.noon.Text = "中"
        Me.noon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.noon.UseVisualStyleBackColor = False
        '
        'night
        '
        Me.night.Appearance = System.Windows.Forms.Appearance.Button
        Me.night.AutoSize = True
        Me.night.BackColor = System.Drawing.Color.SteelBlue
        Me.night.Checked = True
        Me.night.CheckState = System.Windows.Forms.CheckState.Checked
        Me.night.Dock = System.Windows.Forms.DockStyle.Fill
        Me.night.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.night.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.night.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.night.ForeColor = System.Drawing.Color.White
        Me.night.Location = New System.Drawing.Point(123, 3)
        Me.night.Name = "night"
        Me.night.Size = New System.Drawing.Size(54, 36)
        Me.night.TabIndex = 1
        Me.night.Text = "晚"
        Me.night.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.night.UseVisualStyleBackColor = False
        '
        'beforeSleep
        '
        Me.beforeSleep.Appearance = System.Windows.Forms.Appearance.Button
        Me.beforeSleep.AutoSize = True
        Me.beforeSleep.BackColor = System.Drawing.Color.SteelBlue
        Me.beforeSleep.Checked = True
        Me.beforeSleep.CheckState = System.Windows.Forms.CheckState.Checked
        Me.beforeSleep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.beforeSleep.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.beforeSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.beforeSleep.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.beforeSleep.ForeColor = System.Drawing.Color.White
        Me.beforeSleep.Location = New System.Drawing.Point(183, 3)
        Me.beforeSleep.Name = "beforeSleep"
        Me.beforeSleep.Size = New System.Drawing.Size(54, 36)
        Me.beforeSleep.TabIndex = 1
        Me.beforeSleep.Text = "睡前"
        Me.beforeSleep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.beforeSleep.UseVisualStyleBackColor = False
        '
        'beforeMeal
        '
        Me.beforeMeal.Appearance = System.Windows.Forms.Appearance.Button
        Me.beforeMeal.AutoSize = True
        Me.beforeMeal.BackColor = System.Drawing.SystemColors.HotTrack
        Me.beforeMeal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.beforeMeal.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.beforeMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.beforeMeal.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.beforeMeal.ForeColor = System.Drawing.Color.White
        Me.beforeMeal.Location = New System.Drawing.Point(3, 45)
        Me.beforeMeal.Name = "beforeMeal"
        Me.beforeMeal.Size = New System.Drawing.Size(54, 36)
        Me.beforeMeal.TabIndex = 1
        Me.beforeMeal.Text = "飯前"
        Me.beforeMeal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.beforeMeal.UseVisualStyleBackColor = False
        '
        'makePill
        '
        Me.makePill.Appearance = System.Windows.Forms.Appearance.Button
        Me.makePill.AutoSize = True
        Me.makePill.BackColor = System.Drawing.SystemColors.HotTrack
        Me.makePill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.makePill.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.makePill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.makePill.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.makePill.ForeColor = System.Drawing.Color.White
        Me.makePill.Location = New System.Drawing.Point(183, 45)
        Me.makePill.Name = "makePill"
        Me.makePill.Size = New System.Drawing.Size(54, 36)
        Me.makePill.TabIndex = 1
        Me.makePill.Text = "打錠"
        Me.makePill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.makePill.UseVisualStyleBackColor = False
        '
        'notWell
        '
        Me.notWell.Appearance = System.Windows.Forms.Appearance.Button
        Me.notWell.AutoSize = True
        Me.notWell.BackColor = System.Drawing.Color.CornflowerBlue
        Me.notWell.Dock = System.Windows.Forms.DockStyle.Fill
        Me.notWell.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.notWell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.notWell.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.notWell.ForeColor = System.Drawing.Color.Transparent
        Me.notWell.Location = New System.Drawing.Point(243, 3)
        Me.notWell.Name = "notWell"
        Me.notWell.Size = New System.Drawing.Size(57, 36)
        Me.notWell.TabIndex = 1
        Me.notWell.Text = "不適"
        Me.notWell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.notWell.UseVisualStyleBackColor = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 124)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(54, 40)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "天數"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'medGroupDays
        '
        Me.medGroupDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.medGroupDays, 3)
        '
        '
        '
        Me.medGroupDays.CustomButton.Image = Nothing
        Me.medGroupDays.CustomButton.Location = New System.Drawing.Point(146, 2)
        Me.medGroupDays.CustomButton.Name = ""
        Me.medGroupDays.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.medGroupDays.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.medGroupDays.CustomButton.TabIndex = 1
        Me.medGroupDays.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.medGroupDays.CustomButton.UseSelectable = True
        Me.medGroupDays.CustomButton.Visible = False
        Me.medGroupDays.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.medGroupDays.Lines = New String() {"14"}
        Me.medGroupDays.Location = New System.Drawing.Point(63, 129)
        Me.medGroupDays.MaxLength = 32767
        Me.medGroupDays.Name = "medGroupDays"
        Me.medGroupDays.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medGroupDays.PromptText = "天數"
        Me.medGroupDays.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.medGroupDays.SelectedText = ""
        Me.medGroupDays.SelectionLength = 0
        Me.medGroupDays.SelectionStart = 0
        Me.medGroupDays.ShortcutsEnabled = True
        Me.medGroupDays.Size = New System.Drawing.Size(174, 30)
        Me.medGroupDays.TabIndex = 5
        Me.medGroupDays.Text = "14"
        Me.medGroupDays.UseSelectable = True
        Me.medGroupDays.WaterMark = "天數"
        Me.medGroupDays.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.medGroupDays.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'medGroupChange
        '
        Me.medGroupChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medGroupChange.Location = New System.Drawing.Point(243, 127)
        Me.medGroupChange.Name = "medGroupChange"
        Me.medGroupChange.Size = New System.Drawing.Size(57, 34)
        Me.medGroupChange.TabIndex = 6
        Me.medGroupChange.Text = "變更"
        Me.medGroupChange.UseSelectable = True
        '
        'medGroupUnit
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.medGroupUnit, 2)
        Me.medGroupUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medGroupUnit.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.medGroupUnit.FormattingEnabled = True
        Me.medGroupUnit.ItemHeight = 29
        Me.medGroupUnit.Location = New System.Drawing.Point(183, 87)
        Me.medGroupUnit.Name = "medGroupUnit"
        Me.medGroupUnit.Size = New System.Drawing.Size(117, 35)
        Me.medGroupUnit.TabIndex = 9
        Me.medGroupUnit.UseSelectable = True
        '
        'medDetailPanel
        '
        Me.medDetailPanel.BackColor = System.Drawing.Color.DimGray
        Me.medDetailPanel.Controls.Add(Me.delMedDetail)
        Me.medDetailPanel.Controls.Add(Me.addMedDetail)
        Me.medDetailPanel.Controls.Add(Me.TableLayoutPanel4)
        Me.medDetailPanel.Controls.Add(Me.medDetailLabel)
        Me.medDetailPanel.Controls.Add(Me.medDetailGrid)
        Me.medDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medDetailPanel.HorizontalScrollbarBarColor = True
        Me.medDetailPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.medDetailPanel.HorizontalScrollbarSize = 10
        Me.medDetailPanel.Location = New System.Drawing.Point(332, 3)
        Me.medDetailPanel.Name = "medDetailPanel"
        Me.medDetailPanel.Padding = New System.Windows.Forms.Padding(10, 50, 10, 50)
        Me.medDetailPanel.Size = New System.Drawing.Size(324, 671)
        Me.medDetailPanel.TabIndex = 12
        Me.medDetailPanel.UseCustomBackColor = True
        Me.medDetailPanel.VerticalScrollbarBarColor = True
        Me.medDetailPanel.VerticalScrollbarHighlightOnWheel = False
        Me.medDetailPanel.VerticalScrollbarSize = 10
        '
        'delMedDetail
        '
        Me.delMedDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delMedDetail.Location = New System.Drawing.Point(293, 20)
        Me.delMedDetail.Name = "delMedDetail"
        Me.delMedDetail.Size = New System.Drawing.Size(21, 24)
        Me.delMedDetail.TabIndex = 15
        Me.delMedDetail.Text = "-"
        Me.delMedDetail.UseSelectable = True
        '
        'addMedDetail
        '
        Me.addMedDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addMedDetail.Location = New System.Drawing.Point(266, 20)
        Me.addMedDetail.Name = "addMedDetail"
        Me.addMedDetail.Size = New System.Drawing.Size(21, 24)
        Me.addMedDetail.TabIndex = 15
        Me.addMedDetail.Text = "+"
        Me.addMedDetail.UseSelectable = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.MetroLabel3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.medDetailAmount, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.medDetailChange, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.medDetailUnit, 2, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(10, 627)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(304, 37)
        Me.TableLayoutPanel4.TabIndex = 13
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.ForeColor = System.Drawing.Color.White
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(74, 40)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "份量"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'medDetailAmount
        '
        Me.medDetailAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.medDetailAmount.CustomButton.Image = Nothing
        Me.medDetailAmount.CustomButton.Location = New System.Drawing.Point(55, 2)
        Me.medDetailAmount.CustomButton.Name = ""
        Me.medDetailAmount.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.medDetailAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.medDetailAmount.CustomButton.TabIndex = 1
        Me.medDetailAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.medDetailAmount.CustomButton.UseSelectable = True
        Me.medDetailAmount.CustomButton.Visible = False
        Me.medDetailAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.medDetailAmount.Lines = New String() {"14"}
        Me.medDetailAmount.Location = New System.Drawing.Point(83, 5)
        Me.medDetailAmount.MaxLength = 32767
        Me.medDetailAmount.Name = "medDetailAmount"
        Me.medDetailAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medDetailAmount.PromptText = "天數"
        Me.medDetailAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.medDetailAmount.SelectedText = ""
        Me.medDetailAmount.SelectionLength = 0
        Me.medDetailAmount.SelectionStart = 0
        Me.medDetailAmount.ShortcutsEnabled = True
        Me.medDetailAmount.Size = New System.Drawing.Size(83, 30)
        Me.medDetailAmount.TabIndex = 5
        Me.medDetailAmount.Text = "14"
        Me.medDetailAmount.UseSelectable = True
        Me.medDetailAmount.WaterMark = "天數"
        Me.medDetailAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.medDetailAmount.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'medDetailChange
        '
        Me.medDetailChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medDetailChange.Location = New System.Drawing.Point(261, 3)
        Me.medDetailChange.Name = "medDetailChange"
        Me.medDetailChange.Size = New System.Drawing.Size(40, 34)
        Me.medDetailChange.TabIndex = 6
        Me.medDetailChange.Text = "變更"
        Me.medDetailChange.UseSelectable = True
        '
        'medDetailUnit
        '
        Me.medDetailUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medDetailUnit.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.medDetailUnit.FormattingEnabled = True
        Me.medDetailUnit.ItemHeight = 29
        Me.medDetailUnit.Location = New System.Drawing.Point(172, 3)
        Me.medDetailUnit.Name = "medDetailUnit"
        Me.medDetailUnit.Size = New System.Drawing.Size(83, 35)
        Me.medDetailUnit.TabIndex = 9
        Me.medDetailUnit.UseSelectable = True
        '
        'medDetailLabel
        '
        Me.medDetailLabel.AutoSize = True
        Me.medDetailLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.medDetailLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.medDetailLabel.ForeColor = System.Drawing.Color.White
        Me.medDetailLabel.Location = New System.Drawing.Point(10, 22)
        Me.medDetailLabel.Name = "medDetailLabel"
        Me.medDetailLabel.Size = New System.Drawing.Size(92, 25)
        Me.medDetailLabel.TabIndex = 13
        Me.medDetailLabel.Text = "藥物清單"
        Me.medDetailLabel.UseCustomBackColor = True
        Me.medDetailLabel.UseCustomForeColor = True
        '
        'medDetailGrid
        '
        Me.medDetailGrid.AllowUserToAddRows = False
        Me.medDetailGrid.AllowUserToDeleteRows = False
        Me.medDetailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.medDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.medDetailGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medDetailGrid.Location = New System.Drawing.Point(10, 50)
        Me.medDetailGrid.MultiSelect = False
        Me.medDetailGrid.Name = "medDetailGrid"
        Me.medDetailGrid.ReadOnly = True
        Me.medDetailGrid.RowTemplate.Height = 24
        Me.medDetailGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.medDetailGrid.Size = New System.Drawing.Size(304, 571)
        Me.medDetailGrid.TabIndex = 2
        '
        'pnlPerscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Name = "pnlPerscription"
        Me.Size = New System.Drawing.Size(1273, 725)
        Me.pInfoPanel.ResumeLayout(False)
        Me.patientTab.ResumeLayout(False)
        Me.tabPatientInfo.ResumeLayout(False)
        Me.pInfoTable.ResumeLayout(False)
        Me.tabBooking.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.searchTable.ResumeLayout(False)
        Me.searchTable.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabMedSetup.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.medGroupGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.medDetailPanel.ResumeLayout(False)
        Me.medDetailPanel.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.medDetailGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents searchTable As TableLayoutPanel
    Friend WithEvents searchBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents unusedMedList As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents medTree As TreeView
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents F0 As CheckBox
    Friend WithEvents afterMeal As CheckBox
    Friend WithEvents morning As CheckBox
    Friend WithEvents noon As CheckBox
    Friend WithEvents night As CheckBox
    Friend WithEvents beforeSleep As CheckBox
    Friend WithEvents beforeMeal As CheckBox
    Friend WithEvents makePill As CheckBox
    Friend WithEvents notWell As CheckBox
    Friend WithEvents medGroupLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents medGroupDays As MetroFramework.Controls.MetroTextBox
    Friend WithEvents medGroupChange As MetroFramework.Controls.MetroButton
    Friend WithEvents medGroupGrid As DataGridView
    Friend WithEvents medDetailPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents medDetailAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents medDetailChange As MetroFramework.Controls.MetroButton
    Friend WithEvents medDetailUnit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents medDetailLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents medDetailGrid As DataGridView
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents medGroupAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents medGroupUnit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabMedSetup As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents delMedGroup As MetroFramework.Controls.MetroButton
    Friend WithEvents addMedGroup As MetroFramework.Controls.MetroButton
    Friend WithEvents delMedDetail As MetroFramework.Controls.MetroButton
    Friend WithEvents addMedDetail As MetroFramework.Controls.MetroButton
End Class
