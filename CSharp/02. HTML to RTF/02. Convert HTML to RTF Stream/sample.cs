using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
			// Get your free 30-day key here:   
            // https://sautinsoft.com/start-for-free/
	
            // Convert HTML Stream to RTF Stream.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToRtfStream();
        }

        public static void ConvertHtmlToRtfStream()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf;

            string inpFile = @"..\..\..\utf-8.html";
            string outFile = "Result.rtf";

            // Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
            // to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
            opt.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inpFile));

            using (FileStream htmlStream = new FileStream(inpFile, FileMode.Open))
            {
                using (MemoryStream rtfStream = new MemoryStream())
                {
                    if (h.Convert(htmlStream, rtfStream, opt))
                    {
                        // Open the result for demonstration purposes.

                        File.WriteAllBytes(outFile, rtfStream.ToArray());
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
                    }
                }
            }
        }
    }
}

