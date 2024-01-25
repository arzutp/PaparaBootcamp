using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.OpenClosedPrinciple.NotIdealCode
{
    public class MessageSenderNotIdeal
    {
        //bu şekilde kullandığımız da gmail sınıfına bağımlı hale gelmiş oluruz aynı zamanda
        //yeni bir sınıf eklendiğinde kod içerisinde değişikliğe gitmek zorunda kalırız.
        //olası bir senaryo kullanıcı artık sms ile mesaj göndermek istiyor
        public void MessageSend(string to, string message)
        {
            //Gmail gmail = new Gmail();
            //gmail.SendMail(to, message); //yeni senaryo da sistem değiştiğinde bu kısımları silmek durumunda kalırız

            SmsNotIdeal sms = new SmsNotIdeal();
            sms.SendSms(to, message);

            //bu senaryo da kod içinde de değişiklik yapmış olduk bu olumsuz bir durumdur.
        }
    }
}
