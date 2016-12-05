Public Class pnlPatientInfo
    Inherits pnlSlider

    Private MySqlCon As MySql.Data.MySqlClient.MySqlConnection
    Private MySqlAdapter As MySql.Data.MySqlClient.MySqlDataAdapter
    Private MySqlCmdBuilder As MySql.Data.MySqlClient.MySqlCommandBuilder
    Private resultDT As DataTable
    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()
        owner.WindowState = FormWindowState.Maximized
        owner.BringToFront()

        ' Add any initialization after the InitializeComponent() call.
        ' 新增性別
        Dim pt As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) ' 測量點
        pt.Add(0, "女")
        pt.Add(1, "男")
        Dim ptTable As DataTable = New DataTable()
        ptTable.Columns.Add("sexCode", GetType(Integer))
        ptTable.Columns.Add("性別", GetType(String))
        For Each point As KeyValuePair(Of Integer, String) In pt
            ptTable.Rows.Add(point.Key, point.Value)
        Next
        patientSex.DataSource = ptTable
        patientSex.DisplayMember = "性別"
        patientSex.ValueMember = "sexCode"
        'searchTable.ColumnStyles.Item(0).Width = owner.Width
        searchTable.ColumnStyles.Item(1).Width = 0

        Try
            MySqlCon = New MySql.Data.MySqlClient.MySqlConnection(getConnectionString())
            MySqlCon.Open()
            MySqlAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM patient ORDER BY pID DESC Limit 100;", MySqlCon)
            resultDT = New DataTable
            MySqlAdapter.Fill(resultDT)
            sqlGrid.DataSource = resultDT
            MySqlCon.Close()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "請確保網路連線是否正常?" & vbNewLine & "(" & ex.Message & ")", "資料庫連線失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs)
        Try
            MySqlCmdBuilder = New MySql.Data.MySqlClient.MySqlCommandBuilder(MySqlAdapter)
            MySqlAdapter.Update(resultDT)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "請確保網路連線是否正常?" & vbNewLine & "(" & ex.Message & ")", "更新資料庫失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
