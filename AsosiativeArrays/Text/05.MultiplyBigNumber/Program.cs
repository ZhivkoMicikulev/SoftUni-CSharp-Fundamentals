using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstNum = Console.ReadLine().ToCharArray();
            int num = int.Parse(Console.ReadLine());
            int reminder = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = firstNum.Length-1; i >0; i--)
            {
                char currNum = firstNum[i];
                int currentNum = int.Parse(currNum.ToString());
                int sum = currentNum * num+reminder;
                sb.Append(sum % 10);
                reminder = sum / 10;
            }
            if(reminder!=0)
            {
                sb.Append(reminder);
            }
            char[] result = sb.ToString().Reverse().ToArray();
            Console.WriteLine(string.Join("",result));
        }

    }
}
