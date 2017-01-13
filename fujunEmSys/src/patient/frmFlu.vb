Public Class frmFlu
    Inherits MetroFramework.Forms.MetroForm

    Public Event fluSet As EventHandler
    Private bID As Integer

    Public Sub New(ByVal bookingID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bID = bookingID
        dumpFlus()
        checkFlus()
    End Sub
    ' 倒出所有基因缺陷
    Private Sub dumpFlus()
        Dim dt As DataTable = returnData(Me, "SELECT fluID, fluName FROM commonFlu")
        For Each row As DataRow In dt.Rows
            Dim cb As New MetroFramework.Controls.MetroCheckBox
            cb.Name = "flu_" & row.Item("fluID")
            cb.Text = row.Item("fluName")
            cb.Tag = row.Item("fluID")
            'AddHandler cb.CheckStateChanged, AddressOf cb_CheckStateChanged
            fluFlow.Controls.Add(cb)
        Next
    End Sub
    ' 檢查已存在基因缺陷
    Private Sub checkFlus()
        Dim dt As DataTable = returnData(Me, "SELECT bID, fluID FROM booking_flu WHERE bID=" & bID)
        For Each row As DataRow In dt.Rows
            DirectCast(fluFlow.Controls("flu_" & row.Item("fluID")), MetroFramework.Controls.MetroCheckBox).Checked = True
        Next
    End Sub

    Private Sub cb_checkStateChanged(ByVal sender As Object, ByVal e As EventArgs)
        Debug.WriteLine(sender.Tag)
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        runQuery("DELETE FROM booking_flu WHERE bID=" & bID)
        For Each cb As MetroFramework.Controls.MetroCheckBox In fluFlow.Controls
            If cb.Checked Then runQuery("INSERT INTO booking_flu VALUES (" & bID & "," & cb.Tag.ToString & ")")
        Next
        RaiseEvent fluSet(Me, New EventArgs)
        Me.Close()
    End Sub
End Class