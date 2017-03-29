<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmICD10
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.searchBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ICDGrid = New System.Windows.Forms.DataGridView()
        Me.confirmButton = New MetroFramework.Controls.MetroButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.delAllButton = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.delButton = New MetroFramework.Controls.MetroButton()
        Me.ICDList = New System.Windows.Forms.ListBox()
        CType(Me.ICDGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'searchBox
        '
        '
        '
        '
        Me.searchBox.CustomButton.Image = Nothing
        Me.searchBox.CustomButton.Location = New System.Drawing.Point(669, 2)
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
        Me.searchBox.Location = New System.Drawing.Point(83, 3)
        Me.searchBox.MaxLength = 32767
        Me.searchBox.Name = "searchBox"
        Me.searchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchBox.SelectedText = ""
        Me.searchBox.SelectionLength = 0
        Me.searchBox.SelectionStart = 0
        Me.searchBox.ShortcutsEnabled = True
        Me.searchBox.Size = New System.Drawing.Size(701, 34)
        Me.searchBox.TabIndex = 0
        Me.searchBox.UseSelectable = True
        Me.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(74, 40)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "搜尋"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ICDGrid
        '
        Me.ICDGrid.AllowUserToAddRows = False
        Me.ICDGrid.AllowUserToDeleteRows = False
        Me.ICDGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ICDGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ICDGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ICDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.ICDGrid, 2)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ICDGrid.DefaultCellStyle = DataGridViewCellStyle6
        Me.ICDGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ICDGrid.Location = New System.Drawing.Point(3, 43)
        Me.ICDGrid.Name = "ICDGrid"
        Me.ICDGrid.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.ICDGrid, 3)
        Me.ICDGrid.RowTemplate.Height = 24
        Me.ICDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ICDGrid.Size = New System.Drawing.Size(781, 523)
        Me.ICDGrid.TabIndex = 2
        '
        'confirmButton
        '
        Me.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.confirmButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.confirmButton.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.confirmButton.Location = New System.Drawing.Point(487, 648)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(75, 23)
        Me.confirmButton.TabIndex = 3
        Me.confirmButton.Text = "確定"
        Me.confirmButton.UseSelectable = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.delAllButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.searchBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ICDGrid, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.delButton, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ICDList, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1091, 569)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'delAllButton
        '
        Me.delAllButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.delAllButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.delAllButton.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.delAllButton.Location = New System.Drawing.Point(790, 532)
        Me.delAllButton.Name = "delAllButton"
        Me.delAllButton.Size = New System.Drawing.Size(298, 34)
        Me.delAllButton.TabIndex = 6
        Me.delAllButton.Text = "刪除全部"
        Me.delAllButton.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(790, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(298, 40)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "已設定病因"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'delButton
        '
        Me.delButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.delButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.delButton.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.delButton.Location = New System.Drawing.Point(790, 492)
        Me.delButton.Name = "delButton"
        Me.delButton.Size = New System.Drawing.Size(298, 34)
        Me.delButton.TabIndex = 4
        Me.delButton.Text = "刪除"
        Me.delButton.UseSelectable = True
        '
        'ICDList
        '
        Me.ICDList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ICDList.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ICDList.FormattingEnabled = True
        Me.ICDList.ItemHeight = 24
        Me.ICDList.Location = New System.Drawing.Point(790, 43)
        Me.ICDList.Name = "ICDList"
        Me.ICDList.Size = New System.Drawing.Size(298, 443)
        Me.ICDList.TabIndex = 5
        '
        'frmICD10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 689)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.confirmButton)
        Me.Name = "frmICD10"
        Me.Padding = New System.Windows.Forms.Padding(20, 60, 20, 60)
        Me.Text = "病名設定"
        CType(Me.ICDGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents searchBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ICDGrid As DataGridView
    Friend WithEvents confirmButton As MetroFramework.Controls.MetroButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents delButton As MetroFramework.Controls.MetroButton
    Friend WithEvents ICDList As ListBox
    Friend WithEvents delAllButton As MetroFramework.Controls.MetroButton
End Class
