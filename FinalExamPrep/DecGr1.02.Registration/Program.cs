using System;
using System.Text.RegularExpressions;

namespace DecGr1._02.Registration
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int count = int.Parse(Console.ReadLine());
            int counter = 0;
            Regex patern = new Regex(@"U\$(?<username>[A-Z][a-z]{2}[a-z]*)U\$P@\$(?<password>[a-z]{5}[a-z]*[0-9]+)P@\$");
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Match valid = patern.Match(input);
                if(!valid.Success)
                {
                    Console.WriteLine("Invalid username or password");
                }
                else
                {

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {valid.Groups["username"]}, Password: {valid.Groups["password"]}");
                    counter++; 
                }

            }
            Console.WriteLine($"Successful registrations: {counter}");
        }
    }
}
