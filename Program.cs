using System;

namespace FootballSearch
{
    class Program
    {
        //Заносимо дані в масив: рік, переможець, місто, рахунок
        static string[,] metodWorldCups()
        {
            string[,] worldCups = 
                    {
                { "1930", "Uruguay", "Montevideo", "4-2" },
                { "1934", "Italy", "Rome", "2-1 (a.e.t.)" },
                { "1938", "Italy", "Paris", "4-2" },
                { "1950", "Uruguay", "Rio de Janeiro", "2-1" },
                { "1954", "West Germany", "Bern", "3-2" },
                { "1958", "Brazil", "Stockholm", "5-2" },
                { "1962", "Brazil", "Santiago",  "3-1" },
                { "1966", "England", "London", "4-2 (a.e.t.)" },
                { "1970", "Brazil", "Mexico", "4-1" },
                { "1974", "West Germany", "Munich", "2-1" },
                { "1978", "Argentina", "Buenos Aires", "3-1 (a.e.t.)" },
                { "1982", "Italy", "Madrid", "3-1" },
                { "1986", "Argentina", "Mexico", "3-2" },
                { "1990", "West Germany", "Rome", "1-0" },
                { "1994", "Brazil", "Pasadena", "0-0 (a.e.t.)" },
                { "1998", "France", "Saint-Denis", "3-0" },
                { "2002", "Brazil", "Yokohama", "2-0" },
                { "2006", "Italy", "Berlin", "1-1 (a.e.t.)" },
                { "2010", "Spain", "Johannesburg", "1-0 (a.e.t.)"},
                { "2014", "Germany", "Rio de Janeiro", "1-0 (a.e.t.)" },
                { "2018", "France", "Moscow", "4-2" },
                { "2022", "Argentina", "Lusail", "3-3" },
                    };
                return worldCups;
             }


        static void Main(string[] args)
        {

            string[,] worldCups = metodWorldCups(); // виклик методу
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}, this is a football world cup search engine.");
            while (true)
            {
                Console.WriteLine($"Hey {name}, how do you want to search for information:");
                Console.WriteLine("1 - Sort by years");
                Console.WriteLine("2 - Sort by country of the winners");
                Console.WriteLine("3 - Take all of FIFA World Cup ");
                // Виконання операцій залежно від вибраної опції пошуку
                string searchOption = Console.ReadLine();
            
                switch (searchOption)
                {
                    case "1":
                        Console.WriteLine("Enter a year to search for:");
                        string year = Console.ReadLine();

                        for (int i = 0; i < worldCups.GetLength(0); i++)
                        {
                            if (worldCups[i, 0] == year)
                            {
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine($"The {year} World Cup was held in {worldCups[i, 2]}, and was won by {worldCups[i, 1]}");
                                Console.WriteLine("--------------------------------");
                                break;
                            }
                            else if (i == worldCups.GetLength(0) - 1)
                            {
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine($"No World Cup was held in {year}.");
                                Console.WriteLine("--------------------------------");
                            }
                        }
                        
                        break;
                    case "2":
                        Console.WriteLine("Enter a country to search for:");
                        string country = Console.ReadLine();
                        bool foundWinner = false;
                        for (int i = 0; i < worldCups.GetLength(0); i++)
                        {
                            if (worldCups[i, 1] == country)
                            {
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine($"The {worldCups[i, 0]} World Cup was won by {country}, in the {worldCups[i, 2]}");
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
                        else
                        {
                            Console.WriteLine($"Search completed. See above for results.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("City where the matches were held:");
                        Console.WriteLine("--------------------------------");
                        for (int i = 0; i < worldCups.GetLength(0); i++)
                        {
                            Console.WriteLine($"in {worldCups[i, 0]}, the {worldCups[i, 1]} team won with a score of {worldCups[i, 3]} in the city {worldCups[i, 2]}");
                        }
                        Console.WriteLine("--------------------------------");
                        break;
                    
                    default:
                        Console.WriteLine("Invalid option selected."); break;
                }
                Console.WriteLine("What else would you like to do?");
                Console.WriteLine("Press 1 to exit");
                Console.WriteLine("Press any other key to continue searching for matches");
                string usInput = Console.ReadLine();
                //вводемо спосіб виходу з while
                if (usInput == "1")
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                }
                
            }
            
        }

        

    }
}

            