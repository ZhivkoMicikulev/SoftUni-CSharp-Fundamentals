using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            List<Department> departments = new List<Department>();
           
            for (int i = 0; i < numb; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                decimal salary = decimal.Parse(tokens[1]);
                string department = tokens[2];
                if(!departments.Select(x=>x.DepartmentName).Contains(department))
                {
                    Department newDep = new Department(department);
                    departments.Add(newDep);
                }
                departments.Find(d => d.DepartmentName == department).AddNewEmployee(name, salary);
            }
            Department bestDep = departments.OrderByDescending(d => d.TotalSalary / d.Employees.Count()).First();
            Console.WriteLine($"Highest Average Salary: {bestDep.DepartmentName}");
            foreach (var item in bestDep.Employees.OrderByDescending(s=>s.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2}");
            }


        }
       
    }
    class Employee
    {
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
            
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
    class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public decimal TotalSalary { get; set; }
        public void AddNewEmployee(string emName,decimal emSalary)
        {
            this.TotalSalary += emSalary;
            this.Employees.Add(new Employee(emName,emSalary));

        }
        public Department(string departmentName)
        {
            this.DepartmentName = departmentName;
        }

    }
}
