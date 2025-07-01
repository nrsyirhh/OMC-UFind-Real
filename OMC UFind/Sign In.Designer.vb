<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sign_In
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_In))
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblforgotpass = New System.Windows.Forms.Label()
        Me.lblSIgnUp = New System.Windows.Forms.Label()
        Me.lblSignUpLogin = New System.Windows.Forms.Label()
        Me.btnSign1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.sliderTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Poppins", 14.8!, System.Drawing.FontStyle.Bold)
        Me.lblLogin.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblLogin.Location = New System.Drawing.Point(180, 412)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(106, 53)
        Me.lblLogin.TabIndex = 1
        Me.lblLogin.Text = "Login"
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.BackColor = System.Drawing.Color.Transparent
        Me.lblSignIn.Font = New System.Drawing.Font("Poppins", 7.0!)
        Me.lblSignIn.ForeColor = System.Drawing.Color.IndianRed
        Me.lblSignIn.Location = New System.Drawing.Point(158, 456)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(144, 25)
        Me.lblSignIn.TabIndex = 2
        Me.lblSignIn.Text = "Sign in to continue."
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Gray
        Me.lblUsername.Location = New System.Drawing.Point(57, 489)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(107, 31)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "USERNAME"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Gray
        Me.lblPassword.Location = New System.Drawing.Point(57, 571)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(114, 31)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "PASSWORD"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(63, 525)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(336, 42)
        Me.txtUsername.TabIndex = 5
        '
        'lblforgotpass
        '
        Me.lblforgotpass.AutoSize = True
        Me.lblforgotpass.BackColor = System.Drawing.Color.Transparent
        Me.lblforgotpass.Font = New System.Drawing.Font("Poppins", 7.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblforgotpass.ForeColor = System.Drawing.Color.Snow
        Me.lblforgotpass.Location = New System.Drawing.Point(158, 738)
        Me.lblforgotpass.Name = "lblforgotpass"
        Me.lblforgotpass.Size = New System.Drawing.Size(150, 26)
        Me.lblforgotpass.TabIndex = 8
        Me.lblforgotpass.Text = "Forgot Password ?"
        '
        'lblSIgnUp
        '
        Me.lblSIgnUp.AutoSize = True
        Me.lblSIgnUp.BackColor = System.Drawing.Color.Transparent
        Me.lblSIgnUp.Font = New System.Drawing.Font("Poppins", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSIgnUp.ForeColor = System.Drawing.Color.White
        Me.lblSIgnUp.Location = New System.Drawing.Point(128, 766)
        Me.lblSIgnUp.Name = "lblSIgnUp"
        Me.lblSIgnUp.Size = New System.Drawing.Size(123, 26)
        Me.lblSIgnUp.TabIndex = 9
        Me.lblSIgnUp.Text = "Not a user yet?"
        '
        'lblSignUpLogin
        '
        Me.lblSignUpLogin.AutoSize = True
        Me.lblSignUpLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblSignUpLogin.Font = New System.Drawing.Font("Poppins", 7.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUpLogin.ForeColor = System.Drawing.Color.White
        Me.lblSignUpLogin.Location = New System.Drawing.Point(249, 766)
        Me.lblSignUpLogin.Name = "lblSignUpLogin"
        Me.lblSignUpLogin.Size = New System.Drawing.Size(69, 26)
        Me.lblSignUpLogin.TabIndex = 10
        Me.lblSignUpLogin.Text = "Sign Up"
        '
        'btnSign1
        '
        Me.btnSign1.BackColor = System.Drawing.Color.Transparent
        Me.btnSign1.BackgroundImage = Global.OMC_UFind.My.Resources.Resources.Blue_Yellow_Minimalist_Happy_Graduation_Canvas_Button__1_
        Me.btnSign1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSign1.FlatAppearance.BorderSize = 0
        Me.btnSign1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSign1.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSign1.ForeColor = System.Drawing.Color.White
        Me.btnSign1.Location = New System.Drawing.Point(99, 689)
        Me.btnSign1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSign1.Name = "btnSign1"
        Me.btnSign1.Size = New System.Drawing.Size(262, 45)
        Me.btnSign1.TabIndex = 7
        Me.btnSign1.Text = "Sign In"
        Me.btnSign1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(-222, 181)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(806, 1051)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(63, 608)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(336, 42)
        Me.TextBox1.TabIndex = 13
        '
        'sliderTimer
        '
        Me.sliderTimer.Interval = 2000
        '
        'Sign_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OMC_UFind.My.Resources.Resources.front_backround2
        Me.ClientSize = New System.Drawing.Size(458, 814)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSignUpLogin)
        Me.Controls.Add(Me.lblSIgnUp)
        Me.Controls.Add(Me.lblforgotpass)
        Me.Controls.Add(Me.btnSign1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblSignIn)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sign_In"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign_In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblSignIn As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblforgotpass As Label
    Friend WithEvents lblSIgnUp As Label
    Friend WithEvents lblSignUpLogin As Label
    Friend WithEvents btnSign1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents sliderTimer As Timer
End Class
