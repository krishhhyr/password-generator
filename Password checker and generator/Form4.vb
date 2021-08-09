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
            PasswordStrengthLabel.ForeColor = Color.Green
        End If
        If (FinalPoints > 0) And (FinalPoints < 20) Then
            PasswordStrengthLabel.Text = "Good"
            PasswordStrengthLabel.ForeColor = Color.Orange
        End If
        If FinalPoints <= 0 Then
            PasswordStrengthLabel.Text = "Weak"
            PasswordStrengthLabel.ForeColor = Color.Red
        End If

        '0 < FinalPoints < 20
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
        PasswordStrengthLabel.Text = ""
    End Sub
End Class