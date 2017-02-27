using System.Collections.Generic;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class ChangeMobileno : System.Web.UI.Page
{
    string ans;
    protected void Page_Load(object sender, EventArgs e)
    {
        string name = this.Session["unm"].ToString();
        DataTable dt = DBComponent.getUser(name);
        if (dt != null)
        {
            txtque.Text = dt.Rows[0]["Secque"].ToString();
            ans = dt.Rows[0]["Secans"].ToString();
        }
    }
    protected void btnReg_Click(object sender, EventArgs e)
    {
        if(txtans.Text == ans)
        {
            Response.Redirect("Newnumber.aspx");
        }
        else
        {
           lblMsg.Text = "Wrong Answer. Retry.";
        }
    }
}