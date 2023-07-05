Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization


Module user_area
    Public Sub GET_AREA_USER() 'GET DATA USER AREA
        Dashbord.DGV_USER_AREA.Rows.Clear()
        Try
            Dim url As String = "http://localhost/toko/api/user_area/"
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist
                Dashbord.DGV_USER_AREA.Rows.Add(item("username").ToString, item("password").ToString, item("nama").ToString, item("class").ToString, item("status").ToString)

            Next
            KODE_OTOMATIS_AREA_USER()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub


    Public Sub GET_COMBO_AREA_USER_CLASS() 'GET DATA COMBO USER AREA
        Dashbord.COMBO_class_user_area.Items.Clear()

        Try
            Dim url As String = "http://localhost/toko/api/distinct_combo_master_user_class/"
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist

                Dashbord.COMBO_class_user_area.Items.Add(item("class").ToString)

            Next


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub


    Public Sub GET_COMBO_AREA_USER_STATUS() 'GET DATA COMBO USER AREA
        Dashbord.COMBO_status_user_area.Items.Clear()

        Try
            Dim url As String = "http://localhost/toko/api/distinct_combo_master_user_status/"
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist

                Dashbord.COMBO_status_user_area.Items.Add(item("status").ToString)

            Next


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub
    Public Sub POST_AREA_USER() 'POST DATA USER AREA

        Try
            Dim url As String = "http://localhost/toko/api/user_area/" + Dashbord.txt_username_user_area.Text + "/" + Dashbord.txt_password_user_area.Text + "/" + Dashbord.txt_nama_user_area.Text + "/" + Dashbord.COMBO_status_user_area.Text + "/" + Dashbord.COMBO_class_user_area.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("BERHASIL INPUT DATA", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLEAR_AREA_USER()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub

    Public Sub PUT_AREA_USER() 'PUT DATA USER AREA

        Try

            Dim url As String = "http://localhost/toko/api/user_area/" + Dashbord.txt_username_user_area.Text + "/" + Dashbord.txt_password_user_area.Text + "/" + Dashbord.txt_nama_user_area.Text + "/" + Dashbord.COMBO_status_user_area.Text + "/" + Dashbord.COMBO_class_user_area.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "PUT"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("BERHASIL UPDATE DATA", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLEAR_AREA_USER()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub

    Public Sub DELETE_AREA_USER() 'PUT DATA USER AREA

        Try
            Dim url As String = "http://localhost/toko/api/user_area/" + Dashbord.txt_username_user_area.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "DELETE"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            MessageBox.Show("BERHASIL DELETE DATA", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CLEAR_AREA_USER()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub

    Public Sub CLEAR_AREA_USER()
        Dashbord.txt_nama_user_area.Text = ""
        Dashbord.txt_username_user_area.Text = ""
        Dashbord.txt_password_user_area.Text = ""
        Dashbord.COMBO_class_user_area.Text = ""
        Dashbord.COMBO_status_user_area.Text = ""
        Dashbord.COMBO_class_user_area.Items.Clear()
        Dashbord.COMBO_status_user_area.Items.Clear()
        Dashbord.txt_nama_user_area.Focus()

        GET_COMBO_AREA_USER_CLASS()
        GET_COMBO_AREA_USER_STATUS()
        GET_AREA_USER()
        KODE_OTOMATIS_AREA_USER()


    End Sub


    Public Sub VALIDASI_USERNAME_AREA()

        Try

            Dim url As String = "http://localhost/toko/api/validasi_user_area/" + Dashbord.txt_username_user_area.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd

            If return_api = "TRUE" Then
                MessageBox.Show("DATA USERNAME SUDAH ADA !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                MessageBox.Show("KLIK OK MAKA KODE OTOMATIS AKAN TERGANTI", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CLEAR_AREA_USER()
                KODE_OTOMATIS_AREA_USER()

            ElseIf return_api = "FALSE" Then
                POST_AREA_USER()
                CLEAR_AREA_USER()


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try

    End Sub
    Public Sub DGV_AREA_USER() ' CUSTOM DATAGRIDVIEW
        Dim judul() As String = {"USERNAME", "PASSWORD", "NAMA", "CLASS", "STATUS"}
        Dim lebar() As String = {150, 150, 200, 120, 120}

        Dashbord.DGV_USER_AREA.RowHeadersVisible = False
        Dashbord.DGV_USER_AREA.ColumnCount = 5
        Dashbord.DGV_USER_AREA.RowCount = 1
        Dashbord.DGV_USER_AREA.ColumnHeadersHeight = 30
        Dashbord.DGV_USER_AREA.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Dashbord.DGV_USER_AREA.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan
        Dashbord.DGV_USER_AREA.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Dashbord.DGV_USER_AREA.ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        Dashbord.DGV_USER_AREA.SelectionMode = DataGridViewSelectionMode.CellSelect
        Dashbord.DGV_USER_AREA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim i As Integer
        For i = 0 To Dashbord.DGV_USER_AREA.ColumnCount - 1
            Dashbord.DGV_USER_AREA.Columns(i).HeaderText = judul(i)
            Dashbord.DGV_USER_AREA.Columns(i).Width = lebar(i)
            Dashbord.DGV_USER_AREA.Columns(i).DefaultCellStyle.Font = New Font("Times New Roman", 8, FontStyle.Bold)
            Dashbord.DGV_USER_AREA.Columns(i).DefaultCellStyle.BackColor = Color.AliceBlue
        Next


    End Sub

    Public Sub KODE_OTOMATIS_AREA_USER() 'KODE OTOMATIS PADA USER AREA

        Dashbord.txt_username_user_area.Text = Date.Now.ToString("yyyymmhhss")

        'dd -> hari
        'yyyy -> tahun
        'MM -> bulan
        'HH -> 24jam 'hh -> 12 jam
        'mm -> menit
        'ss -> detik

    End Sub


    Public Sub CREATE_API_MASTER_USER()

        If Dashbord.txt_nama_user_area.Text = "" Then
            MessageBox.Show("Harap isi field nama !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_USER()

        ElseIf Dashbord.txt_username_user_area.Text = "" Then
            MessageBox.Show("Harap isi field username !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_USER()

        ElseIf Dashbord.txt_password_user_area.Text = "" Then
            MessageBox.Show("Harap isi field password !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_USER()

        ElseIf Dashbord.COMBO_class_user_area.Text = "" Then
            MessageBox.Show("Harap isi field class !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_USER()

        ElseIf Dashbord.COMBO_status_user_area.Text = "" Then
            MessageBox.Show("Harap isi field status !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CLEAR_AREA_USER()

        Else
            VALIDASI_USERNAME_AREA()

        End If
    End Sub

End Module
