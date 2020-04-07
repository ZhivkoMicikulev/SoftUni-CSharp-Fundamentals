using System;
using System.Collections.Generic;
using System.Linq;

namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<int> numbs = new List<int>();
            for (int i = 0; i < count; i++)
            {
                char[] name = Console.ReadLine().ToArray();
                int sum = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == 'a' || name[j] == 'i' || name[j] == 'o' ||  name[j] == 'u' || name[j] == 'e'
                        || name[j] == 'A' || name[j] == 'I' || name[j] == 'O'  || name[j] == 'U' || name[j] == 'E' )
                    {
                        sum += name[j] * name.Length;
                    }
                    else sum += name[j] / name.Length;
                }
                numbs.Add(sum);
                sum = 0;
            }
            numbs.Sort();
            foreach (var item in numbs)
            {
                Console.WriteLine(item);
            }
        }

    }
} 
    

