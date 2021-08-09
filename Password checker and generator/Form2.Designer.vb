<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(create))
        Me.Enter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EyeWithNoTickPic = New System.Windows.Forms.PictureBox()
        Me.TypingPassword = New System.Windows.Forms.TextBox()
        Me.EyeWithTick1 = New System.Windows.Forms.PictureBox()
        Me.IncorrectMatch = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.EyeWithNoTick2 = New System.Windows.Forms.PictureBox()
        Me.ConfirmingPassword = New System.Windows.Forms.TextBox()
        Me.EyeWithTick2 = New System.Windows.Forms.PictureBox()
        Me.Match = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EightCharErrorLabel = New System.Windows.Forms.Label()
        Me.TwentyFourCharErrorLabel = New System.Windows.Forms.Label()
        Me.InvalidCharLabel = New System.Windows.Forms.Label()
        Me.CharNoticeError = New System.Windows.Forms.Label()
        Me.InvalidPwdLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.EyeWithNoTickPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EyeWithTick1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.EyeWithNoTick2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EyeWithTick2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Enter
        '
        Me.Enter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enter.Location = New System.Drawing.Point(306, 276)
        Me.Enter.Name = "Enter"
        Me.Enter.Size = New System.Drawing.Size(97, 26)
        Me.Enter.TabIndex = 2
        Me.Enter.Text = "Enter"
        Me.Enter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Confirm:"
        '
        'ContinueButton
        '
        Me.ContinueButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueButton.Location = New System.Drawing.Point(418, 276)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(97, 26)
        Me.ContinueButton.TabIndex = 6
        Me.ContinueButton.Text = "Continue"
        Me.ContinueButton.UseVisualStyleBackColor = True
        Me.ContinueButton.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.EyeWithNoTickPic)
        Me.Panel1.Controls.Add(Me.TypingPassword)
        Me.Panel1.Controls.Add(Me.EyeWithTick1)
        Me.Panel1.Location = New System.Drawing.Point(193, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 39)
        Me.Panel1.TabIndex = 10
        '
        'EyeWithNoTickPic
        '
        Me.EyeWithNoTickPic.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EyeWithNoTickPic.Image = CType(resources.GetObject("EyeWithNoTickPic.Image"), System.Drawing.Image)
        Me.EyeWithNoTickPic.Location = New System.Drawing.Point(301, 4)
        Me.EyeWithNoTickPic.Name = "EyeWithNoTickPic"
        Me.EyeWithNoTickPic.Size = New System.Drawing.Size(46, 30)
        Me.EyeWithNoTickPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EyeWithNoTickPic.TabIndex = 11
        Me.EyeWithNoTickPic.TabStop = False
        '
        'TypingPassword
        '
        Me.TypingPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TypingPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TypingPassword.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.TypingPassword.Location = New System.Drawing.Point(-1, 8)
        Me.TypingPassword.Multiline = True
        Me.TypingPassword.Name = "TypingPassword"
        Me.TypingPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TypingPassword.Size = New System.Drawing.Size(297, 26)
        Me.TypingPassword.TabIndex = 0
        '
        'EyeWithTick1
        '
        Me.EyeWithTick1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EyeWithTick1.Image = CType(resources.GetObject("EyeWithTick1.Image"), System.Drawing.Image)
        Me.EyeWithTick1.Location = New System.Drawing.Point(301, 4)
        Me.EyeWithTick1.Name = "EyeWithTick1"
        Me.EyeWithTick1.Size = New System.Drawing.Size(46, 30)
        Me.EyeWithTick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EyeWithTick1.TabIndex = 18
        Me.EyeWithTick1.TabStop = False
        '
        'IncorrectMatch
        '
        Me.IncorrectMatch.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IncorrectMatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IncorrectMatch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncorrectMatch.ForeColor = System.Drawing.Color.Red
        Me.IncorrectMatch.Location = New System.Drawing.Point(187, 223)
        Me.IncorrectMatch.Name = "IncorrectMatch"
        Me.IncorrectMatch.Size = New System.Drawing.Size(328, 27)
        Me.IncorrectMatch.TabIndex = 13
        Me.IncorrectMatch.Text = "Those passwords didn't match. Try again."
        Me.IncorrectMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IncorrectMatch.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.EyeWithNoTick2)
        Me.Panel2.Controls.Add(Me.ConfirmingPassword)
        Me.Panel2.Controls.Add(Me.EyeWithTick2)
        Me.Panel2.Location = New System.Drawing.Point(193, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 39)
        Me.Panel2.TabIndex = 14
        '
        'EyeWithNoTick2
        '
        Me.EyeWithNoTick2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EyeWithNoTick2.Image = CType(resources.GetObject("EyeWithNoTick2.Image"), System.Drawing.Image)
        Me.EyeWithNoTick2.Location = New System.Drawing.Point(301, 3)
        Me.EyeWithNoTick2.Name = "EyeWithNoTick2"
        Me.EyeWithNoTick2.Size = New System.Drawing.Size(46, 30)
        Me.EyeWithNoTick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EyeWithNoTick2.TabIndex = 11
        Me.EyeWithNoTick2.TabStop = False
        '
        'ConfirmingPassword
        '
        Me.ConfirmingPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConfirmingPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConfirmingPassword.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ConfirmingPassword.Location = New System.Drawing.Point(-1, 8)
        Me.ConfirmingPassword.Multiline = True
        Me.ConfirmingPassword.Name = "ConfirmingPassword"
        Me.ConfirmingPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.ConfirmingPassword.Size = New System.Drawing.Size(297, 26)
        Me.ConfirmingPassword.TabIndex = 0
        '
        'EyeWithTick2
        '
        Me.EyeWithTick2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EyeWithTick2.Image = CType(resources.GetObject("EyeWithTick2.Image"), System.Drawing.Image)
        Me.EyeWithTick2.Location = New System.Drawing.Point(301, 4)
        Me.EyeWithTick2.Name = "EyeWithTick2"
        Me.EyeWithTick2.Size = New System.Drawing.Size(46, 30)
        Me.EyeWithTick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EyeWithTick2.TabIndex = 19
        Me.EyeWithTick2.TabStop = False
        '
        'Match
        '
        Me.Match.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Match.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Match.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Match.ForeColor = System.Drawing.Color.Chartreuse
        Me.Match.Location = New System.Drawing.Point(187, 223)
        Me.Match.Name = "Match"
        Me.Match.Size = New System.Drawing.Size(328, 27)
        Me.Match.TabIndex = 15
        Me.Match.Text = "Passwords match."
        Me.Match.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Match.Visible = False
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(187, 276)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(102, 26)
        Me.Back.TabIndex = 16
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(674, 31)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'EightCharErrorLabel
        '
        Me.EightCharErrorLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EightCharErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EightCharErrorLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EightCharErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.EightCharErrorLabel.Location = New System.Drawing.Point(187, 223)
        Me.EightCharErrorLabel.Name = "EightCharErrorLabel"
        Me.EightCharErrorLabel.Size = New System.Drawing.Size(328, 27)
        Me.EightCharErrorLabel.TabIndex = 19
        Me.EightCharErrorLabel.Text = "Password must be greater than 8 characters!"
        Me.EightCharErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EightCharErrorLabel.Visible = False
        '
        'TwentyFourCharErrorLabel
        '
        Me.TwentyFourCharErrorLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TwentyFourCharErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TwentyFourCharErrorLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TwentyFourCharErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.TwentyFourCharErrorLabel.Location = New System.Drawing.Point(187, 223)
        Me.TwentyFourCharErrorLabel.Name = "TwentyFourCharErrorLabel"
        Me.TwentyFourCharErrorLabel.Size = New System.Drawing.Size(328, 27)
        Me.TwentyFourCharErrorLabel.TabIndex = 20
        Me.TwentyFourCharErrorLabel.Text = "Password must be less than 24 characters!"
        Me.TwentyFourCharErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TwentyFourCharErrorLabel.Visible = False
        '
        'InvalidCharLabel
        '
        Me.InvalidCharLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.InvalidCharLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InvalidCharLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvalidCharLabel.ForeColor = System.Drawing.Color.Red
        Me.InvalidCharLabel.Location = New System.Drawing.Point(187, 196)
        Me.InvalidCharLabel.Name = "InvalidCharLabel"
        Me.InvalidCharLabel.Size = New System.Drawing.Size(328, 27)
        Me.InvalidCharLabel.TabIndex = 21
        Me.InvalidCharLabel.Text = "Invalid special characters in passwords!"
        Me.InvalidCharLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.InvalidCharLabel.Visible = False
        '
        'CharNoticeError
        '
        Me.CharNoticeError.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CharNoticeError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CharNoticeError.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharNoticeError.ForeColor = System.Drawing.Color.Red
        Me.CharNoticeError.Location = New System.Drawing.Point(187, 223)
        Me.CharNoticeError.Name = "CharNoticeError"
        Me.CharNoticeError.Size = New System.Drawing.Size(328, 40)
        Me.CharNoticeError.TabIndex = 22
        Me.CharNoticeError.Text = "Only characters, !$%^&*()-_=+ are allowed!"
        Me.CharNoticeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CharNoticeError.Visible = False
        '
        'InvalidPwdLabel
        '
        Me.InvalidPwdLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.InvalidPwdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InvalidPwdLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvalidPwdLabel.ForeColor = System.Drawing.Color.Red
        Me.InvalidPwdLabel.Location = New System.Drawing.Point(187, 223)
        Me.InvalidPwdLabel.Name = "InvalidPwdLabel"
        Me.InvalidPwdLabel.Size = New System.Drawing.Size(328, 27)
        Me.InvalidPwdLabel.TabIndex = 23
        Me.InvalidPwdLabel.Text = "Passwords invalid!"
        Me.InvalidPwdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.InvalidPwdLabel.Visible = False
        '
        'create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 404)
        Me.Controls.Add(Me.InvalidPwdLabel)
        Me.Controls.Add(Me.CharNoticeError)
        Me.Controls.Add(Me.InvalidCharLabel)
        Me.Controls.Add(Me.TwentyFourCharErrorLabel)
        Me.Controls.Add(Me.EightCharErrorLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Match)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IncorrectMatch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Enter)
        Me.Name = "create"
        Me.Text = "Creating a password"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EyeWithNoTickPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EyeWithTick1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.EyeWithNoTick2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EyeWithTick2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Enter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ContinueButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EyeWithNoTickPic As PictureBox
    Friend WithEvents TypingPassword As TextBox
    Friend WithEvents IncorrectMatch As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents EyeWithNoTick2 As PictureBox
    Friend WithEvents ConfirmingPassword As TextBox
    Friend WithEvents Match As Label
    Friend WithEvents Back As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EyeWithTick1 As PictureBox
    Friend WithEvents EyeWithTick2 As PictureBox
    Friend WithEvents EightCharErrorLabel As Label
    Friend WithEvents TwentyFourCharErrorLabel As Label
    Friend WithEvents InvalidCharLabel As Label
    Friend WithEvents CharNoticeError As Label
    Friend WithEvents InvalidPwdLabel As Label
End Class
