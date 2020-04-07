using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = string.Empty;
                int age = 0;
                for (int j = 0; j < input.Length; j++)
                {
                   
                    if(input[j][0]=='@')
                    {
                        string[] nameArgs = input[j].Split('@','|');
                        name = nameArgs[1];
                    }
                    if (input[j][0] == '#')
                    {
                        string[] ageArgs = input[j].Split('#','*');
                        age = int.Parse(ageArgs[1]);
                    }
                   
                }
                people[name] = age;
            }
            foreach ( var kvp in people)
            {
                Console.WriteLine($"{kvp.Key} is {kvp.Value} years old."); 
            }
        }
    }
}
