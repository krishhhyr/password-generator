

Imports System.Text.RegularExpressions
Public Class create

    'Creating a password Form'

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Enter.Click
        'When the "Enter" button is clicked...

        If TypingPassword.Text = ConfirmingPassword.Text And TypingPassword.Text.Length >= 8 And ConfirmingPassword.Text.Length >= 8 And TypingPassword.Text.Length < 24 And ConfirmingPassword.Text.Length < 24 Then
            'if the passwords are greater than 8 and less than 24 and match...
            Match.Show()
            ContinueButton.Show()
            IncorrectMatch.Hide()
            EightCharErrorLabel.Hide()
            TwentyFourCharErrorLabel.Hide()
            InvalidCharLabel.Hide()
            CharNoticeError.Hide()
            InvalidPwdLabel.Hide()

        End If
        If TypingPassword.Text = ConfirmingPassword.Text And Not (TypingPassword.Text.Length >= 8 And ConfirmingPassword.Text.Length >= 8) Then
            'If the passwords match but the lengths of the passwords are below 8 then...
            Match.Hide()
            ContinueButton.Hide()
            EightCharErrorLabel.Show()
            TwentyFourCharErrorLabel.Hide()
            InvalidCharLabel.Hide()
            CharNoticeError.Hide()
            InvalidPwdLabel.Hide()
        End If
        If Not TypingPassword.Text = ConfirmingPassword.Text And (TypingPassword.Text.Length >= 8 And ConfirmingPassword.Text.Length >= 8) And (TypingPassword.Text.Length < 24 And ConfirmingPassword.Text.Length < 24) Then
            'If the passwords don't match but the passwords are greater than 8 characters and less than 24 characters then...
            Match.Hide()
            IncorrectMatch.Show()
            ContinueButton.Hide()
            EightCharErrorLabel.Hide()
            TwentyFourCharErrorLabel.Hide()
            InvalidCharLabel.Hide()
            CharNoticeError.Hide()
            InvalidPwdLabel.Hide()
        End If
        If TypingPassword.Text = ConfirmingPassword.Text And (TypingPassword.Text.Length >= 8 And ConfirmingPassword.Text.Length >= 8) And (TypingPassword.Text.Length > 24 And ConfirmingPassword.Text.Length > 24) Then
            'If the passwords don't match and the passwords are greater than 8 characters but the passwords is greater than 24 characters then...
            Match.Hide()
            IncorrectMatch.Hide()
            ContinueButton.Hide()
            EightCharErrorLabel.Hide()
            TwentyFourCharErrorLabel.Show()
            InvalidPwdLabel.Hide()
        End If
        If Not TypingPassword.Text = ConfirmingPassword.Text And Not (TypingPassword.Text.Length >= 8 And ConfirmingPassword.Text.Length >= 8) Then
            'If the passwords dont match and the passwords length is less than 8 characters then...
            Match.Hide()
            ContinueButton.Hide()
            EightCharErrorLabel.Show()
            TwentyFourCharErrorLabel.Hide()
            InvalidCharLabel.Hide()
            CharNoticeError.Hide()
            InvalidPwdLabel.Hide()
        End If
        If Not TypingPassword.Text = ConfirmingPassword.Text And (TypingPassword.Text.Length > 24 And ConfirmingPassword.Text.Length > 24) Then
            'If the passwords don't match and the passwords have a character length greater than 24 then...
            Match.Hide()
            IncorrectMatch.Hide()
            ContinueButton.Hide()
            EightCharErrorLabel.Hide()
            TwentyFourCharErrorLabel.Show()
            InvalidCharLabel.Hide()
            CharNoticeError.Hide()
            InvalidPwdLabel.Hide()
        End If
        If TypingPassword.Text = ConfirmingPassword.Text And (TypingPassword.Text.Length > 24 And ConfirmingPassword.Text.Length > 24) Then
            'If the passwords match but the passwords have a character length of over 24 then...
            Match.Hide()
            IncorrectMatch.Hide()
            ContinueButton.Hide()
            EightCharErrorLabel.Hide()
            TwentyFourCharErrorLabel.Show()
            InvalidCharLabel.Hide()
            CharNoticeError.Hide()
            InvalidPwdLabel.Hide()
        End If

        'Overall Analysis (Lines 9 - 75): For this, this section is dependent on If statements and reveals buttons and labels when certain conditions are met
        '(Eg, password length greater than 8 characters). The large amount of IF statements is due to the many options the user can input as a password.
        'Essentially, if a condition in an IF statement is met, some labels/buttons will show and other will hide. 

        'Start of Regex Section'
        Dim MatchNumberPattern As String = "^.*(?=.*[a-z])(?=.*[A-Z]).*$"
        If TypingPassword.Text.Trim <> "" Or ConfirmingPassword.Text.Trim <> "" Then
            If Not Regex.IsMatch(TypingPassword.Text, MatchNumberPattern) Or Regex.IsMatch(ConfirmingPassword.Text, MatchNumberPattern) Then
            Else
                CharNoticeError.Hide()
                InvalidCharLabel.Hide()
            End If
        End If
        'allowed special characters in the passwords
        Dim MatchNumberPatternForSpecialChar As String = "^.*(?=.*[!$%^&*()-_=+]).*$"
        If (TypingPassword.Text.Trim <> "") Or (ConfirmingPassword.Text.Trim <> "") Then
            If Regex.IsMatch(TypingPassword.Text, MatchNumberPatternForSpecialChar) Or Regex.IsMatch(ConfirmingPassword.Text, MatchNumberPatternForSpecialChar) Then
                'If the characters which are allowed are written then...

                '(Do nothing)
            End If
        End If
        'Not allowed special characters in the passwords
        Dim MatchNumberSpecialChar As String = ".*[.*{}`¬#@~';: ><. ,?].*$"
        If TypingPassword.Text.Trim <> "" Or ConfirmingPassword.Text.Trim <> "" Then
            If Regex.IsMatch(TypingPassword.Text, MatchNumberSpecialChar) Or Regex.IsMatch(ConfirmingPassword.Text, MatchNumberSpecialChar) Then
                CharNoticeError.Show()
                InvalidCharLabel.Show()

                IncorrectMatch.Hide()
                ContinueButton.Hide()
                EightCharErrorLabel.Hide()
                TwentyFourCharErrorLabel.Hide()
                InvalidPwdLabel.Hide()
            End If
        End If
        'End of Regex Section'

        'What I did was that if the allowed special characters were typed out, an error message (CharNoticeError) would not be shown.
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles EyeWithNoTickPic.Click
        If TypingPassword.UseSystemPasswordChar = True Then
            EyeWithNoTickPic.Hide()
            EyeWithTick1.Show()
            TypingPassword.UseSystemPasswordChar = False
            EyeWithNoTickPic.Show()
            EyeWithTick1.Hide()
        Else
            TypingPassword.UseSystemPasswordChar = True
            EyeWithNoTickPic.Hide()
            EyeWithTick1.Show()
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles EyeWithTick1.Click
        If TypingPassword.UseSystemPasswordChar = True Then
            EyeWithNoTickPic.Hide()
            EyeWithTick1.Show()
            TypingPassword.UseSystemPasswordChar = False
            EyeWithNoTickPic.Show()
            EyeWithTick1.Hide()
        Else
            TypingPassword.UseSystemPasswordChar = True
            EyeWithNoTickPic.Hide()
            EyeWithTick1.Show()
        End If
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles EyeWithNoTick2.Click
        If ConfirmingPassword.UseSystemPasswordChar = True Then
            EyeWithNoTick2.Hide()
            EyeWithTick2.Show()
            ConfirmingPassword.UseSystemPasswordChar = False
            EyeWithNoTick2.Show()
            EyeWithTick2.Hide()
        Else
            ConfirmingPassword.UseSystemPasswordChar = True
            EyeWithNoTick2.Hide()
            EyeWithTick2.Show()
        End If
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles EyeWithTick2.Click
        If ConfirmingPassword.UseSystemPasswordChar = True Then
            EyeWithNoTick2.Hide()
            EyeWithTick2.Show()
            ConfirmingPassword.UseSystemPasswordChar = False
            EyeWithNoTick2.Show()
            EyeWithTick2.Hide()
        Else
            ConfirmingPassword.UseSystemPasswordChar = True
            EyeWithNoTick2.Hide()
            EyeWithTick2.Show()
        End If
    End Sub

    'From lines 21 - 76, these help with hiding the password in asterisks and showcasing them using boolean values. Passwords are
    'usually hidden when creating passwords so I tried to mimic that. Furthermore, the use of (Show()) and (Hide()) are for the picture
    'boxes in which the icon with the eye and line across will only be revealed when the textboxes are using "UseSystemPasswordChar" and
    'this picturebox will hide and the other picturebox (A PNG of an eye to reveal the password which is in asterisks) when "UseSystemPass
    'wordChar" is false.'
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Form1.Show()
        IncorrectMatch.Hide()
        InvalidPwdLabel.Hide()
        Match.Hide()
        EightCharErrorLabel.Hide()
        TwentyFourCharErrorLabel.Hide()
        InvalidCharLabel.Hide()
        CharNoticeError.Hide()
        TypingPassword.Text = ""
        ConfirmingPassword.Text = ""
        Me.Hide()
    End Sub
    'This sub is for the "Back" button which refreshes any text in the textboxes and hides any messages (Like
    '"passwords match" eg.). It also hides the entire form and goes to back to the startup form (Form1/Menu)
    Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click
        'Start of Reset form section'
        Form4.Show()
        IncorrectMatch.Hide()
        Match.Hide()
        InvalidPwdLabel.Hide()
        EightCharErrorLabel.Hide()
        TwentyFourCharErrorLabel.Hide()
        InvalidCharLabel.Hide()
        CharNoticeError.Hide()
        TwentyFourCharErrorLabel.Hide()
        TypingPassword.UseSystemPasswordChar = False
        Me.Hide()
        'End of Reset Form section' 


        If Not TypingPassword.Text = ConfirmingPassword.Text Then
            Form4.Hide()
            Me.Show()
            InvalidPwdLabel.Show()
        End If

        'Making sure if the continue button appears that the passwords must match before continuing onto
        'the next form

        'Start of Points (adding points) section

        PwdLengthpoints = TypingPassword.Text.Length
        'The points based on password length

        Dim MatchNumberPatternForUpperCase As String = "^.*(?=.*[A-Z]).*$"
        'If the password has atleast one uppercase letter then...
        If TypingPassword.Text.Trim <> "" Or ConfirmingPassword.Text.Trim <> "" Then
            If Regex.IsMatch(TypingPassword.Text, MatchNumberPatternForUpperCase) Or Regex.IsMatch(ConfirmingPassword.Text, MatchNumberPatternForUpperCase) Then
                UppercasePoints = 5
            End If
        End If

        Dim MatchNumberPatternForLowercase As String = "^.*(?=.*[a-z]).*$"
        'If the password has atleast one lowercase letter then...
        If TypingPassword.Text.Trim <> "" Or ConfirmingPassword.Text.Trim <> "" Then
            If Regex.IsMatch(TypingPassword.Text, MatchNumberPatternForLowercase) Or Regex.IsMatch(ConfirmingPassword.Text, MatchNumberPatternForLowercase) Then
                LowercasePoints = 5
            End If
        End If

        Dim MatchNumberPatternForDigits As String = ".*[0-9].*"
        'If the password has atleast one digit then...
        If TypingPassword.Text.Trim <> "" Or ConfirmingPassword.Text.Trim <> "" Then
            If Regex.IsMatch(TypingPassword.Text, MatchNumberPatternForDigits) Or Regex.IsMatch(ConfirmingPassword.Text, MatchNumberPatternForDigits) Then
                DigitPoints = 5
            End If
        End If

        Dim MatchNumberPatternForSpecialChars As String = ".*[!$%^&*()-_=+].*"
        'If the password doesn't have a special character then...
        If (TypingPassword.Text.Trim <> "") Or (ConfirmingPassword.Text.Trim <> "") Then
            If Not Regex.IsMatch(TypingPassword.Text, MatchNumberPatternForSpecialChars) Or Not Regex.IsMatch(ConfirmingPassword.Text, MatchNumberPatternForSpecialChars) Then
                SpecialCharPoints = 0
            Else
                SpecialCharPoints = 5
            End If
        End If
        'End of adding points section

        'Start of Subtracting points system'
        Dim MatchNumberPatternForRemUpperCase As String = "^[A-Z]+$"
        Dim MatchNumberPatternForRemLowercase As String = "^[a-z]+$"
        'If the password has ONLY uppercase and lowercase letters then...
        If TypingPassword.Text.Trim <> "" Or ConfirmingPassword.Text.Trim <> "" Then
            If Regex.IsMatch(TypingPassword.Text, MatchNumberPatternForRemUpperCase) Or Regex.IsMatch(ConfirmingPassword.Text, MatchNumberPatternForRemUpperCase) Or Regex.IsMatch(TypingPassword.Text, MatchNumberPatternForRemLowercase) Or Regex.IsMatch(ConfirmingPassword.Text, MatchNumberPatternForRemLowercase) Then
                OnlyUpperCaseAndLowerCase = 5
            Else
                OnlyUpperCaseAndLowerCase = 0
            End If
        End If

        Dim MatchNumberPatternForRemDigits As String = "^[0-9]+$"
        'If the password has ONLY digits then...
        If TypingPassword.Text.Trim <> "" Or ConfirmingPassword.Text.Trim <> "" Then
            If Not Regex.IsMatch(TypingPassword.Text, MatchNumberPatternForRemDigits) Or Not Regex.IsMatch(ConfirmingPassword.Text, MatchNumberPatternForRemDigits) Then
                OnlyDigits = 0
            Else
                OnlyDigits = 5
            End If
        End If

        Dim MatchNumberPatternForRemSpecialChar As String = "^[!$%^&*()-_=+]+$"
        'If the password has ONLY these special characters then...
        If TypingPassword.Text.Trim <> "" Or ConfirmingPassword.Text.Trim <> "" Then
            If Not Regex.IsMatch(TypingPassword.Text, MatchNumberPatternForRemSpecialChar) Or Not Regex.IsMatch(ConfirmingPassword.Text, MatchNumberPatternForRemSpecialChar) Then
                OnlySpecialChar = 0
            Else
                OnlySpecialChar = 5
            End If
        End If








        '".*[A-Z]+.*$"


        '"^[0-9]*$"

        '".*^([0-9]*).*$"


        ' [A-Z]+
        FinalPoints = (LowercasePoints + UppercasePoints + DigitPoints + SpecialCharPoints + PwdLengthpoints) - OnlyUpperCaseAndLowerCase - OnlyDigits - OnlySpecialChar

        MsgBox(FinalPoints)
        MsgBox(PwdLengthpoints)

    End Sub
    'This Sub operates() the "Continue" button which resets elements In this form Like the textboxes Or buttons And Then hides the entire 
    'form and reveals form4
    Private Sub create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InvalidPwdLabel.Hide()
        ContinueButton.Hide()
        Match.Hide()
        IncorrectMatch.Hide()
        InvalidCharLabel.Hide()
        CharNoticeError.Hide()
        TwentyFourCharErrorLabel.Hide()
        TypingPassword.Text = ""
        ConfirmingPassword.Text = ""
        TypingPassword.UseSystemPasswordChar = False
    End Sub
    'This sub controls the featues as soon as the "create" form loads. It resets any used textboes and hides all the message labels. 
End Class


