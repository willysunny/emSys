Imports MySql.Data.MySqlClient
Module SQLModule
    Public Function getConnectionString() As String
        Return String.Format("Server=" & My.Settings.serverHost & ";Port=" & My.Settings.serverPort & ";User=" & My.Settings.serverUser & ";Password=" & My.Settings.serverPass & ";Database=" & My.Settings.serverDB & ";Pooling=false;CharSet=utf8;old guids=true")
    End Function


    Public Function getConnectionString(ByVal host As String, ByVal port As Integer, ByVal user As String, ByVal pass As String, ByVal db As String) As String
        Dim conString As String = String.Format("Server=" & host & ";Port=" & port & ";User=" & user & ";Password=" & pass & ";Database=" & db & ";Pooling=false;CharSet=utf8;old guids=true")
        Debug.WriteLine("Connect String = " & conString)
        Return conString
    End Function

    Public Function runQuery(ByVal query As String, Optional ByVal col As String = "") As IDataReader

        Dim oConn As MySqlConnection

        ' 與伺服器連線
        Try
            Dim sConnStr As String = getConnectionString()
            oConn = New MySqlConnection(sConnStr)
            oConn.Open()
            Debug.WriteLine("SQL = " & query)
            Dim cmd As MySqlCommand = New MySqlCommand(query, oConn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable
            dt.Load(reader)
            Debug.WriteLine("Data Count = " & dt.Rows.Count)
            oConn.Close()
            Return dt.CreateDataReader
        Catch ex As Exception
            MsgBox("伺服器連線錯誤!" & vbNewLine & "錯誤訊息:" & ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "錯誤發生")
        End Try
        Return Nothing
    End Function

    Public Function testConnection(ByVal sender As MetroFramework.Forms.MetroForm, ByVal host As String, ByVal port As Integer, ByVal user As String, ByVal pass As String, ByVal db As String) As Boolean
        Using con As New MySqlConnection(getConnectionString(host, port, user, pass, db))
            Try
                con.Open()
                con.Close()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(sender, ex.Message, "資料庫連線失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
        Return True
    End Function

    Public Function returnData(ByVal sender As MetroFramework.Forms.MetroForm, ByVal sql As String) As DataTable
        Debug.WriteLine("returnData('" & sql & "')")
        If testConnection(mainForm, My.Settings.serverHost, My.Settings.serverPort, My.Settings.serverUser, My.Settings.serverPass, My.Settings.serverDB) Then
            Try
                Dim result As New DataTable
                Using con As New MySqlConnection(getConnectionString())
                    Using adp As New MySqlDataAdapter(sql, con)
                        adp.Fill(result)
                    End Using
                End Using
                Return result
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(sender, ex.Message, "資料庫連線失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Return Nothing
        End If
    End Function

    Public Function MD5(ByVal input As String) As String
        Dim md5Service As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim Bytes() As Byte = md5Service.ComputeHash(System.Text.Encoding.ASCII.GetBytes(input))
        Dim s As String = ""
        For Each bt As Byte In Bytes
            s += bt.ToString("x2")
        Next
        Return s
    End Function
End Module
