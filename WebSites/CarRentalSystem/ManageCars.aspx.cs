using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ManageCars : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] != null && Session["user"] != null && Session["login"].ToString() == "true" && Session["user"].ToString() == "admin")
        {

        }
        else
        {
            Response.Redirect("Default");
        }
    }

    protected void Car_Insert(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");

        try
        {


            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into cars(carname,bid,mileage,rent,seating,Availability) values('" + carname.Text + "','" + brand.Text + "','" + mileage.Text + "','" + rent.Text + "'," + seating.Text + ",'" + availability.Text + "')";
            int res = cmd.ExecuteNonQuery();

            if (res > 0)
            {
                Label11.Text = "car insertion Successful";
                Label11.Visible = true;
            }
        }
        catch (SqlException)
        {
            Label11.Text = "car insertion Failed";
            Label11.Visible = true;
        }
        finally
        {
            cn.Close();
        }

    }
}