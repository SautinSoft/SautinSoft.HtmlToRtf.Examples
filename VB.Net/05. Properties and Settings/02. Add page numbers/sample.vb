Imports System
Imports System.IO
Imports SautinSoft
Imports SautinSoft.HtmlToRtf

Namespace Sample
	Friend Class Test
		Shared Sub Main(ByVal args() As String)
			' Get your free key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Add page numbering during to HTML to RTF conversion.
			' If you need more information about "HTML to RTF .Net" email us at:
			' support@sautinsoft.com		
			AddPageNumbering()

		End Sub

		Public Shared Sub AddPageNumbering()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Docx

			Dim inpFile As String = "..\..\..\Sample.html"
			Dim outFile As String = "Result.docx"

			' Add page numbering.
			' Let's set page numbers from 1st page
			opt.PageSetup.PageNumbers.Appearance = HtmlToRtf.PageNumberingAppearence.PageNumFirst

			' Let's align page numbers by top-center
			opt.PageSetup.PageNumbers.AlignV = HtmlToRtf.Alignment.Top
			opt.PageSetup.PageNumbers.AlignH = HtmlToRtf.Alignment.Center

			' Let's set page numbers format as "Page 1 of 20".
			opt.PageSetup.PageNumbers.Format = "Page {page} of {numpages}"

			' Set page numbers font: Calibry, 36.
			opt.PageSetup.PageNumbers.Font.Face = "Calibri"
			opt.PageSetup.PageNumbers.Font.Size = 36

			If h.Convert(inpFile, outFile, opt) Then
				' Open the result for demonstration purposes.                
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
