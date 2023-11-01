using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {
            // Add a page header and footer during the conversion of HTML to RTF or DOCX.
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com.
            AddHeaderAndFooter();
        }

        public static void AddHeaderAndFooter()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Docx;

            string inpFile = @"..\..\..\Sample.html";
            string outFile = "Result.docx";

            // Set page header and footer.
            string headerFromHtml = File.ReadAllText(@"..\..\..\header.html");
            string footerFromRtf = File.ReadAllText(@"..\..\..\footer.rtf");

            // Add page header.
            opt.PageSetup.PageHeader.Html(headerFromHtml);

            // Add extra space between header and page contents.
            opt.PageSetup.PageHeader.MarginBottom.Mm(10);

            // Add page footer.
            opt.PageSetup.PageFooter.Rtf(footerFromRtf);

            if (h.Convert(inpFile, outFile, opt))
            {
                // Open the result for demonstration purposes.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
            }
        }
    }
}
