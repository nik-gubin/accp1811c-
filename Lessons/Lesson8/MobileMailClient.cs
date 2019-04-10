using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class MobileMailClient
    {
        public MailAccount Account { get; set; }

        public MobileMailClient(MailAccount account)
        {
            this.Account = account;
            this.Account.Received += Account_Received;//подписка на событие
            this.Account.Sended += Account_Sended;//подписка на событие
        }

        //метод обработка события
        private void Account_Sended(object sender, Message message)
        {
            Console.WriteLine("Mobile push notification send");
        }

        //метод обработка события
        private void Account_Received(object sender, Message message)
        {

            Console.WriteLine("Mobile push notification receive");
        }
    }
}
