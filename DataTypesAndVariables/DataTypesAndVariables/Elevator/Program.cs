using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int course = people / capacity;
            int leftCourse = people % capacity;
            if (leftCourse < capacity) course += 1;


                if (capacity > people) Console.WriteLine("1");
            else Console.WriteLine(course);
           
        }
    }
}
