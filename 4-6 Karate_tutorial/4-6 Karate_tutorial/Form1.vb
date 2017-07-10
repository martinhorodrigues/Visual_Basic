Public Class MainForm
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub menListAll_Click(sender As Object, e As EventArgs) Handles menListAll.Click
        AllMembersForm.ShowDialog()
    End Sub

    Private Sub AddNewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewMemberToolStripMenuItem.Click
        AddMemberForm.ShowDialog()
    End Sub

    Private Sub FindMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindMemberToolStripMenuItem.Click
        FindMemberForm.ShowDialog()
    End Sub

    Private Sub AllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllToolStripMenuItem.Click
        AllPaymentsForm.ShowDialog()
    End Sub

    Private Sub OneMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OneMemberToolStripMenuItem.Click
        MemberPaymentsForm.ShowDialog()
    End Sub
End Class
