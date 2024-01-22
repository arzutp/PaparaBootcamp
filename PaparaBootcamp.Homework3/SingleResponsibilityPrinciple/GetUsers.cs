using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.SingleResponsibilityPrinciple
{
    //sınıfları bu şekilde görevlere ayırmak daha doğru bir yaklaşımdır.
    public class GetUsers
    {
        public List<User> Users()
        {
            return new()
            {
                new() {Id = 1, Name ="Aslı", Email="asli@gmail.com", Password="1234"},
                new() {Id = 2, Name ="Burhan", Email="burhan@gmail.com", Password="burhan1234"},
                new() {Id = 3, Name ="Volkan", Email="volkan@gmail.com", Password="1907"}
            };
        }
    }
}
