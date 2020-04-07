using System;

namespace WaterOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int tank = 255;
            int fullLiters = 0;
            for (int i = 1; i <=times; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > tank) Console.WriteLine("Insufficient capacity!");
                else
                {
                    fullLiters += liters;
                    tank -= liters;
                }

            }
            Console.WriteLine(fullLiters);
        }
    }
}
