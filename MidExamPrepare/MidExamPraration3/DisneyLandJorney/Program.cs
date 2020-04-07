using System;

namespace DisneyLandJorney
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeycost = double.Parse(Console.ReadLine());
            int mounths = int.Parse(Console.ReadLine());
            double savedMoney = 0;
            for (int i = 1; i <= mounths; i++)
            {
                double moneyPerMounth = journeycost * 0.25;
                
                double moneyForShoes = (savedMoney * 0.16);
                double bonusFromBoss = (savedMoney * 0.25);
                if (i == 1)
                {

                }
                else if (i % 2 != 0) savedMoney -= moneyForShoes;
                else if (i % 4 == 0) savedMoney += bonusFromBoss;
                savedMoney += moneyPerMounth;
            }
            if (savedMoney >= journeycost) Console.WriteLine($"Bravo! You can go to Disneyland and you will have {(savedMoney-journeycost):f2}lv. for souvenirs.");
            else Console.WriteLine($"Sorry. You need {(journeycost-savedMoney):f2}lv. more.");

        }
    }
}
