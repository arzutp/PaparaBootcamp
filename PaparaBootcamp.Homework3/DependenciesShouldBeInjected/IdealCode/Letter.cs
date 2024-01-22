using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.DependenciesShouldBeInjected.IdealCode
{
    public class Letter : IMessageSender
    {
        public void Send()
        {
            Console.WriteLine("Mektup gönderildi");
        }
    }
}
