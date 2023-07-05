Public Class Form_TambahStok
    Sub RUBAH_SIZE()
        Dim LEBAR As Integer = Me.Width
        Dim TINGGI As Integer = Me.Height
        Size = New Drawing.Size(LEBAR - 130, TINGGI - 200)

        Panel_dua_tambahstok.Visible = True
        Panel_satu_tambahstok.Visible = False

        btn_close_tambahstok.Visible = False
        btn_minim_tambahstok.Visible = False
    End Sub


    Sub SIZE_TETAP()
        Dim LEBAR As Integer = Me.Width
        Dim TINGGI As Integer = Me.Height
        Size = New Drawing.Size(LEBAR + 130, TINGGI + 200)

        If LEBAR = 530 And TINGGI = 450 Then
            Size = New Drawing.Size(LEBAR = 530, TINGGI = 450)

        End If
        Panel_dua_tambahstok.Visible = False
        Panel_satu_tambahstok.Visible = True

        btn_close_tambahstok.Visible = True
        btn_minim_tambahstok.Visible = True
    End Sub

    Private Sub btn_close_tambahstok_Click(sender As Object, e As EventArgs) Handles btn_close_tambahstok.Click
        Close()
        GET_AREA_BARANG()

    End Sub

    Private Sub btn_minim_tambahstok_Click(sender As Object, e As EventArgs) Handles btn_minim_tambahstok.Click
        Me.WindowState = FormWindowState.Minimized


    End Sub


    Dim Mouse_Move As System.Drawing.Point

    Private Sub Panel_top_tambahstok_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_top_retur.MouseDown
        Mouse_Move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Panel_top_tambahstok_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_top_retur.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim posisi As Point
            posisi = Control.MousePosition
            posisi.Offset(Mouse_Move.X, Mouse_Move.Y)
            Me.Location = posisi
        End If
    End Sub

    Private Sub DGV_TAMBAH_STOK_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_TAMBAH_STOK.CellContentClick
        Label_kode_tambahstok.Text = DGV_TAMBAH_STOK.Rows(e.RowIndex).Cells(0).Value
        Label_nama_tambahstok.Text = DGV_TAMBAH_STOK.Rows(e.RowIndex).Cells(1).Value
        Label_stok_tambahstok.Text = DGV_TAMBAH_STOK.Rows(e.RowIndex).Cells(2).Value
        Label_qty_tambahstok.Text = DGV_TAMBAH_STOK.Rows(e.RowIndex).Cells(3).Value
        Label_satuan_tambahstok.Text = DGV_TAMBAH_STOK.Rows(e.RowIndex).Cells(4).Value
        RUBAH_SIZE()


    End Sub

    Private Sub Form_TambahStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_AREA_TAMBAH_STOK_BARANG() 'INI WAJIB DI PANGIL PALING PERTAMA DIKARNAKAN CUSTOM DGV
        GET_AREA_TAMBAH_STOK_BARANG()

    End Sub


    Private Sub btn_batal_paneldua_tambahstok_Click(sender As Object, e As EventArgs) Handles btn_batal_paneldua_tambahstok.Click
        SIZE_TETAP()

    End Sub

    Private Sub btn_simpan_paneldua_tambahstok_Click(sender As Object, e As EventArgs) Handles btn_simpan_paneldua_tambahstok.Click
        STOK_TAMBAH_BARANG_API_TES()
        SIZE_TETAP()
        GET_AREA_TAMBAH_STOK_BARANG()

    End Sub

    Private Sub btn_cari_nama_tambahstok_Click(sender As Object, e As EventArgs) Handles btn_cari_nama_tambahstok.Click
        LIKE_AREA_TAMBAH_SATOK_BARANG()

    End Sub

    Private Sub Panel_top_retur_Paint(sender As Object, e As PaintEventArgs) Handles Panel_top_retur.Paint

    End Sub
End Class