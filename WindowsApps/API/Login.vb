Imports System.Net
Imports System.IO
Module Login
    Public Sub LOGIN_USER()

        Try
            Dim url As String = "http://localhost/toko/api/login/" + F_Login.txt_username.Text + "/" + F_Login.txt_password.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "POST"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd

            If return_api = "BERHASIL LOGIN" Then
                MessageBox.Show(return_api, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dashbord.ShowDialog()

            ElseIf return_api = "USERNAME ATAU PASSWORD ANDA SALAH !" Then
                MessageBox.Show(return_api, "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try

    End Sub

End Module
