using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Warehouse
    {
        List<Product> products;

        public double CalcTotalPrice()
        {
            double s = 0;
            for (int i = 0; i < products.Count; i++)
            {
                s += products[i].TotalPrice();
            }
            return s;
        }
    }
}
