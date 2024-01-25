using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.NotIdealCode
{
    public class WorkerNotIdealCode : EmployeeNotIdealCode
    {
        public override void Eat()
        {
            ///.
            ///
            Console.WriteLine("işci yemek yiyor");
        }

        public override void Rest()
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
