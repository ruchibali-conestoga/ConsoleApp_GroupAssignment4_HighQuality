using ConsoleApp_GroupAssignment4_HighQuality.Models;
using ConsoleApp_GroupAssignment4_HighQuality.Services;
using DogWalkingBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp_GroupAssignment4_HighQuality.Services
{
    public class DogWalkingService
    {
        private List<SessionClass> sessions;
        public DogWalkingService()
        {
            sessions = new List<SessionClass>();
        }
        public void scheduleSession(DogWalkerClass walker, DogOwnerClass owner, string dogName, DateTime date)
        {
            var session = new SessionClass(walker, owner, dogName, date);
            sessions.Add(session);
            walker.scheduledSessions.Add(session);
            owner.scheduledSessions.Add(session);
        }
        public List<SessionClass> getSessionsForWalker(DogWalkerClass walker)
        {
            return walker.scheduledSessions;
        }
        public List<SessionClass> getSessionsForOwner(DogOwnerClass owner)
        {
            return owner.scheduledSessions;
        }
        public List<SessionClass> getAllSessions()
        {
            return sessions;
        }

    }
}


       

        
        

        

        

    

