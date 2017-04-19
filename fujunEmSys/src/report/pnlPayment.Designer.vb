<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlPayment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.printPreviewDlg = New System.Windows.Forms.PrintPreviewDialog()
        Me.printDlg = New System.Windows.Forms.PrintDialog()
        Me.pInfoPanel = New System.Windows.Forms.Panel()
        Me.patientTab = New MetroFramework.Controls.MetroTabControl()
        Me.tabPatientInfo = New System.Windows.Forms.TabPage()
        Me.pInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.fullListView = New System.Windows.Forms.DataGridView()
        Me.sexLabel = New MetroFramework.Controls.MetroLink()
        Me.nameLabel = New MetroFramework.Controls.MetroLink()
        Me.ageLabel = New MetroFramework.Controls.MetroLink()
        Me.countLabel = New MetroFramework.Controls.MetroLink()
        Me.pName = New MetroFramework.Controls.MetroTextBox()
        Me.pSex = New MetroFramework.Controls.MetroTextBox()
        Me.pAge = New MetroFramework.Controls.MetroTextBox()
        Me.pVisitTimes = New MetroFramework.Controls.MetroTextBox()
        Me.tabBooking = New System.Windows.Forms.TabPage()
        Me.refreshWaitingListButton = New MetroFramework.Controls.MetroButton()
        Me.checkDate = New MetroFramework.Controls.MetroDateTime()
        Me.waitingList = New System.Windows.Forms.ListBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.medFee = New System.Windows.Forms.DataGridView()
        Me.bioFee = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.printButton = New MetroFramework.Controls.MetroButton()
        Me.resetButton = New MetroFramework.Controls.MetroButton()
        Me.printBox = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.discountBox = New MetroFramework.Controls.MetroComboBox()
        Me.diagFeeBox = New MetroFramework.Controls.MetroComboBox()
        Me.totalSum = New MetroFramework.Controls.MetroTextBox()
        Me.medTotal = New MetroFramework.Controls.MetroTextBox()
        Me.bioTotal = New MetroFramework.Controls.MetroTextBox()
        Me.pInfoPanel.SuspendLayout()
        Me.patientTab.SuspendLayout()
        Me.tabPatientInfo.SuspendLayout()
        Me.pInfoTable.SuspendLayout()
        CType(Me.fullListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBooking.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.medFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bioFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.ClientSize = New System.Drawing.Size(0, 0)
        Me.owner.Location = New System.Drawing.Point(-32000, -32000)
        Me.owner.WindowState = System.Windows.Forms.FormWindowState.Minimized
        '
        'printDoc
        '
        '
        'printPreviewDlg
        '
        Me.printPreviewDlg.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDlg.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDlg.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDlg.Document = Me.printDoc
        Me.printPreviewDlg.Enabled = True
        Me.printPreviewDlg.Icon = CType(resources.GetObject("printPreviewDlg.Icon"), System.Drawing.Icon)
        Me.printPreviewDlg.Name = "printPreviewDlg"
        Me.printPreviewDlg.Visible = False
        '
        'printDlg
        '
        Me.printDlg.Document = Me.printDoc
        Me.printDlg.UseEXDialog = True
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
        Me.pInfoPanel.Size = New System.Drawing.Size(300, 600)
        Me.pInfoPanel.TabIndex = 8
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
        Me.patientTab.Size = New System.Drawing.Size(260, 560)
        Me.patientTab.TabIndex = 3
        Me.patientTab.UseSelectable = True
        '
        'tabPatientInfo
        '
        Me.tabPatientInfo.Controls.Add(Me.pInfoTable)
        Me.tabPatientInfo.Location = New System.Drawing.Point(4, 44)
        Me.tabPatientInfo.Name = "tabPatientInfo"
        Me.tabPatientInfo.Size = New System.Drawing.Size(252, 512)
        Me.tabPatientInfo.TabIndex = 0
        Me.tabPatientInfo.Text = "病患資料"
        '
        'pInfoTable
        '
        Me.pInfoTable.ColumnCount = 1
        Me.pInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pInfoTable.Controls.Add(Me.fullListView, 0, 10)
        Me.pInfoTable.Controls.Add(Me.sexLabel, 0, 4)
        Me.pInfoTable.Controls.Add(Me.nameLabel, 0, 2)
        Me.pInfoTable.Controls.Add(Me.ageLabel, 0, 6)
        Me.pInfoTable.Controls.Add(Me.countLabel, 0, 8)
        Me.pInfoTable.Controls.Add(Me.pName, 0, 3)
        Me.pInfoTable.Controls.Add(Me.pSex, 0, 5)
        Me.pInfoTable.Controls.Add(Me.pAge, 0, 7)
        Me.pInfoTable.Controls.Add(Me.pVisitTimes, 0, 9)
        Me.pInfoTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pInfoTable.Location = New System.Drawing.Point(0, 0)
        Me.pInfoTable.Name = "pInfoTable"
        Me.pInfoTable.RowCount = 11
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.pInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pInfoTable.Size = New System.Drawing.Size(252, 512)
        Me.pInfoTable.TabIndex = 2
        '
        'fullListView
        '
        Me.fullListView.AllowUserToAddRows = False
        Me.fullListView.AllowUserToDeleteRows = False
        Me.fullListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.fullListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pInfoTable.SetColumnSpan(Me.fullListView, 2)
        Me.fullListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fullListView.Location = New System.Drawing.Point(3, 363)
        Me.fullListView.Name = "fullListView"
        Me.fullListView.RowTemplate.Height = 24
        Me.fullListView.Size = New System.Drawing.Size(246, 146)
        Me.fullListView.TabIndex = 5
        Me.fullListView.Visible = False
        '
        'sexLabel
        '
        Me.sexLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sexLabel.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.sexLabel.Location = New System.Drawing.Point(3, 123)
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
        Me.nameLabel.Location = New System.Drawing.Point(3, 43)
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
        Me.ageLabel.Location = New System.Drawing.Point(3, 203)
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
        Me.countLabel.Location = New System.Drawing.Point(3, 283)
        Me.countLabel.Name = "countLabel"
        Me.countLabel.Size = New System.Drawing.Size(246, 34)
        Me.countLabel.TabIndex = 1
        Me.countLabel.Text = "診次:"
        Me.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.countLabel.UseSelectable = True
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
        Me.pName.Location = New System.Drawing.Point(3, 83)
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
        Me.pSex.Location = New System.Drawing.Point(3, 163)
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
        Me.pAge.Location = New System.Drawing.Point(3, 243)
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
        Me.pVisitTimes.Location = New System.Drawing.Point(3, 323)
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
        'tabBooking
        '
        Me.tabBooking.Controls.Add(Me.refreshWaitingListButton)
        Me.tabBooking.Controls.Add(Me.checkDate)
        Me.tabBooking.Controls.Add(Me.waitingList)
        Me.tabBooking.Location = New System.Drawing.Point(4, 44)
        Me.tabBooking.Name = "tabBooking"
        Me.tabBooking.Padding = New System.Windows.Forms.Padding(0, 30, 0, 50)
        Me.tabBooking.Size = New System.Drawing.Size(252, 512)
        Me.tabBooking.TabIndex = 1
        Me.tabBooking.Text = "等候清單"
        '
        'refreshWaitingListButton
        '
        Me.refreshWaitingListButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshWaitingListButton.Location = New System.Drawing.Point(0, 460)
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
        Me.waitingList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.waitingList.FormattingEnabled = True
        Me.waitingList.ItemHeight = 20
        Me.waitingList.Location = New System.Drawing.Point(0, 30)
        Me.waitingList.Name = "waitingList"
        Me.waitingList.Size = New System.Drawing.Size(252, 432)
        Me.waitingList.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.BurlyWood
        Me.MetroPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(280, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Padding = New System.Windows.Forms.Padding(20)
        Me.MetroPanel1.Size = New System.Drawing.Size(573, 600)
        Me.MetroPanel1.TabIndex = 7
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel2, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.medFee, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.bioFee, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.discountBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.diagFeeBox, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.totalSum, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.medTotal, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.bioTotal, 3, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 20)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(533, 560)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 490)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(74, 35)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "小記:"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(269, 490)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(74, 35)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "小記:"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'medFee
        '
        Me.medFee.AllowUserToAddRows = False
        Me.medFee.AllowUserToDeleteRows = False
        Me.medFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.medFee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.medFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.medFee, 2)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.medFee.DefaultCellStyle = DataGridViewCellStyle2
        Me.medFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medFee.Location = New System.Drawing.Point(3, 73)
        Me.medFee.Name = "medFee"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.medFee.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.medFee.RowTemplate.Height = 24
        Me.medFee.Size = New System.Drawing.Size(260, 414)
        Me.medFee.TabIndex = 2
        '
        'bioFee
        '
        Me.bioFee.AllowUserToAddRows = False
        Me.bioFee.AllowUserToDeleteRows = False
        Me.bioFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bioFee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.bioFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.bioFee, 2)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bioFee.DefaultCellStyle = DataGridViewCellStyle5
        Me.bioFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bioFee.Location = New System.Drawing.Point(269, 73)
        Me.bioFee.Name = "bioFee"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bioFee.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.bioFee.RowTemplate.Height = 24
        Me.bioFee.Size = New System.Drawing.Size(261, 414)
        Me.bioFee.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.printButton, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.resetButton, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.printBox, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(269, 528)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(261, 29)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'printButton
        '
        Me.printButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.printButton.Location = New System.Drawing.Point(198, 3)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(60, 23)
        Me.printButton.TabIndex = 0
        Me.printButton.Text = "列印"
        Me.printButton.UseSelectable = True
        '
        'resetButton
        '
        Me.resetButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resetButton.Location = New System.Drawing.Point(3, 3)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(59, 23)
        Me.resetButton.TabIndex = 1
        Me.resetButton.Text = "重製"
        Me.resetButton.UseSelectable = True
        '
        'printBox
        '
        Me.printBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.printBox.FormattingEnabled = True
        Me.printBox.ItemHeight = 23
        Me.printBox.Location = New System.Drawing.Point(68, 3)
        Me.printBox.Name = "printBox"
        Me.printBox.Size = New System.Drawing.Size(124, 29)
        Me.printBox.TabIndex = 2
        Me.printBox.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.MetroLabel3, 2)
        Me.MetroLabel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 35)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(260, 35)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "診所"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.MetroLabel4, 2)
        Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(269, 35)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(261, 35)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "生醫"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(74, 35)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "折扣:"
        Me.MetroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(269, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(74, 35)
        Me.MetroLabel6.TabIndex = 5
        Me.MetroLabel6.Text = "診費:"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel6.UseCustomBackColor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 525)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(74, 35)
        Me.MetroLabel7.TabIndex = 5
        Me.MetroLabel7.Text = "總額:"
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLabel7.UseCustomBackColor = True
        '
        'discountBox
        '
        Me.discountBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.discountBox.FormattingEnabled = True
        Me.discountBox.ItemHeight = 23
        Me.discountBox.Location = New System.Drawing.Point(83, 3)
        Me.discountBox.Name = "discountBox"
        Me.discountBox.Size = New System.Drawing.Size(180, 29)
        Me.discountBox.TabIndex = 6
        Me.discountBox.UseSelectable = True
        '
        'diagFeeBox
        '
        Me.diagFeeBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.diagFeeBox.FormattingEnabled = True
        Me.diagFeeBox.ItemHeight = 23
        Me.diagFeeBox.Location = New System.Drawing.Point(349, 3)
        Me.diagFeeBox.Name = "diagFeeBox"
        Me.diagFeeBox.Size = New System.Drawing.Size(181, 29)
        Me.diagFeeBox.TabIndex = 7
        Me.diagFeeBox.UseSelectable = True
        '
        'totalSum
        '
        '
        '
        '
        Me.totalSum.CustomButton.Image = Nothing
        Me.totalSum.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.totalSum.CustomButton.Name = ""
        Me.totalSum.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.totalSum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.totalSum.CustomButton.TabIndex = 1
        Me.totalSum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.totalSum.CustomButton.UseSelectable = True
        Me.totalSum.CustomButton.Visible = False
        Me.totalSum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.totalSum.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.totalSum.Lines = New String() {"0"}
        Me.totalSum.Location = New System.Drawing.Point(83, 528)
        Me.totalSum.MaxLength = 32767
        Me.totalSum.Name = "totalSum"
        Me.totalSum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalSum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.totalSum.SelectedText = ""
        Me.totalSum.SelectionLength = 0
        Me.totalSum.SelectionStart = 0
        Me.totalSum.ShortcutsEnabled = True
        Me.totalSum.Size = New System.Drawing.Size(180, 29)
        Me.totalSum.TabIndex = 8
        Me.totalSum.Text = "0"
        Me.totalSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalSum.UseSelectable = True
        Me.totalSum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.totalSum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'medTotal
        '
        '
        '
        '
        Me.medTotal.CustomButton.Image = Nothing
        Me.medTotal.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.medTotal.CustomButton.Name = ""
        Me.medTotal.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.medTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.medTotal.CustomButton.TabIndex = 1
        Me.medTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.medTotal.CustomButton.UseSelectable = True
        Me.medTotal.CustomButton.Visible = False
        Me.medTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.medTotal.Lines = New String() {"0"}
        Me.medTotal.Location = New System.Drawing.Point(83, 493)
        Me.medTotal.MaxLength = 32767
        Me.medTotal.Name = "medTotal"
        Me.medTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.medTotal.SelectedText = ""
        Me.medTotal.SelectionLength = 0
        Me.medTotal.SelectionStart = 0
        Me.medTotal.ShortcutsEnabled = True
        Me.medTotal.Size = New System.Drawing.Size(180, 29)
        Me.medTotal.TabIndex = 8
        Me.medTotal.Text = "0"
        Me.medTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.medTotal.UseSelectable = True
        Me.medTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.medTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'bioTotal
        '
        '
        '
        '
        Me.bioTotal.CustomButton.Image = Nothing
        Me.bioTotal.CustomButton.Location = New System.Drawing.Point(153, 1)
        Me.bioTotal.CustomButton.Name = ""
        Me.bioTotal.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.bioTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.bioTotal.CustomButton.TabIndex = 1
        Me.bioTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.bioTotal.CustomButton.UseSelectable = True
        Me.bioTotal.CustomButton.Visible = False
        Me.bioTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bioTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.bioTotal.Lines = New String() {"0"}
        Me.bioTotal.Location = New System.Drawing.Point(349, 493)
        Me.bioTotal.MaxLength = 32767
        Me.bioTotal.Name = "bioTotal"
        Me.bioTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.bioTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.bioTotal.SelectedText = ""
        Me.bioTotal.SelectionLength = 0
        Me.bioTotal.SelectionStart = 0
        Me.bioTotal.ShortcutsEnabled = True
        Me.bioTotal.Size = New System.Drawing.Size(181, 29)
        Me.bioTotal.TabIndex = 8
        Me.bioTotal.Text = "0"
        Me.bioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.bioTotal.UseSelectable = True
        Me.bioTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.bioTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pnlPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pInfoPanel)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "pnlPayment"
        Me.Padding = New System.Windows.Forms.Padding(280, 0, 0, 0)
        Me.Size = New System.Drawing.Size(853, 600)
        Me.pInfoPanel.ResumeLayout(False)
        Me.patientTab.ResumeLayout(False)
        Me.tabPatientInfo.ResumeLayout(False)
        Me.pInfoTable.ResumeLayout(False)
        CType(Me.fullListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBooking.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.medFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bioFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents medFee As DataGridView
    Friend WithEvents bioFee As DataGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents printButton As MetroFramework.Controls.MetroButton
    Friend WithEvents resetButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents printDoc As Printing.PrintDocument
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents discountBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents diagFeeBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents totalSum As MetroFramework.Controls.MetroTextBox
    Friend WithEvents medTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents bioTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pInfoPanel As Panel
    Friend WithEvents patientTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabPatientInfo As TabPage
    Friend WithEvents pInfoTable As TableLayoutPanel
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
    Friend WithEvents printPreviewDlg As PrintPreviewDialog
    Friend WithEvents printDlg As PrintDialog
    Friend WithEvents fullListView As DataGridView
    Friend WithEvents printBox As MetroFramework.Controls.MetroComboBox
End Class
