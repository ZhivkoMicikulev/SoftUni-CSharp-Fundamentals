using System;

namespace PrintASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSymbol = int.Parse(Console.ReadLine());
            var lastSymbol = int.Parse(Console.ReadLine());
            for (int i = firstSymbol; i <=lastSymbol; i++)
            {
                Console.Write($"{(char)i}"+" ") ;
            }
        }
    }
}
