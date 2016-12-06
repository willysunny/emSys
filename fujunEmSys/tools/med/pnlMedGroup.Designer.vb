<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pnlMedGroup
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.medSubGroupItems = New System.Windows.Forms.ListBox()
        Me.medGroupItems = New System.Windows.Forms.ListBox()
        Me.moveLeftAll = New MetroFramework.Controls.MetroButton()
        Me.moveLeft = New MetroFramework.Controls.MetroButton()
        Me.moveRight = New MetroFramework.Controls.MetroButton()
        Me.moveRightAll = New MetroFramework.Controls.MetroButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.Location = New System.Drawing.Point(52, 52)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.medSubGroupItems, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.medGroupItems, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.moveLeftAll, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.moveLeft, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.moveRight, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.moveRightAll, 1, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(127, 110)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(503, 236)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'medSubGroupItems
        '
        Me.medSubGroupItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medSubGroupItems.FormattingEnabled = True
        Me.medSubGroupItems.ItemHeight = 12
        Me.medSubGroupItems.Location = New System.Drawing.Point(276, 45)
        Me.medSubGroupItems.Margin = New System.Windows.Forms.Padding(5)
        Me.medSubGroupItems.Name = "medSubGroupItems"
        Me.TableLayoutPanel1.SetRowSpan(Me.medSubGroupItems, 5)
        Me.medSubGroupItems.Size = New System.Drawing.Size(222, 190)
        Me.medSubGroupItems.TabIndex = 0
        '
        'medGroupItems
        '
        Me.medGroupItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medGroupItems.FormattingEnabled = True
        Me.medGroupItems.ItemHeight = 12
        Me.medGroupItems.Location = New System.Drawing.Point(5, 45)
        Me.medGroupItems.Margin = New System.Windows.Forms.Padding(5)
        Me.medGroupItems.Name = "medGroupItems"
        Me.TableLayoutPanel1.SetRowSpan(Me.medGroupItems, 5)
        Me.medGroupItems.Size = New System.Drawing.Size(221, 190)
        Me.medGroupItems.TabIndex = 0
        '
        'moveLeftAll
        '
        Me.moveLeftAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.moveLeftAll.Location = New System.Drawing.Point(234, 43)
        Me.moveLeftAll.Name = "moveLeftAll"
        Me.moveLeftAll.Size = New System.Drawing.Size(34, 34)
        Me.moveLeftAll.TabIndex = 1
        Me.moveLeftAll.Text = "<<"
        Me.moveLeftAll.UseSelectable = True
        '
        'moveLeft
        '
        Me.moveLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.moveLeft.Location = New System.Drawing.Point(234, 83)
        Me.moveLeft.Name = "moveLeft"
        Me.moveLeft.Size = New System.Drawing.Size(34, 34)
        Me.moveLeft.TabIndex = 2
        Me.moveLeft.Text = "<"
        Me.moveLeft.UseSelectable = True
        '
        'moveRight
        '
        Me.moveRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.moveRight.Location = New System.Drawing.Point(234, 163)
        Me.moveRight.Name = "moveRight"
        Me.moveRight.Size = New System.Drawing.Size(34, 34)
        Me.moveRight.TabIndex = 2
        Me.moveRight.Text = ">"
        Me.moveRight.UseSelectable = True
        '
        'moveRightAll
        '
        Me.moveRightAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.moveRightAll.Location = New System.Drawing.Point(234, 203)
        Me.moveRightAll.Name = "moveRightAll"
        Me.moveRightAll.Size = New System.Drawing.Size(34, 34)
        Me.moveRightAll.TabIndex = 2
        Me.moveRightAll.Text = ">>"
        Me.moveRightAll.UseSelectable = True
        '
        'pnlMedGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "pnlMedGroup"
        Me.Size = New System.Drawing.Size(1117, 623)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents medSubGroupItems As ListBox
    Friend WithEvents medGroupItems As ListBox
    Friend WithEvents moveLeftAll As MetroFramework.Controls.MetroButton
    Friend WithEvents moveLeft As MetroFramework.Controls.MetroButton
    Friend WithEvents moveRight As MetroFramework.Controls.MetroButton
    Friend WithEvents moveRightAll As MetroFramework.Controls.MetroButton
End Class
