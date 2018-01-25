using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("ItemId");        
        dt.Columns.Add("Text");

        DataRow dr1 = dt.NewRow();
        dr1[0] = "CBOne";        
        dr1[1] = "Item One";
        dt.Rows.Add(dr1);

        DataRow dr2 = dt.NewRow();
        dr2[0] = "CBTwo";
        dr2[1] = "Item Two";
        dt.Rows.Add(dr2);

        DataRow dr3 = dt.NewRow();
        dr3[0] = "CBThree";
        dr3[1] = "Item Three";
        dt.Rows.Add(dr3);

        DataRow dr4 = dt.NewRow();
        dr4[0] = "CBFour";
        dr4[1] = "Item Four";
        dt.Rows.Add(dr4);

        DataRow dr5 = dt.NewRow();
        dr5[0] = "CBFive";
        dr5[1] = "Item Five";
        dt.Rows.Add(dr5);

        LV1.DataSource = dt;
        LV1.DataBind();

        LV2.DataSource = dt;
        LV2.DataBind();

        LV3.DataSource = dt;
        LV3.DataBind();

        LV4.DataSource = dt;
        LV4.DataBind();
    }

    private void bindListView(ListView LV, DataTable Dt)
    {
        foreach (DataRow dr in Dt.Rows)
        {
            CheckBox CB = new CheckBox();
            CB.ID = dr[0].ToString();
            CB.Text = dr[1].ToString();            

           

        }
    }

    protected void LV1_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //e.Item.FindControl("CB11").ClientID = "asdfsd";
        //int i = 10;
        //int j = i;
    }
    protected void LV2_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //int i = 10;
        //int j = i;
    }
    protected void LV3_ItemDataBound(object sender, ListViewItemEventArgs e)
    {
        //int i = 10;
        //int j = i;
    }
    protected void LV4_ItemDataBound(object sender, ListViewItemEventArgs e)
    {

    }
    protected void LV2_DataBinding(object sender, EventArgs e)
    {
        
    }
    protected void LV2_ItemCreated(object sender, ListViewItemEventArgs e)
    {
        
    }
}
