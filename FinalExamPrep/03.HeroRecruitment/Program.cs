using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            
           var heroesBook = new Dictionary<string, List<string>>();
            string comand;
            while ((comand=Console.ReadLine())!="End")
            {
                string[] cmdArgs = comand.Split();
                string cmd = cmdArgs[0];
                if(cmd=="Enroll")
                {
                    Enroll(heroesBook, cmdArgs);
                }
                else if(cmd=="Learn")
                {
                    Learn(heroesBook, cmdArgs);
                }
                else if(cmd=="Unlearn")
                {
                    Unlearn(heroesBook, cmdArgs);
                }
            }
            var sortedHeroes = heroesBook.OrderByDescending(s => s.Value.Count).ThenBy(h => h.Key).ToDictionary(k => k.Key, v => v.Value);
            Console.WriteLine("Heroes:");
            foreach (var heroe in sortedHeroes)
            {
                Console.WriteLine($"== {heroe.Key}: {string.Join(", ",heroe.Value)}");
            }
        }

        private static void Unlearn(Dictionary<string, List<string>> heroesBook, string[] cmdArgs)
        {
            string name = cmdArgs[1];
            string spell = cmdArgs[2];
            if (heroesBook.ContainsKey(name))
            {
                if (heroesBook[name].Contains(spell))
                {
                    heroesBook[name].Remove(spell);
                }
                else
                {
                    Console.WriteLine($"{name} doesn't know {spell}.");
                }
            }
            else
            {
                Console.WriteLine($"{name} doesn't exist.");
            }
        }

        private static void Learn(Dictionary<string, List<string>> heroesBook, string[] cmdArgs)
        {
            string name = cmdArgs[1];
            string spell = cmdArgs[2];
           
            if (heroesBook.ContainsKey(name))
            {
                if (!heroesBook[name].Contains(spell))
                {
                    heroesBook[name].Add(spell);
                }
                else
                {
                    Console.WriteLine($"{name} has already learnt {spell}.");
                }
            }
            else
            {
                Console.WriteLine($"{name} doesn't exist.");
            }
        }

        private static void Enroll(Dictionary<string, List<string>> heroesBook, string[] cmdArgs)
        {
            string name = cmdArgs[1];
            if (!heroesBook.ContainsKey(name))
            {
                heroesBook[name] = new List<string>();
            }
            else
            {
                Console.WriteLine($"{name} is already enrolled.");
            }
        }
    }
}
