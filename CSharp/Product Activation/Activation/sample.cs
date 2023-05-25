using SautinSoft;
using System.IO;

namespace Sample
{
    class Sample
    {
        static void Main()
        {
            HtmlToRtf h = new HtmlToRtf();

            // You will get own serial number after purchasing the license.
            // If you will have any questions, email us to sales@sautinsoft.com or ask at online chat https://www.sautinsoft.com.
            // Let us say, you have this key: 1234567890.            

            HtmlToRtf.SetLicense("1234567890");
            // Activation of Html to Rtf .Net after purchasing.

            string inputFile = @"..\..\..\Sample.html";
            string outputFile = @"Result.rtf";

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