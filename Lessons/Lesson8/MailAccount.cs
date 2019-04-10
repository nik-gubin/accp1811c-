using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class MailAccount
    {
        public List<Message> Sends { get; set; } = new List<Message>();
        public List<Message> Receives { get; set; } = new List<Message>();

        //поля-события
        public event MailHadler Sended;
        public event MailHadler Received;


        public void Send(Message message)
        {
            Console.WriteLine("Отправка сообщения");
            Sends.Add(message);

            Sended?.Invoke(this, message);//генерирование события
        }

        public void Receive(Message message)
        {
            Console.WriteLine("Прием сообщений");
            Receives.Add(message);

            Received?.Invoke(this, message);//генерирование события
            //if (Received != null)
            //{
            //    Received(this, message);
            //}
        }

    }
}
