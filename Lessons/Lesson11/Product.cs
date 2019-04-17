using System;

namespace Lesson11
{
    class Product
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
       
        public override string ToString()
        {
            return $"Название: {Name} \tКоличесво: \t{Count} \tЦена: \t{Price}";
        }       
    }
}
