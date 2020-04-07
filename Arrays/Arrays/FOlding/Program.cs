using System;
using System.Linq;

namespace FOlding
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] colum = Console.ReadLine().Split();
            int leftSideAndRight = colum.Length/2;
            int resultLeftAndRirgh = leftSideAndRight / 2;

            string[] arrLeft = new string[resultLeftAndRirgh];
            string[] arrRight = new string[resultLeftAndRirgh];
            string[] arrMidle = new string[leftSideAndRight];
           
            for (int i = 0; i < resultLeftAndRirgh; i++)
            {
                arrLeft[i] = colum[colum.Length-(resultLeftAndRirgh+leftSideAndRight+i+1)];
            }
            for (int i =0; i < resultLeftAndRirgh; i++)
            {
                arrRight[i] = colum[colum.Length - (resultLeftAndRirgh - i )];
            }
            for (int i =0; i < leftSideAndRight; i++)
            {
                arrMidle[i] = colum[colum.Length - (resultLeftAndRirgh + leftSideAndRight-i)];
            }
            int numLeft = int.Parse(arrLeft[resultLeftAndRirgh]);
            int numRight = int.Parse(arrRight[resultLeftAndRirgh]);
            int numMidle = int.Parse(arrMidle[leftSideAndRight]);
        }
    }
}
