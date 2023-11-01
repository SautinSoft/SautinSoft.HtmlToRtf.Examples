using System;
using System.IO;
using SautinSoft;

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
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Docx;

            string inpFile = @"..\..\..\Sample.html";
            string outFile = "Result.docx";

            // Let's make all text in document the same: Calibri, 32pt, Gray.
            opt.TextSetup.SingleFontFamily = "Calibri";
            opt.TextSetup.SingleFontSize = 32;
            opt.TextSetup.SingleFontColor = SkiaSharp.SKColors.Gray;

            if (h.Convert(inpFile, outFile, opt))
            {
                // Open the result for demonstration purposes.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
            }
        }
    }
}
