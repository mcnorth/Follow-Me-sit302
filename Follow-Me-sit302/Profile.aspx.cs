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
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //adds the seesion variable
            lblSession.Text = "Hello " + Session["name"].ToString();

        }

        //button click to update profile
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //adds user input from the text boxes to an object
            MemberEntity member = new MemberEntity();
            member.UserName = txtProUserName.Text;
            member.Email = txtProEmail.Text;
            member.FirstName = txtProFirstName.Text;
            member.LastName = txtProLastName.Text;
            member.HouseNumber = txtProHouseNo.Text;
            member.StreetName = txtProStreetName.Text;
            member.Suburb = txtProSuburb.Text;
            member.State = txtProState.Text;
            member.Country = txtProCountry.Text;
            member.Postcode = txtProPostcode.Text;

            //creates connection and queries
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='|DataDirectory|FollowMeDatabase.mdf'; Integrated Security=True");
            SqlDataReader rdr = null;


            SqlCommand cmd = new SqlCommand("SELECT * FROM [_UserDetails] WHERE [userName] = '" + member.UserName + "'", con);

            SqlCommand modify = new SqlCommand("UPDATE _UserDetails SET houseNumber=@houseNumber, streetName=@streetName, suburb=@suburb, stat=@stat, country=@country, postcode=@postcode, userName=@userName, firstName=@firstName, lastName=@lastName, email=@email", con);

            SqlCommand insert = new SqlCommand(" INSERT INTO _UserDetails (houseNumber, streetName, suburb, stat, country, postcode, email, userName, firstName, lastName)" +
                                    "VALUES (@houseNumber, @streetName, @suburb, @stat, @country, @postcode, @email, @userName, @firstName, @lastName)", con);


            SqlCommand insertId = new SqlCommand("UPDATE _UserDetails SET followMeId = (SELECT followMeId FROM _User WHERE userName = @userName) WHERE userName=@userName", con);


            //checks the database to see if user exists
            con.Open();
            rdr = cmd.ExecuteReader();
            int dataCount = 0;

            while (rdr.Read())
            {
                dataCount++;
            }
            con.Close();

            //if user exists update the database from user input
            if (dataCount > 0)
            {
                modify.Parameters.Add("@houseNumber", System.Data.SqlDbType.VarChar).Value = member.HouseNumber;
                modify.Parameters.Add("@streetName", System.Data.SqlDbType.VarChar).Value = member.StreetName;
                modify.Parameters.Add("@suburb", System.Data.SqlDbType.VarChar).Value = member.Suburb;
                modify.Parameters.Add("@stat", System.Data.SqlDbType.VarChar).Value = member.State;
                modify.Parameters.Add("@country", System.Data.SqlDbType.VarChar).Value = member.Country;
                modify.Parameters.Add("@postcode", System.Data.SqlDbType.VarChar).Value = member.Postcode;
                modify.Parameters.Add("@userName", System.Data.SqlDbType.VarChar).Value = member.UserName;
                modify.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar).Value = member.FirstName;
                modify.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar).Value = member.LastName;
                modify.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = member.Email;

                con.Open();
                modify.ExecuteNonQuery();
                con.Close();
                lblProStatus.Text = "Details succesfully updated.";
            }

            //if user doesnt exist adds the user input to database
            else
            {
                insert.Parameters.Add("@houseNumber", System.Data.SqlDbType.VarChar).Value = member.HouseNumber;
                insert.Parameters.Add("@streetName", System.Data.SqlDbType.VarChar).Value = member.StreetName;
                insert.Parameters.Add("@suburb", System.Data.SqlDbType.VarChar).Value = member.Suburb;
                insert.Parameters.Add("@stat", System.Data.SqlDbType.VarChar).Value = member.State;
                insert.Parameters.Add("@country", System.Data.SqlDbType.VarChar).Value = member.Country;
                insert.Parameters.Add("@postcode", System.Data.SqlDbType.VarChar).Value = member.Postcode;
                insert.Parameters.Add("@userName", System.Data.SqlDbType.VarChar).Value = member.UserName;
                insert.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar).Value = member.FirstName;
                insert.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar).Value = member.LastName;
                insert.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = member.Email;

                insertId.Parameters.Add("@userName", System.Data.SqlDbType.VarChar).Value = member.UserName;

                con.Open();
                insert.ExecuteNonQuery();
                insertId.ExecuteNonQuery();
                con.Close();



                lblProStatus.Text = "Details succesfully updated.";

            }
        }
    }
}