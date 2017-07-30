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
    public partial class ViewProfile : System.Web.UI.Page
    {
        //as soon as page loads 
        protected void Page_Load(object sender, EventArgs e)
        {
            //session variable
            lblSession.Text = "Hello " + Session["name"].ToString();

            //sql connections and query
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='|DataDirectory|FollowMeDatabase.mdf'; Integrated Security=True");
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [_UserDetails] WHERE [userName] = '" + Session["name"] + "'", con);

            //opens connection reads the database as per the query
            //counts how many rows and adds to the variable datacount
            con.Open();
            rdr = cmd.ExecuteReader();
            int dataCount = 0;
            while (rdr.Read())
            {
                dataCount++;
            }
            con.Close();

            //if one row found reads the database annd adds the records to the specific text boxes
            if (dataCount > 0)
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {


                    txtProHouseNo.Text = (string)rdr["houseNumber"];
                    txtProStreetName.Text = (string)rdr["streetName"];
                    txtProSuburb.Text = (string)rdr["suburb"];
                    txtProState.Text = (string)rdr["stat"];
                    txtProCountry.Text = (string)rdr["country"];
                    txtProPostcode.Text = (string)rdr["postcode"];
                    txtProEmail.Text = (string)rdr["email"];
                    txtProUserName.Text = (string)rdr["userName"];
                    txtProFirstName.Text = (string)rdr["firstName"];
                    txtProLastName.Text = (string)rdr["lastName"];


                }

            }

            //if no records found leaves the text boxes blank
            else
            {
                txtProHouseNo.Text = "";
                txtProStreetName.Text = "";
                txtProSuburb.Text = "";
                txtProState.Text = "";
                txtProCountry.Text = "";
                txtProPostcode.Text = "";
                txtProEmail.Text = "";
                txtProUserName.Text = "";
                txtProFirstName.Text = "";
                txtProLastName.Text = "";
            }

            con.Close();


        }
    }
}