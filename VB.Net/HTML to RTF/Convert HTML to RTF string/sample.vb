Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Convert HTML string to RTF string.
        ' If you need more information about "HTML to RTF .Net" 
        ' Email us at: support@sautinsoft.com.
        ConvertHtmlToRtfString()
    End Sub

    Public Sub ConvertHtmlToRtfString()
        Dim h As New SautinSoft.HtmlToRtf()

        ' After purchasing the license, please insert your serial number here to activate the component.
        'h.Serial = "XXXXXXXXX"

        Dim inputFile As String = "..\..\..\pic.html"
        Dim outputFile As String = "Result.rtf"

        ' Read our HTML file a string.
        Dim htmlString As String = File.ReadAllText(inputFile)

        ' Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
        ' to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
        h.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inputFile))

        If h.OpenHtml(htmlString) Then
            Dim rtfString As String = h.ToRtf()

            ' Open the result for demonstration purposes.
            If Not String.IsNullOrEmpty(rtfString) Then
                File.WriteAllText(outputFile, rtfString)
                System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
            End If
        End If
    End Sub
End Module
