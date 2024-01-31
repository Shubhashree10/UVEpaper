using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UVEpaper
{
    public partial class pdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["path"] != null)
            {
                Response.ContentType = "Application/pdf";
                Response.AddHeader("content-disposition", "inline; filename=123.pdf");
                Response.Write(Request.QueryString["path"]);
                Response.End();
            }
        }
    }
}