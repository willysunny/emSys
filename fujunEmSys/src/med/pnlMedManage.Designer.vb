<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlMedManage
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
        Me.mainLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.mainGroupList = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mainGroupAdd = New MetroFramework.Controls.MetroButton()
        Me.mainGroupDel = New MetroFramework.Controls.MetroButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.subTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.unusedSubGroupAdd = New MetroFramework.Controls.MetroButton()
        Me.unusedSubGroupDel = New MetroFramework.Controls.MetroButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.subGroupAdd = New MetroFramework.Controls.MetroButton()
        Me.subGroupDel = New MetroFramework.Controls.MetroButton()
        Me.subGroupList = New System.Windows.Forms.ListBox()
        Me.unusedSubGroupList = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.addSubGroupAll = New MetroFramework.Controls.MetroButton()
        Me.addSubGroup = New MetroFramework.Controls.MetroButton()
        Me.delSubGroup = New MetroFramework.Controls.MetroButton()
        Me.delSubGroupAll = New MetroFramework.Controls.MetroButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.medTable = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.medList = New System.Windows.Forms.ListBox()
        Me.unusedMedList = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.addMedAll = New MetroFramework.Controls.MetroButton()
        Me.addMed = New MetroFramework.Controls.MetroButton()
        Me.delMed = New MetroFramework.Controls.MetroButton()
        Me.delMedAll = New MetroFramework.Controls.MetroButton()
        Me.mainLayout.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.subTable.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.medTable.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainLayout
        '
        Me.mainLayout.BackColor = System.Drawing.Color.Transparent
        Me.mainLayout.ColumnCount = 2
        Me.mainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.mainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667!))
        Me.mainLayout.Controls.Add(Me.Panel1, 0, 0)
        Me.mainLayout.Controls.Add(Me.Panel2, 1, 0)
        Me.mainLayout.Controls.Add(Me.Panel3, 1, 1)
        Me.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainLayout.Location = New System.Drawing.Point(0, 0)
        Me.mainLayout.Name = "mainLayout"
        Me.mainLayout.RowCount = 2
        Me.mainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.mainLayout.Size = New System.Drawing.Size(1077, 682)
        Me.mainLayout.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.mainLayout.SetRowSpan(Me.Panel1, 2)
        Me.Panel1.Size = New System.Drawing.Size(352, 676)
        Me.Panel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.mainGroupList, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(332, 656)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'mainGroupList
        '
        Me.mainGroupList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainGroupList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mainGroupList.FormattingEnabled = True
        Me.mainGroupList.ItemHeight = 20
        Me.mainGroupList.Items.AddRange(New Object() {"[全部]"})
        Me.mainGroupList.Location = New System.Drawing.Point(3, 43)
        Me.mainGroupList.Name = "mainGroupList"
        Me.mainGroupList.Size = New System.Drawing.Size(326, 610)
        Me.mainGroupList.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.mainGroupAdd, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.mainGroupDel, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(326, 34)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(260, 34)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "主分類"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mainGroupAdd
        '
        Me.mainGroupAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainGroupAdd.Location = New System.Drawing.Point(269, 3)
        Me.mainGroupAdd.Name = "mainGroupAdd"
        Me.mainGroupAdd.Size = New System.Drawing.Size(24, 28)
        Me.mainGroupAdd.TabIndex = 5
        Me.mainGroupAdd.Text = "+"
        Me.mainGroupAdd.UseSelectable = True
        '
        'mainGroupDel
        '
        Me.mainGroupDel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainGroupDel.Location = New System.Drawing.Point(299, 3)
        Me.mainGroupDel.Name = "mainGroupDel"
        Me.mainGroupDel.Size = New System.Drawing.Size(24, 28)
        Me.mainGroupDel.TabIndex = 6
        Me.mainGroupDel.Text = "-"
        Me.mainGroupDel.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel2.Controls.Add(Me.subTable)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(361, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(713, 335)
        Me.Panel2.TabIndex = 2
        '
        'subTable
        '
        Me.subTable.ColumnCount = 3
        Me.subTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.subTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.subTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.subTable.Controls.Add(Me.TableLayoutPanel7, 2, 0)
        Me.subTable.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.subTable.Controls.Add(Me.subGroupList, 0, 1)
        Me.subTable.Controls.Add(Me.unusedSubGroupList, 2, 1)
        Me.subTable.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.subTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subTable.Location = New System.Drawing.Point(10, 10)
        Me.subTable.Name = "subTable"
        Me.subTable.RowCount = 2
        Me.subTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.subTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.subTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.subTable.Size = New System.Drawing.Size(693, 315)
        Me.subTable.TabIndex = 1
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.ListBox2, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(369, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(321, 34)
        Me.TableLayoutPanel7.TabIndex = 7
        '
        'ListBox2
        '
        Me.ListBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Items.AddRange(New Object() {"[全部]"})
        Me.ListBox2.Location = New System.Drawing.Point(3, 43)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(315, 1)
        Me.ListBox2.TabIndex = 2
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.MetroLabel3, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.unusedSubGroupAdd, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.unusedSubGroupDel, 2, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(315, 34)
        Me.TableLayoutPanel8.TabIndex = 3
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(249, 34)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "未使用子分類"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'unusedSubGroupAdd
        '
        Me.unusedSubGroupAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unusedSubGroupAdd.Location = New System.Drawing.Point(258, 3)
        Me.unusedSubGroupAdd.Name = "unusedSubGroupAdd"
        Me.unusedSubGroupAdd.Size = New System.Drawing.Size(24, 28)
        Me.unusedSubGroupAdd.TabIndex = 5
        Me.unusedSubGroupAdd.Text = "+"
        Me.unusedSubGroupAdd.UseSelectable = True
        '
        'unusedSubGroupDel
        '
        Me.unusedSubGroupDel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unusedSubGroupDel.Location = New System.Drawing.Point(288, 3)
        Me.unusedSubGroupDel.Name = "unusedSubGroupDel"
        Me.unusedSubGroupDel.Size = New System.Drawing.Size(24, 28)
        Me.unusedSubGroupDel.TabIndex = 6
        Me.unusedSubGroupDel.Text = "-"
        Me.unusedSubGroupDel.UseSelectable = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ListBox1, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(320, 34)
        Me.TableLayoutPanel4.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"[全部]"})
        Me.ListBox1.Location = New System.Drawing.Point(3, 43)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(314, 1)
        Me.ListBox1.TabIndex = 2
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.MetroLabel2, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.subGroupAdd, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.subGroupDel, 2, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(314, 34)
        Me.TableLayoutPanel6.TabIndex = 3
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(248, 34)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "子分類"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subGroupAdd
        '
        Me.subGroupAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subGroupAdd.Location = New System.Drawing.Point(257, 3)
        Me.subGroupAdd.Name = "subGroupAdd"
        Me.subGroupAdd.Size = New System.Drawing.Size(24, 28)
        Me.subGroupAdd.TabIndex = 5
        Me.subGroupAdd.Text = "+"
        Me.subGroupAdd.UseSelectable = True
        '
        'subGroupDel
        '
        Me.subGroupDel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subGroupDel.Location = New System.Drawing.Point(287, 3)
        Me.subGroupDel.Name = "subGroupDel"
        Me.subGroupDel.Size = New System.Drawing.Size(24, 28)
        Me.subGroupDel.TabIndex = 6
        Me.subGroupDel.Text = "-"
        Me.subGroupDel.UseSelectable = True
        '
        'subGroupList
        '
        Me.subGroupList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subGroupList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.subGroupList.FormattingEnabled = True
        Me.subGroupList.ItemHeight = 20
        Me.subGroupList.Items.AddRange(New Object() {"[全部]"})
        Me.subGroupList.Location = New System.Drawing.Point(3, 43)
        Me.subGroupList.Name = "subGroupList"
        Me.subGroupList.Size = New System.Drawing.Size(320, 269)
        Me.subGroupList.TabIndex = 4
        '
        'unusedSubGroupList
        '
        Me.unusedSubGroupList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unusedSubGroupList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.unusedSubGroupList.FormattingEnabled = True
        Me.unusedSubGroupList.ItemHeight = 20
        Me.unusedSubGroupList.Location = New System.Drawing.Point(369, 43)
        Me.unusedSubGroupList.Name = "unusedSubGroupList"
        Me.unusedSubGroupList.Size = New System.Drawing.Size(321, 269)
        Me.unusedSubGroupList.TabIndex = 4
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.addSubGroupAll, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.addSubGroup, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.delSubGroup, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.delSubGroupAll, 0, 4)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(331, 102)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(30, 150)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'addSubGroupAll
        '
        Me.addSubGroupAll.Location = New System.Drawing.Point(3, 3)
        Me.addSubGroupAll.Name = "addSubGroupAll"
        Me.addSubGroupAll.Size = New System.Drawing.Size(24, 23)
        Me.addSubGroupAll.TabIndex = 0
        Me.addSubGroupAll.Text = "|<"
        Me.addSubGroupAll.UseSelectable = True
        '
        'addSubGroup
        '
        Me.addSubGroup.Location = New System.Drawing.Point(3, 33)
        Me.addSubGroup.Name = "addSubGroup"
        Me.addSubGroup.Size = New System.Drawing.Size(24, 23)
        Me.addSubGroup.TabIndex = 1
        Me.addSubGroup.Text = "<"
        Me.addSubGroup.UseSelectable = True
        '
        'delSubGroup
        '
        Me.delSubGroup.Location = New System.Drawing.Point(3, 93)
        Me.delSubGroup.Name = "delSubGroup"
        Me.delSubGroup.Size = New System.Drawing.Size(24, 23)
        Me.delSubGroup.TabIndex = 1
        Me.delSubGroup.Text = ">"
        Me.delSubGroup.UseSelectable = True
        '
        'delSubGroupAll
        '
        Me.delSubGroupAll.Location = New System.Drawing.Point(3, 123)
        Me.delSubGroupAll.Name = "delSubGroupAll"
        Me.delSubGroupAll.Size = New System.Drawing.Size(24, 23)
        Me.delSubGroupAll.TabIndex = 1
        Me.delSubGroupAll.Text = ">|"
        Me.delSubGroupAll.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.medTable)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(361, 344)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel3.Size = New System.Drawing.Size(713, 335)
        Me.Panel3.TabIndex = 3
        '
        'medTable
        '
        Me.medTable.ColumnCount = 3
        Me.medTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.medTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.medTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.medTable.Controls.Add(Me.MetroLabel4, 0, 0)
        Me.medTable.Controls.Add(Me.MetroLabel5, 2, 0)
        Me.medTable.Controls.Add(Me.medList, 0, 1)
        Me.medTable.Controls.Add(Me.unusedMedList, 2, 1)
        Me.medTable.Controls.Add(Me.TableLayoutPanel5, 1, 1)
        Me.medTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medTable.Location = New System.Drawing.Point(10, 10)
        Me.medTable.Name = "medTable"
        Me.medTable.RowCount = 2
        Me.medTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.medTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.medTable.Size = New System.Drawing.Size(693, 315)
        Me.medTable.TabIndex = 1
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(320, 40)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "藥品名稱"
        Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(369, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(321, 40)
        Me.MetroLabel5.TabIndex = 3
        Me.MetroLabel5.Text = "未使用藥品"
        Me.MetroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'medList
        '
        Me.medList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.medList.FormattingEnabled = True
        Me.medList.ItemHeight = 20
        Me.medList.Location = New System.Drawing.Point(3, 43)
        Me.medList.Name = "medList"
        Me.medList.Size = New System.Drawing.Size(320, 269)
        Me.medList.TabIndex = 4
        '
        'unusedMedList
        '
        Me.unusedMedList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unusedMedList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.unusedMedList.FormattingEnabled = True
        Me.unusedMedList.ItemHeight = 20
        Me.unusedMedList.Location = New System.Drawing.Point(369, 43)
        Me.unusedMedList.Name = "unusedMedList"
        Me.unusedMedList.Size = New System.Drawing.Size(321, 269)
        Me.unusedMedList.TabIndex = 4
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.addMedAll, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.addMed, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.delMed, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.delMedAll, 0, 4)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(331, 102)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(30, 150)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'addMedAll
        '
        Me.addMedAll.Location = New System.Drawing.Point(3, 3)
        Me.addMedAll.Name = "addMedAll"
        Me.addMedAll.Size = New System.Drawing.Size(24, 23)
        Me.addMedAll.TabIndex = 0
        Me.addMedAll.Text = "|<"
        Me.addMedAll.UseSelectable = True
        '
        'addMed
        '
        Me.addMed.Location = New System.Drawing.Point(3, 33)
        Me.addMed.Name = "addMed"
        Me.addMed.Size = New System.Drawing.Size(24, 23)
        Me.addMed.TabIndex = 1
        Me.addMed.Text = "<"
        Me.addMed.UseSelectable = True
        '
        'delMed
        '
        Me.delMed.Location = New System.Drawing.Point(3, 93)
        Me.delMed.Name = "delMed"
        Me.delMed.Size = New System.Drawing.Size(24, 23)
        Me.delMed.TabIndex = 1
        Me.delMed.Text = ">"
        Me.delMed.UseSelectable = True
        '
        'delMedAll
        '
        Me.delMedAll.Location = New System.Drawing.Point(3, 123)
        Me.delMedAll.Name = "delMedAll"
        Me.delMedAll.Size = New System.Drawing.Size(24, 23)
        Me.delMedAll.TabIndex = 1
        Me.delMedAll.Text = ">|"
        Me.delMedAll.UseSelectable = True
        '
        'pnlMedManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.mainLayout)
        Me.Name = "pnlMedManage"
        Me.Size = New System.Drawing.Size(1077, 682)
        Me.mainLayout.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.subTable.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.medTable.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainLayout As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents subTable As TableLayoutPanel
    Friend WithEvents mainGroupList As ListBox
    Friend WithEvents subGroupList As ListBox
    Friend WithEvents unusedSubGroupList As ListBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents addSubGroupAll As MetroFramework.Controls.MetroButton
    Friend WithEvents addSubGroup As MetroFramework.Controls.MetroButton
    Friend WithEvents delSubGroup As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents medTable As TableLayoutPanel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents medList As ListBox
    Friend WithEvents unusedMedList As ListBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents addMedAll As MetroFramework.Controls.MetroButton
    Friend WithEvents addMed As MetroFramework.Controls.MetroButton
    Friend WithEvents delMed As MetroFramework.Controls.MetroButton
    Friend WithEvents delMedAll As MetroFramework.Controls.MetroButton
    Friend WithEvents delSubGroupAll As MetroFramework.Controls.MetroButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mainGroupAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents mainGroupDel As MetroFramework.Controls.MetroButton
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents subGroupAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents subGroupDel As MetroFramework.Controls.MetroButton
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents unusedSubGroupAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents unusedSubGroupDel As MetroFramework.Controls.MetroButton
End Class
