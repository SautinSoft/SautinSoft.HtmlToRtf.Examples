Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Convert HTML Stream to RTF Stream.
        ' If you need more information about "HTML to RTF .Net" 
        ' Email us at: support@sautinsoft.com.
        ConvertHtmlToRtfStream()
    End Sub

    Public Sub ConvertHtmlToRtfStream()
        Dim h As New SautinSoft.HtmlToRtf()

        Dim inputFile As String = "..\utf-8.html"
        Dim outputFile As String = "Result.rtf"

        ' Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
        ' to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
        h.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inputFile))

        Using htmlFileStrem As New FileStream(inputFile, FileMode.Open)
            If h.OpenHtml(htmlFileStrem) Then
                Using rtfMemoryStream As New MemoryStream()
                    Dim ok As Boolean = h.ToRtf(rtfMemoryStream)

                    ' Open the result for demonstration purposes.
                    If ok Then
                        File.WriteAllBytes(outputFile, rtfMemoryStream.ToArray())
                        System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
                    End If
                End Using
            End If
        End Using
    End Sub
End Module
