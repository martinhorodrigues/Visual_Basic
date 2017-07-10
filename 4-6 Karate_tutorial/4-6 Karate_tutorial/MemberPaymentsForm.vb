Public Class MemberPaymentsForm
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MemberPaymentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Payments' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'KarateDataSet.MemberNames' table. You can move, or remove it, as needed.
        Me.MemberNamesTableAdapter.Fill(Me.KarateDataSet.MemberNames)
        cboMemberName.SelectedIndex = -1

    End Sub

    Private Sub cboMemberName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMemberName.SelectedIndexChanged
        If cboMemberName.SelectedIndex = -1 Then Exit Sub

        Dim member_ID As Short = CShort(cboMemberName.SelectedValue)
        PaymentsTableAdapter.MemberPayments(KarateDataSet.Payments, member_ID)
    End Sub
End Class