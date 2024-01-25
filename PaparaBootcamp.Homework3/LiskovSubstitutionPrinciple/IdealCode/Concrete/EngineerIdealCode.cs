
using PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.IdealCode.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.IdealCode.Concrete
{
    public class EngineerIdealCode : BaseEmployeeIdealCode, IEat, IRest
    {
        public void Eat()
        {
            ///..
            ///
            Console.WriteLine("mühendis yemek yiyor");
        }

        public void Rest()
        {
            ///..
            ///
            Console.WriteLine("mühendis mola veriyor");
        }

        public override void Work()
        {
            ///..
            ///
            Console.WriteLine("mühendis çalışıyor");
        }
    }
}
