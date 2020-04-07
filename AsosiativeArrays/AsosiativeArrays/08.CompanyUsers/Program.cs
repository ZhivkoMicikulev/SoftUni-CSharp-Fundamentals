using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companys = new Dictionary<string, List<string>>();
            string cmd;
            while ((cmd=Console.ReadLine())!="End")
            {
                string[] cmdArgs = cmd.Split("->",' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string companyName = cmdArgs[0];
                string id = cmdArgs[1];
                if(!companys.ContainsKey(companyName))
                {
                    companys[companyName] = new List<string>();
                }
                if(!companys[companyName].Contains(id))
                {
                    companys[companyName].Add(id);
                }
            }
            foreach (var kvp in companys.OrderBy(k=>k.Key))
            {
                Console.WriteLine(kvp.Key);
                List<string> ids = kvp.Value;
                foreach (var id in ids)
                {
                    Console.WriteLine($"--{id}");
                }
            }
        }
    }
}
