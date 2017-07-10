Public Class AddMemberForm

    Private Sub AddMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateDataSet.Members)
        MembersBindingSource.AddNew()
        dtpDate.Value = Today

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddMemberForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MembersBindingSource.CancelEdit()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            MembersBindingSource.EndEdit()
            MembersTableAdapter.Update(KarateDataSet.Members)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class