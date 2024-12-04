using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

using System.Collections.Generic;
using ConsoleApp_GroupAssignment4_HighQuality.Models;

namespace DogWalkingBusiness.Models
{
    public class DogOwnerClass : UserClass
    {
        public List<SessionClass> scheduledSessions { get; private set; }

        public DogOwnerClass(string userName, string password) : base(userName, password)
        {
            scheduledSessions = new List<SessionClass>();
        }

        public override bool login(string userName, string password)
        {
            return userName == userName && password == password;
        }
    }
}


