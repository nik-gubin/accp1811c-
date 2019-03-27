using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Order
    {
        Person person;
        Product product;

        public override string ToString()
        {
            return $"{person} {product} {product.TotalPrice()}руб";
        }
    }
}
