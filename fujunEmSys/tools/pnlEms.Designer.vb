<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pnlEms
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlEms))
        Me.InstantDoCtrl1 = New Automation.BDaq.InstantDoCtrl(Me.components)
        Me.emsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pInfoPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.diagTab = New MetroFramework.Controls.MetroTabControl()
        Me.tabGraph = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.diagPanel = New System.Windows.Forms.Panel()
        Me.buttonPanel = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.buttonTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rdoEnergy = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rdoUpLeft = New System.Windows.Forms.CheckBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.rdoUpRight = New System.Windows.Forms.CheckBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.rdoDownLeft = New System.Windows.Forms.CheckBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.rdoDownRight = New System.Windows.Forms.CheckBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.rdoS2 = New System.Windows.Forms.CheckBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.rdoS1 = New System.Windows.Forms.CheckBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.rdoFoot = New System.Windows.Forms.CheckBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.rdoHand = New System.Windows.Forms.CheckBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.rdoRight = New System.Windows.Forms.CheckBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.rdoLeft = New System.Windows.Forms.CheckBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.rdoF1 = New System.Windows.Forms.CheckBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.rdoF2 = New System.Windows.Forms.CheckBox()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.rdoF3 = New System.Windows.Forms.CheckBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.rdoF4 = New System.Windows.Forms.CheckBox()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.rdoF5 = New System.Windows.Forms.CheckBox()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.rdoStone = New System.Windows.Forms.CheckBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.rdoC6 = New System.Windows.Forms.CheckBox()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.rdoC5 = New System.Windows.Forms.CheckBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.rdoC4 = New System.Windows.Forms.CheckBox()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.rdoC3 = New System.Windows.Forms.CheckBox()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.rdoC2 = New System.Windows.Forms.CheckBox()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.rdoC1 = New System.Windows.Forms.CheckBox()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.rdoGraph = New System.Windows.Forms.CheckBox()
        Me.measurePoint = New MetroFramework.Controls.MetroLabel()
        Me.openPanelLink = New MetroFramework.Controls.MetroLink()
        Me.graphTab = New MetroFramework.Controls.MetroTabControl()
        Me.tabEms = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ptBox = New System.Windows.Forms.ComboBox()
        Me.txtEvaValue = New System.Windows.Forms.TextBox()
        Me.txtMaxValue = New System.Windows.Forms.TextBox()
        Me.txtDevValue = New System.Windows.Forms.TextBox()
        Me.tabEnergy = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.tabCheck = New System.Windows.Forms.TabPage()
        Me.caliTable = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFixDevPoint = New MetroFramework.Controls.MetroTextBox()
        Me.txtFullValue = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrevsDev = New MetroFramework.Controls.MetroTextBox()
        Me.txtOffsetValue = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.btnRevise = New System.Windows.Forms.Button()
        Me.btnTrigger = New System.Windows.Forms.Button()
        Me.lblCali = New MetroFramework.Controls.MetroLabel()
        Me.tabMed = New System.Windows.Forms.TabPage()
        Me.InstantAiCtrl1 = New Automation.BDaq.InstantAiCtrl(Me.components)
        Me.okLink = New MetroFramework.Controls.MetroLink()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.pInfoPanel.SuspendLayout()
        Me.pInfoTable.SuspendLayout()
        Me.diagTab.SuspendLayout()
        Me.tabGraph.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.diagPanel.SuspendLayout()
        Me.buttonPanel.SuspendLayout()
        Me.buttonTable.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.graphTab.SuspendLayout()
        Me.tabEms.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tabEnergy.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tabCheck.SuspendLayout()
        Me.caliTable.SuspendLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.ClientSize = New System.Drawing.Size(0, 0)
        Me.owner.Location = New System.Drawing.Point(-32000, -32000)
        Me.owner.WindowState = System.Windows.Forms.FormWindowState.Minimized
        '
        'InstantDoCtrl1
        '
        Me.InstantDoCtrl1._StateStream = CType(resources.GetObject("InstantDoCtrl1._StateStream"), Automation.BDaq.DeviceStateStreamer)
        '
        'emsTimer
        '
        '
        'pInfoPanel
        '
        Me.pInfoPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pInfoPanel.BackColor = System.Drawing.Color.SeaGreen
        Me.pInfoPanel.Controls.Add(Me.Label4)
        Me.pInfoPanel.Controls.Add(Me.pInfoTable)
        Me.pInfoPanel.Location = New System.Drawing.Point(931, 0)
        Me.pInfoPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.pInfoPanel.Name = "pInfoPanel"
        Me.pInfoPanel.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
        Me.pInfoPanel.Size = New System.Drawing.Size(280, 713)
        Me.pInfoPanel.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "病患資料"
        '
        'pInfoTable
        '
        Me.pInfoTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.pInfoTable.Location = New System.Drawing.Point(23, 63)
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
        Me.pInfoTable.Size = New System.Drawing.Size(240, 627)
        Me.pInfoTable.TabIndex = 1
        '
        'MetroLink1
        '
        Me.MetroLink1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink1.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink1.Location = New System.Drawing.Point(3, 403)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(234, 34)
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
        Me.sexLabel.Size = New System.Drawing.Size(234, 34)
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
        Me.nameLabel.Size = New System.Drawing.Size(234, 34)
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
        Me.ageLabel.Size = New System.Drawing.Size(234, 34)
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
        Me.countLabel.Size = New System.Drawing.Size(234, 34)
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
        Me.lastVisitLabel.Size = New System.Drawing.Size(234, 34)
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
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(54, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(179, 179)
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
        Me.MetroTextBox1.Size = New System.Drawing.Size(234, 181)
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
        Me.pName.CustomButton.Location = New System.Drawing.Point(202, 2)
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
        Me.pName.Size = New System.Drawing.Size(234, 34)
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
        Me.pSex.CustomButton.Location = New System.Drawing.Point(202, 2)
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
        Me.pSex.Size = New System.Drawing.Size(234, 34)
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
        Me.pAge.CustomButton.Location = New System.Drawing.Point(202, 2)
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
        Me.pAge.Size = New System.Drawing.Size(234, 34)
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
        Me.pVisitTimes.CustomButton.Location = New System.Drawing.Point(202, 2)
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
        Me.pVisitTimes.Size = New System.Drawing.Size(234, 34)
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
        Me.pPrevVisit.CustomButton.Location = New System.Drawing.Point(202, 2)
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
        Me.pPrevVisit.Size = New System.Drawing.Size(234, 34)
        Me.pPrevVisit.TabIndex = 4
        Me.pPrevVisit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pPrevVisit.UseSelectable = True
        Me.pPrevVisit.WaterMark = "不顯示"
        Me.pPrevVisit.WaterMarkColor = System.Drawing.Color.Silver
        Me.pPrevVisit.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        '
        'diagTab
        '
        Me.diagTab.Controls.Add(Me.tabGraph)
        Me.diagTab.Controls.Add(Me.tabMed)
        Me.diagTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.diagTab.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.diagTab.Location = New System.Drawing.Point(0, 0)
        Me.diagTab.Name = "diagTab"
        Me.diagTab.SelectedIndex = 0
        Me.diagTab.Size = New System.Drawing.Size(931, 713)
        Me.diagTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.diagTab.TabIndex = 5
        Me.diagTab.UseSelectable = True
        '
        'tabGraph
        '
        Me.tabGraph.Controls.Add(Me.TableLayoutPanel1)
        Me.tabGraph.Location = New System.Drawing.Point(4, 44)
        Me.tabGraph.Name = "tabGraph"
        Me.tabGraph.Size = New System.Drawing.Size(923, 665)
        Me.tabGraph.TabIndex = 0
        Me.tabGraph.Text = "頻譜檢查"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.diagPanel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.graphTab, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(923, 665)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'diagPanel
        '
        Me.diagPanel.Controls.Add(Me.buttonPanel)
        Me.diagPanel.Controls.Add(Me.measurePoint)
        Me.diagPanel.Controls.Add(Me.openPanelLink)
        Me.diagPanel.Controls.Add(Me.pb)
        Me.diagPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.diagPanel.Location = New System.Drawing.Point(300, 0)
        Me.diagPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.diagPanel.Name = "diagPanel"
        Me.diagPanel.Padding = New System.Windows.Forms.Padding(20, 60, 20, 60)
        Me.diagPanel.Size = New System.Drawing.Size(623, 665)
        Me.diagPanel.TabIndex = 1
        '
        'buttonPanel
        '
        Me.buttonPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPanel.Controls.Add(Me.MetroLabel5)
        Me.buttonPanel.Controls.Add(Me.okLink)
        Me.buttonPanel.Controls.Add(Me.buttonTable)
        Me.buttonPanel.HorizontalScrollbarBarColor = True
        Me.buttonPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.buttonPanel.HorizontalScrollbarSize = 10
        Me.buttonPanel.Location = New System.Drawing.Point(0, 306)
        Me.buttonPanel.Name = "buttonPanel"
        Me.buttonPanel.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
        Me.buttonPanel.Size = New System.Drawing.Size(623, 359)
        Me.buttonPanel.TabIndex = 1
        Me.buttonPanel.VerticalScrollbarBarColor = True
        Me.buttonPanel.VerticalScrollbarHighlightOnWheel = False
        Me.buttonPanel.VerticalScrollbarSize = 10
        Me.buttonPanel.Visible = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 24)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(112, 25)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "手動量測點"
        '
        'buttonTable
        '
        Me.buttonTable.ColumnCount = 6
        Me.buttonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.buttonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.buttonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.buttonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.buttonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.buttonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.buttonTable.Controls.Add(Me.Panel5, 4, 0)
        Me.buttonTable.Controls.Add(Me.Panel4, 0, 0)
        Me.buttonTable.Controls.Add(Me.Panel6, 1, 0)
        Me.buttonTable.Controls.Add(Me.Panel7, 2, 0)
        Me.buttonTable.Controls.Add(Me.Panel8, 3, 0)
        Me.buttonTable.Controls.Add(Me.Panel9, 5, 1)
        Me.buttonTable.Controls.Add(Me.Panel10, 4, 1)
        Me.buttonTable.Controls.Add(Me.Panel11, 3, 1)
        Me.buttonTable.Controls.Add(Me.Panel12, 2, 1)
        Me.buttonTable.Controls.Add(Me.Panel13, 1, 1)
        Me.buttonTable.Controls.Add(Me.Panel14, 0, 1)
        Me.buttonTable.Controls.Add(Me.Panel15, 0, 2)
        Me.buttonTable.Controls.Add(Me.Panel16, 1, 2)
        Me.buttonTable.Controls.Add(Me.Panel17, 2, 2)
        Me.buttonTable.Controls.Add(Me.Panel18, 3, 2)
        Me.buttonTable.Controls.Add(Me.Panel19, 4, 2)
        Me.buttonTable.Controls.Add(Me.Panel20, 5, 2)
        Me.buttonTable.Controls.Add(Me.Panel21, 5, 3)
        Me.buttonTable.Controls.Add(Me.Panel22, 4, 3)
        Me.buttonTable.Controls.Add(Me.Panel23, 3, 3)
        Me.buttonTable.Controls.Add(Me.Panel24, 2, 3)
        Me.buttonTable.Controls.Add(Me.Panel25, 1, 3)
        Me.buttonTable.Controls.Add(Me.Panel26, 0, 3)
        Me.buttonTable.Controls.Add(Me.Panel27, 5, 0)
        Me.buttonTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonTable.Location = New System.Drawing.Point(20, 60)
        Me.buttonTable.Margin = New System.Windows.Forms.Padding(0)
        Me.buttonTable.Name = "buttonTable"
        Me.buttonTable.RowCount = 4
        Me.buttonTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.buttonTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.buttonTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.buttonTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.buttonTable.Size = New System.Drawing.Size(583, 279)
        Me.buttonTable.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Controls.Add(Me.rdoEnergy)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(388, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(97, 69)
        Me.Panel5.TabIndex = 4
        '
        'rdoEnergy
        '
        Me.rdoEnergy.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEnergy.AutoSize = True
        Me.rdoEnergy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoEnergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEnergy.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoEnergy.Location = New System.Drawing.Point(0, 0)
        Me.rdoEnergy.Name = "rdoEnergy"
        Me.rdoEnergy.Size = New System.Drawing.Size(97, 69)
        Me.rdoEnergy.TabIndex = 3
        Me.rdoEnergy.Text = "元氣"
        Me.rdoEnergy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoEnergy.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel4.Controls.Add(Me.rdoUpLeft)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(97, 69)
        Me.Panel4.TabIndex = 3
        '
        'rdoUpLeft
        '
        Me.rdoUpLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUpLeft.AutoSize = True
        Me.rdoUpLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoUpLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUpLeft.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoUpLeft.Location = New System.Drawing.Point(0, 0)
        Me.rdoUpLeft.Name = "rdoUpLeft"
        Me.rdoUpLeft.Size = New System.Drawing.Size(97, 69)
        Me.rdoUpLeft.TabIndex = 2
        Me.rdoUpLeft.Text = "左上"
        Me.rdoUpLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUpLeft.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel6.Controls.Add(Me.rdoUpRight)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(97, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(97, 69)
        Me.Panel6.TabIndex = 3
        '
        'rdoUpRight
        '
        Me.rdoUpRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUpRight.AutoSize = True
        Me.rdoUpRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoUpRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUpRight.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoUpRight.Location = New System.Drawing.Point(0, 0)
        Me.rdoUpRight.Name = "rdoUpRight"
        Me.rdoUpRight.Size = New System.Drawing.Size(97, 69)
        Me.rdoUpRight.TabIndex = 2
        Me.rdoUpRight.Text = "右上"
        Me.rdoUpRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUpRight.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel7.Controls.Add(Me.rdoDownLeft)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(194, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(97, 69)
        Me.Panel7.TabIndex = 3
        '
        'rdoDownLeft
        '
        Me.rdoDownLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDownLeft.AutoSize = True
        Me.rdoDownLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoDownLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDownLeft.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoDownLeft.Location = New System.Drawing.Point(0, 0)
        Me.rdoDownLeft.Name = "rdoDownLeft"
        Me.rdoDownLeft.Size = New System.Drawing.Size(97, 69)
        Me.rdoDownLeft.TabIndex = 2
        Me.rdoDownLeft.Text = "左下"
        Me.rdoDownLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDownLeft.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel8.Controls.Add(Me.rdoDownRight)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(291, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(97, 69)
        Me.Panel8.TabIndex = 3
        '
        'rdoDownRight
        '
        Me.rdoDownRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDownRight.AutoSize = True
        Me.rdoDownRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoDownRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDownRight.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoDownRight.Location = New System.Drawing.Point(0, 0)
        Me.rdoDownRight.Name = "rdoDownRight"
        Me.rdoDownRight.Size = New System.Drawing.Size(97, 69)
        Me.rdoDownRight.TabIndex = 2
        Me.rdoDownRight.Text = "右下"
        Me.rdoDownRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDownRight.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Peru
        Me.Panel9.Controls.Add(Me.rdoS2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(485, 69)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(98, 69)
        Me.Panel9.TabIndex = 3
        '
        'rdoS2
        '
        Me.rdoS2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoS2.AutoSize = True
        Me.rdoS2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoS2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoS2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoS2.Location = New System.Drawing.Point(0, 0)
        Me.rdoS2.Name = "rdoS2"
        Me.rdoS2.Size = New System.Drawing.Size(98, 69)
        Me.rdoS2.TabIndex = 2
        Me.rdoS2.Text = "外"
        Me.rdoS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoS2.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Peru
        Me.Panel10.Controls.Add(Me.rdoS1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(388, 69)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(97, 69)
        Me.Panel10.TabIndex = 3
        '
        'rdoS1
        '
        Me.rdoS1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoS1.AutoSize = True
        Me.rdoS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoS1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoS1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoS1.Location = New System.Drawing.Point(0, 0)
        Me.rdoS1.Name = "rdoS1"
        Me.rdoS1.Size = New System.Drawing.Size(97, 69)
        Me.rdoS1.TabIndex = 2
        Me.rdoS1.Text = "內"
        Me.rdoS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoS1.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel11.Controls.Add(Me.rdoFoot)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(291, 69)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(97, 69)
        Me.Panel11.TabIndex = 3
        '
        'rdoFoot
        '
        Me.rdoFoot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFoot.AutoSize = True
        Me.rdoFoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoFoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFoot.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoFoot.Location = New System.Drawing.Point(0, 0)
        Me.rdoFoot.Name = "rdoFoot"
        Me.rdoFoot.Size = New System.Drawing.Size(97, 69)
        Me.rdoFoot.TabIndex = 2
        Me.rdoFoot.Text = "腳"
        Me.rdoFoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFoot.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel12.Controls.Add(Me.rdoHand)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(194, 69)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(97, 69)
        Me.Panel12.TabIndex = 3
        '
        'rdoHand
        '
        Me.rdoHand.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHand.AutoSize = True
        Me.rdoHand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoHand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHand.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoHand.Location = New System.Drawing.Point(0, 0)
        Me.rdoHand.Name = "rdoHand"
        Me.rdoHand.Size = New System.Drawing.Size(97, 69)
        Me.rdoHand.TabIndex = 2
        Me.rdoHand.Text = "手"
        Me.rdoHand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHand.UseVisualStyleBackColor = True
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel13.Controls.Add(Me.rdoRight)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(97, 69)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(97, 69)
        Me.Panel13.TabIndex = 3
        '
        'rdoRight
        '
        Me.rdoRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRight.AutoSize = True
        Me.rdoRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRight.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoRight.Location = New System.Drawing.Point(0, 0)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(97, 69)
        Me.rdoRight.TabIndex = 2
        Me.rdoRight.Text = "右"
        Me.rdoRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel14.Controls.Add(Me.rdoLeft)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 69)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(97, 69)
        Me.Panel14.TabIndex = 3
        '
        'rdoLeft
        '
        Me.rdoLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLeft.AutoSize = True
        Me.rdoLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLeft.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoLeft.Location = New System.Drawing.Point(0, 0)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(97, 69)
        Me.rdoLeft.TabIndex = 2
        Me.rdoLeft.Text = "左"
        Me.rdoLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Wheat
        Me.Panel15.Controls.Add(Me.rdoF1)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(0, 138)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(97, 69)
        Me.Panel15.TabIndex = 3
        '
        'rdoF1
        '
        Me.rdoF1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoF1.AutoSize = True
        Me.rdoF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoF1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoF1.Location = New System.Drawing.Point(0, 0)
        Me.rdoF1.Name = "rdoF1"
        Me.rdoF1.Size = New System.Drawing.Size(97, 69)
        Me.rdoF1.TabIndex = 2
        Me.rdoF1.Text = "拇指"
        Me.rdoF1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoF1.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.Wheat
        Me.Panel16.Controls.Add(Me.rdoF2)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(97, 138)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(97, 69)
        Me.Panel16.TabIndex = 3
        '
        'rdoF2
        '
        Me.rdoF2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoF2.AutoSize = True
        Me.rdoF2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoF2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoF2.Location = New System.Drawing.Point(0, 0)
        Me.rdoF2.Name = "rdoF2"
        Me.rdoF2.Size = New System.Drawing.Size(97, 69)
        Me.rdoF2.TabIndex = 2
        Me.rdoF2.Text = "食指"
        Me.rdoF2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoF2.UseVisualStyleBackColor = True
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Wheat
        Me.Panel17.Controls.Add(Me.rdoF3)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel17.Location = New System.Drawing.Point(194, 138)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(97, 69)
        Me.Panel17.TabIndex = 3
        '
        'rdoF3
        '
        Me.rdoF3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoF3.AutoSize = True
        Me.rdoF3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoF3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoF3.Location = New System.Drawing.Point(0, 0)
        Me.rdoF3.Name = "rdoF3"
        Me.rdoF3.Size = New System.Drawing.Size(97, 69)
        Me.rdoF3.TabIndex = 2
        Me.rdoF3.Text = "中指"
        Me.rdoF3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoF3.UseVisualStyleBackColor = True
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.Wheat
        Me.Panel18.Controls.Add(Me.rdoF4)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel18.Location = New System.Drawing.Point(291, 138)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(97, 69)
        Me.Panel18.TabIndex = 3
        '
        'rdoF4
        '
        Me.rdoF4.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoF4.AutoSize = True
        Me.rdoF4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoF4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoF4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoF4.Location = New System.Drawing.Point(0, 0)
        Me.rdoF4.Name = "rdoF4"
        Me.rdoF4.Size = New System.Drawing.Size(97, 69)
        Me.rdoF4.TabIndex = 2
        Me.rdoF4.Text = "無名"
        Me.rdoF4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoF4.UseVisualStyleBackColor = True
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.Wheat
        Me.Panel19.Controls.Add(Me.rdoF5)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(388, 138)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(97, 69)
        Me.Panel19.TabIndex = 3
        '
        'rdoF5
        '
        Me.rdoF5.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoF5.AutoSize = True
        Me.rdoF5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoF5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoF5.Location = New System.Drawing.Point(0, 0)
        Me.rdoF5.Name = "rdoF5"
        Me.rdoF5.Size = New System.Drawing.Size(97, 69)
        Me.rdoF5.TabIndex = 2
        Me.rdoF5.Text = "小指"
        Me.rdoF5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoF5.UseVisualStyleBackColor = True
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel20.Controls.Add(Me.rdoStone)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel20.Location = New System.Drawing.Point(485, 138)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(98, 69)
        Me.Panel20.TabIndex = 3
        '
        'rdoStone
        '
        Me.rdoStone.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStone.AutoSize = True
        Me.rdoStone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoStone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStone.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoStone.Location = New System.Drawing.Point(0, 0)
        Me.rdoStone.Name = "rdoStone"
        Me.rdoStone.Size = New System.Drawing.Size(98, 69)
        Me.rdoStone.TabIndex = 2
        Me.rdoStone.Text = "結石"
        Me.rdoStone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStone.UseVisualStyleBackColor = True
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.Peru
        Me.Panel21.Controls.Add(Me.rdoC6)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(485, 207)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(98, 72)
        Me.Panel21.TabIndex = 3
        '
        'rdoC6
        '
        Me.rdoC6.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC6.AutoSize = True
        Me.rdoC6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoC6.Location = New System.Drawing.Point(0, 0)
        Me.rdoC6.Name = "rdoC6"
        Me.rdoC6.Size = New System.Drawing.Size(98, 72)
        Me.rdoC6.TabIndex = 2
        Me.rdoC6.Text = "下"
        Me.rdoC6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoC6.UseVisualStyleBackColor = True
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.Peru
        Me.Panel22.Controls.Add(Me.rdoC5)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel22.Location = New System.Drawing.Point(388, 207)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(97, 72)
        Me.Panel22.TabIndex = 3
        '
        'rdoC5
        '
        Me.rdoC5.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC5.AutoSize = True
        Me.rdoC5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoC5.Location = New System.Drawing.Point(0, 0)
        Me.rdoC5.Name = "rdoC5"
        Me.rdoC5.Size = New System.Drawing.Size(97, 72)
        Me.rdoC5.TabIndex = 2
        Me.rdoC5.Text = "總"
        Me.rdoC5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoC5.UseVisualStyleBackColor = True
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.Peru
        Me.Panel23.Controls.Add(Me.rdoC4)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel23.Location = New System.Drawing.Point(291, 207)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(97, 72)
        Me.Panel23.TabIndex = 3
        '
        'rdoC4
        '
        Me.rdoC4.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC4.AutoSize = True
        Me.rdoC4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoC4.Location = New System.Drawing.Point(0, 0)
        Me.rdoC4.Name = "rdoC4"
        Me.rdoC4.Size = New System.Drawing.Size(97, 72)
        Me.rdoC4.TabIndex = 2
        Me.rdoC4.Text = "中"
        Me.rdoC4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoC4.UseVisualStyleBackColor = True
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.Peru
        Me.Panel24.Controls.Add(Me.rdoC3)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel24.Location = New System.Drawing.Point(194, 207)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(97, 72)
        Me.Panel24.TabIndex = 3
        '
        'rdoC3
        '
        Me.rdoC3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC3.AutoSize = True
        Me.rdoC3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoC3.Location = New System.Drawing.Point(0, 0)
        Me.rdoC3.Name = "rdoC3"
        Me.rdoC3.Size = New System.Drawing.Size(97, 72)
        Me.rdoC3.TabIndex = 2
        Me.rdoC3.Text = "上"
        Me.rdoC3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoC3.UseVisualStyleBackColor = True
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.Peru
        Me.Panel25.Controls.Add(Me.rdoC2)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel25.Location = New System.Drawing.Point(97, 207)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(97, 72)
        Me.Panel25.TabIndex = 3
        '
        'rdoC2
        '
        Me.rdoC2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC2.AutoSize = True
        Me.rdoC2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoC2.Location = New System.Drawing.Point(0, 0)
        Me.rdoC2.Name = "rdoC2"
        Me.rdoC2.Size = New System.Drawing.Size(97, 72)
        Me.rdoC2.TabIndex = 2
        Me.rdoC2.Text = "頭"
        Me.rdoC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoC2.UseVisualStyleBackColor = True
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.Peru
        Me.Panel26.Controls.Add(Me.rdoC1)
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel26.Location = New System.Drawing.Point(0, 207)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(97, 72)
        Me.Panel26.TabIndex = 3
        '
        'rdoC1
        '
        Me.rdoC1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC1.AutoSize = True
        Me.rdoC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoC1.Location = New System.Drawing.Point(0, 0)
        Me.rdoC1.Name = "rdoC1"
        Me.rdoC1.Size = New System.Drawing.Size(97, 72)
        Me.rdoC1.TabIndex = 2
        Me.rdoC1.Text = "頂"
        Me.rdoC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoC1.UseVisualStyleBackColor = True
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel27.Controls.Add(Me.rdoGraph)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel27.Location = New System.Drawing.Point(485, 0)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(98, 69)
        Me.Panel27.TabIndex = 5
        '
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.AutoSize = True
        Me.rdoGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdoGraph.Location = New System.Drawing.Point(0, 0)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(98, 69)
        Me.rdoGraph.TabIndex = 3
        Me.rdoGraph.Text = "頻譜"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'measurePoint
        '
        Me.measurePoint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.measurePoint.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.measurePoint.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.measurePoint.Location = New System.Drawing.Point(20, 19)
        Me.measurePoint.Name = "measurePoint"
        Me.measurePoint.Size = New System.Drawing.Size(583, 29)
        Me.measurePoint.TabIndex = 3
        Me.measurePoint.Text = "量測點"
        Me.measurePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'openPanelLink
        '
        Me.openPanelLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.openPanelLink.Location = New System.Drawing.Point(255, 623)
        Me.openPanelLink.Name = "openPanelLink"
        Me.openPanelLink.Size = New System.Drawing.Size(112, 23)
        Me.openPanelLink.TabIndex = 2
        Me.openPanelLink.Text = "開啟手動測量點"
        Me.openPanelLink.UseSelectable = True
        '
        'graphTab
        '
        Me.graphTab.Controls.Add(Me.tabEms)
        Me.graphTab.Controls.Add(Me.tabEnergy)
        Me.graphTab.Controls.Add(Me.tabCheck)
        Me.graphTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graphTab.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.graphTab.HotTrack = True
        Me.graphTab.Location = New System.Drawing.Point(0, 0)
        Me.graphTab.Margin = New System.Windows.Forms.Padding(0)
        Me.graphTab.Multiline = True
        Me.graphTab.Name = "graphTab"
        Me.graphTab.SelectedIndex = 0
        Me.graphTab.Size = New System.Drawing.Size(300, 665)
        Me.graphTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.graphTab.TabIndex = 2
        Me.graphTab.UseSelectable = True
        '
        'tabEms
        '
        Me.tabEms.Controls.Add(Me.Panel1)
        Me.tabEms.Location = New System.Drawing.Point(4, 44)
        Me.tabEms.Name = "tabEms"
        Me.tabEms.Size = New System.Drawing.Size(292, 617)
        Me.tabEms.TabIndex = 0
        Me.tabEms.Text = "能量"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Peru
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel1.Size = New System.Drawing.Size(292, 617)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.ptBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEvaValue, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMaxValue, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDevValue, 0, 7)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(20, 20)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(252, 577)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("DFKai-SB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "量測點"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("DFKai-SB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(3, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 72)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "量測值"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("DFKai-SB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(3, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 72)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "最大值"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("DFKai-SB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(3, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(246, 72)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "偏差值"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ptBox
        '
        Me.ptBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ptBox.Font = New System.Drawing.Font("DFKai-SB", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ptBox.FormattingEnabled = True
        Me.ptBox.Items.AddRange(New Object() {"一二三四五六七"})
        Me.ptBox.Location = New System.Drawing.Point(3, 75)
        Me.ptBox.Name = "ptBox"
        Me.ptBox.Size = New System.Drawing.Size(246, 61)
        Me.ptBox.TabIndex = 4
        '
        'txtEvaValue
        '
        Me.txtEvaValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEvaValue.Font = New System.Drawing.Font("DFKai-SB", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtEvaValue.Location = New System.Drawing.Point(3, 219)
        Me.txtEvaValue.Name = "txtEvaValue"
        Me.txtEvaValue.Size = New System.Drawing.Size(246, 71)
        Me.txtEvaValue.TabIndex = 5
        Me.txtEvaValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaxValue
        '
        Me.txtMaxValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMaxValue.Font = New System.Drawing.Font("DFKai-SB", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtMaxValue.Location = New System.Drawing.Point(3, 363)
        Me.txtMaxValue.Name = "txtMaxValue"
        Me.txtMaxValue.Size = New System.Drawing.Size(246, 71)
        Me.txtMaxValue.TabIndex = 5
        Me.txtMaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDevValue
        '
        Me.txtDevValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDevValue.Font = New System.Drawing.Font("DFKai-SB", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtDevValue.Location = New System.Drawing.Point(3, 507)
        Me.txtDevValue.Name = "txtDevValue"
        Me.txtDevValue.Size = New System.Drawing.Size(246, 71)
        Me.txtDevValue.TabIndex = 5
        Me.txtDevValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tabEnergy
        '
        Me.tabEnergy.Controls.Add(Me.Panel3)
        Me.tabEnergy.Location = New System.Drawing.Point(4, 44)
        Me.tabEnergy.Name = "tabEnergy"
        Me.tabEnergy.Size = New System.Drawing.Size(292, 617)
        Me.tabEnergy.TabIndex = 1
        Me.tabEnergy.Text = "元氣"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Peru
        Me.Panel3.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel3.Size = New System.Drawing.Size(292, 617)
        Me.Panel3.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(20, 20)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 8
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(252, 577)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'tabCheck
        '
        Me.tabCheck.Controls.Add(Me.caliTable)
        Me.tabCheck.Location = New System.Drawing.Point(4, 44)
        Me.tabCheck.Name = "tabCheck"
        Me.tabCheck.Size = New System.Drawing.Size(292, 617)
        Me.tabCheck.TabIndex = 2
        Me.tabCheck.Text = "儀器資訊"
        '
        'caliTable
        '
        Me.caliTable.ColumnCount = 2
        Me.caliTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.caliTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.caliTable.Controls.Add(Me.txtFixDevPoint, 1, 3)
        Me.caliTable.Controls.Add(Me.txtFullValue, 1, 0)
        Me.caliTable.Controls.Add(Me.txtPrevsDev, 1, 2)
        Me.caliTable.Controls.Add(Me.txtOffsetValue, 1, 1)
        Me.caliTable.Controls.Add(Me.MetroLabel1, 0, 0)
        Me.caliTable.Controls.Add(Me.MetroLabel2, 0, 1)
        Me.caliTable.Controls.Add(Me.MetroLabel3, 0, 2)
        Me.caliTable.Controls.Add(Me.MetroLabel4, 0, 3)
        Me.caliTable.Controls.Add(Me.btnRevise, 0, 4)
        Me.caliTable.Controls.Add(Me.btnTrigger, 0, 5)
        Me.caliTable.Controls.Add(Me.lblCali, 1, 4)
        Me.caliTable.Location = New System.Drawing.Point(0, 0)
        Me.caliTable.Name = "caliTable"
        Me.caliTable.RowCount = 6
        Me.caliTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.caliTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.caliTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.caliTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.caliTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.caliTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.caliTable.Size = New System.Drawing.Size(289, 245)
        Me.caliTable.TabIndex = 0
        '
        'txtFixDevPoint
        '
        '
        '
        '
        Me.txtFixDevPoint.CustomButton.Image = Nothing
        Me.txtFixDevPoint.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.txtFixDevPoint.CustomButton.Name = ""
        Me.txtFixDevPoint.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtFixDevPoint.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFixDevPoint.CustomButton.TabIndex = 1
        Me.txtFixDevPoint.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFixDevPoint.CustomButton.UseSelectable = True
        Me.txtFixDevPoint.CustomButton.Visible = False
        Me.txtFixDevPoint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFixDevPoint.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtFixDevPoint.Lines = New String(-1) {}
        Me.txtFixDevPoint.Location = New System.Drawing.Point(147, 108)
        Me.txtFixDevPoint.MaxLength = 32767
        Me.txtFixDevPoint.Name = "txtFixDevPoint"
        Me.txtFixDevPoint.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFixDevPoint.PromptText = "固定偏離點"
        Me.txtFixDevPoint.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFixDevPoint.SelectedText = ""
        Me.txtFixDevPoint.SelectionLength = 0
        Me.txtFixDevPoint.SelectionStart = 0
        Me.txtFixDevPoint.ShortcutsEnabled = True
        Me.txtFixDevPoint.Size = New System.Drawing.Size(139, 29)
        Me.txtFixDevPoint.TabIndex = 1
        Me.txtFixDevPoint.UseSelectable = True
        Me.txtFixDevPoint.WaterMark = "固定偏離點"
        Me.txtFixDevPoint.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFixDevPoint.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFullValue
        '
        '
        '
        '
        Me.txtFullValue.CustomButton.Image = Nothing
        Me.txtFullValue.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.txtFullValue.CustomButton.Name = ""
        Me.txtFullValue.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtFullValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFullValue.CustomButton.TabIndex = 1
        Me.txtFullValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFullValue.CustomButton.UseSelectable = True
        Me.txtFullValue.CustomButton.Visible = False
        Me.txtFullValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFullValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtFullValue.Lines = New String(-1) {}
        Me.txtFullValue.Location = New System.Drawing.Point(147, 3)
        Me.txtFullValue.MaxLength = 32767
        Me.txtFullValue.Name = "txtFullValue"
        Me.txtFullValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFullValue.PromptText = "滿刻度"
        Me.txtFullValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFullValue.SelectedText = ""
        Me.txtFullValue.SelectionLength = 0
        Me.txtFullValue.SelectionStart = 0
        Me.txtFullValue.ShortcutsEnabled = True
        Me.txtFullValue.Size = New System.Drawing.Size(139, 29)
        Me.txtFullValue.TabIndex = 4
        Me.txtFullValue.UseSelectable = True
        Me.txtFullValue.WaterMark = "滿刻度"
        Me.txtFullValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFullValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrevsDev
        '
        '
        '
        '
        Me.txtPrevsDev.CustomButton.Image = Nothing
        Me.txtPrevsDev.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.txtPrevsDev.CustomButton.Name = ""
        Me.txtPrevsDev.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPrevsDev.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrevsDev.CustomButton.TabIndex = 1
        Me.txtPrevsDev.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrevsDev.CustomButton.UseSelectable = True
        Me.txtPrevsDev.CustomButton.Visible = False
        Me.txtPrevsDev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrevsDev.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPrevsDev.Lines = New String(-1) {}
        Me.txtPrevsDev.Location = New System.Drawing.Point(147, 73)
        Me.txtPrevsDev.MaxLength = 32767
        Me.txtPrevsDev.Name = "txtPrevsDev"
        Me.txtPrevsDev.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrevsDev.PromptText = "前偏離點"
        Me.txtPrevsDev.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrevsDev.SelectedText = ""
        Me.txtPrevsDev.SelectionLength = 0
        Me.txtPrevsDev.SelectionStart = 0
        Me.txtPrevsDev.ShortcutsEnabled = True
        Me.txtPrevsDev.Size = New System.Drawing.Size(139, 29)
        Me.txtPrevsDev.TabIndex = 2
        Me.txtPrevsDev.UseSelectable = True
        Me.txtPrevsDev.WaterMark = "前偏離點"
        Me.txtPrevsDev.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrevsDev.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtOffsetValue
        '
        '
        '
        '
        Me.txtOffsetValue.CustomButton.Image = Nothing
        Me.txtOffsetValue.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.txtOffsetValue.CustomButton.Name = ""
        Me.txtOffsetValue.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtOffsetValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOffsetValue.CustomButton.TabIndex = 1
        Me.txtOffsetValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOffsetValue.CustomButton.UseSelectable = True
        Me.txtOffsetValue.CustomButton.Visible = False
        Me.txtOffsetValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOffsetValue.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtOffsetValue.Lines = New String(-1) {}
        Me.txtOffsetValue.Location = New System.Drawing.Point(147, 38)
        Me.txtOffsetValue.MaxLength = 32767
        Me.txtOffsetValue.Name = "txtOffsetValue"
        Me.txtOffsetValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOffsetValue.PromptText = "偏離度"
        Me.txtOffsetValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOffsetValue.SelectedText = ""
        Me.txtOffsetValue.SelectionLength = 0
        Me.txtOffsetValue.SelectionStart = 0
        Me.txtOffsetValue.ShortcutsEnabled = True
        Me.txtOffsetValue.Size = New System.Drawing.Size(139, 29)
        Me.txtOffsetValue.TabIndex = 3
        Me.txtOffsetValue.UseSelectable = True
        Me.txtOffsetValue.WaterMark = "偏離度"
        Me.txtOffsetValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOffsetValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(138, 35)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "滿刻度"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 35)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(138, 35)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "偏離度"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 70)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(138, 35)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "前偏離點"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 105)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(138, 35)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "固定偏離點"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRevise
        '
        Me.btnRevise.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRevise.Location = New System.Drawing.Point(3, 143)
        Me.btnRevise.Name = "btnRevise"
        Me.btnRevise.Size = New System.Drawing.Size(138, 30)
        Me.btnRevise.TabIndex = 6
        Me.btnRevise.Text = "校正"
        Me.btnRevise.UseVisualStyleBackColor = True
        '
        'btnTrigger
        '
        Me.caliTable.SetColumnSpan(Me.btnTrigger, 2)
        Me.btnTrigger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTrigger.Location = New System.Drawing.Point(3, 179)
        Me.btnTrigger.Name = "btnTrigger"
        Me.btnTrigger.Size = New System.Drawing.Size(283, 63)
        Me.btnTrigger.TabIndex = 6
        Me.btnTrigger.Text = "測試激發"
        Me.btnTrigger.UseVisualStyleBackColor = True
        '
        'lblCali
        '
        Me.lblCali.AutoSize = True
        Me.lblCali.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCali.Location = New System.Drawing.Point(147, 140)
        Me.lblCali.Name = "lblCali"
        Me.lblCali.Size = New System.Drawing.Size(139, 36)
        Me.lblCali.TabIndex = 7
        Me.lblCali.Text = "校正"
        Me.lblCali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabMed
        '
        Me.tabMed.Location = New System.Drawing.Point(4, 44)
        Me.tabMed.Name = "tabMed"
        Me.tabMed.Size = New System.Drawing.Size(923, 665)
        Me.tabMed.TabIndex = 1
        Me.tabMed.Text = "藥物檢查"
        '
        'InstantAiCtrl1
        '
        Me.InstantAiCtrl1._StateStream = CType(resources.GetObject("InstantAiCtrl1._StateStream"), Automation.BDaq.DeviceStateStreamer)
        '
        'okLink
        '
        Me.okLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okLink.Image = Global.emSys2016.My.Resources.Resources.okHover
        Me.okLink.ImageSize = 35
        Me.okLink.Location = New System.Drawing.Point(557, 9)
        Me.okLink.Name = "okLink"
        Me.okLink.NoFocusImage = Global.emSys2016.My.Resources.Resources.okUp
        Me.okLink.Size = New System.Drawing.Size(40, 40)
        Me.okLink.TabIndex = 4
        Me.okLink.UseSelectable = True
        '
        'pb
        '
        Me.pb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb.Location = New System.Drawing.Point(20, 60)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(583, 545)
        Me.pb.TabIndex = 0
        Me.pb.TabStop = False
        '
        'pnlEms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.diagTab)
        Me.Controls.Add(Me.pInfoPanel)
        Me.Name = "pnlEms"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 280, 0)
        Me.Size = New System.Drawing.Size(1211, 713)
        Me.pInfoPanel.ResumeLayout(False)
        Me.pInfoPanel.PerformLayout()
        Me.pInfoTable.ResumeLayout(False)
        Me.diagTab.ResumeLayout(False)
        Me.tabGraph.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.diagPanel.ResumeLayout(False)
        Me.buttonPanel.ResumeLayout(False)
        Me.buttonPanel.PerformLayout()
        Me.buttonTable.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.Panel27.ResumeLayout(False)
        Me.Panel27.PerformLayout()
        Me.graphTab.ResumeLayout(False)
        Me.tabEms.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tabEnergy.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tabCheck.ResumeLayout(False)
        Me.caliTable.ResumeLayout(False)
        Me.caliTable.PerformLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InstantDoCtrl1 As Automation.BDaq.InstantDoCtrl
    Friend WithEvents emsTimer As Timer
    Friend WithEvents pInfoPanel As Panel
    Friend WithEvents Label4 As Label
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
    Friend WithEvents diagTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabGraph As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tabMed As TabPage
    Friend WithEvents InstantAiCtrl1 As Automation.BDaq.InstantAiCtrl
    Friend WithEvents diagPanel As Panel
    Friend WithEvents pb As PictureBox
    Friend WithEvents graphTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabEms As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ptBox As ComboBox
    Friend WithEvents txtEvaValue As TextBox
    Friend WithEvents txtMaxValue As TextBox
    Friend WithEvents txtDevValue As TextBox
    Friend WithEvents tabEnergy As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents tabCheck As TabPage
    Friend WithEvents caliTable As TableLayoutPanel
    Friend WithEvents txtFixDevPoint As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFullValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrevsDev As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtOffsetValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnRevise As Button
    Friend WithEvents btnTrigger As Button
    Friend WithEvents lblCali As MetroFramework.Controls.MetroLabel
    Friend WithEvents buttonPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents buttonTable As TableLayoutPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents rdoEnergy As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rdoUpLeft As CheckBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents rdoUpRight As CheckBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents rdoDownLeft As CheckBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents rdoDownRight As CheckBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents rdoS2 As CheckBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents rdoS1 As CheckBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents rdoFoot As CheckBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents rdoHand As CheckBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents rdoRight As CheckBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents rdoLeft As CheckBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents rdoF1 As CheckBox
    Friend WithEvents Panel16 As Panel
    Friend WithEvents rdoF2 As CheckBox
    Friend WithEvents Panel17 As Panel
    Friend WithEvents rdoF3 As CheckBox
    Friend WithEvents Panel18 As Panel
    Friend WithEvents rdoF4 As CheckBox
    Friend WithEvents Panel19 As Panel
    Friend WithEvents rdoF5 As CheckBox
    Friend WithEvents Panel20 As Panel
    Friend WithEvents rdoStone As CheckBox
    Friend WithEvents Panel21 As Panel
    Friend WithEvents rdoC6 As CheckBox
    Friend WithEvents Panel22 As Panel
    Friend WithEvents rdoC5 As CheckBox
    Friend WithEvents Panel23 As Panel
    Friend WithEvents rdoC4 As CheckBox
    Friend WithEvents Panel24 As Panel
    Friend WithEvents rdoC3 As CheckBox
    Friend WithEvents Panel25 As Panel
    Friend WithEvents rdoC2 As CheckBox
    Friend WithEvents Panel26 As Panel
    Friend WithEvents rdoC1 As CheckBox
    Friend WithEvents Panel27 As Panel
    Friend WithEvents rdoGraph As CheckBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents okLink As MetroFramework.Controls.MetroLink
    Friend WithEvents openPanelLink As MetroFramework.Controls.MetroLink
    Friend WithEvents measurePoint As MetroFramework.Controls.MetroLabel
End Class
