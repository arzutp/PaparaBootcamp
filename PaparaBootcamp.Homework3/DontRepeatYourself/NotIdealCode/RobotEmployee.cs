using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.DontRepeatYourself.NotIdealCode
{
    //görüldüğü gibi robot çalışan ve insan çalışan ikisi de aynı methodları çalıştırıyor. 
    //başka bir sınıf geldiğinde yine aynı kodları yazmamak için ortak methodları base bir sınıfa almak daha doğru olur
    public class RobotEmployee
    {
        public void Work()
        {
            Console.WriteLine("çalışıyor");
        }
    }
}
