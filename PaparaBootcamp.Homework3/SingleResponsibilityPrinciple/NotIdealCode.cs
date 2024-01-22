using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3.SingleResponsibilityPrinciple
{
    //bu sınıfta hem kullanıcı listeleme yapılmıştır hem de database bağlanmıştır.
    //bu işlemler birbirinde farklı işlemlerdir 
    //bu doğru bir yaklaşım değildir.
    public class NotIdealCode
    {
        public void DatabaseConnection()
        {
            Console.WriteLine("Database bağlandı");
        }
        public List<User> GetUsers()
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
