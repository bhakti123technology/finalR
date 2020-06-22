using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Indivsolvepbl : System.Web.UI.Page
{
    private SqlDataAdapter adapter;
    private SqlCommand cmd;
    private SqlConnection con;
    private string dateFormat;
    private DataTable dt;

    protected void Page_Load(object sender, EventArgs e)
    {
        string name = Session["username"].ToString();
        string conString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        try
        {
           
            con = new SqlConnection(conString);
            con.Open();
            cmd = new SqlCommand("Select Place,Incident,date  from tbl_info2 where name='" + name+"'", con);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
}