using System;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{result(a,b):f2}");
        }
        static double result(double a,double b)
        {
            double resultA = 1;
            double resultB = 1;
            for (int i = 1; i <=a; i++)
            {
                resultA *= i;
            }
            for (int i = 1; i <= b; i++)
            {
                resultB *= i;
            }
            double fullResult = resultA / resultB;
            return fullResult;
        }
    }
}
