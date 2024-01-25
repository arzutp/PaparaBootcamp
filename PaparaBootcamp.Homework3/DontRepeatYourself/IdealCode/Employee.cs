using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.DontRepeatYourself.IdealCode
{
    //bu şekilde kullanırsak kod tekrarına düşmemiş oluruz. istediğimiz yerde bu sınıfı ekleyip kullanabiliriz
    public abstract class BaseEmployee
    {
        public void Work()
        {
            Console.WriteLine("çalışıyor");
        }
    }
}
