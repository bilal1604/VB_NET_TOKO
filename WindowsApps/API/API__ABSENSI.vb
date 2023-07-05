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

End Module
