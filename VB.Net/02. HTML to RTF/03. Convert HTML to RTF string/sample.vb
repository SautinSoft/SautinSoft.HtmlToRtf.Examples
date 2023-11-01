Option Infer On

Imports System
Imports System.IO
Imports SautinSoft

Namespace Sample
	Friend Class Test

		Shared Sub Main(ByVal args() As String)
			' Convert HTML string to RTF string.
			' If you need more information about "HTML to RTF .Net" 
			' Email us at: support@sautinsoft.com.
			ConvertHtmlToRtfString()
		End Sub

		Public Shared Sub ConvertHtmlToRtfString()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf

			Dim inpFile As String = "..\..\..\pic.html"
			Dim outFile As String = "Result.rtf"

			' Read our HTML file a string.
			Dim htmlString As String = File.ReadAllText(inpFile)
			Dim rtfBytes() As Byte = Nothing

			' Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
			' to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
			opt.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inpFile))

			Dim htmlBytes = System.Text.Encoding.UTF8.GetBytes(htmlString)

			If h.Convert(htmlBytes, rtfBytes, opt) Then
				' Open the result for demonstration purposes.
				File.WriteAllBytes(outFile, rtfBytes)
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
