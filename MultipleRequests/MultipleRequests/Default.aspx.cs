using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace MultipleRequests
{
    public partial class _Default : System.Web.UI.Page
    {
        static int i = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //int i = 0;

            Button btn = new Button();
            btn.Text = "sample button";
            btn.ID="BtnOne";

            if (Session["ses"] != null)
            {
                Session["ses"] = Session["ses"].ToString() + "Cached Text; ";
                lblTwo.Text += Session["ses"].ToString();
            }
            else
            {
                Session["ses"] = "Cached Text; ";
                lblTwo.Text = Session["ses"].ToString();
            }


        }

        protected void BtnOne_Click(object sender, EventArgs e)
        {
            //int j = Convert.ToInt16(Session["count"]);
            //for (int i = j; i <= j + 10; i++)
            //{
            //    Session["count"] = i;
            //    Thread.Sleep(500);
            //}
            //lblOne.Text = lblOne.Text + "Button One Clicked, Count: " + Session["count"].ToString() + " ;<br />";
        }

        protected void BtnTwo_Click(object sender, EventArgs e)
        {
            //lblOne.Text = lblOne.Text + "Button Two Clicked, Count: " + Session["count"].ToString() + ";\n";

            
        }

        private static string getSubstitutionContent(HttpContext htcon)
        {
            i += 1;
            return "sample string: " + i.ToString();
        }
    }
}
