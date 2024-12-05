
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

        Console.WriteLine("Enter Walker Name:");
        string walkerName = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter Rate:");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter password:");
        string password = Convert.ToString(Console.ReadLine());

        var walker = new DogWalkerClass(walkerName, password, rate);

        var owner = new DogOwnerClass(walkerName, password);

        Console.WriteLine("Enter Dog Name:");
        string dogName = Convert.ToString(Console.ReadLine());

        dogWalkingService.scheduleSession(walker, owner, dogName, DateTime.Now);
        fileStorageService.saveSessions(sessions); 

        Console.WriteLine("Session scheduled successfully!");

    }
}

