using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string cmd;
            
            while((cmd=Console.ReadLine())!="End")
            {
                string[] cmdArgs = cmd.Split().ToArray();
                string comand = cmdArgs[0];
                if(comand=="Switch")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index >= 0 && index <= numbers.Length-1) numbers[index] = numbers[index] * -1;
                }
                else if(comand=="Change")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int value = int.Parse(cmdArgs[2]);
                    if (index >= 0 && index <= numbers.Length-1) numbers[index] = value;
                }
                else if(comand=="Sum")
                {
                    int sum = 0;
                    string comandArgs = cmdArgs[1];
                    if(comandArgs=="Positive")
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] > 0) sum += numbers[i];
                        }
                    }
                   else if (comandArgs == "Negative")
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] < 0) sum += numbers[i];
                        }
                    }
                    else if (comandArgs == "All")
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                        }
                    }
                    Console.WriteLine(sum);
                    sum = 0;
                }
              
            }
            List<int> empty = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0) empty.Add(numbers[i]);  
            }
            Console.WriteLine(string.Join(' ', empty));

        }
    }
}
