using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> people = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                string comand = Console.ReadLine();
                string[] comandArr = comand.Split().ToArray();
                string name = comandArr[0];
                
                if(comandArr.Length==3)
                {
                    if(people.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        people.Add(name);
                    }
                }
                else if(comandArr.Length==4)
                {
                    if (people.Contains(name)) people.Remove(name);
                    else Console.WriteLine($"{name} is not in the list!");
                }
               
            }
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
}
