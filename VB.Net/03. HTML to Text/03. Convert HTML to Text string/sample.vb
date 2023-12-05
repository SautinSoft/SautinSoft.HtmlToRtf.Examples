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
			' Convert HTML string to Text string.
			' If you need more information about "HTML to RTF .Net" 
			' Email us at: support@sautinsoft.com.
			ConvertHtmlToTextString()
		End Sub

		Public Shared Sub ConvertHtmlToTextString()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.TextUTF8WithBOM

			Dim inputFile As String = "..\..\..\Sample.html"
			Dim outputFile As String = "Result.txt"

			' Read our HTML file a string.
			Dim htmlString As String = File.ReadAllText(inputFile)
			Dim textBytes() As Byte = Nothing

			If h.Convert(System.Text.Encoding.UTF8.GetBytes(htmlString), textBytes, opt) Then
				Dim textString As String = System.Text.Encoding.UTF8.GetString(textBytes)

				' Open the result for demonstration purposes.
				If Not String.IsNullOrEmpty(textString) Then
					File.WriteAllText(outputFile, textString)
					System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outputFile) With {.UseShellExecute = True})
				End If
			End If
		End Sub
	End Class
End Namespace
