using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ").ToArray();
                Article myArticle = new Article(tokens[0], tokens[1], tokens[2]);
                list.Add(myArticle);
            }
           List<Article> sortedArticles= list.OrderBy(a=>a.Author).ToList();
            Console.WriteLine(string.Join(":", sortedArticles));

        }
    }
    
}
