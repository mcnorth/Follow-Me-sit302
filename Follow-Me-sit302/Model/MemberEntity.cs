using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Linq.Mapping; //maps data to sql table

namespace Follow_Me_sit302.Model
{
    //class to hold data from txt boxes
    //adds data to the column that has the same name as in the database
    public class MemberEntity
    {
        private string userName;
        private string email;
        private string password;
        private string houseNumber;
        private string streetName;
        private string suburb;
        private string state;
        private string country;
        private string postcode;
        private string firstName;
        private string lastName;

        [Column(Storage = "userName")]
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        [Column(Storage = "email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [Column(Storage = "password")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [Column(Storage = "houseNumber")]
        public string HouseNumber
        {
            get { return houseNumber; }
            set { houseNumber = value; }
        }

        [Column(Storage = "streetName")]
        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        [Column(Storage = "suburb")]
        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        [Column(Storage = "stat")]
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        [Column(Storage = "country")]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        [Column(Storage = "postcode")]
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        [Column(Storage = "firstName")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [Column(Storage = "lastName")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}