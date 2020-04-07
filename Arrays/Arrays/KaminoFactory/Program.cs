using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int leght = int.Parse(Console.ReadLine());
            string dna = Console.ReadLine();
            int timesCounter = 0;
            int bestTime = 0;
            int counter = 0;
            int bestCounter = 0; ;
            int[] bestDna = new int[5];
            while(dna!="Clone them!")
            {
                timesCounter++;
                int[] dnaResult= dna.Split('!').Select(int.Parse).ToArray();
                for (int i = 0; i < leght; i++)
                {
                    if (dnaResult[i] == 1)
                    {
                        counter++;
                    }
                    if (counter > bestCounter)
                    {
                        bestTime = timesCounter;
                        bestDna = dnaResult;
                        bestCounter = counter;
                    }
                }
                counter = 0;
                dna = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestTime} with sum: {bestCounter}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }
    }
}
