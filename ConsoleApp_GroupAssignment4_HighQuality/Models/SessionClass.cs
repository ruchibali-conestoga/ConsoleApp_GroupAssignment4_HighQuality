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
        public DogWalkerClass Walker { get; set; }
        public DogOwnerClass Owner { get; set; }
        public string DogName { get; set; }
        public DateTime Date { get; set; }

        public SessionClass(DogWalkerClass walker, DogOwnerClass owner, string dogName, DateTime date)
        {
            Walker = walker;
            Owner = owner;
            DogName = dogName;
            Date = date;
        }
    }
}
