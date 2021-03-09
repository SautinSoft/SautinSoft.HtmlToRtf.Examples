using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Net;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Result.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

        // After purchasing the license, please insert your serial number here to activate the component.
        // h.Serial = "XXXXXXXXX";

        //here we specify page numbers
        h.PageStyle.PageNumbers.Appearance = SautinSoft.HtmlToRtf.ePageNumberingAppearence.PageNumFirst;

        //specify HTML format as string
        h.PageStyle.PageHeader.Html("<table border=\"1\"><tr><td>We added this header using the property \"Header.Html\"</td></tr></table>");

        //add footer from HTML file
        h.PageStyle.PageFooter.FromHtmlFile(Path.Combine(Server.MapPath(""), @"footer.htm"));

        // Get HTML content of the current .aspx page
        // 1. Gets the url of the page
        string url = Request.Url.ToString();

        // 2. Download the HTML content
        string htmlString = GetHtmlFromAspx(url);

        // Specify the property 'BaseURL', because we're loading HTML string and
        // it may contain relative paths to images or external .css.
        // The 'BaseURL' helps to get an absolute path from a relative.
        h.BaseURL = url;

        byte[] docxBytes = null;
         if (h.OpenHtml(htmlString))
            docxBytes = h.ToDocx();

        // Show result in the default DOCX viewer app.
        if (docxBytes != null)
        {
            Response.Clear();
            Response.ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            Response.AddHeader("content-disposition", "inline; filename=\"Result.docx\"");
            Response.BinaryWrite(docxBytes);
            Response.Flush();
            Response.End();
        }
        else
        {
            Result.Text = "Converting failed!";
        }
    }
    public static string GetHtmlFromAspx(string url)
    {
        string html = String.Empty;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.AutomaticDecompression = DecompressionMethods.GZip;
        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream responseStream = response.GetResponseStream())
        using (StreamReader streamReader = new StreamReader(responseStream))
        {
            html = streamReader.ReadToEnd();
        }
        return html;
    }
}
