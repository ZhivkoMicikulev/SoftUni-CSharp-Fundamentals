using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int plunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                totalPlunder += plunder;
                if (i % 3 == 0)
                {
                    totalPlunder += (plunder * 0.5);
                }
                if (i % 5 == 0 )
                {
                    totalPlunder -= (totalPlunder * 0.3);
                }
               
                
            }
           if (totalPlunder>=expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {(decimal)totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {(decimal)((totalPlunder/expectedPlunder)*100):f2}% of the plunder.");
            }
            
        }
    }
}
