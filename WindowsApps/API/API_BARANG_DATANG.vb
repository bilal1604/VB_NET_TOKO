Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Module API_BARANG_DATANG
    Public Sub DGV_AREA_VIEW_BARANG_DATANG() ' CUSTOM DATAGRIDVIEW
        Dim judul() As String = {"KODE", "NAMA BARANG ", "INPUT SATUAN", " INPUT PCS ", "TYPE SATUAN", "STOK BARANG ( AWAL QTY)", "TOTAL JUMLAH (PCS)"}
        Dim lebar() As String = {80, 150, 100, 100, 100, 100, 100}

        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.RowHeadersVisible = False
        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.ColumnCount = 7
        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.RowCount = 1
        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.ColumnHeadersHeight = 40
        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan
        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 8, FontStyle.Bold)
        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.SelectionMode = DataGridViewSelectionMode.CellSelect
        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim i As Integer
        For i = 0 To Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.ColumnCount - 1
            Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Columns(i).HeaderText = judul(i)
            Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Columns(i).Width = lebar(i)
            Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Columns(i).DefaultCellStyle.Font = New Font("Times New Roman", 8, FontStyle.Bold)
            Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Columns(i).DefaultCellStyle.BackColor = Color.AntiqueWhite
            Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next


    End Sub

    Public Sub TANGGAL_AREA_BARANG_DATANG()
        Form_Barang_Datang.BARANGDATANG_LABEL_TANGGAL.Text = Date.Now.ToString("yyyy-MM-dd")
    End Sub

    Public Sub CLEAR_AREA_BARANG_DATANG()
        Form_Barang_Datang.BARANGDATANG_LABEL_KODE_BARANG.Text = "-"
        Form_Barang_Datang.BARANGDATANG_LABEL_NAMA_BARANG.Text = "-"
        Form_Barang_Datang.BARANGDATANG_LABEL_HARGA_BARANG.Text = "-"
        Form_Barang_Datang.BARANGDATANG_LABEL_STOK_BARANG.Text = "-"
        Form_Barang_Datang.BARANGDATANG_LABEL_QTY_BARANG.Text = "-"
        Form_Barang_Datang.BARANGDATANG_LABEL_SATUAN_BARANG.Text = "-"

        Form_Barang_Datang.BARANGDATANG_TXT_CARI.Text = ""
        Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_PCS.Text = ""
        Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_SATUAN.Text = ""
        Form_Barang_Datang.BARANGDATANG_TXT_CARI.Focus()


    End Sub

    Public Sub INPUT_KODE_AREA_BARANG_DATANG()
        Dim INPUT As String
        INPUT = InputBox("Masukan Kode Barang Datang :", "INPUT")
        If INPUT = "" Then
            Form_Barang_Datang.Close()
        Else
            Form_Barang_Datang.BARANGDATANG_LABEL_KODE.Text = INPUT
        End If
    End Sub

    Public Sub LIKE_AREA_BARANG_DATANG()
        Try
            Dim url As String = "http://localhost/toko/api/like_master_barang/" + Form_Barang_Datang.BARANGDATANG_TXT_CARI.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist

                Form_Barang_Datang.BARANGDATANG_LABEL_KODE_BARANG.Text = (item("kode_barang").ToString)
                Form_Barang_Datang.BARANGDATANG_LABEL_NAMA_BARANG.Text = (item("nama_barang").ToString)
                Form_Barang_Datang.BARANGDATANG_LABEL_HARGA_BARANG.Text = (item("harga_barang").ToString)
                Form_Barang_Datang.BARANGDATANG_LABEL_STOK_BARANG.Text = (item("stok_barang").ToString)
                Form_Barang_Datang.BARANGDATANG_LABEL_QTY_BARANG.Text = (item("qty_barang").ToString)
                Form_Barang_Datang.BARANGDATANG_LABEL_SATUAN_BARANG.Text = (item("satuan_barang").ToString)


            Next

            If Form_Barang_Datang.BARANGDATANG_LABEL_SATUAN_BARANG.Text = "PCS" Then
                Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_SATUAN.Enabled = False
                Form_Barang_Datang.BARANGDATANG_LABEL_SATUAN_BARANG.Text = "-"
                Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_PCS.Focus()

            Else
                Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_SATUAN.Enabled = True
                Form_Barang_Datang.LABEL_PCS.Visible = True
            End If

            Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_SATUAN.Focus()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub

    Public Sub VALIDASI_SIMPAN_ROW_AREA_BARANG_DATANG()
        If Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_SATUAN.Text = "" Then
            Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_SATUAN.Text = "0"
        ElseIf Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_PCS.Text = "" Then
            Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_PCS.Text = "0"

        End If

        If Form_Barang_Datang.BARANGDATANG_LABEL_SATUAN_BARANG.Text = "-" Then
            Form_Barang_Datang.BARANGDATANG_LABEL_SATUAN_BARANG.Text = "PCS"
        End If

        Dim HITUNG As Integer
        HITUNG = Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_SATUAN.Text * Form_Barang_Datang.BARANGDATANG_LABEL_QTY_BARANG.Text + Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_PCS.Text


        Dim KODE_BARANG As Integer = CInt(Form_Barang_Datang.BARANGDATANG_LABEL_KODE_BARANG.Text) 'INI UNTUK VALIDASI
        Dim JUMLAH_INPUT As Integer = CInt(HITUNG)

        Dim ROWFOND As DataGridViewRow = Nothing
        Dim INDEX As Integer = -1
        For Each ROW As DataGridViewRow In Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows
            If CInt(ROW.Cells(0).Value) = KODE_BARANG Then
                ROWFOND = ROW
                INDEX = ROW.Index
                Exit For
            End If
        Next

        If ROWFOND IsNot Nothing Then
            ROWFOND.Cells(6).Value = CStr(ROWFOND.Cells(61).Value + HITUNG)

        Else
            Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows.Add(New String() {Form_Barang_Datang.BARANGDATANG_LABEL_KODE_BARANG.Text, Form_Barang_Datang.BARANGDATANG_LABEL_NAMA_BARANG.Text, Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_SATUAN.Text, Form_Barang_Datang.BARANGDATANG_TXT_JUMLAH_INPUT_PCS.Text, Form_Barang_Datang.BARANGDATANG_LABEL_SATUAN_BARANG.Text, Form_Barang_Datang.BARANGDATANG_LABEL_STOK_BARANG.Text, HITUNG})
            CLEAR_AREA_BARANG_DATANG()
        End If

    End Sub
    Public Sub POST_CREATE_BARANG_DATANG()


        For row As Integer = 0 To Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows.Count - 2



            Dim url As String = "http://localhost/toko/api/barang_datang_area/" + Form_Barang_Datang.BARANGDATANG_LABEL_KODE.Text + "/" + Form_Barang_Datang.BARANGDATANG_LABEL_TANGGAL.Text + "/" + Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows(row).Cells(0).Value + "/" + Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows(row).Cells(1).Value + "/" + Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows(row).Cells(2).Value + "/" + Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows(row).Cells(3).Value + "/" + Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows(row).Cells(4).Value + "/" + Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows(row).Cells(5).Value + "/" + Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows(row).Cells(6).Value + "/" + Dashbord.LB_NAMA.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
        Next
        MsgBox("Berhasil Proses")
        Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows.Clear()
        CLEAR_AREA_BARANG_DATANG()
        INPUT_KODE_AREA_BARANG_DATANG()
        GET_AREA_BARANG()



    End Sub



    Public Sub PUT_UPDATE_BARANG_DATANG()

        Dim HITUNG As Integer

        For row As Integer = 0 To Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows.Count - 2

            HITUNG = Val(Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows(row).Cells(5).Value) + Val(Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows(row).Cells(6).Value)


            Dim url As String = "http://localhost/toko/api/update_stok_barang/" + Form_Barang_Datang.DGV_VIEW_BARANG_DATANG.Rows(row).Cells(0).Value + "/" + CStr(HITUNG)
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "PUT"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
        Next




    End Sub


End Module
