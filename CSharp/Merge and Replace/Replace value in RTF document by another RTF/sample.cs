using System;
using System.IO;

namespace Sample
{
    class Test
    {

        static void Main(string[] args)
        {
            // How to replace values in RTF document by another RTF content.
            // If you need more information about "HTML to RTF .Net" email us at:
            // support@sautinsoft.com	
            ReplaceValuesInRtf();
        }

        public static void ReplaceValuesInRtf()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

            // After purchasing the license, please insert your serial number here to activate the component.
            // h.Serial = "XXXXXXXXX";

            // For example, we've RTF with such content "This is a sample footer as RTF document."
            // Let's replace the string "sample" by another RTF file.
            string sourceRtfFile = @"..\..\footer.rtf";
            string wherewithReplaceRtfPath = @"..\..\footer.rtf";
            string textToReplace = "sample";
            string resultRtfFile = "Result.rtf";
            h.MergeOptions.PageBreakBetweenDocuments = false;
            h.MergeAndReplaceRtfFileFromFile(sourceRtfFile, textToReplace, wherewithReplaceRtfPath, resultRtfFile);

            // Show the result.
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(resultRtfFile) { UseShellExecute = true });
        }
    }
}
