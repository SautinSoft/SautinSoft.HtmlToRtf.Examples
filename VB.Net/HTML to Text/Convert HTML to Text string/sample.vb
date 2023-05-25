Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Convert HTML string to Text string.
        ' If you need more information about "HTML to RTF .Net" 
        ' Email us at: support@sautinsoft.com.
        ConvertHtmlToTextString()
    End Sub

    Public Sub ConvertHtmlToTextString()
        Dim h As New SautinSoft.HtmlToRtf()

        Dim inputFile As String = "..\..\..\Sample.html"
        Dim outputFile As String = "Result.txt"

        ' Read our HTML file a string.
        Dim htmlString As String = File.ReadAllText(inputFile)

        If h.OpenHtml(htmlString) Then
            Dim textString As String = h.ToText()

            ' Open the result for demonstration purposes.
            If Not String.IsNullOrEmpty(textString) Then
                File.WriteAllText(outputFile, textString)
                System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
            End If
        End If
    End Sub
End Module
