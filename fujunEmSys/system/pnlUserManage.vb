Public Class pnlUserManage
    Inherits pnlSlider
    Public Sub New(ByVal owner As Form)
        MyBase.New(owner)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dt As DataTable = returnData(mainForm, "SELECT uID as '編號', id as '使用者名稱', level as '權限等級' FROM user")
        userDataGrid.AutoGenerateColumns = True
        userDataGrid.DataSource = dt
        userDataGrid.Refresh()
    End Sub
End Class
