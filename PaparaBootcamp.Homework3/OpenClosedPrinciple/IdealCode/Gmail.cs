using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.OpenClosedPrinciple.IdealCode
{
    public class Gmail : IMessage
    {
        public void Send(string to, string message)
        {
            //....
            //...
            Console.WriteLine($"{to}, mail gönderildi");
        }
    }
}
