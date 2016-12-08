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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.bookingLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.delBookingButton = New MetroFramework.Controls.MetroButton()
        Me.addBookingButton = New MetroFramework.Controls.MetroButton()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.checkTime = New MetroFramework.Controls.MetroDateTime()
        Me.sqlDataGrid = New System.Windows.Forms.DataGridView()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.minuteNumber = New System.Windows.Forms.NumericUpDown()
        Me.hourNumber = New System.Windows.Forms.NumericUpDown()
        Me.bookDate = New MetroFramework.Controls.MetroDateTime()
        Me.timeList = New MetroFramework.Controls.MetroComboBox()
        Me.docList = New MetroFramework.Controls.MetroComboBox()
        Me.editButton = New MetroFramework.Controls.MetroButton()
        Me.changePatientButton = New MetroFramework.Controls.MetroButton()
        Me.pName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        Me.bookingLayout.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        CType(Me.sqlDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel3.SuspendLayout()
        CType(Me.minuteNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hourNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'owner
        '
        Me.owner.ClientSize = New System.Drawing.Size(120, 0)
        Me.owner.Location = New System.Drawing.Point(-32000, -32000)
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.MetroPanel1.Controls.Add(Me.bookingLayout)
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
        'bookingLayout
        '
        Me.bookingLayout.BackColor = System.Drawing.Color.DarkSlateGray
        Me.bookingLayout.ColumnCount = 3
        Me.bookingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.bookingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.bookingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.bookingLayout.Controls.Add(Me.MetroPanel2, 0, 0)
        Me.bookingLayout.Controls.Add(Me.sqlDataGrid, 1, 0)
        Me.bookingLayout.Controls.Add(Me.MetroPanel3, 2, 0)
        Me.bookingLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bookingLayout.Location = New System.Drawing.Point(0, 0)
        Me.bookingLayout.Name = "bookingLayout"
        Me.bookingLayout.RowCount = 1
        Me.bookingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 683.0!))
        Me.bookingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 683.0!))
        Me.bookingLayout.Size = New System.Drawing.Size(1053, 683)
        Me.bookingLayout.TabIndex = 5
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.Cornsilk
        Me.MetroPanel2.Controls.Add(Me.delBookingButton)
        Me.MetroPanel2.Controls.Add(Me.addBookingButton)
        Me.MetroPanel2.Controls.Add(Me.MetroLink1)
        Me.MetroPanel2.Controls.Add(Me.checkTime)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(3, 3)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Padding = New System.Windows.Forms.Padding(10)
        Me.MetroPanel2.Size = New System.Drawing.Size(214, 157)
        Me.MetroPanel2.TabIndex = 0
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'delBookingButton
        '
        Me.delBookingButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.delBookingButton.Location = New System.Drawing.Point(13, 112)
        Me.delBookingButton.Name = "delBookingButton"
        Me.delBookingButton.Size = New System.Drawing.Size(188, 29)
        Me.delBookingButton.TabIndex = 5
        Me.delBookingButton.Text = "刪除預約"
        Me.delBookingButton.UseSelectable = True
        '
        'addBookingButton
        '
        Me.addBookingButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.addBookingButton.Location = New System.Drawing.Point(13, 77)
        Me.addBookingButton.Name = "addBookingButton"
        Me.addBookingButton.Size = New System.Drawing.Size(188, 29)
        Me.addBookingButton.TabIndex = 4
        Me.addBookingButton.Text = "新增預約"
        Me.addBookingButton.UseSelectable = True
        '
        'MetroLink1
        '
        Me.MetroLink1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink1.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular
        Me.MetroLink1.Location = New System.Drawing.Point(13, 13)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(100, 23)
        Me.MetroLink1.TabIndex = 3
        Me.MetroLink1.Text = "查看日期"
        Me.MetroLink1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink1.UseCustomBackColor = True
        Me.MetroLink1.UseSelectable = True
        '
        'checkTime
        '
        Me.checkTime.Location = New System.Drawing.Point(13, 42)
        Me.checkTime.MinimumSize = New System.Drawing.Size(0, 29)
        Me.checkTime.Name = "checkTime"
        Me.checkTime.Size = New System.Drawing.Size(188, 29)
        Me.checkTime.TabIndex = 2
        '
        'sqlDataGrid
        '
        Me.sqlDataGrid.AllowUserToAddRows = False
        Me.sqlDataGrid.AllowUserToDeleteRows = False
        Me.sqlDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sqlDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.sqlDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sqlDataGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.sqlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sqlDataGrid.Location = New System.Drawing.Point(223, 3)
        Me.sqlDataGrid.Name = "sqlDataGrid"
        Me.sqlDataGrid.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sqlDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.sqlDataGrid.RowTemplate.Height = 24
        Me.sqlDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sqlDataGrid.Size = New System.Drawing.Size(527, 677)
        Me.sqlDataGrid.TabIndex = 1
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.MetroPanel3.Controls.Add(Me.minuteNumber)
        Me.MetroPanel3.Controls.Add(Me.hourNumber)
        Me.MetroPanel3.Controls.Add(Me.bookDate)
        Me.MetroPanel3.Controls.Add(Me.timeList)
        Me.MetroPanel3.Controls.Add(Me.docList)
        Me.MetroPanel3.Controls.Add(Me.editButton)
        Me.MetroPanel3.Controls.Add(Me.changePatientButton)
        Me.MetroPanel3.Controls.Add(Me.pName)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(756, 3)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Padding = New System.Windows.Forms.Padding(10)
        Me.MetroPanel3.Size = New System.Drawing.Size(294, 677)
        Me.MetroPanel3.TabIndex = 2
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'minuteNumber
        '
        Me.minuteNumber.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!)
        Me.minuteNumber.ForeColor = System.Drawing.SystemColors.GrayText
        Me.minuteNumber.Location = New System.Drawing.Point(206, 255)
        Me.minuteNumber.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.minuteNumber.Name = "minuteNumber"
        Me.minuteNumber.Size = New System.Drawing.Size(75, 29)
        Me.minuteNumber.TabIndex = 8
        '
        'hourNumber
        '
        Me.hourNumber.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!)
        Me.hourNumber.ForeColor = System.Drawing.SystemColors.GrayText
        Me.hourNumber.Location = New System.Drawing.Point(125, 255)
        Me.hourNumber.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.hourNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hourNumber.Name = "hourNumber"
        Me.hourNumber.Size = New System.Drawing.Size(75, 29)
        Me.hourNumber.TabIndex = 8
        Me.hourNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'bookDate
        '
        Me.bookDate.Location = New System.Drawing.Point(13, 220)
        Me.bookDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.bookDate.Name = "bookDate"
        Me.bookDate.Size = New System.Drawing.Size(268, 29)
        Me.bookDate.TabIndex = 7
        '
        'timeList
        '
        Me.timeList.FormattingEnabled = True
        Me.timeList.ItemHeight = 23
        Me.timeList.Location = New System.Drawing.Point(13, 255)
        Me.timeList.Name = "timeList"
        Me.timeList.Size = New System.Drawing.Size(106, 29)
        Me.timeList.TabIndex = 6
        Me.timeList.UseSelectable = True
        '
        'docList
        '
        Me.docList.FormattingEnabled = True
        Me.docList.ItemHeight = 23
        Me.docList.Location = New System.Drawing.Point(13, 160)
        Me.docList.Name = "docList"
        Me.docList.Size = New System.Drawing.Size(268, 29)
        Me.docList.TabIndex = 6
        Me.docList.UseSelectable = True
        '
        'editButton
        '
        Me.editButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.editButton.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.editButton.Location = New System.Drawing.Point(13, 629)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(268, 29)
        Me.editButton.TabIndex = 5
        Me.editButton.Text = "修改預約"
        Me.editButton.UseSelectable = True
        '
        'changePatientButton
        '
        Me.changePatientButton.Location = New System.Drawing.Point(206, 106)
        Me.changePatientButton.Name = "changePatientButton"
        Me.changePatientButton.Size = New System.Drawing.Size(75, 23)
        Me.changePatientButton.TabIndex = 5
        Me.changePatientButton.Text = "變更病患"
        Me.changePatientButton.UseSelectable = True
        '
        'pName
        '
        '
        '
        '
        Me.pName.CustomButton.Image = Nothing
        Me.pName.CustomButton.Location = New System.Drawing.Point(240, 2)
        Me.pName.CustomButton.Name = ""
        Me.pName.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.pName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.pName.CustomButton.TabIndex = 1
        Me.pName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.pName.CustomButton.UseSelectable = True
        Me.pName.CustomButton.Visible = False
        Me.pName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.pName.Lines = New String(-1) {}
        Me.pName.Location = New System.Drawing.Point(13, 70)
        Me.pName.MaxLength = 32767
        Me.pName.Name = "pName"
        Me.pName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pName.PromptText = "病患姓名"
        Me.pName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.pName.SelectedText = ""
        Me.pName.SelectionLength = 0
        Me.pName.SelectionStart = 0
        Me.pName.ShortcutsEnabled = True
        Me.pName.Size = New System.Drawing.Size(268, 30)
        Me.pName.TabIndex = 4
        Me.pName.UseSelectable = True
        Me.pName.WaterMark = "病患姓名"
        Me.pName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.pName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(13, 192)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(145, 25)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "預約日期與時間"
        Me.MetroLabel4.UseCustomBackColor = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(13, 132)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(88, 25)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "看診醫師"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 42)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(88, 25)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "病患姓名"
        Me.MetroLabel2.UseCustomBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(13, 10)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(92, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "預約資訊"
        '
        'pnlBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "pnlBooking"
        Me.Size = New System.Drawing.Size(1053, 683)
        Me.MetroPanel1.ResumeLayout(False)
        Me.bookingLayout.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        CType(Me.sqlDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        CType(Me.minuteNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hourNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents bookingLayout As TableLayoutPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents checkTime As MetroFramework.Controls.MetroDateTime
    Friend WithEvents delBookingButton As MetroFramework.Controls.MetroButton
    Friend WithEvents addBookingButton As MetroFramework.Controls.MetroButton
    Friend WithEvents sqlDataGrid As DataGridView
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents pName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents bookDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents docList As MetroFramework.Controls.MetroComboBox
    Friend WithEvents changePatientButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents editButton As MetroFramework.Controls.MetroButton
    Friend WithEvents minuteNumber As NumericUpDown
    Friend WithEvents hourNumber As NumericUpDown
    Friend WithEvents timeList As MetroFramework.Controls.MetroComboBox
End Class
