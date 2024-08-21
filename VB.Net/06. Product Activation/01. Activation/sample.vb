Imports SautinSoft
Imports System.IO
Imports SautinSoft.HtmlToRtf

Namespace Sample
	Friend Class Sample
		Shared Sub Main()
			' Get your free 100-day key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' You will get own serial number after purchasing the license.
			' If you will have any questions, email us to sales@sautinsoft.com or ask at online chat https://www.sautinsoft.com.
			' Let us say, you have this key: 1234567890.            

			' Activation of Html to Rtf .Net after purchasing.
			HtmlToRtf.SetLicense("1234567890")

			Dim h As New HtmlToRtf()
			Dim inpFile As String = "..\..\..\Sample.html"
			Dim outFile As String = "Result.rtf"

			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf

			If h.Convert(inpFile, outFile, opt) Then
				' Open the result for demonstration purposes.
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
