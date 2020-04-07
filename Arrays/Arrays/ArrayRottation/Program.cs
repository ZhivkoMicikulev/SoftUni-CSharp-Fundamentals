using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main()
        {
            //  4.Array Rotation
            //Write a program that receives an array and number of rotations you have to perform(first element goes at the end) Print the resulting array.

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberRotations = int.Parse(Console.ReadLine());

            if (numberRotations < array.Length)
            {
                numberRotations = numberRotations;    // <------ here VS dont like it so much ! :( why and how to solve the problem?
            }
            else if (numberRotations == array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }
            else if (numberRotations > array.Length)
            {
                numberRotations = numberRotations - array.Length;
            }

            int[] b = new int[numberRotations];
            Array.Copy(array, 0, b, 0, numberRotations);

            int[] c = new int[array.Length - numberRotations];
            Array.Copy(array, numberRotations, c, 0, array.Length - numberRotations);

            Console.WriteLine($"{String.Concat(String.Join(" ", c))} {String.Concat(String.Join(" ", b))}");

            //String.Join(" ", c);
            //Array.Copy(a, 1, b, 0, 3);
            //a = source array
            //1 = start index in source array
            //b = destination array
            //0 = start index in destination array
            //3 = elements to copy
        }
    }
}