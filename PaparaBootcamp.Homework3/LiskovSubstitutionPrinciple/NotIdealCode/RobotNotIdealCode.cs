using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.NotIdealCode
{
    public class RobotNotIdealCode : EmployeeNotIdealCode
    {
        //bu şekilde bir kullanım yanlıştır.
        //eğer base bir sınıftan miras alıyorsak tüm method ve değerleri kullanmamız gerekir.
        //miras alıp boş bırakmak doğru olmaz
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Rest()
        {
            throw new NotImplementedException();
        }

        public override void Work()
        {
            ///...
            ///...
            Console.WriteLine("robot çalışıyor");
        }
    }
}
