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

public partial class Forgotpass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnReg_Click(object sender, EventArgs e)
    {
        string name, num, pass;
        name = txtunm.Text;
        DataTable dt = DBComponent.getUser(name);
        if (dt != null)
        {
            num = dt.Rows[0]["MobileNo"].ToString();
            pass = dt.Rows[0]["Password"].ToString();

            SMS sobj = (SMS)Application["SmsObject"];
            sobj.sendSMS(num, "Your Password is : " + pass + ".    oPas - A User Verification Protocol");
            lblMsg.Text = "Password Sent on your Mobile";
        }
        else
        {
            lblMsg.Text = "User Name not Found";
        }
                
    }
}