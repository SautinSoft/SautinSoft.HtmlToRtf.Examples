using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
			// Get your free 30-day key here:   
            // https://sautinsoft.com/start-for-free/
	
=======
>>>>>>> 45a2beed078790cd1f555bd0ea963d2ba6ee1718
            // Set page size A5; margins: top, bottom 30 mm and left, right to 50 mm.
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com		
            ConvertHtmlToDocxFile();
        }

        public static void ConvertHtmlToDocxFile()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Docx;

            string inpFile = @"..\..\..\sample.html";
            string outFile = "Result.docx";

            // Set page size and page margins.
            opt.PageSetup.PaperType = HtmlToRtf.PaperType.A5;
            opt.PageSetup.PageMargins.Top = new HtmlToRtf.LengthUnit(30, HtmlToRtf.Units.Mm);
            opt.PageSetup.PageMargins.Bottom = new HtmlToRtf.LengthUnit(30, HtmlToRtf.Units.Mm);
            opt.PageSetup.PageMargins.Left = new HtmlToRtf.LengthUnit(50, HtmlToRtf.Units.Mm);
            opt.PageSetup.PageMargins.Right = new HtmlToRtf.LengthUnit(50, HtmlToRtf.Units.Mm);

            if (h.Convert(inpFile, outFile, opt))
            {
                // Open the result for demonstration purposes.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
            }
        }
    }
}
