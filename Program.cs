// See https://aka.ms/new-console-template for more information

using System.Configuration;
using System.Diagnostics;
using System.Text;
using myApp.Models;
using myApp.Services;

internal class Program
{
    public static void Main(string[] args)
    {
        var sw = new Stopwatch();
        DataBaseService service = new DataBaseService();
        
        switch (args[0])
        {
            case "connect":
                var configFile
                break;
            case "1":
                service.MigrateDb();
                break;
            case "2":
                service.MigrateDb();
                Human human = new Human()
                {
                    Name = String.Join(' ',args[1..4]),
                    Gender = args[^1],
                    Birthday = DateTime.Parse(string.Join(' ',args[4..^1]))
                    
                };
                Console.WriteLine(args[^1]);
                service.AddHuman(human);
                break;
            case "3":
                foreach (var allHuman in service.GetAllHumans())
                {
                    Console.WriteLine(allHuman);
                }
                break;
            case "4":
                sw.Start();
                service.AddHumans();
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
                break;
            case "5":
                sw.Start();
                service.GetFMan();
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
                break;

        }

      
        
    }
}