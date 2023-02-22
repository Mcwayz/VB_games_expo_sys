<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpOptional = New System.Windows.Forms.GroupBox()
        Me.chkJam = New System.Windows.Forms.CheckBox()
        Me.chkPodcast = New System.Windows.Forms.CheckBox()
        Me.chkSkies = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTicket = New System.Windows.Forms.ComboBox()
        Me.cboAcess = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Choices = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.grpOptional.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.grpOptional)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 473)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'grpOptional
        '
        Me.grpOptional.Controls.Add(Me.chkJam)
        Me.grpOptional.Controls.Add(Me.chkPodcast)
        Me.grpOptional.Controls.Add(Me.chkSkies)
        Me.grpOptional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOptional.Location = New System.Drawing.Point(6, 252)
        Me.grpOptional.Name = "grpOptional"
        Me.grpOptional.Size = New System.Drawing.Size(298, 221)
        Me.grpOptional.TabIndex = 0
        Me.grpOptional.TabStop = False
        Me.grpOptional.Text = "Select One or More of the Following Events"
        '
        'chkJam
        '
        Me.chkJam.AutoSize = True
        Me.chkJam.Location = New System.Drawing.Point(10, 152)
        Me.chkJam.Name = "chkJam"
        Me.chkJam.Size = New System.Drawing.Size(229, 19)
        Me.chkJam.TabIndex = 2
        Me.chkJam.Text = "Two day Board Game Jam: $50 "
        Me.chkJam.UseVisualStyleBackColor = True
        '
        'chkPodcast
        '
        Me.chkPodcast.AutoSize = True
        Me.chkPodcast.Location = New System.Drawing.Point(12, 99)
        Me.chkPodcast.Name = "chkPodcast"
        Me.chkPodcast.Size = New System.Drawing.Size(183, 19)
        Me.chkPodcast.TabIndex = 1
        Me.chkPodcast.Text = "Room 101 Podcast: $15 "
        Me.chkPodcast.UseVisualStyleBackColor = True
        '
        'chkSkies
        '
        Me.chkSkies.AutoSize = True
        Me.chkSkies.Location = New System.Drawing.Point(10, 52)
        Me.chkSkies.Name = "chkSkies"
        Me.chkSkies.Size = New System.Drawing.Size(257, 19)
        Me.chkSkies.TabIndex = 0
        Me.chkSkies.Text = "Full day Watch the Skies Event: $30 "
        Me.chkSkies.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cboTicket)
        Me.GroupBox3.Controls.Add(Me.cboAcess)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 213)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select  Each of the Following "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Lunch :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Day of Ticket :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Access Type :"
        '
        'cboTicket
        '
        Me.cboTicket.FormattingEnabled = True
        Me.cboTicket.Items.AddRange(New Object() {"-Select-", "Saturday only", "Sunday only", "Weekend pass"})
        Me.cboTicket.Location = New System.Drawing.Point(135, 115)
        Me.cboTicket.Name = "cboTicket"
        Me.cboTicket.Size = New System.Drawing.Size(144, 23)
        Me.cboTicket.TabIndex = 4
        '
        'cboAcess
        '
        Me.cboAcess.FormattingEnabled = True
        Me.cboAcess.Items.AddRange(New Object() {"-Select-", "Board game Hall only", "Roleplaying Hall only", "All area pass"})
        Me.cboAcess.Location = New System.Drawing.Point(135, 61)
        Me.cboAcess.Name = "cboAcess"
        Me.cboAcess.Size = New System.Drawing.Size(144, 23)
        Me.cboAcess.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Choices)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Controls.Add(Me.btnReset)
        Me.GroupBox2.Location = New System.Drawing.Point(394, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 473)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Choices
        '
        Me.Choices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Choices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Choices.FormattingEnabled = True
        Me.Choices.ItemHeight = 16
        Me.Choices.Location = New System.Drawing.Point(6, 20)
        Me.Choices.Name = "Choices"
        Me.Choices.Size = New System.Drawing.Size(288, 276)
        Me.Choices.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(290, 538)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(140, 40)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(6, 382)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 41)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(203, 382)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 41)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(275, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Games Expo "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radNo)
        Me.GroupBox4.Controls.Add(Me.radYes)
        Me.GroupBox4.Location = New System.Drawing.Point(135, 159)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(157, 39)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Location = New System.Drawing.Point(101, 14)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(43, 19)
        Me.radNo.TabIndex = 12
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(6, 14)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(48, 19)
        Me.radYes.TabIndex = 11
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(710, 580)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpOptional.ResumeLayout(False)
        Me.grpOptional.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grpOptional As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Choices As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboTicket As ComboBox
    Friend WithEvents cboAcess As ComboBox
    Friend WithEvents chkPodcast As CheckBox
    Friend WithEvents chkSkies As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkJam As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
End Class
