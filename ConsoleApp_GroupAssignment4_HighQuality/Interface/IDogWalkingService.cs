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
    public interface IDogWalkingService
    {
        void ScheduleSession(DogWalkerClass walker, DogOwnerClass owner, string dogName, DateTime date);
        List<SessionClass> getSessionsForWalker(DogWalkerClass walker);
        List<SessionClass> getSessionsForOwner(DogOwnerClass owner);
        List<SessionClass> getAllSessions();
    }
   }


