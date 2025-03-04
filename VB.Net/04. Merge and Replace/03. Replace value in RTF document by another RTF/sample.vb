Imports System
Imports System.IO
Imports SautinSoft.HtmlToRtf

Namespace Sample
	Friend Class Test

		Shared Sub Main(ByVal args() As String)
			' Get your free key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' How to replace values in RTF document by another RTF content.
			' If you need more information about "HTML to RTF .Net" email us at:
			' support@sautinsoft.com	
			ReplaceValuesInRtf()
		End Sub

		Public Shared Sub ReplaceValuesInRtf()
			Dim h As New SautinSoft.HtmlToRtf()

			' For example, we've RTF with such content "This is a sample footer as RTF document."
			' Let's replace the string "sample" by another RTF file.
			Dim sourceRtfFile As String = "..\..\..\footer.rtf"
			Dim wherewithReplaceRtfPath As String = "..\..\..\footer.rtf"
			Dim textToReplace As String = "sample"
			Dim resultRtfFile As String = "Result.rtf"

			h.MergeAndReplaceRtfFileFromFile(sourceRtfFile, textToReplace, wherewithReplaceRtfPath, resultRtfFile)

			' Show the result.
			System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(resultRtfFile) With {.UseShellExecute = True})
		End Sub
	End Class
End Namespace
