using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace ReqExpressions
{
    public partial class RegularExp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = @"599A90FC-99CE-4E2F-B495-02AC5591A845 is the 1st instance.";
            lblText.Text = Regex.Replace(str, @"[0-9A-Z]{8}-[0-9A-Z]{4}-[0-9A-Z]{4}-[0-9A-Z]{4}-[0-9A-Z]{4,12}", "");

            string str1 = "123.3";
            string str2 = "23231.32";
            string str3 = "1234.1";
            lblText.Text = Regex.Replace(str1, @"^\d+\.?\d{1,2}$", "matched\r\n");
            lblText.Text += Regex.Replace(str2, @"^\d+\.?\d{1,2}$", "matched\r\n");
            lblText.Text += Regex.Replace(str3, @"^\d+\.?\d{1,2}$", "matched");
        }
    }
}