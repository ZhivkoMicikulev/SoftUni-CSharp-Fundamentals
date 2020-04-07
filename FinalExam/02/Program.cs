using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex number = new Regex(@"\d");
            BigInteger coolNumber = 1;
            List<string> coolEmojis = new List<string>();
            Regex validEmoji = new Regex(@"([:|*]{2})(?<emoji>[A-Z][a-z]{2}[a-z]*)\1");
            MatchCollection numbers = number.Matches(input);
            int counter = 0;
            foreach (Match num in numbers)
            {
                BigInteger n = BigInteger.Parse(num.ToString());
                coolNumber *=n;
            }
            MatchCollection emojis = validEmoji.Matches(input);
            foreach (Match emo in emojis)
            {
                string findetEmo = emo.Groups["emoji"].ToString();
                BigInteger isIt = 0;
                for (int i = 0; i < findetEmo.Length; i++)
                {
                    isIt += findetEmo[i];
                }
                if (isIt>=coolNumber)
                {
                    coolEmojis.Add(emo.ToString());
                }
                counter++;
            }

            Console.WriteLine($"Cool threshold: {coolNumber}");
          
            if (counter>0)
            {
                Console.WriteLine($"{counter} emojis found in the text. The cool ones are:");
                if (coolEmojis.Count > 0)
                {

                    foreach (var item in coolEmojis)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            
        }
    }
}
