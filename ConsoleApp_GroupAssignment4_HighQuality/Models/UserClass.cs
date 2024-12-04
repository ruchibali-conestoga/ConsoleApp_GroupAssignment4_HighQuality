using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_GroupAssignment4_HighQuality.Models
{
    public abstract class UserClass
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        
        protected UserClass(string username, string password)
        {
             Username = username;
             Password = password;
         }
        
         public abstract bool Login(string username, string password);

    }
}
