using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    //наследование от абстрактного класса
    class Parrot : Animal
    {
        public Parrot(string name) : base(name)
        {
        }

        public override string Say()
        {
            return "Popka durak";
        }
    }
}
