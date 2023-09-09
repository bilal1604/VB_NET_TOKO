Public Class Form_Absensi
    Private Sub ABSENSI_BTN_CARI_Click(sender As Object, e As EventArgs) Handles ABSENSI_BTN_CARI.Click
        API_ABSENSI_CARI()
        VALIDASI_ABSENSI_ROW()

    End Sub

    Private Sub ABSENSI_BTN_HADIR_Click(sender As Object, e As EventArgs) Handles ABSENSI_BTN_HADIR.Click
        VALIDASI_ABSENSI_HADIR()
    End Sub

    Private Sub ABSENSI_BTN_ABSENSI_PULANG_Click(sender As Object, e As EventArgs) Handles ABSENSI_BTN_ABSENSI_PULANG.Click
        VALIDASI_ABSENSI_PULANG()

    End Sub


End Class