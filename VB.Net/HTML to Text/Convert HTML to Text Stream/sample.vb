Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Convert HTML Stream to Text Stream.
        ' If you need more information about "HTML to RTF .Net" 
        ' Email us at: support@sautinsoft.com.
        ConvertHtmlToTextStream()
    End Sub

    Public Sub ConvertHtmlToTextStream()
        Dim h As New SautinSoft.HtmlToRtf()

        Dim inputFile As String = "..\Sample.html"
        Dim outputFile As String = "Result.txt"

        Using htmlFileStrem As New FileStream(inputFile, FileMode.Open)
            If h.OpenHtml(htmlFileStrem) Then
                Using ms As New MemoryStream()
                    Dim ok As Boolean = h.ToText(ms)

                    ' Open the result for demonstration purposes.
                    If ok Then
                        File.WriteAllBytes(outputFile, ms.ToArray())
                        System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
                    End If
                End Using
            End If
        End Using
    End Sub
End Module
