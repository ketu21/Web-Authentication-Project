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

public partial class CodeVerification : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            txtunm.Text = this.Session["username"].ToString();
            txtMbno.Text = this.Session["mbno"].ToString();  
        }
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtunm.Text = this.Session["username"].ToString();
        txtMbno.Text = this.Session["mbno"].ToString();
        txtVcd.Text = "";
        txtadd.Text = "";
        txtfnm.Text = "";
        txtlnm.Text = "";
        txtLoginId.Text = "";
        txtLoginId2.Text="";
        txtPwd.Text="";
        txtPwd2.Text="";

    }
    protected void btnVerify_Click(object sender, EventArgs e)
    {
        bool b;
        b = DBComponent.checkverificationcode(txtunm.Text, txtVcd.Text.Trim());
        if (b)
        {
            string pwd = DBComponent.GeneratePassword();
            SMS sobj = (SMS)Application["SmsObject"];
            sobj.sendSMS(txtMbno.Text ,"oPas : " + pwd);
            DBComponent.updatePasswd(txtunm.Text,txtfnm.Text.Trim(),txtlnm.Text.Trim(),txtadd.Text.Trim(), pwd, txtLoginId.Text.Trim(), txtPwd.Text.Trim(), txtLoginId2.Text.Trim(), txtPwd2.Text.Trim(),DropDownList1.Text,txtans.Text.Trim()); 
            lblMsg.Text = "Password Sent To Your Mobile , Use It For Future Login By Sending It As SMS";
        }
        else
        {
            lblMsg.Text = "Please Specify Correct Verication Code as Received Through SMS";
        }
    }
    
}
