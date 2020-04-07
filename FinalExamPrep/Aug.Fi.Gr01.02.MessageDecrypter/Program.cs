using System;
using System.Text.RegularExpressions;

namespace Aug.Fi.Gr01._02.MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Regex patern = new Regex(@"^([$|%])(?<tag>[A-Z][a-z]{2}[a-z]*)\1: (\[(?<gr1>[\d]+)\]\|)(\[(?<gr2>[\d]+)\]\|)(\[(?<gr3>[\d]+)\]\|)$");
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Match valid = patern.Match(input);
                if (valid.Success)
                {
                    int gr1 = int.Parse(valid.Groups["gr1"].ToString());
                    int gr2 = int.Parse(valid.Groups["gr2"].ToString());
                    int gr3 = int.Parse(valid.Groups["gr3"].ToString());
                    Console.WriteLine($"{valid.Groups["tag"]}: {(char)gr1}{(char)gr2}{(char)gr3}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
