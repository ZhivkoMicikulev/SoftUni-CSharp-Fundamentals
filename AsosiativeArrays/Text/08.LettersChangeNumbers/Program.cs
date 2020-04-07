using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string curWord = words[i];
                char firstLeter = curWord[0];
                char lastletter = curWord[curWord.Length - 1];
                double num = ParseNumberFromInput(curWord);
                int firstLetterPosition = GetAlpabeticalPositionByLetter(firstLeter);
                int secondLetterPosition = GetAlpabeticalPositionByLetter(lastletter);
                double tempSum = 0;
                if(char.IsUpper(firstLeter))
                {
                    tempSum = num / firstLetterPosition;
                }
                else
                {
                    tempSum = num * firstLetterPosition;
                }
                if(char.IsUpper(lastletter))
                {
                    tempSum = tempSum - secondLetterPosition;
                }
                else
                {
                    tempSum = tempSum + secondLetterPosition;
                }
                sum += tempSum;
            }
            Console.WriteLine($"{sum:f2}");
        }
        private static int GetAlpabeticalPositionByLetter(char letter)
        {
            int position = -1;


            if (char.IsLetter(letter))
            {
                if (char.IsUpper(letter))
                {
                    position = letter - 64;
                }
                else
                {
                    position = letter - 96;
                }
            }
            return position;
           
        }

        private static double ParseNumberFromInput(string curWord)
        {
            char[] numAsCharArr = curWord.Skip(1).Take(curWord.Length - 2).ToArray();
            string numAsString = string.Join("", numAsCharArr);
            double num = double.Parse(numAsCharArr);
            return num;
        }
    }
}
