<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlBooking
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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MetroPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.ClientSize = New System.Drawing.Size(0, 0)
        Me.owner.Location = New System.Drawing.Point(-32000, -32000)
        Me.owner.WindowState = System.Windows.Forms.FormWindowState.Minimized
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.MetroPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1053, 683)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MonthCalendar1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 683.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 683.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1053, 683)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 0)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(0)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'pnlBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "pnlBooking"
        Me.Size = New System.Drawing.Size(1053, 683)
        Me.MetroPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
