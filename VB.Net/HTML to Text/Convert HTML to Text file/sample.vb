Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Convert HTML file to Text file.
        ' If you need more information about "HTML to RTF .Net" 
        ' Email us at: support@sautinsoft.com.
        ConvertHtmlToTextFile()
    End Sub

    Public Sub ConvertHtmlToTextFile()
        Dim h As New SautinSoft.HtmlToRtf()

        Dim inputFile As String = "..\..\..\Sample.html"
        Dim outputFile As String = "Result.txt"

        If h.OpenHtml(inputFile) Then
            Dim ok As Boolean = h.ToText(outputFile)

            ' Open the result for demonstration purposes.
            If ok Then
                System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
            End If
        End If
    End Sub
End Module
