using System;
using System.Collections.Generic;

namespace P1.AdvertisementMessage
{

        internal class Program
        {
            static void Main(string[] args)
            {
                List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
                List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
                List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
                List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

                Random random = new Random();

                int numberOfRandomMessages = int.Parse(Console.ReadLine());

                for (int i = 0; i < numberOfRandomMessages; i++)
                {
                    int indexPhrases = random.Next(phrases.Count);
                    int indexEvents = random.Next(events.Count);
                    int indexAuthors = random.Next(authors.Count);
                    int indexCities = random.Next(cities.Count);

                    Console.WriteLine($"{phrases[indexPhrases]} {events[indexEvents]} {authors[indexAuthors]} – {cities[indexCities]}.");
                }
            }
        }
    }



