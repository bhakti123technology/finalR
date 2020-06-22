using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class MinisterMainFrm : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = Session["username"].ToString();

      
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        foreach (GridViewRow g1 in GridView1.Rows)
        {
            CheckBox CheckBox1 = (CheckBox)g1.FindControl("CheckBox1");
            if (CheckBox1.Checked)
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand("insert into tbl_info2(id,Name,Place,Incident,date) values ('" + g1.Cells[0].Text + "','" + name + "','" + g1.Cells[1].Text + "','" + g1.Cells[2].Text + "','" + g1.Cells[3].Text + "')", con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                SqlConnection con1 = new SqlConnection(connectionString);
                SqlCommand com1 = new SqlCommand("delete from tbl_info1 where Id='"+g1.Cells[0].Text+"'", con1);
                con1.Open();
                com1.ExecuteNonQuery();
                con1.Close();
            }
            GridView1.DataBind();
        }
   
    }
   
}

