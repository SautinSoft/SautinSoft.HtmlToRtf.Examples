using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Convert HTML string to RTF string.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToRtfString();
        }

        public static void ConvertHtmlToRtfString()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf;

            string inpFile = @"..\..\..\pic.html";
            string outFile = "Result.rtf";

            // Read our HTML file a string.
            string htmlString = File.ReadAllText(inpFile);
            byte[] rtfBytes = null;

            // Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
            // to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
            opt.BaseURL = Path.GetDirectoryName(Path.GetFullPath(inpFile));

            var htmlBytes = System.Text.Encoding.UTF8.GetBytes(htmlString);

            if (h.Convert(htmlBytes, out rtfBytes, opt))
            {
                // Open the result for demonstration purposes.
                File.WriteAllBytes(outFile, rtfBytes);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
            }
        }
    }
}
