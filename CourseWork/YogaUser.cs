using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseWork
{//Class used to manipulate users 
    public class YogaUser
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string sname;

        public string Sname
        {
            get { return sname; }
            set { sname = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private int gender;

        public int Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int experience;

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        private string health;

        public string Health
        {
            get { return health; }
            set { health = value; }
        }
        int userType;

        private int UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public YogaUser( int i, string n, string sn, string ad, string tel, string eml, int gen, int a, int exp, string hi, int ut, string pass)
        {
            id = i;
            name = n;
            sname = sn;
            address = ad;
            phone = tel;
            email = eml;
            gender = gen;
            age = a;
            experience = exp;
            health = hi;
            userType = ut;
            password = pass;
        }
    }
}