Public Class Form_Barang_Datang
    Private Sub Form_Barang_Datang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_AREA_VIEW_BARANG_DATANG()
        TANGGAL_AREA_BARANG_DATANG()
        CLEAR_AREA_BARANG_DATANG()
        INPUT_KODE_AREA_BARANG_DATANG()




    End Sub

    Private Sub BARANGDATANG_BTN_CARI_Click(sender As Object, e As EventArgs) Handles BARANGDATANG_BTN_CARI.Click
        LIKE_AREA_BARANG_DATANG()

    End Sub

    Private Sub BARANGDATANG_BTN_SIMPAN_Click(sender As Object, e As EventArgs) Handles BARANGDATANG_BTN_SIMPAN.Click
        VALIDASI_SIMPAN_ROW_AREA_BARANG_DATANG()

    End Sub

    Private Sub BARANGDATANG_BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BARANGDATANG_BTN_CLOSE.Click
        Close()

    End Sub

    Private Sub BARANGDATANG_BTN_MINIM_Click(sender As Object, e As EventArgs) Handles BARANGDATANG_BTN_MINIM.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BARANGDATANG_BTN_PROSES_Click(sender As Object, e As EventArgs) Handles BARANGDATANG_BTN_PROSES.Click
        PUT_UPDATE_BARANG_DATANG()
        POST_CREATE_BARANG_DATANG()


    End Sub

    Private Sub BARANGDATANG_BTN_BATAL_Click(sender As Object, e As EventArgs) Handles BARANGDATANG_BTN_BATAL.Click
        CLEAR_AREA_BARANG_DATANG()

    End Sub
End Class