using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.NotIdealCode
{
    public class EngineerNotIdealCode : EmployeeNotIdealCode
    {
        public override void Eat()
        {
            ///..
            ///
            Console.WriteLine("mühendis yemek yiyor");
        }

        public override void Rest()
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
