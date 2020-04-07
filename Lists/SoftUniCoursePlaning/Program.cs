using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlaning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> program = Console.ReadLine().Split(", ").ToList();
           
            string comand;
            while ((comand=Console.ReadLine())!="course start")
            {
                string[] cmdArgs = comand.Split(':');
                string cmdArg = cmdArgs[0];
                string lesonTitle = cmdArgs[1];
                if (cmdArg=="Add")
                {
                    Add(program, lesonTitle);
                }
                else if (cmdArgs[0] == "Insert")
                {
                    Insert(program, cmdArgs, lesonTitle);
                }
                else if (cmdArgs[0] == "Remove")
                {
                    Remove(program, lesonTitle);
                }
                else if (cmdArgs[0] == "Swap")
                {
                    Swap(program, cmdArgs, lesonTitle);
                }
                else if (cmdArgs[0] == "Exercise")
                {
                    Exercise(program, lesonTitle);
                }

            }
            int count = program.Count;
            foreach (var item in program)
            {
                Console.WriteLine($"{program.Count-(count-1)}.{item.Trim()}");
                count--;
            }
            
        }

        private static void Exercise(List<string> program, string lesonTitle)
        {
            if (program.Contains(lesonTitle))
            {
                int indexLeson = program.IndexOf(lesonTitle);
                program.Insert((indexLeson + 1), (lesonTitle + "-Exercise"));
            }
            else
            {
                program.Add(lesonTitle);
                program.Add(lesonTitle + "-Exercise");
            }
        }

        private static void Swap(List<string> program, string[] cmdArgs, string lesonTitle)
        {
            string lesonTitle2 = cmdArgs[2];
            if (program.Contains(lesonTitle) && program.Contains(lesonTitle2))
            {
                int firstTitleIndex = program.IndexOf(lesonTitle);
                int secondTitleIndex = program.IndexOf(lesonTitle2);
                program[firstTitleIndex] = lesonTitle2;
                program[secondTitleIndex] = lesonTitle;
                if (program.Contains(lesonTitle2 + "-Exercise") && program.Contains(lesonTitle + "-Exercise"))
                {
                    program[secondTitleIndex+1] = lesonTitle + "-Exercise";
                    program[firstTitleIndex + 1] = lesonTitle2 + "-Exercise";
                }
                else if (program.Contains(lesonTitle2 + "-Exercise"))
                {
                    
                    program.Insert(firstTitleIndex+1 , lesonTitle2 + "-Exercise");
                    program.RemoveAt(secondTitleIndex + 1);
                }
                else if (program.Contains(lesonTitle + "-Exercise"))
                {
                    
                    program.Insert(secondTitleIndex + 1, lesonTitle + "-Exercise");
                    program.RemoveAt(firstTitleIndex + 2);
                }

            }
        }

        private static void Remove(List<string> program, string lesonTitle)
        {
            if (program.Contains(lesonTitle))
            {
                program.Remove(lesonTitle);
                program.Remove(lesonTitle + "-Exercise");
            }
        }

        private static void Insert(List<string> program, string[] cmdArgs, string lesonTitle)
        {
            int index = int.Parse(cmdArgs[2]);
            if (program.Contains(lesonTitle.Trim()))
            {
                return;
            }
            else program.Insert(index, lesonTitle);
        }

        private static void Add(List<string> program, string lesonTitle)
        {
            
                if (program.Contains(lesonTitle))
                {
                return;
                }
                else
                {
                    program.Add(lesonTitle);
                }
            
        }
    }
}
