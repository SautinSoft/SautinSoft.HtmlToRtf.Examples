using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Set single font family, size and color.
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com.
            SetSingleFontProperties();
        }

        /// <summary>
        /// Converts HTML to DOCX and sets the uniform Font Family, Size and Color for all text.
        /// </summary>
        public static void SetSingleFontProperties()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            string inputFile = @"..\..\..\Sample.html";
            string outputFile = "Result.docx";

            // Let's make all text in document the same: Calibri, 32pt, Gray.
            h.TextStyle.SingleFontFamily = "Calibri";
            h.TextStyle.SingleFontSize = 32;
            h.TextStyle.SingleFontColor = System.Drawing.Color.Gray;

            if (h.OpenHtml(inputFile))
            {
                bool ok = h.ToDocx(outputFile);

                // Open the result for demonstration purposes.
                if (ok)
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outputFile) { UseShellExecute = true });
            }
        }
    }
}
