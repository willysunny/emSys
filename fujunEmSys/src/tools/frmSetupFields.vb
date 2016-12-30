Public Class frmSetupFields
    Inherits MetroFramework.Forms.MetroForm

    Private tableName As String = ""
    Private tableCol As String = ""
    Private tableDesc As String = ""
    Private IDCol As String = ""
#Region "載入資訊"
    Public Sub New(ByVal tableAlias As String, ByVal table As String, ByVal colID As String, ByVal colName As String, colDesc As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.text = tableAlias & "資料設定"
        tableName = table
        tableCol = colName
        tableDesc = colDesc
        IDCol = colID
        reloadList()
    End Sub

    Public Sub reloadList()
        RemoveHandler colList.SelectedIndexChanged, AddressOf colList_SelectedIndexChanged
        With colList
            .DataSource = returnData(Me, "SELECT * FROM " & tableName)
            .ValueMember = IDCol
            .DisplayMember = tableCol
            .Refresh()
        End With
        AddHandler colList.SelectedIndexChanged, AddressOf colList_SelectedIndexChanged
    End Sub

    Private Sub colList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles colList.SelectedIndexChanged
        Dim reader As IDataReader = runQuery("SELECT * FROM " & tableName & " WHERE " & IDCol & "=" & colList.SelectedValue)
        If reader.Read Then
            descBox.Text = reader.Item(tableDesc)
        End If
    End Sub
#End Region

#Region "按鈕"
    Private Sub addItemButton_Click(sender As Object, e As EventArgs) Handles addItemButton.Click
        Dim inputName As String = InputBox("請輸入項目名稱:", "新增項目")
        If inputName.Trim = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "名稱不可為空!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MetroFramework.MetroMessageBox.Show(Me, "確認新增項目【" & inputName & "】?", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            runQuery("INSERT INTO " & tableName & " (" & tableCol & ") VALUE ('" & inputName & "')")
            reloadList()
        End If
    End Sub

    Private Sub editItemButton_Click(sender As Object, e As EventArgs) Handles editItemButton.Click
        Dim inputName As String = InputBox("請輸入新項目名稱:", "編輯項目", CType(colList.SelectedItem, DataRowView).Item(1))
        If inputName.Trim = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "名稱不可為空!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MetroFramework.MetroMessageBox.Show(Me, "確認修改項目名稱為【" & inputName & "】?", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim index As Integer = colList.SelectedIndex
            runQuery("UPDATE " & tableName & " SET " & tableCol & "='" & inputName & "' WHERE " & IDCol & "=" & colList.SelectedValue)
            reloadList()
            colList.SelectedIndex = index
        End If
    End Sub

    Private Sub delButton_Click(sender As Object, e As EventArgs) Handles delButton.Click
        If MetroFramework.MetroMessageBox.Show(Me, "確認刪除項目【" & CType(colList.SelectedItem, DataRowView).Item(1) & "】?", "再次確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            runQuery("DELETE FROM " & tableName & " WHERE " & IDCol & "=" & colList.SelectedValue)
            reloadList()
        End If
    End Sub

    Private Sub editDescButton_Click(sender As Object, e As EventArgs) Handles editDescButton.Click
        runQuery("UPDATE " & tableName & " SET " & tableDesc & "='" & descBox.Text & "' WHERE " & IDCol & "=" & colList.SelectedValue)
        MetroFramework.MetroMessageBox.Show(Me, "成功", "修改完成", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class