using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3
{
    //bu prensip methodların birden fazla iş yapmaması gerektiğini söyler
    public class FunctionsShouldBeSmall
    {
        //bad code
        //bu method iki işi de yapan bir methoddur bu yüzden kullanımı doğru olmaz.
        public void DatabaseConnectionAndSendMessage()
        {
            //
            //işlemler
            Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");

            //
            //
            //
            Console.WriteLine("Kullanıcıya mesaj gönderildi");
        }

        //clean code
        //bu şekilde işleri ayırıp methodları rahatlatmak çok daha iyi bir yaklaşımdır
        public void DatabaseConnection()
        {
            //
            //işlemler
            Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
        }
        public void SendMessage()
        {
            //
            //
            Console.WriteLine("Kullanıcıya mesaj gönderildi");
        }
    }
}
