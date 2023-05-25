using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Convert HTML string to RTF string.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToRtfString();
        }

        public static void ConvertHtmlToRtfString()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            string inputFile = @"..\..\..\pic.html";
            string outputFile = "Result.rtf";

            // Read our HTML file a string.
            string htmlString = File.ReadAllText(inputFile);

            // Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
            // to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
            h.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inputFile));

            if (h.OpenHtml(htmlString))
            {
                string rtfString = h.ToRtf();

                // Open the result for demonstration purposes.
                if (!String.IsNullOrEmpty(rtfString))
                {
                    File.WriteAllText(outputFile, rtfString);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
                }
            }
        }
    }
}
