Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Set single font family, size and color.
        ' If you need more information about "HTML to RTF .Net" email us at:
        ' support@sautinsoft.com.
        SetSingleFontProperties()
    End Sub

    ' Converts HTML to DOCX and sets the uniform Font Family, Size and Color for all text.
    Public Sub SetSingleFontProperties()
        Dim h As New SautinSoft.HtmlToRtf()

        Dim inputFile As String = "..\..\..\Sample.html"
        Dim outputFile As String = "Result.docx"

        ' Let's make all text in document the same: Calibri, 32pt, Gray.
        h.TextStyle.SingleFontFamily = "Calibri"
        h.TextStyle.SingleFontSize = 32
        h.TextStyle.SingleFontColor = System.Drawing.Color.Gray

        If h.OpenHtml(inputFile) Then
            Dim ok As Boolean = h.ToDocx(outputFile)

            ' Open the result for demonstration purposes.
            If ok Then
                System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
            End If
        End If
    End Sub
End Module
