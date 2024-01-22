using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3
{
    //bu prensip method, değişken ve class isimlerinin anlamlı olması gerektiğini söyler.
    public class MeaningfulNaming
    {
        //bad code
        public void func(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        //good code
        //1. public olan method isimleri küçük harfle başlamaz
        //method isimleri anlamlı olmalıdır.
        public void Sum(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }
}
