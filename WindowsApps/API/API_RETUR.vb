Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Module API_RETUR
    Public Sub DGV_AREA_VIEW_RETUR() ' CUSTOM DATAGRIDVIEW
        Dim judul() As String = {"KODE", "NAMA ", "HARGA ", " STOK ", "JUMLAH RETUR"}
        Dim lebar() As String = {80, 150, 120, 120, 120}

        Form_Retur.DGV_VIEW_RETUR.RowHeadersVisible = False
        Form_Retur.DGV_VIEW_RETUR.ColumnCount = 5
        Form_Retur.DGV_VIEW_RETUR.RowCount = 1
        Form_Retur.DGV_VIEW_RETUR.ColumnHeadersHeight = 45
        Form_Retur.DGV_VIEW_RETUR.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Form_Retur.DGV_VIEW_RETUR.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan
        Form_Retur.DGV_VIEW_RETUR.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Form_Retur.DGV_VIEW_RETUR.ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        Form_Retur.DGV_VIEW_RETUR.SelectionMode = DataGridViewSelectionMode.CellSelect
        Form_Retur.DGV_VIEW_RETUR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim i As Integer
        For i = 0 To Form_Retur.DGV_VIEW_RETUR.ColumnCount - 1
            Form_Retur.DGV_VIEW_RETUR.Columns(i).HeaderText = judul(i)
            Form_Retur.DGV_VIEW_RETUR.Columns(i).Width = lebar(i)
            Form_Retur.DGV_VIEW_RETUR.Columns(i).DefaultCellStyle.Font = New Font("Times New Roman", 8, FontStyle.Bold)
            Form_Retur.DGV_VIEW_RETUR.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next


    End Sub

    Public Sub KODE_OTOMATIS_AREA_RETUR()
        Dim jam As String
        Dim menit As String
        Dim detik As String

        Dim tanggal As String
        Dim bulan As String
        Dim tahun As String

        jam = Date.Now.ToString("HH")
        menit = Date.Now.ToString("mm")
        detik = Date.Now.ToString("ss")

        tanggal = Date.Now.ToString("dd")
        bulan = Date.Now.ToString("MM")
        tahun = Date.Now.ToString("yy")

        Dim hasil As String

        hasil = jam * 24 + menit * 60 + detik * 60 + tanggal * 31 + bulan * 12 + tahun * 12 / 2
        Form_Retur.RETUR_LABEL_KODE_RETUR.Text = "FR-" + Date.Now.ToString("yy") + hasil



    End Sub

    Public Sub TANGGAL_AREA_RETUR()
        Form_Retur.RETUR_TANGGAL_RETUR.Text = Date.Now.ToString("yyyy-MM-dd")
    End Sub

    Public Sub CLEAR_AREA_RETUR()
        Form_Retur.RETUR_TXT_CARI.Text = ""
        Form_Retur.RETUR_TXT_JUMLAH_RETUR.Text = ""
        Form_Retur.RETUR_LABEL_KODE_BARANG.Text = "-"
        Form_Retur.RETUR_LABEL_NAMA_BARANG.Text = "-"
        Form_Retur.RETUR_LABEL_HARGA_BARANG.Text = "-"
        Form_Retur.RETUR_LABEL_STOK_BARANG.Text = "-"
        KODE_OTOMATIS_AREA_RETUR()
        Form_Retur.RETUR_TXT_CARI.Focus()


    End Sub

    Public Sub LIKE_AREA_RETUR()
        Try
            Dim url As String = "http://localhost/toko/api/like_master_barang/" + Form_Retur.RETUR_TXT_CARI.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist

                Form_Retur.RETUR_LABEL_KODE_BARANG.Text = (item("kode_barang").ToString)
                Form_Retur.RETUR_LABEL_NAMA_BARANG.Text = (item("nama_barang").ToString)
                Form_Retur.RETUR_LABEL_HARGA_BARANG.Text = (item("harga_barang").ToString)
                Form_Retur.RETUR_LABEL_STOK_BARANG.Text = (item("stok_barang").ToString)

            Next
            Form_Retur.RETUR_TXT_JUMLAH_RETUR.Focus()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub

    Public Sub VALIDASI_SIMPAN_ROW_AREA_RETUR()
        Dim HITUNG As Integer
        HITUNG = Form_Retur.RETUR_LABEL_STOK_BARANG.Text - Form_Retur.RETUR_TXT_JUMLAH_RETUR.Text

        If HITUNG <= "-1" Then
            MessageBox.Show("DATA SUDAH KOSONG", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLEAR_AREA_RETUR()
        Else
            Dim KODE_BARANG As Integer = CInt(Form_Retur.RETUR_LABEL_KODE_BARANG.Text) 'INI UNTUK VALIDASI
            Dim JUMLAH_RETUR As Integer = CInt(Form_Retur.RETUR_TXT_JUMLAH_RETUR.Text) 'INI TEXTBOX JUMLAH RETUR

            Dim ROWFOND As DataGridViewRow = Nothing
            Dim INDEX As Integer = -1
            For Each ROW As DataGridViewRow In Form_Retur.DGV_VIEW_RETUR.Rows
                If CInt(ROW.Cells(0).Value) = KODE_BARANG Then
                    ROWFOND = ROW
                    INDEX = ROW.Index
                    Exit For
                End If
            Next

            If ROWFOND IsNot Nothing Then
                ROWFOND.Cells(4).Value = CStr(ROWFOND.Cells(4).Value + JUMLAH_RETUR)

            Else
                Form_Retur.DGV_VIEW_RETUR.Rows.Add(New String() {Form_Retur.RETUR_LABEL_KODE_BARANG.Text, Form_Retur.RETUR_LABEL_NAMA_BARANG.Text, Form_Retur.RETUR_LABEL_HARGA_BARANG.Text, Form_Retur.RETUR_LABEL_STOK_BARANG.Text, Form_Retur.RETUR_TXT_JUMLAH_RETUR.Text})
                CLEAR_AREA_RETUR()

            End If

        End If
    End Sub

    Public Sub PUT_UPDATE_BARANG_RETUR()

        Dim HITUNG As Integer
        Dim HASIL As String

        For row As Integer = 0 To Form_Retur.DGV_VIEW_RETUR.Rows.Count - 2

            HITUNG = Form_Retur.DGV_VIEW_RETUR.Rows(row).Cells(3).Value - Form_Retur.DGV_VIEW_RETUR.Rows(row).Cells(4).Value
            HASIL = HITUNG

            Dim url As String = "http://localhost/toko/api/update_stok_barang/" + Form_Retur.DGV_VIEW_RETUR.Rows(row).Cells(0).Value + "/" + HASIL
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "PUT"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
        Next

    End Sub

    Public Sub POST_BARANG_RETUR()



        For row As Integer = 0 To Form_Retur.DGV_VIEW_RETUR.Rows.Count - 2


            Dim url As String = "http://localhost/toko/api/barang_area_retur/" + Form_Retur.RETUR_LABEL_KODE_RETUR.Text + "/" + Form_Retur.RETUR_LABEL_USERNAME.Text + "/" + Form_Retur.RETUR_TANGGAL_RETUR.Text + "/" + Form_Retur.DGV_VIEW_RETUR.Rows(row).Cells(0).Value + "/" + Form_Retur.DGV_VIEW_RETUR.Rows(row).Cells(1).Value + "/" + Form_Retur.DGV_VIEW_RETUR.Rows(row).Cells(2).Value + "/" + Form_Retur.DGV_VIEW_RETUR.Rows(row).Cells(3).Value + "/" + Form_Retur.DGV_VIEW_RETUR.Rows(row).Cells(4).Value
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
        Next
        MessageBox.Show("BERHASIL RETUR DATA", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        CLEAR_AREA_RETUR()
        Form_Retur.DGV_VIEW_RETUR.Rows.Clear()


    End Sub
End Module
