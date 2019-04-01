using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    //наследование от абстрактного класса и интерфейса
    class Cat : Animal,IAction
    {
        public Cat(string name) : base(name)
        {
        }

        public void Move()
        {
            Console.WriteLine("Кошка побежала");
        }

        public override string Say()
        {
            return"Мау-Мау";
        }

        public void Test()
        {
        }
    }
}
