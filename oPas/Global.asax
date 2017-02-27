<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        string pt = ConfigurationManager.AppSettings["port"].ToString();
        SMS smsObject = new SMS(pt);
        smsObject.Start();
        Application["SmsObject"] = smsObject;
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown
        try
        {
            SMS smsObject = (SMS)Application["SmsObject"];
            if (smsObject.IsRunning)
                smsObject.Stop();
        }
        catch (Exception exp)
        {
            System.Diagnostics.Trace.WriteLine(exp.ToString());
            System.Windows.Forms.MessageBox.Show(exp.Message);
        }
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
