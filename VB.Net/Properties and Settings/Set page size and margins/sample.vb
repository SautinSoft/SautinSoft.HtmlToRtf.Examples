Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Set page size A5; margins: top, bottom 30 mm and left, right to 50 mm.
        ' If you need more information about "HTML to RTF .Net" email us at:
        ' support@sautinsoft.com		
        ConvertHtmlToDocxFile()
    End Sub

    Public Sub ConvertHtmlToDocxFile()
        Dim h As New SautinSoft.HtmlToRtf()

        Dim inputFile As String = "..\..\..\Sample.html"
        Dim outputFile As String = "Result.docx"

        ' Set page size and page margins.
        h.PageStyle.PageSize.A5()
        h.PageStyle.PageMarginTop.Mm(30)
        h.PageStyle.PageMarginBottom.Mm(30)
        h.PageStyle.PageMarginLeft.Mm(50)
        h.PageStyle.PageMarginRight.Mm(50)

        If h.OpenHtml(inputFile) Then
            Dim ok As Boolean = h.ToDocx(outputFile)

            ' Open the result for demonstration purposes.
            If ok Then
                System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
            End If
        End If
    End Sub
End Module
