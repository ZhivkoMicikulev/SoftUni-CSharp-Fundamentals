using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> words = new Dictionary<char, int>();
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char currChar = text[i];
                if (currChar != ' ')
                {


                    if (!words.ContainsKey(currChar))
                    {
                        words[currChar] = 0;
                    }
                    words[currChar]++;
                }
            }
            foreach (var chars in words)
            {
                Console.WriteLine($"{chars.Key} -> {chars.Value}");
            }
        }
    }
}
