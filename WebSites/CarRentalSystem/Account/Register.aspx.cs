using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using CarRentalSystem;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {


        SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into users(email,password,firstname,lastname,gender,mobile,Address) values('" + Email.Text + "','" + Password.Text + "','" + FirstName.Text + "','" + LastName.Text + "'," + Gender.Text + ",'" + PhoneNumber.Text + "','" + Address.Text + "')";
            int res = cmd.ExecuteNonQuery();
            Debug.WriteLine(res);
            if (res > 0)
            {
                Label1.Text = "Registration Successful";
                Label1.Visible = true;
                if (Session["backurl"] != null && Session["backurl"].ToString() == "1")
                {
                    Response.Redirect("~/checkout");
                }
                else
                {
                    Response.Redirect("~/Default");
                }
            }
        }
        catch (SqlException)
        {
             Label1.Text = "Registration Failed";
            Label1.Visible = true;
        }
        finally
        {
            cn.Close();
        }

        
    }
}