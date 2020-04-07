using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();
            string cmd;
            while ((cmd=Console.ReadLine())!="End")
            {
                string[] cmdArgs = cmd.Split().ToArray();
                string name = cmdArgs[0];
                string id = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);
                People man = new People(name,id,age);
                people.Add(man);
            }
            List<People>newPeople= people.OrderBy(x => x.Age).ToList();
            foreach (var item in newPeople)
            {
                Console.WriteLine(item);
            }
        }
        class People
        {
            public People(string name,string id,int age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = age;
            }
            public string Name { get; set; }
            public string ID{ get; set; }

            public int Age { get; set; }
            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        }
    }
}
