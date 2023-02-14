using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Set page size A5; margins: top, bottom 30 mm and left, right to 50 mm.
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com		
            ConvertHtmlToDocxFile();
        }

        public static void ConvertHtmlToDocxFile()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            // After purchasing the license, please insert your serial number here to activate the component.
            // h.Serial = "XXXXXXXXX";

            string inputFile = @"..\..\..\sample.html";
            string outputFile = "Result.docx";

            // Set page size and page margins.
            h.PageStyle.PageSize.A5();
            h.PageStyle.PageMarginTop.Mm(30);
            h.PageStyle.PageMarginBottom.Mm(30);
            h.PageStyle.PageMarginLeft.Mm(50);
            h.PageStyle.PageMarginRight.Mm(50);

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
