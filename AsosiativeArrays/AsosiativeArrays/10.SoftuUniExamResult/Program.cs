using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftuUniExamResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> languages = new Dictionary<string, int>();
            Dictionary<string, int> users = new Dictionary<string, int>();
            string cmd;
            while ((cmd=Console.ReadLine())!="exam finished")
            {
                string[] cmdArgs = cmd.Split("-",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string student = cmdArgs[0];
                string language = cmdArgs[1];
                
                if(language!="banned")
                {
                    int points = int.Parse(cmdArgs[2]);
                    if (points >= 0 && points <= 100)
                    {
                        if (!languages.ContainsKey(language))
                        {
                            languages[language] = 0;

                        }
                        if (!users.ContainsKey(student))
                        {
                            users[student] = 0;
                        }
                        languages[language]++;
                        if (users[student] <= points)
                        {
                            users[student] = points;
                        }
                    }
                }
                else
                {
                    users.Remove(student);
                }
            }
            Console.WriteLine("Results:");
            foreach (var kvp in users.OrderByDescending(k=>k.Value).ThenBy(v=>v.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in languages.OrderByDescending(k=>k.Value).ThenBy(n=>n.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
