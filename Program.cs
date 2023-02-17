// See https://aka.ms/new-console-template for more information

using System.Configuration;
using System.Diagnostics;
using System.Text;
using myApp.Models;
using myApp.Services;
using ArgumentOutOfRangeException = System.ArgumentOutOfRangeException;

internal class Program
{
    public static void Main(string[] args)
    {
        var sw = new Stopwatch();
        DataBaseService service = new DataBaseService();
        ConnectChange change = new ConnectChange();
        try
        {
            switch (args[0])
            {
                case "connect":
                    change.ChangeConnection(args[1]);
                    break;
                case "1":
                    service.MigrateDb();
                    break;
                case "2":
                    Human human = new Human()
                    {
                        Name = String.Join(' ', args[1..4]),
                        Gender = args[^1],
                        Birthday = DateTime.Parse(string.Join(' ', args[4..^1]))

                    };
                    service.AddHuman(human);
                    break;
                case "3":
                    foreach (var allHuman in service.GetAllHumans())
                    {
                        Console.WriteLine(allHuman);
                    }

                    break;
                case "4":
                    service.AddHumans();
                    break;
                case "5":
                    sw.Start();
                    service.GetFMan();
                    sw.Stop();
                    Console.WriteLine(sw.Elapsed);
                    break;

            }
        }
        catch (InvalidOperationException ex2)
        {
            Console.WriteLine("Невозможно подключиться по текущей строке подключения к базе данных");
            Console.WriteLine("Пожалуйста, воспользуйтесь командой \"myApp connect (ваша строка подключения)\"");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Пожалуйста, введите необходимое количесвто аргументов");
        }
        catch(Exception e)
        {
            Console.WriteLine("Произошла непредвиденная ошибка");
            Console.WriteLine(e.Message);
        }
    }
}