Public Class Form1

    'Function to Validate all fields in the form that need to be populated with data.
    Public Function ErrorCheck() As Boolean

        If cboAcess.Items.Contains(cboAcess.Text) = False Then
            cboAcess.Select()
            MessageBox.Show("Select Access Type for Your Event Pass", "Access Type ?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCheck = True
        ElseIf cboTicket.Items.Contains(cboTicket.Text) = False Then
            cboTicket.Select()
            MessageBox.Show("Select Day and Duration of Ticket", "Day and Duration of Ticket ?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCheck = True
        ElseIf radYes.Checked = False And radNo.Checked = False Then
            MessageBox.Show("Select Lunch, this is to know weather you will need lunch", "Lunch ?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorCheck = True
        ElseIf chkJam.Checked = False And chkSkies.Checked = False AndAlso chkPodcast.Checked = False Then
            MessageBox.Show("Select One or More Optional Products", "Optional Products", MessageBoxButtons.OK, MessageBoxIcon.Error)
            grpOptional.Focus()
        Else
            ErrorCheck = False
            frmSummary.Show()
            Me.Hide()
        End If

    End Function

    'Function that adds all the charges
    Public Function AddStuff() As Double
        Dim cost, total, ticket, jam, skie, pod As Double
        'saturday board game hall with lunch
        If cboTicket.SelectedIndex = 1 And cboAcess.SelectedIndex = 1 AndAlso radYes.Checked = True Then
            AddStuff = 25
            ticket = 25
        Else
            ticket = 0

        End If

        'saturday board game hall without lunch
        If cboTicket.SelectedIndex = 1 And cboAcess.SelectedIndex = 1 AndAlso radNo.Checked = True Then
            AddStuff = 20
            ticket = 25
        Else
            ticket = 0

        End If

        'Saturday Roleplaying hall with lunch
        If cboTicket.SelectedIndex = 1 And cboAcess.SelectedIndex = 2 AndAlso radYes.Checked = True Then
            AddStuff = 29
            ticket = 29


        End If
        'Saturday Roleplaying hall without lunch
        If cboTicket.SelectedIndex = 1 And cboAcess.SelectedIndex = 2 AndAlso radNo.Checked = True Then
            AddStuff = 24
            ticket = 24
        Else
            ticket = 0
        End If
        'Saturday All Areas Pass with lunch
        If cboTicket.SelectedIndex = 1 And cboAcess.SelectedIndex = 3 AndAlso radYes.Checked = True Then
            AddStuff = 37
            ticket = 37

        End If

        'Saturday All Areas Pass without lunch
        If cboTicket.SelectedIndex = 1 And cboAcess.SelectedIndex = 3 AndAlso radNo.Checked = True Then
                AddStuff = 32
                ticket = 32

            End If
            'NOTE: saturday tickets end here and sunday tickets begin below
            'Sunday Tickets Begin

            'Sunday Board game hall with lunch
            If cboTicket.SelectedIndex = 2 And cboAcess.SelectedIndex = 1 AndAlso radYes.Checked = True Then
                    AddStuff = 19
                    ticket = 19
            End If

            'Sunday Board game hall without lunch
            If cboTicket.SelectedIndex = 2 And cboAcess.SelectedIndex = 1 AndAlso radNo.Checked = True Then
                        AddStuff = 14
                        ticket = 14
            End If


        'Sunday Roleplaying hall with lunch
        If cboTicket.SelectedIndex = 2 And cboAcess.SelectedIndex = 2 AndAlso radYes.Checked = True Then
            AddStuff = 17
            ticket = 17
        End If

        'Sunday Roleplaying hall without lunch
        If cboTicket.SelectedIndex = 2 And cboAcess.SelectedIndex = 2 AndAlso radNo.Checked = True Then
            AddStuff = 12
            ticket = 12

        End If

        'Sunday All areas pass with lunch
        If cboTicket.SelectedIndex = 2 And cboAcess.SelectedIndex = 3 AndAlso radYes.Checked = True Then
            AddStuff = 32
            ticket = 32

        End If

        'Sunday All areas pass without lunch
        If cboTicket.SelectedIndex = 2 And cboAcess.SelectedIndex = 3 AndAlso radNo.Checked = True Then
            AddStuff = 27
            ticket = 27
        End If

        'NOTE: saturday tickets end here and Weekend Pass tickets begin below
        'Weekend Pass Tickets Begin
        'Weekend Pass Board game hall with lunch
        If cboTicket.SelectedIndex = 3 And cboAcess.SelectedIndex = 1 AndAlso radYes.Checked = True Then
            AddStuff = 40
            ticket = 40

        End If

        'Weekend Pass Board game hall without lunch
        If cboTicket.SelectedIndex = 3 And cboAcess.SelectedIndex = 1 AndAlso radNo.Checked = True Then
            AddStuff = 32
            ticket = 32
        End If

        'Weekend Pass Roleplaying hall with lunch
        If cboTicket.SelectedIndex = 3 And cboAcess.SelectedIndex = 2 AndAlso radYes.Checked = True Then
            ticket = 39
            AddStuff = 39

        End If

        'Weekend Pass Roleplaying hall without lunch
        If cboTicket.SelectedIndex = 3 And cboAcess.SelectedIndex = 2 AndAlso radNo.Checked = True Then
            AddStuff = 29
            ticket = 39
        End If

        'Weekend Pass All areas pass  with lunch
        If cboTicket.SelectedIndex = 3 And cboAcess.SelectedIndex = 2 AndAlso radYes.Checked = True Then
            cost = 0
            Dim pass As Double = 65

            AddStuff = 65
            ticket = 65
            total = (pass / 100) * 25
            cost = (ticket - total)
            MessageBox.Show("You have a 25% Discount", "25% Off", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Weekend Pass All areas pass  without lunch
        If cboTicket.SelectedIndex = 3 And cboAcess.SelectedIndex = 2 AndAlso radYes.Checked = True Then
            AddStuff = 55
            ticket = 55

        End If

        'Optional items prices 
        If chkJam.Checked = True Then
            jam = 50

        End If

        If chkSkies.Checked = True Then
            skie = 30

        End If

        If chkPodcast.Checked = True Then
            pod = 15

        End If
        'total price
        Dim Final As Double
        Final = (cost + jam + skie + pod + ticket)
        frmSummary.lblTotal.Text = Final.ToString()
    End Function

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'calling of the validation function to check the form before the user proceeds to the summary form.
        ErrorCheck()
        AddStuff()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closing the application
        Dim Result As DialogResult
        Result = MessageBox.Show("Are You Sure You Want to Leave?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    'adds selected item to the list box
    Private Sub CboAcess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAcess.SelectedIndexChanged
        If Not (cboAcess.SelectedItem = "-Select-") Then
            frmSummary.lblAccess.Text = cboAcess.SelectedItem
            Choices.Items.Add("Access Type:" + cboAcess.SelectedItem.ToString())
        Else
            Choices.Items.Clear()
        End If
    End Sub
    'Adds the selected items to the list box
    Private Sub CboTicket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTicket.SelectedIndexChanged
        If Not (cboTicket.SelectedItem = "-Select-") Then
            frmSummary.lblTicket.Text = cboTicket.SelectedItem
            Choices.Items.Add("Day and Duration of Ticket:" + cboTicket.SelectedItem.ToString())
        Else
            Choices.Items.Clear()
        End If
    End Sub

    'Adds the selected items to the list box
    Private Sub ChkSkies_CheckedChanged(sender As Object, e As EventArgs) Handles chkSkies.CheckedChanged
        If chkSkies.Checked = True Then
            Choices.Items.Add(chkSkies.Text)
            frmSummary.lblSkies.Text = 30
        Else
            Choices.Items.Remove(chkSkies.Text)
            frmSummary.lblSkies.Text = "None"
        End If
    End Sub
    'Adds the selected items to the list box
    Private Sub ChkPodcast_CheckedChanged(sender As Object, e As EventArgs) Handles chkPodcast.CheckedChanged
        If chkPodcast.Checked = True Then
            Choices.Items.Add(chkPodcast.Text)
            frmSummary.lblPod.Text = 15
        Else
            Choices.Items.Remove(chkPodcast.Text)
            frmSummary.lblPod.Text = "None"
        End If
    End Sub

    Private Sub ChkJam_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkJam.CheckedChanged
        If chkJam.Checked = True Then
            Choices.Items.Add(chkJam.Text)
            frmSummary.lblJam.Text = 50
        Else
            Choices.Items.Remove(chkJam.Text)
            frmSummary.lblJam.Text = "None"
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Choices.Items.Clear()
        'Checkboxes reset
        chkJam.Checked = False
        chkPodcast.Checked = False
        chkSkies.Checked = False
        'comboboxes reset
        cboAcess.SelectedIndex = 0
        cboTicket.SelectedIndex = 0
        'radio buttons reset
        radNo.Checked = False
        radYes.Checked = False

    End Sub

    'Adds the selected items to the list box
    Private Sub RadYes_CheckedChanged_1(sender As Object, e As EventArgs) Handles radYes.CheckedChanged
        If radYes.Checked = True Then
            Choices.Items.Add("Lunch:" + radYes.Text)
            frmSummary.lblLunch.Text = radYes.Text
        Else
            Choices.Items.Remove("Lunch:" + radYes.Text)
            frmSummary.lblLunch.Text = "None"
        End If
    End Sub

    Private Sub RadNo_CheckedChanged_1(sender As Object, e As EventArgs) Handles radNo.CheckedChanged
        'Adds the selected items to the list box
        If radNo.Checked = True Then
            Choices.Items.Add("Lunch:" + radNo.Text)
            frmSummary.lblLunch.Text = radNo.Text
        Else
            Choices.Items.Remove("Lunch:" + radNo.Text)
            frmSummary.lblLunch.Text = "None"
        End If
    End Sub
End Class
