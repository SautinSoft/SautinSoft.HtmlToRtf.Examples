using System;
using System.IO;
using SautinSoft;
using static SautinSoft.HtmlToRtf;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {
			// Get your free 100-day key here:   
            // https://sautinsoft.com/start-for-free/
	
            // Add page numbering during to HTML to RTF conversion.
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com		
            AddPageNumbering();

        }

        public static void AddPageNumbering()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Docx;

            string inpFile = @"..\..\..\Sample.html";
            string outFile = "Result.docx";

            // Add page numbering.
            // Let's set page numbers from 1st page
            opt.PageSetup.PageNumbers.Appearance = HtmlToRtf.PageNumberingAppearence.PageNumFirst;

            // Let's align page numbers by top-center
            opt.PageSetup.PageNumbers.AlignV = HtmlToRtf.Alignment.Top;
            opt.PageSetup.PageNumbers.AlignH = HtmlToRtf.Alignment.Center;

            // Let's set page numbers format as "Page 1 of 20".
            opt.PageSetup.PageNumbers.Format = "Page {page} of {numpages}";

            // Set page numbers font: Calibry, 36.
            opt.PageSetup.PageNumbers.Font.Face = "Calibri";
            opt.PageSetup.PageNumbers.Font.Size = 36;

            if (h.Convert(inpFile, outFile, opt))
            {
                // Open the result for demonstration purposes.                
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
            }
        }
    }
}
