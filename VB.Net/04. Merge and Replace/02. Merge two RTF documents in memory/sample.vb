Imports System
Imports System.IO
Imports SautinSoft.HtmlToRtf

Namespace Sample
	Friend Class Test

		Shared Sub Main(ByVal args() As String)
			' Get your free 100-day key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Merge two RTF documents in memory.
			' If you need more information about "HTML to RTF .Net" email us at:
			' support@sautinsoft.com.
			MergeRtfsInMemory()
		End Sub

		Public Shared Sub MergeRtfsInMemory()
			Dim h As New SautinSoft.HtmlToRtf()

			' Now we've both RTF documents stored in memory in String objects.
			Dim rtfString1 As String = File.ReadAllText("..\..\..\footer.rtf")
			Dim rtfString2 As String = File.ReadAllText("..\..\..\footer.rtf")

			' Let's divide RTF documents using page break.
			h.MergeSetup.PageBreakBetweenDocuments = True

			Dim rtfSingle As String = h.MergeRtfString(rtfString1, rtfString2)

			' Save 'rtfSingle' to a file for demonstration purposes and show it.
			If Not String.IsNullOrEmpty(rtfSingle) Then
				Dim singleRtfFile As String = "Single.rtf"
				File.WriteAllText(singleRtfFile, rtfSingle)
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(singleRtfFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
