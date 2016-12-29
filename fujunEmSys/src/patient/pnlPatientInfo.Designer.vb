<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlPatientInfo
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
        Me.components = New System.ComponentModel.Container()
        Me.searchContextMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.addButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.editPatientMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectPatientMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchTable = New System.Windows.Forms.TableLayoutPanel()
        Me.sqlGrid = New System.Windows.Forms.DataGridView()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.searchButton = New MetroFramework.Controls.MetroButton()
        Me.searchBox = New MetroFramework.Controls.MetroTextBox()
        Me.editTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.remarksLabel = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.patientRemarks = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.patientID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.patientName = New MetroFramework.Controls.MetroTextBox()
        Me.patientPhone = New MetroFramework.Controls.MetroTextBox()
        Me.patientCell = New MetroFramework.Controls.MetroTextBox()
        Me.patientAddress = New MetroFramework.Controls.MetroTextBox()
        Me.patientDOB = New MetroFramework.Controls.MetroDateTime()
        Me.patientSex = New MetroFramework.Controls.MetroComboBox()
        Me.updateButton = New MetroFramework.Controls.MetroButton()
        Me.cancelButton = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.patientEmail = New MetroFramework.Controls.MetroTextBox()
        Me.searchContextMenu.SuspendLayout()
        Me.searchTable.SuspendLayout()
        CType(Me.sqlGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.editTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'searchContextMenu
        '
        Me.searchContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addButton, Me.editPatientMenu, Me.selectPatientMenu})
        Me.searchContextMenu.Name = "searchContextMenu"
        Me.searchContextMenu.Size = New System.Drawing.Size(153, 70)
        '
        'addButton
        '
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(152, 22)
        Me.addButton.Text = "新增病患 (&N)"
        '
        'editPatientMenu
        '
        Me.editPatientMenu.Name = "editPatientMenu"
        Me.editPatientMenu.Size = New System.Drawing.Size(152, 22)
        Me.editPatientMenu.Text = "編輯此病患 (&E)"
        '
        'selectPatientMenu
        '
        Me.selectPatientMenu.Name = "selectPatientMenu"
        Me.selectPatientMenu.Size = New System.Drawing.Size(152, 22)
        Me.selectPatientMenu.Text = "選擇此病患 (&S)"
        '
        'searchTable
        '
        Me.searchTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.searchTable.ColumnCount = 2
        Me.searchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.searchTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.searchTable.Controls.Add(Me.sqlGrid, 0, 1)
        Me.searchTable.Controls.Add(Me.MetroPanel1, 0, 0)
        Me.searchTable.Controls.Add(Me.editTable, 1, 0)
        Me.searchTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchTable.Location = New System.Drawing.Point(0, 0)
        Me.searchTable.Name = "searchTable"
        Me.searchTable.RowCount = 2
        Me.searchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126.0!))
        Me.searchTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.searchTable.Size = New System.Drawing.Size(912, 584)
        Me.searchTable.TabIndex = 6
        '
        'sqlGrid
        '
        Me.sqlGrid.AllowUserToAddRows = False
        Me.sqlGrid.AllowUserToDeleteRows = False
        Me.sqlGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.sqlGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sqlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sqlGrid.Location = New System.Drawing.Point(4, 131)
        Me.sqlGrid.MultiSelect = False
        Me.sqlGrid.Name = "sqlGrid"
        Me.sqlGrid.ReadOnly = True
        Me.sqlGrid.RowTemplate.Height = 24
        Me.sqlGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sqlGrid.Size = New System.Drawing.Size(448, 449)
        Me.sqlGrid.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.searchButton)
        Me.MetroPanel1.Controls.Add(Me.searchBox)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(4, 4)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.MetroPanel1.Size = New System.Drawing.Size(448, 120)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 10)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(112, 25)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "搜尋關鍵字"
        '
        'searchButton
        '
        Me.searchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchButton.Location = New System.Drawing.Point(362, 79)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 4
        Me.searchButton.Text = "搜尋"
        Me.searchButton.UseSelectable = True
        '
        'searchBox
        '
        Me.searchBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.searchBox.CustomButton.Image = Nothing
        Me.searchBox.CustomButton.Location = New System.Drawing.Point(390, 1)
        Me.searchBox.CustomButton.Name = ""
        Me.searchBox.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.searchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchBox.CustomButton.TabIndex = 1
        Me.searchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchBox.CustomButton.UseSelectable = True
        Me.searchBox.CustomButton.Visible = False
        Me.searchBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.searchBox.Lines = New String(-1) {}
        Me.searchBox.Location = New System.Drawing.Point(13, 38)
        Me.searchBox.MaxLength = 32767
        Me.searchBox.Name = "searchBox"
        Me.searchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchBox.PromptText = "(病歷號碼, 姓名, 身份證字號, 手機號碼)"
        Me.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchBox.SelectedText = ""
        Me.searchBox.SelectionLength = 0
        Me.searchBox.SelectionStart = 0
        Me.searchBox.ShortcutsEnabled = True
        Me.searchBox.Size = New System.Drawing.Size(424, 35)
        Me.searchBox.TabIndex = 2
        Me.searchBox.UseSelectable = True
        Me.searchBox.WaterMark = "(病歷號碼, 姓名, 身份證字號, 手機號碼)"
        Me.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchBox.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.0!, System.Drawing.FontStyle.Italic)
        '
        'editTable
        '
        Me.editTable.BackColor = System.Drawing.Color.White
        Me.editTable.ColumnCount = 2
        Me.editTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.editTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.editTable.Controls.Add(Me.MetroLabel2, 0, 0)
        Me.editTable.Controls.Add(Me.MetroLabel3, 0, 1)
        Me.editTable.Controls.Add(Me.MetroLabel4, 0, 2)
        Me.editTable.Controls.Add(Me.remarksLabel, 0, 8)
        Me.editTable.Controls.Add(Me.MetroLabel5, 0, 3)
        Me.editTable.Controls.Add(Me.patientRemarks, 1, 8)
        Me.editTable.Controls.Add(Me.MetroLabel6, 0, 4)
        Me.editTable.Controls.Add(Me.patientID, 1, 0)
        Me.editTable.Controls.Add(Me.MetroLabel7, 0, 5)
        Me.editTable.Controls.Add(Me.MetroLabel8, 0, 7)
        Me.editTable.Controls.Add(Me.patientName, 1, 1)
        Me.editTable.Controls.Add(Me.patientPhone, 1, 4)
        Me.editTable.Controls.Add(Me.patientCell, 1, 5)
        Me.editTable.Controls.Add(Me.patientAddress, 1, 7)
        Me.editTable.Controls.Add(Me.patientDOB, 1, 3)
        Me.editTable.Controls.Add(Me.patientSex, 1, 2)
        Me.editTable.Controls.Add(Me.updateButton, 1, 10)
        Me.editTable.Controls.Add(Me.cancelButton, 0, 10)
        Me.editTable.Controls.Add(Me.MetroLabel9, 0, 6)
        Me.editTable.Controls.Add(Me.patientEmail, 1, 6)
        Me.editTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editTable.Location = New System.Drawing.Point(459, 4)
        Me.editTable.Name = "editTable"
        Me.editTable.RowCount = 11
        Me.searchTable.SetRowSpan(Me.editTable, 2)
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.editTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.editTable.Size = New System.Drawing.Size(449, 576)
        Me.editTable.TabIndex = 3
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(144, 40)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "身份證字號"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 40)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(144, 40)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "姓名"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 80)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(144, 40)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "性別"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'remarksLabel
        '
        Me.remarksLabel.AutoSize = True
        Me.remarksLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.remarksLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.remarksLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.remarksLabel.Location = New System.Drawing.Point(3, 320)
        Me.remarksLabel.Name = "remarksLabel"
        Me.remarksLabel.Size = New System.Drawing.Size(144, 40)
        Me.remarksLabel.TabIndex = 3
        Me.remarksLabel.Text = "備註"
        Me.remarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 120)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(144, 40)
        Me.MetroLabel5.TabIndex = 3
        Me.MetroLabel5.Text = "生日"
        Me.MetroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patientRemarks
        '
        '
        '
        '
        Me.patientRemarks.CustomButton.Image = Nothing
        Me.patientRemarks.CustomButton.Location = New System.Drawing.Point(85, 2)
        Me.patientRemarks.CustomButton.Name = ""
        Me.patientRemarks.CustomButton.Size = New System.Drawing.Size(205, 205)
        Me.patientRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.patientRemarks.CustomButton.TabIndex = 1
        Me.patientRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.patientRemarks.CustomButton.UseSelectable = True
        Me.patientRemarks.CustomButton.Visible = False
        Me.patientRemarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientRemarks.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.patientRemarks.Lines = New String(-1) {}
        Me.patientRemarks.Location = New System.Drawing.Point(153, 323)
        Me.patientRemarks.MaxLength = 32767
        Me.patientRemarks.Multiline = True
        Me.patientRemarks.Name = "patientRemarks"
        Me.patientRemarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.patientRemarks.PromptText = "請輸入備註"
        Me.editTable.SetRowSpan(Me.patientRemarks, 2)
        Me.patientRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.patientRemarks.SelectedText = ""
        Me.patientRemarks.SelectionLength = 0
        Me.patientRemarks.SelectionStart = 0
        Me.patientRemarks.ShortcutsEnabled = True
        Me.patientRemarks.Size = New System.Drawing.Size(293, 210)
        Me.patientRemarks.TabIndex = 2
        Me.patientRemarks.UseSelectable = True
        Me.patientRemarks.WaterMark = "請輸入備註"
        Me.patientRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.patientRemarks.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.0!, System.Drawing.FontStyle.Italic)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 160)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(144, 40)
        Me.MetroLabel6.TabIndex = 3
        Me.MetroLabel6.Text = "室內電話"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patientID
        '
        Me.patientID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.patientID.CustomButton.Image = Nothing
        Me.patientID.CustomButton.Location = New System.Drawing.Point(261, 2)
        Me.patientID.CustomButton.Name = ""
        Me.patientID.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.patientID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.patientID.CustomButton.TabIndex = 1
        Me.patientID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.patientID.CustomButton.UseSelectable = True
        Me.patientID.CustomButton.Visible = False
        Me.patientID.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.patientID.Lines = New String(-1) {}
        Me.patientID.Location = New System.Drawing.Point(153, 3)
        Me.patientID.MaxLength = 32767
        Me.patientID.Name = "patientID"
        Me.patientID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.patientID.PromptText = "請輸入身份證字號"
        Me.patientID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.patientID.SelectedText = ""
        Me.patientID.SelectionLength = 0
        Me.patientID.SelectionStart = 0
        Me.patientID.ShortcutsEnabled = True
        Me.patientID.Size = New System.Drawing.Size(293, 34)
        Me.patientID.TabIndex = 2
        Me.patientID.UseSelectable = True
        Me.patientID.WaterMark = "請輸入身份證字號"
        Me.patientID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.patientID.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.0!, System.Drawing.FontStyle.Italic)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 200)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(144, 40)
        Me.MetroLabel7.TabIndex = 3
        Me.MetroLabel7.Text = "手機號碼"
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(3, 280)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(144, 40)
        Me.MetroLabel8.TabIndex = 3
        Me.MetroLabel8.Text = "地址"
        Me.MetroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patientName
        '
        Me.patientName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.patientName.CustomButton.Image = Nothing
        Me.patientName.CustomButton.Location = New System.Drawing.Point(261, 2)
        Me.patientName.CustomButton.Name = ""
        Me.patientName.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.patientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.patientName.CustomButton.TabIndex = 1
        Me.patientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.patientName.CustomButton.UseSelectable = True
        Me.patientName.CustomButton.Visible = False
        Me.patientName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.patientName.Lines = New String(-1) {}
        Me.patientName.Location = New System.Drawing.Point(153, 43)
        Me.patientName.MaxLength = 32767
        Me.patientName.Name = "patientName"
        Me.patientName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.patientName.PromptText = "請輸入姓名"
        Me.patientName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.patientName.SelectedText = ""
        Me.patientName.SelectionLength = 0
        Me.patientName.SelectionStart = 0
        Me.patientName.ShortcutsEnabled = True
        Me.patientName.Size = New System.Drawing.Size(293, 34)
        Me.patientName.TabIndex = 2
        Me.patientName.UseSelectable = True
        Me.patientName.WaterMark = "請輸入姓名"
        Me.patientName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.patientName.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.0!, System.Drawing.FontStyle.Italic)
        '
        'patientPhone
        '
        Me.patientPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.patientPhone.CustomButton.Image = Nothing
        Me.patientPhone.CustomButton.Location = New System.Drawing.Point(261, 2)
        Me.patientPhone.CustomButton.Name = ""
        Me.patientPhone.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.patientPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.patientPhone.CustomButton.TabIndex = 1
        Me.patientPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.patientPhone.CustomButton.UseSelectable = True
        Me.patientPhone.CustomButton.Visible = False
        Me.patientPhone.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.patientPhone.Lines = New String(-1) {}
        Me.patientPhone.Location = New System.Drawing.Point(153, 163)
        Me.patientPhone.MaxLength = 32767
        Me.patientPhone.Name = "patientPhone"
        Me.patientPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.patientPhone.PromptText = "請輸入室內電話"
        Me.patientPhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.patientPhone.SelectedText = ""
        Me.patientPhone.SelectionLength = 0
        Me.patientPhone.SelectionStart = 0
        Me.patientPhone.ShortcutsEnabled = True
        Me.patientPhone.Size = New System.Drawing.Size(293, 34)
        Me.patientPhone.TabIndex = 2
        Me.patientPhone.UseSelectable = True
        Me.patientPhone.WaterMark = "請輸入室內電話"
        Me.patientPhone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.patientPhone.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.0!, System.Drawing.FontStyle.Italic)
        '
        'patientCell
        '
        Me.patientCell.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.patientCell.CustomButton.Image = Nothing
        Me.patientCell.CustomButton.Location = New System.Drawing.Point(261, 2)
        Me.patientCell.CustomButton.Name = ""
        Me.patientCell.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.patientCell.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.patientCell.CustomButton.TabIndex = 1
        Me.patientCell.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.patientCell.CustomButton.UseSelectable = True
        Me.patientCell.CustomButton.Visible = False
        Me.patientCell.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.patientCell.Lines = New String(-1) {}
        Me.patientCell.Location = New System.Drawing.Point(153, 203)
        Me.patientCell.MaxLength = 32767
        Me.patientCell.Name = "patientCell"
        Me.patientCell.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.patientCell.PromptText = "請輸入手機號碼"
        Me.patientCell.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.patientCell.SelectedText = ""
        Me.patientCell.SelectionLength = 0
        Me.patientCell.SelectionStart = 0
        Me.patientCell.ShortcutsEnabled = True
        Me.patientCell.Size = New System.Drawing.Size(293, 34)
        Me.patientCell.TabIndex = 2
        Me.patientCell.UseSelectable = True
        Me.patientCell.WaterMark = "請輸入手機號碼"
        Me.patientCell.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.patientCell.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.0!, System.Drawing.FontStyle.Italic)
        '
        'patientAddress
        '
        '
        '
        '
        Me.patientAddress.CustomButton.Image = Nothing
        Me.patientAddress.CustomButton.Location = New System.Drawing.Point(261, 2)
        Me.patientAddress.CustomButton.Name = ""
        Me.patientAddress.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.patientAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.patientAddress.CustomButton.TabIndex = 1
        Me.patientAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.patientAddress.CustomButton.UseSelectable = True
        Me.patientAddress.CustomButton.Visible = False
        Me.patientAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.patientAddress.Lines = New String(-1) {}
        Me.patientAddress.Location = New System.Drawing.Point(153, 283)
        Me.patientAddress.MaxLength = 32767
        Me.patientAddress.Name = "patientAddress"
        Me.patientAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.patientAddress.PromptText = "請輸入地址"
        Me.patientAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.patientAddress.SelectedText = ""
        Me.patientAddress.SelectionLength = 0
        Me.patientAddress.SelectionStart = 0
        Me.patientAddress.ShortcutsEnabled = True
        Me.patientAddress.Size = New System.Drawing.Size(293, 34)
        Me.patientAddress.TabIndex = 2
        Me.patientAddress.UseSelectable = True
        Me.patientAddress.WaterMark = "請輸入地址"
        Me.patientAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.patientAddress.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.0!, System.Drawing.FontStyle.Italic)
        '
        'patientDOB
        '
        Me.patientDOB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientDOB.FontSize = MetroFramework.MetroDateTimeSize.Tall
        Me.patientDOB.Location = New System.Drawing.Point(153, 123)
        Me.patientDOB.MinimumSize = New System.Drawing.Size(0, 35)
        Me.patientDOB.Name = "patientDOB"
        Me.patientDOB.Size = New System.Drawing.Size(293, 35)
        Me.patientDOB.TabIndex = 4
        '
        'patientSex
        '
        Me.patientSex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientSex.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.patientSex.FormattingEnabled = True
        Me.patientSex.ItemHeight = 29
        Me.patientSex.Location = New System.Drawing.Point(153, 83)
        Me.patientSex.Name = "patientSex"
        Me.patientSex.Size = New System.Drawing.Size(293, 35)
        Me.patientSex.TabIndex = 5
        Me.patientSex.UseSelectable = True
        '
        'updateButton
        '
        Me.updateButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.updateButton.Location = New System.Drawing.Point(153, 539)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(293, 34)
        Me.updateButton.TabIndex = 1
        Me.updateButton.Text = "更新資料"
        Me.updateButton.UseSelectable = True
        '
        'cancelButton
        '
        Me.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cancelButton.Location = New System.Drawing.Point(3, 539)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(144, 34)
        Me.cancelButton.TabIndex = 7
        Me.cancelButton.Text = "取消"
        Me.cancelButton.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.Location = New System.Drawing.Point(3, 240)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(144, 40)
        Me.MetroLabel9.TabIndex = 3
        Me.MetroLabel9.Text = "EMail"
        Me.MetroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'patientEmail
        '
        '
        '
        '
        Me.patientEmail.CustomButton.Image = Nothing
        Me.patientEmail.CustomButton.Location = New System.Drawing.Point(261, 2)
        Me.patientEmail.CustomButton.Name = ""
        Me.patientEmail.CustomButton.Size = New System.Drawing.Size(29, 29)
        Me.patientEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.patientEmail.CustomButton.TabIndex = 1
        Me.patientEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.patientEmail.CustomButton.UseSelectable = True
        Me.patientEmail.CustomButton.Visible = False
        Me.patientEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.patientEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.patientEmail.Lines = New String(-1) {}
        Me.patientEmail.Location = New System.Drawing.Point(153, 243)
        Me.patientEmail.MaxLength = 32767
        Me.patientEmail.Name = "patientEmail"
        Me.patientEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.patientEmail.PromptText = "請輸入Email"
        Me.patientEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.patientEmail.SelectedText = ""
        Me.patientEmail.SelectionLength = 0
        Me.patientEmail.SelectionStart = 0
        Me.patientEmail.ShortcutsEnabled = True
        Me.patientEmail.Size = New System.Drawing.Size(293, 34)
        Me.patientEmail.TabIndex = 2
        Me.patientEmail.UseSelectable = True
        Me.patientEmail.WaterMark = "請輸入Email"
        Me.patientEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.patientEmail.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 14.0!, System.Drawing.FontStyle.Italic)
        '
        'pnlPatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.searchTable)
        Me.Name = "pnlPatientInfo"
        Me.Size = New System.Drawing.Size(912, 584)
        Me.searchContextMenu.ResumeLayout(False)
        Me.searchTable.ResumeLayout(False)
        CType(Me.sqlGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.editTable.ResumeLayout(False)
        Me.editTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents searchContextMenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents editPatientMenu As ToolStripMenuItem
    Friend WithEvents selectPatientMenu As ToolStripMenuItem
    Friend WithEvents searchTable As TableLayoutPanel
    Friend WithEvents sqlGrid As DataGridView
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents updateButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents searchButton As MetroFramework.Controls.MetroButton
    Friend WithEvents searchBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents editTable As TableLayoutPanel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents remarksLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents patientRemarks As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents patientID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents patientName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents patientPhone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents patientCell As MetroFramework.Controls.MetroTextBox
    Friend WithEvents patientAddress As MetroFramework.Controls.MetroTextBox
    Friend WithEvents patientDOB As MetroFramework.Controls.MetroDateTime
    Friend WithEvents patientSex As MetroFramework.Controls.MetroComboBox
    Friend WithEvents addButton As ToolStripMenuItem
    Friend WithEvents cancelButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents patientEmail As MetroFramework.Controls.MetroTextBox
End Class
