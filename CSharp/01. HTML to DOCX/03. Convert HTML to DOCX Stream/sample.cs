using System;
using System.IO;
using SautinSoft;
using static SautinSoft.HtmlToRtf;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {
			// Get your free key here:   
            // https://sautinsoft.com/start-for-free/
			
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
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inputFile));
            opt.OutputFormat = HtmlToRtf.OutputFormat.Docx;

            using (FileStream htmlFileStrem = new FileStream(inputFile, FileMode.Open))
            {
                using (MemoryStream docxMemoryStream = new MemoryStream())
                {
                    if (h.Convert(htmlFileStrem, docxMemoryStream, opt))
                    {
                        // Open the result for demonstration purposes.                        
                        File.WriteAllBytes(outputFile, docxMemoryStream.ToArray());
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
                    }
                }
            }
        }
    }
}