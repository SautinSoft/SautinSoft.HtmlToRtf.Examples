using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Add page numbering during to HTML to RTF conversion.
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com		
            AddPageNumbering();

        }

        public static void AddPageNumbering()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            string inputFile = @"..\..\..\Sample.html";
            string outputFile = "Result.rtf";

            // Add page numbering.
            // Let's set page numbers from 1st page
            h.PageStyle.PageNumbers.Appearance = SautinSoft.HtmlToRtf.ePageNumberingAppearence.PageNumFirst;

            // Let's align page numbers by top-center
            h.PageStyle.PageNumbers.AlignV = SautinSoft.HtmlToRtf.eAlign.Top;
            h.PageStyle.PageNumbers.AlignH = SautinSoft.HtmlToRtf.eAlign.Center;

            // Let's set page numbers format as "Page 1 of 20".
            h.PageStyle.PageNumbers.Format = "Page {page} of {numpages}";

            // Set page numbers font: Calibry, 36.
            h.PageStyle.PageNumbers.Font.Face = "Calibri";
            h.PageStyle.PageNumbers.Font.Size = 36;


            if (h.OpenHtml(inputFile))
            {
                bool ok = h.ToDocx(outputFile);

                // Open the result for demonstration purposes.
                if (ok)
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
            }
        }
    }
}
