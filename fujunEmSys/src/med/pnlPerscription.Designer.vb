﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pnlPerscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlPerscription))
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.printPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.printDlg = New System.Windows.Forms.PrintDialog()
        Me.medTabs = New MetroFramework.Controls.MetroTabControl()
        Me.tabDetail = New MetroFramework.Controls.MetroTabPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.pastRecordBox = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.concernText = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.otherExamBox = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.responseText = New MetroFramework.Controls.MetroTextBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.subICD10Button = New MetroFramework.Controls.MetroButton()
        Me.mainICD10Button = New MetroFramework.Controls.MetroButton()
        Me.geneButton = New MetroFramework.Controls.MetroButton()
        Me.fluButton = New MetroFramework.Controls.MetroButton()
        Me.careButton = New MetroFramework.Controls.MetroButton()
        Me.ICDList = New System.Windows.Forms.ListBox()
        Me.tabMedSetup = New System.Windows.Forms.TabPage()
        Me.fullMedGroupTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.medGroupTable = New System.Windows.Forms.TableLayoutPanel()
        Me.displayDosageCheckBox = New System.Windows.Forms.CheckBox()
        Me.hisMedGroupGrid = New System.Windows.Forms.DataGridView()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.groupSetupTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.medGroupUnitLabel = New MetroFramework.Controls.MetroLabel()
        Me.multiple = New System.Windows.Forms.CheckBox()
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
        Me.medGroupGrid = New System.Windows.Forms.DataGridView()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.medGroupLabel = New MetroFramework.Controls.MetroLabel()
        Me.delMedGroup = New MetroFramework.Controls.MetroButton()
        Me.addMedGroup = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.displayHistoryCheckbox = New System.Windows.Forms.CheckBox()
        Me.historyCombo = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.copyAllButton = New MetroFramework.Controls.MetroButton()
        Me.copyButton = New MetroFramework.Controls.MetroButton()
        Me.medDetailPanel = New MetroFramework.Controls.MetroPanel()
        Me.delMedDetail = New MetroFramework.Controls.MetroButton()
        Me.addMedDetail = New MetroFramework.Controls.MetroButton()
        Me.medListTable = New System.Windows.Forms.TableLayoutPanel()
        Me.medDetailAmount = New MetroFramework.Controls.MetroTextBox()
        Me.medDetailChange = New MetroFramework.Controls.MetroButton()
        Me.medDetailUnit = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.medDetailLabel = New MetroFramework.Controls.MetroLabel()
        Me.medDetailGrid = New System.Windows.Forms.DataGridView()
        Me.displayMedInfoCheckBox = New System.Windows.Forms.CheckBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.searchTable = New System.Windows.Forms.TableLayoutPanel()
        Me.searchBox = New MetroFramework.Controls.MetroTextBox()
        Me.unusedMedList = New MetroFramework.Controls.MetroCheckBox()
        Me.medTree = New System.Windows.Forms.TreeView()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.tabFull = New System.Windows.Forms.TabPage()
        Me.fullListTable = New System.Windows.Forms.TableLayoutPanel()
        Me.fullListView = New System.Windows.Forms.DataGridView()
        Me.historyBox = New System.Windows.Forms.ListBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.printMedButton = New MetroFramework.Controls.MetroButton()
        Me.printSingle = New MetroFramework.Controls.MetroButton()
        Me.pInfoPanel = New System.Windows.Forms.Panel()
        Me.patientTab = New MetroFramework.Controls.MetroTabControl()
        Me.tabPatientInfo = New System.Windows.Forms.TabPage()
        Me.pInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.pID = New MetroFramework.Controls.MetroTextBox()
        Me.altGeneButton = New MetroFramework.Controls.MetroButton()
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
        Me.refreshWaitingListButton = New MetroFramework.Controls.MetroButton()
        Me.checkDate = New MetroFramework.Controls.MetroDateTime()
        Me.waitingList = New System.Windows.Forms.ListBox()
        Me.medTable = New System.Windows.Forms.TableLayoutPanel()
        Me.displayPatientCheckBox = New System.Windows.Forms.CheckBox()
        Me.medTabs.SuspendLayout()
        Me.tabDetail.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.tabMedSetup.SuspendLayout()
        Me.fullMedGroupTable.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.medGroupTable.SuspendLayout()
        CType(Me.hisMedGroupGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel3.SuspendLayout()
        Me.groupSetupTable.SuspendLayout()
        CType(Me.medGroupGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel4.SuspendLayout()
        Me.MetroPanel5.SuspendLayout()
        Me.medDetailPanel.SuspendLayout()
        Me.medListTable.SuspendLayout()
        CType(Me.medDetailGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.searchTable.SuspendLayout()
        Me.tabFull.SuspendLayout()
        Me.fullListTable.SuspendLayout()
        CType(Me.fullListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pInfoPanel.SuspendLayout()
        Me.patientTab.SuspendLayout()
        Me.tabPatientInfo.SuspendLayout()
        Me.pInfoTable.SuspendLayout()
        Me.tabBooking.SuspendLayout()
        Me.medTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.Location = New System.Drawing.Point(130, 130)
        '
        'printDoc
        '
        '
        'printPreview
        '
        Me.printPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreview.Document = Me.printDoc
        Me.printPreview.Enabled = True
        Me.printPreview.Icon = CType(resources.GetObject("printPreview.Icon"), System.Drawing.Icon)
        Me.printPreview.Name = "printPreview"
        Me.printPreview.Visible = False
        '
        'printDlg
        '
        Me.printDlg.Document = Me.printDoc
        Me.printDlg.UseEXDialog = True
        '
        'medTabs
        '
        Me.medTabs.Controls.Add(Me.tabDetail)
        Me.medTabs.Controls.Add(Me.tabMedSetup)
        Me.medTabs.Controls.Add(Me.tabFull)
        Me.medTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medTabs.Enabled = False
        Me.medTabs.Location = New System.Drawing.Point(3, 3)
        Me.medTabs.Name = "medTabs"
        Me.medTabs.SelectedIndex = 0
        Me.medTabs.Size = New System.Drawing.Size(947, 680)
        Me.medTabs.TabIndex = 13
        Me.medTabs.UseSelectable = True
        '
        'tabDetail
        '
        Me.tabDetail.Controls.Add(Me.TableLayoutPanel6)
        Me.tabDetail.Controls.Add(Me.TableLayoutPanel7)
        Me.tabDetail.HorizontalScrollbarBarColor = True
        Me.tabDetail.HorizontalScrollbarHighlightOnWheel = False
        Me.tabDetail.HorizontalScrollbarSize = 10
        Me.tabDetail.Location = New System.Drawing.Point(4, 38)
        Me.tabDetail.Name = "tabDetail"
        Me.tabDetail.Size = New System.Drawing.Size(939, 638)
        Me.tabDetail.TabIndex = 2
        Me.tabDetail.Text = "病史資訊"
        Me.tabDetail.VerticalScrollbarBarColor = True
        Me.tabDetail.VerticalScrollbarHighlightOnWheel = False
        Me.tabDetail.VerticalScrollbarSize = 10
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox2, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.GroupBox4, 0, 2)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(350, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 4
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(589, 635)
        Me.TableLayoutPanel6.TabIndex = 16
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox3.Controls.Add(Me.pastRecordBox)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox3.Size = New System.Drawing.Size(583, 152)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "過去病史"
        '
        'pastRecordBox
        '
        '
        '
        '
        Me.pastRecordBox.CustomButton.Image = Nothing
        Me.pastRecordBox.CustomButton.Location = New System.Drawing.Point(459, 2)
        Me.pastRecordBox.CustomButton.Name = ""
        Me.pastRecordBox.CustomButton.Size = New System.Drawing.Size(101, 101)
        Me.pastRecordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pastRecordBox.CustomButton.TabIndex = 1
        Me.pastRecordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pastRecordBox.CustomButton.UseSelectable = True
        Me.pastRecordBox.CustomButton.Visible = False
        Me.pastRecordBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pastRecordBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pastRecordBox.Lines = New String(-1) {}
        Me.pastRecordBox.Location = New System.Drawing.Point(10, 36)
        Me.pastRecordBox.MaxLength = 32767
        Me.pastRecordBox.Multiline = True
        Me.pastRecordBox.Name = "pastRecordBox"
        Me.pastRecordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pastRecordBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.pastRecordBox.SelectedText = ""
        Me.pastRecordBox.SelectionLength = 0
        Me.pastRecordBox.SelectionStart = 0
        Me.pastRecordBox.ShortcutsEnabled = True
        Me.pastRecordBox.Size = New System.Drawing.Size(563, 106)
        Me.pastRecordBox.TabIndex = 0
        Me.pastRecordBox.UseSelectable = True
        Me.pastRecordBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.pastRecordBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox1.Controls.Add(Me.concernText)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(583, 152)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "主訴"
        '
        'concernText
        '
        '
        '
        '
        Me.concernText.CustomButton.Image = Nothing
        Me.concernText.CustomButton.Location = New System.Drawing.Point(459, 2)
        Me.concernText.CustomButton.Name = ""
        Me.concernText.CustomButton.Size = New System.Drawing.Size(101, 101)
        Me.concernText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.concernText.CustomButton.TabIndex = 1
        Me.concernText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.concernText.CustomButton.UseSelectable = True
        Me.concernText.CustomButton.Visible = False
        Me.concernText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.concernText.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.concernText.Lines = New String(-1) {}
        Me.concernText.Location = New System.Drawing.Point(10, 36)
        Me.concernText.MaxLength = 32767
        Me.concernText.Multiline = True
        Me.concernText.Name = "concernText"
        Me.concernText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.concernText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.concernText.SelectedText = ""
        Me.concernText.SelectionLength = 0
        Me.concernText.SelectionStart = 0
        Me.concernText.ShortcutsEnabled = True
        Me.concernText.Size = New System.Drawing.Size(563, 106)
        Me.concernText.TabIndex = 0
        Me.concernText.UseSelectable = True
        Me.concernText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.concernText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox2.Controls.Add(Me.otherExamBox)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 477)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Size = New System.Drawing.Size(583, 155)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "他院檢查紀錄"
        '
        'otherExamBox
        '
        '
        '
        '
        Me.otherExamBox.CustomButton.Image = Nothing
        Me.otherExamBox.CustomButton.Location = New System.Drawing.Point(455, 1)
        Me.otherExamBox.CustomButton.Name = ""
        Me.otherExamBox.CustomButton.Size = New System.Drawing.Size(107, 107)
        Me.otherExamBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.otherExamBox.CustomButton.TabIndex = 1
        Me.otherExamBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.otherExamBox.CustomButton.UseSelectable = True
        Me.otherExamBox.CustomButton.Visible = False
        Me.otherExamBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.otherExamBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.otherExamBox.Lines = New String(-1) {}
        Me.otherExamBox.Location = New System.Drawing.Point(10, 36)
        Me.otherExamBox.MaxLength = 32767
        Me.otherExamBox.Multiline = True
        Me.otherExamBox.Name = "otherExamBox"
        Me.otherExamBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.otherExamBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.otherExamBox.SelectedText = ""
        Me.otherExamBox.SelectionLength = 0
        Me.otherExamBox.SelectionStart = 0
        Me.otherExamBox.ShortcutsEnabled = True
        Me.otherExamBox.Size = New System.Drawing.Size(563, 109)
        Me.otherExamBox.TabIndex = 0
        Me.otherExamBox.UseSelectable = True
        Me.otherExamBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.otherExamBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox4.Controls.Add(Me.responseText)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 319)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox4.Size = New System.Drawing.Size(583, 152)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "醫囑"
        '
        'responseText
        '
        '
        '
        '
        Me.responseText.CustomButton.Image = Nothing
        Me.responseText.CustomButton.Location = New System.Drawing.Point(459, 2)
        Me.responseText.CustomButton.Name = ""
        Me.responseText.CustomButton.Size = New System.Drawing.Size(101, 101)
        Me.responseText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.responseText.CustomButton.TabIndex = 1
        Me.responseText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.responseText.CustomButton.UseSelectable = True
        Me.responseText.CustomButton.Visible = False
        Me.responseText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.responseText.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.responseText.Lines = New String(-1) {}
        Me.responseText.Location = New System.Drawing.Point(10, 36)
        Me.responseText.MaxLength = 32767
        Me.responseText.Multiline = True
        Me.responseText.Name = "responseText"
        Me.responseText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.responseText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.responseText.SelectedText = ""
        Me.responseText.SelectionLength = 0
        Me.responseText.SelectionStart = 0
        Me.responseText.ShortcutsEnabled = True
        Me.responseText.Size = New System.Drawing.Size(563, 106)
        Me.responseText.TabIndex = 0
        Me.responseText.UseSelectable = True
        Me.responseText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.responseText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.subICD10Button, 0, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.mainICD10Button, 0, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.geneButton, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.fluButton, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.careButton, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.ICDList, 0, 4)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 6
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(350, 635)
        Me.TableLayoutPanel7.TabIndex = 15
        '
        'subICD10Button
        '
        Me.subICD10Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subICD10Button.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.subICD10Button.Location = New System.Drawing.Point(3, 578)
        Me.subICD10Button.Name = "subICD10Button"
        Me.subICD10Button.Size = New System.Drawing.Size(344, 54)
        Me.subICD10Button.TabIndex = 8
        Me.subICD10Button.Text = "副病名設定"
        Me.subICD10Button.UseSelectable = True
        '
        'mainICD10Button
        '
        Me.mainICD10Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainICD10Button.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.mainICD10Button.Location = New System.Drawing.Point(3, 183)
        Me.mainICD10Button.Name = "mainICD10Button"
        Me.mainICD10Button.Size = New System.Drawing.Size(344, 54)
        Me.mainICD10Button.TabIndex = 7
        Me.mainICD10Button.Text = "主病名設定"
        Me.mainICD10Button.UseSelectable = True
        '
        'geneButton
        '
        Me.geneButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.geneButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.geneButton.Location = New System.Drawing.Point(3, 3)
        Me.geneButton.Name = "geneButton"
        Me.geneButton.Size = New System.Drawing.Size(344, 54)
        Me.geneButton.TabIndex = 5
        Me.geneButton.Text = "基因設定"
        Me.geneButton.UseSelectable = True
        '
        'fluButton
        '
        Me.fluButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fluButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.fluButton.Location = New System.Drawing.Point(3, 63)
        Me.fluButton.Name = "fluButton"
        Me.fluButton.Size = New System.Drawing.Size(344, 54)
        Me.fluButton.TabIndex = 5
        Me.fluButton.Text = "時疫設定"
        Me.fluButton.UseSelectable = True
        '
        'careButton
        '
        Me.careButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.careButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.careButton.Location = New System.Drawing.Point(3, 123)
        Me.careButton.Name = "careButton"
        Me.careButton.Size = New System.Drawing.Size(344, 54)
        Me.careButton.TabIndex = 6
        Me.careButton.Text = "保養設定"
        Me.careButton.UseSelectable = True
        '
        'ICDList
        '
        Me.ICDList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ICDList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ICDList.FormattingEnabled = True
        Me.ICDList.ItemHeight = 20
        Me.ICDList.Location = New System.Drawing.Point(3, 243)
        Me.ICDList.Name = "ICDList"
        Me.ICDList.Size = New System.Drawing.Size(344, 329)
        Me.ICDList.TabIndex = 9
        '
        'tabMedSetup
        '
        Me.tabMedSetup.Controls.Add(Me.fullMedGroupTable)
        Me.tabMedSetup.Location = New System.Drawing.Point(4, 38)
        Me.tabMedSetup.Name = "tabMedSetup"
        Me.tabMedSetup.Size = New System.Drawing.Size(939, 638)
        Me.tabMedSetup.TabIndex = 0
        Me.tabMedSetup.Text = "藥包設定"
        '
        'fullMedGroupTable
        '
        Me.fullMedGroupTable.ColumnCount = 3
        Me.fullMedGroupTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.fullMedGroupTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.fullMedGroupTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.fullMedGroupTable.Controls.Add(Me.MetroPanel1, 0, 0)
        Me.fullMedGroupTable.Controls.Add(Me.medDetailPanel, 2, 0)
        Me.fullMedGroupTable.Controls.Add(Me.displayMedInfoCheckBox, 1, 0)
        Me.fullMedGroupTable.Controls.Add(Me.MetroPanel2, 2, 1)
        Me.fullMedGroupTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fullMedGroupTable.Location = New System.Drawing.Point(0, 0)
        Me.fullMedGroupTable.Name = "fullMedGroupTable"
        Me.fullMedGroupTable.RowCount = 2
        Me.fullMedGroupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fullMedGroupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.fullMedGroupTable.Size = New System.Drawing.Size(939, 638)
        Me.fullMedGroupTable.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.DarkCyan
        Me.MetroPanel1.Controls.Add(Me.medGroupTable)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.fullMedGroupTable.SetRowSpan(Me.MetroPanel1, 2)
        Me.MetroPanel1.Size = New System.Drawing.Size(637, 632)
        Me.MetroPanel1.TabIndex = 12
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'medGroupTable
        '
        Me.medGroupTable.ColumnCount = 1
        Me.medGroupTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.medGroupTable.Controls.Add(Me.displayDosageCheckBox, 0, 4)
        Me.medGroupTable.Controls.Add(Me.hisMedGroupGrid, 0, 3)
        Me.medGroupTable.Controls.Add(Me.MetroPanel3, 0, 5)
        Me.medGroupTable.Controls.Add(Me.medGroupGrid, 0, 1)
        Me.medGroupTable.Controls.Add(Me.MetroPanel4, 0, 0)
        Me.medGroupTable.Controls.Add(Me.MetroPanel5, 0, 2)
        Me.medGroupTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medGroupTable.Location = New System.Drawing.Point(3, 3)
        Me.medGroupTable.Name = "medGroupTable"
        Me.medGroupTable.RowCount = 6
        Me.medGroupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.medGroupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.medGroupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.medGroupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.medGroupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.medGroupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.medGroupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.medGroupTable.Size = New System.Drawing.Size(631, 626)
        Me.medGroupTable.TabIndex = 16
        '
        'displayDosageCheckBox
        '
        Me.displayDosageCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.displayDosageCheckBox.AutoSize = True
        Me.displayDosageCheckBox.Checked = True
        Me.displayDosageCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.displayDosageCheckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.displayDosageCheckBox.Location = New System.Drawing.Point(0, 426)
        Me.displayDosageCheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.displayDosageCheckBox.Name = "displayDosageCheckBox"
        Me.displayDosageCheckBox.Size = New System.Drawing.Size(631, 20)
        Me.displayDosageCheckBox.TabIndex = 18
        Me.displayDosageCheckBox.Text = "vvvv"
        Me.displayDosageCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.displayDosageCheckBox.UseVisualStyleBackColor = True
        '
        'hisMedGroupGrid
        '
        Me.hisMedGroupGrid.AllowUserToAddRows = False
        Me.hisMedGroupGrid.AllowUserToDeleteRows = False
        Me.hisMedGroupGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.hisMedGroupGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.hisMedGroupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.hisMedGroupGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hisMedGroupGrid.Location = New System.Drawing.Point(3, 256)
        Me.hisMedGroupGrid.MultiSelect = False
        Me.hisMedGroupGrid.Name = "hisMedGroupGrid"
        Me.hisMedGroupGrid.ReadOnly = True
        Me.hisMedGroupGrid.RowTemplate.Height = 24
        Me.hisMedGroupGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.hisMedGroupGrid.Size = New System.Drawing.Size(625, 167)
        Me.hisMedGroupGrid.TabIndex = 16
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BackColor = System.Drawing.Color.DarkCyan
        Me.MetroPanel3.Controls.Add(Me.groupSetupTable)
        Me.MetroPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(3, 449)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(625, 174)
        Me.MetroPanel3.TabIndex = 13
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'groupSetupTable
        '
        Me.groupSetupTable.ColumnCount = 5
        Me.groupSetupTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.groupSetupTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.groupSetupTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.groupSetupTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.groupSetupTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.groupSetupTable.Controls.Add(Me.MetroLabel8, 0, 3)
        Me.groupSetupTable.Controls.Add(Me.MetroTextBox1, 1, 3)
        Me.groupSetupTable.Controls.Add(Me.medGroupUnitLabel, 2, 3)
        Me.groupSetupTable.Controls.Add(Me.multiple, 4, 1)
        Me.groupSetupTable.Controls.Add(Me.MetroLabel4, 0, 2)
        Me.groupSetupTable.Controls.Add(Me.medGroupAmount, 1, 2)
        Me.groupSetupTable.Controls.Add(Me.F0, 3, 1)
        Me.groupSetupTable.Controls.Add(Me.afterMeal, 1, 1)
        Me.groupSetupTable.Controls.Add(Me.morning, 0, 0)
        Me.groupSetupTable.Controls.Add(Me.noon, 1, 0)
        Me.groupSetupTable.Controls.Add(Me.night, 2, 0)
        Me.groupSetupTable.Controls.Add(Me.beforeSleep, 3, 0)
        Me.groupSetupTable.Controls.Add(Me.beforeMeal, 0, 1)
        Me.groupSetupTable.Controls.Add(Me.makePill, 2, 1)
        Me.groupSetupTable.Controls.Add(Me.notWell, 4, 0)
        Me.groupSetupTable.Controls.Add(Me.MetroLabel1, 3, 2)
        Me.groupSetupTable.Controls.Add(Me.medGroupDays, 4, 2)
        Me.groupSetupTable.Controls.Add(Me.medGroupChange, 4, 3)
        Me.groupSetupTable.Controls.Add(Me.medGroupUnit, 2, 2)
        Me.groupSetupTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupSetupTable.Location = New System.Drawing.Point(0, 0)
        Me.groupSetupTable.Name = "groupSetupTable"
        Me.groupSetupTable.RowCount = 4
        Me.groupSetupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.groupSetupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.groupSetupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.groupSetupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.groupSetupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.groupSetupTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.groupSetupTable.Size = New System.Drawing.Size(625, 174)
        Me.groupSetupTable.TabIndex = 12
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.ForeColor = System.Drawing.Color.White
        Me.MetroLabel8.Location = New System.Drawing.Point(3, 134)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(119, 40)
        Me.MetroLabel8.TabIndex = 13
        Me.MetroLabel8.Text = "多藥"
        Me.MetroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLabel8.UseCustomBackColor = True
        Me.MetroLabel8.UseCustomForeColor = True
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(91, 2)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox1.Lines = New String() {"1"}
        Me.MetroTextBox1.Location = New System.Drawing.Point(128, 139)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.PromptText = "天數"
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(119, 30)
        Me.MetroTextBox1.TabIndex = 12
        Me.MetroTextBox1.Text = "1"
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "天數"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'medGroupUnitLabel
        '
        Me.medGroupUnitLabel.AutoSize = True
        Me.medGroupUnitLabel.BackColor = System.Drawing.Color.Transparent
        Me.medGroupUnitLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medGroupUnitLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.medGroupUnitLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.medGroupUnitLabel.ForeColor = System.Drawing.Color.White
        Me.medGroupUnitLabel.Location = New System.Drawing.Point(253, 134)
        Me.medGroupUnitLabel.Name = "medGroupUnitLabel"
        Me.medGroupUnitLabel.Size = New System.Drawing.Size(119, 40)
        Me.medGroupUnitLabel.TabIndex = 11
        Me.medGroupUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.medGroupUnitLabel.UseCustomBackColor = True
        Me.medGroupUnitLabel.UseCustomForeColor = True
        '
        'multiple
        '
        Me.multiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.multiple.AutoSize = True
        Me.multiple.BackColor = System.Drawing.Color.CornflowerBlue
        Me.multiple.Dock = System.Windows.Forms.DockStyle.Fill
        Me.multiple.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.multiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.multiple.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.multiple.ForeColor = System.Drawing.Color.Transparent
        Me.multiple.Location = New System.Drawing.Point(503, 50)
        Me.multiple.Name = "multiple"
        Me.multiple.Size = New System.Drawing.Size(119, 41)
        Me.multiple.TabIndex = 10
        Me.multiple.Text = "多次"
        Me.multiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.multiple.UseVisualStyleBackColor = False
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.ForeColor = System.Drawing.Color.White
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 94)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(119, 40)
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "份量"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        '
        'medGroupAmount
        '
        Me.medGroupAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.medGroupAmount.CustomButton.Image = Nothing
        Me.medGroupAmount.CustomButton.Location = New System.Drawing.Point(91, 2)
        Me.medGroupAmount.CustomButton.Name = ""
        Me.medGroupAmount.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.medGroupAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.medGroupAmount.CustomButton.TabIndex = 1
        Me.medGroupAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.medGroupAmount.CustomButton.UseSelectable = True
        Me.medGroupAmount.CustomButton.Visible = False
        Me.medGroupAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.medGroupAmount.Lines = New String() {"1"}
        Me.medGroupAmount.Location = New System.Drawing.Point(128, 99)
        Me.medGroupAmount.MaxLength = 32767
        Me.medGroupAmount.Name = "medGroupAmount"
        Me.medGroupAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medGroupAmount.PromptText = "天數"
        Me.medGroupAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.medGroupAmount.SelectedText = ""
        Me.medGroupAmount.SelectionLength = 0
        Me.medGroupAmount.SelectionStart = 0
        Me.medGroupAmount.ShortcutsEnabled = True
        Me.medGroupAmount.Size = New System.Drawing.Size(119, 30)
        Me.medGroupAmount.TabIndex = 8
        Me.medGroupAmount.Text = "1"
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
        Me.F0.Location = New System.Drawing.Point(378, 50)
        Me.F0.Name = "F0"
        Me.F0.Size = New System.Drawing.Size(119, 41)
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
        Me.afterMeal.Location = New System.Drawing.Point(128, 50)
        Me.afterMeal.Name = "afterMeal"
        Me.afterMeal.Size = New System.Drawing.Size(119, 41)
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
        Me.morning.Size = New System.Drawing.Size(119, 41)
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
        Me.noon.Location = New System.Drawing.Point(128, 3)
        Me.noon.Name = "noon"
        Me.noon.Size = New System.Drawing.Size(119, 41)
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
        Me.night.Location = New System.Drawing.Point(253, 3)
        Me.night.Name = "night"
        Me.night.Size = New System.Drawing.Size(119, 41)
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
        Me.beforeSleep.Location = New System.Drawing.Point(378, 3)
        Me.beforeSleep.Name = "beforeSleep"
        Me.beforeSleep.Size = New System.Drawing.Size(119, 41)
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
        Me.beforeMeal.Location = New System.Drawing.Point(3, 50)
        Me.beforeMeal.Name = "beforeMeal"
        Me.beforeMeal.Size = New System.Drawing.Size(119, 41)
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
        Me.makePill.Location = New System.Drawing.Point(253, 50)
        Me.makePill.Name = "makePill"
        Me.makePill.Size = New System.Drawing.Size(119, 41)
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
        Me.notWell.Location = New System.Drawing.Point(503, 3)
        Me.notWell.Name = "notWell"
        Me.notWell.Size = New System.Drawing.Size(119, 41)
        Me.notWell.TabIndex = 1
        Me.notWell.Text = "症發"
        Me.notWell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.notWell.UseVisualStyleBackColor = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.White
        Me.MetroLabel1.Location = New System.Drawing.Point(378, 94)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(119, 40)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "天數"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'medGroupDays
        '
        Me.medGroupDays.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.medGroupDays.CustomButton.Image = Nothing
        Me.medGroupDays.CustomButton.Location = New System.Drawing.Point(91, 2)
        Me.medGroupDays.CustomButton.Name = ""
        Me.medGroupDays.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.medGroupDays.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.medGroupDays.CustomButton.TabIndex = 1
        Me.medGroupDays.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.medGroupDays.CustomButton.UseSelectable = True
        Me.medGroupDays.CustomButton.Visible = False
        Me.medGroupDays.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.medGroupDays.Lines = New String() {"14"}
        Me.medGroupDays.Location = New System.Drawing.Point(503, 99)
        Me.medGroupDays.MaxLength = 32767
        Me.medGroupDays.Name = "medGroupDays"
        Me.medGroupDays.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medGroupDays.PromptText = "天數"
        Me.medGroupDays.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.medGroupDays.SelectedText = ""
        Me.medGroupDays.SelectionLength = 0
        Me.medGroupDays.SelectionStart = 0
        Me.medGroupDays.ShortcutsEnabled = True
        Me.medGroupDays.Size = New System.Drawing.Size(119, 30)
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
        Me.medGroupChange.Location = New System.Drawing.Point(503, 137)
        Me.medGroupChange.Name = "medGroupChange"
        Me.medGroupChange.Size = New System.Drawing.Size(119, 34)
        Me.medGroupChange.TabIndex = 6
        Me.medGroupChange.Text = "變更"
        Me.medGroupChange.UseSelectable = True
        '
        'medGroupUnit
        '
        Me.medGroupUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medGroupUnit.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.medGroupUnit.FormattingEnabled = True
        Me.medGroupUnit.ItemHeight = 29
        Me.medGroupUnit.Location = New System.Drawing.Point(253, 97)
        Me.medGroupUnit.Name = "medGroupUnit"
        Me.medGroupUnit.Size = New System.Drawing.Size(119, 35)
        Me.medGroupUnit.TabIndex = 9
        Me.medGroupUnit.UseSelectable = True
        '
        'medGroupGrid
        '
        Me.medGroupGrid.AllowUserToAddRows = False
        Me.medGroupGrid.AllowUserToDeleteRows = False
        Me.medGroupGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.medGroupGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.medGroupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.medGroupGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medGroupGrid.Location = New System.Drawing.Point(3, 43)
        Me.medGroupGrid.MultiSelect = False
        Me.medGroupGrid.Name = "medGroupGrid"
        Me.medGroupGrid.ReadOnly = True
        Me.medGroupGrid.RowTemplate.Height = 24
        Me.medGroupGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.medGroupGrid.Size = New System.Drawing.Size(625, 167)
        Me.medGroupGrid.TabIndex = 14
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Controls.Add(Me.medGroupLabel)
        Me.MetroPanel4.Controls.Add(Me.delMedGroup)
        Me.MetroPanel4.Controls.Add(Me.addMedGroup)
        Me.MetroPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(631, 40)
        Me.MetroPanel4.TabIndex = 15
        Me.MetroPanel4.UseCustomBackColor = True
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'medGroupLabel
        '
        Me.medGroupLabel.AutoSize = True
        Me.medGroupLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.medGroupLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.medGroupLabel.ForeColor = System.Drawing.Color.White
        Me.medGroupLabel.Location = New System.Drawing.Point(3, 9)
        Me.medGroupLabel.Name = "medGroupLabel"
        Me.medGroupLabel.Size = New System.Drawing.Size(92, 25)
        Me.medGroupLabel.TabIndex = 13
        Me.medGroupLabel.Text = "藥物群組"
        Me.medGroupLabel.UseCustomBackColor = True
        Me.medGroupLabel.UseCustomForeColor = True
        '
        'delMedGroup
        '
        Me.delMedGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delMedGroup.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.delMedGroup.Location = New System.Drawing.Point(573, 5)
        Me.delMedGroup.Name = "delMedGroup"
        Me.delMedGroup.Size = New System.Drawing.Size(55, 32)
        Me.delMedGroup.TabIndex = 15
        Me.delMedGroup.Text = "刪除"
        Me.delMedGroup.UseSelectable = True
        '
        'addMedGroup
        '
        Me.addMedGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addMedGroup.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.addMedGroup.Location = New System.Drawing.Point(515, 5)
        Me.addMedGroup.Name = "addMedGroup"
        Me.addMedGroup.Size = New System.Drawing.Size(55, 32)
        Me.addMedGroup.TabIndex = 15
        Me.addMedGroup.Text = "新增"
        Me.addMedGroup.UseSelectable = True
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Controls.Add(Me.displayHistoryCheckbox)
        Me.MetroPanel5.Controls.Add(Me.historyCombo)
        Me.MetroPanel5.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel5.Controls.Add(Me.copyAllButton)
        Me.MetroPanel5.Controls.Add(Me.copyButton)
        Me.MetroPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(3, 216)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(625, 34)
        Me.MetroPanel5.TabIndex = 17
        Me.MetroPanel5.UseCustomBackColor = True
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
        '
        'displayHistoryCheckbox
        '
        Me.displayHistoryCheckbox.Appearance = System.Windows.Forms.Appearance.Button
        Me.displayHistoryCheckbox.Checked = True
        Me.displayHistoryCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.displayHistoryCheckbox.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Bold)
        Me.displayHistoryCheckbox.Location = New System.Drawing.Point(266, 3)
        Me.displayHistoryCheckbox.Name = "displayHistoryCheckbox"
        Me.displayHistoryCheckbox.Size = New System.Drawing.Size(55, 32)
        Me.displayHistoryCheckbox.TabIndex = 16
        Me.displayHistoryCheckbox.Text = "隱藏"
        Me.displayHistoryCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.displayHistoryCheckbox.UseVisualStyleBackColor = True
        '
        'historyCombo
        '
        Me.historyCombo.FormattingEnabled = True
        Me.historyCombo.ItemHeight = 23
        Me.historyCombo.Location = New System.Drawing.Point(89, 5)
        Me.historyCombo.Name = "historyCombo"
        Me.historyCombo.Size = New System.Drawing.Size(171, 29)
        Me.historyCombo.TabIndex = 14
        Me.historyCombo.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.ForeColor = System.Drawing.Color.White
        Me.MetroLabel5.Location = New System.Drawing.Point(0, 9)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(92, 25)
        Me.MetroLabel5.TabIndex = 13
        Me.MetroLabel5.Text = "歷史紀錄"
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        '
        'copyAllButton
        '
        Me.copyAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copyAllButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.copyAllButton.Location = New System.Drawing.Point(512, 2)
        Me.copyAllButton.Name = "copyAllButton"
        Me.copyAllButton.Size = New System.Drawing.Size(113, 32)
        Me.copyAllButton.TabIndex = 15
        Me.copyAllButton.Text = "複製全部"
        Me.copyAllButton.UseSelectable = True
        '
        'copyButton
        '
        Me.copyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copyButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.copyButton.Location = New System.Drawing.Point(454, 2)
        Me.copyButton.Name = "copyButton"
        Me.copyButton.Size = New System.Drawing.Size(55, 32)
        Me.copyButton.TabIndex = 15
        Me.copyButton.Text = "複製"
        Me.copyButton.UseSelectable = True
        '
        'medDetailPanel
        '
        Me.medDetailPanel.BackColor = System.Drawing.Color.DimGray
        Me.medDetailPanel.Controls.Add(Me.delMedDetail)
        Me.medDetailPanel.Controls.Add(Me.addMedDetail)
        Me.medDetailPanel.Controls.Add(Me.medListTable)
        Me.medDetailPanel.Controls.Add(Me.medDetailLabel)
        Me.medDetailPanel.Controls.Add(Me.medDetailGrid)
        Me.medDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medDetailPanel.HorizontalScrollbarBarColor = True
        Me.medDetailPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.medDetailPanel.HorizontalScrollbarSize = 10
        Me.medDetailPanel.Location = New System.Drawing.Point(666, 3)
        Me.medDetailPanel.Name = "medDetailPanel"
        Me.medDetailPanel.Padding = New System.Windows.Forms.Padding(10, 50, 10, 50)
        Me.medDetailPanel.Size = New System.Drawing.Size(270, 313)
        Me.medDetailPanel.TabIndex = 12
        Me.medDetailPanel.UseCustomBackColor = True
        Me.medDetailPanel.VerticalScrollbarBarColor = True
        Me.medDetailPanel.VerticalScrollbarHighlightOnWheel = False
        Me.medDetailPanel.VerticalScrollbarSize = 10
        '
        'delMedDetail
        '
        Me.delMedDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.delMedDetail.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.delMedDetail.Location = New System.Drawing.Point(205, 15)
        Me.delMedDetail.Name = "delMedDetail"
        Me.delMedDetail.Size = New System.Drawing.Size(55, 32)
        Me.delMedDetail.TabIndex = 15
        Me.delMedDetail.Text = "刪除"
        Me.delMedDetail.UseSelectable = True
        '
        'addMedDetail
        '
        Me.addMedDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addMedDetail.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.addMedDetail.Location = New System.Drawing.Point(148, 15)
        Me.addMedDetail.Name = "addMedDetail"
        Me.addMedDetail.Size = New System.Drawing.Size(55, 32)
        Me.addMedDetail.TabIndex = 15
        Me.addMedDetail.Text = "新增"
        Me.addMedDetail.UseSelectable = True
        '
        'medListTable
        '
        Me.medListTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.medListTable.ColumnCount = 4
        Me.medListTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.medListTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.medListTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.medListTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.medListTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.medListTable.Controls.Add(Me.medDetailAmount, 1, 0)
        Me.medListTable.Controls.Add(Me.medDetailChange, 3, 0)
        Me.medListTable.Controls.Add(Me.medDetailUnit, 2, 0)
        Me.medListTable.Controls.Add(Me.MetroLabel3, 0, 0)
        Me.medListTable.Location = New System.Drawing.Point(10, 269)
        Me.medListTable.Name = "medListTable"
        Me.medListTable.RowCount = 1
        Me.medListTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.medListTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.medListTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.medListTable.Size = New System.Drawing.Size(250, 37)
        Me.medListTable.TabIndex = 13
        '
        'medDetailAmount
        '
        Me.medDetailAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.medDetailAmount.CustomButton.Image = Nothing
        Me.medDetailAmount.CustomButton.Location = New System.Drawing.Point(34, 2)
        Me.medDetailAmount.CustomButton.Name = ""
        Me.medDetailAmount.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.medDetailAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.medDetailAmount.CustomButton.TabIndex = 1
        Me.medDetailAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.medDetailAmount.CustomButton.UseSelectable = True
        Me.medDetailAmount.CustomButton.Visible = False
        Me.medDetailAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.medDetailAmount.Lines = New String() {"6"}
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
        Me.medDetailAmount.Size = New System.Drawing.Size(62, 30)
        Me.medDetailAmount.TabIndex = 5
        Me.medDetailAmount.Text = "6"
        Me.medDetailAmount.UseSelectable = True
        Me.medDetailAmount.WaterMark = "天數"
        Me.medDetailAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.medDetailAmount.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'medDetailChange
        '
        Me.medDetailChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medDetailChange.Location = New System.Drawing.Point(219, 3)
        Me.medDetailChange.Name = "medDetailChange"
        Me.medDetailChange.Size = New System.Drawing.Size(28, 34)
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
        Me.medDetailUnit.Location = New System.Drawing.Point(151, 3)
        Me.medDetailUnit.Name = "medDetailUnit"
        Me.medDetailUnit.Size = New System.Drawing.Size(62, 35)
        Me.medDetailUnit.TabIndex = 9
        Me.medDetailUnit.UseSelectable = True
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
        'medDetailLabel
        '
        Me.medDetailLabel.AutoSize = True
        Me.medDetailLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.medDetailLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.medDetailLabel.ForeColor = System.Drawing.Color.White
        Me.medDetailLabel.Location = New System.Drawing.Point(10, 22)
        Me.medDetailLabel.Name = "medDetailLabel"
        Me.medDetailLabel.Size = New System.Drawing.Size(171, 25)
        Me.medDetailLabel.TabIndex = 13
        Me.medDetailLabel.Text = "藥物清單 (一天量)"
        Me.medDetailLabel.UseCustomBackColor = True
        Me.medDetailLabel.UseCustomForeColor = True
        '
        'medDetailGrid
        '
        Me.medDetailGrid.AllowUserToAddRows = False
        Me.medDetailGrid.AllowUserToDeleteRows = False
        Me.medDetailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.medDetailGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.medDetailGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.medDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.medDetailGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medDetailGrid.Location = New System.Drawing.Point(10, 50)
        Me.medDetailGrid.MultiSelect = False
        Me.medDetailGrid.Name = "medDetailGrid"
        Me.medDetailGrid.ReadOnly = True
        Me.medDetailGrid.RowTemplate.Height = 24
        Me.medDetailGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.medDetailGrid.Size = New System.Drawing.Size(250, 213)
        Me.medDetailGrid.TabIndex = 2
        '
        'displayMedInfoCheckBox
        '
        Me.displayMedInfoCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.displayMedInfoCheckBox.AutoSize = True
        Me.displayMedInfoCheckBox.Checked = True
        Me.displayMedInfoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.displayMedInfoCheckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.displayMedInfoCheckBox.Location = New System.Drawing.Point(643, 0)
        Me.displayMedInfoCheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.displayMedInfoCheckBox.Name = "displayMedInfoCheckBox"
        Me.fullMedGroupTable.SetRowSpan(Me.displayMedInfoCheckBox, 2)
        Me.displayMedInfoCheckBox.Size = New System.Drawing.Size(20, 638)
        Me.displayMedInfoCheckBox.TabIndex = 14
        Me.displayMedInfoCheckBox.Text = ">>>>"
        Me.displayMedInfoCheckBox.UseVisualStyleBackColor = True
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
        Me.MetroPanel2.Location = New System.Drawing.Point(666, 322)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(10, 50, 10, 10)
        Me.MetroPanel2.Size = New System.Drawing.Size(270, 313)
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
        Me.searchTable.Size = New System.Drawing.Size(250, 253)
        Me.searchTable.TabIndex = 7
        '
        'searchBox
        '
        '
        '
        '
        Me.searchBox.CustomButton.Image = Nothing
        Me.searchBox.CustomButton.Location = New System.Drawing.Point(212, 2)
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
        Me.searchBox.Location = New System.Drawing.Point(3, 176)
        Me.searchBox.MaxLength = 32767
        Me.searchBox.Name = "searchBox"
        Me.searchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchBox.PromptText = "快速搜尋"
        Me.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchBox.SelectedText = ""
        Me.searchBox.SelectionLength = 0
        Me.searchBox.SelectionStart = 0
        Me.searchBox.ShortcutsEnabled = True
        Me.searchBox.Size = New System.Drawing.Size(244, 34)
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
        Me.unusedMedList.Location = New System.Drawing.Point(3, 216)
        Me.unusedMedList.Name = "unusedMedList"
        Me.unusedMedList.Size = New System.Drawing.Size(244, 34)
        Me.unusedMedList.TabIndex = 3
        Me.unusedMedList.Text = "顯示未分類藥品"
        Me.unusedMedList.UseCustomBackColor = True
        Me.unusedMedList.UseCustomForeColor = True
        Me.unusedMedList.UseSelectable = True
        '
        'medTree
        '
        Me.medTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medTree.Font = New System.Drawing.Font("Microsoft JhengHei", 14.0!)
        Me.medTree.Location = New System.Drawing.Point(3, 3)
        Me.medTree.Name = "medTree"
        Me.medTree.Size = New System.Drawing.Size(244, 167)
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
        'tabFull
        '
        Me.tabFull.Controls.Add(Me.fullListTable)
        Me.tabFull.Location = New System.Drawing.Point(4, 38)
        Me.tabFull.Name = "tabFull"
        Me.tabFull.Size = New System.Drawing.Size(939, 638)
        Me.tabFull.TabIndex = 1
        Me.tabFull.Text = "總覽"
        '
        'fullListTable
        '
        Me.fullListTable.ColumnCount = 2
        Me.fullListTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.fullListTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.fullListTable.Controls.Add(Me.fullListView, 1, 0)
        Me.fullListTable.Controls.Add(Me.historyBox, 0, 1)
        Me.fullListTable.Controls.Add(Me.MetroLabel2, 0, 0)
        Me.fullListTable.Controls.Add(Me.printMedButton, 0, 3)
        Me.fullListTable.Controls.Add(Me.printSingle, 0, 2)
        Me.fullListTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fullListTable.Location = New System.Drawing.Point(0, 0)
        Me.fullListTable.Name = "fullListTable"
        Me.fullListTable.RowCount = 4
        Me.fullListTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.fullListTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.fullListTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.fullListTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.fullListTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.fullListTable.Size = New System.Drawing.Size(939, 638)
        Me.fullListTable.TabIndex = 1
        '
        'fullListView
        '
        Me.fullListView.AllowUserToAddRows = False
        Me.fullListView.AllowUserToDeleteRows = False
        Me.fullListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.fullListView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.fullListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.fullListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fullListView.Location = New System.Drawing.Point(153, 3)
        Me.fullListView.Name = "fullListView"
        Me.fullListTable.SetRowSpan(Me.fullListView, 4)
        Me.fullListView.RowTemplate.Height = 24
        Me.fullListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.fullListView.Size = New System.Drawing.Size(783, 632)
        Me.fullListView.TabIndex = 0
        '
        'historyBox
        '
        Me.historyBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.historyBox.FormattingEnabled = True
        Me.historyBox.ItemHeight = 12
        Me.historyBox.Location = New System.Drawing.Point(3, 43)
        Me.historyBox.Name = "historyBox"
        Me.historyBox.Size = New System.Drawing.Size(144, 472)
        Me.historyBox.TabIndex = 1
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(144, 40)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "處方籤紀錄"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'printMedButton
        '
        Me.printMedButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.printMedButton.Location = New System.Drawing.Point(3, 581)
        Me.printMedButton.Name = "printMedButton"
        Me.printMedButton.Size = New System.Drawing.Size(144, 54)
        Me.printMedButton.TabIndex = 3
        Me.printMedButton.Text = "列印藥單"
        Me.printMedButton.UseSelectable = True
        '
        'printSingle
        '
        Me.printSingle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.printSingle.Location = New System.Drawing.Point(3, 521)
        Me.printSingle.Name = "printSingle"
        Me.printSingle.Size = New System.Drawing.Size(144, 54)
        Me.printSingle.TabIndex = 3
        Me.printSingle.Text = "單一藥單列印"
        Me.printSingle.UseSelectable = True
        '
        'pInfoPanel
        '
        Me.pInfoPanel.BackColor = System.Drawing.Color.SeaGreen
        Me.pInfoPanel.Controls.Add(Me.patientTab)
        Me.pInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pInfoPanel.Location = New System.Drawing.Point(973, 0)
        Me.pInfoPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.pInfoPanel.Name = "pInfoPanel"
        Me.pInfoPanel.Padding = New System.Windows.Forms.Padding(20)
        Me.pInfoPanel.Size = New System.Drawing.Size(300, 686)
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
        Me.patientTab.SelectedIndex = 0
        Me.patientTab.Size = New System.Drawing.Size(260, 646)
        Me.patientTab.TabIndex = 3
        Me.patientTab.UseSelectable = True
        '
        'tabPatientInfo
        '
        Me.tabPatientInfo.Controls.Add(Me.pInfoTable)
        Me.tabPatientInfo.Location = New System.Drawing.Point(4, 44)
        Me.tabPatientInfo.Name = "tabPatientInfo"
        Me.tabPatientInfo.Size = New System.Drawing.Size(252, 598)
        Me.tabPatientInfo.TabIndex = 0
        Me.tabPatientInfo.Text = "病患資料"
        '
        'pInfoTable
        '
        Me.pInfoTable.ColumnCount = 1
        Me.pInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pInfoTable.Controls.Add(Me.MetroLink1, 0, 0)
        Me.pInfoTable.Controls.Add(Me.pID, 0, 1)
        Me.pInfoTable.Controls.Add(Me.altGeneButton, 0, 12)
        Me.pInfoTable.Controls.Add(Me.sexLabel, 0, 4)
        Me.pInfoTable.Controls.Add(Me.nameLabel, 0, 2)
        Me.pInfoTable.Controls.Add(Me.ageLabel, 0, 6)
        Me.pInfoTable.Controls.Add(Me.countLabel, 0, 8)
        Me.pInfoTable.Controls.Add(Me.lastVisitLabel, 0, 10)
        Me.pInfoTable.Controls.Add(Me.pName, 0, 3)
        Me.pInfoTable.Controls.Add(Me.pSex, 0, 5)
        Me.pInfoTable.Controls.Add(Me.pAge, 0, 7)
        Me.pInfoTable.Controls.Add(Me.pVisitTimes, 0, 9)
        Me.pInfoTable.Controls.Add(Me.pPrevVisit, 0, 11)
        Me.pInfoTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pInfoTable.Location = New System.Drawing.Point(0, 0)
        Me.pInfoTable.Name = "pInfoTable"
        Me.pInfoTable.RowCount = 14
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
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pInfoTable.Size = New System.Drawing.Size(252, 598)
        Me.pInfoTable.TabIndex = 2
        '
        'MetroLink1
        '
        Me.MetroLink1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLink1.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink1.Location = New System.Drawing.Point(3, 3)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(246, 34)
        Me.MetroLink1.TabIndex = 7
        Me.MetroLink1.Text = "病歷號:"
        Me.MetroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink1.UseSelectable = True
        '
        'pID
        '
        '
        '
        '
        Me.pID.CustomButton.Image = Nothing
        Me.pID.CustomButton.Location = New System.Drawing.Point(214, 2)
        Me.pID.CustomButton.Name = ""
        Me.pID.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.pID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pID.CustomButton.TabIndex = 1
        Me.pID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pID.CustomButton.UseSelectable = True
        Me.pID.CustomButton.Visible = False
        Me.pID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pID.Enabled = False
        Me.pID.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pID.Lines = New String(-1) {}
        Me.pID.Location = New System.Drawing.Point(3, 43)
        Me.pID.MaxLength = 32767
        Me.pID.Name = "pID"
        Me.pID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pID.PromptText = "不顯示"
        Me.pID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pID.SelectedText = ""
        Me.pID.SelectionLength = 0
        Me.pID.SelectionStart = 0
        Me.pID.ShortcutsEnabled = True
        Me.pID.Size = New System.Drawing.Size(246, 34)
        Me.pID.TabIndex = 8
        Me.pID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pID.UseSelectable = True
        Me.pID.WaterMark = "不顯示"
        Me.pID.WaterMarkColor = System.Drawing.Color.Silver
        Me.pID.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        '
        'altGeneButton
        '
        Me.altGeneButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.altGeneButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.altGeneButton.Location = New System.Drawing.Point(3, 403)
        Me.altGeneButton.Name = "altGeneButton"
        Me.altGeneButton.Size = New System.Drawing.Size(246, 172)
        Me.altGeneButton.TabIndex = 6
        Me.altGeneButton.Text = "基因設定"
        Me.altGeneButton.UseSelectable = True
        '
        'sexLabel
        '
        Me.sexLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sexLabel.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.sexLabel.Location = New System.Drawing.Point(3, 163)
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
        Me.nameLabel.Location = New System.Drawing.Point(3, 83)
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
        Me.ageLabel.Location = New System.Drawing.Point(3, 243)
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
        Me.countLabel.Location = New System.Drawing.Point(3, 323)
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
        Me.lastVisitLabel.Location = New System.Drawing.Point(3, 403)
        Me.lastVisitLabel.Name = "lastVisitLabel"
        Me.lastVisitLabel.Size = New System.Drawing.Size(246, 1)
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
        Me.pName.Location = New System.Drawing.Point(3, 123)
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
        Me.pSex.Location = New System.Drawing.Point(3, 203)
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
        Me.pAge.Location = New System.Drawing.Point(3, 283)
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
        Me.pVisitTimes.Location = New System.Drawing.Point(3, 363)
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
        Me.pPrevVisit.CustomButton.Location = New System.Drawing.Point(245, 1)
        Me.pPrevVisit.CustomButton.Name = ""
        Me.pPrevVisit.CustomButton.Size = New System.Drawing.Size(0, 0)
        Me.pPrevVisit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pPrevVisit.CustomButton.TabIndex = 1
        Me.pPrevVisit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pPrevVisit.CustomButton.UseSelectable = True
        Me.pPrevVisit.CustomButton.Visible = False
        Me.pPrevVisit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pPrevVisit.Enabled = False
        Me.pPrevVisit.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pPrevVisit.Lines = New String(-1) {}
        Me.pPrevVisit.Location = New System.Drawing.Point(3, 403)
        Me.pPrevVisit.MaxLength = 32767
        Me.pPrevVisit.Name = "pPrevVisit"
        Me.pPrevVisit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pPrevVisit.PromptText = "不顯示"
        Me.pPrevVisit.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pPrevVisit.SelectedText = ""
        Me.pPrevVisit.SelectionLength = 0
        Me.pPrevVisit.SelectionStart = 0
        Me.pPrevVisit.ShortcutsEnabled = True
        Me.pPrevVisit.Size = New System.Drawing.Size(246, 1)
        Me.pPrevVisit.TabIndex = 4
        Me.pPrevVisit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pPrevVisit.UseSelectable = True
        Me.pPrevVisit.WaterMark = "不顯示"
        Me.pPrevVisit.WaterMarkColor = System.Drawing.Color.Silver
        Me.pPrevVisit.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        '
        'tabBooking
        '
        Me.tabBooking.Controls.Add(Me.refreshWaitingListButton)
        Me.tabBooking.Controls.Add(Me.checkDate)
        Me.tabBooking.Controls.Add(Me.waitingList)
        Me.tabBooking.Location = New System.Drawing.Point(4, 44)
        Me.tabBooking.Name = "tabBooking"
        Me.tabBooking.Padding = New System.Windows.Forms.Padding(0, 30, 0, 50)
        Me.tabBooking.Size = New System.Drawing.Size(252, 598)
        Me.tabBooking.TabIndex = 1
        Me.tabBooking.Text = "等候清單"
        '
        'refreshWaitingListButton
        '
        Me.refreshWaitingListButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshWaitingListButton.Location = New System.Drawing.Point(0, 550)
        Me.refreshWaitingListButton.Name = "refreshWaitingListButton"
        Me.refreshWaitingListButton.Size = New System.Drawing.Size(252, 47)
        Me.refreshWaitingListButton.TabIndex = 2
        Me.refreshWaitingListButton.Text = "重新整理"
        Me.refreshWaitingListButton.UseSelectable = True
        '
        'checkDate
        '
        Me.checkDate.Location = New System.Drawing.Point(0, 0)
        Me.checkDate.MinimumSize = New System.Drawing.Size(4, 29)
        Me.checkDate.Name = "checkDate"
        Me.checkDate.Size = New System.Drawing.Size(252, 29)
        Me.checkDate.TabIndex = 1
        '
        'waitingList
        '
        Me.waitingList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.waitingList.Font = New System.Drawing.Font("Microsoft JhengHei", 14.0!)
        Me.waitingList.FormattingEnabled = True
        Me.waitingList.ItemHeight = 24
        Me.waitingList.Location = New System.Drawing.Point(0, 30)
        Me.waitingList.Name = "waitingList"
        Me.waitingList.Size = New System.Drawing.Size(252, 518)
        Me.waitingList.TabIndex = 0
        '
        'medTable
        '
        Me.medTable.ColumnCount = 3
        Me.medTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.medTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.medTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.medTable.Controls.Add(Me.displayPatientCheckBox, 1, 0)
        Me.medTable.Controls.Add(Me.pInfoPanel, 2, 0)
        Me.medTable.Controls.Add(Me.medTabs, 0, 0)
        Me.medTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medTable.Location = New System.Drawing.Point(0, 0)
        Me.medTable.Name = "medTable"
        Me.medTable.RowCount = 1
        Me.medTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.medTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 686.0!))
        Me.medTable.Size = New System.Drawing.Size(1273, 686)
        Me.medTable.TabIndex = 7
        '
        'displayPatientCheckBox
        '
        Me.displayPatientCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.displayPatientCheckBox.AutoSize = True
        Me.displayPatientCheckBox.Checked = True
        Me.displayPatientCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.displayPatientCheckBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.displayPatientCheckBox.Location = New System.Drawing.Point(953, 0)
        Me.displayPatientCheckBox.Margin = New System.Windows.Forms.Padding(0)
        Me.displayPatientCheckBox.Name = "displayPatientCheckBox"
        Me.displayPatientCheckBox.Size = New System.Drawing.Size(20, 686)
        Me.displayPatientCheckBox.TabIndex = 15
        Me.displayPatientCheckBox.Text = ">>>>"
        Me.displayPatientCheckBox.UseVisualStyleBackColor = True
        '
        'pnlPerscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.medTable)
        Me.Name = "pnlPerscription"
        Me.Size = New System.Drawing.Size(1273, 686)
        Me.medTabs.ResumeLayout(False)
        Me.tabDetail.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.tabMedSetup.ResumeLayout(False)
        Me.fullMedGroupTable.ResumeLayout(False)
        Me.fullMedGroupTable.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.medGroupTable.ResumeLayout(False)
        Me.medGroupTable.PerformLayout()
        CType(Me.hisMedGroupGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel3.ResumeLayout(False)
        Me.groupSetupTable.ResumeLayout(False)
        Me.groupSetupTable.PerformLayout()
        CType(Me.medGroupGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        Me.MetroPanel5.ResumeLayout(False)
        Me.MetroPanel5.PerformLayout()
        Me.medDetailPanel.ResumeLayout(False)
        Me.medDetailPanel.PerformLayout()
        Me.medListTable.ResumeLayout(False)
        Me.medListTable.PerformLayout()
        CType(Me.medDetailGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.searchTable.ResumeLayout(False)
        Me.searchTable.PerformLayout()
        Me.tabFull.ResumeLayout(False)
        Me.fullListTable.ResumeLayout(False)
        Me.fullListTable.PerformLayout()
        CType(Me.fullListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pInfoPanel.ResumeLayout(False)
        Me.patientTab.ResumeLayout(False)
        Me.tabPatientInfo.ResumeLayout(False)
        Me.pInfoTable.ResumeLayout(False)
        Me.tabBooking.ResumeLayout(False)
        Me.medTable.ResumeLayout(False)
        Me.medTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents printDoc As Printing.PrintDocument
    Friend WithEvents printPreview As PrintPreviewDialog
    Friend WithEvents printDlg As PrintDialog
    Friend WithEvents medTabs As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabDetail As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents pastRecordBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents concernText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents otherExamBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents responseText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents geneButton As MetroFramework.Controls.MetroButton
    Friend WithEvents fluButton As MetroFramework.Controls.MetroButton
    Friend WithEvents careButton As MetroFramework.Controls.MetroButton
    Friend WithEvents tabMedSetup As TabPage
    Friend WithEvents fullMedGroupTable As TableLayoutPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents medGroupTable As TableLayoutPanel
    Friend WithEvents displayDosageCheckBox As CheckBox
    Friend WithEvents hisMedGroupGrid As DataGridView
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents groupSetupTable As TableLayoutPanel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents medGroupUnitLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents multiple As CheckBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents medGroupAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents F0 As CheckBox
    Friend WithEvents afterMeal As CheckBox
    Friend WithEvents morning As CheckBox
    Friend WithEvents noon As CheckBox
    Friend WithEvents night As CheckBox
    Friend WithEvents beforeSleep As CheckBox
    Friend WithEvents beforeMeal As CheckBox
    Friend WithEvents makePill As CheckBox
    Friend WithEvents notWell As CheckBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents medGroupDays As MetroFramework.Controls.MetroTextBox
    Friend WithEvents medGroupChange As MetroFramework.Controls.MetroButton
    Friend WithEvents medGroupUnit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents medGroupGrid As DataGridView
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents medGroupLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents delMedGroup As MetroFramework.Controls.MetroButton
    Friend WithEvents addMedGroup As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel5 As MetroFramework.Controls.MetroPanel
    Friend WithEvents displayHistoryCheckbox As CheckBox
    Friend WithEvents historyCombo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents copyAllButton As MetroFramework.Controls.MetroButton
    Friend WithEvents copyButton As MetroFramework.Controls.MetroButton
    Friend WithEvents medDetailPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents delMedDetail As MetroFramework.Controls.MetroButton
    Friend WithEvents addMedDetail As MetroFramework.Controls.MetroButton
    Friend WithEvents medListTable As TableLayoutPanel
    Friend WithEvents medDetailAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents medDetailChange As MetroFramework.Controls.MetroButton
    Friend WithEvents medDetailUnit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents medDetailLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents medDetailGrid As DataGridView
    Friend WithEvents displayMedInfoCheckBox As CheckBox
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents searchTable As TableLayoutPanel
    Friend WithEvents searchBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents unusedMedList As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents medTree As TreeView
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tabFull As TabPage
    Friend WithEvents fullListTable As TableLayoutPanel
    Friend WithEvents fullListView As DataGridView
    Friend WithEvents historyBox As ListBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents printMedButton As MetroFramework.Controls.MetroButton
    Friend WithEvents printSingle As MetroFramework.Controls.MetroButton
    Friend WithEvents pInfoPanel As Panel
    Friend WithEvents patientTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabPatientInfo As TabPage
    Friend WithEvents pInfoTable As TableLayoutPanel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents pID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents altGeneButton As MetroFramework.Controls.MetroButton
    Friend WithEvents sexLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents nameLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents ageLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents countLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents pName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pSex As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pAge As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pVisitTimes As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tabBooking As TabPage
    Friend WithEvents refreshWaitingListButton As MetroFramework.Controls.MetroButton
    Friend WithEvents checkDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents waitingList As ListBox
    Friend WithEvents medTable As TableLayoutPanel
    Friend WithEvents displayPatientCheckBox As CheckBox
    Friend WithEvents mainICD10Button As MetroFramework.Controls.MetroButton
    Friend WithEvents subICD10Button As MetroFramework.Controls.MetroButton
    Friend WithEvents ICDList As ListBox
    Friend WithEvents lastVisitLabel As MetroFramework.Controls.MetroLink
    Friend WithEvents pPrevVisit As MetroFramework.Controls.MetroTextBox
End Class
