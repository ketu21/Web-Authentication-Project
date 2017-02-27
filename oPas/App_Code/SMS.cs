using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

public class SMS
    {
        private mCore.SMS objSMS;
        private bool isRunning;
        private ManualResetEvent resetEventNewSMS;
        private bool stopRequested;
        private System.Threading.Thread workThreadSMSProcess;
        private string port;
        private string strMyAppName = "SMS Sender";
        private void SetCommParameters()
        {
            //Set communication parameters
            //check if port is already connected

            try
            {
                if (!objSMS.IsConnected)//&& cboPort.SelectedIndex > 0)
                {

                    objSMS.Port = port;
                    objSMS.BaudRate = (mCore.BaudRate)(Convert.ToInt32("19200"));
                    objSMS.DataBits = (mCore.DataBits)(Convert.ToInt32("8"));
                    objSMS.Parity = (mCore.Parity)0;
                    objSMS.StopBits = (mCore.StopBits)(1);
                    objSMS.FlowControl = (mCore.FlowControl)0;
                    //objSMS.DisableCheckPIN = chkDisableCheckPIN.Checked;
                }
            }
            catch (mCore.GeneralException ex)
            {
                // MessageBox.Show(ex.Message);//, strMyAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Trace.WriteLine(ex.Message);
            }
        }
        private void objSMS_NewMessageReceived(object sender, mCore.NewMessageReceivedEventArgs e)
        {
            //New Message Indication Event
            //Display the new message

            //MessageBox.Show("FROM: " + e.Phone + "\r\n\r\nDATE/TIME: " + e.TimeStampRFC + "\r\n\r\nMESSAGE:\r\n" + e.TextMessage, "NEW MESSAGE RECEIVED...", MessageBoxButtons.OK, MessageBoxIcon.None);
            mCore.SMS.NewMessageReceivedEventHandler instance = new mCore.SMS.NewMessageReceivedEventHandler(SendMSG);
            instance.Invoke(sender, e);

        }
        private void SendMSG(Object sender, mCore.NewMessageReceivedEventArgs e)
        {

            string smsMsg = DBComponent.userSession(e.TextMessage.Trim(),e.Phone);
            sendSMS(e.Phone, smsMsg);
            //Send the message
        }
        public void sendSMS(string phno, string msg)
        {
            if ((phno != "") & (msg != ""))
            {
                try
                {
                    string strSendResult = objSMS.SendSMS(phno, msg);

                  //  MessageBox.Show("Message Being sent! " + msg);//, strMyAppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Trace.WriteLine("Message sent!\r\n\r\n[Message Ref.: " + strSendResult + "]");
                }

                catch (mCore.SMSSendException ex)
                {
                    MessageBox.Show(ex.Message, strMyAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Trace.WriteLine(ex.Message);
                }
                catch (mCore.GeneralException ex)
                {
                    MessageBox.Show(ex.Message, strMyAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //  Trace.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, strMyAppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Trace.WriteLine(ex.Message);
                }

            }
        }
        public SMS(string prt)
        {
            objSMS = new mCore.SMS();
            isRunning = false;
            port = prt;
            SetCommParameters();
            if (objSMS.Connect())
            {
               
              //  MessageBox.Show("Connected", "oPas ...A User Authentication Protocol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                objSMS.NewMessageIndication = true;
                objSMS.NewMessageReceived += new mCore.SMS.NewMessageReceivedEventHandler(this.objSMS_NewMessageReceived);
            }


        }
        public void Start()
        {
            if (isRunning)
                return;

            workThreadSMSProcess = new System.Threading.Thread(new ThreadStart(ProcessSMS));
            workThreadSMSProcess.Start();
            isRunning = true;
        }
        public bool IsRunning
        {
            get
            {
                return isRunning;
            }
        }
        private void ProcessSMS()
        {
            // resetEventPOP = new ManualResetEvent(false);
            while (!stopRequested)
            {
                try
                {
                    objSMS.Connect();
                    objSMS.NewMessageIndication = true;
                    stopRequested = true;
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.Message);
                }

                TimeSpan runInterval = TimeSpan.FromSeconds(60);
                // resetEventNewSMS.WaitOne(runInterval, true);
            }
        }


        public void Stop()
        {
            //stopRequested = true;
            //  resetEventPOP.Set();
            workThreadSMSProcess.Join();
            isRunning = false;
            try
            {
                objSMS.Disconnect();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

            stopRequested = false;
        }

    }
