using DogWalkingBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_GroupAssignment4_HighQuality.Models
{
    public class SessionClass
    {
        public DogWalkerClass walker { get; set; }
        public DogOwnerClass owner { get; set; }
        public string dogName { get; set; }
        public DateTime date { get; set; }

        public SessionClass(DogWalkerClass walker, DogOwnerClass owner, string dogName, DateTime date)
        {
            walker = walker;
            owner = owner;
            dogName = dogName;
            date = date;
        }
    }
}
