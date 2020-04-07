using System;
using System.Collections.Generic;

namespace _04._CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> empty = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                
                char newChar = (char)(input[i]+3);
                empty.Add(newChar.ToString());
            }
            foreach (var item in empty)
            {
                Console.Write(item);
            }
        }
    }
}
