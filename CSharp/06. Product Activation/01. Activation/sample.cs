using SautinSoft;
using System.IO;

namespace Sample
{
    class Sample
    {
        static void Main()
        {
<<<<<<< HEAD
			// Get your free 30-day key here:   
            // https://sautinsoft.com/start-for-free/
	
=======
>>>>>>> 45a2beed078790cd1f555bd0ea963d2ba6ee1718
            // You will get own serial number after purchasing the license.
            // If you will have any questions, email us to sales@sautinsoft.com or ask at online chat https://www.sautinsoft.com.
            // Let us say, you have this key: 1234567890.            

            // Activation of Html to Rtf .Net after purchasing.
            HtmlToRtf.SetLicense("1234567890");

            HtmlToRtf h = new HtmlToRtf();
            string inpFile = @"..\..\..\Sample.html";
            string outFile = @"Result.rtf";

            HtmlConvertOptions opt = new HtmlConvertOptions();
            opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf;

            if (h.Convert(inpFile, outFile, opt))
            {
                // Open the result for demonstration purposes.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(outFile) { UseShellExecute = true });
            }
        }
    }
}