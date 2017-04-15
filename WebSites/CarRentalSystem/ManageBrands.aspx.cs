using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class ManageBrands : System.Web.UI.Page
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

    protected void Brand_Insert(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");

        try
        {


            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into brands(bname) values('" + BrandName.Text.ToUpper() + "')";
            int res = cmd.ExecuteNonQuery();
        
            if (res > 0)
            {
                Label11.Text = "Brand insertion Successful";
                Label11.Visible = true;
            }
        }
        catch (SqlException)
        {
            Label11.Text = "Brand insertion Failed";
            Label11.Visible = true;
        }
        finally
        {
            cn.Close();
        }

    }
    }