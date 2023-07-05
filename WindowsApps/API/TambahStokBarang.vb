Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Module TambahStokBarang
    Public Sub DGV_AREA_TAMBAH_STOK_BARANG() ' CUSTOM DATAGRIDVIEW
        Dim judul() As String = {"KODE", "NAMA", " STOK", "QTY", "SATUAN "}
        Dim lebar() As String = {50, 100, 50, 50, 80}

        Form_TambahStok.DGV_TAMBAH_STOK.RowHeadersVisible = False
        Form_TambahStok.DGV_TAMBAH_STOK.ColumnCount = 5
        Form_TambahStok.DGV_TAMBAH_STOK.RowCount = 1
        Form_TambahStok.DGV_TAMBAH_STOK.ColumnHeadersHeight = 45
        Form_TambahStok.DGV_TAMBAH_STOK.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Form_TambahStok.DGV_TAMBAH_STOK.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan
        Form_TambahStok.DGV_TAMBAH_STOK.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Form_TambahStok.DGV_TAMBAH_STOK.ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 8, FontStyle.Bold)
        Form_TambahStok.DGV_TAMBAH_STOK.SelectionMode = DataGridViewSelectionMode.CellSelect
        Form_TambahStok.DGV_TAMBAH_STOK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim i As Integer
        For i = 0 To Form_TambahStok.DGV_TAMBAH_STOK.ColumnCount - 1
            Form_TambahStok.DGV_TAMBAH_STOK.Columns(i).HeaderText = judul(i)
            Form_TambahStok.DGV_TAMBAH_STOK.Columns(i).Width = lebar(i)
            Form_TambahStok.DGV_TAMBAH_STOK.Columns(i).DefaultCellStyle.Font = New Font("Times New Roman", 8, FontStyle.Bold)
            Form_TambahStok.DGV_TAMBAH_STOK.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next


    End Sub

    Public Sub GET_AREA_TAMBAH_STOK_BARANG() 'GET DATA USER AREA
        Form_TambahStok.DGV_TAMBAH_STOK.Rows.Clear()
        Try
            Dim url As String = "http://localhost/toko/api/barang_area/"
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist
                Form_TambahStok.DGV_TAMBAH_STOK.Rows.Add(item("kode_barang").ToString, item("nama_barang").ToString, item("stok_barang").ToString, item("qty_barang").ToString, item("satuan_barang").ToString)

            Next


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub



    Public Sub STOK_TAMBAH_BARANG_API_TES()

        Dim HITUNG As Integer
        Dim HASIL As String

        If Form_TambahStok.txt_pcs_tambahbarang.Text = "" Then
            Form_TambahStok.txt_pcs_tambahbarang.Text = "0"
            HITUNG = Form_TambahStok.Label_qty_tambahstok.Text * Form_TambahStok.txt_stok_tambahbarang.Text + Form_TambahStok.txt_pcs_tambahbarang.Text
            HASIL = Form_TambahStok.Label_stok_tambahstok.Text + HITUNG
        Else
            HITUNG = Form_TambahStok.Label_qty_tambahstok.Text * Form_TambahStok.txt_stok_tambahbarang.Text + Form_TambahStok.txt_pcs_tambahbarang.Text
            HASIL = Form_TambahStok.Label_stok_tambahstok.Text + HITUNG

        End If


        Try
            Dim url As String = "http://localhost/toko/api/update_stok_barang/" + Form_TambahStok.Label_kode_tambahstok.Text + "/" + HASIL
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "PUT"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("BERHASIL TAMBAH STOK DATA", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form_TambahStok.txt_stok_tambahbarang.Text = ""
            Form_TambahStok.txt_pcs_tambahbarang.Text = ""
        Catch ex As Exception
            MessageBox.Show("Harap tidak mengunakan symbol pada keybord !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try



    End Sub

    Public Sub LIKE_AREA_TAMBAH_SATOK_BARANG()
        Form_TambahStok.DGV_TAMBAH_STOK.Rows.Clear()
        Try
            Dim url As String = "http://localhost/toko/api/like_master_barang/" + Form_TambahStok.txt_cari_tambahstok.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist

                Form_TambahStok.DGV_TAMBAH_STOK.Rows.Add(item("kode_barang").ToString, item("nama_barang").ToString, item("stok_barang").ToString, item("qty_barang").ToString, item("satuan_barang").ToString)

            Next


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub


End Module
