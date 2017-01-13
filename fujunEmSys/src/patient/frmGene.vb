Public Class frmGene
    Inherits MetroFramework.Forms.MetroForm

    Public Event geneSet As EventHandler
    Private pID As Integer

    Public Sub New(ByVal patientID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pID = patientID
        dumpGenes()
        checkGenes()
    End Sub
    ' 倒出所有基因缺陷
    Private Sub dumpGenes()
        Dim dt As DataTable = returnData(Me, "SELECT geneID, geneName FROM gene")
        For Each row As DataRow In dt.Rows
            Dim cb As New MetroFramework.Controls.MetroCheckBox
            cb.Name = "gene_" & row.Item("geneID")
            cb.Text = row.Item("geneName")
            cb.Tag = row.Item("geneID")
            'AddHandler cb.CheckStateChanged, AddressOf cb_CheckStateChanged
            geneFlow.Controls.Add(cb)
        Next
    End Sub
    ' 檢查已存在基因缺陷
    Private Sub checkGenes()
        Dim dt As DataTable = returnData(Me, "SELECT pID, geneID FROM patient_gene WHERE pID=" & pID)
        For Each row As DataRow In dt.Rows
            directcast(geneFlow.Controls("gene_" & row.Item("geneID")), MetroFramework.Controls.MetroCheckBox).Checked = True
        Next
    End Sub

    Private Sub cb_checkStateChanged(ByVal sender As Object, ByVal e As EventArgs)
        Debug.WriteLine(sender.Tag)
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        runQuery("DELETE FROM patient_gene WHERE pID=" & pID)
        For Each cb As MetroFramework.Controls.MetroCheckBox In geneFlow.Controls
            If cb.Checked Then runQuery("INSERT INTO patient_gene VALUES (" & pID & "," & cb.Tag.ToString & ")")
        Next
        RaiseEvent geneSet(Me, New EventArgs)
        Me.Close()
    End Sub
End Class