using System;

namespace BiscuitFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int biscuit30Days = int.Parse(Console.ReadLine());
            double lessbiscuit =(amount * 0.75);
            
            double sum = (amount * workers * 20) + (lessbiscuit * 10 * workers);
            Console.WriteLine($"You have produced {sum} biscuits for the past month.");
            if (sum > biscuit30Days)
            {
                Console.WriteLine($"You produce {((sum - biscuit30Days) / biscuit30Days) * 100:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {((biscuit30Days-sum)/biscuit30Days)*100:f2} percent less biscuits.");
            }
          
        }
    }
}
