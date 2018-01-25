using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlSessionState
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["One"] != null)
            {
                LblOne.Text = "Session Exists";
            }
            else
            {
                LblOne.Text = "Session Doesn't exists";
            }
        }
    }
}
