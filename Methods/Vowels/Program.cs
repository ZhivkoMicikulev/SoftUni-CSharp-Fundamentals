using System;

namespace Vowels
{
    class Program
    {
        static int vowelCounter = 0;
        static void Main(string[] args)
        {
            string strin= Console.ReadLine().ToLower();
            Findvowels(strin);
            Console.WriteLine(vowelCounter);
        }

        static void Findvowels(string strin)
        {
            char[] letersStrin = new char[strin.Length];
            for (int i = 0; i < strin.Length; i++)
            {
                letersStrin[i] = strin[i];
                if (letersStrin[i]=='a'|| letersStrin[i] == 'e'|| letersStrin[i] == 'i'|| letersStrin[i] == 'o'|| letersStrin[i] == 'u')
                {
                    vowelCounter++;
                }
            }
        }
    }
}
