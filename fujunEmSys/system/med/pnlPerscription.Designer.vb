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
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.unusedMedList = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.searchTable = New System.Windows.Forms.TableLayoutPanel()
        Me.medTree = New System.Windows.Forms.TreeView()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.medGroupGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.pInfoPanel.SuspendLayout()
        Me.patientTab.SuspendLayout()
        Me.tabPatientInfo.SuspendLayout()
        Me.pInfoTable.SuspendLayout()
        Me.tabBooking.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.searchTable.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.medGroupGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel2.SetRowSpan(Me.pInfoPanel, 2)
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
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pInfoPanel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroPanel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1273, 725)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.searchTable)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(303, 3)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(10, 50, 10, 10)
        Me.TableLayoutPanel2.SetRowSpan(Me.MetroPanel2, 2)
        Me.MetroPanel2.Size = New System.Drawing.Size(334, 719)
        Me.MetroPanel2.TabIndex = 8
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.MetroPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.MetroPanel3, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(643, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel2.SetRowSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(310, 719)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'MetroButton1
        '
        Me.MetroButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroButton1.Location = New System.Drawing.Point(237, 582)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(74, 34)
        Me.MetroButton1.TabIndex = 6
        Me.MetroButton1.Text = "搜尋"
        Me.MetroButton1.UseSelectable = True
        '
        'unusedMedList
        '
        Me.unusedMedList.AutoSize = True
        Me.searchTable.SetColumnSpan(Me.unusedMedList, 2)
        Me.unusedMedList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unusedMedList.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.unusedMedList.Location = New System.Drawing.Point(3, 622)
        Me.unusedMedList.Name = "unusedMedList"
        Me.unusedMedList.Size = New System.Drawing.Size(308, 34)
        Me.unusedMedList.TabIndex = 3
        Me.unusedMedList.Text = "顯示未分類藥品"
        Me.unusedMedList.UseSelectable = True
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(196, 2)
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
        Me.MetroTextBox2.Location = New System.Drawing.Point(3, 582)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.PromptText = "快速搜尋"
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(228, 34)
        Me.MetroTextBox2.TabIndex = 5
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMark = "快速搜尋"
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'searchTable
        '
        Me.searchTable.ColumnCount = 2
        Me.searchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.searchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.searchTable.Controls.Add(Me.MetroTextBox2, 0, 1)
        Me.searchTable.Controls.Add(Me.unusedMedList, 0, 2)
        Me.searchTable.Controls.Add(Me.MetroButton1, 1, 1)
        Me.searchTable.Controls.Add(Me.medTree, 0, 0)
        Me.searchTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchTable.Location = New System.Drawing.Point(10, 50)
        Me.searchTable.Name = "searchTable"
        Me.searchTable.RowCount = 3
        Me.searchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.searchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.searchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.searchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.searchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.searchTable.Size = New System.Drawing.Size(314, 659)
        Me.searchTable.TabIndex = 7
        '
        'medTree
        '
        Me.searchTable.SetColumnSpan(Me.medTree, 2)
        Me.medTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medTree.Location = New System.Drawing.Point(3, 3)
        Me.medTree.Name = "medTree"
        Me.medTree.Size = New System.Drawing.Size(308, 573)
        Me.medTree.TabIndex = 12
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.DarkCyan
        Me.MetroPanel1.Controls.Add(Me.medGroupGrid)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Padding = New System.Windows.Forms.Padding(10, 50, 10, 140)
        Me.MetroPanel1.Size = New System.Drawing.Size(304, 353)
        Me.MetroPanel1.TabIndex = 12
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BackColor = System.Drawing.Color.DimGray
        Me.MetroPanel3.Controls.Add(Me.DataGridView2)
        Me.MetroPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(3, 362)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Padding = New System.Windows.Forms.Padding(10, 50, 10, 50)
        Me.MetroPanel3.Size = New System.Drawing.Size(304, 354)
        Me.MetroPanel3.TabIndex = 12
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
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
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox9, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox8, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox6, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox7, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroTextBox3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroButton2, 4, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 219)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 123)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'CheckBox9
        '
        Me.CheckBox9.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.BackColor = System.Drawing.SystemColors.HotTrack
        Me.CheckBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox9.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox9.ForeColor = System.Drawing.Color.White
        Me.CheckBox9.Location = New System.Drawing.Point(227, 44)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(54, 35)
        Me.CheckBox9.TabIndex = 3
        Me.CheckBox9.Text = "F-0"
        Me.CheckBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox9.UseVisualStyleBackColor = False
        '
        'CheckBox8
        '
        Me.CheckBox8.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.CheckBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox8.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox8.ForeColor = System.Drawing.Color.White
        Me.CheckBox8.Location = New System.Drawing.Point(59, 44)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(50, 35)
        Me.CheckBox8.TabIndex = 2
        Me.CheckBox8.Text = "飯後"
        Me.CheckBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox8.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(3, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(50, 35)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "早"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.CheckBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(59, 3)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(50, 35)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "中"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.SteelBlue
        Me.CheckBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(115, 3)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(50, 35)
        Me.CheckBox3.TabIndex = 1
        Me.CheckBox3.Text = "晚"
        Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox4
        '
        Me.CheckBox4.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.BackColor = System.Drawing.Color.SteelBlue
        Me.CheckBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox4.ForeColor = System.Drawing.Color.White
        Me.CheckBox4.Location = New System.Drawing.Point(171, 3)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(50, 35)
        Me.CheckBox4.TabIndex = 1
        Me.CheckBox4.Text = "睡前"
        Me.CheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'CheckBox5
        '
        Me.CheckBox5.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.CheckBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.Color.White
        Me.CheckBox5.Location = New System.Drawing.Point(3, 44)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(50, 35)
        Me.CheckBox5.TabIndex = 1
        Me.CheckBox5.Text = "飯前"
        Me.CheckBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'CheckBox6
        '
        Me.CheckBox6.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.CheckBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox6.ForeColor = System.Drawing.Color.White
        Me.CheckBox6.Location = New System.Drawing.Point(171, 44)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(50, 35)
        Me.CheckBox6.TabIndex = 1
        Me.CheckBox6.Text = "打碇"
        Me.CheckBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox6.UseVisualStyleBackColor = False
        '
        'CheckBox7
        '
        Me.CheckBox7.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CheckBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox7.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox7.ForeColor = System.Drawing.Color.Transparent
        Me.CheckBox7.Location = New System.Drawing.Point(227, 3)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(54, 35)
        Me.CheckBox7.TabIndex = 1
        Me.CheckBox7.Text = "不適"
        Me.CheckBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 82)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(50, 41)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "天數"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'MetroTextBox3
        '
        Me.MetroTextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.MetroTextBox3, 3)
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = Nothing
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(134, 2)
        Me.MetroTextBox3.CustomButton.Name = ""
        Me.MetroTextBox3.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MetroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.CustomButton.TabIndex = 1
        Me.MetroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.CustomButton.UseSelectable = True
        Me.MetroTextBox3.CustomButton.Visible = False
        Me.MetroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox3.Lines = New String() {"14"}
        Me.MetroTextBox3.Location = New System.Drawing.Point(59, 87)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.PromptText = "天數"
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.ShortcutsEnabled = True
        Me.MetroTextBox3.Size = New System.Drawing.Size(162, 30)
        Me.MetroTextBox3.TabIndex = 5
        Me.MetroTextBox3.Text = "14"
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMark = "天數"
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroButton2
        '
        Me.MetroButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroButton2.Location = New System.Drawing.Point(227, 85)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(54, 35)
        Me.MetroButton2.TabIndex = 6
        Me.MetroButton2.Text = "變更"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.ForeColor = System.Drawing.Color.White
        Me.MetroLabel2.Location = New System.Drawing.Point(10, 22)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(92, 25)
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "藥物群組"
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'medGroupGrid
        '
        Me.medGroupGrid.AllowUserToAddRows = False
        Me.medGroupGrid.AllowUserToDeleteRows = False
        Me.medGroupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.medGroupGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medGroupGrid.Location = New System.Drawing.Point(10, 50)
        Me.medGroupGrid.Name = "medGroupGrid"
        Me.medGroupGrid.ReadOnly = True
        Me.medGroupGrid.RowTemplate.Height = 24
        Me.medGroupGrid.Size = New System.Drawing.Size(284, 163)
        Me.medGroupGrid.TabIndex = 14
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(10, 50)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(284, 254)
        Me.DataGridView2.TabIndex = 2
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
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.searchTable.ResumeLayout(False)
        Me.searchTable.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.medGroupGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents unusedMedList As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents medTree As TreeView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents medGroupGrid As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
End Class
