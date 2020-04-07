using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(e=>int.Parse(e)).ToArray();
            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                
               int cur = arr[i];
                bool isTopIteger = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (cur <= arr[j])
                    {
                        isTopIteger = false;
                        break;
                    }
                }
                if (isTopIteger) result += cur + " ";
            }
            Console.WriteLine(result);
        }
    }
}
