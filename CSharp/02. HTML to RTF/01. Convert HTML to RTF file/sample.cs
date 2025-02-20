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
	
            // Convert HTML file to RTF file.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToRtfFile();
        }

        public static void ConvertHtmlToRtfFile()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf;

            string inpFile = @"..\..\..\Sample.html";
            string outFile = "Result.rtf";

            if (h.Convert(inpFile, outFile, opt))
            {
                // Open the result for demonstration purposes.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
            }
        }
    }
}
