using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Follow_Me_sit302.Controllers;
using Follow_Me_sit302.Model;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Follow_Me_sit302
{
    public partial class Register : System.Web.UI.Page
    {
        //variable for an object of the class DatabaseController
        public static DatabaseController databaseController = new DatabaseController();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //button click from login
        //adds the data from the txt boxes to an object of MemberEntity class
        protected void btnregister_Click(object sender, EventArgs e)
        {
            MemberEntity member = new MemberEntity();
            member.UserName = txtregname.Text;
            member.Password = txtregpassword.Text;
            //member.HouseNumber = Convert.ToInt32(txtRegHouseNumber.Text);
            //member.StreetName = txtRegStreet.Text;
            //member.Suburb = txtRegSuburb.Text;
            //member.State = txtRegState.Text;
            //member.Country = txtRegCountry.Text;
            //member.Postcode = Convert.ToInt32(txtRegPostcode.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='|DataDirectory|FollowMeDatabase.mdf'; Integrated Security=True");
            SqlDataReader rdr = null;
            //SqlDataReader insertRdr = null;


            SqlCommand cmd = new SqlCommand("SELECT * FROM [_User] WHERE [userName] = '" + member.UserName + "'", con);
            SqlCommand insertCmd = new SqlCommand("INSERT INTO _User (userName, password)" +
                        "VALUES (@userName, @password)", con);

            con.Open();
            rdr = cmd.ExecuteReader();
            int dataCount = 0;

            while (rdr.Read())
            {

                dataCount++;

            }

            con.Close();

            if (dataCount > 0)
            {
                lblregStatus.Text = "UserName already exists, please choose another";
                //Response.Redirect("~/UserPage.aspx");
            }
            else
            {
                insertCmd.Parameters.Add("@userName", System.Data.SqlDbType.VarChar).Value = member.UserName;
                insertCmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = member.Password;

                con.Open();
                insertCmd.ExecuteNonQuery();
                con.Close();
                lblregStatus.Text = "" + member.UserName + "successfully added. Please log in.";

            }

            //create a tuple for different replies for the status lable
            //Tuple<bool, string, List<MemberEntity>> reply = databaseController.AddMemberToList(member);
            //lblregStatus.Text = reply.Item2;



        }
    }
}