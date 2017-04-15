using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Session["uid"] = null;
        Session["login"] = "false";
        Session["user"] = null;
        Session["name"] = null;

        if(Session["uid"]==null && Session["login"]== "false")
        {
            Response.Redirect("Default");
        }

    }
}