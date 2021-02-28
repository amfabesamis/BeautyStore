using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore.BeautyStoreBL
{
    class CustomerLogin
    {
        private string userName;
        private string password;
        public CustomerLogin(string userName, string pass)
        {
            this.userName = userName;
            this.password = pass;
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
