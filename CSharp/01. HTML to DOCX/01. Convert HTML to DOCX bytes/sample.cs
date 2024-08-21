using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
			// Get your free 100-day key here:   
            // https://sautinsoft.com/start-for-free/
			
            // Convert HTML bytes to DOCX bytes.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToDocxBytes();
        }
        public static void ConvertHtmlToDocxBytes()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            string inputFile = @"..\..\..\pic.html";
            string outputFile = "Result.docx";

            // Read our HTML file a bytes.
            byte[] htmlBytes = File.ReadAllBytes(inputFile);
            byte[] docxBytes = null;

            // Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
            // to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
           
            if (h.Convert(htmlBytes, out docxBytes, new HtmlToRtf.HtmlConvertOptions() {  OutputFormat = HtmlToRtf.OutputFormat.Docx}))
            {
                // Open the result for demonstration purposes.
                File.WriteAllBytes(outputFile, docxBytes);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
            }
        }
    }
}
