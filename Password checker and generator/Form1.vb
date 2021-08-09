Public Class Form1
    'Menu/Form1'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CreateOption.Click
        create.Show()
        Me.Hide()
    End Sub
    'This sub hides this form and showcases the "Creating a password" form using (Show()) and (Hide()) once the button is pressed.'

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles GenerateOption.Click
        Form3.Show()
        Me.Hide()
        'Generate form'
    End Sub
    'This sub also hides this form but showcases the "Generate a password" form using (Show()) and (Hide()).'

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles QuitOption.Click
        End
    End Sub
    'This sub ends the run of the program using "End".'

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles LinkPictureBox.Click
        Process.Start("https://www.instagram.com/krishna.r17/")
    End Sub
    'This sub is a picture box and once the box is pressed, the user is guided to an Instagram account.'
End Class