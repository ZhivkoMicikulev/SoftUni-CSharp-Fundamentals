using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sumPower = 0;
            while(pokemons.Count>0)
            {
                int index = int.Parse(Console.ReadLine());
                int powerOfThePoke = 0;
                if (index > pokemons.Count - 1)
                {
                     powerOfThePoke = pokemons[pokemons.Count - 1];
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(pokemons[0]);
                }
                else
                {
                     powerOfThePoke = pokemons[index];
                    pokemons.RemoveAt(index);
                }
                sumPower += powerOfThePoke;
                for (int i = 0; i < pokemons.Count; i++)
                {
                    if(pokemons[i]>powerOfThePoke)
                    {
                        pokemons[i] -= powerOfThePoke;
                        
                    }
                    else if(pokemons[i]<=powerOfThePoke)
                    {
                        pokemons[i] += powerOfThePoke;
                    }
                }
            }
            Console.WriteLine(sumPower);
        }
    }
}
