using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Коллекции");
            //необобщенный список (хранится любой тип)
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("223");
            arrayList.Add(new object());
            arrayList.Add("22object3");
            arrayList.Add("2objectobject3");
            arrayList.Add(new int[] { 12, 2, 2 });
            for (int i = 0; i < arrayList.Count; i++)
            {
                string s = arrayList[i] as string;
                if (s != null)
                {
                    Console.WriteLine($"{s} {s.Length}");
                }
            }

            //обобщенный список
            var intList = new List<int>();
            intList.Add(12);//добавить в конец
            intList.Add(12);
            intList.Add(123);
            intList.AddRange(new int[] { 1, 34, 5 });//добавить в конец массив чисел
            intList.Insert(0, -5);//вставка на позицию
            intList.Insert(2, 33);
            intList[0] = intList[0] * 2;//доспут по индексу
            intList[0] = intList[0] * 2;

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{ intList[i]} ");
            }
            Console.WriteLine();

            intList.Remove(12);//удаление первого 12
            intList.RemoveAll(x => x == 12);//удаление всех 12
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{ intList[i]} ");
            }
            Console.WriteLine();
            intList.RemoveRange(10, 2);//удалить с 10 до 12 элементы
            intList.Sort();//сортировка
            intList.Reverse();//изменить порядок на обратный

            Console.WriteLine("sort");
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{ intList[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write($"{ intList[i]} ");
            }
            Console.WriteLine();

            var products = new List<Product>();
            // products.Add(null);
            products.Add(new Product { Name = "Apple2", Count = 2, Price = 1.2 });
            products.Add(new Product { Name = "Apple3", Count = 12, Price = 112 });
            products.Add(new Product { Name = "Apple1", Count = 22, Price = 122 });
            products.Add(new Product { Name = "Apple4", Count = 32, Price = 12.5 });
            products.Add(new Product { Name = "Apple-1", Count = 32, Price = 12.5 });
            products.Sort();
            foreach (var item in products)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                    Console.WriteLine(item.TotalPrice());
                }
                else
                {
                    Console.WriteLine("null");
                }
            }
            Console.WriteLine("-------------------------");
            products.Sort(new ProductComparer());
            foreach (var item in products)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                    Console.WriteLine(item.TotalPrice());
                }
                else
                {
                    Console.WriteLine("null");
                }
            }


            //двусвязный список
            var linked = new LinkedList<Product>();
            var intLinkedList = new LinkedList<int>();
            intLinkedList.AddLast(10);//добавить в конец
            intLinkedList.AddFirst(11);//добавить в начало
            foreach (var item in intLinkedList)
            {
                Console.WriteLine(item);
            }

            //очередь
            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);
            int f = intQueue.Dequeue();

            //стек
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            int l = intStack.Pop();

            //множество
            HashSet<int> set = new HashSet<int>();
            set.Add(21);
            set.Add(1);
            set.Add(21);
            set.Add(3);
            Console.WriteLine($"set count ${set.Count}");

            //упорядоченное множество
            SortedSet<int> ts = new SortedSet<int>(set);
            ts.Add(2231);
            ts.Add(-1);
            foreach (var item in ts)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            //словарь
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("java", "good");
            dic.Add("c#", "bad");

            dic["c#"] = "very good";
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }

            //упорядоченный по ключам словарь
            var pairs = new SortedDictionary<string, string>();



        }
    }
}
