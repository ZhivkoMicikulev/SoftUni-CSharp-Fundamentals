using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();
            string comand;
            while((comand=Console.ReadLine())!="end")
            {
                string[] cmdArgs = comand.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string course = cmdArgs[0];
                string nameStu = cmdArgs[1];
                if(!courseInfo.ContainsKey(course))
                {
                    courseInfo[course] = new List<string>();
                }
                courseInfo[course].Add(nameStu);
            }
            Dictionary<string, List<string>> sortedCourses = courseInfo.OrderByDescending(k=>k.Value.Count).ThenBy(key => key.Key.OrderBy(k=>k)).ToDictionary(k=>k.Key,r=>r.Value);
            foreach (var kvp in sortedCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                List<string> names = kvp.Value.OrderBy(a => a).ToList();
                foreach (var sup in names )
                {
                    Console.WriteLine($"--{sup}");
                }
                
            }
            

        }
    }
}
