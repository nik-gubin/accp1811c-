namespace Lesson6
{
    //базовый класс
    class Product : object
    {
        string name;
        string description;
        public int Count { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name)
        {
            this.name = name;
        }

        public Product(string name, string desc)
        {
            this.name = name;
        }
        
        public Product(string name, int count, double price, string desc)
        {
            this.name = name;
            this.Count = count;
            this.Price = price;
            this.description = desc;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        //виртуальный метод
        //необходим для отркрытия переопределения метода в классах наследниках
        public virtual double TotalPrice()
        {
            return Count * Price;
        }

        //переопределение метода базового класса
        //для Product базовым классам является object
        public override string ToString()
        {
            return $"Название: {name} \n\tКоличесво: {Count} \n\tЦена: {Price}";
        }
    }
}
