Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Add page numbering during to HTML to RTF conversion.
        ' If you need more information about "HTML to RTF .Net" email us at:
        ' support@sautinsoft.com		
        AddPageNumbering()
    End Sub

    Public Sub AddPageNumbering()
        Dim h As New SautinSoft.HtmlToRtf()

        Dim inputFile As String = "..\..\..\Sample.html"
        Dim outputFile As String = "Result.rtf"

        ' Add page numbering.
        ' Let's set page numbers from 1st page
        h.PageStyle.PageNumbers.Appearance = SautinSoft.HtmlToRtf.ePageNumberingAppearence.PageNumFirst

        ' Let's align page numbers by top-center
        h.PageStyle.PageNumbers.AlignV = SautinSoft.HtmlToRtf.eAlign.Top
        h.PageStyle.PageNumbers.AlignH = SautinSoft.HtmlToRtf.eAlign.Center

        ' Let's set page numbers format as "Page 1 of 20".
        h.PageStyle.PageNumbers.Format = "Page {page} of {numpages}"

        ' Set page numbers font: Calibry, 36.
        h.PageStyle.PageNumbers.Font.Face = "Calibri"
        h.PageStyle.PageNumbers.Font.Size = 36

        If h.OpenHtml(inputFile) Then
            Dim ok As Boolean = h.ToDocx(outputFile)

            ' Open the result for demonstration purposes.
            If ok Then
                System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
            End If
        End If
    End Sub
End Module
