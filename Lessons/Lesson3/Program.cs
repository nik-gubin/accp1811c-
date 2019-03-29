using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Наследование");
            FoodProduct food = new FoodProduct();
            food.SetName("FastFood");
            Console.WriteLine(food);
            food.GetCalory();

            SportProduct sport = new SportProduct();
            sport.GetSport();

            Product product = new Product("Simple Product");
            Console.WriteLine(product);

            //  product.price = -10;
            Product p = new Product("apple", 23, 2235, "");

            FoodProduct food2 = new FoodProduct("hotdog", 32, 12, 7000);
            Console.WriteLine(food2);
            Console.WriteLine($"Total: {food2.TotalPrice()}");

            Console.WriteLine(p);
        }
    }
}
