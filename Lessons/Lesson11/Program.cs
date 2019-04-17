using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            s.Print();

            List<int> ints = new List<int> { 12, 213, 21, 312, 3 };
            var str = ints.ListToString();
            Console.WriteLine(str);

            Util.ListToString2(ints);


            var even = ints.Where(x => x % 2 == 0).OrderByDescending(x => x).ToList();
            Console.WriteLine(even.ListToString());






            List<Product> products = new List<Product>();
            var names = new string[] { "Яблоко", "Груша", "Апельсин", "Морковь" };
            Random rand = new Random(1);
            for (int i = 0; i < 100; i++)
            {
                products.Add(new Product
                {
                    Count = rand.Next(1, 50),
                    Description = "Подробнее о продукте",
                    Name = names[rand.Next(names.Length)],
                    Price = rand.Next(1, 5000)
                });
            }

            foreach (var item in products.OrderBy(x => x.Name).ThenBy(x => x.Count))
            {
                Console.WriteLine(item);
            }

            var p1 = products.Where(x => x.Price > 100 && x.Price < 1000);
            Console.WriteLine("-------------------");
            foreach (var item in p1)
            {
                Console.WriteLine(item);
            }

            var p2 = products
                .Where(x => x.Price > 100 && x.Price < 1000)
                .Select(x => new ProductView { Price = x.Price, Name = $"{x.Name}({x.Count})" });
            Console.WriteLine("-------------------");
            foreach (var item in p2)
            {
                Console.WriteLine(item);
            }

            Product p = products.LastOrDefault(x => x.Count == 5);
            Console.WriteLine("p " + p);



            double avg = products.Where(x => x.Price > 100 && x.Price < 1000).Average(x => x.Price);
            double sum = products.Where(x => x.Price > 100 && x.Price < 1000).Sum(x => x.Count);

            double sumTotal = products.Where(x => x.Price > 100 && x.Price < 1000).Sum(x => x.Count * x.Price);
            Console.WriteLine("avg " + avg);
            Console.WriteLine("sum " + sum);
            Console.WriteLine("sum " + sumTotal);


            var page1 = products.Take(10);
            var page2 = products.Skip(10).Take(10);
            var page3 = products.Skip(20).Take(10);
            int countP = 20;
            int numPage = 0;

            var pageN = products.Skip(countP * numPage).Take(countP);


            var groupProd = products
                .GroupBy(x => x.Name)
                .Select(x => new ProductView
                {
                    Name = x.Key,
                    Price = x.Sum(y => y.Price * y.Count)
                })
                .OrderByDescending(x => x.Price);
            Console.WriteLine("-------------------");
            foreach (var item in groupProd)
            {
                Console.WriteLine(item);
            }

            var prod5 = from pr in products
                        where pr.Price > 100 && pr.Price < 1000
                        orderby pr.Name, pr.Price
                        select new ProductView
                        {
                            Name = pr.Name,
                            Price = pr.Price
                        };

            Console.WriteLine("-------------------");
            foreach (var item in prod5)
            {
                Console.WriteLine(item);
            }

            XDocument document = XDocument.Load("prod.xml");
            var prod6 = from pr in document
                            .Element("products")
                            .Elements("product")
                        orderby pr.Element("name").Value descending
                        select new Product
                        {
                            Name = pr.Element("name").Value,
                            Description = pr.Element("description").Value,
                            Price = double.Parse(pr.Element("price").Value),
                            Count = int.Parse(pr.Element("count").Value),
                        };
            Console.WriteLine("------------");
            foreach (var item in prod6)
            {
                Console.WriteLine(item);
            }
            //document
            //    .Element("products")
            //    .Elements("product").Where(x=>true)
            //    .OrderBy().Select()
            products
                .Where(x=>x.Count>10)
                .ToList()
                .ForEach(x => Console.WriteLine(x));




        }
    }
}
