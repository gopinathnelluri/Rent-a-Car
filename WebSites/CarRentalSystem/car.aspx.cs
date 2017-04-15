using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class car : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String id = null;
        if (!String.IsNullOrEmpty(Request.QueryString["id"]))
        {
            id = Request.QueryString["id"];
            
            int n;
            bool isNumeric = int.TryParse(id, out n);
            Debug.WriteLine(isNumeric + "try parse");

            SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");
            if (isNumeric)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from cars,brands where cars.bid = brands.bid and cars.carid =" + id, cn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                Debug.WriteLine(id);
                Debug.WriteLine(dt.Rows.Count + "count");
            }

            if(Session["login"] != null && Session["user"] != null && Session["login"].ToString() == "true" && Session["user"].ToString() == "admin")
            {
                Response.Redirect("Default");
            }
            

        }



    }

    protected void Checkout(object sender, EventArgs e)
    {
        Session["months"] = Request.Form["months"].ToString();
        Session["carid"] = Request.Form["carid"].ToString();
        Session["rent"] = Request.Form["rent"].ToString();
        Session["bid"] = Request.Form["bid"].ToString();
        Session["carname"] = Request.Form["carname"].ToString();
        Session["bname"] = Request.Form["bname"].ToString();

        if (Session["login"] != null && Session["user"] != null && Session["login"].ToString() == "true" && Session["user"].ToString() == "user")
        {
            Debug.WriteLine("success");
            Response.Redirect("checkout");
        }
        else
        {
            Debug.WriteLine("failed");
            Session["backurl"] = "1";
            Response.Redirect("~/Account/Login");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string Search = search.Text;
        if (!String.IsNullOrEmpty(Search))
        {
            Response.Redirect("Search?name=" + Search);
        }

    }
}