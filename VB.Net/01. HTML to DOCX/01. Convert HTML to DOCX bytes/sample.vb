Imports System
Imports System.IO
Imports SautinSoft
Imports SautinSoft.HtmlToRtf

Namespace Sample
	Friend Class Test

		Shared Sub Main(ByVal args() As String)
			' Get your free 100-day key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Convert HTML bytes to DOCX bytes.
			' If you need more information about "HTML to RTF .Net" 
			' Email us at: support@sautinsoft.com.
			ConvertHtmlToDocxBytes()
		End Sub
		Public Shared Sub ConvertHtmlToDocxBytes()
			Dim h As New SautinSoft.HtmlToRtf()

			Dim inputFile As String = "..\..\..\pic.html"
			Dim outputFile As String = "Result.docx"

			' Read our HTML file a bytes.
			Dim htmlBytes() As Byte = File.ReadAllBytes(inputFile)
			Dim docxBytes() As Byte = Nothing

			' Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
			' to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
			Dim opt As New HtmlConvertOptions()
			opt.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inputFile))
			opt.OutputFormat = HtmlToRtf.OutputFormat.Docx


			If h.Convert(htmlBytes, docxBytes, opt) Then
				' Open the result for demonstration purposes.
				File.WriteAllBytes(outputFile, docxBytes)
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
