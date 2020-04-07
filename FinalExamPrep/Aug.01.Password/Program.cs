using System;
using System.Text.RegularExpressions;

namespace Aug._01.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Regex patern = new Regex(@"^(.+)>(?<numbers>[0-9]{3})\|(?<lowLett>[a-z]{3})\|(?<uppLett>[A-Z]{3})\|(?<symbols>[^<>]{3})<\1$");
            for (int i = 0; i < count; i++)
            {
                string password = Console.ReadLine();
                Match valid = patern.Match(password);
                if (valid.Success)
                {
                    Console.WriteLine($"Password: {valid.Groups["numbers"]}{valid.Groups["lowLett"]}{valid.Groups["uppLett"]}{valid.Groups["symbols"]}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
