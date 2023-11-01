using System;
using System.IO;
using SautinSoft;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {
            // Convert multiple HTML to Text files.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertMultipleHtmlToText();
        }

        public static void ConvertMultipleHtmlToText()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.TextUTF8WithBOM;

            string inpFolder = @"..\..\..\Testing HTMLs\";
            string outFolder = new DirectoryInfo(Directory.GetCurrentDirectory()).CreateSubdirectory("Text").FullName;
            string[] inpFiles = Directory.GetFiles(inpFolder, "*.htm*");

            int total = inpFiles.Length;
            int currCount = 1;
            int successCount = 0;

            foreach (string inpFile in inpFiles)
            {
                string fileName = Path.GetFileName(inpFile);
                Console.Write("{0:D2} of {1} ... {2}", currCount, total, fileName);
                currCount++;

                string outFile = Path.Combine(outFolder, Path.ChangeExtension(fileName, ".txt"));

                if (h.Convert(inpFile, outFile, opt))
                {
                    successCount++;
                    Console.WriteLine(" Ok!");
                }
                else
                {
                    Console.WriteLine(" Error!");
                }

            }
            Console.WriteLine("{0} of {1} HTML(s) converted successfully!", successCount, total);
            Console.WriteLine("Press any key ...");
            Console.ReadKey();

            // Open the result for demonstration purposes.
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFolder) { UseShellExecute = true });

        }
    }
}
