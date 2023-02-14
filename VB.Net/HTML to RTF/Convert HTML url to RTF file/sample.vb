Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Convert HTML url to RTF file.
        ' If you need more information about "HTML to RTF .Net" 
        ' Email us at: support@sautinsoft.com.
        ConvertHtmlUrlToRtfFile()
    End Sub

    Public Sub ConvertHtmlUrlToRtfFile()
        Dim h As New SautinSoft.HtmlToRtf()

        ' After purchasing the license, please insert your serial number here to activate the component.
        'h.Serial = "XXXXXXXXX"

        Dim inputFile As String = "https://www.sautinsoft.net/samples/utf-8.html"
        Dim outputFile As String = "Result.rtf"

        ' Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
        ' to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
        h.BaseURL = "https://www.sautinsoft.net/samples/utf-8.html"

        If h.OpenHtml(inputFile) Then
            Dim ok As Boolean = h.ToRtf(outputFile)

            ' Open the result for demonstration purposes.
            If ok Then
                System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
            End If
        End If
    End Sub
End Module
