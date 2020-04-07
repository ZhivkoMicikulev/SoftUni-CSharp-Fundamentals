using System;
using System.Linq;

namespace LadyBug
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheFild = int.Parse(Console.ReadLine());
            int[] indexBugs= Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bugsOnTheFild = new int[sizeOfTheFild];
            for (int i = 0; i < indexBugs.Length; i++)
            {
                if (indexBugs[i] > sizeOfTheFild - 1) break;
                bugsOnTheFild[indexBugs[i]] = 1;
            }
            string comand = Console.ReadLine();
            while(comand !="end")
            {
                string[] formatingComand = comand.Split();
                int index = int.Parse(formatingComand[0]);
                string direction = formatingComand[1];
                int moves = int.Parse(formatingComand[2]);
                for (int i = 0; i < sizeOfTheFild; i++)
                {
                    if (i == index)
                    {
                        bugsOnTheFild[index] = 0;
                        if (direction == "right")
                        {
                            if (bugsOnTheFild[index + moves] > sizeOfTheFild)
                            {
                                bugsOnTheFild[index] = 0;
                                break;
                            }
                            bugsOnTheFild[index + moves] += 1;
                            int[] bugslenght =new int[index+moves];
                            while (bugsOnTheFild[index+moves]!=1)
                            {
                                if (bugsOnTheFild.Length < bugslenght.Length)
                                {
                                    bugsOnTheFild[index + moves] = 1;
                                    break;
                                }
                                moves += moves;
                                bugsOnTheFild[index + moves] += 1;
                            }
                            

                        }

                    }
                }
                comand = Console.ReadLine();
            }
        }
    }
}
