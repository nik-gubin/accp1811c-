using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обобщенное программирование");
            Document d1 = new Document { Name = "Паспорт" };
            d1.Number = 1231234321l;
            Document d2 = new Document { Name = "Другой док" };
            d2.Number = "AB123121";

            long num1 = (long)d1.Number;
            string num2 = (string)d2.Number;

            Console.WriteLine(num1);
            Console.WriteLine(num2);

            //создание документа, у которого будет номер только с типом long
            var d3 = new DocumentGeneric<long> { Name = "Паспорт" };
            d3.Number = 1231312445L;

            //создание документа, у которого будет номер только с типом string
            var d4 = new DocumentGeneric<string> { Name = "Другой док" };
            d4.Number = "AB123121";

            long num3 = d3.Number;
            string num4 = d4.Number;

            //обращение к статическому generic-полю
            DocumentGeneric<int>.staticDoc = 3;
            //обращение к статическому generic-полю
            DocumentGeneric<long>.staticDoc = 12L;
            //обращение к статическому generic-полю
            DocumentGeneric<string>.staticDoc = "444";
            Console.WriteLine(DocumentGeneric<long>.staticDoc);


            var box = new BoxDocument<string, int>();
            var box2 = new BoxDocument<DocumentGeneric<long>, DocumentGeneric<string>>();
            box2.Doc1 = d3;
            box2.Doc2 = d4;

            int a = 9, b = 10;
            long c;
            Swap(ref a, ref b);
            Console.WriteLine($"{a} {b}");

            var cont = new Container<Product> {
                Product = new Product("Apple", 23, 66, "")
            };
            Console.WriteLine(cont.Product);
            cont.AddPrice();
            Console.WriteLine(cont.Product);

            var cont2 = new Container<FoodProcduct>();
            cont2.Product = new FoodProcduct();

            var f = new FoodContainer();
            var all = new AllContainer<Product>();
        }

        //generic-метод
        public static void Swap<T>(ref T x1, ref T x2)
        {
            T t = x1;
            x1 = x2;
            x2 = t;
        }

        //задание ограничения для generic-параметра в методе
        public static bool Sum<T>(T a,T b) where T:class
        {
            return a.Equals(b);
        }
    }
}
