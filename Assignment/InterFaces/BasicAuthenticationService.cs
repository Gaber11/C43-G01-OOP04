using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterFaces
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string username { get; set; }
        public string password { get; set; }
        public BasicAuthenticationService(string _username="Admin" , string _password = "joker4444")
        {
            username= _username;
            password= _password;
        }
        public bool AuthenticateUser()
        {
            if (username == "Admin" && password == "joker444")
            {
                return true;
            }
            return false;
        }
       

        public bool AuthorizeUser()
        {
            if (username is not null)
            {
                return true;
            }
            return false;
        }
    }
}