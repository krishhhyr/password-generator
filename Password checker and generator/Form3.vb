Imports System.Text.RegularExpressions
Public Class Form3
    Const characterlist = "ABCDEFGHIJKLMNOPQRSTyvwxyzabcdefghijklmnopqrstyvwxyz123456789!$%^&*()-_=+"
    Dim Password As String = ""
    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        'Start of randomising the password length between 8 and 12
        Dim rn As New Random
        Dim pwdlength As Integer
        pwdlength = (rn.Next(8, 12))
        'End of password length section


        'Start of generating section 
        Dim r, i
        Password = ""

        For i = 1 To pwdlength
            Randomize()
            r = Int((Rnd() * 73) + 1)
            Password = Password & Mid(characterlist, r, 1)
        Next i
        GeneratingPassword.Text = Password
        'End of generating section

        ContinueButton3.Show()
        'Showing the continue button
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ContinueButton3.Hide()
    End Sub

    Private Sub BackButton3_Click(sender As Object, e As EventArgs) Handles BackButton3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ContinueButton3_Click(sender As Object, e As EventArgs) Handles ContinueButton3.Click
        Form4.Show()
        Me.Hide()

        'Points Section for Generating a password

        PwdLengthpoints = GeneratingPassword.Text.Length

        Dim MatchNumberPatternForUpperCase As String = "^.*(?=.*[A-Z]).*$"
        'If the password has atleast one uppercase letter then...
        If GeneratingPassword.Text.Trim <> "" Then
            If Regex.IsMatch(GeneratingPassword.Text, MatchNumberPatternForUpperCase) Then
                UppercasePoints = 5
            End If
        End If

        Dim MatchNumberPatternForLowercase As String = "^.*(?=.*[a-z]).*$"
        'If the password has atleast one lowercase letter then...
        If GeneratingPassword.Text.Trim <> "" Then
            If Regex.IsMatch(GeneratingPassword.Text, MatchNumberPatternForLowercase) Then
                LowercasePoints = 5
            End If
        End If

        Dim MatchNumberPatternForDigits As String = ".*[0-9].*"
        'If the password has atleast one digit then...
        If GeneratingPassword.Text.Trim <> "" Then
            If Regex.IsMatch(GeneratingPassword.Text, MatchNumberPatternForDigits) Then
                DigitPoints = 5
            End If
        End If

        Dim MatchNumberPatternForSpecialChars As String = ".*[!$%^&*()-_=+].*"
        'If the password doesn't have a special character then...
        If (GeneratingPassword.Text.Trim <> "") Then
            If Regex.IsMatch(GeneratingPassword.Text, MatchNumberPatternForSpecialChars) Then
                SpecialCharPoints = 5
            End If
        End If

        FinalPoints = (LowercasePoints + UppercasePoints + DigitPoints + SpecialCharPoints + PwdLengthpoints) - OnlyUpperCaseAndLowerCase - OnlyDigits - OnlySpecialChar
        MsgBox(FinalPoints)
        MsgBox(PwdLengthpoints)
    End Sub
End Class