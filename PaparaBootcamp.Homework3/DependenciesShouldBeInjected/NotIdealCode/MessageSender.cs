using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.DependenciesShouldBeInjected.NotIdealCode
{
    //bu prensibe göre sınıf içinde başka bir sınıfı new lememek gerekir.
    //parametre olarak almak daha doğru olur
    public class MessageSender
    {
        public void Send()
        {
            Gmail gmail = new();
            gmail.Send();
        }
    }
}
