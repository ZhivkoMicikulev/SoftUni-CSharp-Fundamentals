using System;
using System.Collections.Generic;
using System.Linq;

namespace Dec.Re._03.Nikulden_sMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand;
            Dictionary<string, List<string>> menu = new Dictionary<string, List<string>>();
            int count = 0;
            while ((comand = Console.ReadLine()) != "Stop")
            {
                string[] cmdArg = comand.Split('-');
                string cmd = cmdArg[0];
                if (cmd == "Like")
                {
                    string name = cmdArg[1];
                    string meal = cmdArg[2];
                    if (!menu.ContainsKey(name))
                    {
                        menu[name] = new List<string>();
                    }
                   if(!menu[name].Contains(meal))
                    {
                        menu[name].Add(meal);
                    }
                }
                else if (cmd == "Unlike")
                {
                    string name = cmdArg[1];
                    string meal = cmdArg[2];
                    if (!menu.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is not at the party.");
                    }
                    else if (menu[name].Contains(meal))
                    {
                        count++;
                        menu[name].Remove(meal);
                        Console.WriteLine($"{name} doesn't like the {meal}.");
                    }
                   
                    else if(!menu[name].Contains(meal))
                    {
                        Console.WriteLine($"{name} doesn't have the {meal} in his/her collection.");
                    }
                }
              
            }
            Dictionary<string, List<string>> sortedMenu = menu.OrderByDescending(m => m.Value.Count).ThenBy(g => g.Key).ToDictionary(k => k.Key, v => v.Value);
            foreach (var item in sortedMenu)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
                
            }
            Console.WriteLine($"Unliked meals: {count}");
        }
    }
 }

