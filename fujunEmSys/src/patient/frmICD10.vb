Public Class frmICD10

    Public Event ICDSet As EventHandler
    Private bID As Integer
    Private setMain As Boolean = False

    Public Sub New(ByVal bookingID As Integer, Optional mainSet As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bID = bookingID
        setMain = mainSet
        If setMain Then Me.Text = "主病名設定" Else Me.Text = "副病名設定"
        dumpICD()
        listICD()
    End Sub
    ' 倒出所有病名
    Private Sub dumpICD(Optional searchString As String = "")
        Dim sql As String = "SELECT ICD10_NO, ICD10_CNAME, ICD10_ENAME FROM ICD10"
        If Not searchString = "" Then
            sql += " WHERE ICD10_NO LIKE '%" & searchString & "%' OR ICD10_CNAME LIKE '%" & searchString & "%' OR ICD10_ENAME LIKE '%" & searchString & "%'"
        End If
        ICDGrid.DataSource = returnData(Me, sql & " LIMIT 500")
    End Sub
    ' 檢查已存在病名
    Private Sub listICD()
        Dim dt As DataTable
        If setMain Then
            dt = returnData(Me, "SELECT bi.bID, bi.ICD10, group_concat('(',bi.ICD10,')',i.ICD10_CNAME) AS 'ICD10_Disp' 
                                 FROM booking_ICD10 AS bi
                                 INNER JOIN ICD10 AS i
                                 ON bi.ICD10 = i.ICD10_NO
                                 WHERE bi.bID=" & bID & " AND bi.isMain=true
                                 GROUP BY bi.ICD10")
        Else
            dt = returnData(Me, "SELECT bID, ICD10, group_concat('(',ICD10,')',ICD10_CNAME) AS 'ICD10_Disp' 
                                 FROM booking_ICD10 AS bi
                                 INNER JOIN ICD10 AS i
                                 ON bi.ICD10 = i.ICD10_NO
                                 WHERE bID=" & bID & " AND bi.isMain=false
                                 GROUP BY bi.ICD10")
        End If
        With ICDList
            .DataSource = dt
            .DisplayMember = "ICD10_Disp"
            .ValueMember = "ICD10"
        End With
    End Sub
    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        dumpICD(searchBox.Text.Trim)
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        RaiseEvent ICDSet(sender, New EventArgs)
        Me.Close()
    End Sub

#Region "新增"
    Private Sub ICDGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ICDGrid.CellDoubleClick
        If setMain Then
            If ICDList.Items.Count > 0 Then
                runQuery("UPDATE booking_ICD10 SET ICD10='" & ICDGrid.Rows(e.RowIndex).Cells("ICD10_NO").Value & "' WHERE bID=" & bID & " AND isMain=true")
            Else
                runQuery("INSERT INTO booking_ICD10 VALUES (" & bID & ", '" & ICDGrid.Rows(e.RowIndex).Cells("ICD10_NO").Value & "', true)")
            End If
        Else
            For Each row As DataRowView In ICDList.Items
                If row.Item(1) = ICDGrid.SelectedRows().Item(0).Cells("ICD10_NO").Value Then Exit Sub
            Next
            runQuery("INSERT INTO booking_ICD10 VALUES (" & bID & ", '" & ICDGrid.SelectedRows().Item(0).Cells("ICD10_NO").Value & "', false)")
        End If
        listICD()
    End Sub
    Private Sub ICDGrid_Keydown(sender As Object, e As KeyEventArgs) Handles ICDGrid.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Then
            If setMain Then
                If ICDList.Items.Count > 0 Then
                    runQuery("UPDATE booking_ICD10 SET ICD10='" & ICDGrid.SelectedRows().Item(0).Cells("ICD10_NO").Value & "' WHERE bID=" & bID & " AND isMain=true")
                Else
                    runQuery("INSERT INTO booking_ICD10 VALUES (" & bID & ", '" & ICDGrid.SelectedRows().Item(0).Cells("ICD10_NO").Value & "', true)")
                End If
            Else
                For Each row As DataRowView In ICDList.Items
                    If row.Item(1) = ICDGrid.SelectedRows().Item(0).Cells("ICD10_NO").Value Then Exit Sub
                Next
                runQuery("INSERT INTO booking_ICD10 VALUES (" & bID & ", '" & ICDGrid.SelectedRows().Item(0).Cells("ICD10_NO").Value & "', false)")
            End If
            listICD()
        End If
    End Sub
#End Region

#Region "刪除"
    Private Sub delButton_Click(sender As Object, e As EventArgs) Handles delButton.Click
        If setMain Then
            runQuery("DELETE FROM booking_ICD10 WHERE bID=" & bID)
        Else
            runQuery("DELETE FROM booking_ICD10 WHERE bID=" & bID & " AND ICD10='" & ICDList.SelectedValue & "'")
        End If
        listICD()
    End Sub
    Private Sub delAllButton_Click(sender As Object, e As EventArgs) Handles delAllButton.Click
        If setMain Then
            runQuery("DELETE FROM booking_ICD10 WHERE bID=" & bID)
        Else
            runQuery("DELETE FROM booking_ICD10 WHERE bID=" & bID & " AND isMain=false")
        End If
        listICD()
    End Sub
#End Region

End Class