Imports System
Imports System.IO
Imports SautinSoft

Namespace Sample
	Friend Class Test
		Shared Sub Main(ByVal args() As String)
<<<<<<< HEAD
			' Get your free 30-day key here:   
            ' https://sautinsoft.com/start-for-free/
	
=======
>>>>>>> 45a2beed078790cd1f555bd0ea963d2ba6ee1718
			' Set page size A5; margins: top, bottom 30 mm and left, right to 50 mm.
			' If you need more information about "HTML to RTF .Net" email us at:
			' support@sautinsoft.com		
			ConvertHtmlToDocxFile()
		End Sub

		Public Shared Sub ConvertHtmlToDocxFile()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Docx

			Dim inpFile As String = "..\..\..\sample.html"
			Dim outFile As String = "Result.docx"

			' Set page size and page margins.
			opt.PageSetup.PaperType = HtmlToRtf.PaperType.A5
			opt.PageSetup.PageMargins.Top = New HtmlToRtf.LengthUnit(30, HtmlToRtf.Units.Mm)
			opt.PageSetup.PageMargins.Bottom = New HtmlToRtf.LengthUnit(30, HtmlToRtf.Units.Mm)
			opt.PageSetup.PageMargins.Left = New HtmlToRtf.LengthUnit(50, HtmlToRtf.Units.Mm)
			opt.PageSetup.PageMargins.Right = New HtmlToRtf.LengthUnit(50, HtmlToRtf.Units.Mm)

			If h.Convert(inpFile, outFile, opt) Then
				' Open the result for demonstration purposes.
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
