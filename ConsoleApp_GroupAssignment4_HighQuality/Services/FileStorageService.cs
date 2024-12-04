using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using static System.Collections.Specialized.BitVector32;
using System.Runtime.Serialization.Formatters.Binary;
using ConsoleApp_GroupAssignment4_HighQuality.Models;
using System.Xml;

namespace ConsoleApp_GroupAssignment4_HighQuality.Services
{
    public class FileStorageService
    {
        private const string filePath = "sessions.json";  
        
        public void saveSessions(List<SessionClass> sessions)
        {
            string json = JsonConvert.SerializeObject(sessions, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
       
        public List<SessionClass> loadSessions()
        {
            if (!File.Exists(filePath))
            {
                return new List<SessionClass>(); 
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<SessionClass>>(json);
        }
    }
}

