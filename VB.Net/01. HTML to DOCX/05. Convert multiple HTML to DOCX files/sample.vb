Imports System
Imports System.IO
Imports SautinSoft

Namespace Sample
	Friend Class Test
		Shared Sub Main(ByVal args() As String)
			' Get your free 30-day key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Convert multiple HTML to DOCX files.
			' If you need more information about "HTML to RTF .Net" 
			' Email us at: support@sautinsoft.com.
			ConvertMultipleHtmlToDocx()
		End Sub

		Public Shared Sub ConvertMultipleHtmlToDocx()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Docx

			Dim inpFolder As String = "..\..\..\Testing HTMLs\"
			Dim outFolder As String = (New DirectoryInfo(Directory.GetCurrentDirectory())).CreateSubdirectory("DOCX").FullName
			Dim inpFiles() As String = Directory.GetFiles(inpFolder, "*.htm*")

			Dim total As Integer = inpFiles.Length
			Dim currCount As Integer = 1
			Dim successCount As Integer = 0

			For Each inpFile As String In inpFiles
				Dim fileName As String = Path.GetFileName(inpFile)
				Console.Write("{0:D2} of {1} ... {2}", currCount, total, fileName)
				currCount += 1

				Dim ok As Boolean = True

				Dim outFile As String = Path.Combine(outFolder, Path.ChangeExtension(fileName, ".docx"))
				If h.Convert(inpFile, outFile, opt) Then
					successCount += 1
				Else
					ok = False
				End If

				Console.WriteLine(" ({0})", ok)
			Next inpFile
			Console.WriteLine("{0} of {1} HTML(s) converted successfully!", successCount, total)
			Console.WriteLine("Press any key ...")
			Console.ReadKey()

			' Open the result for demonstration purposes.
			System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFolder) With {.UseShellExecute = True})
		End Sub
	End Class
End Namespace
