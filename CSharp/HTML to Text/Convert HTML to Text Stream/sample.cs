using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Convert HTML Stream to Text Stream.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToTextStream();
        }

        public static void ConvertHtmlToTextStream()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            // After purchasing the license, please insert your serial number here to activate the component.
            // h.Serial = "XXXXXXXXX";

            string inputFile = @"..\..\Sample.html";
            string outputFile = "Result.txt";

            using (FileStream htmlFileStrem = new FileStream(inputFile, FileMode.Open))
            {
                if (h.OpenHtml(htmlFileStrem))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bool ok = h.ToText(ms);

                        // Open the result for demonstration purposes.
                        if (ok)
                        {
                            File.WriteAllBytes(outputFile, ms.ToArray());
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
                        }
                    }
                }
            }
        }
    }
}
