
using ConsoleApp_GroupAssignment4_HighQuality.Models;
using ConsoleApp_GroupAssignment4_HighQuality.Services;
using DogWalkingBusiness.Models;

public class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Group5 Assignment4!");
        DogWalkingService dogWalkingService = new DogWalkingService();
        FileStorageService fileStorageService = new FileStorageService();
        List<SessionClass> sessions = fileStorageService.loadSessions();

        // dynamic pending:
        var walker = new DogWalkerClass("walker1", "password", 20.0);
        var owner = new DogOwnerClass("owner1", "password");
        var dogName = string.Empty;
        //

        dogWalkingService.scheduleSession(walker, owner, dogName, DateTime.Now);
        fileStorageService.saveSessions(sessions); 

        Console.WriteLine("Session scheduled successfully!");

    }
}

