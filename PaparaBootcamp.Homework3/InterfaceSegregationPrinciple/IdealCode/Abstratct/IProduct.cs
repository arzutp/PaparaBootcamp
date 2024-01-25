using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.IdealCode.Abstratct
{
    public interface IProduct : IBaseDatabaseWorks
    {
        void GetAllWithCategory(string category);
    }
}
