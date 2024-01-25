using PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.NotIdealCode.Abtract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.NotIdealCode.Concrete
{
    public class ProductManagerNotIdealCode : IBaseDatabaseWorksNotIdealCode
    {
        public void Add()
        {
            ///.
            ///
            Console.WriteLine("Ürün eklendi");
        }

        public void Delete()
        {
            ///.
            ///
            Console.WriteLine("ürün silindi");
        }

        public void GetAll()
        {
            ///.
            ///
            Console.WriteLine("ürünler listelendi");
        }

        public void GetAllWithCategory(string category)
        {
            ///.
            ///
            Console.WriteLine("ürünler kategoriye göre listelendi");
        }
    }
}
