Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' How to replace values in RTF document by another RTF content.
        ' If you need more information about "HTML to RTF .Net" email us at:
        ' support[at]sautinsoft.com	
        ReplaceValuesInRtf()
    End Sub

    Public Sub ReplaceValuesInRtf()
        Dim h As New SautinSoft.HtmlToRtf()

        ' For example, we've RTF with such content "This is a sample footer as RTF document."
        ' Let's replace the string "sample" by another RTF file.
        Dim sourceRtfFile As String = "..\footer.rtf"
        Dim wherewithReplaceRtfPath As String = "..\footer.rtf"
        Dim textToReplace As String = "sample"
        Dim resultRtfFile As String = "Result.rtf"

        h.MergeAndReplaceRtfFileFromFile(sourceRtfFile, textToReplace, wherewithReplaceRtfPath, resultRtfFile)

        ' Show the result.
        System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(resultRtfFile) With {.UseShellExecute = True})
    End Sub
End Module
