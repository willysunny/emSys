<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserReport))
        Me.printDlg = New System.Windows.Forms.PrintDialog()
        Me.printDoc = New System.Drawing.Printing.PrintDocument()
        Me.printPreviewDlg = New System.Windows.Forms.PrintPreviewDialog()
        Me.historyBox = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.changePatient = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.pName = New MetroFramework.Controls.MetroTextBox()
        Me.printGraphButton = New MetroFramework.Controls.MetroButton()
        Me.printEnergyButton = New MetroFramework.Controls.MetroButton()
        Me.printFeeButton = New MetroFramework.Controls.MetroButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'printDlg
        '
        Me.printDlg.Document = Me.printDoc
        Me.printDlg.UseEXDialog = True
        '
        'printDoc
        '
        '
        'printPreviewDlg
        '
        Me.printPreviewDlg.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDlg.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDlg.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDlg.Enabled = True
        Me.printPreviewDlg.Icon = CType(resources.GetObject("printPreviewDlg.Icon"), System.Drawing.Icon)
        Me.printPreviewDlg.Name = "printPreviewDlg"
        Me.printPreviewDlg.Visible = False
        '
        'historyBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.historyBox, 2)
        Me.historyBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.historyBox.FormattingEnabled = True
        Me.historyBox.ItemHeight = 12
        Me.historyBox.Location = New System.Drawing.Point(103, 38)
        Me.historyBox.Name = "historyBox"
        Me.historyBox.Size = New System.Drawing.Size(199, 330)
        Me.historyBox.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.historyBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.changePatient, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pName, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 63)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(305, 371)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'changePatient
        '
        Me.changePatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.changePatient.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.changePatient.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.changePatient.Location = New System.Drawing.Point(208, 3)
        Me.changePatient.Name = "changePatient"
        Me.changePatient.Size = New System.Drawing.Size(94, 29)
        Me.changePatient.TabIndex = 3
        Me.changePatient.Text = "變更病患"
        Me.changePatient.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(94, 35)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "病患姓名"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 35)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(94, 336)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "病患紀錄"
        '
        'pName
        '
        '
        '
        '
        Me.pName.CustomButton.Image = Nothing
        Me.pName.CustomButton.Location = New System.Drawing.Point(71, 1)
        Me.pName.CustomButton.Name = ""
        Me.pName.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.pName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pName.CustomButton.TabIndex = 1
        Me.pName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pName.CustomButton.UseSelectable = True
        Me.pName.CustomButton.Visible = False
        Me.pName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pName.Enabled = False
        Me.pName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pName.Lines = New String(-1) {}
        Me.pName.Location = New System.Drawing.Point(103, 3)
        Me.pName.MaxLength = 32767
        Me.pName.Name = "pName"
        Me.pName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pName.PromptText = "未顯示"
        Me.pName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pName.SelectedText = ""
        Me.pName.SelectionLength = 0
        Me.pName.SelectionStart = 0
        Me.pName.ShortcutsEnabled = True
        Me.pName.Size = New System.Drawing.Size(99, 29)
        Me.pName.TabIndex = 6
        Me.pName.UseSelectable = True
        Me.pName.WaterMark = "未顯示"
        Me.pName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.pName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'printGraphButton
        '
        Me.printGraphButton.Location = New System.Drawing.Point(427, 125)
        Me.printGraphButton.Name = "printGraphButton"
        Me.printGraphButton.Size = New System.Drawing.Size(75, 23)
        Me.printGraphButton.TabIndex = 3
        Me.printGraphButton.Text = "頻譜報告"
        Me.printGraphButton.UseSelectable = True
        '
        'printEnergyButton
        '
        Me.printEnergyButton.Location = New System.Drawing.Point(427, 164)
        Me.printEnergyButton.Name = "printEnergyButton"
        Me.printEnergyButton.Size = New System.Drawing.Size(75, 23)
        Me.printEnergyButton.TabIndex = 3
        Me.printEnergyButton.Text = "元氣報告"
        Me.printEnergyButton.UseSelectable = True
        '
        'printFeeButton
        '
        Me.printFeeButton.Location = New System.Drawing.Point(427, 207)
        Me.printFeeButton.Name = "printFeeButton"
        Me.printFeeButton.Size = New System.Drawing.Size(75, 23)
        Me.printFeeButton.TabIndex = 3
        Me.printFeeButton.Text = "列印金額"
        Me.printFeeButton.UseSelectable = True
        '
        'frmUserReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 457)
        Me.Controls.Add(Me.printFeeButton)
        Me.Controls.Add(Me.printEnergyButton)
        Me.Controls.Add(Me.printGraphButton)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmUserReport"
        Me.Text = "病患報告"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents printDlg As PrintDialog
    Friend WithEvents printDoc As Printing.PrintDocument
    Friend WithEvents printPreviewDlg As PrintPreviewDialog
    Friend WithEvents historyBox As ListBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents changePatient As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents printGraphButton As MetroFramework.Controls.MetroButton
    Friend WithEvents printEnergyButton As MetroFramework.Controls.MetroButton
    Friend WithEvents printFeeButton As MetroFramework.Controls.MetroButton
End Class
