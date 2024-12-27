using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterFaces
{
    public interface IAuthenticationService
    {
        public string  username { get; set; }
        public string password { get; set; }

        bool AuthenticateUser();
        bool AuthorizeUser();

    }
}
