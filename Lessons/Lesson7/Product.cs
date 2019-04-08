using System;

namespace Lesson7
{
    class Product :IComparable<Product>//интерфейс для определения сортировки продуктов
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name)
        {
            this.Name = name;
        }

        public Product(string name, string desc)
        {
            this.Name = name;
        }
        
        public Product(string name, int count, double price, string desc)
        {
            this.Name = name;
            this.Count = count;
            this.Price = price;
            this.Description = desc;
        }
        
        public virtual double TotalPrice()
        {
            return Count * Price;
        }

        //переопределение метода базового класса
        //для Product базовым классам является object
        public override string ToString()
        {
            return $"Название: {Name} \n\tКоличесво: {Count} \n\tЦена: {Price}";
        }

        //метод описания правила сортировки продуктов
        //по убыванию цены
        public int CompareTo(Product other)
        {
            //if (this.Price>other.Price)
            //{
            //    return 1;

            //}
            //else
            //{
            //    if (this.Price<other.Price)
            //    {
            //        return -1;
            //    }
            //    else
            //    {
            //        return 0;
            //    }
            //}
            return -1* this.Price.CompareTo(other.Price);
        }
    }
}
