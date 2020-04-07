using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<int>> cityes = new Dictionary<string, List<int>>();
            while ((input=Console.ReadLine())!="Sail")
            {
                string[] cmdArg = input.Split("||");
                string city = cmdArg[0];
                int population = int.Parse(cmdArg[1]);
                int gold = int.Parse(cmdArg[2]);
                if (!cityes.ContainsKey(city))
                {
                    cityes[city] = new List<int>();
                    cityes[city].Add(0);
                    cityes[city].Add(0);
                }
                cityes[city][0] += population;
                cityes[city][1] += gold;
            }
            string comand;
            while ((comand=Console.ReadLine())!="End")
            {
                string[] cmdArg = comand.Split("=>");
                string cmd = cmdArg[0];
                if (cmd=="Plunder")
                {
                    string town = cmdArg[1];
                    int people = int.Parse(cmdArg[2]);
                    int gold = int.Parse(cmdArg[3]);
                    cityes[town][0] -= people;
                    cityes[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (cityes[town][0]<=0 || cityes[town][1] <= 0)
                    {
                        cityes.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (cmd=="Prosper")
                {
                    string town = cmdArg[1];
                    int gold = int.Parse(cmdArg[2]);
                    if (gold<0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else 
                    {
                        cityes[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cityes[town][1]} gold.");
                    }
                }

            }
            if (cityes.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityes.Count} wealthy settlements to go to:");
                foreach (var item in cityes.OrderByDescending(g=>g.Value[1]).ThenBy(n=>n.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
