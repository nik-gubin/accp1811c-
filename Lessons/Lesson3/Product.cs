namespace Lesson3
{
    //базовый класс
    class Product : object
    {
        string name;
        string description;
        protected int count;
        protected double price;
   
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
            this.count = count;
            this.price = price;
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
            return count * price;
        }

        //переопределение метода базового класса
        //для Product базовым классам является object
        public override string ToString()
        {
            return $"Название: {name} \n\tКоличесво: {count} \n\tЦена: {price}";
        }
    }
}
