using PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.IdealCode.Abstratct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.IdealCode.Concrete
{
    public class AdminManager : IBaseDatabaseWorks
    {
        public void Add()
        {
            ///.
            ///
            Console.WriteLine("admin eklendi");
        }

        public void Delete()
        {
            ///.
            ///
            Console.WriteLine("admin silindi");
        }

        public void GetAll()
        {
            ///.
            ///
            Console.WriteLine("adminler listelendi");
        }
    }
}
