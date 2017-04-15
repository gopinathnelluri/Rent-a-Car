using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_AdminLogin : Page
{
    protected void Admin_LogIn(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");

        try
        {

            String Username, Password;
            Username = UserName.Text;
            Password = PassWord.Text;
            Debug.WriteLine(Username);
            Debug.WriteLine(Password);
        
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from admin where username ='" + Username + "' and password = '"+Password+"'", cn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            
        



            Debug.WriteLine(sdr.HasRows);
            if (sdr.Read())
            {
               Label11.Text = "Login Successful";
               Label11.Visible = true;
                Session["user"] = "admin";
                Session["login"] = "true";
                Response.Redirect("~/AdminHome");
            }
        }
        catch (SqlException)
        {
            Label11.Text = "Login Failed";
           Label11.Visible = true;
        }
        finally
        {
            cn.Close();
        }










    }
}
 