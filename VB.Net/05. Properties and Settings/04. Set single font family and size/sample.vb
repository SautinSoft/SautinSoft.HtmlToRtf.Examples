Imports System
Imports System.IO
Imports SautinSoft

Namespace Sample
	Friend Class Test
		Shared Sub Main(ByVal args() As String)
			' Get your free 30-day key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Set single font family, size and color.
			' If you need more information about "HTML to RTF .Net" email us at:
			' support@sautinsoft.com.
			SetSingleFontProperties()
		End Sub

		''' <summary>
		''' Converts HTML to DOCX and sets the uniform Font Family, Size and Color for all text.
		''' </summary>
		Public Shared Sub SetSingleFontProperties()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Docx

			Dim inpFile As String = "..\..\..\Sample.html"
			Dim outFile As String = "Result.docx"

			' Let's make all text in document the same: Calibri, 32pt, Gray.
			opt.TextSetup.SingleFontFamily = "Calibri"
			opt.TextSetup.SingleFontSize = 32
			opt.TextSetup.SingleFontColor = SkiaSharp.SKColors.Gray

			If h.Convert(inpFile, outFile, opt) Then
				' Open the result for demonstration purposes.
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
