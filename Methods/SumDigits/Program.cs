using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SumOfNums(a,b,c));
        }
        static int SumOfNums(int a,int b,int c)
        {
            int result = (a + b) - c;
            return result;
        }
    }
}
