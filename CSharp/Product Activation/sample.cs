using SautinSoft;
using System.IO;

namespace Sample
{
    class Sample
    {
        static void Main()
        {
            HtmlToRtf h = new HtmlToRtf();

            // Place your serial number.
            // You will get own serial number after purchasing the license.
            // If you will have any questions, email us at sales@sautinsoft.com or ask at online chat https://www.sautinsoft.com.

            // For example, you have this key: "1234567890".
            h.Serial = "1234567890";

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