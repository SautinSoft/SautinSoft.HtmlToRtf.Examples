Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Convert HTML bytes to DOCX bytes.
        ' If you need more information about "HTML to RTF .Net" 
        ' Email us at: support@sautinsoft.com.
        ConvertHtmlToDocxBytes()
    End Sub

    Public Sub ConvertHtmlToDocxBytes()
        Dim h As New SautinSoft.HtmlToRtf()

        ' After purchasing the license, please insert your serial number here to activate the component.
        'h.Serial = "XXXXXXXXX"

        Dim inputFile As String = "..\..\..\pic.html"
        Dim outputFile As String = "Result.docx"

        ' Read our HTML file a bytes.
        Dim htmlBytes() As Byte = File.ReadAllBytes(inputFile)

        ' Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
        ' to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
        h.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inputFile))

        If h.OpenHtml(htmlBytes) Then
            Dim docxBytes() As Byte = h.ToDocx()

            ' Open the result for demonstration purposes.
            If docxBytes IsNot Nothing Then
                File.WriteAllBytes(outputFile, docxBytes)
                System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
            End If
        End If
    End Sub
End Module
