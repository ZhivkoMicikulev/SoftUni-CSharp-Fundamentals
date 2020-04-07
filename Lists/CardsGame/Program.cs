using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            while(true)
            {
                int playerOne = firstPlayer[0];
                int playerTwo = secondPlayer[0];
                if(playerOne>playerTwo)
                {
                    secondPlayer.Remove(playerTwo);
                    firstPlayer.Remove(playerOne);
                    firstPlayer.Add(playerOne);
                    firstPlayer.Add(playerTwo);

                }
                else if(playerTwo>playerOne)
                {
                    secondPlayer.Remove(playerTwo);
                    firstPlayer.Remove(playerOne);
                    secondPlayer.Add(playerTwo);
                    secondPlayer.Add(playerOne);
                }
                else
                {
                    secondPlayer.Remove(playerTwo);
                    firstPlayer.Remove(playerOne);
                }
                if (firstPlayer.Count == 0 || secondPlayer.Count == 0) break;

            }
            if (firstPlayer.Count > 0) Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            else Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
        }
    }
}
