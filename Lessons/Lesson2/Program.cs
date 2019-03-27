using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Классы");
            //создание объектов
            Product p1 = new Product();
            Product p2 = new Product("Apple");
            Product p4 = new Product("Apple","Сладкий");
            
            Product p3 = new Product("Cerry", 54, 565.4, null);
            
            //p1.name = "Apple gold";
            //p3.name = "Apple gold";
            p2.price = -1;//изменение значения поля класса
            Console.WriteLine(p3.ToString());//вывод на экран инфо по объекту
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Product2 product = new Product2("", 0, 0, "");
            p3.SetName(Console.ReadLine());//изменение значения поля через сеттор
            string nameTover = "Сматр что-то";
            p3.SetName(nameTover);
            string n = p3.GetName();
            double t = p3.TotalPrice();
            Console.WriteLine($"{n} - {t}");

            int x = 10;
            Console.WriteLine(x);
            MA(x);//передача пареметра по значению
            Console.WriteLine(x);

            x = 10;
            Console.WriteLine(x);
            MA(ref x);//передача пареметра по ссылке
            Console.WriteLine(x);

            Console.WriteLine(p2);
            MA(p2);//передача пареметра по значению
            Console.WriteLine(p2);

            int y;
          //  MA(y);
            MB(out y);//передача пареметра по ссылке с обязательной инициализацией

            bool b = int.TryParse("123", out y);

            CreateEmpty();
    

        }

        static int MA(int a)
        {
            a = 100;
            return 5555;
        }

        static void MA(ref int a)
        {
            a = 100;
        }
        
        static void MA( Product a)
        {
            // a = new Product("Cherry");
            a.SetName("Cherry");
        }

        static void MB(out int a)
        {
            a = 10;
        }

        static void CreateEmpty()
        {
            Product p = new Product("111111");
        }

    }
}
