using ExoMiner.Services;
using ExoMiner.Services.Queries.ExoplanetQueries;

namespace ExoMiner;

public class Program
{
    static void Main(string[] args)
    {
        ExoplanetQueries eq = new ExoplanetQueries();
       AddTitle t = new AddTitle();

       while (true)
       {
           Console.Clear();
           PrintMenu();
           
           var key = Console.ReadKey(true).Key;

           Console.Clear();
           
           switch (key)
           {
               case ConsoleKey.D1:
                   t.Title("Top 10 Earth-sized planets");
                   eq.EarthSizedPlanets();
                   break;
               
               case ConsoleKey.D2:
                   t.Title("Top 10 hottest planets");
                   eq.HottestPlanets();
                   break;

               case ConsoleKey.Escape:
                   return;
           }
           
           Console.WriteLine("\nPress any key to return to menu...");
           Console.ReadKey();
           
       }
    }
    static void PrintMenu()
    {
        Console.WriteLine(new string('=', 40));
        Console.WriteLine($"{new string(' ', 17)}Menu{new string(' ', 17)}");
        Console.WriteLine(new string('=', 40 )+ "\n");
        Console.WriteLine("1 - List the top 10 Earth-sized planets");
        Console.WriteLine("2 - List the 10 hottest planets");
        Console.WriteLine("\nESC - Exit");
        Console.Write("\nSelect: ");
    }
}