using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // Merge multiple RTF files
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com		
            MergeFiles();
        }

        public static void MergeFiles()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            DirectoryInfo htmlDir = new DirectoryInfo(@"..\..\..\");

            // Array with several RTF files.            
            string[] rtfFiles = new string[] { "footer.rtf", "footer.rtf", "footer.rtf" };
            string singleRtf = String.Empty;

            // Let's divide RTF documents using page break.
            h.MergeSetup.PageBreakBetweenDocuments = true;

            foreach (string rtfFile in rtfFiles)
            {
                string rtfFilePath = Path.Combine(htmlDir.FullName, rtfFile);

                // Copy 1st RTF to 'singleRtf'
                if (String.IsNullOrEmpty(singleRtf))
                    singleRtf = File.ReadAllText(rtfFilePath);

                // Merge 2nd, 3rd ....
                else
                    singleRtf = h.MergeRtfString(singleRtf, File.ReadAllText(rtfFilePath));
            }

            // Save 'singleRtf' to a file only for demonstration purposes.
            string singleRtfPath = "Single.rtf";
            File.WriteAllText(singleRtfPath, singleRtf);
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(singleRtfPath) { UseShellExecute = true });
        }
    }
}
