Public Class pnlMedGroup
    Inherits pnlSlider

    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim mainGroup As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
        Dim subGroup As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
        mainGroup.Add(0, "女")
        mainGroup.Add(1, "男")
        Dim ptTable As DataTable = New DataTable()
        ptTable.Columns.Add("sexCode", GetType(Integer))
        ptTable.Columns.Add("性別", GetType(String))
        For Each point As KeyValuePair(Of Integer, String) In mainGroup
            ptTable.Rows.Add(point.Key, point.Value)
        Next
        medGroupItems.DataSource = ptTable
        medGroupItems.DisplayMember = "性別"
        medGroupItems.ValueMember = "sexCode"

    End Sub

End Class
