using System;
using System.Collections.Generic;

namespace EnumHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(1, "Zubenko Michail Petrovich", "Soborna 24", "+38050221414", 5, 2209.50);
            Client client1 = new Client(2, "Shevchenko Andrii Mikolayovich", "Marka Vovchka 9", "+38023255151", 10, 5541.1);
            List<RequestItem> requestItems = new List<RequestItem> { new RequestItem(1, new Article(41, "Calgon", 10, Article.Category.Chemistry)) };
            requestItems.Add(new RequestItem(1, new Article(3, "Milk", 2, Article.Category.Products)));
            requestItems.Add(new RequestItem(8, new Article(10, "Dog Food", 15, Article.Category.DogFood)));
            Request request = new Request(221, client, DateTime.Now, requestItems);
            List<RequestItem> requestItems1 = new List<RequestItem> { new RequestItem(9, new Article(90, "Eags", 500, Article.Category.Products)) };
            requestItems1.Add(new RequestItem(1, new Article(9, "Sausage", 8, Article.Category.Products)));
            requestItems1.Add(new RequestItem(5, new Article(10, "Chocolate", 2, Article.Category.IceCream)));
            Request request2 = new Request(221, client1, DateTime.Now, requestItems1);
            Console.WriteLine(request);
            Console.WriteLine();
            Console.WriteLine(request2);
            Console.WriteLine();
            Console.WriteLine("Press any key to clear console");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Articles: ");
            Console.WriteLine();
            List<Article> articles = new List<Article> { new Article(764, "Butter", 5, Article.Category.Products) };
            articles.Add(new Article(222, "IPhone 12 Pro Max", 1200, Article.Category.Products));
            articles.Add(new Article(321, "Samsung Galaxy Note 11", 1500, Article.Category.Products));
            articles.Add(new Article(334, "MacBook Pro", 1300, Article.Category.Products));
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nSorted By ICompareable: \n");
            articles.Sort();
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nSorted By Lyambda\n");
            articles.Sort((e, e1) => e.Price.CompareTo(e1.Price));
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sorted By Method: \n");
            articles.Sort(Article.SortByPrice);
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nSorted By IComparer");
            ComparerByPrice nc = new ComparerByPrice();
            articles.Sort(nc.CompareByPrice);
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }

        }
    }
}
