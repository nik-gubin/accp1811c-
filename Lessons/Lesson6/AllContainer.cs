using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    //наследование от generic-класса
    //класс остается generic-классом
    class AllContainer<T> : Container<T> where T : Product
    {
        public AllContainer()
        {
        }
    }
}
