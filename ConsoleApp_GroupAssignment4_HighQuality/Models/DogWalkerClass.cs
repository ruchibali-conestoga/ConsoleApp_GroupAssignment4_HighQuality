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
         public double Rate { get; set; }
         public bool IsAvailable { get; set; }
         public List<SessionClass> ScheduledSessions { get; private set; }
         public DogWalkerClass(string username, string password, double rate) : base(username, password)
         {
             Rate = rate;
             IsAvailable = true;
             ScheduledSessions = new List<SessionClass>();
        }
        public override bool Login(string username, string password)
        {
            return Username == username && Password == password;
        }
    }
}
