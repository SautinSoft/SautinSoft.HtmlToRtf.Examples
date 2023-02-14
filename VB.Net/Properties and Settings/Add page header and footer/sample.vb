Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Add a page header and footer during the conversion of HTML to RTF or DOCX.
        ' If you need more information about "HTML to RTF .Net" email us at:
        ' support@sautinsoft.com.
        AddHeaderAndFooter()
    End Sub

    Public Sub AddHeaderAndFooter()
        Dim h As New SautinSoft.HtmlToRtf()

        ' After purchasing the license, please insert your serial number here to activate the component.
        'h.Serial = "XXXXXXXXX"

        Dim inputFile As String = "..\..\..\Sample.html"
        Dim outputFile As String = "Result.docx"

        ' Set page header and footer.
        Dim headerFromHtml As String = File.ReadAllText("..\..\..\header.html")
        Dim footerFromRtf As String = File.ReadAllText("..\..\..\footer.rtf")

        ' Add page header.
        h.PageStyle.PageHeader.Html(headerFromHtml)

        ' Add extra space between header and page contents.
        h.PageStyle.PageHeader.MarginBottom.Mm(10)

        ' Add page footer.
        h.PageStyle.PageFooter.Rtf(footerFromRtf)

        If h.OpenHtml(inputFile) Then
            Dim ok As Boolean = h.ToDocx(outputFile)

            ' Open the result for demonstration purposes.
            If ok Then
                System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
            End If
        End If
    End Sub
End Module
