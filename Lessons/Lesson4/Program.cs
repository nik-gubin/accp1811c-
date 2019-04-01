using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {    
            //нельзя создавать экзепляр астрактного класса
            //Animal animal = new Animal("Животное");
            //animal.Say();
            Cat cat = new Cat("Кошечка");
            Dog dog = new Dog("Собачка");
            Parrot parrot = new Parrot("Кеша");
            // Console.WriteLine(animal);
            Console.WriteLine(cat);
            Console.WriteLine(dog);
            Console.WriteLine(parrot);
            //Console.WriteLine(fact(5));


            //полиморфизм
            Animal animal = cat;
            string s = animal.Say();

            Console.WriteLine(s);
            Animal[] zoo = new Animal[3];
            zoo[0] = cat;
            zoo[1] = dog;
            zoo[2] = parrot;
            for (int i = 0; i < zoo.Length; i++)
            {
                Method(zoo[i]);
            }

            Animal a2 = dog;
            object o1 = a2;
            object o2 = dog;
            s = o1.ToString();
            Console.WriteLine(s);

            //Cat cat2 = new Cat("ca");
            //Dog d = cat2;
            //d.Ohrana();
           // istanceof
           
            if (o2 is Dog)
            {
                Dog d2 = (Dog)o2;
                d2.Security();
            }
            else
            {
                Console.WriteLine("error cast"+ o2.GetType());
            }

            Dog d3 = o2 as Dog;
            if (d3!=null)
            {
                d3.Security();
            }
            else
            {
                Console.WriteLine("cast error");
            }
            MoveMain(cat);
            MoveMain(new Car());

        }

        //метод принимает ссылку на тип интерфейса
        static void MoveMain(IAction a)
        {
            Console.WriteLine("---------------");
            a.Move();
            Console.WriteLine("---------------");
        }

        //метод принимает ссылка на тип абстрактного класса
        static void Method(Animal a)
        {
            Console.WriteLine("Что - делает " + a);
        }

        //пример с рекурсией
        static int Fact(int n)
        {
            if (n == 0) return 1;
            return n * Fact(n - 1);
        }
    }
}
