using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Merge two RTF documents in memory.
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com.
            MergeRtfsInMemory();
        }

        public static void MergeRtfsInMemory()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            // Now we've both RTF documents stored in memory in String objects.
            string rtfString1 = File.ReadAllText(@"..\..\..\footer.rtf");
            string rtfString2 = File.ReadAllText(@"..\..\..\footer.rtf");

            // Let's divide RTF documents using page break.
            h.MergeOptions.PageBreakBetweenDocuments = true;

            string rtfSingle = h.MergeRtfString(rtfString1, rtfString2);

            // Save 'rtfSingle' to a file for demonstration purposes and show it.
            if (!String.IsNullOrEmpty(rtfSingle))
            {
                string singleRtfFile = "Single.rtf";
                File.WriteAllText(singleRtfFile, rtfSingle);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(singleRtfFile) { UseShellExecute = true });
            }
        }
    }
}
