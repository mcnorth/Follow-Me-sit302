using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Follow_Me_sit302.Model;
using Follow_Me_sit302.Controllers;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace Follow_Me_sit302
{
    public partial class SendProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //session variable
            lblSession.Text = "Hello " + Session["name"].ToString();

            //creates connection and query
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='|DataDirectory|FollowMeDatabase.mdf'; Integrated Security=True");
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [_UserDetails] WHERE [userName] = '" + Session["name"] + "'", con);

            //checks user exists
            con.Open();
            rdr = cmd.ExecuteReader();
            int dataCount = 0;
            while (rdr.Read())
            {
                dataCount++;
            }
            con.Close();

            //if user exists add the user information to the text boxes
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
                    txtProFirstName.Text = (string)rdr["firstName"];
                    txtProLastName.Text = (string)rdr["lastName"];


                }

            }

            //if user doesnt exist leave blank
            else
            {
                txtProHouseNo.Text = "";
                txtProStreetName.Text = "";
                txtProSuburb.Text = "";
                txtProState.Text = "";
                txtProCountry.Text = "";
                txtProPostcode.Text = "";
                txtProEmail.Text = "";
                txtProFirstName.Text = "";
                txtProLastName.Text = "";
            }

            con.Close();
        }

        //button click to send data
        protected void btnSend_Click(object sender, EventArgs e)
        {
            //varible for drop down list
            string selBusiness = ddlSendPro.SelectedItem.Text;

            //variable for email of business
            string emailBus;

            //creates connection and query
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='|DataDirectory|FollowMeDatabase.mdf'; Integrated Security=True");
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [_Company] WHERE [companyName] = '" + selBusiness + "'", con);

            //open the connection and reads the database from query
            con.Open();
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                //adds the business email to the variable
                emailBus = (string)rdr["email"];

                //sends an email
                MailMessage msg = new MailMessage();
                msg.To.Add(emailBus);
                msg.From = new MailAddress(txtProEmail.Text);
                msg.Subject = "Change of details";
                msg.Body = "My updated records for your account. Please update ASAP  " +
                            "Name: " + txtProFirstName.Text + " " + txtProLastName.Text + " " +
                            "Address: " + txtProHouseNo.Text + " " + txtProStreetName.Text + " " + txtProSuburb.Text + " " + txtProState.Text + " " + txtProPostcode.Text + " " +
                            "Email: " + txtProEmail.Text + "";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("testingemaildeakin@gmail.com", "followme");
                smtp.Send(msg);

            }

            con.Close();


        }
    }
}