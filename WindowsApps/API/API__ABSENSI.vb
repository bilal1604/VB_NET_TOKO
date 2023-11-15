Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization

Module API__ABSENSI
    Public Sub DGV_AREA_VIEW_ABSENSI() ' CUSTOM DATAGRIDVIEW
        Dim judul() As String = {"USER", "NAMA  ", "TANGGAL", "JAM", "SHIFT", "KETERANGAN"}
        Dim lebar() As String = {80, 150, 100, 100, 100, 100}

        Form_Absensi.DGV_VIEW_ABSENSI.RowHeadersVisible = False
        Form_Absensi.DGV_VIEW_ABSENSI.ColumnCount = 6
        Form_Absensi.DGV_VIEW_ABSENSI.RowCount = 1
        Form_Absensi.DGV_VIEW_ABSENSI.ColumnHeadersHeight = 40
        Form_Absensi.DGV_VIEW_ABSENSI.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Form_Absensi.DGV_VIEW_ABSENSI.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan
        Form_Absensi.DGV_VIEW_ABSENSI.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Form_Absensi.DGV_VIEW_ABSENSI.ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 8, FontStyle.Bold)
        Form_Absensi.DGV_VIEW_ABSENSI.SelectionMode = DataGridViewSelectionMode.CellSelect
        Form_Absensi.DGV_VIEW_ABSENSI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim i As Integer
        For i = 0 To Form_Absensi.DGV_VIEW_ABSENSI.ColumnCount - 1
            Form_Absensi.DGV_VIEW_ABSENSI.Columns(i).HeaderText = judul(i)
            Form_Absensi.DGV_VIEW_ABSENSI.Columns(i).Width = lebar(i)
            Form_Absensi.DGV_VIEW_ABSENSI.Columns(i).DefaultCellStyle.Font = New Font("Times New Roman", 8, FontStyle.Bold)
            Form_Absensi.DGV_VIEW_ABSENSI.Columns(i).DefaultCellStyle.BackColor = Color.AntiqueWhite
            Form_Absensi.DGV_VIEW_ABSENSI.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next
        GET_API_ABSENSI_ID()



    End Sub
    Public Sub API_CLEAR_ABSENSI()
        Form_Absensi.ABSENSI_LABEL_USERNAME.Text = "-"
        Form_Absensi.ABSENSI_LABEL_NAMA_KARYAWAN.Text = "-"
        Form_Absensi.ABSENSI_LABEL_CLASS.Text = "-"
        Form_Absensi.ABSENSI_LABEL_STATUS.Text = "-"

    End Sub

    Public Sub API_ABSENSI_CARI()

        Try
            Dim url As String = "http://localhost/toko/api/user/" + Form_Absensi.ABSENSI_TXT_CARI.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist

                Form_Absensi.ABSENSI_LABEL_USERNAME.Text = (item("username").ToString)
                Form_Absensi.ABSENSI_LABEL_NAMA_KARYAWAN.Text = (item("nama").ToString)
                Form_Absensi.ABSENSI_LABEL_CLASS.Text = (item("class").ToString)
                Form_Absensi.ABSENSI_LABEL_STATUS.Text = (item("status").ToString)



            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub

    Public Sub POST_API_ABSENSI_HADIR()

        Dim validasi_waktu As String
        Dim validasi_shift As String

        validasi_waktu = Date.Now.ToString("HH")

        Dim waktu As Integer = Integer.Parse(validasi_waktu)


        If waktu >= 0 And waktu <= 7 Then
            validasi_waktu = "Hadir Tepat Waktu"
            validasi_shift = "Shift Satu"

        ElseIf waktu >= 8 And waktu <= 12 Then
            validasi_waktu = "Datang Terlambat"
            validasi_shift = "Shift Satu"

        ElseIf waktu >= 13 And waktu <= 14 Then
            validasi_waktu = "Hadir Tepat Waktu"
            validasi_shift = "Shift Dua"

        ElseIf waktu >= 15 And waktu <= 23 Then
            validasi_waktu = "Datang Terlambat"
            validasi_shift = "Shift Dua"

        End If

        Dim url As String = "http://localhost/toko/api/absensi/" + Form_Absensi.ABSENSI_LABEL_USERNAME.Text + "/" + Form_Absensi.ABSENSI_LABEL_NAMA_KARYAWAN.Text + "/" + Form_Absensi.ABSENSI_LABEL_CLASS.Text + "/" + Form_Absensi.ABSENSI_LABEL_STATUS.Text + "/" + Date.Now.ToString("yyyy-MM-dd") + "/" + Date.Now.ToString("HH:mm:ss") + "/" + validasi_shift + "/" + validasi_waktu.ToString
        Dim uri As New Uri(url)
        Dim request As HttpWebRequest = HttpWebRequest.Create(url)
        request.Method = "POST"
        Dim response As HttpWebResponse = request.GetResponse
        Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
        Dim return_api As String = reader.ReadToEnd
        MessageBox.Show("BERHASIL CREATE DATA", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form_Absensi.ABSENSI_TXT_CARI.Text = ""
        Form_Absensi.ABSENSI_TXT_CARI.Focus()
        Form_Absensi.ABSENSI_BTN_ABSENSI_PULANG.Enabled = False
        GET_API_ABSENSI_ID()

    End Sub

    Public Sub POST_API_ABSENSI_PULANG()

        Dim validasi_waktu As String
        Dim validasi_shift As String

        validasi_waktu = Date.Now.ToString("HH")

        Dim waktu As Integer = Integer.Parse(validasi_waktu)


        If waktu >= 0 And waktu <= 7 Then
            MessageBox.Show("Absensi Pulang Tidak Valid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form_Absensi.ABSENSI_TXT_CARI.Focus()

        ElseIf waktu >= 8 And waktu <= 12 Then
            MessageBox.Show("Absensi Pulang Tidak Valid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form_Absensi.ABSENSI_TXT_CARI.Focus()

        ElseIf waktu >= 14 And waktu <= 19 Then
            validasi_waktu = "Pulang Tepat Waktu"
            validasi_shift = "Shift Satu"

            Dim url As String = "http://localhost/toko/api/absensi/" + Form_Absensi.ABSENSI_LABEL_USERNAME.Text + "/" + Form_Absensi.ABSENSI_LABEL_NAMA_KARYAWAN.Text + "/" + Form_Absensi.ABSENSI_LABEL_CLASS.Text + "/" + Form_Absensi.ABSENSI_LABEL_STATUS.Text + "/" + Date.Now.ToString("yyyy-MM-dd") + "/" + Date.Now.ToString("HH:mm:ss") + "/" + validasi_shift + "/" + validasi_waktu.ToString
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("ABSENSI PULANG BERHASIL", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form_Absensi.ABSENSI_TXT_CARI.Text = ""
            Form_Absensi.ABSENSI_TXT_CARI.Focus()
            Form_Absensi.ABSENSI_BTN_ABSENSI_PULANG.Enabled = True
            Form_Absensi.ABSENSI_BTN_HADIR.Enabled = True


        ElseIf waktu >= 20 And waktu <= 23 Then
            validasi_waktu = "Pulang Tepat Waktu"
            validasi_shift = "Shift Dua"

            Dim url As String = "http://localhost/toko/api/absensi/" + Form_Absensi.ABSENSI_LABEL_USERNAME.Text + "/" + Form_Absensi.ABSENSI_LABEL_NAMA_KARYAWAN.Text + "/" + Form_Absensi.ABSENSI_LABEL_CLASS.Text + "/" + Form_Absensi.ABSENSI_LABEL_STATUS.Text + "/" + Date.Now.ToString("yyyy-MM-dd") + "/" + Date.Now.ToString("HH:mm:ss") + "/" + validasi_shift + "/" + validasi_waktu.ToString
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("ABSENSI PULANG BERHASIL", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form_Absensi.ABSENSI_TXT_CARI.Text = ""
            Form_Absensi.ABSENSI_TXT_CARI.Focus()
            Form_Absensi.ABSENSI_BTN_ABSENSI_PULANG.Enabled = True
            Form_Absensi.ABSENSI_BTN_HADIR.Enabled = True



        End If

        GET_API_ABSENSI_ID()


    End Sub


    Public Sub GET_API_ABSENSI_ID()
        Form_Absensi.DGV_VIEW_ABSENSI.Rows.Clear()
        Try
            Dim url As String = "http://localhost/toko/api/Absensi_get_by_id/" + Date.Now.ToString("yyyy-MM-dd")
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist
                Form_Absensi.DGV_VIEW_ABSENSI.Rows.Add(item("username").ToString, item("nama_karyawan").ToString, item("tanggal").ToString, item("jam").ToString, item("shift").ToString, item("keterangan").ToString)
            Next


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor ")

        End Try
    End Sub


    Public Sub VALIDASI_ABSENSI_HADIR()

        Dim input As String
        input = InputBox("Masukan Kata sandi Anda : ", "input")
        If input = "" Then
            MessageBox.Show("KATA SANDI TIDAK BOLEH KOSONG !", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Try
                Dim url As String = "http://localhost/toko/api/validasi_password_absensi/" + Form_Absensi.ABSENSI_LABEL_USERNAME.Text + "/" + input
                Dim uri As New Uri(url)
                Dim request As HttpWebRequest = HttpWebRequest.Create(url)
                request.Method = "POST"
                Dim response As HttpWebResponse = request.GetResponse
                Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
                Dim return_api As String = reader.ReadToEnd

                If return_api = "TRUE" Then
                    POST_API_ABSENSI_HADIR()
                    API_CLEAR_ABSENSI()


                ElseIf return_api = "FALSE" Then
                    MessageBox.Show("KATA SANDI SALAH", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    VALIDASI_ABSENSI_HADIR()

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi ERORRR Validasi Hadir")

            End Try


        End If


    End Sub

    Public Sub VALIDASI_ABSENSI_PULANG()

        Dim input As String
        input = InputBox("Masukan Kata sandi Anda : ", "input")
        If input = "" Then
            MessageBox.Show("KATA SANDI TIDAK BOLEH KOSONG !", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Try
                Dim url As String = "http://localhost/toko/api/validasi_password_absensi/" + Form_Absensi.ABSENSI_LABEL_USERNAME.Text + "/" + input
                Dim uri As New Uri(url)
                Dim request As HttpWebRequest = HttpWebRequest.Create(url)
                request.Method = "POST"
                Dim response As HttpWebResponse = request.GetResponse
                Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
                Dim return_api As String = reader.ReadToEnd

                If return_api = "TRUE" Then
                    VALIDASI_ABSENSI_ROW_PULANG()


                ElseIf return_api = "FALSE" Then
                    MessageBox.Show("KATA SANDI SALAH", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    VALIDASI_ABSENSI_PULANG()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi EROORR Validasi Pulang")

            End Try

        End If


    End Sub


    Public Sub VALIDASI_ABSENSI_ROW()
        Dim KODE_BARANG As Integer = CInt(Form_Absensi.ABSENSI_LABEL_USERNAME.Text) 'INI UNTUK VALIDASI

        Dim ROWFOND As DataGridViewRow = Nothing
        Dim INDEX As Integer = -1
        For Each ROW As DataGridViewRow In Form_Absensi.DGV_VIEW_ABSENSI.Rows
            If CInt(ROW.Cells(0).Value) = KODE_BARANG Then
                ROWFOND = ROW
                INDEX = ROW.Index
                Exit For
            End If
        Next

        If ROWFOND IsNot Nothing Then
            Form_Absensi.ABSENSI_BTN_HADIR.Enabled = False
            Form_Absensi.ABSENSI_BTN_ABSENSI_PULANG.Enabled = True

            MessageBox.Show("DATA KEHADIRAN SUDAH ADA ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("KLIK BUTTON PULANG MELANJUTKAN .. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form_Absensi.ABSENSI_TXT_CARI.Focus()


        Else
            Form_Absensi.ABSENSI_BTN_HADIR.Enabled = True
            Form_Absensi.ABSENSI_BTN_ABSENSI_PULANG.Enabled = False

        End If

    End Sub



    Public Sub VALIDASI_ABSENSI_ROW_PULANG()
        Dim KODE_BARANG As Integer = CInt(Form_Absensi.ABSENSI_LABEL_USERNAME.Text) 'INI UNTUK VALIDASI

        Dim ROWFOND As DataGridViewRow = Nothing
        Dim INDEX As Integer = -1
        For Each ROW As DataGridViewRow In Form_Absensi.DGV_VIEW_ABSENSI.Rows
            If CInt(ROW.Cells(0).Value) = KODE_BARANG Then
                ROWFOND = ROW
                INDEX = ROW.Index
                Exit For
            End If
        Next

        If ROWFOND IsNot Nothing Then
            Form_Absensi.ABSENSI_BTN_ABSENSI_PULANG.Enabled = False

            MessageBox.Show("DATA PULANG SUDAH ADA ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form_Absensi.ABSENSI_TXT_CARI.Focus()


        Else

            POST_API_ABSENSI_PULANG()
            Form_Absensi.ABSENSI_BTN_HADIR.Enabled = True
            Form_Absensi.ABSENSI_BTN_ABSENSI_PULANG.Enabled = False
            Form_Absensi.ABSENSI_TXT_CARI.Focus()

        End If

    End Sub


End Module
