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
        Dim docxBytes() As Byte = Nothing

        Dim h As New SautinSoft.HtmlToRtf()

        ' Page properties.
        h.PageStyle.PageSize.Letter()
        h.PageStyle.PageMarginLeft.Mm(25)

        ' Get HTML content of the current .aspx page
        ' 1. Gets the url of the page
        Dim url As String = Request.Url.ToString()

        ' 2. Download the HTML content
        Dim html As String = String.Empty
        Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        req.AutomaticDecompression = DecompressionMethods.GZip
        Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
            Using responseStream As Stream = resp.GetResponseStream()
                Using streamReader As New StreamReader(responseStream)
                    html = streamReader.ReadToEnd()
                End Using
            End Using
        End Using

        ' Specify the property 'BaseURL', because we're loading HTML string and
        ' it may contain relative paths to images or external .css.
        ' The 'BaseURL' helps to get an absolute path from a relative.
        h.BaseURL = url

        If h.OpenHtml(html) Then
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
End Class
