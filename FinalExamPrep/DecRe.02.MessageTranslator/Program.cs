using System;
using System.Text.RegularExpressions;

namespace DecRe._02.MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string paternMessage = @"^!(?<cmd>[A-Z][a-z]{2}[A-Za-z]+)!:\[(?<mesage>[A-Za-z]{8}[A-Za-z]+)\]$";
            for (int i = 0; i < count; i++)
            {
                string message = Console.ReadLine();
                Match validComand = Regex.Match(message, paternMessage);
                if (validComand.Success)
                {
                    char[] exportedMessage = validComand.Groups["mesage"].Value.ToCharArray();
                    int[] intChar = new int[exportedMessage.Length];
                    for (int j = 0; j < exportedMessage.Length; j++)
                    {
                        intChar[j] = exportedMessage[j];
                    }
                    Console.WriteLine($"{validComand.Groups["cmd"]}: {string.Join(" ",intChar)}");
                } 
                else
                {
                    Console.WriteLine("The message is invalid");
                }

                
            }
        }
    }
}
