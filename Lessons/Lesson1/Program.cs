using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;//изменение цвета фона
            Console.ForegroundColor = ConsoleColor.DarkMagenta;//цвет текста

            Console.WriteLine("Hello World!!!");//Вывод на экран строки

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            //основные примитивные типы
            int a;
            long l = 1231;
            short s;
            double d;
            float f;
            char c;
            bool b;
            byte b1;
            ushort u;

            a = 0;
            int c1 = a + 56;

            //вывод на экран значений переменных
            Console.WriteLine(c1);
            Console.WriteLine("c1 = " + c1);
            Console.Write("\tHello\n");
            Console.Write("Hello");
            Console.WriteLine("+{2}+{2}+{0}+{1}", c1 + 1, a, l);

            string str = "";
            str = Console.ReadLine();//чтение строки с клафиатуры
            Console.WriteLine(str);


            string countStr = Console.ReadLine();
            //преобразование строки в число
            //с генерецией исключения
            int count = int.Parse(countStr);
            Console.WriteLine("count = " + count);
            Console.WriteLine($"count = {count}");

            int num;
            //преобразование строки в число
            //без генерации исключений
            bool res = int.TryParse(Console.ReadLine(), out num);
            if (res)
            {
                Console.WriteLine($"num = {num}");
            }
            else
            {
                Console.WriteLine("Error");
            }

            //пример с пользовальтеским вводом
            int apple = 0;
            bool res1 = false;
            while (!res1)
            {
                Console.Write("Введите кол-во яблок: ");
                res1 = int.TryParse(Console.ReadLine(), out apple);
                if (!res1 || apple < 1)
                {
                    res1 = false;
                    Console.Write("Ошибка ");
                }
            }

            //свитч
            switch (apple)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            //цикл со счетчиком
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
            }
            do
            {

            } while (false);

            //создание одномерного массива
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            PrintArray(arr);

            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                //заполнение случайным образом от 0 до 100
                arr[i] = rand.Next(100);
            }
            PrintArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                //заполнение случайным образом от -5 до 5
                arr[i] = rand.Next(-5, 5);
            }
            PrintArray(arr);

            //"рванный" массив
            int[][] arr2 = new int[3][];
            arr2[0] = new int[3];
            arr2[1] = new int[4];
            arr2[2] = new int[6];

            Console.WriteLine(arr2.Rank);
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j]);
                }
                Console.WriteLine();
            }

            //массив размер массива NxM
            int[,] arr22 = new int[4, 5];
            Console.WriteLine("Rank for arr22 =" + arr22.Rank);
            arr22[0, 1] = 32;
            Console.WriteLine(arr22.Length);
            Console.WriteLine(arr22.GetLength(0));
            Console.WriteLine(arr22.GetLength(1));


            int[] arr3 = { 21, 21, 3, 13, 2, 2 };
            int[] arr4 = new int[10];


        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
