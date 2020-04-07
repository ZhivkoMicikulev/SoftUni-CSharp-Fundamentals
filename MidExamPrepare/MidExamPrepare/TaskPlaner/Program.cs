using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskPlaner
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] tasks = Console.ReadLine().Split().Select(short.Parse).ToArray();
            string cmd;
           
            while ((cmd=Console.ReadLine())!="End")
            {
                string[] argue = cmd.Split();
                string cmdArg = argue[0];
                if(cmdArg=="Complete")
                {
                    int index = int.Parse(argue[1]);
                    if (index > tasks.Length - 1) break;
                    else
                    {
                        tasks[index] = 0;
                       
                    }
                }
                else if(cmdArg=="Change")
                {
                    int index = int.Parse(argue[1]);
                    short time = short.Parse(argue[2]);
                    if (index > tasks.Length - 1) break;
                    else tasks[index] = time;
                }
                else if (cmdArg=="Drop")
                {
                    int index = int.Parse(argue[1]);
                    if (index > tasks.Length - 1) break;
                    else
                    {
                        
                        tasks[index] = -1;
                    }
                }
                else if (cmdArg== "Count")
                {
                    string otherArg = argue[1];
                    if(otherArg=="Completed")
                    {
                        int complete = 0;
                        for (int i = 0; i < tasks.Length; i++)
                        {
                            if (tasks[i] == 0) complete++;
                        }
                        Console.WriteLine(complete);
                    }
                    else if (otherArg== "Incomplete")
                    {
                        int incomplete = 0;
                        for (int i = 0; i < tasks.Length; i++)
                        {
                            if (tasks[i] != 0 && tasks[i] != -1) incomplete++;
                        }
                        Console.WriteLine(incomplete);
                    }
                    else if (otherArg == "Dropped")
                    {
                        int droped = 0;
                        for (int i = 0; i < tasks.Length; i++)
                        {
                            if (tasks[i] == -1) droped++;
                        }
                        Console.WriteLine(droped);
                    }

                }
                
               

            }
            List<short> inTask = new List<short>();
            for (int i = 0; i < tasks.Length; i++)
            { 
                if ( tasks[i] != 0 && tasks[i] != -1)
                {
                    inTask.Add(tasks[i]);
                }
            }
            Console.WriteLine(string.Join(' ',inTask));
        }
    }
}
