using System;
using System.Collections.Generic;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            string phrase = "";
            string event_c = "";
            string author = "";
            string city = "";

            for (int i = 0; i < n; i++)
            {
                phrase = phrases[r.Next(0, phrases.Length)];
                event_c = events[r.Next(0, events.Length)];
                author = authors[r.Next(0, authors.Length)];
                city = cities[r.Next(0, cities.Length)];
                Advertisement a1 = new Advertisement(phrase, event_c, author, city);
                Console.WriteLine(a1.ToString());
            }
        }

    }

    public class Advertisement
    {
        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }


        public Advertisement(string phrase,string event_c,string author,string city)
        {
            Phrase = phrase;
            Event = event_c;
            Author = author;
            City = city;
        }

        public override string ToString()
        {
            return $"{this.Phrase} {this.Event} {this.Author} - {this.City}";
        }
    }
}
