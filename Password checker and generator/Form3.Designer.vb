<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GeneratingPassword = New System.Windows.Forms.TextBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.BackButton3 = New System.Windows.Forms.Button()
        Me.ContinueButton3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GeneratingPassword)
        Me.Panel1.Location = New System.Drawing.Point(217, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 39)
        Me.Panel1.TabIndex = 11
        '
        'GeneratingPassword
        '
        Me.GeneratingPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GeneratingPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GeneratingPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GeneratingPassword.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.GeneratingPassword.Location = New System.Drawing.Point(-1, 8)
        Me.GeneratingPassword.Multiline = True
        Me.GeneratingPassword.Name = "GeneratingPassword"
        Me.GeneratingPassword.ReadOnly = True
        Me.GeneratingPassword.Size = New System.Drawing.Size(352, 26)
        Me.GeneratingPassword.TabIndex = 0
        '
        'GenerateButton
        '
        Me.GenerateButton.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateButton.Location = New System.Drawing.Point(344, 206)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(102, 32)
        Me.GenerateButton.TabIndex = 12
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'BackButton3
        '
        Me.BackButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton3.Location = New System.Drawing.Point(344, 287)
        Me.BackButton3.Name = "BackButton3"
        Me.BackButton3.Size = New System.Drawing.Size(102, 32)
        Me.BackButton3.TabIndex = 13
        Me.BackButton3.Text = "Back"
        Me.BackButton3.UseVisualStyleBackColor = True
        '
        'ContinueButton3
        '
        Me.ContinueButton3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueButton3.Location = New System.Drawing.Point(344, 249)
        Me.ContinueButton3.Name = "ContinueButton3"
        Me.ContinueButton3.Size = New System.Drawing.Size(102, 32)
        Me.ContinueButton3.TabIndex = 14
        Me.ContinueButton3.Text = "Continue"
        Me.ContinueButton3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-7, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(808, 31)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ContinueButton3)
        Me.Controls.Add(Me.BackButton3)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form3"
        Me.Text = "GeneratingAPassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GeneratingPassword As TextBox
    Friend WithEvents GenerateButton As Button
    Friend WithEvents BackButton3 As Button
    Friend WithEvents ContinueButton3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
