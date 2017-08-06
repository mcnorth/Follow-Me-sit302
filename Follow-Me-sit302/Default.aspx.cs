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
    public partial class Default : System.Web.UI.Page
    {
        //variable for an object of the class DatabaseController
        public static DatabaseController databaseController = new DatabaseController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //button for business page
        protected void btnTemp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/business.aspx");
        }
       

        //button click from login
        //adds the data from the txt boxes to an object of MemberEntity class
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            MemberEntity member = new MemberEntity();
            member.UserName = txtlogusername.Text;
            member.Password = txtlogpassword.Text;


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='|DataDirectory|FollowMeDatabase.mdf'; Integrated Security=True");
            SqlDataReader rdr = null;

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [_User] WHERE [userName] = '" + member.UserName + "'", con);

            rdr = cmd.ExecuteReader();
            int dataCount = 0;

            while (rdr.Read())
            {
                dataCount++;
            }

            //checks for user in the database
            //adds a session if the user exists and redirects to userPage
            if (dataCount > 0)
            {
                Session["name"] = member.UserName;
                Response.Redirect("~/UserPage.aspx");
                Session.RemoveAll();
            }
            else
            {
                lbllogStatus.Text = "User does not exist";
            }

            con.Close();

        }
    }
}