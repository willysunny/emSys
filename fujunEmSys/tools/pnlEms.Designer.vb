<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlEms
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlEms))
        Me.InstantDoCtrl1 = New Automation.BDaq.InstantDoCtrl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'InstantDoCtrl1
        '
        Me.InstantDoCtrl1._StateStream = CType(resources.GetObject("InstantDoCtrl1._StateStream"), Automation.BDaq.DeviceStateStreamer)
        '
        'pnlEms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "pnlEms"
        Me.Size = New System.Drawing.Size(1211, 713)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InstantDoCtrl1 As Automation.BDaq.InstantDoCtrl
    Friend WithEvents Timer1 As Timer
End Class
