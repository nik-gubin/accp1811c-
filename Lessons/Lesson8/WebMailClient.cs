using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class WebMailClient
    {
        public MailAccount Account { get; set; }

        public WebMailClient(MailAccount mail)
        {
            this.Account = mail;


            Account.Received += Account_Received;//подписка на событие
            Account.Received += (s, m) => { Console.WriteLine($"Web-clien {m.Author} {m.Subject}"); };//подписка на событие лямбда выражением
        }

        //метод обработка события
        private void Account_Received(object sender, Message message)
        {
            Console.WriteLine("Веб-клиент отловил событие приема сообщения");
        }
    }
}
