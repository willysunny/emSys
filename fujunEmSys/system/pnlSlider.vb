Public Class pnlSlider

    Public owner As New Form
    Public loaded As Boolean = False
    Public menuStatus As Boolean = False
    Public rightSide As Boolean = False

#Region "Event"
    Public Event closedEvent As EventHandler
    Public Event shownEvent As EventHandler

    Protected Sub closed(ByVal e As EventArgs)
        RaiseEvent closedEvent(Me, e)
    End Sub
    Protected Sub shown(ByVal e As EventArgs)
        Me.BringToFront()
        RaiseEvent shownEvent(Me, e)
    End Sub
#End Region

    Public Sub New()

        ' this call is required by the designer.
        InitializeComponent()

        ' add any initialization after the initializecomponent() call.

    End Sub

    Public Sub New(ByVal frmOwner As Form)
        Me.Visible = False
        owner = frmOwner
        frmOwner.Controls.Add(Me)
        resizeForm()
        Me.BringToFront()
        AddHandler owner.Resize, AddressOf owner_resize
    End Sub

    Public Sub owner_resize(ByVal sender As Object, ByVal e As EventArgs)
        resizeForm(menuStatus, rightSide)
    End Sub

    Public Sub resizeForm(Optional ByVal isMenu As Boolean = False, Optional fromRight As Boolean = False)
        If Not isMenu Then Me.Width = owner.Width
        Me.Height = owner.Height - 70
        If loaded Then
            If isMenu Then
                If fromRight Then
                    Me.Location = New Point(owner.Width - Me.Width, 70)
                Else
                    Me.Location = New Point(0, 70)
                End If
            Else
                Me.Location = New Point(0, 70)
            End If
        Else
            Me.Location = New Point(owner.Width, 70)
        End If
        menuStatus = isMenu
        rightSide = fromRight
    End Sub

    Public Sub swipe(Optional show As Boolean = True)
        resizeForm()
        Me.Visible = True
        Dim trans As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(2000))
        If show Then
            trans.add(Me, "Left", 0)
            trans.run()
            While Not (Me.Left = 0)
                Application.DoEvents()
            End While
            loaded = True
            resizeForm()
            shown(New EventArgs)
        Else
            trans.add(Me, "Left", -owner.Width)
            trans.run()
            While Not (Me.Left = -owner.Width)
                Application.DoEvents()
            End While
            closed(New EventArgs())
            RemoveHandler owner.Resize, AddressOf owner_resize
            owner.Controls.Remove(Me)
            Me.Dispose()
        End If

    End Sub
    Public Sub menuSwipe(Optional show As Boolean = True, Optional fromRight As Boolean = False, Optional resize As Boolean = True)
        resizeForm(True, fromRight)
        Me.Visible = True
        Dim trans As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(1000))
        Dim dest As Integer = 0
        Dim orig As Integer = -Me.Width
        If Not fromRight Then
            Me.Left = -Me.Width
        Else
            If show Then Me.Left = owner.Width
            dest = owner.Width - Me.Width
            orig = owner.Width
        End If

        If show Then
            trans.add(Me, "Left", dest)
            trans.run()
            While Not (Me.Left = dest)
                Application.DoEvents()
            End While
            loaded = True
            If resize Then resizeForm(True, fromRight)
            shown(New EventArgs)
        Else
            trans.add(Me, "Left", orig)
            trans.run()
            While Not (Me.Left = orig)
                Application.DoEvents()
            End While
            closed(New EventArgs())
            RemoveHandler owner.Resize, AddressOf owner_resize
            owner.Controls.Remove(Me)
            Me.Dispose()
        End If

    End Sub
End Class
