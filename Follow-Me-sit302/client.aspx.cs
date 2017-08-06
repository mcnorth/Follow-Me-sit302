using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Follow_Me_sit302.Model;
using Follow_Me_sit302.Controllers;
using System.Data.SqlClient;

namespace Follow_Me_sit302
{
    public partial class client : System.Web.UI.Page
    {
        //variable for an object of the class DatabaseController
        public static DatabaseController databaseController = new DatabaseController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserPage.aspx");
        }

        //button for business page
        protected void btnfind_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserPage.aspx");
        }


        //button click from login
        //adds the data from the txt boxes to an object of MemberEntity class
       

        
    }
}