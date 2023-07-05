Public Class Dashbord
    Private Sub Btn_minim_Click(sender As Object, e As EventArgs) Handles btn_minim.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()

    End Sub



    Private Sub Dashbord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        USER_BY_ID()
        DGV_AREA_USER()
        DGV_AREA_BARANG()
        UCAPAN()



        GET_AREA_BARANG()
        GET_AREA_USER()
        GET_COMBO_AREA_USER_CLASS()
        GET_COMBO_AREA_USER_STATUS()
        GET_COMBO_AREA_BARANG()




        DateTime.Enabled = True

    End Sub

    Private Sub DateTime_Tick(sender As Object, e As EventArgs) Handles DateTime.Tick
        LB_TIME.Text = TimeOfDay
        LB_TANGGAL.Text = Today

    End Sub


    Private Sub btn_master_user_Click(sender As Object, e As EventArgs) Handles btn_master_user.Click
        txt_username_user_area.Text = "" 'Clear terlebih dahulu lalu call kode otomastis
        'txt_username_user_area.Enabled = False
        KODE_OTOMATIS_AREA_USER()
        GET_COMBO_AREA_USER_CLASS()
        GET_COMBO_AREA_USER_STATUS()




        Panel_USER_AREA.Visible = True


        Panel_BARANG_AREA.Visible = False
        DASHBORD_UTAMA.Visible = False
        btn_close.Visible = False
        btn_minim.Visible = False

    End Sub

    Private Sub btn_close_dashbord_user_Click(sender As Object, e As EventArgs) Handles btn_close_dashbord_user.Click
        btn_close.Visible = True
        btn_minim.Visible = True
        DASHBORD_UTAMA.Visible = True


        Panel_USER_AREA.Visible = False
    End Sub

    Private Sub btn_dashbord_left_Click(sender As Object, e As EventArgs) Handles btn_dashbord_left.Click
        UCAPAN()

        DASHBORD_UTAMA.Visible = True
        btn_close.Visible = True
        btn_minim.Visible = True

        Panel_USER_AREA.Visible = False
        Panel_BARANG_AREA.Visible = False

    End Sub

    Private Sub btn_create_user_area_Click(sender As Object, e As EventArgs) Handles btn_create_user_area.Click
        CREATE_API_MASTER_USER()
    End Sub

    Private Sub btn_update_user_area_Click(sender As Object, e As EventArgs) Handles btn_update_user_area.Click
        PUT_AREA_USER() 'PUT ADALAH UPDATE
        CLEAR_AREA_USER()


        GET_AREA_USER()
    End Sub

    Private Sub btn_delete_user_area_Click(sender As Object, e As EventArgs) Handles btn_delete_user_area.Click
        DELETE_AREA_USER() 'DELETE DATA
        CLEAR_AREA_USER()



        GET_AREA_USER()
    End Sub







    ''AREA BARANG
    Private Sub btn_master_barang_Click(sender As Object, e As EventArgs) Handles btn_master_barang.Click
        DGV_AREA_BARANG()
        GET_AREA_BARANG()
        KODE_OTOMATIS_AREA_BARANG()
        CLEAR_AREA_BARANG()


        txt_kode_barang.Enabled = False
        btn_update_master_barang.Enabled = False
        btn_delete_master_barang.Enabled = False
        Panel_BARANG_AREA.Visible = True

        Panel_USER_AREA.Visible = False
        DASHBORD_UTAMA.Visible = False

        txt_QTY.Focus()

    End Sub

    Private Sub btn_close_master_barang_Click(sender As Object, e As EventArgs) Handles btn_close_master_barang.Click
        btn_close.Visible = True
        btn_minim.Visible = True
        DASHBORD_UTAMA.Visible = True


        Panel_BARANG_AREA.Visible = False
    End Sub

    Private Sub btn_create_master_barang_Click(sender As Object, e As EventArgs) Handles btn_create_master_barang.Click
        CREATE_API_MASTER_BARANG()
    End Sub

    Private Sub btn_update_master_barang_Click(sender As Object, e As EventArgs) Handles btn_update_master_barang.Click
        PUT_AREA_BARANG()
        CLEAR_AREA_BARANG()
        btn_delete_master_barang.Text = "DELETE"
        btn_update_master_barang.Enabled = False
        btn_delete_master_barang.Enabled = False
        btn_create_master_barang.Enabled = True




    End Sub

    Private Sub btn_delete_master_barang_Click(sender As Object, e As EventArgs) Handles btn_delete_master_barang.Click

        If btn_delete_master_barang.Text = "BATAL" Then
            CLEAR_AREA_BARANG()
            btn_delete_master_barang.Text = "DELETE"
            btn_update_master_barang.Enabled = False
            btn_delete_master_barang.Enabled = False
            btn_create_master_barang.Enabled = True


        Else
            MessageBox.Show("Kode Barang : " + txt_kode_barang.Text, "INFORMASI BARANG", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Nama Barang : " + txt_nama_barang.Text, "INFORMASI BARANG", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim tanya As String
            tanya = MessageBox.Show("Data Yang Akan Dihapus : " + txt_kode_barang.Text + "  &  " + txt_nama_barang.Text, "APAKAH INGIN DIHAPUS ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If tanya = vbYes Then
                DELETE_AREA_BARANG()
                CLEAR_AREA_BARANG()
                txt_kode_barang.Enabled = False
                txt_QTY.Focus()
                txt_QTY.Enabled = True
                txt_nama_barang.Enabled = True
                txt_harga_barang.Enabled = True
                txt_stok_barang.Enabled = True
                COMBO_satuan_barang.Enabled = True

                btn_create_master_barang.Enabled = True
                btn_update_master_barang.Enabled = False
                btn_delete_master_barang.Enabled = False

            ElseIf tanya = vbNo Then

                CLEAR_AREA_BARANG()
                txt_kode_barang.Enabled = False
                txt_QTY.Focus()
                txt_QTY.Enabled = True
                txt_nama_barang.Enabled = True
                txt_harga_barang.Enabled = True
                txt_stok_barang.Enabled = True
                COMBO_satuan_barang.Enabled = True

                btn_create_master_barang.Enabled = True
                btn_update_master_barang.Enabled = False
                btn_delete_master_barang.Enabled = False

            End If
        End If


    End Sub

    Private Sub btn_cari_barang_Click(sender As Object, e As EventArgs) Handles btn_cari_barang.Click
        LIKE_AREA_BARANG()

    End Sub


    Private Sub txt_harga_barang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_harga_barang.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True

    End Sub


    Private Sub txt_stok_barang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stok_barang.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub DGV_BARANG_AREA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BARANG_AREA.CellContentClick
        txt_kode_barang.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(0).Value
        txt_nama_barang.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(1).Value
        txt_harga_barang.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(2).Value
        txt_stok_barang.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(3).Value
        txt_QTY.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(4).Value
        COMBO_satuan_barang.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(5).Value


        txt_kode_barang.Enabled = False

        txt_nama_barang.Enabled = True
        txt_harga_barang.Enabled = True
        txt_stok_barang.Enabled = True
        txt_QTY.Enabled = True
        COMBO_satuan_barang.Enabled = True


        btn_create_master_barang.Enabled = False
        btn_update_master_barang.Enabled = True
        btn_delete_master_barang.Enabled = True
        btn_delete_master_barang.Text = "BATAL"


    End Sub

    Private Sub DGV_BARANG_AREA_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BARANG_AREA.CellContentDoubleClick
        txt_kode_barang.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(0).Value
        txt_nama_barang.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(1).Value
        txt_harga_barang.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(2).Value
        txt_stok_barang.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(3).Value
        txt_QTY.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(4).Value
        COMBO_satuan_barang.Text = DGV_BARANG_AREA.Rows(e.RowIndex).Cells(5).Value


        txt_kode_barang.Enabled = True

        txt_nama_barang.Enabled = False
        txt_harga_barang.Enabled = False
        txt_stok_barang.Enabled = False
        txt_QTY.Enabled = False
        COMBO_satuan_barang.Enabled = False


        btn_create_master_barang.Enabled = False
        btn_update_master_barang.Enabled = False
        btn_delete_master_barang.Text = "DELETE"

    End Sub

    Private Sub btn_tambahstok_masterbarang_Click(sender As Object, e As EventArgs) Handles btn_tambahstok_masterbarang.Click
        Form_TambahStok.Show()

    End Sub

    Private Sub btn_retur_masterbarang_Click(sender As Object, e As EventArgs) Handles btn_retur_masterbarang.Click
        Form_Retur.ShowDialog()
        KODE_OTOMATIS_AREA_RETUR()
        Form_Retur.RETUR_TXT_CARI.Focus()




    End Sub

    Private Sub btn_barangdatang_masterbarang_Click(sender As Object, e As EventArgs) Handles btn_barangdatang_masterbarang.Click
        Form_Barang_Datang.ShowDialog()

    End Sub

    Private Sub btn_master_absensi_Click(sender As Object, e As EventArgs) Handles btn_master_absensi.Click
        Form_Absensi.Show()
        API_CLEAR_ABSENSI()
        DGV_AREA_VIEW_ABSENSI()

    End Sub
End Class