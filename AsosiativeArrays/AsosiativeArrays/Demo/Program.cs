using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string[] wordSplit=words.Where( w=>w.Length% 2 == 0).ToArray();
            Console.WriteLine(string.Join(" ", wordSplit));
        }
    }
}
