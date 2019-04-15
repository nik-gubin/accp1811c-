using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Product[]
            {
                new Product{Count=61,Description="Подробнее о яблоке",  Name="Яблоко",  Price=15.0},
                new Product{Count=21,Description="Подробнее о груше",   Name="Груша",   Price=10.0},
                new Product{Count=43,Description="Подробнее о апельсине",Name="Апельсин",Price=1.5},
                new Product{Count=16,Description="Подробнее о моркови", Name="Морковь", Price=7.3},
            };
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            //CreateProductsXML(products);

            //  ParseProductToConsole();

            //Console.WriteLine("------------------");
            //var listP = ParseProductToList();
            //foreach (var item in listP)
            //{
            //    Console.WriteLine(item);
            //}

            //UpdateProduct();

            XmlDocument document = new XmlDocument();
            document.Load("prod.xml");
            XmlElement root = document.DocumentElement;
            var names = root.SelectNodes("product/name");//поиск узлов name в product
            foreach (XmlNode item in names)
            {
                Console.WriteLine(item.InnerText);
            }
            Console.WriteLine("----------------");
            var prods = root.SelectNodes("product/*");//поиск все узлов в product
            foreach (XmlNode item in prods)
            {
                Console.WriteLine(item.InnerText);
            }

            Console.WriteLine("----------------");
            var prods2 = root.SelectNodes("product[3]");//поиск 3-его product
            foreach (XmlNode item in prods2)
            {
                Console.WriteLine(item.InnerText);
            }

            Console.WriteLine("----------------");

            var prodApple = root.SelectNodes("product[name='Яблоко']");//поиск  product у которого Яблоко
            foreach (XmlNode item in prodApple)
            {
                Console.WriteLine(item.InnerText);
            }
            root.RemoveChild(root.SelectSingleNode("product[name='Яблоко']"));//удаление яблока
            document.Save("p.xml");
        }

        /// <summary>
        /// Чтение Xml в Список продуктов
        /// </summary>
        /// <returns></returns>
        private static List<Product> ParseProductToList()
        {
            var list = new List<Product>();
            XmlDocument document = new XmlDocument();
            document.Load("prod.xml");

            XmlElement root = document.DocumentElement;
            foreach (XmlNode node in root)
            {
                var p = new Product();
                list.Add(p);
                foreach (XmlNode prod in node.ChildNodes)
                {
                    switch (prod.Name)
                    {
                        case "name":
                            p.Name = prod.InnerText; break;
                        case "description":
                            p.Description = prod.InnerText; break;
                        case "count":
                            p.Count = int.Parse(prod.InnerText); break;
                        case "price":
                            p.Price = double.Parse(prod.InnerText); break;
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Обновление количество яблок на 10%
        /// </summary>
        private static void UpdateProduct()
        {
            XmlDocument document = new XmlDocument();
            document.Load("prod.xml");
            XmlElement root = document.DocumentElement;

            foreach (XmlNode node in root)
            {
                bool find = false;
                XmlNode updateElemet = null;
                foreach (XmlNode prod in node.ChildNodes)
                {
                    if (prod.Name == "count")
                    {
                        updateElemet = prod;
                    }
                    if (prod.Name == "name" && prod.InnerText == "Яблоко")
                    {
                        find = true;
                    }
                }
                if (updateElemet != null && find)
                {
                    updateElemet.InnerText = ((int)(int.Parse(updateElemet.InnerText) * 1.1)).ToString();
                    break;
                }
            }
            document.Save("prod.xml");

        }

        /// <summary>
        /// Вывод на экран содержимого документа
        /// </summary>
        private static void ParseProductToConsole()
        {
            XmlDocument document = new XmlDocument();
            document.Load("prod.xml");

            XmlElement root = document.DocumentElement;
            Console.WriteLine(root.Name);
            foreach (XmlNode node in root)
            {
                Console.WriteLine($"\t{node.Name}");
                foreach (XmlNode prod in node.ChildNodes)
                {
                    Console.WriteLine($"\t\t{prod.Name} {prod.InnerText}");
                }
            }
        }

        /// <summary>
        /// Создание документа
        /// </summary>
        /// <param name="products"></param>
        private static void CreateProductsXML(Product[] products)
        {
            XmlDocument document = new XmlDocument();
            XmlElement root = document.CreateElement("products");
            document.AppendChild(root);

            foreach (var item in products)
            {
                XmlElement prod = document.CreateElement("product");
                root.AppendChild(prod);

                XmlElement name = document.CreateElement("name");
                name.AppendChild(document.CreateTextNode(item.Name));
                prod.AppendChild(name);

                XmlElement desc = document.CreateElement("description");
                desc.AppendChild(document.CreateTextNode(item.Description));
                prod.AppendChild(desc);

                XmlElement count = document.CreateElement("count");
                count.AppendChild(document.CreateTextNode(item.Count.ToString()));
                prod.AppendChild(count);

                XmlElement price = document.CreateElement("price");
                price.AppendChild(document.CreateTextNode(item.Price.ToString()));
                prod.AppendChild(price);
            }

            document.Save("prod.xml");
        }
    }
}
