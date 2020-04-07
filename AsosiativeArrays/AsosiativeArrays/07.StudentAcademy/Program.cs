using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> diary = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!diary.ContainsKey(name))
                {
                    diary[name] = new List<double>();
                }
                diary[name].Add(grade);
            }
            foreach (var eachStudent in diary.OrderByDescending(x=>x.Value.Average()))
            {
                if(eachStudent.Value.Average()>=4.5)
                {
                    Console.WriteLine($"{eachStudent.Key} -> {eachStudent.Value.Average():f2}");
                }
            }
        }
    }
}
