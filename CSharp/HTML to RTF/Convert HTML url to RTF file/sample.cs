using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Convert HTML url to RTF file.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlUrlToRtfFile();
        }

        public static void ConvertHtmlUrlToRtfFile()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            // After purchasing the license, please insert your serial number here to activate the component.
            // h.Serial = "XXXXXXXXX";

            string inputFile = @"https://www.sautinsoft.net/samples/utf-8.html";
            string outputFile = "Result.rtf";

            // Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
            // to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
            h.BaseURL = @"https://www.sautinsoft.net/samples/utf-8.html";

            if (h.OpenHtml(inputFile))
            {
                bool ok = h.ToRtf(outputFile);

                // Open the result for demonstration purposes.
                if (ok)
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
            }
        }
    }
}
