using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // String cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.AppContext.BaseDirectory + @"App_Data\UserManagement.mdf" + ";Integrated Security=True;Connect Timeout=30";

        String cs = ConfigurationManager.ConnectionStrings["DBLOGIN"].ConnectionString;
        SqlConnection conn = new SqlConnection(cs);
        
        conn.Open();
        SqlCommand cmd = new SqlCommand("select Username from UserLogin where Username=@u and Password=@p ", conn);
        cmd.Parameters.AddWithValue("@u", TextBoxUsername.Text);
        cmd.Parameters.AddWithValue("@p", TextBoxPassword.Text);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            Session["UserName"] = TextBoxUsername.Text;
            Response.Redirect("~/First.aspx");
            
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >alert('invalid user')</script>");
            TextBoxPassword.Text = "";
        }
        conn.Close();

    }

    protected void LinkButtonSignUp_Click(object sender, EventArgs e)
    {

    }
}