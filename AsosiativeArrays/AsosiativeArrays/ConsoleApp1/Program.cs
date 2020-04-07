using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] materialsName = new string[] { "shards", "motes", "fragments" };
            Dictionary<string, int> materials = new Dictionary<string, int>();
            Dictionary<string, int> junks = new Dictionary<string, int>();
            materials["shards"] = 0;
            materials["motes"] = 0;
            materials["fragments"] = 0;
            string wepon = string.Empty;
            bool obtain = false;
            while(!obtain)
            {
                string[] inputArgs = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < inputArgs.Length; i+=2)
                {
                    int qty = int.Parse(inputArgs[i]);
                    string kindMaterials = inputArgs[i + 1].ToLower();
                    if (materialsName.Contains(kindMaterials))
                    {
                        materials[kindMaterials] += qty;
                        if(materials.Any(m=>m.Value>=250))
                        {
                            if(kindMaterials=="shards")
                            {
                                wepon = "Shadowmourne";
                            }
                            else if(kindMaterials=="fragments")
                            {
                                wepon = "Valanyr";
                            }
                            else
                            {
                                wepon = "Dragonwrath";
                            }
                            materials[kindMaterials] -= 250;
                        }
                    }
                    else
                    {
                        if(!junks.ContainsKey(kindMaterials))
                        {
                            junks[kindMaterials] = 0;
                        }
                        junks[kindMaterials] += qty;
                    }
                }

            }



        }
    }
}
