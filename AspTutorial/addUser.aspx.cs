using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["UserName"]==null)
        {
            Response.Redirect("Login.aspx");
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        {
            if (Session["UserName"] != null)
            {
                // String cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.AppContext.BaseDirectory + @"App_Data\UserManagement.mdf" + ";Integrated Security=True;Connect Timeout=30";

                string cs = ConfigurationManager.ConnectionStrings["DBLOGIN"].ConnectionString;
                SqlConnection conn = new SqlConnection(cs); conn.Open();
                FileUpload1.SaveAs(Server.MapPath("~/Pictures/") + Path.GetFileName(FileUpload1.FileName));
                String image = "Pictures/" + Path.GetFileName(FileUpload1.FileName);

                SqlCommand cmd = new SqlCommand("insert into UserInfo (FirstName,LastName,DOB,age,image) values('" + TextBoxFirstName.Text+ "','" + TextBoxLastName.Text + "','" + TextBoxDob.Text + "','" + TextBoxAge.Text + "','"+image+"' )", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("Services.aspx");


            }
            else
            {

                Response.Write("<script LANGUAGE='JavaScript' >if(confirm('login first')){ window.location ='Login.aspx' ;} else{ window.location ='First.aspx';}</script>");
            }
        }
    }
}