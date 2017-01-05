<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlu
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
        Me.fluFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.confirmButton = New MetroFramework.Controls.MetroButton()
        Me.cancelButton = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'fluFlow
        '
        Me.fluFlow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fluFlow.Font = New System.Drawing.Font("Microsoft JhengHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.fluFlow.Location = New System.Drawing.Point(3, 18)
        Me.fluFlow.Name = "fluFlow"
        Me.fluFlow.Size = New System.Drawing.Size(313, 281)
        Me.fluFlow.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fluFlow)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(20, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 302)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'confirmButton
        '
        Me.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.confirmButton.Location = New System.Drawing.Point(182, 369)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(75, 23)
        Me.confirmButton.TabIndex = 2
        Me.confirmButton.Text = "確定"
        Me.confirmButton.UseSelectable = True
        '
        'cancelButton
        '
        Me.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cancelButton.Location = New System.Drawing.Point(101, 368)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 2
        Me.cancelButton.Text = "取消"
        Me.cancelButton.UseSelectable = True
        '
        'frmFlu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 422)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.confirmButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFlu"
        Me.Padding = New System.Windows.Forms.Padding(20, 60, 20, 60)
        Me.Text = "時疫"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fluFlow As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents confirmButton As MetroFramework.Controls.MetroButton
    Friend WithEvents cancelButton As MetroFramework.Controls.MetroButton
End Class
