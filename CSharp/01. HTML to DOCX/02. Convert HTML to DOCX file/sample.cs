using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {			
			// Get your free key here:   
            // https://sautinsoft.com/start-for-free/
			
            // Convert HTML file to DOCX file.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToDocxFile();
        }

        public static void ConvertHtmlToDocxFile()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            string inputFile = @"..\..\..\Sample.html";
            string outputFile = "Result.docx";

            if (h.Convert(inputFile, outputFile, new HtmlToRtf.HtmlConvertOptions() {  OutputFormat = HtmlToRtf.OutputFormat.Docx}))
            {
                // Open the result for demonstration purposes.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
            }
        }
    }
}
