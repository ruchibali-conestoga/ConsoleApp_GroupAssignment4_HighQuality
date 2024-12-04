using DogWalkingBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleApp_GroupAssignment4_HighQuality.Models
{
    public class DogWalkerClass: UserClass
    {
         public double rate { get; set; }
         public bool isAvailable { get; set; }
         public List<SessionClass> scheduledSessions { get; private set; }
         public DogWalkerClass(string userName, string password, double rate) : base(userName, password)
         {
             rate = rate;
             isAvailable = true;
             scheduledSessions = new List<SessionClass>();
        }
        public override bool login(string userName, string password)
        {
            return userName == userName && password == password;
        }
    }
}
