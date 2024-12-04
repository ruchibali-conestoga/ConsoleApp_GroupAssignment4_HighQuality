using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingBusiness.Models
{
    public abstract class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        protected User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public abstract bool Login(string username, string password);
    }
}
