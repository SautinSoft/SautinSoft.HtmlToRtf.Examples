Imports System
Imports System.IO
Imports SautinSoft

Namespace Sample
	Friend Class Test
		Shared Sub Main(ByVal args() As String)
			' Get your free 30-day key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Convert HTML Stream to Text Stream.
			' If you need more information about "HTML to RTF .Net" 
			' Email us at: support@sautinsoft.com.
			ConvertHtmlToTextStream()
		End Sub

		Public Shared Sub ConvertHtmlToTextStream()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.TextUTF8WithBOM

			Dim inpFile As String = "..\..\..\Sample.html"
			Dim outFile As String = "Result.txt"

			Using htmlFileStrem As New FileStream(inpFile, FileMode.Open)
				Using ms As New MemoryStream()
					If h.Convert(htmlFileStrem, ms, opt) Then
						' Open the result for demonstration purposes.
						File.WriteAllBytes(outFile, ms.ToArray())
						System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
					End If
				End Using
			End Using
		End Sub
	End Class
End Namespace
