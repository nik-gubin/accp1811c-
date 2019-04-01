using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    //наследавание от астрактного класса и интерфейса
    class Dog : Animal,ISecurity
    {
        public Dog(string name) : base(name)
        {
        }

        public override string Say()
        {
            return "Гав-Гав";
        }

        public void Security()
        {
            Console.WriteLine("Охрана");
        }

        public void Start()
        {            
        }

        public void Stop()
        {            
        }
    }
}
