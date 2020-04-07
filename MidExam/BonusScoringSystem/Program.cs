using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double studetsCount = int.Parse(Console.ReadLine());
            double lectureCount = int.Parse(Console.ReadLine());
            double aditionalBonus = int.Parse(Console.ReadLine());
            double totalBonus =0.0;
            int student = 0;
            for (int i = 0; i < studetsCount; i++)
            {
                int attendance = int.Parse(Console.ReadLine());

                double sum = attendance / lectureCount * (5 + aditionalBonus);
                if(sum>totalBonus)
                {
                    totalBonus = sum;
                    student = attendance;
                }
            }


           
           
            Console.WriteLine($"Max Bonus: {Math.Round(totalBonus)}.");
            Console.WriteLine($"The student has attended {student} lectures.");
        }
    }
}
