using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class adminlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string conString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string name1 = Request.Form["txtUsername"];
        string pwd1 = Request.Form["txtpassword"];
        string role = null;
        //string role1="false";
    
        SqlConnection con = new SqlConnection(conString);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_login where Name='" + name1 + "' AND Password='" + pwd1 + "'", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
           String name  = dt.Rows[0][1].ToString();
           String pwd= dt.Rows[0][2].ToString();
         String role1 = dt.Rows[0][3].ToString();
            Session["username"] = name;
            Session["Paaword"] = pwd;
            Session["role"] = role1;
           if( role1=="King")
            {
                Response.Redirect("~/KingMainFrm.aspx");
            }
           else
            {
                Response.Redirect("~/MinisterMainFrm.aspx");

            }
          //  role = "true";
          //  Response.Redirect("~/KingMainFrm.aspx");
       }
        //else
        //{
        //    role1 = "false";
        //   Response.Redirect("~/MinisterMainFrm.aspx");

        //}
      

        //  Response.Write("<script LANGUAGE='JavaScript' >alert('Login Successful')</script>");
    }
}