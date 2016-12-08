Public Class frmUserQuery

    Public Event patientSelected As EventHandler
    Public resultInfo As New pInfo

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        loadData()
    End Sub
    ' 載入資訊
    Public Sub loadData(Optional ByVal whereClause As String = "")
        Dim sql As String = "SELECT SELECT pID as '病歷號碼', pName as '病患姓名' pPID as '身分證字號', pDOB as '生日', pMobile as '手機號碼' FROM patient"
        If Not whereClause = "" Then
            sql += " WHERE " & whereClause
        End If
        sqlGrid.DataSource = returnData(Me, sql & " ORDER BY pID DESC Limit 100;")
    End Sub
    ' 搜尋
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim assumptions As String = ""
        assumptions += "pID LIKE '%" & searchBox.Text & "%' OR "
        assumptions += "pName LIKE '%" & searchBox.Text & "%' OR "
        assumptions += "pPID LIKE '%" & searchBox.Text & "%' OR "
        assumptions += "pMobile LIKE '%" & searchBox.Text & "%'"
        loadData(assumptions)
    End Sub
    ' 取消
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub
    ' 選取
    Private Sub selectButton_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If sqlGrid.SelectedRows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "請先選擇病人。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            resultInfo.initiate(sqlGrid.SelectedRows(0).Cells("病歷號碼").Value)
            RaiseEvent patientSelected(Me, New EventArgs())
            Me.Close()
        End If
    End Sub
    Private Sub sqlGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles sqlGrid.CellDoubleClick
        resultInfo.initiate(sqlGrid.SelectedRows(0).Cells("病歷號碼").Value)
        RaiseEvent patientSelected(Me, New EventArgs())
        Me.Close()
    End Sub
End Class