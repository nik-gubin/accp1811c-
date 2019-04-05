using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    //наследование от generic-класса
    //класс становиться обычным
    class FoodContainer: Container<FoodProcduct>
    {
        public void Info()
        {
            Console.WriteLine(Product);
        }
    }
}
