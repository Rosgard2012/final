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
            Console.WriteLine("- by years");
            Console.WriteLine("- by country to the winners");
            Console.WriteLine("- according to the countries in which the matches were held");

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
            string searchOption = Console.ReadLine();
            switch (searchOption)
            {
                case "by years":
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

                case "by country to the winners":
                    Console.WriteLine("Enter a country to search for:");
                    string country = Console.ReadLine();
                    bool foundWinner = false;

                    for (int i = 0; i < worldCups.GetLength(0); i++)
                    {
                        if (worldCups[i, 1] == country)
                        {
                            Console.WriteLine($"The {worldCups[i, 0]} World Cup was won by {country}.");
                            foundWinner = true
