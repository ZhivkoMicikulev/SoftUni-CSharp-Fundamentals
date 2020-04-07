using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>();
            Dictionary<string, long> productQuantiti = new Dictionary<string, long>();
            string input;
            while((input=Console.ReadLine())!="buy")
                {
                string[] prodArgs = input.Split().ToArray();
                string name = prodArgs[0];
                decimal price = decimal.Parse(prodArgs[1]);
                int quantity = int.Parse(prodArgs[2]);
                if(!productQuantiti.ContainsKey(name))
                {
                    productQuantiti[name] = 0;
                    productPrice[name] = 0m;
                }
                productQuantiti[name] += quantity;
                productPrice[name] = price;

            }
            foreach (var kvp in productPrice)
            {
                string name = kvp.Key;
                decimal price = kvp.Value;
                long quantity = productQuantiti[name];
                decimal totalPrice = price * quantity;
                Console.WriteLine($"{name} -> {totalPrice:f2}");
            }
        }
    }
}
