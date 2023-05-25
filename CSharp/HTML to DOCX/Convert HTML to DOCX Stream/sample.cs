using System;
using System.IO;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {
            // Convert HTML Stream to DOCX Stream.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToDocxStream();
        }

        public static void ConvertHtmlToDocxStream()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            string inputFile = @"..\..\..\utf-8.html";
            string outputFile = "Result.docx";

            // Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
            // to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
            h.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inputFile));

            using (FileStream htmlFileStrem = new FileStream(inputFile, FileMode.Open))
            {
                if (h.OpenHtml(htmlFileStrem))
                {
                    using (MemoryStream docxMemoryStream = new MemoryStream())
                    {
                        bool ok = h.ToDocx(docxMemoryStream);

                        // Open the result for demonstration purposes.
                        if (ok)
                        {
                            File.WriteAllBytes(outputFile, docxMemoryStream.ToArray());
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
                        }
                    }
                }
            }
        }
    }
}
