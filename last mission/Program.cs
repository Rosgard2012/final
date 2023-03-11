using System;
// last mission
namespace FootballSearch
{
    class Program
    {
        //шукаємо чемпіонат за ріком проходження по списку
        static void SearchYear(List<string[]> worldCups)
        {
            Console.WriteLine("Enter a year to search for:");
            string year = Console.ReadLine();

            for (int i = 0; i < worldCups.Count; i++)
            {
                if (worldCups[i][0] == year)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"The {year} World Cup was held in {worldCups[i][2]}, and was won by {worldCups[i][1]}.");
                    Console.WriteLine("--------------------------------");
                    break;
                }
                else if (i == worldCups.Count - 1)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"No World Cup was held in {year}.");
                    Console.WriteLine("--------------------------------");
                }
            }
        }
        //шукаємо за переможцем в списку
        static void SearchWinner(List<string[]> worldCups)
        {
            Console.WriteLine("Enter a country to search for:");
            string country = Console.ReadLine();
            bool foundWinner = false;

            for (int i = 0; i < worldCups.Count; i++)
            {
                if (worldCups[i][1] == country)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"The {worldCups[i][0]} World Cup was won by {country}, in {worldCups[i][2]} city.");
                    Console.WriteLine("--------------------------------");
                    foundWinner = true;
                }
            }

            if (!foundWinner)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"No World Cup was won by {country}.");
                Console.WriteLine("--------------------------------");
            }          
        }
        //виводемо список переможців
        static void PrintWorldCups(List<string[]> worldCups)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("City where the matches were held:");
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < worldCups.Count; i++)
            {
                Console.WriteLine($"in {worldCups[i][0]}, the {worldCups[i][1]} team won with a score of {worldCups[i][3]} in the city {worldCups[i][2]}");
            }
            Console.WriteLine("--------------------------------");
        }
        //Вводемо ще один метод для додавання данних в масив
        static void AddWorldCup(List<string[]> worldCups)
        {
            Console.WriteLine("Enter the year of the World Cup:");
            string year = Console.ReadLine();
            Console.WriteLine("Enter the winner of the World Cup:");
            string winner = Console.ReadLine();
            Console.WriteLine("Enter the host city of the World Cup:");
            string hostCity = Console.ReadLine();
            Console.WriteLine("Enter the score of the World Cup final:");
            string score = Console.ReadLine();

            string[] newWorldCups = { year, winner, hostCity, score };

            worldCups.Add(newWorldCups);

            Console.WriteLine($"The {year} World Cup was added to the search engine.");
        }




        static void Main(string[] args)

        {
            //Заносимо дані в масив: рік, переможець, місто, рахунок
            List<string[]> worldCups = new List<string[]>()
                    {
                new string[] { "1930", "Uruguay", "Montevideo", "4-2" },
                 new string[] { "1934", "Italy", "Rome", "2-1 (a.e.t.)" },
                 new string[] { "1938", "Italy", "Paris", "4-2" },
                 new string[] { "1950", "Uruguay", "Rio de Janeiro", "2-1" },
                 new string[] { "1954", "West Germany", "Bern", "3-2" },
                 new string[] { "1958", "Brazil", "Stockholm", "5-2" },
                 new string[] { "1962", "Brazil", "Santiago",  "3-1" },
                 new string[] { "1966", "England", "London", "4-2 (a.e.t.)" },
                 new string[] { "1970", "Brazil", "Mexico", "4-1" },
                 new string[] { "1974", "West Germany", "Munich", "2-1" },
                 new string[] { "1978", "Argentina", "Buenos Aires", "3-1 (a.e.t.)" },
                 new string[] { "1982", "Italy", "Madrid", "3-1" },
                 new string[] { "1986", "Argentina", "Mexico", "3-2" },
                 new string[] { "1990", "West Germany", "Rome", "1-0" },
                 new string[] { "1994", "Brazil", "Pasadena", "0-0 (a.e.t.)" },
                 new string[] { "1998", "France", "Saint-Denis", "3-0" },
                 new string[] { "2002", "Brazil", "Yokohama", "2-0" },
                 new string[] { "2006", "Italy", "Berlin", "1-1 (a.e.t.)" },
                 new string[] { "2010", "Spain", "Johannesburg", "1-0 (a.e.t.)"},
                 new string[] { "2014", "Germany", "Rio de Janeiro", "1-0 (a.e.t.)" },
                 new string[] { "2018", "France", "Moscow", "4-2" },
                 new string[] { "2022", "Argentina", "Lusail", "3-3" },
                    };
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}, this is a football world cup search engine.");
            while (true)
            {
                Console.WriteLine($"Hey {name}, how do you want to search for information:");
                Console.WriteLine("1 - Sort by years");
                Console.WriteLine("2 - Sort by country of the winners");
                Console.WriteLine("3 - Take all of FIFA World Cup ");
                Console.WriteLine("Press * to add new World Cups");
                // Виконання операцій залежно від вибраної опції пошуку
                string searchOption = Console.ReadLine();
                switch (searchOption)
                {
                    case "1":
                        SearchYear(worldCups);
                        break;
                    case "2":
                        SearchWinner(worldCups);
                        break;
                    case "3":
                        PrintWorldCups(worldCups);
                        break;
                    case "*":
                        AddWorldCup(worldCups);
                        break;
                    default:
                        Console.WriteLine("Invalid option selected."); break;
                }
                Console.WriteLine("What else would you like to do?");
                Console.WriteLine("Press 1 to exit");
                Console.WriteLine("Press any other key to continue searching for matches");
                string usInput = Console.ReadLine();
                if (usInput == "1")
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }
            }
        }
    }
}

