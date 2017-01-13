Public Class frmCare
    Inherits MetroFramework.Forms.MetroForm

    Public Event careSet As EventHandler
    Private bID As Integer

    Public Sub New(ByVal bookingID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bID = bookingID
        dumpCares()
        checkCares()
    End Sub
    ' 倒出所有基因缺陷
    Private Sub dumpCares()
        Dim dt As DataTable = returnData(Me, "SELECT careID, careName FROM care")
        For Each row As DataRow In dt.Rows
            Dim cb As New MetroFramework.Controls.MetroCheckBox
            cb.Name = "care_" & row.Item("careID")
            cb.Text = row.Item("careName")
            cb.Tag = row.Item("careID")
            'AddHandler cb.CheckStateChanged, AddressOf cb_CheckStateChanged
            careFlow.Controls.Add(cb)
        Next
    End Sub
    ' 檢查已存在基因缺陷
    Private Sub checkCares()
        Dim dt As DataTable = returnData(Me, "SELECT bID, careID FROM booking_care WHERE bID=" & bID)
        For Each row As DataRow In dt.Rows
            DirectCast(careFlow.Controls("care_" & row.Item("careID")), MetroFramework.Controls.MetroCheckBox).Checked = True
        Next
    End Sub

    Private Sub cb_checkStateChanged(ByVal sender As Object, ByVal e As EventArgs)
        Debug.WriteLine(sender.Tag)
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        runQuery("DELETE FROM booking_care WHERE bID=" & bID)
        For Each cb As MetroFramework.Controls.MetroCheckBox In careFlow.Controls
            If cb.Checked Then runQuery("INSERT INTO booking_care VALUES (" & bID & "," & cb.Tag.ToString & ")")
        Next
        RaiseEvent careSet(Me, New EventArgs)
        Me.Close()
    End Sub
End Class