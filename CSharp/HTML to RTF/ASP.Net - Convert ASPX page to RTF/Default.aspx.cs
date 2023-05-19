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
        string rtfString = String.Empty;

        SautinSoft.HtmlToRtf h = new SautinSoft.HtmlToRtf();

        // Page properties.
        h.PageStyle.PageSize.Letter();
        h.PageStyle.PageMarginLeft.Mm(25);
        // Get HTML content of the current .aspx page
        // 1. Gets the url of the page
        string url = Request.Url.ToString();

        // 2. Download the HTML content
        string html = String.Empty;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.AutomaticDecompression = DecompressionMethods.GZip;
        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream responseStream = response.GetResponseStream())
        using (StreamReader streamReader = new StreamReader(responseStream))
        {
            html = streamReader.ReadToEnd();
        }

        // Specify the property 'BaseURL', because we're loading HTML string and
        // it may contain relative paths to images or external .css.
        // The 'BaseURL' helps to get an absolute path from a relative.
        h.BaseURL = url;

        if (h.OpenHtml(html))
            rtfString = h.ToRtf();

        // Show result in the default RTF viewer app.
        if (!String.IsNullOrEmpty(rtfString))
        {
            Response.Clear();
            Response.ContentType = "application/rtf";
            Response.AddHeader("content-disposition", "inline; filename=\"Result.rtf\"");
            byte[] data = System.Text.Encoding.UTF8.GetBytes(rtfString);
            Response.BinaryWrite(data);
            Response.Flush();
            Response.End();
        }
        else
        {
            Result.Text = "Converting failed!";
        }
    }
}
