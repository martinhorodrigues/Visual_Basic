Public Class FindMemberForm
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FindMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Me.MembersTableAdapter.FindMember(KarateDataSet.Members, txtLastName.Text)
    End Sub
End Class