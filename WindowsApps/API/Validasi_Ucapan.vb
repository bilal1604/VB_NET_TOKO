Module Validasi_Ucapan
    Public Sub UCAPAN()
        Dashbord.LB_UCAPAN.Text = Date.Now.ToString("HH")
        If Dashbord.LB_UCAPAN.Text >= "0" And Dashbord.LB_UCAPAN.Text <= "10" Then
            Dashbord.LB_UCAPAN.Text = "Selamat Pagi !"
        ElseIf Dashbord.LB_UCAPAN.Text >= "11" And Dashbord.LB_UCAPAN.Text <= "14" Then
            Dashbord.LB_UCAPAN.Text = "Selamat Siang !"
        ElseIf Dashbord.LB_UCAPAN.Text >= "15" And Dashbord.LB_UCAPAN.Text <= "18" Then
            Dashbord.LB_UCAPAN.Text = "Selamat Sore !"
        ElseIf Dashbord.LB_UCAPAN.Text >= "19" And Dashbord.LB_UCAPAN.Text <= "24" Then
            Dashbord.LB_UCAPAN.Text = "Selamat Malam !"
        End If

    End Sub
End Module
