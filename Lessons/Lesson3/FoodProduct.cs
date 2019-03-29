namespace Lesson3
{
    //sealed запечатанный класс(запрещение наследование от данного класса)
    //дочерний класс 
    sealed class FoodProduct 
        : Product//указание родительского класса
    {
        double calory;
        string price;

        public FoodProduct() 
            : base(null)//перед вызовом конструтора вызываем конструктор базавого класса
        { }

        public FoodProduct(string name, int count, double price, double calory) 
            : base(name, count, price, null)//перед вызовом конструтора вызываем конструктор базавого класса
        {
            base.count = count;
            this.calory = calory;
        }

        public double GetCalory()
        {
            //this
            // base.
            return calory;
        }

        public double UdelCalory()
        {
            //base обращение к методам базового класса
            return calory / base.price;
        }

        //переопределение метода базового класса
        public override string ToString()
        {
            //base обращение к методам базового класса
            string pr = base.ToString();
            pr += $"\n\tКалироии: {calory}";
            return pr;
        }

        //переопределение метода базового класса
        public override double TotalPrice()
        {
            //base обращение к методам базового класса
            return base.TotalPrice() * 0.1 * calory;
        }
    }
}
