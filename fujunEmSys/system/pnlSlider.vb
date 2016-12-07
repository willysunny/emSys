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
        BringToFront()
        RaiseEvent shownEvent(Me, e)
    End Sub
#End Region

    Public Sub New()

        ' this call is required by the designer.
        InitializeComponent()

        ' add any initialization after the initializecomponent() call.

    End Sub

    Public Sub New(ByVal frmOwner As Form)
        Visible = False
        owner = frmOwner
        frmOwner.Controls.Add(Me)
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()
        resizeForm()
        BringToFront()
        AddHandler owner.Resize, AddressOf owner_resize
    End Sub

    Public Sub owner_resize(ByVal sender As Object, ByVal e As EventArgs)
        resizeForm(menuStatus, rightSide)
    End Sub

    Public Sub resizeForm(Optional ByVal isMenu As Boolean = False, Optional fromRight As Boolean = False)
        If Not isMenu Then Width = owner.Width
        Height = owner.Height - 70
        If loaded Then
            If isMenu Then
                If fromRight Then
                    Location = New Point(owner.Width - Width, 70)
                Else
                    Location = New Point(0, 70)
                End If
            Else
                Location = New Point(0, 70)
            End If
        Else
            Location = New Point(owner.Width, 70)
        End If
        menuStatus = isMenu
        rightSide = fromRight
    End Sub

    Public Sub swipe(Optional show As Boolean = True)
        resizeForm()
        Visible = True
        If show Then
            Dim trans As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(2000))
            trans.add(Me, "Left", 0)
            trans.run()
            While Not (Left = 0)
                Application.DoEvents()
            End While
            loaded = True
            resizeForm()
            shown(New EventArgs)
        Else
            Dim trans As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(1000))
            trans.add(Me, "Left", -owner.Width)
            trans.run()
            While Not (Left = -owner.Width)
                Application.DoEvents()
            End While
            closed(New EventArgs())
            RemoveHandler owner.Resize, AddressOf owner_resize
            owner.Controls.Remove(Me)
            Dispose()
        End If

    End Sub
    Public Sub menuSwipe(Optional show As Boolean = True, Optional fromRight As Boolean = False, Optional resize As Boolean = True)
        resizeForm(True, fromRight)
        Visible = True
        Dim trans As New Transitions.Transition(New Transitions.TransitionType_EaseInEaseOut(1000))
        Dim dest As Integer = 0
        Dim orig As Integer = -Width
        If Not fromRight Then
            Left = -Width
        Else
            If show Then Left = owner.Width
            dest = owner.Width - Width
            orig = owner.Width
        End If

        If show Then
            trans.add(Me, "Left", dest)
            trans.run()
            While Not (Left = dest)
                Application.DoEvents()
            End While
            loaded = True
            If resize Then resizeForm(True, fromRight)
            shown(New EventArgs)
        Else
            trans.add(Me, "Left", orig)
            trans.run()
            While Not (Left = orig)
                Application.DoEvents()
            End While
            closed(New EventArgs())
            RemoveHandler owner.Resize, AddressOf owner_resize
            owner.Controls.Remove(Me)
            Dispose()
        End If

    End Sub

    Public Function isEventHandlerRegistered(ByVal target As Object, ByVal prospectiveHandler As [Delegate]) As Boolean
        If Not target.EventHandler Is Nothing Then
            For Each existingHandler As [Delegate] In target.EventHandler.GetInvocationList()
                If existingHandler = prospectiveHandler Then Return True
            Next
        End If
        Return False
    End Function
End Class
