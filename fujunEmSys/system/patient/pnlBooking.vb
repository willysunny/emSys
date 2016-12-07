Public Class pnlBooking
    Inherits pnlSlider
    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)
        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
