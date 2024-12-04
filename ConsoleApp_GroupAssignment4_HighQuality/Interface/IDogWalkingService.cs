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
    public interface IDogWalkingService
    {
        void ScheduleSession(DogWalker walker, DogOwner owner, string dogName, DateTime date);
        List<Session> GetSessionsForWalker(DogWalker walker);
        List<Session> GetSessionsForOwner(DogOwner owner);
        List<Session> GetAllSessions();
    }
   }


