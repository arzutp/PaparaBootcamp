using PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.IdealCode.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.IdealCode.Concrete
{
    public class WorkerIdealCode : BaseEmployeeIdealCode, IEat, IRest
    {
        public void Eat()
        {
            ///.
            ///
            Console.WriteLine("işci yemek yiyor");
        }

        public void Rest()
        {
            ///.
            ///
            Console.WriteLine("işci dinleniyor");
        }

        public override void Work()
        {
            ///.
            ///
            Console.WriteLine("işci çalışıyor");
        }
    }
}
