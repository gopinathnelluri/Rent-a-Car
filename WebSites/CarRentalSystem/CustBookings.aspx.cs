using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustBookings : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string uid = Session["uid"].ToString();

        SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");
        SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Bookings,cars where Bookings.carid = cars.carId and bookings.uid="+uid+"", cn);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        Repeater1.DataSource = dt;
        Repeater1.DataBind();




    }
}