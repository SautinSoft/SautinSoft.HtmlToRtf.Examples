Imports System
Imports System.IO
Imports SautinSoft
Imports SautinSoft.HtmlToRtf

Namespace Sample
	Friend Class Test
		Shared Sub Main(ByVal args() As String)
			' Get your free 100-day key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Set a language for a spelling tools.
			' If you need more information about "HTML to RTF .Net" email us at:
			' support@sautinsoft.com		
			ConvertHtmlToRtfFile()
		End Sub

		Public Shared Sub ConvertHtmlToRtfFile()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf

			Dim inpFile As String = "..\..\..\sample.html"
			Dim outFile As String = Path.ChangeExtension(inpFile, ".rtf")

			' Set a language for a spelling tools.
			opt.SpellingLanguage = HtmlToRtf.SpellingLanguage.English_Singapore

			If h.Convert(inpFile, outFile, opt) Then
				' Open the result for demonstration purposes.
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
