using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splited = input.Split('>');
            string result = splited[0];
            int remainingPower = 0;
            for (int i = 1; i < splited.Length; i++)
            {
                result += '>';
                int power = int.Parse(splited[i][0].ToString())+remainingPower;
                if(power>splited[i].Length)
                {
                    remainingPower=power- splited[i].Length;
                }
                else
                {
                    result += splited[i].Substring(power);
                }
            }
            Console.WriteLine(result);

            
        }
    }
}
