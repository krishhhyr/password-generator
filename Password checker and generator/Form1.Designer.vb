<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CreateOption = New System.Windows.Forms.Button()
        Me.GenerateOption = New System.Windows.Forms.Button()
        Me.QuitOption = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinkPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CreateOption
        '
        Me.CreateOption.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateOption.Location = New System.Drawing.Point(18, 10)
        Me.CreateOption.Name = "CreateOption"
        Me.CreateOption.Size = New System.Drawing.Size(153, 40)
        Me.CreateOption.TabIndex = 0
        Me.CreateOption.Text = "Create a password"
        Me.CreateOption.UseVisualStyleBackColor = True
        '
        'GenerateOption
        '
        Me.GenerateOption.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateOption.Location = New System.Drawing.Point(18, 74)
        Me.GenerateOption.Name = "GenerateOption"
        Me.GenerateOption.Size = New System.Drawing.Size(153, 40)
        Me.GenerateOption.TabIndex = 1
        Me.GenerateOption.Text = "Generate a password"
        Me.GenerateOption.UseVisualStyleBackColor = True
        '
        'QuitOption
        '
        Me.QuitOption.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitOption.Location = New System.Drawing.Point(18, 141)
        Me.QuitOption.Name = "QuitOption"
        Me.QuitOption.Size = New System.Drawing.Size(153, 40)
        Me.QuitOption.TabIndex = 2
        Me.QuitOption.Text = "Quit application"
        Me.QuitOption.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(802, 30)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.QuitOption)
        Me.Panel1.Controls.Add(Me.GenerateOption)
        Me.Panel1.Controls.Add(Me.CreateOption)
        Me.Panel1.Location = New System.Drawing.Point(246, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 205)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(423, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "How do you want to check your password?"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(633, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 43)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Over 12 million people have visited this website!"
        '
        'LinkPictureBox
        '
        Me.LinkPictureBox.Image = CType(resources.GetObject("LinkPictureBox.Image"), System.Drawing.Image)
        Me.LinkPictureBox.Location = New System.Drawing.Point(313, 377)
        Me.LinkPictureBox.Name = "LinkPictureBox"
        Me.LinkPictureBox.Size = New System.Drawing.Size(44, 37)
        Me.LinkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LinkPictureBox.TabIndex = 8
        Me.LinkPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 436)
        Me.Controls.Add(Me.LinkPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "KrishhhyscheckYourpassword.com"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinkPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CreateOption As Button
    Friend WithEvents GenerateOption As Button
    Friend WithEvents QuitOption As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkPictureBox As PictureBox
End Class
