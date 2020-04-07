using System;

namespace SmalestNum
{
    class Program
    {
       static int smallNum = int.MaxValue;
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                SmallestNumber(n);
            }
            Console.WriteLine(smallNum);

        }

        static void SmallestNumber(int n)
        {
            if (n<smallNum)
            {
                smallNum = n;
            }
        }

        
        
    }
}
