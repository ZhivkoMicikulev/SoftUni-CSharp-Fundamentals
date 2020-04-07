using System;
using System.Collections.Generic;

namespace _06._ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> empty = new List<string>();
            string typechar = string.Empty;
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                if (input[i].ToString() == typechar)
                {
                    counter++;
                }
                else counter = 0;
                if (counter==0)
                {
                    empty.Add(input[i].ToString());
                    
                }
                typechar = input[i].ToString();
            }
            foreach (var item in empty)
            {
                Console.Write(item);
            }
        }
    }
}
