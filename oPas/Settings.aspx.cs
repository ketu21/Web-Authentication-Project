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

public partial class Settings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string name = this.Session["unm"].ToString();
        if(name=="")
        {
            Response.Redirect("Login.aspx");
        }
        DataTable dt = DBComponent.getUser(name);
        if(dt!=null)
        {
            txtadd.Text = dt.Rows[0][2].ToString();
            txtfnm.Text = dt.Rows[0][9].ToString();
            txtlnm.Text = dt.Rows[0][10].ToString();
            txtLoginId.Text = dt.Rows[0]["LoginId"].ToString();
            txtLoginId2.Text = dt.Rows[0]["LoginId2"].ToString();
            txtPwd.Text = dt.Rows[0]["LoginPwd"].ToString();
            txtPwd2.Text = dt.Rows[0]["LoginPwd2"].ToString();
        }
         
    }
    protected void btnVerify_Click(object sender, EventArgs e)
    {
        string fnm, lnm, add, id1, id2, pwd1, pwd2;
        fnm = txtfnm.Text.Trim();
        lnm = txtlnm.Text.Trim();
        add = txtadd.Text.Trim();
        id1 = txtLoginId.Text.Trim();
        pwd1 = txtPwd.Text.Trim();
        id2 = txtLoginId2.Text.Trim();
        pwd2 = txtPwd2.Text.Trim();
        string name = this.Session["unm"].ToString();
        bool b=DBComponent.update(name,fnm,lnm,add,id1,pwd1,id2,pwd2);
        Response.Redirect("Home.aspx");
    }
    protected void txtfnm_TextChanged(object sender, EventArgs e)
    {
        string fnm = txtfnm.Text.Trim();
    }
}