Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Module barang_area
    Public Sub DGV_AREA_BARANG() ' CUSTOM DATAGRIDVIEW
        Dim judul() As String = {"KODE BARANG", "NAMA BARANG", "HARGA BARANG", " STOK BARANG", "QTY BARANG", "SATUAN BARANG"}
        Dim lebar() As String = {150, 200, 120, 120, 120, 120}

        Dashbord.DGV_BARANG_AREA.RowHeadersVisible = False
        Dashbord.DGV_BARANG_AREA.ColumnCount = 6
        Dashbord.DGV_BARANG_AREA.RowCount = 1
        Dashbord.DGV_BARANG_AREA.ColumnHeadersHeight = 45
        Dashbord.DGV_BARANG_AREA.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Dashbord.DGV_BARANG_AREA.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan
        Dashbord.DGV_BARANG_AREA.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Dashbord.DGV_BARANG_AREA.ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        Dashbord.DGV_BARANG_AREA.SelectionMode = DataGridViewSelectionMode.CellSelect
        Dashbord.DGV_BARANG_AREA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim i As Integer
        For i = 0 To Dashbord.DGV_BARANG_AREA.ColumnCount - 1
            Dashbord.DGV_BARANG_AREA.Columns(i).HeaderText = judul(i)
            Dashbord.DGV_BARANG_AREA.Columns(i).Width = lebar(i)
            Dashbord.DGV_BARANG_AREA.Columns(i).DefaultCellStyle.Font = New Font("Times New Roman", 8, FontStyle.Bold)
            Dashbord.DGV_BARANG_AREA.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next


    End Sub
    Public Sub KODE_OTOMATIS_AREA_BARANG() 'KODE OTOMATIS PADA USER AREA
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
        Dashbord.txt_kode_barang.Text = Date.Now.ToString("yyyy") + hasil + detik


        'dd -> hari
        'yyyy -> tahun
        'MM -> bulan
        'HH -> 24jam 'hh -> 12 jam
        'mm -> menit
        'ss -> detik

    End Sub

    Public Sub CLEAR_AREA_BARANG()
        Dashbord.txt_kode_barang.Text = ""
        Dashbord.txt_nama_barang.Text = ""
        Dashbord.txt_harga_barang.Text = ""
        Dashbord.txt_stok_barang.Text = ""
        Dashbord.txt_QTY.Text = ""
        Dashbord.txt_cari_barang.Text = ""
        Dashbord.COMBO_satuan_barang.Text = ""
        Dashbord.COMBO_satuan_barang.Items.Clear()
        Dashbord.txt_QTY.Focus()


        GET_AREA_BARANG()
        KODE_OTOMATIS_AREA_BARANG()
        GET_COMBO_AREA_BARANG()


    End Sub

    Public Sub GET_AREA_BARANG() 'GET DATA USER AREA
        Dashbord.DGV_BARANG_AREA.Rows.Clear()
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
                Dashbord.DGV_BARANG_AREA.Rows.Add(item("kode_barang").ToString, item("nama_barang").ToString, item("harga_barang").ToString, item("stok_barang").ToString, item("qty_barang").ToString, item("satuan_barang").ToString)

            Next


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub
    Public Sub POST_AREA_BARANG()

        Try
            Dim url As String = "http://localhost/toko/api/barang_area/" + Dashbord.txt_kode_barang.Text + "/" + Dashbord.txt_nama_barang.Text + "/" + Dashbord.txt_harga_barang.Text + "/" + Dashbord.txt_stok_barang.Text + "/" + Dashbord.txt_QTY.Text + "/" + Dashbord.COMBO_satuan_barang.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("BERHASIL CREATE DATA", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLEAR_AREA_BARANG()
            KODE_OTOMATIS_AREA_BARANG()

        Catch ex As Exception
            MessageBox.Show("Harap tidak mengunakan symbol pada keybord !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
    End Sub


    Public Sub PUT_AREA_BARANG() 'PUT DATA BARANG AREA

        Try
            Dim url As String = "http://localhost/toko/api/barang_area/" + Dashbord.txt_kode_barang.Text + "/" + Dashbord.txt_nama_barang.Text + "/" + Dashbord.txt_harga_barang.Text + "/" + Dashbord.txt_stok_barang.Text + "/" + Dashbord.txt_QTY.Text + "/" + Dashbord.COMBO_satuan_barang.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "PUT"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("BERHASIL UPDATE DATA", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLEAR_AREA_BARANG()
            KODE_OTOMATIS_AREA_BARANG()

        Catch ex As Exception
            MessageBox.Show("Harap tidak mengunakan symbol pada keybord !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End Try
    End Sub

    Public Sub DELETE_AREA_BARANG()

        Try
            Dim url As String = "http://localhost/toko/api/barang_area/" + Dashbord.txt_kode_barang.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "DELETE"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("BERHASIL DELETE DATA", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLEAR_AREA_BARANG()
            KODE_OTOMATIS_AREA_BARANG()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub

    Public Sub LIKE_AREA_BARANG()
        Dashbord.DGV_BARANG_AREA.Rows.Clear()
        Try
            Dim url As String = "http://localhost/toko/api/like_master_barang/" + Dashbord.txt_cari_barang.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist

                Dashbord.DGV_BARANG_AREA.Rows.Add(item("kode_barang").ToString, item("nama_barang").ToString, item("harga_barang").ToString, item("stok_barang").ToString, item("qty_barang").ToString, item("satuan_barang").ToString)

            Next


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub


    Public Sub GET_COMBO_AREA_BARANG() 'GET DATA COMBO USER AREA
        Dashbord.COMBO_satuan_barang.Items.Clear()

        Try
            Dim url As String = "http://localhost/toko/api/distinct_combo_masterbarang"
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist

                Dashbord.COMBO_satuan_barang.Items.Add(item("satuan_barang").ToString)

            Next


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub

    Public Sub CREATE_VALIDASI()

        If Dashbord.txt_kode_barang.Text = "" Then
            MessageBox.Show("Harap isi field kode barang !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_BARANG()
        ElseIf Dashbord.txt_QTY.Text = "" Then
            MessageBox.Show("Harap isi field qty barang !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_BARANG()
        ElseIf Dashbord.txt_nama_barang.Text = "" Then
            MessageBox.Show("Harap isi field nama barang !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_BARANG()
        ElseIf Dashbord.txt_harga_barang.Text = "" Then
            MessageBox.Show("Harap isi field harga barang !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_BARANG()
        ElseIf Dashbord.txt_stok_barang.Text = "" Then
            MessageBox.Show("Harap isi field stok barang !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_BARANG()
        ElseIf Dashbord.COMBO_satuan_barang.Text = "" Then
            MessageBox.Show("Harap isi field combo barang !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_BARANG()
        Else
            POST_AREA_BARANG()

        End If
    End Sub

    Public Sub CREATE_API_MASTER_BARANG()

        Try
            Dim url As String = "http://localhost/toko/api/validasi_kodebarang_area/" + Dashbord.txt_kode_barang.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd

            If return_api = "TRUE" Then
                MessageBox.Show("KODE BARANG SUDAH ADA !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MessageBox.Show("KODE AKAN OTOMATIS TERISI KEMBALI", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CLEAR_AREA_BARANG()

            ElseIf return_api = "FALSE" Then
                CREATE_VALIDASI()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try

    End Sub



End Module
