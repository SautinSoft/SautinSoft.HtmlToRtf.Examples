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
	
            // Convert HTML Stream to Text Stream.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToTextStream();
        }

        public static void ConvertHtmlToTextStream()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.TextUTF8WithBOM;

            string inpFile = @"..\..\..\Sample.html";
            string outFile = "Result.txt";

            using (FileStream htmlFileStrem = new FileStream(inpFile, FileMode.Open))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    if (h.Convert(htmlFileStrem, ms, opt))
                    {
                        // Open the result for demonstration purposes.
                        File.WriteAllBytes(outFile, ms.ToArray());
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
                    }
                }
            }
        }
    }
}
