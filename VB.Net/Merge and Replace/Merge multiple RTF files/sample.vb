Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main()
        ' Merge multiple RTF files
        ' If you need more information about "HTML to RTF .Net" email us at:
        ' support@sautinsoft.com		
        MergeFiles()
    End Sub

    Public Sub MergeFiles()
        Dim h As New SautinSoft.HtmlToRtf()

        Dim htmlDir As New DirectoryInfo("..\")

        ' Array with several RTF files.            
        Dim rtfFiles() As String = {"footer.rtf", "footer.rtf", "footer.rtf"}
        Dim singleRtf As String = String.Empty

        ' Let's divide RTF documents using page break.
        h.MergeOptions.PageBreakBetweenDocuments = True

        For Each rtfFile As String In rtfFiles
            Dim rtfFilePath As String = Path.Combine(htmlDir.FullName, rtfFile)

            ' Copy 1st RTF to 'singleRtf'
            If String.IsNullOrEmpty(singleRtf) Then
                singleRtf = File.ReadAllText(rtfFilePath)

                ' Merge 2nd, 3rd ....
            Else
                singleRtf = h.MergeRtfString(singleRtf, File.ReadAllText(rtfFilePath))
            End If
        Next rtfFile

        ' Save 'singleRtf' to a file only for demonstration purposes.
        Dim singleRtfPath As String = "Single.rtf"
        File.WriteAllText(singleRtfPath, singleRtf)
        System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(singleRtfPath) With {.UseShellExecute = True})
    End Sub
End Module
