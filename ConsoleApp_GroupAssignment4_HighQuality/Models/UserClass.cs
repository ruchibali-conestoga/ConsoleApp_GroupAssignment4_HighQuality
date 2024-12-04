using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogWalkingBusiness.Models
{

    public abstract class UserClass
    {
        public string userName { get; private set; }
        public string password { get; private set; }

        protected UserClass(string userName, string password)
        {
            userName = userName;
            password = password;
        }

        public abstract bool login(string userName, string password);

        public abstract class User
        {
            public string userName { get; private set; }
            public string password { get; private set; }

            protected User(string userName, string password)
            {
                userName = userName;
                password = password;
            }

            public abstract bool login(string userName, string password);
        }
    }
}
