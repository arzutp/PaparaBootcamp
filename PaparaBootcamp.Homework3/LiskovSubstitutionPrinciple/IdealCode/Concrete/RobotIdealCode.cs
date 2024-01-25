using PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.IdealCode.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.IdealCode.Concrete
{
    public class RobotIdealCode : BaseEmployeeIdealCode
    {
        public override void Work()
        {
            ///..
            ///
            Console.WriteLine("robot çalışıyor");
        }
    }
}
