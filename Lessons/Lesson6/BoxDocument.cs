using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    //класс с двумя generic-параметрами
    class BoxDocument<T,V>
        where T: class //ограничение generic-параметра (только ссылычные типы)
        //where V:struct //ограничение generic-параметра (только структуры)
    {
        public T Doc1 { get; set; }
        public V Doc2 { get; set; }

    }
}
