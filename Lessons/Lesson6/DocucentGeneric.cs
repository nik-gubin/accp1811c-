using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class DocumentGeneric<T>//содание generic-класса
    {
        public static T staticDoc;//статическое generic-поле

        public string Name { get; set; }
        public T Number { get; set; }//generic-свойство

        public T id;//generic-поле

        public DocumentGeneric() {

            id = default(T);//задание значения по умолчанию
        }

       



    }
}
