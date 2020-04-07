using System;

namespace TriplesOfLatinLeters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 'a'; i < 'a' + n; i++)
            {

                for (int j = 'a'; j <'a'+ n; j++)
                {

                    for (int h = 'a'; h < 'a' + n; h++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)h}");
                    }
                }
            }
        }
    }
}
