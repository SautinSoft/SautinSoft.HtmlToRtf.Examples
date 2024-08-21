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
			// Get your free 100-day key here:   
            // https://sautinsoft.com/start-for-free/
	
            // Convert HTML url to RTF file.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlUrlToRtfFile();
        }

        public static void ConvertHtmlUrlToRtfFile()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            string inpFile = @"https://www.sautinsoft.com/samples/Sample.html";
            string outFile = "Result.rtf";

            // Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
            // to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.BaseURL = @"https://www.sautinsoft.com/samples/";

            if (h.Convert(inpFile, outFile, opt))
            {
                // Open the result for demonstration purposes.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
            }
        }
    }
}
