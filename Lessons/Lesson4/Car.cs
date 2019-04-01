using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    //наследование от трех интерфейсов
    class Car : IAction, ISecurity, ITest
    {
        public void Move()
        {
            Console.WriteLine("car drive");
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public void Test()
        {

        }
    }
}
