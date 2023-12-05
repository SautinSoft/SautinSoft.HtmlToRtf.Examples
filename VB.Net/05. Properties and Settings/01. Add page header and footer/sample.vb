Imports System
Imports System.IO
Imports SautinSoft

Namespace Sample
	Friend Class Test
		Shared Sub Main(ByVal args() As String)
			' Get your free 30-day key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Add a page header and footer during the conversion of HTML to RTF or DOCX.
			' If you need more information about "HTML to RTF .Net" email us at:
			' support@sautinsoft.com.
			AddHeaderAndFooter()
		End Sub

		Public Shared Sub AddHeaderAndFooter()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Docx

			Dim inpFile As String = "..\..\..\Sample.html"
			Dim outFile As String = "Result.docx"

			' Set page header and footer.
			Dim headerFromHtml As String = File.ReadAllText("..\..\..\header.html")
			Dim footerFromRtf As String = File.ReadAllText("..\..\..\footer.rtf")

			' Add page header.
			opt.PageSetup.PageHeader.Html(headerFromHtml)

			' Add extra space between header and page contents.
			opt.PageSetup.PageHeader.MarginBottom.Mm(10)

			' Add page footer.
			opt.PageSetup.PageFooter.Rtf(footerFromRtf)

			If h.Convert(inpFile, outFile, opt) Then
				' Open the result for demonstration purposes.
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
