using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numKegs = int.Parse(Console.ReadLine());
            string nameKeg = string.Empty;
            double maxVolume = 0;
            for (int i = 1; i <=numKegs; i++)
            {
                string nameOfTheKeg = Console.ReadLine();
                double radiusOfTheKeg = float.Parse(Console.ReadLine());
                double heightOfTheKeg = int.Parse(Console.ReadLine());
                double volumeOfTheKeg = Math.PI * (radiusOfTheKeg * radiusOfTheKeg) * heightOfTheKeg;
                if (volumeOfTheKeg > maxVolume) 
                {
                    nameKeg = nameOfTheKeg;
                    maxVolume = volumeOfTheKeg;
                }
            }
            Console.WriteLine(nameKeg);
        }
    }
}
