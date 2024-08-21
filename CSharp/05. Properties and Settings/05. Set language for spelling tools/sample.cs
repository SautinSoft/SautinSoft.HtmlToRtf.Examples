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
	
            // Set a language for a spelling tools.
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com		
            ConvertHtmlToRtfFile();
        }

        public static void ConvertHtmlToRtfFile()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf;

            string inpFile = @"..\..\..\sample.html";
            string outFile = Path.ChangeExtension(inpFile, ".rtf");

            // Set a language for a spelling tools.
            opt.SpellingLanguage = HtmlToRtf.SpellingLanguage.English_Singapore;

            if (h.Convert(inpFile, outFile, opt))
            {
                // Open the result for demonstration purposes.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
            }
        }
    }
}

