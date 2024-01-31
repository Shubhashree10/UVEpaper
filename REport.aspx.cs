using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UVEpaper
{
    public partial class REport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] != null && Session["Login"].ToString() == "Y")
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}