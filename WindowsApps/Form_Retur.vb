Public Class Form_Retur
    Private Sub Form_Retur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DGV_AREA_VIEW_RETUR()
        TANGGAL_AREA_RETUR()
        RETUR_LABEL_USERNAME.Text = Dashbord.LB_NAMA.Text
        CLEAR_AREA_RETUR()

    End Sub

    Private Sub RETUR_BTN_CARI_Click(sender As Object, e As EventArgs) Handles RETUR_BTN_CARI.Click
        LIKE_AREA_RETUR()

    End Sub

    Dim Mouse_Move As System.Drawing.Point
    Private Sub Panel_top_retur_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_top_retur.MouseDown
        Mouse_Move = New Point(-e.X, -e.Y)

    End Sub

    Private Sub Panel_top_retur_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_top_retur.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim posisi As Point
            posisi = Control.MousePosition
            posisi.Offset(Mouse_Move.X, Mouse_Move.Y)
            Me.Location = posisi
        End If
    End Sub

    Private Sub RETUR_BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles RETUR_BTN_CLOSE.Click
        Close()

    End Sub

    Private Sub RETUR_BTN_SIMPAN_Click(sender As Object, e As EventArgs) Handles RETUR_BTN_SIMPAN.Click
        VALIDASI_SIMPAN_ROW_AREA_RETUR()

    End Sub

    Private Sub RETUR_BTN_PROSES_Click(sender As Object, e As EventArgs) Handles RETUR_BTN_PROSES.Click
        PUT_UPDATE_BARANG_RETUR()
        POST_BARANG_RETUR()
        GET_AREA_BARANG()

    End Sub


    Private Sub DGV_VIEW_RETUR_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_VIEW_RETUR.CellContentDoubleClick
        Dim HASIL As DialogResult = MessageBox.Show("Mau menghapus data row tabel ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If HASIL = DialogResult.Yes Then
            DGV_VIEW_RETUR.Rows.RemoveAt(DGV_VIEW_RETUR.CurrentRow.Index)
        ElseIf HASIL = DialogResult.No Then
            RETUR_TXT_CARI.Focus()
        End If

    End Sub

    Private Sub btn_minim_tambahstok_Click(sender As Object, e As EventArgs) Handles btn_minim_tambahstok.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
End Class