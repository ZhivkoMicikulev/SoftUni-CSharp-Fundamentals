using System;

namespace MaxSequences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sec = Console.ReadLine().Split();
            string temp = string.Empty;
            int counter = 1;
            int bestCounter = 1;
            string bestIndex = string.Empty;
            for (int i = 0; i < sec.Length; i++)
            {
                for (int j = i+1; j < sec.Length; j++)
                {
                    if (sec[i] == sec[j])
                    {
                        counter++;
                    }
                    else break;

                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    bestIndex = sec[i];
                }
                counter = 1;
            }
            for (int i = 1; i <= bestCounter; i++)
            {
                Console.Write($"{bestIndex} ");
            }
        }
    }
}
