Imports System
Imports System.IO
Imports SautinSoft

Namespace Sample
	Friend Class Test

		Shared Sub Main(ByVal args() As String)
			' Get your free 30-day key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Convert HTML Stream to RTF Stream.
			' If you need more information about "HTML to RTF .Net" 
			' Email us at: support@sautinsoft.com.
			ConvertHtmlToRtfStream()
		End Sub

		Public Shared Sub ConvertHtmlToRtfStream()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf

			Dim inpFile As String = "..\..\..\utf-8.html"
			Dim outFile As String = "Result.rtf"

			' Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
			' to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
			opt.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inpFile))

			Using htmlStream As New FileStream(inpFile, FileMode.Open)
				Using rtfStream As New MemoryStream()
					If h.Convert(htmlStream, rtfStream, opt) Then
						' Open the result for demonstration purposes.

						File.WriteAllBytes(outFile, rtfStream.ToArray())
						System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
					End If
				End Using
			End Using
		End Sub
	End Class
End Namespace
