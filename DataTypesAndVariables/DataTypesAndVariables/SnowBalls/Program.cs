using System;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections;
            using System.Collections.Generic;
            using System.Linq;
            using System.Numerics;
            using System.Text;
            using System.Threading.Tasks;


namespace _01.Problem
    {

        class Program
        {

            static void Main(string[] args)
            {
                int numberOfSnowballs = int.Parse(Console.ReadLine());

                List<Tuple<double, double, BigInteger, double>> listOfValues = new List<Tuple<double, double, BigInteger, double>>();

                for (int i = 0; i < numberOfSnowballs; i++)
                {
                    double snowballSnow = double.Parse(Console.ReadLine());
                    double snowballTime = double.Parse(Console.ReadLine());
                    int snowballQuality = int.Parse(Console.ReadLine());

                    BigInteger numberOfThrows = (BigInteger)(snowballSnow / snowballTime);

                    BigInteger snowballValue = BigInteger.Pow(numberOfThrows, snowballQuality);

                    var tuple4Parts = new Tuple<double, double, BigInteger, double>
                          (snowballSnow, snowballTime, snowballValue, snowballQuality);

                    listOfValues.Add(tuple4Parts);
                }

                var highestSnowBallValue = listOfValues.OrderByDescending(x => x.Item3).First();
                Console.WriteLine($"{highestSnowBallValue.Item1} : {highestSnowBallValue.Item2} = {highestSnowBallValue.Item3} ({highestSnowBallValue.Item4})");

            }

        }
    }
}
    }
}
