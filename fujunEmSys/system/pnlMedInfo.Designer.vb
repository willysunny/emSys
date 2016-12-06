<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlMedInfo
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
        Me.medInfoSplit = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.medList = New System.Windows.Forms.ListBox()
        Me.mainGroupList = New MetroFramework.Controls.MetroComboBox()
        Me.subGroupList = New MetroFramework.Controls.MetroComboBox()
        Me.unusedMedList = New MetroFramework.Controls.MetroCheckBox()
        CType(Me.medInfoSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.medInfoSplit.Panel1.SuspendLayout()
        Me.medInfoSplit.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.Location = New System.Drawing.Point(26, 26)
        '
        'medInfoSplit
        '
        Me.medInfoSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medInfoSplit.Location = New System.Drawing.Point(0, 0)
        Me.medInfoSplit.Name = "medInfoSplit"
        '
        'medInfoSplit.Panel1
        '
        Me.medInfoSplit.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.medInfoSplit.Size = New System.Drawing.Size(987, 649)
        Me.medInfoSplit.SplitterDistance = 329
        Me.medInfoSplit.TabIndex = 0
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(329, 649)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'medList
        '
        Me.medList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.medList.FormattingEnabled = True
        Me.medList.ItemHeight = 12
        Me.medList.Location = New System.Drawing.Point(3, 83)
        Me.medList.Name = "medList"
        Me.medList.Size = New System.Drawing.Size(323, 523)
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
        Me.mainGroupList.Size = New System.Drawing.Size(323, 35)
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
        Me.subGroupList.Size = New System.Drawing.Size(323, 35)
        Me.subGroupList.TabIndex = 2
        Me.subGroupList.UseSelectable = True
        '
        'unusedMedList
        '
        Me.unusedMedList.AutoSize = True
        Me.unusedMedList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.unusedMedList.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.unusedMedList.Location = New System.Drawing.Point(3, 612)
        Me.unusedMedList.Name = "unusedMedList"
        Me.unusedMedList.Size = New System.Drawing.Size(323, 34)
        Me.unusedMedList.TabIndex = 3
        Me.unusedMedList.Text = "顯示未分類藥品"
        Me.unusedMedList.UseSelectable = True
        '
        'pnlMedInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.medInfoSplit)
        Me.Name = "pnlMedInfo"
        Me.Size = New System.Drawing.Size(987, 649)
        Me.medInfoSplit.Panel1.ResumeLayout(False)
        CType(Me.medInfoSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.medInfoSplit.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents medInfoSplit As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents medList As ListBox
    Friend WithEvents mainGroupList As MetroFramework.Controls.MetroComboBox
    Friend WithEvents subGroupList As MetroFramework.Controls.MetroComboBox
    Friend WithEvents unusedMedList As MetroFramework.Controls.MetroCheckBox
End Class
