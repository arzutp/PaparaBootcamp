using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.NotIdealCode.Abtract
{
    public interface IBaseDatabaseWorksNotIdealCode
    {
        void Add();
        void Delete();
        void GetAll();
        void GetAllWithCategory(string category);
    }
}
