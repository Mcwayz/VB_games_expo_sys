Public Class frmSummary
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Closes the Summary form and Shows the Main Form (Form1)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmCustomer.Show()
        Me.Hide()
    End Sub
End Class