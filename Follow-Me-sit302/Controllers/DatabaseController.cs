using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Follow_Me_sit302.Model;

namespace Follow_Me_sit302.Controllers
{
    public class DatabaseController
    {
        //variable for connection to database
        private SqlConnection con;

        //constructor
        public DatabaseController()
        {

        }



        //string for path to database   
        public SqlConnection ConnectToDatabase()
        {

            return new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename='|DataDirectory|FollowMeDatabase.mdf'; Integrated Security=True");

        }

        //puts the data from the txt boxes into a list
        public Tuple<bool, string, List<MemberEntity>> AddMemberToList(MemberEntity member)
        {
            return AddMember(new List<MemberEntity> { member });

        }

        //puts the data from a database into a list
        public Tuple<bool, string, List<MemberEntity>> GetMemberToList(MemberEntity member)
        {
            return GetMember(new List<MemberEntity> { member });

        }

        //opens the database table, finds the member in the table and adds to a list
        public Tuple<bool, string, List<MemberEntity>> GetMember(List<MemberEntity> member)
        {
            SqlConnection con = ConnectToDatabase();
            SqlDataReader rdr = null;

            con.Open();

            int success = 0;
            int fail = 0;

            foreach (MemberEntity m in member)
            {
                if (DoesRecordExist(m.UserName))
                {

                    success++;
                }
                else
                    fail++;
            }

            //reply message for the status lable
            string returnMessage = "";
            bool returnBool = true;

            if (member.Count == 1)
            {
                if (success == 1)
                {
                    returnMessage = "Retrieved " + member[0].UserName + " successfully!";


                }
                else if (fail == 1)
                {
                    returnMessage = "A member with the user name " + member[0].UserName + " does not exists. Please choose another.";
                    returnBool = false;
                }
            }

            con.Close();
            return new Tuple<bool, string, List<MemberEntity>>(returnBool, returnMessage, member);

        }

        //adds new member to the database table
        public Tuple<bool, string, List<MemberEntity>> AddMember(List<MemberEntity> member)
        {
            SqlConnection con = ConnectToDatabase();
            SqlDataReader rdr = null;

            con.Open();

            int successAdd = 0;
            int duplicate = 0;

            foreach (MemberEntity m in member)
            {
                if (!DoesRecordExist(m.UserName))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO _User (userName, email, password)" +
                        "VALUES (@userName, @email, @password)", con);

                    cmd.Parameters.Add("@userName", System.Data.SqlDbType.VarChar).Value = m.UserName;
                    cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = m.Email;
                    cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = m.Password;

                    cmd.ExecuteNonQuery();
                    successAdd++;
                }
                else
                    duplicate++;
            }


            string returnMessage = "";
            bool returnBool = true;

            if (member.Count == 1)
            {
                if (successAdd == 1)
                {
                    returnMessage = "Added " + member[0].UserName + " successfully!";
                }
                else if (duplicate == 1)
                {
                    returnMessage = "A member with the user name " + member[0].UserName + " already exists. Please choose another.";
                    returnBool = false;
                }
            }

            con.Close();
            return new Tuple<bool, string, List<MemberEntity>>(returnBool, returnMessage, member);


        }


        //checks the database table for existing members
        private bool DoesRecordExist(string username)
        {
            SqlConnection con = ConnectToDatabase();
            SqlDataReader rdr = null;

            con.Open();

            // SqlCommand cmd = new SqlCommand("Select * from [Members] where [UserName] = " + username, con);
            SqlCommand cmd = new SqlCommand("SELECT * FROM [_User] WHERE [userName] = '" + username + "'", con);

            rdr = cmd.ExecuteReader();
            int dataCount = 0;

            while (rdr.Read())
            {
                dataCount++;
            }

            if (dataCount > 0)
                return true;
            else
                return false;
        }

        //public List<MemberEntity> GetUsers()
        //{
        //    SqlConnection con = ConnectToDatabase();
        //    List<MemberEntity> ExistingMembers = new List<MemberEntity>();
        //    SqlCommand cmd = new SqlCommand("select * from Members", con);
        //    SqlDataReader rdr = cmd.ExecuteReader();

        //    while (rdr.Read())
        //    {
        //        MemberEntity mem = new MemberEntity();
        //        mem.UserName = (string)rdr["UserName"];
        //        mem.Email = (string)rdr["Email"];
        //        mem.Password = (string)rdr["Password"];

        //        ExistingMembers.Add(mem);
        //    }

        //    return ExistingMembers;
        //}

    }
}