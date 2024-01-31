using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UVEpaper
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                divMessage.Visible = false;
                txtUsername.Focus();
            }
        }

        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                lblMessage.Text = "Please enter username";
                divMessage.Visible = true;
                txtUsername.Focus();
            }
            else if (txtPassword.Text == "")
            {
                lblMessage.Text = "Please enter password";
                divMessage.Visible = true;
                txtPassword.Focus();
            }
            else if(txtUsername.Text != "admin")
            {
                lblMessage.Text = "Please enter valid username";
                divMessage.Visible = true;
                txtUsername.Focus();
            }
            else if (txtPassword.Text != "Manipal123")
            {
                lblMessage.Text = "Please enter valid password";
                divMessage.Visible = true;
                txtPassword.Focus();
            }
            else
            {
                Session.RemoveAll();
                Session.Add("Login", "Y");
                Response.Redirect("Home.aspx");
            }
        }
    }
}