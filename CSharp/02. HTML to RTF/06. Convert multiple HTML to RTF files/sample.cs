using System;
using System.IO;
using SautinSoft;
using static SautinSoft.HtmlToRtf;

namespace Sample
{
    class Test
    {
        static void Main(string[] args)
        {
			// Get your free 100-day key here:   
            // https://sautinsoft.com/start-for-free/
	
            // Convert multiple HTML to RTF files.
            // If you need more information about "HTML to RTF .Net" 
            // Email us at: support@sautinsoft.com.
            ConvertMultipleHtmlToRtf();
        }

        public static void ConvertMultipleHtmlToRtf()
        {
            SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf;

            string inpFolder = @"..\..\..\Testing HTMLs\";
            string outFolder = new DirectoryInfo(Directory.GetCurrentDirectory()).CreateSubdirectory("RTF").FullName;
            string[] inpFiles = Directory.GetFiles(inpFolder, "*.htm*");

            int total = inpFiles.Length;
            int currCount = 1;
            int successCount = 0;

            foreach (string inpFile in inpFiles)
            {
                string fileName = Path.GetFileName(inpFile);
                Console.Write("{0:D2} of {1} ... {2}", currCount, total, fileName);
                currCount++;

                string outFile = Path.Combine(outFolder, Path.ChangeExtension(fileName, ".rtf"));
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
