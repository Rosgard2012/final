using System;

namespace FootballSearchEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"{name}, this is a football world cup search engine.");
            Console.WriteLine("How do you want to search for information:");
            Console.WriteLine("1 - Sort by years");
            Console.WriteLine("2 - Sort by country of the winners");
            Console.WriteLine("3 - Sort by countries in which the matches were held");

            //Вводемо данні в масив: рік, переможець, місто
            string[,] worldCups = new string[,]
            {
                { "1930", "Uruguay", "Montevideo" },
                { "1934", "Italy", "Rome" },
                { "1938", "Italy", "Paris" },
                { "1950", "Uruguay", "Rio de Janeiro" },
                { "1954", "West Germany", "Bern" },
                { "1958", "Brazil", "Stockholm" },
                { "1962", "Brazil", "Santiago" },
                { "1966", "England", "London" },
                { "1970", "Brazil", "Mexico City" },
                { "1974", "West Germany", "Munich" },
                { "1978", "Argentina", "Buenos Aires" },
                { "1982", "Italy", "Madrid" },
                { "1986", "Argentina", "Mexico City" },
                { "1990", "West Germany", "Rome" },
                { "1994", "Brazil", "Pasadena" },
                { "1998", "France", "Saint-Denis" },
                { "2002", "Brazil", "Yokohama" },
                { "2006", "Italy", "Berlin" },
                { "2010", "Spain", "Johannesburg" },
                { "2014", "Germany", "Rio de Janeiro" },
                { "2018", "France", "Moscow" }
            };

            // Виконання операцій залежно від вибраної опції пошуку
           
            
            
            int searchOption = int.Parse(Console.ReadLine());
            switch (searchOption)
            {
                case 1:
                    Console.WriteLine("Enter a year to search for:");
                    string year = Console.ReadLine();

                    for (int i = 0; i < worldCups.GetLength(0); i++)
                    {
                        if (worldCups[i, 0] == year)
                        {
                            Console.WriteLine($"The {year} World Cup was held in {worldCups[i, 2]}, and was won by {worldCups[i, 1]}.");
                            break;
                        }
                        else if (i == worldCups.GetLength(0) - 1)
                        {
                            Console.WriteLine($"No World Cup was held in {year}.");
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter a country to search for:");
                    string country = Console.ReadLine();
                    bool foundWinner = false;

                    for (int i = 0; i < worldCups.GetLength(0); i++)
                    {
                        if (worldCups[i, 1] == country)
                        {
                            Console.WriteLine($"The {worldCups[i, 0]} World Cup was won by {country}.");
                            foundWinner = true;
                        }
                    }

                    if (!foundWinner)
                    {
                        Console.WriteLine($"No World Cup was won by {country}.");
                    }

                    break;
                case 3:
                    HashSet<string> countries = new HashSet<string>();

                    for (int i = 0; i < worldCups.GetLength(0); i++)
                    {
                        countries.Add(worldCups[i, 1]);
                    }

                    Console.WriteLine("Countries where the matches were held:");
                    foreach (string c in countries)
                    {
                        Console.WriteLine(c);
                    }

                    break;
                

                default:
                    Console.WriteLine("Invalid option selected."); break;

            }
        }
    }
}

