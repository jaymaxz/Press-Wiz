using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class User
    {
        private

        string userId;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        string first_Name;

        public string First_Name
        {
            get { return first_Name; }
            set { first_Name = value; }
        }
        string last_Name;

        public string Last_Name
        {
            get { return last_Name; }
            set { last_Name = value; }
        }
        int telephone;

        public int Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        bool admin;

        public bool Admin
        {
            get { return admin; }
            set { admin = value; }
        }
        string Ip;

        public string ip
        {
            get { return Ip; }
            set { Ip = value; }
        }
    }
}
