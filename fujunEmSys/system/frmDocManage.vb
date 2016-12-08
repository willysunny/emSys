Public Class frmDocManage
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        docManageTable.ColumnStyles.Item(3).Width = 0
        ' Add any initialization after the InitializeComponent() call.
        refreshData()
    End Sub
    ' 刷新資料
    Private Sub refreshData()
        Dim dt As DataTable = returnData(mainForm, "SELECT docID as '編號', docName as '醫師姓名', docLicence as '醫師證照號' FROM doctor")
        docDataGrid.AutoGenerateColumns = True
        docDataGrid.DataSource = dt
        docDataGrid.Refresh()
        docManageTable.ColumnStyles.Item(3).Width = 0
        docDataGrid.Enabled = True
        addDocButton.Enabled = True
        editDocButton.Enabled = True
        delDocButton.Enabled = True
        RemoveHandler okLink.Click, AddressOf adddocLink_OkClick
        RemoveHandler okLink.Click, AddressOf editdocLink_OkClick
    End Sub
    ' 新增使用者
    Private Sub adddocButton_Click(sender As Object, e As EventArgs) Handles addDocButton.Click
        docManageTable.ColumnStyles.Item(3).Width = 200
        docDataGrid.Enabled = False
        AddHandler okLink.Click, AddressOf adddocLink_OkClick
        docLabel.Text = "新增醫師"
        docName.Text = ""
        docLicence.Text = ""
        addDocButton.Enabled = False
        editDocButton.Enabled = False
        delDocButton.Enabled = False
    End Sub
    Private Sub adddocLink_OkClick(ByVal sender As Object, e As EventArgs)
        If docLicence.Text.Trim = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "醫師證照號碼欄位不得為空。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            docLicence.Focus()
        Else
            Try
                runQuery("INSERT INTO doctor (docName, docLicence) VALUES ('" & docName.Text & "', '" & docLicence.Text & "');")
                MetroFramework.MetroMessageBox.Show(Me, docName.Text & "醫師已新增。", "成功!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RemoveHandler okLink.Click, AddressOf adddocLink_OkClick
                refreshData()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "新增失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
                docLicence.Focus()
            End Try
        End If
    End Sub
    ' 修改使用者
    Private Sub editdocButton_Click(sender As Object, e As EventArgs) Handles editDocButton.Click
        If docDataGrid.SelectedRows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "請先選取要修改的醫師。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf docLicence.Text.Trim = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "醫師證照號碼欄位不得為空。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            docLicence.Focus()
        Else
            docManageTable.ColumnStyles.Item(3).Width = 200
            docDataGrid.Enabled = False
            AddHandler okLink.Click, AddressOf editdocLink_OkClick
            docLabel.Text = "修改醫師"
            docName.Text = docDataGrid.Rows(docDataGrid.SelectedRows.Item(0).Index).Cells("醫師姓名").Value
            docLicence.Text = docDataGrid.Rows(docDataGrid.SelectedRows.Item(0).Index).Cells("醫師證照號").Value
        End If
        addDocButton.Enabled = False
        editDocButton.Enabled = False
        delDocButton.Enabled = False
    End Sub
    Private Sub editdocLink_OkClick(ByVal sender As Object, e As EventArgs)
        If docLicence.Text.Trim = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "醫師證照號碼欄位不得為空。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            docLicence.Focus()
        Else
            Try
                runQuery("UPDATE doc SET docName='" & docName.Text & "', docLicence='" & docLicence.Text & "' WHERE docID='" & docDataGrid.Rows(docDataGrid.SelectedRows.Item(0).Index).Cells("編號").Value & "';")
                MetroFramework.MetroMessageBox.Show(Me, docName.Text & "醫師已修改。", "成功!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RemoveHandler okLink.Click, AddressOf editdocLink_OkClick
                refreshData()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "修改失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
                docLicence.Focus()
            End Try
        End If
    End Sub
    ' 刪除醫師
    Private Sub deldocButton_Click(sender As Object, e As EventArgs) Handles delDocButton.Click
        If docDataGrid.SelectedRows.Count = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "請先選取要刪除的醫師。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MetroFramework.MetroMessageBox.Show(Me, "確認刪除" & docDataGrid.Rows(docDataGrid.SelectedRows.Item(0).Index).Cells("使用者名稱").Value & "醫師?", "注意!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                runQuery("DELETE FROM doctor WHERE docID='" & docDataGrid.Rows(docDataGrid.SelectedRows.Item(0).Index).Cells("編號").Value & "' LIMIT 1;")
                MetroFramework.MetroMessageBox.Show(Me, docName.Text & "醫師已刪除。", "成功!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshData()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, "錯誤訊息:" & vbNewLine & ex.Message, "刪除失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
                refreshData()
            End Try
        End If
    End Sub

    Private Sub cancelLink_Click(sender As Object, e As EventArgs) Handles cancelLink.Click
        refreshData()
    End Sub

    Private Sub exitLink_Click(sender As Object, e As EventArgs) Handles exitLink.Click
        Me.Close()
    End Sub
End Class