using System;
using System.Linq;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NetDemoContext())
            {
                if (db.Database.CanConnect())
                {
                    var countries = db.Countries.ToList();
                    var cities = db.Cities.ToList();

                    foreach (Country country in countries)
                    {
                        Console.WriteLine(country.Name);

                        if (country.Cities != null)
                        {
                            foreach (City city in country.Cities)
                            {
                                Console.WriteLine($"  {city.Name}");
                            }
                        }
                        else Console.WriteLine("  Saknar städer!");

                        Console.WriteLine();
                    }

                    Console.WriteLine();

                    foreach (City city in cities)
                    {
                        Console.WriteLine($"{city.Name,-20}{(city.Country == null ? "-" : city.Country.Name)}");
                    }

                    //db.Add(new Country() { Id = 5, Name = "England" });
                    //db.SaveChanges();
                }
                else Console.WriteLine("Can not connect to server!");
            }
        }
    }
}
