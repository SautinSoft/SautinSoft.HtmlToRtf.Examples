Imports SautinSoft
Imports System.IO

Namespace Sample
    Friend Class Sample
        Shared Sub Main()
            Dim h As New HtmlToRtf()

           ' You will get own serial number after purchasing the license.
            ' If you will have any questions, email us to sales@sautinsoft.com or ask at online chat https://www.sautinsoft.com.

            ' Let us say, you have this key: 1234567890.            
            HtmlToRtf.SetLicense("1234567890")
            ' Activation of Html to Rtf .Net after purchasing.

            Dim inputFile As String = "..\Sample.html"
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