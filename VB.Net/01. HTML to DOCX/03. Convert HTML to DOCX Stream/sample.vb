Imports System
Imports System.IO
Imports SautinSoft

Namespace Sample
	Friend Class Test
		Shared Sub Main(ByVal args() As String)
			' Convert HTML Stream to DOCX Stream.
			' If you need more information about "HTML to RTF .Net" 
			' Email us at: support@sautinsoft.com.
			ConvertHtmlToDocxStream()
		End Sub

		Public Shared Sub ConvertHtmlToDocxStream()
			Dim h As New SautinSoft.HtmlToRtf()

			Dim inputFile As String = "..\..\..\utf-8.html"
			Dim outputFile As String = "Result.docx"

			' Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
			' to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
			Dim opt As New HtmlConvertOptions()
			opt.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inputFile))
			opt.OutputFormat = HtmlToRtf.OutputFormat.Docx

			Using htmlFileStrem As New FileStream(inputFile, FileMode.Open)
				Using docxMemoryStream As New MemoryStream()
					If h.Convert(htmlFileStrem, docxMemoryStream, opt) Then
						' Open the result for demonstration purposes.                        
						File.WriteAllBytes(outputFile, docxMemoryStream.ToArray())
						System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
					End If
				End Using
			End Using
		End Sub
	End Class
End Namespace
