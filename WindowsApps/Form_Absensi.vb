Public Class Form_Absensi
    Private Sub ABSENSI_BTN_CARI_Click(sender As Object, e As EventArgs) Handles ABSENSI_BTN_CARI.Click
        API_ABSENSI_CARI()
    End Sub

    Private Sub ABSENSI_BTN_HADIR_Click(sender As Object, e As EventArgs) Handles ABSENSI_BTN_HADIR.Click
        POST_API_ABSENS_HADIR()
    End Sub
End Class