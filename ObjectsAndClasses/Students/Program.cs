using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                
                string firstName = tokens[0];
                string secondName = tokens[1];
                double grade = double.Parse(tokens[2]);
                Students newStudent = new Students();
                newStudent.FirstName = firstName;
                newStudent.SecondName = secondName;
                newStudent.Grade = grade;
                students.Add(newStudent);
            }
            List<Students> newStudents = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var item in newStudents)
            {
                Console.WriteLine(item);
            }
          
           
        }
        class Students
            {
          
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public double Grade { get; set; }
            public override string ToString()
            {
                return $"{FirstName} {SecondName}: {Grade:f2}";
            }

        }
    }
        
}
