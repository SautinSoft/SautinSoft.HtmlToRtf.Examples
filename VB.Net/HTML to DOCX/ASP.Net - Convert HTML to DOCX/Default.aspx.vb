Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.IO
Imports System.Net

Partial Public Class _Default
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Result.Text = ""
    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim h As New SautinSoft.HtmlToRtf()

        'here we specify page numbers
        h.PageStyle.PageNumbers.Appearance = SautinSoft.HtmlToRtf.ePageNumberingAppearence.PageNumFirst

        'specify HTML format as string
        h.PageStyle.PageHeader.Html("<table border=""1""><tr><td>We added this header using the property ""Header.Html""</td></tr></table>")

        'add footer from HTML file
        h.PageStyle.PageFooter.FromHtmlFile(Path.Combine(Server.MapPath(""), "footer.htm"))

        ' Get HTML content of the current .aspx page
        ' 1. Gets the url of the page
        Dim url As String = Request.Url.ToString()

        ' 2. Download the HTML content
        Dim htmlString As String = GetHtmlFromAspx(url)

        ' Specify the property 'BaseURL', because we're loading HTML string and
        ' it may contain relative paths to images or external .css.
        ' The 'BaseURL' helps to get an absolute path from a relative.
        h.BaseURL = url

        Dim docxBytes() As Byte = Nothing
        If h.OpenHtml(htmlString) Then
            docxBytes = h.ToDocx()
        End If

        ' Show result in the default DOCX viewer app.
        If docxBytes IsNot Nothing Then
            Response.Clear()
            Response.ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
            Response.AddHeader("content-disposition", "inline; filename=""Result.docx""")
            Response.BinaryWrite(docxBytes)
            Response.Flush()
            Response.End()
        Else
            Result.Text = "Converting failed!"
        End If
    End Sub
    Public Function GetHtmlFromAspx(ByVal url As String) As String
        Dim html As String = String.Empty
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.AutomaticDecompression = DecompressionMethods.GZip
        Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Using responseStream As Stream = response.GetResponseStream()
                Using streamReader As New StreamReader(responseStream)
                    html = streamReader.ReadToEnd()
                End Using
            End Using
        End Using
        Return html
    End Function
End Class
