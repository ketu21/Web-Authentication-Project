using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;
using System.Text.RegularExpressions;
/// <summary>
/// Summary description for DBComponent
/// </summary>
public class DBComponent
{
    static SqlConnection cn;
    static SqlCommand cmd;
    static SqlDataAdapter da;
    static DataSet ds;
    public string host;


    public DBComponent()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static bool userSignup(string unm, string mbno, string vd)
    {

        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd = new SqlCommand();
        cmd.CommandText = "insert into Registrations values(@nm,@pd,@add,@mbn,@vcode,@lid,@lpd,@lid2,@lpd2,@fnm,@lnm,@que,@ans)";
        // cmd.Parameters.AddWithValue("@uid", ud);
        cmd.Parameters.AddWithValue("@nm", unm);
        cmd.Parameters.AddWithValue("@pd", "");
        cmd.Parameters.AddWithValue("@add", "");
        cmd.Parameters.AddWithValue("@mbn","+91"+ mbno);
        cmd.Parameters.AddWithValue("@vcode",vd);
        cmd.Parameters.AddWithValue("@lid","");
        cmd.Parameters.AddWithValue("@lpd","");
        cmd.Parameters.AddWithValue("@lid2", "");
        cmd.Parameters.AddWithValue("@lpd2", "");
        cmd.Parameters.AddWithValue("@fnm", "");
        cmd.Parameters.AddWithValue("@lnm", "");
        cmd.Parameters.AddWithValue("@que", "");
        cmd.Parameters.AddWithValue("@ans", "");
        cmd.Connection = cn;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
            return true;
        else
            return false;

    }
    public static String userSession(string pwd,string mbno)
    {

        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();    
        cmd = new SqlCommand();
        cmd.CommandText = "Select * from Registrations where Password='" + pwd + "' and MobileNo='"+mbno+"'";
        cmd.Connection = cn;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "Registrations");
        if (ds.Tables["Registrations"].Rows.Count > 0)
        {
            String unm = ds.Tables["Registrations"].Rows[0]["Username"].ToString();
           
            cn.Open();
            cmd = new SqlCommand(); 
            cmd.CommandText = "insert into Session_Info values(@nm,@pd,@mbn,@lgn)";
           
            cmd.Parameters.AddWithValue("@nm", unm);
            cmd.Parameters.AddWithValue("@pd",pwd);
            cmd.Parameters.AddWithValue("@mbn", mbno);
            cmd.Parameters.AddWithValue("@lgn","N");
            cmd.Connection = cn;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                return "Session Mainatined !!! Try Logging";
            else
                return "Failed To Maintain Your Session!!! Kindly Try after sometime";
        }
        else
            return "Please Check your Password";

    }
    public static bool updatePasswd(string unm,string fnm,string lnm, string add, string pd, string lid, string lpwd, string lid2, string lpwd2,string squ, string ans)
    {

        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd = new SqlCommand();
        cmd.CommandText = "update Registrations set Password=@pwd,Address=@add,LoginID=@lg,LoginPwd=@lpwd,LoginID2=@lg2,LoginPwd2=@lpwd2,Fname=@fnm,Lname=@lnm,Secque=@squ,Secans=@ans where Username=@nm";
        cmd.Parameters.AddWithValue("@pwd",pd);
        cmd.Parameters.AddWithValue("@add", add);
        cmd.Parameters.AddWithValue("@nm", unm);
        cmd.Parameters.AddWithValue("@lg", lid);
        cmd.Parameters.AddWithValue("@lpwd",lpwd );
        cmd.Parameters.AddWithValue("@lg2", lid2);
        cmd.Parameters.AddWithValue("@lpwd2", lpwd2);
        cmd.Parameters.AddWithValue("@fnm", fnm);
        cmd.Parameters.AddWithValue("@lnm", lnm);
        cmd.Parameters.AddWithValue("@squ", squ);
        cmd.Parameters.AddWithValue("@ans", ans);
        cmd.Connection = cn;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
            return true;
        else
            return false;

    }
    public static bool delete()
    {
        string pd = "";
        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd = new SqlCommand();
        cmd.CommandText = "delete from Registrations  where Password=@pwd";
        cmd.Parameters.AddWithValue("@pwd", pd);
       
        cmd.Connection = cn;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
            return true;
        else
            return false;

    }
    public static bool chknum(string nm, string mbno)
    {
        cmd = new SqlCommand();
        
        cmd.CommandText = "select * from Registrations where Username='" + nm + "' and MobileNo='"+ mbno+"' ";
        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd.Connection = cn;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "Registrations");
        if (ds.Tables["Registrations"].Rows.Count > 0)
            return true;
        else
            return false;
    }

   

    public static bool chkmbno(string mbno)
    {
        cmd = new SqlCommand();

        cmd.CommandText = "select * from Registrations where MobileNo='" + mbno + "' ";
        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd.Connection = cn;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "Registrations");
        if (ds.Tables["Registrations"].Rows.Count > 0)
            return false;
        else
            return true;
    }
    public static bool changepwd(string pwd,string nm)
    {

        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd = new SqlCommand();
        cmd.CommandText = "update Registrations set Password=@pwd where Username=@nm ";
        cmd.Parameters.AddWithValue("@pwd", pwd);
  
        cmd.Parameters.AddWithValue("@nm", nm);
        
        cmd.Connection = cn;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
            return true;
        else
            return false;

    }
    public static bool changenum(string pwd, string nm,string num)
    {

        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd = new SqlCommand();
        cmd.CommandText = "update Registrations set MobileNo=@num where Username=@nm and Password=@pwd ";
        cmd.Parameters.AddWithValue("@pwd", pwd);
        cmd.Parameters.AddWithValue("@num", num);
        cmd.Parameters.AddWithValue("@nm", nm);

        cmd.Connection = cn;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
            return true;
        else
            return false;

    }

    public static bool update(string unm, string fnm, string lnm, string add, string lid, string lpwd, string lid2, string lpwd2)
    {

        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd = new SqlCommand();
        cmd.CommandText = "update Registrations set Fname=@fnm,Lname=@lnm,Address=@add,LoginID=@lg,LoginPwd=@lpwd,LoginID2=@lg2,LoginPwd2=@lpwd2 where Username=@nm";
        
        cmd.Parameters.AddWithValue("@fnm", fnm);
        cmd.Parameters.AddWithValue("@lnm", lnm);
        cmd.Parameters.AddWithValue("@add", add);
        cmd.Parameters.AddWithValue("@nm", unm);
        cmd.Parameters.AddWithValue("@lg", lid);
        cmd.Parameters.AddWithValue("@lpwd", lpwd);
        cmd.Parameters.AddWithValue("@lg2", lid2);
        cmd.Parameters.AddWithValue("@lpwd2", lpwd2);
        cmd.Connection = cn;
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
            return true;
        else
            return false;

    }
    public static DataTable getUser(String unm)
    {
        cmd = new SqlCommand();
        cmd.CommandText = "select * from Registrations where Username='" + unm + "'";
        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd.Connection = cn;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "Registrations");
        if (ds.Tables["Registrations"].Rows.Count > 0)
            return ds.Tables["Registrations"];
        else
            return null;


    }

       
    public static DataTable getPOP3AccountForUser(String unm)
    {
        cmd = new SqlCommand();
        cmd.CommandText = "select LoginID,LoginPwd,LoginID2,LoginPwd2 from Registrations where Username='" + unm + "'";
        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd.Connection = cn;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "Registrations");
        if (ds.Tables["Registrations"].Rows.Count > 0)
            return ds.Tables["Registrations"];
        else
            return null;


    }
    public static bool checkuser(string unm)
    {
        cmd = new SqlCommand();
        cmd.CommandText = "select * from Registrations where Username='" + unm + "'";
        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd.Connection = cn;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "Registrations");
        if (ds.Tables["Registrations"].Rows.Count > 0)
            return true;
        else
            return false;
    }
    public static bool authenticateUser(string unm)
    {
        cmd = new SqlCommand();
        cmd.CommandText = "select * from Session_Info where Username='" + unm + "' ";
        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd.Connection = cn;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "Session_Info");
        if (ds.Tables["Session_Info"].Rows.Count > 0)
            return true;
        else
            return false;
    }
    public static bool deleteSession(string unm)
    {
        cmd = new SqlCommand();
        cmd.CommandText = "delete from Session_Info where Username='" + unm + "'";
        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd.Connection = cn;
        int i = cmd.ExecuteNonQuery();
        cn.Close();
        if (i > 0)
            return true;
        else
            return false;
    }
    public static bool checkverificationcode(string unm, string vcd)
    {
        cmd = new SqlCommand();
        cmd.CommandText = "select * from Registrations where Username='" + unm + "' and VerrificationCode ='" + vcd + "'" ;
        cn = new SqlConnection();
        cn.ConnectionString = WebConfigurationManager.ConnectionStrings["constring"].ToString();
        cn.Open();
        cmd.Connection = cn;
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds, "Registrations");
        if (ds.Tables["Registrations"].Rows.Count > 0)
            return true;
        else
            return false;
    }
    public static Int64 GenerateVerification()
    {
        Random random = new Random((int)DateTime.Now.Ticks); StringBuilder builder = new StringBuilder();
        string s;
        for (int i = 0; i < 4; i++)
        {
            s = Convert.ToString(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))); builder.Append(s);
        }
        return Convert.ToInt64((builder.ToString()));
    }

    public  static string GeneratePassword()
    {
        int password; password = 6;
        string _allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789"; Random randNum = new Random();
        StringBuilder builder = new StringBuilder(); char[] chars = new char[password];
        int allowedCharCount = _allowedChars.Length; string pwd;
        pwd = string.Empty;
        for (int i = 0; i < password; i++)
        {
            pwd = pwd + _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
        }
        return pwd;
        //TextBox1.Text=chars.ToString(); // 
    }
}
