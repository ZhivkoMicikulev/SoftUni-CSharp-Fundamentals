using System;
using System.Text.RegularExpressions;

namespace Aug.Fi.Gr02._02.StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string patern = @"([\*|@])(?<tag>[A-Z][a-z][a-z]+)\1: \[(?<l1>[A-Za-z])\]\|\[(?<l2>[A-Za-z])\]\|\[(?<l3>[A-Za-z])\]\|$";
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Match valid = Regex.Match(input, patern);
                if (valid.Success)
                {
                    char g1 = char.Parse(valid.Groups["l1"].ToString());
                    char g2 = char.Parse(valid.Groups["l2"].ToString());
                    char g3 = char.Parse(valid.Groups["l3"].ToString());
                    
                    Console.WriteLine($"{valid.Groups["tag"]}: {(int)g1} {(int)g2} {(int)g3}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
