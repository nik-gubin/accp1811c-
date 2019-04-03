using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Исключения");
            try { }//помещается небезопасный код
            catch { }//обработка исключения
            finally { }//обязательно выполняется

            while (true)
            {                
                try
                {
                    int b = random.Next(0, 2);
                    int a1 = 5 / b;
                    Console.WriteLine(a1);
                    break;
                }
                catch
                {
                    Console.WriteLine("Error");
                }
                finally
                {
                    Console.WriteLine("Finally");
                }
            }
            int a=-1;
            try
            {
                a = random.Next(0, 2); ;
                int b = 5 / a;
                Console.WriteLine(a);
                object o = null;
                string s = o.ToString();
            }
            //отлов конкретного типа исключения
            catch (DivideByZeroException) when (a < 0)
            {
                Console.WriteLine("Error -1");
            }
            catch (DivideByZeroException e) 
            {                
                Console.WriteLine(e.StackTrace);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error null");
            }
            catch(Exception)//все ошибки
            {
                Console.WriteLine("other exception");
            }

            //int a1;
            //bool bb = int.TryParse(Console.ReadLine(), out a1);
            //a1 = int.Parse(Console.ReadLine());

            //Console.WriteLine(  div(1, 4));
            // method(16);

            Product p = new Product();
            p.SetName("apple");
            Console.WriteLine(p.GetName());

            p.Name = "cerry";
            Console.WriteLine(p.Name);

          //  p.Name = "";

            Product p2 = new Product
            {
                Count = 10,
                Name="Apple 2",
                Price=123.21
            };

            var item =  p2.Items[2];
            Console.WriteLine(item.Name);

            item = p2[2];
            

            Console.ReadKey();
        }

        public static void method(int a)
        {
            try
            {
                div(a, a);
            }
            catch(DivideSqureException e)
            {
                Exception exception = new Exception("erron in method",e);
                throw exception;//создание внутренного исключения
            }
        }
        public static int div(int a,int b)
        {
            if (b==4||b==9||b==16)
            {
                throw new DivideSqureException(b);//генерация собственного исключения
            }
            return a / b;
        }
    }
}
