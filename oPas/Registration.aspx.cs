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

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnReg_Click(object sender, EventArgs e)
    {
        if (this.IsValid)
        {
            bool b;
            long vcd;
            vcd = DBComponent.GenerateVerification();
            b = DBComponent.userSignup(txtunm.Text.Trim(), txtMbno.Text.Trim(),vcd.ToString() );
            if (b)
            {
                lblMsg.Text = "Registered Successfully, Verification code Sent To Your Mobile";
                this.Session["username"] = txtunm.Text.Trim();
                this.Session["mbno"] = txtMbno.Text.Trim();
                SMS sobj = (SMS)Application["SmsObject"];
                sobj.sendSMS(txtMbno.Text.Trim(),"Your Verification Code is " + vcd.ToString() + "  oPas - A User Verification Protocol");
                BtnNext.Enabled = true;
                btnReg.Enabled = false;
            }
            else
            {
                lblMsg.Text = "Failed to Register,Try After Some Time";
            }
        }
        else
        {
            lblMsg.Text = "Please Correct The Errors";
        }
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {

    }
    protected void btnCheck_Click(object sender, EventArgs e)
    {
        bool b; 
        b=DBComponent.checkuser(txtunm.Text.Trim());
        if (!b)
        {
            lblMsg.Text = "User Name can be Taken";
            btnReg.Enabled = true;
        }
        else
        {
            lblMsg.Text = "User Name already Exist, Try Another One";
        }
    }


    protected void BtnNext_Click(object sender, EventArgs e)
    {
        this.Session["username"] = txtunm.Text.Trim();
        this.Session["mbno"] = txtMbno.Text.Trim();
        Response.Redirect("~/CodeVerification.aspx");
    }
}
