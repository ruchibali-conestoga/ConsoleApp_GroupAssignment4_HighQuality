using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

using System.Collections.Generic;

namespace DogWalkingBusiness.Models
{
    public class DogOwner : User
    {
        public List<Session> ScheduledSessions { get; private set; }

        public DogOwner(string username, string password) : base(username, password)
        {
            ScheduledSessions = new List<Session>();
        }

        public override bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}


