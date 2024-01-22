using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.DependenciesShouldBeInjected.IdealCode
{
    //bu şekilde dışardan alırsak ve interface şeklinde kullanırsak daha farklı değerlerde alabiliriz. 
    //Geliştirme imkanımız daha da artar
    public class IdealMessageSender
    {
        public void Send(IMessageSender messageSender) {
            messageSender.Send();
        }
    }
}
