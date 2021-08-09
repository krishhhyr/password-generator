Public Class Form5
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Form1.Show()
        Me.Hide()
    End Sub
    'This sub is to operate the "Home" button which hides this form (me.hide()) and showcases
    'the startup form which is Form1 (the menu)'
End Class