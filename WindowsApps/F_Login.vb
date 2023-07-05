
Public Class F_Login


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        txt_password.PasswordChar = "*"
    End Sub

    Private Sub Txt_showpasswod_CheckedChanged(sender As Object, e As EventArgs) Handles txt_showpasswod.CheckedChanged
        If txt_showpasswod.Checked = True Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "*"
        End If
    End Sub

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txt_password.Text = ""
        txt_username.Text = ""
        txt_showpasswod.Checked = False

        txt_username.Focus()

    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Panel_login_bar.Visible = True
        Timer_login.Start()


    End Sub


    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Panel_login_bar.Visible = True
            Timer_login.Start()

        End If
    End Sub

    Private Sub Timer_login_Tick(sender As Object, e As EventArgs) Handles Timer_login.Tick
        If BAR_LOGIN.Value <= 100 Then
            BAR_LOGIN.Value += 1
            Label_persen_login.Text = BAR_LOGIN.Value.ToString + " " + "%"
        Else
            Timer_login.Stop()
        End If

        If BAR_LOGIN.Value = 25 Then
            BAR_LOGIN.FillColor = Color.Red
            BAR_LOGIN.ProgressColor2 = Color.Blue
            Label_loading_login.Text = "Sedang Mencari Data ..."
        ElseIf BAR_LOGIN.Value = 50 Then
            BAR_LOGIN.FillColor = Color.Green
            BAR_LOGIN.ProgressColor2 = Color.Brown
            Label_loading_login.Text = "Sedang Memeriksa Data ..."
        ElseIf BAR_LOGIN.Value = 75 Then
            BAR_LOGIN.FillColor = Color.DarkCyan
            BAR_LOGIN.ProgressColor2 = Color.Green
            Label_loading_login.Text = "Sedang Validasi Data ..."
        ElseIf BAR_LOGIN.Value = 100 Then
            Timer_login.Stop()
            Panel_login_bar.Visible = False
            LOGIN_USER()
        End If
    End Sub
End Class
