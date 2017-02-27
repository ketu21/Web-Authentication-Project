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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnReg_Click(object sender, EventArgs e)
    {
        if (DBComponent.authenticateUser(txtunm.Text.Trim()))
        {
            this.Session["unm"] = txtunm.Text;
            Response.Redirect("~/Menu.aspx");
        }
        else
        {
            lblMsg.Text = "SMS Your Password";
        }
    }

    
}
