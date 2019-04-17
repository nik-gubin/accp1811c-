using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public static class Util
    {
        public static void Print(this string s)
        {
            Console.WriteLine(s);
        }

        public static string ListToString(this List<int> l)
        {
            string s = "";
            foreach (var item in l)
            {
                s += item.ToString()+" ";
            }
            return s;
        }

        public static string ListToString2(List<int> l)
        {
            string s = "";
            foreach (var item in l)
            {
                s += item.ToString() + " ";
            }
            return s;
        }
    }
}
