using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Convert HTML bytes to DOCX bytes.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToDocxBytes();
        }
        public static void ConvertHtmlToDocxBytes()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            string inputFile = @"..\..\pic.html";
            string outputFile = "Result.docx";

            // Read our HTML file a bytes.
            byte[] htmlBytes = File.ReadAllBytes(inputFile);

            // Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
            // to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
            h.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inputFile));

            if (h.OpenHtml(htmlBytes))
            {
                byte[] docxBytes = h.ToDocx();

                // Open the result for demonstration purposes.
                if (docxBytes != null)
                {
                    File.WriteAllBytes(outputFile, docxBytes);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
                }
            }
        }
    }
}
