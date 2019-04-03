using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    //создание класса собственного исключения
    class DivideSqureException : ArithmeticException
    {
        int a;

        public DivideSqureException(int a):base($"Деление на квадратное число: {a}")
        {
            this.a = a;
        }
    }
}
