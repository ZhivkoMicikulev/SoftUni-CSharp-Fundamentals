using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            string comand = Console.ReadLine();
            while (comand != "end")
            {
                string[] comandArr = comand.Split();
                if (comand == "max odd")
                {
                    Console.WriteLine(MaxOdd(line));   
                }
                else if (comand == "max even")
                {
                    Console.WriteLine(MaxEven(line));
                }
                else if (comand == "min odd")
                {
                    Console.WriteLine(MinOdd(line));
                }
                else if (comand == "min even")
                {
                    Console.WriteLine(MinEven(line));
                }
                else if (comandArr[0] == "exchange")
                {
                    string arrIndex = comandArr[1];
                    int index = int.Parse(arrIndex);
                    if (index > line.Length) Console.WriteLine("Invalid index");
                   else
                    {
                        line = Exchange(line, index);      
                    }
                }
                else if(comandArr[0]=="first" && comandArr[2]=="odd")
                {
                    string arrIndex = comandArr[1];
                    int index = int.Parse(arrIndex);
                    if (index > line.Length) Console.WriteLine("Invalid count");
                    else Console.WriteLine($"[{string.Join(',',FirstOdd(line,index))}]");
                }
                else if (comandArr[0] == "first" && comandArr[2] == "even")
                {
                    string arrIndex = comandArr[1];
                    int index = int.Parse(arrIndex);
                    if (index > line.Length) Console.WriteLine("Invalid count");
                    else Console.WriteLine($"[{string.Join(',', FirstEven(line, index))}]");
                }
                else if (comandArr[0] == "last" && comandArr[2] == "odd")
                {
                    string arrIndex = comandArr[1];
                    int index = int.Parse(arrIndex);
                    if (index > line.Length) Console.WriteLine("Invalid count");
                    else Console.WriteLine($"[{string.Join(',', LastOdd(line, index))}]");
                }
                else if (comandArr[0] == "last" && comandArr[2] == "even")
                {
                    string arrIndex = comandArr[1];
                    int index = int.Parse(arrIndex);
                    if (index > line.Length) Console.WriteLine("Invalid count");
                    else Console.WriteLine($"[{string.Join(',', LastEven(line, index))}]");
                }
                comand = Console.ReadLine();
            }
            if(comand=="end")
            {
                Console.WriteLine($"[{string.Join(',',line)}]");
            }
        }
        static string MaxOdd(int[] line)
        {
           int MaxOddPosition = int.MinValue;
            for (int i = 0; i <line.Length ; i++)
            {
                if (line[i] % 2 != 0)
                {
                    if (line[i] > MaxOddPosition) MaxOddPosition = i + 1;
                }
            }
            if (MaxOddPosition == int.MinValue) return "No Matches";
            else return MaxOddPosition.ToString();
        }
        static string MaxEven(int[] line)
        {
            int MaxEvenPosition = int.MinValue;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] % 2 == 0)
                {
                    if (line[i] > MaxEvenPosition) MaxEvenPosition = i + 1;
                }
            }
            if (MaxEvenPosition == int.MinValue) return "No Matches";
            else return MaxEvenPosition.ToString();
        }
        static string MinOdd(int[] line)
        {
            int MinOddPosition = int.MaxValue;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] % 2 != 0)
                {
                    if (line[i] < MinOddPosition) MinOddPosition = i + 1;
                }
            }
            if (MinOddPosition == int.MinValue) return "No Matches";
            else return MinOddPosition.ToString();
        }
        static string MinEven(int[] line)
        {
            int MinOddPosition = int.MaxValue;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] % 2 == 0)
                {
                    if (line[i] < MinOddPosition) MinOddPosition = i + 1;
                }
            }
            if (MinOddPosition == int.MinValue) return "No Matches";
            else return MinOddPosition.ToString();
        }
        static int[] Exchange(int[] line, int index)
        {
            
            int[] temp = new int[index];
            int[] wholeTemp = new int[line.Length];
            for (int i = 0; i < index; i++)
            { 
                    temp[i] = line[i];
            }
            for (int i = 0; i < line.Length-index; i++)
            {
                wholeTemp[i] = line[line.Length - (index + 1 - i)];
            }
            for (int i = 0; i <index; i++)
            {
                wholeTemp[(i + line.Length) - index] = temp[i];
            }

            return wholeTemp;
        }
        static string[] FirstOdd(int[] line,int index)
        {
            string emptyString=string.Empty;
            
            for (int i = 0; i <line.Length; i++)
            {
                if (line[i] % 2 != 0)
                {
                    emptyString+=line[i]+" ";
                    index--;
                    if (index == 0) break;
                }
            }
            string[] newArr = emptyString.Split().ToArray();
            return newArr;
        }
        static string[] FirstEven(int[] line ,int index)
        {
            string emptyString = string.Empty;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] % 2 == 0)
                {
                    emptyString += line[i] + " ";
                    index--;
                    if (index == 0) break;
                }
            }
            string[] newArr = emptyString.Split().ToArray();
            return newArr;
        }
        static string[] LastEven(int[] line, int index)
        {
            string emptyString = string.Empty;

            for (int i = line.Length-1; i < line.Length; i--)
            {
                if (line[i] % 2 == 0)
                {
                    emptyString += line[i] + " ";
                    index--;
                    if (index == 0) break;
                }
            }
            string[] newArr = emptyString.Split().ToArray();
            return newArr;
        }
        static string[] LastOdd(int[] line, int index)
        {
            string emptyString = string.Empty;

            for (int i = line.Length - 1; i < line.Length; i--)
            {
                if (line[i] % 2 != 0)
                {
                    emptyString += line[i] + " ";
                    index--;
                    if (index == 0) break;
                }
            }
            string[] newArr = emptyString.Split().ToArray();
            return newArr;
        }
    }
}
