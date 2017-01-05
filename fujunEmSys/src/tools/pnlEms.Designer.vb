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
        Me.InstantAiCtrl1 = New Automation.BDaq.InstantAiCtrl(Me.components)
        Me.diagTab = New MetroFramework.Controls.MetroTabControl()
        Me.tabGraph = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.diagPanel = New System.Windows.Forms.Panel()
        Me.measurePoint = New System.Windows.Forms.Label()
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
        Me.openPanelLink = New MetroFramework.Controls.MetroLink()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.graphTab = New MetroFramework.Controls.MetroTabControl()
        Me.tabEms = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ptBox = New System.Windows.Forms.ComboBox()
        Me.txtDevValue = New System.Windows.Forms.Label()
        Me.txtEvaValue = New System.Windows.Forms.Label()
        Me.txtMaxValue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.tabEnergy = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.top_pos = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bot_pos = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.left_pos = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.right_pos = New MetroFramework.Controls.MetroTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.diagLeft = New MetroFramework.Controls.MetroTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.diagRight = New MetroFramework.Controls.MetroTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.topArea = New MetroFramework.Controls.MetroTextBox()
        Me.botArea = New MetroFramework.Controls.MetroTextBox()
        Me.leftArea = New MetroFramework.Controls.MetroTextBox()
        Me.rightArea = New MetroFramework.Controls.MetroTextBox()
        Me.totalPercentage = New MetroFramework.Controls.MetroTextBox()
        Me.pInfoPanel = New System.Windows.Forms.Panel()
        Me.patientTab = New MetroFramework.Controls.MetroTabControl()
        Me.tabPatientInfo = New System.Windows.Forms.TabPage()
        Me.pInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.sexLabel = New MetroFramework.Controls.MetroLink()
        Me.nameLabel = New MetroFramework.Controls.MetroLink()
        Me.ageLabel = New MetroFramework.Controls.MetroLink()
        Me.countLabel = New MetroFramework.Controls.MetroLink()
        Me.lastVisitLabel = New MetroFramework.Controls.MetroLink()
        Me.pName = New MetroFramework.Controls.MetroTextBox()
        Me.pSex = New MetroFramework.Controls.MetroTextBox()
        Me.pAge = New MetroFramework.Controls.MetroTextBox()
        Me.pVisitTimes = New MetroFramework.Controls.MetroTextBox()
        Me.pPrevVisit = New MetroFramework.Controls.MetroTextBox()
        Me.tabBooking = New System.Windows.Forms.TabPage()
        Me.waitingList = New System.Windows.Forms.ListBox()
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
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.graphTab.SuspendLayout()
        Me.tabEms.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.tabCheck.SuspendLayout()
        Me.caliTable.SuspendLayout()
        Me.tabEnergy.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.pInfoPanel.SuspendLayout()
        Me.patientTab.SuspendLayout()
        Me.tabPatientInfo.SuspendLayout()
        Me.pInfoTable.SuspendLayout()
        Me.tabBooking.SuspendLayout()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.Location = New System.Drawing.Point(156, 156)
        '
        'InstantDoCtrl1
        '
        Me.InstantDoCtrl1._StateStream = CType(resources.GetObject("InstantDoCtrl1._StateStream"), Automation.BDaq.DeviceStateStreamer)
        '
        'emsTimer
        '
        Me.emsTimer.Interval = 10
        '
        'InstantAiCtrl1
        '
        Me.InstantAiCtrl1._StateStream = CType(resources.GetObject("InstantAiCtrl1._StateStream"), Automation.BDaq.DeviceStateStreamer)
        '
        'diagTab
        '
        Me.diagTab.Controls.Add(Me.tabGraph)
        Me.diagTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.diagTab.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.diagTab.Location = New System.Drawing.Point(0, 0)
        Me.diagTab.Name = "diagTab"
        Me.diagTab.SelectedIndex = 0
        Me.diagTab.Size = New System.Drawing.Size(1400, 900)
        Me.diagTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.diagTab.TabIndex = 5
        Me.diagTab.UseSelectable = True
        '
        'tabGraph
        '
        Me.tabGraph.Controls.Add(Me.TableLayoutPanel1)
        Me.tabGraph.Location = New System.Drawing.Point(4, 44)
        Me.tabGraph.Name = "tabGraph"
        Me.tabGraph.Size = New System.Drawing.Size(1392, 852)
        Me.tabGraph.TabIndex = 0
        Me.tabGraph.Text = "頻譜檢查"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.diagPanel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.graphTab, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1392, 852)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'diagPanel
        '
        Me.diagPanel.Controls.Add(Me.measurePoint)
        Me.diagPanel.Controls.Add(Me.buttonPanel)
        Me.diagPanel.Controls.Add(Me.openPanelLink)
        Me.diagPanel.Controls.Add(Me.pb)
        Me.diagPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.diagPanel.Location = New System.Drawing.Point(500, 0)
        Me.diagPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.diagPanel.Name = "diagPanel"
        Me.diagPanel.Padding = New System.Windows.Forms.Padding(20, 200, 20, 370)
        Me.diagPanel.Size = New System.Drawing.Size(892, 852)
        Me.diagPanel.TabIndex = 1
        '
        'measurePoint
        '
        Me.measurePoint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.measurePoint.BackColor = System.Drawing.Color.White
        Me.measurePoint.Font = New System.Drawing.Font("DFKai-SB", 55.0!)
        Me.measurePoint.Location = New System.Drawing.Point(20, 20)
        Me.measurePoint.Name = "measurePoint"
        Me.measurePoint.Size = New System.Drawing.Size(852, 156)
        Me.measurePoint.TabIndex = 3
        Me.measurePoint.Text = "量測點"
        Me.measurePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonPanel
        '
        Me.buttonPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonPanel.Controls.Add(Me.MetroLabel5)
        Me.buttonPanel.Controls.Add(Me.buttonTable)
        Me.buttonPanel.HorizontalScrollbarBarColor = True
        Me.buttonPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.buttonPanel.HorizontalScrollbarSize = 10
        Me.buttonPanel.Location = New System.Drawing.Point(0, 502)
        Me.buttonPanel.Name = "buttonPanel"
        Me.buttonPanel.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
        Me.buttonPanel.Size = New System.Drawing.Size(892, 350)
        Me.buttonPanel.TabIndex = 1
        Me.buttonPanel.VerticalScrollbarBarColor = True
        Me.buttonPanel.VerticalScrollbarHighlightOnWheel = False
        Me.buttonPanel.VerticalScrollbarSize = 10
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 15)
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
        Me.buttonTable.Size = New System.Drawing.Size(852, 270)
        Me.buttonTable.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel5.Controls.Add(Me.rdoEnergy)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(564, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(141, 67)
        Me.Panel5.TabIndex = 4
        '
        'rdoEnergy
        '
        Me.rdoEnergy.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoEnergy.AutoSize = True
        Me.rdoEnergy.Checked = True
        Me.rdoEnergy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdoEnergy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoEnergy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoEnergy.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoEnergy.Location = New System.Drawing.Point(0, 0)
        Me.rdoEnergy.Name = "rdoEnergy"
        Me.rdoEnergy.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel4.Size = New System.Drawing.Size(141, 67)
        Me.Panel4.TabIndex = 3
        '
        'rdoUpLeft
        '
        Me.rdoUpLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUpLeft.AutoSize = True
        Me.rdoUpLeft.Checked = True
        Me.rdoUpLeft.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdoUpLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoUpLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUpLeft.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoUpLeft.Location = New System.Drawing.Point(0, 0)
        Me.rdoUpLeft.Name = "rdoUpLeft"
        Me.rdoUpLeft.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel6.Location = New System.Drawing.Point(141, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(141, 67)
        Me.Panel6.TabIndex = 3
        '
        'rdoUpRight
        '
        Me.rdoUpRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUpRight.AutoSize = True
        Me.rdoUpRight.Checked = True
        Me.rdoUpRight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdoUpRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoUpRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUpRight.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoUpRight.Location = New System.Drawing.Point(0, 0)
        Me.rdoUpRight.Name = "rdoUpRight"
        Me.rdoUpRight.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel7.Location = New System.Drawing.Point(282, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(141, 67)
        Me.Panel7.TabIndex = 3
        '
        'rdoDownLeft
        '
        Me.rdoDownLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDownLeft.AutoSize = True
        Me.rdoDownLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoDownLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDownLeft.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoDownLeft.Location = New System.Drawing.Point(0, 0)
        Me.rdoDownLeft.Name = "rdoDownLeft"
        Me.rdoDownLeft.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel8.Location = New System.Drawing.Point(423, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(141, 67)
        Me.Panel8.TabIndex = 3
        '
        'rdoDownRight
        '
        Me.rdoDownRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDownRight.AutoSize = True
        Me.rdoDownRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoDownRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDownRight.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoDownRight.Location = New System.Drawing.Point(0, 0)
        Me.rdoDownRight.Name = "rdoDownRight"
        Me.rdoDownRight.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel9.Location = New System.Drawing.Point(705, 67)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(147, 67)
        Me.Panel9.TabIndex = 3
        '
        'rdoS2
        '
        Me.rdoS2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoS2.AutoSize = True
        Me.rdoS2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoS2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoS2.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoS2.Location = New System.Drawing.Point(0, 0)
        Me.rdoS2.Name = "rdoS2"
        Me.rdoS2.Size = New System.Drawing.Size(147, 67)
        Me.rdoS2.TabIndex = 2
        Me.rdoS2.Text = "內"
        Me.rdoS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoS2.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Peru
        Me.Panel10.Controls.Add(Me.rdoS1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(564, 67)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(141, 67)
        Me.Panel10.TabIndex = 3
        '
        'rdoS1
        '
        Me.rdoS1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoS1.AutoSize = True
        Me.rdoS1.Checked = True
        Me.rdoS1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdoS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoS1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoS1.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoS1.Location = New System.Drawing.Point(0, 0)
        Me.rdoS1.Name = "rdoS1"
        Me.rdoS1.Size = New System.Drawing.Size(141, 67)
        Me.rdoS1.TabIndex = 2
        Me.rdoS1.Text = "外"
        Me.rdoS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoS1.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel11.Controls.Add(Me.rdoFoot)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(423, 67)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(141, 67)
        Me.Panel11.TabIndex = 3
        '
        'rdoFoot
        '
        Me.rdoFoot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFoot.AutoSize = True
        Me.rdoFoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoFoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFoot.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoFoot.Location = New System.Drawing.Point(0, 0)
        Me.rdoFoot.Name = "rdoFoot"
        Me.rdoFoot.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel12.Location = New System.Drawing.Point(282, 67)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(141, 67)
        Me.Panel12.TabIndex = 3
        '
        'rdoHand
        '
        Me.rdoHand.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHand.AutoSize = True
        Me.rdoHand.Checked = True
        Me.rdoHand.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdoHand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoHand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHand.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoHand.Location = New System.Drawing.Point(0, 0)
        Me.rdoHand.Name = "rdoHand"
        Me.rdoHand.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel13.Location = New System.Drawing.Point(141, 67)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(141, 67)
        Me.Panel13.TabIndex = 3
        '
        'rdoRight
        '
        Me.rdoRight.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRight.AutoSize = True
        Me.rdoRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRight.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoRight.Location = New System.Drawing.Point(0, 0)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel14.Location = New System.Drawing.Point(0, 67)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(141, 67)
        Me.Panel14.TabIndex = 3
        '
        'rdoLeft
        '
        Me.rdoLeft.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLeft.AutoSize = True
        Me.rdoLeft.Checked = True
        Me.rdoLeft.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdoLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLeft.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoLeft.Location = New System.Drawing.Point(0, 0)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel15.Location = New System.Drawing.Point(0, 134)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(141, 67)
        Me.Panel15.TabIndex = 3
        '
        'rdoF1
        '
        Me.rdoF1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoF1.AutoSize = True
        Me.rdoF1.Checked = True
        Me.rdoF1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdoF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoF1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoF1.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoF1.Location = New System.Drawing.Point(0, 0)
        Me.rdoF1.Name = "rdoF1"
        Me.rdoF1.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel16.Location = New System.Drawing.Point(141, 134)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(141, 67)
        Me.Panel16.TabIndex = 3
        '
        'rdoF2
        '
        Me.rdoF2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoF2.AutoSize = True
        Me.rdoF2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoF2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoF2.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoF2.Location = New System.Drawing.Point(0, 0)
        Me.rdoF2.Name = "rdoF2"
        Me.rdoF2.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel17.Location = New System.Drawing.Point(282, 134)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(141, 67)
        Me.Panel17.TabIndex = 3
        '
        'rdoF3
        '
        Me.rdoF3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoF3.AutoSize = True
        Me.rdoF3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoF3.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoF3.Location = New System.Drawing.Point(0, 0)
        Me.rdoF3.Name = "rdoF3"
        Me.rdoF3.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel18.Location = New System.Drawing.Point(423, 134)
        Me.Panel18.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(141, 67)
        Me.Panel18.TabIndex = 3
        '
        'rdoF4
        '
        Me.rdoF4.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoF4.AutoSize = True
        Me.rdoF4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoF4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoF4.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoF4.Location = New System.Drawing.Point(0, 0)
        Me.rdoF4.Name = "rdoF4"
        Me.rdoF4.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel19.Location = New System.Drawing.Point(564, 134)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(141, 67)
        Me.Panel19.TabIndex = 3
        '
        'rdoF5
        '
        Me.rdoF5.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoF5.AutoSize = True
        Me.rdoF5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoF5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoF5.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoF5.Location = New System.Drawing.Point(0, 0)
        Me.rdoF5.Name = "rdoF5"
        Me.rdoF5.Size = New System.Drawing.Size(141, 67)
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
        Me.Panel20.Location = New System.Drawing.Point(705, 134)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(147, 67)
        Me.Panel20.TabIndex = 3
        '
        'rdoStone
        '
        Me.rdoStone.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStone.AutoSize = True
        Me.rdoStone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoStone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStone.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoStone.Location = New System.Drawing.Point(0, 0)
        Me.rdoStone.Name = "rdoStone"
        Me.rdoStone.Size = New System.Drawing.Size(147, 67)
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
        Me.Panel21.Location = New System.Drawing.Point(705, 201)
        Me.Panel21.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(147, 69)
        Me.Panel21.TabIndex = 3
        '
        'rdoC6
        '
        Me.rdoC6.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC6.AutoSize = True
        Me.rdoC6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC6.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoC6.Location = New System.Drawing.Point(0, 0)
        Me.rdoC6.Name = "rdoC6"
        Me.rdoC6.Size = New System.Drawing.Size(147, 69)
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
        Me.Panel22.Location = New System.Drawing.Point(564, 201)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(141, 69)
        Me.Panel22.TabIndex = 3
        '
        'rdoC5
        '
        Me.rdoC5.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC5.AutoSize = True
        Me.rdoC5.Checked = True
        Me.rdoC5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rdoC5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC5.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoC5.Location = New System.Drawing.Point(0, 0)
        Me.rdoC5.Name = "rdoC5"
        Me.rdoC5.Size = New System.Drawing.Size(141, 69)
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
        Me.Panel23.Location = New System.Drawing.Point(423, 201)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(141, 69)
        Me.Panel23.TabIndex = 3
        '
        'rdoC4
        '
        Me.rdoC4.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC4.AutoSize = True
        Me.rdoC4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC4.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoC4.Location = New System.Drawing.Point(0, 0)
        Me.rdoC4.Name = "rdoC4"
        Me.rdoC4.Size = New System.Drawing.Size(141, 69)
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
        Me.Panel24.Location = New System.Drawing.Point(282, 201)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(141, 69)
        Me.Panel24.TabIndex = 3
        '
        'rdoC3
        '
        Me.rdoC3.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC3.AutoSize = True
        Me.rdoC3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC3.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoC3.Location = New System.Drawing.Point(0, 0)
        Me.rdoC3.Name = "rdoC3"
        Me.rdoC3.Size = New System.Drawing.Size(141, 69)
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
        Me.Panel25.Location = New System.Drawing.Point(141, 201)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(141, 69)
        Me.Panel25.TabIndex = 3
        '
        'rdoC2
        '
        Me.rdoC2.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC2.AutoSize = True
        Me.rdoC2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC2.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoC2.Location = New System.Drawing.Point(0, 0)
        Me.rdoC2.Name = "rdoC2"
        Me.rdoC2.Size = New System.Drawing.Size(141, 69)
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
        Me.Panel26.Location = New System.Drawing.Point(0, 201)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(141, 69)
        Me.Panel26.TabIndex = 3
        '
        'rdoC1
        '
        Me.rdoC1.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoC1.AutoSize = True
        Me.rdoC1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoC1.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoC1.Location = New System.Drawing.Point(0, 0)
        Me.rdoC1.Name = "rdoC1"
        Me.rdoC1.Size = New System.Drawing.Size(141, 69)
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
        Me.Panel27.Location = New System.Drawing.Point(705, 0)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(147, 67)
        Me.Panel27.TabIndex = 5
        '
        'rdoGraph
        '
        Me.rdoGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGraph.AutoSize = True
        Me.rdoGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdoGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGraph.Font = New System.Drawing.Font("DFKai-SB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.rdoGraph.Location = New System.Drawing.Point(0, 0)
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.Size = New System.Drawing.Size(147, 67)
        Me.rdoGraph.TabIndex = 3
        Me.rdoGraph.Text = "頻譜"
        Me.rdoGraph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'openPanelLink
        '
        Me.openPanelLink.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.openPanelLink.Location = New System.Drawing.Point(255, 500)
        Me.openPanelLink.Name = "openPanelLink"
        Me.openPanelLink.Size = New System.Drawing.Size(381, 23)
        Me.openPanelLink.TabIndex = 2
        Me.openPanelLink.Text = "開啟手動測量點"
        Me.openPanelLink.UseSelectable = True
        '
        'pb
        '
        Me.pb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb.Location = New System.Drawing.Point(20, 200)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(852, 282)
        Me.pb.TabIndex = 0
        Me.pb.TabStop = False
        '
        'graphTab
        '
        Me.graphTab.Controls.Add(Me.tabEms)
        Me.graphTab.Controls.Add(Me.tabCheck)
        Me.graphTab.Controls.Add(Me.tabEnergy)
        Me.graphTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graphTab.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.graphTab.HotTrack = True
        Me.graphTab.Location = New System.Drawing.Point(0, 0)
        Me.graphTab.Margin = New System.Windows.Forms.Padding(0)
        Me.graphTab.Multiline = True
        Me.graphTab.Name = "graphTab"
        Me.graphTab.SelectedIndex = 0
        Me.graphTab.Size = New System.Drawing.Size(500, 852)
        Me.graphTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.graphTab.TabIndex = 2
        Me.graphTab.UseSelectable = True
        '
        'tabEms
        '
        Me.tabEms.Controls.Add(Me.Panel1)
        Me.tabEms.Location = New System.Drawing.Point(4, 44)
        Me.tabEms.Name = "tabEms"
        Me.tabEms.Size = New System.Drawing.Size(492, 804)
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
        Me.Panel1.Size = New System.Drawing.Size(492, 804)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.ptBox, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDevValue, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txtEvaValue, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtMaxValue, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(20, 20)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(452, 764)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("DFKai-SB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(3, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(446, 60)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "最大值"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("DFKai-SB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "快速選擇"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("DFKai-SB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(3, 580)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(446, 60)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "偏差值"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ptBox
        '
        Me.ptBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ptBox.DropDownWidth = 500
        Me.ptBox.Font = New System.Drawing.Font("DFKai-SB", 40.0!)
        Me.ptBox.FormattingEnabled = True
        Me.ptBox.Items.AddRange(New Object() {"一二三四五六七"})
        Me.ptBox.Location = New System.Drawing.Point(3, 63)
        Me.ptBox.Name = "ptBox"
        Me.ptBox.Size = New System.Drawing.Size(446, 61)
        Me.ptBox.TabIndex = 4
        '
        'txtDevValue
        '
        Me.txtDevValue.AutoSize = True
        Me.txtDevValue.BackColor = System.Drawing.Color.White
        Me.txtDevValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDevValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDevValue.Font = New System.Drawing.Font("Swis721 Blk BT", 100.0!)
        Me.txtDevValue.Location = New System.Drawing.Point(3, 640)
        Me.txtDevValue.Name = "txtDevValue"
        Me.txtDevValue.Size = New System.Drawing.Size(446, 160)
        Me.txtDevValue.TabIndex = 6
        Me.txtDevValue.Text = "0"
        Me.txtDevValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEvaValue
        '
        Me.txtEvaValue.AutoSize = True
        Me.txtEvaValue.BackColor = System.Drawing.Color.White
        Me.txtEvaValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEvaValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEvaValue.Font = New System.Drawing.Font("Swis721 Blk BT", 100.0!)
        Me.txtEvaValue.Location = New System.Drawing.Point(3, 420)
        Me.txtEvaValue.Name = "txtEvaValue"
        Me.txtEvaValue.Size = New System.Drawing.Size(446, 160)
        Me.txtEvaValue.TabIndex = 7
        Me.txtEvaValue.Text = "0"
        Me.txtEvaValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMaxValue
        '
        Me.txtMaxValue.AutoSize = True
        Me.txtMaxValue.BackColor = System.Drawing.Color.White
        Me.txtMaxValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaxValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMaxValue.Font = New System.Drawing.Font("Swis721 Blk BT", 100.0!)
        Me.txtMaxValue.Location = New System.Drawing.Point(3, 200)
        Me.txtMaxValue.Name = "txtMaxValue"
        Me.txtMaxValue.Size = New System.Drawing.Size(446, 160)
        Me.txtMaxValue.TabIndex = 7
        Me.txtMaxValue.Text = "0"
        Me.txtMaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("DFKai-SB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(3, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(446, 60)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "量測值"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabCheck
        '
        Me.tabCheck.Controls.Add(Me.caliTable)
        Me.tabCheck.Location = New System.Drawing.Point(4, 44)
        Me.tabCheck.Name = "tabCheck"
        Me.tabCheck.Size = New System.Drawing.Size(492, 804)
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
        Me.txtFixDevPoint.Lines = New String() {"0"}
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
        Me.txtFixDevPoint.Text = "0"
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
        Me.txtFullValue.Lines = New String() {"0"}
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
        Me.txtFullValue.Text = "0"
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
        Me.txtPrevsDev.Lines = New String() {"0"}
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
        Me.txtPrevsDev.Text = "0"
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
        Me.txtOffsetValue.Lines = New String() {"0"}
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
        Me.txtOffsetValue.Text = "0"
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
        'tabEnergy
        '
        Me.tabEnergy.Controls.Add(Me.Panel3)
        Me.tabEnergy.Location = New System.Drawing.Point(4, 44)
        Me.tabEnergy.Name = "tabEnergy"
        Me.tabEnergy.Size = New System.Drawing.Size(492, 804)
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
        Me.Panel3.Size = New System.Drawing.Size(492, 804)
        Me.Panel3.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.top_pos, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.bot_pos, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.left_pos, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.right_pos, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.diagLeft, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.diagRight, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 0, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 1, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 0, 10)
        Me.TableLayoutPanel3.Controls.Add(Me.topArea, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.botArea, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.leftArea, 0, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.rightArea, 1, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.totalPercentage, 0, 11)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(20, 20)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 13
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(452, 764)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 40)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "上"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'top_pos
        '
        '
        '
        '
        Me.top_pos.CustomButton.Image = Nothing
        Me.top_pos.CustomButton.Location = New System.Drawing.Point(188, 2)
        Me.top_pos.CustomButton.Name = ""
        Me.top_pos.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.top_pos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.top_pos.CustomButton.TabIndex = 1
        Me.top_pos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.top_pos.CustomButton.UseSelectable = True
        Me.top_pos.CustomButton.Visible = False
        Me.top_pos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.top_pos.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.top_pos.Lines = New String(-1) {}
        Me.top_pos.Location = New System.Drawing.Point(3, 43)
        Me.top_pos.MaxLength = 32767
        Me.top_pos.Name = "top_pos"
        Me.top_pos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.top_pos.PromptText = "未測量"
        Me.top_pos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.top_pos.SelectedText = ""
        Me.top_pos.SelectionLength = 0
        Me.top_pos.SelectionStart = 0
        Me.top_pos.ShortcutsEnabled = True
        Me.top_pos.Size = New System.Drawing.Size(220, 34)
        Me.top_pos.TabIndex = 2
        Me.top_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.top_pos.UseSelectable = True
        Me.top_pos.WaterMark = "未測量"
        Me.top_pos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.top_pos.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(229, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 40)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "下"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bot_pos
        '
        '
        '
        '
        Me.bot_pos.CustomButton.Image = Nothing
        Me.bot_pos.CustomButton.Location = New System.Drawing.Point(188, 2)
        Me.bot_pos.CustomButton.Name = ""
        Me.bot_pos.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.bot_pos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.bot_pos.CustomButton.TabIndex = 1
        Me.bot_pos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bot_pos.CustomButton.UseSelectable = True
        Me.bot_pos.CustomButton.Visible = False
        Me.bot_pos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bot_pos.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.bot_pos.Lines = New String(-1) {}
        Me.bot_pos.Location = New System.Drawing.Point(229, 43)
        Me.bot_pos.MaxLength = 32767
        Me.bot_pos.Name = "bot_pos"
        Me.bot_pos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.bot_pos.PromptText = "未測量"
        Me.bot_pos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.bot_pos.SelectedText = ""
        Me.bot_pos.SelectionLength = 0
        Me.bot_pos.SelectionStart = 0
        Me.bot_pos.ShortcutsEnabled = True
        Me.bot_pos.Size = New System.Drawing.Size(220, 34)
        Me.bot_pos.TabIndex = 2
        Me.bot_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.bot_pos.UseSelectable = True
        Me.bot_pos.WaterMark = "未測量"
        Me.bot_pos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.bot_pos.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 40)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "左"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'left_pos
        '
        '
        '
        '
        Me.left_pos.CustomButton.Image = Nothing
        Me.left_pos.CustomButton.Location = New System.Drawing.Point(188, 2)
        Me.left_pos.CustomButton.Name = ""
        Me.left_pos.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.left_pos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.left_pos.CustomButton.TabIndex = 1
        Me.left_pos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.left_pos.CustomButton.UseSelectable = True
        Me.left_pos.CustomButton.Visible = False
        Me.left_pos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.left_pos.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.left_pos.Lines = New String(-1) {}
        Me.left_pos.Location = New System.Drawing.Point(3, 123)
        Me.left_pos.MaxLength = 32767
        Me.left_pos.Name = "left_pos"
        Me.left_pos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.left_pos.PromptText = "未測量"
        Me.left_pos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.left_pos.SelectedText = ""
        Me.left_pos.SelectionLength = 0
        Me.left_pos.SelectionStart = 0
        Me.left_pos.ShortcutsEnabled = True
        Me.left_pos.Size = New System.Drawing.Size(220, 34)
        Me.left_pos.TabIndex = 2
        Me.left_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.left_pos.UseSelectable = True
        Me.left_pos.WaterMark = "未測量"
        Me.left_pos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.left_pos.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(229, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(220, 40)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "右"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'right_pos
        '
        '
        '
        '
        Me.right_pos.CustomButton.Image = Nothing
        Me.right_pos.CustomButton.Location = New System.Drawing.Point(188, 2)
        Me.right_pos.CustomButton.Name = ""
        Me.right_pos.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.right_pos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.right_pos.CustomButton.TabIndex = 1
        Me.right_pos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.right_pos.CustomButton.UseSelectable = True
        Me.right_pos.CustomButton.Visible = False
        Me.right_pos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.right_pos.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.right_pos.Lines = New String(-1) {}
        Me.right_pos.Location = New System.Drawing.Point(229, 123)
        Me.right_pos.MaxLength = 32767
        Me.right_pos.Name = "right_pos"
        Me.right_pos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.right_pos.PromptText = "未測量"
        Me.right_pos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.right_pos.SelectedText = ""
        Me.right_pos.SelectionLength = 0
        Me.right_pos.SelectionStart = 0
        Me.right_pos.ShortcutsEnabled = True
        Me.right_pos.Size = New System.Drawing.Size(220, 34)
        Me.right_pos.TabIndex = 2
        Me.right_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.right_pos.UseSelectable = True
        Me.right_pos.WaterMark = "未測量"
        Me.right_pos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.right_pos.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(220, 40)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "左斜角"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'diagLeft
        '
        '
        '
        '
        Me.diagLeft.CustomButton.Image = Nothing
        Me.diagLeft.CustomButton.Location = New System.Drawing.Point(188, 2)
        Me.diagLeft.CustomButton.Name = ""
        Me.diagLeft.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.diagLeft.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.diagLeft.CustomButton.TabIndex = 1
        Me.diagLeft.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.diagLeft.CustomButton.UseSelectable = True
        Me.diagLeft.CustomButton.Visible = False
        Me.diagLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.diagLeft.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.diagLeft.Lines = New String(-1) {}
        Me.diagLeft.Location = New System.Drawing.Point(3, 203)
        Me.diagLeft.MaxLength = 32767
        Me.diagLeft.Name = "diagLeft"
        Me.diagLeft.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.diagLeft.PromptText = "未測量"
        Me.diagLeft.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.diagLeft.SelectedText = ""
        Me.diagLeft.SelectionLength = 0
        Me.diagLeft.SelectionStart = 0
        Me.diagLeft.ShortcutsEnabled = True
        Me.diagLeft.Size = New System.Drawing.Size(220, 34)
        Me.diagLeft.TabIndex = 2
        Me.diagLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.diagLeft.UseSelectable = True
        Me.diagLeft.WaterMark = "未測量"
        Me.diagLeft.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.diagLeft.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(229, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 40)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "右斜角"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'diagRight
        '
        '
        '
        '
        Me.diagRight.CustomButton.Image = Nothing
        Me.diagRight.CustomButton.Location = New System.Drawing.Point(188, 2)
        Me.diagRight.CustomButton.Name = ""
        Me.diagRight.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.diagRight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.diagRight.CustomButton.TabIndex = 1
        Me.diagRight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.diagRight.CustomButton.UseSelectable = True
        Me.diagRight.CustomButton.Visible = False
        Me.diagRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.diagRight.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.diagRight.Lines = New String(-1) {}
        Me.diagRight.Location = New System.Drawing.Point(229, 203)
        Me.diagRight.MaxLength = 32767
        Me.diagRight.Name = "diagRight"
        Me.diagRight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.diagRight.PromptText = "未測量"
        Me.diagRight.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.diagRight.SelectedText = ""
        Me.diagRight.SelectionLength = 0
        Me.diagRight.SelectionStart = 0
        Me.diagRight.ShortcutsEnabled = True
        Me.diagRight.Size = New System.Drawing.Size(220, 34)
        Me.diagRight.TabIndex = 2
        Me.diagRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.diagRight.UseSelectable = True
        Me.diagRight.WaterMark = "未測量"
        Me.diagRight.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.diagRight.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(220, 40)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "上面積"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(229, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(220, 40)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "下面積"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 320)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 40)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "左面積"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(229, 320)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(220, 40)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "右面積"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label16, 2)
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("DFKai-SB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 400)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(446, 40)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "總面積比例"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'topArea
        '
        '
        '
        '
        Me.topArea.CustomButton.Image = Nothing
        Me.topArea.CustomButton.Location = New System.Drawing.Point(188, 2)
        Me.topArea.CustomButton.Name = ""
        Me.topArea.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.topArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.topArea.CustomButton.TabIndex = 1
        Me.topArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.topArea.CustomButton.UseSelectable = True
        Me.topArea.CustomButton.Visible = False
        Me.topArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.topArea.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.topArea.Lines = New String(-1) {}
        Me.topArea.Location = New System.Drawing.Point(3, 283)
        Me.topArea.MaxLength = 32767
        Me.topArea.Name = "topArea"
        Me.topArea.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.topArea.PromptText = "未測量"
        Me.topArea.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.topArea.SelectedText = ""
        Me.topArea.SelectionLength = 0
        Me.topArea.SelectionStart = 0
        Me.topArea.ShortcutsEnabled = True
        Me.topArea.Size = New System.Drawing.Size(220, 34)
        Me.topArea.TabIndex = 2
        Me.topArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.topArea.UseSelectable = True
        Me.topArea.WaterMark = "未測量"
        Me.topArea.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.topArea.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'botArea
        '
        '
        '
        '
        Me.botArea.CustomButton.Image = Nothing
        Me.botArea.CustomButton.Location = New System.Drawing.Point(188, 2)
        Me.botArea.CustomButton.Name = ""
        Me.botArea.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.botArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.botArea.CustomButton.TabIndex = 1
        Me.botArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.botArea.CustomButton.UseSelectable = True
        Me.botArea.CustomButton.Visible = False
        Me.botArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.botArea.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.botArea.Lines = New String(-1) {}
        Me.botArea.Location = New System.Drawing.Point(229, 283)
        Me.botArea.MaxLength = 32767
        Me.botArea.Name = "botArea"
        Me.botArea.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.botArea.PromptText = "未測量"
        Me.botArea.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.botArea.SelectedText = ""
        Me.botArea.SelectionLength = 0
        Me.botArea.SelectionStart = 0
        Me.botArea.ShortcutsEnabled = True
        Me.botArea.Size = New System.Drawing.Size(220, 34)
        Me.botArea.TabIndex = 2
        Me.botArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.botArea.UseSelectable = True
        Me.botArea.WaterMark = "未測量"
        Me.botArea.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.botArea.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'leftArea
        '
        '
        '
        '
        Me.leftArea.CustomButton.Image = Nothing
        Me.leftArea.CustomButton.Location = New System.Drawing.Point(188, 2)
        Me.leftArea.CustomButton.Name = ""
        Me.leftArea.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.leftArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.leftArea.CustomButton.TabIndex = 1
        Me.leftArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.leftArea.CustomButton.UseSelectable = True
        Me.leftArea.CustomButton.Visible = False
        Me.leftArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.leftArea.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.leftArea.Lines = New String(-1) {}
        Me.leftArea.Location = New System.Drawing.Point(3, 363)
        Me.leftArea.MaxLength = 32767
        Me.leftArea.Name = "leftArea"
        Me.leftArea.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.leftArea.PromptText = "未測量"
        Me.leftArea.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.leftArea.SelectedText = ""
        Me.leftArea.SelectionLength = 0
        Me.leftArea.SelectionStart = 0
        Me.leftArea.ShortcutsEnabled = True
        Me.leftArea.Size = New System.Drawing.Size(220, 34)
        Me.leftArea.TabIndex = 2
        Me.leftArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.leftArea.UseSelectable = True
        Me.leftArea.WaterMark = "未測量"
        Me.leftArea.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.leftArea.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'rightArea
        '
        '
        '
        '
        Me.rightArea.CustomButton.Image = Nothing
        Me.rightArea.CustomButton.Location = New System.Drawing.Point(188, 2)
        Me.rightArea.CustomButton.Name = ""
        Me.rightArea.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.rightArea.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.rightArea.CustomButton.TabIndex = 1
        Me.rightArea.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.rightArea.CustomButton.UseSelectable = True
        Me.rightArea.CustomButton.Visible = False
        Me.rightArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rightArea.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.rightArea.Lines = New String(-1) {}
        Me.rightArea.Location = New System.Drawing.Point(229, 363)
        Me.rightArea.MaxLength = 32767
        Me.rightArea.Name = "rightArea"
        Me.rightArea.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rightArea.PromptText = "未測量"
        Me.rightArea.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.rightArea.SelectedText = ""
        Me.rightArea.SelectionLength = 0
        Me.rightArea.SelectionStart = 0
        Me.rightArea.ShortcutsEnabled = True
        Me.rightArea.Size = New System.Drawing.Size(220, 34)
        Me.rightArea.TabIndex = 2
        Me.rightArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.rightArea.UseSelectable = True
        Me.rightArea.WaterMark = "未測量"
        Me.rightArea.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.rightArea.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'totalPercentage
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.totalPercentage, 2)
        '
        '
        '
        Me.totalPercentage.CustomButton.Image = Nothing
        Me.totalPercentage.CustomButton.Location = New System.Drawing.Point(414, 2)
        Me.totalPercentage.CustomButton.Name = ""
        Me.totalPercentage.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.totalPercentage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.totalPercentage.CustomButton.TabIndex = 1
        Me.totalPercentage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.totalPercentage.CustomButton.UseSelectable = True
        Me.totalPercentage.CustomButton.Visible = False
        Me.totalPercentage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.totalPercentage.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.totalPercentage.Lines = New String(-1) {}
        Me.totalPercentage.Location = New System.Drawing.Point(3, 443)
        Me.totalPercentage.MaxLength = 32767
        Me.totalPercentage.Name = "totalPercentage"
        Me.totalPercentage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalPercentage.PromptText = "未測量"
        Me.totalPercentage.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.totalPercentage.SelectedText = ""
        Me.totalPercentage.SelectionLength = 0
        Me.totalPercentage.SelectionStart = 0
        Me.totalPercentage.ShortcutsEnabled = True
        Me.totalPercentage.Size = New System.Drawing.Size(446, 34)
        Me.totalPercentage.TabIndex = 2
        Me.totalPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.totalPercentage.UseSelectable = True
        Me.totalPercentage.WaterMark = "未測量"
        Me.totalPercentage.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.totalPercentage.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pInfoPanel
        '
        Me.pInfoPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pInfoPanel.BackColor = System.Drawing.Color.SeaGreen
        Me.pInfoPanel.Controls.Add(Me.patientTab)
        Me.pInfoPanel.Location = New System.Drawing.Point(1400, 0)
        Me.pInfoPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.pInfoPanel.Name = "pInfoPanel"
        Me.pInfoPanel.Padding = New System.Windows.Forms.Padding(20)
        Me.pInfoPanel.Size = New System.Drawing.Size(400, 900)
        Me.pInfoPanel.TabIndex = 4
        '
        'patientTab
        '
        Me.patientTab.Controls.Add(Me.tabPatientInfo)
        Me.patientTab.Controls.Add(Me.tabBooking)
        Me.patientTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientTab.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.patientTab.Location = New System.Drawing.Point(20, 20)
        Me.patientTab.Name = "patientTab"
        Me.patientTab.SelectedIndex = 0
        Me.patientTab.Size = New System.Drawing.Size(360, 860)
        Me.patientTab.TabIndex = 3
        Me.patientTab.UseSelectable = True
        '
        'tabPatientInfo
        '
        Me.tabPatientInfo.Controls.Add(Me.pInfoTable)
        Me.tabPatientInfo.Location = New System.Drawing.Point(4, 44)
        Me.tabPatientInfo.Name = "tabPatientInfo"
        Me.tabPatientInfo.Size = New System.Drawing.Size(352, 812)
        Me.tabPatientInfo.TabIndex = 0
        Me.tabPatientInfo.Text = "病患資料"
        '
        'pInfoTable
        '
        Me.pInfoTable.ColumnCount = 1
        Me.pInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pInfoTable.Controls.Add(Me.sexLabel, 0, 2)
        Me.pInfoTable.Controls.Add(Me.nameLabel, 0, 0)
        Me.pInfoTable.Controls.Add(Me.ageLabel, 0, 4)
        Me.pInfoTable.Controls.Add(Me.countLabel, 0, 6)
        Me.pInfoTable.Controls.Add(Me.lastVisitLabel, 0, 8)
        Me.pInfoTable.Controls.Add(Me.pName, 0, 1)
        Me.pInfoTable.Controls.Add(Me.pSex, 0, 3)
        Me.pInfoTable.Controls.Add(Me.pAge, 0, 5)
        Me.pInfoTable.Controls.Add(Me.pVisitTimes, 0, 7)
        Me.pInfoTable.Controls.Add(Me.pPrevVisit, 0, 9)
        Me.pInfoTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pInfoTable.Location = New System.Drawing.Point(0, 0)
        Me.pInfoTable.Name = "pInfoTable"
        Me.pInfoTable.RowCount = 11
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
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pInfoTable.Size = New System.Drawing.Size(352, 812)
        Me.pInfoTable.TabIndex = 2
        '
        'sexLabel
        '
        Me.sexLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sexLabel.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.sexLabel.Location = New System.Drawing.Point(3, 83)
        Me.sexLabel.Name = "sexLabel"
        Me.sexLabel.Size = New System.Drawing.Size(346, 34)
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
        Me.nameLabel.Size = New System.Drawing.Size(346, 34)
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
        Me.ageLabel.Size = New System.Drawing.Size(346, 34)
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
        Me.countLabel.Size = New System.Drawing.Size(346, 34)
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
        Me.lastVisitLabel.Size = New System.Drawing.Size(346, 34)
        Me.lastVisitLabel.TabIndex = 1
        Me.lastVisitLabel.Text = "前次就診日期:"
        Me.lastVisitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lastVisitLabel.UseSelectable = True
        '
        'pName
        '
        '
        '
        '
        Me.pName.CustomButton.Image = Nothing
        Me.pName.CustomButton.Location = New System.Drawing.Point(314, 2)
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
        Me.pName.Size = New System.Drawing.Size(346, 34)
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
        Me.pSex.CustomButton.Location = New System.Drawing.Point(314, 2)
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
        Me.pSex.Size = New System.Drawing.Size(346, 34)
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
        Me.pAge.CustomButton.Location = New System.Drawing.Point(314, 2)
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
        Me.pAge.Size = New System.Drawing.Size(346, 34)
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
        Me.pVisitTimes.CustomButton.Location = New System.Drawing.Point(314, 2)
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
        Me.pVisitTimes.Size = New System.Drawing.Size(346, 34)
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
        Me.pPrevVisit.CustomButton.Location = New System.Drawing.Point(314, 2)
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
        Me.pPrevVisit.Size = New System.Drawing.Size(346, 34)
        Me.pPrevVisit.TabIndex = 4
        Me.pPrevVisit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pPrevVisit.UseSelectable = True
        Me.pPrevVisit.WaterMark = "不顯示"
        Me.pPrevVisit.WaterMarkColor = System.Drawing.Color.Silver
        Me.pPrevVisit.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        '
        'tabBooking
        '
        Me.tabBooking.Controls.Add(Me.waitingList)
        Me.tabBooking.Location = New System.Drawing.Point(4, 44)
        Me.tabBooking.Name = "tabBooking"
        Me.tabBooking.Size = New System.Drawing.Size(352, 812)
        Me.tabBooking.TabIndex = 1
        Me.tabBooking.Text = "等候清單"
        '
        'waitingList
        '
        Me.waitingList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.waitingList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.waitingList.FormattingEnabled = True
        Me.waitingList.ItemHeight = 20
        Me.waitingList.Location = New System.Drawing.Point(0, 0)
        Me.waitingList.Name = "waitingList"
        Me.waitingList.Size = New System.Drawing.Size(352, 812)
        Me.waitingList.TabIndex = 0
        '
        'pnlEms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.diagTab)
        Me.Controls.Add(Me.pInfoPanel)
        Me.Name = "pnlEms"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 400, 0)
        Me.Size = New System.Drawing.Size(1800, 900)
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
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.graphTab.ResumeLayout(False)
        Me.tabEms.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.tabCheck.ResumeLayout(False)
        Me.caliTable.ResumeLayout(False)
        Me.caliTable.PerformLayout()
        Me.tabEnergy.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.pInfoPanel.ResumeLayout(False)
        Me.patientTab.ResumeLayout(False)
        Me.tabPatientInfo.ResumeLayout(False)
        Me.pInfoTable.ResumeLayout(False)
        Me.tabBooking.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InstantDoCtrl1 As Automation.BDaq.InstantDoCtrl
    Friend WithEvents emsTimer As Timer
    Friend WithEvents pInfoPanel As Panel
    Friend WithEvents diagTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabGraph As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents InstantAiCtrl1 As Automation.BDaq.InstantAiCtrl
    Friend WithEvents diagPanel As Panel
    Friend WithEvents pb As PictureBox
    Friend WithEvents graphTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabEms As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ptBox As ComboBox
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
    Friend WithEvents openPanelLink As MetroFramework.Controls.MetroLink
    Friend WithEvents measurePoint As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents top_pos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents bot_pos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents left_pos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents right_pos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents diagLeft As MetroFramework.Controls.MetroTextBox
    Friend WithEvents diagRight As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents topArea As MetroFramework.Controls.MetroTextBox
    Friend WithEvents botArea As MetroFramework.Controls.MetroTextBox
    Friend WithEvents leftArea As MetroFramework.Controls.MetroTextBox
    Friend WithEvents rightArea As MetroFramework.Controls.MetroTextBox
    Friend WithEvents totalPercentage As MetroFramework.Controls.MetroTextBox
    Friend WithEvents patientTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabPatientInfo As TabPage
    Friend WithEvents pInfoTable As TableLayoutPanel
    Friend WithEvents sexLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents nameLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents ageLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents countLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents lastVisitLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents pName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pSex As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pAge As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pVisitTimes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pPrevVisit As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tabBooking As TabPage
    Friend WithEvents waitingList As ListBox
    Friend WithEvents txtDevValue As Label
    Friend WithEvents txtMaxValue As Label
    Friend WithEvents txtEvaValue As Label
    Friend WithEvents Label3 As Label
End Class
