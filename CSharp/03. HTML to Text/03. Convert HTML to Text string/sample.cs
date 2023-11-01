using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {
            // Convert HTML string to Text string.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertHtmlToTextString();
        }

        public static void ConvertHtmlToTextString()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.TextUTF8WithBOM;

            string inputFile = @"..\..\..\Sample.html";
            string outputFile = "Result.txt";

            // Read our HTML file a string.
            string htmlString = File.ReadAllText(inputFile);
            byte[] textBytes = null;

            if (h.Convert(System.Text.Encoding.UTF8.GetBytes(htmlString), out textBytes, opt))
            {
                string textString = System.Text.Encoding.UTF8.GetString(textBytes);

                // Open the result for demonstration purposes.
                if (!String.IsNullOrEmpty(textString))
                {
                    File.WriteAllText(outputFile, textString);
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
                }
            }
        }
    }
}
