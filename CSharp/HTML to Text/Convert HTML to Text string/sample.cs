using System;
using System.IO;

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

            // After purchasing the license, please insert your serial number here to activate the component.
            // h.Serial = "XXXXXXXXX";

            string inputFile = @"..\..\Sample.html";
            string outputFile = "Result.txt";

            // Read our HTML file a string.
            string htmlString = File.ReadAllText(inputFile);

            if (h.OpenHtml(htmlString))
            {
                string textString = h.ToText();

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
