Imports System
Imports System.IO
Imports SautinSoft

Namespace Sample
	Friend Class Test
		Shared Sub Main(ByVal args() As String)
			' Convert HTML file to DOCX file.
			' If you need more information about "HTML to RTF .Net" 
			' Email us at: support@sautinsoft.com.
			ConvertHtmlToDocxFile()
		End Sub

		Public Shared Sub ConvertHtmlToDocxFile()
			Dim h As New SautinSoft.HtmlToRtf()

			Dim inputFile As String = "..\..\..\Sample.html"
			Dim outputFile As String = "Result.docx"

			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Docx

			If h.Convert(inputFile, outputFile, opt) Then
				' Open the result for demonstration purposes.
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
