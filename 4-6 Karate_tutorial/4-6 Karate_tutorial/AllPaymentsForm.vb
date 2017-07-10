Public Class AllPaymentsForm
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AllPaymentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet.Payments1' table. You can move, or remove it, as needed.
        Me.Payments1TableAdapter.AllPayments(Me.KarateDataSet.Payments1)

    End Sub
End Class