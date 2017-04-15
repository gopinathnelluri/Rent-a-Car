using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");
        SqlDataAdapter sda = new SqlDataAdapter("select bid,bname from brands", cn);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        Repeater1.DataSource = dt;
        Repeater1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string Search = search.Text;
        if (!String.IsNullOrEmpty(Search))
        {
            Response.Redirect("Search?name=" + Search);
        }

    }

    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

      //  String Username, Password;
    //    Username = Login1.UserName.ToString();
      //  Password = Login1.Password.ToString();


        /*SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");
        cn.Open();
        SqlCommand cmd = new SqlCommand("select * from users where username ='" + Username + "' and password = '"+Password+"'", cn);
        SqlDataReader sdr;
        sdr = cmd.ExecuteReader();
        sdr.Read();
        Debug.WriteLine(sdr.GetValue(0));
        */



    }

}