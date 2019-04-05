using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Container<T> where T: Product //ограничение generic-параметра (только класс Product и его наследники)
    {
        public T Product { get; set; }

        public void AddPrice()
        {
            Product.Price *= 1.1; 
        }
    }
}
