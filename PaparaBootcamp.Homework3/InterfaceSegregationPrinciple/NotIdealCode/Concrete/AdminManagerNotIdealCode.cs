using PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.NotIdealCode.Abtract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.NotIdealCode.Concrete
{
    //admin sınıfında ürünlerin kategoriye göre listeleme işlemi yapılması anlamsız olur
    public class AdminManagerNotIdealCode : IBaseDatabaseWorksNotIdealCode
    {
        public void Add()
        {
            ///.
            ///
            Console.WriteLine("Admin eklendi");
        }

        public void Delete()
        {
            ///.
            ///
            Console.WriteLine("Admin silindi");
        }

        public void GetAll()
        {
            ///.
            ///
            Console.WriteLine("Adminler listelendi");
        }
        public void GetAllWithCategory(string category)
        {
            throw new NotImplementedException();
        }
    }
}
