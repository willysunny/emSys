<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pnlMedInfo
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
        Me.maintable = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.rightTable = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonTable = New System.Windows.Forms.TableLayoutPanel()
        Me.addButton = New MetroFramework.Controls.MetroButton()
        Me.editButton = New MetroFramework.Controls.MetroButton()
        Me.clearButton = New MetroFramework.Controls.MetroButton()
        Me.delButton = New MetroFramework.Controls.MetroButton()
        Me.medInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.groupAmountUnit = New MetroFramework.Controls.MetroComboBox()
        Me.groupAmount = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.medName = New MetroFramework.Controls.MetroTextBox()
        Me.pinyin = New MetroFramework.Controls.MetroTextBox()
        Me.zhuyin = New MetroFramework.Controls.MetroTextBox()
        Me.medDesc = New MetroFramework.Controls.MetroTextBox()
        Me.discount = New MetroFramework.Controls.MetroCheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.unitUnit = New MetroFramework.Controls.MetroComboBox()
        Me.unitPrice = New MetroFramework.Controls.MetroTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.groupUnit = New MetroFramework.Controls.MetroComboBox()
        Me.groupPrice = New MetroFramework.Controls.MetroTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.medList = New System.Windows.Forms.ListBox()
        Me.mainGroupList = New MetroFramework.Controls.MetroComboBox()
        Me.subGroupList = New MetroFramework.Controls.MetroComboBox()
        Me.unusedMedList = New MetroFramework.Controls.MetroCheckBox()
        Me.maintable.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.rightTable.SuspendLayout()
        Me.buttonTable.SuspendLayout()
        Me.medInfoTable.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.ClientSize = New System.Drawing.Size(120, 0)
        Me.owner.Location = New System.Drawing.Point(-32000, -32000)
        '
        'maintable
        '
        Me.maintable.ColumnCount = 2
        Me.maintable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.maintable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.maintable.Controls.Add(Me.Panel1, 1, 0)
        Me.maintable.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.maintable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maintable.Location = New System.Drawing.Point(0, 0)
        Me.maintable.Name = "maintable"
        Me.maintable.RowCount = 1
        Me.maintable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.maintable.Size = New System.Drawing.Size(987, 649)
        Me.maintable.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.rightTable)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(203, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20, 60, 20, 20)
        Me.Panel1.Size = New System.Drawing.Size(781, 643)
        Me.Panel1.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 19)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(100, 23)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "藥物資訊"
        '
        'rightTable
        '
        Me.rightTable.ColumnCount = 1
        Me.rightTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 741.0!))
        Me.rightTable.Controls.Add(Me.buttonTable, 0, 1)
        Me.rightTable.Controls.Add(Me.medInfoTable, 0, 0)
        Me.rightTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rightTable.Location = New System.Drawing.Point(20, 60)
        Me.rightTable.Name = "rightTable"
        Me.rightTable.RowCount = 2
        Me.rightTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.rightTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.rightTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.rightTable.Size = New System.Drawing.Size(741, 563)
        Me.rightTable.TabIndex = 0
        '
        'buttonTable
        '
        Me.buttonTable.ColumnCount = 4
        Me.buttonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.buttonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.buttonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.buttonTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.buttonTable.Controls.Add(Me.addButton, 1, 0)
        Me.buttonTable.Controls.Add(Me.editButton, 2, 0)
        Me.buttonTable.Controls.Add(Me.clearButton, 0, 0)
        Me.buttonTable.Controls.Add(Me.delButton, 3, 0)
        Me.buttonTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonTable.Location = New System.Drawing.Point(3, 526)
        Me.buttonTable.Name = "buttonTable"
        Me.buttonTable.RowCount = 1
        Me.buttonTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.buttonTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.buttonTable.Size = New System.Drawing.Size(735, 34)
        Me.buttonTable.TabIndex = 0
        '
        'addButton
        '
        Me.addButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addButton.Location = New System.Drawing.Point(186, 3)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(177, 28)
        Me.addButton.TabIndex = 0
        Me.addButton.Text = "新增藥品"
        Me.addButton.UseSelectable = True
        '
        'editButton
        '
        Me.editButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editButton.Location = New System.Drawing.Point(369, 3)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(177, 28)
        Me.editButton.TabIndex = 0
        Me.editButton.Text = "修改藥品"
        Me.editButton.UseSelectable = True
        '
        'clearButton
        '
        Me.clearButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clearButton.Location = New System.Drawing.Point(3, 3)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(177, 28)
        Me.clearButton.TabIndex = 0
        Me.clearButton.Text = "清除欄位"
        Me.clearButton.UseSelectable = True
        '
        'delButton
        '
        Me.delButton.BackColor = System.Drawing.Color.Maroon
        Me.delButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.delButton.ForeColor = System.Drawing.Color.White
        Me.delButton.Location = New System.Drawing.Point(552, 3)
        Me.delButton.Name = "delButton"
        Me.delButton.Size = New System.Drawing.Size(180, 28)
        Me.delButton.TabIndex = 0
        Me.delButton.Text = "刪除藥品"
        Me.delButton.UseCustomBackColor = True
        Me.delButton.UseCustomForeColor = True
        Me.delButton.UseSelectable = True
        '
        'medInfoTable
        '
        Me.medInfoTable.ColumnCount = 2
        Me.medInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.medInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.medInfoTable.Controls.Add(Me.Label8, 0, 6)
        Me.medInfoTable.Controls.Add(Me.Panel4, 1, 6)
        Me.medInfoTable.Controls.Add(Me.Label5, 0, 3)
        Me.medInfoTable.Controls.Add(Me.Label1, 0, 0)
        Me.medInfoTable.Controls.Add(Me.Label2, 0, 1)
        Me.medInfoTable.Controls.Add(Me.Label3, 0, 2)
        Me.medInfoTable.Controls.Add(Me.Label4, 0, 7)
        Me.medInfoTable.Controls.Add(Me.medName, 1, 0)
        Me.medInfoTable.Controls.Add(Me.pinyin, 1, 1)
        Me.medInfoTable.Controls.Add(Me.zhuyin, 1, 2)
        Me.medInfoTable.Controls.Add(Me.medDesc, 1, 3)
        Me.medInfoTable.Controls.Add(Me.discount, 1, 7)
        Me.medInfoTable.Controls.Add(Me.Label6, 0, 5)
        Me.medInfoTable.Controls.Add(Me.Label7, 0, 4)
        Me.medInfoTable.Controls.Add(Me.Panel2, 1, 4)
        Me.medInfoTable.Controls.Add(Me.Panel3, 1, 5)
        Me.medInfoTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medInfoTable.Location = New System.Drawing.Point(3, 3)
        Me.medInfoTable.Name = "medInfoTable"
        Me.medInfoTable.RowCount = 8
        Me.medInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.medInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.medInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.medInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.medInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.medInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.medInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.medInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.medInfoTable.Size = New System.Drawing.Size(735, 517)
        Me.medInfoTable.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 447)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 35)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "數量"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.groupAmountUnit)
        Me.Panel4.Controls.Add(Me.groupAmount)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(122, 450)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.Panel4.Size = New System.Drawing.Size(610, 29)
        Me.Panel4.TabIndex = 5
        '
        'groupAmountUnit
        '
        Me.groupAmountUnit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.groupAmountUnit.FormattingEnabled = True
        Me.groupAmountUnit.ItemHeight = 23
        Me.groupAmountUnit.Items.AddRange(New Object() {"包", "瓶"})
        Me.groupAmountUnit.Location = New System.Drawing.Point(512, 0)
        Me.groupAmountUnit.Name = "groupAmountUnit"
        Me.groupAmountUnit.Size = New System.Drawing.Size(98, 29)
        Me.groupAmountUnit.TabIndex = 1
        Me.groupAmountUnit.UseSelectable = True
        '
        'groupAmount
        '
        '
        '
        '
        Me.groupAmount.CustomButton.Image = Nothing
        Me.groupAmount.CustomButton.Location = New System.Drawing.Point(482, 1)
        Me.groupAmount.CustomButton.Name = ""
        Me.groupAmount.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.groupAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.groupAmount.CustomButton.TabIndex = 1
        Me.groupAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.groupAmount.CustomButton.UseSelectable = True
        Me.groupAmount.CustomButton.Visible = False
        Me.groupAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupAmount.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.groupAmount.Lines = New String(-1) {}
        Me.groupAmount.Location = New System.Drawing.Point(0, 0)
        Me.groupAmount.MaxLength = 32767
        Me.groupAmount.Name = "groupAmount"
        Me.groupAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.groupAmount.PromptText = "數量"
        Me.groupAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.groupAmount.SelectedText = ""
        Me.groupAmount.SelectionLength = 0
        Me.groupAmount.SelectionStart = 0
        Me.groupAmount.ShortcutsEnabled = True
        Me.groupAmount.Size = New System.Drawing.Size(510, 29)
        Me.groupAmount.TabIndex = 0
        Me.groupAmount.UseSelectable = True
        Me.groupAmount.WaterMark = "數量"
        Me.groupAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.groupAmount.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 272)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "藥物說明"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "藥品名稱*"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 35)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "拼音開頭*"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 35)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "注音開頭*"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 482)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 35)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "可折扣"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'medName
        '
        '
        '
        '
        Me.medName.CustomButton.Image = Nothing
        Me.medName.CustomButton.Location = New System.Drawing.Point(582, 1)
        Me.medName.CustomButton.Name = ""
        Me.medName.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.medName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.medName.CustomButton.TabIndex = 1
        Me.medName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.medName.CustomButton.UseSelectable = True
        Me.medName.CustomButton.Visible = False
        Me.medName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.medName.Lines = New String(-1) {}
        Me.medName.Location = New System.Drawing.Point(122, 3)
        Me.medName.MaxLength = 32767
        Me.medName.Name = "medName"
        Me.medName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medName.PromptText = "藥品名稱"
        Me.medName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.medName.SelectedText = ""
        Me.medName.SelectionLength = 0
        Me.medName.SelectionStart = 0
        Me.medName.ShortcutsEnabled = True
        Me.medName.Size = New System.Drawing.Size(610, 29)
        Me.medName.TabIndex = 1
        Me.medName.UseSelectable = True
        Me.medName.WaterMark = "藥品名稱"
        Me.medName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.medName.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pinyin
        '
        '
        '
        '
        Me.pinyin.CustomButton.Image = Nothing
        Me.pinyin.CustomButton.Location = New System.Drawing.Point(582, 1)
        Me.pinyin.CustomButton.Name = ""
        Me.pinyin.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.pinyin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pinyin.CustomButton.TabIndex = 1
        Me.pinyin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pinyin.CustomButton.UseSelectable = True
        Me.pinyin.CustomButton.Visible = False
        Me.pinyin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pinyin.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pinyin.Lines = New String(-1) {}
        Me.pinyin.Location = New System.Drawing.Point(122, 38)
        Me.pinyin.MaxLength = 32767
        Me.pinyin.Name = "pinyin"
        Me.pinyin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pinyin.PromptText = "拼音開頭"
        Me.pinyin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pinyin.SelectedText = ""
        Me.pinyin.SelectionLength = 0
        Me.pinyin.SelectionStart = 0
        Me.pinyin.ShortcutsEnabled = True
        Me.pinyin.Size = New System.Drawing.Size(610, 29)
        Me.pinyin.TabIndex = 1
        Me.pinyin.UseSelectable = True
        Me.pinyin.WaterMark = "拼音開頭"
        Me.pinyin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.pinyin.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'zhuyin
        '
        '
        '
        '
        Me.zhuyin.CustomButton.Image = Nothing
        Me.zhuyin.CustomButton.Location = New System.Drawing.Point(582, 1)
        Me.zhuyin.CustomButton.Name = ""
        Me.zhuyin.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.zhuyin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.zhuyin.CustomButton.TabIndex = 1
        Me.zhuyin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.zhuyin.CustomButton.UseSelectable = True
        Me.zhuyin.CustomButton.Visible = False
        Me.zhuyin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zhuyin.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.zhuyin.Lines = New String(-1) {}
        Me.zhuyin.Location = New System.Drawing.Point(122, 73)
        Me.zhuyin.MaxLength = 32767
        Me.zhuyin.Name = "zhuyin"
        Me.zhuyin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.zhuyin.PromptText = "注音開頭 (英文)"
        Me.zhuyin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.zhuyin.SelectedText = ""
        Me.zhuyin.SelectionLength = 0
        Me.zhuyin.SelectionStart = 0
        Me.zhuyin.ShortcutsEnabled = True
        Me.zhuyin.Size = New System.Drawing.Size(610, 29)
        Me.zhuyin.TabIndex = 1
        Me.zhuyin.UseSelectable = True
        Me.zhuyin.WaterMark = "注音開頭 (英文)"
        Me.zhuyin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.zhuyin.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'medDesc
        '
        '
        '
        '
        Me.medDesc.CustomButton.Image = Nothing
        Me.medDesc.CustomButton.Location = New System.Drawing.Point(346, 2)
        Me.medDesc.CustomButton.Name = ""
        Me.medDesc.CustomButton.Size = New System.Drawing.Size(261, 261)
        Me.medDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.medDesc.CustomButton.TabIndex = 1
        Me.medDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.medDesc.CustomButton.UseSelectable = True
        Me.medDesc.CustomButton.Visible = False
        Me.medDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medDesc.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.medDesc.Lines = New String(-1) {}
        Me.medDesc.Location = New System.Drawing.Point(122, 108)
        Me.medDesc.MaxLength = 32767
        Me.medDesc.Multiline = True
        Me.medDesc.Name = "medDesc"
        Me.medDesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.medDesc.PromptText = "藥物說明"
        Me.medDesc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.medDesc.SelectedText = ""
        Me.medDesc.SelectionLength = 0
        Me.medDesc.SelectionStart = 0
        Me.medDesc.ShortcutsEnabled = True
        Me.medDesc.Size = New System.Drawing.Size(610, 266)
        Me.medDesc.TabIndex = 1
        Me.medDesc.UseSelectable = True
        Me.medDesc.WaterMark = "藥物說明"
        Me.medDesc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.medDesc.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'discount
        '
        Me.discount.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.discount.Checked = True
        Me.discount.CheckState = System.Windows.Forms.CheckState.Checked
        Me.discount.Location = New System.Drawing.Point(129, 493)
        Me.discount.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(12, 12)
        Me.discount.TabIndex = 2
        Me.discount.UseSelectable = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 35)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "批發價"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 35)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "單價"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.unitUnit)
        Me.Panel2.Controls.Add(Me.unitPrice)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(122, 380)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.Panel2.Size = New System.Drawing.Size(610, 29)
        Me.Panel2.TabIndex = 4
        '
        'unitUnit
        '
        Me.unitUnit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.unitUnit.FormattingEnabled = True
        Me.unitUnit.ItemHeight = 23
        Me.unitUnit.Items.AddRange(New Object() {"克", "顆"})
        Me.unitUnit.Location = New System.Drawing.Point(512, 0)
        Me.unitUnit.Name = "unitUnit"
        Me.unitUnit.Size = New System.Drawing.Size(98, 29)
        Me.unitUnit.TabIndex = 1
        Me.unitUnit.UseSelectable = True
        '
        'unitPrice
        '
        '
        '
        '
        Me.unitPrice.CustomButton.Image = Nothing
        Me.unitPrice.CustomButton.Location = New System.Drawing.Point(482, 1)
        Me.unitPrice.CustomButton.Name = ""
        Me.unitPrice.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.unitPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.unitPrice.CustomButton.TabIndex = 1
        Me.unitPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.unitPrice.CustomButton.UseSelectable = True
        Me.unitPrice.CustomButton.Visible = False
        Me.unitPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unitPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.unitPrice.Lines = New String(-1) {}
        Me.unitPrice.Location = New System.Drawing.Point(0, 0)
        Me.unitPrice.MaxLength = 32767
        Me.unitPrice.Name = "unitPrice"
        Me.unitPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.unitPrice.PromptText = "單價"
        Me.unitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.unitPrice.SelectedText = ""
        Me.unitPrice.SelectionLength = 0
        Me.unitPrice.SelectionStart = 0
        Me.unitPrice.ShortcutsEnabled = True
        Me.unitPrice.Size = New System.Drawing.Size(510, 29)
        Me.unitPrice.TabIndex = 0
        Me.unitPrice.UseSelectable = True
        Me.unitPrice.WaterMark = "單價"
        Me.unitPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.unitPrice.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.groupUnit)
        Me.Panel3.Controls.Add(Me.groupPrice)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(122, 415)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.Panel3.Size = New System.Drawing.Size(610, 29)
        Me.Panel3.TabIndex = 4
        '
        'groupUnit
        '
        Me.groupUnit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.groupUnit.FormattingEnabled = True
        Me.groupUnit.ItemHeight = 23
        Me.groupUnit.Items.AddRange(New Object() {"包", "瓶"})
        Me.groupUnit.Location = New System.Drawing.Point(512, 0)
        Me.groupUnit.Name = "groupUnit"
        Me.groupUnit.Size = New System.Drawing.Size(98, 29)
        Me.groupUnit.TabIndex = 1
        Me.groupUnit.UseSelectable = True
        '
        'groupPrice
        '
        '
        '
        '
        Me.groupPrice.CustomButton.Image = Nothing
        Me.groupPrice.CustomButton.Location = New System.Drawing.Point(482, 1)
        Me.groupPrice.CustomButton.Name = ""
        Me.groupPrice.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.groupPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.groupPrice.CustomButton.TabIndex = 1
        Me.groupPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.groupPrice.CustomButton.UseSelectable = True
        Me.groupPrice.CustomButton.Visible = False
        Me.groupPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.groupPrice.Lines = New String(-1) {}
        Me.groupPrice.Location = New System.Drawing.Point(0, 0)
        Me.groupPrice.MaxLength = 32767
        Me.groupPrice.Name = "groupPrice"
        Me.groupPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.groupPrice.PromptText = "批發價"
        Me.groupPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.groupPrice.SelectedText = ""
        Me.groupPrice.SelectionLength = 0
        Me.groupPrice.SelectionStart = 0
        Me.groupPrice.ShortcutsEnabled = True
        Me.groupPrice.Size = New System.Drawing.Size(510, 29)
        Me.groupPrice.TabIndex = 0
        Me.groupPrice.UseSelectable = True
        Me.groupPrice.WaterMark = "批發價"
        Me.groupPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.groupPrice.WaterMarkFont = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.medList, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.mainGroupList, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.subGroupList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.unusedMedList, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(194, 643)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'medList
        '
        Me.medList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.medList.FormattingEnabled = True
        Me.medList.ItemHeight = 20
        Me.medList.Location = New System.Drawing.Point(3, 83)
        Me.medList.Name = "medList"
        Me.medList.Size = New System.Drawing.Size(188, 517)
        Me.medList.TabIndex = 0
        '
        'mainGroupList
        '
        Me.mainGroupList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainGroupList.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.mainGroupList.FormattingEnabled = True
        Me.mainGroupList.ItemHeight = 29
        Me.mainGroupList.Location = New System.Drawing.Point(3, 3)
        Me.mainGroupList.Name = "mainGroupList"
        Me.mainGroupList.Size = New System.Drawing.Size(188, 35)
        Me.mainGroupList.TabIndex = 1
        Me.mainGroupList.UseSelectable = True
        '
        'subGroupList
        '
        Me.subGroupList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subGroupList.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.subGroupList.FormattingEnabled = True
        Me.subGroupList.ItemHeight = 29
        Me.subGroupList.Location = New System.Drawing.Point(3, 43)
        Me.subGroupList.Name = "subGroupList"
        Me.subGroupList.Size = New System.Drawing.Size(188, 35)
        Me.subGroupList.TabIndex = 2
        Me.subGroupList.UseSelectable = True
        '
        'unusedMedList
        '
        Me.unusedMedList.AutoSize = True
        Me.unusedMedList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unusedMedList.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.unusedMedList.Location = New System.Drawing.Point(3, 606)
        Me.unusedMedList.Name = "unusedMedList"
        Me.unusedMedList.Size = New System.Drawing.Size(188, 34)
        Me.unusedMedList.TabIndex = 3
        Me.unusedMedList.Text = "顯示未分類藥品"
        Me.unusedMedList.UseSelectable = True
        '
        'pnlMedInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.maintable)
        Me.Name = "pnlMedInfo"
        Me.Size = New System.Drawing.Size(987, 649)
        Me.maintable.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.rightTable.ResumeLayout(False)
        Me.buttonTable.ResumeLayout(False)
        Me.medInfoTable.ResumeLayout(False)
        Me.medInfoTable.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents maintable As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents rightTable As TableLayoutPanel
    Friend WithEvents buttonTable As TableLayoutPanel
    Friend WithEvents addButton As MetroFramework.Controls.MetroButton
    Friend WithEvents editButton As MetroFramework.Controls.MetroButton
    Friend WithEvents clearButton As MetroFramework.Controls.MetroButton
    Friend WithEvents delButton As MetroFramework.Controls.MetroButton
    Friend WithEvents medInfoTable As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents groupAmountUnit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents groupAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents medName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pinyin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents zhuyin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents medDesc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents discount As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents unitUnit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents unitPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents groupUnit As MetroFramework.Controls.MetroComboBox
    Friend WithEvents groupPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents medList As ListBox
    Friend WithEvents mainGroupList As MetroFramework.Controls.MetroComboBox
    Friend WithEvents subGroupList As MetroFramework.Controls.MetroComboBox
    Friend WithEvents unusedMedList As MetroFramework.Controls.MetroCheckBox
End Class
