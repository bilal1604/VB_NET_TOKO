Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Module user_byID
    Public Sub USER_BY_ID()

        Try
            Dim url As String = "http://localhost/toko/api/user/" + F_Login.txt_username.Text
            Dim uri As New Uri(url)
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Method = "GET"
            Dim response As HttpWebResponse = request.GetResponse
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            Dim return_api As String = reader.ReadToEnd
            Dim list_dist As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(return_api)
            For Each item As Object In list_dist

                Dashbord.LB_NAMA.Text = (item("nama").ToString)
                Dashbord.LB_JOBCLAS.Text = (item("class").ToString)
                Dashbord.LB_STATUS.Text = (item("status").ToString)

            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Notifikasi Eroor")

        End Try
    End Sub
End Module
