using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Session.Count > 0)
        {
            if (Session["unm"]!=null)
            {
                Label1.Text = "Welcome," + this.Session["unm"].ToString();
               // TextBox1.Text = "Welcome," + this.Session["unm"].ToString();
                btnLogout.Visible = true;
                btnLogin.Visible = false;
            }
            else
            {
                Label1.Text = "";
              //  TextBox1.Text = "";
                btnLogin.Visible = true;
                btnLogout.Visible = false;
            }
        }
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        DBComponent.deleteSession(this.Session["unm"].ToString().Trim());   
        Session.Clear();
        Server.Transfer(@"~\Home.aspx");
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Server.Transfer(@"~\Login.aspx");
    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}
