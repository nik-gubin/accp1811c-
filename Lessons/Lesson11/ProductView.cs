using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class ProductView
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name}\t \t \t{Price}";
        }
    }
}
