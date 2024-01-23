using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaBootcamp.Homework3
{
    public class TernaryIf
    {
        //if else bloklarını azaltmak ve tek satıra indirmek için aşağıdaki yöntemi kullanabiliriz
        public List<string> users = new() { "Aslı","Volkan","Burhan","Tahsin"};
        public void GetUsersBadCode()
        {
            if(users.Count > 0)
            {
                Console.WriteLine($"{users.Count-1} tane kullanıcı var");
            }
            else { 
                Console.WriteLine("Kullanıcı bulunamadı");
            }
           
        }

        public void GetUsersCleanCode()
        {
            string result = (users.Count > 0) ? $"{users.Count - 1} tane kullanıcı var" : "Kullanıcı bulunamadı";
            Console.WriteLine(result);

        }
    }
}
