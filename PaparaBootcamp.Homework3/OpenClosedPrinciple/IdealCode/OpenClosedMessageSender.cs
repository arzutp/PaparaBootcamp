using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.OpenClosedPrinciple.IdealCode
{
    public class OpenClosedMessageSender
    {
        public void MessageSend(IMessage messageService,string to, string message)
        {
            messageService.Send(to,message);
        }
    }
}
