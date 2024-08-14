using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Before starting, we recommend to get a free 100-day key:
        // https://sautinsoft.com/start-for-free/

        // Apply the key here:
        // SautinSoft.HtmlToRtf.SetLicense("...");
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();
        h.Convert("sample.html", "sample.rtf", new SautinSoft.HtmlToRtf.HtmlConvertOptions() { });
        Console.WriteLine("Converted - [OK]");
    }
}