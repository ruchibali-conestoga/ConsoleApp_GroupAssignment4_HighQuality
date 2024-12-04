
using ConsoleApp_GroupAssignment4_HighQuality.Models;
using ConsoleApp_GroupAssignment4_HighQuality.Services;

public class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Group5 Assignment4!");
        DogWalkingService dogWalkingService = new DogWalkingService();
        FileStorageService fileStorageService = new FileStorageService();
        List<SessionClass> sessions = fileStorageService.loadSessions();

    }
}

