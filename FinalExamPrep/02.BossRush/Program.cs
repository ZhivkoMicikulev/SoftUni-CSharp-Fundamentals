using System;
using System.Text.RegularExpressions;

namespace _02.BossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Regex patern =new Regex(@"^\|(?<name>[A-Z]+)\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#$");
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Match valid = patern.Match(input);
                if(valid.Success)
                {
                    Console.WriteLine($"{valid.Groups["name"]}, The {valid.Groups["title"]}");
                    Console.WriteLine($">> Strength: {valid.Groups["name"].Length}");
                    Console.WriteLine($">> Armour: {valid.Groups["title"].Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
