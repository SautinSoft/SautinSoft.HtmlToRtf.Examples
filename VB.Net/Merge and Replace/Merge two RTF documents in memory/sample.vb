Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Merge two RTF documents in memory.
        ' If you need more information about "HTML to RTF .Net" email us at:
        ' support@sautinsoft.com.
        MergeRtfsInMemory()
    End Sub

    Public Sub MergeRtfsInMemory()
        Dim h As New SautinSoft.HtmlToRtf()

        ' Now we've both RTF documents stored in memory in String objects.
        Dim rtfString1 As String = File.ReadAllText("..\..\..\footer.rtf")
        Dim rtfString2 As String = File.ReadAllText("..\..\..\footer.rtf")

        ' Let's divide RTF documents using page break.
        h.MergeOptions.PageBreakBetweenDocuments = True

        Dim rtfSingle As String = h.MergeRtfString(rtfString1, rtfString2)

        ' Save 'rtfSingle' to a file for demonstration purposes and show it.
        If Not String.IsNullOrEmpty(rtfSingle) Then
            Dim singleRtfFile As String = "Single.rtf"
            File.WriteAllText(singleRtfFile, rtfSingle)
            System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(singleRtfFile) With {.UseShellExecute = True})
        End If
    End Sub
End Module
