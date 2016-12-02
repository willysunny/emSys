<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.exitLink = New MetroFramework.Controls.MetroLink()
        Me.settingsLink = New MetroFramework.Controls.MetroLink()
        Me.sysStyleManager = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.病人資料查詢QToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.醫師資料維護DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.藥品資料維護MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.sysStyleManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitLink
        '
        Me.exitLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitLink.Image = Global.emSys2016.My.Resources.Resources.shutdownHover
        Me.exitLink.ImageSize = 40
        Me.exitLink.Location = New System.Drawing.Point(1122, 22)
        Me.exitLink.Name = "exitLink"
        Me.exitLink.NoFocusImage = Global.emSys2016.My.Resources.Resources.shutdownUp
        Me.exitLink.Size = New System.Drawing.Size(50, 50)
        Me.exitLink.TabIndex = 0
        Me.exitLink.UseSelectable = True
        '
        'settingsLink
        '
        Me.settingsLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsLink.Image = Global.emSys2016.My.Resources.Resources.settingHover
        Me.settingsLink.ImageSize = 40
        Me.settingsLink.Location = New System.Drawing.Point(1066, 22)
        Me.settingsLink.Name = "settingsLink"
        Me.settingsLink.NoFocusImage = Global.emSys2016.My.Resources.Resources.settingUp
        Me.settingsLink.Size = New System.Drawing.Size(50, 50)
        Me.settingsLink.TabIndex = 0
        Me.settingsLink.UseSelectable = True
        '
        'sysStyleManager
        '
        Me.sysStyleManager.Owner = Me
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.病人資料查詢QToolStripMenuItem, Me.醫師資料維護DToolStripMenuItem, Me.藥品資料維護MToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(170, 70)
        '
        '病人資料查詢QToolStripMenuItem
        '
        Me.病人資料查詢QToolStripMenuItem.Name = "病人資料查詢QToolStripMenuItem"
        Me.病人資料查詢QToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.病人資料查詢QToolStripMenuItem.Text = "病人資料維護 (&Q)"
        '
        '醫師資料維護DToolStripMenuItem
        '
        Me.醫師資料維護DToolStripMenuItem.Name = "醫師資料維護DToolStripMenuItem"
        Me.醫師資料維護DToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.醫師資料維護DToolStripMenuItem.Text = "醫師資料維護 (&D)"
        '
        '藥品資料維護MToolStripMenuItem
        '
        Me.藥品資料維護MToolStripMenuItem.Name = "藥品資料維護MToolStripMenuItem"
        Me.藥品資料維護MToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.藥品資料維護MToolStripMenuItem.Text = "藥品資料維護 (&M)"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 70)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1175, 630)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackMaxSize = 4096
        Me.ClientSize = New System.Drawing.Size(1175, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.exitLink)
        Me.Controls.Add(Me.settingsLink)
        Me.Name = "mainForm"
        Me.Padding = New System.Windows.Forms.Padding(0, 70, 0, 0)
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "福濬生物醫學系統"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.sysStyleManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents settingsLink As MetroFramework.Controls.MetroLink
    Friend WithEvents exitLink As MetroFramework.Controls.MetroLink
    Friend WithEvents sysStyleManager As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents 病人資料查詢QToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents 醫師資料維護DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 藥品資料維護MToolStripMenuItem As ToolStripMenuItem
End Class
