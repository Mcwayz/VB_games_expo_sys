Public Class frmCustomer
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Checks if all Textboxes are Filled
        If txtCredit.Text = "" Then
            MessageBox.Show("Enter Credit Card ", "Credit Card", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtCVS.Text = "" Then
            MessageBox.Show("Enter CVS", "CVS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf txtHouse.Text = "" Then
            MessageBox.Show("Enter House Number", "House Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPost.Text = "" Then
            MessageBox.Show("Enter Post ", "Post", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtStreet.Text = "" Then
            MessageBox.Show("Enter Street ", "Street", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtTown.Text = "" Then
            MessageBox.Show("Enter Town ", "Town", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Thank You For Your Custom ", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'clears all controls and sets them to default values
            Me.Hide()
            Form1.Show()
            '################Reset Code##################
            '____________________________________________

            'Resetting previous controls on the main form
            '____________________________________________
            '################Reset Code##################
            Form1.Choices.Items.Clear()
            'Checkboxes reset
            Form1.chkJam.Checked = False
            Form1.chkPodcast.Checked = False
            Form1.chkSkies.Checked = False
            'comboboxes reset
            Form1.cboAcess.SelectedIndex = 0
            Form1.cboTicket.SelectedIndex = 0
            'radio buttons reset
            Form1.radNo.Checked = False
            Form1.radYes.Checked = False
        End If
    End Sub

    Private Sub TxtCredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCredit.KeyPress
        If txtCredit.Text.Length > 16 Then
            MessageBox.Show("Wrong Credit Card Number, Note that the Limit is 16 digits", "Wrong Credit Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCredit.Text = ""
        End If
        If IsNumeric(txtCredit.Text) Then
        Else
            MessageBox.Show("Wrong Credit Card Number, Numbers Only", "Wrong Credit Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCredit.Text = ""

        End If
    End Sub

    Private Sub TxtCVS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCVS.KeyPress
        If txtCVS.Text.Length > 16 Then
            MessageBox.Show("Wrong CVS Number, Note that the Limit is 3 digits", "Wrong CVS Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCVS.Text = ""
        End If
        If IsNumeric(txtCVS.Text) Then
        Else
            MessageBox.Show("Wrong CVS, Numbers Only", "Wrong Credit Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCVS.Text = ""

        End If
    End Sub
End Class