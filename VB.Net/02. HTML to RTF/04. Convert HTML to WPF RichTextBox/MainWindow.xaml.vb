Imports SautinSoft
Imports System.IO
Imports SautinSoft.HtmlToRtf

Class MainWindow
    Private Sub Start_Click(sender As Object, e As RoutedEventArgs)
		Dim htmlFile As String = "..\..\Sample.html"
		Dim rtfString As String = String.Empty

		' Create an instance of the converter.
		Dim h As SautinSoft.HtmlToRtf = New HtmlToRtf()
		Dim opt As New HtmlConvertOptions()
		opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf

		opt.TextSetup.DefaultFontFamily = "Calibri"

		' Convert HTML to RTF.
		Using fs As New FileStream(htmlFile, FileMode.Open, FileAccess.Read)
			Using msRtf As New MemoryStream()
				' Convert HTML to RTF.
				If h.Convert(fs, msRtf, opt) Then
					' Place the RTF into RichTextBox.
					Dim tr As New System.Windows.Documents.TextRange(RtfControl.Document.ContentStart, RtfControl.Document.ContentEnd)
					tr.Load(msRtf, DataFormats.Rtf)
				End If
			End Using
		End Using
	End Sub
End Class
