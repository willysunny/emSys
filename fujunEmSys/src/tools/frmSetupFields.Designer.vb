<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetupFields
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.colList = New System.Windows.Forms.ListBox()
        Me.descBox = New System.Windows.Forms.TextBox()
        Me.addItemButton = New MetroFramework.Controls.MetroButton()
        Me.editItemButton = New MetroFramework.Controls.MetroButton()
        Me.delButton = New MetroFramework.Controls.MetroButton()
        Me.editDescButton = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.colList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.descBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.addItemButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.editItemButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.delButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.editDescButton, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(785, 562)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'colList
        '
        Me.colList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colList.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.colList.FormattingEnabled = True
        Me.colList.ItemHeight = 20
        Me.colList.Location = New System.Drawing.Point(3, 33)
        Me.colList.Name = "colList"
        Me.colList.Size = New System.Drawing.Size(190, 406)
        Me.colList.TabIndex = 0
        '
        'descBox
        '
        Me.descBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.descBox.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.descBox.Location = New System.Drawing.Point(199, 33)
        Me.descBox.Multiline = True
        Me.descBox.Name = "descBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.descBox, 3)
        Me.descBox.Size = New System.Drawing.Size(583, 486)
        Me.descBox.TabIndex = 1
        '
        'addItemButton
        '
        Me.addItemButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addItemButton.Location = New System.Drawing.Point(3, 445)
        Me.addItemButton.Name = "addItemButton"
        Me.addItemButton.Size = New System.Drawing.Size(190, 34)
        Me.addItemButton.TabIndex = 2
        Me.addItemButton.Text = "新增項目"
        Me.addItemButton.UseSelectable = True
        '
        'editItemButton
        '
        Me.editItemButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editItemButton.Location = New System.Drawing.Point(3, 485)
        Me.editItemButton.Name = "editItemButton"
        Me.editItemButton.Size = New System.Drawing.Size(190, 34)
        Me.editItemButton.TabIndex = 2
        Me.editItemButton.Text = "修改項目"
        Me.editItemButton.UseSelectable = True
        '
        'delButton
        '
        Me.delButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.delButton.Location = New System.Drawing.Point(3, 525)
        Me.delButton.Name = "delButton"
        Me.delButton.Size = New System.Drawing.Size(190, 34)
        Me.delButton.TabIndex = 2
        Me.delButton.Text = "刪除項目"
        Me.delButton.UseSelectable = True
        '
        'editDescButton
        '
        Me.editDescButton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.editDescButton.Location = New System.Drawing.Point(670, 525)
        Me.editDescButton.Name = "editDescButton"
        Me.editDescButton.Size = New System.Drawing.Size(112, 34)
        Me.editDescButton.TabIndex = 2
        Me.editDescButton.Text = "修改說明"
        Me.editDescButton.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(190, 30)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "項目"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(199, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(583, 30)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "說明"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSetupFields
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 642)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmSetupFields"
        Me.Text = "資料設定"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents colList As ListBox
    Friend WithEvents addItemButton As MetroFramework.Controls.MetroButton
    Friend WithEvents editItemButton As MetroFramework.Controls.MetroButton
    Friend WithEvents delButton As MetroFramework.Controls.MetroButton
    Friend WithEvents editDescButton As MetroFramework.Controls.MetroButton
    Friend WithEvents descBox As TextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class
