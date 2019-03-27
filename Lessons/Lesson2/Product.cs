using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Product
    {
        //поля класса
        string name;
        string description;
        int count;
        public double price;

        //конструктор поумолчанию
        public Product() { }

        //конструктор с параметрамами
        public Product(string name)
        {
            this.name = name;
        }

        //конструктор с параметрамами
        public Product(string name,string desc)
        {
            this.name = name;
        }

        //конструктор с параметрамами
        public Product(string name, int count, double price, string desc)
        {
            this.name = name;
            this.count = count;
            this.price = price;
            this.description = desc;
        }

        //методы класса Продукт
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public double TotalPrice()
        {
            return count * price;
        }

        public override string ToString()
        {
            return $"Название: {name} \n\tКоличесво: {count} \n\tЦена: {price}";
        }

        //дексруктор
        ~Product()
        {
            Console.WriteLine($"Удалился {name}");
        }

    }
}
