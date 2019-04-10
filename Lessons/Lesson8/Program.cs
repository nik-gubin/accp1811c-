using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    //создание делегатов
    delegate int Operation(int a, int b);
    delegate void Procudure();

    delegate void MailHadler(object sender, Message message);

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Дегаты и события");
           

            Operation sum = Sum;//объявление и инициализация переменной типа делегата
            Operation div = Div;
            Operation an = delegate (int x, int y) { return x * y; };
            Operation lamba = (x, y) => x / y;

            Procudure p = () => Console.WriteLine("This is procedure");

            //передеча в параметр метода переменной типа делегата
            Calculation(5, 4, sum);
            Calculation(-5, -4, div);
            Console.WriteLine(an(2, 3));

            MailAccount account = new MailAccount();

            WebMailClient webClient = new WebMailClient(account);
            MobileMailClient mobileClient = new MobileMailClient(account);

            account.Send(new Message { Author = "Ivan", Subject = "Test", Body = "Hi!!!" });
            account.Receive(new Message { Author = "Ivan", Subject = "Re:Test", Body = "Hello!!!" });

            int? age = null;
            if (age.HasValue)
            {
                Console.WriteLine(age.Value);
            }
            else
            {
                Console.WriteLine("Value is null");
            }
            Console.WriteLine(age ?? -9999);
            age = 55;
            Console.WriteLine(age ?? -9999);


            Nullable<int> age2 = null;

        }
        static void Calculation(int a, int b, Operation operation)
        {
            int c = operation(a, b);
            Console.WriteLine($"{a} oper {b} = {c}");
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Div(int a, int b)
        {
            return a - b;
        }
    }
}
