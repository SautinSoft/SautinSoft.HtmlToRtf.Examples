using System;
using System.IO;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {
            // Convert HTML file to DOCX file.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToDocxFile();
        }

        public static void ConvertHtmlToDocxFile()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            // After purchasing the license, please insert your serial number here to activate the component.
            // h.Serial = "XXXXXXXXX";

            string inputFile = @"..\..\Sample.html";
            string outputFile = "Result.docx";

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
