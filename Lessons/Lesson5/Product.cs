using System;

namespace Lesson5
{
    class Product
    {
        //поля класса
        private string name;

        //свойства для класса
        //замена методов геттеров и сеттеров
        public string Description { get; private set; }//скрыт метод установки значения
        public int Count { get; set; }
        public double Price { get; set; }

        //свойство массив ингредиентов
        public ItemProduct[] Items { get; set; } =
        {
            new ItemProduct{Name = "Item 1"},
            new ItemProduct{Name = "Item 2"},
            new ItemProduct{Name = "Item 3"},
            new ItemProduct{Name = "Item 4"},
        };
        
        public int CountItems { get { return Items.Length; } }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    throw new InvalidOperationException();
                }
                name = value;
            }
        }
        //индексатор
        public ItemProduct this[int inx]
        {
            get
            {
                return Items[inx];
            }
            set
            {
                Items[inx] = value;
            }
        }

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
            this.Description = desc;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            if (name == "")
            {
                throw new InvalidOperationException();
            }
            this.name = name;
        }

        public double TotalPrice()
        {
            return Count * Price;
        }

        public override string ToString()
        {
            return $"Название: {Name} \n\tКоличесво: {Count} \n\tЦена: {Price}";
        }
    }
}
