using System;

namespace GiftBox
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeSide = double.Parse(Console.ReadLine());
            int sheetsPaper = int.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());
            double areaOfTheBox = sizeSide * sizeSide * 6;
            int resizePaper = sheetsPaper / 3;
            double areaPaper = ((sheetsPaper - resizePaper) * area)+(resizePaper*(area*0.25));
            double percent = (areaPaper / areaOfTheBox) * 100;
            Console.WriteLine($"You can cover {percent:f2}% of the box.");
        }
    }
}
