Imports SautinSoft
Imports System.IO

Namespace Sample
    Friend Class Sample
        Shared Sub Main()
            Dim h As New HtmlToRtf()

            ' Place your serial number.
            ' You will get own serial number after purchasing the license.
            ' If you will have any questions, email us at sales@sautinsoft.com or ask at online chat https://www.sautinsoft.com.

            ' For example, you have this key: "1234567890".
            h.Serial = "1234567890"

            Dim inputFile As String = "..\..\..\Sample.html"
            Dim outputFile As String = "Result.rtf"

            If h.OpenHtml(inputFile) Then
                Dim ok As Boolean = h.ToRtf(outputFile)

                ' Open the result for demonstration purposes.
                If ok Then
                    System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
                End If
            End If
        End Sub
    End Class
End Namespace