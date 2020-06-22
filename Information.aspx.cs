using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Information : System.Web.UI.Page
{
    private object date;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click2(object sender, EventArgs e)
    {
        String name = Session["username"].ToString();
      //  DateTime datetime = Convert.ToDateTime(date.date);
       string date=Request.Form["date"];
     // DateTime oDate = Convert.ToDateTime(date);
        string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Insert Into tbl_info1(Place,Incident,date,Name)values('" + TextBox4.Text + "','" + TextBox5.Text + "','" + date + "','"+name+"')";
        cmd.Parameters.AddWithValue("Place",TextBox4.Text);
        cmd.Parameters.AddWithValue("Incident", TextBox5.Text);
        cmd.Parameters.AddWithValue("date", date);
        cmd.Parameters.AddWithValue("Name", name);
        cmd.ExecuteNonQuery();
        Response.Write("<script LANGUAGE='JavaScript' >alert('Information add Successfully...')</script>");
        Response.Redirect("KingMainFrm.aspx");
       // Button2.Visible = false;

    }
}