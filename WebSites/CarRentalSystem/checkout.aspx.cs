using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Booking : System.Web.UI.Page
{
    public string bid;
    public string bname;
    public string carname;
    public string carid;
    public int rent;
    public int months;
    public int amount;
    protected void Page_Load(object sender, EventArgs e)
    {
        if ( Session["months"]!=null && Session["carid"]!=null && Session["rent"]!=null)
        {
            if (Session["login"] != null && Session["user"] != null && Session["login"].ToString() == "true" && Session["user"].ToString() == "user")
            {
                bid = Session["bid"].ToString();
                bname = Session["bname"].ToString();
                carname = Session["carname"].ToString();
                carid = Session["carid"].ToString();
                int.TryParse(Session["rent"].ToString(), out rent);
                int.TryParse(Session["months"].ToString(), out months);
                amount = rent * months;


            }
            else
            {
                Response.Redirect("~/Account/Login");
            }
        }
        else
        {
            Response.Redirect("~/Default");
        }
    }

    protected void Button1_Click(object sender, EventArgs SqlException)
    {
        String uid, carid, months, amount, card, date1;
        uid = Session["uid"].ToString();
        carid = Request.Form["carid"].ToString();
        months = Request.Form["months"].ToString();
        date1 = Request.Form["pickup"].ToString();
        card = Request.Form["card"].ToString();
        amount = Request.Form["amount"].ToString();
        card = card.Substring(card.Length - 4);
        card = "****-****-****-" + card;
        SqlConnection cn = new SqlConnection("Data Source=dcm.uhcl.edu; Database=c563315fa02g3; uid=c563315fa02g3; pwd=5989040");
        try
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into bookings(uid,carid,date,amount,time,card) values(" +uid + "," + carid + ",'" + date1 + "'," + amount + ",'" + months + "','" + card + "')";
            int res = cmd.ExecuteNonQuery();
            Debug.WriteLine(res);
            if (res > 0)
            {
                Session["months"] = null;
                Session["carid"] = null;
                Session["rent"] = null;
                Session["bid"] = null;
                Session["carname"] = null;
                Session["bname"] = null;
                Response.Redirect("Success");

            }
        }
        catch (SqlException)
        {
            Debug.WriteLine(SqlException);
        }
        finally
        {
            cn.Close();
        }




    }
}