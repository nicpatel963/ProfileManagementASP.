﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class SignUp : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSignUp_Click(object sender, EventArgs e)
    {
        //String cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.AppContext.BaseDirectory + @"App_Data\UserManagement.mdf" + ";Integrated Security=True;Connect Timeout=30";

        String cs = ConfigurationManager.ConnectionStrings["DBLOGIN"].ConnectionString;
        SqlConnection conn = new SqlConnection(cs);
        conn.Open();
        SqlCommand cmd = new SqlCommand("insert into UserLogin (UserName,Password,ContectNumber,Address) values('"+TextBoxUsername.Text+"','"+TextBoxPassword.Text+"','"+TextBoxContectNumber.Text+"','"+TextBoxAddress.Text+"' )",conn);
        cmd.ExecuteNonQuery();
        conn.Close();

    }

}