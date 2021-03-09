using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Convert HTML Stream to RTF Stream.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToRtfStream();
        }

        public static void ConvertHtmlToRtfStream()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            // After purchasing the license, please insert your serial number here to activate the component.
            // h.Serial = "XXXXXXXXX";

            string inputFile = @"..\..\utf-8.html";
            string outputFile = "Result.rtf";

            // Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
            // to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
            h.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inputFile));

            using (FileStream htmlFileStrem = new FileStream(inputFile, FileMode.Open))
            {
                if (h.OpenHtml(htmlFileStrem))
                {
                    using (MemoryStream rtfMemoryStream = new MemoryStream())
                    {
                        bool ok = h.ToRtf(rtfMemoryStream);

                        // Open the result for demonstration purposes.
                        if (ok)
                        {
                            File.WriteAllBytes(outputFile, rtfMemoryStream.ToArray());
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
                        }
                    }
                }
            }
        }
    }
}