using System;

namespace CharacterInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            PrintChars(first, last);
        }
         
        static void PrintChars(char first,char last )
        {
           if(first<last)
            for (int i = first+1; i < last; i++)
            {
                Console.Write((char)i+" ");
            }
            else
            {
                for (int i = last + 1; i < first; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
        

    }
}
