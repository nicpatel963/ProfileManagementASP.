using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class First : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            if (Session["UserName"] != null)
            {
                lblProfile.Text = "WELCOME " + Session["UserName"].ToString();
                btnLogout.Visible = true;
                btnManage.Visible = true;
            }
            else
            {
              

            }
        }
        else
        {

        }
    }

    protected void ImageButtonPlumber_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["UserName"] != null)
        {
            lblProfile.Text = "WELCOME " + Session["UserName"].ToString();
            Session["ServiceName"] = "plumber";
            Response.Redirect("Services.aspx");
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >if(confirm('login first')){ window.location ='Login.aspx' ;} else{ window.location ='First.aspx';}</script>");

            

        }
    }

    protected void ImageButtonPainter_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["UserName"] != null)
        {
            lblProfile.Text = "WELCOME " + Session["UserName"].ToString();
            Session["ServiceName"] = "painter";
            Response.Redirect("Services.aspx");
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >if(confirm('login first')){ window.location ='Login.aspx' ;} else{ window.location ='First.aspx';}</script>");
        }
    }

    protected void ImageButtonCarpenter_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["UserName"] != null)
        {
            lblProfile.Text = "WELCOME " + Session["UserName"].ToString();
            Session["ServiceName"] = "carpenter";
            Response.Redirect("Services.aspx");
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >if(confirm('login first')){ window.location ='Login.aspx' ;} else{ window.location ='First.aspx';}</script>");
        }
    }

    protected void ImageButtonChef_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["UserName"] != null)
        {
            lblProfile.Text = "WELCOME " + Session["UserName"].ToString();
            Session["ServiceName"] = "chef";
            Response.Redirect("Services.aspx");
        }
        else
        {
            Response.Write("<script LANGUAGE='JavaScript' >if(confirm('login first')){ window.location ='Login.aspx' ;} else{ window.location ='First.aspx';}</script>");
        }
    }


    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Contents.RemoveAll();
        btnLogout.Visible = false;
        btnManage.Visible = false;
        Response.Write("<script LANGUAGE='JavaScript' >alert('logout successful')</script>");
        Response.Redirect("First.aspx");

    }

   
    protected void btnManage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Services.aspx");
    }
}