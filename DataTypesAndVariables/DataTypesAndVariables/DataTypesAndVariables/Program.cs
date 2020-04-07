using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());
            var res = ((a + b) / c) * d;
            Console.WriteLine(res);
        }
    }
}
