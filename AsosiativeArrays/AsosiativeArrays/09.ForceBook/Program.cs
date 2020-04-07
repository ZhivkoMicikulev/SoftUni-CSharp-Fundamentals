using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] inputArgs = input.Split(new string[]{"|","->"},StringSplitOptions.RemoveEmptyEntries).ToArray();
               
                if (input.Contains("|"))
                {
                    string forceSide = inputArgs[0];
                    string forceUser = inputArgs[1];
                    AddUser(book, forceSide, forceUser);
                }
                else if (input.Contains("->"))
                {
                    string forceSide = inputArgs[1];
                    string forceUser = inputArgs[0];
                    MovedUSer(book, forceSide, forceUser);
                }
            }

            Print(book);
        }

        private static void Print(Dictionary<string, List<string>> book)
        {
            Dictionary<string, List<string>> filter = book.Where(kvp => kvp.Value.Count > 0).
                          OrderByDescending(kvp => kvp.Value.Count).
                          ThenBy(kvp => kvp.Key).
                          ToDictionary(a => a.Key, b => b.Value);
            foreach (var kvp in filter)
            {
                string side = kvp.Key;
                List<string> currUser = kvp.Value.OrderBy(a => a).ToList();

                Console.WriteLine($"Side: {side}, Members: { currUser.Count}");
                foreach (var name in currUser)
                {
                    Console.WriteLine($"! {name}");
                }

            }
        }

        private static void MovedUSer(Dictionary<string, List<string>> book, string forceSide, string forceUser)
        {
            foreach (var kvp in book)
            {
                if (kvp.Value.Contains(forceUser))
                {
                    kvp.Value.Remove(forceUser);
                    
                }
               
            }
            if (!book.ContainsKey(forceSide))
            {
                book[forceSide] = new List<string>();
            }
            book[forceSide].Add(forceUser);
            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
        }

        private static void AddUser(Dictionary<string, List<string>> book, string forceSide, string forceUser)
        {
            if (!book.ContainsKey(forceSide))
            {
                book[forceSide] = new List<string>();
            }
            if (!book.Values.Any(l => l.Contains(forceUser)))
            {
                book[forceSide].Add(forceUser);
            }
        }
    }
}
