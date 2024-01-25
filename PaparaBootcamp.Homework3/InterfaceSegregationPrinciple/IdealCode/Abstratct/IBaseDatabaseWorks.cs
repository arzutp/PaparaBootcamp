using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.IdealCode.Abstratct
{
    public interface IBaseDatabaseWorks
    {
        void Add();
        void Delete();
        void GetAll();
    }
}
