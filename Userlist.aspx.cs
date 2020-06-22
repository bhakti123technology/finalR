using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Userlist : System.Web.UI.Page
{
    private SqlDataAdapter adapter;
    private SqlCommand cmd;
    private SqlConnection con;
    private string dateFormat;
    private DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string demo = DropDownList2.Text;
        demo = "King";
        string conString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        
        using (SqlConnection con = new SqlConnection(conString))
        {
            con.Open();
            string sql1 = "UPDATE tbl_login SET  role='" + demo + "' where Name='" + DropDownList1.Text + "'";

            using (SqlCommand cmd = new SqlCommand(sql1, con))
            {
                cmd.Parameters.Add(new SqlParameter("role", demo));
                cmd.ExecuteNonQuery();
                con.Close();
            }
            Response.Write("<script LANGUAGE='JavaScript' >alert('Role Assign Successfully...')</script>");
        }

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string role = Request.Form["role"];
            string conString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            con = new SqlConnection(conString);
            string QueryString = "select * from tbl_login where Name='" + DropDownList1.Text + "'";

            SqlDataAdapter myCommand = new SqlDataAdapter(QueryString, con);
            DataSet ds = new DataSet();
            myCommand.Fill(ds, "tbl_login");

            DropDownList2.DataSource = ds;
            DropDownList2.DataTextField = "role";
            DropDownList2.DataValueField = "role";
            DropDownList2.DataBind();
        }
        catch
        {

        }
    }
}