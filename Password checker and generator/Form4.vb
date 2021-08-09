Public Class Form4
    'How many points awarded form'

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton2.Click
        Form1.Show()
        Me.Hide()
        PasswordStrengthLabel.Text = ""
    End Sub
    'This is a back button which allows users to retry the program by allowing them to return to the
    'menu again to input another password or to generate another one. The button, once pressed,
    'hides the "Points" form and reveals the startup form (Form1/Menu) again.'

    Private Sub ContinueButton2_Click(sender As Object, e As EventArgs) Handles ShowStrengthButton.Click
        If FinalPoints >= 20 Then
            PasswordStrengthLabel.Text = "Strong"
            PasswordStrengthLabel.ForeColor = Color.LightGreen
            PasswordStrengthLabel.BackColor = Color.Black
            PictureBox8.BackColor = Color.YellowGreen
            PictureBox9.BackColor = Color.YellowGreen
            PictureBox10.BackColor = Color.LimeGreen
            PictureBox11.BackColor = Color.Lime
        End If
        If (FinalPoints > 0) And (FinalPoints < 20) Then
            PasswordStrengthLabel.Text = "Good"
            PasswordStrengthLabel.ForeColor = Color.Orange
            PasswordStrengthLabel.BackColor = Color.Black
            PictureBox8.BackColor = Color.Black
            PictureBox9.BackColor = Color.Black
            PictureBox10.BackColor = Color.Black
            PictureBox11.BackColor = Color.Black


        End If
        If FinalPoints <= 0 Then
            PasswordStrengthLabel.Text = "Weak"
            PasswordStrengthLabel.ForeColor = Color.Red
            PasswordStrengthLabel.BackColor = Color.Black
        End If

        '0 < FinalPoints < 20
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
        PasswordStrengthLabel.Text = ""
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class