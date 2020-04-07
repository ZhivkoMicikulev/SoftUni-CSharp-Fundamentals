using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsMade = int.Parse(Console.ReadLine());
            double lenghtStep = double.Parse(Console.ReadLine());
            double  distance = int.Parse(Console.ReadLine());
            int shortSteps = stepsMade / 5;
           double lenghtInMeters = lenghtStep / 100;
            double lenghtInMetrsShort = lenghtInMeters - (lenghtInMeters * 0.3);
           double distanceMade=((stepsMade-shortSteps)*lenghtInMeters+shortSteps*lenghtInMetrsShort);
            double percent = (distanceMade / distance) * 100;
            Console.WriteLine($"You travelled {percent:f2}% of the distance!");
        }
    }
}
