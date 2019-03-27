using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Product2
    {
        string name;
        string description;
        int count;
        public double price;
    
        public Product2() {
            Console.WriteLine("Сложная логика Выполнить");
        }

        public Product2(string name)
            :this()//перед выполнением вызвать другой конструктор
        {
            //this();
            this.name = name;
        }
        public Product2(string name,string desc)
            :this(name,0,0,desc)//перед выполнением вызвать другой конструктор
        {
            this.name = name;
        }

        public Product2(string name, int count, double price, string desc)
            :this()//перед выполнением вызвать другой конструктор
        {
            this.name = name;
            this.count = count;
            this.price = price;
            this.description = desc;
        }

        public override string ToString()
        {
            return $"Название: {name} \n\tКоличесво: {count} \n\tЦена: {price}";
        }

    }
}
