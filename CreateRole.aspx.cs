using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Createuserrole : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string name = Request.Form["username"];
        string password = Request.Form["pwd"];
        string role = Request.Form["role"];
        string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand com = new SqlCommand("insert into tbl_login(Name,Password,role) values ('" +name+ "','" + password + "','" + role + "')", con);
        com.Parameters.AddWithValue("Name",name);
        com.Parameters.AddWithValue("Password", password);
        com.Parameters.AddWithValue("role", role);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
        Response.Write("<script LANGUAGE='JavaScript' >alert('New User Added Successfully')</script>");
    }
}
