<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_showpasswod = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btn_login = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse5 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.garis = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Elipse6 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel_login_bar = New System.Windows.Forms.Panel()
        Me.Label_persen_login = New System.Windows.Forms.Label()
        Me.Label_loading_login = New System.Windows.Forms.Label()
        Me.BAR_LOGIN = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Timer_login = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_login_bar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 40)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(604, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(634, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 12
        Me.Guna2Elipse1.TargetControl = Me
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(36, 147)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(251, 201)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'txt_username
        '
        Me.txt_username.BorderThickness = 0
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.DefaultText = ""
        Me.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.DisabledState.Parent = Me.txt_username
        Me.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.FocusedState.Parent = Me.txt_username
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.Color.Black
        Me.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.HoverState.Parent = Me.txt_username
        Me.txt_username.IconLeft = CType(resources.GetObject("txt_username.IconLeft"), System.Drawing.Image)
        Me.txt_username.Location = New System.Drawing.Point(367, 170)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.PlaceholderText = ""
        Me.txt_username.SelectedText = ""
        Me.txt_username.ShadowDecoration.Parent = Me.txt_username
        Me.txt_username.Size = New System.Drawing.Size(250, 30)
        Me.txt_username.TabIndex = 2
        '
        'txt_password
        '
        Me.txt_password.BorderThickness = 0
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.Parent = Me.txt_password
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.FocusedState.Parent = Me.txt_password
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.Color.Black
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.HoverState.Parent = Me.txt_password
        Me.txt_password.IconLeft = CType(resources.GetObject("txt_password.IconLeft"), System.Drawing.Image)
        Me.txt_password.Location = New System.Drawing.Point(367, 234)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.PlaceholderText = ""
        Me.txt_password.SelectedText = ""
        Me.txt_password.ShadowDecoration.Parent = Me.txt_password
        Me.txt_password.Size = New System.Drawing.Size(250, 30)
        Me.txt_password.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(363, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'txt_showpasswod
        '
        Me.txt_showpasswod.AutoSize = True
        Me.txt_showpasswod.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_showpasswod.CheckedState.BorderRadius = 2
        Me.txt_showpasswod.CheckedState.BorderThickness = 0
        Me.txt_showpasswod.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_showpasswod.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_showpasswod.Location = New System.Drawing.Point(367, 271)
        Me.txt_showpasswod.Name = "txt_showpasswod"
        Me.txt_showpasswod.Size = New System.Drawing.Size(110, 19)
        Me.txt_showpasswod.TabIndex = 6
        Me.txt_showpasswod.Text = "Show Password"
        Me.txt_showpasswod.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txt_showpasswod.UncheckedState.BorderRadius = 2
        Me.txt_showpasswod.UncheckedState.BorderThickness = 0
        Me.txt_showpasswod.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txt_showpasswod.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.CheckedState.Parent = Me.btn_login
        Me.btn_login.CustomImages.Parent = Me.btn_login
        Me.btn_login.FillColor = System.Drawing.Color.DarkSlateGray
        Me.btn_login.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Black
        Me.btn_login.HoverState.Parent = Me.btn_login
        Me.btn_login.Location = New System.Drawing.Point(367, 318)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.ShadowDecoration.Parent = Me.btn_login
        Me.btn_login.Size = New System.Drawing.Size(110, 30)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "LOGIN"
        '
        'btn_cancel
        '
        Me.btn_cancel.CheckedState.Parent = Me.btn_cancel
        Me.btn_cancel.CustomImages.Parent = Me.btn_cancel
        Me.btn_cancel.FillColor = System.Drawing.Color.DarkSlateGray
        Me.btn_cancel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cancel.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.HoverState.Parent = Me.btn_cancel
        Me.btn_cancel.Location = New System.Drawing.Point(507, 318)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.ShadowDecoration.Parent = Me.btn_cancel
        Me.btn_cancel.Size = New System.Drawing.Size(110, 30)
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.Text = "CANCEL"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me.txt_username
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.TargetControl = Me.txt_password
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.TargetControl = Me.btn_login
        '
        'Guna2Elipse5
        '
        Me.Guna2Elipse5.TargetControl = Me.btn_cancel
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(462, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Welcome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(414, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Login below to continue"
        '
        'garis
        '
        Me.garis.CheckedState.Parent = Me.garis
        Me.garis.CustomImages.Parent = Me.garis
        Me.garis.FillColor = System.Drawing.Color.Red
        Me.garis.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.garis.ForeColor = System.Drawing.Color.White
        Me.garis.HoverState.Parent = Me.garis
        Me.garis.Location = New System.Drawing.Point(367, 112)
        Me.garis.Name = "garis"
        Me.garis.ShadowDecoration.Parent = Me.garis
        Me.garis.Size = New System.Drawing.Size(250, 5)
        Me.garis.TabIndex = 12
        '
        'Guna2Elipse6
        '
        Me.Guna2Elipse6.TargetControl = Me.garis
        '
        'Panel_login_bar
        '
        Me.Panel_login_bar.Controls.Add(Me.Label_persen_login)
        Me.Panel_login_bar.Controls.Add(Me.Label_loading_login)
        Me.Panel_login_bar.Controls.Add(Me.BAR_LOGIN)
        Me.Panel_login_bar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_login_bar.Location = New System.Drawing.Point(0, 354)
        Me.Panel_login_bar.Name = "Panel_login_bar"
        Me.Panel_login_bar.Size = New System.Drawing.Size(670, 45)
        Me.Panel_login_bar.TabIndex = 13
        Me.Panel_login_bar.Visible = False
        '
        'Label_persen_login
        '
        Me.Label_persen_login.AutoSize = True
        Me.Label_persen_login.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_persen_login.Location = New System.Drawing.Point(617, 18)
        Me.Label_persen_login.Name = "Label_persen_login"
        Me.Label_persen_login.Size = New System.Drawing.Size(53, 19)
        Me.Label_persen_login.TabIndex = 6
        Me.Label_persen_login.Text = "100 %"
        '
        'Label_loading_login
        '
        Me.Label_loading_login.AutoSize = True
        Me.Label_loading_login.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_loading_login.Location = New System.Drawing.Point(8, 6)
        Me.Label_loading_login.Name = "Label_loading_login"
        Me.Label_loading_login.Size = New System.Drawing.Size(112, 19)
        Me.Label_loading_login.TabIndex = 5
        Me.Label_loading_login.Text = "Loading Data .."
        '
        'BAR_LOGIN
        '
        Me.BAR_LOGIN.FillColor = System.Drawing.Color.Gray
        Me.BAR_LOGIN.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.BAR_LOGIN.Location = New System.Drawing.Point(7, 28)
        Me.BAR_LOGIN.Name = "BAR_LOGIN"
        Me.BAR_LOGIN.ShadowDecoration.Parent = Me.BAR_LOGIN
        Me.BAR_LOGIN.Size = New System.Drawing.Size(610, 5)
        Me.BAR_LOGIN.TabIndex = 0
        Me.BAR_LOGIN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Timer_login
        '
        Me.Timer_login.Interval = 20
        '
        'F_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(670, 399)
        Me.Controls.Add(Me.Panel_login_bar)
        Me.Controls.Add(Me.garis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_showpasswod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_login_bar.ResumeLayout(False)
        Me.Panel_login_bar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txt_showpasswod As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse5 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents garis As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Elipse6 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel_login_bar As Panel
    Friend WithEvents Label_persen_login As Label
    Friend WithEvents Label_loading_login As Label
    Friend WithEvents BAR_LOGIN As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Timer_login As Timer
End Class
