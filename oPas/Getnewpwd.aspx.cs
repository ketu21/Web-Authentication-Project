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
using System.Web;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
public partial class Getpwd : System.Web.UI.Page
{
         
    int s = 0,r=0;
    
    private mCore.SMS obSMS;
    string number="";
    protected void Page_Load(object sender, EventArgs e)
    {
        string pt = ConfigurationManager.AppSettings["port"].ToString();
            SMS sobj = (SMS)Application["SmsObject"];
            sobj.Stop();
            obSMS = new mCore.SMS();
            if (!obSMS.IsConnected)//&& cboPort.SelectedIndex > 0)
            {

                obSMS.Port = pt;
                obSMS.BaudRate = (mCore.BaudRate)(Convert.ToInt32("19200"));
                obSMS.DataBits = (mCore.DataBits)(Convert.ToInt32("8"));
                obSMS.Parity = (mCore.Parity)0;
                obSMS.StopBits = (mCore.StopBits)(1);
                obSMS.FlowControl = (mCore.FlowControl)0;
            }
            obSMS.Connect();
                obSMS.NewMessageIndication = true;
                obSMS.NewMessageReceived += new mCore.SMS.NewMessageReceivedEventHandler(this.newmsg);
                while (s != 1)
                {}
        if(r==1)
        {
            obSMS.Disconnect();
            sobj.Start();
            sobj.sendSMS(number, "Number Not Registered.");
            Response.Redirect("~/Home.aspx");
        }
        if(r==2)
        {
            obSMS.Disconnect();
            sobj.Start();
            sobj.sendSMS(number, "Failed to Change Password.");
            Response.Redirect("~/Home.aspx");
        }
        obSMS.Disconnect();
        sobj.Start();
                Response.Redirect("~/Menu.aspx");

    }

    public void newmsg(object sender, mCore.NewMessageReceivedEventArgs e)
    {
        mCore.SMS.NewMessageReceivedEventHandler instance = new mCore.SMS.NewMessageReceivedEventHandler(checkpss);
        instance.Invoke(sender, e);
    }
    private void checkpss(Object sender, mCore.NewMessageReceivedEventArgs e)
    {
        bool b,c;
        number = e.Phone;
        string name=this.Session["unm"].ToString();
        c = DBComponent.chknum(name, e.Phone.Trim());
        if (c)
        {
            b = DBComponent.changepwd(e.TextMessage, name);
            if (b)
            {
                s = 1;
            }
            else
            {
                s = 1;
            r=2;
            }
        }
        else
        {
            s = 1;
            r=1;
        }
    }   

}