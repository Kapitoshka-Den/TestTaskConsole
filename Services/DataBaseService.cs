using System.Text;
using Microsoft.EntityFrameworkCore;
using myApp.Context;
using myApp.Models;

namespace myApp.Services;

public class DataBaseService
{
    private readonly DataContext _context = new DataContext();
    private readonly char[] _letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();

    private Random _random = new();

    public void MigrateDb()
    {
        _context.Database.Migrate();
        _context.SaveChanges();
    }

    public void AddHuman(Human human)
    {
        _context.Humans.Add(human);
        _context.SaveChanges();
    }

    public void AddHumans()
    {
        Console.WriteLine("Загрузка данных");
        var maxRandom = _letters.Length-1;
        for (var i = 0; i <= 1000000 ; i++)
        {
            _context.Humans.Add(new Human
            {
                Name = $"{_letters[_random.Next(maxRandom)]} F F",
                Gender = i%2 == 0?"мужской":"женский",
                Birthday = DateTime.Today
            });
        }

        for (int i = 0; i < 100; i++)
        {
            _context.Humans.Add(new Human
            {
                Name = "F F F",
                Gender = i%2 == 0?"мужской":"женский",
                Birthday = DateTime.Today
            });
        }
        _context.SaveChanges();
    }

    public List<Human> GetAllHumans()
    {
        return _context.Humans.OrderBy(t => t.Name).ToList().DistinctBy(t => new { t.Name, t.Birthday }).ToList();
    }

    public List<Human> GetFMan()
    {
        return _context.Humans.ToList().Where(t => t.Name.StartsWith("F")).ToList();
    }
}