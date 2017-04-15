using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using CarRentalSystem;
using System.Data.SqlClient;
using System.Diagnostics;

public partial class Account_Login : Page
{
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["login"] != null && Session["login"].ToString()=="true")
            {
            Response.Redirect("~/Default");
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {


        SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");

        try
        {

            string email, Password;
            email = Email.Text;
            Password = PassWord.Text;
            Debug.WriteLine(email);
            Debug.WriteLine(Password);

            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from users where email ='" + email + "' and password = '" + Password + "'", cn);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();


            Debug.WriteLine(sdr.HasRows);
            if (sdr.Read())
            {
                Label11.Text = "Login Successful";
                Label11.Visible = true;
                Session["uid"] = sdr.GetValue(0);
                Session["login"] = "true";
                Session["user"] = "user";
                Session["name"] = sdr.GetValue(3)+" "+sdr.GetValue(4);
                
                if(Session["backurl"]!=null && Session["backurl"].ToString() == "1")
                {
                    Response.Redirect("~/checkout");
                }
                else
                {
                    Response.Redirect("~/Default");
                }

            }
            else
            {
                Label11.Text = "Login Failed!";
                Label11.Visible = true;
                Session["uid"] = null;
                Session["login"] = "false";
                Session["name"] = null;
                Session["user"]= null;

            }
        }
        catch (SqlException)
        {
            Label11.Text = "Login Failed!";
            Label11.Visible = true;
        }
        finally
        {
            cn.Close();
        }










        /*
            if (IsValid)
            {
                // Validate the user password
                var manager = new UserManager();
                ApplicationUser user = manager.Find(UserName.Text, Password.Text);
                if (user != null)
                {
                    IdentityHelper.SignIn(manager, user, RememberMe.Checked);
                    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                }
                else
                {
                    FailureText.Text = "Invalid username or password.";
                    ErrorMessage.Visible = true;
                }
            }
            */
    }
}