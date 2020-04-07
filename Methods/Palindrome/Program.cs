using System;
using System.Linq;
namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string line =Console.ReadLine();
            while (line != "END")
            {
                IsItPalindrome(line);
                line = Console.ReadLine();
            }
        }
        static void IsItPalindrome(string line)
        {
            
            
                int couter = line.Length / 2;
                int emptyCounter = 0;
                for (int i = 0; i < line.Length / 2; i++)
                {
                   
                    if (line[i] == line[line.Length - (1 + i)]) emptyCounter++;
                    else Console.WriteLine("false"); ;
                    
                }
                if (emptyCounter == couter) Console.WriteLine("true");
            
          

        }
    }
}
