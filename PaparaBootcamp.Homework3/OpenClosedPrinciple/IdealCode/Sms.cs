using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.OpenClosedPrinciple.IdealCode
{
    public class Sms : IMessage
    {
        public void Send(string to, string message)
        {
            //....
            //...
            Console.WriteLine($"{to}, sms gönderildi");
        }
    }
}
