Imports SautinSoft
Imports System.IO

Class MainWindow
    Private Sub Start_Click(sender As Object, e As RoutedEventArgs)
        Dim htmlFile As String = "..\..\Sample.html"
        Dim rtfString As String = String.Empty

        ' Create an instance of the converter.
        Dim h As SautinSoft.HtmlToRtf = New HtmlToRtf()
		
		h.TextStyle.DefaultFontFamily = "Calibri"

        ' Convert HTML to RTF.            
        If h.OpenHtml(htmlFile) Then
            Using msRtf As New MemoryStream()
                ' Convert HTML to RTF.
                If h.ToRtf(msRtf) Then
                    ' Place the RTF into RichTextBox.
                    Dim tr As New System.Windows.Documents.TextRange(RtfControl.Document.ContentStart, RtfControl.Document.ContentEnd)
                    tr.Load(msRtf, DataFormats.Rtf)
                End If
            End Using
        End If
    End Sub
End Class
