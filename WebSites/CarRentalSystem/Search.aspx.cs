using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String name = null;
        if (!String.IsNullOrEmpty(Request.QueryString["name"]))
        {
            name = Request.QueryString["name"];
            name = name.ToLower();

            int n;
            bool isNumeric = int.TryParse(name, out n);
            Debug.WriteLine(isNumeric+"try parse");

            SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");
            if(isNumeric)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from cars,brands where cars.bid = brands.bid and (cars.mileage = " + name + " or brands.bname like '%" + name + "%' or cars.carname like '%" + name + "%')", cn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                Debug.WriteLine(name);
                Debug.WriteLine(dt.Rows.Count + "count");
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from cars,brands where cars.bid = brands.bid and (brands.bname like '%" + name + "%' or cars.carname like '%" + name + "%')", cn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                Debug.WriteLine(name);
                Debug.WriteLine(dt.Rows.Count + "count");
            }
            
        }



    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string Search = search.Text;
        if(!String.IsNullOrEmpty(Search))
        {
            Response.Redirect("Search?name="+Search);
        }
        
    }
}