using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];
            int numbersCount = list.Count;
            while (true)
            {
                int indexBomb = list.IndexOf(bombNumber);
                if (indexBomb == -1) break;
                int rightIndex = indexBomb + bombPower;
                for (int i = indexBomb; i <= rightIndex; i++)
                {
                    if (i <numbersCount) list.RemoveAt(indexBomb);
                    else break;

                }
                int leftIndex = indexBomb - bombPower;
                for (int i = indexBomb-1; i >= leftIndex; i--)
                {
                    if (i >= 0) list.RemoveAt(i);
                    else break;
                }
            }
            Console.WriteLine(list.Sum());  

        }
    }
}
