using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Follow_Me_sit302.Controllers;

namespace Follow_Me_sit302
{
    public partial class notification : System.Web.UI.Page
    {
        public static DatabaseController databaseController = new DatabaseController();
        protected void Page_Load(object sender, EventArgs e)
        {
            //session variable
         /* lblSession.Text = "Hello " + Session["name"].ToString();*/
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/business.aspx");
        }

        //button for business page
        protected void btnfind_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/business.aspx");
        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/business.aspx");


        }
    }
}