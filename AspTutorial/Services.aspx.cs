using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Services : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserName"] != null)
            {
              
                lblProfile.Text = "WELCOME " + Session["UserName"].ToString();
                btnLogout.Visible = true;
            }
            else
            {

                Response.Write("<script LANGUAGE='JavaScript' >if(confirm('login first')){ window.location ='Login.aspx' ;} else{ window.location ='First.aspx';}</script>");
            }
        }
        
    }
    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Contents.RemoveAll();
        btnLogout.Visible = false;
        Response.Write("<script LANGUAGE='JavaScript' >alert('logout successful')</script>");
        Response.Redirect("~/First.aspx");

    }
}
